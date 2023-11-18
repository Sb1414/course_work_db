namespace AmusementPark.View.Employees
{
	partial class EmployeesForm
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
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.btnInsert = new System.Windows.Forms.ToolStripMenuItem();
			this.btnUpdate = new System.Windows.Forms.ToolStripMenuItem();
			this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.sort = new System.Windows.Forms.ToolStripMenuItem();
			this.btnSortOnName = new System.Windows.Forms.ToolStripMenuItem();
			this.btnSortOnPrice = new System.Windows.Forms.ToolStripMenuItem();
			this.btnSortOnCapacity = new System.Windows.Forms.ToolStripMenuItem();
			this.panelUp = new System.Windows.Forms.Panel();
			this.buttonClose = new System.Windows.Forms.Button();
			this.panelBack.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.panelUp.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelBack
			// 
			this.panelBack.BackColor = System.Drawing.Color.Transparent;
			this.panelBack.BackgroundImage = global::AmusementPark.Properties.Resources.employees;
			this.panelBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panelBack.Controls.Add(this.comboBoxColumns);
			this.panelBack.Controls.Add(this.textBoxSearch);
			this.panelBack.Controls.Add(this.dataGridViewEmployees);
			this.panelBack.Controls.Add(this.menuStrip1);
			this.panelBack.Controls.Add(this.panelUp);
			this.panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelBack.Location = new System.Drawing.Point(0, 0);
			this.panelBack.Name = "panelBack";
			this.panelBack.Size = new System.Drawing.Size(995, 559);
			this.panelBack.TabIndex = 7;
			// 
			// comboBoxColumns
			// 
			this.comboBoxColumns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
			this.comboBoxColumns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBoxColumns.FormattingEnabled = true;
			this.comboBoxColumns.Location = new System.Drawing.Point(151, 431);
			this.comboBoxColumns.Name = "comboBoxColumns";
			this.comboBoxColumns.Size = new System.Drawing.Size(210, 24);
			this.comboBoxColumns.TabIndex = 10;
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
			this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxSearch.Location = new System.Drawing.Point(382, 431);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(430, 20);
			this.textBoxSearch.TabIndex = 9;
			this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
			// 
			// dataGridViewEmployees
			// 
			this.dataGridViewEmployees.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dataGridViewEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewEmployees.Dock = System.Windows.Forms.DockStyle.Top;
			this.dataGridViewEmployees.Location = new System.Drawing.Point(0, 55);
			this.dataGridViewEmployees.Name = "dataGridViewEmployees";
			this.dataGridViewEmployees.RowHeadersWidth = 51;
			this.dataGridViewEmployees.RowTemplate.Height = 24;
			this.dataGridViewEmployees.Size = new System.Drawing.Size(995, 316);
			this.dataGridViewEmployees.TabIndex = 7;
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInsert,
            this.btnUpdate,
            this.btnDelete,
            this.sort});
			this.menuStrip1.Location = new System.Drawing.Point(0, 27);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(995, 28);
			this.menuStrip1.TabIndex = 8;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// btnInsert
			// 
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(173, 24);
			this.btnInsert.Text = "Добавить сотрудника";
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(232, 24);
			this.btnUpdate.Text = "Изменить данные сотрудника";
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(162, 24);
			this.btnDelete.Text = "Удалить сотрудника";
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
			this.panelUp.Size = new System.Drawing.Size(995, 27);
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
			// EmployeesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(995, 559);
			this.Controls.Add(this.panelBack);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "EmployeesForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EmployeesForm";
			this.panelBack.ResumeLayout(false);
			this.panelBack.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panelUp.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelBack;
		private System.Windows.Forms.Panel panelUp;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.DataGridView dataGridViewEmployees;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem btnInsert;
		private System.Windows.Forms.ToolStripMenuItem btnUpdate;
		private System.Windows.Forms.ToolStripMenuItem btnDelete;
		private System.Windows.Forms.ToolStripMenuItem sort;
		private System.Windows.Forms.ToolStripMenuItem btnSortOnName;
		private System.Windows.Forms.ToolStripMenuItem btnSortOnPrice;
		private System.Windows.Forms.ToolStripMenuItem btnSortOnCapacity;
		private System.Windows.Forms.ComboBox comboBoxColumns;
	}
}