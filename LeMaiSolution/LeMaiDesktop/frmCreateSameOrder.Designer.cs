
namespace LeMaiDesktop
{
    partial class frmCreateSameOrder
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.txtSoDon = new System.Windows.Forms.TextBox();
            this.lblChonKhachHang = new System.Windows.Forms.Label();
            this.txtNguoiGui = new System.Windows.Forms.TextBox();
            this.txtSoDienThoaiNguoiGui = new System.Windows.Forms.TextBox();
            this.lblNguoiGui = new System.Windows.Forms.Label();
            this.lblSoDienThoaiNguoiGui = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNguoiNhan = new System.Windows.Forms.TextBox();
            this.txtSoDienThoaiNguoiNhan = new System.Windows.Forms.TextBox();
            this.lblNguoiNhan = new System.Windows.Forms.Label();
            this.lblSoDienThoaiNguoiNhan = new System.Windows.Forms.Label();
            this.txtCuocPhiChinh = new System.Windows.Forms.TextBox();
            this.txtThuHo = new System.Windows.Forms.TextBox();
            this.lblCuocPhiChinh = new System.Windows.Forms.Label();
            this.lblThuHo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 210);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 39);
            this.panel2.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::LeMaiDesktop.Properties.Resources.stt;
            this.btnSave.ImageTextSpacing = 3;
            this.btnSave.Location = new System.Drawing.Point(307, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 30);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Tạo đơn";
            this.btnSave.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::LeMaiDesktop.Properties.Resources.iExit;
            this.btnClose.ImageTextSpacing = 3;
            this.btnClose.Location = new System.Drawing.Point(401, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 30);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Kết thúc";
            this.btnClose.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtSoDon
            // 
            this.txtSoDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDon.Location = new System.Drawing.Point(103, 169);
            this.txtSoDon.MaxLength = 2;
            this.txtSoDon.Name = "txtSoDon";
            this.txtSoDon.Size = new System.Drawing.Size(376, 32);
            this.txtSoDon.TabIndex = 0;
            this.txtSoDon.Text = "1";
            this.txtSoDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSoDon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDon_KeyPress);
            // 
            // lblChonKhachHang
            // 
            this.lblChonKhachHang.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonKhachHang.ForeColor = System.Drawing.Color.Navy;
            this.lblChonKhachHang.Location = new System.Drawing.Point(12, 9);
            this.lblChonKhachHang.Name = "lblChonKhachHang";
            this.lblChonKhachHang.Size = new System.Drawing.Size(200, 20);
            this.lblChonKhachHang.TabIndex = 1222;
            this.lblChonKhachHang.Text = "THÔNG TIN NGƯỜI GỬI";
            this.lblChonKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNguoiGui
            // 
            this.txtNguoiGui.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNguoiGui.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiGui.Location = new System.Drawing.Point(320, 35);
            this.txtNguoiGui.MaxLength = 100;
            this.txtNguoiGui.Name = "txtNguoiGui";
            this.txtNguoiGui.ReadOnly = true;
            this.txtNguoiGui.Size = new System.Drawing.Size(159, 22);
            this.txtNguoiGui.TabIndex = 1221;
            // 
            // txtSoDienThoaiNguoiGui
            // 
            this.txtSoDienThoaiNguoiGui.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSoDienThoaiNguoiGui.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoaiNguoiGui.Location = new System.Drawing.Point(68, 35);
            this.txtSoDienThoaiNguoiGui.MaxLength = 10;
            this.txtSoDienThoaiNguoiGui.Name = "txtSoDienThoaiNguoiGui";
            this.txtSoDienThoaiNguoiGui.ReadOnly = true;
            this.txtSoDienThoaiNguoiGui.Size = new System.Drawing.Size(163, 22);
            this.txtSoDienThoaiNguoiGui.TabIndex = 1220;
            // 
            // lblNguoiGui
            // 
            this.lblNguoiGui.AutoSize = true;
            this.lblNguoiGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguoiGui.ForeColor = System.Drawing.Color.Black;
            this.lblNguoiGui.Location = new System.Drawing.Point(259, 39);
            this.lblNguoiGui.Name = "lblNguoiGui";
            this.lblNguoiGui.Size = new System.Drawing.Size(63, 15);
            this.lblNguoiGui.TabIndex = 1224;
            this.lblNguoiGui.Text = "Người gửi:";
            // 
            // lblSoDienThoaiNguoiGui
            // 
            this.lblSoDienThoaiNguoiGui.AutoSize = true;
            this.lblSoDienThoaiNguoiGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDienThoaiNguoiGui.ForeColor = System.Drawing.Color.Black;
            this.lblSoDienThoaiNguoiGui.Location = new System.Drawing.Point(15, 39);
            this.lblSoDienThoaiNguoiGui.Name = "lblSoDienThoaiNguoiGui";
            this.lblSoDienThoaiNguoiGui.Size = new System.Drawing.Size(56, 15);
            this.lblSoDienThoaiNguoiGui.TabIndex = 1223;
            this.lblSoDienThoaiNguoiGui.Text = "SĐT Gửi:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(18, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 20);
            this.label8.TabIndex = 1227;
            this.label8.Text = "THÔNG TIN NGƯỜI NHẬN";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNguoiNhan
            // 
            this.txtNguoiNhan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNguoiNhan.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiNhan.Location = new System.Drawing.Point(320, 96);
            this.txtNguoiNhan.MaxLength = 100;
            this.txtNguoiNhan.Name = "txtNguoiNhan";
            this.txtNguoiNhan.ReadOnly = true;
            this.txtNguoiNhan.Size = new System.Drawing.Size(159, 22);
            this.txtNguoiNhan.TabIndex = 1226;
            // 
            // txtSoDienThoaiNguoiNhan
            // 
            this.txtSoDienThoaiNguoiNhan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSoDienThoaiNguoiNhan.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoaiNguoiNhan.Location = new System.Drawing.Point(68, 96);
            this.txtSoDienThoaiNguoiNhan.MaxLength = 10;
            this.txtSoDienThoaiNguoiNhan.Name = "txtSoDienThoaiNguoiNhan";
            this.txtSoDienThoaiNguoiNhan.ReadOnly = true;
            this.txtSoDienThoaiNguoiNhan.Size = new System.Drawing.Size(163, 22);
            this.txtSoDienThoaiNguoiNhan.TabIndex = 1225;
            // 
            // lblNguoiNhan
            // 
            this.lblNguoiNhan.AutoSize = true;
            this.lblNguoiNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguoiNhan.ForeColor = System.Drawing.Color.Black;
            this.lblNguoiNhan.Location = new System.Drawing.Point(248, 100);
            this.lblNguoiNhan.Name = "lblNguoiNhan";
            this.lblNguoiNhan.Size = new System.Drawing.Size(74, 15);
            this.lblNguoiNhan.TabIndex = 1229;
            this.lblNguoiNhan.Text = "Người nhận:";
            // 
            // lblSoDienThoaiNguoiNhan
            // 
            this.lblSoDienThoaiNguoiNhan.AutoSize = true;
            this.lblSoDienThoaiNguoiNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDienThoaiNguoiNhan.ForeColor = System.Drawing.Color.Black;
            this.lblSoDienThoaiNguoiNhan.Location = new System.Drawing.Point(4, 100);
            this.lblSoDienThoaiNguoiNhan.Name = "lblSoDienThoaiNguoiNhan";
            this.lblSoDienThoaiNguoiNhan.Size = new System.Drawing.Size(67, 15);
            this.lblSoDienThoaiNguoiNhan.TabIndex = 1228;
            this.lblSoDienThoaiNguoiNhan.Text = "SĐT Nhận:";
            // 
            // txtCuocPhiChinh
            // 
            this.txtCuocPhiChinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCuocPhiChinh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCuocPhiChinh.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuocPhiChinh.Location = new System.Drawing.Point(68, 129);
            this.txtCuocPhiChinh.MaxLength = 10;
            this.txtCuocPhiChinh.Name = "txtCuocPhiChinh";
            this.txtCuocPhiChinh.ReadOnly = true;
            this.txtCuocPhiChinh.Size = new System.Drawing.Size(163, 22);
            this.txtCuocPhiChinh.TabIndex = 1231;
            this.txtCuocPhiChinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtThuHo
            // 
            this.txtThuHo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThuHo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtThuHo.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThuHo.Location = new System.Drawing.Point(320, 129);
            this.txtThuHo.MaxLength = 10;
            this.txtThuHo.Name = "txtThuHo";
            this.txtThuHo.ReadOnly = true;
            this.txtThuHo.Size = new System.Drawing.Size(159, 22);
            this.txtThuHo.TabIndex = 1232;
            this.txtThuHo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCuocPhiChinh
            // 
            this.lblCuocPhiChinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCuocPhiChinh.AutoSize = true;
            this.lblCuocPhiChinh.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuocPhiChinh.ForeColor = System.Drawing.Color.Black;
            this.lblCuocPhiChinh.Location = new System.Drawing.Point(0, 133);
            this.lblCuocPhiChinh.Name = "lblCuocPhiChinh";
            this.lblCuocPhiChinh.Size = new System.Drawing.Size(71, 14);
            this.lblCuocPhiChinh.TabIndex = 1233;
            this.lblCuocPhiChinh.Text = "Phí chuyển:";
            // 
            // lblThuHo
            // 
            this.lblThuHo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThuHo.AutoSize = true;
            this.lblThuHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuHo.ForeColor = System.Drawing.Color.Black;
            this.lblThuHo.Location = new System.Drawing.Point(237, 133);
            this.lblThuHo.Name = "lblThuHo";
            this.lblThuHo.Size = new System.Drawing.Size(85, 15);
            this.lblThuHo.TabIndex = 1234;
            this.lblThuHo.Text = "Thu hộ (COD):";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(9, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 1235;
            this.label1.Text = "Số đơn tạo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmCreateSameOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 249);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCuocPhiChinh);
            this.Controls.Add(this.txtThuHo);
            this.Controls.Add(this.lblCuocPhiChinh);
            this.Controls.Add(this.lblThuHo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNguoiNhan);
            this.Controls.Add(this.txtSoDienThoaiNguoiNhan);
            this.Controls.Add(this.lblNguoiNhan);
            this.Controls.Add(this.lblSoDienThoaiNguoiNhan);
            this.Controls.Add(this.lblChonKhachHang);
            this.Controls.Add(this.txtNguoiGui);
            this.Controls.Add(this.txtSoDienThoaiNguoiGui);
            this.Controls.Add(this.lblNguoiGui);
            this.Controls.Add(this.lblSoDienThoaiNguoiGui);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtSoDon);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCreateSameOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo đơn tương tự";
            this.Load += new System.EventHandler(this.frmUpdateB3CodeManual_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private System.Windows.Forms.TextBox txtSoDon;
        private System.Windows.Forms.Label lblChonKhachHang;
        private System.Windows.Forms.TextBox txtNguoiGui;
        private System.Windows.Forms.TextBox txtSoDienThoaiNguoiGui;
        private System.Windows.Forms.Label lblNguoiGui;
        private System.Windows.Forms.Label lblSoDienThoaiNguoiGui;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNguoiNhan;
        private System.Windows.Forms.TextBox txtSoDienThoaiNguoiNhan;
        private System.Windows.Forms.Label lblNguoiNhan;
        private System.Windows.Forms.Label lblSoDienThoaiNguoiNhan;
        private System.Windows.Forms.TextBox txtCuocPhiChinh;
        private System.Windows.Forms.TextBox txtThuHo;
        private System.Windows.Forms.Label lblCuocPhiChinh;
        private System.Windows.Forms.Label lblThuHo;
        private System.Windows.Forms.Label label1;
    }
}