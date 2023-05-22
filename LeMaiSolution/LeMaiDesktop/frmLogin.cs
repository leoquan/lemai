using Common;
using log4net;
using System;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using LeMaiLogic;
using LeMaiLogic.Logic;
using System.Drawing;

namespace LeMaiDesktop
{
    public partial class frmLogin : frmBase
    {
        UserManagerLogic _logic = new UserManagerLogic(PBean.ConnectionBase);
        public frmLogin() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
            string pathIcon = AppDomain.CurrentDomain.BaseDirectory + "Logo/app_" + PBean.LOCAL_OPTIONS.ICON_NAME + ".ico";
            if (File.Exists(pathIcon))
            {
                this.Icon = new Icon(pathIcon);
            }
            else
            {
                pathIcon = AppDomain.CurrentDomain.BaseDirectory + "Logo/app.ico";
                if (File.Exists(pathIcon))
                {
                    this.Icon = new Icon(pathIcon);
                }
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            //Đăng nhập thành công!
            if (string.IsNullOrEmpty(txtUser.Text.Trim()))
            {
                MessageBox.Show(string.Format(language.GetResourceString("MSG_0002")), PBean.MESSAGE_TITLE);
                txtUser.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MessageBox.Show(string.Format(language.GetResourceString("MSG_0005")), PBean.MESSAGE_TITLE);
                txtPassword.Focus();
                return;
            }

            string resultLogin = await _logic.LoginAsync(txtUser.Text, HasMethod.GetMD5(txtPassword.Text), System.Environment.MachineName).ConfigureAwait(false);

            if (string.IsNullOrEmpty(resultLogin))
            {
                // Login Fail
                MessageBox.Show(language.GetResourceString("MSG_0001"), PBean.MESSAGE_TITLE);
                txtPassword.Text = string.Empty;
                txtUser.Focus();
            }
            else
            {
                PBean.USER = await _logic.GetAccountObject(resultLogin);
                PBean.BRANCH_ID = PBean.USER.FK_BranchOwner;
                PBean.BranchWorking = await _logic.GetAccountObjectBranch(PBean.BRANCH_ID);
                if (chbGhiNho.Checked)
                {
                    PBean.LOCAL_OPTIONS.AUTO_LOGIN = true;
                    PBean.LOCAL_OPTIONS.USER_DEFAULT = txtUser.Text;
                    PBean.LOCAL_OPTIONS.PASSWORD_DEFAULT = txtPassword.Text;
                    PBean.LOCAL_OPTIONS.Save();
                }
                else
                {
                    PBean.LOCAL_OPTIONS.AUTO_LOGIN = false;
                    PBean.LOCAL_OPTIONS.USER_DEFAULT = txtUser.Text;
                    PBean.LOCAL_OPTIONS.PASSWORD_DEFAULT = txtPassword.Text;
                    PBean.LOCAL_OPTIONS.Save();
                }

                this.DialogResult = DialogResult.OK;
            }
            //IDataContext dc = PCommon.getDataContext();
            //try
            //{
            //    dc.Open();

            //    PBean.USER = dc.ACcountobject.GetObjectCon(PBean.SCHEMA, "where UserName=@UserName and PassWord=@PassWord",
            //        "@UserName", txtUser.Text,
            //        "@PassWord", Security.Encrypt(txtPassword.Text));
            //    if (PBean.USER != null)
            //    {

            //    }
            //    else
            //    {
            //        MessageBox.Show(language.GetResourceString("MSG_0001"), PBean.MESSAGE_TITLE);
            //        txtPassword.Text = string.Empty;
            //        txtUser.Focus();
            //    }

            //}
            //catch (Exception ex)
            //{
            //    log.Error(ex);
            //    MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
            //}
            //finally
            //{
            //    dc.Close();

            //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            //
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            //
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtUser.Text))
                {
                    txtPassword.Focus();
                }
            }
        }

        private void frmGUID001_Load(object sender, EventArgs e)
        {
            cmbLanguage.DataSource = language.GetLanguage();
            cmbLanguage.DisplayMember = "Name";
            cmbLanguage.ValueMember = "ID";
            this.cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbLanguage_SelectedIndexChanged);
            cmbLanguage.SelectedValue = PBean.LANGUAGE;
            // Change Image
            string path = AppDomain.CurrentDomain.BaseDirectory + "Logo\\" + PBean.SERVER_OPTION.STARTUP_LOGO;
            if (File.Exists(path))
            {
                pictureBoxLogo.BackgroundImage = PCommon.ImageFromFile(path);
            }
            else
            {
                path = AppDomain.CurrentDomain.BaseDirectory + "Logo/logo_" + PBean.LOCAL_OPTIONS.ICON_NAME + ".png";
                if (File.Exists(path))
                {
                    pictureBoxLogo.BackgroundImage = PCommon.ImageFromFile(path);
                }
                else
                {
                    path = AppDomain.CurrentDomain.BaseDirectory + "Logo\\logo.png";
                    if (File.Exists(path))
                    {
                        pictureBoxLogo.BackgroundImage = PCommon.ImageFromFile(path);
                    }
                }
            }

            if (PBean.LOCAL_OPTIONS.AUTO_LOGIN)
            {
                txtUser.Text = PBean.LOCAL_OPTIONS.USER_DEFAULT;
                txtPassword.Text = PBean.LOCAL_OPTIONS.PASSWORD_DEFAULT;
                chbGhiNho.Checked = true;
            }

        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            PBean.LANGUAGE = cmbLanguage.SelectedValue.ToString();
            language = new Common.Language.LanguageManager();
            ChangeLanguageUI(PBean.MAKE_LANG);
        }

        private void frmGUID001_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}

