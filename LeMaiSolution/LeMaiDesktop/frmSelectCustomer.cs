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
    public partial class frmSelectCustomer : frmBase
    {
        public string SelectCustomer = string.Empty;
        public List<ExpCustomer> lsCustomer = new List<ExpCustomer>();
        public frmSelectCustomer() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
        }

        private void txtLocKhachHang_TextChanged(object sender, EventArgs e)
        {
            TreeNode rootNode = GetTreeForm(txtLocKhachHang.Text);
            trvKhachHang.Nodes.Clear();
            trvKhachHang.Nodes.Add(rootNode);
            trvKhachHang.ExpandAll();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            foreach (var item in lsCustomer)
            {
                SelectCustomer += "\"" + item.CustomerName + "-" + item.CustomerPhone + "\" & ";
            }
            SelectCustomer = SelectCustomer.Trim();
            SelectCustomer = SelectCustomer.TrimEnd('&');
            DialogResult = DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private List<ExpCustomer> getNodeChecked()
        {
            List<ExpCustomer> ls = new List<ExpCustomer>();
            foreach (TreeNode root in trvKhachHang.Nodes)
            {
                foreach (TreeNode parentNode in root.Nodes)
                {
                    if (parentNode.Checked)
                    {
                        ls.Add(parentNode.Tag as ExpCustomer);
                    }
                }
            }

            return ls;
        }

        private TreeNode GetTreeForm(string search)
        {
            TreeNode rootNode = new TreeNode("Tất cả");
            IDataContext dc = PCommon.getDataContext();
            try
            {
                dc.Open();
                List<ExpCustomerGroup> lsGroup = dc.EXpcustomergroup.GetListObjectCon(PBean.SCHEMA, "WHERE FK_Post='" + PBean.USER.CardId + "'");
                foreach (var group in lsGroup)
                {
                    // Node
                    List<ExpCustomer> lsCustomerSi = dc.EXpcustomer.GetListObjectCon(PBean.SCHEMA, "WHERE FK_Post='" + PBean.USER.CardId + "' AND FK_Group='" + group.Id + "' AND UnsigName LIKE '%" + PCommon.UnSigns(search) + "%' ORDER BY CustomerName");
                    TreeNode khachSiNode = new TreeNode(group.TenNhom + " (" + lsCustomerSi.Count.ToString() + ")");
                    khachSiNode.ForeColor = Color.Blue;


                    foreach (var item in lsCustomerSi)
                    {
                        TreeNode formNode = new TreeNode(item.CustomerName + " - " + item.CustomerPhone);
                        formNode.Tag = item;
                        if (lsCustomer.Exists(u => u.Id == item.Id))
                        {
                            formNode.Checked = true;
                        }
                        khachSiNode.Nodes.Add(formNode);
                    }
                    rootNode.Nodes.Add(khachSiNode);
                }

                // Khách lẻ 
                List<ExpCustomer> lsCustomerChuaPhanNhom = dc.EXpcustomer.GetListObjectCon(PBean.SCHEMA, "WHERE FK_Post='" + PBean.USER.CardId + "' AND (FK_Group='' OR FK_Group IS NULL) AND UnsigName LIKE '%" + PCommon.UnSigns(search) + "%' ORDER BY CustomerName");
                TreeNode khachLeNode = new TreeNode("Chưa phân nhóm (" + lsCustomerChuaPhanNhom.Count.ToString() + ")");
                khachLeNode.ForeColor = Color.Blue;

                foreach (var item in lsCustomerChuaPhanNhom)
                {
                    TreeNode formNode = new TreeNode(item.CustomerName + " - " + item.CustomerPhone);
                    formNode.Tag = item;
                    if (lsCustomer.Exists(u => u.Id == item.Id))
                    {
                        formNode.Checked = true;
                    }
                    khachLeNode.Nodes.Add(formNode);
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
        private void frmSelectCustomer_Load(object sender, EventArgs e)
        {
            TreeNode rootNode = GetTreeForm(string.Empty);
            trvKhachHang.Nodes.Add(rootNode);
            trvKhachHang.ExpandAll();
        }

        private void trvKhachHang_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Action == TreeViewAction.ByMouse || e.Action == TreeViewAction.ByKeyboard)
            {
                TreeNode currentNode = e.Node;
                setNodeCheck(currentNode, currentNode.Checked);
            }
            lblSoDonDoiSoat.Text = lsCustomer.Count.ToString();
            if (lsCustomer.Count > 0)
            {
                btnSelect.Enabled = true;
            }
            else
            {
                btnSelect.Enabled = false;
            }
        }
        private void setNodeCheck(TreeNode node, bool check)
        {
            if (node != null && node.Tag != null)
            {
                ExpCustomer cus = node.Tag as ExpCustomer;
                if (cus != null)
                {
                    ExpCustomer sel = lsCustomer.FirstOrDefault(u => u.Id == cus.Id);
                    if (sel == null)
                    {
                        if (check == true)
                        {
                            lsCustomer.Add(cus);
                        }
                    }
                    else
                    {
                        if (check == false)
                        {
                            lsCustomer.Remove(sel);
                        }
                    }
                }
            }
            foreach (TreeNode child in node.Nodes)
            {
                child.Checked = check;
                setNodeCheck(child, check);
            }
        }
    }
}
