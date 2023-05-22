namespace LeMaiDesktop
{
	partial class frmProvineProblem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridMain = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProvinceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_KeyWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelcomtrol = new System.Windows.Forms.Panel();
            this.txtSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnPrint = new DevComponents.DotNetBar.ButtonX();
            this.btnNew = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.lTieude = new System.Windows.Forms.Label();
            this.lblProvinceName = new System.Windows.Forms.Label();
            this.txtProvinceName = new System.Windows.Forms.TextBox();
            this.lblKeyWord = new System.Windows.Forms.Label();
            this.txtKeyWord = new System.Windows.Forms.TextBox();
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            this.panelcomtrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridMain
            // 
            this.gridMain.AllowUserToAddRows = false;
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
            this.col_Id,
            this.col_ProvinceName,
            this.col_KeyWord});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMain.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridMain.EnableHeadersVisualStyles = false;
            this.gridMain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.gridMain.HighlightSelectedColumnHeaders = false;
            this.gridMain.Location = new System.Drawing.Point(3, 33);
            this.gridMain.MultiSelect = false;
            this.gridMain.Name = "gridMain";
            this.gridMain.PaintEnhancedSelection = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridMain.RowHeadersVisible = false;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.gridMain.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridMain.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridMain.RowTemplate.Height = 25;
            this.gridMain.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMain.Size = new System.Drawing.Size(797, 490);
            this.gridMain.TabIndex = 5;
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
            // col_ProvinceName
            // 
            this.col_ProvinceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_ProvinceName.DataPropertyName = "ProvinceName";
            this.col_ProvinceName.HeaderText = "Tên tỉnh";
            this.col_ProvinceName.Name = "col_ProvinceName";
            this.col_ProvinceName.ReadOnly = true;
            this.col_ProvinceName.Width = 150;
            // 
            // col_KeyWord
            // 
            this.col_KeyWord.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_KeyWord.DataPropertyName = "KeyWord";
            this.col_KeyWord.HeaderText = "Từ khóa";
            this.col_KeyWord.Name = "col_KeyWord";
            this.col_KeyWord.ReadOnly = true;
            // 
            // panelcomtrol
            // 
            this.panelcomtrol.BackColor = System.Drawing.Color.SteelBlue;
            this.panelcomtrol.Controls.Add(this.txtSearch);
            this.panelcomtrol.Controls.Add(this.btnPrint);
            this.panelcomtrol.Controls.Add(this.btnNew);
            this.panelcomtrol.Controls.Add(this.btnSave);
            this.panelcomtrol.Controls.Add(this.btnEdit);
            this.panelcomtrol.Controls.Add(this.btnDelete);
            this.panelcomtrol.Controls.Add(this.btnClose);
            this.panelcomtrol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelcomtrol.Location = new System.Drawing.Point(0, 561);
            this.panelcomtrol.Name = "panelcomtrol";
            this.panelcomtrol.Size = new System.Drawing.Size(800, 39);
            this.panelcomtrol.TabIndex = 2;
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
            this.txtSearch.TabIndex = 6;
            this.txtSearch.WatermarkColor = System.Drawing.Color.Maroon;
            this.txtSearch.WatermarkFont = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.WatermarkText = "Tìm kiếm...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = global::LeMaiDesktop.Properties.Resources.iPrint;
            this.btnPrint.ImageTextSpacing = 3;
            this.btnPrint.Location = new System.Drawing.Point(615, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(88, 30);
            this.btnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "&In";
            this.btnPrint.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnNew
            // 
            this.btnNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = global::LeMaiDesktop.Properties.Resources.iNew;
            this.btnNew.ImageTextSpacing = 3;
            this.btnNew.Location = new System.Drawing.Point(303, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(77, 30);
            this.btnNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "&Mới";
            this.btnNew.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::LeMaiDesktop.Properties.Resources.iSave;
            this.btnSave.ImageTextSpacing = 3;
            this.btnSave.Location = new System.Drawing.Point(461, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Lưu";
            this.btnSave.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = global::LeMaiDesktop.Properties.Resources.iEdit;
            this.btnEdit.ImageTextSpacing = 3;
            this.btnEdit.Location = new System.Drawing.Point(380, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 30);
            this.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "&Sửa";
            this.btnEdit.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::LeMaiDesktop.Properties.Resources.iCancel;
            this.btnDelete.ImageTextSpacing = 3;
            this.btnDelete.Location = new System.Drawing.Point(536, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 30);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "&Xóa";
            this.btnDelete.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::LeMaiDesktop.Properties.Resources.iExit;
            this.btnClose.ImageTextSpacing = 3;
            this.btnClose.Location = new System.Drawing.Point(703, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 30);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "&Kết thúc";
            this.btnClose.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.lTieude.Size = new System.Drawing.Size(800, 30);
            this.lTieude.TabIndex = 4;
            this.lTieude.Text = "    Khu vực giao hàng có vấn đề";
            this.lTieude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProvinceName
            // 
            this.lblProvinceName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProvinceName.AutoSize = true;
            this.lblProvinceName.ForeColor = System.Drawing.Color.Black;
            this.lblProvinceName.Location = new System.Drawing.Point(12, 534);
            this.lblProvinceName.Name = "lblProvinceName";
            this.lblProvinceName.Size = new System.Drawing.Size(31, 13);
            this.lblProvinceName.TabIndex = 3;
            this.lblProvinceName.Text = "Tỉnh:";
            // 
            // txtProvinceName
            // 
            this.txtProvinceName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtProvinceName.BackColor = System.Drawing.SystemColors.Window;
            this.txtProvinceName.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtProvinceName, true);
            this.txtProvinceName.Location = new System.Drawing.Point(49, 529);
            this.txtProvinceName.MaxLength = 50;
            this.txtProvinceName.Name = "txtProvinceName";
            this.txtProvinceName.Size = new System.Drawing.Size(274, 22);
            this.txtProvinceName.TabIndex = 0;
            this.txtProvinceName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProvinceName_KeyPress);
            // 
            // lblKeyWord
            // 
            this.lblKeyWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblKeyWord.AutoSize = true;
            this.lblKeyWord.ForeColor = System.Drawing.Color.Black;
            this.lblKeyWord.Location = new System.Drawing.Point(326, 534);
            this.lblKeyWord.Name = "lblKeyWord";
            this.lblKeyWord.Size = new System.Drawing.Size(50, 13);
            this.lblKeyWord.TabIndex = 1000;
            this.lblKeyWord.Text = "Từ khóa:";
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtKeyWord.BackColor = System.Drawing.SystemColors.Window;
            this.txtKeyWord.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlighter.SetHighlightOnFocus(this.txtKeyWord, true);
            this.txtKeyWord.Location = new System.Drawing.Point(381, 529);
            this.txtKeyWord.MaxLength = 250;
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(407, 22);
            this.txtKeyWord.TabIndex = 1;
            this.txtKeyWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyWord_KeyPress);
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            this.highlighter.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Green;
            // 
            // frmProvineProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.gridMain);
            this.Controls.Add(this.panelcomtrol);
            this.Controls.Add(this.lTieude);
            this.Controls.Add(this.lblProvinceName);
            this.Controls.Add(this.txtProvinceName);
            this.Controls.Add(this.lblKeyWord);
            this.Controls.Add(this.txtKeyWord);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProvineProblem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khu vực có vấn đề";
            this.Load += new System.EventHandler(this.frmProvineProblem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            this.panelcomtrol.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panelcomtrol;
		private System.Windows.Forms.Label lTieude;
		private DevComponents.DotNetBar.ButtonX btnClose;
		private DevComponents.DotNetBar.ButtonX btnDelete;
		private DevComponents.DotNetBar.ButtonX btnNew;
		private DevComponents.DotNetBar.ButtonX btnSave;
		private DevComponents.DotNetBar.ButtonX btnEdit;
		private DevComponents.DotNetBar.ButtonX btnPrint;
		private DevComponents.DotNetBar.Controls.DataGridViewX gridMain;
		private DevComponents.DotNetBar.Controls.TextBoxX txtSearch;
		private DevComponents.DotNetBar.Validator.Highlighter highlighter;
		private System.Windows.Forms.Label lblProvinceName;
		private System.Windows.Forms.TextBox txtProvinceName;
		private System.Windows.Forms.Label lblKeyWord;
		private System.Windows.Forms.TextBox txtKeyWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProvinceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_KeyWord;
    }
}
