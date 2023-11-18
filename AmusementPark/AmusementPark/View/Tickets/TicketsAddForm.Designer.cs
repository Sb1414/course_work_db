namespace AmusementPark.View.Tickets
{
	partial class TicketsAddForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panelBack = new System.Windows.Forms.Panel();
			this.comboBoxAttractions = new System.Windows.Forms.ComboBox();
			this.comboBoxEmployees = new System.Windows.Forms.ComboBox();
			this.checkBoxEditDate = new System.Windows.Forms.CheckBox();
			this.dateTicket = new System.Windows.Forms.DateTimePicker();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.panelUp = new System.Windows.Forms.Panel();
			this.buttonClose = new System.Windows.Forms.Button();
			this.panelBack.SuspendLayout();
			this.panelUp.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelBack
			// 
			this.panelBack.BackColor = System.Drawing.Color.Transparent;
			this.panelBack.BackgroundImage = global::AmusementPark.Properties.Resources.add_tickets_form;
			this.panelBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panelBack.Controls.Add(this.comboBoxAttractions);
			this.panelBack.Controls.Add(this.comboBoxEmployees);
			this.panelBack.Controls.Add(this.checkBoxEditDate);
			this.panelBack.Controls.Add(this.dateTicket);
			this.panelBack.Controls.Add(this.buttonAdd);
			this.panelBack.Controls.Add(this.panelUp);
			this.panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelBack.Location = new System.Drawing.Point(0, 0);
			this.panelBack.Name = "panelBack";
			this.panelBack.Size = new System.Drawing.Size(571, 496);
			this.panelBack.TabIndex = 9;
			// 
			// comboBoxAttractions
			// 
			this.comboBoxAttractions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
			this.comboBoxAttractions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxAttractions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBoxAttractions.FormattingEnabled = true;
			this.comboBoxAttractions.Location = new System.Drawing.Point(115, 329);
			this.comboBoxAttractions.Name = "comboBoxAttractions";
			this.comboBoxAttractions.Size = new System.Drawing.Size(331, 24);
			this.comboBoxAttractions.TabIndex = 3;
			// 
			// comboBoxEmployees
			// 
			this.comboBoxEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
			this.comboBoxEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBoxEmployees.FormattingEnabled = true;
			this.comboBoxEmployees.Location = new System.Drawing.Point(115, 122);
			this.comboBoxEmployees.Name = "comboBoxEmployees";
			this.comboBoxEmployees.Size = new System.Drawing.Size(331, 24);
			this.comboBoxEmployees.TabIndex = 1;
			// 
			// checkBoxEditDate
			// 
			this.checkBoxEditDate.AutoSize = true;
			this.checkBoxEditDate.Location = new System.Drawing.Point(133, 256);
			this.checkBoxEditDate.Name = "checkBoxEditDate";
			this.checkBoxEditDate.Size = new System.Drawing.Size(18, 17);
			this.checkBoxEditDate.TabIndex = 11;
			this.checkBoxEditDate.UseVisualStyleBackColor = true;
			this.checkBoxEditDate.CheckedChanged += new System.EventHandler(this.checkBoxEditDate_CheckedChanged);
			// 
			// dateTicket
			// 
			this.dateTicket.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTicket.Location = new System.Drawing.Point(115, 216);
			this.dateTicket.Name = "dateTicket";
			this.dateTicket.Size = new System.Drawing.Size(331, 22);
			this.dateTicket.TabIndex = 2;
			// 
			// buttonAdd
			// 
			this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
			this.buttonAdd.FlatAppearance.BorderSize = 0;
			this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAdd.Location = new System.Drawing.Point(223, 392);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(115, 27);
			this.buttonAdd.TabIndex = 6;
			this.buttonAdd.UseVisualStyleBackColor = false;
			// 
			// panelUp
			// 
			this.panelUp.BackColor = System.Drawing.Color.Transparent;
			this.panelUp.Controls.Add(this.buttonClose);
			this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelUp.Location = new System.Drawing.Point(0, 0);
			this.panelUp.Name = "panelUp";
			this.panelUp.Size = new System.Drawing.Size(571, 27);
			this.panelUp.TabIndex = 1;
			this.panelUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelUp_MouseDown);
			this.panelUp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelUp_MouseMove);
			// 
			// buttonClose
			// 
			this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonClose.Dock = System.Windows.Forms.DockStyle.Left;
			this.buttonClose.FlatAppearance.BorderSize = 0;
			this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonClose.Image = global::AmusementPark.Properties.Resources.icons8_macos_закрыть_20__1_;
			this.buttonClose.Location = new System.Drawing.Point(0, 0);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(27, 27);
			this.buttonClose.TabIndex = 0;
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// TicketsAddForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(571, 496);
			this.Controls.Add(this.panelBack);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "TicketsAddForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TicketsAddForm";
			this.panelBack.ResumeLayout(false);
			this.panelBack.PerformLayout();
			this.panelUp.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelBack;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Panel panelUp;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.CheckBox checkBoxEditDate;
		private System.Windows.Forms.DateTimePicker dateTicket;
		private System.Windows.Forms.ComboBox comboBoxEmployees;
		private System.Windows.Forms.ComboBox comboBoxAttractions;
	}
}