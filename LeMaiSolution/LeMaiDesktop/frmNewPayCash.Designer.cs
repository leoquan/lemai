
namespace LeMaiDesktop
{
    partial class frmNewPayCash
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
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbLoai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBangChu = new System.Windows.Forms.Label();
            this.txtTenNguoiNopNhan = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtSoChungTu = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblSoChungTu = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblTenNguoiNopNhan = new System.Windows.Forms.Label();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.chbChuyenKhoan = new System.Windows.Forms.CheckBox();
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::LeMaiDesktop.Properties.Resources.iSave;
            this.btnSave.ImageTextSpacing = 3;
            this.btnSave.Location = new System.Drawing.Point(489, 445);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 37);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Lưu";
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
            this.btnClose.Location = new System.Drawing.Point(584, 445);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 37);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "&Kết thúc";
            this.btnClose.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(0, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(690, 56);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "CHI TIỀN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(0, 58);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(690, 47);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "20.000.000 VNĐ";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(60, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 16;
            this.label4.Text = "Bằng chữ:";
            // 
            // cmbLoai
            // 
            this.cmbLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.Location = new System.Drawing.Point(121, 133);
            this.cmbLoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(226, 24);
            this.cmbLoai.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(91, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "Loại:";
            // 
            // lblBangChu
            // 
            this.lblBangChu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBangChu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBangChu.ForeColor = System.Drawing.Color.Red;
            this.lblBangChu.Location = new System.Drawing.Point(121, 300);
            this.lblBangChu.Name = "lblBangChu";
            this.lblBangChu.Size = new System.Drawing.Size(566, 28);
            this.lblBangChu.TabIndex = 17;
            this.lblBangChu.Text = "Không đồng";
            this.lblBangChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTenNguoiNopNhan
            // 
            this.txtTenNguoiNopNhan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenNguoiNopNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(245)))), ((int)(((byte)(176)))));
            this.txtTenNguoiNopNhan.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNguoiNopNhan.Location = new System.Drawing.Point(121, 201);
            this.txtTenNguoiNopNhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenNguoiNopNhan.MaxLength = 50;
            this.txtTenNguoiNopNhan.Name = "txtTenNguoiNopNhan";
            this.txtTenNguoiNopNhan.Size = new System.Drawing.Size(226, 22);
            this.txtTenNguoiNopNhan.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaChi.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiaChi.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(121, 234);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiaChi.MaxLength = 50;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(566, 22);
            this.txtDiaChi.TabIndex = 4;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoDienThoai.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoDienThoai.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.Location = new System.Drawing.Point(454, 201);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoDienThoai.MaxLength = 50;
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(233, 22);
            this.txtSoDienThoai.TabIndex = 3;
            // 
            // txtValue
            // 
            this.txtValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(245)))), ((int)(((byte)(176)))));
            this.txtValue.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.Location = new System.Drawing.Point(121, 267);
            this.txtValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValue.MaxLength = 11;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(226, 22);
            this.txtValue.TabIndex = 5;
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            this.txtValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtValue_KeyUp);
            // 
            // txtSoChungTu
            // 
            this.txtSoChungTu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoChungTu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(245)))), ((int)(((byte)(176)))));
            this.txtSoChungTu.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoChungTu.Location = new System.Drawing.Point(121, 168);
            this.txtSoChungTu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoChungTu.MaxLength = 50;
            this.txtSoChungTu.Name = "txtSoChungTu";
            this.txtSoChungTu.Size = new System.Drawing.Size(226, 22);
            this.txtSoChungTu.TabIndex = 1;
            this.txtSoChungTu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoChungTu_KeyPress);
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.BackColor = System.Drawing.SystemColors.Window;
            this.txtNote.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(121, 339);
            this.txtNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNote.MaxLength = 250;
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(566, 90);
            this.txtNote.TabIndex = 6;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.Color.Black;
            this.lblDiaChi.Location = new System.Drawing.Point(77, 238);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(46, 14);
            this.lblDiaChi.TabIndex = 14;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblValue
            // 
            this.lblValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.ForeColor = System.Drawing.Color.Black;
            this.lblValue.Location = new System.Drawing.Point(73, 271);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(50, 14);
            this.lblValue.TabIndex = 15;
            this.lblValue.Text = "Số tiền:";
            // 
            // lblSoChungTu
            // 
            this.lblSoChungTu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSoChungTu.AutoSize = true;
            this.lblSoChungTu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoChungTu.ForeColor = System.Drawing.Color.Black;
            this.lblSoChungTu.Location = new System.Drawing.Point(49, 172);
            this.lblSoChungTu.Name = "lblSoChungTu";
            this.lblSoChungTu.Size = new System.Drawing.Size(74, 14);
            this.lblSoChungTu.TabIndex = 12;
            this.lblSoChungTu.Text = "Mã vận đơn:";
            // 
            // lblNote
            // 
            this.lblNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.Black;
            this.lblNote.Location = new System.Drawing.Point(71, 377);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(52, 14);
            this.lblNote.TabIndex = 18;
            this.lblNote.Text = "Ghi chú:";
            // 
            // lblTenNguoiNopNhan
            // 
            this.lblTenNguoiNopNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTenNguoiNopNhan.AutoSize = true;
            this.lblTenNguoiNopNhan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNguoiNopNhan.ForeColor = System.Drawing.Color.Black;
            this.lblTenNguoiNopNhan.Location = new System.Drawing.Point(23, 205);
            this.lblTenNguoiNopNhan.Name = "lblTenNguoiNopNhan";
            this.lblTenNguoiNopNhan.Size = new System.Drawing.Size(100, 14);
            this.lblTenNguoiNopNhan.TabIndex = 13;
            this.lblTenNguoiNopNhan.Text = "Người nộp/nhận:";
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDienThoai.ForeColor = System.Drawing.Color.Black;
            this.lblSoDienThoai.Location = new System.Drawing.Point(390, 205);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(66, 14);
            this.lblSoDienThoai.TabIndex = 19;
            this.lblSoDienThoai.Text = "Điện thoại:";
            // 
            // chbChuyenKhoan
            // 
            this.chbChuyenKhoan.AutoSize = true;
            this.chbChuyenKhoan.Location = new System.Drawing.Point(454, 169);
            this.chbChuyenKhoan.Name = "chbChuyenKhoan";
            this.chbChuyenKhoan.Size = new System.Drawing.Size(207, 21);
            this.chbChuyenKhoan.TabIndex = 20;
            this.chbChuyenKhoan.Text = "Chuyển khoản không +- quỹ";
            this.chbChuyenKhoan.UseVisualStyleBackColor = true;
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // frmNewPayCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 495);
            this.Controls.Add(this.chbChuyenKhoan);
            this.Controls.Add(this.cmbLoai);
            this.Controls.Add(this.lblBangChu);
            this.Controls.Add(this.txtTenNguoiNopNhan);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtSoChungTu);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblSoChungTu);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblTenNguoiNopNhan);
            this.Controls.Add(this.lblSoDienThoai);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewPayCash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm mới thao tác";
            this.Load += new System.EventHandler(this.frmNewPayCash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBangChu;
        private System.Windows.Forms.TextBox txtTenNguoiNopNhan;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtSoChungTu;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblSoChungTu;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblTenNguoiNopNhan;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.CheckBox chbChuyenKhoan;
        private DevComponents.DotNetBar.StyleManager styleManager;
    }
}