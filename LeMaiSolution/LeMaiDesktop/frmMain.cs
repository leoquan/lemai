
using log4net;
using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common.Language;
using System.Xml;
using LeMaiDomain;
using LeMaiLogic;

namespace LeMaiDesktop
{
    public partial class frmMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private List<int> processList = new List<int>();
        private LanguageManager language;
        private List<Language> lsLanguage = new List<Language>();
        public frmMain()
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
            try
            {
                string pathVersion = AppDomain.CurrentDomain.BaseDirectory;
                pathVersion = Directory.GetParent(Directory.GetParent(pathVersion).FullName).FullName;
                pathVersion = pathVersion + "\\" + "version.xml";
                if (File.Exists(pathVersion))
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(pathVersion);
                    XmlNode root = doc.SelectSingleNode("//update");
                    PBean.APPLICATION_VERSION = root.SelectSingleNode("version").InnerText;
                    PBean.APPLICATION_VERSION = PBean.APPLICATION_VERSION.Substring(0, 4) + "." + PBean.APPLICATION_VERSION.Substring(4, 2) + "." + PBean.APPLICATION_VERSION.Substring(6, 2) + "." + PBean.APPLICATION_VERSION.Substring(8, 2);
                }
            }
            catch
            {
            }
            this.Text = PConstants.APPLICATION_NAME + PBean.APPLICATION_VERSION + " - [" + PBean.CONNECTION_STRING_VIEW + "]";
            language = new LanguageManager();
            lsLanguage = language.GetResourceStringList(this.Name);
        }
        /// <summary>
        /// Xử lý event click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.ButtonItem buttonItem = sender as DevComponents.DotNetBar.ButtonItem;
            if (buttonItem != null && buttonItem.Tag != null)
            {
                MenuFunction openForm = buttonItem.Tag as MenuFunction;
                if (openForm != null)
                {
                    if (openForm.FormShowType == 2)
                    {
                        // Xử lý các command ngoại lệ
                        if (openForm.ControllerName.Contains("exit"))
                        {
                            Application.Exit();
                        }
                        else
                        {
                            ProcessStartInfo startInfo = new ProcessStartInfo();
                            string[] parameter = openForm.ControllerName.Trim().Split(' ');
                            if (parameter.Length > 1)
                            {
                                string argument = string.Empty;
                                for (int i = 1; i < parameter.Length; i++)
                                {
                                    argument += parameter[i] + " ";
                                }
                                startInfo.Arguments = argument.Trim();
                            }
                            startInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + parameter[0];
                            if (File.Exists(startInfo.FileName))
                            {
                                using (Process process = Process.Start(startInfo))
                                {
                                    process.WaitForInputIdle();
                                    processList.Add(process.Id);
                                }
                            }
                            else
                            {
                                MessageBox.Show(string.Format(language.GetResourceString("MSG_0016"), parameter[0]), PBean.MESSAGE_TITLE);
                            }
                        }
                    }
                    else
                    {
                        string[] splitData = openForm.ControllerName.Trim().Split(' ');
                        if (!PCommon.FormIsOpened(splitData[0]))
                        {
                            Form form = PermissionExtension.GetFormWithName(splitData[0]);
                            if (form != null)
                            {
                                if (splitData.Length > 1)
                                {
                                    form.Tag = splitData[1];
                                }
                                form.Text = openForm.Title;
                                if (openForm.FormShowType == 0)
                                {
                                    form.Show();
                                }
                                else
                                {
                                    form.ShowDialog();
                                }
                            }
                            else
                            {
                                MessageBox.Show(string.Format(language.GetResourceString("MSG_0017"), openForm.ControllerName), PBean.MESSAGE_TITLE);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(string.Format(language.GetResourceString("MSG_0018")), PBean.MESSAGE_TITLE);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void MakeMenu()
        {
            IDataContext dc = PCommon.getDataContext();
            try
            {
                dc.Open();
                // Change background
                string path = AppDomain.CurrentDomain.BaseDirectory + "Logo\\" + PBean.SERVER_OPTION.BACKGROUND_IMAGE;
                if (File.Exists(path))
                {
                    this.BackgroundImage = PCommon.ImageFromFile(path);
                }
                else
                {
                    path = AppDomain.CurrentDomain.BaseDirectory + "Logo/bgImage_" + PBean.LOCAL_OPTIONS.ICON_NAME + ".png";
                    if (File.Exists(path))
                    {
                        this.BackgroundImage = PCommon.ImageFromFile(path);
                    }
                    else
                    {
                        path = AppDomain.CurrentDomain.BaseDirectory + "Logo\\bgImage.png";
                        if (File.Exists(path))
                        {
                            this.BackgroundImage = PCommon.ImageFromFile(path);
                        }
                    }
                    
                }
                List<view_MenuFunctionAccount> listMenu = dc.VIewmenufunctionaccount.GetListObjectCon(PBean.SCHEMA, "WHERE ProjectUsed IN (0,1,4,5) AND AccountId=@AccountId", "@AccountId", PBean.USER.Id);
                List<MenuFunctionGroup> lsParent = new List<MenuFunctionGroup>();
                List<MenuFunctionGroup> lsSubParent = new List<MenuFunctionGroup>();
                List<MenuFunction> lsForm = new List<MenuFunction>();
                foreach (var item in listMenu)
                {
                    // Check MenuFunction nếu không tồn tại thì thêm vào
                    if (!lsForm.Exists(u => u.Id == item.Id))
                    {
                        lsForm.Add(new MenuFunction
                        {
                            Id = item.Id,
                            Title = item.Title,
                            ControllerName = item.ControllerName,
                            AcctionName = item.AcctionName,
                            ControllerNameApi = item.ControllerNameApi,
                            AcctionNameApi = item.AcctionNameApi,
                            RouteId = item.RouteId,
                            IsMenu = item.IsMenu,
                            IsPublic = item.IsPublic,
                            Icon = item.Icon,
                            CssClass = item.CssClass,
                            Parrent = item.Parrent,
                            Status = item.Status,
                            CreateDate = item.CreateDate,
                            SortIndex = item.SortIndex,
                            Note = item.Note,
                            ProjectUsed = item.ProjectUsed,
                            FK_MenuGroup = item.FK_MenuGroup,
                            MenuWidth = item.MenuWidth,
                            MenuImageName = item.MenuImageName,
                            FK_MenuImage = item.FK_MenuImage,
                            CreateUser = item.CreateUser,
                            UpdateUser = item.UpdateUser,
                            FormShowType = item.FormShowType
                        });
                    }
                    // Check MenuFunctionSubGroup nếu không tồn tại thì thêm vào
                    if (!lsSubParent.Exists(u => u.Id == item.SubId))
                    {
                        lsSubParent.Add(new MenuFunctionGroup
                        {
                            Id = item.SubId,
                            GroupName = item.SubGroupName,
                            SortIndex = item.SubSortIndex,
                            Icon = item.SubIcon,
                            CssClass = item.SubCssClass,
                            CreateDate = item.SubCreateDate,
                            Status = item.SubStatus,
                            FK_MenuGroup = item.SubFK_MenuGroup,
                            ProjectUsed = item.SubProjectUsed
                        });
                    }
                    // Check MenuFunctionGroup
                    if (!lsParent.Exists(u => u.Id == item.GroupId))
                    {
                        lsParent.Add(new MenuFunctionGroup
                        {
                            Id = item.GroupId,
                            GroupName = item.GroupGroupName,
                            SortIndex = item.GroupSortIndex,
                            Icon = item.GroupIcon,
                            CssClass = item.GroupCssClass,
                            CreateDate = item.GroupCreateDate,
                            Status = item.GroupStatus,
                            FK_MenuGroup = item.GroupFK_MenuGroup,
                            ProjectUsed = item.GroupProjectUsed
                        });
                    }
                }
                lsParent = lsParent.OrderBy(u => u.SortIndex).ToList();
                // Thêm các TabControl
                DevComponents.DotNetBar.BaseItem[] baseItem = new DevComponents.DotNetBar.BaseItem[lsParent.Count];
                this.ribbonControl.SuspendLayout();
                this.SuspendLayout();
                for (int parentIndex = 0; parentIndex < lsParent.Count; parentIndex++)
                {
                    DevComponents.DotNetBar.RibbonTabItem ribbonTab = new DevComponents.DotNetBar.RibbonTabItem();
                    DevComponents.DotNetBar.RibbonPanel ribbonPanel = new DevComponents.DotNetBar.RibbonPanel();
                    ribbonPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
                    List<MenuFunctionGroup> lsCurrentSubParent = lsSubParent.Where(u => u.FK_MenuGroup == lsParent[parentIndex].Id).OrderBy(o => o.SortIndex).ToList();
                    int LocationRibonBar = 3;
                    for (int subParentIndex = 0; subParentIndex < lsCurrentSubParent.Count; subParentIndex++)
                    {
                        DevComponents.DotNetBar.RibbonBar ribbonBar = new DevComponents.DotNetBar.RibbonBar();
                        ribbonBar.AutoOverflowEnabled = true;
                        ribbonBar.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
                        ribbonBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
                        ribbonBar.ContainerControlProcessDialogKey = true;
                        ribbonBar.Dock = System.Windows.Forms.DockStyle.Left;
                        // Thêm Ribbon Bar vào ribon Panel
                        ribbonPanel.Controls.Add(ribbonBar); // Sub panel
                        List<MenuFunction> lsCurrentForm = lsForm.Where(u => u.FK_MenuGroup == lsCurrentSubParent[subParentIndex].Id && String.IsNullOrEmpty(u.Parrent)).OrderBy(o => o.SortIndex).ToList();
                        // Danh sách các Button mà ID Owner là rỗng.
                        DevComponents.DotNetBar.BaseItem[] lsParentButton = new DevComponents.DotNetBar.BaseItem[lsCurrentForm.Count];
                        int widthRibbobBar = 0;
                        for (int formParentIndex = 0; formParentIndex < lsCurrentForm.Count; formParentIndex++)
                        {
                            widthRibbobBar = widthRibbobBar + (int)lsCurrentForm[formParentIndex].MenuWidth + 15;
                            DevComponents.DotNetBar.ButtonItem buttonItem = new DevComponents.DotNetBar.ButtonItem();
                            MenuImage menuImage = dc.MEnuimage.GetObject(PBean.SCHEMA, lsCurrentForm[formParentIndex].Id);
                            if (menuImage != null)
                            {
                                buttonItem.Image = PCommon.Base64ToImage(menuImage.ImageString);
                                buttonItem.ImageFixedSize = new System.Drawing.Size(45, 45);
                            }
                            buttonItem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
                            buttonItem.Name = "button" + (parentIndex * subParentIndex * formParentIndex + 1).ToString();
                            buttonItem.Tag = lsCurrentForm[formParentIndex];
                            this.superTooltip.SetSuperTooltip(buttonItem, new DevComponents.DotNetBar.SuperTooltipInfo(lsCurrentForm[formParentIndex].AcctionName, "", lsCurrentForm[formParentIndex].Note, null, null, DevComponents.DotNetBar.eTooltipColor.Gray, true, false, new System.Drawing.Size(0, 0)));
                            buttonItem.Click += new System.EventHandler(menu_Click);
                            // Nếu có button con thì mới splitbutton còn không thì thôi.
                            List<MenuFunction> lsChildForm = lsForm.Where(u => u.Parrent == lsCurrentForm[formParentIndex].Id).OrderBy(o => o.SortIndex).ToList();
                            if (lsChildForm.Count > 0)
                            {
                                buttonItem.SplitButton = true;
                                DevComponents.DotNetBar.BaseItem[] lsChildButton = new DevComponents.DotNetBar.BaseItem[lsChildForm.Count];
                                for (int formChildIndex = 0; formChildIndex < lsChildForm.Count; formChildIndex++)
                                {
                                    DevComponents.DotNetBar.ButtonItem childButtonItem = new DevComponents.DotNetBar.ButtonItem();
                                    menuImage = dc.MEnuimage.GetObject(PBean.SCHEMA, lsChildForm[formChildIndex].Id);
                                    if (menuImage != null)
                                    {
                                        childButtonItem.Image = PCommon.Base64ToImage(menuImage.ImageString);
                                        childButtonItem.ImageFixedSize = new System.Drawing.Size(20, 20);
                                    }
                                    childButtonItem.Name = "button" + (parentIndex * subParentIndex * formParentIndex * formChildIndex + 1).ToString();
                                    string languageName = GetMenuWithLanguage(lsChildForm[formChildIndex].Note);
                                    childButtonItem.Text = string.IsNullOrEmpty(languageName) ? lsChildForm[formChildIndex].AcctionName : languageName;
                                    childButtonItem.Tag = lsChildForm[formChildIndex];
                                    this.superTooltip.SetSuperTooltip(childButtonItem, new DevComponents.DotNetBar.SuperTooltipInfo(lsChildForm[formChildIndex].AcctionName, "", languageName, null, null, DevComponents.DotNetBar.eTooltipColor.Gray, true, false, new System.Drawing.Size(0, 0)));
                                    childButtonItem.Click += new System.EventHandler(menu_Click);
                                    lsChildButton[formChildIndex] = childButtonItem;
                                }
                                buttonItem.SubItems.AddRange(lsChildButton);
                            }
                            else
                            {
                                buttonItem.SplitButton = false;
                            }
                            buttonItem.SubItemsExpandWidth = 14;
                            string subItemLanguage = GetMenuWithLanguage(lsCurrentForm[formParentIndex].Note);
                            subItemLanguage = string.IsNullOrEmpty(subItemLanguage) ? lsCurrentForm[formParentIndex].AcctionName : subItemLanguage;
                            buttonItem.Text = "<div align=\"center\" width=\"" + lsCurrentForm[formParentIndex].MenuWidth.ToString() + "\">" + subItemLanguage + "</div>";
                            lsParentButton[formParentIndex] = buttonItem;
                        }
                        ribbonBar.Items.AddRange(lsParentButton);
                        ribbonBar.Location = new System.Drawing.Point(LocationRibonBar, 0);
                        LocationRibonBar = LocationRibonBar + widthRibbobBar;
                        ribbonBar.Name = "ribbonBar" + (parentIndex * subParentIndex + 1).ToString();
                        ribbonBar.Size = new System.Drawing.Size(widthRibbobBar, 94);
                        ribbonBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
                        ribbonBar.TabIndex = 0;
                        string ribbonBarLanguage = GetMenuWithLanguage("sub_" + lsCurrentSubParent[subParentIndex].GroupName);
                        ribbonBar.Text = string.IsNullOrEmpty(ribbonBarLanguage) ? lsCurrentSubParent[subParentIndex].GroupName : ribbonBarLanguage;
                        ribbonBar.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
                        ribbonBar.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;

                    }
                    ribbonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
                    ribbonPanel.Location = new System.Drawing.Point(0, 53);
                    ribbonPanel.Name = "ribbonPanel" + (parentIndex + 1).ToString();
                    ribbonPanel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
                    ribbonPanel.Size = new System.Drawing.Size(1187, 97);
                    ribbonPanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
                    ribbonPanel.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
                    ribbonPanel.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
                    ribbonPanel.TabIndex = parentIndex;
                    ribbonPanel.Visible = parentIndex == 0 ? true : false;

                    // Gán các giá trị properties cho tab
                    ribbonTab.Checked = parentIndex == 0 ? true : false;
                    ribbonTab.Name = "ribbonTab" + (parentIndex + 1).ToString();
                    string parentLanguage = GetMenuWithLanguage("parent_" + lsParent[parentIndex].GroupName);
                    ribbonTab.Text = string.IsNullOrEmpty(parentLanguage) ? lsParent[parentIndex].GroupName : parentLanguage;
                    //Gán Panel cho Tab
                    ribbonTab.Panel = ribbonPanel;
                    this.ribbonControl.Controls.Add(ribbonPanel);
                    baseItem[parentIndex] = ribbonTab;
                    ribbonPanel.ResumeLayout(false);

                }
                this.ribbonControl.Items.AddRange(baseItem);
                // Resume layout
                this.ribbonControl.ResumeLayout(false);
                this.ribbonControl.PerformLayout();
                this.ResumeLayout(false);

            }
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
            }
            finally
            {
                dc.Close();

            }
        }
        private string GetMenuWithLanguage(string key)
        {
            string temp = this.Name + "_" + key;
            Language l = lsLanguage.FirstOrDefault(u => u.ID == temp);
            if (l == null)
            {
                return string.Empty;
            }
            else
            {
                return l.Name;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        private Image ImageFromFile(string filename)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "images\\" + filename;
            if (!File.Exists(path))
            {
                path = AppDomain.CurrentDomain.BaseDirectory + "images\\Default.png";
            }
            try
            {
                var bytes = File.ReadAllBytes(path);
                var ms = new MemoryStream(bytes);
                var img = Image.FromStream(ms);
                return img;
            }
            catch (IOException)
            {
                return null;
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //Khai báo Tab chức năng
            if (keyData == (Keys.Control | Keys.F12))
            {
                if (PBean.USER.UserName.ToLower() == "admin")
                {
                    frmSuperAdmin frm = new frmSuperAdmin();
                    frm.ShowDialog();
                    return true;
                }

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void frmGUID002_Load(object sender, EventArgs e)
        {
            MakeMenu();
        }
    }
}
