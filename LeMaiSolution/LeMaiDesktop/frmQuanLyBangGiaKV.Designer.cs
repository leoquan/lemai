namespace LeMaiDesktop
{
    partial class frmQuanLyBangGiaKV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lTieude = new System.Windows.Forms.Label();
            this.panelcomtrol = new System.Windows.Forms.Panel();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.btnRemove = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.txtMinWeight = new System.Windows.Forms.TextBox();
            this.lblSubMinFeeInt = new System.Windows.Forms.Label();
            this.txtMinFee = new System.Windows.Forms.TextBox();
            this.lblSubMinWeightInt = new System.Windows.Forms.Label();
            this.txtNextFee = new System.Windows.Forms.TextBox();
            this.txtStepWeight = new System.Windows.Forms.TextBox();
            this.lblSubStepWeightInt = new System.Windows.Forms.Label();
            this.lblSubNextFeeInt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gridChild = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.col_SubId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SubFK_GExpFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SubMinWeightInt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SubMinFeeInt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SubStepWeightInt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SubNextFeeInt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataQuanHuyen = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Select = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTinh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFeeName = new System.Windows.Forms.TextBox();
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.panelcomtrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridChild)).BeginInit();
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
            this.lTieude.Size = new System.Drawing.Size(876, 33);
            this.lTieude.TabIndex = 77;
            this.lTieude.Text = "    Thêm khu vực đặc biệt";
            this.lTieude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelcomtrol
            // 
            this.panelcomtrol.BackColor = System.Drawing.Color.SteelBlue;
            this.panelcomtrol.Controls.Add(this.btnSave);
            this.panelcomtrol.Controls.Add(this.btnAdd);
            this.panelcomtrol.Controls.Add(this.btnRemove);
            this.panelcomtrol.Controls.Add(this.btnClose);
            this.panelcomtrol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelcomtrol.Location = new System.Drawing.Point(0, 442);
            this.panelcomtrol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelcomtrol.Name = "panelcomtrol";
            this.panelcomtrol.Size = new System.Drawing.Size(876, 42);
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
            this.btnSave.Location = new System.Drawing.Point(674, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 30);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&Save";
            this.btnSave.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::LeMaiDesktop.Properties.Resources.addrow;
            this.btnAdd.ImageTextSpacing = 3;
            this.btnAdd.Location = new System.Drawing.Point(489, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 30);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "&Add";
            this.btnAdd.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRemove.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Image = global::LeMaiDesktop.Properties.Resources.removerow;
            this.btnRemove.ImageTextSpacing = 3;
            this.btnRemove.Location = new System.Drawing.Point(585, 6);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(88, 30);
            this.btnRemove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::LeMaiDesktop.Properties.Resources.iExit;
            this.btnClose.ImageTextSpacing = 3;
            this.btnClose.Location = new System.Drawing.Point(763, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 30);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Kết thúc";
            this.btnClose.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtMinWeight
            // 
            this.txtMinWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMinWeight.BackColor = System.Drawing.SystemColors.Window;
            this.txtMinWeight.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinWeight.Location = new System.Drawing.Point(107, 405);
            this.txtMinWeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMinWeight.Name = "txtMinWeight";
            this.txtMinWeight.Size = new System.Drawing.Size(65, 22);
            this.txtMinWeight.TabIndex = 79;
            this.txtMinWeight.Text = "1,000";
            this.txtMinWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMinWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinWeight_KeyPress);
            this.txtMinWeight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMinWeight_KeyUp);
            // 
            // lblSubMinFeeInt
            // 
            this.lblSubMinFeeInt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSubMinFeeInt.AutoSize = true;
            this.lblSubMinFeeInt.ForeColor = System.Drawing.Color.Black;
            this.lblSubMinFeeInt.Location = new System.Drawing.Point(181, 409);
            this.lblSubMinFeeInt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubMinFeeInt.Name = "lblSubMinFeeInt";
            this.lblSubMinFeeInt.Size = new System.Drawing.Size(74, 14);
            this.lblSubMinFeeInt.TabIndex = 82;
            this.lblSubMinFeeInt.Text = "Giá cân đầu:";
            // 
            // txtMinFee
            // 
            this.txtMinFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMinFee.BackColor = System.Drawing.SystemColors.Window;
            this.txtMinFee.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinFee.Location = new System.Drawing.Point(254, 405);
            this.txtMinFee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMinFee.Name = "txtMinFee";
            this.txtMinFee.Size = new System.Drawing.Size(105, 22);
            this.txtMinFee.TabIndex = 80;
            this.txtMinFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMinFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinFee_KeyPress);
            this.txtMinFee.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMinFee_KeyUp);
            // 
            // lblSubMinWeightInt
            // 
            this.lblSubMinWeightInt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSubMinWeightInt.AutoSize = true;
            this.lblSubMinWeightInt.ForeColor = System.Drawing.Color.Black;
            this.lblSubMinWeightInt.Location = new System.Drawing.Point(5, 409);
            this.lblSubMinWeightInt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubMinWeightInt.Name = "lblSubMinWeightInt";
            this.lblSubMinWeightInt.Size = new System.Drawing.Size(103, 14);
            this.lblSubMinWeightInt.TabIndex = 81;
            this.lblSubMinWeightInt.Text = "Trọng lượng đầu:";
            // 
            // txtNextFee
            // 
            this.txtNextFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNextFee.BackColor = System.Drawing.SystemColors.Window;
            this.txtNextFee.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNextFee.Location = new System.Drawing.Point(576, 405);
            this.txtNextFee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNextFee.Name = "txtNextFee";
            this.txtNextFee.Size = new System.Drawing.Size(105, 22);
            this.txtNextFee.TabIndex = 84;
            this.txtNextFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNextFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNextFee_KeyPress);
            this.txtNextFee.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNextFee_KeyUp);
            // 
            // txtStepWeight
            // 
            this.txtStepWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtStepWeight.BackColor = System.Drawing.SystemColors.Window;
            this.txtStepWeight.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStepWeight.Location = new System.Drawing.Point(453, 405);
            this.txtStepWeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStepWeight.Name = "txtStepWeight";
            this.txtStepWeight.Size = new System.Drawing.Size(65, 22);
            this.txtStepWeight.TabIndex = 83;
            this.txtStepWeight.Text = "1,000";
            this.txtStepWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStepWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStepWeight_KeyPress);
            this.txtStepWeight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtStepWeight_KeyUp);
            // 
            // lblSubStepWeightInt
            // 
            this.lblSubStepWeightInt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSubStepWeightInt.AutoSize = true;
            this.lblSubStepWeightInt.ForeColor = System.Drawing.Color.Black;
            this.lblSubStepWeightInt.Location = new System.Drawing.Point(368, 409);
            this.lblSubStepWeightInt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubStepWeightInt.Name = "lblSubStepWeightInt";
            this.lblSubStepWeightInt.Size = new System.Drawing.Size(85, 14);
            this.lblSubStepWeightInt.TabIndex = 86;
            this.lblSubStepWeightInt.Text = "Nấc cân nặng:";
            // 
            // lblSubNextFeeInt
            // 
            this.lblSubNextFeeInt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSubNextFeeInt.AutoSize = true;
            this.lblSubNextFeeInt.ForeColor = System.Drawing.Color.Black;
            this.lblSubNextFeeInt.Location = new System.Drawing.Point(526, 409);
            this.lblSubNextFeeInt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubNextFeeInt.Name = "lblSubNextFeeInt";
            this.lblSubNextFeeInt.Size = new System.Drawing.Size(50, 14);
            this.lblSubNextFeeInt.TabIndex = 85;
            this.lblSubNextFeeInt.Text = "Giá nấc:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(689, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 14);
            this.label8.TabIndex = 87;
            this.label8.Text = "Cân nặng sử dụng đơn vị gram";
            // 
            // gridChild
            // 
            this.gridChild.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.gridChild.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridChild.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridChild.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridChild.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridChild.ColumnHeadersHeight = 25;
            this.gridChild.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_SubId,
            this.col_SubFK_GExpFee,
            this.col_SubMinWeightInt,
            this.col_SubMinFeeInt,
            this.col_SubStepWeightInt,
            this.col_SubNextFeeInt});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridChild.DefaultCellStyle = dataGridViewCellStyle7;
            this.gridChild.EnableHeadersVisualStyles = false;
            this.gridChild.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.gridChild.HighlightSelectedColumnHeaders = false;
            this.gridChild.Location = new System.Drawing.Point(254, 71);
            this.gridChild.MultiSelect = false;
            this.gridChild.Name = "gridChild";
            this.gridChild.PaintEnhancedSelection = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridChild.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gridChild.RowHeadersVisible = false;
            this.gridChild.RowHeadersWidth = 51;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.gridChild.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.gridChild.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridChild.RowTemplate.Height = 25;
            this.gridChild.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridChild.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridChild.Size = new System.Drawing.Size(622, 314);
            this.gridChild.TabIndex = 88;
            // 
            // col_SubId
            // 
            this.col_SubId.DataPropertyName = "Id";
            this.col_SubId.HeaderText = "Id";
            this.col_SubId.Name = "col_SubId";
            this.col_SubId.ReadOnly = true;
            this.col_SubId.Visible = false;
            // 
            // col_SubFK_GExpFee
            // 
            this.col_SubFK_GExpFee.DataPropertyName = "FK_GExpFee";
            this.col_SubFK_GExpFee.HeaderText = "FK_GExpFee";
            this.col_SubFK_GExpFee.Name = "col_SubFK_GExpFee";
            this.col_SubFK_GExpFee.ReadOnly = true;
            this.col_SubFK_GExpFee.Visible = false;
            // 
            // col_SubMinWeightInt
            // 
            this.col_SubMinWeightInt.DataPropertyName = "MinWeight";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            this.col_SubMinWeightInt.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_SubMinWeightInt.HeaderText = "Cân đầu NT";
            this.col_SubMinWeightInt.Name = "col_SubMinWeightInt";
            this.col_SubMinWeightInt.ReadOnly = true;
            this.col_SubMinWeightInt.ToolTipText = "Cân đầu nội tỉnh";
            // 
            // col_SubMinFeeInt
            // 
            this.col_SubMinFeeInt.DataPropertyName = "MinFee";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            this.col_SubMinFeeInt.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_SubMinFeeInt.HeaderText = "Phí đầu NT";
            this.col_SubMinFeeInt.Name = "col_SubMinFeeInt";
            this.col_SubMinFeeInt.ReadOnly = true;
            this.col_SubMinFeeInt.ToolTipText = "Phí cân đầu nội tỉnh";
            // 
            // col_SubStepWeightInt
            // 
            this.col_SubStepWeightInt.DataPropertyName = "StepWeight";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            this.col_SubStepWeightInt.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_SubStepWeightInt.HeaderText = "Nấc NT";
            this.col_SubStepWeightInt.Name = "col_SubStepWeightInt";
            this.col_SubStepWeightInt.ReadOnly = true;
            this.col_SubStepWeightInt.ToolTipText = "Nấc trọng lượng nội tỉnh";
            // 
            // col_SubNextFeeInt
            // 
            this.col_SubNextFeeInt.DataPropertyName = "NextFee";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            this.col_SubNextFeeInt.DefaultCellStyle = dataGridViewCellStyle6;
            this.col_SubNextFeeInt.HeaderText = "Phí +kg NT";
            this.col_SubNextFeeInt.Name = "col_SubNextFeeInt";
            this.col_SubNextFeeInt.ReadOnly = true;
            this.col_SubNextFeeInt.ToolTipText = "Phí của nấc tiếp theo nội tỉnh";
            // 
            // dataQuanHuyen
            // 
            this.dataQuanHuyen.AllowUserToAddRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.dataQuanHuyen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataQuanHuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataQuanHuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataQuanHuyen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataQuanHuyen.ColumnHeadersHeight = 25;
            this.dataQuanHuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Id,
            this.dataGridViewTextBoxColumn4,
            this.col_Select});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataQuanHuyen.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataQuanHuyen.EnableHeadersVisualStyles = false;
            this.dataQuanHuyen.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataQuanHuyen.HighlightSelectedColumnHeaders = false;
            this.dataQuanHuyen.Location = new System.Drawing.Point(3, 71);
            this.dataQuanHuyen.MultiSelect = false;
            this.dataQuanHuyen.Name = "dataQuanHuyen";
            this.dataQuanHuyen.PaintEnhancedSelection = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataQuanHuyen.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataQuanHuyen.RowHeadersVisible = false;
            this.dataQuanHuyen.RowHeadersWidth = 51;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.dataQuanHuyen.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataQuanHuyen.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataQuanHuyen.RowTemplate.Height = 25;
            this.dataQuanHuyen.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataQuanHuyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataQuanHuyen.Size = new System.Drawing.Size(245, 314);
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
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N0";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle12;
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Format = "N0";
            this.col_Select.DefaultCellStyle = dataGridViewCellStyle13;
            this.col_Select.HeaderText = "Chọn";
            this.col_Select.Name = "col_Select";
            this.col_Select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_Select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_Select.ToolTipText = "Chọn";
            this.col_Select.Width = 50;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 45);
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
            this.cmbTinh.Size = new System.Drawing.Size(196, 22);
            this.cmbTinh.TabIndex = 91;
            this.cmbTinh.SelectedValueChanged += new System.EventHandler(this.cmbTinh_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(255, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 14);
            this.label2.TabIndex = 92;
            this.label2.Text = "Bảng giá:";
            // 
            // txtFeeName
            // 
            this.txtFeeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFeeName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFeeName.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeeName.Location = new System.Drawing.Point(314, 41);
            this.txtFeeName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFeeName.Name = "txtFeeName";
            this.txtFeeName.ReadOnly = true;
            this.txtFeeName.Size = new System.Drawing.Size(556, 22);
            this.txtFeeName.TabIndex = 93;
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // frmQuanLyBangGiaKV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 484);
            this.Controls.Add(this.txtFeeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTinh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataQuanHuyen);
            this.Controls.Add(this.gridChild);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNextFee);
            this.Controls.Add(this.txtStepWeight);
            this.Controls.Add(this.txtMinWeight);
            this.Controls.Add(this.txtMinFee);
            this.Controls.Add(this.panelcomtrol);
            this.Controls.Add(this.lTieude);
            this.Controls.Add(this.lblSubStepWeightInt);
            this.Controls.Add(this.lblSubNextFeeInt);
            this.Controls.Add(this.lblSubMinFeeInt);
            this.Controls.Add(this.lblSubMinWeightInt);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuanLyBangGiaKV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng giá theo khu vực";
            this.Load += new System.EventHandler(this.frmQuanLyBangGiaKV_Load);
            this.panelcomtrol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataQuanHuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTieude;
        private System.Windows.Forms.Panel panelcomtrol;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private System.Windows.Forms.TextBox txtMinWeight;
        private System.Windows.Forms.Label lblSubMinFeeInt;
        private System.Windows.Forms.TextBox txtMinFee;
        private System.Windows.Forms.Label lblSubMinWeightInt;
        private System.Windows.Forms.TextBox txtNextFee;
        private System.Windows.Forms.TextBox txtStepWeight;
        private System.Windows.Forms.Label lblSubStepWeightInt;
        private System.Windows.Forms.Label lblSubNextFeeInt;
        private System.Windows.Forms.Label label8;
        private DevComponents.DotNetBar.Controls.DataGridViewX gridChild;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataQuanHuyen;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.ButtonX btnRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SubId;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SubFK_GExpFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SubMinWeightInt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SubMinFeeInt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SubStepWeightInt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SubNextFeeInt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn col_Select;
        private DevComponents.DotNetBar.StyleManager styleManager;
    }
}