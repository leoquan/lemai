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
using LeMaiDomain;
using LeMaiLogic;
using LeMaiLogic.Logic;

namespace LeMaiDesktop
{
    public partial class frmCustomerFilter : frmBase
    {
        CustomerFilterLogic _logic = new CustomerFilterLogic(PBean.ConnectionBase);
        public ExpCustomer CustomerSelected = null;
        public frmCustomerFilter()
        {
            InitializeComponent();
        }

        private async void frmCustomerFilter_Load(object sender, EventArgs e)
        {
            try
            {
                // List Combobox
                var result = await _logic.GetList(txtSearch.Text, PBean.USER.CardId);
                dataGrid.DataSource = result;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
            }
        }

        private async void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                var result = await _logic.GetList(txtSearch.Text, PBean.USER.CardId);
                DataTable data = MapperExtensionClass.ToDataTable<view_ExpCustomer>(result);
                string template = "BASIC_TEMPLATE.xlsx";

                Dictionary<string, string> dicTitle = new Dictionary<string, string>();
                Dictionary<string, string> dicReplaceValue = new Dictionary<string, string>();

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Microsoft Excel files(*.xlsx)| *.xlsx";
                saveFileDialog.FileName = "ExportFileName";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportDataToExcelTemplate.Export(template, saveFileDialog.FileName, 0, data, dicTitle, dicReplaceValue);
                    MessageBox.Show("Export Complete!", PBean.MESSAGE_TITLE);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var result = await _logic.GetList(txtSearch.Text, PBean.USER.CardId);
            dataGrid.DataSource = result;
        }

        private void dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dataGrid.SelectedRows[0].Index;
                CustomerSelected = _logic.GetThongTinKhachHang(Convert.ToString(dataGrid.Rows[index].Cells["col_Id"].Value));
                this.DialogResult = DialogResult.OK;
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }

        }
    }
}

