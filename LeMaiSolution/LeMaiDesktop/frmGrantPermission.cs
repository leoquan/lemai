using Common;
using LeMaiDomain;
using LeMaiLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LeMaiDesktop
{
    public partial class frmGrantPermission : frmBase
    {

        private string idNguoiDung = string.Empty;
        private AccountObject Gitem;
        private int status = PConstants.MODE_NONE;//0: Không làm gì cả, 1: Chế độ thêm mới, 2: Chế độ chỉnh sửa
        public frmGrantPermission() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
        }
        /// <summary>
        /// Lấy Node cha của chức năng phần mềm
        /// </summary>
        /// <returns></returns>
        private TreeNode GetTreeForm()
        {
            TreeNode rootNode = new TreeNode("Function");
            IDataContext dc = PCommon.getDataContext();
            try
            {
                dc.Open();
                List<MenuFunctionGroup> lsParent = dc.MEnufunctiongroup.GetListObjectCon(PBean.SCHEMA, "WHERE FK_MenuGroup IS NULL OR FK_MenuGroup=''");
                List<MenuFunctionGroup> lsSubParent = dc.MEnufunctiongroup.GetListObjectCon(PBean.SCHEMA, "WHERE FK_MenuGroup IS NOT NULL");
                List<MenuFunction> lsForm = dc.MEnufunction.GetListObjectCon(PBean.SCHEMA, "WHERE ProjectUsed IN (0,1,4,5)");
                foreach (MenuFunctionGroup parent in lsParent)
                {
                    TreeNode parentNode = new TreeNode(parent.GroupName);
                    parentNode.Tag = parent;
                    List<MenuFunctionGroup> lsCurrentSubParent = lsSubParent.Where(u => u.FK_MenuGroup == parent.Id).OrderBy(o => o.SortIndex).ToList();
                    foreach (MenuFunctionGroup subparent in lsCurrentSubParent)
                    {
                        TreeNode subParentNode = new TreeNode(subparent.GroupName);
                        subParentNode.Tag = subparent;
                        parentNode.Nodes.Add(subParentNode);
                        List<MenuFunction> lsCurrentForm = lsForm.Where(u => u.FK_MenuGroup == subparent.Id).OrderBy(o => o.SortIndex).ToList();
                        foreach (MenuFunction form in lsCurrentForm)
                        {
                            TreeNode formNode = new TreeNode(form.Title);
                            formNode.Tag = form;
                            subParentNode.Nodes.Add(formNode);
                        }
                    }
                    rootNode.Nodes.Add(parentNode);
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
            return rootNode;
        }
        private void LoadData()
        {
            IDataContext dc = PCommon.getDataContext();
            try
            {
                dc.Open();
                gridAccount.AutoGenerateColumns = false;
                gridAccount.DataSource = dc.ACcountobject.GetListObject(PBean.SCHEMA);
                dataGridRole.DataSource = dc.MEnurole.GetListObject(PBean.SCHEMA);
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
        private void frmGrantPermission_Load(object sender, EventArgs e)
        {
            TreeNode rootNode = GetTreeForm();
            trvForm.Nodes.Add(rootNode);
            trvForm.ExpandAll();
            // Load danh sách người dùng
            LoadData();
            EnableButton(status);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idNguoiDung))
            {
                MessageBox.Show(string.Format(language.GetResourceString("MSG_0059")));
            }
            else
            {
                List<MenuFunction> lsForm = getNodeChecked();
                IDataContext dc = PCommon.getDataContext();
                try
                {
                    dc.Open();
                    dc.MEnufunctionaccount.DeleteOnSubmitCon(PBean.SCHEMA, "where FK_AccountObject=@FK_AccountObject", "@FK_AccountObject", idNguoiDung);
                    foreach (MenuFunction form in lsForm)
                    {
                        MenuFunction_Account userForm = new MenuFunction_Account();
                        userForm.CreateDate = DateTime.Now;
                        userForm.CreateUser = PBean.USER.Id;
                        userForm.FK_MenuFunction = form.Id;
                        userForm.FK_AccountObject = idNguoiDung;
                        userForm.PermissionValue = 1;
                        dc.MEnufunctionaccount.InsertOnSubmit(PBean.SCHEMA, userForm);
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
            }
        }

        private void trvForm_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action == TreeViewAction.ByMouse || e.Action == TreeViewAction.ByKeyboard)
            {
                TreeNode currentNode = e.Node;
                setNodeCheck(currentNode, currentNode.Checked);
            }
        }
        /// <summary>
        /// Set giá trị check or uncheck cho Node
        /// </summary>
        /// <param name="node"></param>
        /// <param name="check"></param>
        private void setNodeCheck(TreeNode node, bool check)
        {
            foreach (TreeNode child in node.Nodes)
            {
                child.Checked = check;
                setNodeCheck(child, check);
            }
        }
        /// <summary>
        /// Get danh sách form được check
        /// </summary>
        /// <returns></returns>
        private List<MenuFunction> getNodeChecked()
        {
            List<MenuFunction> ls = new List<MenuFunction>();
            foreach (TreeNode root in trvForm.Nodes)
            {
                foreach (TreeNode parentNode in root.Nodes)
                {
                    foreach (TreeNode subparentNode in parentNode.Nodes)
                    {
                        foreach (TreeNode formNode in subparentNode.Nodes)
                        {
                            if (formNode.Checked)
                            {
                                ls.Add(formNode.Tag as MenuFunction);
                            }
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
                List<MenuFunction_Account> lQSuserform = dc.MEnufunctionaccount.GetListObjectCon(PBean.SCHEMA, "where FK_AccountObject=@FK_AccountObject", "@FK_AccountObject", idUser);
                foreach (TreeNode root in trvForm.Nodes)
                {
                    int parrentIncheck = 0;
                    foreach (TreeNode parentNode in root.Nodes)
                    {
                        int subParrentInCheck = 0;
                        foreach (TreeNode subparentNode in parentNode.Nodes)
                        {
                            int formInCheck = 0;
                            foreach (TreeNode formNode in subparentNode.Nodes)
                            {
                                MenuFunction form = formNode.Tag as MenuFunction;
                                if (lQSuserform.Exists(u => u.FK_MenuFunction == form.Id))
                                {
                                    formNode.Checked = true;
                                    formInCheck++;
                                }
                                else
                                {
                                    formNode.Checked = false;
                                }
                            }
                            // Nếu sô lượng form con được check = số form trong nhóm, thì ta check nhóm luôn
                            if (formInCheck == subparentNode.Nodes.Count)
                            {
                                subparentNode.Checked = true;
                                subParrentInCheck++;
                            }
                            else
                            {
                                subparentNode.Checked = false;
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
                    if (parrentIncheck == root.Nodes.Count)
                    {
                        root.Checked = true;
                    }
                    else
                    {
                        root.Checked = false;
                    }
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
        private void EnableButton(int stus)
        {
            //Enable tất cả các button
            btnSave.Enabled = true;
            if (stus == PConstants.MODE_NONE)
            {
                btnSave.Enabled = false;
                trvForm.Enabled = false;
            }
            if (stus == PConstants.MODE_NEW)
            {
                trvForm.Enabled = true;
            }
            if (stus == PConstants.MODE_UPDATE)
            {
                trvForm.Enabled = true;
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            IDataContext dc = PCommon.getDataContext();
            try
            {
                dc.Open();
                StringBuilder sql = new StringBuilder();

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
