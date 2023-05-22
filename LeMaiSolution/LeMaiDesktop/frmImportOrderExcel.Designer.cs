namespace LeMaiDesktop
{
    partial class frmImportOrderExcel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.lblWaitCount = new System.Windows.Forms.Label();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnKetToanC1 = new DevComponents.DotNetBar.ButtonX();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.gridBills = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txtKhachHangFilter = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbKhachHangFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.col_CustomerCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SendMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SendManPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AcceptMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AcceptManPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AcceptManAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FeeWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_RegisterSiteCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_COD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SendManUs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SendManAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SendProvince = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SendDistrict = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SendWard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AcceptManUs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AcceptProvince = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AcceptDistrict = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AcceptWard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IsSigned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IsReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BillProcessStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_RegisterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SignedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LastUpdateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LastUpdateUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SystemDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BT3Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BT3Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BT3Freight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BT3COD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BT3PayType = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.col_ProviderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_RegisterUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BT3LastMess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_StatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProviderTypeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBills)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.progressBar);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.lblWaitCount);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 687);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 39);
            this.panel2.TabIndex = 1387;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(52, 8);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1020, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 1283;
            this.progressBar.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::LeMaiDesktop.Properties.Resources.iSave;
            this.btnSave.ImageTextSpacing = 3;
            this.btnSave.Location = new System.Drawing.Point(1078, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 30);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 1282;
            this.btnSave.Text = "Nạp đơn";
            this.btnSave.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblWaitCount
            // 
            this.lblWaitCount.AutoSize = true;
            this.lblWaitCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaitCount.ForeColor = System.Drawing.Color.White;
            this.lblWaitCount.Location = new System.Drawing.Point(5, 9);
            this.lblWaitCount.Name = "lblWaitCount";
            this.lblWaitCount.Size = new System.Drawing.Size(19, 20);
            this.lblWaitCount.TabIndex = 77;
            this.lblWaitCount.Text = "0";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::LeMaiDesktop.Properties.Resources.iExit;
            this.btnClose.ImageTextSpacing = 3;
            this.btnClose.Location = new System.Drawing.Point(1172, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 30);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "&Kết thúc";
            this.btnClose.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnKetToanC1
            // 
            this.btnKetToanC1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnKetToanC1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKetToanC1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnKetToanC1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetToanC1.ImageTextSpacing = 3;
            this.btnKetToanC1.Location = new System.Drawing.Point(1197, 10);
            this.btnKetToanC1.Name = "btnKetToanC1";
            this.btnKetToanC1.Size = new System.Drawing.Size(63, 25);
            this.btnKetToanC1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnKetToanC1.TabIndex = 1390;
            this.btnKetToanC1.Text = ":::";
            this.btnKetToanC1.Click += new System.EventHandler(this.btnKetToanC1_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(535, 12);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(656, 21);
            this.txtFileName.TabIndex = 1389;
            // 
            // gridBills
            // 
            this.gridBills.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.gridBills.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridBills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridBills.ColumnHeadersHeight = 25;
            this.gridBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_CustomerCode,
            this.col_SendMan,
            this.col_SendManPhone,
            this.col_AcceptMan,
            this.col_AcceptManPhone,
            this.col_AcceptManAddress,
            this.col_FeeWeight,
            this.col_RegisterSiteCode,
            this.col_COD,
            this.col_SendManUs,
            this.col_SendManAddress,
            this.col_SendProvince,
            this.col_SendDistrict,
            this.col_SendWard,
            this.col_AcceptManUs,
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
            this.col_BT3Status,
            this.col_BT3Freight,
            this.col_BT3COD,
            this.col_BT3PayType,
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
            this.col_ProviderName,
            this.col_RegisterUser,
            this.col_BT3LastMess,
            this.col_StatusName,
            this.col_ProviderTypeCode});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridBills.DefaultCellStyle = dataGridViewCellStyle12;
            this.gridBills.EnableHeadersVisualStyles = false;
            this.gridBills.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.gridBills.HighlightSelectedColumnHeaders = false;
            this.gridBills.Location = new System.Drawing.Point(0, 41);
            this.gridBills.MultiSelect = false;
            this.gridBills.Name = "gridBills";
            this.gridBills.PaintEnhancedSelection = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBills.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.gridBills.RowHeadersVisible = false;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            this.gridBills.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.gridBills.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBills.RowTemplate.Height = 25;
            this.gridBills.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridBills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBills.Size = new System.Drawing.Size(1260, 640);
            this.gridBills.TabIndex = 1391;
            // 
            // txtKhachHangFilter
            // 
            // 
            // 
            // 
            this.txtKhachHangFilter.Border.Class = "TextBoxBorder";
            this.txtKhachHangFilter.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtKhachHangFilter.Location = new System.Drawing.Point(85, 12);
            this.txtKhachHangFilter.Name = "txtKhachHangFilter";
            this.txtKhachHangFilter.Size = new System.Drawing.Size(69, 20);
            this.txtKhachHangFilter.TabIndex = 1394;
            this.txtKhachHangFilter.TextChanged += new System.EventHandler(this.txtKhachHangFilter_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(8, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 15);
            this.label10.TabIndex = 1393;
            this.label10.Text = "Khách hàng:";
            // 
            // cmbKhachHangFilter
            // 
            this.cmbKhachHangFilter.FormattingEnabled = true;
            this.cmbKhachHangFilter.Location = new System.Drawing.Point(156, 12);
            this.cmbKhachHangFilter.Name = "cmbKhachHangFilter";
            this.cmbKhachHangFilter.Size = new System.Drawing.Size(298, 21);
            this.cmbKhachHangFilter.TabIndex = 1392;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(460, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 1395;
            this.label1.Text = "Danh sách:";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // col_CustomerCode
            // 
            this.col_CustomerCode.DataPropertyName = "CustomerCode";
            this.col_CustomerCode.HeaderText = "Mã khách hàng";
            this.col_CustomerCode.Name = "col_CustomerCode";
            this.col_CustomerCode.ReadOnly = true;
            // 
            // col_SendMan
            // 
            this.col_SendMan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_SendMan.DataPropertyName = "SendMan";
            this.col_SendMan.HeaderText = "Người gửi";
            this.col_SendMan.Name = "col_SendMan";
            this.col_SendMan.ReadOnly = true;
            this.col_SendMan.Width = 160;
            // 
            // col_SendManPhone
            // 
            this.col_SendManPhone.DataPropertyName = "SendManPhone";
            this.col_SendManPhone.HeaderText = "SĐT Gửi";
            this.col_SendManPhone.Name = "col_SendManPhone";
            this.col_SendManPhone.ReadOnly = true;
            // 
            // col_AcceptMan
            // 
            this.col_AcceptMan.DataPropertyName = "AcceptMan";
            this.col_AcceptMan.HeaderText = "Người nhận";
            this.col_AcceptMan.Name = "col_AcceptMan";
            this.col_AcceptMan.ReadOnly = true;
            // 
            // col_AcceptManPhone
            // 
            this.col_AcceptManPhone.DataPropertyName = "AcceptManPhone";
            this.col_AcceptManPhone.HeaderText = "SĐT Nhận";
            this.col_AcceptManPhone.Name = "col_AcceptManPhone";
            this.col_AcceptManPhone.ReadOnly = true;
            // 
            // col_AcceptManAddress
            // 
            this.col_AcceptManAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_AcceptManAddress.DataPropertyName = "FullAddress";
            this.col_AcceptManAddress.HeaderText = "Địa chỉ nhận";
            this.col_AcceptManAddress.Name = "col_AcceptManAddress";
            this.col_AcceptManAddress.ReadOnly = true;
            this.col_AcceptManAddress.Width = 300;
            // 
            // col_FeeWeight
            // 
            this.col_FeeWeight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_FeeWeight.DataPropertyName = "FeeWeight";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            this.col_FeeWeight.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_FeeWeight.HeaderText = "TL KH";
            this.col_FeeWeight.Name = "col_FeeWeight";
            this.col_FeeWeight.ReadOnly = true;
            this.col_FeeWeight.Width = 60;
            // 
            // col_RegisterSiteCode
            // 
            this.col_RegisterSiteCode.DataPropertyName = "RegisterSiteCode";
            this.col_RegisterSiteCode.HeaderText = "RegisterSiteCode";
            this.col_RegisterSiteCode.Name = "col_RegisterSiteCode";
            this.col_RegisterSiteCode.ReadOnly = true;
            this.col_RegisterSiteCode.Visible = false;
            // 
            // col_COD
            // 
            this.col_COD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_COD.DataPropertyName = "COD";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            this.col_COD.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_COD.HeaderText = "Thu hộ";
            this.col_COD.Name = "col_COD";
            this.col_COD.ReadOnly = true;
            // 
            // col_SendManUs
            // 
            this.col_SendManUs.DataPropertyName = "SendManUs";
            this.col_SendManUs.HeaderText = "SendManUs";
            this.col_SendManUs.Name = "col_SendManUs";
            this.col_SendManUs.ReadOnly = true;
            this.col_SendManUs.Visible = false;
            // 
            // col_SendManAddress
            // 
            this.col_SendManAddress.DataPropertyName = "SendManAddress";
            this.col_SendManAddress.HeaderText = "Địa chỉ người gửi";
            this.col_SendManAddress.Name = "col_SendManAddress";
            this.col_SendManAddress.ReadOnly = true;
            this.col_SendManAddress.Visible = false;
            // 
            // col_SendProvince
            // 
            this.col_SendProvince.DataPropertyName = "AcceptProvinceCode";
            this.col_SendProvince.HeaderText = "AcceptProvinceCode";
            this.col_SendProvince.Name = "col_SendProvince";
            this.col_SendProvince.ReadOnly = true;
            this.col_SendProvince.Visible = false;
            // 
            // col_SendDistrict
            // 
            this.col_SendDistrict.DataPropertyName = "AcceptDistrictCode";
            this.col_SendDistrict.HeaderText = "AcceptDistrictCode";
            this.col_SendDistrict.Name = "col_SendDistrict";
            this.col_SendDistrict.ReadOnly = true;
            this.col_SendDistrict.Visible = false;
            // 
            // col_SendWard
            // 
            this.col_SendWard.DataPropertyName = "AcceptWardCode";
            this.col_SendWard.HeaderText = "AcceptWardCode";
            this.col_SendWard.Name = "col_SendWard";
            this.col_SendWard.ReadOnly = true;
            this.col_SendWard.Visible = false;
            // 
            // col_AcceptManUs
            // 
            this.col_AcceptManUs.DataPropertyName = "AcceptManUs";
            this.col_AcceptManUs.HeaderText = "AcceptManUs";
            this.col_AcceptManUs.Name = "col_AcceptManUs";
            this.col_AcceptManUs.ReadOnly = true;
            this.col_AcceptManUs.Visible = false;
            // 
            // col_AcceptProvince
            // 
            this.col_AcceptProvince.DataPropertyName = "AcceptProvince";
            this.col_AcceptProvince.HeaderText = "Tỉnh nhận";
            this.col_AcceptProvince.Name = "col_AcceptProvince";
            this.col_AcceptProvince.ReadOnly = true;
            // 
            // col_AcceptDistrict
            // 
            this.col_AcceptDistrict.DataPropertyName = "AcceptDistrict";
            this.col_AcceptDistrict.HeaderText = "Huyện nhận";
            this.col_AcceptDistrict.Name = "col_AcceptDistrict";
            this.col_AcceptDistrict.ReadOnly = true;
            this.col_AcceptDistrict.Visible = false;
            // 
            // col_AcceptWard
            // 
            this.col_AcceptWard.DataPropertyName = "AcceptWard";
            this.col_AcceptWard.HeaderText = "Xã nhận";
            this.col_AcceptWard.Name = "col_AcceptWard";
            this.col_AcceptWard.ReadOnly = true;
            this.col_AcceptWard.Visible = false;
            // 
            // col_IsSigned
            // 
            this.col_IsSigned.DataPropertyName = "IsSigned";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_IsSigned.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_IsSigned.HeaderText = "IsSigned";
            this.col_IsSigned.Name = "col_IsSigned";
            this.col_IsSigned.ReadOnly = true;
            this.col_IsSigned.Visible = false;
            // 
            // col_IsReturn
            // 
            this.col_IsReturn.DataPropertyName = "IsReturn";
            this.col_IsReturn.HeaderText = "IsReturn";
            this.col_IsReturn.Name = "col_IsReturn";
            this.col_IsReturn.ReadOnly = true;
            this.col_IsReturn.Visible = false;
            // 
            // col_BillProcessStatus
            // 
            this.col_BillProcessStatus.DataPropertyName = "BillProcessStatus";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            this.col_BillProcessStatus.DefaultCellStyle = dataGridViewCellStyle6;
            this.col_BillProcessStatus.HeaderText = "BillProcessStatus";
            this.col_BillProcessStatus.Name = "col_BillProcessStatus";
            this.col_BillProcessStatus.ReadOnly = true;
            this.col_BillProcessStatus.Visible = false;
            // 
            // col_RegisterDate
            // 
            this.col_RegisterDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_RegisterDate.DataPropertyName = "RegisterDate";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Format = "dd/MM HH:mm";
            this.col_RegisterDate.DefaultCellStyle = dataGridViewCellStyle7;
            this.col_RegisterDate.HeaderText = "Ngày tạo";
            this.col_RegisterDate.Name = "col_RegisterDate";
            this.col_RegisterDate.ReadOnly = true;
            this.col_RegisterDate.Width = 80;
            // 
            // col_SignedDate
            // 
            this.col_SignedDate.DataPropertyName = "SignedDate";
            this.col_SignedDate.HeaderText = "SignedDate";
            this.col_SignedDate.Name = "col_SignedDate";
            this.col_SignedDate.ReadOnly = true;
            this.col_SignedDate.Visible = false;
            // 
            // col_LastUpdateDate
            // 
            this.col_LastUpdateDate.DataPropertyName = "LastUpdateDate";
            this.col_LastUpdateDate.HeaderText = "LastUpdateDate";
            this.col_LastUpdateDate.Name = "col_LastUpdateDate";
            this.col_LastUpdateDate.ReadOnly = true;
            this.col_LastUpdateDate.Visible = false;
            // 
            // col_LastUpdateUser
            // 
            this.col_LastUpdateUser.DataPropertyName = "LastUpdateUser";
            this.col_LastUpdateUser.HeaderText = "LastUpdateUser";
            this.col_LastUpdateUser.Name = "col_LastUpdateUser";
            this.col_LastUpdateUser.ReadOnly = true;
            this.col_LastUpdateUser.Visible = false;
            // 
            // col_Note
            // 
            this.col_Note.DataPropertyName = "Note";
            this.col_Note.HeaderText = "Ghi chú";
            this.col_Note.Name = "col_Note";
            this.col_Note.ReadOnly = true;
            // 
            // col_SystemDate
            // 
            this.col_SystemDate.DataPropertyName = "SystemDate";
            this.col_SystemDate.HeaderText = "SystemDate";
            this.col_SystemDate.Name = "col_SystemDate";
            this.col_SystemDate.ReadOnly = true;
            this.col_SystemDate.Visible = false;
            // 
            // col_BT3Type
            // 
            this.col_BT3Type.DataPropertyName = "BT3Type";
            this.col_BT3Type.HeaderText = "BT3Type";
            this.col_BT3Type.Name = "col_BT3Type";
            this.col_BT3Type.ReadOnly = true;
            this.col_BT3Type.Visible = false;
            // 
            // col_BT3Status
            // 
            this.col_BT3Status.DataPropertyName = "BT3Status";
            this.col_BT3Status.HeaderText = "BT3Status";
            this.col_BT3Status.Name = "col_BT3Status";
            this.col_BT3Status.ReadOnly = true;
            this.col_BT3Status.Visible = false;
            // 
            // col_BT3Freight
            // 
            this.col_BT3Freight.DataPropertyName = "BT3Freight";
            this.col_BT3Freight.HeaderText = "BT3Freight";
            this.col_BT3Freight.Name = "col_BT3Freight";
            this.col_BT3Freight.ReadOnly = true;
            this.col_BT3Freight.Visible = false;
            // 
            // col_BT3COD
            // 
            this.col_BT3COD.DataPropertyName = "BT3COD";
            this.col_BT3COD.HeaderText = "BT3COD";
            this.col_BT3COD.Name = "col_BT3COD";
            this.col_BT3COD.ReadOnly = true;
            this.col_BT3COD.Visible = false;
            // 
            // col_BT3PayType
            // 
            this.col_BT3PayType.DataPropertyName = "BT3PayType";
            this.col_BT3PayType.HeaderText = "BT3PayType";
            this.col_BT3PayType.Name = "col_BT3PayType";
            this.col_BT3PayType.ReadOnly = true;
            this.col_BT3PayType.Visible = false;
            // 
            // col_GoodsName
            // 
            this.col_GoodsName.DataPropertyName = "GoodsName";
            this.col_GoodsName.HeaderText = "Tên hàng";
            this.col_GoodsName.Name = "col_GoodsName";
            this.col_GoodsName.ReadOnly = true;
            // 
            // col_GoodsNumber
            // 
            this.col_GoodsNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_GoodsNumber.DataPropertyName = "GoodsNumber";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_GoodsNumber.DefaultCellStyle = dataGridViewCellStyle8;
            this.col_GoodsNumber.HeaderText = "SL";
            this.col_GoodsNumber.Name = "col_GoodsNumber";
            this.col_GoodsNumber.ReadOnly = true;
            this.col_GoodsNumber.Width = 35;
            // 
            // col_GoodsCode
            // 
            this.col_GoodsCode.DataPropertyName = "GoodsCode";
            this.col_GoodsCode.HeaderText = "GoodsCode";
            this.col_GoodsCode.Name = "col_GoodsCode";
            this.col_GoodsCode.ReadOnly = true;
            this.col_GoodsCode.Visible = false;
            // 
            // col_GoodsW
            // 
            this.col_GoodsW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_GoodsW.DataPropertyName = "GoodsW";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_GoodsW.DefaultCellStyle = dataGridViewCellStyle9;
            this.col_GoodsW.HeaderText = "W";
            this.col_GoodsW.Name = "col_GoodsW";
            this.col_GoodsW.ReadOnly = true;
            this.col_GoodsW.Width = 40;
            // 
            // col_GoodsH
            // 
            this.col_GoodsH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_GoodsH.DataPropertyName = "GoodsH";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_GoodsH.DefaultCellStyle = dataGridViewCellStyle10;
            this.col_GoodsH.HeaderText = "H";
            this.col_GoodsH.Name = "col_GoodsH";
            this.col_GoodsH.ReadOnly = true;
            this.col_GoodsH.Width = 40;
            // 
            // col_GoodsL
            // 
            this.col_GoodsL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_GoodsL.DataPropertyName = "GoodsL";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_GoodsL.DefaultCellStyle = dataGridViewCellStyle11;
            this.col_GoodsL.HeaderText = "L";
            this.col_GoodsL.Name = "col_GoodsL";
            this.col_GoodsL.ReadOnly = true;
            this.col_GoodsL.Width = 40;
            // 
            // col_FK_Customer
            // 
            this.col_FK_Customer.DataPropertyName = "FK_Customer";
            this.col_FK_Customer.HeaderText = "FK_Customer";
            this.col_FK_Customer.Name = "col_FK_Customer";
            this.col_FK_Customer.ReadOnly = true;
            this.col_FK_Customer.Visible = false;
            // 
            // col_FK_ProviderAccount
            // 
            this.col_FK_ProviderAccount.DataPropertyName = "FK_ProviderAccount";
            this.col_FK_ProviderAccount.HeaderText = "FK_ProviderAccount";
            this.col_FK_ProviderAccount.Name = "col_FK_ProviderAccount";
            this.col_FK_ProviderAccount.ReadOnly = true;
            this.col_FK_ProviderAccount.Visible = false;
            // 
            // col_PayCustomerDate
            // 
            this.col_PayCustomerDate.DataPropertyName = "PayCustomerDate";
            this.col_PayCustomerDate.HeaderText = "PayCustomerDate";
            this.col_PayCustomerDate.Name = "col_PayCustomerDate";
            this.col_PayCustomerDate.ReadOnly = true;
            this.col_PayCustomerDate.Visible = false;
            // 
            // col_IsPayCustomer
            // 
            this.col_IsPayCustomer.DataPropertyName = "IsPayCustomer";
            this.col_IsPayCustomer.HeaderText = "IsPayCustomer";
            this.col_IsPayCustomer.Name = "col_IsPayCustomer";
            this.col_IsPayCustomer.ReadOnly = true;
            this.col_IsPayCustomer.Visible = false;
            // 
            // col_ShipperPhoneNumber
            // 
            this.col_ShipperPhoneNumber.DataPropertyName = "ShipperPhoneNumber";
            this.col_ShipperPhoneNumber.HeaderText = "ShipperPhoneNumber";
            this.col_ShipperPhoneNumber.Name = "col_ShipperPhoneNumber";
            this.col_ShipperPhoneNumber.ReadOnly = true;
            this.col_ShipperPhoneNumber.Visible = false;
            // 
            // col_BillStatus
            // 
            this.col_BillStatus.DataPropertyName = "BillStatus";
            this.col_BillStatus.HeaderText = "BillStatus";
            this.col_BillStatus.Name = "col_BillStatus";
            this.col_BillStatus.ReadOnly = true;
            this.col_BillStatus.Visible = false;
            // 
            // col_ProviderName
            // 
            this.col_ProviderName.DataPropertyName = "ProviderName";
            this.col_ProviderName.HeaderText = "Loại kiện";
            this.col_ProviderName.Name = "col_ProviderName";
            this.col_ProviderName.ReadOnly = true;
            // 
            // col_RegisterUser
            // 
            this.col_RegisterUser.DataPropertyName = "RegisterUser";
            this.col_RegisterUser.HeaderText = "NV Tạo";
            this.col_RegisterUser.Name = "col_RegisterUser";
            this.col_RegisterUser.ReadOnly = true;
            // 
            // col_BT3LastMess
            // 
            this.col_BT3LastMess.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_BT3LastMess.DataPropertyName = "BT3LastMess";
            this.col_BT3LastMess.HeaderText = "BT3 Mess";
            this.col_BT3LastMess.Name = "col_BT3LastMess";
            this.col_BT3LastMess.ReadOnly = true;
            this.col_BT3LastMess.Width = 120;
            // 
            // col_StatusName
            // 
            this.col_StatusName.DataPropertyName = "StatusName";
            this.col_StatusName.HeaderText = "Tình trạng";
            this.col_StatusName.Name = "col_StatusName";
            this.col_StatusName.ReadOnly = true;
            // 
            // col_ProviderTypeCode
            // 
            this.col_ProviderTypeCode.DataPropertyName = "ProviderTypeCode";
            this.col_ProviderTypeCode.HeaderText = "ProviderTypeCode";
            this.col_ProviderTypeCode.Name = "col_ProviderTypeCode";
            this.col_ProviderTypeCode.ReadOnly = true;
            this.col_ProviderTypeCode.Visible = false;
            // 
            // frmImportOrderExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 726);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKhachHangFilter);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbKhachHangFilter);
            this.Controls.Add(this.gridBills);
            this.Controls.Add(this.btnKetToanC1);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.panel2);
            this.Name = "frmImportOrderExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập đơn từ file excel";
            this.Load += new System.EventHandler(this.frmImportOrderExcel_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar progressBar;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private System.Windows.Forms.Label lblWaitCount;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnKetToanC1;
        private System.Windows.Forms.TextBox txtFileName;
        private DevComponents.DotNetBar.Controls.DataGridViewX gridBills;
        private DevComponents.DotNetBar.Controls.TextBoxX txtKhachHangFilter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbKhachHangFilter;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CustomerCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SendMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SendManPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AcceptMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AcceptManPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AcceptManAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FeeWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RegisterSiteCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_COD;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SendManUs;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SendManAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SendProvince;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SendDistrict;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SendWard;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AcceptManUs;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AcceptProvince;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AcceptDistrict;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AcceptWard;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IsSigned;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IsReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BillProcessStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RegisterDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SignedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LastUpdateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LastUpdateUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SystemDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BT3Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BT3Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BT3Freight;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BT3COD;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BT3PayType;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProviderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RegisterUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BT3LastMess;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_StatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProviderTypeCode;
    }
}