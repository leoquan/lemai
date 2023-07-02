
namespace LeMaiDesktop
{
	partial class frmThongKeDoanhSo
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
            this.lblCounter = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPrint = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnExcel = new DevComponents.DotNetBar.ButtonX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new DevComponents.DotNetBar.ButtonX();
            this.lblBillCode = new System.Windows.Forms.Label();
            this.txtBillCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblRegisterUser = new System.Windows.Forms.Label();
            this.cmbRegisterUser = new System.Windows.Forms.ComboBox();
            this.lblRegisterSiteCode = new System.Windows.Forms.Label();
            this.cmbRegisterSiteCode = new System.Windows.Forms.ComboBox();
            this.lblAcceptProvinceCode = new System.Windows.Forms.Label();
            this.cmbAcceptProvinceCode = new System.Windows.Forms.ComboBox();
            this.dtpToRegisterDate = new System.Windows.Forms.DateTimePicker();
            this.lblToRegisterDate = new System.Windows.Forms.Label();
            this.dtpFromRegisterDate = new System.Windows.Forms.DateTimePicker();
            this.lblFK_Customer = new System.Windows.Forms.Label();
            this.cmbFK_Customer = new System.Windows.Forms.ComboBox();
            this.lblFK_ProviderAccount = new System.Windows.Forms.Label();
            this.cmbFK_ProviderAccount = new System.Windows.Forms.ComboBox();
            this.lblBillStatus = new System.Windows.Forms.Label();
            this.cmbBillStatus = new System.Windows.Forms.ComboBox();
            this.lblFK_PaymentType = new System.Windows.Forms.Label();
            this.cmbFK_PaymentType = new System.Windows.Forms.ComboBox();
            this.btnFilter = new DevComponents.DotNetBar.ButtonX();
            this.dataGrid = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.col_BillCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BT3Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BillWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FeeWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_RegisterUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_RegisterSiteCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Freight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_COD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PayType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SendMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SendManUs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SendManPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SendManAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AcceptProvinceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AcceptDistrictCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AcceptWardCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AcceptMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AcceptManUs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AcceptManPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AcceptManAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AcceptProvince = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AcceptDistrict = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AcceptWard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IsSigned = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_IsReturn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_BillProcessStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_RegisterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SignedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LastUpdateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LastUpdateUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SystemDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BT3Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BT3CodeSub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BT3Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BT3Freight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BT3COD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BT3PayType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BT3LastMess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GoodsNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GoodsCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GoodsW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GoodsH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GoodsL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FK_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FK_ProviderAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PayCustomerDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IsPayCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ShipperPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BillStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FK_PaymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FK_ShipType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FullAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProviderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProviderTypeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GroupProvider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CustomerCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PaymentTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ShipNoteType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_StatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_StatusBackgroundColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_StatusTextColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PrintLable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_RunMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Pickup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AddressPickup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProvincePickup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DistricPickup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_WardPickup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ShopIdPickup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PrintData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelcomtrol.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panelcomtrol
            // 
            this.panelcomtrol.BackColor = System.Drawing.Color.SteelBlue;
            this.panelcomtrol.Controls.Add(this.lblCounter);
            this.panelcomtrol.Controls.Add(this.lblTotal);
            this.panelcomtrol.Controls.Add(this.btnPrint);
            this.panelcomtrol.Controls.Add(this.btnClose);
            this.panelcomtrol.Controls.Add(this.btnExcel);
            this.panelcomtrol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelcomtrol.Location = new System.Drawing.Point(0, 548);
            this.panelcomtrol.Name = "panelcomtrol";
            this.panelcomtrol.Size = new System.Drawing.Size(1535, 39);
            this.panelcomtrol.TabIndex = 7;
            // 
            // lblCounter
            // 
            this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.ForeColor = System.Drawing.Color.White;
            this.lblCounter.Location = new System.Drawing.Point(69, 7);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(130, 27);
            this.lblCounter.TabIndex = 10;
            this.lblCounter.Text = "0";
            this.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(13, 12);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(50, 17);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total:";
            // 
            // btnPrint
            // 
            this.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = global::LeMaiDesktop.Properties.Resources.iPrint;
            this.btnPrint.ImageTextSpacing = 3;
            this.btnPrint.Location = new System.Drawing.Point(1254, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(88, 30);
            this.btnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "&Print";
            this.btnPrint.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::LeMaiDesktop.Properties.Resources.iExit;
            this.btnClose.ImageTextSpacing = 3;
            this.btnClose.Location = new System.Drawing.Point(1436, 5);
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
            this.btnExcel.Location = new System.Drawing.Point(1345, 5);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(88, 30);
            this.btnExcel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExcel.TabIndex = 6;
            this.btnExcel.Text = "&Export";
            this.btnExcel.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.lblBillCode);
            this.panel1.Controls.Add(this.txtBillCode);
            this.panel1.Controls.Add(this.lblRegisterUser);
            this.panel1.Controls.Add(this.cmbRegisterUser);
            this.panel1.Controls.Add(this.lblRegisterSiteCode);
            this.panel1.Controls.Add(this.cmbRegisterSiteCode);
            this.panel1.Controls.Add(this.lblAcceptProvinceCode);
            this.panel1.Controls.Add(this.cmbAcceptProvinceCode);
            this.panel1.Controls.Add(this.dtpToRegisterDate);
            this.panel1.Controls.Add(this.lblToRegisterDate);
            this.panel1.Controls.Add(this.dtpFromRegisterDate);
            this.panel1.Controls.Add(this.lblFK_Customer);
            this.panel1.Controls.Add(this.cmbFK_Customer);
            this.panel1.Controls.Add(this.lblFK_ProviderAccount);
            this.panel1.Controls.Add(this.cmbFK_ProviderAccount);
            this.panel1.Controls.Add(this.lblBillStatus);
            this.panel1.Controls.Add(this.cmbBillStatus);
            this.panel1.Controls.Add(this.lblFK_PaymentType);
            this.panel1.Controls.Add(this.cmbFK_PaymentType);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1535, 84);
            this.panel1.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = global::LeMaiDesktop.Properties.Resources.iChange;
            this.btnClear.ImageTextSpacing = 3;
            this.btnClear.Location = new System.Drawing.Point(1331, 44);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 30);
            this.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Đặt lại";
            this.btnClear.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblBillCode
            // 
            this.lblBillCode.AutoSize = true;
            this.lblBillCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillCode.ForeColor = System.Drawing.Color.White;
            this.lblBillCode.Location = new System.Drawing.Point(28, 14);
            this.lblBillCode.Name = "lblBillCode";
            this.lblBillCode.Size = new System.Drawing.Size(59, 15);
            this.lblBillCode.TabIndex = 2;
            this.lblBillCode.Text = "Mã đơn:";
            this.lblBillCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBillCode
            // 
            // 
            // 
            // 
            this.txtBillCode.Border.Class = "TextBoxBorder";
            this.txtBillCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBillCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillCode.Location = new System.Drawing.Point(87, 11);
            this.txtBillCode.Name = "txtBillCode";
            this.txtBillCode.Size = new System.Drawing.Size(200, 21);
            this.txtBillCode.TabIndex = 1;
            this.txtBillCode.WatermarkText = "BillCode";
            // 
            // lblRegisterUser
            // 
            this.lblRegisterUser.AutoSize = true;
            this.lblRegisterUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterUser.ForeColor = System.Drawing.Color.White;
            this.lblRegisterUser.Location = new System.Drawing.Point(296, 14);
            this.lblRegisterUser.Name = "lblRegisterUser";
            this.lblRegisterUser.Size = new System.Drawing.Size(75, 15);
            this.lblRegisterUser.TabIndex = 2;
            this.lblRegisterUser.Text = "Nhân viên:";
            this.lblRegisterUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbRegisterUser
            // 
            this.cmbRegisterUser.FormattingEnabled = true;
            this.cmbRegisterUser.Location = new System.Drawing.Point(371, 11);
            this.cmbRegisterUser.Name = "cmbRegisterUser";
            this.cmbRegisterUser.Size = new System.Drawing.Size(200, 21);
            this.cmbRegisterUser.TabIndex = 3;
            // 
            // lblRegisterSiteCode
            // 
            this.lblRegisterSiteCode.AutoSize = true;
            this.lblRegisterSiteCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterSiteCode.ForeColor = System.Drawing.Color.White;
            this.lblRegisterSiteCode.Location = new System.Drawing.Point(324, 52);
            this.lblRegisterSiteCode.Name = "lblRegisterSiteCode";
            this.lblRegisterSiteCode.Size = new System.Drawing.Size(47, 15);
            this.lblRegisterSiteCode.TabIndex = 2;
            this.lblRegisterSiteCode.Text = "Đại lý:";
            this.lblRegisterSiteCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbRegisterSiteCode
            // 
            this.cmbRegisterSiteCode.FormattingEnabled = true;
            this.cmbRegisterSiteCode.Location = new System.Drawing.Point(371, 49);
            this.cmbRegisterSiteCode.Name = "cmbRegisterSiteCode";
            this.cmbRegisterSiteCode.Size = new System.Drawing.Size(200, 21);
            this.cmbRegisterSiteCode.TabIndex = 3;
            // 
            // lblAcceptProvinceCode
            // 
            this.lblAcceptProvinceCode.AutoSize = true;
            this.lblAcceptProvinceCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcceptProvinceCode.ForeColor = System.Drawing.Color.White;
            this.lblAcceptProvinceCode.Location = new System.Drawing.Point(1144, 14);
            this.lblAcceptProvinceCode.Name = "lblAcceptProvinceCode";
            this.lblAcceptProvinceCode.Size = new System.Drawing.Size(75, 15);
            this.lblAcceptProvinceCode.TabIndex = 2;
            this.lblAcceptProvinceCode.Text = "Tỉnh nhận:";
            this.lblAcceptProvinceCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbAcceptProvinceCode
            // 
            this.cmbAcceptProvinceCode.FormattingEnabled = true;
            this.cmbAcceptProvinceCode.Location = new System.Drawing.Point(1225, 11);
            this.cmbAcceptProvinceCode.Name = "cmbAcceptProvinceCode";
            this.cmbAcceptProvinceCode.Size = new System.Drawing.Size(200, 21);
            this.cmbAcceptProvinceCode.TabIndex = 3;
            // 
            // dtpToRegisterDate
            // 
            this.dtpToRegisterDate.CustomFormat = "dd/MM/yyyy";
            this.dtpToRegisterDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToRegisterDate.Location = new System.Drawing.Point(1017, 49);
            this.dtpToRegisterDate.Name = "dtpToRegisterDate";
            this.dtpToRegisterDate.Size = new System.Drawing.Size(101, 20);
            this.dtpToRegisterDate.TabIndex = 4;
            // 
            // lblToRegisterDate
            // 
            this.lblToRegisterDate.AutoSize = true;
            this.lblToRegisterDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToRegisterDate.ForeColor = System.Drawing.Color.White;
            this.lblToRegisterDate.Location = new System.Drawing.Point(847, 52);
            this.lblToRegisterDate.Name = "lblToRegisterDate";
            this.lblToRegisterDate.Size = new System.Drawing.Size(71, 15);
            this.lblToRegisterDate.TabIndex = 5;
            this.lblToRegisterDate.Text = "Thời gian:";
            this.lblToRegisterDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFromRegisterDate
            // 
            this.dtpFromRegisterDate.CustomFormat = "dd/MM/yyyy";
            this.dtpFromRegisterDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromRegisterDate.Location = new System.Drawing.Point(918, 49);
            this.dtpFromRegisterDate.Name = "dtpFromRegisterDate";
            this.dtpFromRegisterDate.Size = new System.Drawing.Size(95, 20);
            this.dtpFromRegisterDate.TabIndex = 6;
            // 
            // lblFK_Customer
            // 
            this.lblFK_Customer.AutoSize = true;
            this.lblFK_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFK_Customer.ForeColor = System.Drawing.Color.White;
            this.lblFK_Customer.Location = new System.Drawing.Point(0, 52);
            this.lblFK_Customer.Name = "lblFK_Customer";
            this.lblFK_Customer.Size = new System.Drawing.Size(87, 15);
            this.lblFK_Customer.TabIndex = 2;
            this.lblFK_Customer.Text = "Khách hàng:";
            this.lblFK_Customer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbFK_Customer
            // 
            this.cmbFK_Customer.FormattingEnabled = true;
            this.cmbFK_Customer.Location = new System.Drawing.Point(87, 49);
            this.cmbFK_Customer.Name = "cmbFK_Customer";
            this.cmbFK_Customer.Size = new System.Drawing.Size(200, 21);
            this.cmbFK_Customer.TabIndex = 3;
            // 
            // lblFK_ProviderAccount
            // 
            this.lblFK_ProviderAccount.AutoSize = true;
            this.lblFK_ProviderAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFK_ProviderAccount.ForeColor = System.Drawing.Color.White;
            this.lblFK_ProviderAccount.Location = new System.Drawing.Point(590, 14);
            this.lblFK_ProviderAccount.Name = "lblFK_ProviderAccount";
            this.lblFK_ProviderAccount.Size = new System.Drawing.Size(56, 15);
            this.lblFK_ProviderAccount.TabIndex = 2;
            this.lblFK_ProviderAccount.Text = "Đối tác:";
            this.lblFK_ProviderAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbFK_ProviderAccount
            // 
            this.cmbFK_ProviderAccount.FormattingEnabled = true;
            this.cmbFK_ProviderAccount.Location = new System.Drawing.Point(647, 11);
            this.cmbFK_ProviderAccount.Name = "cmbFK_ProviderAccount";
            this.cmbFK_ProviderAccount.Size = new System.Drawing.Size(200, 21);
            this.cmbFK_ProviderAccount.TabIndex = 3;
            // 
            // lblBillStatus
            // 
            this.lblBillStatus.AutoSize = true;
            this.lblBillStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillStatus.ForeColor = System.Drawing.Color.White;
            this.lblBillStatus.Location = new System.Drawing.Point(570, 52);
            this.lblBillStatus.Name = "lblBillStatus";
            this.lblBillStatus.Size = new System.Drawing.Size(76, 15);
            this.lblBillStatus.TabIndex = 2;
            this.lblBillStatus.Text = "Tình trạng:";
            this.lblBillStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbBillStatus
            // 
            this.cmbBillStatus.FormattingEnabled = true;
            this.cmbBillStatus.Location = new System.Drawing.Point(647, 49);
            this.cmbBillStatus.Name = "cmbBillStatus";
            this.cmbBillStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbBillStatus.TabIndex = 3;
            // 
            // lblFK_PaymentType
            // 
            this.lblFK_PaymentType.AutoSize = true;
            this.lblFK_PaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFK_PaymentType.ForeColor = System.Drawing.Color.White;
            this.lblFK_PaymentType.Location = new System.Drawing.Point(859, 14);
            this.lblFK_PaymentType.Name = "lblFK_PaymentType";
            this.lblFK_PaymentType.Size = new System.Drawing.Size(59, 15);
            this.lblFK_PaymentType.TabIndex = 2;
            this.lblFK_PaymentType.Text = "Loại TT:";
            this.lblFK_PaymentType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbFK_PaymentType
            // 
            this.cmbFK_PaymentType.FormattingEnabled = true;
            this.cmbFK_PaymentType.Location = new System.Drawing.Point(918, 11);
            this.cmbFK_PaymentType.Name = "cmbFK_PaymentType";
            this.cmbFK_PaymentType.Size = new System.Drawing.Size(200, 21);
            this.cmbFK_PaymentType.TabIndex = 3;
            // 
            // btnFilter
            // 
            this.btnFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFilter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Image = global::LeMaiDesktop.Properties.Resources.iSearch;
            this.btnFilter.ImageTextSpacing = 3;
            this.btnFilter.Location = new System.Drawing.Point(1225, 44);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 30);
            this.btnFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFilter.TabIndex = 7;
            this.btnFilter.Text = "&Filter";
            this.btnFilter.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
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
            this.col_BillCode,
            this.col_BT3Code,
            this.col_BillWeight,
            this.col_FeeWeight,
            this.col_RegisterUser,
            this.col_RegisterSiteCode,
            this.col_Freight,
            this.col_COD,
            this.col_PayType,
            this.col_SendMan,
            this.col_SendManUs,
            this.col_SendManPhone,
            this.col_SendManAddress,
            this.col_AcceptProvinceCode,
            this.col_AcceptDistrictCode,
            this.col_AcceptWardCode,
            this.col_AcceptMan,
            this.col_AcceptManUs,
            this.col_AcceptManPhone,
            this.col_AcceptManAddress,
            this.col_AcceptProvince,
            this.col_AcceptDistrict,
            this.col_AcceptWard,
            this.col_IsSigned,
            this.col_IsReturn,
            this.col_BillProcessStatus,
            this.col_RegisterDate,
            this.col_SignedDate,
            this.col_LastUpdateDate,
            this.col_LastUpdateUser,
            this.col_Note,
            this.col_SystemDate,
            this.col_BT3Type,
            this.col_BT3CodeSub,
            this.col_BT3Status,
            this.col_BT3Freight,
            this.col_BT3COD,
            this.col_BT3PayType,
            this.col_BT3LastMess,
            this.col_GoodsName,
            this.col_GoodsNumber,
            this.col_GoodsCode,
            this.col_GoodsW,
            this.col_GoodsH,
            this.col_GoodsL,
            this.col_FK_Customer,
            this.col_FK_ProviderAccount,
            this.col_PayCustomerDate,
            this.col_IsPayCustomer,
            this.col_ShipperPhoneNumber,
            this.col_BillStatus,
            this.col_FK_PaymentType,
            this.col_FK_ShipType,
            this.col_FullAddress,
            this.col_ProviderName,
            this.col_ProviderTypeCode,
            this.col_GroupProvider,
            this.col_CustomerCode,
            this.col_PaymentTypeName,
            this.col_ShipNoteType,
            this.col_StatusName,
            this.col_StatusBackgroundColor,
            this.col_StatusTextColor,
            this.col_PrintLable,
            this.col_RunMode,
            this.col_Pickup,
            this.col_AddressPickup,
            this.col_ProvincePickup,
            this.col_DistricPickup,
            this.col_WardPickup,
            this.col_ShopIdPickup,
            this.col_PrintData});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataGrid.HighlightSelectedColumnHeaders = false;
            this.dataGrid.Location = new System.Drawing.Point(0, 90);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.PaintEnhancedSelection = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid.RowTemplate.Height = 25;
            this.dataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(1535, 458);
            this.dataGrid.TabIndex = 9;
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // col_BillCode
            // 
            this.col_BillCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_BillCode.DataPropertyName = "BillCode";
            this.col_BillCode.HeaderText = "Mã đơn";
            this.col_BillCode.Name = "col_BillCode";
            this.col_BillCode.ReadOnly = true;
            this.col_BillCode.Width = 120;
            // 
            // col_BT3Code
            // 
            this.col_BT3Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_BT3Code.DataPropertyName = "BT3Code";
            this.col_BT3Code.HeaderText = "BT3Code";
            this.col_BT3Code.Name = "col_BT3Code";
            this.col_BT3Code.ReadOnly = true;
            this.col_BT3Code.Width = 120;
            // 
            // col_BillWeight
            // 
            this.col_BillWeight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_BillWeight.DataPropertyName = "BillWeight";
            this.col_BillWeight.HeaderText = "BillWeight";
            this.col_BillWeight.Name = "col_BillWeight";
            this.col_BillWeight.ReadOnly = true;
            this.col_BillWeight.Width = 80;
            // 
            // col_FeeWeight
            // 
            this.col_FeeWeight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_FeeWeight.DataPropertyName = "FeeWeight";
            this.col_FeeWeight.HeaderText = "FeeWeight";
            this.col_FeeWeight.Name = "col_FeeWeight";
            this.col_FeeWeight.ReadOnly = true;
            this.col_FeeWeight.Width = 80;
            // 
            // col_RegisterUser
            // 
            this.col_RegisterUser.DataPropertyName = "RegisterUser";
            this.col_RegisterUser.HeaderText = "RegisterUser";
            this.col_RegisterUser.Name = "col_RegisterUser";
            this.col_RegisterUser.ReadOnly = true;
            this.col_RegisterUser.Visible = false;
            this.col_RegisterUser.Width = 24;
            // 
            // col_RegisterSiteCode
            // 
            this.col_RegisterSiteCode.DataPropertyName = "RegisterSiteCode";
            this.col_RegisterSiteCode.HeaderText = "RegisterSiteCode";
            this.col_RegisterSiteCode.Name = "col_RegisterSiteCode";
            this.col_RegisterSiteCode.ReadOnly = true;
            this.col_RegisterSiteCode.Visible = false;
            this.col_RegisterSiteCode.Width = 24;
            // 
            // col_Freight
            // 
            this.col_Freight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Freight.DataPropertyName = "Freight";
            this.col_Freight.HeaderText = "Freight";
            this.col_Freight.Name = "col_Freight";
            this.col_Freight.ReadOnly = true;
            this.col_Freight.Width = 120;
            // 
            // col_COD
            // 
            this.col_COD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_COD.DataPropertyName = "COD";
            this.col_COD.HeaderText = "COD";
            this.col_COD.Name = "col_COD";
            this.col_COD.ReadOnly = true;
            this.col_COD.Width = 120;
            // 
            // col_PayType
            // 
            this.col_PayType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_PayType.DataPropertyName = "PayType";
            this.col_PayType.HeaderText = "PayType";
            this.col_PayType.Name = "col_PayType";
            this.col_PayType.ReadOnly = true;
            this.col_PayType.Width = 120;
            // 
            // col_SendMan
            // 
            this.col_SendMan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_SendMan.DataPropertyName = "SendMan";
            this.col_SendMan.HeaderText = "SendMan";
            this.col_SendMan.Name = "col_SendMan";
            this.col_SendMan.ReadOnly = true;
            this.col_SendMan.Width = 120;
            // 
            // col_SendManUs
            // 
            this.col_SendManUs.DataPropertyName = "SendManUs";
            this.col_SendManUs.HeaderText = "SendManUs";
            this.col_SendManUs.Name = "col_SendManUs";
            this.col_SendManUs.ReadOnly = true;
            this.col_SendManUs.Visible = false;
            this.col_SendManUs.Width = 24;
            // 
            // col_SendManPhone
            // 
            this.col_SendManPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_SendManPhone.DataPropertyName = "SendManPhone";
            this.col_SendManPhone.HeaderText = "SendManPhone";
            this.col_SendManPhone.Name = "col_SendManPhone";
            this.col_SendManPhone.ReadOnly = true;
            // 
            // col_SendManAddress
            // 
            this.col_SendManAddress.DataPropertyName = "SendManAddress";
            this.col_SendManAddress.HeaderText = "SendManAddress";
            this.col_SendManAddress.Name = "col_SendManAddress";
            this.col_SendManAddress.ReadOnly = true;
            this.col_SendManAddress.Visible = false;
            this.col_SendManAddress.Width = 24;
            // 
            // col_AcceptProvinceCode
            // 
            this.col_AcceptProvinceCode.DataPropertyName = "AcceptProvinceCode";
            this.col_AcceptProvinceCode.HeaderText = "AcceptProvinceCode";
            this.col_AcceptProvinceCode.Name = "col_AcceptProvinceCode";
            this.col_AcceptProvinceCode.ReadOnly = true;
            this.col_AcceptProvinceCode.Visible = false;
            this.col_AcceptProvinceCode.Width = 24;
            // 
            // col_AcceptDistrictCode
            // 
            this.col_AcceptDistrictCode.DataPropertyName = "AcceptDistrictCode";
            this.col_AcceptDistrictCode.HeaderText = "AcceptDistrictCode";
            this.col_AcceptDistrictCode.Name = "col_AcceptDistrictCode";
            this.col_AcceptDistrictCode.ReadOnly = true;
            this.col_AcceptDistrictCode.Visible = false;
            this.col_AcceptDistrictCode.Width = 24;
            // 
            // col_AcceptWardCode
            // 
            this.col_AcceptWardCode.DataPropertyName = "AcceptWardCode";
            this.col_AcceptWardCode.HeaderText = "AcceptWardCode";
            this.col_AcceptWardCode.Name = "col_AcceptWardCode";
            this.col_AcceptWardCode.ReadOnly = true;
            this.col_AcceptWardCode.Visible = false;
            this.col_AcceptWardCode.Width = 24;
            // 
            // col_AcceptMan
            // 
            this.col_AcceptMan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_AcceptMan.DataPropertyName = "AcceptMan";
            this.col_AcceptMan.HeaderText = "AcceptMan";
            this.col_AcceptMan.Name = "col_AcceptMan";
            this.col_AcceptMan.ReadOnly = true;
            // 
            // col_AcceptManUs
            // 
            this.col_AcceptManUs.DataPropertyName = "AcceptManUs";
            this.col_AcceptManUs.HeaderText = "AcceptManUs";
            this.col_AcceptManUs.Name = "col_AcceptManUs";
            this.col_AcceptManUs.ReadOnly = true;
            this.col_AcceptManUs.Visible = false;
            this.col_AcceptManUs.Width = 24;
            // 
            // col_AcceptManPhone
            // 
            this.col_AcceptManPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_AcceptManPhone.DataPropertyName = "AcceptManPhone";
            this.col_AcceptManPhone.HeaderText = "AcceptManPhone";
            this.col_AcceptManPhone.Name = "col_AcceptManPhone";
            this.col_AcceptManPhone.ReadOnly = true;
            // 
            // col_AcceptManAddress
            // 
            this.col_AcceptManAddress.DataPropertyName = "AcceptManAddress";
            this.col_AcceptManAddress.HeaderText = "AcceptManAddress";
            this.col_AcceptManAddress.Name = "col_AcceptManAddress";
            this.col_AcceptManAddress.ReadOnly = true;
            this.col_AcceptManAddress.Visible = false;
            this.col_AcceptManAddress.Width = 24;
            // 
            // col_AcceptProvince
            // 
            this.col_AcceptProvince.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_AcceptProvince.DataPropertyName = "AcceptProvince";
            this.col_AcceptProvince.HeaderText = "AcceptProvince";
            this.col_AcceptProvince.Name = "col_AcceptProvince";
            this.col_AcceptProvince.ReadOnly = true;
            this.col_AcceptProvince.Width = 120;
            // 
            // col_AcceptDistrict
            // 
            this.col_AcceptDistrict.DataPropertyName = "AcceptDistrict";
            this.col_AcceptDistrict.HeaderText = "AcceptDistrict";
            this.col_AcceptDistrict.Name = "col_AcceptDistrict";
            this.col_AcceptDistrict.ReadOnly = true;
            this.col_AcceptDistrict.Visible = false;
            this.col_AcceptDistrict.Width = 24;
            // 
            // col_AcceptWard
            // 
            this.col_AcceptWard.DataPropertyName = "AcceptWard";
            this.col_AcceptWard.HeaderText = "AcceptWard";
            this.col_AcceptWard.Name = "col_AcceptWard";
            this.col_AcceptWard.ReadOnly = true;
            this.col_AcceptWard.Visible = false;
            this.col_AcceptWard.Width = 24;
            // 
            // col_IsSigned
            // 
            this.col_IsSigned.DataPropertyName = "IsSigned";
            this.col_IsSigned.HeaderText = "IsSigned";
            this.col_IsSigned.Name = "col_IsSigned";
            this.col_IsSigned.ReadOnly = true;
            this.col_IsSigned.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_IsSigned.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_IsSigned.Width = 50;
            // 
            // col_IsReturn
            // 
            this.col_IsReturn.DataPropertyName = "IsReturn";
            this.col_IsReturn.HeaderText = "IsReturn";
            this.col_IsReturn.Name = "col_IsReturn";
            this.col_IsReturn.ReadOnly = true;
            this.col_IsReturn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_IsReturn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_IsReturn.Width = 50;
            // 
            // col_BillProcessStatus
            // 
            this.col_BillProcessStatus.DataPropertyName = "BillProcessStatus";
            this.col_BillProcessStatus.HeaderText = "BillProcessStatus";
            this.col_BillProcessStatus.Name = "col_BillProcessStatus";
            this.col_BillProcessStatus.ReadOnly = true;
            this.col_BillProcessStatus.Visible = false;
            this.col_BillProcessStatus.Width = 23;
            // 
            // col_RegisterDate
            // 
            this.col_RegisterDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_RegisterDate.DataPropertyName = "RegisterDate";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            this.col_RegisterDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_RegisterDate.HeaderText = "RegisterDate";
            this.col_RegisterDate.Name = "col_RegisterDate";
            this.col_RegisterDate.ReadOnly = true;
            this.col_RegisterDate.Width = 120;
            // 
            // col_SignedDate
            // 
            this.col_SignedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_SignedDate.DataPropertyName = "SignedDate";
            this.col_SignedDate.HeaderText = "SignedDate";
            this.col_SignedDate.Name = "col_SignedDate";
            this.col_SignedDate.ReadOnly = true;
            this.col_SignedDate.Width = 120;
            // 
            // col_LastUpdateDate
            // 
            this.col_LastUpdateDate.DataPropertyName = "LastUpdateDate";
            this.col_LastUpdateDate.HeaderText = "LastUpdateDate";
            this.col_LastUpdateDate.Name = "col_LastUpdateDate";
            this.col_LastUpdateDate.ReadOnly = true;
            this.col_LastUpdateDate.Visible = false;
            this.col_LastUpdateDate.Width = 24;
            // 
            // col_LastUpdateUser
            // 
            this.col_LastUpdateUser.DataPropertyName = "LastUpdateUser";
            this.col_LastUpdateUser.HeaderText = "LastUpdateUser";
            this.col_LastUpdateUser.Name = "col_LastUpdateUser";
            this.col_LastUpdateUser.ReadOnly = true;
            this.col_LastUpdateUser.Visible = false;
            this.col_LastUpdateUser.Width = 24;
            // 
            // col_Note
            // 
            this.col_Note.DataPropertyName = "Note";
            this.col_Note.HeaderText = "Note";
            this.col_Note.Name = "col_Note";
            this.col_Note.ReadOnly = true;
            this.col_Note.Visible = false;
            this.col_Note.Width = 24;
            // 
            // col_SystemDate
            // 
            this.col_SystemDate.DataPropertyName = "SystemDate";
            this.col_SystemDate.HeaderText = "SystemDate";
            this.col_SystemDate.Name = "col_SystemDate";
            this.col_SystemDate.ReadOnly = true;
            this.col_SystemDate.Visible = false;
            this.col_SystemDate.Width = 24;
            // 
            // col_BT3Type
            // 
            this.col_BT3Type.DataPropertyName = "BT3Type";
            this.col_BT3Type.HeaderText = "BT3Type";
            this.col_BT3Type.Name = "col_BT3Type";
            this.col_BT3Type.ReadOnly = true;
            this.col_BT3Type.Visible = false;
            this.col_BT3Type.Width = 24;
            // 
            // col_BT3CodeSub
            // 
            this.col_BT3CodeSub.DataPropertyName = "BT3CodeSub";
            this.col_BT3CodeSub.HeaderText = "BT3CodeSub";
            this.col_BT3CodeSub.Name = "col_BT3CodeSub";
            this.col_BT3CodeSub.ReadOnly = true;
            this.col_BT3CodeSub.Visible = false;
            this.col_BT3CodeSub.Width = 18;
            // 
            // col_BT3Status
            // 
            this.col_BT3Status.DataPropertyName = "BT3Status";
            this.col_BT3Status.HeaderText = "BT3Status";
            this.col_BT3Status.Name = "col_BT3Status";
            this.col_BT3Status.ReadOnly = true;
            this.col_BT3Status.Visible = false;
            this.col_BT3Status.Width = 17;
            // 
            // col_BT3Freight
            // 
            this.col_BT3Freight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_BT3Freight.DataPropertyName = "BT3Freight";
            this.col_BT3Freight.HeaderText = "BT3Freight";
            this.col_BT3Freight.Name = "col_BT3Freight";
            this.col_BT3Freight.ReadOnly = true;
            // 
            // col_BT3COD
            // 
            this.col_BT3COD.DataPropertyName = "BT3COD";
            this.col_BT3COD.HeaderText = "BT3COD";
            this.col_BT3COD.Name = "col_BT3COD";
            this.col_BT3COD.ReadOnly = true;
            this.col_BT3COD.Visible = false;
            this.col_BT3COD.Width = 18;
            // 
            // col_BT3PayType
            // 
            this.col_BT3PayType.DataPropertyName = "BT3PayType";
            this.col_BT3PayType.HeaderText = "BT3PayType";
            this.col_BT3PayType.Name = "col_BT3PayType";
            this.col_BT3PayType.ReadOnly = true;
            this.col_BT3PayType.Visible = false;
            this.col_BT3PayType.Width = 17;
            // 
            // col_BT3LastMess
            // 
            this.col_BT3LastMess.DataPropertyName = "BT3LastMess";
            this.col_BT3LastMess.HeaderText = "BT3LastMess";
            this.col_BT3LastMess.Name = "col_BT3LastMess";
            this.col_BT3LastMess.ReadOnly = true;
            this.col_BT3LastMess.Visible = false;
            this.col_BT3LastMess.Width = 18;
            // 
            // col_GoodsName
            // 
            this.col_GoodsName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_GoodsName.DataPropertyName = "GoodsName";
            this.col_GoodsName.HeaderText = "GoodsName";
            this.col_GoodsName.Name = "col_GoodsName";
            this.col_GoodsName.ReadOnly = true;
            this.col_GoodsName.Width = 120;
            // 
            // col_GoodsNumber
            // 
            this.col_GoodsNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_GoodsNumber.DataPropertyName = "GoodsNumber";
            this.col_GoodsNumber.HeaderText = "GoodsNumber";
            this.col_GoodsNumber.Name = "col_GoodsNumber";
            this.col_GoodsNumber.ReadOnly = true;
            this.col_GoodsNumber.Width = 50;
            // 
            // col_GoodsCode
            // 
            this.col_GoodsCode.DataPropertyName = "GoodsCode";
            this.col_GoodsCode.HeaderText = "GoodsCode";
            this.col_GoodsCode.Name = "col_GoodsCode";
            this.col_GoodsCode.ReadOnly = true;
            this.col_GoodsCode.Visible = false;
            this.col_GoodsCode.Width = 18;
            // 
            // col_GoodsW
            // 
            this.col_GoodsW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_GoodsW.DataPropertyName = "GoodsW";
            this.col_GoodsW.HeaderText = "GoodsW";
            this.col_GoodsW.Name = "col_GoodsW";
            this.col_GoodsW.ReadOnly = true;
            this.col_GoodsW.Width = 50;
            // 
            // col_GoodsH
            // 
            this.col_GoodsH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_GoodsH.DataPropertyName = "GoodsH";
            this.col_GoodsH.HeaderText = "GoodsH";
            this.col_GoodsH.Name = "col_GoodsH";
            this.col_GoodsH.ReadOnly = true;
            this.col_GoodsH.Width = 50;
            // 
            // col_GoodsL
            // 
            this.col_GoodsL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_GoodsL.DataPropertyName = "GoodsL";
            this.col_GoodsL.HeaderText = "GoodsL";
            this.col_GoodsL.Name = "col_GoodsL";
            this.col_GoodsL.ReadOnly = true;
            this.col_GoodsL.Width = 50;
            // 
            // col_FK_Customer
            // 
            this.col_FK_Customer.DataPropertyName = "FK_Customer";
            this.col_FK_Customer.HeaderText = "FK_Customer";
            this.col_FK_Customer.Name = "col_FK_Customer";
            this.col_FK_Customer.ReadOnly = true;
            this.col_FK_Customer.Visible = false;
            this.col_FK_Customer.Width = 17;
            // 
            // col_FK_ProviderAccount
            // 
            this.col_FK_ProviderAccount.DataPropertyName = "FK_ProviderAccount";
            this.col_FK_ProviderAccount.HeaderText = "FK_ProviderAccount";
            this.col_FK_ProviderAccount.Name = "col_FK_ProviderAccount";
            this.col_FK_ProviderAccount.ReadOnly = true;
            this.col_FK_ProviderAccount.Visible = false;
            this.col_FK_ProviderAccount.Width = 18;
            // 
            // col_PayCustomerDate
            // 
            this.col_PayCustomerDate.DataPropertyName = "PayCustomerDate";
            this.col_PayCustomerDate.HeaderText = "PayCustomerDate";
            this.col_PayCustomerDate.Name = "col_PayCustomerDate";
            this.col_PayCustomerDate.ReadOnly = true;
            this.col_PayCustomerDate.Visible = false;
            this.col_PayCustomerDate.Width = 18;
            // 
            // col_IsPayCustomer
            // 
            this.col_IsPayCustomer.DataPropertyName = "IsPayCustomer";
            this.col_IsPayCustomer.HeaderText = "IsPayCustomer";
            this.col_IsPayCustomer.Name = "col_IsPayCustomer";
            this.col_IsPayCustomer.ReadOnly = true;
            this.col_IsPayCustomer.Visible = false;
            this.col_IsPayCustomer.Width = 17;
            // 
            // col_ShipperPhoneNumber
            // 
            this.col_ShipperPhoneNumber.DataPropertyName = "ShipperPhoneNumber";
            this.col_ShipperPhoneNumber.HeaderText = "ShipperPhoneNumber";
            this.col_ShipperPhoneNumber.Name = "col_ShipperPhoneNumber";
            this.col_ShipperPhoneNumber.ReadOnly = true;
            this.col_ShipperPhoneNumber.Visible = false;
            this.col_ShipperPhoneNumber.Width = 18;
            // 
            // col_BillStatus
            // 
            this.col_BillStatus.DataPropertyName = "BillStatus";
            this.col_BillStatus.HeaderText = "BillStatus";
            this.col_BillStatus.Name = "col_BillStatus";
            this.col_BillStatus.ReadOnly = true;
            this.col_BillStatus.Visible = false;
            this.col_BillStatus.Width = 18;
            // 
            // col_FK_PaymentType
            // 
            this.col_FK_PaymentType.DataPropertyName = "FK_PaymentType";
            this.col_FK_PaymentType.HeaderText = "FK_PaymentType";
            this.col_FK_PaymentType.Name = "col_FK_PaymentType";
            this.col_FK_PaymentType.ReadOnly = true;
            this.col_FK_PaymentType.Visible = false;
            this.col_FK_PaymentType.Width = 17;
            // 
            // col_FK_ShipType
            // 
            this.col_FK_ShipType.DataPropertyName = "FK_ShipType";
            this.col_FK_ShipType.HeaderText = "FK_ShipType";
            this.col_FK_ShipType.Name = "col_FK_ShipType";
            this.col_FK_ShipType.ReadOnly = true;
            this.col_FK_ShipType.Visible = false;
            this.col_FK_ShipType.Width = 24;
            // 
            // col_FullAddress
            // 
            this.col_FullAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_FullAddress.DataPropertyName = "FullAddress";
            this.col_FullAddress.HeaderText = "FullAddress";
            this.col_FullAddress.Name = "col_FullAddress";
            this.col_FullAddress.ReadOnly = true;
            this.col_FullAddress.Width = 250;
            // 
            // col_ProviderName
            // 
            this.col_ProviderName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_ProviderName.DataPropertyName = "ProviderName";
            this.col_ProviderName.HeaderText = "ProviderName";
            this.col_ProviderName.Name = "col_ProviderName";
            this.col_ProviderName.ReadOnly = true;
            // 
            // col_ProviderTypeCode
            // 
            this.col_ProviderTypeCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_ProviderTypeCode.DataPropertyName = "ProviderTypeCode";
            this.col_ProviderTypeCode.HeaderText = "ProviderTypeCode";
            this.col_ProviderTypeCode.Name = "col_ProviderTypeCode";
            this.col_ProviderTypeCode.ReadOnly = true;
            this.col_ProviderTypeCode.Width = 50;
            // 
            // col_GroupProvider
            // 
            this.col_GroupProvider.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_GroupProvider.DataPropertyName = "GroupProvider";
            this.col_GroupProvider.HeaderText = "GroupProvider";
            this.col_GroupProvider.Name = "col_GroupProvider";
            this.col_GroupProvider.ReadOnly = true;
            this.col_GroupProvider.Width = 17;
            // 
            // col_CustomerCode
            // 
            this.col_CustomerCode.DataPropertyName = "CustomerCode";
            this.col_CustomerCode.HeaderText = "CustomerCode";
            this.col_CustomerCode.Name = "col_CustomerCode";
            this.col_CustomerCode.ReadOnly = true;
            this.col_CustomerCode.Width = 18;
            // 
            // col_PaymentTypeName
            // 
            this.col_PaymentTypeName.DataPropertyName = "PaymentTypeName";
            this.col_PaymentTypeName.HeaderText = "PaymentTypeName";
            this.col_PaymentTypeName.Name = "col_PaymentTypeName";
            this.col_PaymentTypeName.ReadOnly = true;
            this.col_PaymentTypeName.Width = 18;
            // 
            // col_ShipNoteType
            // 
            this.col_ShipNoteType.DataPropertyName = "ShipNoteType";
            this.col_ShipNoteType.HeaderText = "ShipNoteType";
            this.col_ShipNoteType.Name = "col_ShipNoteType";
            this.col_ShipNoteType.ReadOnly = true;
            this.col_ShipNoteType.Width = 17;
            // 
            // col_StatusName
            // 
            this.col_StatusName.DataPropertyName = "StatusName";
            this.col_StatusName.HeaderText = "StatusName";
            this.col_StatusName.Name = "col_StatusName";
            this.col_StatusName.ReadOnly = true;
            this.col_StatusName.Width = 18;
            // 
            // col_StatusBackgroundColor
            // 
            this.col_StatusBackgroundColor.DataPropertyName = "StatusBackgroundColor";
            this.col_StatusBackgroundColor.HeaderText = "StatusBackgroundColor";
            this.col_StatusBackgroundColor.Name = "col_StatusBackgroundColor";
            this.col_StatusBackgroundColor.ReadOnly = true;
            this.col_StatusBackgroundColor.Visible = false;
            this.col_StatusBackgroundColor.Width = 24;
            // 
            // col_StatusTextColor
            // 
            this.col_StatusTextColor.DataPropertyName = "StatusTextColor";
            this.col_StatusTextColor.HeaderText = "StatusTextColor";
            this.col_StatusTextColor.Name = "col_StatusTextColor";
            this.col_StatusTextColor.ReadOnly = true;
            this.col_StatusTextColor.Visible = false;
            this.col_StatusTextColor.Width = 24;
            // 
            // col_PrintLable
            // 
            this.col_PrintLable.DataPropertyName = "PrintLable";
            this.col_PrintLable.HeaderText = "PrintLable";
            this.col_PrintLable.Name = "col_PrintLable";
            this.col_PrintLable.ReadOnly = true;
            this.col_PrintLable.Visible = false;
            this.col_PrintLable.Width = 24;
            // 
            // col_RunMode
            // 
            this.col_RunMode.DataPropertyName = "RunMode";
            this.col_RunMode.HeaderText = "RunMode";
            this.col_RunMode.Name = "col_RunMode";
            this.col_RunMode.ReadOnly = true;
            this.col_RunMode.Visible = false;
            this.col_RunMode.Width = 21;
            // 
            // col_Pickup
            // 
            this.col_Pickup.DataPropertyName = "Pickup";
            this.col_Pickup.HeaderText = "Pickup";
            this.col_Pickup.Name = "col_Pickup";
            this.col_Pickup.ReadOnly = true;
            this.col_Pickup.Visible = false;
            this.col_Pickup.Width = 21;
            // 
            // col_AddressPickup
            // 
            this.col_AddressPickup.DataPropertyName = "AddressPickup";
            this.col_AddressPickup.HeaderText = "AddressPickup";
            this.col_AddressPickup.Name = "col_AddressPickup";
            this.col_AddressPickup.ReadOnly = true;
            this.col_AddressPickup.Visible = false;
            this.col_AddressPickup.Width = 22;
            // 
            // col_ProvincePickup
            // 
            this.col_ProvincePickup.DataPropertyName = "ProvincePickup";
            this.col_ProvincePickup.HeaderText = "ProvincePickup";
            this.col_ProvincePickup.Name = "col_ProvincePickup";
            this.col_ProvincePickup.ReadOnly = true;
            this.col_ProvincePickup.Visible = false;
            this.col_ProvincePickup.Width = 21;
            // 
            // col_DistricPickup
            // 
            this.col_DistricPickup.DataPropertyName = "DistricPickup";
            this.col_DistricPickup.HeaderText = "DistricPickup";
            this.col_DistricPickup.Name = "col_DistricPickup";
            this.col_DistricPickup.ReadOnly = true;
            this.col_DistricPickup.Visible = false;
            this.col_DistricPickup.Width = 21;
            // 
            // col_WardPickup
            // 
            this.col_WardPickup.DataPropertyName = "WardPickup";
            this.col_WardPickup.HeaderText = "WardPickup";
            this.col_WardPickup.Name = "col_WardPickup";
            this.col_WardPickup.ReadOnly = true;
            this.col_WardPickup.Visible = false;
            this.col_WardPickup.Width = 21;
            // 
            // col_ShopIdPickup
            // 
            this.col_ShopIdPickup.DataPropertyName = "ShopIdPickup";
            this.col_ShopIdPickup.HeaderText = "ShopIdPickup";
            this.col_ShopIdPickup.Name = "col_ShopIdPickup";
            this.col_ShopIdPickup.ReadOnly = true;
            this.col_ShopIdPickup.Visible = false;
            this.col_ShopIdPickup.Width = 22;
            // 
            // col_PrintData
            // 
            this.col_PrintData.DataPropertyName = "PrintData";
            this.col_PrintData.HeaderText = "PrintData";
            this.col_PrintData.Name = "col_PrintData";
            this.col_PrintData.ReadOnly = true;
            this.col_PrintData.Visible = false;
            this.col_PrintData.Width = 21;
            // 
            // frmThongKeDoanhSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1535, 587);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelcomtrol);
            this.Name = "frmThongKeDoanhSo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongKeDoanhSo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmThongKeDoanhSo_Load);
            this.panelcomtrol.ResumeLayout(false);
            this.panelcomtrol.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblBillCode;
		private DevComponents.DotNetBar.Controls.TextBoxX txtBillCode;
		private System.Windows.Forms.Label lblRegisterUser;
		private System.Windows.Forms.ComboBox cmbRegisterUser;
		private System.Windows.Forms.Label lblRegisterSiteCode;
		private System.Windows.Forms.ComboBox cmbRegisterSiteCode;
		private System.Windows.Forms.Label lblAcceptProvinceCode;
		private System.Windows.Forms.ComboBox cmbAcceptProvinceCode;
		private System.Windows.Forms.DateTimePicker dtpFromRegisterDate;
		private System.Windows.Forms.Label lblToRegisterDate;
		private System.Windows.Forms.DateTimePicker dtpToRegisterDate;
		private System.Windows.Forms.Label lblFK_Customer;
		private System.Windows.Forms.ComboBox cmbFK_Customer;
		private System.Windows.Forms.Label lblFK_ProviderAccount;
		private System.Windows.Forms.ComboBox cmbFK_ProviderAccount;
		private System.Windows.Forms.Label lblBillStatus;
		private System.Windows.Forms.ComboBox cmbBillStatus;
		private System.Windows.Forms.Label lblFK_PaymentType;
		private System.Windows.Forms.ComboBox cmbFK_PaymentType;
		private System.Windows.Forms.Panel panelcomtrol;
		private DevComponents.DotNetBar.ButtonX btnClose;
		private System.Windows.Forms.Panel panel1;
		private DevComponents.DotNetBar.ButtonX btnExcel;
		private DevComponents.DotNetBar.ButtonX btnFilter;
		private DevComponents.DotNetBar.ButtonX btnPrint;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label lblCounter;
		private DevComponents.DotNetBar.Controls.DataGridViewX dataGrid;
		private DevComponents.DotNetBar.StyleManager styleManager;
		private DevComponents.DotNetBar.ButtonX btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BillCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BT3Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BillWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FeeWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RegisterUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RegisterSiteCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Freight;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_COD;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PayType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SendMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SendManUs;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SendManPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SendManAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AcceptProvinceCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AcceptDistrictCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AcceptWardCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AcceptMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AcceptManUs;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AcceptManPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AcceptManAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AcceptProvince;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AcceptDistrict;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AcceptWard;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_IsSigned;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_IsReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BillProcessStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RegisterDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SignedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LastUpdateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LastUpdateUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SystemDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BT3Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BT3CodeSub;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BT3Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BT3Freight;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BT3COD;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BT3PayType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BT3LastMess;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GoodsNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GoodsCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GoodsW;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GoodsH;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GoodsL;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_ProviderAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PayCustomerDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IsPayCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ShipperPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BillStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_PaymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_ShipType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FullAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProviderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProviderTypeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GroupProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CustomerCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PaymentTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ShipNoteType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_StatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_StatusBackgroundColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_StatusTextColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PrintLable;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RunMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Pickup;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AddressPickup;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProvincePickup;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DistricPickup;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_WardPickup;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ShopIdPickup;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PrintData;
    }
}
