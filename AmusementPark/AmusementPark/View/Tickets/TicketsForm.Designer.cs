namespace AmusementPark.View
{
	partial class TicketsForm
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
			this.comboBoxColumns = new System.Windows.Forms.ComboBox();
			this.panelForTable = new System.Windows.Forms.Panel();
			this.dataGridViewAttractions = new System.Windows.Forms.DataGridView();
			this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.btnInsert = new System.Windows.Forms.ToolStripMenuItem();
			this.btnUpdate = new System.Windows.Forms.ToolStripMenuItem();
			this.btnEditTicket = new System.Windows.Forms.ToolStripMenuItem();
			this.btnEditAttraction = new System.Windows.Forms.ToolStripMenuItem();
			this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.addAttraction = new System.Windows.Forms.ToolStripMenuItem();
			this.sort = new System.Windows.Forms.ToolStripMenuItem();
			this.btnSortOnName = new System.Windows.Forms.ToolStripMenuItem();
			this.btnSortOnPrice = new System.Windows.Forms.ToolStripMenuItem();
			this.btnSortOnCapacity = new System.Windows.Forms.ToolStripMenuItem();
			this.panelUp = new System.Windows.Forms.Panel();
			this.buttonClose = new System.Windows.Forms.Button();
			this.btnRemoveTicket = new System.Windows.Forms.ToolStripMenuItem();
			this.btnRemoveAttr = new System.Windows.Forms.ToolStripMenuItem();
			this.labelSum = new System.Windows.Forms.ToolStripMenuItem();
			this.panelBack.SuspendLayout();
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
			this.panelBack.BackgroundImage = global::AmusementPark.Properties.Resources.tickets;
			this.panelBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panelBack.Controls.Add(this.comboBoxColumns);
			this.panelBack.Controls.Add(this.panelForTable);
			this.panelBack.Controls.Add(this.textBoxSearch);
			this.panelBack.Controls.Add(this.menuStrip1);
			this.panelBack.Controls.Add(this.panelUp);
			this.panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelBack.Location = new System.Drawing.Point(0, 0);
			this.panelBack.Name = "panelBack";
			this.panelBack.Size = new System.Drawing.Size(955, 609);
			this.panelBack.TabIndex = 8;
			// 
			// comboBoxColumns
			// 
			this.comboBoxColumns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
			this.comboBoxColumns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBoxColumns.FormattingEnabled = true;
			this.comboBoxColumns.Location = new System.Drawing.Point(176, 513);
			this.comboBoxColumns.Name = "comboBoxColumns";
			this.comboBoxColumns.Size = new System.Drawing.Size(210, 24);
			this.comboBoxColumns.TabIndex = 12;
			// 
			// panelForTable
			// 
			this.panelForTable.Controls.Add(this.dataGridViewAttractions);
			this.panelForTable.Controls.Add(this.dataGridViewTickets);
			this.panelForTable.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelForTable.Location = new System.Drawing.Point(0, 55);
			this.panelForTable.Name = "panelForTable";
			this.panelForTable.Size = new System.Drawing.Size(955, 441);
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
			this.dataGridViewAttractions.Size = new System.Drawing.Size(407, 441);
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
			// textBoxSearch
			// 
			this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
			this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxSearch.Location = new System.Drawing.Point(412, 513);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(481, 20);
			this.textBoxSearch.TabIndex = 11;
			this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInsert,
            this.btnUpdate,
            this.btnDelete,
            this.addAttraction,
            this.sort,
            this.labelSum});
			this.menuStrip1.Location = new System.Drawing.Point(0, 27);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(955, 28);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// btnInsert
			// 
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(122, 24);
			this.btnInsert.Text = "Создать билет";
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditTicket,
            this.btnEditAttraction});
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(92, 24);
			this.btnUpdate.Text = "Изменить";
			// 
			// btnEditTicket
			// 
			this.btnEditTicket.Name = "btnEditTicket";
			this.btnEditTicket.Size = new System.Drawing.Size(224, 26);
			this.btnEditTicket.Text = "Данные о билете";
			this.btnEditTicket.Click += new System.EventHandler(this.btnEditTicket_Click);
			// 
			// btnEditAttraction
			// 
			this.btnEditAttraction.Name = "btnEditAttraction";
			this.btnEditAttraction.Size = new System.Drawing.Size(224, 26);
			this.btnEditAttraction.Text = "Аттракцион";
			this.btnEditAttraction.Click += new System.EventHandler(this.btnEditAttraction_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRemoveTicket,
            this.btnRemoveAttr});
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(79, 24);
			this.btnDelete.Text = "Удалить";
			// 
			// addAttraction
			// 
			this.addAttraction.Name = "addAttraction";
			this.addAttraction.Size = new System.Drawing.Size(230, 24);
			this.addAttraction.Text = "Добавить аттракцион в билет";
			this.addAttraction.Click += new System.EventHandler(this.addAttraction_Click);
			// 
			// sort
			// 
			this.sort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSortOnName,
            this.btnSortOnPrice,
            this.btnSortOnCapacity});
			this.sort.Name = "sort";
			this.sort.Size = new System.Drawing.Size(106, 24);
			this.sort.Text = "Сортировка";
			// 
			// btnSortOnName
			// 
			this.btnSortOnName.Name = "btnSortOnName";
			this.btnSortOnName.Size = new System.Drawing.Size(193, 26);
			this.btnSortOnName.Text = "По должности";
			// 
			// btnSortOnPrice
			// 
			this.btnSortOnPrice.Name = "btnSortOnPrice";
			this.btnSortOnPrice.Size = new System.Drawing.Size(193, 26);
			this.btnSortOnPrice.Text = "По зарплате";
			// 
			// btnSortOnCapacity
			// 
			this.btnSortOnCapacity.Name = "btnSortOnCapacity";
			this.btnSortOnCapacity.Size = new System.Drawing.Size(193, 26);
			this.btnSortOnCapacity.Text = "По количеству";
			// 
			// panelUp
			// 
			this.panelUp.BackColor = System.Drawing.Color.Transparent;
			this.panelUp.Controls.Add(this.buttonClose);
			this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelUp.Location = new System.Drawing.Point(0, 0);
			this.panelUp.Name = "panelUp";
			this.panelUp.Size = new System.Drawing.Size(955, 27);
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
			// labelSum
			// 
			this.labelSum.Enabled = false;
			this.labelSum.Name = "labelSum";
			this.labelSum.Size = new System.Drawing.Size(199, 24);
			this.labelSum.Text = "Сумма по всем билетам: ";
			// 
			// TicketsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(955, 609);
			this.Controls.Add(this.panelBack);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "TicketsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TicketsForm";
			this.panelBack.ResumeLayout(false);
			this.panelBack.PerformLayout();
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
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem btnInsert;
		private System.Windows.Forms.ToolStripMenuItem btnUpdate;
		private System.Windows.Forms.ToolStripMenuItem btnDelete;
		private System.Windows.Forms.ToolStripMenuItem sort;
		private System.Windows.Forms.ToolStripMenuItem btnSortOnName;
		private System.Windows.Forms.ToolStripMenuItem btnSortOnPrice;
		private System.Windows.Forms.ToolStripMenuItem btnSortOnCapacity;
		private System.Windows.Forms.Panel panelUp;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Panel panelForTable;
		private System.Windows.Forms.DataGridView dataGridViewAttractions;
		private System.Windows.Forms.DataGridView dataGridViewTickets;
		private System.Windows.Forms.ComboBox comboBoxColumns;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.ToolStripMenuItem addAttraction;
		private System.Windows.Forms.ToolStripMenuItem btnEditTicket;
		private System.Windows.Forms.ToolStripMenuItem btnEditAttraction;
		private System.Windows.Forms.ToolStripMenuItem btnRemoveTicket;
		private System.Windows.Forms.ToolStripMenuItem btnRemoveAttr;
		private System.Windows.Forms.ToolStripMenuItem labelSum;
	}
}