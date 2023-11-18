using AmusementPark.View.Positions;
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
using System.Windows.Forms.VisualStyles;

namespace AmusementPark.View.Employees
{
	public partial class EmployeesForm : Form
	{
		string connectionString;
		public EmployeesForm(string connectionString)
		{
			this.connectionString = connectionString;
			InitializeComponent();
			LoadEmployees();

			Dictionary<string, string> keys = new Dictionary<string, string>
			{
				{ "LastName", "Фамилия сотрудника" },
				{ "Position", "должность" },
				{ "Login", "логин" }
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

		private void LoadEmployees()
		{
			try
			{
				string query = "SELECT Employees.Id, LastName, FirstName, MiddleName, DateOfBirth, P.Position, Login, PositionID, Password FROM Employees" +
					" JOIN UserCredentials UC on UC.Id = Employees.UserCredentialId JOIN Positions P on P.Id = Employees.PositionID";

				using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
				{

					connection.Open();

					using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection))
					{
						DataTable attractionsTable = new DataTable();
						adapter.Fill(attractionsTable);

						dataGridViewEmployees.DataSource = attractionsTable;
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
			dataGridViewEmployees.Columns["id"].Visible = false;
			dataGridViewEmployees.Columns["PositionID"].Visible = false;
			dataGridViewEmployees.Columns["FirstName"].HeaderText = "Имя";
			dataGridViewEmployees.Columns["LastName"].HeaderText = "Фамилия";
			dataGridViewEmployees.Columns["MiddleName"].HeaderText = "Отчество";
			dataGridViewEmployees.Columns["DateOfBirth"].HeaderText = "Дата рождения";
			dataGridViewEmployees.Columns["Position"].HeaderText = "Должность";
			dataGridViewEmployees.Columns["Login"].HeaderText = "Логин";
			dataGridViewEmployees.Columns["Password"].HeaderText = "Пароль";
		}

		private void textBoxSearch_TextChanged(object sender, EventArgs e)
		{
			string field = ((KeyValuePair<string, string>)comboBoxColumns.SelectedItem).Key;

			string searchText = textBoxSearch.Text.Trim();

			using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
			{
				connection.Open();

				string commonQuery = "SELECT Employees.Id, LastName, FirstName, MiddleName, DateOfBirth, P.Position, Login, Password, PositionID FROM Employees" +
					" JOIN UserCredentials UC on UC.Id = Employees.UserCredentialId JOIN Positions P on P.Id = Employees.PositionID";

				string query;
				query = $"{commonQuery} WHERE {field} ILIKE @searchText";
				if (!string.IsNullOrEmpty(searchText))
				{
					using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
					{

						command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");


						using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
						{
							DataTable dt = new DataTable();
							adapter.Fill(dt);

							dataGridViewEmployees.DataSource = dt;
						}
						NamesColumns();
					}
				}
				else
				{
					LoadEmployees();
				}
			}
		}

		private void btnInsert_Click(object sender, EventArgs e)
		{
			EmployeesAddForm addForm = new EmployeesAddForm(connectionString);

			if (addForm.ShowDialog() == DialogResult.OK)
			{
				if (!addForm.ValueForm)
				{
					return;
				}
				string addFirstName = addForm.FirstName;
				string addLastName = addForm.LastName;
				string addMiddleName = addForm.MiddleName;
				string addLogin = addForm.Login;
				string addPassword = addForm.Password;
				DateTime addDateOfBirth = addForm.DateOfBirth;
				int addPositionId = addForm.PositionId;

				using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
				{
					try
					{
						connection.Open();

						string userCredentialsQuery = "INSERT INTO UserCredentials (Login, Password) VALUES (@Login, @Password)";
						using (NpgsqlCommand userCredentialsCommand = new NpgsqlCommand(userCredentialsQuery, connection))
						{
							userCredentialsCommand.Parameters.AddWithValue("@Login", addLogin);
							userCredentialsCommand.Parameters.AddWithValue("@Password", addPassword);
							userCredentialsCommand.ExecuteNonQuery();
						}

						string getUserIdQuery = "SELECT id FROM UserCredentials WHERE Login = @Login AND Password = @Password";
						using (NpgsqlCommand getUserIdCommand = new NpgsqlCommand(getUserIdQuery, connection))
						{
							getUserIdCommand.Parameters.AddWithValue("@Login", addLogin);
							getUserIdCommand.Parameters.AddWithValue("@Password", addPassword);
							int userId = Convert.ToInt32(getUserIdCommand.ExecuteScalar());

							string employeesQuery = "INSERT INTO Employees (UserCredentialId, FirstName, LastName, MiddleName, DateOfBirth, PositionID) " +
													"VALUES (@UserCredentialId, @FirstName, @LastName, @MiddleName, @DateOfBirth, @PositionID)";
							using (NpgsqlCommand employeesCommand = new NpgsqlCommand(employeesQuery, connection))
							{
								employeesCommand.Parameters.AddWithValue("@UserCredentialId", userId);
								employeesCommand.Parameters.AddWithValue("@FirstName", addFirstName);
								employeesCommand.Parameters.AddWithValue("@LastName", addLastName);
								employeesCommand.Parameters.AddWithValue("@MiddleName", addMiddleName);
								employeesCommand.Parameters.AddWithValue("@DateOfBirth", addDateOfBirth);
								employeesCommand.Parameters.AddWithValue("@PositionID", addPositionId);
								int rowsAffected = employeesCommand.ExecuteNonQuery();
								if (rowsAffected > 0)
								{
									LoadEmployees();
								}
								else
								{
									MessageBox.Show("Не удалось добавить данные в таблицу Employees");
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

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				if (dataGridViewEmployees.CurrentRow == null)
				{
					throw new Exception("Не выбран сотрудник");
				}

				int id = Convert.ToInt32(dataGridViewEmployees.CurrentRow.Cells["id"].Value);
				string firstName = dataGridViewEmployees.CurrentRow.Cells["FirstName"].Value?.ToString();
				string lastName = dataGridViewEmployees.CurrentRow.Cells["LastName"].Value?.ToString();
				string middleName = dataGridViewEmployees.CurrentRow.Cells["MiddleName"].Value?.ToString();
				string login = dataGridViewEmployees.CurrentRow.Cells["Login"].Value?.ToString();
				string password = dataGridViewEmployees.CurrentRow.Cells["Password"].Value?.ToString();
				DateTime dateOfBirth = Convert.ToDateTime(dataGridViewEmployees.CurrentRow.Cells["DateOfBirth"].Value);
				int positionId = Convert.ToInt32(dataGridViewEmployees.CurrentRow.Cells["PositionID"].Value);

				object[] values = { login, password, firstName, lastName, middleName, dateOfBirth, positionId, id };

				EmployeesAddForm addForm = new EmployeesAddForm(connectionString, values);
				if (addForm.ShowDialog() == DialogResult.OK)
				{
					if (!addForm.ValueForm)
					{
						return;
					}

					login = addForm.Login;
					password = addForm.Password;
					firstName = addForm.FirstName;
					lastName = addForm.LastName;
					middleName = addForm.MiddleName;
					dateOfBirth = addForm.DateOfBirth;
					positionId = addForm.PositionId;

					using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
					{
						connection.Open();

						string updateUserCredentialsQuery = "UPDATE UserCredentials SET Login = @Login, Password = @Password WHERE Id = @Id";
						using (NpgsqlCommand updateUserCredentialsCommand = new NpgsqlCommand(updateUserCredentialsQuery, connection))
						{
							updateUserCredentialsCommand.Parameters.AddWithValue("@Id", id);
							updateUserCredentialsCommand.Parameters.AddWithValue("@Login", login);
							updateUserCredentialsCommand.Parameters.AddWithValue("@Password", password);
							updateUserCredentialsCommand.ExecuteNonQuery();
						}

						string updateEmployeeQuery = "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, " +
													 "MiddleName = @MiddleName, DateOfBirth = @DateOfBirth, PositionID = @PositionID WHERE Id = @Id";
						using (NpgsqlCommand updateEmployeeCommand = new NpgsqlCommand(updateEmployeeQuery, connection))
						{
							updateEmployeeCommand.Parameters.AddWithValue("@Id", id);
							updateEmployeeCommand.Parameters.AddWithValue("@FirstName", firstName);
							updateEmployeeCommand.Parameters.AddWithValue("@LastName", lastName);
							updateEmployeeCommand.Parameters.AddWithValue("@MiddleName", middleName);
							updateEmployeeCommand.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
							updateEmployeeCommand.Parameters.AddWithValue("@PositionID", positionId);
							int rowsAffected = updateEmployeeCommand.ExecuteNonQuery();
							if (rowsAffected > 0)
							{
								LoadEmployees();
							}
							else
							{
								MessageBox.Show("Не удалось изменить данные");
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
				if (dataGridViewEmployees.CurrentRow == null)
				{
					throw new Exception("Не выбран сотрудник");
				}

				int id = Convert.ToInt32(dataGridViewEmployees.CurrentRow.Cells["id"].Value);
				DialogResult res = MessageBox.Show("Точно удалить сотрудника?\n" +
					"Все билеты связанные с сотрудником пропадут", "Предупреждение", MessageBoxButtons.OKCancel);
				if (res == DialogResult.OK)
				{
					using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
					{
						connection.Open();

						using (NpgsqlCommand command = new NpgsqlCommand("DELETE FROM UserCredentials WHERE id = @id", connection))
						{
							command.Parameters.AddWithValue("@id", id);

							int rowsUpdated = command.ExecuteNonQuery();
							if (rowsUpdated > 0)
							{
								LoadEmployees();
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

		private void btnSortOnPosition_Click(object sender, EventArgs e)
		{
			if (dataGridViewEmployees.DataSource is DataTable dataTable && dataTable.Rows.Count > 0)
			{
				DataView dataView = new DataView(dataTable);

				dataView.Sort = "Position ASC";
				dataGridViewEmployees.DataSource = dataView;
			}
		}

		private void btnSortOnLastName_Click(object sender, EventArgs e)
		{
			if (dataGridViewEmployees.DataSource is DataTable dataTable && dataTable.Rows.Count > 0)
			{
				DataView dataView = new DataView(dataTable);

				dataView.Sort = "LastName ASC";
				dataGridViewEmployees.DataSource = dataView;
			}
		}

		private void btnSortOnLogin_Click(object sender, EventArgs e)
		{
			if (dataGridViewEmployees.DataSource is DataTable dataTable && dataTable.Rows.Count > 0)
			{
				DataView dataView = new DataView(dataTable);

				dataView.Sort = "Login ASC";
				dataGridViewEmployees.DataSource = dataView;
			}
		}
	}
}
