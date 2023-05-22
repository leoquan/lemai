
namespace LeMaiDesktop
{
    partial class frmSetUpdateProvinceVTP
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
            this.gridata = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDuLieuHuyen = new DevComponents.DotNetBar.ButtonX();
            this.btnLayDuLieuTinh = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnLoadDuLieu = new DevComponents.DotNetBar.ButtonX();
            this.cmbTinh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHuyen = new System.Windows.Forms.ComboBox();
            this.btnLoadHuyen = new DevComponents.DotNetBar.ButtonX();
            this.btnLoadXa = new DevComponents.DotNetBar.ButtonX();
            this.btnMap = new DevComponents.DotNetBar.ButtonX();
            this.btnMapAll = new DevComponents.DotNetBar.ButtonItem();
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridata)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridata
            // 
            this.gridata.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.gridata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridata.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridata.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridata.EnableHeadersVisualStyles = false;
            this.gridata.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.gridata.HighlightSelectedColumnHeaders = false;
            this.gridata.Location = new System.Drawing.Point(5, 99);
            this.gridata.MultiSelect = false;
            this.gridata.Name = "gridata";
            this.gridata.PaintEnhancedSelection = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridata.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridata.RowHeadersVisible = false;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.gridata.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridata.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridata.RowTemplate.Height = 25;
            this.gridata.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridata.Size = new System.Drawing.Size(648, 611);
            this.gridata.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.btnDuLieuHuyen);
            this.panel2.Controls.Add(this.btnLayDuLieuTinh);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 719);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(653, 39);
            this.panel2.TabIndex = 32;
            // 
            // btnDuLieuHuyen
            // 
            this.btnDuLieuHuyen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDuLieuHuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDuLieuHuyen.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDuLieuHuyen.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuLieuHuyen.Image = global::LeMaiDesktop.Properties.Resources.iChange;
            this.btnDuLieuHuyen.ImageTextSpacing = 3;
            this.btnDuLieuHuyen.Location = new System.Drawing.Point(144, 5);
            this.btnDuLieuHuyen.Name = "btnDuLieuHuyen";
            this.btnDuLieuHuyen.Size = new System.Drawing.Size(133, 30);
            this.btnDuLieuHuyen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDuLieuHuyen.TabIndex = 4;
            this.btnDuLieuHuyen.Text = "Load dữ liệu xã";
            this.btnDuLieuHuyen.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnDuLieuHuyen.Click += new System.EventHandler(this.btnDuLieuHuyen_Click);
            // 
            // btnLayDuLieuTinh
            // 
            this.btnLayDuLieuTinh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLayDuLieuTinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLayDuLieuTinh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLayDuLieuTinh.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLayDuLieuTinh.Image = global::LeMaiDesktop.Properties.Resources.iChange;
            this.btnLayDuLieuTinh.ImageTextSpacing = 3;
            this.btnLayDuLieuTinh.Location = new System.Drawing.Point(5, 5);
            this.btnLayDuLieuTinh.Name = "btnLayDuLieuTinh";
            this.btnLayDuLieuTinh.Size = new System.Drawing.Size(133, 30);
            this.btnLayDuLieuTinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLayDuLieuTinh.TabIndex = 3;
            this.btnLayDuLieuTinh.Text = "Load dữ liệu huyện";
            this.btnLayDuLieuTinh.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnLayDuLieuTinh.Click += new System.EventHandler(this.btnLayDuLieu_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::LeMaiDesktop.Properties.Resources.stt;
            this.btnSave.ImageTextSpacing = 3;
            this.btnSave.Location = new System.Drawing.Point(469, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 30);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Cập nhật";
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
            this.btnClose.Location = new System.Drawing.Point(563, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 30);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Kết thúc";
            this.btnClose.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLoadDuLieu
            // 
            this.btnLoadDuLieu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLoadDuLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadDuLieu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLoadDuLieu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadDuLieu.Image = global::LeMaiDesktop.Properties.Resources.iChange;
            this.btnLoadDuLieu.ImageTextSpacing = 3;
            this.btnLoadDuLieu.Location = new System.Drawing.Point(313, 3);
            this.btnLoadDuLieu.Name = "btnLoadDuLieu";
            this.btnLoadDuLieu.Size = new System.Drawing.Size(115, 25);
            this.btnLoadDuLieu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLoadDuLieu.TabIndex = 2;
            this.btnLoadDuLieu.Text = "Load Tỉnh";
            this.btnLoadDuLieu.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnLoadDuLieu.Click += new System.EventHandler(this.btnLoadTinh_Click);
            // 
            // cmbTinh
            // 
            this.cmbTinh.FormattingEnabled = true;
            this.cmbTinh.Location = new System.Drawing.Point(67, 36);
            this.cmbTinh.Name = "cmbTinh";
            this.cmbTinh.Size = new System.Drawing.Size(239, 21);
            this.cmbTinh.TabIndex = 33;
            this.cmbTinh.SelectedValueChanged += new System.EventHandler(this.cmbTinh_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Tỉnh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Huyện:";
            // 
            // cmbHuyen
            // 
            this.cmbHuyen.FormattingEnabled = true;
            this.cmbHuyen.Location = new System.Drawing.Point(67, 65);
            this.cmbHuyen.Name = "cmbHuyen";
            this.cmbHuyen.Size = new System.Drawing.Size(239, 21);
            this.cmbHuyen.TabIndex = 35;
            // 
            // btnLoadHuyen
            // 
            this.btnLoadHuyen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLoadHuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadHuyen.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLoadHuyen.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadHuyen.Image = global::LeMaiDesktop.Properties.Resources.iChange;
            this.btnLoadHuyen.ImageTextSpacing = 3;
            this.btnLoadHuyen.Location = new System.Drawing.Point(313, 32);
            this.btnLoadHuyen.Name = "btnLoadHuyen";
            this.btnLoadHuyen.Size = new System.Drawing.Size(115, 25);
            this.btnLoadHuyen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLoadHuyen.TabIndex = 37;
            this.btnLoadHuyen.Text = "Load Huyện";
            this.btnLoadHuyen.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnLoadHuyen.Click += new System.EventHandler(this.btnLoadHuyen_Click);
            // 
            // btnLoadXa
            // 
            this.btnLoadXa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLoadXa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadXa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLoadXa.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadXa.Image = global::LeMaiDesktop.Properties.Resources.iChange;
            this.btnLoadXa.ImageTextSpacing = 3;
            this.btnLoadXa.Location = new System.Drawing.Point(313, 63);
            this.btnLoadXa.Name = "btnLoadXa";
            this.btnLoadXa.Size = new System.Drawing.Size(115, 25);
            this.btnLoadXa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLoadXa.TabIndex = 38;
            this.btnLoadXa.Text = "Load Xã";
            this.btnLoadXa.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnLoadXa.Click += new System.EventHandler(this.btnLoadXa_Click);
            // 
            // btnMap
            // 
            this.btnMap.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMap.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnMap.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMap.Image = global::LeMaiDesktop.Properties.Resources.iChange;
            this.btnMap.ImageTextSpacing = 3;
            this.btnMap.Location = new System.Drawing.Point(435, 3);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(126, 85);
            this.btnMap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMap.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnMapAll});
            this.btnMap.TabIndex = 39;
            this.btnMap.Text = "Tự động map";
            this.btnMap.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // btnMapAll
            // 
            this.btnMapAll.GlobalItem = false;
            this.btnMapAll.Name = "btnMapAll";
            this.btnMapAll.Text = "Map all";
            this.btnMapAll.Click += new System.EventHandler(this.btnMapAll_Click);
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // frmSetUpdateProvinceVTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 758);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.btnLoadXa);
            this.Controls.Add(this.btnLoadHuyen);
            this.Controls.Add(this.btnLoadDuLieu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbHuyen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTinh);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gridata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetUpdateProvinceVTP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Province VTP";
            this.Load += new System.EventHandler(this.frmSetUpdateProvince_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridata)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX gridata;
        private System.Windows.Forms.BindingSource gExpProvinceBindingSource;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.ButtonX btnLoadDuLieu;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnClose;
        
        private System.Windows.Forms.ComboBox cmbTinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHuyen;
        private DevComponents.DotNetBar.ButtonX btnLoadHuyen;
        private DevComponents.DotNetBar.ButtonX btnLoadXa;
        private DevComponents.DotNetBar.ButtonX btnMap;
        private DevComponents.DotNetBar.ButtonItem btnMapAll;
        private DevComponents.DotNetBar.ButtonX btnLayDuLieuTinh;
        private DevComponents.DotNetBar.ButtonX btnDuLieuHuyen;
        private DevComponents.DotNetBar.StyleManager styleManager;
    }
}