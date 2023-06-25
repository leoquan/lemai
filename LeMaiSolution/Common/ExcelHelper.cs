using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Common
{
    public class ExcelHelper
    {
        public static string ReadPhienCODGHN(string fileName)
        {
            try
            {
                using (SpreadsheetDocument spreadSheetDocument = SpreadsheetDocument.Open(fileName, false))
                {
                    WorkbookPart workbookPart = spreadSheetDocument.WorkbookPart;
                    IEnumerable<Sheet> sheets = spreadSheetDocument.WorkbookPart.Workbook.GetFirstChild<Sheets>().Elements<Sheet>();
                    string relationshipId = sheets.First().Id.Value;
                    WorksheetPart worksheetPart = (WorksheetPart)spreadSheetDocument.WorkbookPart.GetPartById(relationshipId);
                    Worksheet workSheet = worksheetPart.Worksheet;
                    SheetData sheetData = workSheet.GetFirstChild<SheetData>();
                    IEnumerable<Row> rows = sheetData.Descendants<Row>();
                    var columnCells = sheetData.Descendants<Cell>().Where(c => string.Compare(GetColumnName(c.CellReference.Value), "B", true) == 0).OrderBy(r => GetRowIndex(r.CellReference)).ToList();
                    for (int i = 0; i < columnCells.Count; i++)
                    {
                        string tempVal = GetCellValue(spreadSheetDocument, columnCells[i]);
                        if (tempVal.Contains("COD_"))
                        {
                            return tempVal;
                        }
                    }
                }
            }
            catch
            {
            }
            return string.Empty;
        }
        public static DataTable Read2007Xlsx(string fileName, string KeyA)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SpreadsheetDocument spreadSheetDocument = SpreadsheetDocument.Open(fileName, false))
                {
                    WorkbookPart workbookPart = spreadSheetDocument.WorkbookPart;
                    IEnumerable<Sheet> sheets = spreadSheetDocument.WorkbookPart.Workbook.GetFirstChild<Sheets>().Elements<Sheet>();
                    string relationshipId = sheets.First().Id.Value;
                    WorksheetPart worksheetPart = (WorksheetPart)spreadSheetDocument.WorkbookPart.GetPartById(relationshipId);
                    Worksheet workSheet = worksheetPart.Worksheet;
                    SheetData sheetData = workSheet.GetFirstChild<SheetData>();
                    IEnumerable<Row> rows = sheetData.Descendants<Row>();
                    int startIndex = 0;
                    // Search keyA
                    if (!string.IsNullOrEmpty(KeyA))
                    {
                        var columnCells = sheetData.Descendants<Cell>().Where(c => string.Compare(GetColumnName(c.CellReference.Value), "A", true) == 0).OrderBy(r => GetRowIndex(r.CellReference)).ToList();
                        for (int i = 0; i < columnCells.Count; i++)
                        {
                            if (GetCellValue(spreadSheetDocument, columnCells[i]) == KeyA)
                            {
                                startIndex = i;
                                break;
                            }
                        }
                    }
                    foreach (Cell cell in rows.ElementAt(startIndex))
                    {
                        dt.Columns.Add(GetCellValue(spreadSheetDocument, cell));
                    }
                    foreach (Row row in rows.Skip(startIndex))
                    {
                        DataRow tempRow = dt.NewRow();
                        int columnIndex = 0;
                        foreach (Cell cell in row.Descendants<Cell>())
                        {
                            // Gets the column index of the cell with data
                            int cellColumnIndex = (int)GetColumnIndexFromName(GetColumnName(cell.CellReference));
                            cellColumnIndex--; //zero based index
                            if (columnIndex < cellColumnIndex)
                            {
                                do
                                {
                                    tempRow[columnIndex] = ""; //Insert blank data here;
                                    columnIndex++;
                                }
                                while (columnIndex < cellColumnIndex);
                            }//end if block
                            tempRow[columnIndex] = GetCellValue(spreadSheetDocument, cell);
                            columnIndex++;
                        }//end inner foreach loop
                        dt.Rows.Add(tempRow);
                    }//end outer foreach loop
                }//end using block
                dt.Rows.RemoveAt(0); //...so i'm taking it out here.
            }//end try
            catch (Exception ex)
            {
            }
            return dt;
        }//end Read2007Xlsx method
        public static DataTable Read2007Xlsx(string fileName, int startIndex = 0)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SpreadsheetDocument spreadSheetDocument = SpreadsheetDocument.Open(fileName, false))
                {
                    WorkbookPart workbookPart = spreadSheetDocument.WorkbookPart;
                    IEnumerable<Sheet> sheets = spreadSheetDocument.WorkbookPart.Workbook.GetFirstChild<Sheets>().Elements<Sheet>();
                    string relationshipId = sheets.First().Id.Value;
                    WorksheetPart worksheetPart = (WorksheetPart)spreadSheetDocument.WorkbookPart.GetPartById(relationshipId);
                    Worksheet workSheet = worksheetPart.Worksheet;
                    SheetData sheetData = workSheet.GetFirstChild<SheetData>();
                    IEnumerable<Row> rows = sheetData.Descendants<Row>();

                    foreach (Cell cell in rows.ElementAt(startIndex))
                    {
                        dt.Columns.Add(GetCellValue(spreadSheetDocument, cell));
                    }
                    foreach (Row row in rows.Skip(startIndex))
                    {
                        DataRow tempRow = dt.NewRow();
                        int columnIndex = 0;
                        foreach (Cell cell in row.Descendants<Cell>())
                        {
                            // Gets the column index of the cell with data
                            int cellColumnIndex = (int)GetColumnIndexFromName(GetColumnName(cell.CellReference));
                            cellColumnIndex--; //zero based index
                            if (columnIndex < cellColumnIndex)
                            {
                                do
                                {
                                    tempRow[columnIndex] = ""; //Insert blank data here;
                                    columnIndex++;
                                }
                                while (columnIndex < cellColumnIndex);
                            }//end if block
                            tempRow[columnIndex] = GetCellValue(spreadSheetDocument, cell);
                            columnIndex++;
                        }//end inner foreach loop
                        dt.Rows.Add(tempRow);
                    }//end outer foreach loop
                }//end using block
                dt.Rows.RemoveAt(0); //...so i'm taking it out here.
            }//end try
            catch (Exception ex)
            {
            }
            return dt;
        }//end Read2007Xlsx method

        private static uint GetRowIndex(StringValue cellName)
        {
            var regex = new Regex(@"\d+");
            var match = regex.Match(cellName);
            return uint.Parse(match.Value);
        }

        /// <summary>
        /// Given a cell name, parses the specified cell to get the column name.
        /// </summary>
        /// <param name="cellReference">Address of the cell (ie. B2)</param>
        /// <returns>Column Name (ie. B)</returns>
        public static string GetColumnName(string cellReference)
        {
            // Create a regular expression to match the column name portion of the cell name.
            Regex regex = new Regex("[A-Za-z]+");
            Match match = regex.Match(cellReference);
            return match.Value;
        } //end GetColumnName method

        /// <summary>
        /// Given just the column name (no row index), it will return the zero based column index.
        /// Note: This method will only handle columns with a length of up to two (ie. A to Z and AA to ZZ). 
        /// A length of three can be implemented when needed.
        /// </summary>
        /// <param name="columnName">Column Name (ie. A or AB)</param>
        /// <returns>Zero based index if the conversion was successful; otherwise null</returns>
        public static int? GetColumnIndexFromName(string columnName)
        {
            //return columnIndex;
            string name = columnName;
            int number = 0;
            int pow = 1;
            for (int i = name.Length - 1; i >= 0; i--)
            {
                number += (name[i] - 'A' + 1) * pow;
                pow *= 26;
            }
            return number;
        } //end GetColumnIndexFromName method

        public static string GetCellValue(SpreadsheetDocument document, Cell cell)
        {
            SharedStringTablePart stringTablePart = document.WorkbookPart.SharedStringTablePart;
            if (cell.CellValue == null)
            {
                return "";
            }
            string value = cell.CellValue.InnerXml;
            if (cell.DataType != null && cell.DataType.Value == CellValues.SharedString)
            {
                return stringTablePart.SharedStringTable.ChildElements[Int32.Parse(value)].InnerText;
            }
            else
            {
                return value;
            }
        }//end GetCellValue method
    }
}
