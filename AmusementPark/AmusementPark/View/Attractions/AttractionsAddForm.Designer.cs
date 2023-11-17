namespace AmusementPark.View.Attractions
{
	partial class AttractionsAddForm
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
			this.textBoxTicketPrice = new System.Windows.Forms.TextBox();
			this.textBoxCapacity = new System.Windows.Forms.TextBox();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
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
			this.panelBack.BackgroundImage = global::AmusementPark.Properties.Resources.add_atractions;
			this.panelBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panelBack.Controls.Add(this.textBoxTicketPrice);
			this.panelBack.Controls.Add(this.textBoxCapacity);
			this.panelBack.Controls.Add(this.textBoxDescription);
			this.panelBack.Controls.Add(this.textBoxName);
			this.panelBack.Controls.Add(this.buttonAdd);
			this.panelBack.Controls.Add(this.panelUp);
			this.panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelBack.Location = new System.Drawing.Point(0, 0);
			this.panelBack.Name = "panelBack";
			this.panelBack.Size = new System.Drawing.Size(586, 478);
			this.panelBack.TabIndex = 7;
			// 
			// textBoxTicketPrice
			// 
			this.textBoxTicketPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(186)))), ((int)(((byte)(227)))));
			this.textBoxTicketPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxTicketPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxTicketPrice.Location = new System.Drawing.Point(162, 338);
			this.textBoxTicketPrice.Name = "textBoxTicketPrice";
			this.textBoxTicketPrice.Size = new System.Drawing.Size(260, 23);
			this.textBoxTicketPrice.TabIndex = 10;
			this.textBoxTicketPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTicketPrice_KeyPress);
			// 
			// textBoxCapacity
			// 
			this.textBoxCapacity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(186)))), ((int)(((byte)(227)))));
			this.textBoxCapacity.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxCapacity.Location = new System.Drawing.Point(162, 262);
			this.textBoxCapacity.Name = "textBoxCapacity";
			this.textBoxCapacity.Size = new System.Drawing.Size(260, 23);
			this.textBoxCapacity.TabIndex = 9;
			this.textBoxCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCapacity_KeyPress);
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(186)))), ((int)(((byte)(227)))));
			this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxDescription.Location = new System.Drawing.Point(162, 186);
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.Size = new System.Drawing.Size(260, 23);
			this.textBoxDescription.TabIndex = 8;
			this.textBoxDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDescription_KeyPress);
			// 
			// textBoxName
			// 
			this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(186)))), ((int)(((byte)(227)))));
			this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxName.Location = new System.Drawing.Point(162, 109);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(260, 23);
			this.textBoxName.TabIndex = 7;
			this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
			// 
			// buttonAdd
			// 
			this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
			this.buttonAdd.FlatAppearance.BorderSize = 0;
			this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAdd.Location = new System.Drawing.Point(233, 401);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(122, 27);
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
			this.panelUp.Size = new System.Drawing.Size(586, 27);
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
			// AttractionsAddForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(586, 478);
			this.Controls.Add(this.panelBack);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AttractionsAddForm";
			this.Text = "AttrationsAddForm";
			this.panelBack.ResumeLayout(false);
			this.panelBack.PerformLayout();
			this.panelUp.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelBack;
		private System.Windows.Forms.Panel panelUp;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.TextBox textBoxTicketPrice;
		private System.Windows.Forms.TextBox textBoxCapacity;
		private System.Windows.Forms.TextBox textBoxDescription;
		private System.Windows.Forms.TextBox textBoxName;
	}
}