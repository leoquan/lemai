namespace Common.Report
{
    partial class LVReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LVReport));
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advanceExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXCELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nudSoBanIn = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudTuTrang = new System.Windows.Forms.NumericUpDown();
            this.nudDenTrang = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrint = new DevComponents.DotNetBar.ButtonX();
            this.btnExcel = new DevComponents.DotNetBar.ButtonX();
            this.btnXml = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoBanIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuTrang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDenTrang)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = -1;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.ContextMenuStrip = this.contextMenuStrip;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.SelectionFormula = "";
            this.crystalReportViewer.ShowCloseButton = false;
            this.crystalReportViewer.ShowGroupTreeButton = false;
            this.crystalReportViewer.ShowLogo = false;
            this.crystalReportViewer.ShowRefreshButton = false;
            this.crystalReportViewer.Size = new System.Drawing.Size(974, 565);
            this.crystalReportViewer.TabIndex = 1;
            this.crystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer.ViewTimeSelectionFormula = "";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openFolderToolStripMenuItem,
            this.advanceExportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(184, 92);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::Common.Properties.Resources.iOpenFile;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Image = global::Common.Properties.Resources.iOpenFolder;
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + F";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.openFolderToolStripMenuItem.Text = "Open folder";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // advanceExportToolStripMenuItem
            // 
            this.advanceExportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem,
            this.eXCELToolStripMenuItem,
            this.pDFToolStripMenuItem});
            this.advanceExportToolStripMenuItem.Name = "advanceExportToolStripMenuItem";
            this.advanceExportToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.advanceExportToolStripMenuItem.Text = "Advance Export";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Image = global::Common.Properties.Resources.iHtml;
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + H";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.xMLToolStripMenuItem.Text = "HTML";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            // 
            // eXCELToolStripMenuItem
            // 
            this.eXCELToolStripMenuItem.Image = global::Common.Properties.Resources.iExcel;
            this.eXCELToolStripMenuItem.Name = "eXCELToolStripMenuItem";
            this.eXCELToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + E";
            this.eXCELToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.eXCELToolStripMenuItem.Text = "EXCEL";
            this.eXCELToolStripMenuItem.Click += new System.EventHandler(this.eXCELToolStripMenuItem_Click);
            // 
            // pDFToolStripMenuItem
            // 
            this.pDFToolStripMenuItem.Image = global::Common.Properties.Resources.iPdf;
            this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            this.pDFToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + D";
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.pDFToolStripMenuItem.Text = "PDF";
            this.pDFToolStripMenuItem.Click += new System.EventHandler(this.pDFToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Common.Properties.Resources.iClose;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = "ESC";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.exitToolStripMenuItem.Text = "Close";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // nudSoBanIn
            // 
            this.nudSoBanIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSoBanIn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoBanIn.Location = new System.Drawing.Point(451, 4);
            this.nudSoBanIn.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudSoBanIn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoBanIn.Name = "nudSoBanIn";
            this.nudSoBanIn.Size = new System.Drawing.Size(38, 21);
            this.nudSoBanIn.TabIndex = 290;
            this.nudSoBanIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSoBanIn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(383, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 14);
            this.label1.TabIndex = 293;
            this.label1.Text = "Số bản in :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudTuTrang
            // 
            this.nudTuTrang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudTuTrang.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTuTrang.Location = new System.Drawing.Point(553, 4);
            this.nudTuTrang.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudTuTrang.Name = "nudTuTrang";
            this.nudTuTrang.Size = new System.Drawing.Size(44, 21);
            this.nudTuTrang.TabIndex = 301;
            this.nudTuTrang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudDenTrang
            // 
            this.nudDenTrang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudDenTrang.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDenTrang.Location = new System.Drawing.Point(629, 4);
            this.nudDenTrang.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudDenTrang.Name = "nudDenTrang";
            this.nudDenTrang.Size = new System.Drawing.Size(44, 21);
            this.nudDenTrang.TabIndex = 302;
            this.nudDenTrang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(599, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 14);
            this.label3.TabIndex = 304;
            this.label3.Text = "đến:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(491, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 14);
            this.label2.TabIndex = 303;
            this.label2.Text = "Từ trang:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPrint
            // 
            this.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrint.Image = global::Common.Properties.Resources.iPrint;
            this.btnPrint.Location = new System.Drawing.Point(679, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(69, 23);
            this.btnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrint.TabIndex = 305;
            this.btnPrint.Text = "&In";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExcel.Image = global::Common.Properties.Resources.iExcel;
            this.btnExcel.Location = new System.Drawing.Point(753, 3);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(69, 23);
            this.btnExcel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExcel.TabIndex = 306;
            this.btnExcel.Text = "&Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnXml
            // 
            this.btnXml.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXml.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXml.Image = global::Common.Properties.Resources.iXml;
            this.btnXml.Location = new System.Drawing.Point(827, 3);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(69, 23);
            this.btnXml.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXml.TabIndex = 307;
            this.btnXml.Text = "&Xml";
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Image = global::Common.Properties.Resources.iClose;
            this.btnClose.Location = new System.Drawing.Point(901, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 23);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 308;
            this.btnClose.Text = "&Thoát";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // LVReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(974, 565);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnXml);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.nudTuTrang);
            this.Controls.Add(this.nudDenTrang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudSoBanIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crystalReportViewer);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LVReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoBanIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuTrang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDenTrang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
        private System.Windows.Forms.NumericUpDown nudSoBanIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advanceExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXCELToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown nudTuTrang;
        private System.Windows.Forms.NumericUpDown nudDenTrang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.ButtonX btnPrint;
        private DevComponents.DotNetBar.ButtonX btnExcel;
        private DevComponents.DotNetBar.ButtonX btnXml;
        private DevComponents.DotNetBar.ButtonX btnClose;

    }
}