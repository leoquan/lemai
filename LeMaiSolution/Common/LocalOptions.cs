using log4net;
using System;
using System.IO;

namespace Common
{
    public class LocalOptions
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// Đường dẫn hình cục bộ
        /// </summary>
        public string LOCAL_IMAGE_FOLDER { get; set; }

        public string FULL_ECG_FOLDER { get; set; }
        /// <summary>
        /// Cho phép tự động đăng nhập
        /// </summary>
        public bool AUTO_LOGIN { get; set; }

        public bool LOG_FILE { get; set; }

        //
        /// <summary>
        /// User Cho đăng nhập
        /// </summary>
        public string USER_DEFAULT { get; set; }
        /// <summary>
        /// Password cho đăng nhập
        /// </summary>
        public string PASSWORD_DEFAULT { get; set; }
        /// <summary>
        /// Cho phép lưu trữ hình ảnh ở server
        /// </summary>
        public bool SAVE_IMAGE_SERVER { get; set; }
        public int CAPTURE_DEVICE_INDEX { get; set; }
        public int BARCODE_DEVICE_INDEX { get; set; }
        public int SEARCH_TYPE { get; set; }

        public bool ALWAY_CHANGE_STT { get; set; }

        public bool PRINT_PREVIEW { get; set; }
        public bool SAVE_AND_PRINT { get; set; }
        public string LOCALTION_TINH { get; set; }
        public string LOCALTION_HUYEN { get; set; }
        public string LOCALTION_XA { get; set; }

        public string SAVE_TINH { get; set; }
        public string SAVE_HUYEN { get; set; }
        public string SAVE_XA { get; set; }
        public string PRINTER_BILL { get; set; }
        public string PRINTER_RECEPT { get; set; }
        public string PRINTER_NAME { get; set; }

        public string ICON_NAME { get; set; }

        public string PrintSize { get; set; }

        public string PrintSizeReceipt { get; set; }

        public string CustomerCare { get; set; }

        public bool DevExpressReport { get; set; }

        // Kết thúc phần thêm các options
        /// <summary>
        /// Đọc file option from local machine
        /// </summary>
        public static LocalOptions ReadOption()
        {
            LocalOptions local = new LocalOptions();
            try
            {
                var iniFile = new IniFile(AppDomain.CurrentDomain.BaseDirectory + PConstants.FILE_OPTION);
                foreach (var prop in typeof(LocalOptions).GetProperties())
                {
                    switch (prop.PropertyType.Name)
                    {
                        case "Boolean":
                            prop.SetValue(local, iniFile.GetBoolean(PConstants.SECTION_OPTION, prop.Name, false), null);
                            break;
                        case "Int32":
                            prop.SetValue(local, iniFile.GetInteger(PConstants.SECTION_OPTION, prop.Name, 0), null);
                            break;
                        case "Double":
                            prop.SetValue(local, iniFile.GetDouble(PConstants.SECTION_OPTION, prop.Name, 0), null);
                            break;
                        case "String":
                            prop.SetValue(local, iniFile.GetValue(PConstants.SECTION_OPTION, prop.Name, string.Empty), null);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
            return local;
        }
        public LocalOptions()
        {

        }
        /// <summary>
        /// Lưu trạng thái của local option xuống file
        /// </summary>
        public void Save()
        {
            try
            {
                if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + PConstants.FILE_OPTION))
                {
                    File.Create(AppDomain.CurrentDomain.BaseDirectory + PConstants.FILE_OPTION).Close();
                }
                using (StreamWriter st = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + PConstants.FILE_OPTION))
                {
                    st.WriteLine("[" + PConstants.SECTION_OPTION + "]");
                    foreach (var prop in typeof(LocalOptions).GetProperties())
                    {
                        st.WriteLine(prop.Name + " = " + prop.GetValue(this, null));
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
    }
}
