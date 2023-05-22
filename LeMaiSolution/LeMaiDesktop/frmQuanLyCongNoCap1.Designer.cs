namespace LeMaiDesktop
{
    partial class frmQuanLyCongNoCap1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelcomtrol = new System.Windows.Forms.Panel();
            this.btnXemChiTietCongNo = new DevComponents.DotNetBar.ButtonX();
            this.btnAddRequest = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.gridMain = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.col_idqltc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BuuCuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_QLTCSoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuanLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IsNapTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lTieude = new System.Windows.Forms.Label();
            this.panelcomtrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panelcomtrol
            // 
            this.panelcomtrol.BackColor = System.Drawing.Color.SteelBlue;
            this.panelcomtrol.Controls.Add(this.btnXemChiTietCongNo);
            this.panelcomtrol.Controls.Add(this.btnAddRequest);
            this.panelcomtrol.Controls.Add(this.btnClose);
            this.panelcomtrol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelcomtrol.Location = new System.Drawing.Point(0, 493);
            this.panelcomtrol.Name = "panelcomtrol";
            this.panelcomtrol.Size = new System.Drawing.Size(749, 39);
            this.panelcomtrol.TabIndex = 301;
            // 
            // btnXemChiTietCongNo
            // 
            this.btnXemChiTietCongNo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXemChiTietCongNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXemChiTietCongNo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXemChiTietCongNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTietCongNo.Image = global::LeMaiDesktop.Properties.Resources.iGop;
            this.btnXemChiTietCongNo.ImageTextSpacing = 3;
            this.btnXemChiTietCongNo.Location = new System.Drawing.Point(3, 5);
            this.btnXemChiTietCongNo.Name = "btnXemChiTietCongNo";
            this.btnXemChiTietCongNo.Size = new System.Drawing.Size(134, 30);
            this.btnXemChiTietCongNo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXemChiTietCongNo.TabIndex = 1168;
            this.btnXemChiTietCongNo.Text = "Chi tiết công nợ";
            this.btnXemChiTietCongNo.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnXemChiTietCongNo.Click += new System.EventHandler(this.btnXemChiTietCongNo_Click);
            // 
            // btnAddRequest
            // 
            this.btnAddRequest.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRequest.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddRequest.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRequest.Image = global::LeMaiDesktop.Properties.Resources.iEdit;
            this.btnAddRequest.ImageTextSpacing = 3;
            this.btnAddRequest.Location = new System.Drawing.Point(514, 5);
            this.btnAddRequest.Name = "btnAddRequest";
            this.btnAddRequest.Size = new System.Drawing.Size(134, 30);
            this.btnAddRequest.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddRequest.TabIndex = 1167;
            this.btnAddRequest.Text = "Tạo lệnh nạp tiền";
            this.btnAddRequest.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnAddRequest.Click += new System.EventHandler(this.btnAddRequest_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::LeMaiDesktop.Properties.Resources.iExit;
            this.btnClose.ImageTextSpacing = 3;
            this.btnClose.Location = new System.Drawing.Point(654, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 30);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 1166;
            this.btnClose.Text = "&Kết thúc";
            this.btnClose.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gridMain
            // 
            this.gridMain.AllowUserToAddRows = false;
            this.gridMain.AllowUserToDeleteRows = false;
            this.gridMain.AllowUserToResizeColumns = false;
            this.gridMain.AllowUserToResizeRows = false;
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
            this.col_idqltc,
            this.dataGridViewTextBoxColumn33,
            this.col_BuuCuc,
            this.col_QLTCSoTien,
            this.colQuanLy,
            this.colSdt,
            this.col_IsNapTien});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMain.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridMain.EnableHeadersVisualStyles = false;
            this.gridMain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.gridMain.HighlightSelectedColumnHeaders = false;
            this.gridMain.Location = new System.Drawing.Point(0, 33);
            this.gridMain.MultiSelect = false;
            this.gridMain.Name = "gridMain";
            this.gridMain.PaintEnhancedSelection = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridMain.RowHeadersVisible = false;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.gridMain.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gridMain.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridMain.RowTemplate.Height = 25;
            this.gridMain.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMain.Size = new System.Drawing.Size(749, 459);
            this.gridMain.TabIndex = 302;
            this.gridMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMain_CellDoubleClick);
            // 
            // col_idqltc
            // 
            this.col_idqltc.DataPropertyName = "PostReferCode";
            this.col_idqltc.HeaderText = "Id";
            this.col_idqltc.Name = "col_idqltc";
            this.col_idqltc.Visible = false;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn33.DataPropertyName = "LastDate";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "dd/MM/yy HH:mm:ss";
            this.dataGridViewTextBoxColumn33.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn33.HeaderText = "Ngày cập nhật";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ReadOnly = true;
            this.dataGridViewTextBoxColumn33.Width = 120;
            // 
            // col_BuuCuc
            // 
            this.col_BuuCuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_BuuCuc.DataPropertyName = "PostReferName";
            this.col_BuuCuc.HeaderText = "Bưu cục";
            this.col_BuuCuc.Name = "col_BuuCuc";
            this.col_BuuCuc.ReadOnly = true;
            // 
            // col_QLTCSoTien
            // 
            this.col_QLTCSoTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_QLTCSoTien.DataPropertyName = "Balance";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            this.col_QLTCSoTien.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_QLTCSoTien.HeaderText = "Số tiền";
            this.col_QLTCSoTien.Name = "col_QLTCSoTien";
            this.col_QLTCSoTien.ReadOnly = true;
            this.col_QLTCSoTien.Width = 120;
            // 
            // colQuanLy
            // 
            this.colQuanLy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colQuanLy.DataPropertyName = "QuanLy";
            this.colQuanLy.HeaderText = "Quản lý";
            this.colQuanLy.Name = "colQuanLy";
            this.colQuanLy.ReadOnly = true;
            this.colQuanLy.Width = 180;
            // 
            // colSdt
            // 
            this.colSdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSdt.DataPropertyName = "SoDienThoai";
            this.colSdt.HeaderText = "Số điện thoại";
            this.colSdt.Name = "colSdt";
            this.colSdt.ReadOnly = true;
            this.colSdt.Width = 120;
            // 
            // col_IsNapTien
            // 
            this.col_IsNapTien.DataPropertyName = "IsNapTien";
            this.col_IsNapTien.HeaderText = "Nạp tiền";
            this.col_IsNapTien.Name = "col_IsNapTien";
            this.col_IsNapTien.ReadOnly = true;
            this.col_IsNapTien.Visible = false;
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
            this.lTieude.Size = new System.Drawing.Size(749, 32);
            this.lTieude.TabIndex = 303;
            this.lTieude.Text = "    Danh sách công nợ cấp 1";
            this.lTieude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmQuanLyCongNoCap1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 532);
            this.Controls.Add(this.lTieude);
            this.Controls.Add(this.gridMain);
            this.Controls.Add(this.panelcomtrol);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuanLyCongNoCap1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý công nợ cấp 1";
            this.Load += new System.EventHandler(this.frmQuanLyCongNoCap1_Load);
            this.panelcomtrol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelcomtrol;
        private DevComponents.DotNetBar.ButtonX btnAddRequest;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnXemChiTietCongNo;
        private DevComponents.DotNetBar.Controls.DataGridViewX gridMain;
        private System.Windows.Forms.Label lTieude;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_idqltc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BuuCuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_QLTCSoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuanLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IsNapTien;
    }
}