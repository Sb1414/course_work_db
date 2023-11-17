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
			this.panelBack = new System.Windows.Forms.Panel();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnCheckPass = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.labelInfo = new System.Windows.Forms.Label();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.panelUp = new System.Windows.Forms.Panel();
			this.buttonClose = new System.Windows.Forms.Button();
			this.textBoxLogin = new System.Windows.Forms.TextBox();
			this.panelBack.SuspendLayout();
			this.panelUp.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelBack
			// 
			this.panelBack.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.panelBack.BackgroundImage = global::AmusementPark.Properties.Resources.back1;
			this.panelBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panelBack.Controls.Add(this.btnClear);
			this.panelBack.Controls.Add(this.btnCheckPass);
			this.panelBack.Controls.Add(this.btnLogin);
			this.panelBack.Controls.Add(this.labelInfo);
			this.panelBack.Controls.Add(this.textBoxPassword);
			this.panelBack.Controls.Add(this.panelUp);
			this.panelBack.Controls.Add(this.textBoxLogin);
			this.panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelBack.Location = new System.Drawing.Point(0, 0);
			this.panelBack.Name = "panelBack";
			this.panelBack.Size = new System.Drawing.Size(576, 378);
			this.panelBack.TabIndex = 4;
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.Transparent;
			this.btnClear.FlatAppearance.BorderSize = 0;
			this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.Location = new System.Drawing.Point(294, 265);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(97, 37);
			this.btnClear.TabIndex = 3;
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnCheckPass
			// 
			this.btnCheckPass.BackColor = System.Drawing.Color.Transparent;
			this.btnCheckPass.BackgroundImage = global::AmusementPark.Properties.Resources.icons8_eye_24;
			this.btnCheckPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnCheckPass.FlatAppearance.BorderSize = 0;
			this.btnCheckPass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnCheckPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnCheckPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCheckPass.Location = new System.Drawing.Point(407, 184);
			this.btnCheckPass.Name = "btnCheckPass";
			this.btnCheckPass.Size = new System.Drawing.Size(26, 23);
			this.btnCheckPass.TabIndex = 2;
			this.btnCheckPass.UseVisualStyleBackColor = false;
			this.btnCheckPass.Click += new System.EventHandler(this.btnCheckPass_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.Transparent;
			this.btnLogin.FlatAppearance.BorderSize = 0;
			this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Location = new System.Drawing.Point(177, 265);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(97, 37);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// labelInfo
			// 
			this.labelInfo.BackColor = System.Drawing.Color.Transparent;
			this.labelInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelInfo.ForeColor = System.Drawing.Color.Brown;
			this.labelInfo.Location = new System.Drawing.Point(174, 220);
			this.labelInfo.Name = "labelInfo";
			this.labelInfo.Size = new System.Drawing.Size(224, 42);
			this.labelInfo.TabIndex = 1;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(186)))), ((int)(((byte)(227)))));
			this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.textBoxPassword.Location = new System.Drawing.Point(177, 187);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(214, 20);
			this.textBoxPassword.TabIndex = 1;
			this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
			// 
			// panelUp
			// 
			this.panelUp.BackColor = System.Drawing.Color.Transparent;
			this.panelUp.Controls.Add(this.buttonClose);
			this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelUp.Location = new System.Drawing.Point(0, 0);
			this.panelUp.Name = "panelUp";
			this.panelUp.Size = new System.Drawing.Size(576, 27);
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
			// textBoxLogin
			// 
			this.textBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(186)))), ((int)(((byte)(227)))));
			this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxLogin.Location = new System.Drawing.Point(177, 119);
			this.textBoxLogin.Name = "textBoxLogin";
			this.textBoxLogin.Size = new System.Drawing.Size(214, 20);
			this.textBoxLogin.TabIndex = 0;
			this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(576, 378);
			this.Controls.Add(this.panelBack);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Вход";
			this.panelBack.ResumeLayout(false);
			this.panelBack.PerformLayout();
			this.panelUp.ResumeLayout(false);
			this.ResumeLayout(false);

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
		private System.Windows.Forms.Button btnCheckPass;
	}
}

