using System;
using System.Collections.Generic;
using System.ComponentModel;
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
		public AdminForm()
		{
			InitializeComponent();
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
	}
}
