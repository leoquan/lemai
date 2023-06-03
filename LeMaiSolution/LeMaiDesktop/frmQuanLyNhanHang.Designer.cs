namespace LeMaiDesktop
{
	partial class frmQuanLyNhanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelcomtrol = new System.Windows.Forms.Panel();
            this.txtSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnNew = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.lTieude = new System.Windows.Forms.Label();
            this.gridMain = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.cmbFK_CustomerId = new System.Windows.Forms.ComboBox();
            this.cmbFK_ShipperId = new System.Windows.Forms.ComboBox();
            this.txtGoodsNumber = new System.Windows.Forms.TextBox();
            this.chbHaveReturn = new System.Windows.Forms.CheckBox();
            this.txtNote = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtKHFilter = new System.Windows.Forms.TextBox();
            this.txtShipperFilter = new System.Windows.Forms.TextBox();
            this.lblFK_CustomerId = new System.Windows.Forms.Label();
            this.lblFK_ShipperId = new System.Windows.Forms.Label();
            this.lblGoodsNumber = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.datePickup = new System.Windows.Forms.DateTimePicker();
            this.timerFilterKH = new System.Windows.Forms.Timer(this.components);
            this.col_StatusReceiveName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FK_CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FK_ShipperId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FK_Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FK_Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CustomerCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CustomerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GoodsNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HaveReturn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_ShipperName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ShipperPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenDaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GoogleMap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NVGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_StatusTextColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_StatusBackgroundColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FK_PickupShipper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PickupDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelcomtrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panelcomtrol
            // 
            this.panelcomtrol.BackColor = System.Drawing.Color.SteelBlue;
            this.panelcomtrol.Controls.Add(this.txtSearch);
            this.panelcomtrol.Controls.Add(this.btnNew);
            this.panelcomtrol.Controls.Add(this.btnSave);
            this.panelcomtrol.Controls.Add(this.btnEdit);
            this.panelcomtrol.Controls.Add(this.btnDelete);
            this.panelcomtrol.Controls.Add(this.btnClose);
            this.panelcomtrol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelcomtrol.Location = new System.Drawing.Point(0, 561);
            this.panelcomtrol.Name = "panelcomtrol";
            this.panelcomtrol.Size = new System.Drawing.Size(925, 39);
            this.panelcomtrol.TabIndex = 7;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.Border.Class = "TextBoxBorder";
            this.txtSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearch.FocusHighlightColor = System.Drawing.Color.Empty;
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(9, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(252, 21);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.WatermarkColor = System.Drawing.Color.Maroon;
            this.txtSearch.WatermarkFont = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.WatermarkText = "Tìm kiếm...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnNew
            // 
            this.btnNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = global::LeMaiDesktop.Properties.Resources.iNew;
            this.btnNew.ImageTextSpacing = 3;
            this.btnNew.Location = new System.Drawing.Point(514, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(77, 30);
            this.btnNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "&Mới";
            this.btnNew.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::LeMaiDesktop.Properties.Resources.iSave;
            this.btnSave.ImageTextSpacing = 3;
            this.btnSave.Location = new System.Drawing.Point(673, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&Lưu";
            this.btnSave.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = global::LeMaiDesktop.Properties.Resources.iEdit;
            this.btnEdit.ImageTextSpacing = 3;
            this.btnEdit.Location = new System.Drawing.Point(592, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 30);
            this.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "&Sửa";
            this.btnEdit.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::LeMaiDesktop.Properties.Resources.iCancel;
            this.btnDelete.ImageTextSpacing = 3;
            this.btnDelete.Location = new System.Drawing.Point(749, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 30);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.TabIndex = 3;
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
            this.btnClose.Location = new System.Drawing.Point(829, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 30);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 4;
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
            this.lTieude.Size = new System.Drawing.Size(925, 30);
            this.lTieude.TabIndex = 9;
            this.lTieude.Text = "    Danh sách nhận hàng";
            this.lTieude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gridMain
            // 
            this.gridMain.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.gridMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridMain.ColumnHeadersHeight = 25;
            this.gridMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_StatusReceiveName,
            this.col_Id,
            this.col_FK_CustomerId,
            this.col_FK_ShipperId,
            this.col_FK_Post,
            this.col_FK_Account,
            this.col_CustomerCode,
            this.col_CustomerName,
            this.col_CustomerPhone,
            this.col_DiaChi,
            this.col_GoodsNumber,
            this.col_HaveReturn,
            this.col_ShipperName,
            this.col_ShipperPhone,
            this.col_TenDaiLy,
            this.col_GoogleMap,
            this.col_NVGiao,
            this.col_StatusTextColor,
            this.col_StatusBackgroundColor,
            this.col_FK_PickupShipper,
            this.col_PickupDate,
            this.col_CreateDate,
            this.col_Note});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMain.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridMain.EnableHeadersVisualStyles = false;
            this.gridMain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.gridMain.HighlightSelectedColumnHeaders = false;
            this.gridMain.Location = new System.Drawing.Point(3, 33);
            this.gridMain.MultiSelect = false;
            this.gridMain.Name = "gridMain";
            this.gridMain.PaintEnhancedSelection = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridMain.RowHeadersVisible = false;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.gridMain.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.gridMain.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridMain.RowTemplate.Height = 25;
            this.gridMain.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMain.Size = new System.Drawing.Size(922, 375);
            this.gridMain.TabIndex = 8;
            this.gridMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMain_CellDoubleClick);
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            this.highlighter.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Green;
            // 
            // cmbFK_CustomerId
            // 
            this.cmbFK_CustomerId.FormattingEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.cmbFK_CustomerId, true);
            this.cmbFK_CustomerId.Location = new System.Drawing.Point(202, 437);
            this.cmbFK_CustomerId.Name = "cmbFK_CustomerId";
            this.cmbFK_CustomerId.Size = new System.Drawing.Size(257, 21);
            this.cmbFK_CustomerId.TabIndex = 1;
            // 
            // cmbFK_ShipperId
            // 
            this.cmbFK_ShipperId.FormattingEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.cmbFK_ShipperId, true);
            this.cmbFK_ShipperId.Location = new System.Drawing.Point(664, 437);
            this.cmbFK_ShipperId.Name = "cmbFK_ShipperId";
            this.cmbFK_ShipperId.Size = new System.Drawing.Size(253, 21);
            this.cmbFK_ShipperId.TabIndex = 3;
            // 
            // txtGoodsNumber
            // 
            this.txtGoodsNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtGoodsNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtGoodsNumber.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtGoodsNumber, true);
            this.txtGoodsNumber.Location = new System.Drawing.Point(88, 467);
            this.txtGoodsNumber.Name = "txtGoodsNumber";
            this.txtGoodsNumber.Size = new System.Drawing.Size(111, 22);
            this.txtGoodsNumber.TabIndex = 4;
            this.txtGoodsNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGoodsNumber_KeyPress);
            this.txtGoodsNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGoodsNumber_KeyUp);
            // 
            // chbHaveReturn
            // 
            this.chbHaveReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chbHaveReturn.AutoSize = true;
            this.chbHaveReturn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbHaveReturn.ForeColor = System.Drawing.Color.Red;
            this.highlighter.SetHighlightOnFocus(this.chbHaveReturn, true);
            this.chbHaveReturn.Location = new System.Drawing.Point(205, 469);
            this.chbHaveReturn.Name = "chbHaveReturn";
            this.chbHaveReturn.Size = new System.Drawing.Size(127, 18);
            this.chbHaveReturn.TabIndex = 5;
            this.chbHaveReturn.Text = "Có đơn hàng hoàn";
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNote.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.txtNote.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNote.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtNote, true);
            this.txtNote.Location = new System.Drawing.Point(88, 498);
            this.txtNote.MaxLength = 500;
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(829, 53);
            this.txtNote.TabIndex = 6;
            this.txtNote.WatermarkText = "Ghi chú cho người lấy hàng VD: Lấy hàng trước 11h, Mang 2 cây keo, Phiếu in...";
            this.txtNote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNote_KeyPress);
            // 
            // txtKHFilter
            // 
            this.txtKHFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtKHFilter.BackColor = System.Drawing.SystemColors.Window;
            this.txtKHFilter.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtKHFilter, true);
            this.txtKHFilter.Location = new System.Drawing.Point(88, 436);
            this.txtKHFilter.MaxLength = 500;
            this.txtKHFilter.Name = "txtKHFilter";
            this.txtKHFilter.Size = new System.Drawing.Size(111, 22);
            this.txtKHFilter.TabIndex = 0;
            this.txtKHFilter.TextChanged += new System.EventHandler(this.txtKHFilter_TextChanged);
            // 
            // txtShipperFilter
            // 
            this.txtShipperFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtShipperFilter.BackColor = System.Drawing.SystemColors.Window;
            this.txtShipperFilter.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtShipperFilter, true);
            this.txtShipperFilter.Location = new System.Drawing.Point(551, 436);
            this.txtShipperFilter.MaxLength = 500;
            this.txtShipperFilter.Name = "txtShipperFilter";
            this.txtShipperFilter.Size = new System.Drawing.Size(111, 22);
            this.txtShipperFilter.TabIndex = 2;
            this.txtShipperFilter.TextChanged += new System.EventHandler(this.txtShipperFilter_TextChanged);
            // 
            // lblFK_CustomerId
            // 
            this.lblFK_CustomerId.AutoSize = true;
            this.lblFK_CustomerId.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFK_CustomerId.ForeColor = System.Drawing.Color.Black;
            this.lblFK_CustomerId.Location = new System.Drawing.Point(11, 440);
            this.lblFK_CustomerId.Name = "lblFK_CustomerId";
            this.lblFK_CustomerId.Size = new System.Drawing.Size(75, 14);
            this.lblFK_CustomerId.TabIndex = 11;
            this.lblFK_CustomerId.Text = "Khách hàng:";
            // 
            // lblFK_ShipperId
            // 
            this.lblFK_ShipperId.AutoSize = true;
            this.lblFK_ShipperId.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFK_ShipperId.ForeColor = System.Drawing.Color.Black;
            this.lblFK_ShipperId.Location = new System.Drawing.Point(470, 440);
            this.lblFK_ShipperId.Name = "lblFK_ShipperId";
            this.lblFK_ShipperId.Size = new System.Drawing.Size(80, 14);
            this.lblFK_ShipperId.TabIndex = 14;
            this.lblFK_ShipperId.Text = "NV Lấy hàng:";
            // 
            // lblGoodsNumber
            // 
            this.lblGoodsNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGoodsNumber.AutoSize = true;
            this.lblGoodsNumber.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoodsNumber.ForeColor = System.Drawing.Color.Black;
            this.lblGoodsNumber.Location = new System.Drawing.Point(1, 471);
            this.lblGoodsNumber.Name = "lblGoodsNumber";
            this.lblGoodsNumber.Size = new System.Drawing.Size(85, 14);
            this.lblGoodsNumber.TabIndex = 12;
            this.lblGoodsNumber.Text = "Số lượng đơn:";
            // 
            // lblNote
            // 
            this.lblNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.Black;
            this.lblNote.Location = new System.Drawing.Point(34, 517);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(52, 14);
            this.lblNote.TabIndex = 13;
            this.lblNote.Text = "Ghi chú:";
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // datePickup
            // 
            this.datePickup.CustomFormat = "dd/MM/yyyy";
            this.datePickup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickup.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickup.Location = new System.Drawing.Point(766, 4);
            this.datePickup.Name = "datePickup";
            this.datePickup.Size = new System.Drawing.Size(111, 23);
            this.datePickup.TabIndex = 10;
            this.datePickup.ValueChanged += new System.EventHandler(this.datePickup_ValueChanged);
            // 
            // timerFilterKH
            // 
            this.timerFilterKH.Interval = 500;
            this.timerFilterKH.Tick += new System.EventHandler(this.timerFilterKH_Tick);
            // 
            // col_StatusReceiveName
            // 
            this.col_StatusReceiveName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_StatusReceiveName.DataPropertyName = "StatusReceiveName";
            this.col_StatusReceiveName.HeaderText = "Tình trạng";
            this.col_StatusReceiveName.Name = "col_StatusReceiveName";
            this.col_StatusReceiveName.ReadOnly = true;
            this.col_StatusReceiveName.Width = 120;
            // 
            // col_Id
            // 
            this.col_Id.DataPropertyName = "Id";
            this.col_Id.HeaderText = "Id";
            this.col_Id.Name = "col_Id";
            this.col_Id.ReadOnly = true;
            this.col_Id.Visible = false;
            // 
            // col_FK_CustomerId
            // 
            this.col_FK_CustomerId.DataPropertyName = "FK_CustomerId";
            this.col_FK_CustomerId.HeaderText = "FK_CustomerId";
            this.col_FK_CustomerId.Name = "col_FK_CustomerId";
            this.col_FK_CustomerId.ReadOnly = true;
            this.col_FK_CustomerId.Visible = false;
            // 
            // col_FK_ShipperId
            // 
            this.col_FK_ShipperId.DataPropertyName = "FK_ShipperId";
            this.col_FK_ShipperId.HeaderText = "FK_ShipperId";
            this.col_FK_ShipperId.Name = "col_FK_ShipperId";
            this.col_FK_ShipperId.ReadOnly = true;
            this.col_FK_ShipperId.Visible = false;
            // 
            // col_FK_Post
            // 
            this.col_FK_Post.DataPropertyName = "FK_Post";
            this.col_FK_Post.HeaderText = "FK_Post";
            this.col_FK_Post.Name = "col_FK_Post";
            this.col_FK_Post.ReadOnly = true;
            this.col_FK_Post.Visible = false;
            // 
            // col_FK_Account
            // 
            this.col_FK_Account.DataPropertyName = "FK_Account";
            this.col_FK_Account.HeaderText = "FK_Account";
            this.col_FK_Account.Name = "col_FK_Account";
            this.col_FK_Account.ReadOnly = true;
            this.col_FK_Account.Visible = false;
            // 
            // col_CustomerCode
            // 
            this.col_CustomerCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_CustomerCode.DataPropertyName = "CustomerCode";
            this.col_CustomerCode.HeaderText = "Mã KH";
            this.col_CustomerCode.Name = "col_CustomerCode";
            this.col_CustomerCode.ReadOnly = true;
            this.col_CustomerCode.Width = 60;
            // 
            // col_CustomerName
            // 
            this.col_CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_CustomerName.DataPropertyName = "CustomerName";
            this.col_CustomerName.HeaderText = "Khách hàng";
            this.col_CustomerName.Name = "col_CustomerName";
            this.col_CustomerName.ReadOnly = true;
            this.col_CustomerName.Width = 200;
            // 
            // col_CustomerPhone
            // 
            this.col_CustomerPhone.DataPropertyName = "CustomerPhone";
            this.col_CustomerPhone.HeaderText = "SĐT Khách hàng";
            this.col_CustomerPhone.Name = "col_CustomerPhone";
            this.col_CustomerPhone.ReadOnly = true;
            // 
            // col_DiaChi
            // 
            this.col_DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_DiaChi.DataPropertyName = "DiaChi";
            this.col_DiaChi.HeaderText = "Địa chỉ";
            this.col_DiaChi.Name = "col_DiaChi";
            this.col_DiaChi.ReadOnly = true;
            this.col_DiaChi.Width = 250;
            // 
            // col_GoodsNumber
            // 
            this.col_GoodsNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_GoodsNumber.DataPropertyName = "GoodsNumber";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            this.col_GoodsNumber.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_GoodsNumber.HeaderText = "SL";
            this.col_GoodsNumber.Name = "col_GoodsNumber";
            this.col_GoodsNumber.ReadOnly = true;
            this.col_GoodsNumber.Width = 50;
            // 
            // col_HaveReturn
            // 
            this.col_HaveReturn.DataPropertyName = "HaveReturn";
            this.col_HaveReturn.HeaderText = "Có hàng trả";
            this.col_HaveReturn.Name = "col_HaveReturn";
            this.col_HaveReturn.ReadOnly = true;
            this.col_HaveReturn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_HaveReturn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // col_ShipperName
            // 
            this.col_ShipperName.DataPropertyName = "ShipperName";
            this.col_ShipperName.HeaderText = "NV Nhận hàng";
            this.col_ShipperName.Name = "col_ShipperName";
            this.col_ShipperName.ReadOnly = true;
            // 
            // col_ShipperPhone
            // 
            this.col_ShipperPhone.DataPropertyName = "ShipperPhone";
            this.col_ShipperPhone.HeaderText = "SĐT";
            this.col_ShipperPhone.Name = "col_ShipperPhone";
            this.col_ShipperPhone.ReadOnly = true;
            // 
            // col_TenDaiLy
            // 
            this.col_TenDaiLy.DataPropertyName = "TenDaiLy";
            this.col_TenDaiLy.HeaderText = "TenDaiLy";
            this.col_TenDaiLy.Name = "col_TenDaiLy";
            this.col_TenDaiLy.ReadOnly = true;
            this.col_TenDaiLy.Visible = false;
            // 
            // col_GoogleMap
            // 
            this.col_GoogleMap.DataPropertyName = "GoogleMap";
            this.col_GoogleMap.HeaderText = "GoogleMap";
            this.col_GoogleMap.Name = "col_GoogleMap";
            this.col_GoogleMap.ReadOnly = true;
            this.col_GoogleMap.Visible = false;
            // 
            // col_NVGiao
            // 
            this.col_NVGiao.DataPropertyName = "NVGiao";
            this.col_NVGiao.HeaderText = "NV Tạo";
            this.col_NVGiao.Name = "col_NVGiao";
            this.col_NVGiao.ReadOnly = true;
            // 
            // col_StatusTextColor
            // 
            this.col_StatusTextColor.DataPropertyName = "StatusTextColor";
            this.col_StatusTextColor.HeaderText = "StatusTextColor";
            this.col_StatusTextColor.Name = "col_StatusTextColor";
            this.col_StatusTextColor.ReadOnly = true;
            this.col_StatusTextColor.Visible = false;
            // 
            // col_StatusBackgroundColor
            // 
            this.col_StatusBackgroundColor.DataPropertyName = "StatusBackgroundColor";
            this.col_StatusBackgroundColor.HeaderText = "StatusBackgroundColor";
            this.col_StatusBackgroundColor.Name = "col_StatusBackgroundColor";
            this.col_StatusBackgroundColor.ReadOnly = true;
            this.col_StatusBackgroundColor.Visible = false;
            // 
            // col_FK_PickupShipper
            // 
            this.col_FK_PickupShipper.DataPropertyName = "FK_PickupShipper";
            this.col_FK_PickupShipper.HeaderText = "FK_PickupShipper";
            this.col_FK_PickupShipper.Name = "col_FK_PickupShipper";
            this.col_FK_PickupShipper.ReadOnly = true;
            this.col_FK_PickupShipper.Visible = false;
            // 
            // col_PickupDate
            // 
            this.col_PickupDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_PickupDate.DataPropertyName = "PickupDate";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "dd/MM/yyyy HH:mm";
            this.col_PickupDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_PickupDate.HeaderText = "Thời gian nhận";
            this.col_PickupDate.Name = "col_PickupDate";
            this.col_PickupDate.ReadOnly = true;
            this.col_PickupDate.Width = 120;
            // 
            // col_CreateDate
            // 
            this.col_CreateDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_CreateDate.DataPropertyName = "CreateDate";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "dd/MM/yyyy HH:mm";
            this.col_CreateDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_CreateDate.HeaderText = "Thời gian";
            this.col_CreateDate.Name = "col_CreateDate";
            this.col_CreateDate.ReadOnly = true;
            this.col_CreateDate.Width = 120;
            // 
            // col_Note
            // 
            this.col_Note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Note.DataPropertyName = "Note";
            this.col_Note.HeaderText = "Ghi chú";
            this.col_Note.Name = "col_Note";
            this.col_Note.ReadOnly = true;
            this.col_Note.Width = 250;
            // 
            // frmQuanLyNhanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(925, 600);
            this.Controls.Add(this.txtShipperFilter);
            this.Controls.Add(this.datePickup);
            this.Controls.Add(this.txtKHFilter);
            this.Controls.Add(this.gridMain);
            this.Controls.Add(this.panelcomtrol);
            this.Controls.Add(this.lTieude);
            this.Controls.Add(this.cmbFK_CustomerId);
            this.Controls.Add(this.cmbFK_ShipperId);
            this.Controls.Add(this.txtGoodsNumber);
            this.Controls.Add(this.chbHaveReturn);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.lblFK_CustomerId);
            this.Controls.Add(this.lblFK_ShipperId);
            this.Controls.Add(this.lblGoodsNumber);
            this.Controls.Add(this.lblNote);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuanLyNhanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhận hàng";
            this.Load += new System.EventHandler(this.frmQuanLyNhanHang_Load);
            this.panelcomtrol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panelcomtrol;
		private System.Windows.Forms.Label lTieude;
		private DevComponents.DotNetBar.ButtonX btnClose;
		private DevComponents.DotNetBar.ButtonX btnDelete;
		private DevComponents.DotNetBar.ButtonX btnNew;
		private DevComponents.DotNetBar.ButtonX btnSave;
		private DevComponents.DotNetBar.ButtonX btnEdit;
		private DevComponents.DotNetBar.Controls.DataGridViewX gridMain;
		private DevComponents.DotNetBar.Controls.TextBoxX txtSearch;
		private DevComponents.DotNetBar.Validator.Highlighter highlighter;
		private System.Windows.Forms.Label lblFK_CustomerId;
		private System.Windows.Forms.ComboBox cmbFK_CustomerId;
		private System.Windows.Forms.Label lblFK_ShipperId;
		private System.Windows.Forms.ComboBox cmbFK_ShipperId;
		private System.Windows.Forms.Label lblGoodsNumber;
		private System.Windows.Forms.TextBox txtGoodsNumber;
		private System.Windows.Forms.CheckBox chbHaveReturn;
		private System.Windows.Forms.Label lblNote;
		private DevComponents.DotNetBar.Controls.TextBoxX txtNote;
        private DevComponents.DotNetBar.StyleManager styleManager;
        private System.Windows.Forms.TextBox txtKHFilter;
        private System.Windows.Forms.DateTimePicker datePickup;
        private System.Windows.Forms.Timer timerFilterKH;
        private System.Windows.Forms.TextBox txtShipperFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_StatusReceiveName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_ShipperId;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_Post;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CustomerCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CustomerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GoodsNumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_HaveReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ShipperName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ShipperPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GoogleMap;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NVGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_StatusTextColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_StatusBackgroundColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_PickupShipper;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PickupDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Note;
    }
}
