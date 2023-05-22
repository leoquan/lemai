
namespace LeMaiDesktop
{
    partial class frmSuperAdmin
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
            this.lTieude = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnPermission = new DevComponents.DotNetBar.ButtonX();
            this.btnMenuFunc = new DevComponents.DotNetBar.ButtonX();
            this.btnSubParrent = new DevComponents.DotNetBar.ButtonX();
            this.btnParrent = new DevComponents.DotNetBar.ButtonX();
            this.btnUnlock = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnRole = new DevComponents.DotNetBar.ButtonX();
            this.btnAccount = new DevComponents.DotNetBar.ButtonX();
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.SuspendLayout();
            // 
            // lTieude
            // 
            this.lTieude.BackColor = System.Drawing.Color.SteelBlue;
            this.lTieude.Cursor = System.Windows.Forms.Cursors.Default;
            this.lTieude.Dock = System.Windows.Forms.DockStyle.Top;
            this.lTieude.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTieude.ForeColor = System.Drawing.Color.White;
            this.lTieude.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lTieude.Location = new System.Drawing.Point(0, 0);
            this.lTieude.Name = "lTieude";
            this.lTieude.Size = new System.Drawing.Size(551, 30);
            this.lTieude.TabIndex = 301;
            this.lTieude.Text = "    SUPPER ADMIN";
            this.lTieude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtKey
            // 
            this.txtKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(17, 133);
            this.txtKey.Name = "txtKey";
            this.txtKey.PasswordChar = '*';
            this.txtKey.Size = new System.Drawing.Size(338, 23);
            this.txtKey.TabIndex = 0;
            this.txtKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKey_KeyPress);
            // 
            // btnPermission
            // 
            this.btnPermission.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPermission.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPermission.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPermission.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermission.Image = global::LeMaiDesktop.Properties.Resources.add;
            this.btnPermission.ImageTextSpacing = 3;
            this.btnPermission.Location = new System.Drawing.Point(344, 33);
            this.btnPermission.Name = "btnPermission";
            this.btnPermission.Size = new System.Drawing.Size(117, 42);
            this.btnPermission.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPermission.TabIndex = 5;
            this.btnPermission.Text = "&Grand Permission";
            this.btnPermission.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnPermission.Click += new System.EventHandler(this.btnPermission_Click);
            // 
            // btnMenuFunc
            // 
            this.btnMenuFunc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMenuFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenuFunc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnMenuFunc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuFunc.Image = global::LeMaiDesktop.Properties.Resources.addrow;
            this.btnMenuFunc.ImageTextSpacing = 3;
            this.btnMenuFunc.Location = new System.Drawing.Point(225, 33);
            this.btnMenuFunc.Name = "btnMenuFunc";
            this.btnMenuFunc.Size = new System.Drawing.Size(113, 42);
            this.btnMenuFunc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMenuFunc.TabIndex = 4;
            this.btnMenuFunc.Text = "&Menu Function";
            this.btnMenuFunc.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnMenuFunc.Click += new System.EventHandler(this.btnMenuFunc_Click);
            // 
            // btnSubParrent
            // 
            this.btnSubParrent.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSubParrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubParrent.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSubParrent.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubParrent.Image = global::LeMaiDesktop.Properties.Resources.iSettings;
            this.btnSubParrent.ImageTextSpacing = 3;
            this.btnSubParrent.Location = new System.Drawing.Point(122, 33);
            this.btnSubParrent.Name = "btnSubParrent";
            this.btnSubParrent.Size = new System.Drawing.Size(96, 42);
            this.btnSubParrent.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSubParrent.TabIndex = 3;
            this.btnSubParrent.Text = "&Child Menu";
            this.btnSubParrent.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnSubParrent.Click += new System.EventHandler(this.btnSubParrent_Click);
            // 
            // btnParrent
            // 
            this.btnParrent.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnParrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParrent.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnParrent.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParrent.Image = global::LeMaiDesktop.Properties.Resources.iEditNew;
            this.btnParrent.ImageTextSpacing = 3;
            this.btnParrent.Location = new System.Drawing.Point(10, 33);
            this.btnParrent.Name = "btnParrent";
            this.btnParrent.Size = new System.Drawing.Size(105, 42);
            this.btnParrent.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnParrent.TabIndex = 2;
            this.btnParrent.Text = "&Parrent Menu";
            this.btnParrent.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnParrent.Click += new System.EventHandler(this.btnParrent_Click);
            // 
            // btnUnlock
            // 
            this.btnUnlock.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUnlock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnlock.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUnlock.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnlock.Image = global::LeMaiDesktop.Properties.Resources.icoBanQuyen;
            this.btnUnlock.ImageTextSpacing = 3;
            this.btnUnlock.Location = new System.Drawing.Point(372, 129);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(77, 30);
            this.btnUnlock.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUnlock.TabIndex = 1;
            this.btnUnlock.Text = "&Unclock";
            this.btnUnlock.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::LeMaiDesktop.Properties.Resources.iExit;
            this.btnClose.ImageTextSpacing = 3;
            this.btnClose.Location = new System.Drawing.Point(455, 129);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 30);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "&Close";
            this.btnClose.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRole
            // 
            this.btnRole.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRole.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRole.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRole.Image = global::LeMaiDesktop.Properties.Resources.add;
            this.btnRole.ImageTextSpacing = 3;
            this.btnRole.Location = new System.Drawing.Point(468, 33);
            this.btnRole.Name = "btnRole";
            this.btnRole.Size = new System.Drawing.Size(75, 42);
            this.btnRole.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRole.TabIndex = 302;
            this.btnRole.Text = "&Role";
            this.btnRole.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnRole.Click += new System.EventHandler(this.btnRole_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccount.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAccount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.Image = global::LeMaiDesktop.Properties.Resources.add;
            this.btnAccount.ImageTextSpacing = 3;
            this.btnAccount.Location = new System.Drawing.Point(10, 84);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(105, 42);
            this.btnAccount.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAccount.TabIndex = 303;
            this.btnAccount.Text = "&User";
            this.btnAccount.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // frmSuperAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(551, 174);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnRole);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lTieude);
            this.Controls.Add(this.btnPermission);
            this.Controls.Add(this.btnMenuFunc);
            this.Controls.Add(this.btnSubParrent);
            this.Controls.Add(this.btnParrent);
            this.Controls.Add(this.btnUnlock);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSuperAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSuperAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnParrent;
        private DevComponents.DotNetBar.ButtonX btnSubParrent;
        private DevComponents.DotNetBar.ButtonX btnMenuFunc;
        private DevComponents.DotNetBar.ButtonX btnPermission;
        private System.Windows.Forms.Label lTieude;
        private DevComponents.DotNetBar.ButtonX btnUnlock;
        private System.Windows.Forms.TextBox txtKey;
        private DevComponents.DotNetBar.ButtonX btnRole;
        private DevComponents.DotNetBar.ButtonX btnAccount;
        private DevComponents.DotNetBar.StyleManager styleManager;
    }
}
