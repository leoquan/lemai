namespace LeMaiDesktop
{
    partial class frmOrderCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelcomtrol = new System.Windows.Forms.Panel();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.txtKhachHangFilter = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbKhachHangFilter = new System.Windows.Forms.ComboBox();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFilter = new DevComponents.DotNetBar.ButtonX();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.gridMain = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_OrderCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CustomerCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CustomerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AcceptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AcceptPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AcceptAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_COD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IsShopPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FK_CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_StatusOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PickupUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PickupDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TransferCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_StatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_StatusTextColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_StatusBackgroundColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FK_Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblWaitCount = new System.Windows.Forms.Label();
            this.panelcomtrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panelcomtrol
            // 
            this.panelcomtrol.BackColor = System.Drawing.Color.SteelBlue;
            this.panelcomtrol.Controls.Add(this.lblWaitCount);
            this.panelcomtrol.Controls.Add(this.btnClose);
            this.panelcomtrol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelcomtrol.Location = new System.Drawing.Point(0, 496);
            this.panelcomtrol.Name = "panelcomtrol";
            this.panelcomtrol.Size = new System.Drawing.Size(970, 39);
            this.panelcomtrol.TabIndex = 13;
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::LeMaiDesktop.Properties.Resources.iExit;
            this.btnClose.ImageTextSpacing = 3;
            this.btnClose.Location = new System.Drawing.Point(871, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 30);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "&Kết thúc";
            this.btnClose.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtKhachHangFilter
            // 
            // 
            // 
            // 
            this.txtKhachHangFilter.Border.Class = "TextBoxBorder";
            this.txtKhachHangFilter.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtKhachHangFilter.Location = new System.Drawing.Point(394, 12);
            this.txtKhachHangFilter.Name = "txtKhachHangFilter";
            this.txtKhachHangFilter.Size = new System.Drawing.Size(69, 20);
            this.txtKhachHangFilter.TabIndex = 1195;
            this.txtKhachHangFilter.TextChanged += new System.EventHandler(this.txtKhachHangFilter_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(10, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 1190;
            this.label4.Text = "Từ ngày:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(317, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 15);
            this.label10.TabIndex = 1194;
            this.label10.Text = "Khách hàng:";
            // 
            // cmbKhachHangFilter
            // 
            this.cmbKhachHangFilter.FormattingEnabled = true;
            this.cmbKhachHangFilter.Location = new System.Drawing.Point(465, 12);
            this.cmbKhachHangFilter.Name = "cmbKhachHangFilter";
            this.cmbKhachHangFilter.Size = new System.Drawing.Size(298, 21);
            this.cmbKhachHangFilter.TabIndex = 1193;
            // 
            // dateTo
            // 
            this.dateTo.CustomFormat = "dd/MM/yyyy";
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTo.Location = new System.Drawing.Point(218, 12);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(95, 20);
            this.dateTo.TabIndex = 1191;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(162, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 1192;
            this.label7.Text = "đến ngày";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFilter
            // 
            this.btnFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFilter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFilter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Image = global::LeMaiDesktop.Properties.Resources.iSearch;
            this.btnFilter.ImageTextSpacing = 3;
            this.btnFilter.Location = new System.Drawing.Point(770, 10);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(86, 25);
            this.btnFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFilter.TabIndex = 1189;
            this.btnFilter.Text = "Truy vấn";
            this.btnFilter.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dateFrom
            // 
            this.dateFrom.CustomFormat = "dd/MM/yyyy";
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFrom.Location = new System.Drawing.Point(64, 12);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(95, 20);
            this.dateFrom.TabIndex = 1188;
            // 
            // gridMain
            // 
            this.gridMain.AllowUserToAddRows = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.gridMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.gridMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.gridMain.ColumnHeadersHeight = 25;
            this.gridMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Id,
            this.col_OrderCode,
            this.col_CustomerCode,
            this.col_CustomerName,
            this.col_CustomerPhone,
            this.col_AcceptName,
            this.col_AcceptPhone,
            this.col_AcceptAddress,
            this.col_GoodsName,
            this.col_COD,
            this.col_Weight,
            this.col_IsShopPay,
            this.col_Note,
            this.col_CreateDate,
            this.col_FK_CustomerId,
            this.col_StatusOrder,
            this.col_PickupUser,
            this.col_PickupDate,
            this.col_TransferCode,
            this.col_StatusName,
            this.col_StatusTextColor,
            this.col_StatusBackgroundColor,
            this.col_FK_Post});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMain.DefaultCellStyle = dataGridViewCellStyle20;
            this.gridMain.EnableHeadersVisualStyles = false;
            this.gridMain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.gridMain.HighlightSelectedColumnHeaders = false;
            this.gridMain.Location = new System.Drawing.Point(0, 41);
            this.gridMain.MultiSelect = false;
            this.gridMain.Name = "gridMain";
            this.gridMain.PaintEnhancedSelection = false;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.gridMain.RowHeadersVisible = false;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.White;
            this.gridMain.RowsDefaultCellStyle = dataGridViewCellStyle22;
            this.gridMain.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridMain.RowTemplate.Height = 25;
            this.gridMain.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMain.Size = new System.Drawing.Size(970, 454);
            this.gridMain.TabIndex = 1196;
            this.gridMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMain_CellDoubleClick);
            // 
            // col_Id
            // 
            this.col_Id.DataPropertyName = "Id";
            this.col_Id.HeaderText = "Id";
            this.col_Id.Name = "col_Id";
            this.col_Id.ReadOnly = true;
            this.col_Id.Visible = false;
            // 
            // col_OrderCode
            // 
            this.col_OrderCode.DataPropertyName = "OrderCode";
            this.col_OrderCode.HeaderText = "Mã đặt hàng";
            this.col_OrderCode.Name = "col_OrderCode";
            this.col_OrderCode.ReadOnly = true;
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
            this.col_CustomerName.HeaderText = "Tên KH";
            this.col_CustomerName.Name = "col_CustomerName";
            this.col_CustomerName.ReadOnly = true;
            // 
            // col_CustomerPhone
            // 
            this.col_CustomerPhone.DataPropertyName = "CustomerPhone";
            this.col_CustomerPhone.HeaderText = "SĐT Gửi";
            this.col_CustomerPhone.Name = "col_CustomerPhone";
            this.col_CustomerPhone.ReadOnly = true;
            // 
            // col_AcceptName
            // 
            this.col_AcceptName.DataPropertyName = "AcceptName";
            this.col_AcceptName.HeaderText = "Người nhận";
            this.col_AcceptName.Name = "col_AcceptName";
            this.col_AcceptName.ReadOnly = true;
            // 
            // col_AcceptPhone
            // 
            this.col_AcceptPhone.DataPropertyName = "AcceptPhone";
            this.col_AcceptPhone.HeaderText = "SĐT Nhận";
            this.col_AcceptPhone.Name = "col_AcceptPhone";
            this.col_AcceptPhone.ReadOnly = true;
            // 
            // col_AcceptAddress
            // 
            this.col_AcceptAddress.DataPropertyName = "AcceptAddress";
            this.col_AcceptAddress.HeaderText = "Địa chỉ";
            this.col_AcceptAddress.Name = "col_AcceptAddress";
            this.col_AcceptAddress.ReadOnly = true;
            // 
            // col_GoodsName
            // 
            this.col_GoodsName.DataPropertyName = "GoodsName";
            this.col_GoodsName.HeaderText = "Tên hàng";
            this.col_GoodsName.Name = "col_GoodsName";
            this.col_GoodsName.ReadOnly = true;
            // 
            // col_COD
            // 
            this.col_COD.DataPropertyName = "COD";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "N0";
            this.col_COD.DefaultCellStyle = dataGridViewCellStyle14;
            this.col_COD.HeaderText = "Thu hộ";
            this.col_COD.Name = "col_COD";
            this.col_COD.ReadOnly = true;
            // 
            // col_Weight
            // 
            this.col_Weight.DataPropertyName = "Weight";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "N0";
            this.col_Weight.DefaultCellStyle = dataGridViewCellStyle15;
            this.col_Weight.HeaderText = "Cân nặng";
            this.col_Weight.Name = "col_Weight";
            this.col_Weight.ReadOnly = true;
            // 
            // col_IsShopPay
            // 
            this.col_IsShopPay.DataPropertyName = "IsShopPay";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_IsShopPay.DefaultCellStyle = dataGridViewCellStyle16;
            this.col_IsShopPay.HeaderText = "Gửi trả";
            this.col_IsShopPay.Name = "col_IsShopPay";
            this.col_IsShopPay.ReadOnly = true;
            // 
            // col_Note
            // 
            this.col_Note.DataPropertyName = "Note";
            this.col_Note.HeaderText = "Ghi chú";
            this.col_Note.Name = "col_Note";
            this.col_Note.ReadOnly = true;
            // 
            // col_CreateDate
            // 
            this.col_CreateDate.DataPropertyName = "CreateDate";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.Format = "dd/MM/yyyy HH:mm:ss";
            this.col_CreateDate.DefaultCellStyle = dataGridViewCellStyle17;
            this.col_CreateDate.HeaderText = "Ngày đặt hàng";
            this.col_CreateDate.Name = "col_CreateDate";
            this.col_CreateDate.ReadOnly = true;
            // 
            // col_FK_CustomerId
            // 
            this.col_FK_CustomerId.DataPropertyName = "FK_CustomerId";
            this.col_FK_CustomerId.HeaderText = "FK_CustomerId";
            this.col_FK_CustomerId.Name = "col_FK_CustomerId";
            this.col_FK_CustomerId.ReadOnly = true;
            this.col_FK_CustomerId.Visible = false;
            // 
            // col_StatusOrder
            // 
            this.col_StatusOrder.DataPropertyName = "StatusOrder";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "N0";
            this.col_StatusOrder.DefaultCellStyle = dataGridViewCellStyle18;
            this.col_StatusOrder.HeaderText = "StatusOrder";
            this.col_StatusOrder.Name = "col_StatusOrder";
            this.col_StatusOrder.ReadOnly = true;
            this.col_StatusOrder.Visible = false;
            // 
            // col_PickupUser
            // 
            this.col_PickupUser.DataPropertyName = "PickupUser";
            this.col_PickupUser.HeaderText = "PickupUser";
            this.col_PickupUser.Name = "col_PickupUser";
            this.col_PickupUser.ReadOnly = true;
            this.col_PickupUser.Visible = false;
            // 
            // col_PickupDate
            // 
            this.col_PickupDate.DataPropertyName = "PickupDate";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.Format = "dd/MM/yyyy HH:mm:ss";
            this.col_PickupDate.DefaultCellStyle = dataGridViewCellStyle19;
            this.col_PickupDate.HeaderText = "PickupDate";
            this.col_PickupDate.Name = "col_PickupDate";
            this.col_PickupDate.ReadOnly = true;
            this.col_PickupDate.Visible = false;
            // 
            // col_TransferCode
            // 
            this.col_TransferCode.DataPropertyName = "TransferCode";
            this.col_TransferCode.HeaderText = "TransferCode";
            this.col_TransferCode.Name = "col_TransferCode";
            this.col_TransferCode.ReadOnly = true;
            this.col_TransferCode.Visible = false;
            // 
            // col_StatusName
            // 
            this.col_StatusName.DataPropertyName = "StatusName";
            this.col_StatusName.HeaderText = "Tình trạng";
            this.col_StatusName.Name = "col_StatusName";
            this.col_StatusName.ReadOnly = true;
            // 
            // col_StatusTextColor
            // 
            this.col_StatusTextColor.DataPropertyName = "StatusTextColor";
            this.col_StatusTextColor.HeaderText = "StatusTextColor";
            this.col_StatusTextColor.Name = "col_StatusTextColor";
            this.col_StatusTextColor.ReadOnly = true;
            this.col_StatusTextColor.Visible = false;
            // 
            // col_StatusBackgroundColor
            // 
            this.col_StatusBackgroundColor.DataPropertyName = "StatusBackgroundColor";
            this.col_StatusBackgroundColor.HeaderText = "StatusBackgroundColor";
            this.col_StatusBackgroundColor.Name = "col_StatusBackgroundColor";
            this.col_StatusBackgroundColor.ReadOnly = true;
            this.col_StatusBackgroundColor.Visible = false;
            // 
            // col_FK_Post
            // 
            this.col_FK_Post.DataPropertyName = "FK_Post";
            this.col_FK_Post.HeaderText = "FK_Post";
            this.col_FK_Post.Name = "col_FK_Post";
            this.col_FK_Post.ReadOnly = true;
            this.col_FK_Post.Visible = false;
            // 
            // lblWaitCount
            // 
            this.lblWaitCount.AutoSize = true;
            this.lblWaitCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaitCount.ForeColor = System.Drawing.Color.White;
            this.lblWaitCount.Location = new System.Drawing.Point(8, 5);
            this.lblWaitCount.Name = "lblWaitCount";
            this.lblWaitCount.Size = new System.Drawing.Size(25, 26);
            this.lblWaitCount.TabIndex = 78;
            this.lblWaitCount.Text = "0";
            // 
            // frmOrderCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 535);
            this.Controls.Add(this.gridMain);
            this.Controls.Add(this.txtKhachHangFilter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbKhachHangFilter);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.panelcomtrol);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrderCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách đơn đặt hàng";
            this.Load += new System.EventHandler(this.frmOrderCustomer_Load);
            this.panelcomtrol.ResumeLayout(false);
            this.panelcomtrol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelcomtrol;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.Controls.TextBoxX txtKhachHangFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbKhachHangFilter;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label label7;
        private DevComponents.DotNetBar.ButtonX btnFilter;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private DevComponents.DotNetBar.Controls.DataGridViewX gridMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_OrderCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CustomerCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CustomerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AcceptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AcceptPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AcceptAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_COD;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IsShopPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_StatusOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PickupUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PickupDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TransferCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_StatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_StatusTextColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_StatusBackgroundColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FK_Post;
        private System.Windows.Forms.Label lblWaitCount;
    }
}