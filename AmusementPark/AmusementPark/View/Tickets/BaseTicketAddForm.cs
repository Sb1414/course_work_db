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
	public partial class BaseTicketAddForm : Form
	{
		private Dictionary<int, string> attractionDictionary = new Dictionary<int, string>();
		private List<int> selectedAttractionIds = new List<int>();
		string connectionString;
		bool todayDate = true;
		public BaseTicketAddForm(string connectionString)
		{
			this.connectionString = connectionString;
			InitializeComponent();
			FillAttractionDictionary();

			dateTicket.Value = DateTime.Today;
			dateTicket.Enabled = false;

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

		public List<int> AttractionsId
		{
			get
			{
				return selectedAttractionIds;
			}
		}

		void FillAttractionDictionary()
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
							int attractionId = reader.GetInt32(0);
							string attractionName = reader.GetString(1);
							attractionDictionary.Add(attractionId, attractionName);
						}
					}
				}
			}

			checkedListBoxAttractions.Items.Clear();

			foreach (var attraction in attractionDictionary)
			{
				checkedListBoxAttractions.Items.Add(attraction.Value, false);
			}
		}

		private void CheckedListBoxAttractions_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			int attractionId = attractionDictionary.ElementAt(e.Index).Key;

			if (e.NewValue == CheckState.Checked)
			{
				selectedAttractionIds.Add(attractionId);
			}
			else if (e.NewValue == CheckState.Unchecked)
			{
				selectedAttractionIds.Remove(attractionId);
			}
		}

		private void checkBoxEditDate_CheckedChanged(object sender, EventArgs e)
		{
			if (todayDate)
			{
				dateTicket.Enabled = true;
				todayDate = false;
			}
			else
			{
				dateTicket.Enabled = false;
				todayDate = true;
				dateTicket.Value = DateTime.Today;
			}
		}
	}
}
