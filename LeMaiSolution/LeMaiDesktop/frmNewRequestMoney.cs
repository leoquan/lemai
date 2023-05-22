using Common;
using GmailAPI.APIHelper;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using LeMaiDomain;
using LeMaiLogic.Logic;
using NUglify;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace LeMaiDesktop
{
    public partial class frmNewRequestMoney : frmBase
    {
        QuanLyNapTienLogic _logic = new QuanLyNapTienLogic(PBean.ConnectionBase);
        GExpBillLogic _logicbill = new GExpBillLogic(PBean.ConnectionBase);
        public string FK_PostTo { get; set; }
        public frmNewRequestMoney() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            int SoTien = 0;
            if (Int32.TryParse(txtMoney.Text, System.Globalization.NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out SoTien))
            {
                string note = PBean.USER.FullName + " đã tạo yêu cầu nạp tiền với mã giao dịch:{0}. Số tiền {1}";

                ExpPost postTo = _logicbill.GetPostDetail(FK_PostTo);
                ExpPost postFrom = _logicbill.GetPostDetail(PBean.USER.CardId);
                var result = _logic.AddRequestMoney(postFrom.Id, postTo.Id, PBean.USER.Id, SoTien, note, postTo.SoTaiKhoan, postTo.QuanLy, postTo.NganHang);
                if (!result.Contains("[E]"))
                {
                    Clipboard.SetText(result);
                    txtRequestCode.Text = result;
                    MessageBox.Show("Đã thêm yêu cầu nạp tiền thành công, mã giao dịch [" + result + "]", PBean.MESSAGE_TITLE);
                }
                else
                {
                    MessageBox.Show(result, PBean.MESSAGE_TITLE);
                }
            }
        }

        private void frmNewRequestMoney_Load(object sender, EventArgs e)
        {
            ExpPost postTo = _logicbill.GetPostDetail(FK_PostTo);
            // Thông tin nạp tiền đến
            lblSoTK.Text = postTo.SoTaiKhoan;
            lblChuTaiKhoan.Text = postTo.QuanLy;
            lblNganHang.Text = postTo.NganHang;

            ExpPost postFrom = _logicbill.GetPostDetail(PBean.USER.CardId);
            lblTotal.Text = PCommon.FormatNumber(postFrom.ValueBlance.ToString()) + " VNĐ";
            if (postFrom.ValueBlance >= 0)
            {
                txtMoney.Text = "0";
                lblBangChu.Text = "Số dư đang >= 0. Không cần thiết phải nạp tiền";
                btnAddRequest.Enabled = false;
            }
            else
            {
                int value = Math.Abs(postFrom.ValueBlance);
                txtMoney.Text = PCommon.FormatNumber(value.ToString());
                lblBangChu.Text = PCommon.ChuyenSoThanhChu(value.ToString());
                btnAddRequest.Enabled = true;
            }

        }
        private void txtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }

        private void txtMoney_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        public static List<GExpBankEmail> GetAllEmails(string HostEmailAddress)
        {
            try
            {
                GmailService GmailService = GmailAPIHelper.GetService();
                List<GExpBankEmail> EmailList = new List<GExpBankEmail>();
                UsersResource.MessagesResource.ListRequest ListRequest = GmailService.Users.Messages.List(HostEmailAddress);
                ListRequest.LabelIds = "INBOX";
                ListRequest.IncludeSpamTrash = false;
                ListRequest.Q = "is:unread"; //ONLY FOR UNDREAD EMAIL'S...

                //GET ALL EMAILS
                ListMessagesResponse ListResponse = ListRequest.Execute();

                if (ListResponse != null && ListResponse.Messages != null)
                {
                    foreach (Google.Apis.Gmail.v1.Data.Message Msg in ListResponse.Messages)
                    {
                        //MESSAGE MARKS AS READ AFTER READING MESSAGE
                        GmailAPIHelper.MsgMarkAsRead(HostEmailAddress, Msg.Id);
                        UsersResource.MessagesResource.GetRequest Message = GmailService.Users.Messages.Get(HostEmailAddress, Msg.Id);

                        Google.Apis.Gmail.v1.Data.Message MsgContent = Message.Execute();

                        if (MsgContent != null)
                        {
                            string FromAddress = string.Empty;
                            string Date = string.Empty;
                            string Subject = string.Empty;
                            string MailBody = string.Empty;
                            string ReadableText = string.Empty;

                            foreach (var MessageParts in MsgContent.Payload.Headers)
                            {
                                if (MessageParts.Name == "From")
                                {
                                    FromAddress = MessageParts.Value;
                                }
                                else if (MessageParts.Name == "Date")
                                {
                                    Date = MessageParts.Value;
                                }
                                else if (MessageParts.Name == "Subject")
                                {
                                    Subject = MessageParts.Value;
                                }
                            }
                            if (!FromAddress.Equals("VCBDigibank@info.vietcombank.com.vn"))
                            {
                                continue;
                            }
                            if (!Subject.Equals("Biên lai chuyển tiền qua tài khoản"))
                            {
                                continue;
                            }
                            MailBody = string.Empty;
                            if (MsgContent.Payload.Parts == null && MsgContent.Payload.Body != null)
                            {
                                MailBody = MsgContent.Payload.Body.Data;
                            }
                            else
                            {
                                MailBody = GmailAPIHelper.MsgNestedParts(MsgContent.Payload.Parts);
                            }

                            //BASE64 TO READABLE TEXT--------------------------------------------------------------------------------
                            ReadableText = string.Empty;
                            ReadableText = GmailAPIHelper.Base64Decode(MailBody);
                            if (!string.IsNullOrEmpty(ReadableText))
                            {
                                var result = Uglify.HtmlToText(ReadableText);
                                GExpBankEmail gmail = new GExpBankEmail();
                                gmail.Id = Guid.NewGuid().ToString();
                                gmail.FromEmail = FromAddress;
                                gmail.EmailDate = Convert.ToDateTime(Date);
                                // Tìm cái mã giao dịch
                                int postion = result.Code.IndexOf("Order Number");
                                string sub = result.Code.Substring(postion + "Order Number".Length);
                                sub = sub.Trim();
                                postion = sub.IndexOf(" ");
                                sub = sub.Substring(0, postion);
                                gmail.TransactionId = sub;
                                // Tìm cái debit Account - Số tiền trích ra


                                // Tìm số tiền giao dịch
                                postion = result.Code.IndexOf("Số tiền Amount");
                                sub = result.Code.Substring(postion + "Số tiền Amount".Length);
                                sub = sub.Trim();
                                postion = sub.IndexOf(" ");
                                sub = sub.Substring(0, postion);
                                sub = sub.Replace(",", "");
                                int SoTien = 0;
                                if (!Int32.TryParse(sub, out SoTien))
                                {
                                    SoTien = 0;
                                }
                                gmail.MoneyValue = SoTien;
                                // Tìm cái nội dung giao dịch
                                postion = result.Code.IndexOf("Details of Payment");
                                sub = result.Code.Substring(postion + "Details of Payment".Length);
                                sub = sub.Trim();
                                postion = sub.IndexOf("Tham khảo hướng dẫn");
                                string noidung = sub.Substring(0, postion);
                                noidung = noidung.Trim();
                                gmail.ContentBodyCode = noidung;
                                gmail.EmailId = Msg.Id;
                                EmailList.Add(gmail);
                            }
                        }
                    }
                }
                return EmailList;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);

                return null;
            }
        }

    }
}
