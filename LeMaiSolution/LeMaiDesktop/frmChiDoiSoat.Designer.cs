
namespace LeMaiDesktop
{
    partial class frmChiDoiSoat
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
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnChiTien = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblLoiNhuan = new System.Windows.Forms.Label();
            this.lblChiPhi = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblThuHoKT = new System.Windows.Forms.Label();
            this.lblThuHo = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblThanhToan = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDoiSoat = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblPhiNhanTra = new System.Windows.Forms.Label();
            this.lblPhiGuiTra = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblBangChu = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.SteelBlue;
            this.panelControl.Controls.Add(this.btnChiTien);
            this.panelControl.Controls.Add(this.btnClose);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl.Location = new System.Drawing.Point(0, 373);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(662, 40);
            this.panelControl.TabIndex = 1;
            // 
            // btnChiTien
            // 
            this.btnChiTien.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChiTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChiTien.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChiTien.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTien.Image = global::LeMaiDesktop.Properties.Resources.stt;
            this.btnChiTien.ImageTextSpacing = 3;
            this.btnChiTien.Location = new System.Drawing.Point(482, 5);
            this.btnChiTien.Name = "btnChiTien";
            this.btnChiTien.Size = new System.Drawing.Size(83, 30);
            this.btnChiTien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnChiTien.TabIndex = 1278;
            this.btnChiTien.Text = "Chi tiền";
            this.btnChiTien.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnChiTien.Click += new System.EventHandler(this.btnChiTien_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::LeMaiDesktop.Properties.Resources.Close;
            this.btnClose.ImageTextSpacing = 3;
            this.btnClose.Location = new System.Drawing.Point(569, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 30);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 1276;
            this.btnClose.Text = "Thoát";
            this.btnClose.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(1, 5);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(657, 47);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "CHI TIỀN ĐỐI SOÁT KHÁCH HÀNG";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLoiNhuan
            // 
            this.lblLoiNhuan.AutoSize = true;
            this.lblLoiNhuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoiNhuan.ForeColor = System.Drawing.Color.Red;
            this.lblLoiNhuan.Location = new System.Drawing.Point(445, 187);
            this.lblLoiNhuan.Name = "lblLoiNhuan";
            this.lblLoiNhuan.Size = new System.Drawing.Size(17, 17);
            this.lblLoiNhuan.TabIndex = 1452;
            this.lblLoiNhuan.Text = "0";
            // 
            // lblChiPhi
            // 
            this.lblChiPhi.AutoSize = true;
            this.lblChiPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiPhi.ForeColor = System.Drawing.Color.Red;
            this.lblChiPhi.Location = new System.Drawing.Point(143, 187);
            this.lblChiPhi.Name = "lblChiPhi";
            this.lblChiPhi.Size = new System.Drawing.Size(17, 17);
            this.lblChiPhi.TabIndex = 1450;
            this.lblChiPhi.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(372, 187);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 17);
            this.label15.TabIndex = 1451;
            this.label15.Text = "Lợi nhuận:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(82, 187);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 17);
            this.label16.TabIndex = 1449;
            this.label16.Text = "Chi phí:";
            // 
            // lblThuHoKT
            // 
            this.lblThuHoKT.AutoSize = true;
            this.lblThuHoKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuHoKT.ForeColor = System.Drawing.Color.Green;
            this.lblThuHoKT.Location = new System.Drawing.Point(445, 157);
            this.lblThuHoKT.Name = "lblThuHoKT";
            this.lblThuHoKT.Size = new System.Drawing.Size(17, 17);
            this.lblThuHoKT.TabIndex = 1448;
            this.lblThuHoKT.Text = "0";
            // 
            // lblThuHo
            // 
            this.lblThuHo.AutoSize = true;
            this.lblThuHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuHo.ForeColor = System.Drawing.Color.Green;
            this.lblThuHo.Location = new System.Drawing.Point(143, 157);
            this.lblThuHo.Name = "lblThuHo";
            this.lblThuHo.Size = new System.Drawing.Size(17, 17);
            this.lblThuHo.TabIndex = 1446;
            this.lblThuHo.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(368, 157);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(79, 17);
            this.label23.TabIndex = 1447;
            this.label23.Text = "Thu hộ KT:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(80, 157);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(57, 17);
            this.label24.TabIndex = 1445;
            this.label24.Text = "Thu hộ:";
            // 
            // lblThanhToan
            // 
            this.lblThanhToan.AutoSize = true;
            this.lblThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhToan.ForeColor = System.Drawing.Color.Red;
            this.lblThanhToan.Location = new System.Drawing.Point(442, 250);
            this.lblThanhToan.Name = "lblThanhToan";
            this.lblThanhToan.Size = new System.Drawing.Size(17, 17);
            this.lblThanhToan.TabIndex = 1460;
            this.lblThanhToan.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(334, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 17);
            this.label10.TabIndex = 1459;
            this.label10.Text = "Đã thanh toán:";
            // 
            // lblDoiSoat
            // 
            this.lblDoiSoat.AutoSize = true;
            this.lblDoiSoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoiSoat.ForeColor = System.Drawing.Color.Red;
            this.lblDoiSoat.Location = new System.Drawing.Point(143, 250);
            this.lblDoiSoat.Name = "lblDoiSoat";
            this.lblDoiSoat.Size = new System.Drawing.Size(17, 17);
            this.lblDoiSoat.TabIndex = 1458;
            this.lblDoiSoat.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(50, 250);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 17);
            this.label12.TabIndex = 1457;
            this.label12.Text = "Đối soát KH:";
            // 
            // lblPhiNhanTra
            // 
            this.lblPhiNhanTra.AutoSize = true;
            this.lblPhiNhanTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhiNhanTra.ForeColor = System.Drawing.Color.Red;
            this.lblPhiNhanTra.Location = new System.Drawing.Point(442, 220);
            this.lblPhiNhanTra.Name = "lblPhiNhanTra";
            this.lblPhiNhanTra.Size = new System.Drawing.Size(17, 17);
            this.lblPhiNhanTra.TabIndex = 1456;
            this.lblPhiNhanTra.Text = "0";
            // 
            // lblPhiGuiTra
            // 
            this.lblPhiGuiTra.AutoSize = true;
            this.lblPhiGuiTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhiGuiTra.ForeColor = System.Drawing.Color.Red;
            this.lblPhiGuiTra.Location = new System.Drawing.Point(143, 220);
            this.lblPhiGuiTra.Name = "lblPhiGuiTra";
            this.lblPhiGuiTra.Size = new System.Drawing.Size(17, 17);
            this.lblPhiGuiTra.TabIndex = 1454;
            this.lblPhiGuiTra.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(347, 220);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 17);
            this.label19.TabIndex = 1455;
            this.label19.Text = "Phí nhận trả:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(61, 220);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 17);
            this.label20.TabIndex = 1453;
            this.label20.Text = "Phí gửi trả:";
            // 
            // lblBangChu
            // 
            this.lblBangChu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBangChu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBangChu.ForeColor = System.Drawing.Color.Red;
            this.lblBangChu.Location = new System.Drawing.Point(80, 317);
            this.lblBangChu.Name = "lblBangChu";
            this.lblBangChu.Size = new System.Drawing.Size(566, 28);
            this.lblBangChu.TabIndex = 1464;
            this.lblBangChu.Text = "Không đồng";
            this.lblBangChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtValue
            // 
            this.txtValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(245)))), ((int)(((byte)(176)))));
            this.txtValue.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.Location = new System.Drawing.Point(80, 284);
            this.txtValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValue.MaxLength = 10;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(226, 22);
            this.txtValue.TabIndex = 1461;
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            this.txtValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtValue_KeyUp);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(19, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 1463;
            this.label4.Text = "Bằng chữ:";
            // 
            // lblValue
            // 
            this.lblValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.ForeColor = System.Drawing.Color.Black;
            this.lblValue.Location = new System.Drawing.Point(32, 288);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(50, 14);
            this.lblValue.TabIndex = 1462;
            this.lblValue.Text = "Số tiền:";
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhachHang.ForeColor = System.Drawing.Color.Blue;
            this.lblTenKhachHang.Location = new System.Drawing.Point(143, 61);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(17, 17);
            this.lblTenKhachHang.TabIndex = 1466;
            this.lblTenKhachHang.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(49, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 1465;
            this.label2.Text = "Khách hàng:";
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDienThoai.ForeColor = System.Drawing.Color.Blue;
            this.lblSoDienThoai.Location = new System.Drawing.Point(143, 90);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(17, 17);
            this.lblSoDienThoai.TabIndex = 1468;
            this.lblSoDienThoai.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(61, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 1467;
            this.label5.Text = "Điện thoại:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(18, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(619, 5);
            this.label6.TabIndex = 1469;
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // frmChiDoiSoat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 413);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSoDienThoai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTenKhachHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBangChu);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblThanhToan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblDoiSoat);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblPhiNhanTra);
            this.Controls.Add(this.lblPhiGuiTra);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblLoiNhuan);
            this.Controls.Add(this.lblChiPhi);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblThuHoKT);
            this.Controls.Add(this.lblThuHo);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.panelControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChiDoiSoat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiền";
            this.Load += new System.EventHandler(this.frmChiDoiSoat_Load);
            this.panelControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelControl;
        private DevComponents.DotNetBar.ButtonX btnChiTien;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblLoiNhuan;
        private System.Windows.Forms.Label lblChiPhi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblThuHoKT;
        private System.Windows.Forms.Label lblThuHo;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblThanhToan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDoiSoat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblPhiNhanTra;
        private System.Windows.Forms.Label lblPhiGuiTra;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblBangChu;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevComponents.DotNetBar.StyleManager styleManager;
    }
}