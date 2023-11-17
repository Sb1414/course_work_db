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

namespace AmusementPark.View.Attractions
{
	public partial class AttractionsAddForm : Form
	{
		public AttractionsAddForm()
		{
			InitializeComponent();
			buttonAdd.DialogResult = DialogResult.OK;

			this.AcceptButton = buttonAdd;
		}
		public AttractionsAddForm(string Name, string Description, int Capacity, int TicketPrice)
		{
			InitializeComponent();
			buttonAdd.DialogResult = DialogResult.OK;

			textBoxName.Text = Name;
			textBoxDescription.Text = Description;
			textBoxCapacity.Text = Capacity.ToString();
			textBoxTicketPrice.Text = TicketPrice.ToString();

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

		public string AttractionsName
		{
			get
			{
				return textBoxName.Text;
			}
		}

		public string AttractionsDescription
		{
			get
			{
				return textBoxDescription.Text;
			}
		}

		public int AttractionsCapacity
		{
			get
			{
				return Convert.ToInt32(textBoxCapacity.Text);
			}
		}

		public int AttractionsTicketPrice
		{
			get
			{
				return Convert.ToInt32(textBoxTicketPrice.Text);
			}
		}

		private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
		}

		private void textBoxDescription_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back || textBoxDescription.TextLength >= 200)
			{
				e.Handled = true;
			}
		}

		private void textBoxCapacity_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
			{
				e.Handled = true;
			}
		}

		private void textBoxTicketPrice_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
			{
				e.Handled = true;
			}
		}
	}
}
