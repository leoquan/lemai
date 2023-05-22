using Common;
using log4net;
using log4net.Config;
using LeMaiLogic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace LeMaiDesktop
{
    static class Program
    {
        private static readonly log4net.ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.ThreadException += new ThreadExceptionEventHandler(Main_UIThreadException);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            //Init Log
            XmlConfigurator.Configure();

            //string s = Security.Encrypt("U$erGi@Cong");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Kiểm tra, nếu lần đầu tiên chưa cấu hình database, thì chương trình mở hộp thoại cấu hình database
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + PConstants.FILE_DATABASE_CONFIG))
            {
                frmDatabase frmdatabase = new frmDatabase(1);
                frmdatabase.ShowDialog();
                MessageBox.Show("Vui lòng khởi động lại chương trình để hoàn tất cấu hình!", PBean.MESSAGE_TITLE);
            }
           
            PBean.LOCAL_OPTIONS = LocalOptions.ReadOption();
            PBean.LOCAL_OPTIONS.Save();
            //Load cấu hình database
            //string s = Security.Encrypt("Sa1@QWEqaz");
            DatabaseConfig _dbconfig = new DatabaseConfig();
            PBean.CONNECTION_STRING = string.Format("Server={0},{1};User Id={2};Password={3};Database={4};", _dbconfig.ServerName, _dbconfig.Port, _dbconfig.User, _dbconfig.Password, _dbconfig.DatabaseName);
            PBean.ConnectionBase = new BaseLogicConnectionData
            {
                ConnectionString = PBean.CONNECTION_STRING,
                Schema = "dbo"
            };
            PBean.CONNECTION_STRING_VIEW = string.Format("Server={0},{1};Database={2};", _dbconfig.ServerName, _dbconfig.Port, _dbconfig.DatabaseName);
            PBean.SERVER_OPTION = ServerOption.ReadServerOption(PBean.CONNECTION_STRING);

            if (args.Length > 0)
            {
                if (args[0].Equals("/t"))
                {
                    // Xử lý khi có parameter
                    frmTestTool frmTest = new frmTestTool();
                    frmTest.ShowDialog();
                    return;
                }
                else if (args[0].Equals("/p"))
                {
                    // Xử lý khi có parameter
                    frmSetUpdateProvince frmTest = new frmSetUpdateProvince();
                    frmTest.ShowDialog();
                    return;
                }
                else if (args[0].Equals("/a"))
                {
                    // Xử lý khi có parameter
                    frmAutoUpdateTrack frmTracking = new frmAutoUpdateTrack();
                    frmTracking.ShowDialog();
                    return;
                }
            }


            // Run main form
            frmLogin frm = new frmLogin();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmMain());
            }
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                MessageBox.Show(e.ExceptionObject.ToString());
                Application.Exit();
            }
            catch
            {
            }
        }
        private static void Main_UIThreadException(object sender, ThreadExceptionEventArgs e)
        {
            try
            {
                MessageBox.Show(e.Exception.ToString());
                Application.Exit();
            }
            catch
            {
            }
        }
    }
}
