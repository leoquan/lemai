using ClosedXML.Excel;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Common
{
    public class TemplateKey
    {
        public const string KEY_HEADER = "#header";
        public const string KEY_ROW = "#row";
        public const string KEY_COLUMN = "#column";

        public const string KEY_COLUMN_TITLE = "#columntitle";
        public const string KEY_COLUMN_NAME = "#columname";
        public const string KEY_END_COLUMN_NAME = "#endcolumname";

    }
    public class ExportDataToExcelTemplate
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileTemplate"></param>
        /// <param name="fileExport"></param>
        /// <param name="indexSheet"></param>
        /// <param name="data"></param>
        /// <param name="listTitleID"></param>
        /// <param name="listReplaceValue"></param>
        /// <param name="includeSTT"></param>
        /// <param name="listString"></param>
        public static void Export(string fileTemplate, string fileExport, int indexSheet, DataTable data, Dictionary<string, string> listTitleID, Dictionary<string, string> listReplaceValue, bool includeSTT = true, List<string> listString = null)
        {
            try
            {
                if (data.Rows.Count <= 0)
                {
                    return;
                }
                string templateFileName = fileTemplate;
                if (string.IsNullOrEmpty(fileTemplate))
                {
                    templateFileName = AppDomain.CurrentDomain.BaseDirectory + "Templates\\BASIC_TEMPLATE.xlsx";
                    if (!File.Exists(templateFileName))
                    {
                        throw new Exception("Không tìm thấy file template [" + templateFileName + "]");
                    }
                }
                else
                {
                    if (!File.Exists(fileTemplate))
                    {
                        templateFileName = AppDomain.CurrentDomain.BaseDirectory + "Templates\\BASIC_TEMPLATE.xlsx";
                    }
                }
                //
                if (listString == null)
                {
                    listString = new List<string>();
                }
                // Khởi tạo WorkBook
                var workBook = new XLWorkbook(templateFileName);
                var workSheet = workBook.Worksheet(indexSheet);
                // Step 1 - Thay đổi giá trị của các từ khóa  dạng {KEY} thành giá trị trong dictionary
                foreach (var item in listReplaceValue)
                {
                    string key = "{" + item.Key + "}";
                    IXLCells cells = workSheet.CellsUsed(c => c.GetString().Contains(key));
                    foreach (var cell in cells)
                    {
                        cell.Value = cell.Value.ToString().Replace(key, item.Value);
                    }
                }
                // Step 2 - Thêm các cột dữ liệu khác #data vào file mẫu nếu có.
                var cellColumName = workSheet.CellsUsed(c => c.GetString() == TemplateKey.KEY_COLUMN_NAME).FirstOrDefault();
                if (cellColumName == null)
                {
                    throw new Exception("Template không tìm thấy key " + TemplateKey.KEY_COLUMN_NAME);
                }
                var cellEndColumName = workSheet.CellsUsed(c => c.GetString() == TemplateKey.KEY_END_COLUMN_NAME).FirstOrDefault();
                if (cellEndColumName == null)
                {
                    throw new Exception("Template không tìm thấy key " + TemplateKey.KEY_END_COLUMN_NAME);
                }
                var cellHeader = workSheet.CellsUsed(c => c.GetString() == TemplateKey.KEY_HEADER).FirstOrDefault();
                if (cellHeader == null)
                {
                    throw new Exception("Template không tìm thấy key " + TemplateKey.KEY_HEADER);
                }
                bool haveAutoGen = true;
                var cellColum = workSheet.CellsUsed(c => c.GetString() == TemplateKey.KEY_COLUMN).FirstOrDefault();
                if (cellColum == null)
                {
                    haveAutoGen = false;
                }
                var cellColumTitle = workSheet.CellsUsed(c => c.GetString() == TemplateKey.KEY_COLUMN_TITLE).FirstOrDefault();
                if (cellColumTitle == null)
                {
                    haveAutoGen = false;
                }
                var cellRow = workSheet.CellsUsed(c => c.GetString() == TemplateKey.KEY_ROW).FirstOrDefault();
                if (cellRow == null)
                {
                    throw new Exception("Template không tìm thấy key " + TemplateKey.KEY_ROW);
                }
                IXLRow rowColumName = workSheet.Row(cellColumName.Address.RowNumber);

                // Xử lý thêm các colum theo cấu trúc DataTable
                if (haveAutoGen)
                {
                    IXLColumn columData = workSheet.Column(cellColum.Address.ColumnNumber);

                    foreach (DataColumn item in data.Columns)
                    {
                        var cellCheck = rowColumName.CellsUsed(c => c.GetString() == item.ColumnName).SingleOrDefault();
                        if (cellCheck == null)
                        {
                            // column của DataTable chưa được định nghĩa dữ liệu.
                            // Thêm column vào
                            IXLColumn newColumnData = columData.InsertColumnsAfter(1).FirstOrDefault();
                            newColumnData.Cell(cellColumName.Address.RowNumber).Value = item.ColumnName;
                            if (listTitleID.ContainsKey(item.ColumnName))
                            {
                                newColumnData.Cell(cellColumTitle.Address.RowNumber).Value = listTitleID[item.ColumnName];
                            }
                            else
                            {
                                newColumnData.Cell(cellColumTitle.Address.RowNumber).Value = item.ColumnName;
                            }
                        }
                    }
                    // Thêm xong thì xóa cái cột template đi
                    columData.Delete();
                }

                cellEndColumName = workSheet.CellsUsed(c => c.GetString() == TemplateKey.KEY_END_COLUMN_NAME).FirstOrDefault();
                // Step 3 - Copy dữ liệu dòng dữ liệu và format
                IXLRow currentRow = workSheet.Row(cellRow.Address.RowNumber);
                // Insert các dòng dữ liệu
                currentRow.InsertRowsBelow(data.Rows.Count);
                // Fill data
                if (includeSTT)
                {
                    int rowNumber = currentRow.RowNumber();
                    int count = 1;
                    foreach (DataRow item in data.Rows)
                    {
                        // Fill data
                        IXLRow row = workSheet.Row(rowNumber);
                        // Colum STT
                        row.Cell(cellColumName.Address.ColumnNumber).Value = count;
                        int begin = cellColumName.Address.ColumnNumber + 1;
                        int end = cellEndColumName.Address.ColumnNumber;
                        for (int i = begin; i < end; i++)
                        {
                            string name = rowColumName.Cell(i).Value.ToString();
                            if (data.Columns.Contains(name))
                            {
                                string value = item[name].ToString();
                                if (listString.Exists(u => u == name))
                                {
                                    value = "'" + value;
                                }
                                if (string.IsNullOrEmpty(value))
                                {
                                    value = "'";
                                }
                                row.Cell(i).Value = value;
                            }
                        }
                        // Tăng index lên
                        rowNumber++;
                        count++;
                    }
                    // Clean
                    cellHeader.Value = "STT";
                    IXLRow deleteRow = workSheet.Row(cellColumName.Address.RowNumber);
                    deleteRow.Delete();
                }
                else
                {
                    // Không có cột STT dữ liệu
                    int rowNumber = currentRow.RowNumber();
                    int count = 1;
                    foreach (DataRow item in data.Rows)
                    {
                        // Fill data
                        IXLRow row = workSheet.Row(rowNumber);
                        // Colum STT
                        row.Cell(cellColumName.Address.ColumnNumber).Value = count;
                        int begin = cellColumName.Address.ColumnNumber + 1;
                        int end = cellEndColumName.Address.ColumnNumber;
                        for (int i = begin; i < end; i++)
                        {
                            string name = rowColumName.Cell(i).Value.ToString();
                            if (data.Columns.Contains(name))
                            {
                                string value = item[name].ToString();
                                if (listString.Exists(u => u == name))
                                {
                                    value = "'" + value;
                                }
                                if (string.IsNullOrEmpty(value))
                                {
                                    value = "'";
                                }
                                row.Cell(i).Value = value;
                            }
                        }
                        // Tăng index lên
                        rowNumber++;
                        count++;
                    }
                    // Clean
                    cellHeader.Value = "STT";
                    IXLColumn STT = workSheet.Column(cellHeader.Address.ColumnNumber);
                    STT.Delete();
                    IXLRow deleteRow = workSheet.Row(cellColumName.Address.RowNumber);
                    deleteRow.Delete();
                }

                // Save to disk
                workBook.SaveAs(fileExport);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static void Export(string fileExport, DataTable data)
        {
            try
            {
                var workBook = new XLWorkbook();
                var workSheet = workBook.Worksheets.Add("Sheet1");
                IXLColumn columData = workSheet.Column(1);
                // Xử lý thêm các colum theo cấu trúc DataTable
                IXLRow rowHeader = workSheet.Row(1);
                for (int i = 1; i <= data.Columns.Count; i++)
                {
                    rowHeader.Cell(i).Value = data.Columns[i - 1].ColumnName;
                }
                // Fill data
                int rowNumber = 2;
                foreach (DataRow item in data.Rows)
                {
                    IXLRow row = workSheet.Row(rowNumber);
                    for (int j = 1; j <= data.Columns.Count; j++)
                    {
                        row.Cell(j).Value = item[j - 1];
                    }
                    rowNumber++;
                }
                // Save to disk
                workBook.SaveAs(fileExport);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static DataTable ReadAsDataTable(string fileName)
        {
            DataTable dataTable = new DataTable();
            using (SpreadsheetDocument spreadSheetDocument = SpreadsheetDocument.Open(fileName, false))
            {
                WorkbookPart workbookPart = spreadSheetDocument.WorkbookPart;
                IEnumerable<Sheet> sheets = spreadSheetDocument.WorkbookPart.Workbook.GetFirstChild<Sheets>().Elements<Sheet>();
                string relationshipId = sheets.First().Id.Value;
                WorksheetPart worksheetPart = (WorksheetPart)spreadSheetDocument.WorkbookPart.GetPartById(relationshipId);
                Worksheet workSheet = worksheetPart.Worksheet;
                SheetData sheetData = workSheet.GetFirstChild<SheetData>();
                IEnumerable<Row> rows = sheetData.Descendants<Row>();

                foreach (Cell cell in rows.ElementAt(0))
                {
                    dataTable.Columns.Add(GetCellValue(spreadSheetDocument, cell));
                }
                int rowIndex = 0;
                foreach (Row row in rows)
                {
                    rowIndex++;
                    DataRow dataRow = dataTable.NewRow();
                    var cells = row.Descendants<Cell>();
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        Cell ele = cells.ElementAtOrDefault(i);
                        dataRow[i] = GetCellValue(spreadSheetDocument, ele);
                    }
                    dataTable.Rows.Add(dataRow);
                }

            }
            dataTable.Rows.RemoveAt(0);

            return dataTable;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="document"></param>
        /// <param name="cell"></param>
        /// <returns></returns>
        private static string GetCellValue(SpreadsheetDocument document, Cell cell)
        {
            if (cell == null)
            {
                return string.Empty;
            }
            if (cell.CellValue == null)
            {
                return string.Empty;
            }
            SharedStringTablePart stringTablePart = document.WorkbookPart.SharedStringTablePart;
            string value = cell.CellValue.InnerXml;

            if (cell.DataType != null && cell.DataType.Value == CellValues.SharedString)
            {
                return stringTablePart.SharedStringTable.ChildElements[Int32.Parse(value)].InnerText;
            }
            else
            {
                return value;
            }
        }
        
        public static DataTable ReadAsDataTableK10(string fileName)
        {
            DataTable dataTable = new DataTable();
            using (SpreadsheetDocument spreadSheetDocument = SpreadsheetDocument.Open(fileName, false))
            {
                WorkbookPart workbookPart = spreadSheetDocument.WorkbookPart;
                IEnumerable<Sheet> sheets = spreadSheetDocument.WorkbookPart.Workbook.GetFirstChild<Sheets>().Elements<Sheet>();
                string relationshipId = sheets.First().Id.Value;
                WorksheetPart worksheetPart = (WorksheetPart)spreadSheetDocument.WorkbookPart.GetPartById(relationshipId);
                Worksheet workSheet = worksheetPart.Worksheet;
                SheetData sheetData = workSheet.GetFirstChild<SheetData>();
                IEnumerable<Row> rows = sheetData.Descendants<Row>();

                foreach (Cell cell in rows.ElementAt(0))
                {
                    dataTable.Columns.Add(GetCellValueK10(spreadSheetDocument, cell));
                }
                int rowIndex = 0;
                foreach (Row row in rows)
                {
                    rowIndex++;
                    DataRow dataRow = dataTable.NewRow();
                    var cells = row.Descendants<Cell>();
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        Cell ele = cells.ElementAtOrDefault(i);
                        dataRow[i] = GetCellValueK10(spreadSheetDocument, ele);
                    }
                    dataTable.Rows.Add(dataRow);
                }

            }
            dataTable.Rows.RemoveAt(0);

            return dataTable;
        }
        private static string GetCellValueK10(SpreadsheetDocument document, Cell cell)
        {
            if (cell == null)
            {
                return string.Empty;
            }
            SharedStringTablePart stringTablePart = document.WorkbookPart.SharedStringTablePart;
            string value;
            if (cell.CellValue == null)
            {
                value = cell.InnerText;
            }
            else
            {
                value = cell.CellValue.InnerXml;
            }


            if (cell.DataType != null && cell.DataType.Value == CellValues.SharedString)
            {
                return stringTablePart.SharedStringTable.ChildElements[Int32.Parse(value)].InnerText;
            }
            else
            {
                return value;
            }
        }
    }
}


