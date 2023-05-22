namespace LeMaiDesktop
{
	partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtUser = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnLogin = new DevComponents.DotNetBar.ButtonX();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.chbGhiNho = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(244, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 17;
            this.label2.Tag = "";
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(244, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 16;
            this.label1.Tag = "";
            this.label1.Text = "Tên đăng nhập:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.txtPassword.Border.Class = "TextBoxBorder";
            this.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Location = new System.Drawing.Point(244, 149);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(228, 24);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.txtUser.Border.Class = "TextBoxBorder";
            this.txtUser.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUser.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUser.Location = new System.Drawing.Point(244, 93);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(228, 24);
            this.txtUser.TabIndex = 12;
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::LeMaiDesktop.Properties.Resources.Close;
            this.btnCancel.ImageTextSpacing = 5;
            this.btnCancel.Location = new System.Drawing.Point(363, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 30);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Tag = "";
            this.btnCancel.Text = "Thoát";
            this.btnCancel.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLogin.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Image = global::LeMaiDesktop.Properties.Resources.Done;
            this.btnLogin.ImageTextSpacing = 5;
            this.btnLogin.Location = new System.Drawing.Point(244, 226);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(113, 30);
            this.btnLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Tag = "";
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Location = new System.Drawing.Point(26, 69);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(170, 162);
            this.pictureBoxLogo.TabIndex = 18;
            this.pictureBoxLogo.TabStop = false;
            // 
            // chbGhiNho
            // 
            this.chbGhiNho.AutoSize = true;
            this.chbGhiNho.BackColor = System.Drawing.Color.Transparent;
            this.chbGhiNho.Location = new System.Drawing.Point(245, 191);
            this.chbGhiNho.Name = "chbGhiNho";
            this.chbGhiNho.Size = new System.Drawing.Size(116, 17);
            this.chbGhiNho.TabIndex = 19;
            this.chbGhiNho.Text = "Ghi nhớ đăng nhập";
            this.chbGhiNho.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(6, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(476, 39);
            this.label3.TabIndex = 20;
            this.label3.Tag = "";
            this.label3.Text = "ĐĂNG NHẬP HỆ THỐNG";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(363, 189);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(109, 21);
            this.cmbLanguage.TabIndex = 21;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LeMaiDesktop.Properties.Resources.frmLogin;
            this.ClientSize = new System.Drawing.Size(488, 271);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chbGhiNho);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGUID001_FormClosing);
            this.Load += new System.EventHandler(this.frmGUID001_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private DevComponents.DotNetBar.Controls.TextBoxX txtPassword;
		private DevComponents.DotNetBar.Controls.TextBoxX txtUser;
		private DevComponents.DotNetBar.ButtonX btnCancel;
		private DevComponents.DotNetBar.ButtonX btnLogin;
		private DevComponents.DotNetBar.StyleManager styleManager1;
		private System.Windows.Forms.PictureBox pictureBoxLogo;
		private System.Windows.Forms.CheckBox chbGhiNho;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbLanguage;
	}
}
