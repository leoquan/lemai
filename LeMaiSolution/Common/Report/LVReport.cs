using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Common.Report
{
    /// <summary>
    /// Hiển thị report
    /// Bước 1: frmReport frm = new frmReport();
    /// Bước 2: frm.ShowReport("report.rpt", "A5", true, "Tiêu đề của form report", "Tiêu đề của messagebox", source, true, "TenDonVi", tendonvi, "DiaChi", diachi);
    /// Nếu cần hiển thị report dạng dialog thì ta dùng phương thức ShowReportDialog để thay thế cho ShowReport
    /// </summary>
    public partial class LVReport : DevComponents.DotNetBar.Office2007Form
    {
        DataSet dsSource = new DataSet();
        string sPagesize = string.Empty;
        bool bLanscape = false;
        string sReportFile = string.Empty;
        string[] objFormula;
        ReportDocument rptDocument = new ReportDocument();
        DataTable dtSource = new DataTable();
        bool breview = false;
        bool bdataset = false;
        string sTitle = string.Empty;
        string sMessageTitle = string.Empty;
        bool bDialogSetting = false;
        /// <summary>
        /// Empty Contrustor
        /// </summary>
        public LVReport()
        {

        }
        private LVReport(string reportfile, string pagesize, bool Landscape, string Title, DataSet source, bool review, bool viewDialog, params string[] formula)
        {
            if (review)
            {
                InitializeComponent();
            }
            bDialogSetting = viewDialog;
            sReportFile = reportfile;
            sPagesize = pagesize;
            bLanscape = Landscape;
            dsSource = source;
            objFormula = formula;
            sTitle = Title;
            bdataset = true;
            breview = review;
            InitReportViewData();
            this.Text = sTitle + " - " + Path.GetFileName(reportfile);
        }

        private LVReport(string reportfile, string pagesize, bool Landscape, string Title, DataTable source, bool review, bool viewDialog, params string[] formula)
        {
            if (review)
            {
                InitializeComponent();
            }
            bDialogSetting = viewDialog;
            sReportFile = reportfile;
            sPagesize = pagesize;
            bLanscape = Landscape;
            dtSource = source;
            objFormula = formula;
            sTitle = Title;
            bdataset = false;
            breview = review;
            InitReportViewData();
            this.Text = sTitle + " - " + Path.GetFileName(reportfile);
        }

        /// <summary>
        /// Khởi tạo form hiển thị report
        /// </summary>
        /// <param name="reportfile">Đường dẫn - tên đầy đủ của file report (*.rpt)</param>
        /// <param name="pagesize">Khổ giấy in dạng A3, A4, A5...Nhập chuỗi rỗng nếu như không thuộc 3 loại khổ giấy trên</param>
        /// <param name="Landscape">In giấy ngang hay dọc, True là giấy ngang.</param>
        /// <param name="Title">Tiêu đề của form hiển thị</param>
        /// <param name="MessageBoxTitle">Tiêu đề của các messagebox</param>
        /// <param name="source">DataTable dữ liệu</param>
        /// <param name="review">Xem trước khi in</param>
        /// <param name="formula">Danh sách các formula dạng "Tên formula", "Giá trị formula"</param>
        public void ShowReport(string reportfile, string pagesize, bool Landscape, string Title, string MessageBoxTitle, DataTable source, bool review, bool viewDialogPrinter, params string[] formula)
        {
            sMessageTitle = MessageBoxTitle;
            bDialogSetting = viewDialogPrinter;
            LVReport frm = new LVReport(reportfile, pagesize, Landscape, Title, source, review, viewDialogPrinter, formula);
            if (review)
            {
                frm.Show();
            }
            else
            {
                frm.Dispose();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TSource">Kiểu dữ liệu được sử dụng khi truyền vào</typeparam>
        /// <param name="reportfile"></param>
        /// <param name="pagesize"></param>
        /// <param name="Landscape"></param>
        /// <param name="Title"></param>
        /// <param name="MessageBoxTitle">Tieeu đề của các messagebox sử dụng trong form</param>
        /// <param name="data">List Object</param>
        /// <param name="review"></param>
        /// <param name="formula"></param>
        public void ShowReport<TSource>(string reportfile, string pagesize, bool Landscape, string Title, string MessageBoxTitle, IList<TSource> data, bool review, bool viewDialogPrinter, params string[] formula)
        {
            sMessageTitle = MessageBoxTitle;
            bDialogSetting = viewDialogPrinter;
            DataTable source = ToDataTable(data);
            LVReport frm = new LVReport(reportfile, pagesize, Landscape, Title, source, review, viewDialogPrinter, formula);
            if (review)
            {
                frm.Show();
            }
            else
            {
                frm.Dispose();
            }
        }
        /// <summary>
        /// Khởi tạo Dialog hiển thị report
        /// </summary>
        /// <param name="reportfile">Đường dẫn - tên đầy đủ của file report (*.rpt)</param>
        /// <param name="pagesize">Khổ giấy in dạng A3, A4, A5...Nhập chuỗi rỗng nếu như không thuộc 3 loại khổ giấy trên</param>
        /// <param name="Landscape">In giấy ngang hay dọc, True là giấy ngang.</param>
        /// <param name="Title">Tiêu đề của form hiển thị</param>
        /// <param name="MessageBoxTitle">Tiêu đề của các messagebox</param>
        /// <param name="source">DataTable dữ liệu</param>
        /// <param name="review">Xem trước khi in</param>
        /// <param name="formula">Danh sách các formula dạng "Tên formula", "Giá trị formula"</param>
        public void ShowReportDialog(string reportfile, string pagesize, bool Landscape, string Title, string MessageBoxTitle, DataTable source, bool review, bool viewDialogPrinter, params string[] formula)
        {
            sMessageTitle = MessageBoxTitle;
            bDialogSetting = viewDialogPrinter;
            LVReport frm = new LVReport(reportfile, pagesize, Landscape, Title, source, review, viewDialogPrinter, formula);
            if (review)
            {
                frm.ShowDialog();
            }
            else
            {
                frm.Dispose();
            }
        }
        /// <summary>
        /// Khởi tạo form hiển thị report
        /// </summary>
        /// <param name="reportfile">Đường dẫn - tên đầy đủ của file report (*.rpt)</param>
        /// <param name="pagesize">Khổ giấy in dạng A3, A4, A5...Nhập chuỗi rỗng nếu như không thuộc 3 loại khổ giấy trên</param>
        /// <param name="Landscape">In giấy ngang hay dọc, True là giấy ngang.</param>
        /// <param name="Title">Tiêu đề của form hiển thị</param>
        /// <param name="MessageBoxTitle">Tiêu đề của các messagebox</param>
        /// <param name="source">Dataset dữ liệu</param>
        /// <param name="review">Xem trước khi in</param>
        /// <param name="formula">Danh sách các formula dạng "Tên formula", "Giá trị formula"</param>
        public void ShowReport(string reportfile, string pagesize, bool Landscape, string Title, string MessageBoxTitle, DataSet source, bool review, bool viewDialogPrinter, params string[] formula)
        {
            sMessageTitle = MessageBoxTitle;
            bDialogSetting = viewDialogPrinter;
            LVReport frm = new LVReport(reportfile, pagesize, Landscape, Title, source, review, viewDialogPrinter, formula);
            if (review)
            {
                frm.Show();
            }
            else
            {
                frm.Dispose();
            }
        }
        /// <summary>
        /// Khởi tạo Dialog hiển thị report
        /// </summary>
        /// <param name="reportfile">Đường dẫn - tên đầy đủ của file report (*.rpt)</param>
        /// <param name="pagesize">Khổ giấy in dạng A3, A4, A5...Nhập chuỗi rỗng nếu như không thuộc 3 loại khổ giấy trên</param>
        /// <param name="Landscape">In giấy ngang hay dọc, True là giấy ngang.</param>
        /// <param name="Title">Tiêu đề của form hiển thị</param>
        /// <param name="MessageBoxTitle">Tiêu đề của các messagebox</param>
        /// <param name="source">Dataset dữ liệu</param>
        /// <param name="review">Xem trước khi in</param>
        /// <param name="formula">Danh sách các formula dạng "Tên formula", "Giá trị formula"</param>
        public void ShowReportDialog(string reportfile, string pagesize, bool Landscape, string Title, string MessageBoxTitle, DataSet source, bool review, bool viewDialogPrinter, params string[] formula)
        {
            sMessageTitle = MessageBoxTitle;
            bDialogSetting = viewDialogPrinter;
            LVReport frm = new LVReport(reportfile, pagesize, Landscape, Title, source, review, viewDialogPrinter, formula);
            if (review)
            {
                frm.ShowDialog();
            }
            else
            {
                frm.Dispose();
            }
        }

        private void InitReportViewData()//Load các thông số cần thiết cho report
        {
            try
            {
                //Init ReportDocument
                rptDocument = new ReportDocument();
                //Check Exist file
                //Process Report
                string sRealFile = PCommon.GetReportByCompany(sReportFile);
                if (File.Exists(sRealFile))
                {
                    //Set DataSource
                    rptDocument.Load(sRealFile, OpenReportMethod.OpenReportByTempCopy);

                    if (bdataset)
                        rptDocument.SetDataSource(dsSource);
                    else
                    {

                        rptDocument.SetDataSource(dtSource);
                    }
                    // Create Common Formula
                    string[] commonFormula = PCommon.GetCommonFormulaReport(sReportFile);
                    string[] concatFormula = new string[objFormula.Length + commonFormula.Length];
                    commonFormula.CopyTo(concatFormula, 0);
                    objFormula.CopyTo(concatFormula, commonFormula.Length);
                    // Set Formula
                    for (int i = 0; i < concatFormula.Length; i += 2)
                    {
                        string s1 = concatFormula[i].ToString();
                        string s2 = concatFormula[i + 1].ToString();
                        rptDocument.DataDefinition.FormulaFields[concatFormula[i].ToString()].Text = "'" + concatFormula[i + 1].ToString().Replace("'", "''") + "'";
                    }
                    //Set PageSize
                    switch (sPagesize)
                    {
                        case "A4":
                            rptDocument.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                            break;
                        case "A5":
                            rptDocument.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA5;
                            break;
                        case "A3":
                            rptDocument.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA3;
                            break;
                        default:
                            rptDocument.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize;
                            break;
                    }
                    //Set PaperOrientation
                    if (bLanscape)
                    {
                        rptDocument.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape;
                    }
                    else
                    {
                        rptDocument.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                    }
                    if (breview)
                    {
                        crystalReportViewer.ReportSource = rptDocument;
                    }
                    else
                    {
                        if (bDialogSetting)
                        {
                            PrintDialog printDialog = new PrintDialog();
                            if (printDialog.ShowDialog() == DialogResult.OK)
                            {
                                PageSetupDialog pageSetting = new PageSetupDialog();
                                pageSetting.PrinterSettings = printDialog.PrinterSettings;
                                pageSetting.PageSettings = new System.Drawing.Printing.PageSettings();
                                if (pageSetting.ShowDialog() == DialogResult.OK)
                                {
                                    rptDocument.PrintToPrinter(printDialog.PrinterSettings, pageSetting.PageSettings, false);
                                }
                            }
                            btnClose_Click(null, null);
                        }
                        else
                        {
                            rptDocument.PrintToPrinter(1, false, 0, 0);
                            btnClose_Click(null, null);
                        }
                    }
                }
                else
                {
                    if (MessageBox.Show("Không thể tìm thấy hoặc mở file " + sReportFile + ". Bạn có muốn xuất ra file excel?", sMessageTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        btnExcel_Click(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, sMessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (MessageBox.Show("Bạn có muốn xuất cấu trúc của report ra xml?", sMessageTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveFileDialog fs = new SaveFileDialog();
                    fs.Filter = "Xml file (*.xml)|*.xml";
                    fs.FileName = ConvertToUnSign(sTitle).Replace(" ", "");
                    if (fs.ShowDialog() == DialogResult.OK)
                    {
                        if (bdataset)
                        {

                            System.IO.StreamWriter xmlSW = new System.IO.StreamWriter(fs.FileName);
                            dsSource.WriteXml(xmlSW, XmlWriteMode.WriteSchema);
                            xmlSW.Close();
                        }
                        else
                        {

                            dtSource.TableName = "DataTable";
                            System.IO.StreamWriter xmlSW = new System.IO.StreamWriter(fs.FileName);
                            dtSource.WriteXml(xmlSW, XmlWriteMode.WriteSchema);
                            xmlSW.Close();

                        }
                        if (objFormula.Length > 0)
                        {
                            try
                            {
                                using (StreamWriter st = new StreamWriter(fs.FileName + ".ini"))
                                {
                                    for (int i = 0; i < objFormula.Length; i += 2)
                                    {
                                        st.WriteLine(objFormula[i].ToString() + " = " + objFormula[i + 1].ToString() + "");
                                    }
                                    st.Flush();
                                    st.Close();

                                }
                            }
                            catch
                            {
                            }
                        }
                    }
                }
            }
        }

        private string ConvertToUnSign(string text)
        {
            for (int i = 33; i < 48; i++)
            {
                text = text.Replace(((char)i).ToString(), "");
            }

            for (int i = 58; i < 65; i++)
            {
                text = text.Replace(((char)i).ToString(), "");
            }

            for (int i = 91; i < 97; i++)
            {
                text = text.Replace(((char)i).ToString(), "");
            }

            for (int i = 123; i < 127; i++)
            {
                text = text.Replace(((char)i).ToString(), "");
            }

            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");

            string strFormD = text.Normalize(System.Text.NormalizationForm.FormD);

            return regex.Replace(strFormD, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }

        /// <summary>
        /// Chuyển đổi list dữ liệu thành DataTable
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="data">List dữ liệu cần được chuyển đổi</param>
        /// <returns>DataTable có cấu trúc và dữ liệu như List</returns>
        public DataTable ToDataTable<TSource>(IList<TSource> data)
        {
            DataTable dataTable = new DataTable(typeof(TSource).Name);
            PropertyInfo[] props = typeof(TSource).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in props)
            {
                dataTable.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            foreach (TSource item in data)
            {
                var values = new object[props.Length];
                for (int i = 0; i < props.Length; i++)
                {
                    values[i] = props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (bDialogSetting)
                {
                    PrintDialog printDialog = new PrintDialog();
                    if (printDialog.ShowDialog() == DialogResult.OK)
                    {
                        PageSetupDialog pageSetting = new PageSetupDialog();
                        pageSetting.PrinterSettings = printDialog.PrinterSettings;
                        pageSetting.PageSettings = new System.Drawing.Printing.PageSettings();
                        if (pageSetting.ShowDialog() == DialogResult.OK)
                        {
                            rptDocument.PrintToPrinter(printDialog.PrinterSettings, pageSetting.PageSettings, false);
                        }
                    }
                }
                else
                {
                    rptDocument.PrintToPrinter(Convert.ToInt16(nudSoBanIn.Value), false, Convert.ToInt16(nudTuTrang.Value), Convert.ToInt16(nudDenTrang.Value));
                    this.Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, sMessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Cursor = Cursors.Default;
            btnClose_Click(null, null);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "Excel file (*.xls)|*.xls";
            f.FileName = ConvertToUnSign(sTitle).Replace(" ", "");
            if (f.ShowDialog() == DialogResult.OK)
            {
                if (bdataset)
                {
                    frmexcel frm = new frmexcel(f.FileName, sTitle, dsSource.Tables[0]);
                    frm.ShowDialog();
                }
                else
                {
                    frmexcel frm = new frmexcel(f.FileName, sTitle, dtSource);
                    frm.ShowDialog();
                }
            }
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            //Write data to xml
            SaveFileDialog fr = new SaveFileDialog();
            fr.Filter = "Xml file (*.xml)|*.xml";
            fr.FileName = ConvertToUnSign(sTitle).Replace(" ", "");
            if (fr.ShowDialog() == DialogResult.OK)
            {
                this.Cursor = Cursors.WaitCursor;
                try
                {
                    if (bdataset)
                    {
                        System.IO.StreamWriter xmlSW = new System.IO.StreamWriter(fr.FileName);
                        dsSource.WriteXml(xmlSW, XmlWriteMode.WriteSchema);
                        xmlSW.Close();
                    }
                    else
                    {

                        dtSource.TableName = "DataTable";
                        System.IO.StreamWriter xmlSW = new System.IO.StreamWriter(fr.FileName);
                        dtSource.WriteXml(xmlSW, XmlWriteMode.WriteSchema);
                        xmlSW.Close();

                    }
                    if (objFormula.Length > 0)
                    {
                        try
                        {
                            using (StreamWriter st = new StreamWriter(fr.FileName + ".ini"))
                            {
                                for (int i = 0; i < objFormula.Length; i += 2)
                                {
                                    st.WriteLine(objFormula[i].ToString() + " = " + objFormula[i + 1].ToString() + "");
                                }
                                st.Flush();
                                st.Close();

                            }
                        }
                        catch
                        {
                        }
                    }
                }
                catch { }
                this.Cursor = Cursors.Default;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                dtSource.Dispose();
                dsSource.Dispose();
                rptDocument.Dispose();
            }
            catch { }
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(sReportFile))
            {
                try
                {
                    System.Diagnostics.Process prc = new System.Diagnostics.Process();
                    prc.StartInfo.FileName = sReportFile;
                    prc.Start();
                }
                catch
                {
                    MessageBox.Show("Cannot open the " + sReportFile + " Because no application is associated with the specified file for this operation.", sMessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("Cannot find the " + sReportFile, sMessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open folder browser
            try
            {
                string folder = Path.GetDirectoryName(sReportFile);
                if (Directory.Exists(folder))
                {
                    System.Diagnostics.Process prc = new System.Diagnostics.Process();
                    prc.StartInfo.FileName = folder;
                    prc.Start();
                }
            }
            catch { }
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                SaveFileDialog f = new SaveFileDialog();
                f.Filter = "Html file(*.html)|*.html";
                f.FileName = ConvertToUnSign(sTitle).Replace(" ", "");
                if (f.ShowDialog() == DialogResult.OK)
                {
                    rptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.HTML40, f.FileName);
                }
            }
            catch
            {
            }
            this.Cursor = Cursors.Default;
        }

        private void eXCELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //EXCEL
            this.Cursor = Cursors.WaitCursor;
            try
            {
                SaveFileDialog f = new SaveFileDialog();
                f.Filter = "Excel file (*.xlsx)|*.xlsx";
                f.FileName = ConvertToUnSign(sTitle).Replace(" ", "");
                if (f.ShowDialog() == DialogResult.OK)
                {
                    rptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.Excel, f.FileName);
                }
            }
            catch
            {
            }
            this.Cursor = Cursors.Default;
        }

        private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                SaveFileDialog f = new SaveFileDialog();
                f.Filter = "Pdf file (*.pdf)|*.pdf";
                f.FileName = ConvertToUnSign(sTitle).Replace(" ", "");
                if (f.ShowDialog() == DialogResult.OK)
                {
                    rptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, f.FileName);
                }
            }
            catch
            {
            }
            this.Cursor = Cursors.Default;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnClose_Click(null, null);
        }
    }
}
