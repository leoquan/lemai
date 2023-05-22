using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

namespace Common
{
    public class WordHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputTemplateFile"></param>
        /// <param name="saveFile"></param>
        /// <param name="dictionText"></param>
        public static void MakeWordFromTemplate(string inputTemplateFile, string saveFile, Dictionary<string, string> dictionText)
        {
            try
            {
                File.Copy(inputTemplateFile, saveFile, true);
                using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(saveFile, true))
                {
                    string docText = null;
                    using (StreamReader sr = new StreamReader(wordDoc.MainDocumentPart.GetStream()))
                    {
                        docText = sr.ReadToEnd();
                    }
                    foreach (var item in dictionText)
                    {
                        Regex regexText = new Regex("{" + item.Key + "}");
                        docText = regexText.Replace(docText, item.Value);
                    }
                    using (StreamWriter sw = new StreamWriter(wordDoc.MainDocumentPart.GetStream(FileMode.Create)))
                    {
                        sw.Write(docText);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="editFile"></param>
        /// <param name="tableName"></param>
        /// <param name="data"></param>
        /// <param name="countStart"></param>
        public static void MakeWordFromTemplateAddRow(string editFile, string tableName, DataTable data, int countStart = 1)
        {
            try
            {
                using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(editFile, true))
                {
                    Body body = wordDoc.MainDocumentPart.Document.Body;

                    Table myTable = body.Descendants<Table>().FirstOrDefault(tbl => tbl.InnerText.Contains(tableName));
                    if (myTable == null)
                    {
                        throw new Exception("Cannot find Table");
                    }
                    // Change text
                    TableRow rowHeader = myTable.Elements<TableRow>().FirstOrDefault(u => u.InnerText.Contains(tableName));
                    TableCell cellHeader = rowHeader.Elements<TableCell>().FirstOrDefault(u => u.InnerText.Contains(tableName));
                    Paragraph ph = cellHeader.Elements<Paragraph>().First();
                    foreach (Run item in ph.Elements<Run>())
                    {
                        Text th = item.Elements<Text>().First();
                        if (th.InnerText.Contains(tableName))
                        {
                            th.Text = string.Empty;
                        }
                    }
                    // Proces data
                    TableRow dataRow = myTable.Elements<TableRow>().FirstOrDefault(u => u.InnerText.Contains("#data"));
                    List<TableCell> lsDataCollect = dataRow.Descendants<TableCell>().ToList();
                    foreach (DataRow item in data.Rows)
                    {
                        TableRow newRow = (TableRow)dataRow.CloneNode(true);
                        for (int i = 0; i < lsDataCollect.Count(); i++)
                        {
                            if (i == 0)
                            {
                                TableCell cell = newRow.Elements<TableCell>().ElementAt(i);
                                Paragraph p = cell.Elements<Paragraph>().First();
                                Run r = p.Elements<Run>().First();
                                Text t = r.Elements<Text>().First();
                                t.Text = countStart.ToString();
                            }
                            else
                            {
                                if (data.Columns.Contains(lsDataCollect[i].InnerText))
                                {
                                    TableCell cell = newRow.Elements<TableCell>().ElementAt(i);
                                    Paragraph p = cell.Elements<Paragraph>().First();
                                    Run r = p.Elements<Run>().First();
                                    Text t = r.Elements<Text>().First();
                                    t.Text = item[lsDataCollect[i].InnerText].ToString();
                                }
                            }

                        }
                        myTable.AppendChild(newRow);
                        // Tăng index lên 1 đơn vị
                        countStart++;
                    }
                    // Remove row defined data
                    myTable.RemoveChild(dataRow);
                    // Save data to file
                    using (StreamWriter sw = new StreamWriter(wordDoc.MainDocumentPart.GetStream(FileMode.Create)))
                    {
                        sw.Write(body);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
