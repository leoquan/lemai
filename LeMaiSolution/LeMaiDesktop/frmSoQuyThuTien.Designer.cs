namespace LeMaiDesktop
{
    partial class frmSoQuyThuTien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lTieude = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.btnInThuChi = new DevComponents.DotNetBar.ButtonX();
            this.dataQLTCGrid = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.col_idqltc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IsPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BuuCuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TTNguoiTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_QLTCSoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TTTonQuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GhiChuTTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateQLTCTo = new System.Windows.Forms.DateTimePicker();
            this.cmbQLTCLoai = new System.Windows.Forms.ComboBox();
            this.dateQLTCFrom = new System.Windows.Forms.DateTimePicker();
            this.btnChiTien = new DevComponents.DotNetBar.ButtonX();
            this.label35 = new System.Windows.Forms.Label();
            this.btnThuTien = new DevComponents.DotNetBar.ButtonX();
            this.label26 = new System.Windows.Forms.Label();
            this.btnQLTCExcel = new DevComponents.DotNetBar.ButtonX();
            this.btnQLTCTruyVan = new DevComponents.DotNetBar.ButtonX();
            this.label28 = new System.Windows.Forms.Label();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataQLTCGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lTieude
            // 
            this.lTieude.BackColor = System.Drawing.Color.SteelBlue;
            this.lTieude.Cursor = System.Windows.Forms.Cursors.Default;
            this.lTieude.Dock = System.Windows.Forms.DockStyle.Top;
            this.lTieude.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTieude.ForeColor = System.Drawing.Color.White;
            this.lTieude.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lTieude.Location = new System.Drawing.Point(0, 0);
            this.lTieude.Name = "lTieude";
            this.lTieude.Size = new System.Drawing.Size(1269, 30);
            this.lTieude.TabIndex = 78;
            this.lTieude.Text = "    Quản lý dòng tiền thu chi";
            this.lTieude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.SteelBlue;
            this.panel8.Controls.Add(this.btnThoat);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 656);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1269, 39);
            this.panel8.TabIndex = 1167;
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::LeMaiDesktop.Properties.Resources.Close;
            this.btnThoat.ImageTextSpacing = 3;
            this.btnThoat.Location = new System.Drawing.Point(1176, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(88, 30);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnInThuChi
            // 
            this.btnInThuChi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInThuChi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInThuChi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnInThuChi.Enabled = false;
            this.btnInThuChi.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInThuChi.Image = global::LeMaiDesktop.Properties.Resources.iPrint;
            this.btnInThuChi.ImageTextSpacing = 3;
            this.btnInThuChi.Location = new System.Drawing.Point(856, 36);
            this.btnInThuChi.Name = "btnInThuChi";
            this.btnInThuChi.Size = new System.Drawing.Size(79, 30);
            this.btnInThuChi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnInThuChi.TabIndex = 1338;
            this.btnInThuChi.Text = "In";
            this.btnInThuChi.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnInThuChi.Click += new System.EventHandler(this.btnInThuChi_Click);
            // 
            // dataQLTCGrid
            // 
            this.dataQLTCGrid.AllowUserToAddRows = false;
            this.dataQLTCGrid.AllowUserToDeleteRows = false;
            this.dataQLTCGrid.AllowUserToResizeColumns = false;
            this.dataQLTCGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.dataQLTCGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataQLTCGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataQLTCGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataQLTCGrid.ColumnHeadersHeight = 25;
            this.dataQLTCGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_idqltc,
            this.dataGridViewTextBoxColumn33,
            this.col_IsPay,
            this.col_BuuCuc,
            this.col_TTNguoiTT,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn30,
            this.col_QLTCSoTien,
            this.col_TTTonQuy,
            this.dataGridViewTextBoxColumn41,
            this.col_GhiChuTTT});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataQLTCGrid.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataQLTCGrid.EnableHeadersVisualStyles = false;
            this.dataQLTCGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataQLTCGrid.HighlightSelectedColumnHeaders = false;
            this.dataQLTCGrid.Location = new System.Drawing.Point(3, 72);
            this.dataQLTCGrid.MultiSelect = false;
            this.dataQLTCGrid.Name = "dataQLTCGrid";
            this.dataQLTCGrid.PaintEnhancedSelection = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataQLTCGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataQLTCGrid.RowHeadersVisible = false;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.dataQLTCGrid.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataQLTCGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataQLTCGrid.RowTemplate.Height = 25;
            this.dataQLTCGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataQLTCGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataQLTCGrid.Size = new System.Drawing.Size(1264, 583);
            this.dataQLTCGrid.TabIndex = 1327;
            // 
            // col_idqltc
            // 
            this.col_idqltc.DataPropertyName = "Id";
            this.col_idqltc.HeaderText = "Id";
            this.col_idqltc.Name = "col_idqltc";
            this.col_idqltc.Visible = false;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn33.DataPropertyName = "CreateDate";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Format = "dd/MM/yyyy HH:mm:ss";
            this.dataGridViewTextBoxColumn33.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn33.HeaderText = "Ngày";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ReadOnly = true;
            this.dataGridViewTextBoxColumn33.Width = 150;
            // 
            // col_IsPay
            // 
            this.col_IsPay.DataPropertyName = "IsPay";
            this.col_IsPay.HeaderText = "Ispay";
            this.col_IsPay.Name = "col_IsPay";
            this.col_IsPay.ReadOnly = true;
            this.col_IsPay.Visible = false;
            // 
            // col_BuuCuc
            // 
            this.col_BuuCuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_BuuCuc.DataPropertyName = "TenDaiLy";
            this.col_BuuCuc.HeaderText = "Bưu cục";
            this.col_BuuCuc.Name = "col_BuuCuc";
            this.col_BuuCuc.ReadOnly = true;
            this.col_BuuCuc.Width = 200;
            // 
            // col_TTNguoiTT
            // 
            this.col_TTNguoiTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_TTNguoiTT.DataPropertyName = "MaNguoiNopNhan";
            this.col_TTNguoiTT.HeaderText = "Người thực hiện";
            this.col_TTNguoiTT.Name = "col_TTNguoiTT";
            this.col_TTNguoiTT.ReadOnly = true;
            this.col_TTNguoiTT.Width = 120;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn28.DataPropertyName = "SoChungTu";
            this.dataGridViewTextBoxColumn28.FillWeight = 189.6907F;
            this.dataGridViewTextBoxColumn28.HeaderText = "Mã vận đơn";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            this.dataGridViewTextBoxColumn28.Width = 120;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn30.DataPropertyName = "TenNguoiNopNhan";
            this.dataGridViewTextBoxColumn30.HeaderText = "Người nhận/nộp";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            this.dataGridViewTextBoxColumn30.Width = 120;
            // 
            // col_QLTCSoTien
            // 
            this.col_QLTCSoTien.DataPropertyName = "Value";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N0";
            this.col_QLTCSoTien.DefaultCellStyle = dataGridViewCellStyle12;
            this.col_QLTCSoTien.HeaderText = "Số tiền";
            this.col_QLTCSoTien.Name = "col_QLTCSoTien";
            this.col_QLTCSoTien.ReadOnly = true;
            // 
            // col_TTTonQuy
            // 
            this.col_TTTonQuy.DataPropertyName = "AfterTotalValue";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "N0";
            this.col_TTTonQuy.DefaultCellStyle = dataGridViewCellStyle13;
            this.col_TTTonQuy.HeaderText = "Tồn quỹ";
            this.col_TTTonQuy.Name = "col_TTTonQuy";
            this.col_TTTonQuy.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "TenLoai";
            this.dataGridViewTextBoxColumn41.HeaderText = "Loại thanh toán";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.ReadOnly = true;
            // 
            // col_GhiChuTTT
            // 
            this.col_GhiChuTTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_GhiChuTTT.DataPropertyName = "Note";
            this.col_GhiChuTTT.HeaderText = "Ghi chú";
            this.col_GhiChuTTT.Name = "col_GhiChuTTT";
            this.col_GhiChuTTT.ReadOnly = true;
            // 
            // dateQLTCTo
            // 
            this.dateQLTCTo.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateQLTCTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateQLTCTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateQLTCTo.Location = new System.Drawing.Point(274, 38);
            this.dateQLTCTo.Name = "dateQLTCTo";
            this.dateQLTCTo.Size = new System.Drawing.Size(185, 26);
            this.dateQLTCTo.TabIndex = 1332;
            // 
            // cmbQLTCLoai
            // 
            this.cmbQLTCLoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbQLTCLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQLTCLoai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQLTCLoai.FormattingEnabled = true;
            this.cmbQLTCLoai.Location = new System.Drawing.Point(505, 38);
            this.cmbQLTCLoai.Name = "cmbQLTCLoai";
            this.cmbQLTCLoai.Size = new System.Drawing.Size(261, 27);
            this.cmbQLTCLoai.TabIndex = 1336;
            // 
            // dateQLTCFrom
            // 
            this.dateQLTCFrom.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateQLTCFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateQLTCFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateQLTCFrom.Location = new System.Drawing.Point(60, 38);
            this.dateQLTCFrom.Name = "dateQLTCFrom";
            this.dateQLTCFrom.Size = new System.Drawing.Size(185, 26);
            this.dateQLTCFrom.TabIndex = 1329;
            // 
            // btnChiTien
            // 
            this.btnChiTien.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChiTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChiTien.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChiTien.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTien.Image = global::LeMaiDesktop.Properties.Resources.sub;
            this.btnChiTien.ImageTextSpacing = 3;
            this.btnChiTien.Location = new System.Drawing.Point(1105, 36);
            this.btnChiTien.Name = "btnChiTien";
            this.btnChiTien.Size = new System.Drawing.Size(79, 30);
            this.btnChiTien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnChiTien.TabIndex = 1335;
            this.btnChiTien.Text = "Chi tiền";
            this.btnChiTien.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnChiTien.Click += new System.EventHandler(this.btnChiTien_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.Black;
            this.label35.Location = new System.Drawing.Point(463, 41);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(43, 20);
            this.label35.TabIndex = 1337;
            this.label35.Text = "Loại:";
            // 
            // btnThuTien
            // 
            this.btnThuTien.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThuTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThuTien.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThuTien.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuTien.Image = global::LeMaiDesktop.Properties.Resources.add;
            this.btnThuTien.ImageTextSpacing = 3;
            this.btnThuTien.Location = new System.Drawing.Point(1023, 36);
            this.btnThuTien.Name = "btnThuTien";
            this.btnThuTien.Size = new System.Drawing.Size(79, 30);
            this.btnThuTien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThuTien.TabIndex = 1334;
            this.btnThuTien.Text = "Thu tiền";
            this.btnThuTien.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnThuTien.Click += new System.EventHandler(this.btnThuTien_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(247, 41);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(27, 20);
            this.label26.TabIndex = 1331;
            this.label26.Text = "=>";
            // 
            // btnQLTCExcel
            // 
            this.btnQLTCExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQLTCExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQLTCExcel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQLTCExcel.Enabled = false;
            this.btnQLTCExcel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLTCExcel.Image = global::LeMaiDesktop.Properties.Resources.iExcel;
            this.btnQLTCExcel.ImageTextSpacing = 3;
            this.btnQLTCExcel.Location = new System.Drawing.Point(938, 36);
            this.btnQLTCExcel.Name = "btnQLTCExcel";
            this.btnQLTCExcel.Size = new System.Drawing.Size(82, 30);
            this.btnQLTCExcel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQLTCExcel.TabIndex = 1333;
            this.btnQLTCExcel.Text = "Xuất Excel";
            this.btnQLTCExcel.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnQLTCExcel.Click += new System.EventHandler(this.btnQLTCExcel_Click);
            // 
            // btnQLTCTruyVan
            // 
            this.btnQLTCTruyVan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQLTCTruyVan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQLTCTruyVan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQLTCTruyVan.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLTCTruyVan.Image = global::LeMaiDesktop.Properties.Resources.iSearch;
            this.btnQLTCTruyVan.ImageTextSpacing = 3;
            this.btnQLTCTruyVan.Location = new System.Drawing.Point(770, 36);
            this.btnQLTCTruyVan.Name = "btnQLTCTruyVan";
            this.btnQLTCTruyVan.Size = new System.Drawing.Size(83, 30);
            this.btnQLTCTruyVan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQLTCTruyVan.TabIndex = 1330;
            this.btnQLTCTruyVan.Text = "Truy vấn";
            this.btnQLTCTruyVan.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnQLTCTruyVan.Click += new System.EventHandler(this.btnQLTCTruyVan_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(12, 41);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(49, 20);
            this.label28.TabIndex = 1328;
            this.label28.Text = "Ngày:";
            // 
            // frmSoQuyThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 695);
            this.Controls.Add(this.btnInThuChi);
            this.Controls.Add(this.dataQLTCGrid);
            this.Controls.Add(this.dateQLTCTo);
            this.Controls.Add(this.cmbQLTCLoai);
            this.Controls.Add(this.dateQLTCFrom);
            this.Controls.Add(this.btnChiTien);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.btnThuTien);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.btnQLTCExcel);
            this.Controls.Add(this.btnQLTCTruyVan);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.lTieude);
            this.Name = "frmSoQuyThuTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSoQuyThuTien";
            this.Load += new System.EventHandler(this.frmSoQuyThuTien_Load);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataQLTCGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTieude;
        private System.Windows.Forms.Panel panel8;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.ButtonX btnInThuChi;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataQLTCGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_idqltc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IsPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BuuCuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TTNguoiTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_QLTCSoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TTTonQuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GhiChuTTT;
        private System.Windows.Forms.DateTimePicker dateQLTCTo;
        private System.Windows.Forms.ComboBox cmbQLTCLoai;
        private System.Windows.Forms.DateTimePicker dateQLTCFrom;
        private DevComponents.DotNetBar.ButtonX btnChiTien;
        private System.Windows.Forms.Label label35;
        private DevComponents.DotNetBar.ButtonX btnThuTien;
        private System.Windows.Forms.Label label26;
        private DevComponents.DotNetBar.ButtonX btnQLTCExcel;
        private DevComponents.DotNetBar.ButtonX btnQLTCTruyVan;
        private System.Windows.Forms.Label label28;
    }
}