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
    public class PrintDocumentTinDat : IDocumentPrint
    {
        Pen blackPen = new Pen(Color.Black, 1);

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
        #region Tem 76x130
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="setting"></param>
        /// <param name="isReceipt"></param>
        public void Print76x130(view_GExpBill data, PrinterSettings setting, bool isReceipt)
        {
            expCon = data;
            PrintDocument printdocument = new PrintDocument();
            printdocument.PrinterSettings = setting;
            printdocument.PrinterSettings.DefaultPageSettings.PaperSize = new PaperSize("76mm x 130mm", 299, 511);
            // Setting
            InitFormat();
            if (isReceipt == true)
            {
                //In biên nhận
                printdocument.PrintPage += this.Doc_PrintReceipt76x130;
            }
            else
            {
                // In tem dán trên kiện hàng
                printdocument.PrintPage += this.Doc_PrintBill76x130;
            }
            for (int j = 0; j < setting.Copies; j++)
            {
                printdocument.Print();
            }
        }
        private void Doc_PrintBill76x130(object sender, PrintPageEventArgs e)
        {
            //Set all parameter for
            RectangleF drawRect;
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

            if (!string.IsNullOrEmpty(expCon.BT3Code))
            {
                // Barcode mã vận đơn 
                drawRect = new RectangleF(0, 62, 287, 40);
                e.Graphics.DrawString(Common.BarcodeHelper.Encode(expCon.BillCode), fontCode128_50, drawBrush, drawRect, drawFormatCenter);

                // In dòng mã vận đơn bên dưới
                drawRect = new RectangleF(0, 105, 287, fontTimeNewRoman10Bold.Height);
                e.Graphics.DrawString(expCon.BillCode, fontTimeNewRoman10Bold, drawBrush, drawRect, drawFormatCenter);
            }
            else if (expCon.RunMode == 0)
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

            row = 342;
            drawRect = new RectangleF(0, row, 140, fontTimeNewRoman8.Height);
            e.Graphics.DrawString("GHI CHÚ:", fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);


            // In dòng ghi chú
            row = 355;
            drawRect = new RectangleF(0, row, 287, 50);
            //e.Graphics.DrawString(expCon.Note, fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);
            e.Graphics.DrawString(expCon.Note, fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);
            string codePrint = expCon.BT3Code;

            if (!string.IsNullOrEmpty(expCon.BT3Code))
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
            else
            {
                codePrint = expCon.BillCode;
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
        private void Doc_PrintReceipt76x130(object sender, PrintPageEventArgs e)
        {
            // 287 x 505
            //Set all parameter for
            RectangleF drawRect;
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
        #endregion

        #region Tem ZTO 100x180
        public void Print100x180(view_GExpBill data, PrinterSettings setting, bool isReceipt)
        {
            // 377 x 705
            expCon = data;
            PrintDocument printdocument = new PrintDocument();
            printdocument.PrinterSettings = setting;
            printdocument.PrinterSettings.DefaultPageSettings.PaperSize = new PaperSize("100mm x 180mm", 380, 705);
            // 377 x 
            // Setting
            InitFormat();
            if (isReceipt == true)
            {
                //In biên nhận
                printdocument.PrintPage += this.Doc_PrintReceipt100x180;
            }
            else
            {
                // In tem dán trên kiện hàng
                printdocument.PrintPage += this.Doc_PrintBill100x180;
            }
            for (int j = 0; j < setting.Copies; j++)
            {
                printdocument.Print();
            }
        }
        private void Doc_PrintBill100x180(object sender, PrintPageEventArgs e)
        {
            //Set all parameter for
            RectangleF drawRect;
            int trucdung = 5;
            int trucngang = 0;
            // Line Đứng 1
            trucdung = 188;
            e.Graphics.DrawLine(blackPen, trucdung, 45, trucdung, 201);

            // Line Đứng 2
            trucdung = 125;
            e.Graphics.DrawLine(blackPen, trucdung, 315, trucdung, 423);
            // Line Đứng 3
            trucdung = 250;
            e.Graphics.DrawLine(blackPen, trucdung, 315, trucdung, 423);

            // Line Đứng 4
            trucdung = 62;
            e.Graphics.DrawLine(blackPen, trucdung, 500, trucdung, 572);

            // Line Ngang 1
            trucngang = 45;
            e.Graphics.DrawLine(blackPen, 0, trucngang, 377, trucngang);
            // Line Ngang 2
            trucngang = 149;
            e.Graphics.DrawLine(blackPen, 0, trucngang, 377, trucngang);
            // Line Ngang 3
            trucngang = 201;
            e.Graphics.DrawLine(blackPen, 0, trucngang, 377, trucngang);
            // Line Ngang 4
            trucngang = 253;
            e.Graphics.DrawLine(blackPen, 0, trucngang, 377, trucngang);
            // Line Ngang 5
            trucngang = 315;
            e.Graphics.DrawLine(blackPen, 0, trucngang, 377, trucngang);
            // Line Ngang 6
            trucngang = 423;
            e.Graphics.DrawLine(blackPen, 0, trucngang, 377, trucngang);
            // Line Ngang 7
            trucngang = 443;
            e.Graphics.DrawLine(blackPen, 0, trucngang, 377, trucngang);
            // Line Ngang 8
            trucngang = 500;
            e.Graphics.DrawLine(blackPen, 0, trucngang, 377, trucngang);
            // Line Ngang 9
            trucngang = 572;
            e.Graphics.DrawLine(blackPen, 0, trucngang, 377, trucngang);
            // Line Ngang 10
            trucngang = 705;
            e.Graphics.DrawLine(blackPen, 0, trucngang, 377, trucngang);

            // IN DỮ LIỆU TỪ TRÊN XUỐNG DƯỚI, TRÁI SANG PHẢI
            // Time
            drawRect = new RectangleF(190, 30, 185, fontTimeNewRoman7.Height);
            e.Graphics.DrawString(string.Format("{0:HH:mm dd/MM/yyyy}", expCon.RegisterDate) + " " + (expCon.FeeWeight - 2000), fontTimeNewRoman7, drawBrush, drawRect, drawFormatLeft);

            drawRect = new RectangleF(5, 45, 50, fontTimeNewRoman8.Height);
            e.Graphics.DrawString("NHẬN", fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);

            drawRect = new RectangleF(5, 45, 185, fontTimeNewRoman8Bold.Height);
            e.Graphics.DrawString(expCon.AcceptMan, fontTimeNewRoman8Bold, drawBrush, drawRect, drawFormatRight);

            drawRect = new RectangleF(5, 60, 180, fontTimeNewRoman8.Height);
            e.Graphics.DrawString(expCon.AcceptManPhone, fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);

            drawRect = new RectangleF(5, 80, 180, 80);
            e.Graphics.DrawString(expCon.FullAddress, fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);

            drawRect = new RectangleF(190, 45, 50, fontTimeNewRoman8.Height);
            e.Graphics.DrawString("GỬI", fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);

            drawRect = new RectangleF(190, 45, 180, fontTimeNewRoman8Bold.Height);
            e.Graphics.DrawString(expCon.SendMan, fontTimeNewRoman8Bold, drawBrush, drawRect, drawFormatRight);

            drawRect = new RectangleF(190, 60, 180, fontTimeNewRoman8.Height);
            e.Graphics.DrawString(expCon.SendManPhone, fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);
            drawRect = new RectangleF(190, 80, 180, 80);
            e.Graphics.DrawString(expCon.SendManAddress, fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);

            // Phương thức thanh toán
            drawRect = new RectangleF(5, 150, 180, fontTimeNewRoman8.Height);
            e.Graphics.DrawString("Phương thức thanh toán", fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);

            drawRect = new RectangleF(5, 180, 180, fontTimeNewRoman8Bold.Height);
            e.Graphics.DrawString(expCon.PayType, fontTimeNewRoman8Bold, drawBrush, drawRect, drawFormatLeft);

            // Loại dịch vụ
            drawRect = new RectangleF(190, 150, 190, fontTimeNewRoman8.Height);
            e.Graphics.DrawString("Loại dịch vụ: COD", fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);

            drawRect = new RectangleF(190, 180, 190, fontTimeNewRoman8.Height);
            e.Graphics.DrawString("Loại kiện nội địa", fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);

            // Tên dịch vụ
            drawRect = new RectangleF(0, 210, 388, fontTimeNewRoman12Bold.Height);
            e.Graphics.DrawString(expCon.PrintLable, fontTimeNewRoman12Bold, drawBrush, drawRect, drawFormatCenter);

            // BARCODE 
            if (!string.IsNullOrEmpty(expCon.BT3Code))
            {
                // Barcode mã vận đơn 
                drawRect = new RectangleF(0, 250, 388, 40);
                e.Graphics.DrawString(Common.BarcodeHelper.Encode(expCon.BillCode), fontCode128_50, drawBrush, drawRect, drawFormatCenter);

                // In dòng mã vận đơn bên dưới
                drawRect = new RectangleF(0, 295, 388, fontTimeNewRoman10Bold.Height);
                e.Graphics.DrawString(expCon.BillCode, fontTimeNewRoman10Bold, drawBrush, drawRect, drawFormatCenter);
            }
            else if (expCon.RunMode == 0)
            {
                // Barcode mã vận đơn 
                drawRect = new RectangleF(0, 250, 388, 40);
                e.Graphics.DrawString(Common.BarcodeHelper.Encode(expCon.BillCode), fontCode128_50, drawBrush, drawRect, drawFormatCenter);

                // In dòng mã vận đơn bên dưới
                drawRect = new RectangleF(0, 295, 388, fontTimeNewRoman10Bold.Height);
                e.Graphics.DrawString(expCon.BillCode, fontTimeNewRoman10Bold, drawBrush, drawRect, drawFormatCenter);
            }

            drawRect = new RectangleF(5, 320, 120, fontTimeNewRoman8.Height);
            e.Graphics.DrawString("Trọng lượng", fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);

            drawRect = new RectangleF(5, 340, 120, fontTimeNewRoman8Bold.Height);
            e.Graphics.DrawString(expCon.BillWeight.ToString("N0") + " Gram", fontTimeNewRoman8Bold, drawBrush, drawRect, drawFormatRight);

            drawRect = new RectangleF(5, 370, 120, fontTimeNewRoman8.Height);
            e.Graphics.DrawString("Số lượng:", fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);

            drawRect = new RectangleF(5, 390, 120, fontTimeNewRoman8Bold.Height);
            e.Graphics.DrawString(expCon.GoodsNumber + " Kiện", fontTimeNewRoman8Bold, drawBrush, drawRect, drawFormatRight);


            drawRect = new RectangleF(130, 320, 125, fontTimeNewRoman8.Height);
            e.Graphics.DrawString("Tổng tiền thu", fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);

            if (expCon.FK_PaymentType == "GTT")
            {
                drawRect = new RectangleF(130, 340, 125, fontTimeNewRoman12Bold.Height);
                e.Graphics.DrawString(expCon.COD.ToString("N0") + " đ", fontTimeNewRoman12Bold, drawBrush, drawRect, drawFormatCenter);
            }
            else
            {
                drawRect = new RectangleF(130, 340, 125, fontTimeNewRoman12Bold.Height);
                e.Graphics.DrawString((expCon.COD + expCon.Freight).ToString("N0") + " đ", fontTimeNewRoman12Bold, drawBrush, drawRect, drawFormatCenter);
            }

            drawRect = new RectangleF(130, 390, 125, fontTimeNewRoman8Bold.Height);
            e.Graphics.DrawString(expCon.ShipNoteType, fontTimeNewRoman8Bold, drawBrush, drawRect, drawFormatCenter);

            drawRect = new RectangleF(255, 320, 125, fontTimeNewRoman8.Height);
            e.Graphics.DrawString("Người ký nhận", fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);

            drawRect = new RectangleF(255, 370, 125, fontTimeNewRoman8.Height);
            e.Graphics.DrawString("Thời gian ký nhận", fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);


            if (!string.IsNullOrEmpty(expCon.BT3Code))
            {
                // Barcode mã vận đơn 
                drawRect = new RectangleF(140, 440, 248, 40);
                e.Graphics.DrawString(Common.BarcodeHelper.Encode(expCon.BT3Code), fontCode128_50, drawBrush, drawRect, drawFormatCenter);

                // In dòng mã vận đơn bên dưới
                drawRect = new RectangleF(140, 485, 248, fontTimeNewRoman10Bold.Height);
                e.Graphics.DrawString(expCon.BT3Code, fontTimeNewRoman10Bold, drawBrush, drawRect, drawFormatCenter);
            }
            else
            {
                // Barcode mã vận đơn 
                drawRect = new RectangleF(140, 440, 248, 40);
                e.Graphics.DrawString(Common.BarcodeHelper.Encode(expCon.BillCode), fontCode128_50, drawBrush, drawRect, drawFormatCenter);

                // In dòng mã vận đơn bên dưới
                drawRect = new RectangleF(140, 485, 248, fontTimeNewRoman10Bold.Height);
                e.Graphics.DrawString(expCon.BillCode, fontTimeNewRoman10Bold, drawBrush, drawRect, drawFormatCenter);
            }
            // Dòng chữ GỬI
            drawRect = new RectangleF(0, 520, 62, fontTimeNewRoman12Bold.Height);
            e.Graphics.DrawString("GỬI", fontTimeNewRoman12Bold, drawBrush, drawRect, drawFormatCenter);

            drawRect = new RectangleF(70, 510, 150, fontTimeNewRoman8Bold.Height);
            e.Graphics.DrawString(expCon.SendMan, fontTimeNewRoman8Bold, drawBrush, drawRect, drawFormatLeft);

            drawRect = new RectangleF(220, 510, 140, fontTimeNewRoman8.Height);
            e.Graphics.DrawString(expCon.SendManPhone, fontTimeNewRoman8, drawBrush, drawRect, drawFormatRight);

            drawRect = new RectangleF(70, 530, 300, 30);
            e.Graphics.DrawString(expCon.SendManAddress, fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);

            // Dòng chữ ghi chú:
            drawRect = new RectangleF(0, 572, 62, fontTimeNewRoman8.Height);
            e.Graphics.DrawString("Ghi chú:", fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);

            drawRect = new RectangleF(70, 572, 300, fontTimeNewRoman8.Height);
            e.Graphics.DrawString("Loại mặt hàng: " + expCon.GoodsName, fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);

            drawRect = new RectangleF(0, 590, 377, 60);
            e.Graphics.DrawString(expCon.Note, fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);

            drawRect = new RectangleF(5, 680, 388, fontTimeNewRoman8.Height);
            e.Graphics.DrawString("Trọng lượng: " + expCon.BillWeight + " Gram. Kích thước " + expCon.GoodsW + " X " + expCon.GoodsH + " X " + expCon.GoodsL, fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);

        }
        private void Doc_PrintReceipt100x180(object sender, PrintPageEventArgs e)
        {
            //Set all parameter for
            RectangleF drawRect;
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
        #endregion

        #region Tem 100x150
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="setting"></param>
        /// <param name="isReceipt"></param>
        public void Print100x150(view_GExpBill data, PrinterSettings setting, bool isReceipt)
        {
            expCon = data;
            PrintDocument printdocument = new PrintDocument();
            printdocument.PrinterSettings = setting;
            printdocument.PrinterSettings.DefaultPageSettings.PaperSize = new PaperSize("100mm x 150mm", 394, 708);
            // Setting
            InitFormat();
            if (isReceipt == true)
            {
                //In biên nhận
                printdocument.PrintPage += this.Doc_PrintReceipt100x150;
            }
            else
            {
                // In tem dán trên kiện hàng
                printdocument.PrintPage += this.Doc_PrintBill100x150;
            }
            for (int j = 0; j < setting.Copies; j++)
            {
                printdocument.Print();
            }
        }
        private void Doc_PrintBill100x150(object sender, PrintPageEventArgs e)
        {
            //Set all parameter for
            RectangleF drawRect;
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
            else if (expCon.RunMode == 0)
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

            if (expCon.RunMode == 0)
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
        private void Doc_PrintReceipt100x150(object sender, PrintPageEventArgs e)
        {
            //Set all parameter for
            RectangleF drawRect;
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
        #endregion
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
