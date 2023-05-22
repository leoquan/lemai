using LeMaiLogic;
using LeMaiLogic.Logic;
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
    public partial class frmLuaChonKyKetToan : frmBase
    {
        private ExpChungTuLogic _logicChungTu = new ExpChungTuLogic(PBean.ConnectionBase);
        public string IdKyKetToan = string.Empty;
        public frmLuaChonKyKetToan() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            IdKyKetToan = cmbKyChungTu.SelectedValue.ToString();
            this.DialogResult = DialogResult.OK;
        }

        private void frmLuaChonKyKetToan_Load(object sender, EventArgs e)
        {
            IDataContext dc = PCommon.getDataContext();
            try
            {
                dc.Open();
                cmbKyChungTu.DataSource = dc.EXpkykettoan.GetListObjectCon(PBean.SCHEMA, "ORDER BY NgayTao asc");
                cmbKyChungTu.DisplayMember = "TenKy";
                cmbKyChungTu.ValueMember = "Id";
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
