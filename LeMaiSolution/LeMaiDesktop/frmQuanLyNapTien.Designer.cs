namespace LeMaiDesktop
{
	partial class frmQuanLyNapTien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelcomtrol = new System.Windows.Forms.Panel();
            this.btnXacNhan = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.lTieude = new System.Windows.Forms.Label();
            this.gridMain = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FK_Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FK_RequestAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FK_PostResponse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DaiLyYeuCau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DaiLyXuLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_RequestCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BankAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BankOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IsConfirm = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_ConfirmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ReSoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FK_Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NguoiYeuCau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NguoiXuLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.cmbLoai = new System.Windows.Forms.ComboBox();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.label35 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.btnExcel = new DevComponents.DotNetBar.ButtonX();
            this.btnTruyVan = new DevComponents.DotNetBar.ButtonX();
            this.label28 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelcomtrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panelcomtrol
            // 
            this.panelcomtrol.BackColor = System.Drawing.Color.SteelBlue;
            this.panelcomtrol.Controls.Add(this.btnXacNhan);
            this.panelcomtrol.Controls.Add(this.btnClose);
            this.panelcomtrol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelcomtrol.Location = new System.Drawing.Point(0, 640);
            this.panelcomtrol.Name = "panelcomtrol";
            this.panelcomtrol.Size = new System.Drawing.Size(1149, 39);
            this.panelcomtrol.TabIndex = 299;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXacNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXacNhan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXacNhan.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Image = global::LeMaiDesktop.Properties.Resources.Done;
            this.btnXacNhan.ImageTextSpacing = 3;
            this.btnXacNhan.Location = new System.Drawing.Point(906, 5);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(143, 30);
            this.btnXacNhan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXacNhan.TabIndex = 1275;
            this.btnXacNhan.Text = "Xác nhận nạp tiền";
            this.btnXacNhan.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::LeMaiDesktop.Properties.Resources.iExit;
            this.btnClose.ImageTextSpacing = 3;
            this.btnClose.Location = new System.Drawing.Point(1052, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 30);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 1166;
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
            this.lTieude.Size = new System.Drawing.Size(1149, 30);
            this.lTieude.TabIndex = 300;
            this.lTieude.Text = "    Danh sách yêu cầu nạp tiền";
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
            this.col_Id,
            this.col_FK_Post,
            this.col_FK_RequestAccount,
            this.col_FK_PostResponse,
            this.col_CreateDate,
            this.col_DaiLyYeuCau,
            this.col_DaiLyXuLy,
            this.col_RequestCode,
            this.col_SoTien,
            this.col_BankAccount,
            this.col_BankName,
            this.col_BankOwner,
            this.col_Note,
            this.col_IsConfirm,
            this.col_ConfirmDate,
            this.col_ReSoTien,
            this.col_FK_Account,
            this.col_NguoiYeuCau,
            this.col_NguoiXuLy});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMain.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridMain.EnableHeadersVisualStyles = false;
            this.gridMain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.gridMain.HighlightSelectedColumnHeaders = false;
            this.gridMain.Location = new System.Drawing.Point(3, 69);
            this.gridMain.MultiSelect = false;
            this.gridMain.Name = "gridMain";
            this.gridMain.PaintEnhancedSelection = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridMain.RowHeadersVisible = false;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.gridMain.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gridMain.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridMain.RowTemplate.Height = 25;
            this.gridMain.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMain.Size = new System.Drawing.Size(1146, 570);
            this.gridMain.TabIndex = 1164;
            this.gridMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMain_CellDoubleClick);
            // 
            // col_Id
            // 
            this.col_Id.DataPropertyName = "Id";
            this.col_Id.HeaderText = "Id";
            this.col_Id.Name = "col_Id";
            this.col_Id.ReadOnly = true;
            this.col_Id.Visible = false;
            // 
            // col_FK_Post
            // 
            this.col_FK_Post.DataPropertyName = "FK_Post";
            this.col_FK_Post.HeaderText = "FK_Post";
            this.col_FK_Post.Name = "col_FK_Post";
            this.col_FK_Post.ReadOnly = true;
            this.col_FK_Post.Visible = false;
            // 
            // col_FK_RequestAccount
            // 
            this.col_FK_RequestAccount.DataPropertyName = "FK_RequestAccount";
            this.col_FK_RequestAccount.HeaderText = "FK_RequestAccount";
            this.col_FK_RequestAccount.Name = "col_FK_RequestAccount";
            this.col_FK_RequestAccount.ReadOnly = true;
            this.col_FK_RequestAccount.Visible = false;
            // 
            // col_FK_PostResponse
            // 
            this.col_FK_PostResponse.DataPropertyName = "FK_PostResponse";
            this.col_FK_PostResponse.HeaderText = "FK_PostResponse";
            this.col_FK_PostResponse.Name = "col_FK_PostResponse";
            this.col_FK_PostResponse.ReadOnly = true;
            this.col_FK_PostResponse.Visible = false;
            // 
            // col_CreateDate
            // 
            this.col_CreateDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_CreateDate.DataPropertyName = "CreateDate";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Format = "dd/MM/yyyy HH:mm:ss";
            this.col_CreateDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_CreateDate.HeaderText = "Ngày tạo lệnh";
            this.col_CreateDate.Name = "col_CreateDate";
            this.col_CreateDate.ReadOnly = true;
            this.col_CreateDate.Width = 130;
            // 
            // col_DaiLyYeuCau
            // 
            this.col_DaiLyYeuCau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_DaiLyYeuCau.DataPropertyName = "DaiLyYeuCau";
            this.col_DaiLyYeuCau.HeaderText = "Đại lý nạp tiền";
            this.col_DaiLyYeuCau.Name = "col_DaiLyYeuCau";
            this.col_DaiLyYeuCau.ReadOnly = true;
            this.col_DaiLyYeuCau.Width = 200;
            // 
            // col_DaiLyXuLy
            // 
            this.col_DaiLyXuLy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_DaiLyXuLy.DataPropertyName = "DaiLyXuLy";
            this.col_DaiLyXuLy.HeaderText = "Đại lý nhận tiền";
            this.col_DaiLyXuLy.Name = "col_DaiLyXuLy";
            this.col_DaiLyXuLy.ReadOnly = true;
            this.col_DaiLyXuLy.Width = 200;
            // 
            // col_RequestCode
            // 
            this.col_RequestCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_RequestCode.DataPropertyName = "RequestCode";
            this.col_RequestCode.HeaderText = "Mã nạp tiền";
            this.col_RequestCode.Name = "col_RequestCode";
            this.col_RequestCode.ReadOnly = true;
            this.col_RequestCode.Width = 80;
            // 
            // col_SoTien
            // 
            this.col_SoTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_SoTien.DataPropertyName = "SoTien";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            this.col_SoTien.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_SoTien.HeaderText = "Số tiền";
            this.col_SoTien.Name = "col_SoTien";
            this.col_SoTien.ReadOnly = true;
            this.col_SoTien.Width = 80;
            // 
            // col_BankAccount
            // 
            this.col_BankAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_BankAccount.DataPropertyName = "BankAccount";
            this.col_BankAccount.HeaderText = "Tài khoản nhận";
            this.col_BankAccount.Name = "col_BankAccount";
            this.col_BankAccount.ReadOnly = true;
            this.col_BankAccount.Width = 150;
            // 
            // col_BankName
            // 
            this.col_BankName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_BankName.DataPropertyName = "BankName";
            this.col_BankName.HeaderText = "Ngân hàng";
            this.col_BankName.Name = "col_BankName";
            this.col_BankName.ReadOnly = true;
            this.col_BankName.Width = 200;
            // 
            // col_BankOwner
            // 
            this.col_BankOwner.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_BankOwner.DataPropertyName = "BankOwner";
            this.col_BankOwner.HeaderText = "Chú tài khoản";
            this.col_BankOwner.Name = "col_BankOwner";
            this.col_BankOwner.ReadOnly = true;
            this.col_BankOwner.Width = 150;
            // 
            // col_Note
            // 
            this.col_Note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Note.DataPropertyName = "Note";
            this.col_Note.HeaderText = "Ghi chú";
            this.col_Note.Name = "col_Note";
            this.col_Note.ReadOnly = true;
            // 
            // col_IsConfirm
            // 
            this.col_IsConfirm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_IsConfirm.DataPropertyName = "IsConfirm";
            this.col_IsConfirm.HeaderText = "Đã xác nhận";
            this.col_IsConfirm.Name = "col_IsConfirm";
            this.col_IsConfirm.ReadOnly = true;
            this.col_IsConfirm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_IsConfirm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_IsConfirm.Width = 80;
            // 
            // col_ConfirmDate
            // 
            this.col_ConfirmDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_ConfirmDate.DataPropertyName = "ConfirmDate";
            this.col_ConfirmDate.HeaderText = "Ngày xác nhận";
            this.col_ConfirmDate.Name = "col_ConfirmDate";
            this.col_ConfirmDate.ReadOnly = true;
            this.col_ConfirmDate.Width = 120;
            // 
            // col_ReSoTien
            // 
            this.col_ReSoTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_ReSoTien.DataPropertyName = "ReSoTien";
            this.col_ReSoTien.HeaderText = "Số tiền xác nhận";
            this.col_ReSoTien.Name = "col_ReSoTien";
            this.col_ReSoTien.ReadOnly = true;
            this.col_ReSoTien.Width = 80;
            // 
            // col_FK_Account
            // 
            this.col_FK_Account.DataPropertyName = "FK_Account";
            this.col_FK_Account.HeaderText = "FK_Account";
            this.col_FK_Account.Name = "col_FK_Account";
            this.col_FK_Account.ReadOnly = true;
            this.col_FK_Account.Visible = false;
            // 
            // col_NguoiYeuCau
            // 
            this.col_NguoiYeuCau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_NguoiYeuCau.DataPropertyName = "NguoiYeuCau";
            this.col_NguoiYeuCau.HeaderText = "Người tạo";
            this.col_NguoiYeuCau.Name = "col_NguoiYeuCau";
            this.col_NguoiYeuCau.ReadOnly = true;
            this.col_NguoiYeuCau.Width = 120;
            // 
            // col_NguoiXuLy
            // 
            this.col_NguoiXuLy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_NguoiXuLy.DataPropertyName = "NguoiXuLy";
            this.col_NguoiXuLy.HeaderText = "Người xác nhận";
            this.col_NguoiXuLy.Name = "col_NguoiXuLy";
            this.col_NguoiXuLy.ReadOnly = true;
            this.col_NguoiXuLy.Width = 120;
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            this.highlighter.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Green;
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(679, 39);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(277, 23);
            this.txtFilter.TabIndex = 1350;
            // 
            // dateTo
            // 
            this.dateTo.CustomFormat = "dd/MM/yyyy";
            this.dateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTo.Location = new System.Drawing.Point(203, 39);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(118, 23);
            this.dateTo.TabIndex = 1354;
            // 
            // cmbLoai
            // 
            this.cmbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoai.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.Items.AddRange(new object[] {
            "Tất cả",
            "Chưa phê duyệt",
            "Đã phê duyệt"});
            this.cmbLoai.Location = new System.Drawing.Point(367, 38);
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(210, 24);
            this.cmbLoai.TabIndex = 1353;
            // 
            // dateFrom
            // 
            this.dateFrom.CustomFormat = "dd/MM/yyyy";
            this.dateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFrom.Location = new System.Drawing.Point(58, 39);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(118, 23);
            this.dateFrom.TabIndex = 1355;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.Black;
            this.label35.Location = new System.Drawing.Point(329, 42);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(39, 17);
            this.label35.TabIndex = 1358;
            this.label35.Text = "Loại:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(180, 42);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(24, 17);
            this.label26.TabIndex = 1357;
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
            this.btnExcel.Location = new System.Drawing.Point(1055, 35);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(82, 30);
            this.btnExcel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExcel.TabIndex = 1352;
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
            this.btnTruyVan.Location = new System.Drawing.Point(967, 35);
            this.btnTruyVan.Name = "btnTruyVan";
            this.btnTruyVan.Size = new System.Drawing.Size(83, 30);
            this.btnTruyVan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTruyVan.TabIndex = 1351;
            this.btnTruyVan.Text = "Truy vấn";
            this.btnTruyVan.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnTruyVan.Click += new System.EventHandler(this.btnTruyVan_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(14, 42);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(45, 17);
            this.label28.TabIndex = 1356;
            this.label28.Text = "Ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(586, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 1359;
            this.label1.Text = "Mã giao dịch:";
            // 
            // frmQuanLyNapTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1149, 679);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.cmbLoai);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnTruyVan);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.gridMain);
            this.Controls.Add(this.panelcomtrol);
            this.Controls.Add(this.lTieude);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmQuanLyNapTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyNapTien";
            this.Load += new System.EventHandler(this.frmQuanLyNapTien_Load);
            this.panelcomtrol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panelcomtrol;
		private System.Windows.Forms.Label lTieude;
		private DevComponents.DotNetBar.ButtonX btnClose;
		private DevComponents.DotNetBar.ButtonX btnXacNhan;
		private DevComponents.DotNetBar.Controls.DataGridViewX gridMain;
		private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.ComboBox cmbLoai;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label26;
        private DevComponents.DotNetBar.ButtonX btnExcel;
        private DevComponents.DotNetBar.ButtonX btnTruyVan;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_Post;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_RequestAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_PostResponse;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DaiLyYeuCau;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DaiLyXuLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RequestCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BankAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BankOwner;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Note;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_IsConfirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ConfirmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ReSoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NguoiYeuCau;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NguoiXuLy;
        private System.Windows.Forms.Label label1;
    }
}
