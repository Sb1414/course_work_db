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
	public partial class TicketsAddForm : Form
	{
		string connectionString;
		Dictionary<int, string> attractions = new Dictionary<int, string>();
		Dictionary<int, string> employees = new Dictionary<int, string>();
		bool todayDate = true;

		public TicketsAddForm(string connectionString)
		{
			this.connectionString = connectionString;
			InitializeComponent();
			FillComboBoxEmployees();
			FillComboBoxAttractions();
			dateTicket.Value = DateTime.Today;
			dateTicket.Enabled = false;

			buttonAdd.DialogResult = DialogResult.OK;

			this.AcceptButton = buttonAdd;
		}
		public TicketsAddForm(string connectionString, Tuple<int, int> result, DateTime date, bool check)
		{
			this.connectionString = connectionString;
			InitializeComponent();
			FillComboBoxEmployees();
			FillComboBoxAttractions();
			if (!check)
			{
				checkBoxEditDate.Enabled = false;
				dateTicket.Enabled = false;
			}

			int idEmployees = result.Item1;
			comboBoxEmployees.SelectedItem = new KeyValuePair<int, string>(idEmployees, employees[idEmployees]);
			dateTicket.Value = date;
			int idAttractions = result.Item2;
			comboBoxAttractions.SelectedItem = new KeyValuePair<int, string>(idAttractions, attractions[idAttractions]);

			buttonAdd.DialogResult = DialogResult.OK;

			this.AcceptButton = buttonAdd;
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

		public DateTime PurchaseDate
		{
			get
			{
				return dateTicket.Value;
			}
		}

		public int EmployeeId
		{
			get
			{
				if (comboBoxEmployees.SelectedItem != null)
				{
					return (int)comboBoxEmployees.SelectedValue;
				}
				return -1;
			}
		}
		public int AttractionId
		{
			get
			{
				if (comboBoxAttractions.SelectedItem != null)
				{
					return (int)comboBoxAttractions.SelectedValue;
				}
				return -1;
			}
		}

		private void FillComboBoxEmployees()
		{
			using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
			{
				connection.Open();

				string query = "SELECT id, CONCAT(LastName, ' ', FirstName, ' ', MiddleName) AS Employee FROM Employees";
				using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
				{
					using (NpgsqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							int id = reader.GetInt32(0);
							string employee = reader.GetString(1);
							employees.Add(id, employee);
						}
					}
				}
			}

			comboBoxEmployees.DataSource = new BindingSource(employees, null);
			comboBoxEmployees.DisplayMember = "Value";
			comboBoxEmployees.ValueMember = "Key";
			comboBoxEmployees.DropDownStyle = ComboBoxStyle.DropDownList;
		}

		private void FillComboBoxAttractions()
		{
			using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
			{
				connection.Open();

				string query = "SELECT id, Name FROM Attractions";
				using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
				{
					using (NpgsqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							int id = reader.GetInt32(0);
							string name = reader.GetString(1);
							attractions.Add(id, name);
						}
					}
				}
			}

			comboBoxAttractions.DataSource = new BindingSource(attractions, null);
			comboBoxAttractions.DisplayMember = "Value";
			comboBoxAttractions.ValueMember = "Key";
			comboBoxAttractions.DropDownStyle = ComboBoxStyle.DropDownList;
		}

		private void checkBoxEditDate_CheckedChanged(object sender, EventArgs e)
		{
			if (todayDate)
			{
				dateTicket.Enabled = true;
				todayDate = false;
			} else
			{
				dateTicket.Enabled = false;
				todayDate = true;
				dateTicket.Value = DateTime.Today;
			}
		}
	}
}
