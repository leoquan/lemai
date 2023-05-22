namespace LeMaiDesktop
{
	partial class frmMenuFuntionGroup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.txtSortIndex = new System.Windows.Forms.TextBox();
            this.txtIcon = new System.Windows.Forms.TextBox();
            this.txtCssClass = new System.Windows.Forms.TextBox();
            this.txtProgramUse = new System.Windows.Forms.TextBox();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.lblSortIndex = new System.Windows.Forms.Label();
            this.lblIcon = new System.Windows.Forms.Label();
            this.lblCssClass = new System.Windows.Forms.Label();
            this.lblFK_MenuGroup = new System.Windows.Forms.Label();
            this.lblProjectUsed = new System.Windows.Forms.Label();
            this.cmbProjectUsed = new System.Windows.Forms.ComboBox();
            this.cmbParrentMenuGroup = new System.Windows.Forms.ComboBox();
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SortIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Icon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CssClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FK_MenuGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProjectUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panelcomtrol.Size = new System.Drawing.Size(800, 39);
            this.panelcomtrol.TabIndex = 6;
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
            this.btnNew.Location = new System.Drawing.Point(382, 5);
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
            this.btnSave.Location = new System.Drawing.Point(543, 5);
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
            this.btnEdit.Location = new System.Drawing.Point(461, 5);
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
            this.btnDelete.Location = new System.Drawing.Point(620, 5);
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
            this.btnClose.Location = new System.Drawing.Point(701, 5);
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
            this.lTieude.Size = new System.Drawing.Size(800, 30);
            this.lTieude.TabIndex = 300;
            this.lTieude.Text = "    Danh sách nhóm menu";
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
            this.gridMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.col_GroupName,
            this.col_SortIndex,
            this.col_Icon,
            this.col_CssClass,
            this.col_CreateDate,
            this.col_Status,
            this.col_FK_MenuGroup,
            this.col_ProjectUsed});
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
            this.gridMain.Location = new System.Drawing.Point(3, 33);
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
            this.gridMain.Size = new System.Drawing.Size(797, 447);
            this.gridMain.TabIndex = 1164;
            this.gridMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMain_CellDoubleClick);
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            this.highlighter.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Green;
            // 
            // txtGroupName
            // 
            this.txtGroupName.BackColor = System.Drawing.SystemColors.Window;
            this.txtGroupName.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtGroupName, true);
            this.txtGroupName.Location = new System.Drawing.Point(95, 501);
            this.txtGroupName.MaxLength = 100;
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(317, 22);
            this.txtGroupName.TabIndex = 0;
            this.txtGroupName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGroupName_KeyPress);
            // 
            // txtSortIndex
            // 
            this.txtSortIndex.BackColor = System.Drawing.SystemColors.Window;
            this.txtSortIndex.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtSortIndex, true);
            this.txtSortIndex.Location = new System.Drawing.Point(703, 501);
            this.txtSortIndex.MaxLength = 3;
            this.txtSortIndex.Name = "txtSortIndex";
            this.txtSortIndex.Size = new System.Drawing.Size(65, 22);
            this.txtSortIndex.TabIndex = 2;
            this.txtSortIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSortIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSortIndex_KeyPress);
            this.txtSortIndex.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSortIndex_KeyUp);
            // 
            // txtIcon
            // 
            this.txtIcon.BackColor = System.Drawing.SystemColors.Window;
            this.txtIcon.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtIcon, true);
            this.txtIcon.Location = new System.Drawing.Point(254, 533);
            this.txtIcon.MaxLength = 100;
            this.txtIcon.Name = "txtIcon";
            this.txtIcon.Size = new System.Drawing.Size(100, 22);
            this.txtIcon.TabIndex = 4;
            this.txtIcon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIcon_KeyPress);
            // 
            // txtCssClass
            // 
            this.txtCssClass.BackColor = System.Drawing.SystemColors.Window;
            this.txtCssClass.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtCssClass, true);
            this.txtCssClass.Location = new System.Drawing.Point(95, 533);
            this.txtCssClass.MaxLength = 100;
            this.txtCssClass.Name = "txtCssClass";
            this.txtCssClass.Size = new System.Drawing.Size(100, 22);
            this.txtCssClass.TabIndex = 3;
            this.txtCssClass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCssClass_KeyPress);
            // 
            // txtProgramUse
            // 
            this.txtProgramUse.BackColor = System.Drawing.SystemColors.Window;
            this.txtProgramUse.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtProgramUse, true);
            this.txtProgramUse.Location = new System.Drawing.Point(359, 532);
            this.txtProgramUse.MaxLength = 100;
            this.txtProgramUse.Name = "txtProgramUse";
            this.txtProgramUse.Size = new System.Drawing.Size(56, 22);
            this.txtProgramUse.TabIndex = 1165;
            // 
            // lblGroupName
            // 
            this.lblGroupName.ForeColor = System.Drawing.Color.Black;
            this.lblGroupName.Location = new System.Drawing.Point(0, 501);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(94, 22);
            this.lblGroupName.TabIndex = 1000;
            this.lblGroupName.Text = "GroupName:";
            this.lblGroupName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSortIndex
            // 
            this.lblSortIndex.ForeColor = System.Drawing.Color.Black;
            this.lblSortIndex.Location = new System.Drawing.Point(624, 501);
            this.lblSortIndex.Name = "lblSortIndex";
            this.lblSortIndex.Size = new System.Drawing.Size(73, 22);
            this.lblSortIndex.TabIndex = 1000;
            this.lblSortIndex.Text = "SortIndex:";
            this.lblSortIndex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIcon
            // 
            this.lblIcon.ForeColor = System.Drawing.Color.Black;
            this.lblIcon.Location = new System.Drawing.Point(196, 532);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(59, 22);
            this.lblIcon.TabIndex = 1000;
            this.lblIcon.Text = "Icon:";
            this.lblIcon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCssClass
            // 
            this.lblCssClass.ForeColor = System.Drawing.Color.Black;
            this.lblCssClass.Location = new System.Drawing.Point(4, 533);
            this.lblCssClass.Name = "lblCssClass";
            this.lblCssClass.Size = new System.Drawing.Size(90, 22);
            this.lblCssClass.TabIndex = 1000;
            this.lblCssClass.Text = "CssClass:";
            this.lblCssClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFK_MenuGroup
            // 
            this.lblFK_MenuGroup.ForeColor = System.Drawing.Color.Black;
            this.lblFK_MenuGroup.Location = new System.Drawing.Point(421, 533);
            this.lblFK_MenuGroup.Name = "lblFK_MenuGroup";
            this.lblFK_MenuGroup.Size = new System.Drawing.Size(76, 22);
            this.lblFK_MenuGroup.TabIndex = 1000;
            this.lblFK_MenuGroup.Text = "Parrent:";
            this.lblFK_MenuGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProjectUsed
            // 
            this.lblProjectUsed.ForeColor = System.Drawing.Color.Black;
            this.lblProjectUsed.Location = new System.Drawing.Point(418, 501);
            this.lblProjectUsed.Name = "lblProjectUsed";
            this.lblProjectUsed.Size = new System.Drawing.Size(79, 22);
            this.lblProjectUsed.TabIndex = 1000;
            this.lblProjectUsed.Text = "ProjectUsed:";
            this.lblProjectUsed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbProjectUsed
            // 
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
            this.cmbProjectUsed.Location = new System.Drawing.Point(498, 503);
            this.cmbProjectUsed.Name = "cmbProjectUsed";
            this.cmbProjectUsed.Size = new System.Drawing.Size(121, 21);
            this.cmbProjectUsed.TabIndex = 1;
            // 
            // cmbParrentMenuGroup
            // 
            this.cmbParrentMenuGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParrentMenuGroup.FormattingEnabled = true;
            this.cmbParrentMenuGroup.Location = new System.Drawing.Point(498, 534);
            this.cmbParrentMenuGroup.Name = "cmbParrentMenuGroup";
            this.cmbParrentMenuGroup.Size = new System.Drawing.Size(270, 21);
            this.cmbParrentMenuGroup.TabIndex = 5;
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // col_Id
            // 
            this.col_Id.DataPropertyName = "Id";
            this.col_Id.HeaderText = "Id";
            this.col_Id.Name = "col_Id";
            this.col_Id.ReadOnly = true;
            this.col_Id.Visible = false;
            // 
            // col_GroupName
            // 
            this.col_GroupName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_GroupName.DataPropertyName = "GroupName";
            this.col_GroupName.HeaderText = "GroupName";
            this.col_GroupName.Name = "col_GroupName";
            this.col_GroupName.ReadOnly = true;
            this.col_GroupName.Width = 200;
            // 
            // col_SortIndex
            // 
            this.col_SortIndex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_SortIndex.DataPropertyName = "SortIndex";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            this.col_SortIndex.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_SortIndex.HeaderText = "Sort";
            this.col_SortIndex.Name = "col_SortIndex";
            this.col_SortIndex.ReadOnly = true;
            this.col_SortIndex.Width = 50;
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
            // col_CreateDate
            // 
            this.col_CreateDate.DataPropertyName = "CreateDate";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            this.col_CreateDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_CreateDate.HeaderText = "CreateDate";
            this.col_CreateDate.Name = "col_CreateDate";
            this.col_CreateDate.ReadOnly = true;
            // 
            // col_Status
            // 
            this.col_Status.DataPropertyName = "Status";
            this.col_Status.HeaderText = "Status";
            this.col_Status.Name = "col_Status";
            this.col_Status.ReadOnly = true;
            // 
            // col_FK_MenuGroup
            // 
            this.col_FK_MenuGroup.DataPropertyName = "FK_MenuGroup";
            this.col_FK_MenuGroup.HeaderText = "FK_MenuGroup";
            this.col_FK_MenuGroup.Name = "col_FK_MenuGroup";
            this.col_FK_MenuGroup.ReadOnly = true;
            this.col_FK_MenuGroup.Visible = false;
            // 
            // col_ProjectUsed
            // 
            this.col_ProjectUsed.DataPropertyName = "ProjectUsed";
            this.col_ProjectUsed.HeaderText = "ProjectUsed";
            this.col_ProjectUsed.Name = "col_ProjectUsed";
            this.col_ProjectUsed.ReadOnly = true;
            // 
            // frmMenuFuntionGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.txtProgramUse);
            this.Controls.Add(this.cmbParrentMenuGroup);
            this.Controls.Add(this.cmbProjectUsed);
            this.Controls.Add(this.gridMain);
            this.Controls.Add(this.panelcomtrol);
            this.Controls.Add(this.lTieude);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.lblSortIndex);
            this.Controls.Add(this.txtSortIndex);
            this.Controls.Add(this.txtIcon);
            this.Controls.Add(this.txtCssClass);
            this.Controls.Add(this.lblFK_MenuGroup);
            this.Controls.Add(this.lblProjectUsed);
            this.Controls.Add(this.lblIcon);
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.lblCssClass);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuFuntionGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuFuntionGroup";
            this.Load += new System.EventHandler(this.frmMenuFuntionGroup_Load);
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
		private System.Windows.Forms.Label lblGroupName;
		private System.Windows.Forms.TextBox txtGroupName;
		private System.Windows.Forms.Label lblSortIndex;
		private System.Windows.Forms.TextBox txtSortIndex;
		private System.Windows.Forms.Label lblIcon;
		private System.Windows.Forms.TextBox txtIcon;
		private System.Windows.Forms.Label lblCssClass;
		private System.Windows.Forms.TextBox txtCssClass;
		private System.Windows.Forms.Label lblFK_MenuGroup;
		private System.Windows.Forms.Label lblProjectUsed;
        private System.Windows.Forms.ComboBox cmbProjectUsed;
        private System.Windows.Forms.ComboBox cmbParrentMenuGroup;
        private DevComponents.DotNetBar.StyleManager styleManager;
        private System.Windows.Forms.TextBox txtProgramUse;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SortIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Icon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CssClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_MenuGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProjectUsed;
    }
}
