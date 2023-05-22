namespace LeMaiDesktop
{
    partial class frmGrantPermission
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.group_chucnang = new System.Windows.Forms.GroupBox();
            this.trvForm = new System.Windows.Forms.TreeView();
            this.panelcomtrol = new System.Windows.Forms.Panel();
            this.txtSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridAccount = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridRole = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Prioty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LastLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CardId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_chucnang.SuspendLayout();
            this.panelcomtrol.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAccount)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRole)).BeginInit();
            this.SuspendLayout();
            // 
            // group_chucnang
            // 
            this.group_chucnang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.group_chucnang.Controls.Add(this.trvForm);
            this.group_chucnang.Location = new System.Drawing.Point(522, 0);
            this.group_chucnang.Name = "group_chucnang";
            this.group_chucnang.Size = new System.Drawing.Size(385, 580);
            this.group_chucnang.TabIndex = 478;
            this.group_chucnang.TabStop = false;
            this.group_chucnang.Text = "Menu Function";
            // 
            // trvForm
            // 
            this.trvForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trvForm.BackColor = System.Drawing.SystemColors.Window;
            this.trvForm.CheckBoxes = true;
            this.trvForm.Location = new System.Drawing.Point(3, 20);
            this.trvForm.Name = "trvForm";
            this.trvForm.Size = new System.Drawing.Size(379, 554);
            this.trvForm.TabIndex = 10;
            this.trvForm.TabStop = false;
            this.trvForm.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.trvForm_AfterCheck);
            // 
            // panelcomtrol
            // 
            this.panelcomtrol.BackColor = System.Drawing.Color.SteelBlue;
            this.panelcomtrol.Controls.Add(this.txtSearch);
            this.panelcomtrol.Controls.Add(this.btnSave);
            this.panelcomtrol.Controls.Add(this.btnClose);
            this.panelcomtrol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelcomtrol.Location = new System.Drawing.Point(0, 586);
            this.panelcomtrol.Name = "panelcomtrol";
            this.panelcomtrol.Size = new System.Drawing.Size(910, 39);
            this.panelcomtrol.TabIndex = 1167;
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
            this.txtSearch.Size = new System.Drawing.Size(252, 21);
            this.txtSearch.TabIndex = 1165;
            this.txtSearch.WatermarkColor = System.Drawing.Color.Maroon;
            this.txtSearch.WatermarkFont = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.WatermarkText = "Tìm kiếm...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            this.btnSave.Location = new System.Drawing.Point(735, 5);
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
            this.btnClose.Location = new System.Drawing.Point(813, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 30);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "&Kết thúc";
            this.btnClose.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(516, 580);
            this.tabControl1.TabIndex = 1168;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridAccount);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(508, 554);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Account";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridAccount
            // 
            this.gridAccount.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.gridAccount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridAccount.ColumnHeadersHeight = 25;
            this.gridAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Id,
            this.col_Code,
            this.col_FullName,
            this.col_UserName,
            this.col_LastLogin,
            this.col_CardId});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAccount.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAccount.EnableHeadersVisualStyles = false;
            this.gridAccount.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.gridAccount.HighlightSelectedColumnHeaders = false;
            this.gridAccount.Location = new System.Drawing.Point(3, 3);
            this.gridAccount.MultiSelect = false;
            this.gridAccount.Name = "gridAccount";
            this.gridAccount.PaintEnhancedSelection = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAccount.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridAccount.RowHeadersVisible = false;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.gridAccount.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridAccount.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridAccount.RowTemplate.Height = 25;
            this.gridAccount.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAccount.Size = new System.Drawing.Size(502, 548);
            this.gridAccount.TabIndex = 1165;
            this.gridAccount.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridNguoiDung_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridRole);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(508, 554);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Role";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridRole
            // 
            this.dataGridRole.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.dataGridRole.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRole.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridRole.ColumnHeadersHeight = 25;
            this.dataGridRole.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.col_RoleName,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.col_Prioty});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridRole.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridRole.EnableHeadersVisualStyles = false;
            this.dataGridRole.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataGridRole.HighlightSelectedColumnHeaders = false;
            this.dataGridRole.Location = new System.Drawing.Point(3, 3);
            this.dataGridRole.MultiSelect = false;
            this.dataGridRole.Name = "dataGridRole";
            this.dataGridRole.PaintEnhancedSelection = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRole.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridRole.RowHeadersVisible = false;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridRole.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridRole.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridRole.RowTemplate.Height = 25;
            this.dataGridRole.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridRole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRole.Size = new System.Drawing.Size(502, 548);
            this.dataGridRole.TabIndex = 1165;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Code";
            this.dataGridViewTextBoxColumn2.HeaderText = "Code";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // col_RoleName
            // 
            this.col_RoleName.DataPropertyName = "RoleName";
            this.col_RoleName.HeaderText = "RoleName";
            this.col_RoleName.Name = "col_RoleName";
            this.col_RoleName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AtCreatedDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "AtCreatedDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AtCreatedBy";
            this.dataGridViewTextBoxColumn4.HeaderText = "AtCreatedBy";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AtLastModifiedDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "AtLastModifiedDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "AtLastModifiedBy";
            this.dataGridViewTextBoxColumn6.HeaderText = "AtLastModifiedBy";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "AtRowStatus";
            this.dataGridViewTextBoxColumn7.HeaderText = "AtRowStatus";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // col_Prioty
            // 
            this.col_Prioty.DataPropertyName = "Prioty";
            this.col_Prioty.HeaderText = "Prioty";
            this.col_Prioty.Name = "col_Prioty";
            this.col_Prioty.ReadOnly = true;
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
            // frmGrantPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 625);
            this.Controls.Add(this.group_chucnang);
            this.Controls.Add(this.panelcomtrol);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGrantPermission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grant Permission";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGrantPermission_Load);
            this.group_chucnang.ResumeLayout(false);
            this.panelcomtrol.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAccount)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_chucnang;
        private System.Windows.Forms.TreeView trvForm;
        private System.Windows.Forms.Panel panelcomtrol;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearch;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.StyleManager styleManager;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DevComponents.DotNetBar.Controls.DataGridViewX gridAccount;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Prioty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LastLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CardId;
    }
}
