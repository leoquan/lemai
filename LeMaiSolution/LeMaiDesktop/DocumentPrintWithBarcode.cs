using LeMaiDomain;
using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using DevComponents.DotNetBar.Controls;
using QRCoder;
using System.Windows.Forms;
using System.IO;

namespace LeMaiDesktop
{
    public class DocumentPrintWithBarcode
    {
        int indexRow = 0;
        private int _top1, _left1, _top2, _left2;
        private int _from, _to;

        Pen blackPen = new Pen(Color.Black, 1);


        List<string> _lsMaVanDon = new List<string>();
        string _MaNhanVien = string.Empty;
        string _TongTienDon = string.Empty;
        string _SoDon = string.Empty;
        int _pageShipper = 0;

        view_GExpBill expCon = new view_GExpBill();
        SolidBrush drawBrush = new SolidBrush(Color.Black);

        StringFormat drawFormatCenter = new StringFormat();
        StringFormat drawFormatLeft = new StringFormat();
        StringFormat drawFormatRight = new StringFormat();
        // Font
        Font fontTimeNewRoman14Bold = new Font("Time New Roman", 14, FontStyle.Bold);
        Font fontTimeNewRoman13Bold = new Font("Time New Roman", 13, FontStyle.Bold);
        Font tahoma12Bold = new Font("Tahoma", 12, FontStyle.Bold);
        Font fontTimeNewRoman12Bold = new Font("Time New Roman", 12, FontStyle.Bold);
        Font fontTimeNewRoman10Bold = new Font("Time New Roman", 10, FontStyle.Bold);

        Font fontTimeNewRoman14 = new Font("Time New Roman", 14);
        Font fontTimeNewRoman13 = new Font("Time New Roman", 13);
        Font fontTimeNewRoman12 = new Font("Time New Roman", 12);
        Font fontTimeNewRoman11 = new Font("Time New Roman", 11);
        Font fontTimeNewRoman10 = new Font("Time New Roman", 10);
        Font fontTimeNewRoman9 = new Font("Time New Roman", 9);
        Font fontTimeNewRoman8 = new Font("Time New Roman", 8);

        Font fontCode128_32 = new Font("Code-128", 32);
        Font fontCode128_28 = new Font("Code-128", 28);
        Font fontCode128_26 = new Font("Code-128", 26);
        Font fontCode128_24 = new Font("Code-128", 24);
        Font fontCode128_22 = new Font("Code-128", 22);
        Font fontCode128_20 = new Font("Code-128", 20);
        Font fontCode128_18 = new Font("Code-128", 18);
        Font fontCode128_16 = new Font("Code-128", 16);

        Font fontTimeNewRoman8Bold = new Font("Time New Roman", 8, FontStyle.Bold);

        Font fontTimeNewRoman7 = new Font("Time New Roman", 7);
        Font fontTimeNewRoman6 = new Font("Time New Roman", 6);
        Font fontTimeNewRoman5 = new Font("Time New Roman", 5);

        Font fontCode128_50 = new Font("Code-128", 40);
        Font fontCode128_55 = new Font("Code-128", 50);
        Font fontCode128_29 = new Font("Code-128", 30);
        Font fontCode128_25 = new Font("Code-128", 25);

        private string _typeLabel = string.Empty;

        /// <summary>
        /// In vận đơn mẫu 180x100mm
        /// </summary>
        /// <param name="data"></param>
        /// <param name="setting"></param>
        /// <param name="numberOfCopy"></param>
        /// <param name="top1"></param>
        /// <param name="left1"></param>
        public void PrintExpConsignment100x180(view_GExpBill data, PrinterSettings setting, int numberOfCopy, int top1, int left1)
        {
            _top1 = top1;
            _left1 = left1;

            expCon = data;
            PrintDocument printdocument = new PrintDocument();
            printdocument.PrinterSettings = setting;
            printdocument.PrinterSettings.DefaultPageSettings.PaperSize = new PaperSize("100mm x 180mm", 394, 708);
            // Setting
            InitFormat();
            // Event handle
            printdocument.PrintPage += this.Doc_PrintExpConsignment100x180;//
            for (int j = 0; j < numberOfCopy; j++)
            {
                printdocument.Print();
            }
        }
        private void Doc_PrintExpConsignment100x180(object sender, PrintPageEventArgs e)
        {
            //Set all parameter for
            RectangleF drawRect;
            int x = 10;
            int y = 10;
            int w = 380;
            int w2 = 195;
            Image logo = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Logo\\vn_logo.png");
            // Logo
            e.Graphics.DrawImage(logo, 10, 10);
            // Dòng Tổng tiền
            y += 10;
            drawRect = new RectangleF(x + 110, y, w, fontTimeNewRoman10Bold.Height);
            //e.Graphics.DrawString("TỔNG TIỀN THU:", fontTimeNewRoman10Bold, drawBrush, drawRect, drawFormatLeft);
            // Số tiền
            y += fontTimeNewRoman10Bold.Height;
            y += 10;
            drawRect = new RectangleF(x, y, 360, fontTimeNewRoman14Bold.Height);
            if (expCon.FK_PaymentType == "GTT")
            {
                e.Graphics.DrawString(PCommon.FormatNumber(expCon.COD.ToString()) + " VNĐ", fontTimeNewRoman14Bold, drawBrush, drawRect, drawFormatRight);
            }
            else
            {
                e.Graphics.DrawString(PCommon.FormatNumber((expCon.COD + expCon.Freight).ToString()) + " VNĐ", fontTimeNewRoman14Bold, drawBrush, drawRect, drawFormatRight);
            }
            // Ngày
            drawRect = new RectangleF(x, y + 20, w, fontTimeNewRoman10.Height);
            e.Graphics.DrawString("  Ngày tạo đơn: " + string.Format("{0:dd/MM/yyyy HH:mm}", expCon.RegisterDate), fontTimeNewRoman10, drawBrush, drawRect, drawFormatLeft);

            // Line 
            y += fontTimeNewRoman14Bold.Height;
            y += 10;
            drawRect = new RectangleF(x, y, w, fontTimeNewRoman9.Height);
            e.Graphics.DrawString("---------------------------------------------------------------", fontTimeNewRoman12Bold, drawBrush, drawRect, drawFormatCenter);
            // Mã Barcode
            y += 10;
            drawRect = new RectangleF(x, y, 380, 60);
            e.Graphics.DrawString(Common.BarcodeHelper.Encode(expCon.BillCode), fontCode128_50, drawBrush, drawRect, drawFormatCenter);
            // Mã Đơn hàng bên dưới
            y += 55;
            drawRect = new RectangleF(x, y, w, fontTimeNewRoman10Bold.Height);
            e.Graphics.DrawString(expCon.BillCode, fontTimeNewRoman10Bold, drawBrush, drawRect, drawFormatCenter);
            // Line 
            y += 10;
            drawRect = new RectangleF(x, y, w, fontTimeNewRoman9.Height);
            e.Graphics.DrawString("---------------------------------------------------------------", fontTimeNewRoman12Bold, drawBrush, drawRect, drawFormatCenter);
            // Tên đại lý
            y += 20;
            drawRect = new RectangleF(x, y, w, fontTimeNewRoman12Bold.Height);
            e.Graphics.DrawString(expCon.BT3Code, fontTimeNewRoman12Bold, drawBrush, drawRect, drawFormatCenter);
            //LINE
            y += fontTimeNewRoman12Bold.Height;
            y += 20;
            drawRect = new RectangleF(x, y, w, fontTimeNewRoman9.Height);
            e.Graphics.DrawString("---------------------------------------------------------------", fontTimeNewRoman12Bold, drawBrush, drawRect, drawFormatCenter);

            int y1 = y;
            int y2 = y;
            int x2 = w2;
            int row = 4;
            int yLine = y + 10;

            // Nhận
            y1 += 20;
            drawRect = new RectangleF(x, y1, w2, (fontTimeNewRoman10Bold.Height * 2));
            e.Graphics.DrawString("Nhận: " + expCon.AcceptMan, fontTimeNewRoman10Bold, drawBrush, drawRect, drawFormatLeft);

            y1 += (fontTimeNewRoman10Bold.Height * 2);
            y1 += 5;
            drawRect = new RectangleF(x, y1, w2, fontTimeNewRoman9.Height);
            e.Graphics.DrawString("Số điện thoại: " + expCon.AcceptManPhone, fontTimeNewRoman9, drawBrush, drawRect, drawFormatLeft);

            y1 += fontTimeNewRoman9.Height;
            y1 += 5;
            drawRect = new RectangleF(x, y1, w2, (fontTimeNewRoman9.Height * row));
            e.Graphics.DrawString("Địa chỉ: " + expCon.FullAddress, fontTimeNewRoman9, drawBrush, drawRect, drawFormatLeft);
            // Gửi
            y2 += 20;
            drawRect = new RectangleF(x2, y2, w2, (fontTimeNewRoman10Bold.Height * 2));
            e.Graphics.DrawString("Gửi: " + expCon.SendMan, fontTimeNewRoman10Bold, drawBrush, drawRect, drawFormatLeft);

            y2 += (fontTimeNewRoman10Bold.Height * 2);
            y2 += 5;
            drawRect = new RectangleF(x2, y2, w2, fontTimeNewRoman9.Height);
            e.Graphics.DrawString("Số điện thoại: " + expCon.SendManPhone, fontTimeNewRoman9, drawBrush, drawRect, drawFormatLeft);

            y2 += fontTimeNewRoman10.Height;
            y2 += 5;
            drawRect = new RectangleF(x2, y2, w2, (fontTimeNewRoman9.Height * row));
            e.Graphics.DrawString("Địa chỉ: " + expCon.SendManAddress, fontTimeNewRoman9, drawBrush, drawRect, drawFormatLeft);

            //LINE
            y = 335;
            drawRect = new RectangleF(x, y, w, fontTimeNewRoman9.Height);
            e.Graphics.DrawString("---------------------------------------------------------------", fontTimeNewRoman12Bold, drawBrush, drawRect, drawFormatCenter);
            y += fontTimeNewRoman9.Height;
            drawRect = new RectangleF(x, y, w, fontTimeNewRoman10Bold.Height);
            e.Graphics.DrawString("Hàng hóa:", fontTimeNewRoman10Bold, drawBrush, drawRect, drawFormatLeft);
            y += fontTimeNewRoman10.Height;
            y += 5;
            drawRect = new RectangleF(x + 20, y, w, fontTimeNewRoman10.Height);
            e.Graphics.DrawString(expCon.GoodsName + " x " + expCon.GoodsNumber, fontTimeNewRoman10, drawBrush, drawRect, drawFormatLeft);

            //LINE
            y = 380;
            drawRect = new RectangleF(x, y, w, fontTimeNewRoman9.Height);
            e.Graphics.DrawString("---------------------------------------------------------------", fontTimeNewRoman12Bold, drawBrush, drawRect, drawFormatCenter);
            // Line Đứng
            e.Graphics.DrawLine(blackPen, 185, yLine, 185, 345);

            drawRect = new RectangleF(x, 400, w, fontTimeNewRoman10.Height);
            e.Graphics.DrawString("Ghi chú nhận hàng:", fontTimeNewRoman10, drawBrush, drawRect, drawFormatLeft);
            drawRect = new RectangleF(x, 420, w, (fontTimeNewRoman10.Height * 3));

            if (string.IsNullOrEmpty(expCon.Note))
            {
                e.Graphics.DrawString(expCon.ShipNoteType, fontTimeNewRoman10, drawBrush, drawRect, drawFormatLeft);
            }
            else
            {
                e.Graphics.DrawString(expCon.ShipNoteType + " (" + expCon.Note + ")", fontTimeNewRoman10, drawBrush, drawRect, drawFormatLeft);
            }


            drawRect = new RectangleF(x, 500, w, fontTimeNewRoman14.Height);
            e.Graphics.DrawString(expCon.ProviderTypeCode, fontTimeNewRoman14Bold, drawBrush, drawRect, drawFormatCenter);
        }

        public void PrintExpConsignment76x130(view_GExpBill data, PrinterSettings setting, int numberOfCopy, int top1, int left1)
        {
            _top1 = top1;
            _left1 = left1;

            expCon = data;
            PrintDocument printdocument = new PrintDocument();
            printdocument.PrinterSettings = setting;
            printdocument.PrinterSettings.DefaultPageSettings.PaperSize = new PaperSize("76mm x 130mm", 299, 511);
            // Setting
            InitFormat();
            // Event handle
            printdocument.PrintPage += this.Doc_PrintExpConsignment76x130;
            for (int j = 0; j < numberOfCopy; j++)
            {
                printdocument.Print();
            }
        }
        private void Doc_PrintExpConsignment76x130(object sender, PrintPageEventArgs e)
        {
            //Set all parameter for
            RectangleF drawRect;
            int minx = 0;
            int maxx = 287;
            int miny = 5;
            int maxy = 505;
            int trucdung = 0;
            int trucngang = 0;
            // Line Đứng 1
            e.Graphics.DrawLine(blackPen, trucdung, 5, trucdung, 505);
            // Line Đứng 2
            trucdung = 143;
            e.Graphics.DrawLine(blackPen, trucdung, 164, trucdung, 340);
            // Line Đứng 3
            trucdung = 287;
            e.Graphics.DrawLine(blackPen, trucdung, 5, trucdung, 505);

            // Line Ngang 1
            trucngang = 62;
            e.Graphics.DrawLine(blackPen, 0, trucngang, 287, trucngang);
            // Line Ngang 2
            trucngang = 124;
            e.Graphics.DrawLine(blackPen, 0, trucngang, 287, trucngang);
            // Line Ngang 3
            trucngang = 164;
            e.Graphics.DrawLine(blackPen, 0, trucngang, 287, trucngang);
            // Line Ngang 4
            trucngang = 226;
            e.Graphics.DrawLine(blackPen, 0, trucngang, 287, trucngang);
            // Line Ngang 5
            trucngang = 340;
            e.Graphics.DrawLine(blackPen, 0, trucngang, 287, trucngang);
            // Dòng chữ TỔNG TIỀN
            drawRect = new RectangleF(143, 15, 140, fontTimeNewRoman8.Height);
            e.Graphics.DrawString("Tổng tiền thu", fontTimeNewRoman8, drawBrush, drawRect, drawFormatRight);
            // In Số tiền phải thu
            drawRect = new RectangleF(143, 35, 143, 20);
            if (expCon.FK_PaymentType == "GTT")
            {
                e.Graphics.DrawString(PCommon.FormatNumber(expCon.COD.ToString()) + " đ", fontTimeNewRoman12Bold, drawBrush, drawRect, drawFormatRight);
            }
            else
            {
                e.Graphics.DrawString(PCommon.FormatNumber((expCon.COD + expCon.Freight).ToString()) + " đ", fontTimeNewRoman12Bold, drawBrush, drawRect, drawFormatRight);
            }
            Image logo = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Logo\\vn_logo.png");

            string pathImage = AppDomain.CurrentDomain.BaseDirectory + "Logo/vn_logo_" + PBean.LOCAL_OPTIONS.ICON_NAME + ".png";
            if (File.Exists(pathImage))
            {
                logo = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Logo\\vn_logo_" + PBean.LOCAL_OPTIONS.ICON_NAME + ".png");
            }
            // Logo
            e.Graphics.DrawImage(logo, 10, 10);

            // Time
            drawRect = new RectangleF(0, 50, 140, fontTimeNewRoman7.Height);
            e.Graphics.DrawString(string.Format("{0:HH:mm dd/MM/yyyy}", expCon.RegisterDate) + " " + (expCon.FeeWeight - 2000), fontTimeNewRoman7, drawBrush, drawRect, drawFormatLeft);

            if (!string.IsNullOrEmpty(expCon.BT3Code) && expCon.BT3Code.Length <= 14)
            {
                // Barcode mã vận đơn 
                drawRect = new RectangleF(0, 62, 287, 40);
                e.Graphics.DrawString(Common.BarcodeHelper.Encode(expCon.BillCode), fontCode128_50, drawBrush, drawRect, drawFormatCenter);

                // In dòng mã vận đơn bên dưới
                drawRect = new RectangleF(0, 105, 287, fontTimeNewRoman10Bold.Height);
                e.Graphics.DrawString(expCon.BillCode, fontTimeNewRoman10Bold, drawBrush, drawRect, drawFormatCenter);
            }
            else if (expCon.GroupProvider.Contains("LM"))
            {
                // Barcode mã vận đơn 
                drawRect = new RectangleF(0, 62, 287, 40);
                e.Graphics.DrawString(Common.BarcodeHelper.Encode(expCon.BillCode), fontCode128_50, drawBrush, drawRect, drawFormatCenter);

                // In dòng mã vận đơn bên dưới
                drawRect = new RectangleF(0, 105, 287, fontTimeNewRoman10Bold.Height);
                e.Graphics.DrawString(expCon.BillCode, fontTimeNewRoman10Bold, drawBrush, drawRect, drawFormatCenter);
            }

            // In dòng tên nhà cung cấp DV BT3
            drawRect = new RectangleF(0, 135, 287, fontTimeNewRoman12Bold.Height);
            e.Graphics.DrawString(expCon.PrintLable, fontTimeNewRoman12Bold, drawBrush, drawRect, drawFormatCenter);

            // In dòng vật phẩm
            drawRect = new RectangleF(0, 165, 140, fontTimeNewRoman8Bold.Height);
            e.Graphics.DrawString("Tên vật phẩm:", fontTimeNewRoman8Bold, drawBrush, drawRect, drawFormatLeft);
            // In tên vật phẩm
            drawRect = new RectangleF(10, 180, 140, 30);
            e.Graphics.DrawString(expCon.GoodsName, fontTimeNewRoman8Bold, drawBrush, drawRect, drawFormatLeft);

            drawRect = new RectangleF(10, 200, 140, fontTimeNewRoman8Bold.Height);
            e.Graphics.DrawString(expCon.ShipNoteType, fontTimeNewRoman8Bold, drawBrush, drawRect, drawFormatCenter);
            // In dòng trọng lượng
            drawRect = new RectangleF(143, 165, 140, fontTimeNewRoman8Bold.Height);
            e.Graphics.DrawString("Trọng lượng: " + PCommon.FormatNumber(expCon.BillWeight.ToString()) + " Gr", fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);
            // In dòng phương thức thanh toán
            drawRect = new RectangleF(143, 182, 140, fontTimeNewRoman8Bold.Height);
            e.Graphics.DrawString("Phương thức thanh toán", fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);
            // In nội dung phương thức thanh toán
            drawRect = new RectangleF(143, 200, 140, fontTimeNewRoman8Bold.Height + 5);
            e.Graphics.DrawString(expCon.PaymentTypeName, fontTimeNewRoman8Bold, drawBrush, drawRect, drawFormatCenter);

            // In dòng NHẬN
            int row = 230;
            drawRect = new RectangleF(0, row, 140, fontTimeNewRoman8Bold.Height);
            e.Graphics.DrawString("NHẬN", fontTimeNewRoman8Bold, drawBrush, drawRect, drawFormatLeft);

            // IN TÊN NHẬN
            drawRect = new RectangleF(0, row + 12, 140, fontTimeNewRoman8Bold.Height);
            e.Graphics.DrawString(expCon.AcceptMan.ToUpper(), fontTimeNewRoman8Bold, drawBrush, drawRect, drawFormatRight);

            // In dòng chữ GỬI
            drawRect = new RectangleF(143, row, 140, fontTimeNewRoman8Bold.Height);
            e.Graphics.DrawString("GỬI", fontTimeNewRoman8Bold, drawBrush, drawRect, drawFormatLeft);
            // IN TÊN GỬI
            drawRect = new RectangleF(143, row + 12, 140, fontTimeNewRoman8Bold.Height);
            e.Graphics.DrawString(expCon.SendMan.ToUpper(), fontTimeNewRoman8Bold, drawBrush, drawRect, drawFormatRight);

            row = 255;
            // In Số điện thoại nhận
            drawRect = new RectangleF(0, row, 140, fontTimeNewRoman8.Height);
            e.Graphics.DrawString(expCon.AcceptManPhone, fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);

            if (expCon.GroupProvider.Contains("LM"))
            {
                // In số điện thoại gửi
                drawRect = new RectangleF(143, row, 140, fontTimeNewRoman8.Height);
                e.Graphics.DrawString(expCon.SendManPhone, fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);
            }
            else
            {
                // In số điện thoại gửi
                drawRect = new RectangleF(143, row, 140, fontTimeNewRoman8.Height);
                e.Graphics.DrawString(expCon.SendManPhone.Replace("0", "*").Replace("9", "*").Replace("7", "*"), fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);
            }

            row = 275;
            //In địa chỉ nhận
            drawRect = new RectangleF(0, row, 140, 65);
            e.Graphics.DrawString(expCon.FullAddress, fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);

            // In địa chỉ gửi
            drawRect = new RectangleF(143, row, 140, 65);
            e.Graphics.DrawString(expCon.SendManAddress, fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);
            // In chữ [GHI CHÚ]

            row = 342;
            drawRect = new RectangleF(0, row, 140, fontTimeNewRoman8.Height);
            e.Graphics.DrawString("GHI CHÚ:", fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);


            // In dòng ghi chú
            row = 355;
            drawRect = new RectangleF(0, row, 287, 50);
            //e.Graphics.DrawString(expCon.Note, fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);
            e.Graphics.DrawString(expCon.Note, fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);
            string codePrint = expCon.BT3Code;

            if (!string.IsNullOrEmpty(expCon.BT3Code) && expCon.BT3Code.Length <= 14)
            {
                codePrint = expCon.BT3Code;
                // IN MÃ VẠCH VẬN ĐƠN BT3
                row = 410;
                drawRect = new RectangleF(0, row, 287, 40);
                e.Graphics.DrawString(Common.BarcodeHelper.Encode(codePrint), fontCode128_50, drawBrush, drawRect, drawFormatCenter);

                // IN MÃ VẬN ĐƠN BT3
                row = 455;
                drawRect = new RectangleF(0, row, 287, fontTimeNewRoman10Bold.Height);
                e.Graphics.DrawString(codePrint, fontTimeNewRoman10Bold, drawBrush, drawRect, drawFormatCenter);
            }


            // IN DÒNG TỈNH NHẬN HÀNG
            row = 470;
            drawRect = new RectangleF(0, row, 287, fontTimeNewRoman12Bold.Height);
            e.Graphics.DrawString(expCon.AcceptProvince, fontTimeNewRoman12Bold, drawBrush, drawRect, drawFormatCenter);
            // In dòng số lượng
            row = 490;
            drawRect = new RectangleF(0, row, 140, fontTimeNewRoman8.Height);
            e.Graphics.DrawString("Số lượng: " + expCon.GoodsNumber.ToString(), fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);
            // In dòng kích thước
            drawRect = new RectangleF(143, row, 140, fontTimeNewRoman8Bold.Height);
            e.Graphics.DrawString("Kích thước: " + expCon.GoodsW.ToString() + " x " + expCon.GoodsH.ToString() + " x " + expCon.GoodsL.ToString(), fontTimeNewRoman8Bold, drawBrush, drawRect, drawFormatRight);

        }
        /// <summary>
        /// In phiếu thu
        /// </summary>
        /// <param name="data"></param>
        /// <param name="setting"></param>
        /// <param name="numberOfCopy"></param>
        /// <param name="top1"></param>
        /// <param name="left1"></param>
        public void PrintExpConsignmentBill(view_GExpBill data, PrinterSettings setting, int numberOfCopy, int top1, int left1)
        {
            _top1 = top1;
            _left1 = left1;

            expCon = data;
            PrintDocument printdocument = new PrintDocument();
            printdocument.PrinterSettings = setting;
            printdocument.PrinterSettings.DefaultPageSettings.PaperSize = new PaperSize("76mm x 130mm", 299, 511);
            // Setting
            InitFormat();
            // Event handle
            printdocument.PrintPage += this.Doc_PrintExpConsignmentBill;
            for (int j = 0; j < numberOfCopy; j++)
            {
                printdocument.Print();
            }
        }
        private void Doc_PrintExpConsignmentBill(object sender, PrintPageEventArgs e)
        {
            //Set all parameter for
            RectangleF drawRect;
            int minx = 0;
            int maxx = 287;
            int miny = 5;
            int maxy = 505;
            int trucdung = 0;
            int trucngang = 0;
            // Line Đứng 1
            e.Graphics.DrawLine(blackPen, trucdung, 5, trucdung, 505);
            // Line Đứng 2
            trucdung = 143;
            e.Graphics.DrawLine(blackPen, trucdung, 164, trucdung, 340);
            // Line Đứng 3
            trucdung = 287;
            e.Graphics.DrawLine(blackPen, trucdung, 5, trucdung, 505);

            // Line Ngang 1 //40 62
            trucngang = 62;
            e.Graphics.DrawLine(blackPen, 0, trucngang, 287, trucngang);
            // Line Ngang 2
            trucngang = 102;
            e.Graphics.DrawLine(blackPen, 0, trucngang, 287, trucngang);
            // Line Ngang 3
            trucngang = 164;
            e.Graphics.DrawLine(blackPen, 0, trucngang, 287, trucngang);
            // Line Ngang 4
            trucngang = 226;
            e.Graphics.DrawLine(blackPen, 0, trucngang, 287, trucngang);
            // Line Ngang 5
            trucngang = 340;
            e.Graphics.DrawLine(blackPen, 0, trucngang, 287, trucngang);
            // Dòng chữ TỔNG TIỀN
            drawRect = new RectangleF(143, 15, 140, fontTimeNewRoman8.Height);
            e.Graphics.DrawString("Tổng tiền thu", fontTimeNewRoman8, drawBrush, drawRect, drawFormatRight);
            // In Số tiền phải thu
            drawRect = new RectangleF(143, 35, 143, 20);
            if (expCon.FK_PaymentType == "GTT")
            {
                e.Graphics.DrawString(PCommon.FormatNumber(expCon.COD.ToString()) + " đ", fontTimeNewRoman12Bold, drawBrush, drawRect, drawFormatRight);
            }
            else
            {
                e.Graphics.DrawString(PCommon.FormatNumber((expCon.COD + expCon.Freight).ToString()) + " đ", fontTimeNewRoman12Bold, drawBrush, drawRect, drawFormatRight);
            }
            Image logo = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Logo\\vn_logo.png");

            string pathImage = AppDomain.CurrentDomain.BaseDirectory + "Logo/vn_logo_" + PBean.LOCAL_OPTIONS.ICON_NAME + ".png";
            if (File.Exists(pathImage))
            {
                logo = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Logo\\vn_logo_" + PBean.LOCAL_OPTIONS.ICON_NAME + ".png");
            }
            // Logo
            e.Graphics.DrawImage(logo, 10, 10);

            // Time
            drawRect = new RectangleF(0, 50, 140, fontTimeNewRoman7.Height);
            e.Graphics.DrawString(string.Format("{0:HH:mm dd/MM/yyyy}", expCon.RegisterDate), fontTimeNewRoman7, drawBrush, drawRect, drawFormatLeft);


            // In dòng mã vận đơn bên thứ 3
            if (expCon.IsPayCustomer == false)
            {
                drawRect = new RectangleF(0, 72, 287, fontTimeNewRoman12Bold.Height);
                e.Graphics.DrawString("BIÊN NHẬN GỬI HÀNG", fontTimeNewRoman12Bold, drawBrush, drawRect, drawFormatCenter);
            }
            else
            {
                drawRect = new RectangleF(0, 72, 287, fontTimeNewRoman10Bold.Height);
                e.Graphics.DrawString("ĐÃ ĐỐI SOÁT NGÀY " + string.Format("{0:dd/MM/yyyy}", expCon.PayCustomerDate), fontTimeNewRoman10Bold, drawBrush, drawRect, drawFormatCenter);
            }

            // Barcode mã vận đơn 
            drawRect = new RectangleF(0, 100, 287, 40);
            e.Graphics.DrawString(Common.BarcodeHelper.Encode(expCon.BillCode), fontCode128_50, drawBrush, drawRect, drawFormatCenter);
            // In dòng mã vận đơn bên dưới
            drawRect = new RectangleF(0, 145, 287, fontTimeNewRoman10Bold.Height);
            e.Graphics.DrawString(expCon.BillCode, fontTimeNewRoman10Bold, drawBrush, drawRect, drawFormatCenter);

            // In dòng vật phẩm
            drawRect = new RectangleF(0, 165, 140, fontTimeNewRoman8Bold.Height);
            e.Graphics.DrawString("Tên vật phẩm:", fontTimeNewRoman8Bold, drawBrush, drawRect, drawFormatLeft);
            // In tên vật phẩm
            drawRect = new RectangleF(10, 180, 140, fontTimeNewRoman8Bold.Height);
            e.Graphics.DrawString(expCon.GoodsName, fontTimeNewRoman8Bold, drawBrush, drawRect, drawFormatLeft);

            drawRect = new RectangleF(10, 200, 140, fontTimeNewRoman8Bold.Height);
            e.Graphics.DrawString(expCon.ShipNoteType, fontTimeNewRoman8Bold, drawBrush, drawRect, drawFormatCenter);
            // In dòng trọng lượng
            drawRect = new RectangleF(143, 165, 140, fontTimeNewRoman8Bold.Height);
            e.Graphics.DrawString("Trọng lượng: " + PCommon.FormatNumber(expCon.FeeWeight.ToString()) + " Gr", fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);
            // In dòng phương thức thanh toán
            drawRect = new RectangleF(143, 182, 140, fontTimeNewRoman8Bold.Height);
            e.Graphics.DrawString("Phương thức thanh toán", fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);
            // In nội dung phương thức thanh toán
            drawRect = new RectangleF(143, 200, 140, fontTimeNewRoman8Bold.Height + 5);
            e.Graphics.DrawString(expCon.PaymentTypeName, fontTimeNewRoman8Bold, drawBrush, drawRect, drawFormatCenter);

            // In dòng NHẬN
            int row = 230;
            drawRect = new RectangleF(0, row, 140, fontTimeNewRoman8Bold.Height);
            e.Graphics.DrawString("NHẬN", fontTimeNewRoman8Bold, drawBrush, drawRect, drawFormatLeft);

            // IN TÊN NHẬN
            drawRect = new RectangleF(0, row + 12, 140, fontTimeNewRoman8Bold.Height);
            e.Graphics.DrawString(expCon.AcceptMan.ToUpper(), fontTimeNewRoman8Bold, drawBrush, drawRect, drawFormatRight);

            // In dòng chữ GỬI
            drawRect = new RectangleF(143, row, 140, fontTimeNewRoman8Bold.Height);
            e.Graphics.DrawString("GỬI", fontTimeNewRoman8Bold, drawBrush, drawRect, drawFormatLeft);
            // IN TÊN GỬI
            drawRect = new RectangleF(143, row + 12, 140, fontTimeNewRoman8Bold.Height);
            e.Graphics.DrawString(expCon.SendMan.ToUpper(), fontTimeNewRoman8Bold, drawBrush, drawRect, drawFormatRight);

            row = 255;
            // In Số điện thoại nhận
            drawRect = new RectangleF(0, row, 140, fontTimeNewRoman8.Height);
            e.Graphics.DrawString(expCon.AcceptManPhone, fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);

            // In số điện thoại gửi
            drawRect = new RectangleF(143, row, 140, fontTimeNewRoman8.Height);
            e.Graphics.DrawString(expCon.SendManPhone, fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);

            row = 275;
            //In địa chỉ nhận
            drawRect = new RectangleF(0, row, 140, 65);
            e.Graphics.DrawString(expCon.FullAddress, fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);

            // In địa chỉ gửi
            drawRect = new RectangleF(143, row, 140, 65);
            e.Graphics.DrawString(expCon.SendManAddress, fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);
            // In chữ [GHI CHÚ]
            row = 345;
            drawRect = new RectangleF(0, row, 287, 65);
            e.Graphics.DrawString("Theo dõi đơn: www.lemai.vn/?code=" + expCon.BillCode, fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);

            // IN DÒNG SỐ TIỀN COD
            row = 390;
            drawRect = new RectangleF(143, row, 140, fontTimeNewRoman10Bold.Height);
            e.Graphics.DrawString("THU HỘ (COD)", fontTimeNewRoman10Bold, drawBrush, drawRect, drawFormatLeft);

            // IN QR CODE
            Image qrCode = RenderQrCode("https://lemai.vn/?code=" + expCon.BillCode);
            // Logo
            e.Graphics.DrawImage(qrCode, 10, 360);

            row = 410;
            drawRect = new RectangleF(143, row, 140, fontTimeNewRoman10Bold.Height);
            e.Graphics.DrawString(PCommon.FormatNumber(expCon.COD.ToString()) + " đ", fontTimeNewRoman10Bold, drawBrush, drawRect, drawFormatCenter);


            // IN SỐ TIỀN PHÍ Vận chuyển
            row = 430;
            drawRect = new RectangleF(143, row, 140, fontTimeNewRoman10Bold.Height);
            e.Graphics.DrawString("PHÍ VẬN CHUYỂN", fontTimeNewRoman10Bold, drawBrush, drawRect, drawFormatLeft);

            row = 450;
            drawRect = new RectangleF(143, row, 140, fontTimeNewRoman10Bold.Height);
            e.Graphics.DrawString(PCommon.FormatNumber(expCon.Freight.ToString()) + " đ", fontTimeNewRoman10Bold, drawBrush, drawRect, drawFormatCenter);

            // In dòng ngày in
            row = 475;
            // In dòng kích thước
            drawRect = new RectangleF(143, row, 140, fontTimeNewRoman8.Height);
            e.Graphics.DrawString("Ngày In:" + string.Format("{0:HH:mm dd/MM/yy}", DateTime.Now), fontTimeNewRoman8, drawBrush, drawRect, drawFormatRight);


            // In dòng số lượng
            row = 490;
            drawRect = new RectangleF(0, row, 140, fontTimeNewRoman8.Height);
            e.Graphics.DrawString("Số lượng: " + expCon.GoodsNumber.ToString(), fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);
            // In dòng kích thước
            drawRect = new RectangleF(143, row, 140, fontTimeNewRoman8.Height);
            e.Graphics.DrawString("NV In:" + PBean.USER.FullName, fontTimeNewRoman8, drawBrush, drawRect, drawFormatRight);
        }

        private void InitFormat()
        {
            drawFormatCenter.Alignment = StringAlignment.Center;
            drawFormatLeft.Alignment = StringAlignment.Near;
            drawFormatRight.Alignment = StringAlignment.Far;
        }
        private Bitmap RenderQrCode(string text)
        {
            QRCodeGenerator.ECCLevel eccLevel = QRCodeGenerator.ECCLevel.L;
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, eccLevel))
            using (QRCode qrCode = new QRCode(qrCodeData))
            {
                return qrCode.GetGraphic(3, Color.Black, Color.White, null, 0);
            }
        }
    }
}
