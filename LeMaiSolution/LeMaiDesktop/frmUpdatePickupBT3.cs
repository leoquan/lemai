using Common;
using LeMaiDomain;
using LeMaiLogic.Logic;
using NPOI.SS.Util;
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
    public partial class frmUpdatePickupBT3 : frmBase
    {
        private GExpBillLogic _logic = new GExpBillLogic(PBean.ConnectionBase);
        public string customerId { get; set; }
        public PickupAddressItem pickupAddress = new PickupAddressItem();
        public string FullAddress { get; set; }
        public frmUpdatePickupBT3() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            pickupAddress.ProvincePickup = cmbTinhNhan.SelectedValue.ToString();
            pickupAddress.DistrictPickup = cmbHuyenNhan.SelectedValue.ToString();
            pickupAddress.WardPickup = cmbXaNhan.SelectedValue.ToString();
            pickupAddress.Address = txtSoNhaNguoiGui.Text;
            FullAddress = txtSoNhaNguoiGui.Text + ", " + cmbXaNhan.Text + ", " + cmbHuyenNhan.Text + ", " + cmbTinhNhan.Text;
            DialogResult = DialogResult.OK;
        }

        private async void frmUpdatePickupBT3_Load(object sender, EventArgs e)
        {
            if (pickupAddress.IsUpdate == false)
            {
                var _listProvince = await _logic.GetDanhSachTinh();
                cmbTinhNhan.DataSource = _listProvince;
                cmbTinhNhan.DisplayMember = "ProvinceName";
                cmbTinhNhan.ValueMember = "ProvinceID";
                ExpPost post = _logic.GetPostDetail(PBean.USER.CardId);
                if (post != null)
                {
                    cmbTinhNhan.SelectedValue = post.FK_DVHC;
                    var listDist = await _logic.GetDanhSachHuyen(post.FK_DVHC.ToString());
                    cmbHuyenNhan.DataSource = listDist;
                    cmbHuyenNhan.DisplayMember = "DistrictName";
                    cmbHuyenNhan.ValueMember = "DistrictID";
                    if (listDist.Count > 0)
                    {
                        cmbXaNhan.DataSource = await _logic.GetDanhSachXa(listDist[0].DistrictID.ToString());
                        cmbXaNhan.DisplayMember = "WardName";
                        cmbXaNhan.ValueMember = "WardId";
                    }
                }
                txtSoNhaNguoiGui.Text = string.Empty;
            }
            else
            {
                var _listProvince = await _logic.GetDanhSachTinh();
                cmbTinhNhan.DataSource = _listProvince;
                cmbTinhNhan.DisplayMember = "ProvinceName";
                cmbTinhNhan.ValueMember = "ProvinceID";
                cmbTinhNhan.SelectedValue = Int32.Parse(pickupAddress.ProvincePickup);

                var listDist = await _logic.GetDanhSachHuyen(pickupAddress.ProvincePickup);
                cmbHuyenNhan.DataSource = listDist;
                cmbHuyenNhan.DisplayMember = "DistrictName";
                cmbHuyenNhan.ValueMember = "DistrictID";
                cmbHuyenNhan.SelectedValue = Int32.Parse(pickupAddress.DistrictPickup);

                cmbXaNhan.DataSource = await _logic.GetDanhSachXa(listDist[0].DistrictID.ToString());
                cmbXaNhan.DisplayMember = "WardName";
                cmbXaNhan.ValueMember = "WardId";
                cmbXaNhan.SelectedValue = pickupAddress.WardPickup;

                txtSoNhaNguoiGui.Text = pickupAddress.Address;
            }
        }

        private async void cmbTinhNhan_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ActiveControl == sender)
            {
                if (cmbTinhNhan.SelectedValue != null)
                {
                    cmbHuyenNhan.DataSource = await _logic.GetDanhSachHuyen(cmbTinhNhan.SelectedValue.ToString());
                    cmbHuyenNhan.DisplayMember = "DistrictName";
                    cmbHuyenNhan.ValueMember = "DistrictID";
                }
            }

        }

        private async void cmbHuyenNhan_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ActiveControl == sender)
            {
                if (cmbHuyenNhan.SelectedValue != null)
                {
                    cmbXaNhan.DataSource = await _logic.GetDanhSachXa(cmbHuyenNhan.SelectedValue.ToString());
                    cmbXaNhan.DisplayMember = "WardName";
                    cmbXaNhan.ValueMember = "WardId";
                }
            }
        }
    }
}
