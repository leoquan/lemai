using Common;
using LeMaiDomain;
using LeMaiLogic;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LeMaiDesktop
{
    public partial class frmMyAccount : frmBase
    {
        public frmMyAccount() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
        }

        public static bool IsEmail(string email)
        {
            string MatchEmailPattern =
            @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
     + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
     + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
     + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";
            if (!string.IsNullOrEmpty(email))
            {
                return Regex.IsMatch(email, MatchEmailPattern);
            }
            else
            {
                return false;
            }
        }

        private void frmMyAccount_Load(object sender, EventArgs e)
        {
            txtUser.Text = PBean.USER.UserName;
            txtFullname.Text = PBean.USER.FullName;
            txtEmail.Text = PBean.USER.Email;
            ChangeLanguageUI();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text))
            {
                MessageBox.Show(getResource("GUID_021_11"), PBean.MESSAGE_TITLE);
                return;
            }
            if (string.IsNullOrEmpty(txtFullname.Text))
            {
                MessageBox.Show(getResource("Họ tên không được trống!"), PBean.MESSAGE_TITLE);
                return;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show(getResource("Email không được trống!"), PBean.MESSAGE_TITLE);
                return;
            }
            if (!IsEmail(txtEmail.Text))
            {
                MessageBox.Show(getResource("Địa chỉ email không đúng định dạng!"), PBean.MESSAGE_TITLE);
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show(getResource("Mật khẩu không được trống"), PBean.MESSAGE_TITLE);
                return;
            }
            if (Common.Security.GetMD5(txtPassword.Text).ToUpper() != PBean.USER.PassWord)
            {
                MessageBox.Show(getResource("Mật khẩu không đúng!"), PBean.MESSAGE_TITLE);
                return;
            }

            if (txtNewPassword.Text != txtrepassword.Text)
            {
                MessageBox.Show(getResource("Xác nhận mật khẩu không đúng!"), PBean.MESSAGE_TITLE);
                return;
            }
            IDataContext dc = PCommon.getDataContext();
            try
            {
                dc.Open();
                AccountObject m = dc.ACcountobject.GetListObject(PBean.SCHEMA).FirstOrDefault(u => u.UserName == txtUser.Text.ToLower() && u.Id != PBean.USER.Id);
                if (null != m)
                {
                    dc.Close();
                    MessageBox.Show(getResource("Không tìm thấy thông tin tài khoản. Vui lòng liên hệ quản trị!"), PBean.MESSAGE_TITLE);
                    return;
                }
                else
                {
                    //Change
                    AccountObject a = PBean.USER;
                    a.UserName = txtUser.Text.ToLower();
                    a.FullName = txtFullname.Text;
                    a.Email = txtEmail.Text;
                    if (!string.IsNullOrEmpty(txtNewPassword.Text))
                    {
                        a.PassWord = Common.Security.GetMD5(txtNewPassword.Text);
                    }

                    dc.ACcountobject.Update(PBean.SCHEMA, a);
                    dc.SubmitChanges();
                    PBean.USER = a;
                    MessageBox.Show(getResource("Cập nhật tài khoản thành công"), PBean.MESSAGE_TITLE);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
            finally
            {
                dc.Close();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }

        private void txtFullname_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }

        private void txtNewPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }

        private void txtrepassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
    }
}
