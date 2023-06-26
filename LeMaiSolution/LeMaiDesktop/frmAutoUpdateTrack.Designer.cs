namespace LeMaiDesktop
{
    partial class frmAutoUpdateTrack
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
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.txtMaDonHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNguoiGui = new System.Windows.Forms.TextBox();
            this.txtSoDienThoaiNguoiGui = new System.Windows.Forms.TextBox();
            this.lblNguoiGui = new System.Windows.Forms.Label();
            this.lblSoDienThoaiNguoiGui = new System.Windows.Forms.Label();
            this.txtBT3Code = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNguoiNhan = new System.Windows.Forms.TextBox();
            this.txtSoDienThoaiNguoiNhan = new System.Windows.Forms.TextBox();
            this.lblNguoiNhan = new System.Windows.Forms.Label();
            this.lblSoDienThoaiNguoiNhan = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnRun = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.txtSystemDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNgayGui = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.timerwebhook = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorkerWH = new System.ComponentModel.BackgroundWorker();
            this.timerSign = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorkerSign = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẬP NHẬT HÀNH TRÌNH ĐƠN HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(17, 214);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(297, 23);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 80;
            this.progressBar.Visible = false;
            // 
            // txtMaDonHang
            // 
            this.txtMaDonHang.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaDonHang.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDonHang.Location = new System.Drawing.Point(73, 84);
            this.txtMaDonHang.MaxLength = 100;
            this.txtMaDonHang.Name = "txtMaDonHang";
            this.txtMaDonHang.ReadOnly = true;
            this.txtMaDonHang.Size = new System.Drawing.Size(163, 22);
            this.txtMaDonHang.TabIndex = 1408;
            this.txtMaDonHang.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(30, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1409;
            this.label2.Text = "Code:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(12, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 20);
            this.label8.TabIndex = 1410;
            this.label8.Text = "THÔNG TIN ĐƠN HÀNG";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNguoiGui
            // 
            this.txtNguoiGui.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNguoiGui.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiGui.Location = new System.Drawing.Point(325, 115);
            this.txtNguoiGui.MaxLength = 100;
            this.txtNguoiGui.Name = "txtNguoiGui";
            this.txtNguoiGui.ReadOnly = true;
            this.txtNguoiGui.Size = new System.Drawing.Size(163, 22);
            this.txtNguoiGui.TabIndex = 1412;
            // 
            // txtSoDienThoaiNguoiGui
            // 
            this.txtSoDienThoaiNguoiGui.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSoDienThoaiNguoiGui.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoaiNguoiGui.Location = new System.Drawing.Point(73, 115);
            this.txtSoDienThoaiNguoiGui.MaxLength = 10;
            this.txtSoDienThoaiNguoiGui.Name = "txtSoDienThoaiNguoiGui";
            this.txtSoDienThoaiNguoiGui.ReadOnly = true;
            this.txtSoDienThoaiNguoiGui.Size = new System.Drawing.Size(163, 22);
            this.txtSoDienThoaiNguoiGui.TabIndex = 1411;
            // 
            // lblNguoiGui
            // 
            this.lblNguoiGui.AutoSize = true;
            this.lblNguoiGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguoiGui.ForeColor = System.Drawing.Color.Black;
            this.lblNguoiGui.Location = new System.Drawing.Point(264, 119);
            this.lblNguoiGui.Name = "lblNguoiGui";
            this.lblNguoiGui.Size = new System.Drawing.Size(63, 15);
            this.lblNguoiGui.TabIndex = 1414;
            this.lblNguoiGui.Text = "Người gửi:";
            // 
            // lblSoDienThoaiNguoiGui
            // 
            this.lblSoDienThoaiNguoiGui.AutoSize = true;
            this.lblSoDienThoaiNguoiGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDienThoaiNguoiGui.ForeColor = System.Drawing.Color.Black;
            this.lblSoDienThoaiNguoiGui.Location = new System.Drawing.Point(18, 119);
            this.lblSoDienThoaiNguoiGui.Name = "lblSoDienThoaiNguoiGui";
            this.lblSoDienThoaiNguoiGui.Size = new System.Drawing.Size(56, 15);
            this.lblSoDienThoaiNguoiGui.TabIndex = 1413;
            this.lblSoDienThoaiNguoiGui.Text = "SĐT Gửi:";
            // 
            // txtBT3Code
            // 
            this.txtBT3Code.BackColor = System.Drawing.SystemColors.Window;
            this.txtBT3Code.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBT3Code.Location = new System.Drawing.Point(325, 81);
            this.txtBT3Code.MaxLength = 100;
            this.txtBT3Code.Name = "txtBT3Code";
            this.txtBT3Code.ReadOnly = true;
            this.txtBT3Code.Size = new System.Drawing.Size(163, 22);
            this.txtBT3Code.TabIndex = 1415;
            this.txtBT3Code.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(258, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 1416;
            this.label3.Text = "BT3Code:";
            // 
            // txtNguoiNhan
            // 
            this.txtNguoiNhan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNguoiNhan.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiNhan.Location = new System.Drawing.Point(325, 146);
            this.txtNguoiNhan.MaxLength = 100;
            this.txtNguoiNhan.Name = "txtNguoiNhan";
            this.txtNguoiNhan.ReadOnly = true;
            this.txtNguoiNhan.Size = new System.Drawing.Size(163, 22);
            this.txtNguoiNhan.TabIndex = 1418;
            // 
            // txtSoDienThoaiNguoiNhan
            // 
            this.txtSoDienThoaiNguoiNhan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSoDienThoaiNguoiNhan.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoaiNguoiNhan.Location = new System.Drawing.Point(73, 146);
            this.txtSoDienThoaiNguoiNhan.MaxLength = 10;
            this.txtSoDienThoaiNguoiNhan.Name = "txtSoDienThoaiNguoiNhan";
            this.txtSoDienThoaiNguoiNhan.ReadOnly = true;
            this.txtSoDienThoaiNguoiNhan.Size = new System.Drawing.Size(163, 22);
            this.txtSoDienThoaiNguoiNhan.TabIndex = 1417;
            // 
            // lblNguoiNhan
            // 
            this.lblNguoiNhan.AutoSize = true;
            this.lblNguoiNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguoiNhan.ForeColor = System.Drawing.Color.Black;
            this.lblNguoiNhan.Location = new System.Drawing.Point(253, 150);
            this.lblNguoiNhan.Name = "lblNguoiNhan";
            this.lblNguoiNhan.Size = new System.Drawing.Size(74, 15);
            this.lblNguoiNhan.TabIndex = 1420;
            this.lblNguoiNhan.Text = "Người nhận:";
            // 
            // lblSoDienThoaiNguoiNhan
            // 
            this.lblSoDienThoaiNguoiNhan.AutoSize = true;
            this.lblSoDienThoaiNguoiNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDienThoaiNguoiNhan.ForeColor = System.Drawing.Color.Black;
            this.lblSoDienThoaiNguoiNhan.Location = new System.Drawing.Point(8, 150);
            this.lblSoDienThoaiNguoiNhan.Name = "lblSoDienThoaiNguoiNhan";
            this.lblSoDienThoaiNguoiNhan.Size = new System.Drawing.Size(67, 15);
            this.lblSoDienThoaiNguoiNhan.TabIndex = 1419;
            this.lblSoDienThoaiNguoiNhan.Text = "SĐT Nhận:";
            // 
            // timer
            // 
            this.timer.Interval = 3000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnRun
            // 
            this.btnRun.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRun.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Image = global::LeMaiDesktop.Properties.Resources.iPlay;
            this.btnRun.ImageTextSpacing = 3;
            this.btnRun.Location = new System.Drawing.Point(320, 210);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(96, 30);
            this.btnRun.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Đang dừng";
            this.btnRun.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::LeMaiDesktop.Properties.Resources.iExit;
            this.btnClose.ImageTextSpacing = 3;
            this.btnClose.Location = new System.Drawing.Point(419, 210);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 30);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Kết thúc";
            this.btnClose.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // txtSystemDate
            // 
            this.txtSystemDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSystemDate.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSystemDate.Location = new System.Drawing.Point(73, 176);
            this.txtSystemDate.MaxLength = 10;
            this.txtSystemDate.Name = "txtSystemDate";
            this.txtSystemDate.ReadOnly = true;
            this.txtSystemDate.Size = new System.Drawing.Size(163, 22);
            this.txtSystemDate.TabIndex = 1421;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(25, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 1423;
            this.label5.Text = "Update:";
            // 
            // txtNgayGui
            // 
            this.txtNgayGui.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNgayGui.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayGui.Location = new System.Drawing.Point(325, 176);
            this.txtNgayGui.MaxLength = 10;
            this.txtNgayGui.Name = "txtNgayGui";
            this.txtNgayGui.ReadOnly = true;
            this.txtNgayGui.Size = new System.Drawing.Size(163, 22);
            this.txtNgayGui.TabIndex = 1424;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(269, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 1425;
            this.label4.Text = "Ngày gửi:";
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // timerwebhook
            // 
            this.timerwebhook.Interval = 300000;
            this.timerwebhook.Tick += new System.EventHandler(this.timerwebhook_Tick);
            // 
            // backgroundWorkerWH
            // 
            this.backgroundWorkerWH.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerWH_DoWork);
            this.backgroundWorkerWH.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerWH_RunWorkerCompleted);
            // 
            // timerSign
            // 
            this.timerSign.Interval = 30000;
            this.timerSign.Tick += new System.EventHandler(this.timerSign_Tick);
            // 
            // backgroundWorkerSign
            // 
            this.backgroundWorkerSign.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSign_DoWork);
            this.backgroundWorkerSign.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerSign_RunWorkerCompleted);
            // 
            // frmAutoUpdateTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 252);
            this.Controls.Add(this.txtNgayGui);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSystemDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNguoiNhan);
            this.Controls.Add(this.txtSoDienThoaiNguoiNhan);
            this.Controls.Add(this.lblNguoiNhan);
            this.Controls.Add(this.lblSoDienThoaiNguoiNhan);
            this.Controls.Add(this.txtBT3Code);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNguoiGui);
            this.Controls.Add(this.txtSoDienThoaiNguoiGui);
            this.Controls.Add(this.lblNguoiGui);
            this.Controls.Add(this.lblSoDienThoaiNguoiGui);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMaDonHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAutoUpdateTrack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật hành trình đơn hàng";
            this.Load += new System.EventHandler(this.frmAutoUpdateTrack_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX btnRun;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox txtMaDonHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNguoiGui;
        private System.Windows.Forms.TextBox txtSoDienThoaiNguoiGui;
        private System.Windows.Forms.Label lblNguoiGui;
        private System.Windows.Forms.Label lblSoDienThoaiNguoiGui;
        private System.Windows.Forms.TextBox txtBT3Code;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNguoiNhan;
        private System.Windows.Forms.TextBox txtSoDienThoaiNguoiNhan;
        private System.Windows.Forms.Label lblNguoiNhan;
        private System.Windows.Forms.Label lblSoDienThoaiNguoiNhan;
        private System.Windows.Forms.Timer timer;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.TextBox txtSystemDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNgayGui;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.StyleManager styleManager;
        private System.Windows.Forms.Timer timerwebhook;
        private System.ComponentModel.BackgroundWorker backgroundWorkerWH;
        private System.Windows.Forms.Timer timerSign;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSign;
    }
}