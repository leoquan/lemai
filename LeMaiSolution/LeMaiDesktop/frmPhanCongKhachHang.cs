using LeMaiDomain;
using LeMaiLogic;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeMaiDesktop
{
    public partial class frmPhanCongKhachHang : frmBase
    {
        private string idNguoiDung = string.Empty;
        private AccountObject Gitem;

        private int status = PConstants.MODE_NONE;//0: Không làm gì cả, 1: Chế độ thêm mới, 2: Chế độ chỉnh sửa
        public frmPhanCongKhachHang() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
        }
        /// <summary>
        /// Get danh sách form được check
        /// </summary>
        /// <returns></returns>
        private List<ExpCustomer> getNodeChecked()
        {
            List<ExpCustomer> ls = new List<ExpCustomer>();
            foreach (TreeNode root in trvKhachHang.Nodes)
            {
                foreach (TreeNode parentNode in root.Nodes)
                {
                    foreach (TreeNode subparentNode in parentNode.Nodes)
                    {
                        if (subparentNode.Checked)
                        {
                            ls.Add(subparentNode.Tag as ExpCustomer);
                        }
                    }
                }
            }

            return ls;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idUser"></param>
        private void setNodeCheckUser(string idUser)
        {
            IDataContext dc = PCommon.getDataContext();
            try
            {
                dc.Open();
                List<ExpAccountCustomer> lQSuserform = dc.EXpaccountcustomer.GetListObjectCon(PBean.SCHEMA, "WHERE FK_Account=@FK_Account", "@FK_Account", idUser);
                foreach (TreeNode root in trvKhachHang.Nodes)
                {
                    int parrentIncheck = 0;
                    foreach (TreeNode parentNode in root.Nodes)
                    {
                        int subParrentInCheck = 0;
                        foreach (TreeNode cusNode in parentNode.Nodes)
                        {
                            ExpCustomer customer = cusNode.Tag as ExpCustomer;
                            if (lQSuserform.Exists(u => u.FK_Customer == customer.Id))
                            {
                                cusNode.Checked = true;
                                subParrentInCheck++;
                            }
                            else
                            {
                                cusNode.Checked = false;
                            }
                        }
                        if (parentNode.Nodes.Count == subParrentInCheck)
                        {
                            parentNode.Checked = true;
                            parrentIncheck++;
                        }
                        else
                        {
                            parentNode.Checked = false;
                        }
                    }
                    // Check all nếu mình check hết các check con
                    if (parrentIncheck == root.Nodes.Count)
                    {
                        root.Checked = true;
                    }
                    else
                    {
                        root.Checked = false;
                    }
                }
                //foreach (TreeNode root in trvKhachHang.Nodes)
                //{
                //    int parrentIncheck = 0;
                //    foreach (TreeNode parentNode in root.Nodes)
                //    {
                //        int subParrentInCheck = 0;
                //        foreach (TreeNode subparentNode in parentNode.Nodes)
                //        {
                //            int formInCheck = 0;
                //            foreach (TreeNode formNode in subparentNode.Nodes)
                //            {
                //                MenuFunction form = formNode.Tag as MenuFunction;
                //                if (lQSuserform.Exists(u => u.FK_MenuFunction == form.Id))
                //                {
                //                    formNode.Checked = true;
                //                    formInCheck++;
                //                }
                //                else
                //                {
                //                    formNode.Checked = false;
                //                }
                //            }
                //            // Nếu sô lượng form con được check = số form trong nhóm, thì ta check nhóm luôn
                //            if (formInCheck == subparentNode.Nodes.Count)
                //            {
                //                subparentNode.Checked = true;
                //                subParrentInCheck++;
                //            }
                //            else
                //            {
                //                subparentNode.Checked = false;
                //            }
                //        }
                //        if (parentNode.Nodes.Count == subParrentInCheck)
                //        {
                //            parentNode.Checked = true;
                //            parrentIncheck++;
                //        }
                //        else
                //        {
                //            parentNode.Checked = false;
                //        }
                //    }
                //    if (parrentIncheck == root.Nodes.Count)
                //    {
                //        root.Checked = true;
                //    }
                //    else
                //    {
                //        root.Checked = false;
                //    }
                //}
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
        /// <summary>
        /// DoubleClik trên lưới người dùng.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridNguoiDung_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //lấy index của dòng đầu tiên được chọn
                int index = gridAccount.SelectedRows[0].Index;
                IDataContext dc = PCommon.getDataContext();
                try
                {
                    dc.Open();
                    idNguoiDung = Convert.ToString(gridAccount.Rows[index].Cells["col_Id"].Value);
                    setNodeCheckUser(idNguoiDung);
                    Gitem = dc.ACcountobject.GetObject(PBean.SCHEMA, idNguoiDung);
                    // Enable button
                    status = PConstants.MODE_UPDATE;
                    EnableButton(status);
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
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idNguoiDung))
            {
                MessageBox.Show(string.Format(language.GetResourceString("MSG_0059")));
            }
            else
            {
                List<ExpCustomer> lsForm = getNodeChecked();
                IDataContext dc = PCommon.getDataContext();
                try
                {
                    dc.Open();
                    dc.EXpaccountcustomer.DeleteOnSubmitCon(PBean.SCHEMA, "where FK_Account=@FK_Account", "@FK_Account", idNguoiDung);
                    foreach (ExpCustomer form in lsForm)
                    {
                        ExpAccountCustomer userForm = new ExpAccountCustomer();
                        userForm.FK_Customer = form.Id;
                        userForm.FK_Account = idNguoiDung;
                        userForm.TypeCode = 1;
                        dc.EXpaccountcustomer.InsertOnSubmit(PBean.SCHEMA, userForm);
                    }
                    dc.SubmitChanges();
                    status = PConstants.MODE_NONE;
                    EnableButton(status);
                    LoadData();
                    MessageBox.Show(string.Format(language.GetResourceString("MSG_0060")));
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
                ReloadTreeView();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPhanCongKhachHang_Load(object sender, EventArgs e)
        {
            ReloadTreeView();
            // Load danh sách người dùng
            LoadData();
            EnableButton(status);
        }
        void ReloadTreeView()
        {
            trvKhachHang.Nodes.Clear();

            TreeNode rootNode = GetTreeForm();
            trvKhachHang.Nodes.Add(rootNode);
            trvKhachHang.ExpandAll();
        }
        private void EnableButton(int stus)
        {
            //Enable tất cả các button
            btnSave.Enabled = true;
            if (stus == PConstants.MODE_NONE)
            {
                btnSave.Enabled = false;
                trvKhachHang.Enabled = true;
            }
            if (stus == PConstants.MODE_NEW)
            {
                trvKhachHang.Enabled = true;
            }
            if (stus == PConstants.MODE_UPDATE)
            {
                trvKhachHang.Enabled = true;
            }
        }
        private void LoadData()
        {
            IDataContext dc = PCommon.getDataContext();
            try
            {
                dc.Open();
                gridAccount.AutoGenerateColumns = false;
                gridAccount.DataSource = dc.ACcountobject.GetListObjectCon(PBean.SCHEMA, "WHERE CardId=@CardId", "@CardId", PBean.USER.CardId);
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
        private TreeNode GetTreeForm()
        {
            TreeNode rootNode = new TreeNode("Tất cả");
            IDataContext dc = PCommon.getDataContext();
            try
            {
                dc.Open();
                List<ExpCustomerGroup> lsGroup = dc.EXpcustomergroup.GetListObjectCon(PBean.SCHEMA, "WHERE FK_Post='" + PBean.USER.CardId + "'");
                this.menuChuyenNhom.DropDownItems.Clear();
                foreach (var group in lsGroup)
                {
                    // Tạo menu trip
                    ToolStripMenuItem menuStrip = new ToolStripMenuItem();
                    menuStrip.Name = "menuStrip" + group.Code;
                    menuStrip.Size = new System.Drawing.Size(180, 22);
                    menuStrip.Text = group.TenNhom;
                    menuStrip.Tag = group.Id;
                    menuStrip.Click += new System.EventHandler(this.menuStrip_Click);
                    this.menuChuyenNhom.DropDownItems.Add(menuStrip);
                    // Node
                    List<ExpCustomer> lsCustomerSi = dc.EXpcustomer.GetListObjectCon(PBean.SCHEMA, "WHERE FK_Post='" + PBean.USER.CardId + "' AND FK_Group='" + group.Id + "' ORDER BY CustomerName");
                    TreeNode khachSiNode = new TreeNode(group.TenNhom + " (" + lsCustomerSi.Count.ToString() + ")");
                    khachSiNode.ForeColor = Color.Blue;


                    foreach (var item in lsCustomerSi)
                    {
                        string account = string.Empty;
                        List<ExpAccountCustomer> lsCus = dc.EXpaccountcustomer.GetListObjectCon(PBean.SCHEMA, "WHERE FK_Customer=@FK_Customer", "@FK_Customer", item.Id);
                        foreach (var subItem in lsCus)
                        {
                            account += subItem.FK_Account + ", ";
                        }
                        account = account.Trim();
                        account = account.TrimEnd(',');
                        if (lsCus.Count > 0)
                        {
                            TreeNode formNode = new TreeNode(item.CustomerName + " - " + item.CustomerPhone + " (" + account + ")");
                            formNode.Tag = item;
                            khachSiNode.Nodes.Add(formNode);
                        }
                        else
                        {
                            TreeNode formNode = new TreeNode(item.CustomerName + " - " + item.CustomerPhone);
                            formNode.Tag = item;
                            formNode.ForeColor = Color.Red;
                            khachSiNode.Nodes.Add(formNode);
                        }

                    }
                    rootNode.Nodes.Add(khachSiNode);
                }

                // Khách lẻ 
                List<ExpCustomer> lsCustomerChuaPhanNhom = dc.EXpcustomer.GetListObjectCon(PBean.SCHEMA, "WHERE FK_Post='" + PBean.USER.CardId + "' AND (FK_Group='' OR FK_Group IS NULL) ORDER BY CustomerName");
                TreeNode khachLeNode = new TreeNode("Chưa phân nhóm (" + lsCustomerChuaPhanNhom.Count.ToString() + ")");
                khachLeNode.ForeColor = Color.Blue;

                foreach (var item in lsCustomerChuaPhanNhom)
                {
                    string account = string.Empty;
                    List<ExpAccountCustomer> lsCus = dc.EXpaccountcustomer.GetListObjectCon(PBean.SCHEMA, "WHERE FK_Customer=@FK_Customer", "@FK_Customer", item.Id);
                    foreach (var subItem in lsCus)
                    {
                        account += subItem.FK_Account + ", ";
                    }
                    account = account.Trim();
                    account = account.TrimEnd(',');
                    if (lsCus.Count > 0)
                    {
                        TreeNode formNode = new TreeNode(item.CustomerName + " - " + item.CustomerPhone + " (" + account + ")");
                        formNode.Tag = item;
                        khachLeNode.Nodes.Add(formNode);
                    }
                    else
                    {
                        TreeNode formNode = new TreeNode(item.CustomerName + " - " + item.CustomerPhone);
                        formNode.Tag = item;
                        formNode.ForeColor = Color.Red;
                        khachLeNode.Nodes.Add(formNode);
                    }
                }
                rootNode.Nodes.Add(khachLeNode);

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
            return rootNode;
        }

        private void trvKhachHang_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action == TreeViewAction.ByMouse || e.Action == TreeViewAction.ByKeyboard)
            {
                TreeNode currentNode = e.Node;
                setNodeCheck(currentNode, currentNode.Checked);
            }
        }
        private void setNodeCheck(TreeNode node, bool check)
        {
            foreach (TreeNode child in node.Nodes)
            {
                child.Checked = check;
                setNodeCheck(child, check);
            }
        }

        private void menuStrip_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuStrip = sender as ToolStripMenuItem;
            if (menuStrip != null)
            {
                if (menuStrip.Tag != null)
                {
                    TreeNode node = trvKhachHang.SelectedNode;
                    if (node != null)
                    {
                        ExpCustomer itemCus = node.Tag as ExpCustomer;
                        if (itemCus != null)
                        {
                            IDataContext dc = PCommon.getDataContext();
                            try
                            {
                                dc.Open();
                                ExpCustomer cus = dc.EXpcustomer.GetObject(PBean.SCHEMA, itemCus.Id);
                                if (cus != null)
                                {
                                    cus.FK_Group = menuStrip.Tag.ToString();
                                    dc.EXpcustomer.Update(PBean.SCHEMA, cus);
                                    dc.SubmitChanges();
                                }
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

                    }
                }
            }
        }
    }
}
