namespace LeMaiDesktop
{
	partial class frmQuanLyNapTienShipper
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyleInteger = new System.Windows.Forms.DataGridViewCellStyle();
			dataGridViewCellStyleInteger.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyleInteger.Format = "N0";
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyleDecimal = new System.Windows.Forms.DataGridViewCellStyle();
			dataGridViewCellStyleDecimal.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyleDecimal.Format = "N2";
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyleDateTime = new System.Windows.Forms.DataGridViewCellStyle();
			dataGridViewCellStyleDateTime.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyleDateTime.Format = "dd/MM/yyyy HH:mm:ss";
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyleString = new System.Windows.Forms.DataGridViewCellStyle();
			dataGridViewCellStyleDateTime.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyleBoolean = new System.Windows.Forms.DataGridViewCellStyle();
			dataGridViewCellStyleBoolean.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
			this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
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
			this.col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_FK_Shipper = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_FK_Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_TotalCash = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_FK_Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_ShipperName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_ShipperPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.menuParrent = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuCopyParrent = new System.Windows.Forms.ToolStripMenuItem();
			this.menuPasteParrent = new System.Windows.Forms.ToolStripMenuItem();
			this.tab02 = new System.Windows.Forms.TabPage();
			this.lblFK_Shipper = new System.Windows.Forms.Label();
			this.cmbFK_Shipper = new System.Windows.Forms.ComboBox();
			this.lblTotalCash = new System.Windows.Forms.Label();
			this.txtTotalCash = new System.Windows.Forms.TextBox();
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
			this.lblSubId = new System.Windows.Forms.Label();
			this.txtSubId = new System.Windows.Forms.TextBox();
			this.lblSubBillCode = new System.Windows.Forms.Label();
			this.txtSubBillCode = new System.Windows.Forms.TextBox();
			this.lblSubMoneyValue = new System.Windows.Forms.Label();
			this.txtSubMoneyValue = new System.Windows.Forms.TextBox();
			this.lblSubFreight = new System.Windows.Forms.Label();
			this.txtSubFreight = new System.Windows.Forms.TextBox();
			this.lblSubCOD = new System.Windows.Forms.Label();
			this.txtSubCOD = new System.Windows.Forms.TextBox();
			this.lblSubPayMentType = new System.Windows.Forms.Label();
			this.txtSubPayMentType = new System.Windows.Forms.TextBox();
			this.col_SubId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_SubBillCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_SubMoneyValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_SubFreight = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_SubCOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_SubPayMentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_SubFK_CashShipper = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_SubSendMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_SubAcceptMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_SubSendManPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_SubAcceptManPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_SubAcceptManAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.menuChild = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuCopyChild = new System.Windows.Forms.ToolStripMenuItem();
			this.menuPasteChild = new System.Windows.Forms.ToolStripMenuItem();
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
			this.panelControl.Location = new System.Drawing.Point(3, 540);
			this.panelControl.Name = "panelControl";
			this.panelControl.Size = new System.Drawing.Size(994, 39);
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
			this.btnNew.Location = new System.Drawing.Point(540, 4);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(73, 30);
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
			this.txtSearchForm.Location = new System.Drawing.Point(5, 10);
			this.txtSearchForm.Name = "txtSearchForm";
			this.txtSearchForm.Size = new System.Drawing.Size(276, 21);
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
			this.btnClose.Location = new System.Drawing.Point(901, 4);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(88, 30);
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
			this.btnDelete.Location = new System.Drawing.Point(714, 4);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(88, 30);
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
			this.btnPrint.Location = new System.Drawing.Point(807, 4);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(88, 30);
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
			this.btnEdit.Location = new System.Drawing.Point(619, 4);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(88, 30);
			this.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnEdit.TabIndex = 1274;
			this.btnEdit.Text = "&Edit";
			this.btnEdit.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// highlighter
			// 
			this.highlighter.ContainerControl = this;
			// 
			// 
			// lblFK_Shipper
			// 
			this.lblFK_Shipper.AutoSize = true;
			this.lblFK_Shipper.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFK_Shipper.ForeColor = System.Drawing.Color.Black;
			this.lblFK_Shipper.Location = new System.Drawing.Point(164, 45);
			this.lblFK_Shipper.Name = "lblFK_Shipper";
			this.lblFK_Shipper.Size = new System.Drawing.Size(50, 14);
			this.lblFK_Shipper.TabIndex = 1000;
			this.lblFK_Shipper.Text = "FK_Shipper:";
			// 
			// cmbFK_Shipper
			// 
			this.cmbFK_Shipper.FormattingEnabled = true;
			this.cmbFK_Shipper.Location = new System.Drawing.Point(227, 45);
			this.cmbFK_Shipper.Name = "cmbFK_Shipper";
			this.cmbFK_Shipper.Size = new System.Drawing.Size(100, 21);
			this.cmbFK_Shipper.TabIndex = 2;
			this.highlighter.SetHighlightOnFocus(this.cmbFK_Shipper, true);
			// 
			// lblTotalCash
			// 
			this.lblTotalCash.AutoSize = true;
			this.lblTotalCash.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalCash.ForeColor = System.Drawing.Color.Black;
			this.lblTotalCash.Location = new System.Drawing.Point(8, 75);
			this.lblTotalCash.Name = "lblTotalCash";
			this.lblTotalCash.Size = new System.Drawing.Size(50, 14);
			this.lblTotalCash.TabIndex = 1000;
			this.lblTotalCash.Text = "TotalCash:";
			// 
			// txtTotalCash
			// 
			this.txtTotalCash.BackColor = System.Drawing.SystemColors.Window;
			this.txtTotalCash.Location = new System.Drawing.Point(75, 75);
			this.txtTotalCash.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.highlighter.SetHighlightOnFocus(this.txtTotalCash, true);
			this.txtTotalCash.Name = "txtTotalCash";
			this.txtTotalCash.Size = new System.Drawing.Size(100, 21);
			this.txtTotalCash.TabIndex = 5;
			this.txtTotalCash.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTotalCash_KeyUp);
			this.txtTotalCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalCash_KeyPress);
			// 
			// lblSubId
			// 
			this.lblSubId.AutoSize = true;
			this.lblSubId.ForeColor = System.Drawing.Color.Black;
			this.lblSubId.Location = new System.Drawing.Point(8, 328);
			this.lblSubId.Name = "lblSubId";
			this.lblSubId.Size = new System.Drawing.Size(50, 14);
			this.lblSubId.TabIndex = 1000;
			this.lblSubId.Text = "Id:";
			// 
			// txtSubId
			// 
			this.txtSubId.BackColor = System.Drawing.SystemColors.Window;
			this.txtSubId.Location = new System.Drawing.Point(75, 328);
			this.txtSubId.Name = "txtSubId";
			this.txtSubId.Size = new System.Drawing.Size(100, 21);
			this.txtSubId.TabIndex = 7;
			this.txtSubId.MaxLength = 50;
			this.txtSubId.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.highlighter.SetHighlightOnFocus(this.txtSubId, true);
			this.txtSubId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubId_KeyPress);
			// 
			// lblSubBillCode
			// 
			this.lblSubBillCode.AutoSize = true;
			this.lblSubBillCode.ForeColor = System.Drawing.Color.Black;
			this.lblSubBillCode.Location = new System.Drawing.Point(164, 328);
			this.lblSubBillCode.Name = "lblSubBillCode";
			this.lblSubBillCode.Size = new System.Drawing.Size(50, 14);
			this.lblSubBillCode.TabIndex = 1000;
			this.lblSubBillCode.Text = "BillCode:";
			// 
			// txtSubBillCode
			// 
			this.txtSubBillCode.BackColor = System.Drawing.SystemColors.Window;
			this.txtSubBillCode.Location = new System.Drawing.Point(227, 328);
			this.txtSubBillCode.Name = "txtSubBillCode";
			this.txtSubBillCode.Size = new System.Drawing.Size(100, 21);
			this.txtSubBillCode.TabIndex = 8;
			this.txtSubBillCode.MaxLength = 50;
			this.txtSubBillCode.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.highlighter.SetHighlightOnFocus(this.txtSubBillCode, true);
			this.txtSubBillCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubBillCode_KeyPress);
			// 
			// lblSubMoneyValue
			// 
			this.lblSubMoneyValue.AutoSize = true;
			this.lblSubMoneyValue.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubMoneyValue.ForeColor = System.Drawing.Color.Black;
			this.lblSubMoneyValue.Location = new System.Drawing.Point(349, 328);
			this.lblSubMoneyValue.Name = "lblSubMoneyValue";
			this.lblSubMoneyValue.Size = new System.Drawing.Size(50, 14);
			this.lblSubMoneyValue.TabIndex = 1000;
			this.lblSubMoneyValue.Text = "MoneyValue:";
			// 
			// txtSubMoneyValue
			// 
			this.txtSubMoneyValue.BackColor = System.Drawing.SystemColors.Window;
			this.txtSubMoneyValue.Location = new System.Drawing.Point(428, 328);
			this.txtSubMoneyValue.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.highlighter.SetHighlightOnFocus(this.txtSubMoneyValue, true);
			this.txtSubMoneyValue.Name = "txtSubMoneyValue";
			this.txtSubMoneyValue.Size = new System.Drawing.Size(100, 21);
			this.txtSubMoneyValue.TabIndex = 9;
			this.txtSubMoneyValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSubMoneyValue_KeyUp);
			this.txtSubMoneyValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubMoneyValue_KeyPress);
			// 
			// lblSubFreight
			// 
			this.lblSubFreight.AutoSize = true;
			this.lblSubFreight.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubFreight.ForeColor = System.Drawing.Color.Black;
			this.lblSubFreight.Location = new System.Drawing.Point(558, 328);
			this.lblSubFreight.Name = "lblSubFreight";
			this.lblSubFreight.Size = new System.Drawing.Size(50, 14);
			this.lblSubFreight.TabIndex = 1000;
			this.lblSubFreight.Text = "Freight:";
			// 
			// txtSubFreight
			// 
			this.txtSubFreight.BackColor = System.Drawing.SystemColors.Window;
			this.txtSubFreight.Location = new System.Drawing.Point(601, 328);
			this.txtSubFreight.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.highlighter.SetHighlightOnFocus(this.txtSubFreight, true);
			this.txtSubFreight.Name = "txtSubFreight";
			this.txtSubFreight.Size = new System.Drawing.Size(100, 21);
			this.txtSubFreight.TabIndex = 10;
			this.txtSubFreight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSubFreight_KeyUp);
			this.txtSubFreight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubFreight_KeyPress);
			// 
			// lblSubCOD
			// 
			this.lblSubCOD.AutoSize = true;
			this.lblSubCOD.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubCOD.ForeColor = System.Drawing.Color.Black;
			this.lblSubCOD.Location = new System.Drawing.Point(8, 358);
			this.lblSubCOD.Name = "lblSubCOD";
			this.lblSubCOD.Size = new System.Drawing.Size(50, 14);
			this.lblSubCOD.TabIndex = 1000;
			this.lblSubCOD.Text = "COD:";
			// 
			// txtSubCOD
			// 
			this.txtSubCOD.BackColor = System.Drawing.SystemColors.Window;
			this.txtSubCOD.Location = new System.Drawing.Point(75, 358);
			this.txtSubCOD.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.highlighter.SetHighlightOnFocus(this.txtSubCOD, true);
			this.txtSubCOD.Name = "txtSubCOD";
			this.txtSubCOD.Size = new System.Drawing.Size(100, 21);
			this.txtSubCOD.TabIndex = 11;
			this.txtSubCOD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSubCOD_KeyUp);
			this.txtSubCOD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubCOD_KeyPress);
			// 
			// lblSubPayMentType
			// 
			this.lblSubPayMentType.AutoSize = true;
			this.lblSubPayMentType.ForeColor = System.Drawing.Color.Black;
			this.lblSubPayMentType.Location = new System.Drawing.Point(164, 358);
			this.lblSubPayMentType.Name = "lblSubPayMentType";
			this.lblSubPayMentType.Size = new System.Drawing.Size(50, 14);
			this.lblSubPayMentType.TabIndex = 1000;
			this.lblSubPayMentType.Text = "PayMentType:";
			// 
			// txtSubPayMentType
			// 
			this.txtSubPayMentType.BackColor = System.Drawing.SystemColors.Window;
			this.txtSubPayMentType.Location = new System.Drawing.Point(227, 358);
			this.txtSubPayMentType.Name = "txtSubPayMentType";
			this.txtSubPayMentType.Size = new System.Drawing.Size(100, 21);
			this.txtSubPayMentType.TabIndex = 12;
			this.txtSubPayMentType.MaxLength = 50;
			this.txtSubPayMentType.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.highlighter.SetHighlightOnFocus(this.txtSubPayMentType, true);
			this.txtSubPayMentType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubPayMentType_KeyPress);
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tab01);
			this.tabControl.Controls.Add(this.tab02);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(1008, 608);
			this.tabControl.TabIndex = 0;
			// 
			// tab01
			// 
			this.tab01.Controls.Add(this.panelControl);
			this.tab01.Controls.Add(this.gridParrent);
			this.tab01.Location = new System.Drawing.Point(4, 22);
			this.tab01.Name = "tab01";
			this.tab01.Padding = new System.Windows.Forms.Padding(3);
			this.tab01.Size = new System.Drawing.Size(1000, 582);
			this.tab01.TabIndex = 0;
			this.tab01.Text = "Parrent Tab";
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
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridParrent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.gridParrent.ColumnHeadersHeight = 25;
			this.gridParrent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.col_Id,
			this.col_FK_Shipper,
			this.col_CreateDate,
			this.col_FK_Account,
			this.col_TotalCash,
			this.col_FK_Post,
			this.col_ShipperName,
			this.col_ShipperPhone,
			this.col_FullName});
			this.gridParrent.ContextMenuStrip = this.menuParrent;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridParrent.DefaultCellStyle = dataGridViewCellStyle6;
			this.gridParrent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridParrent.EnableHeadersVisualStyles = false;
			this.gridParrent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.gridParrent.HighlightSelectedColumnHeaders = false;
			this.gridParrent.Location = new System.Drawing.Point(3, 3);
			this.gridParrent.MultiSelect = false;
			this.gridParrent.Name = "gridParrent";
			this.gridParrent.PaintEnhancedSelection = false;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.gridParrent.Size = new System.Drawing.Size(994, 576);
			this.gridParrent.TabIndex = 0;
			this.gridParrent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridParrent_CellDoubleClick);
			// 
			// col_Id
			// 
			this.col_Id.DataPropertyName = "Id";
			this.col_Id.HeaderText = "Id";
			this.col_Id.Name = "col_Id";
			this.col_Id.ReadOnly = true;
			this.col_Id.Width = 100;
			this.col_Id.DefaultCellStyle = dataGridViewCellStyleString;
			// 
			// col_FK_Shipper
			// 
			this.col_FK_Shipper.DataPropertyName = "FK_Shipper";
			this.col_FK_Shipper.HeaderText = "FK_Shipper";
			this.col_FK_Shipper.Name = "col_FK_Shipper";
			this.col_FK_Shipper.ReadOnly = true;
			this.col_FK_Shipper.Width = 100;
			this.col_FK_Shipper.DefaultCellStyle = dataGridViewCellStyleString;
			// 
			// col_CreateDate
			// 
			this.col_CreateDate.DataPropertyName = "CreateDate";
			this.col_CreateDate.HeaderText = "CreateDate";
			this.col_CreateDate.Name = "col_CreateDate";
			this.col_CreateDate.ReadOnly = true;
			this.col_CreateDate.Width = 100;
			this.col_CreateDate.DefaultCellStyle = dataGridViewCellStyleDateTime;
			// 
			// col_FK_Account
			// 
			this.col_FK_Account.DataPropertyName = "FK_Account";
			this.col_FK_Account.HeaderText = "FK_Account";
			this.col_FK_Account.Name = "col_FK_Account";
			this.col_FK_Account.ReadOnly = true;
			this.col_FK_Account.Width = 100;
			this.col_FK_Account.DefaultCellStyle = dataGridViewCellStyleString;
			// 
			// col_TotalCash
			// 
			this.col_TotalCash.DataPropertyName = "TotalCash";
			this.col_TotalCash.HeaderText = "TotalCash";
			this.col_TotalCash.Name = "col_TotalCash";
			this.col_TotalCash.ReadOnly = true;
			this.col_TotalCash.Width = 100;
			this.col_TotalCash.DefaultCellStyle = dataGridViewCellStyleDecimal;
			// 
			// col_FK_Post
			// 
			this.col_FK_Post.DataPropertyName = "FK_Post";
			this.col_FK_Post.HeaderText = "FK_Post";
			this.col_FK_Post.Name = "col_FK_Post";
			this.col_FK_Post.ReadOnly = true;
			this.col_FK_Post.Width = 100;
			this.col_FK_Post.DefaultCellStyle = dataGridViewCellStyleString;
			// 
			// col_ShipperName
			// 
			this.col_ShipperName.DataPropertyName = "ShipperName";
			this.col_ShipperName.HeaderText = "ShipperName";
			this.col_ShipperName.Name = "col_ShipperName";
			this.col_ShipperName.ReadOnly = true;
			this.col_ShipperName.Width = 100;
			this.col_ShipperName.DefaultCellStyle = dataGridViewCellStyleString;
			// 
			// col_ShipperPhone
			// 
			this.col_ShipperPhone.DataPropertyName = "ShipperPhone";
			this.col_ShipperPhone.HeaderText = "ShipperPhone";
			this.col_ShipperPhone.Name = "col_ShipperPhone";
			this.col_ShipperPhone.ReadOnly = true;
			this.col_ShipperPhone.Width = 100;
			this.col_ShipperPhone.DefaultCellStyle = dataGridViewCellStyleString;
			// 
			// col_FullName
			// 
			this.col_FullName.DataPropertyName = "FullName";
			this.col_FullName.HeaderText = "FullName";
			this.col_FullName.Name = "col_FullName";
			this.col_FullName.ReadOnly = true;
			this.col_FullName.Width = 100;
			this.col_FullName.DefaultCellStyle = dataGridViewCellStyleString;
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
			this.tab02.Controls.Add(this.lblFK_Shipper);
			this.tab02.Controls.Add(this.cmbFK_Shipper);
			this.tab02.Controls.Add(this.lblTotalCash);
			this.tab02.Controls.Add(this.txtTotalCash);
			this.tab02.Controls.Add(this.lblSubId);
			this.tab02.Controls.Add(this.txtSubId);
			this.tab02.Controls.Add(this.lblSubBillCode);
			this.tab02.Controls.Add(this.txtSubBillCode);
			this.tab02.Controls.Add(this.lblSubMoneyValue);
			this.tab02.Controls.Add(this.txtSubMoneyValue);
			this.tab02.Controls.Add(this.lblSubFreight);
			this.tab02.Controls.Add(this.txtSubFreight);
			this.tab02.Controls.Add(this.lblSubCOD);
			this.tab02.Controls.Add(this.txtSubCOD);
			this.tab02.Controls.Add(this.lblSubPayMentType);
			this.tab02.Controls.Add(this.txtSubPayMentType);
			this.tab02.Location = new System.Drawing.Point(4, 22);
			this.tab02.Name = "tab02";
			this.tab02.Padding = new System.Windows.Forms.Padding(3);
			this.tab02.Size = new System.Drawing.Size(1000, 582);
			this.tab02.TabIndex = 1;
			this.tab02.Text = "Detail";
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
			this.panel1.Location = new System.Drawing.Point(3, 540);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(994, 39);
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
			this.btnNewChild.Location = new System.Drawing.Point(260, 4);
			this.btnNewChild.Name = "btnNewChild";
			this.btnNewChild.Size = new System.Drawing.Size(73, 30);
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
			this.btnEditChild.Location = new System.Drawing.Point(624, 4);
			this.btnEditChild.Name = "btnEditChild";
			this.btnEditChild.Size = new System.Drawing.Size(88, 30);
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
			this.btnDeleteChild.Location = new System.Drawing.Point(716, 4);
			this.btnDeleteChild.Name = "btnDeleteChild";
			this.btnDeleteChild.Size = new System.Drawing.Size(88, 30);
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
			this.btnPrintChild.Location = new System.Drawing.Point(810, 4);
			this.btnPrintChild.Name = "btnPrintChild";
			this.btnPrintChild.Size = new System.Drawing.Size(88, 30);
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
			this.btnClose2.Location = new System.Drawing.Point(902, 4);
			this.btnClose2.Name = "btnClose2";
			this.btnClose2.Size = new System.Drawing.Size(88, 30);
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
			this.btnSave.Location = new System.Drawing.Point(530, 4);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(88, 30);
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
			this.btnAdd.Location = new System.Drawing.Point(338, 4);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(94, 30);
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
			this.btnRemove.Location = new System.Drawing.Point(438, 4);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(88, 30);
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
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridChild.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
			this.gridChild.ColumnHeadersHeight = 25;
			this.gridChild.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.col_SubId,
			this.col_SubBillCode,
			this.col_SubMoneyValue,
			this.col_SubFreight,
			this.col_SubCOD,
			this.col_SubPayMentType,
			this.col_SubFK_CashShipper,
			this.col_SubSendMan,
			this.col_SubAcceptMan,
			this.col_SubSendManPhone,
			this.col_SubAcceptManPhone,
			this.col_SubAcceptManAddress});
			this.gridChild.ContextMenuStrip = this.menuChild;
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridChild.DefaultCellStyle = dataGridViewCellStyle17;
			this.gridChild.EnableHeadersVisualStyles = false;
			this.gridChild.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.gridChild.HighlightSelectedColumnHeaders = false;
			this.gridChild.Location = new System.Drawing.Point(47, 172);
			this.gridChild.MultiSelect = false;
			this.gridChild.Name = "gridChild";
			this.gridChild.PaintEnhancedSelection = false;
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle18.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridChild.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
			this.gridChild.RowHeadersVisible = false;
			this.gridChild.RowHeadersWidth = 51;
			dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
			dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
			this.gridChild.RowsDefaultCellStyle = dataGridViewCellStyle19;
			this.gridChild.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridChild.RowTemplate.Height = 25;
			this.gridChild.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.gridChild.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridChild.Size = new System.Drawing.Size(898, 136);
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
			this.col_SubId.Width = 100;
			this.col_SubId.DefaultCellStyle = dataGridViewCellStyleString;
			// 
			// col_SubBillCode
			// 
			this.col_SubBillCode.DataPropertyName = "BillCode";
			this.col_SubBillCode.HeaderText = "BillCode";
			this.col_SubBillCode.Name = "col_SubBillCode";
			this.col_SubBillCode.ReadOnly = true;
			this.col_SubBillCode.Width = 100;
			this.col_SubBillCode.DefaultCellStyle = dataGridViewCellStyleString;
			// 
			// col_SubMoneyValue
			// 
			this.col_SubMoneyValue.DataPropertyName = "MoneyValue";
			this.col_SubMoneyValue.HeaderText = "MoneyValue";
			this.col_SubMoneyValue.Name = "col_SubMoneyValue";
			this.col_SubMoneyValue.ReadOnly = true;
			this.col_SubMoneyValue.Width = 100;
			this.col_SubMoneyValue.DefaultCellStyle = dataGridViewCellStyleDecimal;
			// 
			// col_SubFreight
			// 
			this.col_SubFreight.DataPropertyName = "Freight";
			this.col_SubFreight.HeaderText = "Freight";
			this.col_SubFreight.Name = "col_SubFreight";
			this.col_SubFreight.ReadOnly = true;
			this.col_SubFreight.Width = 100;
			this.col_SubFreight.DefaultCellStyle = dataGridViewCellStyleDecimal;
			// 
			// col_SubCOD
			// 
			this.col_SubCOD.DataPropertyName = "COD";
			this.col_SubCOD.HeaderText = "COD";
			this.col_SubCOD.Name = "col_SubCOD";
			this.col_SubCOD.ReadOnly = true;
			this.col_SubCOD.Width = 100;
			this.col_SubCOD.DefaultCellStyle = dataGridViewCellStyleDecimal;
			// 
			// col_SubPayMentType
			// 
			this.col_SubPayMentType.DataPropertyName = "PayMentType";
			this.col_SubPayMentType.HeaderText = "PayMentType";
			this.col_SubPayMentType.Name = "col_SubPayMentType";
			this.col_SubPayMentType.ReadOnly = true;
			this.col_SubPayMentType.Width = 100;
			this.col_SubPayMentType.DefaultCellStyle = dataGridViewCellStyleString;
			// 
			// col_SubFK_CashShipper
			// 
			this.col_SubFK_CashShipper.DataPropertyName = "FK_CashShipper";
			this.col_SubFK_CashShipper.HeaderText = "FK_CashShipper";
			this.col_SubFK_CashShipper.Name = "col_SubFK_CashShipper";
			this.col_SubFK_CashShipper.ReadOnly = true;
			this.col_SubFK_CashShipper.Width = 100;
			this.col_SubFK_CashShipper.DefaultCellStyle = dataGridViewCellStyleString;
			// 
			// col_SubSendMan
			// 
			this.col_SubSendMan.DataPropertyName = "SendMan";
			this.col_SubSendMan.HeaderText = "SendMan";
			this.col_SubSendMan.Name = "col_SubSendMan";
			this.col_SubSendMan.ReadOnly = true;
			this.col_SubSendMan.Width = 100;
			this.col_SubSendMan.DefaultCellStyle = dataGridViewCellStyleString;
			// 
			// col_SubAcceptMan
			// 
			this.col_SubAcceptMan.DataPropertyName = "AcceptMan";
			this.col_SubAcceptMan.HeaderText = "AcceptMan";
			this.col_SubAcceptMan.Name = "col_SubAcceptMan";
			this.col_SubAcceptMan.ReadOnly = true;
			this.col_SubAcceptMan.Width = 100;
			this.col_SubAcceptMan.DefaultCellStyle = dataGridViewCellStyleString;
			// 
			// col_SubSendManPhone
			// 
			this.col_SubSendManPhone.DataPropertyName = "SendManPhone";
			this.col_SubSendManPhone.HeaderText = "SendManPhone";
			this.col_SubSendManPhone.Name = "col_SubSendManPhone";
			this.col_SubSendManPhone.ReadOnly = true;
			this.col_SubSendManPhone.Width = 100;
			this.col_SubSendManPhone.DefaultCellStyle = dataGridViewCellStyleString;
			// 
			// col_SubAcceptManPhone
			// 
			this.col_SubAcceptManPhone.DataPropertyName = "AcceptManPhone";
			this.col_SubAcceptManPhone.HeaderText = "AcceptManPhone";
			this.col_SubAcceptManPhone.Name = "col_SubAcceptManPhone";
			this.col_SubAcceptManPhone.ReadOnly = true;
			this.col_SubAcceptManPhone.Width = 100;
			this.col_SubAcceptManPhone.DefaultCellStyle = dataGridViewCellStyleString;
			// 
			// col_SubAcceptManAddress
			// 
			this.col_SubAcceptManAddress.DataPropertyName = "AcceptManAddress";
			this.col_SubAcceptManAddress.HeaderText = "AcceptManAddress";
			this.col_SubAcceptManAddress.Name = "col_SubAcceptManAddress";
			this.col_SubAcceptManAddress.ReadOnly = true;
			this.col_SubAcceptManAddress.Width = 100;
			this.col_SubAcceptManAddress.DefaultCellStyle = dataGridViewCellStyleString;
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
			// frmQuanLyNapTienShipper
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 608);
			this.Controls.Add(this.tabControl);
			this.DoubleBuffered = true;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmQuanLyNapTienShipper";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "QuanLyNapTienShipper";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLyNapTienShipper_FormClosing);
			this.Load += new System.EventHandler(this.frmQuanLyNapTienShipper_Load);
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
		private System.Windows.Forms.Label lblFK_Shipper;
		private System.Windows.Forms.ComboBox cmbFK_Shipper;
		private System.Windows.Forms.Label lblTotalCash;
		private System.Windows.Forms.TextBox txtTotalCash;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_Shipper;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_CreateDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_Account;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_TotalCash;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_Post;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_ShipperName;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_ShipperPhone;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_FullName;
		private System.Windows.Forms.Label lblSubId;
		private System.Windows.Forms.TextBox txtSubId;
		private System.Windows.Forms.Label lblSubBillCode;
		private System.Windows.Forms.TextBox txtSubBillCode;
		private System.Windows.Forms.Label lblSubMoneyValue;
		private System.Windows.Forms.TextBox txtSubMoneyValue;
		private System.Windows.Forms.Label lblSubFreight;
		private System.Windows.Forms.TextBox txtSubFreight;
		private System.Windows.Forms.Label lblSubCOD;
		private System.Windows.Forms.TextBox txtSubCOD;
		private System.Windows.Forms.Label lblSubPayMentType;
		private System.Windows.Forms.TextBox txtSubPayMentType;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_SubId;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_SubBillCode;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_SubMoneyValue;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_SubFreight;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_SubCOD;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_SubPayMentType;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_SubFK_CashShipper;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_SubSendMan;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_SubAcceptMan;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_SubSendManPhone;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_SubAcceptManPhone;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_SubAcceptManAddress;
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
	}
}
