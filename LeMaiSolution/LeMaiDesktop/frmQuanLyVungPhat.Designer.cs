namespace LeMaiDesktop
{
    partial class frmQuanLyVungPhat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lTieude = new System.Windows.Forms.Label();
            this.panelcomtrol = new System.Windows.Forms.Panel();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.dataQuanHuyen = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Select = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTinh = new System.Windows.Forms.ComboBox();
            this.btnChuyenTinh = new DevComponents.DotNetBar.ButtonX();
            this.panelcomtrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataQuanHuyen)).BeginInit();
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
            this.lTieude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTieude.Name = "lTieude";
            this.lTieude.Size = new System.Drawing.Size(349, 33);
            this.lTieude.TabIndex = 77;
            this.lTieude.Text = "    Thêm khu vực đặc biệt";
            this.lTieude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelcomtrol
            // 
            this.panelcomtrol.BackColor = System.Drawing.Color.SteelBlue;
            this.panelcomtrol.Controls.Add(this.btnSave);
            this.panelcomtrol.Controls.Add(this.btnClose);
            this.panelcomtrol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelcomtrol.Location = new System.Drawing.Point(0, 440);
            this.panelcomtrol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelcomtrol.Name = "panelcomtrol";
            this.panelcomtrol.Size = new System.Drawing.Size(349, 42);
            this.panelcomtrol.TabIndex = 78;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::LeMaiDesktop.Properties.Resources.iSave;
            this.btnSave.ImageTextSpacing = 3;
            this.btnSave.Location = new System.Drawing.Point(147, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 30);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&Save";
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
            this.btnClose.Location = new System.Drawing.Point(238, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 30);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Kết thúc";
            this.btnClose.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataQuanHuyen
            // 
            this.dataQuanHuyen.AllowUserToAddRows = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.dataQuanHuyen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataQuanHuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataQuanHuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataQuanHuyen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataQuanHuyen.ColumnHeadersHeight = 25;
            this.dataQuanHuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Id,
            this.dataGridViewTextBoxColumn4,
            this.col_Select});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataQuanHuyen.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataQuanHuyen.EnableHeadersVisualStyles = false;
            this.dataQuanHuyen.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataQuanHuyen.HighlightSelectedColumnHeaders = false;
            this.dataQuanHuyen.Location = new System.Drawing.Point(3, 71);
            this.dataQuanHuyen.MultiSelect = false;
            this.dataQuanHuyen.Name = "dataQuanHuyen";
            this.dataQuanHuyen.PaintEnhancedSelection = false;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataQuanHuyen.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dataQuanHuyen.RowHeadersVisible = false;
            this.dataQuanHuyen.RowHeadersWidth = 51;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White;
            this.dataQuanHuyen.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dataQuanHuyen.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataQuanHuyen.RowTemplate.Height = 25;
            this.dataQuanHuyen.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataQuanHuyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataQuanHuyen.Size = new System.Drawing.Size(340, 363);
            this.dataQuanHuyen.TabIndex = 89;
            // 
            // col_Id
            // 
            this.col_Id.DataPropertyName = "DistrictID";
            this.col_Id.HeaderText = "Id";
            this.col_Id.Name = "col_Id";
            this.col_Id.ReadOnly = true;
            this.col_Id.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DistrictName";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "N0";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewTextBoxColumn4.HeaderText = "Quận/Huyện";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // col_Select
            // 
            this.col_Select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Select.Checked = true;
            this.col_Select.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.col_Select.CheckValue = "N";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Format = "N0";
            this.col_Select.DefaultCellStyle = dataGridViewCellStyle18;
            this.col_Select.HeaderText = "Chọn";
            this.col_Select.Name = "col_Select";
            this.col_Select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_Select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_Select.ToolTipText = "Chọn";
            this.col_Select.Width = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 90;
            this.label1.Text = "Tỉnh:";
            // 
            // cmbTinh
            // 
            this.cmbTinh.FormattingEnabled = true;
            this.cmbTinh.Location = new System.Drawing.Point(52, 41);
            this.cmbTinh.Name = "cmbTinh";
            this.cmbTinh.Size = new System.Drawing.Size(245, 22);
            this.cmbTinh.TabIndex = 91;
            this.cmbTinh.SelectedValueChanged += new System.EventHandler(this.cmbTinh_SelectedValueChanged);
            // 
            // btnChuyenTinh
            // 
            this.btnChuyenTinh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChuyenTinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChuyenTinh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChuyenTinh.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenTinh.Image = global::LeMaiDesktop.Properties.Resources.iClear;
            this.btnChuyenTinh.ImageTextSpacing = 3;
            this.btnChuyenTinh.Location = new System.Drawing.Point(303, 41);
            this.btnChuyenTinh.Name = "btnChuyenTinh";
            this.btnChuyenTinh.Size = new System.Drawing.Size(38, 24);
            this.btnChuyenTinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnChuyenTinh.TabIndex = 5;
            this.btnChuyenTinh.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnChuyenTinh.Click += new System.EventHandler(this.btnChuyenTinh_Click);
            // 
            // frmQuanLyVungPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 482);
            this.Controls.Add(this.btnChuyenTinh);
            this.Controls.Add(this.cmbTinh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataQuanHuyen);
            this.Controls.Add(this.panelcomtrol);
            this.Controls.Add(this.lTieude);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuanLyVungPhat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khu vực giao hàng";
            this.Load += new System.EventHandler(this.frmQuanLyBangGiaKV_Load);
            this.panelcomtrol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataQuanHuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTieude;
        private System.Windows.Forms.Panel panelcomtrol;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataQuanHuyen;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn col_Select;
        private DevComponents.DotNetBar.ButtonX btnChuyenTinh;
    }
}