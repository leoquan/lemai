using Common;
using System;
using System.IO;

namespace LeMaiDesktop
{
    public partial class frmAbout : frmBase
    {
        private const string GUID = "GUID_001";
        public frmAbout() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
            ChangeLanguageUI(PBean.MAKE_LANG);
            lblVersion.Text += PBean.APPLICATION_VERSION;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Logo\\" + PBean.SERVER_OPTION.STARTUP_LOGO;
            if (File.Exists(path))
            {
                picLogo.BackgroundImage = PCommon.ImageFromFile(path);
            }
            else
            {
                path = AppDomain.CurrentDomain.BaseDirectory + "Logo\\logo.png";
                if (File.Exists(path))
                {
                    picLogo.BackgroundImage = PCommon.ImageFromFile(path);
                }
            }
        }
    }
}
