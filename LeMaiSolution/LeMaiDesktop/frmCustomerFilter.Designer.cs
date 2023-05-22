
namespace LeMaiDesktop
{
	partial class frmCustomerFilter
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
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnExcel = new DevComponents.DotNetBar.ButtonX();
            this.txtSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dataGrid = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CustomerCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CustomerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AccountCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GoogleMap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FK_Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ContractCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_UnsigName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FK_Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SoHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FK_GiaCuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MaSoThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.panelcomtrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panelcomtrol
            // 
            this.panelcomtrol.BackColor = System.Drawing.Color.SteelBlue;
            this.panelcomtrol.Controls.Add(this.btnClose);
            this.panelcomtrol.Controls.Add(this.btnExcel);
            this.panelcomtrol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelcomtrol.Location = new System.Drawing.Point(0, 548);
            this.panelcomtrol.Name = "panelcomtrol";
            this.panelcomtrol.Size = new System.Drawing.Size(959, 39);
            this.panelcomtrol.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::LeMaiDesktop.Properties.Resources.iExit;
            this.btnClose.ImageTextSpacing = 3;
            this.btnClose.Location = new System.Drawing.Point(860, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 30);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "&Kết thúc";
            this.btnClose.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExcel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Image = global::LeMaiDesktop.Properties.Resources.iExcel;
            this.btnExcel.ImageTextSpacing = 3;
            this.btnExcel.Location = new System.Drawing.Point(769, 5);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(88, 30);
            this.btnExcel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExcel.TabIndex = 6;
            this.btnExcel.Text = "&Export";
            this.btnExcel.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.Border.Class = "TextBoxBorder";
            this.txtSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(108, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(839, 29);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.WatermarkText = "Tên, Mã số, SĐT khách hàng...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.ColumnHeadersHeight = 25;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Id,
            this.col_CustomerCode,
            this.col_CustomerName,
            this.col_TenHopDong,
            this.col_CustomerPhone,
            this.col_BankName,
            this.col_AccountName,
            this.col_AccountCode,
            this.col_GoogleMap,
            this.col_FK_Post,
            this.col_ContractCustomer,
            this.col_UnsigName,
            this.col_FK_Group,
            this.col_SoHopDong,
            this.col_NgayHopDong,
            this.col_DiaChi,
            this.col_FK_GiaCuoc,
            this.col_DonVi,
            this.col_MaSoThue});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataGrid.HighlightSelectedColumnHeaders = false;
            this.dataGrid.Location = new System.Drawing.Point(3, 55);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.PaintEnhancedSelection = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid.RowTemplate.Height = 25;
            this.dataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(948, 493);
            this.dataGrid.TabIndex = 9;
            this.dataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellDoubleClick);
            // 
            // col_Id
            // 
            this.col_Id.DataPropertyName = "Id";
            this.col_Id.HeaderText = "Id";
            this.col_Id.Name = "col_Id";
            this.col_Id.ReadOnly = true;
            this.col_Id.Visible = false;
            this.col_Id.Width = 65;
            // 
            // col_CustomerCode
            // 
            this.col_CustomerCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_CustomerCode.DataPropertyName = "CustomerCode";
            this.col_CustomerCode.HeaderText = "Mã khách hàng";
            this.col_CustomerCode.Name = "col_CustomerCode";
            this.col_CustomerCode.ReadOnly = true;
            this.col_CustomerCode.Width = 120;
            // 
            // col_CustomerName
            // 
            this.col_CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_CustomerName.DataPropertyName = "CustomerName";
            this.col_CustomerName.HeaderText = "Tên khách hàng";
            this.col_CustomerName.Name = "col_CustomerName";
            this.col_CustomerName.ReadOnly = true;
            this.col_CustomerName.Width = 200;
            // 
            // col_TenHopDong
            // 
            this.col_TenHopDong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_TenHopDong.DataPropertyName = "TenHopDong";
            this.col_TenHopDong.HeaderText = "Tên hợp đồng";
            this.col_TenHopDong.Name = "col_TenHopDong";
            this.col_TenHopDong.ReadOnly = true;
            this.col_TenHopDong.Width = 200;
            // 
            // col_CustomerPhone
            // 
            this.col_CustomerPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_CustomerPhone.DataPropertyName = "CustomerPhone";
            this.col_CustomerPhone.HeaderText = "Số điện thoại";
            this.col_CustomerPhone.Name = "col_CustomerPhone";
            this.col_CustomerPhone.ReadOnly = true;
            // 
            // col_BankName
            // 
            this.col_BankName.DataPropertyName = "BankName";
            this.col_BankName.HeaderText = "BankName";
            this.col_BankName.Name = "col_BankName";
            this.col_BankName.ReadOnly = true;
            this.col_BankName.Visible = false;
            this.col_BankName.Width = 64;
            // 
            // col_AccountName
            // 
            this.col_AccountName.DataPropertyName = "AccountName";
            this.col_AccountName.HeaderText = "AccountName";
            this.col_AccountName.Name = "col_AccountName";
            this.col_AccountName.ReadOnly = true;
            this.col_AccountName.Visible = false;
            this.col_AccountName.Width = 65;
            // 
            // col_AccountCode
            // 
            this.col_AccountCode.DataPropertyName = "AccountCode";
            this.col_AccountCode.HeaderText = "AccountCode";
            this.col_AccountCode.Name = "col_AccountCode";
            this.col_AccountCode.ReadOnly = true;
            this.col_AccountCode.Visible = false;
            this.col_AccountCode.Width = 64;
            // 
            // col_GoogleMap
            // 
            this.col_GoogleMap.DataPropertyName = "GoogleMap";
            this.col_GoogleMap.HeaderText = "GoogleMap";
            this.col_GoogleMap.Name = "col_GoogleMap";
            this.col_GoogleMap.ReadOnly = true;
            this.col_GoogleMap.Visible = false;
            this.col_GoogleMap.Width = 65;
            // 
            // col_FK_Post
            // 
            this.col_FK_Post.DataPropertyName = "FK_Post";
            this.col_FK_Post.HeaderText = "FK_Post";
            this.col_FK_Post.Name = "col_FK_Post";
            this.col_FK_Post.ReadOnly = true;
            this.col_FK_Post.Visible = false;
            this.col_FK_Post.Width = 64;
            // 
            // col_ContractCustomer
            // 
            this.col_ContractCustomer.DataPropertyName = "ContractCustomer";
            this.col_ContractCustomer.HeaderText = "Khách hợp đồng";
            this.col_ContractCustomer.Name = "col_ContractCustomer";
            this.col_ContractCustomer.ReadOnly = true;
            this.col_ContractCustomer.Visible = false;
            this.col_ContractCustomer.Width = 64;
            // 
            // col_UnsigName
            // 
            this.col_UnsigName.DataPropertyName = "UnsigName";
            this.col_UnsigName.HeaderText = "UnsigName";
            this.col_UnsigName.Name = "col_UnsigName";
            this.col_UnsigName.ReadOnly = true;
            this.col_UnsigName.Visible = false;
            this.col_UnsigName.Width = 65;
            // 
            // col_FK_Group
            // 
            this.col_FK_Group.DataPropertyName = "FK_Group";
            this.col_FK_Group.HeaderText = "FK_Group";
            this.col_FK_Group.Name = "col_FK_Group";
            this.col_FK_Group.ReadOnly = true;
            this.col_FK_Group.Visible = false;
            this.col_FK_Group.Width = 64;
            // 
            // col_SoHopDong
            // 
            this.col_SoHopDong.DataPropertyName = "SoHopDong";
            this.col_SoHopDong.HeaderText = "SoHopDong";
            this.col_SoHopDong.Name = "col_SoHopDong";
            this.col_SoHopDong.ReadOnly = true;
            this.col_SoHopDong.Visible = false;
            this.col_SoHopDong.Width = 65;
            // 
            // col_NgayHopDong
            // 
            this.col_NgayHopDong.DataPropertyName = "NgayHopDong";
            this.col_NgayHopDong.HeaderText = "NgayHopDong";
            this.col_NgayHopDong.Name = "col_NgayHopDong";
            this.col_NgayHopDong.ReadOnly = true;
            this.col_NgayHopDong.Visible = false;
            this.col_NgayHopDong.Width = 64;
            // 
            // col_DiaChi
            // 
            this.col_DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_DiaChi.DataPropertyName = "DiaChi";
            this.col_DiaChi.HeaderText = "Địa chỉ";
            this.col_DiaChi.Name = "col_DiaChi";
            this.col_DiaChi.ReadOnly = true;
            // 
            // col_FK_GiaCuoc
            // 
            this.col_FK_GiaCuoc.DataPropertyName = "FK_GiaCuoc";
            this.col_FK_GiaCuoc.HeaderText = "FK_GiaCuoc";
            this.col_FK_GiaCuoc.Name = "col_FK_GiaCuoc";
            this.col_FK_GiaCuoc.ReadOnly = true;
            this.col_FK_GiaCuoc.Visible = false;
            this.col_FK_GiaCuoc.Width = 65;
            // 
            // col_DonVi
            // 
            this.col_DonVi.DataPropertyName = "DonVi";
            this.col_DonVi.HeaderText = "DonVi";
            this.col_DonVi.Name = "col_DonVi";
            this.col_DonVi.ReadOnly = true;
            this.col_DonVi.Visible = false;
            this.col_DonVi.Width = 64;
            // 
            // col_MaSoThue
            // 
            this.col_MaSoThue.DataPropertyName = "MaSoThue";
            this.col_MaSoThue.HeaderText = "MaSoThue";
            this.col_MaSoThue.Name = "col_MaSoThue";
            this.col_MaSoThue.ReadOnly = true;
            this.col_MaSoThue.Visible = false;
            this.col_MaSoThue.Width = 65;
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.Black;
            this.lblCustomerName.Location = new System.Drawing.Point(12, 10);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(92, 24);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Tìm kiếm:";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmCustomerFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 587);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panelcomtrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomerFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm khách hàng hợp đồng";
            this.Load += new System.EventHandler(this.frmCustomerFilter_Load);
            this.panelcomtrol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private DevComponents.DotNetBar.Controls.TextBoxX txtSearch;
		private System.Windows.Forms.Panel panelcomtrol;
		private DevComponents.DotNetBar.ButtonX btnClose;
		private DevComponents.DotNetBar.ButtonX btnExcel;
		private DevComponents.DotNetBar.Controls.DataGridViewX dataGrid;
		private DevComponents.DotNetBar.StyleManager styleManager;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CustomerCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CustomerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AccountCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GoogleMap;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_Post;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ContractCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_UnsigName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SoHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_GiaCuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaSoThue;
    }
}
