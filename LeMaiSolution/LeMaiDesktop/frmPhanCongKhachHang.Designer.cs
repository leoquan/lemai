
namespace LeMaiDesktop
{
    partial class frmPhanCongKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridAccount = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LastLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CardId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelcomtrol = new System.Windows.Forms.Panel();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.trvKhachHang = new System.Windows.Forms.TreeView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuChuyenNhom = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridAccount)).BeginInit();
            this.panelcomtrol.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridAccount
            // 
            this.gridAccount.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.gridAccount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gridAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridAccount.ColumnHeadersHeight = 25;
            this.gridAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Id,
            this.col_Code,
            this.col_FullName,
            this.col_UserName,
            this.col_LastLogin,
            this.col_CardId});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAccount.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridAccount.EnableHeadersVisualStyles = false;
            this.gridAccount.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.gridAccount.HighlightSelectedColumnHeaders = false;
            this.gridAccount.Location = new System.Drawing.Point(2, 2);
            this.gridAccount.MultiSelect = false;
            this.gridAccount.Name = "gridAccount";
            this.gridAccount.PaintEnhancedSelection = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAccount.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridAccount.RowHeadersVisible = false;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.gridAccount.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gridAccount.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridAccount.RowTemplate.Height = 25;
            this.gridAccount.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAccount.Size = new System.Drawing.Size(502, 616);
            this.gridAccount.TabIndex = 1166;
            this.gridAccount.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridNguoiDung_CellDoubleClick);
            // 
            // col_Id
            // 
            this.col_Id.DataPropertyName = "Id";
            this.col_Id.HeaderText = "Id";
            this.col_Id.Name = "col_Id";
            this.col_Id.ReadOnly = true;
            this.col_Id.Visible = false;
            // 
            // col_Code
            // 
            this.col_Code.DataPropertyName = "Code";
            this.col_Code.HeaderText = "Code";
            this.col_Code.Name = "col_Code";
            this.col_Code.ReadOnly = true;
            // 
            // col_FullName
            // 
            this.col_FullName.DataPropertyName = "FullName";
            this.col_FullName.HeaderText = "FullName";
            this.col_FullName.Name = "col_FullName";
            this.col_FullName.ReadOnly = true;
            // 
            // col_UserName
            // 
            this.col_UserName.DataPropertyName = "UserName";
            this.col_UserName.HeaderText = "UserName";
            this.col_UserName.Name = "col_UserName";
            this.col_UserName.ReadOnly = true;
            // 
            // col_LastLogin
            // 
            this.col_LastLogin.DataPropertyName = "LastLogin";
            this.col_LastLogin.HeaderText = "LastLogin";
            this.col_LastLogin.Name = "col_LastLogin";
            this.col_LastLogin.ReadOnly = true;
            // 
            // col_CardId
            // 
            this.col_CardId.DataPropertyName = "CardId";
            this.col_CardId.HeaderText = "CardId";
            this.col_CardId.Name = "col_CardId";
            this.col_CardId.ReadOnly = true;
            // 
            // panelcomtrol
            // 
            this.panelcomtrol.BackColor = System.Drawing.Color.SteelBlue;
            this.panelcomtrol.Controls.Add(this.btnSave);
            this.panelcomtrol.Controls.Add(this.btnClose);
            this.panelcomtrol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelcomtrol.Location = new System.Drawing.Point(0, 624);
            this.panelcomtrol.Name = "panelcomtrol";
            this.panelcomtrol.Size = new System.Drawing.Size(1006, 39);
            this.panelcomtrol.TabIndex = 1168;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::LeMaiDesktop.Properties.Resources.iSave;
            this.btnSave.ImageTextSpacing = 3;
            this.btnSave.Location = new System.Drawing.Point(831, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Lưu";
            this.btnSave.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::LeMaiDesktop.Properties.Resources.iExit;
            this.btnClose.ImageTextSpacing = 3;
            this.btnClose.Location = new System.Drawing.Point(909, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 30);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "&Kết thúc";
            this.btnClose.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // trvKhachHang
            // 
            this.trvKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trvKhachHang.BackColor = System.Drawing.SystemColors.Window;
            this.trvKhachHang.CheckBoxes = true;
            this.trvKhachHang.ContextMenuStrip = this.contextMenuStrip;
            this.trvKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvKhachHang.Location = new System.Drawing.Point(510, 2);
            this.trvKhachHang.Name = "trvKhachHang";
            this.trvKhachHang.Size = new System.Drawing.Size(496, 616);
            this.trvKhachHang.TabIndex = 1169;
            this.trvKhachHang.TabStop = false;
            this.trvKhachHang.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.trvKhachHang_AfterCheck);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuChuyenNhom});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(181, 48);
            // 
            // menuChuyenNhom
            // 
            this.menuChuyenNhom.Name = "menuChuyenNhom";
            this.menuChuyenNhom.Size = new System.Drawing.Size(180, 22);
            this.menuChuyenNhom.Text = "Chuyển nhóm";
            // 
            // frmPhanCongKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 663);
            this.Controls.Add(this.trvKhachHang);
            this.Controls.Add(this.panelcomtrol);
            this.Controls.Add(this.gridAccount);
            this.Name = "frmPhanCongKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân công khách hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhanCongKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAccount)).EndInit();
            this.panelcomtrol.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX gridAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LastLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CardId;
        private System.Windows.Forms.Panel panelcomtrol;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private System.Windows.Forms.TreeView trvKhachHang;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuChuyenNhom;
    }
}