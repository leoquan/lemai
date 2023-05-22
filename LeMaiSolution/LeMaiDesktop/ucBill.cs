using Common;
using LeMaiDomain;
using LeMaiLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeMaiDesktop
{
    public partial class ucBill : UserControl
    {
        view_GExpBill _bill = new view_GExpBill();
        public ucBill()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            txtNguoiGui.Text = string.Empty;
            txtSoDienThoaiNguoiGui.Text = string.Empty;
            txtSoNhaNguoiGui.Text = string.Empty;

            txtDiaChiNguoiNhan.Text = string.Empty;
            txtSoDienThoaiNguoiNhan.Text = string.Empty;
            txtNguoiNhan.Text = string.Empty;

            lblThongTinHangHoa.Text = string.Empty;
            txtYeuCauKhac.Text = string.Empty;
            txtXemHang.Text = string.Empty;

            txtCuocPhiChinh.Text = "0";
            txtThuHo.Text = "0";
            txtMaDonHang.Text = string.Empty;
            txtTrongLuongKH.Text = "0";
            txtTongCuoc.Text = "0";
            txtBT3Code.Text = string.Empty;

        }
        public void SetView(view_GExpBill bill)
        {
            // Load Thông tin đơn hàng
            txtNguoiGui.Text = bill.SendMan;
            txtSoDienThoaiNguoiGui.Text = bill.SendManPhone;
            txtSoNhaNguoiGui.Text = bill.SendManAddress;

            txtDiaChiNguoiNhan.Text = bill.FullAddress;
            txtSoDienThoaiNguoiNhan.Text = bill.AcceptManPhone;
            txtNguoiNhan.Text = bill.AcceptMan;

            lblThongTinHangHoa.Text = bill.GoodsName + " - Kích thước: " + bill.GoodsW.ToString() + " x " + bill.GoodsH.ToString() + " x " + bill.GoodsL.ToString() + " cm";
            txtYeuCauKhac.Text = bill.Note;
            txtXemHang.Text = bill.ShipNoteType;

            txtCuocPhiChinh.Text = PCommon.FormatNumber(bill.Freight.ToString());
            txtThuHo.Text = PCommon.FormatNumber(bill.COD.ToString());
            txtMaDonHang.Text = bill.BillCode;

            txtTrongLuongKH.Text = PCommon.FormatNumber(bill.FeeWeight.ToString());
            txtBillWeight.Text = PCommon.FormatNumber(bill.BillWeight.ToString());

            txtBT3Code.Text = bill.BT3Code;

            if (bill.FK_PaymentType == "GTT")
            {
                txtTongCuoc.Text = PCommon.FormatNumber(bill.COD.ToString());
            }
            else
            {
                txtTongCuoc.Text = PCommon.FormatNumber((bill.COD + bill.Freight).ToString());
            }
            _bill = bill;
        }
        public void SetView(string billCode)
        {
            IDataContext dc = new dcDataContextM(PBean.CONNECTION_STRING);
            try
            {
                dc.Open();
                _bill = dc.VIewgexpbill.GetObjectCon(PBean.SCHEMA, "WHERE BillCode=@BillCode", "@BillCode", billCode);
                if (_bill != null)
                {
                    SetView(_bill);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public view_GExpBill GetBill()
        {
            return _bill;
        }
    }
}
