namespace LeMaiDesktop
{
    partial class frmTrackingAndProcess
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
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnXemHanhTrinhBenDVT3 = new DevComponents.DotNetBar.ButtonX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.cmbTinhTrang = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbLoaiXuLy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCapNhatTT = new DevComponents.DotNetBar.ButtonX();
            this.btnXuLyDon = new DevComponents.DotNetBar.ButtonX();
            this.txtComment = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ucBillMain = new LeMaiDesktop.ucBill();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.SteelBlue;
            this.panel8.Controls.Add(this.btnXemHanhTrinhBenDVT3);
            this.panel8.Controls.Add(this.btnThoat);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 690);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1264, 39);
            this.panel8.TabIndex = 1185;
            // 
            // btnXemHanhTrinhBenDVT3
            // 
            this.btnXemHanhTrinhBenDVT3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXemHanhTrinhBenDVT3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXemHanhTrinhBenDVT3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemHanhTrinhBenDVT3.Image = global::LeMaiDesktop.Properties.Resources.Done;
            this.btnXemHanhTrinhBenDVT3.ImageTextSpacing = 3;
            this.btnXemHanhTrinhBenDVT3.Location = new System.Drawing.Point(9, 8);
            this.btnXemHanhTrinhBenDVT3.Name = "btnXemHanhTrinhBenDVT3";
            this.btnXemHanhTrinhBenDVT3.Size = new System.Drawing.Size(143, 25);
            this.btnXemHanhTrinhBenDVT3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXemHanhTrinhBenDVT3.TabIndex = 1194;
            this.btnXemHanhTrinhBenDVT3.Text = "Xem hành trình BT3";
            this.btnXemHanhTrinhBenDVT3.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnXemHanhTrinhBenDVT3.Click += new System.EventHandler(this.btnXemHanhTrinhBenDVT3_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::LeMaiDesktop.Properties.Resources.Close;
            this.btnThoat.ImageTextSpacing = 3;
            this.btnThoat.Location = new System.Drawing.Point(1171, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(88, 30);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser.Location = new System.Drawing.Point(0, 226);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1259, 462);
            this.webBrowser.TabIndex = 1186;
            // 
            // cmbTinhTrang
            // 
            this.cmbTinhTrang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cmbTinhTrang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTinhTrang.FormattingEnabled = true;
            this.cmbTinhTrang.Location = new System.Drawing.Point(75, 194);
            this.cmbTinhTrang.Name = "cmbTinhTrang";
            this.cmbTinhTrang.Size = new System.Drawing.Size(194, 22);
            this.cmbTinhTrang.TabIndex = 1188;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(6, 198);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 15);
            this.label21.TabIndex = 1187;
            this.label21.Text = "Tình trạng:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbLoaiXuLy
            // 
            this.cmbLoaiXuLy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbLoaiXuLy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoaiXuLy.FormattingEnabled = true;
            this.cmbLoaiXuLy.Location = new System.Drawing.Point(455, 194);
            this.cmbLoaiXuLy.Name = "cmbLoaiXuLy";
            this.cmbLoaiXuLy.Size = new System.Drawing.Size(207, 22);
            this.cmbLoaiXuLy.TabIndex = 1189;
            this.cmbLoaiXuLy.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiXuLy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(399, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 1190;
            this.label2.Text = "NV Xử lý:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(50, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1200, 3);
            this.label11.TabIndex = 1191;
            // 
            // btnCapNhatTT
            // 
            this.btnCapNhatTT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCapNhatTT.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCapNhatTT.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatTT.Image = global::LeMaiDesktop.Properties.Resources.iChange;
            this.btnCapNhatTT.ImageTextSpacing = 3;
            this.btnCapNhatTT.Location = new System.Drawing.Point(275, 193);
            this.btnCapNhatTT.Name = "btnCapNhatTT";
            this.btnCapNhatTT.Size = new System.Drawing.Size(116, 25);
            this.btnCapNhatTT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCapNhatTT.TabIndex = 1192;
            this.btnCapNhatTT.Text = "Update TT đơn";
            this.btnCapNhatTT.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnCapNhatTT.Click += new System.EventHandler(this.btnCapNhatTT_Click);
            // 
            // btnXuLyDon
            // 
            this.btnXuLyDon.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXuLyDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuLyDon.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXuLyDon.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuLyDon.Image = global::LeMaiDesktop.Properties.Resources.Done;
            this.btnXuLyDon.ImageTextSpacing = 3;
            this.btnXuLyDon.Location = new System.Drawing.Point(1158, 193);
            this.btnXuLyDon.Name = "btnXuLyDon";
            this.btnXuLyDon.Size = new System.Drawing.Size(99, 25);
            this.btnXuLyDon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXuLyDon.TabIndex = 1193;
            this.btnXuLyDon.Text = "Xử lý đơn";
            this.btnXuLyDon.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnXuLyDon.Click += new System.EventHandler(this.btnXuLyDon_Click);
            // 
            // txtComment
            // 
            this.txtComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.txtComment.Border.Class = "TextBoxBorder";
            this.txtComment.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtComment.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.Location = new System.Drawing.Point(668, 194);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(484, 22);
            this.txtComment.TabIndex = 1194;
            this.txtComment.WatermarkText = "Nội dung xử lý";
            // 
            // ucBillMain
            // 
            this.ucBillMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucBillMain.Location = new System.Drawing.Point(7, 7);
            this.ucBillMain.Name = "ucBillMain";
            this.ucBillMain.Size = new System.Drawing.Size(1248, 175);
            this.ucBillMain.TabIndex = 1184;
            // 
            // frmTrackingAndProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.btnXuLyDon);
            this.Controls.Add(this.btnCapNhatTT);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbLoaiXuLy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTinhTrang);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.ucBillMain);
            this.Name = "frmTrackingAndProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Theo dõi hành trình và xử lý đơn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucBill ucBillMain;
        private System.Windows.Forms.Panel panel8;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.ComboBox cmbTinhTrang;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cmbLoaiXuLy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private DevComponents.DotNetBar.ButtonX btnCapNhatTT;
        private DevComponents.DotNetBar.ButtonX btnXuLyDon;
        private DevComponents.DotNetBar.Controls.TextBoxX txtComment;
        private DevComponents.DotNetBar.ButtonX btnXemHanhTrinhBenDVT3;
    }
}