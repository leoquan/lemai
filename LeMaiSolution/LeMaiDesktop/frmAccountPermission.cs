using Common;
using LeMaiDomain;
using LeMaiLogic;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LeMaiDesktop
{
    public partial class frmAccountPermission : frmBase
    {
        public string AccountObjectId = string.Empty;
        public frmAccountPermission() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
        }

        private void frmAccountPermission_Load(object sender, EventArgs e)
        {
            TreeNode rootNode = GetTreeForm();
            trvForm.Nodes.Add(rootNode);
            trvForm.ExpandAll();
            // Load
            setNodeCheckUser(AccountObjectId);
        }
        private TreeNode GetTreeForm()
        {
            TreeNode rootNode = new TreeNode("Chức năng");
            IDataContext dc = PCommon.getDataContext();
            try
            {
                dc.Open();
                List<MenuFunctionGroup> lsParent = dc.MEnufunctiongroup.GetListObjectCon(PBean.SCHEMA, "WHERE (FK_MenuGroup IS NULL OR FK_MenuGroup='') AND ProgramGroup LIKE '%" + PBean.PROGRAM_GROUP + "%'");
                List<MenuFunctionGroup> lsSubParent = dc.MEnufunctiongroup.GetListObjectCon(PBean.SCHEMA, "WHERE FK_MenuGroup IS NOT NULL AND ProgramGroup LIKE '%" + PBean.PROGRAM_GROUP + "%'");
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
        private void trvForm_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action == TreeViewAction.ByMouse || e.Action == TreeViewAction.ByKeyboard)
            {
                TreeNode currentNode = e.Node;
                setNodeCheck(currentNode, currentNode.Checked);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<MenuFunction> lsForm = getNodeChecked();
            IDataContext dc = PCommon.getDataContext();
            try
            {
                dc.Open();
                dc.MEnufunctionaccount.DeleteOnSubmitCon(PBean.SCHEMA, "where FK_AccountObject=@FK_AccountObject", "@FK_AccountObject", AccountObjectId);
                foreach (MenuFunction form in lsForm)
                {
                    MenuFunction_Account userForm = new MenuFunction_Account();
                    userForm.CreateDate = DateTime.Now;
                    userForm.CreateUser = PBean.USER.Id;
                    userForm.FK_MenuFunction = form.Id;
                    userForm.FK_AccountObject = AccountObjectId;
                    userForm.PermissionValue = 1;
                    dc.MEnufunctionaccount.InsertOnSubmit(PBean.SCHEMA, userForm);
                }
                dc.SubmitChanges();
                this.DialogResult = DialogResult.OK;
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
