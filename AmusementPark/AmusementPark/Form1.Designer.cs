namespace AmusementPark
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBoxLogin = new System.Windows.Forms.TextBox();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.panelBack = new System.Windows.Forms.Panel();
			this.labelInfo = new System.Windows.Forms.Label();
			this.panelUp = new System.Windows.Forms.Panel();
			this.buttonClose = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panelBack.SuspendLayout();
			this.panelUp.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxLogin
			// 
			this.textBoxLogin.Location = new System.Drawing.Point(139, 73);
			this.textBoxLogin.Name = "textBoxLogin";
			this.textBoxLogin.Size = new System.Drawing.Size(214, 22);
			this.textBoxLogin.TabIndex = 0;
			this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(139, 142);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(214, 22);
			this.textBoxPassword.TabIndex = 1;
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(139, 208);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(97, 37);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "Войти";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(256, 208);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(97, 37);
			this.btnClear.TabIndex = 3;
			this.btnClear.Text = "Очистить";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// panelBack
			// 
			this.panelBack.Controls.Add(this.dataGridView1);
			this.panelBack.Controls.Add(this.labelInfo);
			this.panelBack.Controls.Add(this.panelUp);
			this.panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelBack.Location = new System.Drawing.Point(0, 0);
			this.panelBack.Name = "panelBack";
			this.panelBack.Size = new System.Drawing.Size(919, 452);
			this.panelBack.TabIndex = 4;
			// 
			// labelInfo
			// 
			this.labelInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.labelInfo.Location = new System.Drawing.Point(136, 167);
			this.labelInfo.Name = "labelInfo";
			this.labelInfo.Size = new System.Drawing.Size(217, 23);
			this.labelInfo.TabIndex = 1;
			// 
			// panelUp
			// 
			this.panelUp.Controls.Add(this.buttonClose);
			this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelUp.Location = new System.Drawing.Point(0, 0);
			this.panelUp.Name = "panelUp";
			this.panelUp.Size = new System.Drawing.Size(919, 27);
			this.panelUp.TabIndex = 0;
			this.panelUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelUp_MouseDown);
			this.panelUp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelUp_MouseMove);
			// 
			// buttonClose
			// 
			this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonClose.Dock = System.Windows.Forms.DockStyle.Left;
			this.buttonClose.FlatAppearance.BorderSize = 0;
			this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonClose.Image = global::AmusementPark.Properties.Resources.icons8_macos_закрыть_20__1_;
			this.buttonClose.Location = new System.Drawing.Point(0, 0);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(27, 27);
			this.buttonClose.TabIndex = 0;
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(376, 33);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(531, 407);
			this.dataGridView1.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(919, 452);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.textBoxLogin);
			this.Controls.Add(this.panelBack);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Вход";
			this.panelBack.ResumeLayout(false);
			this.panelUp.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxLogin;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Panel panelBack;
		private System.Windows.Forms.Panel panelUp;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Label labelInfo;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}

