namespace LeMaiDesktop
{
    partial class frmViewNotify
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
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnRead = new DevComponents.DotNetBar.ButtonX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.ucBill = new LeMaiDesktop.ucBill();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.SteelBlue;
            this.panel8.Controls.Add(this.btnRead);
            this.panel8.Controls.Add(this.btnThoat);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 320);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1126, 39);
            this.panel8.TabIndex = 1169;
            // 
            // btnRead
            // 
            this.btnRead.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRead.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRead.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Image = global::LeMaiDesktop.Properties.Resources.Done;
            this.btnRead.ImageTextSpacing = 3;
            this.btnRead.Location = new System.Drawing.Point(939, 3);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(88, 30);
            this.btnRead.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRead.TabIndex = 8;
            this.btnRead.Text = "Đã xử lý";
            this.btnRead.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::LeMaiDesktop.Properties.Resources.Close;
            this.btnThoat.ImageTextSpacing = 3;
            this.btnThoat.Location = new System.Drawing.Point(1033, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(88, 30);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // ucBill
            // 
            this.ucBill.Location = new System.Drawing.Point(9, 6);
            this.ucBill.Name = "ucBill";
            this.ucBill.Size = new System.Drawing.Size(1113, 162);
            this.ucBill.TabIndex = 1170;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(21, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 20);
            this.label7.TabIndex = 1171;
            this.label7.Text = "NỘI DUNG KIỆN VẤN ĐỀ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNgay
            // 
            this.txtNgay.BackColor = System.Drawing.SystemColors.Window;
            this.txtNgay.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgay.Location = new System.Drawing.Point(77, 205);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.ReadOnly = true;
            this.txtNgay.Size = new System.Drawing.Size(156, 22);
            this.txtNgay.TabIndex = 1172;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 14);
            this.label1.TabIndex = 1173;
            this.label1.Text = "Ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 14);
            this.label2.TabIndex = 1175;
            this.label2.Text = "Nội dung:";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.BackColor = System.Drawing.SystemColors.Window;
            this.txtNoiDung.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.Location = new System.Drawing.Point(77, 231);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.ReadOnly = true;
            this.txtNoiDung.Size = new System.Drawing.Size(1037, 83);
            this.txtNoiDung.TabIndex = 1174;
            // 
            // frmViewNotify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 359);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNgay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ucBill);
            this.Controls.Add(this.panel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmViewNotify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hiển thị notify";
            this.Load += new System.EventHandler(this.frmViewNotify_Load);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel8;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private ucBill ucBill;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNoiDung;
        private DevComponents.DotNetBar.ButtonX btnRead;
    }
}