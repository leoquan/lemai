namespace LeMaiDesktop
{
	partial class frmMenuFunction
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtControllerName = new System.Windows.Forms.TextBox();
            this.txtAcctionName = new System.Windows.Forms.TextBox();
            this.txtControllerNameApi = new System.Windows.Forms.TextBox();
            this.txtAcctionNameApi = new System.Windows.Forms.TextBox();
            this.txtRouteId = new System.Windows.Forms.TextBox();
            this.chbIsMenu = new System.Windows.Forms.CheckBox();
            this.chbIsPublic = new System.Windows.Forms.CheckBox();
            this.txtIcon = new System.Windows.Forms.TextBox();
            this.txtCssClass = new System.Windows.Forms.TextBox();
            this.txtParrent = new System.Windows.Forms.TextBox();
            this.txtSortIndex = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtMenuWidth = new System.Windows.Forms.TextBox();
            this.txtMenuImageName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblControllerName = new System.Windows.Forms.Label();
            this.lblAcctionName = new System.Windows.Forms.Label();
            this.lblControllerNameApi = new System.Windows.Forms.Label();
            this.lblAcctionNameApi = new System.Windows.Forms.Label();
            this.lblRouteId = new System.Windows.Forms.Label();
            this.lblIcon = new System.Windows.Forms.Label();
            this.lblCssClass = new System.Windows.Forms.Label();
            this.lblParrent = new System.Windows.Forms.Label();
            this.lblSortIndex = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblProjectUsed = new System.Windows.Forms.Label();
            this.lblMenuWidth = new System.Windows.Forms.Label();
            this.lblMenuImageName = new System.Windows.Forms.Label();
            this.lblFormShowType = new System.Windows.Forms.Label();
            this.cmbProjectUsed = new System.Windows.Forms.ComboBox();
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.cmbShowType = new System.Windows.Forms.ComboBox();
            this.cmbParent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNhomRibbonBar = new System.Windows.Forms.ComboBox();
            this.lblid_subparent = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ControllerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AcctionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ControllerNameApi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AcctionNameApi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_RouteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IsMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IsPublic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Icon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CssClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Parrent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SortIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProjectUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FK_MenuGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MenuWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MenuImageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FK_MenuImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CreateUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_UpdateUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FormShowType = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panelcomtrol.Location = new System.Drawing.Point(0, 563);
            this.panelcomtrol.Name = "panelcomtrol";
            this.panelcomtrol.Size = new System.Drawing.Size(896, 39);
            this.panelcomtrol.TabIndex = 19;
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
            this.btnNew.Location = new System.Drawing.Point(482, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(77, 30);
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
            this.btnSave.Location = new System.Drawing.Point(641, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
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
            this.btnEdit.Location = new System.Drawing.Point(560, 5);
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
            this.btnDelete.Location = new System.Drawing.Point(717, 5);
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
            this.btnClose.Location = new System.Drawing.Point(797, 5);
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
            this.lTieude.Size = new System.Drawing.Size(896, 30);
            this.lTieude.TabIndex = 38;
            this.lTieude.Text = "    Menu Function";
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
            this.col_Title,
            this.col_ControllerName,
            this.col_AcctionName,
            this.col_ControllerNameApi,
            this.col_AcctionNameApi,
            this.col_RouteId,
            this.col_IsMenu,
            this.col_IsPublic,
            this.col_Icon,
            this.col_CssClass,
            this.col_Parrent,
            this.col_Status,
            this.col_CreateDate,
            this.col_SortIndex,
            this.col_Note,
            this.col_ProjectUsed,
            this.col_FK_MenuGroup,
            this.col_MenuWidth,
            this.col_MenuImageName,
            this.col_FK_MenuImage,
            this.col_CreateUser,
            this.col_UpdateUser,
            this.col_FormShowType});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMain.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridMain.EnableHeadersVisualStyles = false;
            this.gridMain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.gridMain.HighlightSelectedColumnHeaders = false;
            this.gridMain.Location = new System.Drawing.Point(3, 33);
            this.gridMain.MultiSelect = false;
            this.gridMain.Name = "gridMain";
            this.gridMain.PaintEnhancedSelection = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridMain.RowHeadersVisible = false;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.gridMain.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridMain.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridMain.RowTemplate.Height = 25;
            this.gridMain.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMain.Size = new System.Drawing.Size(893, 319);
            this.gridMain.TabIndex = 37;
            this.gridMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMain_CellDoubleClick);
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            this.highlighter.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Green;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.BackColor = System.Drawing.SystemColors.Window;
            this.txtTitle.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtTitle, true);
            this.txtTitle.Location = new System.Drawing.Point(80, 371);
            this.txtTitle.MaxLength = 200;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(235, 22);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTitle_KeyPress);
            // 
            // txtControllerName
            // 
            this.txtControllerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtControllerName.BackColor = System.Drawing.SystemColors.Window;
            this.txtControllerName.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtControllerName, true);
            this.txtControllerName.Location = new System.Drawing.Point(419, 371);
            this.txtControllerName.MaxLength = 100;
            this.txtControllerName.Name = "txtControllerName";
            this.txtControllerName.Size = new System.Drawing.Size(138, 22);
            this.txtControllerName.TabIndex = 1;
            this.txtControllerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtControllerName_KeyPress);
            // 
            // txtAcctionName
            // 
            this.txtAcctionName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAcctionName.BackColor = System.Drawing.SystemColors.Window;
            this.txtAcctionName.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtAcctionName, true);
            this.txtAcctionName.Location = new System.Drawing.Point(649, 371);
            this.txtAcctionName.MaxLength = 100;
            this.txtAcctionName.Name = "txtAcctionName";
            this.txtAcctionName.Size = new System.Drawing.Size(147, 22);
            this.txtAcctionName.TabIndex = 2;
            this.txtAcctionName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAcctionName_KeyPress);
            // 
            // txtControllerNameApi
            // 
            this.txtControllerNameApi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtControllerNameApi.BackColor = System.Drawing.SystemColors.Window;
            this.txtControllerNameApi.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtControllerNameApi, true);
            this.txtControllerNameApi.Location = new System.Drawing.Point(80, 403);
            this.txtControllerNameApi.MaxLength = 100;
            this.txtControllerNameApi.Name = "txtControllerNameApi";
            this.txtControllerNameApi.Size = new System.Drawing.Size(235, 22);
            this.txtControllerNameApi.TabIndex = 4;
            this.txtControllerNameApi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtControllerNameApi_KeyPress);
            // 
            // txtAcctionNameApi
            // 
            this.txtAcctionNameApi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAcctionNameApi.BackColor = System.Drawing.SystemColors.Window;
            this.txtAcctionNameApi.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtAcctionNameApi, true);
            this.txtAcctionNameApi.Location = new System.Drawing.Point(419, 403);
            this.txtAcctionNameApi.MaxLength = 100;
            this.txtAcctionNameApi.Name = "txtAcctionNameApi";
            this.txtAcctionNameApi.Size = new System.Drawing.Size(138, 22);
            this.txtAcctionNameApi.TabIndex = 5;
            this.txtAcctionNameApi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAcctionNameApi_KeyPress);
            // 
            // txtRouteId
            // 
            this.txtRouteId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRouteId.BackColor = System.Drawing.SystemColors.Window;
            this.txtRouteId.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtRouteId, true);
            this.txtRouteId.Location = new System.Drawing.Point(649, 403);
            this.txtRouteId.MaxLength = 100;
            this.txtRouteId.Name = "txtRouteId";
            this.txtRouteId.Size = new System.Drawing.Size(147, 22);
            this.txtRouteId.TabIndex = 6;
            this.txtRouteId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRouteId_KeyPress);
            // 
            // chbIsMenu
            // 
            this.chbIsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chbIsMenu.AutoSize = true;
            this.highlighter.SetHighlightOnFocus(this.chbIsMenu, true);
            this.chbIsMenu.Location = new System.Drawing.Point(800, 374);
            this.chbIsMenu.Name = "chbIsMenu";
            this.chbIsMenu.Size = new System.Drawing.Size(93, 17);
            this.chbIsMenu.TabIndex = 3;
            this.chbIsMenu.Text = "Is Menu Show";
            this.chbIsMenu.UseVisualStyleBackColor = true;
            // 
            // chbIsPublic
            // 
            this.chbIsPublic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chbIsPublic.AutoSize = true;
            this.highlighter.SetHighlightOnFocus(this.chbIsPublic, true);
            this.chbIsPublic.Location = new System.Drawing.Point(800, 406);
            this.chbIsPublic.Name = "chbIsPublic";
            this.chbIsPublic.Size = new System.Drawing.Size(65, 17);
            this.chbIsPublic.TabIndex = 7;
            this.chbIsPublic.Text = "Is Public";
            this.chbIsPublic.UseVisualStyleBackColor = true;
            // 
            // txtIcon
            // 
            this.txtIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIcon.BackColor = System.Drawing.SystemColors.Window;
            this.txtIcon.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtIcon, true);
            this.txtIcon.Location = new System.Drawing.Point(80, 435);
            this.txtIcon.MaxLength = 100;
            this.txtIcon.Name = "txtIcon";
            this.txtIcon.Size = new System.Drawing.Size(235, 22);
            this.txtIcon.TabIndex = 8;
            this.txtIcon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIcon_KeyPress);
            // 
            // txtCssClass
            // 
            this.txtCssClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCssClass.BackColor = System.Drawing.SystemColors.Window;
            this.txtCssClass.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtCssClass, true);
            this.txtCssClass.Location = new System.Drawing.Point(419, 435);
            this.txtCssClass.MaxLength = 100;
            this.txtCssClass.Name = "txtCssClass";
            this.txtCssClass.Size = new System.Drawing.Size(138, 22);
            this.txtCssClass.TabIndex = 9;
            this.txtCssClass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCssClass_KeyPress);
            // 
            // txtParrent
            // 
            this.txtParrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParrent.BackColor = System.Drawing.SystemColors.Window;
            this.txtParrent.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtParrent, true);
            this.txtParrent.Location = new System.Drawing.Point(649, 435);
            this.txtParrent.MaxLength = 50;
            this.txtParrent.Name = "txtParrent";
            this.txtParrent.Size = new System.Drawing.Size(239, 22);
            this.txtParrent.TabIndex = 10;
            this.txtParrent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParrent_KeyPress);
            // 
            // txtSortIndex
            // 
            this.txtSortIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSortIndex.BackColor = System.Drawing.SystemColors.Window;
            this.txtSortIndex.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtSortIndex, true);
            this.txtSortIndex.Location = new System.Drawing.Point(779, 466);
            this.txtSortIndex.Name = "txtSortIndex";
            this.txtSortIndex.Size = new System.Drawing.Size(39, 22);
            this.txtSortIndex.TabIndex = 14;
            this.txtSortIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSortIndex_KeyPress);
            this.txtSortIndex.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSortIndex_KeyUp);
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNote.BackColor = System.Drawing.SystemColors.Window;
            this.txtNote.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtNote, true);
            this.txtNote.Location = new System.Drawing.Point(80, 530);
            this.txtNote.MaxLength = 500;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(808, 22);
            this.txtNote.TabIndex = 18;
            this.txtNote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNote_KeyPress);
            // 
            // txtMenuWidth
            // 
            this.txtMenuWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMenuWidth.BackColor = System.Drawing.SystemColors.Window;
            this.txtMenuWidth.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtMenuWidth, true);
            this.txtMenuWidth.Location = new System.Drawing.Point(649, 466);
            this.txtMenuWidth.Name = "txtMenuWidth";
            this.txtMenuWidth.Size = new System.Drawing.Size(40, 22);
            this.txtMenuWidth.TabIndex = 13;
            this.txtMenuWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMenuWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMenuWidth_KeyPress);
            this.txtMenuWidth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMenuWidth_KeyUp);
            // 
            // txtMenuImageName
            // 
            this.txtMenuImageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMenuImageName.BackColor = System.Drawing.SystemColors.Window;
            this.txtMenuImageName.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtMenuImageName, true);
            this.txtMenuImageName.Location = new System.Drawing.Point(80, 498);
            this.txtMenuImageName.MaxLength = 200;
            this.txtMenuImageName.Name = "txtMenuImageName";
            this.txtMenuImageName.Size = new System.Drawing.Size(188, 22);
            this.txtMenuImageName.TabIndex = 15;
            this.txtMenuImageName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMenuImageName_KeyPress);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(-7, 372);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(85, 21);
            this.lblTitle.TabIndex = 25;
            this.lblTitle.Text = "Tiêu đề:";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblControllerName
            // 
            this.lblControllerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblControllerName.ForeColor = System.Drawing.Color.Black;
            this.lblControllerName.Location = new System.Drawing.Point(321, 372);
            this.lblControllerName.Name = "lblControllerName";
            this.lblControllerName.Size = new System.Drawing.Size(94, 21);
            this.lblControllerName.TabIndex = 26;
            this.lblControllerName.Text = "Form/Controller:";
            this.lblControllerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAcctionName
            // 
            this.lblAcctionName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAcctionName.ForeColor = System.Drawing.Color.Black;
            this.lblAcctionName.Location = new System.Drawing.Point(563, 372);
            this.lblAcctionName.Name = "lblAcctionName";
            this.lblAcctionName.Size = new System.Drawing.Size(85, 21);
            this.lblAcctionName.TabIndex = 35;
            this.lblAcctionName.Text = "Menu/Acction:";
            this.lblAcctionName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblControllerNameApi
            // 
            this.lblControllerNameApi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblControllerNameApi.ForeColor = System.Drawing.Color.Black;
            this.lblControllerNameApi.Location = new System.Drawing.Point(-7, 404);
            this.lblControllerNameApi.Name = "lblControllerNameApi";
            this.lblControllerNameApi.Size = new System.Drawing.Size(85, 21);
            this.lblControllerNameApi.TabIndex = 24;
            this.lblControllerNameApi.Text = "Controller Api:";
            this.lblControllerNameApi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAcctionNameApi
            // 
            this.lblAcctionNameApi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAcctionNameApi.ForeColor = System.Drawing.Color.Black;
            this.lblAcctionNameApi.Location = new System.Drawing.Point(330, 404);
            this.lblAcctionNameApi.Name = "lblAcctionNameApi";
            this.lblAcctionNameApi.Size = new System.Drawing.Size(85, 21);
            this.lblAcctionNameApi.TabIndex = 27;
            this.lblAcctionNameApi.Text = "Acction Api:";
            this.lblAcctionNameApi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRouteId
            // 
            this.lblRouteId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRouteId.ForeColor = System.Drawing.Color.Black;
            this.lblRouteId.Location = new System.Drawing.Point(563, 404);
            this.lblRouteId.Name = "lblRouteId";
            this.lblRouteId.Size = new System.Drawing.Size(85, 21);
            this.lblRouteId.TabIndex = 34;
            this.lblRouteId.Text = "RouteId:";
            this.lblRouteId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIcon
            // 
            this.lblIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIcon.ForeColor = System.Drawing.Color.Black;
            this.lblIcon.Location = new System.Drawing.Point(-7, 436);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(85, 21);
            this.lblIcon.TabIndex = 23;
            this.lblIcon.Text = "Icon:";
            this.lblIcon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCssClass
            // 
            this.lblCssClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCssClass.ForeColor = System.Drawing.Color.Black;
            this.lblCssClass.Location = new System.Drawing.Point(330, 436);
            this.lblCssClass.Name = "lblCssClass";
            this.lblCssClass.Size = new System.Drawing.Size(85, 21);
            this.lblCssClass.TabIndex = 28;
            this.lblCssClass.Text = "CssClass:";
            this.lblCssClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblParrent
            // 
            this.lblParrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblParrent.ForeColor = System.Drawing.Color.Black;
            this.lblParrent.Location = new System.Drawing.Point(563, 436);
            this.lblParrent.Name = "lblParrent";
            this.lblParrent.Size = new System.Drawing.Size(85, 21);
            this.lblParrent.TabIndex = 33;
            this.lblParrent.Text = "Parrent:";
            this.lblParrent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSortIndex
            // 
            this.lblSortIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSortIndex.ForeColor = System.Drawing.Color.Black;
            this.lblSortIndex.Location = new System.Drawing.Point(695, 467);
            this.lblSortIndex.Name = "lblSortIndex";
            this.lblSortIndex.Size = new System.Drawing.Size(85, 21);
            this.lblSortIndex.TabIndex = 36;
            this.lblSortIndex.Text = "SortIndex:";
            this.lblSortIndex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNote
            // 
            this.lblNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNote.ForeColor = System.Drawing.Color.Black;
            this.lblNote.Location = new System.Drawing.Point(-7, 531);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(85, 21);
            this.lblNote.TabIndex = 20;
            this.lblNote.Text = "Note:";
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProjectUsed
            // 
            this.lblProjectUsed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProjectUsed.ForeColor = System.Drawing.Color.Black;
            this.lblProjectUsed.Location = new System.Drawing.Point(-7, 467);
            this.lblProjectUsed.Name = "lblProjectUsed";
            this.lblProjectUsed.Size = new System.Drawing.Size(85, 21);
            this.lblProjectUsed.TabIndex = 22;
            this.lblProjectUsed.Text = "ProjectUsed:";
            this.lblProjectUsed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMenuWidth
            // 
            this.lblMenuWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMenuWidth.ForeColor = System.Drawing.Color.Black;
            this.lblMenuWidth.Location = new System.Drawing.Point(563, 467);
            this.lblMenuWidth.Name = "lblMenuWidth";
            this.lblMenuWidth.Size = new System.Drawing.Size(85, 21);
            this.lblMenuWidth.TabIndex = 32;
            this.lblMenuWidth.Text = "MenuWidth:";
            this.lblMenuWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMenuImageName
            // 
            this.lblMenuImageName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMenuImageName.ForeColor = System.Drawing.Color.Black;
            this.lblMenuImageName.Location = new System.Drawing.Point(-7, 499);
            this.lblMenuImageName.Name = "lblMenuImageName";
            this.lblMenuImageName.Size = new System.Drawing.Size(85, 21);
            this.lblMenuImageName.TabIndex = 21;
            this.lblMenuImageName.Text = "Image:";
            this.lblMenuImageName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFormShowType
            // 
            this.lblFormShowType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFormShowType.ForeColor = System.Drawing.Color.Black;
            this.lblFormShowType.Location = new System.Drawing.Point(330, 467);
            this.lblFormShowType.Name = "lblFormShowType";
            this.lblFormShowType.Size = new System.Drawing.Size(85, 21);
            this.lblFormShowType.TabIndex = 29;
            this.lblFormShowType.Text = "Show Type:";
            this.lblFormShowType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbProjectUsed
            // 
            this.cmbProjectUsed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProjectUsed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjectUsed.FormattingEnabled = true;
            this.cmbProjectUsed.Items.AddRange(new object[] {
            "0. All",
            "1. Desktop App",
            "2. Web App",
            "3. Mobile App",
            "4. Desktop + Web",
            "5. Desktop + Mobile",
            "6. Web + Mobile"});
            this.cmbProjectUsed.Location = new System.Drawing.Point(80, 467);
            this.cmbProjectUsed.Name = "cmbProjectUsed";
            this.cmbProjectUsed.Size = new System.Drawing.Size(235, 21);
            this.cmbProjectUsed.TabIndex = 11;
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // cmbShowType
            // 
            this.cmbShowType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbShowType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShowType.FormattingEnabled = true;
            this.cmbShowType.Items.AddRange(new object[] {
            "Window/Open",
            "Dialog/href",
            "Application/Extend"});
            this.cmbShowType.Location = new System.Drawing.Point(419, 467);
            this.cmbShowType.Name = "cmbShowType";
            this.cmbShowType.Size = new System.Drawing.Size(138, 21);
            this.cmbShowType.TabIndex = 12;
            // 
            // cmbParent
            // 
            this.cmbParent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParent.FormattingEnabled = true;
            this.cmbParent.Location = new System.Drawing.Point(419, 499);
            this.cmbParent.Name = "cmbParent";
            this.cmbParent.Size = new System.Drawing.Size(138, 21);
            this.cmbParent.TabIndex = 16;
            this.cmbParent.SelectedIndexChanged += new System.EventHandler(this.cmbParent_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(330, 499);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tab/Group:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbNhomRibbonBar
            // 
            this.cmbNhomRibbonBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNhomRibbonBar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhomRibbonBar.FormattingEnabled = true;
            this.cmbNhomRibbonBar.Location = new System.Drawing.Point(696, 499);
            this.cmbNhomRibbonBar.Name = "cmbNhomRibbonBar";
            this.cmbNhomRibbonBar.Size = new System.Drawing.Size(192, 21);
            this.cmbNhomRibbonBar.TabIndex = 17;
            // 
            // lblid_subparent
            // 
            this.lblid_subparent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblid_subparent.ForeColor = System.Drawing.Color.Black;
            this.lblid_subparent.Location = new System.Drawing.Point(563, 499);
            this.lblid_subparent.Name = "lblid_subparent";
            this.lblid_subparent.Size = new System.Drawing.Size(127, 21);
            this.lblid_subparent.TabIndex = 31;
            this.lblid_subparent.Text = "Ribbobar/Sub Group:";
            this.lblid_subparent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(274, 497);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(43, 23);
            this.btnBrowse.TabIndex = 39;
            this.btnBrowse.Text = ":::";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // col_Id
            // 
            this.col_Id.DataPropertyName = "Id";
            this.col_Id.HeaderText = "Id";
            this.col_Id.Name = "col_Id";
            this.col_Id.ReadOnly = true;
            this.col_Id.Visible = false;
            // 
            // col_Title
            // 
            this.col_Title.DataPropertyName = "Title";
            this.col_Title.HeaderText = "Title";
            this.col_Title.Name = "col_Title";
            this.col_Title.ReadOnly = true;
            // 
            // col_ControllerName
            // 
            this.col_ControllerName.DataPropertyName = "ControllerName";
            this.col_ControllerName.HeaderText = "ControllerName";
            this.col_ControllerName.Name = "col_ControllerName";
            this.col_ControllerName.ReadOnly = true;
            // 
            // col_AcctionName
            // 
            this.col_AcctionName.DataPropertyName = "AcctionName";
            this.col_AcctionName.HeaderText = "AcctionName";
            this.col_AcctionName.Name = "col_AcctionName";
            this.col_AcctionName.ReadOnly = true;
            // 
            // col_ControllerNameApi
            // 
            this.col_ControllerNameApi.DataPropertyName = "ControllerNameApi";
            this.col_ControllerNameApi.HeaderText = "ControllerNameApi";
            this.col_ControllerNameApi.Name = "col_ControllerNameApi";
            this.col_ControllerNameApi.ReadOnly = true;
            // 
            // col_AcctionNameApi
            // 
            this.col_AcctionNameApi.DataPropertyName = "AcctionNameApi";
            this.col_AcctionNameApi.HeaderText = "AcctionNameApi";
            this.col_AcctionNameApi.Name = "col_AcctionNameApi";
            this.col_AcctionNameApi.ReadOnly = true;
            // 
            // col_RouteId
            // 
            this.col_RouteId.DataPropertyName = "RouteId";
            this.col_RouteId.HeaderText = "RouteId";
            this.col_RouteId.Name = "col_RouteId";
            this.col_RouteId.ReadOnly = true;
            // 
            // col_IsMenu
            // 
            this.col_IsMenu.DataPropertyName = "IsMenu";
            this.col_IsMenu.HeaderText = "IsMenu";
            this.col_IsMenu.Name = "col_IsMenu";
            this.col_IsMenu.ReadOnly = true;
            // 
            // col_IsPublic
            // 
            this.col_IsPublic.DataPropertyName = "IsPublic";
            this.col_IsPublic.HeaderText = "IsPublic";
            this.col_IsPublic.Name = "col_IsPublic";
            this.col_IsPublic.ReadOnly = true;
            // 
            // col_Icon
            // 
            this.col_Icon.DataPropertyName = "Icon";
            this.col_Icon.HeaderText = "Icon";
            this.col_Icon.Name = "col_Icon";
            this.col_Icon.ReadOnly = true;
            // 
            // col_CssClass
            // 
            this.col_CssClass.DataPropertyName = "CssClass";
            this.col_CssClass.HeaderText = "CssClass";
            this.col_CssClass.Name = "col_CssClass";
            this.col_CssClass.ReadOnly = true;
            // 
            // col_Parrent
            // 
            this.col_Parrent.DataPropertyName = "Parrent";
            this.col_Parrent.HeaderText = "Parrent";
            this.col_Parrent.Name = "col_Parrent";
            this.col_Parrent.ReadOnly = true;
            // 
            // col_Status
            // 
            this.col_Status.DataPropertyName = "Status";
            this.col_Status.HeaderText = "Status";
            this.col_Status.Name = "col_Status";
            this.col_Status.ReadOnly = true;
            // 
            // col_CreateDate
            // 
            this.col_CreateDate.DataPropertyName = "CreateDate";
            this.col_CreateDate.HeaderText = "CreateDate";
            this.col_CreateDate.Name = "col_CreateDate";
            this.col_CreateDate.ReadOnly = true;
            // 
            // col_SortIndex
            // 
            this.col_SortIndex.DataPropertyName = "SortIndex";
            this.col_SortIndex.HeaderText = "SortIndex";
            this.col_SortIndex.Name = "col_SortIndex";
            this.col_SortIndex.ReadOnly = true;
            // 
            // col_Note
            // 
            this.col_Note.DataPropertyName = "Note";
            this.col_Note.HeaderText = "Note";
            this.col_Note.Name = "col_Note";
            this.col_Note.ReadOnly = true;
            // 
            // col_ProjectUsed
            // 
            this.col_ProjectUsed.DataPropertyName = "ProjectUsed";
            this.col_ProjectUsed.HeaderText = "ProjectUsed";
            this.col_ProjectUsed.Name = "col_ProjectUsed";
            this.col_ProjectUsed.ReadOnly = true;
            // 
            // col_FK_MenuGroup
            // 
            this.col_FK_MenuGroup.DataPropertyName = "FK_MenuGroup";
            this.col_FK_MenuGroup.HeaderText = "FK_MenuGroup";
            this.col_FK_MenuGroup.Name = "col_FK_MenuGroup";
            this.col_FK_MenuGroup.ReadOnly = true;
            // 
            // col_MenuWidth
            // 
            this.col_MenuWidth.DataPropertyName = "MenuWidth";
            this.col_MenuWidth.HeaderText = "MenuWidth";
            this.col_MenuWidth.Name = "col_MenuWidth";
            this.col_MenuWidth.ReadOnly = true;
            // 
            // col_MenuImageName
            // 
            this.col_MenuImageName.DataPropertyName = "MenuImageName";
            this.col_MenuImageName.HeaderText = "MenuImageName";
            this.col_MenuImageName.Name = "col_MenuImageName";
            this.col_MenuImageName.ReadOnly = true;
            // 
            // col_FK_MenuImage
            // 
            this.col_FK_MenuImage.DataPropertyName = "FK_MenuImage";
            this.col_FK_MenuImage.HeaderText = "FK_MenuImage";
            this.col_FK_MenuImage.Name = "col_FK_MenuImage";
            this.col_FK_MenuImage.ReadOnly = true;
            // 
            // col_CreateUser
            // 
            this.col_CreateUser.DataPropertyName = "CreateUser";
            this.col_CreateUser.HeaderText = "CreateUser";
            this.col_CreateUser.Name = "col_CreateUser";
            this.col_CreateUser.ReadOnly = true;
            // 
            // col_UpdateUser
            // 
            this.col_UpdateUser.DataPropertyName = "UpdateUser";
            this.col_UpdateUser.HeaderText = "UpdateUser";
            this.col_UpdateUser.Name = "col_UpdateUser";
            this.col_UpdateUser.ReadOnly = true;
            // 
            // col_FormShowType
            // 
            this.col_FormShowType.DataPropertyName = "FormShowType";
            this.col_FormShowType.HeaderText = "FormShowType";
            this.col_FormShowType.Name = "col_FormShowType";
            this.col_FormShowType.ReadOnly = true;
            // 
            // frmMenuFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(896, 602);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.cmbParent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbNhomRibbonBar);
            this.Controls.Add(this.lblid_subparent);
            this.Controls.Add(this.cmbShowType);
            this.Controls.Add(this.cmbProjectUsed);
            this.Controls.Add(this.gridMain);
            this.Controls.Add(this.panelcomtrol);
            this.Controls.Add(this.lTieude);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblControllerName);
            this.Controls.Add(this.txtControllerName);
            this.Controls.Add(this.lblAcctionName);
            this.Controls.Add(this.txtAcctionName);
            this.Controls.Add(this.lblControllerNameApi);
            this.Controls.Add(this.txtControllerNameApi);
            this.Controls.Add(this.lblAcctionNameApi);
            this.Controls.Add(this.txtAcctionNameApi);
            this.Controls.Add(this.lblRouteId);
            this.Controls.Add(this.txtRouteId);
            this.Controls.Add(this.chbIsMenu);
            this.Controls.Add(this.chbIsPublic);
            this.Controls.Add(this.lblIcon);
            this.Controls.Add(this.txtIcon);
            this.Controls.Add(this.lblCssClass);
            this.Controls.Add(this.txtCssClass);
            this.Controls.Add(this.lblParrent);
            this.Controls.Add(this.txtParrent);
            this.Controls.Add(this.txtSortIndex);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.lblProjectUsed);
            this.Controls.Add(this.lblMenuWidth);
            this.Controls.Add(this.txtMenuWidth);
            this.Controls.Add(this.lblMenuImageName);
            this.Controls.Add(this.txtMenuImageName);
            this.Controls.Add(this.lblFormShowType);
            this.Controls.Add(this.lblSortIndex);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMenuFunction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Function";
            this.Load += new System.EventHandler(this.frmMenuFunction_Load);
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
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.Label lblControllerName;
		private System.Windows.Forms.TextBox txtControllerName;
		private System.Windows.Forms.Label lblAcctionName;
		private System.Windows.Forms.TextBox txtAcctionName;
		private System.Windows.Forms.Label lblControllerNameApi;
		private System.Windows.Forms.TextBox txtControllerNameApi;
		private System.Windows.Forms.Label lblAcctionNameApi;
		private System.Windows.Forms.TextBox txtAcctionNameApi;
		private System.Windows.Forms.Label lblRouteId;
		private System.Windows.Forms.TextBox txtRouteId;
		private System.Windows.Forms.CheckBox chbIsMenu;
		private System.Windows.Forms.CheckBox chbIsPublic;
		private System.Windows.Forms.Label lblIcon;
		private System.Windows.Forms.TextBox txtIcon;
		private System.Windows.Forms.Label lblCssClass;
		private System.Windows.Forms.TextBox txtCssClass;
		private System.Windows.Forms.Label lblParrent;
		private System.Windows.Forms.TextBox txtParrent;
		private System.Windows.Forms.Label lblSortIndex;
		private System.Windows.Forms.TextBox txtSortIndex;
		private System.Windows.Forms.Label lblNote;
		private System.Windows.Forms.TextBox txtNote;
		private System.Windows.Forms.Label lblProjectUsed;
		private System.Windows.Forms.Label lblMenuWidth;
		private System.Windows.Forms.TextBox txtMenuWidth;
		private System.Windows.Forms.Label lblMenuImageName;
		private System.Windows.Forms.TextBox txtMenuImageName;
		private System.Windows.Forms.Label lblFormShowType;
        private System.Windows.Forms.ComboBox cmbProjectUsed;
        private DevComponents.DotNetBar.StyleManager styleManager;
        private System.Windows.Forms.ComboBox cmbShowType;
        private System.Windows.Forms.ComboBox cmbParent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNhomRibbonBar;
        private System.Windows.Forms.Label lblid_subparent;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ControllerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AcctionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ControllerNameApi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AcctionNameApi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RouteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IsMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IsPublic;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Icon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CssClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Parrent;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SortIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProjectUsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_MenuGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MenuWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MenuImageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_MenuImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CreateUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_UpdateUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FormShowType;
    }
}
