
namespace LeMaiDesktop
{
    partial class frmXuLyDonHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXuLyDonHang));
            this.cmbLoaiXuLy = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viettelPostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ninjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gHNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gHTKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vNPostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.superShipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbTinhTrang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaDonHang = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtComment = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnTruyVan = new DevComponents.DotNetBar.ButtonX();
            this.btnProcess = new DevComponents.DotNetBar.ButtonX();
            this.btnTheoDoiDon = new DevComponents.DotNetBar.ButtonX();
            this.btnDangKyKienVanDe = new DevComponents.DotNetBar.ButtonX();
            this.btnDangKyNoiMang = new DevComponents.DotNetBar.ButtonX();
            this.btnDangKyKienHoTro = new DevComponents.DotNetBar.ButtonX();
            this.btnThucKyNhan = new DevComponents.DotNetBar.ButtonX();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbLoaiXuLy
            // 
            this.cmbLoaiXuLy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoaiXuLy.FormattingEnabled = true;
            this.cmbLoaiXuLy.Location = new System.Drawing.Point(429, 34);
            this.cmbLoaiXuLy.Name = "cmbLoaiXuLy";
            this.cmbLoaiXuLy.Size = new System.Drawing.Size(454, 27);
            this.cmbLoaiXuLy.TabIndex = 0;
            this.cmbLoaiXuLy.SelectedValueChanged += new System.EventHandler(this.cmbLoaiXuLy_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(346, 7);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(84, 20);
            this.label21.TabIndex = 4;
            this.label21.Text = "Tình trạng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(354, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nội dung:";
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.ContextMenuStrip = this.contextMenuStrip;
            this.webBrowser.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser.Location = new System.Drawing.Point(3, 114);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1218, 527);
            this.webBrowser.TabIndex = 8;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viettelPostToolStripMenuItem,
            this.ninjaToolStripMenuItem,
            this.jTToolStripMenuItem,
            this.gHNToolStripMenuItem,
            this.gHTKToolStripMenuItem,
            this.bestToolStripMenuItem,
            this.vNPostToolStripMenuItem,
            this.superShipToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(134, 180);
            // 
            // viettelPostToolStripMenuItem
            // 
            this.viettelPostToolStripMenuItem.Image = global::LeMaiDesktop.Properties.Resources.viettel;
            this.viettelPostToolStripMenuItem.Name = "viettelPostToolStripMenuItem";
            this.viettelPostToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.viettelPostToolStripMenuItem.Text = "Viettel Post";
            this.viettelPostToolStripMenuItem.Click += new System.EventHandler(this.viettelPostToolStripMenuItem_Click);
            // 
            // ninjaToolStripMenuItem
            // 
            this.ninjaToolStripMenuItem.Image = global::LeMaiDesktop.Properties.Resources.ninja;
            this.ninjaToolStripMenuItem.Name = "ninjaToolStripMenuItem";
            this.ninjaToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.ninjaToolStripMenuItem.Text = "Ninja";
            this.ninjaToolStripMenuItem.Click += new System.EventHandler(this.ninjaToolStripMenuItem_Click);
            // 
            // jTToolStripMenuItem
            // 
            this.jTToolStripMenuItem.Image = global::LeMaiDesktop.Properties.Resources.j7t;
            this.jTToolStripMenuItem.Name = "jTToolStripMenuItem";
            this.jTToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.jTToolStripMenuItem.Text = "J&&T";
            this.jTToolStripMenuItem.Click += new System.EventHandler(this.jTToolStripMenuItem_Click);
            // 
            // gHNToolStripMenuItem
            // 
            this.gHNToolStripMenuItem.Image = global::LeMaiDesktop.Properties.Resources.ghn;
            this.gHNToolStripMenuItem.Name = "gHNToolStripMenuItem";
            this.gHNToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.gHNToolStripMenuItem.Text = "GHN";
            this.gHNToolStripMenuItem.Click += new System.EventHandler(this.gHNToolStripMenuItem_Click);
            // 
            // gHTKToolStripMenuItem
            // 
            this.gHTKToolStripMenuItem.Image = global::LeMaiDesktop.Properties.Resources.ghtk;
            this.gHTKToolStripMenuItem.Name = "gHTKToolStripMenuItem";
            this.gHTKToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.gHTKToolStripMenuItem.Text = "GHTK";
            this.gHTKToolStripMenuItem.Click += new System.EventHandler(this.gHTKToolStripMenuItem_Click);
            // 
            // bestToolStripMenuItem
            // 
            this.bestToolStripMenuItem.Image = global::LeMaiDesktop.Properties.Resources.best;
            this.bestToolStripMenuItem.Name = "bestToolStripMenuItem";
            this.bestToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.bestToolStripMenuItem.Text = "Best";
            this.bestToolStripMenuItem.Click += new System.EventHandler(this.bestToolStripMenuItem_Click);
            // 
            // vNPostToolStripMenuItem
            // 
            this.vNPostToolStripMenuItem.Image = global::LeMaiDesktop.Properties.Resources.vnposts;
            this.vNPostToolStripMenuItem.Name = "vNPostToolStripMenuItem";
            this.vNPostToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.vNPostToolStripMenuItem.Text = "VN Post";
            this.vNPostToolStripMenuItem.Click += new System.EventHandler(this.vNPostToolStripMenuItem_Click);
            // 
            // superShipToolStripMenuItem
            // 
            this.superShipToolStripMenuItem.Image = global::LeMaiDesktop.Properties.Resources.supership;
            this.superShipToolStripMenuItem.Name = "superShipToolStripMenuItem";
            this.superShipToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.superShipToolStripMenuItem.Text = "Super Ship";
            this.superShipToolStripMenuItem.Click += new System.EventHandler(this.superShipToolStripMenuItem_Click);
            // 
            // cmbTinhTrang
            // 
            this.cmbTinhTrang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbTinhTrang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTinhTrang.FormattingEnabled = true;
            this.cmbTinhTrang.Location = new System.Drawing.Point(429, 4);
            this.cmbTinhTrang.Name = "cmbTinhTrang";
            this.cmbTinhTrang.Size = new System.Drawing.Size(454, 27);
            this.cmbTinhTrang.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(353, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Loại xử lý:";
            // 
            // txtMaDonHang
            // 
            // 
            // 
            // 
            this.txtMaDonHang.Border.Class = "TextBoxBorder";
            this.txtMaDonHang.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaDonHang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDonHang.Location = new System.Drawing.Point(12, 4);
            this.txtMaDonHang.Multiline = true;
            this.txtMaDonHang.Name = "txtMaDonHang";
            this.txtMaDonHang.Size = new System.Drawing.Size(240, 102);
            this.txtMaDonHang.TabIndex = 23;
            this.txtMaDonHang.WatermarkText = "Mã vận đơn";
            // 
            // txtComment
            // 
            // 
            // 
            // 
            this.txtComment.Border.Class = "TextBoxBorder";
            this.txtComment.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtComment.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.Location = new System.Drawing.Point(429, 66);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(454, 42);
            this.txtComment.TabIndex = 24;
            this.txtComment.WatermarkText = "Nội dung xử lý";
            // 
            // btnTruyVan
            // 
            this.btnTruyVan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTruyVan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTruyVan.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruyVan.Image = global::LeMaiDesktop.Properties.Resources.iSearch;
            this.btnTruyVan.ImageTextSpacing = 3;
            this.btnTruyVan.Location = new System.Drawing.Point(255, 65);
            this.btnTruyVan.Name = "btnTruyVan";
            this.btnTruyVan.Size = new System.Drawing.Size(92, 41);
            this.btnTruyVan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTruyVan.TabIndex = 22;
            this.btnTruyVan.Text = "Truy vấn";
            this.btnTruyVan.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnTruyVan.Click += new System.EventHandler(this.btnTruyVan_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnProcess.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnProcess.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Image = global::LeMaiDesktop.Properties.Resources.iEdit;
            this.btnProcess.ImageTextSpacing = 3;
            this.btnProcess.Location = new System.Drawing.Point(887, 76);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(78, 32);
            this.btnProcess.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "&Xử lý";
            this.btnProcess.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnTheoDoiDon
            // 
            this.btnTheoDoiDon.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTheoDoiDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTheoDoiDon.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTheoDoiDon.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheoDoiDon.Image = global::LeMaiDesktop.Properties.Resources.iSearch;
            this.btnTheoDoiDon.ImageTextSpacing = 3;
            this.btnTheoDoiDon.Location = new System.Drawing.Point(1094, 7);
            this.btnTheoDoiDon.Name = "btnTheoDoiDon";
            this.btnTheoDoiDon.Size = new System.Drawing.Size(116, 30);
            this.btnTheoDoiDon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTheoDoiDon.TabIndex = 25;
            this.btnTheoDoiDon.Text = "Theo dõi đơn";
            this.btnTheoDoiDon.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnTheoDoiDon.Click += new System.EventHandler(this.btnTheoDoiDon_Click);
            // 
            // btnDangKyKienVanDe
            // 
            this.btnDangKyKienVanDe.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDangKyKienVanDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangKyKienVanDe.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDangKyKienVanDe.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKyKienVanDe.Image = global::LeMaiDesktop.Properties.Resources.add;
            this.btnDangKyKienVanDe.ImageTextSpacing = 3;
            this.btnDangKyKienVanDe.Location = new System.Drawing.Point(1094, 42);
            this.btnDangKyKienVanDe.Name = "btnDangKyKienVanDe";
            this.btnDangKyKienVanDe.Size = new System.Drawing.Size(116, 30);
            this.btnDangKyKienVanDe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDangKyKienVanDe.TabIndex = 26;
            this.btnDangKyKienVanDe.Text = "Kiện vấn đề";
            this.btnDangKyKienVanDe.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnDangKyKienVanDe.Click += new System.EventHandler(this.btnDangKyKienVanDe_Click);
            // 
            // btnDangKyNoiMang
            // 
            this.btnDangKyNoiMang.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDangKyNoiMang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangKyNoiMang.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDangKyNoiMang.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKyNoiMang.Image = global::LeMaiDesktop.Properties.Resources.addrow;
            this.btnDangKyNoiMang.ImageTextSpacing = 3;
            this.btnDangKyNoiMang.Location = new System.Drawing.Point(1094, 77);
            this.btnDangKyNoiMang.Name = "btnDangKyNoiMang";
            this.btnDangKyNoiMang.Size = new System.Drawing.Size(116, 30);
            this.btnDangKyNoiMang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDangKyNoiMang.TabIndex = 27;
            this.btnDangKyNoiMang.Text = "Kiện nội mạng";
            this.btnDangKyNoiMang.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnDangKyNoiMang.Click += new System.EventHandler(this.btnDangKyNoiMang_Click);
            // 
            // btnDangKyKienHoTro
            // 
            this.btnDangKyKienHoTro.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDangKyKienHoTro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangKyKienHoTro.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDangKyKienHoTro.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKyKienHoTro.Image = global::LeMaiDesktop.Properties.Resources.iPlay;
            this.btnDangKyKienHoTro.ImageTextSpacing = 3;
            this.btnDangKyKienHoTro.Location = new System.Drawing.Point(968, 7);
            this.btnDangKyKienHoTro.Name = "btnDangKyKienHoTro";
            this.btnDangKyKienHoTro.Size = new System.Drawing.Size(121, 30);
            this.btnDangKyKienHoTro.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDangKyKienHoTro.TabIndex = 28;
            this.btnDangKyKienHoTro.Text = "Thúc giao hàng";
            this.btnDangKyKienHoTro.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnDangKyKienHoTro.Click += new System.EventHandler(this.btnDangKyKienHoTro_Click);
            // 
            // btnThucKyNhan
            // 
            this.btnThucKyNhan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThucKyNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThucKyNhan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThucKyNhan.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThucKyNhan.Image = global::LeMaiDesktop.Properties.Resources.Done;
            this.btnThucKyNhan.ImageTextSpacing = 3;
            this.btnThucKyNhan.Location = new System.Drawing.Point(968, 42);
            this.btnThucKyNhan.Name = "btnThucKyNhan";
            this.btnThucKyNhan.Size = new System.Drawing.Size(121, 30);
            this.btnThucKyNhan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThucKyNhan.TabIndex = 29;
            this.btnThucKyNhan.Text = "Thúc ký nhận";
            this.btnThucKyNhan.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            // 
            // frmXuLyDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 641);
            this.Controls.Add(this.btnThucKyNhan);
            this.Controls.Add(this.btnDangKyKienHoTro);
            this.Controls.Add(this.btnDangKyNoiMang);
            this.Controls.Add(this.btnDangKyKienVanDe);
            this.Controls.Add(this.btnTheoDoiDon);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtMaDonHang);
            this.Controls.Add(this.btnTruyVan);
            this.Controls.Add(this.cmbTinhTrang);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.cmbLoaiXuLy);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmXuLyDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xử lý đơn hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmXuLyDonHang_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cmbLoaiXuLy;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX btnProcess;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.ComboBox cmbTinhTrang;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.ButtonX btnTruyVan;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem viettelPostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ninjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gHNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gHTKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestToolStripMenuItem;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaDonHang;
        private DevComponents.DotNetBar.Controls.TextBoxX txtComment;
        private System.Windows.Forms.ToolStripMenuItem vNPostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem superShipToolStripMenuItem;
        private DevComponents.DotNetBar.ButtonX btnTheoDoiDon;
        private DevComponents.DotNetBar.ButtonX btnDangKyKienVanDe;
        private DevComponents.DotNetBar.ButtonX btnDangKyNoiMang;
        private DevComponents.DotNetBar.ButtonX btnDangKyKienHoTro;
        private DevComponents.DotNetBar.ButtonX btnThucKyNhan;
    }
}