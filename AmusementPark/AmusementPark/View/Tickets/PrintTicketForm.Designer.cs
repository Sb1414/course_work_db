namespace AmusementPark.View.Tickets
{
	partial class PrintTicketForm
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
			this.labelAllPrice = new System.Windows.Forms.Label();
			this.labelAttractions = new System.Windows.Forms.Label();
			this.labelNameEmployee = new System.Windows.Forms.Label();
			this.labelTicketDate = new System.Windows.Forms.Label();
			this.panelUp = new System.Windows.Forms.Panel();
			this.buttonClose = new System.Windows.Forms.Button();
			this.panelBack.SuspendLayout();
			this.panelUp.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelBack
			// 
			this.panelBack.BackColor = System.Drawing.Color.Transparent;
			this.panelBack.BackgroundImage = global::AmusementPark.Properties.Resources.ticket_print;
			this.panelBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panelBack.Controls.Add(this.labelAllPrice);
			this.panelBack.Controls.Add(this.labelAttractions);
			this.panelBack.Controls.Add(this.labelNameEmployee);
			this.panelBack.Controls.Add(this.labelTicketDate);
			this.panelBack.Controls.Add(this.panelUp);
			this.panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelBack.Location = new System.Drawing.Point(0, 0);
			this.panelBack.Name = "panelBack";
			this.panelBack.Size = new System.Drawing.Size(800, 450);
			this.panelBack.TabIndex = 11;
			// 
			// labelAllPrice
			// 
			this.labelAllPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.labelAllPrice.Location = new System.Drawing.Point(151, 358);
			this.labelAllPrice.Name = "labelAllPrice";
			this.labelAllPrice.Size = new System.Drawing.Size(163, 32);
			this.labelAllPrice.TabIndex = 5;
			// 
			// labelAttractions
			// 
			this.labelAttractions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.labelAttractions.Location = new System.Drawing.Point(89, 168);
			this.labelAttractions.Name = "labelAttractions";
			this.labelAttractions.Size = new System.Drawing.Size(520, 190);
			this.labelAttractions.TabIndex = 4;
			// 
			// labelNameEmployee
			// 
			this.labelNameEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.labelNameEmployee.Location = new System.Drawing.Point(231, 390);
			this.labelNameEmployee.Name = "labelNameEmployee";
			this.labelNameEmployee.Size = new System.Drawing.Size(163, 23);
			this.labelNameEmployee.TabIndex = 3;
			// 
			// labelTicketDate
			// 
			this.labelTicketDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelTicketDate.Location = new System.Drawing.Point(141, 86);
			this.labelTicketDate.Name = "labelTicketDate";
			this.labelTicketDate.Size = new System.Drawing.Size(163, 23);
			this.labelTicketDate.TabIndex = 2;
			// 
			// panelUp
			// 
			this.panelUp.BackColor = System.Drawing.Color.Transparent;
			this.panelUp.Controls.Add(this.buttonClose);
			this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelUp.Location = new System.Drawing.Point(0, 0);
			this.panelUp.Name = "panelUp";
			this.panelUp.Size = new System.Drawing.Size(800, 27);
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
			// PrintTicketForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panelBack);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "PrintTicketForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PrintTicketForm";
			this.panelBack.ResumeLayout(false);
			this.panelUp.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelBack;
		private System.Windows.Forms.Panel panelUp;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Label labelTicketDate;
		private System.Windows.Forms.Label labelNameEmployee;
		private System.Windows.Forms.Label labelAttractions;
		private System.Windows.Forms.Label labelAllPrice;
	}
}