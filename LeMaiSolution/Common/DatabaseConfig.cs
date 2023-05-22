using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Common
{
    public class DatabaseConfig
    {
        public string ServerName { get; set; }
        public int Port { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string DatabaseName { get; set; }
        public DatabaseConfig()
        {
            try
            {
                using (StreamReader st = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + PConstants.FILE_DATABASE_CONFIG))
                {
                    st.ReadLine();
                    this.ServerName = st.ReadLine();
                    this.Port = Int32.Parse(st.ReadLine());
                    this.User = st.ReadLine();
                    this.Password = Security.Decrypt(st.ReadLine());
                    this.DatabaseName = st.ReadLine();

                }
            }
            catch
            {
                //default
                this.ServerName = "115.78.5.68";
                this.Port = 5432;
                this.User = "admin";
                this.Password = "admin123";
                this.DatabaseName = "cmsdb";
            }
        }
        public void Save()
        {
            try
            {
                if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + PConstants.FILE_DATABASE_CONFIG))
                {
                    File.Create(AppDomain.CurrentDomain.BaseDirectory + PConstants.FILE_DATABASE_CONFIG).Close();
                }
                using (StreamWriter st = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + PConstants.FILE_DATABASE_CONFIG))
                {
                    st.WriteLine("#Database Settings - Server, Port, User, Password, DatabaseName");
                    st.WriteLine(this.ServerName);
                    st.WriteLine(this.Port);
                    st.WriteLine(this.User);
                    st.WriteLine(Security.Encrypt(this.Password));
                    st.WriteLine(this.DatabaseName);
                }

            }
            catch
            {
            }
        }

    }
}
