using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiDesktop
{
    public interface IDocumentPrint
    {
        void Print76x130(view_GExpBill data, PrinterSettings setting, bool isReceipt);
        void Print100x150(view_GExpBill data, PrinterSettings setting, bool isReceipt);
        void Print100x180(view_GExpBill data, PrinterSettings setting, bool isReceipt);

    }
    public class DocumentPrintHelper
    {
        public static List<DocumentType> GetAllType()
        {
            List<DocumentType> list = new List<DocumentType>();
            list.Add(new DocumentType { Id = "76x130", Name = "76x130mm" });
            list.Add(new DocumentType { Id = "100x150", Name = "100x150mm" });
            list.Add(new DocumentType { Id = "100x180", Name = "100x180mm" });
            return list;
        }
        public static IDocumentPrint GetDocument(string code)
        {
            switch (code)
            {
                case "tindat":
                    return new PrintDocumentTinDat();
                default:
                    return new PrintDocumentLeMai();
            }
        }
    }
    public class DocumentType
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
