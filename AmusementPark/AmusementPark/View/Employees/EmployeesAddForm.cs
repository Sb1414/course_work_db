using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmusementPark.View.Employees
{
	public partial class EmployeesAddForm : Form
	{
		string connectionString;
		bool isField = true;
		Dictionary<int, string> positions = new Dictionary<int, string>();

		public EmployeesAddForm(string connectionString)
		{
			this.connectionString = connectionString;
			InitializeComponent();
			FillComboBoxPosition();

			buttonAdd.DialogResult = DialogResult.OK;

			this.AcceptButton = buttonAdd;
		}

		public EmployeesAddForm(string connectionString, object[] values) 
		{
			this.connectionString = connectionString;
			InitializeComponent();
			FillComboBoxPosition();

			buttonAdd.DialogResult = DialogResult.OK;

			this.AcceptButton = buttonAdd;

			textBoxLogin.Text = values[0].ToString();
			textBoxPassword.Text = values[1].ToString();
			textBoxFirstName.Text = values[2].ToString();
			textBoxLastName.Text = values[3].ToString();
			textBoxMiddleName.Text = values[4].ToString();
			dateOfBirth.Value = Convert.ToDateTime(values[5]);

			int id = int.Parse(values[6].ToString());
			comboBoxPosition.SelectedItem = new KeyValuePair<int, string>(id, positions[id]);
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

		public string FirstName
		{
			get
			{
				return textBoxFirstName.Text;
			}
		}

		public string LastName
		{
			get
			{
				return textBoxLastName.Text;
			}
		}
		public string MiddleName
		{
			get
			{
				return textBoxMiddleName.Text;
			}
		}
		public string Login
		{
			get
			{
				return textBoxLogin.Text;
			}
		}

		public string Password
		{
			get
			{
				return textBoxPassword.Text;
			}
		}

		public DateTime DateOfBirth
		{
			get
			{
				return dateOfBirth.Value;
			}
		}

		public int PositionId
		{
			get
			{
				if (comboBoxPosition.SelectedItem != null)
				{
					return (int)comboBoxPosition.SelectedValue;
				}
				return -1;
			}
		}

		public bool ValueForm
		{
			get
			{
				return isField;
			}
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Login) || 
				string.IsNullOrEmpty(MiddleName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(FirstName))
			{
				MessageBox.Show("Заполните все поля !");
				isField = false;
				return;
			}
		}

		private void FillComboBoxPosition()
		{
			using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
			{
				connection.Open();

				string query = "WITH EmployeeCounts AS (SELECT PositionId, COUNT(*) AS EmployeeCount " +
					"FROM Employees GROUP BY PositionId) " +
					"SELECT Positions.Id, Positions.Position FROM Positions " +
					"LEFT JOIN EmployeeCounts ON Positions.Id = EmployeeCounts.PositionId " +
					"WHERE Positions.Count - COALESCE(EmployeeCounts.EmployeeCount, 0) > 0";
				using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
				{
					using (NpgsqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							int id = reader.GetInt32(0);
							string position = reader.GetString(1);
							positions.Add(id, position);
						}
					}
				}
			}

			comboBoxPosition.DataSource = new BindingSource(positions, null);
			comboBoxPosition.DisplayMember = "Value";
			comboBoxPosition.ValueMember = "Key";
			comboBoxPosition.DropDownStyle = ComboBoxStyle.DropDownList;
		}

		private void comboBoxPosition_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxPosition.SelectedItem != null)
			{
				int selectedPositionId = ((KeyValuePair<int, string>)comboBoxPosition.SelectedItem).Key;

				int freePositions = GetFreePositions(selectedPositionId);

				labelInfo.Text = $"Свободных мест: {freePositions}";
			}
		}

		private int GetFreePositions(int positionId)
		{
			using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
			{
				connection.Open();

				string query = "SELECT (SELECT Count FROM Positions WHERE Id = @PositionId) - " +
					   "(SELECT COUNT(*) FROM Employees WHERE PositionId = @PositionId)";

				using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@PositionId", positionId);

					return Convert.ToInt32(command.ExecuteScalar());
				}
			}
		}

		private void textBoxLastName_TextChanged(object sender, EventArgs e)
		{
			string name = textBoxLastName.Text;

			if (!Regex.IsMatch(name, @"^[a-zA-Zа-яА-Я]+$"))
			{
				MessageBox.Show("Фамилия может содержать только буквы");
			}

			if (name.Length > 0)
			{
				name = char.ToUpper(name[0]) + name.Substring(1).ToLower();
				name = new string(name.Where(c => char.IsLetter(c)).ToArray());

				textBoxLastName.Text = name;
				textBoxLastName.Select(name.Length, 0);
			}
		}

		private void textBoxFirstName_TextChanged(object sender, EventArgs e)
		{
			string name = textBoxFirstName.Text;

			if (!Regex.IsMatch(name, @"^[a-zA-Zа-яА-Я]+$"))
			{
				MessageBox.Show("Имя может содержать только буквы");
			}

			if (name.Length > 0)
			{
				name = char.ToUpper(name[0]) + name.Substring(1).ToLower();
				name = new string(name.Where(c => char.IsLetter(c)).ToArray());

				textBoxFirstName.Text = name;
				textBoxFirstName.Select(name.Length, 0);
			}
		}

		private void textBoxMiddleName_TextChanged(object sender, EventArgs e)
		{
			string name = textBoxMiddleName.Text;

			if (!Regex.IsMatch(name, @"^[a-zA-Zа-яА-Я]+$"))
			{
				MessageBox.Show("Отчество может содержать только буквы");
			}

			if (name.Length > 0)
			{
				name = char.ToUpper(name[0]) + name.Substring(1).ToLower();
				name = new string(name.Where(c => char.IsLetter(c)).ToArray());

				textBoxMiddleName.Text = name;
				textBoxMiddleName.Select(name.Length, 0);
			}
		}

		private void textBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				e.Handled = true;
				return;
			}

			if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
		}

		private void textBoxPassword_Validating(object sender, CancelEventArgs e)
		{
			string password = textBoxPassword.Text;

			if (!IsPasswordValid(password))
			{
				labelPass.Text = "Пароль должен содержать только цифры и буквы, и быть не менее 8 символов.";
				e.Cancel = true;
			}
			else
			{
				labelPass.Text = "";
				e.Cancel = false;
			}
		}

		private bool IsPasswordValid(string password)
		{
			string pattern = @"^[a-zA-Zа-яА-я0-9]{8,}$";
			return Regex.IsMatch(password, pattern) && !password.Contains(" ");
		}

		private void textBoxPassword_KeyPress_1(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				e.Handled = true;
				return;
			}

			if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
		}

		private void textBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				e.Handled = true;
				return;
			}
		}

		private void textBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				e.Handled = true;
				return;
			}
		}

		private void textBoxMiddleName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				e.Handled = true;
				return;
			}
		}

	}
}
