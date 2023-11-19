using AmusementPark.View;
using AmusementPark.View.Employees;
using AmusementPark.View.Positions;
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

namespace AmusementPark
{
	public partial class AdminForm : Form
	{
		string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
		public AdminForm()
		{
			InitializeComponent();
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			DialogResult res = MessageBox.Show("Действительно выйти из учетной записи?", "Предупреждение", MessageBoxButtons.OKCancel);
			if (res == DialogResult.OK)
			{
				this.Close();
			}
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

		private void btnAttractions_MouseHover(object sender, EventArgs e)
		{
			panelBack.BackgroundImage = Properties.Resources.admin_attraction;
		}

		private void btnAttractions_MouseLeave(object sender, EventArgs e)
		{
			panelBack.BackgroundImage = Properties.Resources.admin_back;
		}

		private void btnTickets_MouseHover(object sender, EventArgs e)
		{
			panelBack.BackgroundImage = Properties.Resources.admin_tickets;
		}

		private void btnPositions_MouseHover(object sender, EventArgs e)
		{
			panelBack.BackgroundImage = Properties.Resources.admin_position;
		}

		private void btnEmployees_MouseHover(object sender, EventArgs e)
		{
			panelBack.BackgroundImage = Properties.Resources.admin_employees;
		}

		private void btnAttractions_Click(object sender, EventArgs e)
		{
			AttractionsForm attractions = new AttractionsForm(connectionString);
			attractions.Show();
		}

		private void btnPositions_Click(object sender, EventArgs e)
		{
			PositionsForm positions = new PositionsForm(connectionString);
			positions.Show();
		}

		private void btnEmployees_Click(object sender, EventArgs e)
		{
			EmployeesForm employees = new EmployeesForm(connectionString);
			employees.Show();
		}

		private void btnTickets_Click(object sender, EventArgs e)
		{
			TicketsForm tickets = new TicketsForm(connectionString);
			tickets.Show();
		}
	}
}
