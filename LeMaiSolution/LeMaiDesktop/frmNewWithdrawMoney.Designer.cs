namespace LeMaiDesktop
{
    partial class frmNewWithdrawMoney
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
            this.panelcomtrol = new System.Windows.Forms.Panel();
            this.btnAddRequest = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSoTK = new System.Windows.Forms.Label();
            this.lblChuTaiKhoan = new System.Windows.Forms.Label();
            this.lblNganHang = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBangChu = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRequestCode = new System.Windows.Forms.TextBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelcomtrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelcomtrol
            // 
            this.panelcomtrol.BackColor = System.Drawing.Color.SteelBlue;
            this.panelcomtrol.Controls.Add(this.btnAddRequest);
            this.panelcomtrol.Controls.Add(this.btnClose);
            this.panelcomtrol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelcomtrol.Location = new System.Drawing.Point(0, 368);
            this.panelcomtrol.Name = "panelcomtrol";
            this.panelcomtrol.Size = new System.Drawing.Size(634, 39);
            this.panelcomtrol.TabIndex = 300;
            // 
            // btnAddRequest
            // 
            this.btnAddRequest.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRequest.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddRequest.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRequest.Image = global::LeMaiDesktop.Properties.Resources.iEdit;
            this.btnAddRequest.ImageTextSpacing = 3;
            this.btnAddRequest.Location = new System.Drawing.Point(399, 5);
            this.btnAddRequest.Name = "btnAddRequest";
            this.btnAddRequest.Size = new System.Drawing.Size(134, 30);
            this.btnAddRequest.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddRequest.TabIndex = 1167;
            this.btnAddRequest.Text = "Tạo lệnh rút tiền";
            this.btnAddRequest.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnAddRequest.Click += new System.EventHandler(this.btnAddRequest_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::LeMaiDesktop.Properties.Resources.iExit;
            this.btnClose.ImageTextSpacing = 3;
            this.btnClose.Location = new System.Drawing.Point(539, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 30);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 1166;
            this.btnClose.Text = "&Kết thúc";
            this.btnClose.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(1, 58);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(633, 39);
            this.lblTotal.TabIndex = 302;
            this.lblTotal.Text = "20.000.000 VNĐ";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(1, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(633, 46);
            this.lblTitle.TabIndex = 301;
            this.lblTitle.Text = "RÚT TIỀN TỪ HỆ THỐNG";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoTK
            // 
            this.lblSoTK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoTK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTK.ForeColor = System.Drawing.Color.Green;
            this.lblSoTK.Location = new System.Drawing.Point(127, 116);
            this.lblSoTK.Name = "lblSoTK";
            this.lblSoTK.Size = new System.Drawing.Size(485, 33);
            this.lblSoTK.TabIndex = 303;
            this.lblSoTK.Text = "01438001001";
            this.lblSoTK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblChuTaiKhoan
            // 
            this.lblChuTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChuTaiKhoan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuTaiKhoan.ForeColor = System.Drawing.Color.Green;
            this.lblChuTaiKhoan.Location = new System.Drawing.Point(127, 152);
            this.lblChuTaiKhoan.Name = "lblChuTaiKhoan";
            this.lblChuTaiKhoan.Size = new System.Drawing.Size(485, 33);
            this.lblChuTaiKhoan.TabIndex = 304;
            this.lblChuTaiKhoan.Text = "VÕ HỒNG QUÂN";
            this.lblChuTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNganHang
            // 
            this.lblNganHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNganHang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNganHang.ForeColor = System.Drawing.Color.Green;
            this.lblNganHang.Location = new System.Drawing.Point(127, 188);
            this.lblNganHang.Name = "lblNganHang";
            this.lblNganHang.Size = new System.Drawing.Size(485, 33);
            this.lblNganHang.TabIndex = 305;
            this.lblNganHang.Text = "NGÂN HÀNG TIÊN PHONG (TP BANK)";
            this.lblNganHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(11, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(619, 5);
            this.label6.TabIndex = 1470;
            // 
            // lblBangChu
            // 
            this.lblBangChu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBangChu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBangChu.ForeColor = System.Drawing.Color.Red;
            this.lblBangChu.Location = new System.Drawing.Point(8, 319);
            this.lblBangChu.Name = "lblBangChu";
            this.lblBangChu.Size = new System.Drawing.Size(620, 44);
            this.lblBangChu.TabIndex = 1474;
            this.lblBangChu.Text = "Không đồng";
            this.lblBangChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(27, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 33);
            this.label5.TabIndex = 1475;
            this.label5.Text = "Nội dung:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRequestCode
            // 
            this.txtRequestCode.BackColor = System.Drawing.Color.White;
            this.txtRequestCode.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequestCode.ForeColor = System.Drawing.Color.Navy;
            this.txtRequestCode.Location = new System.Drawing.Point(127, 244);
            this.txtRequestCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRequestCode.MaxLength = 10;
            this.txtRequestCode.Name = "txtRequestCode";
            this.txtRequestCode.ReadOnly = true;
            this.txtRequestCode.Size = new System.Drawing.Size(226, 30);
            this.txtRequestCode.TabIndex = 1476;
            // 
            // txtMoney
            // 
            this.txtMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMoney.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.ForeColor = System.Drawing.Color.Red;
            this.txtMoney.Location = new System.Drawing.Point(127, 281);
            this.txtMoney.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoney.MaxLength = 10;
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(226, 30);
            this.txtMoney.TabIndex = 1477;
            this.txtMoney.Text = "20.000.000";
            this.txtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoney_KeyPress);
            this.txtMoney.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMoney_KeyUp);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(27, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 33);
            this.label7.TabIndex = 1478;
            this.label7.Text = "Số tiền:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(359, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 33);
            this.label4.TabIndex = 1479;
            this.label4.Text = "VNĐ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(33, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 33);
            this.label1.TabIndex = 1480;
            this.label1.Text = "Số TK:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(33, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 33);
            this.label2.TabIndex = 1481;
            this.label2.Text = "Chủ TK:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(33, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 33);
            this.label3.TabIndex = 1482;
            this.label3.Text = "Tên NH:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(356, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(274, 30);
            this.label8.TabIndex = 1483;
            this.label8.Text = "(Nội dung thanh toán)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmNewWithdrawMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 407);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.txtRequestCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblBangChu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNganHang);
            this.Controls.Add(this.lblChuTaiKhoan);
            this.Controls.Add(this.lblSoTK);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelcomtrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewWithdrawMoney";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rút tiền từ hệ thống";
            this.Load += new System.EventHandler(this.frmNewRequestMoney_Load);
            this.panelcomtrol.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelcomtrol;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSoTK;
        private System.Windows.Forms.Label lblChuTaiKhoan;
        private System.Windows.Forms.Label lblNganHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBangChu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRequestCode;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label7;
        private DevComponents.DotNetBar.ButtonX btnAddRequest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
    }
}