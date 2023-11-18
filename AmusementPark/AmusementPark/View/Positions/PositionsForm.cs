using AmusementPark.View.Attractions;
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

namespace AmusementPark.View.Positions
{
	public partial class PositionsForm : Form
	{
		string connectionString;
		public PositionsForm(string connectionString)
		{
			this.connectionString = connectionString;
			InitializeComponent();
			LoadPositions();
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

		private void LoadPositions()
		{
			try
			{
				string query = "SELECT * FROM Positions";

				using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
				{

					connection.Open();

					using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection))
					{
						DataTable attractionsTable = new DataTable();
						adapter.Fill(attractionsTable);

						dataGridViewPositions.DataSource = attractionsTable;
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
			dataGridViewPositions.Columns["id"].Visible = false;
			dataGridViewPositions.Columns["Position"].HeaderText = "Название";
			dataGridViewPositions.Columns["Salary"].HeaderText = "Зарплата";
			dataGridViewPositions.Columns["Count"].HeaderText = "Количество мест";
		}

		private void btnInsert_Click(object sender, EventArgs e)
		{
			PositionsAddForm addForm = new PositionsAddForm();

			if (addForm.ShowDialog() == DialogResult.OK)
			{
				string addPosition = addForm.Position;
				int addSalary = addForm.Salary;
				int addCount = addForm.Count;

				using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
				{
					try
					{
						connection.Open();

						string query = "INSERT INTO Positions (Position, Salary, Count) " +
									   "VALUES (@Position, @Salary, @Count)";

						using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
						{
							command.Parameters.AddWithValue("@Position", addPosition);
							command.Parameters.AddWithValue("@Salary", addSalary);
							command.Parameters.AddWithValue("@Count", addCount);

							int rowsAffected = command.ExecuteNonQuery();

							if (rowsAffected > 0)
							{
								LoadPositions();
							}
							else
							{
								MessageBox.Show("Не удалось добавить данные в таблицу Positions.");
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
				if (dataGridViewPositions.CurrentRow == null)
				{
					throw new Exception("Не выбрана должность");
				}

				int id = Convert.ToInt32(dataGridViewPositions.CurrentRow.Cells["id"].Value);
				string oldPosition = dataGridViewPositions.CurrentRow.Cells["Position"].Value?.ToString();
				int oldSalary = Convert.ToInt32(dataGridViewPositions.CurrentRow.Cells["Salary"].Value);
				int oldCount = Convert.ToInt32(dataGridViewPositions.CurrentRow.Cells["Count"].Value);

				PositionsAddForm addForm = new PositionsAddForm(oldPosition, oldSalary, oldCount);

				if (addForm.ShowDialog() == DialogResult.OK)
				{
					string addPosition = addForm.Position;
					int addSalary = addForm.Salary;
					int addCount = addForm.Count;

					using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
					{
						connection.Open();
						string query = "UPDATE Positions SET Position = @Position, Salary = @Salary, Count = @Count WHERE ID = @id";

						using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
						{
							command.Parameters.AddWithValue("@Position", addPosition);
							command.Parameters.AddWithValue("@Salary", addSalary);
							command.Parameters.AddWithValue("@Count", addCount);
							command.Parameters.AddWithValue("@id", id);

							int rowsUpdated = command.ExecuteNonQuery();
							if (rowsUpdated > 0)
							{
								LoadPositions();
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
				if (dataGridViewPositions.CurrentRow == null)
				{
					throw new Exception("Не выбрана должность");
				}

				int id = Convert.ToInt32(dataGridViewPositions.CurrentRow.Cells["id"].Value);
				DialogResult res = MessageBox.Show("Точно удалить должность?\n" +
					"Все сотрудники на данной должности останутся без должности (null)", "Предупреждение", MessageBoxButtons.OKCancel);
				if (res == DialogResult.OK)
				{
					using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
					{
						connection.Open();

						using (NpgsqlCommand command = new NpgsqlCommand("DELETE FROM Positions WHERE id = @id", connection))
						{
							command.Parameters.AddWithValue("@id", id);

							int rowsUpdated = command.ExecuteNonQuery();
							if (rowsUpdated > 0)
							{
								LoadPositions();
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

		private void textBoxSearch_TextChanged(object sender, EventArgs e)
		{
			string searchText = textBoxSearch.Text.Trim();
			if (!string.IsNullOrEmpty(searchText))
			{
				using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
				{
					connection.Open();

					string query = "SELECT * FROM Positions WHERE Position ILIKE @searchText";

					using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

						using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
						{
							DataTable attractionsTable = new DataTable();
							adapter.Fill(attractionsTable);

							dataGridViewPositions.DataSource = attractionsTable;
						}
						NamesColumns();
					}
				}
			}
			else
			{
				LoadPositions();
			}
		}

		private void btnSortOnName_Click(object sender, EventArgs e)
		{
			if (dataGridViewPositions.DataSource is DataTable dataTable && dataTable.Rows.Count > 0)
			{
				DataView dataView = new DataView(dataTable);

				dataView.Sort = "Position ASC";
				dataGridViewPositions.DataSource = dataView;
			}
		}

		private void btnSortOnPrice_Click(object sender, EventArgs e)
		{
			if (dataGridViewPositions.DataSource is DataTable dataTable && dataTable.Rows.Count > 0)
			{
				DataView dataView = new DataView(dataTable);

				dataView.Sort = "Salary ASC";
				dataGridViewPositions.DataSource = dataView;
			}
		}

		private void btnSortOnCapacity_Click(object sender, EventArgs e)
		{
			if (dataGridViewPositions.DataSource is DataTable dataTable && dataTable.Rows.Count > 0)
			{
				DataView dataView = new DataView(dataTable);

				dataView.Sort = "Count ASC";
				dataGridViewPositions.DataSource = dataView;
			}
		}
	}
}
