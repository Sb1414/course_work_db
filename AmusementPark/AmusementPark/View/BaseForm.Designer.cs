namespace AmusementPark
{
	partial class BaseForm
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.panelForTable = new System.Windows.Forms.Panel();
			this.dataGridViewAttractions = new System.Windows.Forms.DataGridView();
			this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.btnInsert = new System.Windows.Forms.ToolStripMenuItem();
			this.btnUpdate = new System.Windows.Forms.ToolStripMenuItem();
			this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.btnRemoveTicket = new System.Windows.Forms.ToolStripMenuItem();
			this.btnRemoveAttr = new System.Windows.Forms.ToolStripMenuItem();
			this.printTicket = new System.Windows.Forms.ToolStripMenuItem();
			this.labelSum = new System.Windows.Forms.ToolStripMenuItem();
			this.btnEmployees = new System.Windows.Forms.Button();
			this.btnPositions = new System.Windows.Forms.Button();
			this.btnTickets = new System.Windows.Forms.Button();
			this.btnAttractions = new System.Windows.Forms.Button();
			this.panelUp = new System.Windows.Forms.Panel();
			this.labelUsername = new System.Windows.Forms.Label();
			this.buttonClose = new System.Windows.Forms.Button();
			this.panelBack.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panelForTable.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttractions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.panelUp.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelBack
			// 
			this.panelBack.BackColor = System.Drawing.Color.Transparent;
			this.panelBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panelBack.Controls.Add(this.panel2);
			this.panelBack.Controls.Add(this.btnEmployees);
			this.panelBack.Controls.Add(this.btnPositions);
			this.panelBack.Controls.Add(this.btnTickets);
			this.panelBack.Controls.Add(this.btnAttractions);
			this.panelBack.Controls.Add(this.panelUp);
			this.panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelBack.Location = new System.Drawing.Point(0, 0);
			this.panelBack.Name = "panelBack";
			this.panelBack.Size = new System.Drawing.Size(969, 652);
			this.panelBack.TabIndex = 7;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Transparent;
			this.panel2.BackgroundImage = global::AmusementPark.Properties.Resources._base;
			this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel2.Controls.Add(this.panelForTable);
			this.panel2.Controls.Add(this.menuStrip1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 27);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(969, 625);
			this.panel2.TabIndex = 9;
			// 
			// panelForTable
			// 
			this.panelForTable.Controls.Add(this.dataGridViewAttractions);
			this.panelForTable.Controls.Add(this.dataGridViewTickets);
			this.panelForTable.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelForTable.Location = new System.Drawing.Point(0, 30);
			this.panelForTable.Name = "panelForTable";
			this.panelForTable.Size = new System.Drawing.Size(969, 441);
			this.panelForTable.TabIndex = 7;
			// 
			// dataGridViewAttractions
			// 
			this.dataGridViewAttractions.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dataGridViewAttractions.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridViewAttractions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAttractions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewAttractions.Location = new System.Drawing.Point(548, 0);
			this.dataGridViewAttractions.Name = "dataGridViewAttractions";
			this.dataGridViewAttractions.RowHeadersWidth = 51;
			this.dataGridViewAttractions.RowTemplate.Height = 24;
			this.dataGridViewAttractions.Size = new System.Drawing.Size(421, 441);
			this.dataGridViewAttractions.TabIndex = 6;
			// 
			// dataGridViewTickets
			// 
			this.dataGridViewTickets.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dataGridViewTickets.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTickets.Dock = System.Windows.Forms.DockStyle.Left;
			this.dataGridViewTickets.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewTickets.Name = "dataGridViewTickets";
			this.dataGridViewTickets.RowHeadersWidth = 51;
			this.dataGridViewTickets.RowTemplate.Height = 24;
			this.dataGridViewTickets.Size = new System.Drawing.Size(548, 441);
			this.dataGridViewTickets.TabIndex = 5;
			this.dataGridViewTickets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTickets_CellClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInsert,
            this.btnUpdate,
            this.btnDelete,
            this.printTicket,
            this.labelSum});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(969, 30);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// btnInsert
			// 
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(122, 26);
			this.btnInsert.Text = "Создать билет";
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(149, 26);
			this.btnUpdate.Text = "Изменить данные";
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRemoveTicket,
            this.btnRemoveAttr});
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(79, 26);
			this.btnDelete.Text = "Удалить";
			// 
			// btnRemoveTicket
			// 
			this.btnRemoveTicket.Name = "btnRemoveTicket";
			this.btnRemoveTicket.Size = new System.Drawing.Size(246, 26);
			this.btnRemoveTicket.Text = "Билет";
			this.btnRemoveTicket.Click += new System.EventHandler(this.btnRemoveTicket_Click);
			// 
			// btnRemoveAttr
			// 
			this.btnRemoveAttr.Name = "btnRemoveAttr";
			this.btnRemoveAttr.Size = new System.Drawing.Size(246, 26);
			this.btnRemoveAttr.Text = "Аттракцион из билета";
			this.btnRemoveAttr.Click += new System.EventHandler(this.btnRemoveAttr_Click);
			// 
			// printTicket
			// 
			this.printTicket.Name = "printTicket";
			this.printTicket.Size = new System.Drawing.Size(151, 26);
			this.printTicket.Text = "Распечатать билет";
			this.printTicket.Click += new System.EventHandler(this.printTicket_Click);
			// 
			// labelSum
			// 
			this.labelSum.Enabled = false;
			this.labelSum.Name = "labelSum";
			this.labelSum.Size = new System.Drawing.Size(199, 26);
			this.labelSum.Text = "Сумма по всем билетам: ";
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
			// 
			// panelUp
			// 
			this.panelUp.BackColor = System.Drawing.Color.Transparent;
			this.panelUp.Controls.Add(this.labelUsername);
			this.panelUp.Controls.Add(this.buttonClose);
			this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelUp.Location = new System.Drawing.Point(0, 0);
			this.panelUp.Name = "panelUp";
			this.panelUp.Size = new System.Drawing.Size(969, 27);
			this.panelUp.TabIndex = 0;
			this.panelUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelUp_MouseDown);
			this.panelUp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelUp_MouseMove);
			// 
			// labelUsername
			// 
			this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelUsername.Location = new System.Drawing.Point(92, 0);
			this.labelUsername.Name = "labelUsername";
			this.labelUsername.Size = new System.Drawing.Size(791, 24);
			this.labelUsername.TabIndex = 1;
			this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelUsername.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelUp_MouseDown);
			this.labelUsername.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelUp_MouseMove);
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
			// BaseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(969, 652);
			this.Controls.Add(this.panelBack);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "BaseForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "baseForm";
			this.panelBack.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panelForTable.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttractions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panelUp.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelBack;
		private System.Windows.Forms.Button btnEmployees;
		private System.Windows.Forms.Button btnPositions;
		private System.Windows.Forms.Button btnTickets;
		private System.Windows.Forms.Button btnAttractions;
		private System.Windows.Forms.Panel panelUp;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panelForTable;
		private System.Windows.Forms.DataGridView dataGridViewAttractions;
		private System.Windows.Forms.DataGridView dataGridViewTickets;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem btnInsert;
		private System.Windows.Forms.ToolStripMenuItem btnUpdate;
		private System.Windows.Forms.ToolStripMenuItem btnDelete;
		private System.Windows.Forms.ToolStripMenuItem btnRemoveAttr;
		private System.Windows.Forms.ToolStripMenuItem labelSum;
		private System.Windows.Forms.Label labelUsername;
		private System.Windows.Forms.ToolStripMenuItem btnRemoveTicket;
		private System.Windows.Forms.ToolStripMenuItem printTicket;
	}
}