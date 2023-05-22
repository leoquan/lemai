using Common;
using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using DevComponents.WinForms.Drawing;
using LeMaiDomain;
using LeMaiLogic.Logic;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace LeMaiDesktop
{
    public partial class frmTrackingAndProcess : frmBase
    {
        StringBuilder htmlstr = new StringBuilder();
        private GExpBillLogic _logic = new GExpBillLogic(PBean.ConnectionBase);
        view_GExpBill billItem = new view_GExpBill();
        public frmTrackingAndProcess() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
        }
        public void StartView(view_GExpBill bill)
        {
            // Load Thông tin đơn hàng
            billItem = bill;
            LoadData(true);
        }
        private async void MakeHtmlNew()
        {
            StringBuilder w = new StringBuilder();
            w.Append("<!DOCTYPE html>");
            w.Append("<html>");
            w.Append("<head>");
            w.Append("<style>");
            w.Append(".bill {");
            w.Append("	font-family: Arial, Helvetica, sans-serif;");
            w.Append("	border-collapse: collapse;");
            w.Append("	width: 100%;");
            w.Append("}");
            w.Append(".bill td, .bill th {");
            w.Append("	border: 1px solid #ddd;");
            w.Append("	padding: 8px;");
            w.Append("	font-size: 14px;");
            w.Append("}");
            w.Append(".bill tr:nth-child(even) {");
            w.Append("	background-color: #fff;");
            w.Append("}");
            w.Append(".bill tr:hover {");
            w.Append("	background-color: #fff;");
            w.Append("}");
            w.Append(".bill th {");
            w.Append("	padding-top: 12px;");
            w.Append("	padding-bottom: 12px;");
            w.Append("	text-align: center;");
            w.Append("	background-color: #04AA6D;");
            w.Append("	color: white;");
            w.Append("}");
            w.Append(".scan {");
            w.Append("	font-family: Arial, Helvetica, sans-serif;");
            w.Append("	border-collapse: collapse;");
            w.Append("	width: 100%;");
            w.Append("}");
            w.Append(".scan td, .scan th {");
            w.Append("	border: 1px solid #ddd;");
            w.Append("	padding: 8px;");
            w.Append("	font-size: 14px;");
            w.Append("}");
            w.Append(".scan tr:nth-child(even) {");
            w.Append("	background-color: #f2f2f2;");
            w.Append("}");
            w.Append(".scan tr:hover {");
            w.Append("	background-color: #ddd;");
            w.Append("}");
            w.Append(".scan th {");
            w.Append("	padding-top: 12px;");
            w.Append("	padding-bottom: 12px;");
            w.Append("	text-align: center;");
            w.Append("	background-color: #0080C0;");
            w.Append("	color: white;");
            w.Append("}");
            w.Append(".problem {");
            w.Append("	font-family: Arial, Helvetica, sans-serif;");
            w.Append("	border-collapse: collapse;");
            w.Append("	width: 100%;");
            w.Append("}");
            w.Append(".problem td, .problem th {");
            w.Append("	border: 1px solid #ddd;");
            w.Append("	padding: 8px;");
            w.Append("	font-size: 14px;");
            w.Append("}");
            w.Append(".problem tr:nth-child(even) {");
            w.Append("	background-color: #f2f2f2;");
            w.Append("}");
            w.Append(".problem tr:hover {");
            w.Append("	background-color: #ddd;");
            w.Append("}");
            w.Append(".problem th {");
            w.Append("	padding-top: 12px;");
            w.Append("	padding-bottom: 12px;");
            w.Append("	text-align: center;");
            w.Append("	background-color: #C30;");
            w.Append("	color: white;");
            w.Append("}");
            w.Append(".history {");
            w.Append("	font-family: Arial, Helvetica, sans-serif;");
            w.Append("	border-collapse: collapse;");
            w.Append("	width: 50%;");
            w.Append("}");
            w.Append(".history td, .history th {");
            w.Append("	border: 1px solid #ddd;");
            w.Append("	padding: 8px;");
            w.Append("	font-size: 14px;");
            w.Append("}");
            w.Append(".history tr:nth-child(even) {");
            w.Append("	background-color: #f2f2f2;");
            w.Append("}");
            w.Append(".history tr:hover {");
            w.Append("	background-color: #ddd;");
            w.Append("}");
            w.Append(".history th {");
            w.Append("	padding-top: 12px;");
            w.Append("	padding-bottom: 12px;");
            w.Append("	text-align: center;");
            w.Append("	background-color: #393;");
            w.Append("	color: white;");
            w.Append("}");
            w.Append("</style>");
            w.Append("</head>");
            w.Append("<body>");
            w.Append("<table class=\"bill\">");
            w.Append("  <tr>");
            w.Append("    <th>BT3</th>");
            w.Append("    <th>Số vận đơn</th>");
            w.Append("    <th>Ngày gửi</th>");
            w.Append("    <th>Người gửi</th>");
            w.Append("    <th>SĐT Gửi</th>");
            w.Append("    <th>Người nhận</th>");
            w.Append("    <th>SĐT Nhận</th>");
            w.Append("    <th>Địa chỉ</th>");
            w.Append("    <th>SL</th>");
            w.Append("    <th>Trọng lượng</th>");
            w.Append("    <th>Thu hộ</th>");
            w.Append("    <th>Phí VC</th>");
            w.Append("    <th>Loại TT</th>");
            w.Append("    <th>Tổng nhận trả</th>");
            w.Append("    <th>Ngày ký nhận</th>");
            w.Append("    <th>Ghi chú</th>");
            w.Append("  </tr>");
            w.Append("  <tr>");
            w.Append("    <td>" + billItem.BT3Code + "</td>");
            w.Append("    <td>" + billItem.BillCode + "</td>");
            w.Append("    <td>" + string.Format("{0:dd/MM/yyyy HH:mm}", billItem.RegisterDate) + "</td>");
            w.Append("    <td>" + billItem.SendMan + "</td>");
            w.Append("    <td>" + billItem.SendManPhone + "</td>");
            w.Append("    <td>" + billItem.AcceptMan + "</td>");
            w.Append("    <td>" + billItem.AcceptManPhone + "</td>");
            w.Append("    <td>" + billItem.FullAddress + "</td>");
            w.Append("    <td>" + billItem.GoodsNumber + "</td>");
            w.Append("    <td>" + PCommon.FormatNumber(billItem.FeeWeight.ToString()) + "</td>");
            w.Append("    <td>" + PCommon.FormatNumber(billItem.COD.ToString()) + "</td>");
            w.Append("    <td>" + PCommon.FormatNumber(billItem.Freight.ToString()) + "</td>");
            w.Append("    <td>" + billItem.PayType + "</td>");
            if (billItem.FK_PaymentType == "GTT")
            {
                w.Append("    <td>" + PCommon.FormatNumber(billItem.COD.ToString()) + "</td>");
            }
            else
            {
                w.Append("    <td>" + PCommon.FormatNumber((billItem.COD + billItem.Freight).ToString()) + "</td>");
            }
            if (billItem.SignedDate.HasValue)
            {
                w.Append("    <td>" + string.Format("{0:dd/MM/yyyy HH:mm}", billItem.SignedDate) + "</td>");
            }
            else
            {
                w.Append("    <td>-</td>");
            }

            w.Append("    <td>" + billItem.Note + "</td>");
            w.Append("  </tr>");
            w.Append("</table>");


            List<view_GExpScan> lsScans = await _logic.GetListTrack(billItem.BillCode);
            if (lsScans.Count > 0)
            {
                w.Append("<h2 style=\"color:#336; font-size:20px;\">Lịch sử quét hàng</h2>");
                w.Append("<table class=\"scan\">");
                w.Append("  <tr>");
                w.Append("    <th>Loại</th>");
                w.Append("    <th>Điểm quét</th>");
                w.Append("    <th>Ngày Quét</th>");
                w.Append("    <th>Nội dung</th>");
                w.Append("  </tr>");
                foreach (var item in lsScans)
                {
                    w.Append("  <tr>");
                    w.Append("    <td align=\"center\" width=\"150px\">" + item.TypeScan + "</td>");
                    w.Append("    <td align=\"center\" width=\"150px\">" + item.UserCreate + "</td>");
                    w.Append("    <td align=\"center\" width=\"150px\">" + string.Format("{0:dd/MM/yyyy HH:mm}", item.CreateDate) + "</td>");
                    w.Append("    <td>" + item.Note + "</td>");
                    w.Append("  </tr>");
                }
                w.Append("</table>");
            }

            List<view_GExpProblem> lsProblems = await _logic.GetListProblem(billItem.BillCode);
            if (lsProblems.Count > 0)
            {
                w.Append("<h2 style=\"color:#C30; font-size:20px;\">Kiện vấn đề</h2>");
                w.Append("<table class=\"problem\">");
                w.Append("  <tr>");
                w.Append("    <th>Điểm đăng ký</th>");
                w.Append("    <th>Ngày đăng ký</th>");
                w.Append("    <th>Nội dung</th>");
                w.Append("  </tr>");
                foreach (var item in lsProblems)
                {
                    w.Append("  <tr>");
                    w.Append("    <td align=\"center\" width=\"150px\">" + item.FullName + "</td>");
                    w.Append("    <td align=\"center\" width=\"150px\">" + string.Format("{0:dd/MM/yyyy HH:mm}", item.RegisterDate) + "</td>");
                    w.Append("    <td>" + item.Note + "</td>");
                    w.Append("  </tr>");
                }
                w.Append("</table>");
            }


            List<view_ExpComment> lsComments = await _logic.GetListComment(billItem.BillCode);
            if (lsComments.Count > 0)
            {
                w.Append("<h2 style=\"color:#336; font-size:20px;\">Nhân viên xử lý</h2>");
                w.Append("<table class=\"scan\">");
                w.Append("  <tr>");
                w.Append("    <th>Loại</th>");
                w.Append("    <th>Thời gian</th>");
                w.Append("    <th>Nhân viên</th>");
                w.Append("    <th>Nội dung</th>");
                w.Append("  </tr>");
                foreach (var item in lsComments)
                {
                    w.Append("  <tr>");
                    w.Append("    <td align=\"center\" width=\"150px\">" + item.TypeName + "</td>");
                    w.Append("    <td align=\"center\" width=\"150px\">" + item.FullName + "</td>");
                    w.Append("    <td align=\"center\" width=\"150px\">" + string.Format("{0:dd/MM/yyyy HH:mm}", item.UpdateDate) + "</td>");
                    w.Append("    <td>" + item.Comment + "</td>");
                    w.Append("  </tr>");
                }


                w.Append("</table>");
            }


            List<view_GExpBillHistory> lsHistory = await _logic.GetListHistory(billItem.BillCode);
            if (lsHistory.Count > 0)
            {
                w.Append("<h2 style=\"color:#393; font-size:20px;\">Lịch sử thay đổi</h2>");
                w.Append("<table class=\"history\">");
                w.Append("  <tr>");
                w.Append("    <th>Người thay đối</th>");
                w.Append("    <th>Thời gian</th>");
                w.Append("    <th>Loại thay đổi</th>");
                w.Append("    <th>Nội dung</th>");
                w.Append("  </tr>");
                foreach (var item in lsHistory)
                {
                    string[] header = item.BeforeUpdate.Split(';');
                    string[] content = item.AfterUpdate.Split('|');
                    w.Append("  <tr>");
                    w.Append("    <td align=\"center\" rowspan=\"" + header.Length + "\" width=\"150px\">" + item.FullName + "</td>");
                    w.Append("    <td align=\"center\" rowspan=\"" + header.Length + "\" width=\"150px\">" + string.Format("{0:dd/MM/yyyy HH:mm}", item.UpdateDate) + "</td>");
                    w.Append("    <td align=\"center\" width=\"150px\">" + header[0] + "</td>");
                    w.Append("    <td>" + content[0] + "</td>");
                    w.Append("  </tr>");
                    for (int i = 1; i < header.Length; i++)
                    {
                        w.Append("  <tr>");
                        w.Append("    <td align=\"center\" width=\"150px\">" + header[i] + "</td>");
                        w.Append("    <td>" + content[i] + "</td>");
                        w.Append("  </tr>");
                    }
                }

                w.Append("</table>");
            }

            w.Append("</body>");
            w.Append("</html>");
            this.htmlstr = w;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void LoadData(bool reload = false)
        {
            ucBillMain.SetView(billItem);
            MakeHtmlNew();
            webBrowser.DocumentText = htmlstr.ToString();

            if (reload)
            {
                // Load Comment Type
                cmbLoaiXuLy.DataSource = await _logic.GetListCommentType();
                cmbLoaiXuLy.DisplayMember = "TypeName";
                cmbLoaiXuLy.ValueMember = "Id";
                // Load tình trạng
                cmbTinhTrang.DataSource = await _logic.GetListBillStatusType();
                cmbTinhTrang.DisplayMember = "StatusName";
                cmbTinhTrang.ValueMember = "Id";
            }
            cmbTinhTrang.SelectedValue = billItem.BillStatus;
        }

        private async void btnCapNhatTT_Click(object sender, EventArgs e)
        {
            string result = _logic.ChangeStausBill(billItem.BillCode, Int32.Parse(cmbTinhTrang.SelectedValue.ToString()), PBean.USER.Id, PBean.USER.CardId);
            if (!string.IsNullOrEmpty(result))
            {
                MessageBox.Show(result, PBean.MESSAGE_TITLE);
            }
            else
            {
                billItem = await _logic.GetDetails(billItem.BillCode);
                LoadData(false);
            }
        }
        private void btnXuLyDon_Click(object sender, EventArgs e)
        {
            //CommentOnBill
            if (!string.IsNullOrEmpty(txtComment.Text))
            {
                string result = _logic.CommentOnBill(billItem.BillCode, cmbLoaiXuLy.SelectedValue.ToString(), txtComment.Text.Trim(), PBean.USER.Id);
                if (!string.IsNullOrEmpty(result))
                {
                    MessageBox.Show(result, PBean.MESSAGE_TITLE);
                }
                else
                {
                    // Xử lý thành công
                    LoadData(false);
                }
            }

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

        private void btnXemHanhTrinhBenDVT3_Click(object sender, EventArgs e)
        {
            string link = string.Empty;
            if (billItem.GroupProvider == "GHN")
            {
                link = "https://donhang.ghn.vn/?order_code=" + billItem.BT3Code;
            }
            else if (billItem.GroupProvider == "JNT")
            {
                link = "https://jtexpress.vn/vi/tracking?type=track&billcode=" + billItem.BT3Code;
            }
            else if (billItem.GroupProvider == "NINJA")
            {
                link = "https://www.ninjavan.co/vi-vn/tracking?id=" + billItem.BT3Code;
            }
            else if (billItem.GroupProvider == "BEST")
            {
                link = "https://best-inc.vn/track?bills=" + billItem.BT3Code;
            }
            else if (billItem.GroupProvider == "VNPOST")
            {
                link = "http://www.vnpost.vn/vi-vn/dinh-vi/buu-pham?key=" + billItem.BT3Code;
            }
            Process.Start(link);
        }
    }
}
