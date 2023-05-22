namespace LeMaiDesktop
{
    partial class frmQuanLyKetToanBuuCuc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelcomtrol = new System.Windows.Forms.Panel();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.lTieude = new System.Windows.Forms.Label();
            this.dataQLTCGrid = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.col_idqltc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IsPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BuuCuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_billCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SoDuTruoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_QLTCSoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TTTonQuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GhiChuTTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.cmbLoaiKetToan = new System.Windows.Forms.ComboBox();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.label35 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.btnExcel = new DevComponents.DotNetBar.ButtonX();
            this.btnTruyVan = new DevComponents.DotNetBar.ButtonX();
            this.label28 = new System.Windows.Forms.Label();
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.panelcomtrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataQLTCGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panelcomtrol
            // 
            this.panelcomtrol.BackColor = System.Drawing.Color.SteelBlue;
            this.panelcomtrol.Controls.Add(this.lblSoLuong);
            this.panelcomtrol.Controls.Add(this.btnClose);
            this.panelcomtrol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelcomtrol.Location = new System.Drawing.Point(0, 656);
            this.panelcomtrol.Name = "panelcomtrol";
            this.panelcomtrol.Size = new System.Drawing.Size(1267, 39);
            this.panelcomtrol.TabIndex = 12;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.ForeColor = System.Drawing.Color.White;
            this.lblSoLuong.Location = new System.Drawing.Point(9, 6);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(24, 26);
            this.lblSoLuong.TabIndex = 0;
            this.lblSoLuong.Text = "0";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::LeMaiDesktop.Properties.Resources.iExit;
            this.btnClose.ImageTextSpacing = 3;
            this.btnClose.Location = new System.Drawing.Point(1170, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 30);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "&Kết thúc";
            this.btnClose.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.lTieude.Size = new System.Drawing.Size(1267, 30);
            this.lTieude.TabIndex = 76;
            this.lTieude.Text = "    Quản lý công nợ theo bưu cục";
            this.lTieude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataQLTCGrid
            // 
            this.dataQLTCGrid.AllowUserToAddRows = false;
            this.dataQLTCGrid.AllowUserToDeleteRows = false;
            this.dataQLTCGrid.AllowUserToResizeColumns = false;
            this.dataQLTCGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.dataQLTCGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataQLTCGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataQLTCGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataQLTCGrid.ColumnHeadersHeight = 25;
            this.dataQLTCGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_idqltc,
            this.dataGridViewTextBoxColumn33,
            this.col_IsPay,
            this.dataGridViewTextBoxColumn41,
            this.col_BuuCuc,
            this.col_billCode,
            this.col_SoDuTruoc,
            this.col_QLTCSoTien,
            this.col_TTTonQuy,
            this.col_GhiChuTTT});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataQLTCGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataQLTCGrid.EnableHeadersVisualStyles = false;
            this.dataQLTCGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataQLTCGrid.HighlightSelectedColumnHeaders = false;
            this.dataQLTCGrid.Location = new System.Drawing.Point(1, 70);
            this.dataQLTCGrid.MultiSelect = false;
            this.dataQLTCGrid.Name = "dataQLTCGrid";
            this.dataQLTCGrid.PaintEnhancedSelection = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataQLTCGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataQLTCGrid.RowHeadersVisible = false;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dataQLTCGrid.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataQLTCGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataQLTCGrid.RowTemplate.Height = 25;
            this.dataQLTCGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataQLTCGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataQLTCGrid.Size = new System.Drawing.Size(1265, 585);
            this.dataQLTCGrid.TabIndex = 11;
            this.dataQLTCGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataQLTCGrid_CellDoubleClick);
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
            this.dataGridViewTextBoxColumn33.DataPropertyName = "Ngay";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "dd/MM/yy HH:mm:ss";
            this.dataGridViewTextBoxColumn33.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn33.HeaderText = "Ngày";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ReadOnly = true;
            this.dataGridViewTextBoxColumn33.Width = 120;
            // 
            // col_IsPay
            // 
            this.col_IsPay.DataPropertyName = "IsPay";
            this.col_IsPay.HeaderText = "Ispay";
            this.col_IsPay.Name = "col_IsPay";
            this.col_IsPay.ReadOnly = true;
            this.col_IsPay.Visible = false;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "TenLoaiThanhToan";
            this.dataGridViewTextBoxColumn41.HeaderText = "Loại thanh toán";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.ReadOnly = true;
            // 
            // col_BuuCuc
            // 
            this.col_BuuCuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_BuuCuc.DataPropertyName = "BuuCuc";
            this.col_BuuCuc.HeaderText = "Bưu cục";
            this.col_BuuCuc.Name = "col_BuuCuc";
            this.col_BuuCuc.ReadOnly = true;
            this.col_BuuCuc.Width = 200;
            // 
            // col_billCode
            // 
            this.col_billCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_billCode.DataPropertyName = "BillCode";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_billCode.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_billCode.FillWeight = 189.6907F;
            this.col_billCode.HeaderText = "Mã vận đơn";
            this.col_billCode.Name = "col_billCode";
            this.col_billCode.ReadOnly = true;
            // 
            // col_SoDuTruoc
            // 
            this.col_SoDuTruoc.DataPropertyName = "BeforeValue";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            this.col_SoDuTruoc.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_SoDuTruoc.HeaderText = "Số dư trước";
            this.col_SoDuTruoc.Name = "col_SoDuTruoc";
            this.col_SoDuTruoc.ReadOnly = true;
            // 
            // col_QLTCSoTien
            // 
            this.col_QLTCSoTien.DataPropertyName = "Value";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            this.col_QLTCSoTien.DefaultCellStyle = dataGridViewCellStyle6;
            this.col_QLTCSoTien.HeaderText = "Số tiền";
            this.col_QLTCSoTien.Name = "col_QLTCSoTien";
            this.col_QLTCSoTien.ReadOnly = true;
            // 
            // col_TTTonQuy
            // 
            this.col_TTTonQuy.DataPropertyName = "AffterValue";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N0";
            this.col_TTTonQuy.DefaultCellStyle = dataGridViewCellStyle7;
            this.col_TTTonQuy.HeaderText = "Số dư sau";
            this.col_TTTonQuy.Name = "col_TTTonQuy";
            this.col_TTTonQuy.ReadOnly = true;
            // 
            // col_GhiChuTTT
            // 
            this.col_GhiChuTTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_GhiChuTTT.DataPropertyName = "GhiChu";
            this.col_GhiChuTTT.HeaderText = "Ghi chú";
            this.col_GhiChuTTT.Name = "col_GhiChuTTT";
            this.col_GhiChuTTT.ReadOnly = true;
            // 
            // dateTo
            // 
            this.dateTo.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTo.Location = new System.Drawing.Point(233, 40);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(162, 23);
            this.dateTo.TabIndex = 8;
            // 
            // cmbLoaiKetToan
            // 
            this.cmbLoaiKetToan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiKetToan.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoaiKetToan.FormattingEnabled = true;
            this.cmbLoaiKetToan.Location = new System.Drawing.Point(435, 39);
            this.cmbLoaiKetToan.Name = "cmbLoaiKetToan";
            this.cmbLoaiKetToan.Size = new System.Drawing.Size(229, 24);
            this.cmbLoaiKetToan.TabIndex = 7;
            // 
            // dateFrom
            // 
            this.dateFrom.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFrom.Location = new System.Drawing.Point(49, 40);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(159, 23);
            this.dateFrom.TabIndex = 9;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.Black;
            this.label35.Location = new System.Drawing.Point(397, 43);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(39, 17);
            this.label35.TabIndex = 1349;
            this.label35.Text = "Loại:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(210, 43);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(24, 17);
            this.label26.TabIndex = 1343;
            this.label26.Text = "=>";
            // 
            // btnExcel
            // 
            this.btnExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExcel.Enabled = false;
            this.btnExcel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Image = global::LeMaiDesktop.Properties.Resources.iExcel;
            this.btnExcel.ImageTextSpacing = 3;
            this.btnExcel.Location = new System.Drawing.Point(946, 36);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(82, 30);
            this.btnExcel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExcel.TabIndex = 4;
            this.btnExcel.Text = "Xuất Excel";
            this.btnExcel.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnTruyVan
            // 
            this.btnTruyVan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTruyVan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTruyVan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTruyVan.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruyVan.Image = global::LeMaiDesktop.Properties.Resources.iSearch;
            this.btnTruyVan.ImageTextSpacing = 3;
            this.btnTruyVan.Location = new System.Drawing.Point(858, 36);
            this.btnTruyVan.Name = "btnTruyVan";
            this.btnTruyVan.Size = new System.Drawing.Size(83, 30);
            this.btnTruyVan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTruyVan.TabIndex = 2;
            this.btnTruyVan.Text = "Truy vấn";
            this.btnTruyVan.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnTruyVan.Click += new System.EventHandler(this.btnTruyVan_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(5, 43);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(45, 17);
            this.label28.TabIndex = 10;
            this.label28.Text = "Ngày:";
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(670, 40);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(182, 23);
            this.txtFilter.TabIndex = 0;
            // 
            // frmQuanLyKetToanBuuCuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 695);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.dataQLTCGrid);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.cmbLoaiKetToan);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnTruyVan);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.lTieude);
            this.Controls.Add(this.panelcomtrol);
            this.Name = "frmQuanLyKetToanBuuCuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanLyKetToan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQuanLyKetToan_Load);
            this.panelcomtrol.ResumeLayout(false);
            this.panelcomtrol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataQLTCGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelcomtrol;
        private System.Windows.Forms.Label lblSoLuong;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private System.Windows.Forms.Label lTieude;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataQLTCGrid;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.ComboBox cmbLoaiKetToan;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label26;
        private DevComponents.DotNetBar.ButtonX btnExcel;
        private DevComponents.DotNetBar.ButtonX btnTruyVan;
        private System.Windows.Forms.Label label28;
        private DevComponents.DotNetBar.StyleManager styleManager;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_idqltc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IsPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BuuCuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_billCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SoDuTruoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_QLTCSoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TTTonQuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GhiChuTTT;
    }
}