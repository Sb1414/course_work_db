namespace AmusementPark.View.Employees
{
	partial class EmployeesAddForm
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
			this.labelPass = new System.Windows.Forms.Label();
			this.labelInfo = new System.Windows.Forms.Label();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.comboBoxPosition = new System.Windows.Forms.ComboBox();
			this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
			this.textBoxLogin = new System.Windows.Forms.TextBox();
			this.textBoxMiddleName = new System.Windows.Forms.TextBox();
			this.textBoxFirstName = new System.Windows.Forms.TextBox();
			this.textBoxLastName = new System.Windows.Forms.TextBox();
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
			this.panelBack.BackgroundImage = global::AmusementPark.Properties.Resources.add_employees_form;
			this.panelBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panelBack.Controls.Add(this.labelPass);
			this.panelBack.Controls.Add(this.labelInfo);
			this.panelBack.Controls.Add(this.textBoxPassword);
			this.panelBack.Controls.Add(this.comboBoxPosition);
			this.panelBack.Controls.Add(this.dateOfBirth);
			this.panelBack.Controls.Add(this.textBoxLogin);
			this.panelBack.Controls.Add(this.textBoxMiddleName);
			this.panelBack.Controls.Add(this.textBoxFirstName);
			this.panelBack.Controls.Add(this.textBoxLastName);
			this.panelBack.Controls.Add(this.buttonAdd);
			this.panelBack.Controls.Add(this.panelUp);
			this.panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelBack.Location = new System.Drawing.Point(0, 0);
			this.panelBack.Name = "panelBack";
			this.panelBack.Size = new System.Drawing.Size(566, 671);
			this.panelBack.TabIndex = 8;
			// 
			// labelPass
			// 
			this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelPass.ForeColor = System.Drawing.Color.Maroon;
			this.labelPass.Location = new System.Drawing.Point(147, 435);
			this.labelPass.Name = "labelPass";
			this.labelPass.Size = new System.Drawing.Size(342, 29);
			this.labelPass.TabIndex = 15;
			// 
			// labelInfo
			// 
			this.labelInfo.Location = new System.Drawing.Point(144, 593);
			this.labelInfo.Name = "labelInfo";
			this.labelInfo.Size = new System.Drawing.Size(251, 23);
			this.labelInfo.TabIndex = 14;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(186)))), ((int)(((byte)(227)))));
			this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.textBoxPassword.Location = new System.Drawing.Point(147, 402);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(248, 20);
			this.textBoxPassword.TabIndex = 13;
			this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassword_KeyPress_1);
			this.textBoxPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPassword_Validating);
			// 
			// comboBoxPosition
			// 
			this.comboBoxPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(186)))), ((int)(((byte)(227)))));
			this.comboBoxPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBoxPosition.FormattingEnabled = true;
			this.comboBoxPosition.Location = new System.Drawing.Point(147, 556);
			this.comboBoxPosition.Name = "comboBoxPosition";
			this.comboBoxPosition.Size = new System.Drawing.Size(248, 24);
			this.comboBoxPosition.TabIndex = 12;
			this.comboBoxPosition.SelectedIndexChanged += new System.EventHandler(this.comboBoxPosition_SelectedIndexChanged);
			// 
			// dateOfBirth
			// 
			this.dateOfBirth.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(186)))), ((int)(((byte)(227)))));
			this.dateOfBirth.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(186)))), ((int)(((byte)(227)))));
			this.dateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateOfBirth.Location = new System.Drawing.Point(147, 480);
			this.dateOfBirth.Name = "dateOfBirth";
			this.dateOfBirth.Size = new System.Drawing.Size(248, 22);
			this.dateOfBirth.TabIndex = 11;
			// 
			// textBoxLogin
			// 
			this.textBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(186)))), ((int)(((byte)(227)))));
			this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.textBoxLogin.Location = new System.Drawing.Point(147, 324);
			this.textBoxLogin.Name = "textBoxLogin";
			this.textBoxLogin.Size = new System.Drawing.Size(248, 20);
			this.textBoxLogin.TabIndex = 10;
			this.textBoxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLogin_KeyPress);
			// 
			// textBoxMiddleName
			// 
			this.textBoxMiddleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(186)))), ((int)(((byte)(227)))));
			this.textBoxMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.textBoxMiddleName.Location = new System.Drawing.Point(147, 246);
			this.textBoxMiddleName.Name = "textBoxMiddleName";
			this.textBoxMiddleName.Size = new System.Drawing.Size(248, 20);
			this.textBoxMiddleName.TabIndex = 9;
			this.textBoxMiddleName.TextChanged += new System.EventHandler(this.textBoxMiddleName_TextChanged);
			this.textBoxMiddleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMiddleName_KeyPress);
			// 
			// textBoxFirstName
			// 
			this.textBoxFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(186)))), ((int)(((byte)(227)))));
			this.textBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.textBoxFirstName.Location = new System.Drawing.Point(147, 167);
			this.textBoxFirstName.Name = "textBoxFirstName";
			this.textBoxFirstName.Size = new System.Drawing.Size(248, 20);
			this.textBoxFirstName.TabIndex = 8;
			this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBoxFirstName_TextChanged);
			this.textBoxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFirstName_KeyPress);
			// 
			// textBoxLastName
			// 
			this.textBoxLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(186)))), ((int)(((byte)(227)))));
			this.textBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxLastName.Location = new System.Drawing.Point(147, 90);
			this.textBoxLastName.Name = "textBoxLastName";
			this.textBoxLastName.Size = new System.Drawing.Size(248, 20);
			this.textBoxLastName.TabIndex = 7;
			this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
			this.textBoxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLastName_KeyPress);
			// 
			// buttonAdd
			// 
			this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
			this.buttonAdd.FlatAppearance.BorderSize = 0;
			this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAdd.Location = new System.Drawing.Point(210, 619);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(122, 27);
			this.buttonAdd.TabIndex = 6;
			this.buttonAdd.UseVisualStyleBackColor = false;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// panelUp
			// 
			this.panelUp.BackColor = System.Drawing.Color.Transparent;
			this.panelUp.Controls.Add(this.buttonClose);
			this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelUp.Location = new System.Drawing.Point(0, 0);
			this.panelUp.Name = "panelUp";
			this.panelUp.Size = new System.Drawing.Size(566, 27);
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
			// EmployeesAddForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(566, 671);
			this.Controls.Add(this.panelBack);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "EmployeesAddForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EmployeesAddForm";
			this.panelBack.ResumeLayout(false);
			this.panelBack.PerformLayout();
			this.panelUp.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelBack;
		private System.Windows.Forms.DateTimePicker dateOfBirth;
		private System.Windows.Forms.TextBox textBoxLogin;
		private System.Windows.Forms.TextBox textBoxMiddleName;
		private System.Windows.Forms.TextBox textBoxFirstName;
		private System.Windows.Forms.TextBox textBoxLastName;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Panel panelUp;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.ComboBox comboBoxPosition;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Label labelInfo;
		private System.Windows.Forms.Label labelPass;
	}
}