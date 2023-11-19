using AmusementPark.View.Employees;
using AmusementPark.View.Tickets;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmusementPark.View
{
	public partial class TicketsForm : Form
	{
		string connectionString;
		public TicketsForm(string connectionString)
		{
			this.connectionString = connectionString;
			InitializeComponent();
			LoadTickets();

			Dictionary<string, string> keys = new Dictionary<string, string>
			{
				{ "Position", "должность" },
				{ "LastName", "ФИО сотрудника" }
			};

			comboBoxColumns.DataSource = new BindingSource(keys, null);
			comboBoxColumns.DisplayMember = "Value";
			comboBoxColumns.ValueMember = "Key";
			comboBoxColumns.SelectedItem = keys["LastName"];
			comboBoxColumns.DropDownStyle = ComboBoxStyle.DropDownList;
		}
		private void buttonClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		Point lastPoint;
		private void panelUp_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Left += e.X - lastPoint.X;
				this.Top += e.Y - lastPoint.Y;
			}
		}

		private void panelUp_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint = new Point(e.X, e.Y);
		}
		
		private void LoadTickets()
		{
			try
			{
				string query = @"SELECT Tickets.Id AS TicketId,
									   P.Position,
									   CONCAT(E.LastName, ' ', E.FirstName, ' ', E.MiddleName) AS Employee,
									   PurchaseDate,
									   COALESCE(SUM(A.TicketPrice), 0) AS TotalAttractionCost
								FROM Tickets
										 JOIN Employees E on E.Id = Tickets.EmployeeId
										 JOIN Positions P on P.Id = E.PositionID
										 LEFT JOIN TicketAttractions TA on TA.TicketId = Tickets.Id
										 LEFT JOIN Attractions A on A.Id = TA.AttractionID
								WHERE E.PositionID > 3
								GROUP BY Tickets.Id, P.Position, E.LastName, E.FirstName, E.MiddleName, PurchaseDate
								ORDER BY PurchaseDate";

				using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
				{

					connection.Open();

					using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection))
					{
						DataTable attractionsTable = new DataTable();
						adapter.Fill(attractionsTable);

						dataGridViewTickets.DataSource = attractionsTable;
					}
					NamesColumns();
					SumAllTickets();
				}
				if (dataGridViewTickets.Rows.Count > 0)
				{
					dataGridViewTickets_CellClick(dataGridViewTickets, new DataGridViewCellEventArgs(0, 0));
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error: {ex.Message}");
			}
		}

		private void NamesColumns()
		{
			dataGridViewTickets.Width = 500;
			dataGridViewTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewTickets.Columns["TicketId"].Visible = false;
			dataGridViewTickets.Columns["Position"].HeaderText = "Должность";
			dataGridViewTickets.Columns["Employee"].HeaderText = "Сотрудник";
			dataGridViewTickets.Columns["PurchaseDate"].HeaderText = "Дата продажи";
			dataGridViewTickets.Columns["TotalAttractionCost"].HeaderText = "Сумма";
		}

		private void NamesAttractionsColumns()
		{
			dataGridViewAttractions.Width = 200;
			dataGridViewAttractions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewAttractions.Columns["Name"].HeaderText = "Название";
			dataGridViewAttractions.Columns["TicketPrice"].HeaderText = "Цена";
		}

		private void SumAllTickets()
		{
			labelSum.Text = "Сумма по всем билетам: ";
			try
			{
				using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
				{
					connection.Open();

					string query = @"SELECT SUM(COALESCE(A.TicketPrice, 0)) AS TotalAttractionCost
                             FROM Tickets T
                             LEFT JOIN TicketAttractions TA ON TA.TicketId = T.Id
                             LEFT JOIN Attractions A ON A.Id = TA.AttractionID
                             WHERE T.EmployeeId IS NOT NULL AND T.EmployeeId IN (SELECT Id FROM Employees WHERE PositionID > 3)";

					using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
					{
						object result = command.ExecuteScalar();
						if (result != null && result != DBNull.Value)
						{
							decimal totalAttractionCost = Convert.ToDecimal(result);
							labelSum.Text += totalAttractionCost.ToString("C");
						}
						else
						{
							labelSum.Text += "0";
						}
					}
				}
			}
			catch (Exception){}
		}


		private void dataGridViewTickets_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex >= 0 && e.RowIndex < dataGridViewTickets.Rows.Count)
				{
					int id = Convert.ToInt32(dataGridViewTickets.Rows[e.RowIndex].Cells["TicketId"].Value);

					string query = @"SELECT A.Name, A.TicketPrice
                             FROM TicketAttractions TA
                             JOIN Attractions A ON A.id = TA.AttractionID
                             WHERE TA.TicketId = @TicketId";

					using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
					{
						connection.Open();
						using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
						{
							command.Parameters.AddWithValue("@TicketId", id);

							using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
							{
								DataTable attractionsTable = new DataTable();
								adapter.Fill(attractionsTable);

								dataGridViewAttractions.DataSource = attractionsTable;
							}
						}
						NamesAttractionsColumns();
					}
				}
			}
			catch (Exception)
			{
				dataGridViewAttractions.DataSource = null;
			}
		}

		private void textBoxSearch_TextChanged(object sender, EventArgs e)
		{
			string field = ((KeyValuePair<string, string>)comboBoxColumns.SelectedItem).Key;

			string searchText = textBoxSearch.Text.Trim();

			using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
			{
				connection.Open();

				string query = $@"SELECT Tickets.Id AS TicketId,
									   P.Position,
									   CONCAT(E.LastName, ' ', E.FirstName, ' ', E.MiddleName) AS Employee,
									   PurchaseDate,
									   COALESCE(SUM(A.TicketPrice), 0) AS TotalAttractionCost
								FROM Tickets
										 JOIN Employees E on E.Id = Tickets.EmployeeId
										 JOIN Positions P on P.Id = E.PositionID
										 LEFT JOIN TicketAttractions TA on TA.TicketId = Tickets.Id
										 LEFT JOIN Attractions A on A.Id = TA.AttractionID
								WHERE E.PositionID > 3 AND {field} ILIKE @searchText
								GROUP BY Tickets.Id, P.Position, E.LastName, E.FirstName, E.MiddleName, PurchaseDate
								ORDER BY PurchaseDate";

				if (!string.IsNullOrEmpty(searchText))
				{
					using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
					{

						command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");


						using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
						{
							DataTable dt = new DataTable();
							adapter.Fill(dt);

							dataGridViewTickets.DataSource = dt;
						}
						NamesColumns();
					}
					if (dataGridViewTickets.Rows.Count > 0)
					{
						dataGridViewTickets_CellClick(dataGridViewTickets, new DataGridViewCellEventArgs(0, 0));
					}
				}
				else
				{
					LoadTickets();
				}
			}
		}

		private void btnInsert_Click(object sender, EventArgs e)
		{
			TicketsAddForm addForm = new TicketsAddForm(connectionString);

			if (addForm.ShowDialog() == DialogResult.OK)
			{
				int emplId = addForm.EmployeeId;
				int atrId = addForm.AttractionId;
				DateTime addDate = addForm.PurchaseDate;

				using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
				{
					try
					{
						connection.Open();

						string ticketsQuery = "INSERT INTO Tickets (EmployeeId, PurchaseDate) VALUES (@EmployeeId, @PurchaseDate)";
						using (NpgsqlCommand ticketsCommand = new NpgsqlCommand(ticketsQuery, connection))
						{
							ticketsCommand.Parameters.AddWithValue("@EmployeeId", emplId);
							ticketsCommand.Parameters.AddWithValue("@PurchaseDate", addDate);
							ticketsCommand.ExecuteNonQuery();
						}						

						string getIdQuery = "SELECT lastval()";
						using (NpgsqlCommand getIdCommand = new NpgsqlCommand(getIdQuery, connection))
						{
							int TicketId = Convert.ToInt32(getIdCommand.ExecuteScalar());

							string ticketAttractionsQuery = "INSERT INTO TicketAttractions (TicketId, AttractionId) VALUES (@TicketId, @AttractionId)";
							
							using (NpgsqlCommand ticketAttractionsCommand = new NpgsqlCommand(ticketAttractionsQuery, connection))
							{
								ticketAttractionsCommand.Parameters.AddWithValue("@TicketId", TicketId);
								ticketAttractionsCommand.Parameters.AddWithValue("@AttractionId", atrId);								
								int rowsAffected = ticketAttractionsCommand.ExecuteNonQuery();
								if (rowsAffected > 0)
								{
									LoadTickets();
								}
								else
								{
									MessageBox.Show("Не удалось добавить данные");
								}
							}

						}
					}
					catch (Exception ex)
					{
						Console.WriteLine($"Error: {ex.Message}");
					}
				}
			}
		}
		private Tuple<int, int> GetEmployeeAndAttractionIds(int ticketId)
		{
			using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
			{
				connection.Open();

				string query = "SELECT EmployeeId, AttractionId FROM TicketAttractions " +
					"JOIN Tickets T on TicketAttractions.TicketId = T.Id" +
					" WHERE TicketId = @TicketId";

				using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@TicketId", ticketId);

					using (NpgsqlDataReader reader = command.ExecuteReader())
					{
						if (reader.Read())
						{
							int employeeId = reader.GetInt32(0);
							int attractionId = reader.GetInt32(1);
							return Tuple.Create(employeeId, attractionId);
						}
					}
				}
			}
			return null;
		}

		private void addAttraction_Click(object sender, EventArgs e)
		{
			try
			{
				if (dataGridViewTickets.CurrentRow == null)
				{
					throw new Exception("Не выбран билет");
				}

				string employee = dataGridViewTickets.CurrentRow.Cells["Employee"].Value?.ToString();
				int id = Convert.ToInt32(dataGridViewTickets.CurrentRow.Cells["TicketId"].Value);
				DateTime date = Convert.ToDateTime(dataGridViewTickets.CurrentRow.Cells["PurchaseDate"].Value);
				Tuple<int, int> result = GetEmployeeAndAttractionIds(id);

				TicketsAddForm addForm = new TicketsAddForm(connectionString, result, date, 1);
				if (addForm.ShowDialog() == DialogResult.OK)
				{
					int atrId = addForm.AttractionId;
					DateTime addDate = addForm.PurchaseDate;

					using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
					{
						connection.Open();

						string ticketAttractionsQuery = "INSERT INTO TicketAttractions (TicketId, AttractionId) VALUES (@TicketId, @AttractionId)";

						using (NpgsqlCommand ticketAttractionsCommand = new NpgsqlCommand(ticketAttractionsQuery, connection))
						{
							ticketAttractionsCommand.Parameters.AddWithValue("@TicketId", id);
							ticketAttractionsCommand.Parameters.AddWithValue("@AttractionId", atrId);
							int rowsAffected = ticketAttractionsCommand.ExecuteNonQuery();
							if (rowsAffected > 0)
							{
								LoadTickets();
							}
							else
							{
								MessageBox.Show("Не удалось добавить данные");
							}
						}

					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
			}
		}

		private void btnEditTicket_Click(object sender, EventArgs e)
		{
			try
			{
				if (dataGridViewTickets.CurrentRow == null)
				{
					throw new Exception("Не выбран билет");
				}

				string employee = dataGridViewTickets.CurrentRow.Cells["Employee"].Value?.ToString();
				int id = Convert.ToInt32(dataGridViewTickets.CurrentRow.Cells["TicketId"].Value);
				DateTime date = Convert.ToDateTime(dataGridViewTickets.CurrentRow.Cells["PurchaseDate"].Value);
				Tuple<int, int> result = GetEmployeeAndAttractionIds(id);

				TicketsAddForm addForm = new TicketsAddForm(connectionString, result, date, 2);
				if (addForm.ShowDialog() == DialogResult.OK)
				{
					int empId = addForm.EmployeeId;
					DateTime addDate = addForm.PurchaseDate;

					using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
					{
						connection.Open();

						string ticketsQuery = "UPDATE Tickets SET EmployeeId = @EmployeeId, PurchaseDate = @PurchaseDate WHERE Id = @TicketId";
						using (NpgsqlCommand ticketsCommand = new NpgsqlCommand(ticketsQuery, connection))
						{
							ticketsCommand.Parameters.AddWithValue("@EmployeeId", empId);
							ticketsCommand.Parameters.AddWithValue("@PurchaseDate", addDate);
							ticketsCommand.Parameters.AddWithValue("@TicketId", id);
							int rowsAffected = ticketsCommand.ExecuteNonQuery();
							if (rowsAffected > 0)
							{
								LoadTickets();
							}
							else
							{
								MessageBox.Show("Не удалось добавить данные");
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
			}
		}

		private void btnEditAttraction_Click(object sender, EventArgs e)
		{
			try
			{
				if (dataGridViewAttractions.CurrentRow == null)
				{
					throw new Exception("Не выбран аттракцион");
				}

				string employee = dataGridViewTickets.CurrentRow.Cells["Employee"].Value?.ToString();
				int id = Convert.ToInt32(dataGridViewTickets.CurrentRow.Cells["TicketId"].Value);
				DateTime date = Convert.ToDateTime(dataGridViewTickets.CurrentRow.Cells["PurchaseDate"].Value);
				Tuple<int, int> result = GetEmployeeAndAttractionIds(id);
				int oldAtrId = result.Item2;

				TicketsAddForm addForm = new TicketsAddForm(connectionString, result, date, 1);
				if (addForm.ShowDialog() == DialogResult.OK)
				{
					int atrId = addForm.AttractionId;

					using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
					{
						connection.Open();

						string ticketsQuery = "UPDATE TicketAttractions SET TicketId = @TicketId, AttractionId = @AttractionId " +
							"WHERE AttractionId = @oldAtrId AND TicketId = @TicketId";
						using (NpgsqlCommand ticketsCommand = new NpgsqlCommand(ticketsQuery, connection))
						{
							ticketsCommand.Parameters.AddWithValue("@AttractionId", atrId);
							ticketsCommand.Parameters.AddWithValue("@TicketId", id);
							ticketsCommand.Parameters.AddWithValue("@oldAtrId", oldAtrId);
							int rowsAffected = ticketsCommand.ExecuteNonQuery();
							if (rowsAffected > 0)
							{
								LoadTickets();
							}
							else
							{
								MessageBox.Show("Не удалось добавить данные");
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
			}
		}

		private void btnRemoveTicket_Click(object sender, EventArgs e)
		{
			try
			{
				if (dataGridViewTickets.CurrentRow == null)
				{
					throw new Exception("Не выбран билет");
				}

				int id = Convert.ToInt32(dataGridViewTickets.CurrentRow.Cells["TicketId"].Value);

				DialogResult res = MessageBox.Show("Точно удалить билет?", "Предупреждение", MessageBoxButtons.OKCancel);
				if (res == DialogResult.OK)
				{
					using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
					{
						connection.Open();

						using (NpgsqlCommand command = new NpgsqlCommand("DELETE FROM Tickets WHERE id = @id", connection))
						{
							command.Parameters.AddWithValue("@id", id);

							int rowsUpdated = command.ExecuteNonQuery();
							if (rowsUpdated > 0)
							{
								LoadTickets();
							}
							else
							{
								MessageBox.Show("Ошибка удаления данных");
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
			}
		}

		private void btnRemoveAttr_Click(object sender, EventArgs e)
		{
			try
			{
				if (dataGridViewAttractions.CurrentRow == null)
				{
					throw new Exception("Не выбран аттракцион");
				}

				int id = Convert.ToInt32(dataGridViewTickets.CurrentRow.Cells["TicketId"].Value);
				Tuple<int, int> result = GetEmployeeAndAttractionIds(id);
				int atrId = result.Item2;

				DialogResult res = MessageBox.Show("Точно удалить аттракцион?", "Предупреждение", MessageBoxButtons.OKCancel);
				if (res == DialogResult.OK)
				{
					using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
					{
						connection.Open();

						using (NpgsqlCommand command = new NpgsqlCommand("DELETE FROM TicketAttractions WHERE TicketId = @id AND AttractionID = @AttractionID", connection))
						{
							command.Parameters.AddWithValue("@id", id);
							command.Parameters.AddWithValue("@AttractionID", atrId);

							int rowsUpdated = command.ExecuteNonQuery();
							if (rowsUpdated > 0)
							{
								LoadTickets();
							}
							else
							{
								MessageBox.Show("Ошибка удаления данных");
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
			}
		}
	}
}
