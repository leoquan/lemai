namespace LeMaiDesktop
{
	partial class frmAccountObject
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.col_AtRowStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AccountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LastLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CardId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCardId = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.lblCardId = new System.Windows.Forms.Label();
            this.cmbAccountType = new System.Windows.Forms.ComboBox();
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
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
            this.panelcomtrol.Size = new System.Drawing.Size(1025, 39);
            this.panelcomtrol.TabIndex = 299;
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
            this.txtSearch.TabIndex = 1165;
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
            this.btnNew.Location = new System.Drawing.Point(610, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(77, 30);
            this.btnNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNew.TabIndex = 1170;
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
            this.btnSave.Location = new System.Drawing.Point(771, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 1169;
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
            this.btnEdit.Location = new System.Drawing.Point(689, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 30);
            this.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEdit.TabIndex = 1168;
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
            this.btnDelete.Location = new System.Drawing.Point(848, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 30);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.TabIndex = 1167;
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
            this.lTieude.Size = new System.Drawing.Size(1025, 30);
            this.lTieude.TabIndex = 300;
            this.lTieude.Text = "    Account Object";
            this.lTieude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gridMain
            // 
            this.gridMain.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.gridMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gridMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
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
            this.col_AtRowStatus,
            this.col_AccountType,
            this.col_LastLogin,
            this.col_CardId});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMain.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridMain.EnableHeadersVisualStyles = false;
            this.gridMain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.gridMain.HighlightSelectedColumnHeaders = false;
            this.gridMain.Location = new System.Drawing.Point(3, 33);
            this.gridMain.MultiSelect = false;
            this.gridMain.Name = "gridMain";
            this.gridMain.PaintEnhancedSelection = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridMain.RowHeadersVisible = false;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.gridMain.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gridMain.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridMain.RowTemplate.Height = 25;
            this.gridMain.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMain.Size = new System.Drawing.Size(1022, 434);
            this.gridMain.TabIndex = 1164;
            this.gridMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMain_CellDoubleClick);
            // 
            // col_Id
            // 
            this.col_Id.DataPropertyName = "Id";
            this.col_Id.HeaderText = "Id";
            this.col_Id.Name = "col_Id";
            this.col_Id.ReadOnly = true;
            // 
            // col_Code
            // 
            this.col_Code.DataPropertyName = "Code";
            this.col_Code.HeaderText = "Code";
            this.col_Code.Name = "col_Code";
            this.col_Code.ReadOnly = true;
            // 
            // col_FullName
            // 
            this.col_FullName.DataPropertyName = "FullName";
            this.col_FullName.HeaderText = "FullName";
            this.col_FullName.Name = "col_FullName";
            this.col_FullName.ReadOnly = true;
            // 
            // col_UserName
            // 
            this.col_UserName.DataPropertyName = "UserName";
            this.col_UserName.HeaderText = "UserName";
            this.col_UserName.Name = "col_UserName";
            this.col_UserName.ReadOnly = true;
            // 
            // col_PassWord
            // 
            this.col_PassWord.DataPropertyName = "PassWord";
            this.col_PassWord.HeaderText = "PassWord";
            this.col_PassWord.Name = "col_PassWord";
            this.col_PassWord.ReadOnly = true;
            // 
            // col_Phone
            // 
            this.col_Phone.DataPropertyName = "Phone";
            this.col_Phone.HeaderText = "Phone";
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
            this.col_AtCreatedDate.HeaderText = "AtCreatedDate";
            this.col_AtCreatedDate.Name = "col_AtCreatedDate";
            this.col_AtCreatedDate.ReadOnly = true;
            // 
            // col_AtCreatedBy
            // 
            this.col_AtCreatedBy.DataPropertyName = "AtCreatedBy";
            this.col_AtCreatedBy.HeaderText = "AtCreatedBy";
            this.col_AtCreatedBy.Name = "col_AtCreatedBy";
            this.col_AtCreatedBy.ReadOnly = true;
            // 
            // col_AtLastModifiedDate
            // 
            this.col_AtLastModifiedDate.DataPropertyName = "AtLastModifiedDate";
            this.col_AtLastModifiedDate.HeaderText = "AtLastModifiedDate";
            this.col_AtLastModifiedDate.Name = "col_AtLastModifiedDate";
            this.col_AtLastModifiedDate.ReadOnly = true;
            // 
            // col_AtLastModifiedBy
            // 
            this.col_AtLastModifiedBy.DataPropertyName = "AtLastModifiedBy";
            this.col_AtLastModifiedBy.HeaderText = "AtLastModifiedBy";
            this.col_AtLastModifiedBy.Name = "col_AtLastModifiedBy";
            this.col_AtLastModifiedBy.ReadOnly = true;
            // 
            // col_AtRowStatus
            // 
            this.col_AtRowStatus.DataPropertyName = "AtRowStatus";
            this.col_AtRowStatus.HeaderText = "AtRowStatus";
            this.col_AtRowStatus.Name = "col_AtRowStatus";
            this.col_AtRowStatus.ReadOnly = true;
            // 
            // col_AccountType
            // 
            this.col_AccountType.DataPropertyName = "AccountType";
            this.col_AccountType.HeaderText = "AccountType";
            this.col_AccountType.Name = "col_AccountType";
            this.col_AccountType.ReadOnly = true;
            // 
            // col_LastLogin
            // 
            this.col_LastLogin.DataPropertyName = "LastLogin";
            this.col_LastLogin.HeaderText = "LastLogin";
            this.col_LastLogin.Name = "col_LastLogin";
            this.col_LastLogin.ReadOnly = true;
            // 
            // col_CardId
            // 
            this.col_CardId.DataPropertyName = "CardId";
            this.col_CardId.HeaderText = "CardId";
            this.col_CardId.Name = "col_CardId";
            this.col_CardId.ReadOnly = true;
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            this.highlighter.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Green;
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtCode.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtCode, true);
            this.txtCode.Location = new System.Drawing.Point(69, 490);
            this.txtCode.MaxLength = 50;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(111, 22);
            this.txtCode.TabIndex = 2;
            this.txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCode_KeyPress);
            // 
            // txtFullName
            // 
            this.txtFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFullName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFullName.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtFullName, true);
            this.txtFullName.Location = new System.Drawing.Point(248, 490);
            this.txtFullName.MaxLength = 250;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(250, 22);
            this.txtFullName.TabIndex = 3;
            this.txtFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFullName_KeyPress);
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserName.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtUserName, true);
            this.txtUserName.Location = new System.Drawing.Point(575, 490);
            this.txtUserName.MaxLength = 50;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(180, 22);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            // 
            // txtPassWord
            // 
            this.txtPassWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassWord.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassWord.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtPassWord, true);
            this.txtPassWord.Location = new System.Drawing.Point(862, 490);
            this.txtPassWord.MaxLength = 50;
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(156, 22);
            this.txtPassWord.TabIndex = 5;
            this.txtPassWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassWord_KeyPress);
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPhone.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhone.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtPhone, true);
            this.txtPhone.Location = new System.Drawing.Point(69, 528);
            this.txtPhone.MaxLength = 13;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(111, 22);
            this.txtPhone.TabIndex = 6;
            this.txtPhone.Text = "0934090231";
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtEmail, true);
            this.txtEmail.Location = new System.Drawing.Point(248, 528);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 22);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // txtCardId
            // 
            this.txtCardId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCardId.BackColor = System.Drawing.SystemColors.Window;
            this.txtCardId.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtCardId, true);
            this.txtCardId.Location = new System.Drawing.Point(575, 528);
            this.txtCardId.MaxLength = 50;
            this.txtCardId.Name = "txtCardId";
            this.txtCardId.Size = new System.Drawing.Size(180, 22);
            this.txtCardId.TabIndex = 15;
            this.txtCardId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardId_KeyPress);
            // 
            // lblCode
            // 
            this.lblCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCode.ForeColor = System.Drawing.Color.Black;
            this.lblCode.Location = new System.Drawing.Point(6, 493);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(63, 16);
            this.lblCode.TabIndex = 1000;
            this.lblCode.Text = "Code:";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFullName.ForeColor = System.Drawing.Color.Black;
            this.lblFullName.Location = new System.Drawing.Point(186, 493);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(63, 17);
            this.lblFullName.TabIndex = 1000;
            this.lblFullName.Text = "FullName:";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(510, 495);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(63, 13);
            this.lblUserName.TabIndex = 1000;
            this.lblUserName.Text = "UserName:";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPassWord
            // 
            this.lblPassWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassWord.ForeColor = System.Drawing.Color.Black;
            this.lblPassWord.Location = new System.Drawing.Point(764, 493);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(97, 16);
            this.lblPassWord.TabIndex = 1000;
            this.lblPassWord.Text = "PassWord:";
            this.lblPassWord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Location = new System.Drawing.Point(6, 533);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(63, 13);
            this.lblPhone.TabIndex = 1000;
            this.lblPhone.Text = "Phone:";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(186, 533);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 13);
            this.lblEmail.TabIndex = 1000;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAccountType
            // 
            this.lblAccountType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccountType.ForeColor = System.Drawing.Color.Black;
            this.lblAccountType.Location = new System.Drawing.Point(761, 533);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(100, 13);
            this.lblAccountType.TabIndex = 1000;
            this.lblAccountType.Text = "AccountType:";
            this.lblAccountType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCardId
            // 
            this.lblCardId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCardId.ForeColor = System.Drawing.Color.Black;
            this.lblCardId.Location = new System.Drawing.Point(510, 530);
            this.lblCardId.Name = "lblCardId";
            this.lblCardId.Size = new System.Drawing.Size(63, 19);
            this.lblCardId.TabIndex = 1000;
            this.lblCardId.Text = "CardId:";
            this.lblCardId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbAccountType
            // 
            this.cmbAccountType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountType.FormattingEnabled = true;
            this.cmbAccountType.Items.AddRange(new object[] {
            "Người dùng"});
            this.cmbAccountType.Location = new System.Drawing.Point(862, 529);
            this.cmbAccountType.Name = "cmbAccountType";
            this.cmbAccountType.Size = new System.Drawing.Size(156, 21);
            this.cmbAccountType.TabIndex = 1165;
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // frmAccountObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1025, 600);
            this.Controls.Add(this.cmbAccountType);
            this.Controls.Add(this.gridMain);
            this.Controls.Add(this.panelcomtrol);
            this.Controls.Add(this.lTieude);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCardId);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblPassWord);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAccountType);
            this.Controls.Add(this.lblCardId);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAccountObject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAccountObject";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAccountObject_Load);
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
		private System.Windows.Forms.DataGridViewTextBoxColumn col_Id;
		private System.Windows.Forms.Label lblCode;
		private System.Windows.Forms.TextBox txtCode;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_Code;
		private System.Windows.Forms.Label lblFullName;
		private System.Windows.Forms.TextBox txtFullName;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_FullName;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_UserName;
		private System.Windows.Forms.Label lblPassWord;
		private System.Windows.Forms.TextBox txtPassWord;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_PassWord;
		private System.Windows.Forms.Label lblPhone;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_Phone;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_Email;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_AtCreatedDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_AtCreatedBy;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_AtLastModifiedDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_AtLastModifiedBy;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_AtRowStatus;
		private System.Windows.Forms.Label lblAccountType;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_AccountType;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_LastLogin;
		private System.Windows.Forms.Label lblCardId;
		private System.Windows.Forms.TextBox txtCardId;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_CardId;
        private System.Windows.Forms.ComboBox cmbAccountType;
        private DevComponents.DotNetBar.StyleManager styleManager;
    }
}
