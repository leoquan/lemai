namespace LeMaiDesktop
{
    partial class frmAbout
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
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.lblCompany = new DevComponents.DotNetBar.LabelX();
            this.lblApplicaitonName = new DevComponents.DotNetBar.LabelX();
            this.lblVersion = new DevComponents.DotNetBar.LabelX();
            this.lblContact = new DevComponents.DotNetBar.LabelX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // lblCompany
            // 
            // 
            // 
            // 
            this.lblCompany.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCompany.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(171, 5);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(299, 28);
            this.lblCompany.TabIndex = 1;
            this.lblCompany.Tag = "GUID_001_2";
            this.lblCompany.Text = "CTY TNHH TMDV PHÁT TRIỂN LÊ MAI";
            // 
            // lblApplicaitonName
            // 
            // 
            // 
            // 
            this.lblApplicaitonName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblApplicaitonName.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicaitonName.Location = new System.Drawing.Point(175, 39);
            this.lblApplicaitonName.Name = "lblApplicaitonName";
            this.lblApplicaitonName.Size = new System.Drawing.Size(295, 28);
            this.lblApplicaitonName.TabIndex = 32;
            this.lblApplicaitonName.Tag = "GUID_001_3";
            this.lblApplicaitonName.Text = "Chương trình: LE MAI CARRY SYSTEM";
            // 
            // lblVersion
            // 
            // 
            // 
            // 
            this.lblVersion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblVersion.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(175, 67);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(295, 28);
            this.lblVersion.TabIndex = 33;
            this.lblVersion.Tag = "";
            this.lblVersion.Text = "Phiên bản: 2.0.0.1";
            // 
            // lblContact
            // 
            // 
            // 
            // 
            this.lblContact.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblContact.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(175, 95);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(295, 28);
            this.lblContact.TabIndex = 34;
            this.lblContact.Tag = "";
            this.lblContact.Text = "Liên hệ: 0934 090 231";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Image = global::LeMaiDesktop.Properties.Resources.iExit;
            this.btnClose.Location = new System.Drawing.Point(379, 125);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 30);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 30;
            this.btnClose.Tag = "GUID_000_17";
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.Location = new System.Drawing.Point(1, 7);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(168, 143);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(466, 162);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblApplicaitonName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.picLogo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "GUID_001_1";
            this.Text = "About Us";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager;
        private System.Windows.Forms.PictureBox picLogo;
        private DevComponents.DotNetBar.LabelX lblCompany;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.LabelX lblApplicaitonName;
        private DevComponents.DotNetBar.LabelX lblVersion;
        private DevComponents.DotNetBar.LabelX lblContact;
    }
}
