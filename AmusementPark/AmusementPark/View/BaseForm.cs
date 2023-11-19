using AmusementPark.View.Tickets;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmusementPark
{
	public partial class BaseForm : Form
	{
		string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
		Tuple<int, string> usernameInfo;
		public BaseForm(string username)
		{
			InitializeComponent();
			usernameInfo = GetName(username);

			labelUsername.Text = "Хорошего дня, " + usernameInfo.Item2;
			LoadTickets();
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

		private Tuple<int, string> GetName(string username)
		{

			Console.WriteLine($"\nusername: {username}");
			using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
			{
				connection.Open();

				string query = @"SELECT UC.id, CONCAT(FirstName, ' ', MiddleName) AS Employee FROM Employees 
								JOIN UserCredentials UC on UC.Id = Employees.UserCredentialId
								WHERE Login = @Login";

				using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Login", username);

					using (NpgsqlDataReader reader = command.ExecuteReader())
					{
						if (reader.Read())
						{
							int employeeId = reader.GetInt32(0);
							string employeeName = reader.GetString(1);
							Console.WriteLine($"\nEmployee ID: {employeeId}, Employee Name: {employeeName}\n");
							return Tuple.Create(employeeId, employeeName);
						}
					}
				}
			}
			return null;
		}

		private void LoadTickets()
		{
			try
			{
				using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
				{
					connection.Open();

					string query = @"SELECT Tickets.Id AS TicketId, PurchaseDate,
                                   COALESCE(SUM(A.TicketPrice), 0) AS TotalAttractionCost
                            FROM Tickets
                                     JOIN Employees E on E.Id = Tickets.EmployeeId
                                     JOIN Positions P on P.Id = E.PositionID
                                     LEFT JOIN TicketAttractions TA on TA.TicketId = Tickets.Id
                                     LEFT JOIN Attractions A on A.Id = TA.AttractionID
                            WHERE E.Id = @Employee
                            GROUP BY Tickets.Id, PurchaseDate
                            ORDER BY PurchaseDate";

					using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@Employee", usernameInfo.Item1);

						using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
						{
							DataTable ticketsTable = new DataTable();
							adapter.Fill(ticketsTable);

							dataGridViewTickets.DataSource = ticketsTable;
						}
						NamesColumns();
						SumAllTickets();
					}
					if (dataGridViewTickets.Rows.Count > 0)
					{
						dataGridViewTickets_CellClick(dataGridViewTickets, new DataGridViewCellEventArgs(0, 0));
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error: {ex.Message}");
			}
		}


		private void NamesColumns()
		{
			dataGridViewTickets.Width = 400;
			dataGridViewTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewTickets.Columns["TicketId"].Visible = false;
			dataGridViewTickets.Columns["PurchaseDate"].HeaderText = "Дата продажи";
			dataGridViewTickets.Columns["TotalAttractionCost"].HeaderText = "Сумма";
		}

		private void NamesAttractionsColumns()
		{
			dataGridViewAttractions.Width = 300;
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
									WHERE T.EmployeeId = @Employee";

					using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@Employee", usernameInfo.Item1);
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
			catch (Exception) { }
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

		private void btnInsert_Click(object sender, EventArgs e)
		{
			BaseTicketAddForm addForm = new BaseTicketAddForm(connectionString);
			if (addForm.ShowDialog() == DialogResult.OK)
			{
				DateTime addDate = addForm.PurchaseDate;
				List<int> idAttractions = addForm.AttractionsId;

				using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
				{
					connection.Open();

					string insertTicketQuery = "INSERT INTO Tickets (EmployeeId, PurchaseDate) VALUES (@EmployeeId, @PurchaseDate) RETURNING Id";
					using (NpgsqlCommand command = new NpgsqlCommand(insertTicketQuery, connection))
					{
						command.Parameters.AddWithValue("@EmployeeId", usernameInfo.Item1);
						command.Parameters.AddWithValue("@PurchaseDate", addDate);

						int ticketId = (int)command.ExecuteScalar();

						if (idAttractions != null && idAttractions.Count > 0)
						{
							string insertAttractionsQuery = "INSERT INTO TicketAttractions (TicketId, AttractionId) VALUES (@TicketId, @AttractionId)";
							using (NpgsqlCommand attractionsCommand = new NpgsqlCommand(insertAttractionsQuery, connection))
							{
								attractionsCommand.Parameters.AddWithValue("@TicketId", ticketId);

								foreach (int attractionId in idAttractions)
								{
									attractionsCommand.Parameters.Clear();
									attractionsCommand.Parameters.AddWithValue("@TicketId", ticketId);
									attractionsCommand.Parameters.AddWithValue("@AttractionId", attractionId);
									attractionsCommand.ExecuteNonQuery();
								}
							}
						}
						LoadTickets();
					}
				}
			}
		}


		private void btnUpdate_Click(object sender, EventArgs e)
		{

		}
	}
}
