using AmusementPark.View.Attractions;
using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmusementPark
{
	public partial class AttractionsForm : Form
	{
		string connectionString;
		public AttractionsForm(string connectionString)
		{
			this.connectionString = connectionString;

			InitializeComponent(); 
			LoadAttractions();
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

		private void LoadAttractions()
		{
			try
			{
				string query = "SELECT * FROM Attractions";

				using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
				{

					connection.Open();

					using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection))
					{
						DataTable attractionsTable = new DataTable();
						adapter.Fill(attractionsTable);

						dataGridViewAttractions.DataSource = attractionsTable;
					}
					NamesColumns();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error: {ex.Message}");
			}
		}

		private void NamesColumns()
		{
			dataGridViewAttractions.Columns["id"].Visible = false;
			dataGridViewAttractions.Columns["Name"].HeaderText = "Название";
			dataGridViewAttractions.Columns["Description"].HeaderText = "Описание";
			dataGridViewAttractions.Columns["Capacity"].HeaderText = "Вместимость";
			dataGridViewAttractions.Columns["TicketPrice"].HeaderText = "Стоимость";

		}

		private void btnInsert_Click(object sender, EventArgs e)
		{
			AttractionsAddForm addForm = new AttractionsAddForm();

			if (addForm.ShowDialog() == DialogResult.OK)
			{
				string addName = addForm.AttractionsName;
				string addDescription = addForm.AttractionsDescription;
				int addCapacity = addForm.AttractionsCapacity;
				int addTicketPrice = addForm.AttractionsTicketPrice;

				using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
				{
					try
					{
						connection.Open();

						string query = "INSERT INTO Attractions (Name, Description, Capacity, TicketPrice) " +
									   "VALUES (@Name, @Description, @Capacity, @TicketPrice)";

						using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
						{
							command.Parameters.AddWithValue("@Name", addName);
							command.Parameters.AddWithValue("@Description", addDescription);
							command.Parameters.AddWithValue("@Capacity", addCapacity);
							command.Parameters.AddWithValue("@TicketPrice", addTicketPrice);

							int rowsAffected = command.ExecuteNonQuery();

							if (rowsAffected > 0)
							{
								LoadAttractions();
							}
							else
							{
								MessageBox.Show("Не удалось добавить данные в таблицу Attractions.");
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

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				if (dataGridViewAttractions.CurrentRow == null)
				{
					throw new Exception("Не выбран аттракцион");
				}

				int id = Convert.ToInt32(dataGridViewAttractions.CurrentRow.Cells["id"].Value);
				string oldName = dataGridViewAttractions.CurrentRow.Cells["Name"].Value?.ToString();
				string oldDescription = dataGridViewAttractions.CurrentRow.Cells["Description"].Value?.ToString();
				int oldCapacity = Convert.ToInt32(dataGridViewAttractions.CurrentRow.Cells["Capacity"].Value);
				int oldTicketPrice = Convert.ToInt32(dataGridViewAttractions.CurrentRow.Cells["TicketPrice"].Value);

				AttractionsAddForm addForm = new AttractionsAddForm(oldName, oldDescription, oldCapacity, oldTicketPrice);

				if (addForm.ShowDialog() == DialogResult.OK)
				{
					string addName = addForm.AttractionsName;
					string addDescription = addForm.AttractionsDescription;
					int addCapacity = addForm.AttractionsCapacity;
					int addTicketPrice = addForm.AttractionsTicketPrice;

					using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
					{
						connection.Open();
						string query = "UPDATE Attractions SET Name = @Name, Description = @Description, Capacity = @Capacity, " +
									"TicketPrice = @TicketPrice WHERE ID = @id";

						using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
						{
							command.Parameters.AddWithValue("@Name", addName);
							command.Parameters.AddWithValue("@Description", addDescription);
							command.Parameters.AddWithValue("@Capacity", addCapacity);
							command.Parameters.AddWithValue("@TicketPrice", addTicketPrice);
							command.Parameters.AddWithValue("@id", id);

							int rowsUpdated = command.ExecuteNonQuery();
							if (rowsUpdated > 0)
							{
								LoadAttractions();
							}
							else
							{
								MessageBox.Show("Ошибка редактирования данных");
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

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				if (dataGridViewAttractions.CurrentRow == null)
				{
					throw new Exception("Не выбран аттракцион");
				}

				int id = Convert.ToInt32(dataGridViewAttractions.CurrentRow.Cells["id"].Value);
				DialogResult res = MessageBox.Show("Точно удалить аттракцион?\n" +
					"Будут удалены все билеты, связанные с этим аттракционом", "Предупреждение", MessageBoxButtons.OKCancel);
				if (res == DialogResult.OK)
				{
					using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
					{
						connection.Open();

						using (NpgsqlCommand command = new NpgsqlCommand("DELETE FROM Attractions WHERE id = @id", connection))
						{
							command.Parameters.AddWithValue("@id", id);

							int rowsUpdated = command.ExecuteNonQuery();
							if (rowsUpdated > 0)
							{
								LoadAttractions();
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

		private void btnSortOnName_Click(object sender, EventArgs e)
		{
			if (dataGridViewAttractions.DataSource is DataTable dataTable && dataTable.Rows.Count > 0)
			{
				DataView dataView = new DataView(dataTable);

				dataView.Sort = "Name ASC";
				dataGridViewAttractions.DataSource = dataView;
			}
		}

		private void btnSortOnPrice_Click(object sender, EventArgs e)
		{
			if (dataGridViewAttractions.DataSource is DataTable dataTable && dataTable.Rows.Count > 0)
			{
				DataView dataView = new DataView(dataTable);

				dataView.Sort = "TicketPrice ASC";
				dataGridViewAttractions.DataSource = dataView;
			}
		}

		private void btnSortOnCapacity_Click(object sender, EventArgs e)
		{
			if (dataGridViewAttractions.DataSource is DataTable dataTable && dataTable.Rows.Count > 0)
			{
				DataView dataView = new DataView(dataTable);

				dataView.Sort = "Capacity ASC";
				dataGridViewAttractions.DataSource = dataView;
			}
		}

		private void textBoxSearch_TextChanged(object sender, EventArgs e)
		{
			string searchText = textBoxSearch.Text.Trim();
			if (!string.IsNullOrEmpty(searchText))
			{
				using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
				{
					connection.Open();

					string query = "SELECT * FROM Attractions WHERE Name ILIKE @searchText";

					using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

						using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
						{
							DataTable attractionsTable = new DataTable();
							adapter.Fill(attractionsTable);

							dataGridViewAttractions.DataSource = attractionsTable;
						}
						NamesColumns();
					}
				}
			}
			else
			{
				LoadAttractions();
			}
		}

	}
}
