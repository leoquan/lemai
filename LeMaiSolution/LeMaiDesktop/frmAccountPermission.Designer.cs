namespace LeMaiDesktop
{
    partial class frmAccountPermission
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
            this.panelcomtrol = new System.Windows.Forms.Panel();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.lTieude = new System.Windows.Forms.Label();
            this.trvForm = new System.Windows.Forms.TreeView();
            this.panelcomtrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelcomtrol
            // 
            this.panelcomtrol.BackColor = System.Drawing.Color.SteelBlue;
            this.panelcomtrol.Controls.Add(this.btnSave);
            this.panelcomtrol.Controls.Add(this.btnClose);
            this.panelcomtrol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelcomtrol.Location = new System.Drawing.Point(0, 411);
            this.panelcomtrol.Name = "panelcomtrol";
            this.panelcomtrol.Size = new System.Drawing.Size(582, 39);
            this.panelcomtrol.TabIndex = 1168;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::LeMaiDesktop.Properties.Resources.iSave;
            this.btnSave.ImageTextSpacing = 3;
            this.btnSave.Location = new System.Drawing.Point(407, 5);
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
            this.btnClose.Location = new System.Drawing.Point(485, 5);
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
            this.lTieude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTieude.Name = "lTieude";
            this.lTieude.Size = new System.Drawing.Size(582, 32);
            this.lTieude.TabIndex = 1169;
            this.lTieude.Text = "    Cấu hình tài khoản";
            this.lTieude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trvForm
            // 
            this.trvForm.BackColor = System.Drawing.SystemColors.Window;
            this.trvForm.CheckBoxes = true;
            this.trvForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvForm.Location = new System.Drawing.Point(0, 32);
            this.trvForm.Name = "trvForm";
            this.trvForm.Size = new System.Drawing.Size(582, 379);
            this.trvForm.TabIndex = 1170;
            this.trvForm.TabStop = false;
            this.trvForm.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.trvForm_AfterCheck);
            // 
            // frmAccountPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.trvForm);
            this.Controls.Add(this.lTieude);
            this.Controls.Add(this.panelcomtrol);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAccountPermission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân quyền tài khoản";
            this.Load += new System.EventHandler(this.frmAccountPermission_Load);
            this.panelcomtrol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelcomtrol;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private System.Windows.Forms.Label lTieude;
        private System.Windows.Forms.TreeView trvForm;
    }
}