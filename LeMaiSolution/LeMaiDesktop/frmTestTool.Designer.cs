
namespace LeMaiDesktop
{
    partial class frmTestTool
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
            this.btnWardInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFolderJson = new System.Windows.Forms.TextBox();
            this.btnBrowserFolderWard = new System.Windows.Forms.Button();
            this.btnTestAPI = new System.Windows.Forms.Button();
            this.btnHuyenVN = new System.Windows.Forms.Button();
            this.btnNapXa = new System.Windows.Forms.Button();
            this.butTaoDanhBa = new System.Windows.Forms.Button();
            this.btnSaiLech = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWardInsert
            // 
            this.btnWardInsert.Location = new System.Drawing.Point(629, 20);
            this.btnWardInsert.Name = "btnWardInsert";
            this.btnWardInsert.Size = new System.Drawing.Size(159, 23);
            this.btnWardInsert.TabIndex = 0;
            this.btnWardInsert.Text = "Nhập xã phường GHN";
            this.btnWardInsert.UseVisualStyleBackColor = true;
            this.btnWardInsert.Click += new System.EventHandler(this.btnWardInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thư mục Json ward:";
            // 
            // txtFolderJson
            // 
            this.txtFolderJson.Location = new System.Drawing.Point(141, 21);
            this.txtFolderJson.Name = "txtFolderJson";
            this.txtFolderJson.Size = new System.Drawing.Size(435, 20);
            this.txtFolderJson.TabIndex = 2;
            // 
            // btnBrowserFolderWard
            // 
            this.btnBrowserFolderWard.Location = new System.Drawing.Point(581, 20);
            this.btnBrowserFolderWard.Name = "btnBrowserFolderWard";
            this.btnBrowserFolderWard.Size = new System.Drawing.Size(42, 23);
            this.btnBrowserFolderWard.TabIndex = 3;
            this.btnBrowserFolderWard.Text = ":::";
            this.btnBrowserFolderWard.UseVisualStyleBackColor = true;
            this.btnBrowserFolderWard.Click += new System.EventHandler(this.btnBrowserFolderWard_Click);
            // 
            // btnTestAPI
            // 
            this.btnTestAPI.Location = new System.Drawing.Point(629, 49);
            this.btnTestAPI.Name = "btnTestAPI";
            this.btnTestAPI.Size = new System.Drawing.Size(159, 23);
            this.btnTestAPI.TabIndex = 4;
            this.btnTestAPI.Text = "Nạp tỉnh VNP";
            this.btnTestAPI.UseVisualStyleBackColor = true;
            this.btnTestAPI.Click += new System.EventHandler(this.btnTestAPI_Click);
            // 
            // btnHuyenVN
            // 
            this.btnHuyenVN.Location = new System.Drawing.Point(629, 78);
            this.btnHuyenVN.Name = "btnHuyenVN";
            this.btnHuyenVN.Size = new System.Drawing.Size(159, 23);
            this.btnHuyenVN.TabIndex = 5;
            this.btnHuyenVN.Text = "Nạp huyện VNP";
            this.btnHuyenVN.UseVisualStyleBackColor = true;
            this.btnHuyenVN.Click += new System.EventHandler(this.btnHuyenVN_Click);
            // 
            // btnNapXa
            // 
            this.btnNapXa.Location = new System.Drawing.Point(629, 107);
            this.btnNapXa.Name = "btnNapXa";
            this.btnNapXa.Size = new System.Drawing.Size(159, 23);
            this.btnNapXa.TabIndex = 6;
            this.btnNapXa.Text = "Nạp xã VNP";
            this.btnNapXa.UseVisualStyleBackColor = true;
            this.btnNapXa.Click += new System.EventHandler(this.btnNapXa_Click);
            // 
            // butTaoDanhBa
            // 
            this.butTaoDanhBa.Location = new System.Drawing.Point(629, 136);
            this.butTaoDanhBa.Name = "butTaoDanhBa";
            this.butTaoDanhBa.Size = new System.Drawing.Size(159, 23);
            this.butTaoDanhBa.TabIndex = 7;
            this.butTaoDanhBa.Text = "Tạo danh bạ";
            this.butTaoDanhBa.UseVisualStyleBackColor = true;
            this.butTaoDanhBa.Click += new System.EventHandler(this.butTaoDanhBa_Click);
            // 
            // btnSaiLech
            // 
            this.btnSaiLech.Location = new System.Drawing.Point(67, 241);
            this.btnSaiLech.Name = "btnSaiLech";
            this.btnSaiLech.Size = new System.Drawing.Size(159, 23);
            this.btnSaiLech.TabIndex = 8;
            this.btnSaiLech.Text = "Sai Lech";
            this.btnSaiLech.UseVisualStyleBackColor = true;
            this.btnSaiLech.Click += new System.EventHandler(this.btnSaiLech_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(2, 424);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(786, 23);
            this.progressBar.TabIndex = 9;
            this.progressBar.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(629, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Gộp nhóm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(629, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Xuất excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(333, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Không dấu cái xã";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmTestTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnSaiLech);
            this.Controls.Add(this.butTaoDanhBa);
            this.Controls.Add(this.btnNapXa);
            this.Controls.Add(this.btnHuyenVN);
            this.Controls.Add(this.btnTestAPI);
            this.Controls.Add(this.btnBrowserFolderWard);
            this.Controls.Add(this.txtFolderJson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWardInsert);
            this.Name = "frmTestTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWardInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFolderJson;
        private System.Windows.Forms.Button btnBrowserFolderWard;
        private System.Windows.Forms.Button btnTestAPI;
        private System.Windows.Forms.Button btnHuyenVN;
        private System.Windows.Forms.Button btnNapXa;
        private System.Windows.Forms.Button butTaoDanhBa;
        private System.Windows.Forms.Button btnSaiLech;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}