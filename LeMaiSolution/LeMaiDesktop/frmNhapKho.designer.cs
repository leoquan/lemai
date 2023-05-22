namespace LeMaiDesktop
{
	partial class frmNhapKho
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.cmbFK_SanPham = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.cmbSubFK_VatTu = new System.Windows.Forms.ComboBox();
            this.txtSubSoLuong = new System.Windows.Forms.TextBox();
            this.txtSubDonGia = new System.Windows.Forms.TextBox();
            this.txtSubThanhTien = new System.Windows.Forms.TextBox();
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
            this.col_NgayNhapKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FK_NguoiNhapKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FK_SanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.col_SubFK_NhapKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SubFK_VatTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SubTenVatTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SubDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SubSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SubDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SubThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuChild = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuCopyChild = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPasteChild = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFK_SanPham = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblSubFK_VatTu = new System.Windows.Forms.Label();
            this.lblSubSoLuong = new System.Windows.Forms.Label();
            this.lblSubDonGia = new System.Windows.Forms.Label();
            this.lblSubThanhTien = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.btnNhapVatTu = new DevComponents.DotNetBar.ButtonX();
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
            // cmbFK_SanPham
            // 
            this.cmbFK_SanPham.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFK_SanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFK_SanPham.FormattingEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.cmbFK_SanPham, true);
            this.cmbFK_SanPham.Location = new System.Drawing.Point(75, 14);
            this.cmbFK_SanPham.Name = "cmbFK_SanPham";
            this.cmbFK_SanPham.Size = new System.Drawing.Size(276, 21);
            this.cmbFK_SanPham.TabIndex = 4;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoLuong.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoLuong.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtSoLuong, true);
            this.txtSoLuong.Location = new System.Drawing.Point(423, 13);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(77, 22);
            this.txtSoLuong.TabIndex = 5;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            this.txtSoLuong.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSoLuong_KeyUp);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDonGia.BackColor = System.Drawing.SystemColors.Window;
            this.txtDonGia.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtDonGia, true);
            this.txtDonGia.Location = new System.Drawing.Point(558, 13);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(129, 22);
            this.txtDonGia.TabIndex = 6;
            this.txtDonGia.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            this.txtDonGia.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDonGia_KeyUp);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThanhTien.BackColor = System.Drawing.SystemColors.Window;
            this.txtThanhTien.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtThanhTien, true);
            this.txtThanhTien.Location = new System.Drawing.Point(766, 13);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(211, 22);
            this.txtThanhTien.TabIndex = 7;
            this.txtThanhTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThanhTien_KeyPress);
            this.txtThanhTien.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtThanhTien_KeyUp);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGhiChu.BackColor = System.Drawing.SystemColors.Window;
            this.txtGhiChu.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtGhiChu, true);
            this.txtGhiChu.Location = new System.Drawing.Point(75, 43);
            this.txtGhiChu.MaxLength = 200;
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(902, 45);
            this.txtGhiChu.TabIndex = 8;
            this.txtGhiChu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGhiChu_KeyPress);
            // 
            // cmbSubFK_VatTu
            // 
            this.cmbSubFK_VatTu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSubFK_VatTu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubFK_VatTu.FormattingEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.cmbSubFK_VatTu, true);
            this.cmbSubFK_VatTu.Location = new System.Drawing.Point(75, 503);
            this.cmbSubFK_VatTu.Name = "cmbSubFK_VatTu";
            this.cmbSubFK_VatTu.Size = new System.Drawing.Size(276, 21);
            this.cmbSubFK_VatTu.TabIndex = 10;
            // 
            // txtSubSoLuong
            // 
            this.txtSubSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubSoLuong.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubSoLuong.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtSubSoLuong, true);
            this.txtSubSoLuong.Location = new System.Drawing.Point(423, 502);
            this.txtSubSoLuong.Name = "txtSubSoLuong";
            this.txtSubSoLuong.Size = new System.Drawing.Size(77, 22);
            this.txtSubSoLuong.TabIndex = 11;
            this.txtSubSoLuong.TextChanged += new System.EventHandler(this.txtSubSoLuong_TextChanged);
            this.txtSubSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubSoLuong_KeyPress);
            this.txtSubSoLuong.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSubSoLuong_KeyUp);
            // 
            // txtSubDonGia
            // 
            this.txtSubDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubDonGia.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubDonGia.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtSubDonGia, true);
            this.txtSubDonGia.Location = new System.Drawing.Point(558, 502);
            this.txtSubDonGia.Name = "txtSubDonGia";
            this.txtSubDonGia.Size = new System.Drawing.Size(129, 22);
            this.txtSubDonGia.TabIndex = 12;
            this.txtSubDonGia.TextChanged += new System.EventHandler(this.txtSubSoLuong_TextChanged);
            this.txtSubDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubDonGia_KeyPress);
            this.txtSubDonGia.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSubDonGia_KeyUp);
            // 
            // txtSubThanhTien
            // 
            this.txtSubThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubThanhTien.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubThanhTien.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtSubThanhTien, true);
            this.txtSubThanhTien.Location = new System.Drawing.Point(766, 502);
            this.txtSubThanhTien.Name = "txtSubThanhTien";
            this.txtSubThanhTien.ReadOnly = true;
            this.txtSubThanhTien.Size = new System.Drawing.Size(211, 22);
            this.txtSubThanhTien.TabIndex = 13;
            this.txtSubThanhTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubThanhTien_KeyPress);
            this.txtSubThanhTien.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSubThanhTien_KeyUp);
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
            this.btnNew.Location = new System.Drawing.Point(553, 4);
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
            this.btnDelete.Location = new System.Drawing.Point(719, 4);
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
            this.btnPrint.Location = new System.Drawing.Point(811, 4);
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
            this.btnEdit.Location = new System.Drawing.Point(629, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 30);
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
            this.tab01.Text = "Danh sách nhập kho";
            this.tab01.UseVisualStyleBackColor = true;
            // 
            // gridParrent
            // 
            this.gridParrent.AllowUserToAddRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.gridParrent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gridParrent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridParrent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.gridParrent.ColumnHeadersHeight = 25;
            this.gridParrent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Id,
            this.col_NgayNhapKho,
            this.col_FK_NguoiNhapKho,
            this.col_FK_SanPham,
            this.col_TenSanPham,
            this.col_DonViTinh,
            this.col_SoLuong,
            this.col_DonGia,
            this.col_ThanhTien,
            this.col_FullName,
            this.col_GhiChu});
            this.gridParrent.ContextMenuStrip = this.menuParrent;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridParrent.DefaultCellStyle = dataGridViewCellStyle27;
            this.gridParrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridParrent.EnableHeadersVisualStyles = false;
            this.gridParrent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.gridParrent.HighlightSelectedColumnHeaders = false;
            this.gridParrent.Location = new System.Drawing.Point(3, 3);
            this.gridParrent.MultiSelect = false;
            this.gridParrent.Name = "gridParrent";
            this.gridParrent.PaintEnhancedSelection = false;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridParrent.RowHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.gridParrent.RowHeadersVisible = false;
            this.gridParrent.RowHeadersWidth = 51;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.White;
            this.gridParrent.RowsDefaultCellStyle = dataGridViewCellStyle29;
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
            this.col_Id.Visible = false;
            // 
            // col_NgayNhapKho
            // 
            this.col_NgayNhapKho.DataPropertyName = "NgayNhapKho";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.Format = "dd/MM/yyyy HH:mm:ss";
            this.col_NgayNhapKho.DefaultCellStyle = dataGridViewCellStyle15;
            this.col_NgayNhapKho.HeaderText = "Ngày nhập kho";
            this.col_NgayNhapKho.Name = "col_NgayNhapKho";
            this.col_NgayNhapKho.ReadOnly = true;
            // 
            // col_FK_NguoiNhapKho
            // 
            this.col_FK_NguoiNhapKho.DataPropertyName = "FK_NguoiNhapKho";
            this.col_FK_NguoiNhapKho.HeaderText = "FK_NguoiNhapKho";
            this.col_FK_NguoiNhapKho.Name = "col_FK_NguoiNhapKho";
            this.col_FK_NguoiNhapKho.ReadOnly = true;
            this.col_FK_NguoiNhapKho.Visible = false;
            // 
            // col_FK_SanPham
            // 
            this.col_FK_SanPham.DataPropertyName = "FK_SanPham";
            this.col_FK_SanPham.HeaderText = "FK_SanPham";
            this.col_FK_SanPham.Name = "col_FK_SanPham";
            this.col_FK_SanPham.ReadOnly = true;
            this.col_FK_SanPham.Visible = false;
            // 
            // col_TenSanPham
            // 
            this.col_TenSanPham.DataPropertyName = "TenSanPham";
            this.col_TenSanPham.HeaderText = "Tên sản phẩm";
            this.col_TenSanPham.Name = "col_TenSanPham";
            this.col_TenSanPham.ReadOnly = true;
            // 
            // col_DonViTinh
            // 
            this.col_DonViTinh.DataPropertyName = "DonViTinh";
            this.col_DonViTinh.HeaderText = "Đơn vị tính";
            this.col_DonViTinh.Name = "col_DonViTinh";
            this.col_DonViTinh.ReadOnly = true;
            // 
            // col_SoLuong
            // 
            this.col_SoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Format = "N2";
            this.col_SoLuong.DefaultCellStyle = dataGridViewCellStyle16;
            this.col_SoLuong.HeaderText = "Số lượng";
            this.col_SoLuong.Name = "col_SoLuong";
            this.col_SoLuong.ReadOnly = true;
            // 
            // col_DonGia
            // 
            this.col_DonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "N2";
            this.col_DonGia.DefaultCellStyle = dataGridViewCellStyle17;
            this.col_DonGia.HeaderText = "Đơn giá";
            this.col_DonGia.Name = "col_DonGia";
            this.col_DonGia.ReadOnly = true;
            // 
            // col_ThanhTien
            // 
            this.col_ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle26.Format = "N2";
            this.col_ThanhTien.DefaultCellStyle = dataGridViewCellStyle26;
            this.col_ThanhTien.HeaderText = "Thành tiền";
            this.col_ThanhTien.Name = "col_ThanhTien";
            this.col_ThanhTien.ReadOnly = true;
            // 
            // col_FullName
            // 
            this.col_FullName.DataPropertyName = "FullName";
            this.col_FullName.HeaderText = "Người nhập";
            this.col_FullName.Name = "col_FullName";
            this.col_FullName.ReadOnly = true;
            // 
            // col_GhiChu
            // 
            this.col_GhiChu.DataPropertyName = "GhiChu";
            this.col_GhiChu.HeaderText = "Ghi chú";
            this.col_GhiChu.Name = "col_GhiChu";
            this.col_GhiChu.ReadOnly = true;
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
            this.tab02.Controls.Add(this.lblFK_SanPham);
            this.tab02.Controls.Add(this.cmbFK_SanPham);
            this.tab02.Controls.Add(this.txtSoLuong);
            this.tab02.Controls.Add(this.lblDonGia);
            this.tab02.Controls.Add(this.txtDonGia);
            this.tab02.Controls.Add(this.lblThanhTien);
            this.tab02.Controls.Add(this.txtThanhTien);
            this.tab02.Controls.Add(this.lblGhiChu);
            this.tab02.Controls.Add(this.txtGhiChu);
            this.tab02.Controls.Add(this.lblSubFK_VatTu);
            this.tab02.Controls.Add(this.cmbSubFK_VatTu);
            this.tab02.Controls.Add(this.lblSubSoLuong);
            this.tab02.Controls.Add(this.txtSubSoLuong);
            this.tab02.Controls.Add(this.lblSubDonGia);
            this.tab02.Controls.Add(this.txtSubDonGia);
            this.tab02.Controls.Add(this.lblSubThanhTien);
            this.tab02.Controls.Add(this.txtSubThanhTien);
            this.tab02.Controls.Add(this.lblSoLuong);
            this.tab02.Location = new System.Drawing.Point(4, 22);
            this.tab02.Name = "tab02";
            this.tab02.Padding = new System.Windows.Forms.Padding(3);
            this.tab02.Size = new System.Drawing.Size(1000, 582);
            this.tab02.TabIndex = 1;
            this.tab02.Text = "Chi tiết nhập kho";
            this.tab02.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnNhapVatTu);
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
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.gridChild.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle18;
            this.gridChild.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridChild.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridChild.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.gridChild.ColumnHeadersHeight = 25;
            this.gridChild.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_SubFK_NhapKho,
            this.col_SubFK_VatTu,
            this.col_SubTenVatTu,
            this.col_SubDVT,
            this.col_SubSoLuong,
            this.col_SubDonGia,
            this.col_SubThanhTien});
            this.gridChild.ContextMenuStrip = this.menuChild;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridChild.DefaultCellStyle = dataGridViewCellStyle23;
            this.gridChild.EnableHeadersVisualStyles = false;
            this.gridChild.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.gridChild.HighlightSelectedColumnHeaders = false;
            this.gridChild.Location = new System.Drawing.Point(11, 98);
            this.gridChild.MultiSelect = false;
            this.gridChild.Name = "gridChild";
            this.gridChild.PaintEnhancedSelection = false;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridChild.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.gridChild.RowHeadersVisible = false;
            this.gridChild.RowHeadersWidth = 51;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.White;
            this.gridChild.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.gridChild.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridChild.RowTemplate.Height = 25;
            this.gridChild.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridChild.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridChild.Size = new System.Drawing.Size(981, 390);
            this.gridChild.TabIndex = 6;
            this.gridChild.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridMain_CellMouseDoubleClick);
            this.gridChild.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridMain_RowPostPaint);
            // 
            // col_SubFK_NhapKho
            // 
            this.col_SubFK_NhapKho.DataPropertyName = "FK_NhapKho";
            this.col_SubFK_NhapKho.HeaderText = "FK_NhapKho";
            this.col_SubFK_NhapKho.Name = "col_SubFK_NhapKho";
            this.col_SubFK_NhapKho.ReadOnly = true;
            this.col_SubFK_NhapKho.Visible = false;
            // 
            // col_SubFK_VatTu
            // 
            this.col_SubFK_VatTu.DataPropertyName = "FK_VatTu";
            this.col_SubFK_VatTu.HeaderText = "FK_VatTu";
            this.col_SubFK_VatTu.Name = "col_SubFK_VatTu";
            this.col_SubFK_VatTu.ReadOnly = true;
            this.col_SubFK_VatTu.Visible = false;
            // 
            // col_SubTenVatTu
            // 
            this.col_SubTenVatTu.DataPropertyName = "TenVatTu";
            this.col_SubTenVatTu.HeaderText = "Vật tư";
            this.col_SubTenVatTu.Name = "col_SubTenVatTu";
            this.col_SubTenVatTu.ReadOnly = true;
            // 
            // col_SubDVT
            // 
            this.col_SubDVT.DataPropertyName = "DVT";
            this.col_SubDVT.HeaderText = "ĐVT";
            this.col_SubDVT.Name = "col_SubDVT";
            this.col_SubDVT.ReadOnly = true;
            // 
            // col_SubSoLuong
            // 
            this.col_SubSoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.Format = "N2";
            this.col_SubSoLuong.DefaultCellStyle = dataGridViewCellStyle20;
            this.col_SubSoLuong.HeaderText = "Số lượng";
            this.col_SubSoLuong.Name = "col_SubSoLuong";
            this.col_SubSoLuong.ReadOnly = true;
            // 
            // col_SubDonGia
            // 
            this.col_SubDonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle21.Format = "N2";
            this.col_SubDonGia.DefaultCellStyle = dataGridViewCellStyle21;
            this.col_SubDonGia.HeaderText = "Đơn giá";
            this.col_SubDonGia.Name = "col_SubDonGia";
            this.col_SubDonGia.ReadOnly = true;
            // 
            // col_SubThanhTien
            // 
            this.col_SubThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Format = "N2";
            this.col_SubThanhTien.DefaultCellStyle = dataGridViewCellStyle22;
            this.col_SubThanhTien.HeaderText = "Thành tiền";
            this.col_SubThanhTien.Name = "col_SubThanhTien";
            this.col_SubThanhTien.ReadOnly = true;
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
            // lblFK_SanPham
            // 
            this.lblFK_SanPham.AutoSize = true;
            this.lblFK_SanPham.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFK_SanPham.ForeColor = System.Drawing.Color.Black;
            this.lblFK_SanPham.Location = new System.Drawing.Point(8, 17);
            this.lblFK_SanPham.Name = "lblFK_SanPham";
            this.lblFK_SanPham.Size = new System.Drawing.Size(65, 14);
            this.lblFK_SanPham.TabIndex = 1000;
            this.lblFK_SanPham.Text = "Sản phẩm:";
            // 
            // lblDonGia
            // 
            this.lblDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.ForeColor = System.Drawing.Color.Black;
            this.lblDonGia.Location = new System.Drawing.Point(505, 17);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(52, 14);
            this.lblDonGia.TabIndex = 1000;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTien.ForeColor = System.Drawing.Color.Black;
            this.lblThanhTien.Location = new System.Drawing.Point(693, 17);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(71, 14);
            this.lblThanhTien.TabIndex = 1000;
            this.lblThanhTien.Text = "Thành tiền:";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.ForeColor = System.Drawing.Color.Black;
            this.lblGhiChu.Location = new System.Drawing.Point(26, 59);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(47, 13);
            this.lblGhiChu.TabIndex = 1000;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // lblSubFK_VatTu
            // 
            this.lblSubFK_VatTu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSubFK_VatTu.AutoSize = true;
            this.lblSubFK_VatTu.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubFK_VatTu.ForeColor = System.Drawing.Color.Black;
            this.lblSubFK_VatTu.Location = new System.Drawing.Point(26, 506);
            this.lblSubFK_VatTu.Name = "lblSubFK_VatTu";
            this.lblSubFK_VatTu.Size = new System.Drawing.Size(47, 14);
            this.lblSubFK_VatTu.TabIndex = 1000;
            this.lblSubFK_VatTu.Text = "Vật tư:";
            // 
            // lblSubSoLuong
            // 
            this.lblSubSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubSoLuong.AutoSize = true;
            this.lblSubSoLuong.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubSoLuong.ForeColor = System.Drawing.Color.Black;
            this.lblSubSoLuong.Location = new System.Drawing.Point(359, 506);
            this.lblSubSoLuong.Name = "lblSubSoLuong";
            this.lblSubSoLuong.Size = new System.Drawing.Size(60, 14);
            this.lblSubSoLuong.TabIndex = 1000;
            this.lblSubSoLuong.Text = "Số lượng:";
            // 
            // lblSubDonGia
            // 
            this.lblSubDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubDonGia.AutoSize = true;
            this.lblSubDonGia.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubDonGia.ForeColor = System.Drawing.Color.Black;
            this.lblSubDonGia.Location = new System.Drawing.Point(505, 506);
            this.lblSubDonGia.Name = "lblSubDonGia";
            this.lblSubDonGia.Size = new System.Drawing.Size(52, 14);
            this.lblSubDonGia.TabIndex = 1000;
            this.lblSubDonGia.Text = "Đơn giá:";
            // 
            // lblSubThanhTien
            // 
            this.lblSubThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubThanhTien.AutoSize = true;
            this.lblSubThanhTien.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubThanhTien.ForeColor = System.Drawing.Color.Black;
            this.lblSubThanhTien.Location = new System.Drawing.Point(693, 506);
            this.lblSubThanhTien.Name = "lblSubThanhTien";
            this.lblSubThanhTien.Size = new System.Drawing.Size(71, 14);
            this.lblSubThanhTien.TabIndex = 1000;
            this.lblSubThanhTien.Text = "Thành tiền:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.ForeColor = System.Drawing.Color.Black;
            this.lblSoLuong.Location = new System.Drawing.Point(359, 17);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(60, 14);
            this.lblSoLuong.TabIndex = 1000;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // btnNhapVatTu
            // 
            this.btnNhapVatTu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNhapVatTu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNhapVatTu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapVatTu.Image = global::LeMaiDesktop.Properties.Resources.icoTonKho;
            this.btnNhapVatTu.ImageTextSpacing = 3;
            this.btnNhapVatTu.Location = new System.Drawing.Point(8, 4);
            this.btnNhapVatTu.Name = "btnNhapVatTu";
            this.btnNhapVatTu.Size = new System.Drawing.Size(104, 30);
            this.btnNhapVatTu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNhapVatTu.TabIndex = 1324;
            this.btnNhapVatTu.Text = "Nhập vật tư";
            this.btnNhapVatTu.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnNhapVatTu.Click += new System.EventHandler(this.btnNhapVatTu_Click);
            // 
            // frmNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 608);
            this.Controls.Add(this.tabControl);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhapKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập kho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNhapKho_FormClosing);
            this.Load += new System.EventHandler(this.frmNhapKho_Load);
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
		private System.Windows.Forms.Label lblFK_SanPham;
		private System.Windows.Forms.ComboBox cmbFK_SanPham;
		private System.Windows.Forms.Label lblSoLuong;
		private System.Windows.Forms.TextBox txtSoLuong;
		private System.Windows.Forms.Label lblDonGia;
		private System.Windows.Forms.TextBox txtDonGia;
		private System.Windows.Forms.Label lblThanhTien;
		private System.Windows.Forms.TextBox txtThanhTien;
		private System.Windows.Forms.Label lblGhiChu;
		private System.Windows.Forms.TextBox txtGhiChu;
		private System.Windows.Forms.Label lblSubFK_VatTu;
		private System.Windows.Forms.ComboBox cmbSubFK_VatTu;
		private System.Windows.Forms.Label lblSubSoLuong;
		private System.Windows.Forms.TextBox txtSubSoLuong;
		private System.Windows.Forms.Label lblSubDonGia;
		private System.Windows.Forms.TextBox txtSubDonGia;
		private System.Windows.Forms.Label lblSubThanhTien;
		private System.Windows.Forms.TextBox txtSubThanhTien;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayNhapKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_NguoiNhapKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_SanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SubFK_NhapKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SubFK_VatTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SubTenVatTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SubDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SubSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SubDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SubThanhTien;
        private DevComponents.DotNetBar.ButtonX btnNhapVatTu;
    }
}
