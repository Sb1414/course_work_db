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
				string query = "SELECT TicketSales.TicketId, P.Position, CONCAT(E.LastName, ' ', E.FirstName, ' ', E.MiddleName) AS Employee, SaleTime FROM TicketSales " +
								"JOIN Employees E on E.Id = TicketSales.EmployeeId " +
								"JOIN Tickets T on T.Id = TicketSales.TicketId " +
								"JOIN Positions P on P.Id = E.PositionID WHERE E.PositionID > 3";

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
			dataGridViewTickets.Columns["SaleTime"].HeaderText = "Время продажи";
		}

		private void NamesAttractionsColumns()
		{
			dataGridViewAttractions.Width = 200;
			dataGridViewAttractions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewAttractions.Columns["Name"].HeaderText = "Название";
		}

		private void dataGridViewTickets_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex >= 0 && e.RowIndex < dataGridViewTickets.Rows.Count)
				{
					int id = Convert.ToInt32(dataGridViewTickets.Rows[e.RowIndex].Cells["TicketId"].Value);

					string query = @"SELECT A.Name
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

				string query = $@"SELECT TicketSales.TicketId, P.Position, 
										CONCAT(E.LastName, ' ', E.FirstName, ' ', E.MiddleName) AS Employee, 
										SaleTime FROM TicketSales
										JOIN Employees E on E.Id = TicketSales.EmployeeId 
										JOIN Tickets T on T.Id = TicketSales.TicketId
										JOIN Positions P on P.Id = E.PositionID 
												 WHERE E.PositionID > 3
									AND {field} ILIKE @searchText";

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
	}
}
