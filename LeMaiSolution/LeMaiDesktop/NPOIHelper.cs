using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiDesktop
{
    public class NPOIHelper
    {
        public static System.Data.DataSet GetDataSetFromXls(string excelFilePath)
        {
            IWorkbook workbook;
            if (excelFilePath.Contains(".xlsx"))
            {
                using (FileStream stream = new FileStream(excelFilePath, FileMode.Open, FileAccess.Read))
                {
                    workbook = new XSSFWorkbook(stream);
                }
            }
            else
            {
                using (FileStream stream = new FileStream(excelFilePath, FileMode.Open, FileAccess.Read))
                {
                    workbook = new HSSFWorkbook(stream);
                }
            }
            System.Data.DataSet ds = new System.Data.DataSet();
            for (int i = 0; i < workbook.NumberOfSheets; i++)
            {
                ISheet sheet = workbook.GetSheetAt(i);
                System.Data.DataTable dt = new System.Data.DataTable(sheet.SheetName);
                // write header row
                IRow headerRow = sheet.GetRow(0);
                if (headerRow == null)
                {
                    continue;
                }
                int col = 0;
                foreach (ICell headerCell in headerRow)
                {
                    string headerName = headerCell.ToString();
                    if (string.IsNullOrEmpty(headerName))
                    {
                        headerName = "COL" + col.ToString();
                        col = col + 1;
                    }
                    dt.Columns.Add(headerName);
                }
                int rowIndex = 0;
                foreach (IRow row in sheet)
                {
                    if (rowIndex++ == 0) continue;
                    System.Data.DataRow dataRow = dt.NewRow();
                    dataRow.ItemArray = row.Cells.Select(c => c.ToString()).ToArray();
                    dt.Rows.Add(dataRow);
                }
                ds.Tables.Add(dt);
            }

            return ds;
        }


        public static void SaveDataSetToXls(System.Data.DataSet ds, string savedExcelFilePath)
        {
            //IWorkbook workbook = new XSSFWorkbook();
            IWorkbook workbook = new HSSFWorkbook();

            foreach (System.Data.DataTable dt in ds.Tables)
            {
                ISheet sheet = workbook.CreateSheet(dt.TableName);

                var row0 = sheet.CreateRow(0);//header
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    row0.CreateCell(j).SetCellValue(dt.Columns[j].ColumnName);
                }

                for (int i = 0; i < dt.Rows.Count; i++)//rest
                {
                    var row = sheet.CreateRow(1 + i);
                    for (int j = 0; j < dt.Columns.Count; j++)
                        row.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());
                }
            }

            FileStream sw = File.Create(savedExcelFilePath);
            workbook.Write(sw);
            sw.Close();
        }

    }
}
