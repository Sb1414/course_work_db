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
using AmusementPark.View.Employees;
using AmusementPark.View.Positions;
using Npgsql;

namespace AmusementPark
{
	public partial class Form1 : Form
	{
		string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
		bool passVisible = false;
		public Form1()
		{
			InitializeComponent();
			textBoxPassword.PasswordChar = '●';
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

		private LoginStatus IsValidLogin(string username, string password)
		{
			using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
			{
				try
				{
					connection.Open();
					Console.WriteLine("Connected to PostgreSQL");

					string query = "SELECT COUNT(*) FROM UserCredentials WHERE Login = @Username AND Password = @Password";
					using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@Username", username);
						command.Parameters.AddWithValue("@Password", password);

						int count = Convert.ToInt32(command.ExecuteScalar());

						if (count > 0)
						{
							return LoginStatus.Success;
						}
						else if (UserExists(username))
						{
							return LoginStatus.InvalidPassword;
						}
						else
						{
							return LoginStatus.InvalidUsername;
						}
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine($"Error: {ex.Message}");
					return LoginStatus.Failure;
				}
			}
		}

		private bool UserExists(string username)
		{
			using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
			{				
				connection.Open();

				string query = "SELECT COUNT(*) FROM UserCredentials WHERE Login = @Username";
				using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Username", username);

					int count = Convert.ToInt32(command.ExecuteScalar());

					if (count > 0)
					{
						return true;
					}
				}
			}
			return false;
		}

		private string GetPositionByLogin(string username, string password)
		{
			using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
			{
				try
				{
					connection.Open();
					Console.WriteLine("Connected to PostgreSQL");

					string query = "SELECT p.Position " +
								   "FROM UserCredentials uc " +
								   "JOIN Employees e ON uc.Id = e.UserCredentialId " +
								   "JOIN Positions p ON e.PositionID = p.Id " +
								   "WHERE uc.Login = @Username AND uc.Password = @Password";

					using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@Username", username);
						command.Parameters.AddWithValue("@Password", password);

						string position = command.ExecuteScalar() as string;
						return position;
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine($"Error: {ex.Message}");
					return null;
				}
			}
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string username = textBoxLogin.Text;
			string password = textBoxPassword.Text;

			if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
			{
				labelInfo.Text = "Введите логин и пароль";
				return;
			}

			LoginStatus loginStatus = IsValidLogin(username, password);

			switch (loginStatus)
			{
				case LoginStatus.Success:
					string position = GetPositionByLogin(username, password).ToLower();

					if (position != null)
					{
						switch (position)
						{
							case "администратор":
							case "директор":
								AdminForm adminForm = new AdminForm();
								adminForm.Show();
								break;

							default:
								BaseForm baseForm = new BaseForm();
								baseForm.Show();
								break;
						}
					}
					break;

				case LoginStatus.InvalidUsername:
					labelInfo.Text = "Пользователя не существует";
					break;

				case LoginStatus.InvalidPassword:
					labelInfo.Text = "Неверный пароль";
					break;

				case LoginStatus.Failure:
					labelInfo.Text = "Ошибка";
					break;
			}
		}

		private void textBoxLogin_TextChanged(object sender, EventArgs e)
		{
			string currentText = textBoxLogin.Text;
			string filteredText = new string(currentText.Where(c => Char.IsLetterOrDigit(c)).ToArray());
			labelInfo.Text = "";

			textBoxLogin.Text = filteredText;
			textBoxLogin.SelectionStart = textBoxLogin.Text.Length;
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			labelInfo.Text = "";
			textBoxLogin.Clear();
			textBoxPassword.Clear();
		}

		private void textBoxPassword_TextChanged(object sender, EventArgs e)
		{
			labelInfo.Text = "";
		}

		private void btnCheckPass_Click(object sender, EventArgs e)
		{
			if (passVisible)
			{
				passVisible = false;
				textBoxPassword.PasswordChar = '●';
			} else
			{
				passVisible = true;
				textBoxPassword.PasswordChar = '\0';
			}
		}
	}
}
