
namespace LeMaiDesktop
{
    partial class frmQuetHangKyNhan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.panelcomtrol = new System.Windows.Forms.Panel();
            this.btnExportExcel = new DevComponents.DotNetBar.ButtonX();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.lTieude = new System.Windows.Forms.Label();
            this.txtMaDonHang = new System.Windows.Forms.TextBox();
            this.lblMaDonHang = new System.Windows.Forms.Label();
            this.grpDangKyKienVanDe = new System.Windows.Forms.GroupBox();
            this.cmbShipper = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFilter = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBillCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.gridBills = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BillCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AcceptMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AcceptManPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AcceptManAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BillWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_RegisterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LastUpdateUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.btnFilter = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.ucBillMain = new LeMaiDesktop.ucBill();
            this.btnKyNhan = new DevComponents.DotNetBar.ButtonX();
            this.panelcomtrol.SuspendLayout();
            this.grpDangKyKienVanDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBills)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // panelcomtrol
            // 
            this.panelcomtrol.BackColor = System.Drawing.Color.SteelBlue;
            this.panelcomtrol.Controls.Add(this.btnExportExcel);
            this.panelcomtrol.Controls.Add(this.lblSoLuong);
            this.panelcomtrol.Controls.Add(this.btnDelete);
            this.panelcomtrol.Controls.Add(this.btnClose);
            this.panelcomtrol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelcomtrol.Location = new System.Drawing.Point(0, 724);
            this.panelcomtrol.Name = "panelcomtrol";
            this.panelcomtrol.Size = new System.Drawing.Size(1271, 39);
            this.panelcomtrol.TabIndex = 4;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExportExcel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.Image = global::LeMaiDesktop.Properties.Resources.iExcel;
            this.btnExportExcel.ImageTextSpacing = 3;
            this.btnExportExcel.Location = new System.Drawing.Point(1023, 4);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(75, 30);
            this.btnExportExcel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExportExcel.TabIndex = 3;
            this.btnExportExcel.Text = "&Excel";
            this.btnExportExcel.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
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
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::LeMaiDesktop.Properties.Resources.iCancel;
            this.btnDelete.ImageTextSpacing = 3;
            this.btnDelete.Location = new System.Drawing.Point(1102, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(69, 30);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "&Xóa";
            this.btnDelete.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::LeMaiDesktop.Properties.Resources.iExit;
            this.btnClose.ImageTextSpacing = 3;
            this.btnClose.Location = new System.Drawing.Point(1174, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 30);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 1;
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
            this.lTieude.Size = new System.Drawing.Size(1271, 30);
            this.lTieude.TabIndex = 75;
            this.lTieude.Text = "    Quản lý đơn hàng ký nhận";
            this.lTieude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaDonHang
            // 
            this.txtMaDonHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(245)))), ((int)(((byte)(176)))));
            this.txtMaDonHang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDonHang.Location = new System.Drawing.Point(416, 20);
            this.txtMaDonHang.MaxLength = 12;
            this.txtMaDonHang.Name = "txtMaDonHang";
            this.txtMaDonHang.Size = new System.Drawing.Size(205, 27);
            this.txtMaDonHang.TabIndex = 0;
            this.txtMaDonHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaDonHang_KeyPress);
            // 
            // lblMaDonHang
            // 
            this.lblMaDonHang.AutoSize = true;
            this.lblMaDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDonHang.ForeColor = System.Drawing.Color.Black;
            this.lblMaDonHang.Location = new System.Drawing.Point(323, 25);
            this.lblMaDonHang.Name = "lblMaDonHang";
            this.lblMaDonHang.Size = new System.Drawing.Size(95, 17);
            this.lblMaDonHang.TabIndex = 78;
            this.lblMaDonHang.Text = "Mã đơn hàng:";
            // 
            // grpDangKyKienVanDe
            // 
            this.grpDangKyKienVanDe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDangKyKienVanDe.Controls.Add(this.btnKyNhan);
            this.grpDangKyKienVanDe.Controls.Add(this.cmbShipper);
            this.grpDangKyKienVanDe.Controls.Add(this.label2);
            this.grpDangKyKienVanDe.Controls.Add(this.txtMaDonHang);
            this.grpDangKyKienVanDe.Controls.Add(this.lblMaDonHang);
            this.grpDangKyKienVanDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDangKyKienVanDe.Location = new System.Drawing.Point(14, 33);
            this.grpDangKyKienVanDe.Name = "grpDangKyKienVanDe";
            this.grpDangKyKienVanDe.Size = new System.Drawing.Size(727, 59);
            this.grpDangKyKienVanDe.TabIndex = 0;
            this.grpDangKyKienVanDe.TabStop = false;
            this.grpDangKyKienVanDe.Text = "Máy quét";
            // 
            // cmbShipper
            // 
            this.cmbShipper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(245)))), ((int)(((byte)(176)))));
            this.cmbShipper.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbShipper.FormattingEnabled = true;
            this.cmbShipper.Location = new System.Drawing.Point(85, 20);
            this.cmbShipper.Name = "cmbShipper";
            this.cmbShipper.Size = new System.Drawing.Size(228, 26);
            this.cmbShipper.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 85;
            this.label2.Text = "Người giao:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(12, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(274, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "TRUY VẤN ĐƠN HÀNG QUÉT KÝ NHẬN";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFilter
            // 
            // 
            // 
            // 
            this.txtFilter.Border.Class = "TextBoxBorder";
            this.txtFilter.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFilter.Location = new System.Drawing.Point(408, 316);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(69, 20);
            this.txtFilter.TabIndex = 3;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtKhachHangFilter_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(15, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 14);
            this.label6.TabIndex = 1;
            this.label6.Text = "Từ ngày:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(331, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 14);
            this.label10.TabIndex = 6;
            this.label10.Text = "Bưu cục gửi:";
            // 
            // cmbFilter
            // 
            this.cmbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(479, 316);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(444, 21);
            this.cmbFilter.TabIndex = 4;
            // 
            // dateTo
            // 
            this.dateTo.CustomFormat = "dd/MM/yyyy";
            this.dateTo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTo.Location = new System.Drawing.Point(232, 315);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(95, 22);
            this.dateTo.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(176, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 14);
            this.label9.TabIndex = 8;
            this.label9.Text = "đến ngày";
            // 
            // dateFrom
            // 
            this.dateFrom.CustomFormat = "dd/MM/yyyy";
            this.dateFrom.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFrom.Location = new System.Drawing.Point(78, 315);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(95, 22);
            this.dateFrom.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(925, 319);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 15);
            this.label12.TabIndex = 1418;
            this.label12.Text = "Mã vận đơn:";
            // 
            // txtBillCode
            // 
            this.txtBillCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtBillCode.Border.Class = "TextBoxBorder";
            this.txtBillCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBillCode.Location = new System.Drawing.Point(998, 316);
            this.txtBillCode.Name = "txtBillCode";
            this.txtBillCode.Size = new System.Drawing.Size(175, 20);
            this.txtBillCode.TabIndex = 5;
            // 
            // gridBills
            // 
            this.gridBills.AllowUserToAddRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.gridBills.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.gridBills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridBills.ColumnHeadersHeight = 25;
            this.gridBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Id,
            this.col_BillCode,
            this.col_AcceptMan,
            this.col_AcceptManPhone,
            this.col_AcceptManAddress,
            this.col_BillWeight,
            this.col_RegisterDate,
            this.col_LastUpdateUser,
            this.col_Note});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridBills.DefaultCellStyle = dataGridViewCellStyle12;
            this.gridBills.EnableHeadersVisualStyles = false;
            this.gridBills.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.gridBills.HighlightSelectedColumnHeaders = false;
            this.gridBills.Location = new System.Drawing.Point(2, 353);
            this.gridBills.MultiSelect = false;
            this.gridBills.Name = "gridBills";
            this.gridBills.PaintEnhancedSelection = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBills.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.gridBills.RowHeadersVisible = false;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            this.gridBills.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.gridBills.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBills.RowTemplate.Height = 25;
            this.gridBills.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridBills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBills.Size = new System.Drawing.Size(1268, 370);
            this.gridBills.TabIndex = 2;
            this.gridBills.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBills_CellDoubleClick);
            // 
            // col_Id
            // 
            this.col_Id.DataPropertyName = "Id";
            this.col_Id.HeaderText = "Id";
            this.col_Id.Name = "col_Id";
            this.col_Id.ReadOnly = true;
            this.col_Id.Visible = false;
            // 
            // col_BillCode
            // 
            this.col_BillCode.DataPropertyName = "BillCode";
            this.col_BillCode.HeaderText = "Mã đơn hàng";
            this.col_BillCode.Name = "col_BillCode";
            this.col_BillCode.ReadOnly = true;
            this.col_BillCode.Width = 90;
            // 
            // col_AcceptMan
            // 
            this.col_AcceptMan.DataPropertyName = "AcceptMan";
            this.col_AcceptMan.HeaderText = "Người nhận";
            this.col_AcceptMan.Name = "col_AcceptMan";
            this.col_AcceptMan.ReadOnly = true;
            // 
            // col_AcceptManPhone
            // 
            this.col_AcceptManPhone.DataPropertyName = "AcceptManPhone";
            this.col_AcceptManPhone.HeaderText = "SĐT Nhận";
            this.col_AcceptManPhone.Name = "col_AcceptManPhone";
            this.col_AcceptManPhone.ReadOnly = true;
            // 
            // col_AcceptManAddress
            // 
            this.col_AcceptManAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_AcceptManAddress.DataPropertyName = "AcceptProvince";
            this.col_AcceptManAddress.HeaderText = "Địa chỉ nhận";
            this.col_AcceptManAddress.Name = "col_AcceptManAddress";
            this.col_AcceptManAddress.ReadOnly = true;
            this.col_AcceptManAddress.Width = 300;
            // 
            // col_BillWeight
            // 
            this.col_BillWeight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_BillWeight.DataPropertyName = "BillWeight";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N0";
            this.col_BillWeight.DefaultCellStyle = dataGridViewCellStyle10;
            this.col_BillWeight.HeaderText = "TL Ghi đơn";
            this.col_BillWeight.Name = "col_BillWeight";
            this.col_BillWeight.ReadOnly = true;
            this.col_BillWeight.Width = 60;
            // 
            // col_RegisterDate
            // 
            this.col_RegisterDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_RegisterDate.DataPropertyName = "CreateDate";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.Format = "dd/MM HH:mm";
            this.col_RegisterDate.DefaultCellStyle = dataGridViewCellStyle11;
            this.col_RegisterDate.HeaderText = "Ngày tạo";
            this.col_RegisterDate.Name = "col_RegisterDate";
            this.col_RegisterDate.ReadOnly = true;
            this.col_RegisterDate.Width = 80;
            // 
            // col_LastUpdateUser
            // 
            this.col_LastUpdateUser.DataPropertyName = "NameCreate";
            this.col_LastUpdateUser.HeaderText = "Người đăng ký";
            this.col_LastUpdateUser.Name = "col_LastUpdateUser";
            this.col_LastUpdateUser.ReadOnly = true;
            // 
            // col_Note
            // 
            this.col_Note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Note.DataPropertyName = "Note";
            this.col_Note.HeaderText = "Ghi chú";
            this.col_Note.Name = "col_Note";
            this.col_Note.ReadOnly = true;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(197, 276);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(876, 3);
            this.label11.TabIndex = 1419;
            // 
            // btnFilter
            // 
            this.btnFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFilter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Image = global::LeMaiDesktop.Properties.Resources.iSearch;
            this.btnFilter.ImageTextSpacing = 3;
            this.btnFilter.Location = new System.Drawing.Point(1179, 311);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(86, 30);
            this.btnFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = "Truy vấn";
            this.btnFilter.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(827, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 49);
            this.label1.TabIndex = 1420;
            this.label1.Text = "Bưu cục cân kiểm tra đối chiếu thông tin trước khi ký nhận đơn hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucBillMain
            // 
            this.ucBillMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucBillMain.Location = new System.Drawing.Point(13, 94);
            this.ucBillMain.Name = "ucBillMain";
            this.ucBillMain.Size = new System.Drawing.Size(1242, 168);
            this.ucBillMain.TabIndex = 1214;
            // 
            // btnKyNhan
            // 
            this.btnKyNhan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnKyNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKyNhan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnKyNhan.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKyNhan.Image = global::LeMaiDesktop.Properties.Resources.Done;
            this.btnKyNhan.ImageTextSpacing = 3;
            this.btnKyNhan.Location = new System.Drawing.Point(632, 18);
            this.btnKyNhan.Name = "btnKyNhan";
            this.btnKyNhan.Size = new System.Drawing.Size(86, 30);
            this.btnKyNhan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnKyNhan.TabIndex = 87;
            this.btnKyNhan.Text = "Ký nhận";
            this.btnKyNhan.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnKyNhan.Click += new System.EventHandler(this.btnKyNhan_Click);
            // 
            // frmQuetHangKyNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 763);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ucBillMain);
            this.Controls.Add(this.gridBills);
            this.Controls.Add(this.txtBillCode);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grpDangKyKienVanDe);
            this.Controls.Add(this.lTieude);
            this.Controls.Add(this.panelcomtrol);
            this.Name = "frmQuetHangKyNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hành trình đơn hàng";
            this.Load += new System.EventHandler(this.frmQuanLyHanhTrinh_Load);
            this.panelcomtrol.ResumeLayout(false);
            this.panelcomtrol.PerformLayout();
            this.grpDangKyKienVanDe.ResumeLayout(false);
            this.grpDangKyKienVanDe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager;
        private System.Windows.Forms.Panel panelcomtrol;
        private System.Windows.Forms.Label lblSoLuong;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private System.Windows.Forms.Label lTieude;
        private System.Windows.Forms.TextBox txtMaDonHang;
        private System.Windows.Forms.Label lblMaDonHang;
        private System.Windows.Forms.GroupBox grpDangKyKienVanDe;
        private System.Windows.Forms.Label label7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label label9;
        private DevComponents.DotNetBar.ButtonX btnFilter;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label label12;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBillCode;
        private DevComponents.DotNetBar.Controls.DataGridViewX gridBills;
        private ucBill ucBillMain;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbShipper;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.ButtonX btnExportExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BillCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AcceptMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AcceptManPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AcceptManAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BillWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RegisterDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LastUpdateUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Note;
        private DevComponents.DotNetBar.ButtonX btnKyNhan;
    }
}