namespace LeMaiDesktop
{
	partial class frmQuanLyPickup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelcomtrol = new System.Windows.Forms.Panel();
            this.txtSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnPrint = new DevComponents.DotNetBar.ButtonX();
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
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtFilterKH = new System.Windows.Forms.TextBox();
            this.txtFilterShipper = new System.Windows.Forms.TextBox();
            this.lblFK_CustomerId = new System.Windows.Forms.Label();
            this.lblFK_ShipperId = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.timerFilterKH = new System.Windows.Forms.Timer(this.components);
            this.col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FK_CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FK_ShipperId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CustomerCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CustomerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ShipperName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ShipperPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FK_Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FK_Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenDaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NVGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_StatusReceiveName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FK_PickupShipper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PickupDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GoogleMap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelcomtrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panelcomtrol
            // 
            this.panelcomtrol.BackColor = System.Drawing.Color.SteelBlue;
            this.panelcomtrol.Controls.Add(this.txtSearch);
            this.panelcomtrol.Controls.Add(this.btnPrint);
            this.panelcomtrol.Controls.Add(this.btnNew);
            this.panelcomtrol.Controls.Add(this.btnSave);
            this.panelcomtrol.Controls.Add(this.btnEdit);
            this.panelcomtrol.Controls.Add(this.btnDelete);
            this.panelcomtrol.Controls.Add(this.btnClose);
            this.panelcomtrol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelcomtrol.Location = new System.Drawing.Point(0, 561);
            this.panelcomtrol.Name = "panelcomtrol";
            this.panelcomtrol.Size = new System.Drawing.Size(800, 39);
            this.panelcomtrol.TabIndex = 5;
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
            this.txtSearch.TabIndex = 6;
            this.txtSearch.WatermarkColor = System.Drawing.Color.Maroon;
            this.txtSearch.WatermarkFont = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.WatermarkText = "Tìm kiếm...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = global::LeMaiDesktop.Properties.Resources.iPrint;
            this.btnPrint.ImageTextSpacing = 3;
            this.btnPrint.Location = new System.Drawing.Point(619, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(82, 30);
            this.btnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "&In";
            this.btnPrint.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnNew
            // 
            this.btnNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = global::LeMaiDesktop.Properties.Resources.iNew;
            this.btnNew.ImageTextSpacing = 3;
            this.btnNew.Location = new System.Drawing.Point(304, 5);
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
            this.btnSave.Location = new System.Drawing.Point(463, 5);
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
            this.btnEdit.Location = new System.Drawing.Point(382, 5);
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
            this.btnDelete.Location = new System.Drawing.Point(539, 5);
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
            this.btnClose.Location = new System.Drawing.Point(702, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 30);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 5;
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
            this.lTieude.TabIndex = 8;
            this.lTieude.Text = "    Danh sách nhiệm vụ nhận hàng";
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
            this.col_FK_CustomerId,
            this.col_FK_ShipperId,
            this.col_CustomerCode,
            this.col_CustomerName,
            this.col_CustomerPhone,
            this.col_DiaChi,
            this.col_ShipperName,
            this.col_ShipperPhone,
            this.col_CreateDate,
            this.col_FK_Post,
            this.col_FK_Account,
            this.col_Note,
            this.col_TenDaiLy,
            this.col_NVGiao,
            this.col_StatusReceiveName,
            this.col_FK_PickupShipper,
            this.col_PickupDate,
            this.col_GoogleMap});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMain.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridMain.EnableHeadersVisualStyles = false;
            this.gridMain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.gridMain.HighlightSelectedColumnHeaders = false;
            this.gridMain.Location = new System.Drawing.Point(3, 33);
            this.gridMain.MultiSelect = false;
            this.gridMain.Name = "gridMain";
            this.gridMain.PaintEnhancedSelection = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridMain.RowHeadersVisible = false;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.gridMain.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gridMain.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridMain.RowTemplate.Height = 25;
            this.gridMain.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMain.Size = new System.Drawing.Size(797, 448);
            this.gridMain.TabIndex = 9;
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
            this.cmbFK_CustomerId.Location = new System.Drawing.Point(181, 498);
            this.cmbFK_CustomerId.Name = "cmbFK_CustomerId";
            this.cmbFK_CustomerId.Size = new System.Drawing.Size(243, 21);
            this.cmbFK_CustomerId.TabIndex = 1;
            // 
            // cmbFK_ShipperId
            // 
            this.cmbFK_ShipperId.FormattingEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.cmbFK_ShipperId, true);
            this.cmbFK_ShipperId.Location = new System.Drawing.Point(597, 498);
            this.cmbFK_ShipperId.Name = "cmbFK_ShipperId";
            this.cmbFK_ShipperId.Size = new System.Drawing.Size(188, 21);
            this.cmbFK_ShipperId.TabIndex = 3;
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNote.BackColor = System.Drawing.SystemColors.Window;
            this.txtNote.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtNote, true);
            this.txtNote.Location = new System.Drawing.Point(79, 530);
            this.txtNote.MaxLength = 500;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(709, 22);
            this.txtNote.TabIndex = 4;
            this.txtNote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNote_KeyPress);
            // 
            // txtFilterKH
            // 
            this.txtFilterKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFilterKH.BackColor = System.Drawing.SystemColors.Window;
            this.txtFilterKH.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtFilterKH, true);
            this.txtFilterKH.Location = new System.Drawing.Point(79, 497);
            this.txtFilterKH.MaxLength = 500;
            this.txtFilterKH.Name = "txtFilterKH";
            this.txtFilterKH.Size = new System.Drawing.Size(99, 22);
            this.txtFilterKH.TabIndex = 0;
            this.txtFilterKH.TextChanged += new System.EventHandler(this.txtFilterKH_TextChanged);
            // 
            // txtFilterShipper
            // 
            this.txtFilterShipper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFilterShipper.BackColor = System.Drawing.SystemColors.Window;
            this.txtFilterShipper.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtFilterShipper, true);
            this.txtFilterShipper.Location = new System.Drawing.Point(496, 497);
            this.txtFilterShipper.MaxLength = 500;
            this.txtFilterShipper.Name = "txtFilterShipper";
            this.txtFilterShipper.Size = new System.Drawing.Size(99, 22);
            this.txtFilterShipper.TabIndex = 2;
            this.txtFilterShipper.TextChanged += new System.EventHandler(this.txtFilterShipper_TextChanged);
            // 
            // lblFK_CustomerId
            // 
            this.lblFK_CustomerId.AutoSize = true;
            this.lblFK_CustomerId.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFK_CustomerId.ForeColor = System.Drawing.Color.Black;
            this.lblFK_CustomerId.Location = new System.Drawing.Point(6, 501);
            this.lblFK_CustomerId.Name = "lblFK_CustomerId";
            this.lblFK_CustomerId.Size = new System.Drawing.Size(75, 14);
            this.lblFK_CustomerId.TabIndex = 7;
            this.lblFK_CustomerId.Text = "Khách hàng:";
            // 
            // lblFK_ShipperId
            // 
            this.lblFK_ShipperId.AutoSize = true;
            this.lblFK_ShipperId.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFK_ShipperId.ForeColor = System.Drawing.Color.Black;
            this.lblFK_ShipperId.Location = new System.Drawing.Point(429, 501);
            this.lblFK_ShipperId.Name = "lblFK_ShipperId";
            this.lblFK_ShipperId.Size = new System.Drawing.Size(65, 14);
            this.lblFK_ShipperId.TabIndex = 1000;
            this.lblFK_ShipperId.Text = "Nhân viên:";
            // 
            // lblNote
            // 
            this.lblNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNote.AutoSize = true;
            this.lblNote.ForeColor = System.Drawing.Color.Black;
            this.lblNote.Location = new System.Drawing.Point(35, 535);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(46, 13);
            this.lblNote.TabIndex = 6;
            this.lblNote.Text = "Ghi chú:";
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // timerFilterKH
            // 
            this.timerFilterKH.Interval = 500;
            this.timerFilterKH.Tick += new System.EventHandler(this.timerFilterKH_Tick);
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
            // col_CustomerCode
            // 
            this.col_CustomerCode.DataPropertyName = "CustomerCode";
            this.col_CustomerCode.HeaderText = "Mã KH";
            this.col_CustomerCode.Name = "col_CustomerCode";
            this.col_CustomerCode.ReadOnly = true;
            // 
            // col_CustomerName
            // 
            this.col_CustomerName.DataPropertyName = "CustomerName";
            this.col_CustomerName.HeaderText = "Khách hàng";
            this.col_CustomerName.Name = "col_CustomerName";
            this.col_CustomerName.ReadOnly = true;
            // 
            // col_CustomerPhone
            // 
            this.col_CustomerPhone.DataPropertyName = "CustomerPhone";
            this.col_CustomerPhone.HeaderText = "Số ĐT KH";
            this.col_CustomerPhone.Name = "col_CustomerPhone";
            this.col_CustomerPhone.ReadOnly = true;
            // 
            // col_DiaChi
            // 
            this.col_DiaChi.DataPropertyName = "DiaChi";
            this.col_DiaChi.HeaderText = "Địa chỉ KH";
            this.col_DiaChi.Name = "col_DiaChi";
            this.col_DiaChi.ReadOnly = true;
            // 
            // col_ShipperName
            // 
            this.col_ShipperName.DataPropertyName = "ShipperName";
            this.col_ShipperName.HeaderText = "Nhân viên";
            this.col_ShipperName.Name = "col_ShipperName";
            this.col_ShipperName.ReadOnly = true;
            // 
            // col_ShipperPhone
            // 
            this.col_ShipperPhone.DataPropertyName = "ShipperPhone";
            this.col_ShipperPhone.HeaderText = "Số ĐT NV";
            this.col_ShipperPhone.Name = "col_ShipperPhone";
            this.col_ShipperPhone.ReadOnly = true;
            // 
            // col_CreateDate
            // 
            this.col_CreateDate.DataPropertyName = "CreateDate";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "dd/MM HH:mm";
            this.col_CreateDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_CreateDate.HeaderText = "Ngày tạo";
            this.col_CreateDate.Name = "col_CreateDate";
            this.col_CreateDate.ReadOnly = true;
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
            // col_Note
            // 
            this.col_Note.DataPropertyName = "Note";
            this.col_Note.HeaderText = "Ghi chú";
            this.col_Note.Name = "col_Note";
            this.col_Note.ReadOnly = true;
            // 
            // col_TenDaiLy
            // 
            this.col_TenDaiLy.DataPropertyName = "TenDaiLy";
            this.col_TenDaiLy.HeaderText = "TenDaiLy";
            this.col_TenDaiLy.Name = "col_TenDaiLy";
            this.col_TenDaiLy.ReadOnly = true;
            this.col_TenDaiLy.Visible = false;
            // 
            // col_NVGiao
            // 
            this.col_NVGiao.DataPropertyName = "NVGiao";
            this.col_NVGiao.HeaderText = "NVGiao";
            this.col_NVGiao.Name = "col_NVGiao";
            this.col_NVGiao.ReadOnly = true;
            // 
            // col_StatusReceiveName
            // 
            this.col_StatusReceiveName.DataPropertyName = "StatusReceiveName";
            this.col_StatusReceiveName.HeaderText = "Tình trạng";
            this.col_StatusReceiveName.Name = "col_StatusReceiveName";
            this.col_StatusReceiveName.ReadOnly = true;
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
            this.col_PickupDate.DataPropertyName = "PickupDate";
            this.col_PickupDate.HeaderText = "PickupDate";
            this.col_PickupDate.Name = "col_PickupDate";
            this.col_PickupDate.ReadOnly = true;
            this.col_PickupDate.Visible = false;
            // 
            // col_GoogleMap
            // 
            this.col_GoogleMap.DataPropertyName = "GoogleMap";
            this.col_GoogleMap.HeaderText = "Google Map";
            this.col_GoogleMap.Name = "col_GoogleMap";
            this.col_GoogleMap.ReadOnly = true;
            this.col_GoogleMap.Visible = false;
            // 
            // frmQuanLyPickup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.txtFilterShipper);
            this.Controls.Add(this.txtFilterKH);
            this.Controls.Add(this.gridMain);
            this.Controls.Add(this.panelcomtrol);
            this.Controls.Add(this.lTieude);
            this.Controls.Add(this.cmbFK_CustomerId);
            this.Controls.Add(this.cmbFK_ShipperId);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.lblFK_CustomerId);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblFK_ShipperId);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuanLyPickup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhiệm vụ nhận hàng";
            this.Load += new System.EventHandler(this.frmQuanLyPickup_Load);
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
		private DevComponents.DotNetBar.ButtonX btnPrint;
		private DevComponents.DotNetBar.Controls.DataGridViewX gridMain;
		private DevComponents.DotNetBar.Controls.TextBoxX txtSearch;
		private DevComponents.DotNetBar.Validator.Highlighter highlighter;
		private System.Windows.Forms.Label lblFK_CustomerId;
		private System.Windows.Forms.ComboBox cmbFK_CustomerId;
		private System.Windows.Forms.Label lblFK_ShipperId;
		private System.Windows.Forms.ComboBox cmbFK_ShipperId;
		private System.Windows.Forms.Label lblNote;
		private System.Windows.Forms.TextBox txtNote;
        private DevComponents.DotNetBar.StyleManager styleManager;
        private System.Windows.Forms.TextBox txtFilterShipper;
        private System.Windows.Forms.TextBox txtFilterKH;
        private System.Windows.Forms.Timer timerFilterKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_ShipperId;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CustomerCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CustomerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ShipperName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ShipperPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_Post;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NVGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_StatusReceiveName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_PickupShipper;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PickupDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GoogleMap;
    }
}
