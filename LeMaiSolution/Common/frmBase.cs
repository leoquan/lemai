using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Common
{
    public partial class frmBase : Form
    {
        protected log4net.ILog log { get; private set; }
        protected Language.LanguageManager language;
        protected CultureInfo _CultureInfo;
        protected string GdecimalString;
        protected char GdecimalChar;
        protected string GthousandString;
        public enum Action
        {
            New_Item,
            Edit_Item,
            Delete_Item,
            Print_Item
        }
        /// <summary>
        /// 
        /// </summary>
        public frmBase()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="childType"></param>
        public frmBase(Type childType)
        {
            InitializeComponent();
            Separator();
            language = new Language.LanguageManager();
            log = log4net.LogManager.GetLogger(childType);
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
        /// <summary>
        /// Lưu lại thao tác
        /// </summary>
        /// <param name="action">Enum Action: Mở form, đóng form, New, Eit, Delete</param>
        /// <param name="description"></param>
        /// <param name="key"></param>
        //public void SaveActionDetail(Action action, string description, string key)
        //{

        //    IDataContext dc = PCommon.getDataContext();
        //    try
        //    {
        //        dc.Open();
        //        //luu lich su
        //        if (PBean.USER != null)
        //        {
        //            _ManagerID = this.Tag == null ? string.Empty : this.Tag.ToString();

        //            q_s_historyct Item = new q_s_historyct();
        //            Item.id = PCommon.GetID();
        //            Item.id_history = _HistoryOpenFormID;
        //            Item.id_user = PBean.USER.id;
        //            Item.ngaytao = dc.CurrentTime();
        //            Item.enumaction = action.ToString();
        //            Item.actioned = description;
        //            Item.id_actioned = key;
        //            Item.maql = _ManagerID;
        //            dc.QShistoryct.InsertOnSubmit(PBean.SCHEMA, Item);
        //            dc.SubmitChanges();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
        //    }
        //    finally
        //    {
        //        dc.Close();

        //    }
        //}
        /// <summary>
        /// Thay đổi ngôn ngữ
        /// </summary>
        protected void ChangeLanguageUI(bool makeLanguge = false)
        {
            string key = string.Empty;
            Dictionary<string, string> lsDictions = new Dictionary<string, string>();
            // Tiểu đề của form
            if (makeLanguge)
            {
                key = this.Name;
                if (!lsDictions.ContainsKey(key))
                    lsDictions.Add(this.Name, this.Text);
            }
            else
            {
                this.Text = language.GetResourceString(this.Name);
            }
            // Xử lý cái message title
            PBean.MESSAGE_TITLE = language.GetResourceString(PConstants.APPLICATION_NAME);

            List<Control> lis = GetAllControl(this);
            foreach (Control con in lis)
            {
                string type = con.GetType().Name;
                // Xử lý cái DataGridview
                if (type.Contains("DataGridView"))
                {
                    DataGridView grid = con as DataGridView;
                    string gridName = grid.Name;
                    foreach (DataGridViewColumn col in grid.Columns)
                    {
                        if (makeLanguge)
                        {
                            key = this.Name + "_" + col.Name;
                            if (!lsDictions.ContainsKey(key))
                                lsDictions.Add(key, col.HeaderText);
                        }
                        else
                        {
                            string value = language.GetResourceStringEmpty(this.Name + "_" + col.Name);
                            col.HeaderText = string.IsNullOrEmpty(value) ? col.HeaderText : value;
                        }
                    }
                }
                else
                {
                    if (type.Contains("TextBoxX"))
                    {
                        DevComponents.DotNetBar.Controls.TextBoxX textboxX = con as DevComponents.DotNetBar.Controls.TextBoxX;
                        if (makeLanguge)
                        {
                            key = this.Name + "_" + con.Name;
                            if (!lsDictions.ContainsKey(key))
                                lsDictions.Add(key, textboxX.WatermarkText);
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(textboxX.WatermarkText))
                            {
                                textboxX.WatermarkText = language.GetResourceString(this.Name + "_" + con.Name);
                            }
                        }
                    }
                    else
                    {
                        if (type.Contains("ContextMenuStrip"))
                        {
                            // Xử lý cái context menu strip
                            if (makeLanguge)
                            {

                            }
                            else
                            {

                            }
                        }
                        else
                        {
                            if (!type.Contains("TextBox") && !type.Contains("ComboBox") && !type.Contains("DateTimePicker") && !type.Contains("PictureBox") && !string.IsNullOrEmpty(con.Name))
                            {
                                if (makeLanguge)
                                {
                                    if (con.Parent != null)
                                    {
                                        string typeParrent = con.Parent.GetType().Name;
                                        if (typeParrent.StartsWith("uc"))
                                        {
                                            // Xử lý UC
                                            key = typeParrent + "_" + con.Name;
                                            if (!lsDictions.ContainsKey(key))
                                                lsDictions.Add(key, con.Text);
                                        }
                                        else
                                        {
                                            key = this.Name + "_" + con.Name;
                                            if (!lsDictions.ContainsKey(key))
                                                lsDictions.Add(key, con.Text);
                                        }
                                    }
                                    else
                                    {
                                        key = this.Name + "_" + con.Name;
                                        if (!lsDictions.ContainsKey(key))
                                            lsDictions.Add(key, con.Text);
                                    }

                                }
                                else
                                {
                                    if (con.Parent != null)
                                    {
                                        string typeParrent = con.Parent.GetType().Name;
                                        if (typeParrent.StartsWith("uc"))
                                        {
                                            if (con.Tag == null)
                                            {
                                                con.Text = language.GetResourceString(typeParrent + "_" + con.Name);
                                            }
                                            else
                                            {
                                                if (con.Tag != null && string.IsNullOrEmpty(con.Tag.ToString()))
                                                {
                                                    con.Text = language.GetResourceString(typeParrent + "_" + con.Name);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (con.Tag == null)
                                            {
                                                con.Text = language.GetResourceString(this.Name + "_" + con.Name);
                                            }
                                            else
                                            {
                                                if (con.Tag != null && string.IsNullOrEmpty(con.Tag.ToString()))
                                                {
                                                    con.Text = language.GetResourceString(this.Name + "_" + con.Name);
                                                }
                                            }
                                        }

                                    }
                                    else
                                    {
                                        if (con.Tag == null)
                                        {
                                            con.Text = language.GetResourceString(this.Name + "_" + con.Name);
                                        }
                                        else
                                        {
                                            if (con.Tag != null && string.IsNullOrEmpty(con.Tag.ToString()))
                                            {
                                                con.Text = language.GetResourceString(this.Name + "_" + con.Name);
                                            }
                                        }
                                    }

                                }

                            }
                        }
                    }
                }
            }
            // Xử lý cái menu
            if (this.Menu != null)
            {
                foreach (MenuItem item in this.Menu.MenuItems)
                {
                    List<MenuItem> lsMenu = GetAllMenuItem(item);
                    if (makeLanguge)
                    {
                        key = this.Name + "_" + item.Name;
                        if (!lsDictions.ContainsKey(key))
                            lsDictions.Add(key, item.Text);
                    }
                    else
                    {
                        item.Text = language.GetResourceString(this.Name + "_" + item.Name);
                    }
                    foreach (MenuItem i in lsMenu)
                    {
                        if (makeLanguge)
                        {
                            key = this.Name + "_" + i.Name;
                            if (!lsDictions.ContainsKey(key))
                                lsDictions.Add(key, i.Text);
                        }
                        else
                        {
                            i.Text = language.GetResourceString(this.Name + "_" + i.Name);
                        }
                    }
                }
            }
            // Xử lý cái context menu strip

            // Xử lý riêng cho sub button bên trong button
            foreach (DevComponents.DotNetBar.ButtonItem item in GetAllSubItem(lis))
            {
                if (makeLanguge)
                {
                    key = this.Name + "_" + item.Name;
                    if (!lsDictions.ContainsKey(key))
                        lsDictions.Add(this.Name + "_" + item.Name, item.Text);
                }
                else
                {
                    item.Text = language.GetResourceString(this.Name + "_" + item.Name);
                }
            }

            if (makeLanguge)
            {
                // Tạo file language
                try
                {
                    if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Language//" + this.Name + ".txt"))
                    {
                        File.Create(AppDomain.CurrentDomain.BaseDirectory + "Language//" + this.Name + ".txt").Close();
                    }
                    string dataText = string.Empty;
                    using (StreamWriter st = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Language//" + this.Name + ".txt"))
                    {
                        foreach (KeyValuePair<string, string> pair in lsDictions)
                        {
                            string result = "<data name=\"" + pair.Key + "\">" + changeSpecialString(pair.Value) + "</data>";
                            dataText += result + "\n";
                            st.WriteLine(result);
                        }
                    }
                    //Clipboard.SetText(dataText);
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                }
            }
            // Xử lý lưu lại lịch sử mở form
            //string className = this.GetType().ToString();
            //string titleForm = this.Text;
            //IDataContext dc = PCommon.getDataContext();
            //try
            //{
            //    dc.Open();
            //    //luu lich su
            //    if (PBean.USER != null)
            //    {
            //        Gitem = new q_s_history();
            //        Gitem.id = PCommon.GetID();
            //        _HistoryOpenFormID = Gitem.id;
            //        Gitem.id_his_login = PBean.HIS_LOGIN_ID;
            //        Gitem.actions = PConstants.OPEN_FORM + titleForm + " [" + className + "]";
            //        Gitem.createdate = dc.CurrentTime();
            //        Gitem.createuser = PBean.USER.id;
            //        dc.QShistory.InsertOnSubmit(PBean.SCHEMA, Gitem);
            //        dc.SubmitChanges();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    log.Error(ex);
            //}
            //finally
            //{
            //    dc.Close();
            //}
        }
        /// <summary>
        /// Tạo file language
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private string changeSpecialString(string value)
        {
            value = value.Replace("&", "&amp;");
            value = value.Replace("\"", "&quot;");
            value = value.Replace("'", "&apos;");
            value = value.Replace("<", "&lt;");
            value = value.Replace(">", "&gt;");
            return value;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == (Keys.Control | Keys.Alt | Keys.S))
            {
                //Make Language file
                ChangeLanguageUI(true);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID_RESOURCE"></param>
        /// <returns></returns>
        protected string getResource(string ID_RESOURCE)
        {
            try
            {
                return language.GetResourceString(ID_RESOURCE);
            }
            catch (Exception ex)
            {
                log.Error(ex);
                return ID_RESOURCE;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        protected List<Control> GetAllControl(Control control)
        {
            List<Control> list = new List<Control>();
            // Control
            foreach (Control childControl in control.Controls)
            {
                list.Add(childControl);
                list.AddRange(GetAllControl(childControl));
            }
            return list;
        }
        protected List<DevComponents.DotNetBar.ButtonItem> GetAllSubItem(List<Control> controls)
        {
            List<DevComponents.DotNetBar.ButtonItem> list = new List<DevComponents.DotNetBar.ButtonItem>();
            // Control
            foreach (Control childControl in controls)
            {
                string type = childControl.GetType().Name;
                if (type.Contains("ButtonX"))
                {
                    DevComponents.DotNetBar.ButtonX button = childControl as DevComponents.DotNetBar.ButtonX;
                    foreach (DevComponents.DotNetBar.ButtonItem item in button.SubItems)
                    {
                        list.Add(item);
                    }
                }
            }
            return list;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        protected List<MenuItem> GetAllMenuItem(MenuItem control)
        {
            List<MenuItem> list = new List<MenuItem>();
            foreach (MenuItem childControl in control.MenuItems)
            {
                list.Add(childControl);
                list.AddRange(GetAllMenuItem(childControl));
            }
            return list;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }
        /// <summary>
        /// Textbox chỉ cho nhập số
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Number_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox textbox = (sender as TextBox);
            if (!String.IsNullOrEmpty(textbox.Text))
            {
                textbox.Text = ThousandSeparator(textbox.Text);
            }
            textbox.SelectionStart = textbox.Text.Length;
            textbox.SelectionLength = 0;
        }
        /// <summary>
        /// Textbox nhập số có hỗ trợ thập phân có phân cách phần nghìn KeyPress và KeyUp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Curency_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != GdecimalChar)
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    SendKeys.Send("{Tab}");
                }
                if (e.KeyChar == GdecimalChar && (sender as TextBox).Text.IndexOf(GdecimalString) != -1)
                {
                    e.Handled = true;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Curency_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox textbox = (sender as TextBox);
            if (!String.IsNullOrEmpty(textbox.Text))
            {
                if (textbox.Text.IndexOf(GdecimalString) != -1 && textbox.Text.Length == 1)
                {
                    textbox.Text = "0" + GdecimalString;
                }
                else
                {
                    if (textbox.Text.IndexOf(GdecimalString) != -1)
                    {
                        string[] sr = textbox.Text.Split(GdecimalChar);
                        textbox.Text = ThousandSeparator(sr[0]) + GdecimalString + sr[1];
                    }
                    else
                    {
                        textbox.Text = ThousandSeparator(textbox.Text);
                    }
                }
            }
            textbox.SelectionStart = textbox.Text.Length;
            textbox.SelectionLength = 0;

        }
        /// <summary>
        /// Textbox chỉ cho nhập chữ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Alpha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }
        /// <summary>
        /// Lấy định dạng dấu phân cách số thập phân - phân cách hàng nghìn
        /// </summary>
        protected void Separator()
        {
            GdecimalString = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            GdecimalChar = Convert.ToChar(GdecimalString);
            if (GdecimalChar == '.')
            {
                GthousandString = ",";
            }
            else
            {
                GthousandString = ".";
            }
        }
        /// <summary>
        /// Xử lý dấu ngăn cách thập phân - dấu ngăn cách phần nghìn
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        protected string ThousandSeparator(string number)
        {
            if (number.Length >= 4)
            {
                number = number.Replace(GthousandString, "");
                int sodu = number.Length % 3;
                string result = string.Empty;
                if (sodu > 0)
                {
                    result = number.Substring(0, sodu) + GthousandString;
                    number = number.Substring(sodu, number.Length - sodu);
                }
                for (int i = 0; i < number.Length; i = i + 3)
                {
                    result += number.Substring(i, 3) + GthousandString;
                }
                return result.Substring(0, result.Length - 1);
            }
            else
            {
                return number;
            }
        }

        private void frmBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ghi lịch sử đóng form
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
        }
    }
}
