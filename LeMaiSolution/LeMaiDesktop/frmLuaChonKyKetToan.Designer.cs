
namespace LeMaiDesktop
{
    partial class frmLuaChonKyKetToan
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
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnSelect = new DevComponents.DotNetBar.ButtonX();
            this.label29 = new System.Windows.Forms.Label();
            this.cmbKyChungTu = new System.Windows.Forms.ComboBox();
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::LeMaiDesktop.Properties.Resources.Close;
            this.btnClose.ImageTextSpacing = 3;
            this.btnClose.Location = new System.Drawing.Point(269, 65);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 30);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 1278;
            this.btnClose.Text = "&Close";
            this.btnClose.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSelect.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Image = global::LeMaiDesktop.Properties.Resources.Done;
            this.btnSelect.ImageTextSpacing = 3;
            this.btnSelect.Location = new System.Drawing.Point(175, 65);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(88, 30);
            this.btnSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSelect.TabIndex = 1277;
            this.btnSelect.Text = "&Chọn";
            this.btnSelect.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(7, 24);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(92, 20);
            this.label29.TabIndex = 1414;
            this.label29.Text = "Kỳ kết toán:";
            // 
            // cmbKyChungTu
            // 
            this.cmbKyChungTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKyChungTu.FormattingEnabled = true;
            this.cmbKyChungTu.Location = new System.Drawing.Point(99, 22);
            this.cmbKyChungTu.Name = "cmbKyChungTu";
            this.cmbKyChungTu.Size = new System.Drawing.Size(258, 26);
            this.cmbKyChungTu.TabIndex = 1413;
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // frmLuaChonKyKetToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 105);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.cmbKyChungTu);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLuaChonKyKetToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lựa chọn kỳ kết toán";
            this.Load += new System.EventHandler(this.frmLuaChonKyKetToan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnSelect;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox cmbKyChungTu;
        private DevComponents.DotNetBar.StyleManager styleManager;
    }
}