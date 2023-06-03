namespace LeMaiDesktop
{
    partial class frmQuanLyDonHangGiao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lTieude = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.btnTruyVan = new DevComponents.DotNetBar.ButtonX();
            this.lblTongCOD = new System.Windows.Forms.Label();
            this.lblDaKyNhanCount = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridBills = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.panelcomtrol = new System.Windows.Forms.Panel();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BillCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AcceptMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AcceptManPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AcceptManAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BillWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_RegisterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LastUpdateUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbNV = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridBills)).BeginInit();
            this.panelcomtrol.SuspendLayout();
            this.SuspendLayout();
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
            this.lTieude.Size = new System.Drawing.Size(1185, 30);
            this.lTieude.TabIndex = 10;
            this.lTieude.Text = "    Danh sách đơn hàng đã giao";
            this.lTieude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.ForeColor = System.Drawing.Color.Black;
            this.label61.Location = new System.Drawing.Point(12, 42);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(61, 17);
            this.label61.TabIndex = 1346;
            this.label61.Text = "Shipper:";
            // 
            // btnTruyVan
            // 
            this.btnTruyVan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTruyVan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTruyVan.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruyVan.Image = global::LeMaiDesktop.Properties.Resources.iSearch;
            this.btnTruyVan.ImageTextSpacing = 3;
            this.btnTruyVan.Location = new System.Drawing.Point(358, 38);
            this.btnTruyVan.Name = "btnTruyVan";
            this.btnTruyVan.Size = new System.Drawing.Size(82, 24);
            this.btnTruyVan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTruyVan.TabIndex = 1347;
            this.btnTruyVan.Text = "Truy vấn";
            this.btnTruyVan.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnTruyVan.Click += new System.EventHandler(this.btnTruyVan_Click);
            // 
            // lblTongCOD
            // 
            this.lblTongCOD.AutoSize = true;
            this.lblTongCOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongCOD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTongCOD.Location = new System.Drawing.Point(794, 42);
            this.lblTongCOD.Name = "lblTongCOD";
            this.lblTongCOD.Size = new System.Drawing.Size(17, 17);
            this.lblTongCOD.TabIndex = 1351;
            this.lblTongCOD.Text = "0";
            // 
            // lblDaKyNhanCount
            // 
            this.lblDaKyNhanCount.AutoSize = true;
            this.lblDaKyNhanCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaKyNhanCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDaKyNhanCount.Location = new System.Drawing.Point(525, 42);
            this.lblDaKyNhanCount.Name = "lblDaKyNhanCount";
            this.lblDaKyNhanCount.Size = new System.Drawing.Size(17, 17);
            this.lblDaKyNhanCount.TabIndex = 1349;
            this.lblDaKyNhanCount.Text = "0";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.Color.Black;
            this.label59.Location = new System.Drawing.Point(718, 42);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(79, 17);
            this.label59.TabIndex = 1350;
            this.label59.Text = "Tổng COD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(445, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 1348;
            this.label1.Text = "Đã ký nhận:";
            // 
            // gridBills
            // 
            this.gridBills.AllowUserToAddRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.gridBills.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.gridBills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.gridBills.ColumnHeadersHeight = 25;
            this.gridBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Id,
            this.col_BillCode,
            this.col_AcceptMan,
            this.col_AcceptManPhone,
            this.col_AcceptManAddress,
            this.col_BillWeight,
            this.col_RegisterDate,
            this.col_LastUpdateUser});
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridBills.DefaultCellStyle = dataGridViewCellStyle26;
            this.gridBills.EnableHeadersVisualStyles = false;
            this.gridBills.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.gridBills.HighlightSelectedColumnHeaders = false;
            this.gridBills.Location = new System.Drawing.Point(3, 85);
            this.gridBills.MultiSelect = false;
            this.gridBills.Name = "gridBills";
            this.gridBills.PaintEnhancedSelection = false;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBills.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.gridBills.RowHeadersVisible = false;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.White;
            this.gridBills.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.gridBills.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBills.RowTemplate.Height = 25;
            this.gridBills.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridBills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBills.Size = new System.Drawing.Size(1182, 523);
            this.gridBills.TabIndex = 1352;
            this.gridBills.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBills_CellDoubleClick);
            // 
            // panelcomtrol
            // 
            this.panelcomtrol.BackColor = System.Drawing.Color.SteelBlue;
            this.panelcomtrol.Controls.Add(this.btnClose);
            this.panelcomtrol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelcomtrol.Location = new System.Drawing.Point(0, 610);
            this.panelcomtrol.Name = "panelcomtrol";
            this.panelcomtrol.Size = new System.Drawing.Size(1185, 39);
            this.panelcomtrol.TabIndex = 1353;
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::LeMaiDesktop.Properties.Resources.iExit;
            this.btnClose.ImageTextSpacing = 3;
            this.btnClose.Location = new System.Drawing.Point(1088, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 30);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Kết thúc";
            this.btnClose.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            // col_BillCode
            // 
            this.col_BillCode.DataPropertyName = "BillCode";
            this.col_BillCode.HeaderText = "Mã đơn hàng";
            this.col_BillCode.Name = "col_BillCode";
            this.col_BillCode.ReadOnly = true;
            this.col_BillCode.Width = 90;
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
            this.col_AcceptManAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_AcceptManAddress.DataPropertyName = "AcceptProvince";
            this.col_AcceptManAddress.HeaderText = "Địa chỉ nhận";
            this.col_AcceptManAddress.Name = "col_AcceptManAddress";
            this.col_AcceptManAddress.ReadOnly = true;
            // 
            // col_BillWeight
            // 
            this.col_BillWeight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_BillWeight.DataPropertyName = "BillWeight";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle24.Format = "N0";
            this.col_BillWeight.DefaultCellStyle = dataGridViewCellStyle24;
            this.col_BillWeight.HeaderText = "TL Ghi đơn";
            this.col_BillWeight.Name = "col_BillWeight";
            this.col_BillWeight.ReadOnly = true;
            this.col_BillWeight.Width = 60;
            // 
            // col_RegisterDate
            // 
            this.col_RegisterDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_RegisterDate.DataPropertyName = "SignDate";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.Format = "dd/MM HH:mm";
            this.col_RegisterDate.DefaultCellStyle = dataGridViewCellStyle25;
            this.col_RegisterDate.HeaderText = "Ngày giao";
            this.col_RegisterDate.Name = "col_RegisterDate";
            this.col_RegisterDate.ReadOnly = true;
            this.col_RegisterDate.Width = 80;
            // 
            // col_LastUpdateUser
            // 
            this.col_LastUpdateUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_LastUpdateUser.DataPropertyName = "ShipperName";
            this.col_LastUpdateUser.HeaderText = "Người giao";
            this.col_LastUpdateUser.Name = "col_LastUpdateUser";
            this.col_LastUpdateUser.ReadOnly = true;
            this.col_LastUpdateUser.Width = 150;
            // 
            // cmbNV
            // 
            this.cmbNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNV.FormattingEnabled = true;
            this.cmbNV.Location = new System.Drawing.Point(69, 39);
            this.cmbNV.Name = "cmbNV";
            this.cmbNV.Size = new System.Drawing.Size(283, 23);
            this.cmbNV.TabIndex = 1354;
            // 
            // frmQuanLyDonHangGiao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 649);
            this.Controls.Add(this.cmbNV);
            this.Controls.Add(this.panelcomtrol);
            this.Controls.Add(this.gridBills);
            this.Controls.Add(this.lblTongCOD);
            this.Controls.Add(this.lblDaKyNhanCount);
            this.Controls.Add(this.label59);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTruyVan);
            this.Controls.Add(this.label61);
            this.Controls.Add(this.lTieude);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuanLyDonHangGiao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách đơn hàng đã giao";
            this.Load += new System.EventHandler(this.frmQuanLyDonHangGiao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBills)).EndInit();
            this.panelcomtrol.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTieude;
        private System.Windows.Forms.Label label61;
        private DevComponents.DotNetBar.ButtonX btnTruyVan;
        private System.Windows.Forms.Label lblTongCOD;
        private System.Windows.Forms.Label lblDaKyNhanCount;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.DataGridViewX gridBills;
        private System.Windows.Forms.Panel panelcomtrol;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.StyleManager styleManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BillCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AcceptMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AcceptManPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AcceptManAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BillWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RegisterDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LastUpdateUser;
        private System.Windows.Forms.ComboBox cmbNV;
    }
}