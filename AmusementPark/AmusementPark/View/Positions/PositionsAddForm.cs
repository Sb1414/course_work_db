using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmusementPark.View.Positions
{
	public partial class PositionsAddForm : Form
	{
		public PositionsAddForm()
		{
			InitializeComponent();
			buttonAdd.DialogResult = DialogResult.OK;

			this.AcceptButton = buttonAdd;
		}
		public PositionsAddForm(string Position, int Salary, int Count)
		{
			InitializeComponent();
			buttonAdd.DialogResult = DialogResult.OK;

			textBoxPosition.Text = Position;
			textBoxSalary.Text = Salary.ToString();
			textBoxCount.Text = Count.ToString();

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

		public string Position
		{
			get
			{
				return textBoxPosition.Text;
			}
		}

		public int Salary
		{
			get
			{
				return Convert.ToInt32(textBoxCount.Text);
			}
		}

		public int Count
		{
			get
			{
				return Convert.ToInt32(textBoxCount.Text);
			}
		}

		private void textBoxPosition_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
		}

		private void textBoxSalary_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
			{
				e.Handled = true;
			}
		}

		private void textBoxCount_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
			{
				e.Handled = true;
			}
		}
	}
}
