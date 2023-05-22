
namespace LeMaiDesktop
{
    partial class frmNhapKetToan
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
            this.btnKetToanC1 = new DevComponents.DotNetBar.ButtonX();
            this.txtFileChiTietKetToanC1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.lblWaitCount = new System.Windows.Forms.Label();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKetToanC1
            // 
            this.btnKetToanC1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnKetToanC1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnKetToanC1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetToanC1.ImageTextSpacing = 3;
            this.btnKetToanC1.Location = new System.Drawing.Point(521, 48);
            this.btnKetToanC1.Name = "btnKetToanC1";
            this.btnKetToanC1.Size = new System.Drawing.Size(63, 25);
            this.btnKetToanC1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnKetToanC1.TabIndex = 1385;
            this.btnKetToanC1.Text = ":::";
            this.btnKetToanC1.Click += new System.EventHandler(this.btnKetToanC1_Click);
            // 
            // txtFileChiTietKetToanC1
            // 
            this.txtFileChiTietKetToanC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileChiTietKetToanC1.Location = new System.Drawing.Point(128, 50);
            this.txtFileChiTietKetToanC1.Name = "txtFileChiTietKetToanC1";
            this.txtFileChiTietKetToanC1.Size = new System.Drawing.Size(387, 21);
            this.txtFileChiTietKetToanC1.TabIndex = 1384;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 1383;
            this.label1.Text = "Chi tiết kết toán:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.progressBar);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.lblWaitCount);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 39);
            this.panel2.TabIndex = 1386;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(52, 8);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(348, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 1283;
            this.progressBar.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::LeMaiDesktop.Properties.Resources.iSave;
            this.btnSave.ImageTextSpacing = 3;
            this.btnSave.Location = new System.Drawing.Point(406, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 30);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 1282;
            this.btnSave.Text = "Nạp kết toán";
            this.btnSave.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblWaitCount
            // 
            this.lblWaitCount.AutoSize = true;
            this.lblWaitCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaitCount.ForeColor = System.Drawing.Color.White;
            this.lblWaitCount.Location = new System.Drawing.Point(5, 9);
            this.lblWaitCount.Name = "lblWaitCount";
            this.lblWaitCount.Size = new System.Drawing.Size(19, 20);
            this.lblWaitCount.TabIndex = 77;
            this.lblWaitCount.Text = "0";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::LeMaiDesktop.Properties.Resources.iExit;
            this.btnClose.ImageTextSpacing = 3;
            this.btnClose.Location = new System.Drawing.Point(504, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 30);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "&Kết thúc";
            this.btnClose.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(0, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(590, 38);
            this.label2.TabIndex = 1387;
            this.label2.Text = "Kéo rộng cột mã đơn đặt sau đó lưu file lại trước khi chạy chương trình để được s" +
    "ố liệu đúng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // frmNhapKetToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 126);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnKetToanC1);
            this.Controls.Add(this.txtFileChiTietKetToanC1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNhapKetToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập kết toán";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.DotNetBar.ButtonX btnKetToanC1;
        private System.Windows.Forms.TextBox txtFileChiTietKetToanC1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar progressBar;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private System.Windows.Forms.Label lblWaitCount;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}