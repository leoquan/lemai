using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Common
{
    public partial class frmexcel : Form
    {
        private DataTable dt = new DataTable();
        private string sTitle = string.Empty;
        private string sfilename = string.Empty;
        private int percent;
        Dictionary<string, string> _replaceName = new Dictionary<string, string>();

        public frmexcel()
        {
            InitializeComponent();
        }
        public frmexcel(string filename, string Title, DataTable data)
        {
            InitializeComponent();
            dt = data;
            sTitle = Title;
            sfilename = filename;
            percent = dt.Rows.Count;
            this.progressBar.Maximum = percent;
            this.progressBar.Minimum = 0;
            this.progressBar.Step = 1;
            lbTong.Text = percent.ToString();
            lblChua.Text = percent.ToString();
            lblDa.Text = "0";
            backgroundWorker.RunWorkerAsync();
        }
        
        public frmexcel(string filename, string Title, DataTable data, Dictionary<string, string> replaceColumn)
        {
            InitializeComponent();
            dt = data;
            sTitle = Title;
            sfilename = filename;
            percent = dt.Rows.Count;
            this.progressBar.Maximum = percent;
            this.progressBar.Minimum = 0;
            this.progressBar.Step = 1;
            lbTong.Text = percent.ToString();
            lblChua.Text = percent.ToString();
            lblDa.Text = "0";
            _replaceName = replaceColumn;
            backgroundWorker.RunWorkerAsync();
        }
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string templateFileName = AppDomain.CurrentDomain.BaseDirectory + "Templates\\BASIC.xlsx";
                var workBook = new XLWorkbook(templateFileName);
                var xlSheet = workBook.Worksheet(1);
                int columns = dt.Columns.Count;
                int rows = dt.Rows.Count;
                int i, j;
                xlSheet.Cell(1, 1).Value = "[STT]";
                for (j = 0; j < columns; j++)
                {
                    if (_replaceName != null && _replaceName.ContainsKey(dt.Columns[j].ColumnName))
                    {
                        xlSheet.Cell(1, j + 2).Value = _replaceName[dt.Columns[j].ColumnName];
                    }
                    else
                    {
                        xlSheet.Cell(1, j + 2).Value = dt.Columns[j].ColumnName;
                    }
                }
                //Fill data to sheet
                for (i = 0; i < rows; i++)
                {
                    xlSheet.Cell(i + 2, 1).Value = i + 1;//In cột số thứ tự
                    for (j = 0; j < columns; j++)
                    {
                        xlSheet.Cell(i + 2, j + 2).Value = dt.Rows[i][j];

                    }
                    backgroundWorker.ReportProgress(i);
                }
                workBook.SaveAs(sfilename);
            }
            catch (Exception ex)
            {
                this.Invoke(new CallMessageBoxDelegate(CallMessageBox), ex.Message, "Export error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblDa.Text = (e.ProgressPercentage + 1).ToString();
            lblChua.Text = (percent - e.ProgressPercentage - 1).ToString();
            progressBar.PerformStep();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                throw new Exception("Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Hiển thị Messagebox
        private delegate DialogResult CallMessageBoxDelegate(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon);
        public DialogResult CallMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return MessageBox.Show(this, text, caption, buttons, icon);
        }
        #endregion
    }
}