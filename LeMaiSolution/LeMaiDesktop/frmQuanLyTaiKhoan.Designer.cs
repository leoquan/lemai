namespace LeMaiDesktop
{
	partial class frmQuanLyTaiKhoan
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
            this.col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PassWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AtCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AtCreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AtLastModifiedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AtLastModifiedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AccountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LastLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CardId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BirthDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IdAccountIntro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ImagePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FK_BranchOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IsDelete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_RewardPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TaxCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CreateByName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ModifyByName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BranchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuReset = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPermission = new System.Windows.Forms.ToolStripMenuItem();
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmbAccountType = new System.Windows.Forms.ComboBox();
            this.cmbCardId = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.lblCardId = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.panelcomtrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            this.contextMenu.SuspendLayout();
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
            this.panelcomtrol.Location = new System.Drawing.Point(0, 611);
            this.panelcomtrol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelcomtrol.Name = "panelcomtrol";
            this.panelcomtrol.Size = new System.Drawing.Size(1025, 42);
            this.panelcomtrol.TabIndex = 9;
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
            this.txtSearch.Location = new System.Drawing.Point(10, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(294, 21);
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
            this.btnNew.Location = new System.Drawing.Point(583, 5);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(90, 32);
            this.btnNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNew.TabIndex = 2;
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
            this.btnSave.Location = new System.Drawing.Point(761, 5);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 32);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 0;
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
            this.btnEdit.Location = new System.Drawing.Point(675, 5);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 32);
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
            this.btnDelete.Location = new System.Drawing.Point(844, 5);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 32);
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
            this.btnClose.Location = new System.Drawing.Point(929, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 32);
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
            this.lTieude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTieude.Name = "lTieude";
            this.lTieude.Size = new System.Drawing.Size(1025, 32);
            this.lTieude.TabIndex = 20;
            this.lTieude.Text = "    Tài khoản nhân viên";
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridMain.ColumnHeadersHeight = 25;
            this.gridMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Id,
            this.col_Code,
            this.col_FullName,
            this.col_UserName,
            this.col_PassWord,
            this.col_Phone,
            this.col_Email,
            this.col_AtCreatedDate,
            this.col_AtCreatedBy,
            this.col_AtLastModifiedDate,
            this.col_AtLastModifiedBy,
            this.col_AccountType,
            this.col_LastLogin,
            this.col_CardId,
            this.col_BirthDay,
            this.col_Address,
            this.col_IdAccountIntro,
            this.col_ImagePath,
            this.col_FK_BranchOwner,
            this.col_Note,
            this.col_IsDelete,
            this.col_Balance,
            this.col_RewardPoint,
            this.col_TaxCode,
            this.col_CreateByName,
            this.col_ModifyByName,
            this.col_BranchName});
            this.gridMain.ContextMenuStrip = this.contextMenu;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMain.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridMain.EnableHeadersVisualStyles = false;
            this.gridMain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.gridMain.HighlightSelectedColumnHeaders = false;
            this.gridMain.Location = new System.Drawing.Point(4, 36);
            this.gridMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridMain.MultiSelect = false;
            this.gridMain.Name = "gridMain";
            this.gridMain.PaintEnhancedSelection = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.gridMain.Size = new System.Drawing.Size(1022, 454);
            this.gridMain.TabIndex = 19;
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
            // col_Code
            // 
            this.col_Code.DataPropertyName = "Code";
            this.col_Code.HeaderText = "Mã";
            this.col_Code.Name = "col_Code";
            this.col_Code.ReadOnly = true;
            // 
            // col_FullName
            // 
            this.col_FullName.DataPropertyName = "FullName";
            this.col_FullName.HeaderText = "Tên tài khoản";
            this.col_FullName.Name = "col_FullName";
            this.col_FullName.ReadOnly = true;
            // 
            // col_UserName
            // 
            this.col_UserName.DataPropertyName = "UserName";
            this.col_UserName.HeaderText = "Tên đăng nhập";
            this.col_UserName.Name = "col_UserName";
            this.col_UserName.ReadOnly = true;
            // 
            // col_PassWord
            // 
            this.col_PassWord.DataPropertyName = "PassWord";
            this.col_PassWord.HeaderText = "PassWord";
            this.col_PassWord.Name = "col_PassWord";
            this.col_PassWord.ReadOnly = true;
            this.col_PassWord.Visible = false;
            // 
            // col_Phone
            // 
            this.col_Phone.DataPropertyName = "Phone";
            this.col_Phone.HeaderText = "Điện thoại";
            this.col_Phone.Name = "col_Phone";
            this.col_Phone.ReadOnly = true;
            // 
            // col_Email
            // 
            this.col_Email.DataPropertyName = "Email";
            this.col_Email.HeaderText = "Email";
            this.col_Email.Name = "col_Email";
            this.col_Email.ReadOnly = true;
            // 
            // col_AtCreatedDate
            // 
            this.col_AtCreatedDate.DataPropertyName = "AtCreatedDate";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Format = "dd/MM/yyyy HH:mm:ss";
            this.col_AtCreatedDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_AtCreatedDate.HeaderText = "Ngày tạo";
            this.col_AtCreatedDate.Name = "col_AtCreatedDate";
            this.col_AtCreatedDate.ReadOnly = true;
            // 
            // col_AtCreatedBy
            // 
            this.col_AtCreatedBy.DataPropertyName = "AtCreatedBy";
            this.col_AtCreatedBy.HeaderText = "AtCreatedBy";
            this.col_AtCreatedBy.Name = "col_AtCreatedBy";
            this.col_AtCreatedBy.ReadOnly = true;
            this.col_AtCreatedBy.Visible = false;
            // 
            // col_AtLastModifiedDate
            // 
            this.col_AtLastModifiedDate.DataPropertyName = "AtLastModifiedDate";
            this.col_AtLastModifiedDate.HeaderText = "AtLastModifiedDate";
            this.col_AtLastModifiedDate.Name = "col_AtLastModifiedDate";
            this.col_AtLastModifiedDate.ReadOnly = true;
            this.col_AtLastModifiedDate.Visible = false;
            // 
            // col_AtLastModifiedBy
            // 
            this.col_AtLastModifiedBy.DataPropertyName = "AtLastModifiedBy";
            this.col_AtLastModifiedBy.HeaderText = "AtLastModifiedBy";
            this.col_AtLastModifiedBy.Name = "col_AtLastModifiedBy";
            this.col_AtLastModifiedBy.ReadOnly = true;
            this.col_AtLastModifiedBy.Visible = false;
            // 
            // col_AccountType
            // 
            this.col_AccountType.DataPropertyName = "AccountType";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            this.col_AccountType.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_AccountType.HeaderText = "AccountType";
            this.col_AccountType.Name = "col_AccountType";
            this.col_AccountType.ReadOnly = true;
            this.col_AccountType.Visible = false;
            // 
            // col_LastLogin
            // 
            this.col_LastLogin.DataPropertyName = "LastLogin";
            this.col_LastLogin.HeaderText = "LastLogin";
            this.col_LastLogin.Name = "col_LastLogin";
            this.col_LastLogin.ReadOnly = true;
            this.col_LastLogin.Visible = false;
            // 
            // col_CardId
            // 
            this.col_CardId.DataPropertyName = "CardId";
            this.col_CardId.HeaderText = "Bưu cục";
            this.col_CardId.Name = "col_CardId";
            this.col_CardId.ReadOnly = true;
            // 
            // col_BirthDay
            // 
            this.col_BirthDay.DataPropertyName = "BirthDay";
            this.col_BirthDay.HeaderText = "BirthDay";
            this.col_BirthDay.Name = "col_BirthDay";
            this.col_BirthDay.ReadOnly = true;
            this.col_BirthDay.Visible = false;
            // 
            // col_Address
            // 
            this.col_Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Address.DataPropertyName = "Address";
            this.col_Address.HeaderText = "Địa chỉ";
            this.col_Address.Name = "col_Address";
            this.col_Address.ReadOnly = true;
            // 
            // col_IdAccountIntro
            // 
            this.col_IdAccountIntro.DataPropertyName = "IdAccountIntro";
            this.col_IdAccountIntro.HeaderText = "IdAccountIntro";
            this.col_IdAccountIntro.Name = "col_IdAccountIntro";
            this.col_IdAccountIntro.ReadOnly = true;
            this.col_IdAccountIntro.Visible = false;
            // 
            // col_ImagePath
            // 
            this.col_ImagePath.DataPropertyName = "ImagePath";
            this.col_ImagePath.HeaderText = "ImagePath";
            this.col_ImagePath.Name = "col_ImagePath";
            this.col_ImagePath.ReadOnly = true;
            this.col_ImagePath.Visible = false;
            // 
            // col_FK_BranchOwner
            // 
            this.col_FK_BranchOwner.DataPropertyName = "FK_BranchOwner";
            this.col_FK_BranchOwner.HeaderText = "FK_BranchOwner";
            this.col_FK_BranchOwner.Name = "col_FK_BranchOwner";
            this.col_FK_BranchOwner.ReadOnly = true;
            this.col_FK_BranchOwner.Visible = false;
            // 
            // col_Note
            // 
            this.col_Note.DataPropertyName = "Note";
            this.col_Note.HeaderText = "Note";
            this.col_Note.Name = "col_Note";
            this.col_Note.ReadOnly = true;
            this.col_Note.Visible = false;
            // 
            // col_IsDelete
            // 
            this.col_IsDelete.DataPropertyName = "IsDelete";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_IsDelete.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_IsDelete.HeaderText = "IsDelete";
            this.col_IsDelete.Name = "col_IsDelete";
            this.col_IsDelete.ReadOnly = true;
            this.col_IsDelete.Visible = false;
            // 
            // col_Balance
            // 
            this.col_Balance.DataPropertyName = "Balance";
            this.col_Balance.HeaderText = "Balance";
            this.col_Balance.Name = "col_Balance";
            this.col_Balance.ReadOnly = true;
            this.col_Balance.Visible = false;
            // 
            // col_RewardPoint
            // 
            this.col_RewardPoint.DataPropertyName = "RewardPoint";
            this.col_RewardPoint.HeaderText = "RewardPoint";
            this.col_RewardPoint.Name = "col_RewardPoint";
            this.col_RewardPoint.ReadOnly = true;
            this.col_RewardPoint.Visible = false;
            // 
            // col_TaxCode
            // 
            this.col_TaxCode.DataPropertyName = "TaxCode";
            this.col_TaxCode.HeaderText = "TaxCode";
            this.col_TaxCode.Name = "col_TaxCode";
            this.col_TaxCode.ReadOnly = true;
            this.col_TaxCode.Visible = false;
            // 
            // col_CreateByName
            // 
            this.col_CreateByName.DataPropertyName = "CreateByName";
            this.col_CreateByName.HeaderText = "Người tạo";
            this.col_CreateByName.Name = "col_CreateByName";
            this.col_CreateByName.ReadOnly = true;
            // 
            // col_ModifyByName
            // 
            this.col_ModifyByName.DataPropertyName = "ModifyByName";
            this.col_ModifyByName.HeaderText = "ModifyByName";
            this.col_ModifyByName.Name = "col_ModifyByName";
            this.col_ModifyByName.ReadOnly = true;
            this.col_ModifyByName.Visible = false;
            // 
            // col_BranchName
            // 
            this.col_BranchName.DataPropertyName = "BranchName";
            this.col_BranchName.HeaderText = "Nhóm";
            this.col_BranchName.Name = "col_BranchName";
            this.col_BranchName.ReadOnly = true;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuReset,
            this.menuPermission});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(161, 48);
            // 
            // menuReset
            // 
            this.menuReset.Image = global::LeMaiDesktop.Properties.Resources.iChange;
            this.menuReset.Name = "menuReset";
            this.menuReset.Size = new System.Drawing.Size(160, 22);
            this.menuReset.Text = "Đặt lại mật khẩu";
            this.menuReset.Click += new System.EventHandler(this.menuReset_Click);
            // 
            // menuPermission
            // 
            this.menuPermission.Image = global::LeMaiDesktop.Properties.Resources.icoBanQuyen;
            this.menuPermission.Name = "menuPermission";
            this.menuPermission.Size = new System.Drawing.Size(160, 22);
            this.menuPermission.Text = "Cấu hình quyền";
            this.menuPermission.Click += new System.EventHandler(this.menuPermission_Click);
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            this.highlighter.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Green;
            // 
            // txtFullName
            // 
            this.txtFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFullName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFullName.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtFullName, true);
            this.txtFullName.Location = new System.Drawing.Point(93, 511);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFullName.MaxLength = 250;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(227, 22);
            this.txtFullName.TabIndex = 0;
            this.txtFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFullName_KeyPress);
            this.txtFullName.Leave += new System.EventHandler(this.txtFullName_Leave);
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtUserName.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtUserName, true);
            this.txtUserName.Location = new System.Drawing.Point(417, 511);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUserName.MaxLength = 50;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(183, 22);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            // 
            // txtPassWord
            // 
            this.txtPassWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassWord.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassWord.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtPassWord, true);
            this.txtPassWord.Location = new System.Drawing.Point(663, 511);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassWord.MaxLength = 50;
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(164, 22);
            this.txtPassWord.TabIndex = 2;
            this.txtPassWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassWord_KeyPress);
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhone.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtPhone, true);
            this.txtPhone.Location = new System.Drawing.Point(867, 511);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPhone.MaxLength = 13;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(149, 22);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtEmail, true);
            this.txtEmail.Location = new System.Drawing.Point(867, 544);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(149, 22);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // cmbAccountType
            // 
            this.cmbAccountType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAccountType.FormattingEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.cmbAccountType, true);
            this.cmbAccountType.Location = new System.Drawing.Point(663, 544);
            this.cmbAccountType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbAccountType.Name = "cmbAccountType";
            this.cmbAccountType.Size = new System.Drawing.Size(164, 22);
            this.cmbAccountType.TabIndex = 6;
            // 
            // cmbCardId
            // 
            this.cmbCardId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCardId.FormattingEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.cmbCardId, true);
            this.cmbCardId.Location = new System.Drawing.Point(417, 544);
            this.cmbCardId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbCardId.Name = "cmbCardId";
            this.cmbCardId.Size = new System.Drawing.Size(183, 22);
            this.cmbCardId.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtAddress, true);
            this.txtAddress.Location = new System.Drawing.Point(93, 544);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAddress.MaxLength = 250;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(227, 22);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress_KeyPress);
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.BackColor = System.Drawing.SystemColors.Window;
            this.txtNote.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtNote, true);
            this.txtNote.Location = new System.Drawing.Point(93, 577);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNote.MaxLength = 250;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(923, 22);
            this.txtNote.TabIndex = 8;
            this.txtNote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNote_KeyPress);
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFullName.AutoSize = true;
            this.lblFullName.ForeColor = System.Drawing.Color.Black;
            this.lblFullName.Location = new System.Drawing.Point(4, 515);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(90, 14);
            this.lblFullName.TabIndex = 10;
            this.lblFullName.Text = "Tên nhân viên:";
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(322, 515);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(95, 14);
            this.lblUserName.TabIndex = 13;
            this.lblUserName.Text = "Tên đăng nhập:";
            // 
            // lblPassWord
            // 
            this.lblPassWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassWord.AutoSize = true;
            this.lblPassWord.ForeColor = System.Drawing.Color.Black;
            this.lblPassWord.Location = new System.Drawing.Point(604, 515);
            this.lblPassWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(61, 14);
            this.lblPassWord.TabIndex = 15;
            this.lblPassWord.Text = "Mật khẩu:";
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhone.AutoSize = true;
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Location = new System.Drawing.Point(834, 515);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(34, 14);
            this.lblPhone.TabIndex = 17;
            this.lblPhone.Text = "SĐT:";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(831, 548);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 14);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email:";
            // 
            // lblAccountType
            // 
            this.lblAccountType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountType.ForeColor = System.Drawing.Color.Black;
            this.lblAccountType.Location = new System.Drawing.Point(633, 548);
            this.lblAccountType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(32, 14);
            this.lblAccountType.TabIndex = 16;
            this.lblAccountType.Text = "Loại:";
            // 
            // lblCardId
            // 
            this.lblCardId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCardId.AutoSize = true;
            this.lblCardId.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardId.ForeColor = System.Drawing.Color.Black;
            this.lblCardId.Location = new System.Drawing.Point(378, 548);
            this.lblCardId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCardId.Name = "lblCardId";
            this.lblCardId.Size = new System.Drawing.Size(39, 14);
            this.lblCardId.TabIndex = 14;
            this.lblCardId.Text = "Đại lý:";
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAddress.AutoSize = true;
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(48, 548);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(46, 14);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "Địa chỉ:";
            // 
            // lblNote
            // 
            this.lblNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNote.AutoSize = true;
            this.lblNote.ForeColor = System.Drawing.Color.Black;
            this.lblNote.Location = new System.Drawing.Point(42, 581);
            this.lblNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(52, 14);
            this.lblNote.TabIndex = 12;
            this.lblNote.Text = "Ghi chú:";
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // frmQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1025, 653);
            this.Controls.Add(this.gridMain);
            this.Controls.Add(this.panelcomtrol);
            this.Controls.Add(this.lTieude);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.cmbAccountType);
            this.Controls.Add(this.cmbCardId);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblPassWord);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAccountType);
            this.Controls.Add(this.lblCardId);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblNote);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmQuanLyTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyTaiKhoan";
            this.Load += new System.EventHandler(this.frmQuanLyTaiKhoan_Load);
            this.panelcomtrol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            this.contextMenu.ResumeLayout(false);
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
		private System.Windows.Forms.Label lblFullName;
		private System.Windows.Forms.TextBox txtFullName;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label lblPassWord;
		private System.Windows.Forms.TextBox txtPassWord;
		private System.Windows.Forms.Label lblPhone;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label lblAccountType;
		private System.Windows.Forms.ComboBox cmbAccountType;
		private System.Windows.Forms.Label lblCardId;
		private System.Windows.Forms.ComboBox cmbCardId;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Label lblNote;
		private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem menuReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PassWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AtCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AtCreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AtLastModifiedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AtLastModifiedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AccountType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LastLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CardId;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BirthDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IdAccountIntro;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ImagePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_BranchOwner;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IsDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RewardPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TaxCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CreateByName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ModifyByName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BranchName;
        private DevComponents.DotNetBar.StyleManager styleManager;
        private System.Windows.Forms.ToolStripMenuItem menuPermission;
    }
}
