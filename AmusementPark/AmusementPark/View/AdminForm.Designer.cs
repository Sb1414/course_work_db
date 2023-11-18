namespace AmusementPark
{
	partial class AdminForm
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
			this.btnEmployees = new System.Windows.Forms.Button();
			this.btnPositions = new System.Windows.Forms.Button();
			this.btnTickets = new System.Windows.Forms.Button();
			this.btnAttractions = new System.Windows.Forms.Button();
			this.panelUp = new System.Windows.Forms.Panel();
			this.buttonClose = new System.Windows.Forms.Button();
			this.panelBack.SuspendLayout();
			this.panelUp.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelBack
			// 
			this.panelBack.BackColor = System.Drawing.Color.Transparent;
			this.panelBack.BackgroundImage = global::AmusementPark.Properties.Resources.admin_back;
			this.panelBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panelBack.Controls.Add(this.btnEmployees);
			this.panelBack.Controls.Add(this.btnPositions);
			this.panelBack.Controls.Add(this.btnTickets);
			this.panelBack.Controls.Add(this.btnAttractions);
			this.panelBack.Controls.Add(this.panelUp);
			this.panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelBack.Location = new System.Drawing.Point(0, 0);
			this.panelBack.Name = "panelBack";
			this.panelBack.Size = new System.Drawing.Size(957, 593);
			this.panelBack.TabIndex = 6;
			// 
			// btnEmployees
			// 
			this.btnEmployees.BackColor = System.Drawing.Color.Transparent;
			this.btnEmployees.FlatAppearance.BorderSize = 0;
			this.btnEmployees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEmployees.Location = new System.Drawing.Point(143, 191);
			this.btnEmployees.Name = "btnEmployees";
			this.btnEmployees.Size = new System.Drawing.Size(170, 37);
			this.btnEmployees.TabIndex = 7;
			this.btnEmployees.UseVisualStyleBackColor = false;
			this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
			this.btnEmployees.MouseLeave += new System.EventHandler(this.btnAttractions_MouseLeave);
			this.btnEmployees.MouseHover += new System.EventHandler(this.btnEmployees_MouseHover);
			// 
			// btnPositions
			// 
			this.btnPositions.BackColor = System.Drawing.Color.Transparent;
			this.btnPositions.FlatAppearance.BorderSize = 0;
			this.btnPositions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnPositions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnPositions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPositions.Location = new System.Drawing.Point(265, 112);
			this.btnPositions.Name = "btnPositions";
			this.btnPositions.Size = new System.Drawing.Size(170, 37);
			this.btnPositions.TabIndex = 6;
			this.btnPositions.UseVisualStyleBackColor = false;
			this.btnPositions.Click += new System.EventHandler(this.btnPositions_Click);
			this.btnPositions.MouseLeave += new System.EventHandler(this.btnAttractions_MouseLeave);
			this.btnPositions.MouseHover += new System.EventHandler(this.btnPositions_MouseHover);
			// 
			// btnTickets
			// 
			this.btnTickets.BackColor = System.Drawing.Color.Transparent;
			this.btnTickets.FlatAppearance.BorderSize = 0;
			this.btnTickets.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnTickets.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTickets.Location = new System.Drawing.Point(610, 191);
			this.btnTickets.Name = "btnTickets";
			this.btnTickets.Size = new System.Drawing.Size(170, 37);
			this.btnTickets.TabIndex = 5;
			this.btnTickets.UseVisualStyleBackColor = false;
			this.btnTickets.MouseLeave += new System.EventHandler(this.btnAttractions_MouseLeave);
			this.btnTickets.MouseHover += new System.EventHandler(this.btnTickets_MouseHover);
			// 
			// btnAttractions
			// 
			this.btnAttractions.BackColor = System.Drawing.Color.Transparent;
			this.btnAttractions.FlatAppearance.BorderSize = 0;
			this.btnAttractions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnAttractions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnAttractions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAttractions.Location = new System.Drawing.Point(487, 112);
			this.btnAttractions.Name = "btnAttractions";
			this.btnAttractions.Size = new System.Drawing.Size(170, 37);
			this.btnAttractions.TabIndex = 4;
			this.btnAttractions.UseVisualStyleBackColor = false;
			this.btnAttractions.Click += new System.EventHandler(this.btnAttractions_Click);
			this.btnAttractions.MouseLeave += new System.EventHandler(this.btnAttractions_MouseLeave);
			this.btnAttractions.MouseHover += new System.EventHandler(this.btnAttractions_MouseHover);
			// 
			// panelUp
			// 
			this.panelUp.BackColor = System.Drawing.Color.Transparent;
			this.panelUp.Controls.Add(this.buttonClose);
			this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelUp.Location = new System.Drawing.Point(0, 0);
			this.panelUp.Name = "panelUp";
			this.panelUp.Size = new System.Drawing.Size(957, 27);
			this.panelUp.TabIndex = 0;
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
			// AdminForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(957, 593);
			this.Controls.Add(this.panelBack);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AdminForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "adminForm";
			this.panelBack.ResumeLayout(false);
			this.panelUp.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Panel panelUp;
		private System.Windows.Forms.Panel panelBack;
		private System.Windows.Forms.Button btnAttractions;
		private System.Windows.Forms.Button btnTickets;
		private System.Windows.Forms.Button btnPositions;
		private System.Windows.Forms.Button btnEmployees;
	}
}