using Common;
using LeMaiDomain;
using LeMaiDomain.Models;
using LeMaiLogic.Logic;
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
    public partial class frmThayDoiNhaVanChuyen : frmBase
    {
        private GExpBillLogic _logic = new GExpBillLogic(PBean.ConnectionBase);
        string _billCode = string.Empty;
        view_GExpBillGHNApi bill = new view_GExpBillGHNApi();
        public frmThayDoiNhaVanChuyen(string idbillCode) : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            _billCode = idbillCode;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void PrintMaVanDon(string ids)
        {
            List<view_GExpBill> ls = await _logic.GetListByListIds(ids, true);
            if (ls.Count > 0)
            {
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    // Chấp nhận in là chấp nhận kiện hàng
                    await _logic.PrintBilltByListIds(ids, true, PBean.USER.Id, PBean.USER.FullName, PBean.USER.CardId);
                    IDocumentPrint doc = DocumentPrintHelper.GetDocument(PBean.LOCAL_OPTIONS.ICON_NAME);
                    foreach (var item in ls)
                    {
                        if (PBean.LOCAL_OPTIONS.PrintSize == "76x130")
                        {
                            doc.Print76x130(item, printDialog.PrinterSettings, false);
                        }
                        else if (PBean.LOCAL_OPTIONS.PrintSize == "100x150")
                        {
                            doc.Print100x150(item, printDialog.PrinterSettings, false);
                        }
                        else if (PBean.LOCAL_OPTIONS.PrintSize == "100x180")
                        {
                            doc.Print100x180(item, printDialog.PrinterSettings, false);
                        }

                    }
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            // Thay đổi đơn vị vận chuyển
            if (cmbLoaiKien.SelectedValue.ToString() != bill.FK_ProviderAccount)
            {
                view_GExpBillGHNApi oldNhaVanChuyen = bill;

                _logic.ClearDataProviderAccount(bill.BillCode, cmbLoaiKien.SelectedValue.ToString());

                bill = _logic.GetDetailGHNApi(_billCode);
                if (bill != null)
                {
                    IConnectApi api = ApiConnectUlti.GetApiByName(cmbLoaiKien.SelectedValue.ToString(), bill);
                    if (api != null)
                    {
                        var result = api.CreateOrder(bill);
                        if (result.IsSuccess == true)
                        {
                            // Xóa nhà vận chuyển cũ
                            try
                            {
                                IConnectApi apiCancel = ApiConnectUlti.GetApiByName(oldNhaVanChuyen.FK_ProviderAccount, oldNhaVanChuyen);
                                apiCancel.CancelOrder(oldNhaVanChuyen);
                            }
                            catch
                            {
                            }
                            // Update mã nhà vận chuyển mới
                            _logic.UpdateBT3Code(bill.BillCode, result.OrderCode, result.BT3COD, result.BT3Freight, result.BT3SubCode, result.PrintData, result.BT3PayType);
                            if (MessageBox.Show("Đã thay đổi nhà vận chuyển. Mã BT3 mới là [" + result.OrderCode + "]. Bạn có muốn in tem không?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                PrintMaVanDon("'" + bill.BillCode + "'");
                            }
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show(result.Message, PBean.MESSAGE_TITLE);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đã thay đổi nhà vận chuyển. Nhà vận chuyển không có kết nối API, vui lòng tạo đơn trên hệ thống và cập nhật lại mã BT3!", PBean.MESSAGE_TITLE);
                    }

                }
            }
            else
            {
                MessageBox.Show("Chưa chọn nhà vận chuyển mới cần chuyển!", PBean.MESSAGE_TITLE);
            }

        }
        private async void frmThayDoiNhaVanChuyen_Load(object sender, EventArgs e)
        {
            // Load danh sách nhà vận chuyển
            var pro = await _logic.GetDanhSachProvider(PBean.USER.CardId);
            cmbLoaiKien.DataSource = pro;
            cmbLoaiKien.DisplayMember = "ProviderName";
            cmbLoaiKien.ValueMember = "Id";

            bill = _logic.GetDetailGHNApi(_billCode);
            if (bill != null)
            {
                cmbLoaiKien.SelectedValue = bill.FK_ProviderAccount;
                if (bill.BillStatus >= (int)enumGExpBillStatus.DEN_TRUNG_TAM_3)
                {
                    MessageBox.Show("Đơn hàng đã vận chuyển bởi BT3, không thể thay đổi nhà vận chuyển!", PBean.MESSAGE_TITLE);
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }

        }
    }
}
