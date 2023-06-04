namespace LeMaiDesktop
{
	partial class frmQuanLyBaoTriXe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.cmbFK_Vihcle = new System.Windows.Forms.ComboBox();
            this.txtTotalKM = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.cmbSubFK_Service = new System.Windows.Forms.ComboBox();
            this.txtSubCurrentValue = new System.Windows.Forms.TextBox();
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnNew = new DevComponents.DotNetBar.ButtonX();
            this.txtSearchForm = new System.Windows.Forms.TextBox();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnPrint = new DevComponents.DotNetBar.ButtonX();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab01 = new System.Windows.Forms.TabPage();
            this.gridParrent = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.menuParrent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuCopyParrent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPasteParrent = new System.Windows.Forms.ToolStripMenuItem();
            this.tab02 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNewChild = new DevComponents.DotNetBar.ButtonX();
            this.btnEditChild = new DevComponents.DotNetBar.ButtonX();
            this.btnDeleteChild = new DevComponents.DotNetBar.ButtonX();
            this.btnPrintChild = new DevComponents.DotNetBar.ButtonX();
            this.btnClose2 = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.btnRemove = new DevComponents.DotNetBar.ButtonX();
            this.gridChild = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.col_SubId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SubFK_Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SubFK_VihcleCoupon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SubServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SubCurrentValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SubServiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SubValueCycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SubConfigNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuChild = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuCopyChild = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPasteChild = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFK_Vihcle = new System.Windows.Forms.Label();
            this.lblTotalFee = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblSubFK_Service = new System.Windows.Forms.Label();
            this.lblSubCurrentValue = new System.Windows.Forms.Label();
            this.col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BienSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FK_Vihcle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TotalFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelControl.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tab01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridParrent)).BeginInit();
            this.menuParrent.SuspendLayout();
            this.tab02.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridChild)).BeginInit();
            this.menuChild.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            // 
            // cmbFK_Vihcle
            // 
            this.cmbFK_Vihcle.FormattingEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.cmbFK_Vihcle, true);
            this.cmbFK_Vihcle.Location = new System.Drawing.Point(34, 13);
            this.cmbFK_Vihcle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbFK_Vihcle.Name = "cmbFK_Vihcle";
            this.cmbFK_Vihcle.Size = new System.Drawing.Size(312, 23);
            this.cmbFK_Vihcle.TabIndex = 2;
            // 
            // txtTotalKM
            // 
            this.txtTotalKM.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalKM.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtTotalKM, true);
            this.txtTotalKM.Location = new System.Drawing.Point(399, 13);
            this.txtTotalKM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotalKM.Name = "txtTotalKM";
            this.txtTotalKM.Size = new System.Drawing.Size(160, 22);
            this.txtTotalKM.TabIndex = 3;
            this.txtTotalKM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalKM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalFee_KeyPress);
            this.txtTotalKM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTotalFee_KeyUp);
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.SystemColors.Window;
            this.txtNote.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtNote, true);
            this.txtNote.Location = new System.Drawing.Point(614, 13);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNote.MaxLength = 250;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(625, 22);
            this.txtNote.TabIndex = 5;
            this.txtNote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNote_KeyPress);
            // 
            // cmbSubFK_Service
            // 
            this.cmbSubFK_Service.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbSubFK_Service.FormattingEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.cmbSubFK_Service, true);
            this.cmbSubFK_Service.Location = new System.Drawing.Point(67, 623);
            this.cmbSubFK_Service.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbSubFK_Service.Name = "cmbSubFK_Service";
            this.cmbSubFK_Service.Size = new System.Drawing.Size(852, 23);
            this.cmbSubFK_Service.TabIndex = 7;
            // 
            // txtSubCurrentValue
            // 
            this.txtSubCurrentValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSubCurrentValue.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubCurrentValue.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtSubCurrentValue, true);
            this.txtSubCurrentValue.Location = new System.Drawing.Point(974, 623);
            this.txtSubCurrentValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSubCurrentValue.Name = "txtSubCurrentValue";
            this.txtSubCurrentValue.Size = new System.Drawing.Size(266, 22);
            this.txtSubCurrentValue.TabIndex = 9;
            this.txtSubCurrentValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubCurrentValue_KeyPress);
            this.txtSubCurrentValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSubCurrentValue_KeyUp);
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.SteelBlue;
            this.panelControl.Controls.Add(this.btnNew);
            this.panelControl.Controls.Add(this.txtSearchForm);
            this.panelControl.Controls.Add(this.btnClose);
            this.panelControl.Controls.Add(this.btnDelete);
            this.panelControl.Controls.Add(this.btnPrint);
            this.panelControl.Controls.Add(this.btnEdit);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl.Location = new System.Drawing.Point(4, 662);
            this.panelControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1240, 45);
            this.panelControl.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = global::LeMaiDesktop.Properties.Resources.iNew;
            this.btnNew.ImageTextSpacing = 3;
            this.btnNew.Location = new System.Drawing.Point(710, 5);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 35);
            this.btnNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNew.TabIndex = 1277;
            this.btnNew.Text = "&New";
            this.btnNew.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtSearchForm
            // 
            this.txtSearchForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchForm.Location = new System.Drawing.Point(6, 12);
            this.txtSearchForm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearchForm.Name = "txtSearchForm";
            this.txtSearchForm.Size = new System.Drawing.Size(401, 21);
            this.txtSearchForm.TabIndex = 0;
            this.txtSearchForm.TextChanged += new System.EventHandler(this.txtSearchForm_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::LeMaiDesktop.Properties.Resources.Close;
            this.btnClose.ImageTextSpacing = 3;
            this.btnClose.Location = new System.Drawing.Point(1131, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 35);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 1276;
            this.btnClose.Text = "&Close";
            this.btnClose.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::LeMaiDesktop.Properties.Resources.iDeleteAll;
            this.btnDelete.ImageTextSpacing = 3;
            this.btnDelete.Location = new System.Drawing.Point(913, 5);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 35);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.TabIndex = 1275;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = global::LeMaiDesktop.Properties.Resources.iPrint;
            this.btnPrint.ImageTextSpacing = 3;
            this.btnPrint.Location = new System.Drawing.Point(1021, 5);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(103, 35);
            this.btnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrint.TabIndex = 1274;
            this.btnPrint.Text = "&Print";
            this.btnPrint.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = global::LeMaiDesktop.Properties.Resources.iEditNew;
            this.btnEdit.ImageTextSpacing = 3;
            this.btnEdit.Location = new System.Drawing.Point(802, 5);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(103, 35);
            this.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEdit.TabIndex = 1274;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab01);
            this.tabControl.Controls.Add(this.tab02);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1256, 738);
            this.tabControl.TabIndex = 0;
            // 
            // tab01
            // 
            this.tab01.Controls.Add(this.panelControl);
            this.tab01.Controls.Add(this.gridParrent);
            this.tab01.Location = new System.Drawing.Point(4, 24);
            this.tab01.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tab01.Name = "tab01";
            this.tab01.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tab01.Size = new System.Drawing.Size(1248, 710);
            this.tab01.TabIndex = 0;
            this.tab01.Text = "Danh sách bảo trì";
            this.tab01.UseVisualStyleBackColor = true;
            // 
            // gridParrent
            // 
            this.gridParrent.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.gridParrent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridParrent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridParrent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridParrent.ColumnHeadersHeight = 25;
            this.gridParrent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Id,
            this.col_BienSo,
            this.col_TenXe,
            this.col_Date,
            this.col_FK_Vihcle,
            this.col_TotalFee,
            this.col_Note});
            this.gridParrent.ContextMenuStrip = this.menuParrent;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridParrent.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridParrent.EnableHeadersVisualStyles = false;
            this.gridParrent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.gridParrent.HighlightSelectedColumnHeaders = false;
            this.gridParrent.Location = new System.Drawing.Point(4, 3);
            this.gridParrent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridParrent.MultiSelect = false;
            this.gridParrent.Name = "gridParrent";
            this.gridParrent.PaintEnhancedSelection = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridParrent.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridParrent.RowHeadersVisible = false;
            this.gridParrent.RowHeadersWidth = 51;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.gridParrent.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.gridParrent.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridParrent.RowTemplate.Height = 25;
            this.gridParrent.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridParrent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridParrent.Size = new System.Drawing.Size(1244, 658);
            this.gridParrent.TabIndex = 0;
            this.gridParrent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridParrent_CellDoubleClick);
            // 
            // menuParrent
            // 
            this.menuParrent.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuParrent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCopyParrent,
            this.menuPasteParrent});
            this.menuParrent.Name = "menuChild";
            this.menuParrent.Size = new System.Drawing.Size(107, 56);
            // 
            // menuCopyParrent
            // 
            this.menuCopyParrent.Image = global::LeMaiDesktop.Properties.Resources.iEdit;
            this.menuCopyParrent.Name = "menuCopyParrent";
            this.menuCopyParrent.Size = new System.Drawing.Size(106, 26);
            this.menuCopyParrent.Text = "Copy";
            this.menuCopyParrent.Click += new System.EventHandler(this.menuCopyParrent_Click);
            // 
            // menuPasteParrent
            // 
            this.menuPasteParrent.Image = global::LeMaiDesktop.Properties.Resources.Done;
            this.menuPasteParrent.Name = "menuPasteParrent";
            this.menuPasteParrent.Size = new System.Drawing.Size(106, 26);
            this.menuPasteParrent.Text = "Paste";
            this.menuPasteParrent.Click += new System.EventHandler(this.menuPasteParrent_Click);
            // 
            // tab02
            // 
            this.tab02.Controls.Add(this.panel1);
            this.tab02.Controls.Add(this.gridChild);
            this.tab02.Controls.Add(this.cmbFK_Vihcle);
            this.tab02.Controls.Add(this.txtTotalKM);
            this.tab02.Controls.Add(this.txtNote);
            this.tab02.Controls.Add(this.cmbSubFK_Service);
            this.tab02.Controls.Add(this.txtSubCurrentValue);
            this.tab02.Controls.Add(this.lblFK_Vihcle);
            this.tab02.Controls.Add(this.lblTotalFee);
            this.tab02.Controls.Add(this.lblNote);
            this.tab02.Controls.Add(this.lblSubFK_Service);
            this.tab02.Controls.Add(this.lblSubCurrentValue);
            this.tab02.Location = new System.Drawing.Point(4, 24);
            this.tab02.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tab02.Name = "tab02";
            this.tab02.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tab02.Size = new System.Drawing.Size(1248, 710);
            this.tab02.TabIndex = 1;
            this.tab02.Text = "Chi tiết bảo trì";
            this.tab02.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnNewChild);
            this.panel1.Controls.Add(this.btnEditChild);
            this.panel1.Controls.Add(this.btnDeleteChild);
            this.panel1.Controls.Add(this.btnPrintChild);
            this.panel1.Controls.Add(this.btnClose2);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(4, 662);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 45);
            this.panel1.TabIndex = 19;
            // 
            // btnNewChild
            // 
            this.btnNewChild.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNewChild.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewChild.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNewChild.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewChild.Image = global::LeMaiDesktop.Properties.Resources.iNew;
            this.btnNewChild.ImageTextSpacing = 3;
            this.btnNewChild.Location = new System.Drawing.Point(384, 5);
            this.btnNewChild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNewChild.Name = "btnNewChild";
            this.btnNewChild.Size = new System.Drawing.Size(85, 35);
            this.btnNewChild.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNewChild.TabIndex = 3;
            this.btnNewChild.Text = "&New";
            this.btnNewChild.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnNewChild.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEditChild
            // 
            this.btnEditChild.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEditChild.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditChild.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEditChild.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditChild.Image = global::LeMaiDesktop.Properties.Resources.iEditNew;
            this.btnEditChild.ImageTextSpacing = 3;
            this.btnEditChild.Location = new System.Drawing.Point(808, 5);
            this.btnEditChild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditChild.Name = "btnEditChild";
            this.btnEditChild.Size = new System.Drawing.Size(103, 35);
            this.btnEditChild.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEditChild.TabIndex = 4;
            this.btnEditChild.Text = "&Edit";
            this.btnEditChild.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnEditChild.Click += new System.EventHandler(this.btnEditChild_Click);
            // 
            // btnDeleteChild
            // 
            this.btnDeleteChild.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeleteChild.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteChild.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDeleteChild.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteChild.Image = global::LeMaiDesktop.Properties.Resources.iCancel;
            this.btnDeleteChild.ImageTextSpacing = 3;
            this.btnDeleteChild.Location = new System.Drawing.Point(916, 5);
            this.btnDeleteChild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteChild.Name = "btnDeleteChild";
            this.btnDeleteChild.Size = new System.Drawing.Size(103, 35);
            this.btnDeleteChild.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDeleteChild.TabIndex = 5;
            this.btnDeleteChild.Text = "&Delete";
            this.btnDeleteChild.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnDeleteChild.Click += new System.EventHandler(this.btnDeleteChild_Click);
            // 
            // btnPrintChild
            // 
            this.btnPrintChild.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrintChild.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintChild.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrintChild.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintChild.Image = global::LeMaiDesktop.Properties.Resources.iPrint;
            this.btnPrintChild.ImageTextSpacing = 3;
            this.btnPrintChild.Location = new System.Drawing.Point(1026, 5);
            this.btnPrintChild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrintChild.Name = "btnPrintChild";
            this.btnPrintChild.Size = new System.Drawing.Size(103, 35);
            this.btnPrintChild.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrintChild.TabIndex = 6;
            this.btnPrintChild.Text = "&Print";
            this.btnPrintChild.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnPrintChild.Click += new System.EventHandler(this.btnPrintChild_Click);
            // 
            // btnClose2
            // 
            this.btnClose2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose2.Image = global::LeMaiDesktop.Properties.Resources.Close;
            this.btnClose2.ImageTextSpacing = 3;
            this.btnClose2.Location = new System.Drawing.Point(1133, 5);
            this.btnClose2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(103, 35);
            this.btnClose2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose2.TabIndex = 7;
            this.btnClose2.Text = "&Close";
            this.btnClose2.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnClose2.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::LeMaiDesktop.Properties.Resources.iSave;
            this.btnSave.ImageTextSpacing = 3;
            this.btnSave.Location = new System.Drawing.Point(699, 5);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 35);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save";
            this.btnSave.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::LeMaiDesktop.Properties.Resources.addrow;
            this.btnAdd.ImageTextSpacing = 3;
            this.btnAdd.Location = new System.Drawing.Point(475, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 35);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "&Add";
            this.btnAdd.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRemove.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Image = global::LeMaiDesktop.Properties.Resources.removerow;
            this.btnRemove.ImageTextSpacing = 3;
            this.btnRemove.Location = new System.Drawing.Point(592, 5);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(103, 35);
            this.btnRemove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gridChild
            // 
            this.gridChild.AllowUserToAddRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.gridChild.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.gridChild.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridChild.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridChild.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gridChild.ColumnHeadersHeight = 25;
            this.gridChild.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_SubId,
            this.col_SubFK_Service,
            this.col_SubFK_VihcleCoupon,
            this.col_SubServiceName,
            this.col_SubCurrentValue,
            this.col_SubServiceDate,
            this.col_SubValueCycle,
            this.col_SubConfigNote});
            this.gridChild.ContextMenuStrip = this.menuChild;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridChild.DefaultCellStyle = dataGridViewCellStyle14;
            this.gridChild.EnableHeadersVisualStyles = false;
            this.gridChild.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.gridChild.HighlightSelectedColumnHeaders = false;
            this.gridChild.Location = new System.Drawing.Point(13, 53);
            this.gridChild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridChild.MultiSelect = false;
            this.gridChild.Name = "gridChild";
            this.gridChild.PaintEnhancedSelection = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridChild.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.gridChild.RowHeadersVisible = false;
            this.gridChild.RowHeadersWidth = 51;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.gridChild.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.gridChild.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridChild.RowTemplate.Height = 25;
            this.gridChild.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridChild.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridChild.Size = new System.Drawing.Size(1227, 560);
            this.gridChild.TabIndex = 6;
            this.gridChild.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridMain_CellMouseDoubleClick);
            this.gridChild.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridMain_RowPostPaint);
            // 
            // col_SubId
            // 
            this.col_SubId.DataPropertyName = "Id";
            this.col_SubId.HeaderText = "Id";
            this.col_SubId.Name = "col_SubId";
            this.col_SubId.ReadOnly = true;
            this.col_SubId.Visible = false;
            // 
            // col_SubFK_Service
            // 
            this.col_SubFK_Service.DataPropertyName = "FK_Service";
            this.col_SubFK_Service.HeaderText = "FK_Service";
            this.col_SubFK_Service.Name = "col_SubFK_Service";
            this.col_SubFK_Service.ReadOnly = true;
            this.col_SubFK_Service.Visible = false;
            // 
            // col_SubFK_VihcleCoupon
            // 
            this.col_SubFK_VihcleCoupon.DataPropertyName = "FK_VihcleCoupon";
            this.col_SubFK_VihcleCoupon.HeaderText = "FK_VihcleCoupon";
            this.col_SubFK_VihcleCoupon.Name = "col_SubFK_VihcleCoupon";
            this.col_SubFK_VihcleCoupon.ReadOnly = true;
            this.col_SubFK_VihcleCoupon.Visible = false;
            // 
            // col_SubServiceName
            // 
            this.col_SubServiceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_SubServiceName.DataPropertyName = "ServiceName";
            this.col_SubServiceName.HeaderText = "Tên dịch vụ";
            this.col_SubServiceName.Name = "col_SubServiceName";
            this.col_SubServiceName.ReadOnly = true;
            this.col_SubServiceName.Width = 200;
            // 
            // col_SubCurrentValue
            // 
            this.col_SubCurrentValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_SubCurrentValue.DataPropertyName = "CurrentValue";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N0";
            this.col_SubCurrentValue.DefaultCellStyle = dataGridViewCellStyle11;
            this.col_SubCurrentValue.HeaderText = "Số tiền";
            this.col_SubCurrentValue.Name = "col_SubCurrentValue";
            this.col_SubCurrentValue.ReadOnly = true;
            // 
            // col_SubServiceDate
            // 
            this.col_SubServiceDate.DataPropertyName = "ServiceDate";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.Format = "dd/MM/yyyy HH:mm:ss";
            this.col_SubServiceDate.DefaultCellStyle = dataGridViewCellStyle12;
            this.col_SubServiceDate.HeaderText = "Ngày";
            this.col_SubServiceDate.Name = "col_SubServiceDate";
            this.col_SubServiceDate.ReadOnly = true;
            this.col_SubServiceDate.Visible = false;
            // 
            // col_SubValueCycle
            // 
            this.col_SubValueCycle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_SubValueCycle.DataPropertyName = "ValueCycle";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "N2";
            this.col_SubValueCycle.DefaultCellStyle = dataGridViewCellStyle13;
            this.col_SubValueCycle.HeaderText = "Giá trị mục tiêu";
            this.col_SubValueCycle.Name = "col_SubValueCycle";
            this.col_SubValueCycle.ReadOnly = true;
            // 
            // col_SubConfigNote
            // 
            this.col_SubConfigNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_SubConfigNote.DataPropertyName = "ConfigNote";
            this.col_SubConfigNote.HeaderText = "Ghi chú";
            this.col_SubConfigNote.Name = "col_SubConfigNote";
            this.col_SubConfigNote.ReadOnly = true;
            // 
            // menuChild
            // 
            this.menuChild.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuChild.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCopyChild,
            this.menuPasteChild});
            this.menuChild.Name = "menuChild";
            this.menuChild.Size = new System.Drawing.Size(107, 56);
            // 
            // menuCopyChild
            // 
            this.menuCopyChild.Image = global::LeMaiDesktop.Properties.Resources.iEdit;
            this.menuCopyChild.Name = "menuCopyChild";
            this.menuCopyChild.Size = new System.Drawing.Size(106, 26);
            this.menuCopyChild.Text = "Copy";
            this.menuCopyChild.Click += new System.EventHandler(this.menuCopyChild_Click);
            // 
            // menuPasteChild
            // 
            this.menuPasteChild.Image = global::LeMaiDesktop.Properties.Resources.Done;
            this.menuPasteChild.Name = "menuPasteChild";
            this.menuPasteChild.Size = new System.Drawing.Size(106, 26);
            this.menuPasteChild.Text = "Paste";
            this.menuPasteChild.Click += new System.EventHandler(this.menuPasteChild_Click);
            // 
            // lblFK_Vihcle
            // 
            this.lblFK_Vihcle.AutoSize = true;
            this.lblFK_Vihcle.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFK_Vihcle.ForeColor = System.Drawing.Color.Black;
            this.lblFK_Vihcle.Location = new System.Drawing.Point(9, 17);
            this.lblFK_Vihcle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFK_Vihcle.Name = "lblFK_Vihcle";
            this.lblFK_Vihcle.Size = new System.Drawing.Size(25, 14);
            this.lblFK_Vihcle.TabIndex = 1000;
            this.lblFK_Vihcle.Text = "Xe:";
            // 
            // lblTotalFee
            // 
            this.lblTotalFee.AutoSize = true;
            this.lblTotalFee.ForeColor = System.Drawing.Color.Black;
            this.lblTotalFee.Location = new System.Drawing.Point(350, 17);
            this.lblTotalFee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalFee.Name = "lblTotalFee";
            this.lblTotalFee.Size = new System.Drawing.Size(47, 15);
            this.lblTotalFee.TabIndex = 1000;
            this.lblTotalFee.Text = "Số KM:";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.ForeColor = System.Drawing.Color.Black;
            this.lblNote.Location = new System.Drawing.Point(563, 17);
            this.lblNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(52, 15);
            this.lblNote.TabIndex = 1000;
            this.lblNote.Text = "Ghi chú:";
            // 
            // lblSubFK_Service
            // 
            this.lblSubFK_Service.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSubFK_Service.AutoSize = true;
            this.lblSubFK_Service.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubFK_Service.ForeColor = System.Drawing.Color.Black;
            this.lblSubFK_Service.Location = new System.Drawing.Point(17, 627);
            this.lblSubFK_Service.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubFK_Service.Name = "lblSubFK_Service";
            this.lblSubFK_Service.Size = new System.Drawing.Size(51, 14);
            this.lblSubFK_Service.TabIndex = 1000;
            this.lblSubFK_Service.Text = "Dịch vụ:";
            // 
            // lblSubCurrentValue
            // 
            this.lblSubCurrentValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSubCurrentValue.AutoSize = true;
            this.lblSubCurrentValue.ForeColor = System.Drawing.Color.Black;
            this.lblSubCurrentValue.Location = new System.Drawing.Point(927, 627);
            this.lblSubCurrentValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubCurrentValue.Name = "lblSubCurrentValue";
            this.lblSubCurrentValue.Size = new System.Drawing.Size(48, 15);
            this.lblSubCurrentValue.TabIndex = 1000;
            this.lblSubCurrentValue.Text = "Số tiền:";
            // 
            // col_Id
            // 
            this.col_Id.DataPropertyName = "Id";
            this.col_Id.HeaderText = "Id";
            this.col_Id.Name = "col_Id";
            this.col_Id.ReadOnly = true;
            this.col_Id.Visible = false;
            // 
            // col_BienSo
            // 
            this.col_BienSo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_BienSo.DataPropertyName = "BienSo";
            this.col_BienSo.HeaderText = "Biển số xe";
            this.col_BienSo.Name = "col_BienSo";
            this.col_BienSo.ReadOnly = true;
            this.col_BienSo.Width = 150;
            // 
            // col_TenXe
            // 
            this.col_TenXe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_TenXe.DataPropertyName = "TenXe";
            this.col_TenXe.HeaderText = "Tên xe";
            this.col_TenXe.Name = "col_TenXe";
            this.col_TenXe.ReadOnly = true;
            this.col_TenXe.Width = 150;
            // 
            // col_Date
            // 
            this.col_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Date.DataPropertyName = "Date";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Format = "dd/MM/yyyy HH:mm:ss";
            this.col_Date.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_Date.HeaderText = "Ngày thực hiện";
            this.col_Date.Name = "col_Date";
            this.col_Date.ReadOnly = true;
            this.col_Date.Width = 140;
            // 
            // col_FK_Vihcle
            // 
            this.col_FK_Vihcle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_FK_Vihcle.DataPropertyName = "SoKM";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            this.col_FK_Vihcle.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_FK_Vihcle.HeaderText = "Số KM";
            this.col_FK_Vihcle.Name = "col_FK_Vihcle";
            this.col_FK_Vihcle.ReadOnly = true;
            // 
            // col_TotalFee
            // 
            this.col_TotalFee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_TotalFee.DataPropertyName = "TotalFee";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            this.col_TotalFee.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_TotalFee.HeaderText = "Tổng tiền";
            this.col_TotalFee.Name = "col_TotalFee";
            this.col_TotalFee.ReadOnly = true;
            // 
            // col_Note
            // 
            this.col_Note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Note.DataPropertyName = "Note";
            this.col_Note.HeaderText = "Ghi chú";
            this.col_Note.Name = "col_Note";
            this.col_Note.ReadOnly = true;
            // 
            // frmQuanLyBaoTriXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 738);
            this.Controls.Add(this.tabControl);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmQuanLyBaoTriXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyBaoTriXe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLyBaoTriXe_FormClosing);
            this.Load += new System.EventHandler(this.frmQuanLyBaoTriXe_Load);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tab01.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridParrent)).EndInit();
            this.menuParrent.ResumeLayout(false);
            this.tab02.ResumeLayout(false);
            this.tab02.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridChild)).EndInit();
            this.menuChild.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label lblFK_Vihcle;
		private System.Windows.Forms.ComboBox cmbFK_Vihcle;
		private System.Windows.Forms.Label lblTotalFee;
		private System.Windows.Forms.TextBox txtTotalKM;
		private System.Windows.Forms.Label lblNote;
		private System.Windows.Forms.TextBox txtNote;
		private System.Windows.Forms.Label lblSubFK_Service;
		private System.Windows.Forms.ComboBox cmbSubFK_Service;
		private System.Windows.Forms.Label lblSubCurrentValue;
		private System.Windows.Forms.TextBox txtSubCurrentValue;
		private DevComponents.DotNetBar.StyleManager styleManager;
		private System.Windows.Forms.Panel panelControl;
		private DevComponents.DotNetBar.ButtonX btnNew;
		private DevComponents.DotNetBar.ButtonX btnClose;
		private DevComponents.DotNetBar.ButtonX btnDelete;
		private DevComponents.DotNetBar.ButtonX btnPrint;
		private DevComponents.DotNetBar.ButtonX btnEdit;
		private DevComponents.DotNetBar.ButtonX btnSave;
		private DevComponents.DotNetBar.ButtonX btnRemove;
		private DevComponents.DotNetBar.ButtonX btnAdd;
		private DevComponents.DotNetBar.Validator.Highlighter highlighter;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tab01;
		private System.Windows.Forms.TabPage tab02;
		private DevComponents.DotNetBar.Controls.DataGridViewX gridParrent;
		private System.Windows.Forms.TextBox txtSearchForm;
		private DevComponents.DotNetBar.Controls.DataGridViewX gridChild;
		private System.Windows.Forms.ContextMenuStrip menuChild;
		private System.Windows.Forms.ToolStripMenuItem menuCopyChild;
		private System.Windows.Forms.ToolStripMenuItem menuPasteChild;
		private System.Windows.Forms.Panel panel1;
		private DevComponents.DotNetBar.ButtonX btnNewChild;
		private DevComponents.DotNetBar.ButtonX btnEditChild;
		private DevComponents.DotNetBar.ButtonX btnDeleteChild;
		private DevComponents.DotNetBar.ButtonX btnPrintChild;
		private DevComponents.DotNetBar.ButtonX btnClose2;
		private System.Windows.Forms.ContextMenuStrip menuParrent;
		private System.Windows.Forms.ToolStripMenuItem menuCopyParrent;
		private System.Windows.Forms.ToolStripMenuItem menuPasteParrent;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SubId;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SubFK_Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SubFK_VihcleCoupon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SubServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SubCurrentValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SubServiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SubValueCycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SubConfigNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BienSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_Vihcle;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TotalFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Note;
    }
}
