namespace LeMaiDesktop
{
	partial class frmChuyenKhoanCOD
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panelcomtrol = new System.Windows.Forms.Panel();
			this.txtSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.btnNew = new DevComponents.DotNetBar.ButtonX();
			this.btnSave = new DevComponents.DotNetBar.ButtonX();
			this.btnEdit = new DevComponents.DotNetBar.ButtonX();
			this.btnClose = new DevComponents.DotNetBar.ButtonX();
			this.lTieude = new System.Windows.Forms.Label();
			this.gridMain = new DevComponents.DotNetBar.Controls.DataGridViewX();
			this.col_BILL_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_SoTienCKCOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_FK_Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_FK_Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
			this.txtBILL_CODE = new System.Windows.Forms.TextBox();
			this.txtSoTienCKCOD = new System.Windows.Forms.TextBox();
			this.lblBILL_CODE = new System.Windows.Forms.Label();
			this.lblSoTienCKCOD = new System.Windows.Forms.Label();
			this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
			this.btnExcel = new DevComponents.DotNetBar.ButtonX();
			this.panelcomtrol.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
			this.SuspendLayout();
			// 
			// panelcomtrol
			// 
			this.panelcomtrol.BackColor = System.Drawing.Color.SteelBlue;
			this.panelcomtrol.Controls.Add(this.btnExcel);
			this.panelcomtrol.Controls.Add(this.txtSearch);
			this.panelcomtrol.Controls.Add(this.btnNew);
			this.panelcomtrol.Controls.Add(this.btnSave);
			this.panelcomtrol.Controls.Add(this.btnEdit);
			this.panelcomtrol.Controls.Add(this.btnClose);
			this.panelcomtrol.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelcomtrol.Location = new System.Drawing.Point(0, 561);
			this.panelcomtrol.Name = "panelcomtrol";
			this.panelcomtrol.Size = new System.Drawing.Size(576, 39);
			this.panelcomtrol.TabIndex = 2;
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
			this.txtSearch.Size = new System.Drawing.Size(134, 21);
			this.txtSearch.TabIndex = 4;
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
			this.btnNew.Location = new System.Drawing.Point(207, 6);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(65, 30);
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
			this.btnSave.Location = new System.Drawing.Point(419, 6);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(65, 30);
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
			this.btnEdit.Location = new System.Drawing.Point(276, 6);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(70, 30);
			this.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnEdit.TabIndex = 1;
			this.btnEdit.Text = "&Sửa";
			this.btnEdit.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnClose
			// 
			this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = global::LeMaiDesktop.Properties.Resources.iExit;
			this.btnClose.ImageTextSpacing = 3;
			this.btnClose.Location = new System.Drawing.Point(488, 6);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(80, 30);
			this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnClose.TabIndex = 3;
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
			this.lTieude.Size = new System.Drawing.Size(576, 30);
			this.lTieude.TabIndex = 5;
			this.lTieude.Text = "    Chuyển khoản điều chỉnh COD";
			this.lTieude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// gridMain
			// 
			this.gridMain.AllowUserToAddRows = false;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
			this.gridMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
			this.gridMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.gridMain.ColumnHeadersHeight = 25;
			this.gridMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_BILL_CODE,
            this.col_SoTienCKCOD,
            this.col_FK_Post,
            this.col_FK_Account,
            this.col_CreateDate});
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridMain.DefaultCellStyle = dataGridViewCellStyle12;
			this.gridMain.EnableHeadersVisualStyles = false;
			this.gridMain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.gridMain.HighlightSelectedColumnHeaders = false;
			this.gridMain.Location = new System.Drawing.Point(3, 33);
			this.gridMain.MultiSelect = false;
			this.gridMain.Name = "gridMain";
			this.gridMain.PaintEnhancedSelection = false;
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
			this.gridMain.RowHeadersVisible = false;
			dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
			dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
			this.gridMain.RowsDefaultCellStyle = dataGridViewCellStyle14;
			this.gridMain.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridMain.RowTemplate.Height = 25;
			this.gridMain.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.gridMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridMain.Size = new System.Drawing.Size(573, 479);
			this.gridMain.TabIndex = 4;
			this.gridMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMain_CellDoubleClick);
			// 
			// col_BILL_CODE
			// 
			this.col_BILL_CODE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.col_BILL_CODE.DataPropertyName = "BILL_CODE";
			this.col_BILL_CODE.HeaderText = "Mã vận đơn";
			this.col_BILL_CODE.Name = "col_BILL_CODE";
			this.col_BILL_CODE.ReadOnly = true;
			this.col_BILL_CODE.Width = 200;
			// 
			// col_SoTienCKCOD
			// 
			this.col_SoTienCKCOD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.col_SoTienCKCOD.DataPropertyName = "SoTienCKCOD";
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle10.Format = "N0";
			this.col_SoTienCKCOD.DefaultCellStyle = dataGridViewCellStyle10;
			this.col_SoTienCKCOD.HeaderText = "Số tiền CK";
			this.col_SoTienCKCOD.Name = "col_SoTienCKCOD";
			this.col_SoTienCKCOD.ReadOnly = true;
			this.col_SoTienCKCOD.Width = 150;
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
			this.col_FK_Account.HeaderText = "Người thực hiện";
			this.col_FK_Account.Name = "col_FK_Account";
			this.col_FK_Account.ReadOnly = true;
			// 
			// col_CreateDate
			// 
			this.col_CreateDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.col_CreateDate.DataPropertyName = "CreateDate";
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.Format = "dd/MM/yyyy HH:mm:ss";
			this.col_CreateDate.DefaultCellStyle = dataGridViewCellStyle11;
			this.col_CreateDate.HeaderText = "Ngày thực hiện";
			this.col_CreateDate.Name = "col_CreateDate";
			this.col_CreateDate.ReadOnly = true;
			this.col_CreateDate.Width = 150;
			// 
			// highlighter
			// 
			this.highlighter.ContainerControl = this;
			this.highlighter.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Green;
			// 
			// txtBILL_CODE
			// 
			this.txtBILL_CODE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtBILL_CODE.BackColor = System.Drawing.SystemColors.Window;
			this.txtBILL_CODE.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.highlighter.SetHighlightOnFocus(this.txtBILL_CODE, true);
			this.txtBILL_CODE.Location = new System.Drawing.Point(81, 528);
			this.txtBILL_CODE.MaxLength = 14;
			this.txtBILL_CODE.Name = "txtBILL_CODE";
			this.txtBILL_CODE.Size = new System.Drawing.Size(257, 22);
			this.txtBILL_CODE.TabIndex = 0;
			this.txtBILL_CODE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBILL_CODE_KeyPress);
			// 
			// txtSoTienCKCOD
			// 
			this.txtSoTienCKCOD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtSoTienCKCOD.BackColor = System.Drawing.SystemColors.Window;
			this.txtSoTienCKCOD.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.highlighter.SetHighlightOnFocus(this.txtSoTienCKCOD, true);
			this.txtSoTienCKCOD.Location = new System.Drawing.Point(399, 528);
			this.txtSoTienCKCOD.Name = "txtSoTienCKCOD";
			this.txtSoTienCKCOD.Size = new System.Drawing.Size(165, 22);
			this.txtSoTienCKCOD.TabIndex = 1;
			this.txtSoTienCKCOD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTienCKCOD_KeyPress);
			this.txtSoTienCKCOD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSoTienCKCOD_KeyUp);
			// 
			// lblBILL_CODE
			// 
			this.lblBILL_CODE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblBILL_CODE.AutoSize = true;
			this.lblBILL_CODE.ForeColor = System.Drawing.Color.Black;
			this.lblBILL_CODE.Location = new System.Drawing.Point(8, 533);
			this.lblBILL_CODE.Name = "lblBILL_CODE";
			this.lblBILL_CODE.Size = new System.Drawing.Size(67, 13);
			this.lblBILL_CODE.TabIndex = 3;
			this.lblBILL_CODE.Text = "Mã vận đơn:";
			// 
			// lblSoTienCKCOD
			// 
			this.lblSoTienCKCOD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblSoTienCKCOD.AutoSize = true;
			this.lblSoTienCKCOD.ForeColor = System.Drawing.Color.Black;
			this.lblSoTienCKCOD.Location = new System.Drawing.Point(339, 533);
			this.lblSoTienCKCOD.Name = "lblSoTienCKCOD";
			this.lblSoTienCKCOD.Size = new System.Drawing.Size(60, 13);
			this.lblSoTienCKCOD.TabIndex = 1000;
			this.lblSoTienCKCOD.Text = "Số tiền CK:";
			// 
			// styleManager
			// 
			this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue;
			this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
			// 
			// btnExcel
			// 
			this.btnExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExcel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnExcel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcel.Image = global::LeMaiDesktop.Properties.Resources.iExcel;
			this.btnExcel.ImageTextSpacing = 3;
			this.btnExcel.Location = new System.Drawing.Point(350, 6);
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(65, 30);
			this.btnExcel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnExcel.TabIndex = 5;
			this.btnExcel.Text = "Excel";
			this.btnExcel.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
			this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
			// 
			// frmChuyenKhoanCOD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(576, 600);
			this.Controls.Add(this.gridMain);
			this.Controls.Add(this.panelcomtrol);
			this.Controls.Add(this.lTieude);
			this.Controls.Add(this.lblBILL_CODE);
			this.Controls.Add(this.txtBILL_CODE);
			this.Controls.Add(this.lblSoTienCKCOD);
			this.Controls.Add(this.txtSoTienCKCOD);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmChuyenKhoanCOD";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chuyển khoản điều chỉnh COD";
			this.Load += new System.EventHandler(this.frmChuyenKhoanCOD_Load);
			this.panelcomtrol.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panelcomtrol;
		private System.Windows.Forms.Label lTieude;
		private DevComponents.DotNetBar.ButtonX btnClose;
		private DevComponents.DotNetBar.ButtonX btnNew;
		private DevComponents.DotNetBar.ButtonX btnSave;
		private DevComponents.DotNetBar.ButtonX btnEdit;
		private DevComponents.DotNetBar.Controls.DataGridViewX gridMain;
		private DevComponents.DotNetBar.Controls.TextBoxX txtSearch;
		private DevComponents.DotNetBar.Validator.Highlighter highlighter;
		private System.Windows.Forms.Label lblBILL_CODE;
		private System.Windows.Forms.TextBox txtBILL_CODE;
		private System.Windows.Forms.Label lblSoTienCKCOD;
		private System.Windows.Forms.TextBox txtSoTienCKCOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BILL_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SoTienCKCOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_Post;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CreateDate;
        private DevComponents.DotNetBar.StyleManager styleManager;
		private DevComponents.DotNetBar.ButtonX btnExcel;
	}
}
