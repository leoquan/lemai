using LeMaiDomain;
using LeMaiLogic.Logic;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeMaiDesktop
{
    public partial class frmXuLyDonHang : frmBase
    {
        StringBuilder htmlstr = new StringBuilder();
        private ExpConsignmentV2Logic _logic = new ExpConsignmentV2Logic(PBean.ConnectionBase);
        Dictionary<string, string> lsPayMethod = new Dictionary<string, string>();
        public string _BillCode = string.Empty;
        public string _Comment = string.Empty;
        public string _Type = string.Empty;

        public bool processBill = false;
        public bool updateStatus = false;
        public string updateStatusName = string.Empty;
        public string commentContent = string.Empty;

        List<ExpBILL> lsBill = new List<ExpBILL>();
        public frmXuLyDonHang() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
        }
        public frmXuLyDonHang(string MaVanDon) : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
            _BillCode = MaVanDon;
        }

        private async void frmXuLyDonHang_Load(object sender, EventArgs e)
        {
            // Load Comment Type
            cmbLoaiXuLy.DataSource = await _logic.GetListCommentType();
            cmbLoaiXuLy.DisplayMember = "TypeName";
            cmbLoaiXuLy.ValueMember = "Id";
            // Load tình trạng
            cmbTinhTrang.DataSource = await _logic.GetListBillStatusType();
            cmbTinhTrang.DisplayMember = "StatusName";
            cmbTinhTrang.ValueMember = "Id";

            if (!string.IsNullOrEmpty(_BillCode))
            {
                txtMaDonHang.Text = _BillCode;
                lsBill = _logic.GetListBillByCode(_BillCode);
                if (lsBill.Count > 0)
                {
                    cmbTinhTrang.SelectedValue = lsBill[0].BILL_PROCESS_STATUS;
                    MakeHtml(lsBill);
                    webBrowser.DocumentText = htmlstr.ToString();
                }
                else
                {
                    MessageBox.Show("Dữ liệu không tồn tại vui lòng thử lại.");
                }
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtComment.Text))
            {
                List<string> bills = new List<string>();
                foreach (var item in txtMaDonHang.Lines.ToList())
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        bills.Add(item);
                    }
                }
                string result = _logic.CommentOnBill(bills, cmbLoaiXuLy.SelectedValue.ToString(), txtComment.Text.Trim(), PBean.USER.Id, cmbTinhTrang.SelectedValue.ToString(), cmbTinhTrang.Text, out updateStatus);
                if (!string.IsNullOrEmpty(result))
                {
                    MessageBox.Show(result, PBean.MESSAGE_TITLE);
                }
                else
                {
                    // Xử lý thành công
                    updateStatusName = cmbTinhTrang.Text.Trim();
                    processBill = true;
                    commentContent = txtComment.Text.Trim();
                    btnTruyVan_Click(null, null);
                }
            }
        }
        private void MakeHtml(List<ExpBILL> listBill)
        {
            this.htmlstr = new StringBuilder();
            this.htmlstr.Append("<html>");
            this.htmlstr.Append("<head>");
            this.htmlstr.Append("<meta http-equiv=\"Content-type\" content=\"text/html; charset=gb2312\">");
            this.htmlstr.Append("  <style><!--   A {TEXT-DECORATION: none } body  {background:#FFFFFF;} -->    </style> ");
            this.htmlstr.Append(" <script type=\"text/javascript\">  function getbill_code(s) { window.location.hash = s } function Showdia(str) { alert(str); } function hideTip() { var fm = getTipDiv(); if (fm != undefined) { fm.style.display = \"none\"; } } function showTip(message, e) { var fm = getTipDiv(); var posX, posY; if (document.all) { posX = window.event.clientX + document.documentElement.scrollLeft + document.body.scrollLeft; posY = window.event.clientY + document.documentElement.scrollTop + document.body.scrollTop; } else if (e) { posX = document.body.scrollLeft + e.pageX; posY = document.body.scrollTop + e.pageY; } else { posX = 10; posY = 10; } var top = posY + 15; var left = posX + 5; fm.style.left = left + \"px\"; fm.style.top = top + \"px\"; fm.style.display = \"\"; fm.innerHTML = message; } var getTipDiv = function () { var id = \"__popids\"; var getObj = document.getElementById(id); if (getObj != undefined) return getObj; var div = document.createElement(\"DIV\"); div.setAttribute(\"id\", id); div.cssText = \"-moz-opacity:.8;\"; div.style.display = \"none\"; div.style.position = \"absolute\"; div.style.top = \"0px\"; div.style.left = \"0px\"; div.style.background = \"#FFFF99\"; div.style.border = \"1px\"; div.style.filter = \"alpha(opacity=80)\"; document.body.appendChild(div); return div; }  </script> ");
            this.htmlstr.Append("</head>");
            this.htmlstr.Append("<body>");

            foreach (var item in listBill)
            {
                this.htmlstr.Append("<table style=\"margin-top:25px; border-collapse: collapse; font-family: Calibri; font-size: 12px\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" height=\"10\">");
                this.htmlstr.Append("<tbody>");
                this.htmlstr.Append("<tr>");
                this.htmlstr.Append("<td height=\"25\" valign=\"bottom\"><b> <font color=\"Blue\" size=\"13px\"> #===== ĐƠN HÀNG " + item.BILL_CODE + "=====#</font></b></td>");
                this.htmlstr.Append("</tr>");
                this.htmlstr.Append("</tbody>");
                this.htmlstr.Append("</table>");
                // 1.a Tiêu đề của bảng bill
                this.htmlstr.Append("<table style=\"border-collapse: collapse; font-family: Calibri; font-size: 12px\" border=\"1\" cellspacing=\"0\" width=\"100%\" bordercolor=\"#C0C0C0\">");
                this.htmlstr.Append("<tbody>");
                this.htmlstr.Append("<tr>");
                this.htmlstr.Append("<td width=\"140\" valign=\"middle\" align=\"center\" height=\"25\" bgcolor=\"#F3F3F3\"><b id=\"aCode\"><a name=\"top\" id=\"top\">Số vận đơn</a></b></td>");
                this.htmlstr.Append("<td width=\"100\" valign=\"middle\" align=\"center\" height=\"25\" bgcolor=\"#F3F3F3\"><b>Ngày gửi hàng</b></td>");
                this.htmlstr.Append("<td width=\"140\" valign=\"middle\" align=\"center\" height=\"25\" bgcolor=\"#F3F3F3\"><b>Điểm gửi hàng</b></td>");
                this.htmlstr.Append("<td width=\"140\" valign=\"middle\" align=\"center\" height=\"25\" bgcolor=\"#F3F3F3\"><b>Người gửi</b></td>");
                this.htmlstr.Append("<td width=\"140\" valign=\"middle\" align=\"center\" height=\"25\" bgcolor=\"#F3F3F3\"><b>Số điện thoại gửi hàng</b></td>");
                this.htmlstr.Append("<td width=\"140\" valign=\"middle\" align=\"center\" height=\"25\" bgcolor=\"#F3F3F3\"><b>Điểm đến</b></td>");
                this.htmlstr.Append("<td width=\"140\" valign=\"middle\" align=\"center\" height=\"25\" bgcolor=\"#F3F3F3\"><b>Người nhận</b></td>");
                this.htmlstr.Append("<td width=\"140\" valign=\"middle\" align=\"center\" height=\"25\" bgcolor=\"#F3F3F3\"><b>Số điện thoại nhận hàng</b></td>");
                this.htmlstr.Append("<td width=\"140\" valign=\"middle\" align=\"center\" height=\"25\" bgcolor=\"#F3F3F3\"><b>Địa chỉ nhận hàng</b></td>");
                this.htmlstr.Append("<td width=\"60\" valign=\"middle\" align=\"center\" height=\"25\" bgcolor=\"#F3F3F3\"><b>Số lượng hàng hóa</b></td>");
                this.htmlstr.Append("<td width=\"60\" valign=\"middle\" align=\"center\" height=\"25\" bgcolor=\"#F3F3F3\"><b>Trọng lượng</b></td>");
                this.htmlstr.Append("<td width=\"90\" valign=\"middle\" align=\"center\" height=\"25\" bgcolor=\"#F3F3F3\"><b>Phương thức thanh toán</b></td>");
                this.htmlstr.Append("<td width=\"90\" valign=\"middle\" align=\"center\" height=\"25\" bgcolor=\"#F3F3F3\"><b>Số tiền thu hộ</b></td>");
                this.htmlstr.Append("<td width=\"140\" valign=\"middle\" align=\"center\" height=\"25\" bgcolor=\"#F3F3F3\"><b>Phí vận chuyển</b></td>");
                this.htmlstr.Append("<td width=\"90\" valign=\"middle\" align=\"center\" height=\"25\" bgcolor=\"#F3F3F3\"><b>Tổng nhận trả</b></td>"); // Total
                this.htmlstr.Append("<td width=\"140\" valign=\"middle\" align=\"center\" height=\"25\" bgcolor=\"#F3F3F3\"><b>Thời gian ký nhận</b></td>");
                this.htmlstr.Append("<td width=\"140\" valign=\"middle\" align=\"center\" height=\"25\" bgcolor=\"#F3F3F3\"><b>Ghi chú</b></td>");
                this.htmlstr.Append("</tr>");
                // 1.b Data của bill
                this.htmlstr.Append("<tr>");
                this.htmlstr.Append("<td width=\"140\" align=\"center\" height=\"22\"><a id=\"ks\" href=\"#a_" + item.BILL_CODE + "\"id=\"" + item.BILL_CODE + "\" name=\"" + item.BILL_CODE + "\">" + item.BILL_CODE + "</a></td>");
                this.htmlstr.Append("<td width=\"100\" align=\"center\" height=\"22\">" + string.Format("{0:dd/MM/yyyy HH:mm}", item.REGISTER_DATE) + "</td>");
                this.htmlstr.Append("<td width=\"140\" align=\"center\" height=\"22\">" + item.REGISTER_SITE_CODE + "</td>");
                this.htmlstr.Append("<td width=\"140\" align=\"center\" height=\"22\">" + item.SEND_MAN + "</td>");
                this.htmlstr.Append("<td width=\"140\" align=\"center\" height=\"22\">" + item.SEND_MAN_PHONE + "</td>");
                this.htmlstr.Append("<td width=\"140\" align=\"center\" height=\"22\">" + item.DES_SITE + "</td>");
                this.htmlstr.Append("<td width=\"140\" align=\"center\" height=\"22\">" + item.ACCEPT_MAN + "</td>");
                this.htmlstr.Append("<td width=\"140\" align=\"center\" height=\"22\">" + item.ACCEPT_MAN_PHONE + "</td>");
                this.htmlstr.Append("<td width=\"140\" align=\"center\" height=\"22\">" + item.ACCEPT_MAN_ADDRESS + ", " + item.ACCEPT_COUNTY_CODE + ", " + item.ACCEPT_CITY_CODE + ", " + item.ACCEPT_PROVINCE_CODE + "</td>");
                this.htmlstr.Append("<td width=\"60\" align=\"center\" height=\"22\">1</td>");
                this.htmlstr.Append("<td width=\"60\" align=\"center\" height=\"22\">" + item.BILL_WEIGHT.ToString() + "</td>");
                this.htmlstr.Append("<td width=\"90\" align=\"center\" height=\"22\">" + item.PAY_TYPE + "</td>");
                this.htmlstr.Append("<td width=\"90\" align=\"center\" height=\"22\">" + PCommon.FormatNumber(item.GOODS_PAYMENT.ToString()) + "</td>");
                this.htmlstr.Append("<td width=\"140\" align=\"center\" height=\"22\">" + PCommon.FormatNumber(item.FREIGHT.ToString()) + "</td>");

                decimal TongTienNhanTra = item.GOODS_PAYMENT;
                if (item.PAY_TYPE == "Nhận thanh toán")
                {
                    TongTienNhanTra += item.FREIGHT;
                }
                this.htmlstr.Append("<td width=\"90\" align=\"center\" height=\"22\" style =\"color:Red\">" + PCommon.FormatNumber(TongTienNhanTra.ToString()) + "</td>");

                this.htmlstr.Append("<td width=\"140\" align=\"center\" height=\"22\">" + string.Format("{0:dd/MM/yyyy HH:mm}", item.SIGNED_DATE) + "</td>");

                this.htmlstr.Append("<td width=\"140\" align=\"center\" height=\"22\">" + item.Note + "</td>");
                this.htmlstr.Append("</tr>");
                this.htmlstr.Append("</tbody>");
                this.htmlstr.Append("</table>");

                // Quét hàng
                List<ExpScan> lsScans = _logic.GetListScanBillCode(item.BILL_CODE);
                if (lsScans.Count > 0)
                {
                    // Tiêu đề của scan
                    this.htmlstr.Append("<table style=\"margin-top:25px; border-collapse: collapse; font-family: Calibri; font-size: 12px\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" height=\"10\">");
                    this.htmlstr.Append("<tbody>");
                    this.htmlstr.Append("<tr>");
                    this.htmlstr.Append("<td height=\"25\" valign=\"bottom\"><b> <span id=\"a_TETTT\">【" + item.BILL_CODE + "】</span><font color=\"#FF00FF\">THEO DÕI LỊCH SỬ QUÉT HÀNG HÓA</font></b></td>");
                    this.htmlstr.Append("</tr>");
                    this.htmlstr.Append("</tbody>");
                    this.htmlstr.Append("</table>");
                    // Table lịch sử quét hàng
                    this.htmlstr.Append("<table style=\"border-collapse: collapse; font-family: Calibri; font-size: 12px\" border=\"1\" cellspacing=\"0\" width=\"100%\" bordercolor=\"#C0C0C0\">");
                    this.htmlstr.Append("<tbody>");
                    this.htmlstr.Append("<tr>");
                    this.htmlstr.Append("<td align=\"center\" width=\"100\" height=\"25\" bgcolor=\"#F3F3F3\"><b>Loại</b></td>");
                    this.htmlstr.Append("<td align=\"center\" width=\"150\" height=\"25\" bgcolor=\"#F3F3F3\"><b>Điểm quét</b></td>");
                    this.htmlstr.Append("<td align=\"center\" width=\"120\" height=\"25\" bgcolor=\"#F3F3F3\"><b>Thời gian quét</b></td>");
                    this.htmlstr.Append("<td align=\"center\" width=\"100\" height=\"25\" bgcolor=\"#F3F3F3\"><b>Trọng lượng</b></td>");
                    this.htmlstr.Append("<td align=\"center\" width=\"33%\" height=\"25\" bgcolor=\"#F3F3F3\"><b>Theo dõi hồ sơ ghi lại</b></td>");
                    this.htmlstr.Append("</tr>");
                    // Nội dung của scan
                    foreach (var scan in lsScans)
                    {
                        this.htmlstr.Append("<tr>");
                        this.htmlstr.Append("<td align=\"center\" height=\"22\">" + scan.TypeScan + "</td>");
                        this.htmlstr.Append("<td align=\"center\" height=\"22\">" + scan.Post + "</td>");
                        this.htmlstr.Append("<td align=\"center\" height=\"22\">" + string.Format("{0:dd/MM/yyyy HH:mm}", scan.CreateDate) + "</td>");
                        this.htmlstr.Append("<td align=\"center\" height=\"22\">" + PCommon.FormatNumber(scan.Weight.ToString(), 1) + "</td>");
                        this.htmlstr.Append("<td align=\"left\" height=\"22\">" + scan.Note + "</td>");
                        this.htmlstr.Append("</tr>");
                    }
                    this.htmlstr.Append("</tbody>");
                    this.htmlstr.Append("</table>");
                }

                List<ExpProblem> lsProblems = _logic.GetListKVDBillCode(item.BILL_CODE);
                if (lsProblems.Count > 0)
                {
                    // 2a. Tiêu đề của kiện vấn đề
                    this.htmlstr.Append("<table style=\"margin-top:25px; border-collapse: collapse; font-family: Calibri; font-size: 12px\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" height=\"10\">");
                    this.htmlstr.Append("<tbody>");
                    this.htmlstr.Append("<tr>");
                    this.htmlstr.Append("<td height=\"25\" valign=\"bottom\"><b> <span id=\"a_TETTT\">【" + item.BILL_CODE + "】</span><font color=\"#FF0000\">Đơn hàng có vấn đề</font></b></td>");
                    this.htmlstr.Append("</tr>");
                    this.htmlstr.Append("</tbody>");
                    this.htmlstr.Append("</table>");

                    this.htmlstr.Append("<table style=\"border-collapse: collapse; font-family: Arial; font-size: 12px\" border=\"1\" cellspacing=\"0\" width=\"100%\" bordercolor=\"#C0C0C0\">");
                    this.htmlstr.Append("<tbody>");
                    this.htmlstr.Append("<tr>");
                    this.htmlstr.Append("<td width=\"60\" valign=\"middle\" align=\"center\" height=\"25\" bgcolor=\"#F3F3F3\"><b>Thời gian</b></td>");
                    this.htmlstr.Append("<td width=\"60\" valign=\"middle\" align=\"center\" height=\"25\" bgcolor=\"#F3F3F3\"><b>Bưu cục đăng ký</b></td>");
                    this.htmlstr.Append("<td width=\"60\" valign=\"middle\" align=\"center\" height=\"25\" bgcolor=\"#F3F3F3\"><b>Loại C1</b></td>");
                    this.htmlstr.Append("<td width=\"60\" valign=\"middle\" align=\"center\" height=\"25\" bgcolor=\"#F3F3F3\"><b>Loại C2</b></td>");
                    this.htmlstr.Append("<td width=\"300\" valign=\"middle\" align=\"center\" bgcolor=\"#F3F3F3\" height=\"22\"><b>Đơn hàng có vấn đề lý do</b></td>");
                    this.htmlstr.Append("<td width=\"300\" valign=\"middle\" align=\"center\" bgcolor=\"#F3F3F3\" height=\"22\"><b>Trả lời</b></td>");
                    this.htmlstr.Append("</tr>");
                    //2b. Nội dung kiện vấn đề
                    foreach (var kvd in lsProblems)
                    {
                        this.htmlstr.Append("<tr>");
                        this.htmlstr.Append("<td width=\"60\" class=\"regiestTime\"  align=\"left\" height=\"22\">" + string.Format("{0:dd/MM/yyyy HH:mm}", kvd.CreateDate) + "</td>");
                        this.htmlstr.Append("<td width=\"60\"  align=\"left\" height=\"22\">" + kvd.Post + "</td>");
                        this.htmlstr.Append("<td width=\"60\"  align=\"left\" height=\"22\">" + kvd.TypeC1 + "</td>");
                        this.htmlstr.Append("<td width=\"60\"  align=\"left\" height=\"22\">" + kvd.TypeC2 + "</td>");
                        this.htmlstr.Append("<td width=\"300\"  align=\"left\" height=\"22\">" + kvd.Note + "</td>");
                        this.htmlstr.Append("<td width=\"300\"  align=\"left\" height=\"22\">" + kvd.Replay + "</td>");
                        this.htmlstr.Append("</tr>");
                    }
                    this.htmlstr.Append("</tbody>");
                    this.htmlstr.Append("</table>");
                }

                List<ExpInternal> lsIntenals = _logic.GetListIntenalBillCode(item.BILL_CODE);
                if (lsIntenals.Count > 0)
                {
                    //3a. Tiêu đề kiện nội mạng
                    this.htmlstr.Append("<table style=\"margin-top:25px; border-collapse: collapse; font-family: Calibri; font-size: 12px\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" height=\"10\">");
                    this.htmlstr.Append("<tbody>");
                    this.htmlstr.Append("<tr>");
                    this.htmlstr.Append("<td height=\"25\" valign=\"bottom\"><b> <span id=\"a_TETTT\">【" + item.BILL_CODE + "】</span><font color=\"#FF00FF\">KIỆN NỘI MẠNG</font></b></td>");
                    this.htmlstr.Append("</tr>");
                    this.htmlstr.Append("</tbody>");
                    this.htmlstr.Append("</table>");

                    this.htmlstr.Append("<table style=\"border-collapse: collapse; font-family: Arial; font-size: 12px\" border=\"1\" cellspacing=\"0\" width=\"100%\" bordercolor=\"#C0C0C0\">");
                    this.htmlstr.Append("<tbody>");
                    this.htmlstr.Append("<tr>");
                    this.htmlstr.Append("<td width=\"100\" align=\"center\" height=\"25\" bgcolor=\"#F3F3F3\"><b>Thời gian đăng ký</b></td>");
                    this.htmlstr.Append("<td width=\"200\" align=\"center\" height=\"25\" bgcolor=\"#F3F3F3\"><b>Người đăng ký</b></td>");
                    this.htmlstr.Append("<td width=\"300\" align=\"center\" height=\"25\" bgcolor=\"#F3F3F3\"><b>Đại lý đăng ký</b></td>");
                    this.htmlstr.Append("<td width=\"100\" align=\"center\" height=\"25\" bgcolor=\"#F3F3F3\"><b>Mã đơn đầu tiên</b></td>");
                    this.htmlstr.Append("<td width=\"300\" align=\"center\" height=\"35\" bgcolor=\"#F3F3F3\"><b>Kết quả xử lý</b></td>");
                    this.htmlstr.Append("</tr>");
                    //3b. Nội dung kiện nội mạng
                    foreach (var intenal in lsIntenals)
                    {
                        this.htmlstr.Append("<tr>");
                        this.htmlstr.Append("<td width=\"100\" class=\"regiestTime\"  align=\"left\" height=\"22\">" + string.Format("{0:dd/MM/yyyy HH:mm}", intenal.CreateDate) + "</td>");
                        this.htmlstr.Append("<td width=\"200\" class=\"regiestTime\"  align=\"left\" height=\"22\">" + intenal.CreateBy + "</td>");
                        this.htmlstr.Append("<td width=\"300\" class=\"regiestTime\"  align=\"left\" height=\"22\">" + intenal.Post + "</td>");
                        this.htmlstr.Append("<td width=\"100\" class=\"regiestTime\"  align=\"left\" height=\"22\">" + intenal.FIRST_CODE + "</td>");
                        this.htmlstr.Append("<td width=\"300\" class=\"regiestTime\"  align=\"left\" height=\"22\">" + intenal.Note + "</td>");

                        this.htmlstr.Append("</tr>");
                    }
                    this.htmlstr.Append("</tbody>");
                    this.htmlstr.Append("</table>");
                }

                List<view_ExpComment> lsComments = _logic.GetListCommentByBillCode(item.BILL_CODE);
                if (lsComments.Count > 0)
                {
                    //4a. Tiêu đề xử lý của nhân viên
                    this.htmlstr.Append("<table style=\"margin-top:25px; border-collapse: collapse; font-family: Calibri; font-size: 12px\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" height=\"10\">");
                    this.htmlstr.Append("<tbody>");
                    this.htmlstr.Append("<tr>");
                    this.htmlstr.Append("<td height=\"25\" valign=\"bottom\"><b> <span id=\"a_TETTT\">【" + item.BILL_CODE + "】</span><font color=\"#FF00FF\">NHÂN VIÊN XỬ LÝ</font></b></td>");
                    this.htmlstr.Append("</tr>");
                    this.htmlstr.Append("</tbody>");
                    this.htmlstr.Append("</table>");

                    this.htmlstr.Append("<table style=\"border-collapse: collapse; font-family: Arial; font-size: 12px\" border=\"1\" cellspacing=\"0\" width=\"100%\" bordercolor=\"#C0C0C0\">");
                    this.htmlstr.Append("<tbody>");
                    this.htmlstr.Append("<tr>");
                    this.htmlstr.Append("<td width=\"140\" align=\"center\" height=\"25\" bgcolor=\"#F3F3F3\"><b>Thời gian đăng ký</b></td>");
                    this.htmlstr.Append("<td width=\"140\" align=\"center\" height=\"25\" bgcolor=\"#F3F3F3\"><b>Người đăng ký</b></td>");
                    this.htmlstr.Append("<td width=\"140\" align=\"center\" height=\"25\" bgcolor=\"#F3F3F3\"><b>Loại</b></td>");
                    this.htmlstr.Append("<td width=\"300\" align=\"center\" height=\"25\" bgcolor=\"#F3F3F3\"><b>Nội dung</b></td>");
                    this.htmlstr.Append("</tr>");
                    foreach (var comment in lsComments)
                    {
                        //4b. Nội dung xử lý của nhân viên
                        this.htmlstr.Append("<tr>");
                        this.htmlstr.Append("<td width=\"140\" class=\"regiestTime\"  align=\"left\" height=\"22\">" + string.Format("{0:dd/MM/yyyy HH:mm}", comment.UpdateDate) + "</td>");
                        this.htmlstr.Append("<td width=\"140\" class=\"regiestTime\"  align=\"left\" height=\"22\">" + comment.FullName + "</td>");
                        this.htmlstr.Append("<td width=\"140\" class=\"regiestTime\"  align=\"left\" height=\"22\">" + comment.TypeName + "</td>");
                        this.htmlstr.Append("<td width=\"300\" class=\"regiestTime\"  align=\"left\" height=\"22\">" + comment.Comment + "</td>");
                        this.htmlstr.Append("</tr>");
                    }
                    this.htmlstr.Append("</tbody>");
                    this.htmlstr.Append("</table>");

                }


            }
            // Kết thúc trang HTML
            this.htmlstr.Append("<br>");
            this.htmlstr.Append("<br>");
            this.htmlstr.Append("<br>");
            this.htmlstr.Append("</body>");
            this.htmlstr.Append("</html>");
        }
        private void cmbLoaiXuLy_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExpCommentType select = cmbLoaiXuLy.SelectedItem as ExpCommentType;
            if (select != null)
            {
                txtComment.Text = select.TypeName;
                txtComment.Focus();
            }
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.ToString() != this.webBrowser.Url.ToString())
                return;
        }
        private string GetSelectedText()
        {
            try
            {
                dynamic document = webBrowser.Document.DomDocument;
                dynamic selection = document.selection;
                dynamic text = selection.createRange().text;
                return (string)text;
            }
            catch
            {
                return string.Empty;
            }

        }
        private void viettelPostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string code = GetSelectedText();
            if (string.IsNullOrEmpty(code))
            {
                return;
            }
            _logic.UpdateBT3(_BillCode, "VIETTEL", code);
            Process.Start(@"https://viettelpost.com.vn/");
            Clipboard.SetText(code);
        }
        private void ninjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string code = GetSelectedText();
            if (string.IsNullOrEmpty(code))
            {
                return;
            }
            _logic.UpdateBT3(_BillCode, "NINJA", code);
            Process.Start(@"https://www.ninjavan.co/vi-vn/tracking?id=" + code);
            Clipboard.SetText(code);
        }

        private void jTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string code = GetSelectedText();
            if (string.IsNullOrEmpty(code))
            {
                return;
            }
            _logic.UpdateBT3(_BillCode, "J&T", code);
            Process.Start(@"https://jtexpress.vn/vi/tracking?type=track&billcode=" + code);
            Clipboard.SetText(code);
        }

        private void gHNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string code = GetSelectedText();
            if (string.IsNullOrEmpty(code))
            {
                return;
            }
            _logic.UpdateBT3(_BillCode, "GHN", code);
            Process.Start(@"https://donhang.ghn.vn/?order_code=" + code);
            Clipboard.SetText(code);
        }

        private void gHTKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string code = GetSelectedText();
            if (string.IsNullOrEmpty(code))
            {
                return;
            }
            _logic.UpdateBT3(_BillCode, "GHTK", code);
            Process.Start(@"https://i.ghtk.vn/" + code);
            Clipboard.SetText(code);
        }

        private void bestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string code = GetSelectedText();
            if (string.IsNullOrEmpty(code))
            {
                return;
            }
            _logic.UpdateBT3(_BillCode, "BEST", code);
            Process.Start(@"https://best-inc.vn/track?bills=" + code);
            Clipboard.SetText(code);
        }
        private void vNPostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string code = GetSelectedText();
            if (string.IsNullOrEmpty(code))
            {
                return;
            }
            _logic.UpdateBT3(_BillCode, "VNPOST", code);
            Process.Start(@"http://www.vnpost.vn/vi-vn/dinh-vi/buu-pham?key=" + code);
            Clipboard.SetText(code);
        }

        private void superShipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string code = GetSelectedText();
            if (string.IsNullOrEmpty(code))
            {
                return;
            }
            _logic.UpdateBT3(_BillCode, "SUPERSHIP", code);
            Process.Start(@"https://mysupership.vn/orders/tracking?ref=SuperShip&code=" + code);
            Clipboard.SetText(code);
        }
        private void btnTruyVan_Click(object sender, EventArgs e)
        {
            string bills = string.Empty;
            foreach (var item in txtMaDonHang.Lines.ToList())
            {
                if (!string.IsNullOrEmpty(item))
                {
                    bills += "'" + item + "',";
                }
            }
            bills = bills.TrimEnd(',');
            lsBill = _logic.GetListBillByCode(bills);
            if (lsBill.Count > 0)
            {
                cmbTinhTrang.SelectedValue = lsBill[0].BILL_PROCESS_STATUS;

                MakeHtml(lsBill);
                webBrowser.DocumentText = htmlstr.ToString();
            }
            else
            {
                MessageBox.Show("Dữ liệu không tồn tại vui lòng thử lại.");
            }
        }

        private void btnTheoDoiDon_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtMaDonHang.Text);
            Process.Start(@"https://argus.ztoglobal.com/#/order/expressTracking/expressTracking");
        }

        private void btnDangKyKienVanDe_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtMaDonHang.Text);
            Process.Start(@"https://argus.ztoglobal.com/#/order/problemManagement/problemEnter");
        }

        private void btnDangKyNoiMang_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtMaDonHang.Text);
            Process.Start(@"https://argus.ztoglobal.com/#/order/intranetRegistration/intranetRegistration");
        }

        private void btnDangKyKienHoTro_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.Arguments = "/s";
            startInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + "Ext\\AutoZTOK10.exe";
            if (File.Exists(startInfo.FileName))
            {
                using (Process process = Process.Start(startInfo))
                {
                    process.WaitForInputIdle();
                }
            }
        }
    }
}
