namespace Common
{
    partial class frmexcel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmexcel));
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.lTieude = new System.Windows.Forms.Label();
            this.lblTongSo = new System.Windows.Forms.Label();
            this.lblDaXong = new System.Windows.Forms.Label();
            this.lblConLai = new System.Windows.Forms.Label();
            this.lbTong = new System.Windows.Forms.Label();
            this.lblDa = new System.Windows.Forms.Label();
            this.lblChua = new System.Windows.Forms.Label();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.progressBar = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.SuspendLayout();
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // lTieude
            // 
            this.lTieude.BackColor = System.Drawing.Color.SteelBlue;
            this.lTieude.Dock = System.Windows.Forms.DockStyle.Top;
            this.lTieude.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTieude.ForeColor = System.Drawing.Color.White;
            this.lTieude.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lTieude.Location = new System.Drawing.Point(0, 0);
            this.lTieude.Name = "lTieude";
            this.lTieude.Size = new System.Drawing.Size(399, 30);
            this.lTieude.TabIndex = 301;
            this.lTieude.Text = "     Đang kết xuất dữ liệu vui lòng đợi...";
            this.lTieude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTongSo
            // 
            this.lblTongSo.AutoSize = true;
            this.lblTongSo.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSo.ForeColor = System.Drawing.Color.Black;
            this.lblTongSo.Location = new System.Drawing.Point(9, 33);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(57, 14);
            this.lblTongSo.TabIndex = 303;
            this.lblTongSo.Text = "Số dòng:";
            // 
            // lblDaXong
            // 
            this.lblDaXong.AutoSize = true;
            this.lblDaXong.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaXong.ForeColor = System.Drawing.Color.Black;
            this.lblDaXong.Location = new System.Drawing.Point(9, 53);
            this.lblDaXong.Name = "lblDaXong";
            this.lblDaXong.Size = new System.Drawing.Size(75, 14);
            this.lblDaXong.TabIndex = 304;
            this.lblDaXong.Text = "Đã kết xuất:";
            // 
            // lblConLai
            // 
            this.lblConLai.AutoSize = true;
            this.lblConLai.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConLai.ForeColor = System.Drawing.Color.Black;
            this.lblConLai.Location = new System.Drawing.Point(9, 73);
            this.lblConLai.Name = "lblConLai";
            this.lblConLai.Size = new System.Drawing.Size(95, 14);
            this.lblConLai.TabIndex = 305;
            this.lblConLai.Text = "Số dòng còn lại:";
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTong.Location = new System.Drawing.Point(62, 33);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(35, 14);
            this.lbTong.TabIndex = 306;
            this.lbTong.Text = "1000";
            // 
            // lblDa
            // 
            this.lblDa.AutoSize = true;
            this.lblDa.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDa.Location = new System.Drawing.Point(81, 53);
            this.lblDa.Name = "lblDa";
            this.lblDa.Size = new System.Drawing.Size(35, 14);
            this.lblDa.TabIndex = 307;
            this.lblDa.Text = "1000";
            // 
            // lblChua
            // 
            this.lblChua.AutoSize = true;
            this.lblChua.Font = new System.Drawing.Font("Tahoma", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChua.Location = new System.Drawing.Point(101, 73);
            this.lblChua.Name = "lblChua";
            this.lblChua.Size = new System.Drawing.Size(35, 14);
            this.lblChua.TabIndex = 308;
            this.lblChua.Text = "1000";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Image = global::Common.Properties.Resources.iClose;
            this.btnClose.Location = new System.Drawing.Point(318, 131);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 25);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "&Close";
            // 
            // progressBar
            // 
            // 
            // 
            // 
            this.progressBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBar.Location = new System.Drawing.Point(12, 102);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(375, 23);
            this.progressBar.TabIndex = 309;
            this.progressBar.Text = "progressBarX1";
            // 
            // frmexcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(399, 165);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblChua);
            this.Controls.Add(this.lblDa);
            this.Controls.Add(this.lbTong);
            this.Controls.Add(this.lblConLai);
            this.Controls.Add(this.lblDaXong);
            this.Controls.Add(this.lblTongSo);
            this.Controls.Add(this.lTieude);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmexcel";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export data to excel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label lTieude;
        private System.Windows.Forms.Label lblTongSo;
        private System.Windows.Forms.Label lblDaXong;
        private System.Windows.Forms.Label lblConLai;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.Label lblDa;
        private System.Windows.Forms.Label lblChua;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBar;
    }
}