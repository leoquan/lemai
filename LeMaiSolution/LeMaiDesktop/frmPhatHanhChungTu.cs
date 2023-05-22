using Common;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LeMaiDomain;
using LeMaiDomain.Models;
using LeMaiLogic;
using LeMaiLogic.Logic;

namespace LeMaiDesktop
{
    public partial class frmPhatHanhChungTu : frmBase
    {
        private enumAction status = enumAction.NONE;
        private enumEdit edited = enumEdit.NONE;
        private view_ExpChungTu Gitem;
        private view_ExpChungTu GCopyParrent;
        private List<view_ExpChungTuCt> GListITem = new List<view_ExpChungTuCt>();
        private view_ExpChungTuCt GitemChild;
        private view_ExpChungTuCt GCopyChild;
        private PhatHanhChungTuLogic _logic = new PhatHanhChungTuLogic(PBean.ConnectionBase);
        private ExpChungTuLogic _logicChungTu = new ExpChungTuLogic(PBean.ConnectionBase);
        private string _SelectChungTuId = string.Empty;
        private string _SelectChungTuName = string.Empty;
        public frmPhatHanhChungTu() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
            gridChild.AutoGenerateColumns = false;
            this.gridChild.RowTemplate.MinimumHeight = 22;
            Separator();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Print
            IDataContext dc = PCommon.getDataContext();
            try
            {
                dc.Open();
                DataTable data = dc.GetData("select * from " + PBean.SCHEMA + ".ExpChungTu");

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = gridParrent.SelectedRows[0].Index;
                string Id = Convert.ToString(gridParrent.Rows[index].Cells["col_Id"].Value);
                DeleteItem(Id);
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }
        private async void DeleteItem(String Id)
        {
            var check = await _logic.GetDetails(Id);
            if (check != null)
            {
                if (MessageBox.Show("Bạn có muốn xóa [" + check.ToString() + "] không?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool result = await _logic.Delete(Id);
                    if (result)
                    {
                        Gitem = null;
                        status = enumAction.NONE;
                        edited = enumEdit.NONE;
                        EnableButton(status);
                        LoadGridData();
                    }
                }
            }
        }
        private async void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int index = gridParrent.SelectedRows[0].Index;
                try
                {
                    string Id = Convert.ToString(gridParrent.Rows[index].Cells["col_Id"].Value);
                    Gitem = await _logic.GetDetails(Id);
                    if (null != Gitem)
                    {
                        FillData(Gitem, false);
                        // Fill data to Machine
                        GListITem = await _logic.GetChildList(Id);
                        LoadDataChildItem();
                        status = enumAction.UPDATE;
                        tabControl.SelectedIndex = 1;
                        EnableButton(status);
                    }
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                    MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (Gitem.IsPhatHanh == true)
            {
                MessageBox.Show("Chứng từ đã phát hành, không cho phép chỉnh sửa?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Kiểm tra dữ liệu nhập
            if (String.IsNullOrEmpty(txtSoHoaDon.Text))
            {
                MessageBox.Show("Số hóa đơn không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoHoaDon.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSoTienThu.Text))
            {
                MessageBox.Show("Số tiền thu không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTienThu.Focus();
                return;
            }
            if (txtSoTienThu.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("Số tiền thu không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTienThu.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSoTienChi.Text))
            {
                MessageBox.Show("Số tiền chi không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTienChi.Focus();
                return;
            }
            if (txtSoTienChi.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("Số tiền chi không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTienChi.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtLyDoChi.Text))
            {
                MessageBox.Show("Lý do chi không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLyDoChi.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtLyDoThu.Text))
            {
                MessageBox.Show("Lý do thu không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLyDoThu.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSoChungTuThu.Text))
            {
                MessageBox.Show("Số chứng từ thu không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoChungTuThu.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSoChungTuChi.Text))
            {
                MessageBox.Show("Số chứng từ chi không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoChungTuChi.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtNguoiMuaHang.Text))
            {
                MessageBox.Show("Người mua hàng không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNguoiMuaHang.Focus();
                return;
            }
            if (GListITem.Count() <= 0)
            {
                MessageBox.Show("Chưa nhập danh sách chi tiết đơn hàng?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                PhatHanhChungTuLogicInputDto masterItem = new PhatHanhChungTuLogicInputDto();
                masterItem.SoHoaDon = txtSoHoaDon.Text;
                masterItem.NgayHoaDon = dtpNgayHoaDon.Value;
                masterItem.NgayCT = dtpNgayChungTu.Value;
                masterItem.SoTienThu = decimal.Parse(txtSoTienThu.Text, CultureInfo.CurrentCulture);
                masterItem.SoTienChi = decimal.Parse(txtSoTienChi.Text, CultureInfo.CurrentCulture);
                masterItem.LyDoChi = txtLyDoChi.Text;
                masterItem.LyDoThu = txtLyDoThu.Text;
                masterItem.SoChungTuThu = txtSoChungTuThu.Text;
                masterItem.SoChungTuChi = txtSoChungTuChi.Text;
                masterItem.FK_Account = PBean.USER.Id;
                masterItem.ThangKT = dtpThangKT.Value;
                masterItem.FK_KyKetToan = cmbKyKetToan.SelectedValue.ToString();
                masterItem.NguoiMuaHang = txtNguoiMuaHang.Text;
                masterItem.DonViMuaHang = txtDonViMuaHang.Text;
                masterItem.MaSoThue = txtMaSoThue.Text;
                masterItem.DiaChi = txtDiaChi.Text;
                foreach (var item in GListITem)
                {
                    childPhatHanhChungTuLogicInputDto childItem = new childPhatHanhChungTuLogicInputDto();
                    childItem.FK_ExpChungTu = item.FK_ExpChungTu;
                    childItem.BILL_CODE = item.BILL_CODE;
                    childItem.SoTienPhaiThu = item.SoTienPhaiThu;
                    childItem.SoTienPhaiChi = item.SoTienPhaiChi;
                    childItem.TenNguoiNhan = item.TenNguoiNhan;
                    childItem.SoDienThoaiNhan = item.SoDienThoaiNhan;
                    childItem.DiaChiNhan = item.DiaChiNhan;
                    childItem.SoTienThuHo = item.SoTienThuHo;
                    childItem.CuocPhiVanChuyen = item.CuocPhiVanChuyen;
                    childItem.TenHang = item.TenHang;
                    childItem.TrongLuong = item.TrongLuong;
                    childItem.IsPhatHanh = item.IsPhatHanh;
                    childItem.CuocPhiChuaGTGT = item.CuocPhiChuaGTGT;
                    childItem.ThueGTGT = item.ThueGTGT;
                    childItem.NgayGuiHang = item.NgayGuiHang;
                    childItem.LoaiThanhToan = item.LoaiThanhToan;
                    masterItem.lsExpChungTuCt.Add(childItem);
                }
                if (status == enumAction.NEW)
                {
                    await _logic.Create(masterItem);
                }
                else if (status == enumAction.UPDATE)
                {
                    await _logic.Update(Gitem.Id, masterItem);
                }
                status = enumAction.NONE;
                edited = enumEdit.NONE;
                EnableButton(status);
                LoadGridData();
                tabControl.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
            }
        }

        //private async void btnRemove_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        int index = gridChild.SelectedRows[0].Index;
        //        string FK_ExpChungTu = Convert.ToString(gridChild.Rows[index].Cells["col_SubFK_ExpChungTu"].Value);
        //        string BILL_CODE = Convert.ToString(gridChild.Rows[index].Cells["col_SubBILL_CODE"].Value);
        //        view_ExpChungTuCt childItem = await _logic.GetChildDetails(FK_ExpChungTu, BILL_CODE);
        //        if (null != childItem)
        //        {
        //            if (MessageBox.Show("Bạn có muốn xóa chi tiết [" + childItem.ToString() + "] không?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //            {
        //                await _logic.DeleteChild(FK_ExpChungTu, BILL_CODE);
        //                GListITem.Remove(childItem);
        //                LoadDataChildItem();
        //                ClearTextSubItem();
        //            }
        //        }

        //    }
        //    catch (ArgumentOutOfRangeException)
        //    {
        //        return;
        //    }
        //}


        private void btnNew_Click(object sender, EventArgs e)
        {

            if (status != enumAction.NONE)
            {
                if (edited != enumEdit.NONE)
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn bỏ qua điều chỉnh", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
                GCopyChild = null;
                GCopyParrent = null;
                Gitem = null;
                GitemChild = null;

                status = enumAction.NONE;
                edited = enumEdit.NONE;
                EnableButton(status);
                tabControl.SelectedIndex = 0;
            }
            else
            {
                GCopyChild = null;
                GCopyParrent = null;
                Gitem = null;
                GitemChild = null;

                status = enumAction.NEW;
                EnableButton(status);
                ClearText();
                GListITem = new List<view_ExpChungTuCt>();
                LoadDataChildItem();
                tabControl.SelectedIndex = 1;
            }
        }
        private void AddItem()
        {
            //Add sub item
            if (String.IsNullOrEmpty(txtSubBILL_CODE.Text))
            {
                MessageBox.Show("BILL_CODE không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubBILL_CODE.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubSoTienPhaiThu.Text))
            {
                MessageBox.Show("SoTienPhaiThu không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubSoTienPhaiThu.Focus();
                return;
            }
            if (txtSubSoTienPhaiThu.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("SoTienPhaiThu không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubSoTienPhaiThu.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubSoTienPhaiChi.Text))
            {
                MessageBox.Show("SoTienPhaiChi không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubSoTienPhaiChi.Focus();
                return;
            }
            if (txtSubSoTienPhaiChi.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("SoTienPhaiChi không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubSoTienPhaiChi.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubTenNguoiNhan.Text))
            {
                MessageBox.Show("TenNguoiNhan không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubTenNguoiNhan.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubSoDienThoaiNhan.Text))
            {
                MessageBox.Show("SoDienThoaiNhan không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubSoDienThoaiNhan.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubDiaChiNhan.Text))
            {
                MessageBox.Show("DiaChiNhan không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubDiaChiNhan.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubSoTienThuHo.Text))
            {
                MessageBox.Show("SoTienThuHo không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubSoTienThuHo.Focus();
                return;
            }
            if (txtSubSoTienThuHo.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("SoTienThuHo không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubSoTienThuHo.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubCuocPhiVanChuyen.Text))
            {
                MessageBox.Show("CuocPhiVanChuyen không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubCuocPhiVanChuyen.Focus();
                return;
            }
            if (txtSubCuocPhiVanChuyen.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("CuocPhiVanChuyen không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubCuocPhiVanChuyen.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubTenHang.Text))
            {
                MessageBox.Show("TenHang không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubTenHang.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubTrongLuong.Text))
            {
                MessageBox.Show("TrongLuong không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubTrongLuong.Focus();
                return;
            }
            if (txtSubTrongLuong.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("TrongLuong không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubTrongLuong.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubCuocPhiChuaGTGT.Text))
            {
                MessageBox.Show("CuocPhiChuaGTGT không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubCuocPhiChuaGTGT.Focus();
                return;
            }
            if (txtSubCuocPhiChuaGTGT.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("CuocPhiChuaGTGT không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubCuocPhiChuaGTGT.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubThueGTGT.Text))
            {
                MessageBox.Show("ThueGTGT không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubThueGTGT.Focus();
                return;
            }
            if (txtSubThueGTGT.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("ThueGTGT không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubThueGTGT.Focus();
                return;
            }

            view_ExpChungTuCt childItem = new view_ExpChungTuCt();
            childItem.BILL_CODE = txtSubBILL_CODE.Text;
            childItem.SoTienPhaiThu = decimal.Parse(txtSubSoTienPhaiThu.Text, CultureInfo.CurrentCulture);
            childItem.SoTienPhaiChi = decimal.Parse(txtSubSoTienPhaiChi.Text, CultureInfo.CurrentCulture);
            childItem.TenNguoiNhan = txtSubTenNguoiNhan.Text;
            childItem.SoDienThoaiNhan = txtSubSoDienThoaiNhan.Text;
            childItem.DiaChiNhan = txtSubDiaChiNhan.Text;
            childItem.SoTienThuHo = decimal.Parse(txtSubSoTienThuHo.Text, CultureInfo.CurrentCulture);
            childItem.CuocPhiVanChuyen = decimal.Parse(txtSubCuocPhiVanChuyen.Text, CultureInfo.CurrentCulture);
            childItem.TenHang = txtSubTenHang.Text;
            childItem.TrongLuong = decimal.Parse(txtSubTrongLuong.Text, CultureInfo.CurrentCulture);
            childItem.IsPhatHanh = false;
            childItem.CuocPhiChuaGTGT = decimal.Parse(txtSubCuocPhiChuaGTGT.Text, CultureInfo.CurrentCulture);
            childItem.ThueGTGT = decimal.Parse(txtSubThueGTGT.Text, CultureInfo.CurrentCulture);
            childItem.NgayGuiHang = dtpSubNgayGuiHang.Value;

            GListITem.Add(childItem);
            edited = enumEdit.EDIT;
            LoadDataChildItem();
            ClearTextSubItem();
        }
        private void LoadDataChildItem()
        {
            ClearTextSubItem();
            gridChild.DataSource = GListITem.ToList();
        }
        private void frmPhatHanhChungTu_Load(object sender, EventArgs e)
        {
            LoadData();
            EnableButton(status);
        }

        private void LoadData(string searchText = "")
        {
            IDataContext dc = PCommon.getDataContext();
            try
            {
                dc.Open();
                cmbKyKetToan.DataSource = dc.EXpkykettoan.GetListObjectCon(PBean.SCHEMA, "ORDER BY NgayTao asc");
                cmbKyKetToan.DisplayMember = "TenKy";
                cmbKyKetToan.ValueMember = "Id";

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
        private void LoadGridData(string searchText = "")
        {
            IDataContext dc = PCommon.getDataContext();
            try
            {
                dc.Open();
                gridParrent.AutoGenerateColumns = false;
                DataTable data = new DataTable();
                if (string.IsNullOrEmpty(searchText))
                {
                    data = dc.GetData("SELECT * FROM " + PBean.SCHEMA + ".view_ExpChungTu WHERE FK_KyKetToan='" + cmbKyChungTu.SelectedValue.ToString() + "' order by SoChungTuThu asc");
                }
                else
                {
                    data = dc.GetData("select * from " + PBean.SCHEMA + ".view_ExpChungTu WHERE FK_KyKetToan='" + cmbKyChungTu.SelectedValue.ToString() + "' AND SoHoaDon like N'%" + searchText + "%' or NguoiMuaHang like N'%" + searchText + "%' order by SoChungTuThu asc");
                }

                gridParrent.DataSource = data;
                int count = 0;
                foreach (DataRow item in data.Rows)
                {
                    int subCount = Int32.Parse(item["COUNT_CHILD"].ToString());
                    count = count + subCount;
                }
                lblCountChild.Text = PCommon.FormatNumber(count.ToString());
                // TÍNH TOÁN GIÁ TRỊ ĐÃ PHÁT HÀNH, CHƯA PHÁT HÀNH. TỔNG TIỀN VÀ TIỀN THUẾ
                view_ExpTotalChungTu totalChungTu = dc.VIewexptotalchungtu.GetObjectCon(PBean.SCHEMA, "WHERE FK_KyKetToan=@FK_KyKetToan", "@FK_KyKetToan", cmbKyChungTu.SelectedValue.ToString());
                if (totalChungTu != null)
                {
                    lblCODPH.Text = PCommon.FormatNumber(totalChungTu.COD_DAPH.ToString());
                    lblCODChuaPH.Text = PCommon.FormatNumber(totalChungTu.COD_CHUA_PH.ToString());
                    lblVATPH.Text = PCommon.FormatNumber(totalChungTu.THUEVAT_DAPH.ToString());
                    lblVATChuaPH.Text = PCommon.FormatNumber(totalChungTu.THUEVAT_CHUA_PH.ToString());
                    lblShipPH.Text = PCommon.FormatNumber(totalChungTu.PHIVC_DAPH.ToString());
                    lblShipChuaPH.Text = PCommon.FormatNumber(totalChungTu.PHIVC_CHUA_PH.ToString());
                    
                }
                lblCount.Text = data.Rows.Count.ToString();
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
        private void txtSearchForm_TextChanged(object sender, EventArgs e)
        {
            LoadGridData(txtSearchForm.Text);
        }
        private void EnableButton(enumAction stus)
        {
            //Enable tất cả các button
            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            // Child
            btnNewChild.Enabled = true;
            //btnAdd.Enabled = true;
            //btnRemove.Enabled = true;
            btnSave.Enabled = true;
            btnEditChild.Enabled = true;
            if (stus == enumAction.NONE)
            {
                btnNew.Text = "Mới";
                btnNewChild.Text = "Mới";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iNew;
                btnNewChild.Image = global::LeMaiDesktop.Properties.Resources.iNew;
                txtSoHoaDon.Enabled = false;
                dtpNgayHoaDon.Enabled = false;
                txtSoTienThu.Enabled = false;
                txtSoTienChi.Enabled = false;
                txtLyDoChi.Enabled = false;
                txtLyDoThu.Enabled = false;
                txtSoChungTuThu.Enabled = false;
                txtSoChungTuChi.Enabled = false;
                dtpThangKT.Enabled = false;
                cmbKyKetToan.Enabled = false;
                txtNguoiMuaHang.Enabled = false;
                txtDonViMuaHang.Enabled = false;
                txtMaSoThue.Enabled = false;
                txtDiaChi.Enabled = false;
                txtSubBILL_CODE.Enabled = false;
                txtSubSoTienPhaiThu.Enabled = false;
                txtSubSoTienPhaiChi.Enabled = false;
                txtSubTenNguoiNhan.Enabled = false;
                txtSubSoDienThoaiNhan.Enabled = false;
                txtSubDiaChiNhan.Enabled = false;
                txtSubSoTienThuHo.Enabled = false;
                txtSubCuocPhiVanChuyen.Enabled = false;
                txtSubTenHang.Enabled = false;
                txtSubTrongLuong.Enabled = false;
                txtSubCuocPhiChuaGTGT.Enabled = false;
                txtSubThueGTGT.Enabled = false;
                txtSubLoaiTT.Enabled = false;
                dtpSubNgayGuiHang.Enabled = false;
            }
            if (stus == enumAction.NEW)
            {
                btnNew.Enabled = true;
                btnNew.Text = "Bỏ qua";
                btnNewChild.Text = "Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                btnNewChild.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                txtSoHoaDon.Enabled = true;
                dtpNgayHoaDon.Enabled = true;
                txtSoTienThu.Enabled = true;
                txtSoTienChi.Enabled = true;
                txtLyDoChi.Enabled = true;
                txtLyDoThu.Enabled = true;
                txtSoChungTuThu.Enabled = true;
                txtSoChungTuChi.Enabled = true;
                dtpThangKT.Enabled = true;
                cmbKyKetToan.Enabled = true;
                txtNguoiMuaHang.Enabled = true;
                txtDonViMuaHang.Enabled = true;
                txtMaSoThue.Enabled = true;
                txtDiaChi.Enabled = true;
                txtSubBILL_CODE.Enabled = true;
                txtSubSoTienPhaiThu.Enabled = true;
                txtSubSoTienPhaiChi.Enabled = true;
                txtSubTenNguoiNhan.Enabled = true;
                txtSubSoDienThoaiNhan.Enabled = true;
                txtSubDiaChiNhan.Enabled = true;
                txtSubSoTienThuHo.Enabled = true;
                txtSubCuocPhiVanChuyen.Enabled = true;
                txtSubTenHang.Enabled = true;
                txtSubTrongLuong.Enabled = true;
                txtSubCuocPhiChuaGTGT.Enabled = true;
                txtSubThueGTGT.Enabled = true;
                txtSubLoaiTT.Enabled = true;
                dtpSubNgayGuiHang.Enabled = true;
            }
            if (stus == enumAction.UPDATE)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnNew.Enabled = true;
                btnNew.Text = "Bỏ qua";
                btnNewChild.Text = "Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                btnNewChild.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                txtSoHoaDon.Enabled = true;
                dtpNgayHoaDon.Enabled = true;
                txtSoTienThu.Enabled = true;
                txtSoTienChi.Enabled = true;
                txtLyDoChi.Enabled = true;
                txtLyDoThu.Enabled = true;
                txtSoChungTuThu.Enabled = true;
                txtSoChungTuChi.Enabled = true;
                dtpThangKT.Enabled = true;
                cmbKyKetToan.Enabled = true;
                txtNguoiMuaHang.Enabled = true;
                txtDonViMuaHang.Enabled = true;
                txtMaSoThue.Enabled = true;
                txtDiaChi.Enabled = true;
                txtSubBILL_CODE.Enabled = true;
                txtSubSoTienPhaiThu.Enabled = true;
                txtSubSoTienPhaiChi.Enabled = true;
                txtSubTenNguoiNhan.Enabled = true;
                txtSubSoDienThoaiNhan.Enabled = true;
                txtSubDiaChiNhan.Enabled = true;
                txtSubSoTienThuHo.Enabled = true;
                txtSubCuocPhiVanChuyen.Enabled = true;
                txtSubTenHang.Enabled = true;
                txtSubTrongLuong.Enabled = true;
                txtSubCuocPhiChuaGTGT.Enabled = true;
                txtSubThueGTGT.Enabled = true;
                txtSubLoaiTT.Enabled = true;
                dtpSubNgayGuiHang.Enabled = true;
            }
        }
        // Xóa trắng tất cả các textbox.
        private void ClearText()
        {
            txtSoHoaDon.Text = string.Empty;
            txtSoTienThu.Text = "0";
            txtSoTienChi.Text = "0";
            txtLyDoChi.Text = string.Empty;
            txtLyDoThu.Text = string.Empty;
            txtSoChungTuThu.Text = string.Empty;
            txtSoChungTuChi.Text = string.Empty;
            txtNguoiMuaHang.Text = string.Empty;
            txtDonViMuaHang.Text = string.Empty;
            txtMaSoThue.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
        }
        private void ClearTextSubItem()
        {
            txtSubBILL_CODE.Text = string.Empty;
            txtSubSoTienPhaiThu.Text = string.Empty;
            txtSubSoTienPhaiChi.Text = string.Empty;
            txtSubTenNguoiNhan.Text = string.Empty;
            txtSubSoDienThoaiNhan.Text = string.Empty;
            txtSubDiaChiNhan.Text = string.Empty;
            txtSubSoTienThuHo.Text = string.Empty;
            txtSubCuocPhiVanChuyen.Text = string.Empty;
            txtSubTenHang.Text = string.Empty;
            txtSubTrongLuong.Text = string.Empty;
            txtSubCuocPhiChuaGTGT.Text = string.Empty;
            txtSubThueGTGT.Text = string.Empty;
            txtSubLoaiTT.Text = string.Empty;
        }
        private void FillDataChildItem(view_ExpChungTuCt item, bool copy)
        {
            txtSubBILL_CODE.Text = item.BILL_CODE;
            txtSubSoTienPhaiThu.Text = item.SoTienPhaiThu.ToString();
            txtSubSoTienPhaiChi.Text = item.SoTienPhaiChi.ToString();
            txtSubTenNguoiNhan.Text = item.TenNguoiNhan;
            txtSubSoDienThoaiNhan.Text = item.SoDienThoaiNhan;
            txtSubDiaChiNhan.Text = item.DiaChiNhan;
            txtSubSoTienThuHo.Text = item.SoTienThuHo.ToString();
            txtSubCuocPhiVanChuyen.Text = item.CuocPhiVanChuyen.ToString();
            txtSubTenHang.Text = item.TenHang;
            txtSubTrongLuong.Text = item.TrongLuong.ToString();
            txtSubCuocPhiChuaGTGT.Text = item.CuocPhiChuaGTGT.ToString();
            txtSubThueGTGT.Text = item.ThueGTGT.ToString();
            dtpSubNgayGuiHang.Value = item.NgayGuiHang;
            txtSubLoaiTT.Text = item.LoaiThanhToan;
        }
        private void FillData(view_ExpChungTu item, bool copy)
        {
            txtSoHoaDon.Text = item.SoHoaDon;
            dtpNgayHoaDon.Value = item.NgayHoaDon;
            txtSoTienThu.Text = item.SoTienThu.ToString();
            txtSoTienChi.Text = item.SoTienChi.ToString();
            txtLyDoChi.Text = item.LyDoChi;
            txtLyDoThu.Text = item.LyDoThu;
            txtSoChungTuThu.Text = item.SoChungTuThu;
            txtSoChungTuChi.Text = item.SoChungTuChi;
            dtpThangKT.Value = item.ThangKT;
            cmbKyKetToan.SelectedValue = item.FK_KyKetToan;
            txtNguoiMuaHang.Text = item.NguoiMuaHang;
            txtDonViMuaHang.Text = item.DonViMuaHang;
            txtMaSoThue.Text = item.MaSoThue;
            txtDiaChi.Text = item.DiaChi;
            dtpNgayChungTu.Value = item.NgayChungTu;
            txtVAT.Text = PCommon.FormatNumber(item.ThueVAT.ToString());
            txtPhiVC.Text = PCommon.FormatNumber(item.TongPhiVanChuyen.ToString());
        }
        private void gridParrent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit_Click(null, null);
        }

        private async void gridMain_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Edit child item
            try
            {
                int index = gridChild.SelectedRows[0].Index;
                string FK_ExpChungTu = Convert.ToString(gridChild.Rows[index].Cells["col_SubFK_ExpChungTu"].Value);
                string BILL_CODE = Convert.ToString(gridChild.Rows[index].Cells["col_SubBILL_CODE"].Value);
                GitemChild = await _logic.GetChildDetails(FK_ExpChungTu, BILL_CODE);
                if (null != GitemChild)
                {
                    FillDataChildItem(GitemChild, false);
                    btnEditChild.Enabled = true;
                    //btnAdd.Enabled = false;
                    //btnRemove.Enabled = false;
                    btnSave.Enabled = false;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }

        }

        private void gridMain_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private async void btnEditChild_Click(object sender, EventArgs e)
        {
            if (Gitem.IsPhatHanh == true)
            {
                MessageBox.Show("Chứng từ đã phát hành, không cho phép chỉnh sửa?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(txtSubBILL_CODE.Text))
            {
                MessageBox.Show("Mã vận đơn không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubBILL_CODE.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubSoTienPhaiThu.Text))
            {
                MessageBox.Show("Số tiền phải thu không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubSoTienPhaiThu.Focus();
                return;
            }
            if (txtSubSoTienPhaiThu.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("Số tiền phải thu không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubSoTienPhaiThu.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubSoTienPhaiChi.Text))
            {
                MessageBox.Show("Số tiền phải chi không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubSoTienPhaiChi.Focus();
                return;
            }
            if (txtSubSoTienPhaiChi.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("Số tiền phải chi không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubSoTienPhaiChi.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubTenNguoiNhan.Text))
            {
                MessageBox.Show("Tên người nhận không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubTenNguoiNhan.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubSoDienThoaiNhan.Text))
            {
                MessageBox.Show("Số điện thoại người nhận không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubSoDienThoaiNhan.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubDiaChiNhan.Text))
            {
                MessageBox.Show("Địa chỉ người nhận không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubDiaChiNhan.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubSoTienThuHo.Text))
            {
                MessageBox.Show("Số tiền thu hộ không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubSoTienThuHo.Focus();
                return;
            }
            if (txtSubSoTienThuHo.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("Số tiền thu hộ không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubSoTienThuHo.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubCuocPhiVanChuyen.Text))
            {
                MessageBox.Show("Cước vận chuyển không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubCuocPhiVanChuyen.Focus();
                return;
            }
            if (txtSubCuocPhiVanChuyen.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("Cước vận chuyển không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubCuocPhiVanChuyen.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubTenHang.Text))
            {
                MessageBox.Show("Tên hàng hóa không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubTenHang.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubTrongLuong.Text))
            {
                MessageBox.Show("Trọng lượng không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubTrongLuong.Focus();
                return;
            }
            if (txtSubTrongLuong.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("Trọng lượng không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubTrongLuong.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubCuocPhiChuaGTGT.Text))
            {
                MessageBox.Show("Cước phí chưa GTGT không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubCuocPhiChuaGTGT.Focus();
                return;
            }
            if (txtSubCuocPhiChuaGTGT.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("Cước phí chưa GTGT không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubCuocPhiChuaGTGT.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSubThueGTGT.Text))
            {
                MessageBox.Show("Thuế GTGT không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubThueGTGT.Focus();
                return;
            }
            if (txtSubThueGTGT.Text.Equals("0" + GdecimalString))
            {
                MessageBox.Show("Thuế GTGT không hợp lệ?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubThueGTGT.Focus();
                return;
            }
            // Edit child
            if (GitemChild != null)
            {

                childPhatHanhChungTuLogicInputDto childItem = new childPhatHanhChungTuLogicInputDto();
                childItem.BILL_CODE = txtSubBILL_CODE.Text;
                childItem.SoTienPhaiThu = decimal.Parse(txtSubSoTienPhaiThu.Text, CultureInfo.CurrentCulture);
                childItem.SoTienPhaiChi = decimal.Parse(txtSubSoTienPhaiChi.Text, CultureInfo.CurrentCulture);
                childItem.TenNguoiNhan = txtSubTenNguoiNhan.Text;
                childItem.SoDienThoaiNhan = txtSubSoDienThoaiNhan.Text;
                childItem.DiaChiNhan = txtSubDiaChiNhan.Text;
                childItem.SoTienThuHo = decimal.Parse(txtSubSoTienThuHo.Text, CultureInfo.CurrentCulture);
                childItem.CuocPhiVanChuyen = decimal.Parse(txtSubCuocPhiVanChuyen.Text, CultureInfo.CurrentCulture);
                childItem.TenHang = txtSubTenHang.Text;
                childItem.TrongLuong = decimal.Parse(txtSubTrongLuong.Text, CultureInfo.CurrentCulture);
                childItem.IsPhatHanh = false;
                childItem.CuocPhiChuaGTGT = decimal.Parse(txtSubCuocPhiChuaGTGT.Text, CultureInfo.CurrentCulture);
                childItem.ThueGTGT = decimal.Parse(txtSubThueGTGT.Text, CultureInfo.CurrentCulture);
                childItem.NgayGuiHang = dtpSubNgayGuiHang.Value;
                await _logic.CreateOrUpdateChildOnly(GitemChild.FK_ExpChungTu, GitemChild.BILL_CODE, childItem);
                _logicChungTu.TotalCalculatorChungTu(GitemChild.FK_ExpChungTu);
            }
            GitemChild = null;
            //
            ClearTextSubItem();
            LoadDataChildItem();
            btnEditChild.Enabled = false;
            //btnAdd.Enabled = true;
            //btnRemove.Enabled = true;
            btnSave.Enabled = true;
        }


        private void frmPhatHanhChungTu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (edited != enumEdit.NONE)
            {
                DialogResult dialogResult = MessageBox.Show("", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo);
                e.Cancel = (dialogResult == DialogResult.No);
            }
        }

        private void txtSoHoaDon_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void dtpNgayHoaDon_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtSoTienThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Curency_KeyPress(sender, e);
        }
        private void txtSoTienThu_KeyUp(object sender, KeyEventArgs e)
        {
            base.Curency_KeyUp(sender, e);
        }
        private void txtSoTienChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Curency_KeyPress(sender, e);
        }
        private void txtSoTienChi_KeyUp(object sender, KeyEventArgs e)
        {
            base.Curency_KeyUp(sender, e);
        }
        private void txtLyDoChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtLyDoThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtSoChungTuThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtSoChungTuChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtFK_Account_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void dtpThangKT_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtFK_KyKetToan_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtNguoiMuaHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtDonViMuaHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtMaSoThue_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtSubFK_ExpChungTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtSubBILL_CODE_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtSubSoTienPhaiThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Curency_KeyPress(sender, e);
        }
        private void txtSubSoTienPhaiThu_KeyUp(object sender, KeyEventArgs e)
        {
            base.Curency_KeyUp(sender, e);
        }
        private void txtSubSoTienPhaiChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Curency_KeyPress(sender, e);
        }
        private void txtSubSoTienPhaiChi_KeyUp(object sender, KeyEventArgs e)
        {
            base.Curency_KeyUp(sender, e);
        }
        private void txtSubTenNguoiNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtSubSoDienThoaiNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtSubDiaChiNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtSubSoTienThuHo_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Curency_KeyPress(sender, e);
        }
        private void txtSubSoTienThuHo_KeyUp(object sender, KeyEventArgs e)
        {
            base.Curency_KeyUp(sender, e);
        }
        private void txtSubCuocPhiVanChuyen_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Curency_KeyPress(sender, e);
        }
        private void txtSubCuocPhiVanChuyen_KeyUp(object sender, KeyEventArgs e)
        {
            base.Curency_KeyUp(sender, e);
        }
        private void txtSubTenHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtSubTrongLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Curency_KeyPress(sender, e);
        }
        private void txtSubTrongLuong_KeyUp(object sender, KeyEventArgs e)
        {
            base.Curency_KeyUp(sender, e);
        }
        private void txtSubCuocPhiChuaGTGT_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Curency_KeyPress(sender, e);
        }
        private void txtSubCuocPhiChuaGTGT_KeyUp(object sender, KeyEventArgs e)
        {
            base.Curency_KeyUp(sender, e);
        }
        private void txtSubThueGTGT_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Curency_KeyPress(sender, e);
        }
        private void txtSubThueGTGT_KeyUp(object sender, KeyEventArgs e)
        {
            base.Curency_KeyUp(sender, e);
        }
        private void dtpSubNgayGuiHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }


        private void btnPhatHanhChungTu_Click(object sender, EventArgs e)
        {
            // Phát hành chứng từ
            if (Gitem != null)
            {
                string mess = _logicChungTu.PhatHanhChungTu(Gitem.Id, PBean.USER.CardId, PBean.USER.Id, PBean.USER.FullName);
                if (!string.IsNullOrEmpty(mess))
                {
                    MessageBox.Show(mess, PBean.MESSAGE_TITLE);
                }
                else
                {
                    MessageBox.Show("Phát hành chứng từ thành công!", PBean.MESSAGE_TITLE);
                }
            }
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            // Lập hóa đơn, kết nối API
            if (Gitem != null)
            {
                view_ExpChungTu chungtu = _logicChungTu.GetChungTu(Gitem.Id);
                //ReturnResultCreateInvoice result = _invoice.CreateInvoice(chungtu, DateTime.Now, "CÔNG TY TNHH THƯƠNG MẠI DỊCH VỤ PHÁT TRIỂN LÊ MAI", "1402180322", "ấp Tân Thành, xã Tân Quy Tây, TP Sa Đéc, Đồng Tháp", "0934090231", "hongquanov@gmail.com", "D:\\HOADON");
                //if (result.CreateSuccess)
                //{
                //    // Cập nhật số hóa đơn
                //    bool updateHD = _logicChungTu.UpdateHoaDonDienTu(Gitem.Id, result.SoHoaDon, result.NgayHoaDon);
                //}
                //else
                //{
                //    MessageBox.Show(result.Message, PBean.MESSAGE_TITLE);
                //}
            }
        }
        private void btnPrintChild_Click(object sender, EventArgs e)
        {
            // Print
            if (Gitem != null)
            {
                DataTable printKetQua = _logicChungTu.GetChiTietBangKe(Gitem.Id);
                Common.Report.LVReport report = new Common.Report.LVReport();
                string reportFile = AppDomain.CurrentDomain.BaseDirectory + PConstants.FOLDER_REPORT.TrimEnd('\\') + "\\BangKeHoaDon.rpt";
                report.ShowReport(reportFile, "A4", false, "Bảng kê hóa đơn", PBean.MESSAGE_TITLE, printKetQua, true, false);
            }
            else
            {
                MessageBox.Show("Không thấy dữ liệu cần in", PBean.MESSAGE_TITLE);
            }

        }

        private void btnPrintChildPC_Click(object sender, EventArgs e)
        {
            if (Gitem != null)
            {
                // Phiếu chi COD
                DataTable printKetQua = _logicChungTu.GetPhieuChi(Gitem.Id);
                Common.Report.LVReport report = new Common.Report.LVReport();
                string bangchu = PCommon.ChuyenSoThanhChu(printKetQua.Rows[0]["SoTienChi"].ToString());
                string reportFile = AppDomain.CurrentDomain.BaseDirectory + PConstants.FOLDER_REPORT.TrimEnd('\\') + "\\PhieuChi.rpt";
                report.ShowReport(reportFile, "A5", true, "Phiếu chi tiền thu hộ", PBean.MESSAGE_TITLE, printKetQua, true, false, "bangchu", bangchu);
            }
            else
            {
                MessageBox.Show("Không thấy dữ liệu cần in", PBean.MESSAGE_TITLE);
            }

        }

        private void btnPrintChildBBCTCN_Click(object sender, EventArgs e)
        {
            if (Gitem != null)
            {
                DataTable printKetQua = _logicChungTu.GetPhieuChi(Gitem.Id);
                Common.Report.LVReport report = new Common.Report.LVReport();
                string bangchuphiVC = PCommon.ChuyenSoThanhChu(printKetQua.Rows[0]["TongPhiGuiTra"].ToString());
                string bangchuThuHo = PCommon.ChuyenSoThanhChu(printKetQua.Rows[0]["TongThuHo"].ToString());
                string bangchuConLai = PCommon.ChuyenSoThanhChu(printKetQua.Rows[0]["SoTienChi"].ToString());
                string SoTienConLai = "";
                string benconno = "";
                decimal SoTienThu = decimal.Parse(printKetQua.Rows[0]["SoTienThu"].ToString());
                decimal SoTienChi = decimal.Parse(printKetQua.Rows[0]["SoTienChi"].ToString());
                if (SoTienChi > SoTienThu)
                {
                    SoTienConLai = PCommon.FormatNumber(SoTienChi.ToString());
                    benconno = "bên B còn nợ bên A ";
                }
                else
                {
                    SoTienConLai = PCommon.FormatNumber(SoTienThu.ToString());
                    benconno = "bên A còn nợ bên B ";
                }

                string reportFile = AppDomain.CurrentDomain.BaseDirectory + PConstants.FOLDER_REPORT.TrimEnd('\\') + "\\BienBanCanTruCongNo.rpt";
                report.ShowReport(reportFile, "A4", false, "Biên bản cấn trừ công nợ", PBean.MESSAGE_TITLE, printKetQua, true, false,
                    "bangchuphiVC", bangchuphiVC,
                    "bangchuThuHo", bangchuThuHo,
                    "bangchuConLai", bangchuConLai,
                    "SoTienConLai", SoTienConLai,
                    "benconno", benconno);
            }
            else
            {
                MessageBox.Show("Không thấy dữ liệu cần in", PBean.MESSAGE_TITLE);
            }

        }

        private void btnInSoChiKL_Click(object sender, EventArgs e)
        {
            if (Gitem != null)
            {
                // Phiếu chi COD
                DataTable printKetQua = _logicChungTu.GetChiTietBangKe(Gitem.Id);
                Common.Report.LVReport report = new Common.Report.LVReport();
                string reportFile = AppDomain.CurrentDomain.BaseDirectory + PConstants.FOLDER_REPORT.TrimEnd('\\') + "\\SoChiTien.rpt";
                report.ShowReport(reportFile, "A4", true, "Sổ chi tiền thu hộ", PBean.MESSAGE_TITLE, printKetQua, true, false);
            }
            else
            {
                MessageBox.Show("Không thấy dữ liệu cần in", PBean.MESSAGE_TITLE);
            }
        }

        private void btnInPhieuChiKhachLe_Click(object sender, EventArgs e)
        {
            if (Gitem != null)
            {
                // Phiếu chi COD
                DataTable printKetQua = _logicChungTu.GetPhieuChi(Gitem.Id);
                Common.Report.LVReport report = new Common.Report.LVReport();
                string bangchu = PCommon.ChuyenSoThanhChu(printKetQua.Rows[0]["TongThuHo"].ToString());
                string reportFile = AppDomain.CurrentDomain.BaseDirectory + PConstants.FOLDER_REPORT.TrimEnd('\\') + "\\PhieuChiKL.rpt";
                report.ShowReport(reportFile, "A5", true, "Phiếu chi tiền thu hộ", PBean.MESSAGE_TITLE, printKetQua, true, false, "bangchu", bangchu);
            }
            else
            {
                MessageBox.Show("Không thấy dữ liệu cần in", PBean.MESSAGE_TITLE);
            }
        }

        private void btnTruyVanDonChuaPhatHanh_Click(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private void btnXoaToanBoChungTu_Click(object sender, EventArgs e)
        {
            // Xóa toàn bộ chứng từ
            if (MessageBox.Show("Bạn có chắc chắn là mình muốn xóa toàn bộ chứng từ của kỳ kết toán [" + cmbKyChungTu.Text + "] không?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string mess = _logic.DeleteAllChungTu(cmbKyChungTu.SelectedValue.ToString());
                MessageBox.Show(mess, PBean.MESSAGE_TITLE);
                LoadGridData();
            }
        }

        private void menuChuyenKy_Click(object sender, EventArgs e)
        {
            string name;
            string IdA = GetIdChungTu(out name);
            frmLuaChonKyKetToan frm = new frmLuaChonKyKetToan();
            frm.ShowDialog();
            string IdKyKetToan = frm.IdKyKetToan;
            string mess = _logic.ChuyenDoiKyKetToan(IdA, IdKyKetToan);
            MessageBox.Show(mess, PBean.MESSAGE_TITLE);
            LoadGridData();
        }

        private void menuGopChiTiet_Click(object sender, EventArgs e)
        {
            string name;
            if (!string.IsNullOrEmpty(_SelectChungTuId))
            {
                string IdA = GetIdChungTu(out name);
                if (MessageBox.Show("Bạn có chắc gộp chi tiết chứng từ [" + name + "] vào chứng từ [" + _SelectChungTuName + "]?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mess = _logic.GopChiTietChungTu(IdA, _SelectChungTuId);
                    MessageBox.Show(mess, PBean.MESSAGE_TITLE);
                    LoadGridData();
                }
            }
            else
            {
                MessageBox.Show("Chọn chứng từ cần gộp trước!", PBean.MESSAGE_TITLE);
            }
        }

        private void menuGopCOD_Click(object sender, EventArgs e)
        {
            string name;
            if (!string.IsNullOrEmpty(_SelectChungTuId))
            {
                string IdA = GetIdChungTu(out name);
                if (MessageBox.Show("Bạn có chắc gộp COD chứng từ [" + name + "] vào chứng từ [" + _SelectChungTuName + "]?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mess = _logic.GopCODChungTu(IdA, _SelectChungTuId);
                    MessageBox.Show(mess, PBean.MESSAGE_TITLE);
                    LoadGridData();
                }
            }
            else
            {
                MessageBox.Show("Chọn chứng từ cần gộp trước!", PBean.MESSAGE_TITLE);
            }
        }

        private void menuRemove_Click(object sender, EventArgs e)
        {
            string name;
            string IdA = GetIdChungTu(out name);
            if (MessageBox.Show("Bạn có muốn xóa chứng từ [" + name + "]?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Xóa chứng từ
                string mess = _logic.RemoveChungTu(IdA);
                MessageBox.Show(mess, PBean.MESSAGE_TITLE);
                LoadGridData();
            }
        }

        private void menuSkip_Click(object sender, EventArgs e)
        {
            string name;
            string IdA = GetIdChungTu(out name);
            if (MessageBox.Show("Bạn có muốn bỏ qua chứng từ [" + name + "]?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Bỏ qua chứng từ
                string mess = _logic.SkipChungTu(IdA);
                MessageBox.Show(mess, PBean.MESSAGE_TITLE);
                LoadGridData();
            }
        }

        private void menuSelect_Click(object sender, EventArgs e)
        {
            _SelectChungTuId = GetIdChungTu(out _SelectChungTuName);
        }
        private void menuUnSelect_Click(object sender, EventArgs e)
        {
            _SelectChungTuId = string.Empty;
            _SelectChungTuName = string.Empty;
        }
        private string GetIdChungTu(out string Name)
        {
            try
            {
                int index = gridParrent.SelectedRows[0].Index;
                string Id = Convert.ToString(gridParrent.Rows[index].Cells["col_Id"].Value);
                Name = Convert.ToString(gridParrent.Rows[index].Cells["colTenKhachHang"].Value);
                return Id;
            }
            catch (ArgumentOutOfRangeException)
            {
                Name = string.Empty;
                return string.Empty;
            }
        }

        private async void btnXuatExcelKT_Click(object sender, EventArgs e)
        {
            // Xuất dữ liệu excel để kiểm tra tính đúng đắn trước khi phát hành.
            if (Gitem != null)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = "CHUNG_TU";
                save.Filter = "Excel Files | *.xlsx";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string templateFileName = AppDomain.CurrentDomain.BaseDirectory + "Templates\\CHUNG_TU.xlsx";
                    Dictionary<string, string> lsReplace = new Dictionary<string, string>();
                    lsReplace.Add("NGAY_CT", string.Format("{0:dd/MM/yyyy}", Gitem.NgayChungTu));
                    lsReplace.Add("TONG_CHUA_VAT", Gitem.TongPhiChuaVAT.ToString());
                    lsReplace.Add("THUE_VAT", Gitem.ThueVAT.ToString());
                    lsReplace.Add("TONG_TIEN", Gitem.TongPhiVanChuyen.ToString());
                    Dictionary<string, string> lsTitile = new Dictionary<string, string>();
                    var childs = await _logic.GetChildList(Gitem.Id);
                    DataTable data = MapperExtensionClass.ToDataTable<view_ExpChungTuCt>(childs);
                    ExportDataToExcelTemplate.Export(templateFileName, save.FileName, 1, data, lsTitile, lsReplace);
                    MessageBox.Show("Xuất file excel thành công!", PBean.MESSAGE_TITLE);
                }
            }

        }

        private void btnHuyPhatHanh_Click(object sender, EventArgs e)
        {
            // Phát hành chứng từ
            if (Gitem != null)
            {
                string mess = _logicChungTu.HuyPhatHanhChungTu(Gitem.Id, PBean.USER.CardId, PBean.USER.Id, PBean.USER.FullName);
                if (!string.IsNullOrEmpty(mess))
                {
                    MessageBox.Show(mess, PBean.MESSAGE_TITLE);
                }
                else
                {
                    MessageBox.Show("Hủy phát hành chứng từ thành công!", PBean.MESSAGE_TITLE);
                }
            }
        }

        private void btnCopyNote_Click(object sender, EventArgs e)
        {
            if (Gitem != null)
            {
                Clipboard.SetText("Cước dịch vụ chuyển phát nhanh (Đính kèm bảng kê chi tiết cước vận chuyển số " + Gitem.SoChungTuThu + " ngày " + string.Format("{0:dd/MM/yyyy}", Gitem.NgayChungTu) + ")");
            }

        }

        private void btnCopySoTien_Click(object sender, EventArgs e)
        {
            if (Gitem != null)
            {
                Clipboard.SetText(Gitem.TongPhiChuaVAT.ToString());
            }
        }
    }
}
