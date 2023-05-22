
namespace LeMaiDesktop
{
    partial class frmSelectCustomer
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
            this.trvKhachHang = new System.Windows.Forms.TreeView();
            this.panelcomtrol = new System.Windows.Forms.Panel();
            this.lblSoDonDoiSoat = new System.Windows.Forms.Label();
            this.btnSelect = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.txtLocKhachHang = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.panelcomtrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvKhachHang
            // 
            this.trvKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trvKhachHang.BackColor = System.Drawing.SystemColors.Window;
            this.trvKhachHang.CheckBoxes = true;
            this.trvKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvKhachHang.Location = new System.Drawing.Point(0, 43);
            this.trvKhachHang.Name = "trvKhachHang";
            this.trvKhachHang.Size = new System.Drawing.Size(572, 367);
            this.trvKhachHang.TabIndex = 1170;
            this.trvKhachHang.TabStop = false;
            this.trvKhachHang.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.trvKhachHang_AfterSelect);
            // 
            // panelcomtrol
            // 
            this.panelcomtrol.BackColor = System.Drawing.Color.SteelBlue;
            this.panelcomtrol.Controls.Add(this.lblSoDonDoiSoat);
            this.panelcomtrol.Controls.Add(this.btnSelect);
            this.panelcomtrol.Controls.Add(this.btnClose);
            this.panelcomtrol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelcomtrol.Location = new System.Drawing.Point(0, 411);
            this.panelcomtrol.Name = "panelcomtrol";
            this.panelcomtrol.Size = new System.Drawing.Size(572, 39);
            this.panelcomtrol.TabIndex = 1171;
            // 
            // lblSoDonDoiSoat
            // 
            this.lblSoDonDoiSoat.AutoSize = true;
            this.lblSoDonDoiSoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDonDoiSoat.ForeColor = System.Drawing.Color.White;
            this.lblSoDonDoiSoat.Location = new System.Drawing.Point(8, 5);
            this.lblSoDonDoiSoat.Name = "lblSoDonDoiSoat";
            this.lblSoDonDoiSoat.Size = new System.Drawing.Size(24, 26);
            this.lblSoDonDoiSoat.TabIndex = 78;
            this.lblSoDonDoiSoat.Text = "0";
            // 
            // btnSelect
            // 
            this.btnSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSelect.Enabled = false;
            this.btnSelect.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Image = global::LeMaiDesktop.Properties.Resources.Done;
            this.btnSelect.ImageTextSpacing = 3;
            this.btnSelect.Location = new System.Drawing.Point(397, 5);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 30);
            this.btnSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "&Chọn";
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
            this.btnClose.Location = new System.Drawing.Point(475, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 30);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "&Kết thúc";
            this.btnClose.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtLocKhachHang
            // 
            // 
            // 
            // 
            this.txtLocKhachHang.Border.Class = "TextBoxBorder";
            this.txtLocKhachHang.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLocKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocKhachHang.Location = new System.Drawing.Point(12, 11);
            this.txtLocKhachHang.Name = "txtLocKhachHang";
            this.txtLocKhachHang.Size = new System.Drawing.Size(551, 26);
            this.txtLocKhachHang.TabIndex = 1172;
            this.txtLocKhachHang.WatermarkText = "Lọc khách hàng...";
            this.txtLocKhachHang.TextChanged += new System.EventHandler(this.txtLocKhachHang_TextChanged);
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // frmSelectCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.txtLocKhachHang);
            this.Controls.Add(this.panelcomtrol);
            this.Controls.Add(this.trvKhachHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lựa chọn khách hàng";
            this.Load += new System.EventHandler(this.frmSelectCustomer_Load);
            this.panelcomtrol.ResumeLayout(false);
            this.panelcomtrol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvKhachHang;
        private System.Windows.Forms.Panel panelcomtrol;
        private DevComponents.DotNetBar.ButtonX btnSelect;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLocKhachHang;
        private DevComponents.DotNetBar.StyleManager styleManager;
        private System.Windows.Forms.Label lblSoDonDoiSoat;
    }
}