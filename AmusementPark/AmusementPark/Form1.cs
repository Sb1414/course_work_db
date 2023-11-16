using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace AmusementPark
{
	public partial class Form1 : Form
	{
		string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
		public Form1()
		{
			InitializeComponent();
			LoadUserData();
		}

		private void LoadUserData()
		{
			using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
			{
				connection.Open();

				string query = "SELECT * FROM Employees";

				using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection))
				{
					DataTable dataTable = new DataTable();
					adapter.Fill(dataTable);

					// Assuming you have a DataGridView named dataGridView1 on your form
					dataGridView1.DataSource = dataTable;
				}
			}
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

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string username = textBoxLogin.Text;
			string password = textBoxPassword.Text;

			if (IsValidLogin(username, password))
			{
				MessageBox.Show("Login successful!");
			}
			else
			{
				MessageBox.Show("Invalid login credentials. Please try again.");
			}
		}

		private bool IsValidLogin(string username, string password)
		{
			using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
			{
				try
				{
					connection.Open();
					Console.WriteLine("Connected to PostgreSQL database!");

					string query = "SELECT COUNT(*) FROM UserCredentials WHERE Login = @Username AND Password = @Password";
					using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@Username", username);
						command.Parameters.AddWithValue("@Password", password);

						int count = (int)command.ExecuteScalar();
						return count > 0;
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine($"Error: {ex.Message}");
					return false; // Return false in case of an exception
				}
			}
		}


		private void textBoxLogin_TextChanged(object sender, EventArgs e)
		{
			string currentText = textBoxLogin.Text;
			string filteredText = new string(currentText.Where(c => Char.IsLetterOrDigit(c)).ToArray());

			textBoxLogin.Text = filteredText;
			textBoxLogin.SelectionStart = textBoxLogin.Text.Length;
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			textBoxLogin.Clear();
			textBoxPassword.Clear();
		}
	}
}
