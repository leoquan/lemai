namespace LeMaiDesktop
{
    partial class frmThayDoiNhaVanChuyen
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
			this.lTieude = new System.Windows.Forms.Label();
			this.panelcomtrol = new System.Windows.Forms.Panel();
			this.btnSelect = new DevComponents.DotNetBar.ButtonX();
			this.btnClose = new DevComponents.DotNetBar.ButtonX();
			this.cmbLoaiKien = new System.Windows.Forms.ComboBox();
			this.panelcomtrol.SuspendLayout();
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
			this.lTieude.Size = new System.Drawing.Size(314, 30);
			this.lTieude.TabIndex = 302;
			this.lTieude.Text = "     Thay đổi đơn vị vận chuyển";
			this.lTieude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panelcomtrol
			// 
			this.panelcomtrol.BackColor = System.Drawing.Color.SteelBlue;
			this.panelcomtrol.Controls.Add(this.btnSelect);
			this.panelcomtrol.Controls.Add(this.btnClose);
			this.panelcomtrol.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelcomtrol.Location = new System.Drawing.Point(0, 113);
			this.panelcomtrol.Name = "panelcomtrol";
			this.panelcomtrol.Size = new System.Drawing.Size(314, 39);
			this.panelcomtrol.TabIndex = 1172;
			// 
			// btnSelect
			// 
			this.btnSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnSelect.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSelect.Image = global::LeMaiDesktop.Properties.Resources.Done;
			this.btnSelect.ImageTextSpacing = 3;
			this.btnSelect.Location = new System.Drawing.Point(98, 5);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(116, 30);
			this.btnSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnSelect.TabIndex = 0;
			this.btnSelect.Text = "Thay đổi";
			this.btnSelect.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// btnClose
			// 
			this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = global::LeMaiDesktop.Properties.Resources.iExit;
			this.btnClose.ImageTextSpacing = 3;
			this.btnClose.Location = new System.Drawing.Point(217, 5);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(88, 30);
			this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnClose.TabIndex = 5;
			this.btnClose.Text = "&Kết thúc";
			this.btnClose.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// cmbLoaiKien
			// 
			this.cmbLoaiKien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbLoaiKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbLoaiKien.FormattingEnabled = true;
			this.cmbLoaiKien.Location = new System.Drawing.Point(12, 52);
			this.cmbLoaiKien.Name = "cmbLoaiKien";
			this.cmbLoaiKien.Size = new System.Drawing.Size(290, 28);
			this.cmbLoaiKien.TabIndex = 1173;
			// 
			// frmThayDoiNhaVanChuyen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(314, 152);
			this.Controls.Add(this.cmbLoaiKien);
			this.Controls.Add(this.panelcomtrol);
			this.Controls.Add(this.lTieude);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmThayDoiNhaVanChuyen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thay đổi đơn vị vận chuyển";
			this.Load += new System.EventHandler(this.frmThayDoiNhaVanChuyen_Load);
			this.panelcomtrol.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lTieude;
        private System.Windows.Forms.Panel panelcomtrol;
        private DevComponents.DotNetBar.ButtonX btnSelect;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private System.Windows.Forms.ComboBox cmbLoaiKien;
    }
}