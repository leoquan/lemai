using Common;
using LeMaiDomain;
using LeMaiLogic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeMaiDesktop
{

    public partial class frmTestTool : Form
    {
        List<VPTemp> listSource = new List<VPTemp>();
        List<VPTempR> listSourceR = new List<VPTempR>();

        List<ExtVPTemp> listDest = new List<ExtVPTemp>();
        List<ExtVPTemp> listDestR = new List<ExtVPTemp>();
        public frmTestTool()
        {
            InitializeComponent();
        }

        private void btnWardInsert_Click(object sender, EventArgs e)
        {
            DirectoryInfo directory = new DirectoryInfo(txtFolderJson.Text);
            FileInfo[] files = directory.GetFiles();
            string error = string.Empty;
            foreach (FileInfo item in files)
            {
                IDataContext dc = new dcDataContextM(PBean.CONNECTION_STRING);
                try
                {
                    dc.Open();
                    using (StreamReader st = new StreamReader(item.FullName))
                    {
                        string json = st.ReadToEnd();
                        JSonRootWardGHN ward = JsonConvert.DeserializeObject<JSonRootWardGHN>(json);
                        if (ward != null && ward.data != null)
                        {
                            foreach (var sub in ward.data)
                            {
                                GExpWard wardCheck;
                                try
                                {
                                    wardCheck = dc.GExpward.GetObject(PBean.SCHEMA, sub.WardCode);
                                    if (wardCheck == null)
                                    {
                                        wardCheck = new GExpWard();
                                        wardCheck.WardId = sub.WardCode;
                                        wardCheck.Code = sub.WardCode;
                                        wardCheck.DistrictID = sub.DistrictID;
                                        wardCheck.WardName = sub.WardName;
                                        dc.GExpward.InsertOnSubmit(PBean.SCHEMA, wardCheck);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString());
                                }

                            }
                        }
                    }
                    dc.SubmitChanges();
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
            MessageBox.Show(error);
            MessageBox.Show("Finish");

        }

        private void btnBrowserFolderWard_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                txtFolderJson.Text = folder.SelectedPath;
            }
        }

        private void btnTestAPI_Click(object sender, EventArgs e)
        {
            DirectoryInfo directory = new DirectoryInfo(txtFolderJson.Text);
            FileInfo[] files = directory.GetFiles();
            string error = string.Empty;
            foreach (FileInfo item in files)
            {
                IDataContext dc = new dcDataContextM(PBean.CONNECTION_STRING);
                try
                {
                    dc.Open();
                    using (StreamReader st = new StreamReader(item.FullName))
                    {
                        string json = st.ReadToEnd();
                        List<VNPOSTProvince> ls = JsonConvert.DeserializeObject<List<VNPOSTProvince>>(json);

                        foreach (var sub in ls)
                        {
                            GExpProvinceVNP pro = dc.GExpprovincevnp.GetObject(PBean.SCHEMA, sub.provinceCode);
                            if (pro != null)
                            {
                                pro.provinceCode = sub.provinceCode;
                                pro.provinceName = sub.provinceName.Trim();
                                dc.GExpprovincevnp.Update(PBean.SCHEMA, pro);
                            }
                            else
                            {
                                pro = new GExpProvinceVNP();
                                pro.provinceCode = sub.provinceCode;
                                pro.provinceName = sub.provinceName.Trim();
                                dc.GExpprovincevnp.InsertOnSubmit(PBean.SCHEMA, pro);
                            }
                        }

                    }
                    dc.SubmitChanges();
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
            MessageBox.Show(error);
            MessageBox.Show("Finish");
        }

        private void btnHuyenVN_Click(object sender, EventArgs e)
        {
            DirectoryInfo directory = new DirectoryInfo(txtFolderJson.Text);
            FileInfo[] files = directory.GetFiles();
            string error = string.Empty;
            foreach (FileInfo item in files)
            {
                IDataContext dc = new dcDataContextM(PBean.CONNECTION_STRING);
                try
                {
                    dc.Open();
                    using (StreamReader st = new StreamReader(item.FullName))
                    {
                        string json = st.ReadToEnd();
                        List<VNPOSTDistrict> ls = JsonConvert.DeserializeObject<List<VNPOSTDistrict>>(json);

                        foreach (var sub in ls)
                        {
                            GExpDistrictVNP pro = dc.GExpdistrictvnp.GetObject(PBean.SCHEMA, sub.districtCode);
                            if (pro != null)
                            {
                                pro.districtCode = sub.districtCode;
                                pro.districtName = sub.districtName.Trim();
                                pro.provinceCode = sub.provinceCode;
                                dc.GExpdistrictvnp.Update(PBean.SCHEMA, pro);
                            }
                            else
                            {
                                pro = new GExpDistrictVNP();
                                pro.districtCode = sub.districtCode;
                                pro.districtName = sub.districtName.Trim();
                                pro.provinceCode = sub.provinceCode;
                                dc.GExpdistrictvnp.InsertOnSubmit(PBean.SCHEMA, pro);
                            }
                        }

                    }
                    dc.SubmitChanges();
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
            MessageBox.Show(error);
            MessageBox.Show("Finish");
        }

        private void btnNapXa_Click(object sender, EventArgs e)
        {
            DirectoryInfo directory = new DirectoryInfo(txtFolderJson.Text);
            FileInfo[] files = directory.GetFiles();
            string error = string.Empty;
            foreach (FileInfo item in files)
            {
                IDataContext dc = new dcDataContextM(PBean.CONNECTION_STRING);
                try
                {
                    dc.Open();
                    using (StreamReader st = new StreamReader(item.FullName))
                    {
                        string json = st.ReadToEnd();
                        List<VNPOSTWard> ls = JsonConvert.DeserializeObject<List<VNPOSTWard>>(json);

                        foreach (var sub in ls)
                        {
                            GExpWardVNP pro = dc.GExpwardvnp.GetObject(PBean.SCHEMA, sub.communeCode);
                            if (pro != null)
                            {
                                pro.districtCode = sub.districtCode;
                                pro.communeName = sub.communeName.Trim();
                                pro.communeCode = sub.communeCode;
                                dc.GExpwardvnp.Update(PBean.SCHEMA, pro);
                            }
                            else
                            {
                                pro = new GExpWardVNP();
                                pro.districtCode = sub.districtCode;
                                pro.communeName = sub.communeName.Trim();
                                pro.communeCode = sub.communeCode;
                                dc.GExpwardvnp.InsertOnSubmit(PBean.SCHEMA, pro);
                            }
                        }

                    }
                    dc.SubmitChanges();
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
            MessageBox.Show(error);
            MessageBox.Show("Finish");
        }

        private void butTaoDanhBa_Click(object sender, EventArgs e)
        {
            IDataContext dc = new dcDataContextM(PBean.CONNECTION_STRING);
            try
            {
                dc.Open();
                List<GExpBill> lsBill = dc.GExpbill.GetListObject(PBean.SCHEMA);
                foreach (GExpBill input in lsBill)
                {
                    GExpAccept accept = dc.GExpaccept.GetObjectCon(PBean.SCHEMA, "WHERE AcceptPhone=@AcceptPhone", "@AcceptPhone", input.AcceptManPhone.Trim());
                    if (accept == null)
                    {
                        accept = new GExpAccept();
                        accept.Id = Guid.NewGuid().ToString();
                        accept.AcceptMan = input.AcceptMan;
                        accept.AcceptPhone = input.AcceptManPhone;
                        accept.AcceptAddress = input.AcceptManAddress;
                        accept.AcceptAddressFull = input.AcceptManAddress + "," + input.AcceptWard + "," + input.AcceptDistrict + "," + input.AcceptProvince;
                        accept.AcceptProvince = input.AcceptProvinceCode;
                        accept.AcceptDistrict = input.AcceptDistrictCode;
                        accept.AcceptWard = input.AcceptWardCode;
                        accept.AcceptLevel = 0;
                        dc.GExpaccept.InsertOnSubmit(PBean.SCHEMA, accept);
                    }
                }
                dc.SubmitChanges();
                MessageBox.Show("Tạo danh bạ thành công!");
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

        private void btnSaiLech_Click(object sender, EventArgs e)
        {
            IDataContext dc = new dcDataContextM(PBean.CONNECTION_STRING);
            try
            {
                dc.Open();
                listDest = new List<ExtVPTemp>();
                listDestR = new List<ExtVPTemp>();

                listSource = dc.VPtemp.GetListObjectCon(PBean.SCHEMA, "WHERE STT>0");
                listSourceR = dc.VPtempr.GetListObjectCon(PBean.SCHEMA, "WHERE STT>0");

                progressBar.Visible = true;
                progressBar.Value = 0;
                progressBar.Step = 1;
                progressBar.Maximum = listSource.Count;
                backgroundWorker.RunWorkerAsync();
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

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int GroupIndex = 0;
            // Check Source
            //foreach (var item in listSource)
            //{
            //    ExtVPTemp dest = listDest.FirstOrDefault(u => u.HC.ToLower().Trim() == item.HC.ToLower().Trim()
            //    && PCommon.ConvertToUnSign(u.ND.ToLower().Trim()) == PCommon.ConvertToUnSign(item.ND.ToLower().Trim())
            //    && PCommon.ConvertToUnSign(u.BC.ToLower().Trim()) == PCommon.ConvertToUnSign(item.BC.ToLower().Trim())
            //    && PCommon.ConvertToUnSign(u.DD.ToLower().Trim()) == PCommon.ConvertToUnSign(item.DD.ToLower().Trim())
            //    && PCommon.ConvertToUnSign(u.DVT.ToLower().Trim()) == PCommon.ConvertToUnSign(item.DVT.ToLower().Trim())
            //    && PCommon.ConvertToUnSign(u.NHOM.ToLower().Trim()) == PCommon.ConvertToUnSign(item.NHOM.ToLower().Trim()) && u.Root == true);
            //    if (dest == null)
            //    {
            //        GroupIndex++;
            //        ExtVPTemp newdest = new ExtVPTemp();
            //        newdest.Root = true;
            //        newdest.GroupID = GroupIndex;
            //        newdest.Error = "ROOT";

            //        newdest.STT = item.STT;
            //        newdest.HC = item.HC;
            //        newdest.ND = item.ND;
            //        newdest.BC = item.BC;
            //        newdest.DD = item.DD;
            //        newdest.DVT = item.DVT;
            //        newdest.NHOM = item.NHOM;
            //        newdest.SL2 = item.SL2;
            //        newdest.DG = item.DG;
            //        newdest.TT = item.TT;

            //        VPTempR tempR = listSourceR.FirstOrDefault(u => u.HC.ToLower().Trim() == item.HC.ToLower().Trim()
            //        && PCommon.ConvertToUnSign(u.ND.ToLower().Trim()) == PCommon.ConvertToUnSign(item.ND.ToLower().Trim())
            //        && PCommon.ConvertToUnSign(u.BC.ToLower().Trim()) == PCommon.ConvertToUnSign(item.BC.ToLower().Trim())
            //        && PCommon.ConvertToUnSign(u.DD.ToLower().Trim()) == PCommon.ConvertToUnSign(item.DD.ToLower().Trim())
            //        && PCommon.ConvertToUnSign(u.DVT.ToLower().Trim()) == PCommon.ConvertToUnSign(item.DVT.ToLower().Trim())
            //        && PCommon.ConvertToUnSign(u.NHOM.ToLower().Trim()) == PCommon.ConvertToUnSign(item.NHOM.ToLower().Trim()));
            //        if (tempR != null)
            //        {
            //            newdest.GroupR = tempR.STT;
            //            newdest.SoLuongTongPhanMemTinh = tempR.SL2;
            //            newdest.TongTienPhanMemTinh = tempR.TT;
            //            newdest.TongTienMinhTinh = newdest.TT;
            //            newdest.SoLuongTongMinhTinh = newdest.SL2;
            //        }
            //        else
            //        {
            //            newdest.GroupR = 0;
            //        }
            //        listDest.Add(newdest);
            //    }
            //    else
            //    {
            //        // Update cho cái dest
            //        dest.TongTienMinhTinh = dest.TongTienMinhTinh + item.TT;
            //        dest.SoLuongTongMinhTinh = dest.SoLuongTongMinhTinh + item.SL2;

            //        if (item.DG != dest.DG)
            //        {
            //            // Lệch đơn giá
            //            ExtVPTemp newdest = new ExtVPTemp();
            //            newdest.Root = false;
            //            newdest.GroupID = GroupIndex;
            //            newdest.Error = "#DG";

            //            newdest.STT = item.STT;
            //            newdest.HC = item.HC;
            //            newdest.ND = item.ND;
            //            newdest.BC = item.BC;
            //            newdest.DD = item.DD;
            //            newdest.DVT = item.DVT;
            //            newdest.NHOM = item.NHOM;
            //            newdest.SL2 = item.SL2;
            //            newdest.DG = item.DG;
            //            newdest.TT = item.TT;
            //            newdest.GroupR = dest.GroupR;

            //            newdest.TongTienMinhTinh = 0;
            //            newdest.TongTienPhanMemTinh = 0;
            //            newdest.SoLuongTongMinhTinh = 0;
            //            newdest.SoLuongTongPhanMemTinh = 0;

            //            listDest.Add(newdest);
            //        }
            //        else
            //        {
            //            ExtVPTemp newdest = new ExtVPTemp();
            //            newdest.Root = false;
            //            newdest.GroupID = GroupIndex;
            //            newdest.Error = "REMOVE";

            //            newdest.STT = item.STT;
            //            newdest.HC = item.HC;
            //            newdest.ND = item.ND;
            //            newdest.BC = item.BC;
            //            newdest.DD = item.DD;
            //            newdest.DVT = item.DVT;
            //            newdest.NHOM = item.NHOM;
            //            newdest.SL2 = item.SL2;
            //            newdest.DG = item.DG;
            //            newdest.TT = item.TT;
            //            newdest.GroupR = dest.GroupR;

            //            newdest.TongTienMinhTinh = 0;
            //            newdest.TongTienPhanMemTinh = 0;
            //            newdest.SoLuongTongMinhTinh = 0;
            //            newdest.SoLuongTongPhanMemTinh = 0;

            //            listDest.Add(newdest);
            //        }
            //    }

            //    backgroundWorker.ReportProgress(0);
            //}
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.PerformStep();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "REPORT_" + string.Format("{0:dd_MM_yyyy_(HH_mm)}", DateTime.Now);
            save.Filter = "Excel Files | *.xlsx";
            if (save.ShowDialog() == DialogResult.OK)
            {
                string templateFileName = AppDomain.CurrentDomain.BaseDirectory + "Templates\\MAU_CHENH_LECH.xlsx";
                Dictionary<string, string> lsReplace = new Dictionary<string, string>();
                Dictionary<string, string> lsTitile = new Dictionary<string, string>();
                List<string> lsKeyString = new List<string>();
                DataTable data = MapperExtensionClass.ToDataTable<ExtVPTemp>(listDest);
                ExportDataToExcelTemplate.Export(templateFileName, save.FileName, 1, data, lsTitile, lsReplace, true, lsKeyString);
                MessageBox.Show("Xuất file excel thành công!", PBean.MESSAGE_TITLE);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IDataContext dc = new dcDataContextM(PBean.CONNECTION_STRING);
            try
            {
                dc.Open();

                var listS = dc.VPtemp.GetListObjectCon(PBean.SCHEMA, "WHERE GroupId='G4'");
                var listR = dc.VPtempr.GetListObjectCon(PBean.SCHEMA, "WHERE GroupId='G4'");
                foreach (var item in listS)
                {
                    var tempR = listR.Where(u => u.HoatChat.ToLower().Trim() == item.HoatChat.ToLower().Trim()
                    && PCommon.ConvertToUnSign(u.BietDuoc.ToLower().Trim()) == PCommon.ConvertToUnSign(item.BietDuoc.ToLower().Trim())).ToList();
                    //&& PCommon.ConvertToUnSign(u.BaoChe.ToLower().Trim()) == PCommon.ConvertToUnSign(item.BaoChe.ToLower().Trim())
                    //&& PCommon.ConvertToUnSign(u.DuongDung.ToLower().Trim()) == PCommon.ConvertToUnSign(item.DuongDung.ToLower().Trim())
                    //&& PCommon.ConvertToUnSign(u.DVT.ToLower().Trim()) == PCommon.ConvertToUnSign(item.DVT.ToLower().Trim())
                    //&& PCommon.ConvertToUnSign(u.NHOM.ToLower().Trim()) == PCommon.ConvertToUnSign(item.NHOM.ToLower().Trim())).ToList();
                    if (tempR.Count == 1)
                    {
                        // Tìm được đúng
                        item.DonGiaMin = tempR[0].DonGiaMin;
                        item.DonGiaMax = tempR[0].DonGiaMax;
                        item.CTY1 = tempR[0].CTY1;
                        item.TENT1 = tempR[0].TENT1;
                        item.DONGIA1 = tempR[0].DONGIA1;
                        item.GIAKK1 = tempR[0].GIAKK1;
                        item.CTY2 = tempR[0].CTY2;
                        item.TENT2 = tempR[0].TENT2;
                        item.DONGIA2 = tempR[0].DONGIA2;
                        item.GIAKK2 = tempR[0].GIAKK2;
                        item.CTY3 = tempR[0].CTY3;
                        item.TENT3 = tempR[0].TENT3;
                        item.DONGIA3 = tempR[0].DONGIA3;
                        item.GIAKK3 = tempR[0].GIAKK3;
                        item.Note = "Found";
                        dc.VPtemp.Update(PBean.SCHEMA, item);
                    }
                    else
                    {
                        if (item.Note != "Found")
                        {
                            item.Note = "CXL: " + tempR.Count.ToString();
                            dc.VPtemp.Update(PBean.SCHEMA, item);
                        }
                    }
                }
                dc.SubmitChanges();
                MessageBox.Show("Xử lý xong!", PBean.MESSAGE_TITLE);
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

        private void button2_Click(object sender, EventArgs e)
        {
            IDataContext dc = new dcDataContextM(PBean.CONNECTION_STRING);
            try
            {
                dc.Open();
                string nhom = "G1";
                var listS = dc.VPtemp.GetListObjectCon(PBean.SCHEMA, "WHERE GroupId='" + nhom + "'");
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = "REPORT_" + string.Format("{0:dd_MM_yyyy_(HH_mm)}", DateTime.Now) + "_" + nhom;
                save.Filter = "Excel Files | *.xlsx";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string templateFileName = AppDomain.CurrentDomain.BaseDirectory + "Templates\\MAU_GROUP.xlsx";
                    Dictionary<string, string> lsReplace = new Dictionary<string, string>();
                    Dictionary<string, string> lsTitile = new Dictionary<string, string>();
                    List<string> lsKeyString = new List<string>();
                    DataTable data = MapperExtensionClass.ToDataTable(listS);
                    ExportDataToExcelTemplate.Export(templateFileName, save.FileName, 1, data, lsTitile, lsReplace, true, lsKeyString);
                    MessageBox.Show("Xuất file excel thành công!", PBean.MESSAGE_TITLE);
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

        private void button3_Click(object sender, EventArgs e)
        {
            string ids = string.Empty;
            IDataContext dc = new dcDataContextM(PBean.CONNECTION_STRING);
            try
            {
                dc.Open();
                List<GExpWard> wardList = dc.GExpward.GetListObject(PBean.SCHEMA);
                foreach (var item in wardList)
                {
                    ids = item.SearchKey;
                    string s = PCommon.UnSigns(item.SearchKey).ToLower();
                    string[] temp = s.Split(';');
                    if (temp.Length < 3)
                    {
                        continue;
                    }
                    string xa = temp[0];
                    string huyen = temp[1];
                    string tinh = temp[2];
                    string[] splitxa = xa.Split(' ');
                    // xử lý xã
                    s = string.Empty;
                    if (splitxa[0] == "xa")
                    {
                        for (int i = 1; i < splitxa.Length; i++)
                        {
                            s = s + splitxa[i] + " ";
                        }
                        xa = s.Trim();
                    }
                    else if (splitxa[0] == "thi" && splitxa[1] == "tran")
                    {
                        for (int i = 2; i < splitxa.Length; i++)
                        {
                            s = s + splitxa[i] + " ";
                        }
                        xa = s.Trim();
                    }
                    // xử lý huyện
                    s = string.Empty;
                    string[] splithuyen = huyen.Split(' ');
                    if (splithuyen[0] == "huyen")
                    {
                        for (int i = 1; i < splithuyen.Length; i++)
                        {
                            s = s + splithuyen[i] + " ";
                        }
                        huyen = s.Trim();
                    }
                    else if (splithuyen[0] == "thanh" && splithuyen[1] == "pho")
                    {
                        for (int i = 2; i < splithuyen.Length; i++)
                        {
                            s = s + splithuyen[i] + " ";
                        }
                        huyen = s.Trim();
                    }
                    else if (splithuyen[0] == "thi" && splithuyen[1] == "xa")
                    {
                        for (int i = 2; i < splithuyen.Length; i++)
                        {
                            s = s + splithuyen[i] + " ";
                        }
                        huyen = s.Trim();
                    }
                    // xử lý Tinh
                    s = string.Empty;
                    string[] splitTinh = tinh.Split(' ');
                    if (splitTinh[0] == "tinh")
                    {
                        for (int i = 1; i < splitTinh.Length; i++)
                        {
                            s = s + splitTinh[i] + " ";
                        }
                        tinh = s.Trim();
                    }
                    else if (splitTinh[0] == "thanh" && splitTinh[1] == "pho")
                    {
                        for (int i = 2; i < splitTinh.Length; i++)
                        {
                            s = s + splitTinh[i] + " ";
                        }
                        tinh = s.Trim();
                    }
                    item.SearchKey = xa + " " + huyen + " " + tinh + " " + huyen + " " + xa + " " + tinh + " " + xa;
                    item.SearchKey = item.SearchKey.Trim();
                    dc.GExpward.Update(PBean.SCHEMA, item);
                }
                dc.SubmitChanges();
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
    public class ExtVPTemp : VPTemp
    {
        public bool Root { get; set; }
        public int GroupID { get; set; }
        public int GroupR { get; set; }
        public string Error { get; set; }
        public decimal SoLuongTongMinhTinh { get; set; }
        public decimal SoLuongTongPhanMemTinh { get; set; }
        public decimal TongTienMinhTinh { get; set; }
        public decimal TongTienPhanMemTinh { get; set; }

    }
    public class ExtVPTempR : VPTempR
    {
        public decimal TongTienR { get; set; }
    }
}
