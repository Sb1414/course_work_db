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

namespace AmusementPark.View.Tickets
{
	public partial class PrintTicketForm : Form
	{
		string connectionString;
		int id;
		public PrintTicketForm(string connectionString, int id)
		{
			this.connectionString = connectionString;
			this.id = id;
			InitializeComponent();
			LoadTicketDate();
			LoadTicketEmployee();
			LoadTicketAttractions();
			LoadTicketAllPrice();
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

		private void LoadTicketDate()
		{
			try
			{
				using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
				{
					connection.Open();

					string query = @"SELECT PurchaseDate FROM Tickets WHERE Id = @id";

					using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@id", id);
						using (NpgsqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
								DateTime purchaseDate = reader.GetDateTime(0);
								labelTicketDate.Text = $"{purchaseDate.ToString("yyyy-MM-dd")}";
							}
						}

					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error: {ex.Message}");
			}
		}

		private void LoadTicketEmployee()
		{
			try
			{
				using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
				{
					connection.Open();

					string query = @"SELECT CONCAT(E.LastName, ' ', LEFT(E.FirstName, 1), '. ', LEFT(E.MiddleName, 1), '.') FROM Tickets
									JOIN Employees E on E.Id = Tickets.EmployeeId WHERE Tickets.Id = @id";

					using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@id", id);
						using (NpgsqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
								labelNameEmployee.Text = reader.GetString(0);
							}
						}

					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error: {ex.Message}");
			}
		}

		private void LoadTicketAttractions()
		{
			try
			{
				using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
				{
					connection.Open();

					string query = @"SELECT A.Name, A.TicketPrice FROM Tickets
									 JOIN TicketAttractions TA on Tickets.Id = TA.TicketId
									 JOIN Attractions A on A.id = TA.AttractionID WHERE Tickets.Id = @id";

					using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@id", id);
						using (NpgsqlDataReader reader = command.ExecuteReader())
						{
							while (reader.Read())
							{
								string attractionName = reader.GetString(0);
								int attractionPrice = reader.GetInt32(1);
								labelAttractions.Text += $"{attractionName}: {attractionPrice} руб.\n";
							}
						}

					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error: {ex.Message}");
			}
		}

		private void LoadTicketAllPrice()
		{
			try
			{
				using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
				{
					connection.Open();

					string query = @"SELECT SUM(COALESCE(A.TicketPrice, 0)) AS TotalAttractionCost FROM Tickets T
											 LEFT JOIN TicketAttractions TA ON TA.TicketId = T.Id
											 LEFT JOIN Attractions A ON A.Id = TA.AttractionID
									WHERE T.Id = @id";

					using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@id", id);
						using (NpgsqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
								labelAllPrice.Text = reader.GetInt32(0).ToString() + " руб.";
							}
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
