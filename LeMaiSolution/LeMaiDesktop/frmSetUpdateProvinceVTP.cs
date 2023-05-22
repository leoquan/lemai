using Common;
using LeMaiLogic;
using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using DevComponents.WinForms.Drawing;
using RestSharp;
using System.Net;

namespace LeMaiDesktop
{

    public partial class frmSetUpdateProvinceVTP : frmBase
    {
        string _token = "eyJhbGciOiJFUzI1NiJ9.eyJzdWIiOiIwOTM0MDkwMjMxIiwiVXNlcklkIjo1NjUwOTg3LCJGcm9tU291cmNlIjo1LCJUb2tlbiI6IjYwTFpRNVVaN0NRMDhBIiwiZXhwIjoxNjgxMjI3NDQyLCJQYXJ0bmVyIjo1NjUwOTg3fQ.i5S2q0s1NSY6Ruh_UOWhMG44Vr-aAZKLJ_dwLgdkgMzuAuHZCi9sMpv6aipYbGLIeqBgjVTb3tYDthgpOzoKrw";
        int LoaiDuLieu = -1;
        List<GExpProvince> _lsProvince = new List<GExpProvince>();
        List<GExpDistrict> _lsDistrict = new List<GExpDistrict>();
        List<GExpWard> _lsWard = new List<GExpWard>();
        public frmSetUpdateProvinceVTP() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IDataContext dc = new dcDataContextM(PBean.CONNECTION_STRING);
            try
            {
                dc.Open();
                if (LoaiDuLieu == 0)
                {
                    // Cập nhật tỉnh
                    for (int i = 0; i < gridata.Rows.Count; i++)
                    {
                        string provinceVNPTId = gridata.Rows[i].Cells["col_Code"].Value.ToString();
                        if (gridata.Rows[i].Cells["col_Select"].Value != null)
                        {
                            string provinceId = gridata.Rows[i].Cells["col_Select"].Value.ToString();
                            GExpProvinceVTP provincevnp = dc.GExpprovincevtp.GetObject(PBean.SCHEMA, provinceVNPTId);
                            if (provincevnp != null)
                            {
                                provincevnp.ProvinceID = Int32.Parse(provinceId);
                                dc.GExpprovincevtp.Update(PBean.SCHEMA, provincevnp);
                            }
                        }

                    }
                }
                else if (LoaiDuLieu == 1)
                {
                    // Cập nhật huyện
                    for (int i = 0; i < gridata.Rows.Count; i++)
                    {
                        string districtVNPTId = gridata.Rows[i].Cells["col_Code"].Value.ToString();
                        if (gridata.Rows[i].Cells["col_Select"].Value != null)
                        {
                            string districtId = gridata.Rows[i].Cells["col_Select"].Value.ToString();
                            GExpDistrictVTP district = dc.GExpdistrictvtp.GetObject(PBean.SCHEMA, districtVNPTId);
                            if (district != null)
                            {
                                district.DistrictID = Int32.Parse(districtId);
                                dc.GExpdistrictvtp.Update(PBean.SCHEMA, district);
                            }
                        }

                    }
                }
                else if (LoaiDuLieu == 2)
                {
                    // Cập nhật xã
                    for (int i = 0; i < gridata.Rows.Count; i++)
                    {
                        string wardVNPTId = gridata.Rows[i].Cells["col_Code"].Value.ToString();
                        if (gridata.Rows[i].Cells["col_Select"].Value != null)
                        {
                            string wardId = gridata.Rows[i].Cells["col_Select"].Value.ToString();
                            GExpWardVTP ward = dc.GExpwardvtp.GetObject(PBean.SCHEMA, wardVNPTId);
                            if (ward != null)
                            {
                                ward.WardId = wardId.Trim();
                                dc.GExpwardvtp.Update(PBean.SCHEMA, ward);
                            }
                        }

                    }
                }
                dc.SubmitChanges();
                MessageBox.Show("Hoàn thành cập nhật", PBean.MESSAGE_TITLE);
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

        private void btnLoadTinh_Click(object sender, EventArgs e)
        {
            LoaiDuLieu = 0;
            gridata.Columns.Clear();
            IDataContext dc = new dcDataContextM(PBean.CONNECTION_STRING);
            try
            {
                dc.Open();
                DataGridViewTextBoxColumn col_Code = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn col_Name = new DataGridViewTextBoxColumn();

                col_Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
                col_Code.HeaderText = "Mã tỉnh";
                col_Code.Name = "col_Code";
                col_Code.DataPropertyName = "provinceCode";
                col_Code.ReadOnly = true;
                col_Code.Width = 120;
                gridata.Columns.Add(col_Code);

                col_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
                col_Name.HeaderText = "Tên tỉnh";
                col_Name.Name = "col_Name";
                col_Name.DataPropertyName = "provinceName";
                col_Name.ReadOnly = true;
                col_Name.Width = 150;
                gridata.Columns.Add(col_Name);


                List<GExpProvinceVTP> lsProvince = dc.GExpprovincevtp.GetListObjectCon(PBean.SCHEMA, "ORDER BY provinceName");
                DataGridViewComboBoxColumn dgvCmb = new DataGridViewComboBoxColumn();
                dgvCmb.HeaderText = "Tỉnh tương ứng";
                dgvCmb.DataSource = dc.GExpprovince.GetListObjectCon(PBean.SCHEMA, "ORDER BY ProvinceName");
                _lsProvince = dc.GExpprovince.GetListObjectCon(PBean.SCHEMA, "ORDER BY ProvinceName");
                dgvCmb.DisplayMember = "ProvinceName";
                dgvCmb.ValueMember = "ProvinceID";
                dgvCmb.Name = "col_Select";
                dgvCmb.Width = 200;
                dgvCmb.DataPropertyName = "ProvinceID";
                dgvCmb.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                gridata.Columns.Add(dgvCmb);
                gridata.AutoGenerateColumns = false;
                gridata.DataSource = lsProvince;
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

        private void btnLoadHuyen_Click(object sender, EventArgs e)
        {
            LoaiDuLieu = 1;
            gridata.Columns.Clear();
            IDataContext dc = new dcDataContextM(PBean.CONNECTION_STRING);
            try
            {
                dc.Open();

                DataGridViewTextBoxColumn col_Code = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn col_Name = new DataGridViewTextBoxColumn();

                col_Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
                col_Code.HeaderText = "Mã huyện";
                col_Code.Name = "col_Code";
                col_Code.DataPropertyName = "districtCode";
                col_Code.ReadOnly = true;
                col_Code.Width = 120;
                gridata.Columns.Add(col_Code);

                col_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
                col_Name.HeaderText = "Tên huyện";
                col_Name.Name = "col_Name";
                col_Name.DataPropertyName = "districtName";
                col_Name.ReadOnly = true;
                col_Name.Width = 200;
                gridata.Columns.Add(col_Name);

                List<GExpDistrictVTP> lsData = dc.GExpdistrictvtp.GetListObjectCon(PBean.SCHEMA, "WHERE provinceCode=@provinceCode ORDER BY districtName",
                    "@provinceCode", cmbTinh.SelectedValue.ToString());

                DataGridViewComboBoxColumn dgvCmb = new DataGridViewComboBoxColumn();
                dgvCmb.HeaderText = "Huyện tương ứng";
                dgvCmb.DataSource = dc.GExpdistrict.GetListObjectCon(PBean.SCHEMA, " INNER JOIN GExpProvince B ON A.ProvinceID = B.ProvinceID INNER JOIN GExpProvinceVTP C ON C.ProvinceID = B.ProvinceID WHERE C.provinceCode=@provinceCode",
                    "@provinceCode", cmbTinh.SelectedValue.ToString());
                _lsDistrict = dc.GExpdistrict.GetListObjectCon(PBean.SCHEMA, " INNER JOIN GExpProvince B ON A.ProvinceID = B.ProvinceID INNER JOIN GExpProvinceVTP C ON C.ProvinceID = B.ProvinceID WHERE C.provinceCode=@provinceCode",
                    "@provinceCode", cmbTinh.SelectedValue.ToString());

                dgvCmb.DisplayMember = "DistrictName";
                dgvCmb.ValueMember = "DistrictID";
                dgvCmb.Name = "col_Select";
                dgvCmb.Width = 150;
                dgvCmb.DataPropertyName = "DistrictID";
                dgvCmb.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                gridata.Columns.Add(dgvCmb);

                gridata.AutoGenerateColumns = false;
                gridata.DataSource = lsData;
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

        private void btnLoadXa_Click(object sender, EventArgs e)
        {
            LoaiDuLieu = 2;
            gridata.Columns.Clear();
            IDataContext dc = new dcDataContextM(PBean.CONNECTION_STRING);
            try
            {
                dc.Open();
                DataGridViewTextBoxColumn col_Code = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn col_Name = new DataGridViewTextBoxColumn();

                col_Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
                col_Code.HeaderText = "Mã xã";
                col_Code.Name = "col_Code";
                col_Code.DataPropertyName = "communeCode";
                col_Code.ReadOnly = true;
                col_Code.Width = 120;
                gridata.Columns.Add(col_Code);

                col_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
                col_Name.HeaderText = "Tên xã";
                col_Name.Name = "col_Name";
                col_Name.DataPropertyName = "communeName";
                col_Name.ReadOnly = true;
                col_Name.Width = 150;
                gridata.Columns.Add(col_Name);

                List<GExpWardVTP> lsData = dc.GExpwardvtp.GetListObjectCon(PBean.SCHEMA, "WHERE districtCode=@districtCode ORDER BY communeName",
                    "@districtCode", cmbHuyen.SelectedValue.ToString());

                DataGridViewComboBoxColumn dgvCmb = new DataGridViewComboBoxColumn();
                dgvCmb.HeaderText = "Xã tương ứng";
                dgvCmb.DataSource = dc.GExpward.GetListObjectCon(PBean.SCHEMA, " INNER JOIN GExpDistrict B ON A.DistrictID = B.DistrictID INNER JOIN GExpDistrictVTP C ON C.DistrictID = B.DistrictID WHERE C.districtCode=@districtCode",
                    "@districtCode", cmbHuyen.SelectedValue.ToString());
                _lsWard = dc.GExpward.GetListObjectCon(PBean.SCHEMA, " INNER JOIN GExpDistrict B ON A.DistrictID = B.DistrictID INNER JOIN GExpDistrictVTP C ON C.DistrictID = B.DistrictID WHERE C.districtCode=@districtCode",
                    "@districtCode", cmbHuyen.SelectedValue.ToString());
                dgvCmb.DisplayMember = "WardName";
                dgvCmb.ValueMember = "WardId";
                dgvCmb.Name = "col_Select";
                dgvCmb.Width = 200;
                dgvCmb.DataPropertyName = "WardId";
                dgvCmb.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                gridata.Columns.Add(dgvCmb);

                gridata.AutoGenerateColumns = false;
                gridata.DataSource = lsData;
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

        private void frmSetUpdateProvince_Load(object sender, EventArgs e)
        {
            IDataContext dc = new dcDataContextM(PBean.CONNECTION_STRING);
            try
            {
                dc.Open();
                List<GExpProvinceVTP> lsProvince = dc.GExpprovincevtp.GetListObjectCon(PBean.SCHEMA, "ORDER BY provinceName");
                cmbTinh.DataSource = lsProvince;
                cmbTinh.DisplayMember = "provinceName";
                cmbTinh.ValueMember = "provinceCode";
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

        private void cmbTinh_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ActiveControl == cmbTinh)
            {
                if (cmbTinh.SelectedValue != null)
                {
                    IDataContext dc = new dcDataContextM(PBean.CONNECTION_STRING);
                    try
                    {
                        dc.Open();
                        List<GExpDistrictVTP> lsDistrict = dc.GExpdistrictvtp.GetListObjectCon(PBean.SCHEMA, "WHERE provinceCode = @provinceCode ORDER BY districtName",
                            "@provinceCode", cmbTinh.SelectedValue.ToString());
                        cmbHuyen.DataSource = lsDistrict;
                        cmbHuyen.DisplayMember = "districtName";
                        cmbHuyen.ValueMember = "districtCode";
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
            }
        }
        public string GetMapShort(string input)
        {
            string result = PCommon.ConvertToUnSign(input).ToLower().Trim();
            string[] split = result.Split(' ');
            if (split.Length <= 1)
            {
                result = split[0];
            }
            else if (split.Length == 2)
            {
                result = split[1];
            }
            else
            {
                result = split[split.Length - 2] + " " + split[split.Length - 1];
            }
            return result;
        }
        private void btnMap_Click(object sender, EventArgs e)
        {

            if (LoaiDuLieu == 0)
            {
                // Cập nhật tỉnh
                for (int i = 0; i < gridata.Rows.Count; i++)
                {
                    string provinceVNPTId = gridata.Rows[i].Cells["col_Code"].Value.ToString();
                    string provinceVNPTName = gridata.Rows[i].Cells["col_Name"].Value.ToString();
                    provinceVNPTName = GetMapShort(provinceVNPTName);
                    foreach (var item in _lsProvince)
                    {
                        string proName = GetMapShort(item.ProvinceName);
                        if (provinceVNPTName.Equals(proName) == true)
                        {
                            gridata.Rows[i].Cells["col_Select"].Value = item.ProvinceID;
                            break;
                        }
                    }

                }
            }
            else if (LoaiDuLieu == 1)
            {
                // Cập nhật huyện
                for (int i = 0; i < gridata.Rows.Count; i++)
                {
                    string districtVNPTId = gridata.Rows[i].Cells["col_Code"].Value.ToString();
                    string districtVNPTName = gridata.Rows[i].Cells["col_Name"].Value.ToString();
                    districtVNPTName = GetMapShort(districtVNPTName);
                    foreach (var item in _lsDistrict)
                    {
                        string districtName = GetMapShort(item.DistrictName);
                        if (districtVNPTName.Equals(districtName) == true)
                        {
                            gridata.Rows[i].Cells["col_Select"].Value = item.DistrictID;
                            break;
                        }
                    }

                }
            }
            else if (LoaiDuLieu == 2)
            {
                // Cập nhật xã
                for (int i = 0; i < gridata.Rows.Count; i++)
                {
                    string wardVNPTId = gridata.Rows[i].Cells["col_Code"].Value.ToString();
                    string wardVNPTName = gridata.Rows[i].Cells["col_Name"].Value.ToString();
                    wardVNPTName = GetMapShort(wardVNPTName);
                    foreach (var item in _lsWard)
                    {
                        string wardName = GetMapShort(item.WardName);
                        if (wardVNPTName.Equals(wardName) == true)
                        {
                            gridata.Rows[i].Cells["col_Select"].Value = item.WardId;
                            break;
                        }
                    }
                }
            }

        }

        private void btnMapAll_Click(object sender, EventArgs e)
        {
            IDataContext dc = new dcDataContextM(PBean.CONNECTION_STRING);
            try
            {
                dc.Open();
                string error = string.Empty;
                List<GExpDistrictVTP> lsDistrict = dc.GExpdistrictvtp.GetListObjectCon(PBean.SCHEMA, "WHERE provinceCode = @provinceCode ORDER BY districtName",
                    "@provinceCode", cmbTinh.SelectedValue.ToString());
                foreach (var item in lsDistrict)
                {
                    List<GExpWardVTP> lsWardVNP = dc.GExpwardvtp.GetListObjectCon(PBean.SCHEMA, "WHERE districtCode=@districtCode", "@districtCode", item.districtCode);
                    List<GExpWard> lsWard = dc.GExpward.GetListObjectCon(PBean.SCHEMA, "WHERE DistrictID=@DistrictID", "@DistrictID", item.DistrictID);
                    if (lsWardVNP.Count > 0 && lsWard.Count > 0)
                    {
                        foreach (var wardVNPT in lsWardVNP)
                        {
                            if (string.IsNullOrEmpty(wardVNPT.WardId))
                            {
                                string wardVNPTName = GetMapShort(wardVNPT.communeName);
                                bool found = false;
                                foreach (var ward in lsWard)
                                {
                                    string wardName = GetMapShort(ward.WardName);
                                    if (wardVNPTName.Equals(wardName) == true)
                                    {
                                        wardVNPT.WardId = ward.WardId;
                                        dc.GExpwardvtp.Update(PBean.SCHEMA, wardVNPT);
                                        found = true;
                                        break;
                                    }
                                }
                                if (found == false)
                                {
                                    error += item.districtCode + " | Q/Huyện: " + item.districtName + "| P/Xã: " + wardVNPT.communeName + ". Không mapping được vui lòng kiểm tra lại" + System.Environment.NewLine;
                                }
                            }
                        }
                    }
                    else
                    {
                        error += item.districtCode + " | Q/Huyện " + item.districtName + ". Lỗi dữ liệu vui lòng kiểm tra lại" + System.Environment.NewLine;
                    }

                }
                dc.SubmitChanges();
                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show(error, PBean.MESSAGE_TITLE);
                }
                MessageBox.Show("Hoàn thành mapping tự động", PBean.MESSAGE_TITLE);
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

        private void btnLayDuLieu_Click(object sender, EventArgs e)
        {
            IDataContext dc = new dcDataContextM(PBean.CONNECTION_STRING);
            try
            {
                dc.Open();
                string error = string.Empty;
                List<GExpProvinceVTP> lsProvinces = dc.GExpprovincevtp.GetListObject(PBean.SCHEMA);
                foreach (var item in lsProvinces)
                {
                    var client = new RestClient("https://partner.viettelpost.vn/v2/categories/listDistrict?provinceId=" + item.provinceCode);
                    var request = new RestRequest();
                    request.Method = Method.GET;
                    request.AddHeader("Token", _token);
                    request.AddHeader("Content-Type", "application/json");
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    var response = client.Execute(request);
                    OutputGetDistrict result = JsonConvert.DeserializeObject<OutputGetDistrict>(response.Content);
                    if (result != null)
                    {
                        foreach (var dis in result.data)
                        {
                            GExpDistrictVTP district = dc.GExpdistrictvtp.GetObject(PBean.SCHEMA, dis.DISTRICT_ID.ToString());
                            if (district == null)
                            {
                                district = new GExpDistrictVTP();
                                district.districtCode = dis.DISTRICT_ID.ToString();
                                district.districtName = dis.DISTRICT_NAME;
                                district.provinceCode = item.provinceCode;
                                dc.GExpdistrictvtp.InsertOnSubmit(PBean.SCHEMA, district);
                            }
                        }
                    }
                }
                dc.SubmitChanges();
                MessageBox.Show("Hoàn thành lấy huyện tự động", PBean.MESSAGE_TITLE);
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
        public class OutputDistrict
        {
            public int DISTRICT_ID { get; set; }
            public string DISTRICT_VALUE { get; set; }
            public string DISTRICT_NAME { get; set; }
            public int PROVINCE_ID { get; set; }
        }

        public class OutputGetDistrict
        {
            public int status { get; set; }
            public bool error { get; set; }
            public string message { get; set; }
            public List<OutputDistrict> data { get; set; }
        }
        public class OutputGetWardData
        {
            public int WARDS_ID { get; set; }
            public string WARDS_NAME { get; set; }
            public int DISTRICT_ID { get; set; }
        }

        public class OutputGetWard
        {
            public int status { get; set; }
            public bool error { get; set; }
            public string message { get; set; }
            public List<OutputGetWardData> data { get; set; }
        }
        private void btnDuLieuHuyen_Click(object sender, EventArgs e)
        {
            IDataContext dc = new dcDataContextM(PBean.CONNECTION_STRING);
            try
            {
                dc.Open();
                string error = string.Empty;
                List<GExpDistrictVTP> lsDistricts = dc.GExpdistrictvtp.GetListObject(PBean.SCHEMA);
                foreach (var item in lsDistricts)
                {
                    var client = new RestClient("https://partner.viettelpost.vn/v2/categories/listWards?districtId=" + item.districtCode);
                    var request = new RestRequest();
                    request.Method = Method.GET;
                    request.AddHeader("token", _token);
                    request.AddHeader("Content-Type", "application/json");
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    var response = client.Execute(request);
                    OutputGetWard result = JsonConvert.DeserializeObject<OutputGetWard>(response.Content);
                    if (result != null)
                    {
                        foreach (var dis in result.data)
                        {
                            GExpWardVTP ward = dc.GExpwardvtp.GetObject(PBean.SCHEMA, dis.WARDS_ID.ToString());
                            if (ward == null)
                            {
                                ward = new GExpWardVTP();
                                ward.communeCode = dis.WARDS_ID.ToString();
                                ward.communeName = dis.WARDS_NAME;
                                ward.districtCode = item.districtCode;
                                dc.GExpwardvtp.InsertOnSubmit(PBean.SCHEMA, ward);
                            }
                        }
                    }
                }
                dc.SubmitChanges();
                MessageBox.Show("Hoàn thành lấy xã tự động", PBean.MESSAGE_TITLE);
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
    }
}
