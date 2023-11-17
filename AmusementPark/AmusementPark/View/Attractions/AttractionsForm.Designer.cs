namespace AmusementPark
{
	partial class AttractionsForm
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
			this.dataGridViewAttractions = new System.Windows.Forms.DataGridView();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.btnInsert = new System.Windows.Forms.ToolStripMenuItem();
			this.btnUpdate = new System.Windows.Forms.ToolStripMenuItem();
			this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnSortOnName = new System.Windows.Forms.ToolStripMenuItem();
			this.btnSortOnPrice = new System.Windows.Forms.ToolStripMenuItem();
			this.btnSortOnCapacity = new System.Windows.Forms.ToolStripMenuItem();
			this.panelUp = new System.Windows.Forms.Panel();
			this.buttonClose = new System.Windows.Forms.Button();
			this.panelBack.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttractions)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.panelUp.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelBack
			// 
			this.panelBack.BackColor = System.Drawing.Color.Transparent;
			this.panelBack.BackgroundImage = global::AmusementPark.Properties.Resources.attractions_back;
			this.panelBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panelBack.Controls.Add(this.dataGridViewAttractions);
			this.panelBack.Controls.Add(this.menuStrip1);
			this.panelBack.Controls.Add(this.panelUp);
			this.panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelBack.Location = new System.Drawing.Point(0, 0);
			this.panelBack.Name = "panelBack";
			this.panelBack.Size = new System.Drawing.Size(841, 524);
			this.panelBack.TabIndex = 7;
			// 
			// dataGridViewAttractions
			// 
			this.dataGridViewAttractions.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dataGridViewAttractions.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridViewAttractions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAttractions.Dock = System.Windows.Forms.DockStyle.Top;
			this.dataGridViewAttractions.Location = new System.Drawing.Point(0, 55);
			this.dataGridViewAttractions.Name = "dataGridViewAttractions";
			this.dataGridViewAttractions.RowHeadersWidth = 51;
			this.dataGridViewAttractions.RowTemplate.Height = 24;
			this.dataGridViewAttractions.Size = new System.Drawing.Size(841, 361);
			this.dataGridViewAttractions.TabIndex = 1;
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInsert,
            this.btnUpdate,
            this.btnDelete,
            this.сортировкаToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 27);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(841, 28);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// btnInsert
			// 
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(174, 24);
			this.btnInsert.Text = "Добавить аттракцион";
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(176, 24);
			this.btnUpdate.Text = "Изменить аттракцион";
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(163, 24);
			this.btnDelete.Text = "Удалить аттракцион";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// сортировкаToolStripMenuItem
			// 
			this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSortOnName,
            this.btnSortOnPrice,
            this.btnSortOnCapacity});
			this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
			this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
			this.сортировкаToolStripMenuItem.Text = "Сортировка";
			// 
			// btnSortOnName
			// 
			this.btnSortOnName.Name = "btnSortOnName";
			this.btnSortOnName.Size = new System.Drawing.Size(224, 26);
			this.btnSortOnName.Text = "По названию";
			this.btnSortOnName.Click += new System.EventHandler(this.btnSortOnName_Click);
			// 
			// btnSortOnPrice
			// 
			this.btnSortOnPrice.Name = "btnSortOnPrice";
			this.btnSortOnPrice.Size = new System.Drawing.Size(224, 26);
			this.btnSortOnPrice.Text = "По цене";
			this.btnSortOnPrice.Click += new System.EventHandler(this.btnSortOnPrice_Click);
			// 
			// btnSortOnCapacity
			// 
			this.btnSortOnCapacity.Name = "btnSortOnCapacity";
			this.btnSortOnCapacity.Size = new System.Drawing.Size(224, 26);
			this.btnSortOnCapacity.Text = "По вместимости";
			this.btnSortOnCapacity.Click += new System.EventHandler(this.btnSortOnCapacity_Click);
			// 
			// panelUp
			// 
			this.panelUp.BackColor = System.Drawing.Color.Transparent;
			this.panelUp.Controls.Add(this.buttonClose);
			this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelUp.Location = new System.Drawing.Point(0, 0);
			this.panelUp.Name = "panelUp";
			this.panelUp.Size = new System.Drawing.Size(841, 27);
			this.panelUp.TabIndex = 0;
			this.panelUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelUp_MouseDown);
			this.panelUp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelUp_MouseMove);
			// 
			// buttonClose
			// 
			this.buttonClose.BackgroundImage = global::AmusementPark.Properties.Resources.icons8_macos_закрыть_20__1_;
			this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonClose.Dock = System.Windows.Forms.DockStyle.Left;
			this.buttonClose.FlatAppearance.BorderSize = 0;
			this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonClose.Location = new System.Drawing.Point(0, 0);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(27, 27);
			this.buttonClose.TabIndex = 0;
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// AttractionsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(841, 524);
			this.Controls.Add(this.panelBack);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "AttractionsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AttractionsForm";
			this.panelBack.ResumeLayout(false);
			this.panelBack.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttractions)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panelUp.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelBack;
		private System.Windows.Forms.Panel panelUp;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.DataGridView dataGridViewAttractions;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem btnInsert;
		private System.Windows.Forms.ToolStripMenuItem btnUpdate;
		private System.Windows.Forms.ToolStripMenuItem btnDelete;
		private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem btnSortOnName;
		private System.Windows.Forms.ToolStripMenuItem btnSortOnPrice;
		private System.Windows.Forms.ToolStripMenuItem btnSortOnCapacity;
	}
}