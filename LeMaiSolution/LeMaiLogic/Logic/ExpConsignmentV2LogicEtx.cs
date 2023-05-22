using LeMaiDomain;
using LeMaiDomain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{
    public partial class ExpConsignmentV2Logic : BaseLogic
    {
        public List<ExpBILL> GetListBillByCode(string mavandon)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpbill.GetListObjectCon(base.ConnectionData.Schema, "WHERE BILL_CODE IN (" + mavandon + ")");
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
        public string CheckCODBalance(string mavandon, string post, decimal COD, out decimal KTCOD)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<ExpBalanceDetail> lsDetail = dc.EXpbalancedetail.GetListObjectCon(base.ConnectionData.Schema, "WHERE BILL_CODE=@BILL_CODE AND MaChiPhi='SDSHK-F' AND MaDaiLy=@MaDaiLy",
                    "@BILL_CODE", mavandon,
                    "@MaDaiLy", post);
                if (lsDetail.Count > 0)
                {
                    decimal sumCOD = lsDetail.Sum(u => u.SoTien);
                    KTCOD = sumCOD;
                    if (sumCOD == COD)
                    {

                        return "+ Thu hộ " + sumCOD.ToString() + " (" + lsDetail[0].KeyThoiGianKetToan + ")";
                    }
                    else
                    {
                        return "Thu hộ không đúng";
                    }
                }
                else
                {
                    KTCOD = 0;
                    return "Không vào COD";
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
        public List<ExpProvinceFee> GetListProvinceFee()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpprovincefee.GetListObjectCon(base.ConnectionData.Schema, "order by FeeID");
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
        public List<ExpProvinceFeeCustomer> GetListProvinceFeeCustomer()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpprovincefeecustomer.GetListObjectCon(base.ConnectionData.Schema, "order by Name");
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
        public decimal GetPhiGiaoHang(string stringWeight)
        {
            decimal feeGiaoHang = 9000;
            decimal deWeight;
            if (!Decimal.TryParse(stringWeight, out deWeight))
            {
                deWeight = 0;
            }
            if (deWeight <= 3)
            {
                feeGiaoHang = 9000;
            }
            else if (deWeight <= 20)
            {
                feeGiaoHang = 9000 + (deWeight - 3) * 700;
            }
            else if (deWeight <= 30)
            {
                feeGiaoHang = 9000 + 17 * 700 + (deWeight - 20) * 1000;
            }
            else
            {
                feeGiaoHang = 9000 + 17 * 700 + 10000 + (deWeight - 30) * 1500;
            }
            return feeGiaoHang;
        }

        public decimal GetFeeBalanceDetail(string mavandon, string post)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<ExpBalanceDetail> lsDetail = dc.EXpbalancedetail.GetListObjectCon(base.ConnectionData.Schema, "WHERE BILL_CODE=@BILL_CODE AND MaChiPhi<>'SDSHK-F' AND MaChiPhi<>'PDFK-F' AND MaDaiLy=@MaDaiLy",
                    "@BILL_CODE", mavandon,
                    "@MaDaiLy", post);
                if (lsDetail.Count > 0)
                {
                    decimal sumFee = lsDetail.Where(o => o.LoaiThu == "Thu").Sum(u => u.SoTien);
                    decimal sumReturn = lsDetail.Where(o => o.LoaiThu == "Trả").Sum(u => u.SoTien);
                    return sumFee - sumReturn + 3200;
                }
                else
                {
                    return 3200;
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
        public decimal GetPhiTrungChuyenBalanceDetail(string mavandon, string post, out decimal weightKT)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<ExpBalanceDetail> lsDetail = dc.EXpbalancedetail.GetListObjectCon(base.ConnectionData.Schema, "WHERE BILL_CODE=@BILL_CODE AND MaChiPhi='ZZF-S' AND MaDaiLy=@MaDaiLy",
                    "@BILL_CODE", mavandon,
                    "@MaDaiLy", post);
                if (lsDetail.Count > 0)
                {
                    decimal sumFee = lsDetail.Where(o => o.LoaiThu == "Thu").Sum(u => u.SoTien);
                    decimal sumReturn = lsDetail.Where(o => o.LoaiThu == "Trả").Sum(u => u.SoTien);
                    weightKT = (decimal)lsDetail[0].TrongLuongThanhToan;
                    return sumFee - sumReturn;
                }
                else
                {
                    weightKT = 0;
                    return 0;
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
        public DataTable GetStrucFeeBalanceDetail()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                DataTable ds = dc.GetData("SELECT TOP(1) A.BILL_CODE, A.MaChiPhi, A.TenChiPhi, A.SoTien, A.LoaiThu, A.ThoiGianKetToan  FROM " + base.ConnectionData.Schema + ".[ExpBalanceDetail] A ");
                return ds.Clone();
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
        public decimal GetFeeBalanceDetail(string mavandon, string post, DataTable data)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                DataTable ds = dc.GetData("SELECT A.BILL_CODE, A.MaChiPhi, A.TenChiPhi, A.SoTien, A.LoaiThu, A.ThoiGianKetToan  FROM " + base.ConnectionData.Schema + ".[ExpBalanceDetail] A WHERE BILL_CODE=@BILL_CODE AND MaChiPhi<>'SDSHK-F' AND MaChiPhi<>'SDSHK-S' AND MaChiPhi<>'PDFK-F' AND MaDaiLy=@MaDaiLy",
                    "@BILL_CODE", mavandon,
                    "@MaDaiLy", post);
                List<ExpBalanceDetail> lsDetail = new List<ExpBalanceDetail>();
                foreach (DataRow dr in ds.Rows)
                {
                    ExpBalanceDetail item = new ExpBalanceDetail();
                    if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
                    {
                        item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
                    }
                    if (dr["ThoiGianKetToan"] != null && dr["ThoiGianKetToan"] != DBNull.Value)
                    {
                        item.ThoiGianKetToan = Convert.ToDateTime(dr["ThoiGianKetToan"]);
                    }
                    if (dr["MaChiPhi"] != null && dr["MaChiPhi"] != DBNull.Value)
                    {
                        item.MaChiPhi = Convert.ToString(dr["MaChiPhi"]);
                    }
                    if (dr["TenChiPhi"] != null && dr["TenChiPhi"] != DBNull.Value)
                    {
                        item.TenChiPhi = Convert.ToString(dr["TenChiPhi"]);
                    }
                    if (dr["LoaiThu"] != null && dr["LoaiThu"] != DBNull.Value)
                    {
                        item.LoaiThu = Convert.ToString(dr["LoaiThu"]);
                    }
                    if (dr["SoTien"] != null && dr["SoTien"] != DBNull.Value)
                    {
                        item.SoTien = Convert.ToDecimal(dr["SoTien"]);
                    }
                    data.ImportRow(dr);

                    lsDetail.Add(item);
                }
                if (lsDetail.Count > 0)
                {
                    decimal sumFee = lsDetail.Where(o => o.LoaiThu == "Thu").Sum(u => u.SoTien);
                    decimal sumReturn = lsDetail.Where(o => o.LoaiThu == "Trả").Sum(u => u.SoTien);

                    return sumFee - sumReturn + 3200;
                }
                else
                {
                    return 3200;
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

        public decimal GetCODBalance(string mavandon, string post)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<ExpBalanceDetail> lsDetail = dc.EXpbalancedetail.GetListObjectCon(base.ConnectionData.Schema, "WHERE BILL_CODE=@BILL_CODE AND MaChiPhi='SDSHK-F' AND MaDaiLy=@MaDaiLy",
                    "@BILL_CODE", mavandon,
                    "@MaDaiLy", post);
                if (lsDetail.Count > 0)
                {
                    decimal sumCOD = lsDetail.Sum(u => u.SoTien);
                    return sumCOD;
                }
                else
                {
                    return 0;
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
        public int GetCKCODBalance(string mavandon)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpCODCK ck = dc.EXpcodck.GetObject(base.ConnectionData.Schema, mavandon);
                if (ck == null)
                {
                    return 0;
                }
                else
                {
                    return ck.SoTienCKCOD;
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
        public decimal GetFeeCalculatorByGiaCuoc(string province, string billWeight, string IdGiaCuoc)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string temp = UnSigns(province.Trim());
                ExpProvinceFee provineFee = dc.EXpprovincefee.GetObject(base.ConnectionData.Schema, temp);
                if (provineFee != null)
                {
                    decimal weight;
                    if (decimal.TryParse(billWeight, out weight))
                    {

                        ExpProvinceFeeCustomer feeCustom = dc.EXpprovincefeecustomer.GetObject(base.ConnectionData.Schema, IdGiaCuoc);
                        if (feeCustom == null)
                        {
                            feeCustom = dc.EXpprovincefeecustomer.GetObject(base.ConnectionData.Schema, "0000");
                        }

                        if (feeCustom.UsingLess == true)
                        {
                            if (feeCustom.UsingZone == true)
                            {
                                // Dưới 1Kg, 2kg, 3kg
                                int initFee = feeCustom.InitMN;
                                int nextWeight = feeCustom.NextWeightMN;
                                int less1 = feeCustom.Less1MN;
                                int less2 = feeCustom.Less2MN;
                                int less3 = feeCustom.Less3MN;
                                int less4 = feeCustom.Less4MN;
                                int less5 = feeCustom.Less5MN;
                                if (provineFee.Zone == "B")
                                {
                                    initFee = feeCustom.InitMB;
                                    nextWeight = feeCustom.NextWeightMB;
                                    less1 = feeCustom.Less1MB;
                                    less2 = feeCustom.Less2MB;
                                    less3 = feeCustom.Less3MB;
                                    less4 = feeCustom.Less4MB;
                                    less5 = feeCustom.Less5MB;
                                }
                                else if (provineFee.Zone == "T")
                                {
                                    initFee = feeCustom.InitMT;
                                    nextWeight = feeCustom.NextWeightMT;
                                    less1 = feeCustom.Less1MT;
                                    less2 = feeCustom.Less2MT;
                                    less3 = feeCustom.Less3MT;
                                    less4 = feeCustom.Less4MT;
                                    less5 = feeCustom.Less5MT;
                                }

                                if (weight <= 1.0m)
                                {
                                    return less1;
                                }
                                else if (weight <= 2.0m)
                                {
                                    return less2;
                                }
                                else if (weight <= 3.0m)
                                {
                                    return less3;
                                }
                                else if (weight <= 4.0m)
                                {
                                    return less4;
                                }
                                else if (weight <= 5.0m)
                                {
                                    return less5;
                                }
                                else
                                {
                                    return initFee + (weight - feeCustom.InitWeight) * nextWeight;
                                }
                            }
                            else
                            {
                                // Dưới 1Kg, 2kg, 3kg
                                if (weight <= 1.0m)
                                {
                                    return feeCustom.Less1MB;
                                }
                                else if (weight <= 2.0m)
                                {
                                    return feeCustom.Less2MB;
                                }
                                else if (weight <= 3.0m)
                                {
                                    return feeCustom.Less3MB;
                                }
                                else if (weight <= 4.0m)
                                {
                                    return feeCustom.Less4MB;
                                }
                                else if (weight <= 5.0m)
                                {
                                    return feeCustom.Less5MB;
                                }
                                else
                                {
                                    return feeCustom.InitAll + (weight - feeCustom.InitWeight) * feeCustom.NextWeightAll;
                                }
                            }

                        }
                        else
                        {
                            if (feeCustom.UsingZone == true)
                            {
                                // Tính theo miền
                                int initFee = feeCustom.InitMN;
                                int nextWeight = feeCustom.NextWeightMN;
                                if (provineFee.Zone == "B")
                                {
                                    initFee = feeCustom.InitMB;
                                    nextWeight = feeCustom.NextWeightMB;
                                }
                                else if (provineFee.Zone == "T")
                                {
                                    initFee = feeCustom.InitMT;
                                    nextWeight = feeCustom.NextWeightMT;
                                }
                                if (weight <= feeCustom.InitWeight)
                                {
                                    return initFee;
                                }
                                else
                                {
                                    return initFee + (weight - feeCustom.InitWeight) * nextWeight;
                                }
                            }
                            else
                            {
                                // Không tính theo miền
                                if (weight <= feeCustom.InitWeight)
                                {
                                    return feeCustom.InitAll;
                                }
                                else
                                {
                                    return feeCustom.InitAll + (weight - feeCustom.InitWeight) * feeCustom.NextWeightAll;
                                }
                            }
                        }
                    }
                }

                return 0;
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
        public decimal GetFeeCalculator(string province, string billWeight, string customerId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string idGiaCuoc = "0000";
                ExpProvinceFeeCustomer feeCustom = dc.EXpprovincefeecustomer.GetObjectCon(base.ConnectionData.Schema, "WHERE Id IN (SELECT B.FK_GiaCuoc FROM ExpCustomer B WHERE B.Id='" + customerId + "')");
                if (feeCustom != null)
                {
                    idGiaCuoc = feeCustom.Id;
                }
                return GetFeeCalculatorByGiaCuoc(province, billWeight, idGiaCuoc);
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
        public decimal GetPhiTrungChuyen(string billWeight, string province)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string temp = UnSigns(province.Trim());
                ExpProvinceFee fee = dc.EXpprovincefee.GetObject(base.ConnectionData.Schema, temp);
                if (fee != null)
                {
                    decimal weight;
                    if (decimal.TryParse(billWeight, out weight))
                    {
                        if (weight <= 0.5m)
                        {
                            return fee.W05;
                        }
                        else if (weight <= 1)
                        {
                            return weight * (decimal)fee.W10;
                        }
                        else if (weight <= 3)
                        {
                            return (decimal)fee.W30;
                        }
                        else if (weight <= 5)
                        {
                            return (decimal)fee.W50;
                        }
                        else
                        {
                            return weight * (decimal)fee.W500;
                        }
                    }
                }
                return 0;
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
        public void InitProvinceFee(List<string> tenTinhs)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                foreach (var item in tenTinhs)
                {
                    if (!string.IsNullOrEmpty(item.Trim()))
                    {
                        string temp = UnSigns(item);
                        ExpProvinceFee fee = dc.EXpprovincefee.GetObject(base.ConnectionData.Schema, temp);
                        if (fee == null)
                        {
                            fee = new ExpProvinceFee();
                            fee.FeeID = temp;
                            fee.InitWeight = 32;
                            fee.NextWeight = 5;
                            dc.EXpprovincefee.InsertOnSubmit(base.ConnectionData.Schema, fee);
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
        public string CheckFeeBalance(string mavandon, string post, decimal PhiVC, out decimal PhiVCKT)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<ExpBalanceDetail> lsDetail = dc.EXpbalancedetail.GetListObjectCon(base.ConnectionData.Schema, "WHERE BILL_CODE=@BILL_CODE AND MaChiPhi='PDFK-F' AND MaDaiLy=@MaDaiLy",
                    "@BILL_CODE", mavandon,
                    "@MaDaiLy", post);
                if (lsDetail.Count > 0)
                {
                    decimal sumfee = lsDetail.Sum(u => u.SoTien);
                    PhiVCKT = sumfee;
                    if (sumfee == PhiVC)
                    {
                        return "+ Phí nhận trả";
                    }
                    else
                    {
                        return "Phí nhận trả không đúng";
                    }
                }
                else
                {
                    PhiVCKT = 0;
                    return "Không vào phí nhận trả";
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

        public List<ExpBalanceDetail> GetBalanceDetailList(string mavandon, string loaiChiPhi, string maDaiLy, DateTime fromDate, DateTime toDate, bool isTaiKhoanChung, bool isTaiKhoanCOD, DateTime? fromCod, DateTime? toCod)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();//ThoiGianKetToan
                string condition = string.Empty;
                if (fromCod == null && toCod == null)
                {
                    condition = "WHERE ThoiGianKetToan >='" + string.Format("{0:yyyy-MM-dd}", fromDate) + " 00:00:00' AND ThoiGianKetToan <='" + string.Format("{0:yyyy-MM-dd}", toDate) + " 23:59:59' AND MaDaiLy='" + maDaiLy + "' &";
                }
                else
                {
                    if (fromCod == null)
                    {
                        condition = "WHERE ThoiGianKetToan <='" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", toCod) + "' AND MaDaiLy='" + maDaiLy + "' &";
                    }
                    else if (toCod == null)
                    {
                        condition = "WHERE ThoiGianKetToan >='" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", fromCod) + "' AND MaDaiLy='" + maDaiLy + "' &";
                    }
                    else
                    {
                        condition = "WHERE ThoiGianKetToan >='" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", fromCod) + "' AND ThoiGianKetToan <='" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", toCod) + "' AND MaDaiLy='" + maDaiLy + "' &";
                    }
                }

                if (!string.IsNullOrEmpty(mavandon))
                {
                    condition += " BILL_CODE IN (" + mavandon + ") &";
                }
                if (!string.IsNullOrEmpty(loaiChiPhi))
                {
                    condition += " MaChiPhi IN (" + loaiChiPhi + ") &";
                }
                if (isTaiKhoanChung && isTaiKhoanCOD)
                {
                    // Chọn tất cả
                }
                else if (isTaiKhoanChung)
                {
                    // Chỉ chọn tài khoản chung
                    condition += " LoaiTaiKhoan=N'Tài khoản chung' &";
                }
                else
                {
                    // Chỉ chọn tài khoản COD
                    condition += " LoaiTaiKhoan=N'Tài khoản COD' &";
                }
                condition = condition.TrimEnd('&');
                condition = condition.Replace("&", "AND");
                return dc.EXpbalancedetail.GetListObjectCon(base.ConnectionData.Schema, condition);
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
        public List<ExpBalanceDetail> GetBalanceDetailList(DateTime? fromCod, DateTime? toCod, out List<view_BaoCaoTaiChinh> lsBaoCaoTaiChinh)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();//ThoiGianKetToan
                string condition = string.Empty;
                if (fromCod == null)
                {
                    condition = "WHERE ThoiGianKetToan <='" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", toCod) + "' &";
                }
                else if (toCod == null)
                {
                    condition = "WHERE ThoiGianKetToan >'" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", fromCod) + "' &";
                }
                else
                {
                    condition = "WHERE ThoiGianKetToan >'" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", fromCod) + "' AND ThoiGianKetToan <='" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", toCod) + "' &";
                }
                condition = condition.TrimEnd('&');
                condition = condition.Replace("&", "AND");
                condition += " ORDER BY ThoiGianKetToan ASC";
                lsBaoCaoTaiChinh = dc.VIewbaocaotaichinh.GetListObjectCon(base.ConnectionData.Schema, condition);
                return dc.EXpbalancedetail.GetListObjectCon(base.ConnectionData.Schema, condition);
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
        public string InsetDoiSoat(ExpDoiSoat doiSoat, List<ExpDoiSoatChiTiet> lsDoiSoatChiTiet, List<ExpDoiSoatChiTietCt> lsDoiSoatChiTietCt)
        {
            string mess = string.Empty;
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                dc.EXpdoisoat.InsertOnSubmit(base.ConnectionData.Schema, doiSoat);
                dc.EXpdoisoatchitiet.InsertAllSubmit(base.ConnectionData.Schema, lsDoiSoatChiTiet);
                foreach (var item in lsDoiSoatChiTietCt)
                {
                    ExpDoiSoatChiTietCt ct = dc.EXpdoisoatchitietct.GetObject(base.ConnectionData.Schema, item.BILL_CODE);
                    if (ct != null)
                    {
                        mess = mess + item.BILL_CODE + System.Environment.NewLine;
                    }
                    else
                    {
                        dc.EXpdoisoatchitietct.InsertOnSubmit(base.ConnectionData.Schema, item);
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
            return mess;
        }
        public ExpBalanceDetail GetCODDetail(string mavandon, string post)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpbalancedetail.GetObjectCon(base.ConnectionData.Schema, "WHERE MaChiPhi='SDSHK-F' AND MaDaiLy='" + post + "' AND BILL_CODE='" + mavandon + "'");
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
        public List<ExpBalanceDetail> GetBalanceDetailListC2(DateTime? fromCod, DateTime? toCod, string parentPost)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();//ThoiGianKetToan
                string condition = string.Empty;
                if (fromCod == null)
                {
                    condition = "WHERE ThoiGianKetToan <='" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", toCod) + "' &";
                }
                else if (toCod == null)
                {
                    condition = "WHERE ThoiGianKetToan >'" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", fromCod) + "' &";
                }
                else
                {
                    condition = "WHERE ThoiGianKetToan >'" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", fromCod) + "' AND ThoiGianKetToan <='" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", toCod) + "' &";
                }
                condition += " TrucThuocDaiLy='" + parentPost + "'";
                condition = condition.TrimEnd('&');
                condition = condition.Replace("&", "AND");
                condition += " ORDER BY ThoiGianKetToan ASC";
                return dc.EXpbalancedetail.GetListObjectCon(base.ConnectionData.Schema, condition);
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
        public decimal CheckSumAndCountBalanceDetail(string MaVanDon, string MaChiPhi, string MaDaiLy, out int CountRecord)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                DataTable data = dc.GetData("SELECT COUNT(*) AS NumberRecord, COALESCE(SUM(SoTien),0) AS SumRecord FROM ExpBalanceDetail WHERE BILL_CODE='" + MaVanDon + "' AND MaChiPhi='" + MaChiPhi + "' AND MaDaiLy ='" + MaDaiLy + "'");
                if (data.Rows.Count > 0)
                {
                    CountRecord = (int)decimal.Parse(data.Rows[0]["NumberRecord"].ToString());
                    return Math.Round(decimal.Parse(data.Rows[0]["SumRecord"].ToString()));
                }
                else
                {
                    CountRecord = 0;
                    return 0;
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
        public List<ExpCODCK> GetCODCKList(DateTime? fromCod, DateTime? toCod)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();//ThoiGianKetToan
                string condition = string.Empty;
                if (fromCod == null)
                {
                    condition = "WHERE CreateDate <='" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", toCod) + "' &";
                }
                else if (toCod == null)
                {
                    condition = "WHERE CreateDate >'" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", fromCod) + "' &";
                }
                else
                {
                    condition = "WHERE CreateDate >'" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", fromCod) + "' AND CreateDate <='" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", toCod) + "' &";
                }
                condition = condition.TrimEnd('&');
                condition = condition.Replace("&", "AND");
                condition += " ORDER BY CreateDate ASC";
                return dc.EXpcodck.GetListObjectCon(base.ConnectionData.Schema, condition);
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
        public List<ExpLoanCod> GetLoanCODList(DateTime? fromCod, DateTime? toCod)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();//ThoiGianKetToan
                string condition = string.Empty;
                if (fromCod == null)
                {
                    condition = "WHERE CreateDate <='" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", toCod) + "' &";
                }
                else if (toCod == null)
                {
                    condition = "WHERE CreateDate >'" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", fromCod) + "' &";
                }
                else
                {
                    condition = "WHERE CreateDate >'" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", fromCod) + "' AND CreateDate <='" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", toCod) + "' &";
                }
                condition = condition.TrimEnd('&');
                condition = condition.Replace("&", "AND");
                condition += " ORDER BY CreateDate ASC";
                return dc.EXploancod.GetListObjectCon(base.ConnectionData.Schema, condition);
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
        public List<ExpCustomer> GetCustomerListSend(string postID, string keyword = "")
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<ExpCustomer> list = new List<ExpCustomer>();
                if (string.IsNullOrEmpty(keyword))
                {
                    ExpCustomer exp = new ExpCustomer();
                    exp.Id = "1111";
                    exp.CustomerName = "Được phân công";
                    list.Add(exp);

                    List<ExpCustomerGroup> lsNhom = dc.EXpcustomergroup.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_Post=@FK_Post", "@FK_Post", postID);
                    foreach (var item in lsNhom)
                    {
                        exp = new ExpCustomer();
                        exp.Id = "GR" + item.Id;
                        exp.CustomerName = "BC - " + item.TenNhom;
                        list.Add(exp);
                    }

                    exp = new ExpCustomer();
                    exp.Id = "0000";
                    exp.CustomerName = "Tất cả";
                    list.Add(exp);
                    List<ExpCustomer> temp = dc.EXpcustomer.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_Post=@FK_Post ORDER BY CustomerName", "@FK_Post", postID);
                    foreach (var item in temp)
                    {
                        item.CustomerName = item.CustomerName + " - " + item.CustomerPhone;
                        list.Add(item);
                    }
                }
                else
                {
                    // Search
                    string searchKey = UnSigns(keyword);
                    List<ExpCustomer> temp = dc.EXpcustomer.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_Post=@FK_Post AND (UnsigName LIKE '%" + searchKey + "%' OR CustomerPhone LIKE '%" + searchKey + "%' OR CustomerName LIKE N'%" + searchKey + "%') ORDER BY CustomerName", "@FK_Post", postID);
                    foreach (var item in temp)
                    {
                        item.CustomerName = item.CustomerName + " - " + item.CustomerPhone;
                        list.Add(item);
                    }
                }


                return list;
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
        public List<ExpCustomer> GetCustomerListKL(string postID, string keyword = "")
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<ExpCustomer> list = new List<ExpCustomer>();
                // Search
                string searchKey = UnSigns(keyword);
                List<ExpCustomer> temp = dc.EXpcustomer.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_Post=@FK_Post AND (UnsigName LIKE '%" + searchKey + "%' OR CustomerPhone LIKE '%" + searchKey + "%' OR CustomerName LIKE N'%" + searchKey + "%') ORDER BY CustomerName", "@FK_Post", postID);
                foreach (var item in temp)
                {
                    item.CustomerName = item.CustomerName + " - " + item.CustomerPhone;
                    list.Add(item);
                }
                return list;
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
        public bool CheckProvinceProblem(string keyword)
        {
            bool provinceProblem = false;
            //
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                ExpProviceProblem exp = dc.EXpproviceproblem.GetObjectCon(base.ConnectionData.Schema, "WHERE ProvinceName LIKE '%" + keyword.ToUpper() + "%'");
                if (exp != null)
                {
                    provinceProblem = true;
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
            return provinceProblem;
        }
        public List<ExpCustomer> GetCustomerList(string postID)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<ExpCustomer> list = new List<ExpCustomer>();
                ExpCustomer exp = new ExpCustomer();
                exp.CustomerPhone = "0000";
                exp.CustomerName = "Tất cả";
                list.Add(exp);
                List<ExpCustomer> temp = dc.EXpcustomer.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_Post=@FK_Post ORDER BY CustomerName", "@FK_Post", postID);
                foreach (var item in temp)
                {
                    item.CustomerName = item.CustomerName + " - " + item.CustomerPhone;
                    list.Add(item);
                }

                return list;
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
        public List<ExpLoiNhuanBuuCuc> GetDaiLyKetToanList()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXploinhuanbuucuc.GetListObject(base.ConnectionData.Schema);
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
        public List<ExpBalanceDetailType> GetBalanceTypeList()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpbalancedetailtype.GetListObject(base.ConnectionData.Schema);
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
        public List<ExpCustomer> GetCustomerListNotAll(string postID)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<ExpCustomer> list = new List<ExpCustomer>();
                List<ExpCustomer> temp = dc.EXpcustomer.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_Post=@FK_Post ORDER BY CustomerName", "@FK_Post", postID);
                foreach (var item in temp)
                {
                    item.CustomerName = item.CustomerName + "-" + item.CustomerPhone;
                    list.Add(item);
                }

                return list;
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
        public DataTable GetListBill(string customerId, string status, string userId, string BILLCODE = "")
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Lấy dữ liệu trong vòng 45 ngày thôi

                string condition = "WHERE REGISTER_DATE >='" + string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddDays(-45)) + " 00:00:00' AND REGISTER_DATE <='" + string.Format("{0:yyyy-MM-dd}", DateTime.Now) + " 23:59:59' &";

                if (customerId.Contains("GR"))
                {
                    // Lấy danh sách theo group
                    condition += " FK_Customer IN (SELECT Id FROM ExpCustomer WHERE FK_Group='" + customerId.Replace("GR", "") + "') &";
                }
                else
                {
                    if (customerId == "0000")
                    {
                        // Chọn tất cả thì không có thêm điều kiện gì vào
                    }
                    else if (customerId == "1111")
                    {
                        // Chọn đơn theo khách hàng được phân công
                        condition += " FK_Customer IN (SELECT FK_Customer FROM ExpAccountCustomer WHERE FK_Account='" + userId + "') &";
                    }
                    else
                    {
                        // Chọn khách hàng
                        condition += " FK_Customer='" + customerId + "' &";
                    }
                }

                if (!string.IsNullOrEmpty(status))
                {
                    condition += " BILL_PROCESS_STATUS IN (" + status + ") &";
                }
                if (!string.IsNullOrEmpty(BILLCODE))
                {
                    condition += " BILL_CODE='" + BILLCODE + "' &";
                }
                condition = condition.TrimEnd('&');
                condition = condition.Replace("&", "AND");
                return dc.GetData("SELECT *, 0 KVD, '' LAST_KVD, '' FLAG, '' STT, '' KQ1, '' KQ2, '' KQ3, '' KQ4, '' KQ5, '' LAST_COMMENT, '' LAST_INTERNAL, '' LAST_POST_CUR, '' SUM_ADDRESS, CAST(0 AS int) DAY_LATE, '' EMPLOYEE_AD FROM view_ExpBILL " + condition);
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
        public List<ExpBILLStatus> GetBillStatus()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<ExpBILLStatus> list = new List<ExpBILLStatus>();
                ExpBILLStatus exp = new ExpBILLStatus();
                exp.Id = 100;
                exp.StatusName = "Tất cả";
                list.Add(exp);
                list.AddRange(dc.EXpbillstatus.GetListObjectCon(base.ConnectionData.Schema, "WHERE SelectNV=1 ORDER BY Id"));
                return list;
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
        public List<ExpBILLStatus> GetBillStatusNotAll()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<ExpBILLStatus> list = new List<ExpBILLStatus>();
                list.AddRange(dc.EXpbillstatus.GetListObjectCon(base.ConnectionData.Schema, "ORDER BY Id"));
                return list;
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
        public List<ExpLoiNhuanBuuCuc> GetDaiLyList()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXploinhuanbuucuc.GetListObject(base.ConnectionData.Schema);

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
        public string GetEmployee(string customerID)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string result = string.Empty;
                List<ExpAccountCustomer> lsCusAccount = dc.EXpaccountcustomer.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_Customer=@FK_Customer", "@FK_Customer", customerID);
                foreach (var item in lsCusAccount)
                {
                    result += item.FK_Account + ", ";
                }
                result = result.Trim();
                result = result.TrimEnd(',');
                return result;
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
        public int InsertHoaDon(List<ExpHoaDonDoiSoat> lsHoaDon)
        {
            int row = 0;
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                foreach (var item in lsHoaDon)
                {
                    ExpHoaDonDoiSoat hd = dc.EXphoadondoisoat.GetObject(base.ConnectionData.Schema, item.Id);
                    if (hd == null)
                    {
                        ExpHoaDonDoiSoatKL hoadonKL = dc.EXphoadondoisoatkl.GetObject(base.ConnectionData.Schema, item.Id);
                        if (hoadonKL != null)
                        {
                            item.HoaDon = hoadonKL.HoaDon;
                        }
                        dc.EXphoadondoisoat.InsertOnSubmit(base.ConnectionData.Schema, item);
                        row++;
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


            return row;


        }
        public ExpCustomer GetCustomerDetail(string customerId, string postId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpcustomer.GetObjectCon(base.ConnectionData.Schema, "WHERE FK_Post=@FK_Post AND (Id=@Id OR CustomerPhone=@CustomerPhone)", "@FK_Post", postId, "@Id", customerId, "@CustomerPhone", customerId);
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
        public void CreateCustomer(ExpCustomer cus)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                dc.EXpcustomer.InsertOnSubmit(base.ConnectionData.Schema, cus);
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

        public string UnSigns(string text)
        {
            string result = text.ToLower();
            string sign = "ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý";
            string unsign = "aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyy";
            for (int i = 0; i < sign.Length; i++)
            {
                result = result.Replace(sign.Substring(i, 1), unsign.Substring(i, 1));
            }
            return result;
        }
        public List<ExpSiteAutoRun> GetListSiteAuto()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpsiteautorun.GetListObject(base.ConnectionData.Schema);
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
        public ExpSiteAutoRun GetSiteAuto(string siteId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpsiteautorun.GetObject(base.ConnectionData.Schema, siteId);
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
        public List<ExpScanTT> GetScanSiteTTList(string Site)
        {
            List<ExpScanTT> ls = new List<ExpScanTT>();
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.EXpscantt.GetListObjectCon(base.ConnectionData.Schema, "WHERE ChangeSiteCode=@ChangeSiteCode AND IsUpdate=@IsUpdate AND ScanDate >='" + string.Format("{0:yyyy-MM-dd 00:00:00}", DateTime.Now) + "'", "@ChangeSiteCode", Site, "@IsUpdate", true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
            return ls;
        }
        public int AddScanTT(string BillCode, string ToSite, string FromSite, string createSiteCode, string scanManCode, string sendSiteCode, bool scanCome)
        {
            int result = 0;
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpScanTT scan = dc.EXpscantt.GetObjectCon(base.ConnectionData.Schema, "WHERE BillCode=@BillCode AND ScanDate>='" + string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now.AddMinutes(-30)) + "'", "@BillCode", BillCode);
                if (scan == null)
                {
                    scan = new ExpScanTT();
                    scan.Id = Guid.NewGuid().ToString();
                    scan.BillCode = BillCode;
                    scan.ToSite = ToSite.Trim();
                    scan.BillSite = createSiteCode.Trim();
                    scan.FromSite = FromSite.Trim();
                    scan.ScanManCode = scanManCode;
                    scan.ChangeSiteCode = ToSite.Trim();
                    if (!string.IsNullOrEmpty(scanManCode))
                    {
                        // Chuyển Code
                        ExpSiteAutoRun siteAutoRun = dc.EXpsiteautorun.GetObjectCon(base.ConnectionData.Schema, "WHERE UserId=@UserId", "@UserId", scanManCode);
                        if (siteAutoRun != null)
                        {
                            scan.ChangeSiteCode = siteAutoRun.SiteId;
                        }
                    }
                    // Đơn hàng hoàn tra mà có site code thì không kiểm tra
                    if (ToSite == sendSiteCode)
                    {
                        // Đơn hoàn trả.
                        scan.ErrorMessage = "Hoàn trả";
                    }
                    else
                    {
                        if (scan.ToSite == scan.BillSite)
                        {
                            scan.ErrorMessage = "Hàng gửi";
                        }
                        else
                        {
                            scan.ErrorMessage = "TTKT phân sai";
                        }
                    }
                    scan.IsUpdate = scanCome;
                    scan.ScanDate = dc.CurrentTime();
                    dc.EXpscantt.InsertOnSubmit(base.ConnectionData.Schema, scan);
                    dc.SubmitChanges();
                    result = 1;
                }
                else
                {
                    result = 2;
                }

            }
            catch
            {
                result = 0;
            }
            finally
            {
                dc.Close();
            }
            return result;
        }
        public string CheckAddress(string BillCode, string address, string huyenCode, string scanToSiteCode, string desSiteCode, string regisSiteCode, string sendSiteCode, out string mancode)
        {
            string codeOwner = "80174, 80104, 80105, 80112, VN80768, 8017413";
            mancode = string.Empty;
            string result = string.Empty;
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string realDestination = string.Empty;
                realDestination = scanToSiteCode;
                if (scanToSiteCode != desSiteCode && sendSiteCode != scanToSiteCode)
                {
                    // Quét gửi tào lao rồi
                }
                else
                {
                    // Lấy site code tạo đơn

                }

                List<ExpDestination> lsDestination = dc.EXpdestination.GetListObjectCon(base.ConnectionData.Schema, "WHERE Parrent='" + realDestination + "'");
                if (lsDestination.Count == 0)
                {
                    ExpLogErrorCheck errorCheck = new ExpLogErrorCheck();
                    errorCheck.Id = Guid.NewGuid().ToString();
                    errorCheck.BillCode = BillCode;
                    errorCheck.Address = address;
                    errorCheck.HuyenCode = huyenCode;
                    errorCheck.SiteCode = scanToSiteCode;
                    errorCheck.CreateSite = desSiteCode;
                    errorCheck.ManCode = mancode;
                    errorCheck.ResultCheck = 0;
                    dc.EXplogerrorcheck.InsertOnSubmit(base.ConnectionData.Schema, errorCheck);
                    dc.SubmitChanges();
                    return string.Empty;
                }
                else if (lsDestination.Count == 1)
                {
                    // Chỉ có 1 thì trả về
                    result = lsDestination[0].ExpId;
                    if (lsDestination[0].ScanCome == true)
                    {
                        mancode = lsDestination[0].AccountCode;
                    }
                }
                else if (lsDestination.Count > 1)
                {
                    // Có nhiều hơn
                    address = UnSigns(address);
                    huyenCode = UnSigns(huyenCode);

                    // Kiểm tra có phải đơn hoàn về không
                    // 
                    ExpDestination destination = lsDestination.FirstOrDefault(u => u.ExpId == desSiteCode);
                    if (destination == null)
                    {
                        destination = lsDestination.FirstOrDefault(u => u.KeyWord.Contains(address) || u.KeyWord.Contains(huyenCode));
                        if (destination == null)
                        {
                            destination = lsDestination.FirstOrDefault(u => u.SubCity.Contains(address) || u.SubCity.Contains(huyenCode));
                        }
                        if (destination != null)
                        {
                            result = destination.ExpId;
                            if (destination.ScanCome == true)
                            {
                                mancode = destination.AccountCode;
                            }
                        }
                        else
                        {
                            // Cuối cùng dữ liệu phải trả về nếu vẫn là null
                            ExpLogErrorCheck errorCheck = new ExpLogErrorCheck();
                            errorCheck.Id = Guid.NewGuid().ToString();
                            errorCheck.BillCode = BillCode;
                            errorCheck.Address = address;
                            errorCheck.HuyenCode = huyenCode;
                            errorCheck.SiteCode = scanToSiteCode;
                            errorCheck.CreateSite = desSiteCode;
                            errorCheck.ManCode = mancode;
                            errorCheck.ResultCheck = 1;
                            dc.EXplogerrorcheck.InsertOnSubmit(base.ConnectionData.Schema, errorCheck);
                            dc.SubmitChanges();

                            destination = lsDestination[0];
                            result = string.Empty;
                            if (destination.ScanCome == true)
                            {
                                mancode = destination.AccountCode;
                            }
                        }
                    }
                    else
                    {
                        result = destination.ExpId;
                        if (destination.ScanCome == true)
                        {
                            mancode = destination.AccountCode;
                        }
                    }
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
            return result;
        }
        public bool CheckContact(string mavandon)
        {
            bool payCod = false;
            //
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                ExpComment exp = dc.EXpcomment.GetObjectCon(base.ConnectionData.Schema, "WHERE BillCode='" + mavandon + "' AND CommentType='01'");
                if (exp != null)
                {
                    payCod = true;
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
            return payCod;
        }
        public bool CheckPayShipper(string mavandon, out string NgayNop)
        {
            bool payCod = false;
            NgayNop = string.Empty;
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpShipper exp = dc.EXpshipper.GetObjectCon(base.ConnectionData.Schema, "WHERE BillCode='" + mavandon + "'");
                if (exp != null)
                {
                    NgayNop = string.Format("{0:dd/MM/yyyy HH:mm:ss}", exp.PayDate) + " (" + exp.RealPay.ToString() + ")";
                    payCod = true;
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
            return payCod;
        }
        public int AddPayShipper(List<string> listMavanDon, List<string> listRequest, string shipper, string note)
        {
            int result = 0;
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                foreach (var item in listMavanDon)
                {
                    string temp = item.Trim().Replace(" ", "").Replace(",", "");
                    string[] split = temp.Split('-');
                    if (split.Length < 2)
                    {
                        continue;
                    }
                    ExpShipper exp = dc.EXpshipper.GetObjectCon(base.ConnectionData.Schema, "WHERE BillCode='" + split[0].Trim() + "'");
                    if (exp == null)
                    {
                        decimal SoTienTra = 0;
                        decimal SoTienThucTra = decimal.Parse(split[1].Trim());
                        string s = listRequest.FirstOrDefault(u => u.Contains(split[0].Trim()));
                        if (s != null)
                        {
                            SoTienTra = decimal.Parse(s.Split('-')[1].Trim().Replace(" ", "").Replace(",", ""));
                        }
                        exp = new ExpShipper();
                        exp.Id = Guid.NewGuid().ToString();
                        exp.Note = note;
                        exp.PayDate = DateTime.Now;
                        exp.RealPay = SoTienThucTra;
                        exp.RequestMoney = SoTienTra;
                        exp.Shipper = shipper;
                        exp.BillCode = split[0].Trim();
                        dc.EXpshipper.InsertOnSubmit(base.ConnectionData.Schema, exp);
                        result++;
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
            return result;
        }
        public void UpdateCustomer()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<ExpCustomer> ls = dc.EXpcustomer.GetListObject(base.ConnectionData.Schema);
                foreach (ExpCustomer item in ls)
                {
                    item.UnsigName = UnSigns(item.CustomerName);
                    dc.EXpcustomer.Update(base.ConnectionData.Schema, item);
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

        public string CommentOnBill(List<string> billCodes, string commentTypeId, string Content, string accountId, string status, string statusName, out bool UpdateStatus)
        {
            string result = string.Empty;
            UpdateStatus = false;
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                int sta;

                if (Int32.TryParse(status, out sta))
                {
                    foreach (var item in billCodes)
                    {
                        ExpBILL bill = dc.EXpbill.GetObject(base.ConnectionData.Schema, item);
                        if (bill != null)
                        {
                            // Comment
                            ExpComment comment = new ExpComment();
                            comment.Id = Guid.NewGuid().ToString();
                            comment.BillCode = item;
                            comment.Author = accountId;
                            if (bill.BILL_PROCESS_STATUS != sta)
                            {
                                Content = Content + "(Cập nhật TT: " + statusName + ")";
                                UpdateStatus = true;
                            }
                            comment.Comment = Content;
                            comment.CommentType = commentTypeId;
                            comment.UpdateDate = dc.CurrentTime();
                            dc.EXpcomment.InsertOnSubmit(base.ConnectionData.Schema, comment);
                            // Update trạng thái của bill
                            bill.BILL_PROCESS_STATUS = sta;
                            bill.LAST_UPDATE_DATE = dc.CurrentTime();
                            bill.LAST_UPDATE_USER = accountId;
                            dc.EXpbill.Update(base.ConnectionData.Schema, bill);
                        }

                    }
                }
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }
            finally
            {
                dc.Close();
            }
            return result;
        }
        public List<ExpCheckBalance> GetCheckBalance(string siteCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpcheckbalance.GetListObjectCon(base.ConnectionData.Schema, "WHERE Post=@Post ORDER BY CheckDate", "@Post", siteCode);
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
        public List<ExpCheckBalanceDetail> GetCheckBalanceDetail(string balance)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpcheckbalancedetail.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_CheckBalance=@FK_CheckBalance ORDER BY BalanceType", "@FK_CheckBalance", balance);
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
        public DataTable GetCheckBalanceTable(string siteCode, DateTime from, DateTime to)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpcheckbalance.GetDataTable(base.ConnectionData.Schema, "WHERE Post='" + siteCode + "' AND CheckDate >= '" + string.Format("{0:yyyy-MM-dd}", from) + " 00:00:00' AND CheckDate <= '" + string.Format("{0:yyyy-MM-dd}", to) + " 23:59:59.999' ORDER BY CheckDate");
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
        public DataTable GetCheckBalanceDetailTable(string siteCode, DateTime from, DateTime to)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.GetData("SELECT A.FK_CheckBalance, A.BalanceType, A.BalanceTypeName, A.MoneyValue FROM ExpCheckBalanceDetail A INNER JOIN ExpCheckBalance B ON A.FK_CheckBalance = B.Id WHERE B.Post='" + siteCode + "' AND B.CheckDate >= '" + string.Format("{0:yyyy-MM-dd}", from) + " 00:00:00' AND B.CheckDate <= '" + string.Format("{0:yyyy-MM-dd}", to) + " 23:59:59.999' ORDER BY B.CheckDate");
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
        public List<view_ExpComment> GetListCommentByBillCode(string BillCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpcomment.GetListObjectCon(base.ConnectionData.Schema, "WHERE BillCode=@BillCode ORDER BY UpdateDate", "@BillCode", BillCode);
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
        public List<ExpScan> GetListScanBillCode(string BillCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpscan.GetListObjectCon(base.ConnectionData.Schema, "WHERE BILL_CODE=@BILL_CODE ORDER BY CreateDate", "@BILL_CODE", BillCode);
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
        public ExpScan GetLastScanBillCode(string BillCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpscan.GetObjectCon(base.ConnectionData.Schema, "WHERE BILL_CODE=@BILL_CODE ORDER BY CreateDate desc", "@BILL_CODE", BillCode);
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
        //Trung tâm khai thác HCM
        public string CheckTTKTScanBillCode(string BillCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpScan scan = dc.EXpscan.GetObjectCon(base.ConnectionData.Schema, "WHERE BILL_CODE=@BILL_CODE AND Post=N'Trung tâm khai thác HCM'", "@BILL_CODE", BillCode);
                if (scan == null)
                {
                    return "KT Hàng thất lạc";
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
            return string.Empty;
        }
        public string CheckTTKTWeightScanBillCode(string BillCode, string billWeight)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpScan scan = dc.EXpscan.GetObjectCon(base.ConnectionData.Schema, "WHERE BILL_CODE=@BILL_CODE AND Post=N'Trung tâm khai thác HCM' AND TypeScan=N'Quét đến' ORDER BY CreateDate", "@BILL_CODE", BillCode);
                if (scan != null)
                {
                    decimal bill;
                    if (!decimal.TryParse(billWeight, out bill))
                    {
                        bill = 0;
                    }
                    decimal lechKg = scan.Weight - bill;
                    if (lechKg > 3)
                    {
                        return "Sai lệch " + lechKg.ToString() + " Kg";
                    }
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
            return string.Empty;
        }
        public List<ExpProblem> GetListKVDBillCode(string BillCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpproblem.GetListObjectCon(base.ConnectionData.Schema, "WHERE BILL_CODE=@BILL_CODE ORDER BY CreateDate", "@BILL_CODE", BillCode);
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
        public ExpProblem GetLastKVDBillCode(string BillCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpproblem.GetObjectCon(base.ConnectionData.Schema, "WHERE BILL_CODE=@BILL_CODE ORDER BY CreateDate desc", "@BILL_CODE", BillCode);
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
        public List<ExpInternal> GetListIntenalBillCode(string BillCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpinternal.GetListObjectCon(base.ConnectionData.Schema, "WHERE BILL_CODE=@BILL_CODE ORDER BY CreateDate", "@BILL_CODE", BillCode);
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
        public ExpInternal GetLastIntenalBillCode(string BillCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpinternal.GetObjectCon(base.ConnectionData.Schema, "WHERE BILL_CODE=@BILL_CODE ORDER BY CreateDate desc", "@BILL_CODE", BillCode);
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
        public ExpComment GetLastCommentBillCode(string BillCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpcomment.GetObjectCon(base.ConnectionData.Schema, "WHERE BillCode=@BillCode ORDER BY UpdateDate desc", "@BillCode", BillCode);
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
        public string CheckHoanTra(string BillCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpScan hoantra = dc.EXpscan.GetObjectCon(base.ConnectionData.Schema, "WHERE BILL_CODE=@BILL_CODE AND TypeScan='Hoàn'", "@BILL_CODE", BillCode);
                if (hoantra == null)
                {
                    string[] s = hoantra.Note.Split(',');
                    if (s.Length >= 3)
                    {
                        return s[1];
                    }
                    return hoantra.Note;
                }
                else
                {
                    return hoantra.Note;
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
        public async Task<List<ExpCommentType>> GetListCommentType()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpcommenttype.GetListObject(base.ConnectionData.Schema);
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
        public string GetQuickReport()
        {
            string report = string.Empty;
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();

                List<ExpComment> lsComment = dc.EXpcomment.GetListObjectCon(base.ConnectionData.Schema, "WHERE UpdateDate between '" + string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddDays(-7)) + " 00:00:00' and '" + string.Format("{0:yyyy-MM-dd}", DateTime.Now) + "  23:59:59'");
                for (int i = 0; i < 7; i++)
                {
                    DateTime dateTime = DateTime.Now.AddDays(-i);
                    List<ExpComment> subLit = lsComment.Where(u => u.UpdateDate.Date == dateTime.Date).ToList();
                    report += dateTime.Date.ToString("dd/MM/yyyy") + " (" + subLit.Count.ToString() + ")" + Environment.NewLine;
                    var q = from c in subLit
                            group c by c.Author into g
                            select new { g.Key, Count = g.Count() };
                    foreach (var item in q)
                    {
                        report += item.Key + " : " + item.Count + Environment.NewLine;
                    }
                    report += "---------------------" + Environment.NewLine;
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
            return report;
        }
        public void UpdateBT3(string billCode, string BT3Type, string BT3Code)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                dc.ExecuteNonQuery("UPDATE ExpBILL SET BT3Type=@BT3Type, BT3Code=@BT3Code WHERE BILL_CODE=@BILL_CODE",
                    "@BT3Type", BT3Type,
                    "@BT3Code", BT3Code,
                    "@BILL_CODE", billCode);
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
        public async Task<List<ExpBILLStatus>> GetListBillStatusType()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpbillstatus.GetListObjectCon(base.ConnectionData.Schema, "WHERE SelectNV=1 ORDER BY SortIndex");
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
        public async Task<List<ExpPost>> GetOnlyListExpPost(string idParrent)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXppost.GetListObjectCon(base.ConnectionData.Schema, "WHERE ParrentPost=@ParrentPost OR Code=@Code", "@ParrentPost", idParrent, "@Code", idParrent);
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
        public async Task<List<ExpPost>> GetListExpPost(string idParrent)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<ExpPost> items = dc.EXppost.GetListObjectCon(base.ConnectionData.Schema, "WHERE ParrentPost=@ParrentPost", "@ParrentPost", idParrent);
                ExpPost selectAll = new ExpPost();
                selectAll.Id = "0000";
                selectAll.Code = "0000";
                selectAll.TenDaiLy = "Tất cả";
                List<ExpPost> result = new List<ExpPost>();
                result.Add(selectAll);
                result.AddRange(items);
                return result;
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
        public async Task<List<ExpBalanceDetail>> GetListBalanceRutCOD(string IdPost)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<ExpBalanceDetail> items = dc.EXpbalancedetail.GetListObjectCon(base.ConnectionData.Schema, "WHERE MaDaiLy=@MaDaiLy AND MaChiPhi='TX-S' ORDER BY ThoiGianKetToan DESC", "@MaDaiLy", IdPost);
                ExpBalanceDetail selectAll = new ExpBalanceDetail();
                selectAll.Id = "0000";
                selectAll.KeyThoiGianKetToan = "- Không chọn -";
                List<ExpBalanceDetail> result = new List<ExpBalanceDetail>();
                result.Add(selectAll);
                result.AddRange(items);
                return result;
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
        public async Task<List<ExpConsignmentCashPayType>> GetMasterCashPayTypeList()
        {

            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();

                List<ExpConsignmentCashPayType> items = dc.EXpconsignmentcashpaytype.GetListObjectCon(base.ConnectionData.Schema, "WHERE UsingCashPay=1");
                ExpConsignmentCashPayType selectAll = new ExpConsignmentCashPayType();
                selectAll.Id = "0000";
                selectAll.TenLoai = "Tất cả";
                List<ExpConsignmentCashPayType> result = new List<ExpConsignmentCashPayType>();
                result.Add(selectAll);
                result.AddRange(items);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
        }

        public async Task<List<ExpPost>> GetListCashType(string idParrent)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<ExpPost> items = dc.EXppost.GetListObjectCon(base.ConnectionData.Schema, "WHERE ParrentPost=@ParrentPost", "@ParrentPost", idParrent);
                ExpPost selectAll = new ExpPost();
                selectAll.Id = "0000";
                selectAll.Code = "0000";
                selectAll.TenDaiLy = "Tất cả";
                List<ExpPost> result = new List<ExpPost>();
                result.Add(selectAll);
                result.AddRange(items);
                return result;
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
        public async Task<List<view_ExpCashPay>> GetListCash(string idPost, string typeId, DateTime from, DateTime to, bool isAll)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string sqlExt = string.Empty;
                if (typeId != "0000")
                {
                    sqlExt = " AND Type='" + typeId + "' ";
                }
                sqlExt += " AND (CreateDate between '" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", from) + "' AND '" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", to) + "')";
                return dc.VIewexpcashpay.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_ExtPost=@FK_ExtPost " + sqlExt + " ORDER BY CreateDate", "@FK_ExtPost", idPost);
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
        public async Task<string> ThuTienMuonTamUng(string IdQLTC, string userId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpCashPay item = dc.EXpcashpay.GetObject(base.ConnectionData.Schema, IdQLTC);
                if (item != null)
                {
                    item.SoChungTu = item.Id;
                    item.Id = Guid.NewGuid().ToString();
                    if (item.Type != "PAY_LOAN")
                    {
                        return "Không phải loại Tạm ứng/cho mượn nên không trả tiền được!";
                    }
                    item.IsPay = false;
                    item.CreateDate = dc.CurrentTime();
                    item.CreateBy = userId;
                    // Update ExpPost
                    ExpPost post = dc.EXppost.GetObject(base.ConnectionData.Schema, item.FK_ExtPost);
                    post.ValueBlanceMoney = post.ValueBlanceMoney + item.Value;
                    dc.EXppost.Update(base.ConnectionData.Schema, post);
                    item.AfterTotalValue = post.ValueBlanceMoney;
                    // Update value
                    dc.EXpcashpay.InsertOnSubmit(base.ConnectionData.Schema, item);
                    //Change Database
                    dc.SubmitChanges();
                    return string.Empty;
                }
                return "Không tìm thấy dữ liệu thu chi";
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
        public string CheckLoanCOD(string mavandon)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                ExpLoanCod exp = dc.EXploancod.GetObject(base.ConnectionData.Schema, mavandon);
                if (exp != null)
                {
                    if (exp.IsBoiThuong == false)
                        return exp.CreateBy + " tạm ứng " + string.Format("{0:dd/MM/yyyy}", exp.CreateDate);
                    else
                        return exp.CreateBy + " bồi thường " + string.Format("{0:dd/MM/yyyy}", exp.CreateDate);
                }
                else
                {
                    return string.Empty;
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
        public bool CheckHoaDonDoiSoat(string mavandon)
        {
            bool payCod = false;
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                ExpHoaDonDoiSoat exp = dc.EXphoadondoisoat.GetObjectCon(base.ConnectionData.Schema, "WHERE Id='" + mavandon + "'");
                if (exp != null)
                {
                    payCod = true;
                }
                else
                {
                    // Kiểm tra xem có phần chi tiền COD không?
                    ExpCashPay cash = dc.EXpcashpay.GetObjectCon(base.ConnectionData.Schema, "WHERE SoChungTu=@SoChungTu AND IsPay=@IsPay", "@SoChungTu", mavandon, "@IsPay", true);
                    if (cash != null)
                    {
                        payCod = true;
                    }
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
            return payCod;
        }
        public bool CheckHoaDonDoiSoatKL(string mavandon)
        {
            bool payCod = false;
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                ExpHoaDonDoiSoatKL exp = dc.EXphoadondoisoatkl.GetObjectCon(base.ConnectionData.Schema, "WHERE Id='" + mavandon + "'");
                if (exp != null)
                {
                    payCod = true;
                }
                else
                {
                    ExpHoaDonDoiSoat hd = dc.EXphoadondoisoat.GetObjectCon(base.ConnectionData.Schema, "WHERE Id='" + mavandon + "'");
                    if (hd != null)
                    {
                        payCod = true;
                    }
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
            return payCod;
        }
        public bool CheckPayCOD(string mavandon)
        {
            bool payCod = false;
            //
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                ExpCashPay exp = dc.EXpcashpay.GetObjectCon(base.ConnectionData.Schema, "WHERE SoChungTu='" + mavandon + "' AND Type='PAY_COD' AND IsPay=1");
                if (exp != null)
                {
                    payCod = true;
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
            return payCod;
        }

        public bool CheckCashCOD(string mavandon)
        {
            bool payCod = false;
            //
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                ExpCashPay exp = dc.EXpcashpay.GetObjectCon(base.ConnectionData.Schema, "WHERE SoChungTu='" + mavandon + "' AND Type='CASH_COD' AND IsPay=0");
                if (exp != null)
                {
                    payCod = true;
                }
                else
                {
                    ExpShipper shipper = dc.EXpshipper.GetObjectCon(base.ConnectionData.Schema, "WHERE BillCode='" + mavandon + "'");
                    if (shipper != null)
                    {
                        payCod = true;
                    }
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
            return payCod;
        }
        public string GetParrentPost(string postId)
        {
            //
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                ExpPost exp = dc.EXppost.GetObject(base.ConnectionData.Schema, postId);
                if (exp != null)
                {
                    return exp.ParrentPost;
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
            return string.Empty;
        }
        public int GetCashFee(string Provicder)
        {
            int payCod = 3;
            //
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                ExpGroupFee exp = dc.EXpgroupfee.GetObjectCon(base.ConnectionData.Schema, "WHERE KeyWord like '%" + Provicder + "%'");
                if (exp != null)
                {
                    payCod = exp.GroupFeeVal;
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
            return payCod;
        }
        public int GetPrice(ExpFee fee, double cannang)
        {
            int cuocChinh = 0;
            if (fee.InitFee > 0)
            {
                // Đơn giá tính theo kg
                if (cannang <= fee.InitWeight)
                {
                    cuocChinh = fee.InitFee;
                }
                else
                {
                    cuocChinh = fee.InitFee + (int)((cannang - fee.InitWeight) * fee.FeePerKg);
                }
            }
            else
            {
                // Đơn giá tính theo khung
                if (cannang <= fee.InitWeight)
                {
                    if (cannang <= 20)
                    {
                        cuocChinh = fee.Less20;
                    }
                    else if (cannang <= 50)
                    {
                        cuocChinh = fee.Less50;
                    }
                    else if (cannang <= 100)
                    {
                        cuocChinh = fee.Less100;
                    }
                    else if (cannang <= 300)
                    {
                        cuocChinh = fee.Less300;
                    }
                    else if (cannang <= 500)
                    {
                        cuocChinh = fee.Less500;
                    }
                    else if (cannang <= 1000)
                    {
                        cuocChinh = fee.Less1000;
                    }
                    else
                    {
                        cuocChinh = fee.ElseFee;
                    }
                }
                else
                {
                    if (cannang <= 20)
                    {
                        cuocChinh = (int)(cannang * fee.Less20);
                    }
                    else if (cannang <= 50)
                    {
                        cuocChinh = (int)(cannang * fee.Less50);
                    }
                    else if (cannang <= 100)
                    {
                        cuocChinh = (int)(cannang * fee.Less100);
                    }
                    else if (cannang <= 300)
                    {
                        cuocChinh = (int)(cannang * fee.Less300);
                    }
                    else if (cannang <= 500)
                    {
                        cuocChinh = (int)(cannang * fee.Less500);
                    }
                    else if (cannang <= 1000)
                    {
                        cuocChinh = (int)(cannang * fee.Less1000);
                    }
                    else
                    {
                        cuocChinh = (int)(cannang * fee.ElseFee);
                    }
                }
            }
            return cuocChinh;
        }
        public int GetFromFee(ExpFee fee, double cannang)
        {
            int cuocChinh = 0;
            if (fee.InitFee > 0)
            {
                // Đơn giá tính theo kg
                if (cannang <= fee.InitWeight)
                {
                    cuocChinh = fee.InitFeeFrom;
                }
                else
                {
                    cuocChinh = fee.InitFeeFrom + (int)((cannang - fee.InitWeight) * fee.FeePerKgFrom);
                }
            }
            else
            {
                if (fee.InitFeeFrom < 0)
                {
                    return -1;
                }
                // Đơn giá tính theo khung
                if (cannang <= fee.InitWeight)
                {
                    if (cannang <= 20)
                    {
                        cuocChinh = fee.Less20From;
                    }
                    else if (cannang <= 50)
                    {
                        cuocChinh = fee.Less50From;
                    }
                    else if (cannang <= 100)
                    {
                        cuocChinh = fee.Less100From;
                    }
                    else if (cannang <= 300)
                    {
                        cuocChinh = fee.Less300From;
                    }
                    else if (cannang <= 500)
                    {
                        cuocChinh = fee.Less500From;
                    }
                    else if (cannang <= 1000)
                    {
                        cuocChinh = fee.Less1000From;
                    }
                    else
                    {
                        cuocChinh = fee.ElseFeeFrom;
                    }
                }
                else
                {
                    if (cannang <= 20)
                    {
                        cuocChinh = (int)(cannang * fee.Less20From);
                    }
                    else if (cannang <= 50)
                    {
                        cuocChinh = (int)(cannang * fee.Less50From);
                    }
                    else if (cannang <= 100)
                    {
                        cuocChinh = (int)(cannang * fee.Less100From);
                    }
                    else if (cannang <= 300)
                    {
                        cuocChinh = (int)(cannang * fee.Less300From);
                    }
                    else if (cannang <= 500)
                    {
                        cuocChinh = (int)(cannang * fee.Less500From);
                    }
                    else if (cannang <= 1000)
                    {
                        cuocChinh = (int)(cannang * fee.Less1000From);
                    }
                    else
                    {
                        cuocChinh = (int)(cannang * fee.ElseFeeFrom);
                    }
                }
            }
            return cuocChinh;
        }
        public int GetToFee(ExpFee fee, double cannang)
        {
            int cuocChinh = 0;
            if (fee.InitFee > 0)
            {
                // Đơn giá tính theo kg
                if (cannang <= fee.InitWeight)
                {
                    cuocChinh = fee.InitFeeTo;
                }
                else
                {
                    cuocChinh = fee.InitFeeTo + (int)((cannang - fee.InitWeight) * fee.FeePerKgTo);
                }
            }
            else
            {
                if (fee.InitFeeTo < 0)
                {
                    return -1;
                }
                // Đơn giá tính theo khung
                if (cannang <= fee.InitWeight)
                {
                    if (cannang <= 20)
                    {
                        cuocChinh = fee.Less20To;
                    }
                    else if (cannang <= 50)
                    {
                        cuocChinh = fee.Less50To;
                    }
                    else if (cannang <= 100)
                    {
                        cuocChinh = fee.Less100To;
                    }
                    else if (cannang <= 300)
                    {
                        cuocChinh = fee.Less300To;
                    }
                    else if (cannang <= 500)
                    {
                        cuocChinh = fee.Less500To;
                    }
                    else if (cannang <= 1000)
                    {
                        cuocChinh = fee.Less1000To;
                    }
                    else
                    {
                        cuocChinh = fee.ElseFeeTo;
                    }
                }
                else
                {
                    if (cannang <= 20)
                    {
                        cuocChinh = (int)(cannang * fee.Less20To);
                    }
                    else if (cannang <= 50)
                    {
                        cuocChinh = (int)(cannang * fee.Less50To);
                    }
                    else if (cannang <= 100)
                    {
                        cuocChinh = (int)(cannang * fee.Less100To);
                    }
                    else if (cannang <= 300)
                    {
                        cuocChinh = (int)(cannang * fee.Less300To);
                    }
                    else if (cannang <= 500)
                    {
                        cuocChinh = (int)(cannang * fee.Less500To);
                    }
                    else if (cannang <= 1000)
                    {
                        cuocChinh = (int)(cannang * fee.Less1000To);
                    }
                    else
                    {
                        cuocChinh = (int)(cannang * fee.ElseFeeTo);
                    }
                }
            }
            return cuocChinh;
        }
        public int GetSysFee(ExpFee fee, double cannang)
        {
            int cuocChinh = 0;
            if (fee.InitFee > 0)
            {
                // Đơn giá tính theo kg
                if (cannang <= fee.InitWeight)
                {
                    cuocChinh = fee.InitFeeSys;
                }
                else
                {
                    cuocChinh = fee.InitFeeSys + (int)((cannang - fee.InitWeight) * fee.FeePerKgSys);
                }
            }
            else
            {
                if (fee.InitFeeSys < 0)
                {
                    return -1;
                }
                // Đơn giá tính theo khung
                if (cannang <= fee.InitWeight)
                {
                    if (cannang <= 20)
                    {
                        cuocChinh = fee.Less20Sys;
                    }
                    else if (cannang <= 50)
                    {
                        cuocChinh = fee.Less50Sys;
                    }
                    else if (cannang <= 100)
                    {
                        cuocChinh = fee.Less100Sys;
                    }
                    else if (cannang <= 300)
                    {
                        cuocChinh = fee.Less300Sys;
                    }
                    else if (cannang <= 500)
                    {
                        cuocChinh = fee.Less500Sys;
                    }
                    else if (cannang <= 1000)
                    {
                        cuocChinh = fee.Less1000Sys;
                    }
                    else
                    {
                        cuocChinh = fee.ElseFeeSys;
                    }
                }
                else
                {
                    if (cannang <= 20)
                    {
                        cuocChinh = (int)(cannang * fee.Less20Sys);
                    }
                    else if (cannang <= 50)
                    {
                        cuocChinh = (int)(cannang * fee.Less50Sys);
                    }
                    else if (cannang <= 100)
                    {
                        cuocChinh = (int)(cannang * fee.Less100Sys);
                    }
                    else if (cannang <= 300)
                    {
                        cuocChinh = (int)(cannang * fee.Less300Sys);
                    }
                    else if (cannang <= 500)
                    {
                        cuocChinh = (int)(cannang * fee.Less500Sys);
                    }
                    else if (cannang <= 1000)
                    {
                        cuocChinh = (int)(cannang * fee.Less1000Sys);
                    }
                    else
                    {
                        cuocChinh = (int)(cannang * fee.ElseFeeSys);
                    }
                }
            }
            return cuocChinh;
        }
        public async Task<string> ScanFinishV2(string toPostId, string expPostName, string deliveryId, string deliveryName, string accountId, string Id, string sysPost)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                DateTime currentDate = dc.CurrentTime();
                ExpConsignment consig = dc.EXpconsignment.GetObject(ConnectionData.Schema, Id);
                if (consig != null)
                {
                    if (consig.FK_ExpStatus == "FINISH")
                    {
                        return "Đơn hàng đã được ký nhận. Không thể ký nhận tiếp.";
                    }
                    ExpPost postFrom = dc.EXppost.GetObject(ConnectionData.Schema, consig.FK_ExpPostFrom);
                    ExpPost postTo = dc.EXppost.GetObject(ConnectionData.Schema, toPostId);
                    ExpPost postTT = dc.EXppost.GetObject(ConnectionData.Schema, sysPost);
                    if (postFrom == null || postTo == null || postTT == null)
                    {
                        return "Mã bưu cục không tồn tại. Vui lòng liên hệ quản trị";
                    }
                    // Lấy đơn giá của From và To
                    ExpFee feeFrom = await GetDetailFee(consig.FK_ExpProvider, consig.FK_ExpPostFrom);
                    if (feeFrom == null)
                    {
                        return "Cấu hình bảng giá chưa có trên hệ thống không thể ký nhận. Vui lòng liên hệ quản trị";
                    }
                    if (postFrom.Id == postTo.Id)
                    {
                        return "Bạn đã quá rảnh rỗi để tạo đơn hàng cho chính mình rồi tự giao luôn. Rảnh quá thì ngồi đánh bài đi nè!";
                    }
                    // Kiểm tra kiện hàng có quét cùng một thời điểm hay không
                    // History
                    ExpConsignmentHistory history = new ExpConsignmentHistory();
                    history.Id = Guid.NewGuid().ToString();
                    history.CreateDate = currentDate;
                    history.FK_ExpConsignment = consig.Id;
                    history.FK_ExpStatus = "FINISH";
                    history.FK_ExpPost = toPostId;
                    history.Note = "Ký nhận giao hàng thành công tại bưu cục  " + expPostName;
                    history.CreateBy = accountId;
                    // Insert History
                    dc.EXpconsignmenthistory.InsertOnSubmit(ConnectionData.Schema, history);
                    // Update trạng thái của đơn hàng
                    consig.FK_ExpStatus = "FINISH";
                    consig.FK_NhanVienPhat = deliveryId;
                    consig.HoTenNguoiKyNhan = deliveryName;
                    dc.EXpconsignment.Update(ConnectionData.Schema, consig);

                    // Kết toán hệ thống
                    ExpConsignmentCashPay syscash = new ExpConsignmentCashPay();
                    // 1. Tính toán tiền nong với hệ thống nếu phí hệ thống, hoặc phí vận chuyển nội tỉnh hoặc phí vận chuyển ngoại tỉnh >0
                    if (feeFrom.InternalFee > 0 || feeFrom.SystemFee > 0 || feeFrom.ExternalFee > 0)
                    {
                        if (consig.FK_CachThanhToan == "01")
                        {
                            // Người gửi trả phí thì mình cho From => System
                            // Phí hệ thống FROM => TT
                            if (feeFrom.SystemFee > 0)
                            {
                                syscash = new ExpConsignmentCashPay();
                                syscash.Id = Guid.NewGuid().ToString();
                                syscash.FK_ExtPostFrom = postFrom.Id;
                                syscash.CurrentExtPostFrom = postFrom.ValueBlance;
                                syscash.FK_ExtPostTo = postTT.Id;
                                syscash.CurrentExtPostTo = postTT.ValueBlance;
                                syscash.Value = feeFrom.SystemFee;
                                syscash.CreateDate = currentDate.AddSeconds(1);
                                syscash.CreateBy = accountId;
                                syscash.FK_ExpConsignment = consig.Id;
                                syscash.Type = "OPER";
                                syscash.Note = "Phí thao tác và hệ thống " + postFrom.TenDaiLy + " trả cho hệ thống.";
                                syscash.IsDelete = false;
                                dc.EXpconsignmentcashpay.InsertOnSubmit(ConnectionData.Schema, syscash);
                                // ++/-- Update EXP Post
                                postTT.ValueBlance += syscash.Value;
                                postFrom.ValueBlance -= syscash.Value;
                            }
                            if (feeFrom.InternalFee > 0)
                            {
                                // Phí thao tác chung nội tỉnh FROM => TT
                                syscash = new ExpConsignmentCashPay();
                                syscash.Id = Guid.NewGuid().ToString();
                                syscash.FK_ExtPostFrom = postFrom.Id;
                                syscash.CurrentExtPostFrom = postFrom.ValueBlance;
                                syscash.FK_ExtPostTo = postTT.Id;
                                syscash.CurrentExtPostTo = postTT.ValueBlance;
                                syscash.Value = feeFrom.InternalFee;
                                syscash.CreateDate = currentDate.AddSeconds(2);
                                syscash.CreateBy = accountId;
                                syscash.FK_ExpConsignment = consig.Id;
                                syscash.Type = "TRANSIT_INT";
                                syscash.Note = "Phí trung chuyển nội tỉnh " + postFrom.TenDaiLy + " trả cho hệ thống";
                                syscash.IsDelete = false;
                                dc.EXpconsignmentcashpay.InsertOnSubmit(ConnectionData.Schema, syscash);
                                // ++/-- Update EXP Post
                                postTT.ValueBlance += syscash.Value;
                                postFrom.ValueBlance -= syscash.Value;
                            }
                            if (feeFrom.ExternalFee > 0)
                            {
                                // Phí thao tác chung nội tỉnh FROM => TT
                                syscash = new ExpConsignmentCashPay();
                                syscash.Id = Guid.NewGuid().ToString();
                                syscash.FK_ExtPostFrom = postFrom.Id;
                                syscash.CurrentExtPostFrom = postFrom.ValueBlance;
                                syscash.FK_ExtPostTo = postTT.Id;
                                syscash.CurrentExtPostTo = postTT.ValueBlance;
                                syscash.Value = feeFrom.ExternalFee;
                                syscash.CreateDate = currentDate.AddSeconds(3);
                                syscash.CreateBy = accountId;
                                syscash.FK_ExpConsignment = consig.Id;
                                syscash.Type = "TRANSIT_EXT";
                                syscash.Note = "Phí trung chuyển ngoại tỉnh " + postFrom.TenDaiLy + " trả cho hệ thống";
                                syscash.IsDelete = false;
                                dc.EXpconsignmentcashpay.InsertOnSubmit(ConnectionData.Schema, syscash);
                                // ++/-- Update EXP Post
                                postTT.ValueBlance += syscash.Value;
                                postFrom.ValueBlance -= syscash.Value;
                            }

                        }
                        else if (consig.FK_CachThanhToan == "02")
                        {
                            // Phí hệ thống TO => TT
                            if (feeFrom.SystemFee > 0)
                            {
                                syscash = new ExpConsignmentCashPay();
                                syscash.Id = Guid.NewGuid().ToString();
                                syscash.FK_ExtPostFrom = postTo.Id;
                                syscash.CurrentExtPostFrom = postTo.ValueBlance;
                                syscash.FK_ExtPostTo = postTT.Id;
                                syscash.CurrentExtPostTo = postTT.ValueBlance;
                                syscash.Value = feeFrom.SystemFee;
                                syscash.CreateDate = currentDate.AddSeconds(1);
                                syscash.CreateBy = accountId;
                                syscash.FK_ExpConsignment = consig.Id;
                                syscash.Type = "OPER";
                                syscash.Note = "Phí thao tác và hệ thống [" + postTo.TenDaiLy + "] trả giùm [" + postFrom.TenDaiLy + "] cho hệ thống";
                                syscash.IsDelete = false;
                                dc.EXpconsignmentcashpay.InsertOnSubmit(ConnectionData.Schema, syscash);
                                // ++/-- Update EXP Post
                                postTT.ValueBlance += syscash.Value;
                                postTo.ValueBlance -= syscash.Value;
                            }
                            if (feeFrom.InternalFee > 0)
                            {
                                // Phí thao tác chung nội tỉnh TO => TT
                                syscash = new ExpConsignmentCashPay();
                                syscash.Id = Guid.NewGuid().ToString();
                                syscash.FK_ExtPostFrom = postTo.Id;
                                syscash.CurrentExtPostFrom = postTo.ValueBlance;
                                syscash.FK_ExtPostTo = postTT.Id;
                                syscash.CurrentExtPostTo = postTT.ValueBlance;
                                syscash.Value = feeFrom.InternalFee;
                                syscash.CreateDate = currentDate.AddSeconds(2);
                                syscash.CreateBy = accountId;
                                syscash.FK_ExpConsignment = consig.Id;
                                syscash.Type = "TRANSIT_INT";
                                syscash.Note = "Phí trung chuyển nội tỉnh [" + postTo.TenDaiLy + "] trả giùm [" + postFrom.TenDaiLy + "] cho hệ thống";
                                syscash.IsDelete = false;
                                dc.EXpconsignmentcashpay.InsertOnSubmit(ConnectionData.Schema, syscash);
                                // ++/-- Update EXP Post
                                postTT.ValueBlance += syscash.Value;
                                postTo.ValueBlance -= syscash.Value;
                            }
                            if (feeFrom.ExternalFee > 0)
                            {
                                // Phí thao tác chung nội tỉnh TO => TT
                                syscash = new ExpConsignmentCashPay();
                                syscash.Id = Guid.NewGuid().ToString();
                                syscash.FK_ExtPostFrom = postTo.Id;
                                syscash.CurrentExtPostFrom = postTo.ValueBlance;
                                syscash.FK_ExtPostTo = postTT.Id;
                                syscash.CurrentExtPostTo = postTT.ValueBlance;
                                syscash.Value = feeFrom.ExternalFee;
                                syscash.CreateDate = currentDate.AddSeconds(3);
                                syscash.CreateBy = accountId;
                                syscash.FK_ExpConsignment = consig.Id;
                                syscash.Type = "TRANSIT_EXT";
                                syscash.Note = "Phí trung chuyển ngoại tỉnh [" + postTo.TenDaiLy + "] trả giùm [" + postFrom.TenDaiLy + "] cho hệ thống";
                                syscash.IsDelete = false;
                                dc.EXpconsignmentcashpay.InsertOnSubmit(ConnectionData.Schema, syscash);
                                // ++/-- Update EXP Post
                                postTT.ValueBlance += syscash.Value;
                                postTo.ValueBlance -= syscash.Value;
                            }
                        }
                    }
                    // 2. Tính toán tiền nong giữa nơi gửi và nơi nhận
                    int TongCuocVC = consig.CuocPhiChinh + consig.CuocCongThem + consig.PhuPhi;
                    int soTienPhieuThu = 0;
                    double cannang = ((double)consig.TrongLuongGram / 1000);

                    int phiGiaoHang = GetToFee(feeFrom, cannang);
                    if (phiGiaoHang < 100 && phiGiaoHang > 0)
                    {
                        phiGiaoHang = (int)(TongCuocVC * phiGiaoHang) / 100;
                    }
                    int phiNhanHang = GetFromFee(feeFrom, cannang);// Nếu = -1 là trừ hết khoản phát hàng và hệ thống thì còn lại là của người gửi
                    if (phiNhanHang < 100 && phiNhanHang > 0)
                    {
                        phiNhanHang = (int)(TongCuocVC * phiNhanHang) / 100;
                    }

                    int phiHeThong = GetSysFee(feeFrom, cannang);
                    if (phiHeThong < 100 && phiHeThong > 0)
                    {
                        phiHeThong = (int)(TongCuocVC * phiHeThong) / 100;
                    }

                    // ### 1. NGƯỜI GỬI TRẢ
                    if (consig.FK_CachThanhToan == "01")
                    {
                        // 1.A. Trả tiền giao hàng cho TO
                        if (phiGiaoHang > 0)
                        {
                            // Nếu người gửi trả thì FROM phải trả tiền giao hàng cho TO
                            syscash.Id = Guid.NewGuid().ToString();
                            syscash.FK_ExtPostFrom = postFrom.Id;
                            syscash.CurrentExtPostFrom = postFrom.ValueBlance;
                            syscash.FK_ExtPostTo = postTo.Id;
                            syscash.CurrentExtPostTo = postTo.ValueBlance;
                            syscash.Value = phiGiaoHang;
                            syscash.CreateDate = currentDate.AddSeconds(4);
                            syscash.CreateBy = accountId;
                            syscash.FK_ExpConsignment = consig.Id;
                            syscash.Type = "DELIVERY";
                            syscash.Note = "Phí giao hàng " + postFrom.TenDaiLy + " trả cho " + postTo.TenDaiLy;
                            syscash.IsDelete = false;
                            dc.EXpconsignmentcashpay.InsertOnSubmit(ConnectionData.Schema, syscash);
                            // ++/-- Update EXP Post
                            postTo.ValueBlance += syscash.Value;
                            postFrom.ValueBlance -= syscash.Value;
                        }
                        // 1.B Hệ thống -1 thì toàn bộ tiền sau khi trừ tiền cho hoa hồng, phí giao hàng, phí hệ thống cố định được đưa cho hệ thống
                        if (phiHeThong < 0)
                        {
                            if (phiNhanHang < 0)
                            {
                                phiNhanHang = 0;
                            }
                            // Người gửi trả thì FROM => SYS số tiền còn là sau  khi trừ tiền hoa hồng, phí giao hàng, phí hệ thống cố định
                            syscash = new ExpConsignmentCashPay();
                            syscash.Id = Guid.NewGuid().ToString();
                            syscash.FK_ExtPostFrom = postFrom.Id;
                            syscash.CurrentExtPostFrom = postFrom.ValueBlance;
                            syscash.FK_ExtPostTo = postTT.Id;
                            syscash.CurrentExtPostTo = postTT.ValueBlance;
                            syscash.Value = TongCuocVC - phiGiaoHang - phiNhanHang - feeFrom.InternalFee - feeFrom.ExternalFee - feeFrom.SystemFee;
                            syscash.CreateDate = currentDate.AddSeconds(5);
                            syscash.CreateBy = accountId;
                            syscash.FK_ExpConsignment = consig.Id;
                            syscash.Type = "TRANSIT_EXT";
                            syscash.Note = "Phí vận tải do " + postFrom.TenDaiLy + " trả cho hệ thống";
                            syscash.IsDelete = false;
                            dc.EXpconsignmentcashpay.InsertOnSubmit(ConnectionData.Schema, syscash);
                            // ++/-- Update EXP Post
                            postTT.ValueBlance += syscash.Value;
                            postFrom.ValueBlance -= syscash.Value;
                        }
                        else
                        {
                            // 1.C Hệ thống là 1 con số
                            if (phiHeThong > 0)
                            {
                                // 1.C Hệ thống > 0 thì chuyển đúng số tiền cho hệ thống thôi
                                syscash = new ExpConsignmentCashPay();
                                syscash.Id = Guid.NewGuid().ToString();
                                syscash.FK_ExtPostFrom = postFrom.Id;
                                syscash.CurrentExtPostFrom = postFrom.ValueBlance;
                                syscash.FK_ExtPostTo = postTT.Id;
                                syscash.CurrentExtPostTo = postTT.ValueBlance;
                                syscash.Value = phiHeThong;
                                syscash.CreateDate = currentDate.AddSeconds(5);
                                syscash.CreateBy = accountId;
                                syscash.FK_ExpConsignment = consig.Id;
                                syscash.Type = "TRANSIT_EXT";
                                syscash.Note = "Phí vận tải do " + postFrom.TenDaiLy + " trả cho hệ thống";
                                syscash.IsDelete = false;
                                dc.EXpconsignmentcashpay.InsertOnSubmit(ConnectionData.Schema, syscash);
                                // ++/-- Update EXP Post
                                postTT.ValueBlance += syscash.Value;
                                postFrom.ValueBlance -= syscash.Value;
                            }
                        }
                    }
                    //##### 2. NGƯỜI NHẬN TRẢ
                    else if (consig.FK_CachThanhToan == "02")
                    {
                        soTienPhieuThu += TongCuocVC;
                        //2.A.i Hệ thống = -1
                        if (phiHeThong < 0)
                        {
                            // 2.A.i CHI TRẢ LỢI NHUẬN FROM, PHẦN TIỀN CÒN LẠI HỆ THỐNG LẤY HẾT
                            if (phiNhanHang < 0)
                            {
                                phiNhanHang = 0;
                            }
                            if (phiNhanHang > 0)
                            {
                                // Người nhận trả thì TO => FROM lợi nhuận gửi hàng
                                syscash.Id = Guid.NewGuid().ToString();
                                syscash.FK_ExtPostFrom = postTo.Id;
                                syscash.CurrentExtPostFrom = postTo.ValueBlance;
                                syscash.FK_ExtPostTo = postFrom.Id;
                                syscash.CurrentExtPostTo = postFrom.ValueBlance;
                                // Tiền trả hoa hồng cho bưu cục nhận hàng
                                syscash.Value = phiNhanHang;
                                syscash.CreateDate = currentDate.AddSeconds(5);
                                syscash.CreateBy = accountId;
                                syscash.FK_ExpConsignment = consig.Id;
                                syscash.Type = "PROFIT";
                                syscash.Note = "Lợi nhuận gửi hàng " + postTo.TenDaiLy + " hoàn trả " + postFrom.TenDaiLy;
                                syscash.IsDelete = false;
                                dc.EXpconsignmentcashpay.InsertOnSubmit(ConnectionData.Schema, syscash);
                                // ++/-- Update EXP Post
                                postTo.ValueBlance -= syscash.Value;
                                postFrom.ValueBlance += syscash.Value;
                            }
                            // 2.A.ii Người nhận trả thì TO => SYS số tiền còn là sau  khi trừ hết chi phí
                            syscash = new ExpConsignmentCashPay();
                            syscash.Id = Guid.NewGuid().ToString();
                            syscash.FK_ExtPostFrom = postTo.Id;
                            syscash.CurrentExtPostFrom = postTo.ValueBlance;
                            syscash.FK_ExtPostTo = postTT.Id;
                            syscash.CurrentExtPostTo = postTT.ValueBlance;
                            syscash.Value = TongCuocVC - phiGiaoHang - phiNhanHang - feeFrom.InternalFee - feeFrom.ExternalFee - feeFrom.SystemFee;
                            syscash.CreateDate = currentDate.AddSeconds(5);
                            syscash.CreateBy = accountId;
                            syscash.FK_ExpConsignment = consig.Id;
                            syscash.Type = "TRANSIT_EXT";
                            syscash.Note = "Phí vận tải do " + postFrom.TenDaiLy + " trả cho hệ thống";
                            syscash.IsDelete = false;
                            dc.EXpconsignmentcashpay.InsertOnSubmit(ConnectionData.Schema, syscash);
                            // ++/-- Update EXP Post
                            postTT.ValueBlance += syscash.Value;
                            postTo.ValueBlance -= syscash.Value;
                        }
                        //2.B HỆ THỐNG LÀ MỘT CON SỐ
                        else
                        {
                            //2.B.i Lợi nhuận -1
                            if (phiNhanHang < 0)
                            {
                                //2.B.i.1 Trả tiền hệ thống
                                if (phiHeThong > 0)
                                {
                                    // Người nhận trả thì TO => SYS số tiền hệ thống
                                    syscash = new ExpConsignmentCashPay();
                                    syscash.Id = Guid.NewGuid().ToString();
                                    syscash.FK_ExtPostFrom = postTo.Id;
                                    syscash.CurrentExtPostFrom = postTo.ValueBlance;
                                    syscash.FK_ExtPostTo = postTT.Id;
                                    syscash.CurrentExtPostTo = postTT.ValueBlance;
                                    syscash.Value = phiHeThong;
                                    syscash.CreateDate = currentDate.AddSeconds(5);
                                    syscash.CreateBy = accountId;
                                    syscash.FK_ExpConsignment = consig.Id;
                                    syscash.Type = "TRANSIT_EXT";
                                    syscash.Note = "Phí vận tải do " + postFrom.TenDaiLy + " trả cho hệ thống";
                                    syscash.IsDelete = false;
                                    dc.EXpconsignmentcashpay.InsertOnSubmit(ConnectionData.Schema, syscash);
                                    // ++/-- Update EXP Post
                                    postTT.ValueBlance += syscash.Value;
                                    postTo.ValueBlance -= syscash.Value;
                                }
                                // 2.B.i.2 Lợi nhuận lấy toàn bộ sau khi chi trả tiền giao hàng, tiền hệ thống và phí cố định
                                syscash.Id = Guid.NewGuid().ToString();
                                syscash.FK_ExtPostFrom = postTo.Id;
                                syscash.CurrentExtPostFrom = postTo.ValueBlance;
                                syscash.FK_ExtPostTo = postFrom.Id;
                                syscash.CurrentExtPostTo = postFrom.ValueBlance;
                                // Tiền trả hoa hồng cho bưu cục nhận hàng
                                syscash.Value = TongCuocVC - phiGiaoHang - phiHeThong - feeFrom.InternalFee - feeFrom.ExternalFee - feeFrom.SystemFee;
                                syscash.CreateDate = currentDate.AddSeconds(4);
                                syscash.CreateBy = accountId;
                                syscash.FK_ExpConsignment = consig.Id;
                                syscash.Type = "PROFIT";
                                syscash.Note = "Lợi nhuận gửi hàng " + postTo.TenDaiLy + " hoàn trả " + postFrom.TenDaiLy;
                                syscash.IsDelete = false;
                                dc.EXpconsignmentcashpay.InsertOnSubmit(ConnectionData.Schema, syscash);
                                // ++/-- Update EXP Post
                                postTo.ValueBlance -= syscash.Value;
                                postFrom.ValueBlance += syscash.Value;
                            }
                            //2.B.ii Lợi nhuận là 1 con số
                            else
                            {
                                if (phiNhanHang > 0)
                                {
                                    // Người nhận trả thì TO => FROM 15% hoa hồng
                                    syscash.Id = Guid.NewGuid().ToString();
                                    syscash.FK_ExtPostFrom = postTo.Id;
                                    syscash.CurrentExtPostFrom = postTo.ValueBlance;
                                    syscash.FK_ExtPostTo = postFrom.Id;
                                    syscash.CurrentExtPostTo = postFrom.ValueBlance;
                                    // Tiền trả hoa hồng cho bưu cục nhận hàng
                                    syscash.Value = phiNhanHang;
                                    syscash.CreateDate = currentDate.AddSeconds(4);
                                    syscash.CreateBy = accountId;
                                    syscash.FK_ExpConsignment = consig.Id;
                                    syscash.Type = "PROFIT";
                                    syscash.Note = "Lợi nhuận gửi hàng " + postTo.TenDaiLy + " hoàn trả " + postFrom.TenDaiLy;
                                    syscash.IsDelete = false;
                                    dc.EXpconsignmentcashpay.InsertOnSubmit(ConnectionData.Schema, syscash);
                                    // ++/-- Update EXP Post
                                    postTo.ValueBlance -= syscash.Value;
                                    postFrom.ValueBlance += syscash.Value;
                                }

                                if (phiHeThong > 0)
                                {
                                    // Người nhận trả thì TO => SYS số tiền còn là sau  khi trừ 15% tiền hoa hồng
                                    syscash = new ExpConsignmentCashPay();
                                    syscash.Id = Guid.NewGuid().ToString();
                                    syscash.FK_ExtPostFrom = postTo.Id;
                                    syscash.CurrentExtPostFrom = postTo.ValueBlance;
                                    syscash.FK_ExtPostTo = postTT.Id;
                                    syscash.CurrentExtPostTo = postTT.ValueBlance;
                                    syscash.Value = phiHeThong;
                                    syscash.CreateDate = currentDate.AddSeconds(5);
                                    syscash.CreateBy = accountId;
                                    syscash.FK_ExpConsignment = consig.Id;
                                    syscash.Type = "TRANSIT_EXT";
                                    syscash.Note = "Phí vận tải do " + postFrom.TenDaiLy + " trả cho hệ thống";
                                    syscash.IsDelete = false;
                                    dc.EXpconsignmentcashpay.InsertOnSubmit(ConnectionData.Schema, syscash);
                                    // ++/-- Update EXP Post
                                    postTT.ValueBlance += syscash.Value;
                                    postTo.ValueBlance -= syscash.Value;
                                }
                            }
                        }
                    }
                    //####  3 Thu HỘ
                    if (consig.ThuHo > 0)
                    {
                        soTienPhieuThu += consig.ThuHo;
                        // Tiền Thu Hộ Chuyển tiền từ TO => FROM
                        syscash = new ExpConsignmentCashPay();
                        syscash.Id = Guid.NewGuid().ToString();
                        syscash.FK_ExtPostFrom = postTo.Id;
                        syscash.CurrentExtPostFrom = postTo.ValueBlance;
                        syscash.FK_ExtPostTo = postFrom.Id;
                        syscash.CurrentExtPostTo = postFrom.ValueBlance;
                        syscash.Value = consig.ThuHo;
                        syscash.CreateDate = currentDate.AddSeconds(6);
                        syscash.CreateBy = accountId;
                        syscash.FK_ExpConsignment = consig.Id;
                        syscash.Type = "COD";
                        syscash.Note = "Tiền thu hộ khách hàng " + postTo.TenDaiLy + " trả cho " + postFrom.TenDaiLy;
                        syscash.IsDelete = false;
                        dc.EXpconsignmentcashpay.InsertOnSubmit(ConnectionData.Schema, syscash);
                        // ++/-- Update EXP Post
                        postTo.ValueBlance -= syscash.Value;
                        postFrom.ValueBlance += syscash.Value;
                    }
                    // 4. Lập phiếu thu tiền nếu có thu hộ hoặc người nhận thanh toán Ship
                    if (soTienPhieuThu > 0)
                    {
                        ExpCashPay cashPay = new ExpCashPay();
                        cashPay.Id = Guid.NewGuid().ToString();
                        cashPay.CreateBy = accountId;
                        cashPay.CreateDate = currentDate;
                        cashPay.SoChungTu = consig.MaDonHang;
                        cashPay.FK_ExtPost = consig.FK_ExpPostTo;
                        cashPay.MaNguoiNopNhan = consig.FK_NguoiNhan;
                        cashPay.TenNguoiNopNhan = consig.NguoiNhan;
                        cashPay.DiaChi = consig.DiaChiNguoiNhan;
                        cashPay.SoDienThoai = consig.SoDienThoaiNguoiNhan;
                        cashPay.IsPay = false;
                        cashPay.IsDelete = false;
                        cashPay.Note = "Thu tiền của người nhận đơn hàng " + consig.MaDonHang;
                        cashPay.Value = soTienPhieuThu;
                        cashPay.Type = "CASH_COD";
                        cashPay.PrintCopied = 0;
                        dc.EXpcashpay.InsertOnSubmit(base.ConnectionData.Schema, cashPay);
                        // Update ExpPost
                        postTo.ValueBlanceMoney = postTo.ValueBlanceMoney + cashPay.Value;
                    }
                    // Change Balance ExpPost
                    dc.EXppost.Update(ConnectionData.Schema, postTo);
                    dc.EXppost.Update(ConnectionData.Schema, postFrom);
                    dc.EXppost.Update(ConnectionData.Schema, postTT);
                }
                dc.SubmitChanges();
                return string.Empty;
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
        public async Task<string> ScanFinish(string toPostId, string expPostName, string deliveryId, string deliveryName, string accountId, string Id, string sysPost)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                DateTime currentDate = dc.CurrentTime();
                ExpConsignment consig = dc.EXpconsignment.GetObject(ConnectionData.Schema, Id);
                if (consig != null)
                {
                    if (consig.FK_ExpStatus == "FINISH")
                    {
                        return "Đơn hàng đã được ký nhận. Không thể ký nhận tiếp.";
                    }
                    ExpPost postFrom = dc.EXppost.GetObject(ConnectionData.Schema, consig.FK_ExpPostFrom);
                    ExpPost postTo = dc.EXppost.GetObject(ConnectionData.Schema, toPostId);
                    ExpPost postTT = dc.EXppost.GetObject(ConnectionData.Schema, sysPost);
                    if (postFrom == null || postTo == null || postTT == null)
                    {
                        return "Mã bưu cục không tồn tại. Vui lòng liên hệ quản trị";
                    }
                    // Kiểm tra kiện hàng có quét cùng một thời điểm hay không
                    // History
                    ExpConsignmentHistory history = new ExpConsignmentHistory();
                    history.Id = Guid.NewGuid().ToString();
                    history.CreateDate = currentDate;
                    history.FK_ExpConsignment = consig.Id;
                    history.FK_ExpStatus = "FINISH";
                    history.FK_ExpPost = toPostId;
                    history.Note = "Ký nhận giao hàng thành công tại bưu cục  " + expPostName;
                    history.CreateBy = accountId;
                    // Insert History
                    dc.EXpconsignmenthistory.InsertOnSubmit(ConnectionData.Schema, history);
                    // Update trạng thái của đơn hàng
                    consig.FK_ExpStatus = "FINISH";
                    consig.FK_NhanVienPhat = deliveryId;
                    consig.HoTenNguoiKyNhan = deliveryName;
                    dc.EXpconsignment.Update(ConnectionData.Schema, consig);
                    if (consig.FK_ExpProvider == "2")
                    {
                        // Tính toán đơn hàng nội tỉnh
                        // ================ Tính toán thu chi hệ thống ===========
                        ExpConsignmentCashPay syscash = new ExpConsignmentCashPay();
                        if (consig.FK_CachThanhToan == "01")
                        {
                            // Người gửi trả phí thì mình cho From => System
                            // Phí hệ thống FROM => TT
                            syscash = new ExpConsignmentCashPay();
                            syscash.Id = Guid.NewGuid().ToString();
                            syscash.FK_ExtPostFrom = postFrom.Id;
                            syscash.CurrentExtPostFrom = postFrom.ValueBlance;
                            syscash.FK_ExtPostTo = postTT.Id;
                            syscash.CurrentExtPostTo = postTT.ValueBlance;
                            syscash.Value = postFrom.SytemFee;
                            syscash.CreateDate = currentDate.AddSeconds(1);
                            syscash.CreateBy = accountId;
                            syscash.FK_ExpConsignment = consig.Id;
                            syscash.Type = "OPER";
                            syscash.Note = "Phí thao tác và hệ thống " + postFrom.TenDaiLy + " trả cho hệ thống.";
                            syscash.IsDelete = false;
                            dc.EXpconsignmentcashpay.InsertOnSubmit(ConnectionData.Schema, syscash);
                            // ++/-- Update EXP Post
                            postTT.ValueBlance += syscash.Value;
                            postFrom.ValueBlance -= syscash.Value;

                            // Phí thao tác chung nội tỉnh FROM => TT
                            syscash = new ExpConsignmentCashPay();
                            syscash.Id = Guid.NewGuid().ToString();
                            syscash.FK_ExtPostFrom = postFrom.Id;
                            syscash.CurrentExtPostFrom = postFrom.ValueBlance;
                            syscash.FK_ExtPostTo = postTT.Id;
                            syscash.CurrentExtPostTo = postTT.ValueBlance;
                            syscash.Value = postFrom.InternalDeliveryFee;
                            syscash.CreateDate = currentDate.AddSeconds(2);
                            syscash.CreateBy = accountId;
                            syscash.FK_ExpConsignment = consig.Id;
                            syscash.Type = "TRANSIT_INT";
                            syscash.Note = "Phí trung chuyển nội tỉnh " + postFrom.TenDaiLy + " trả cho hệ thống";
                            syscash.IsDelete = false;
                            dc.EXpconsignmentcashpay.InsertOnSubmit(ConnectionData.Schema, syscash);
                            // ++/-- Update EXP Post
                            postTT.ValueBlance += syscash.Value;
                            postFrom.ValueBlance -= syscash.Value;
                        }
                        else if (consig.FK_CachThanhToan == "02")
                        {
                            // Phí hệ thống TO => TT
                            syscash = new ExpConsignmentCashPay();
                            syscash.Id = Guid.NewGuid().ToString();
                            syscash.FK_ExtPostFrom = postTo.Id;
                            syscash.CurrentExtPostFrom = postTo.ValueBlance;
                            syscash.FK_ExtPostTo = postTT.Id;
                            syscash.CurrentExtPostTo = postTT.ValueBlance;
                            syscash.Value = postTo.SytemFee;
                            syscash.CreateDate = currentDate.AddSeconds(1);
                            syscash.CreateBy = accountId;
                            syscash.FK_ExpConsignment = consig.Id;
                            syscash.Type = "OPER";
                            syscash.Note = "Phí thao tác và hệ thống" + postTo.TenDaiLy + " trả giùm cho hệ thống";
                            syscash.IsDelete = false;
                            dc.EXpconsignmentcashpay.InsertOnSubmit(ConnectionData.Schema, syscash);
                            // ++/-- Update EXP Post
                            postTT.ValueBlance += syscash.Value;
                            postTo.ValueBlance -= syscash.Value;

                            // Phí thao tác chung nội tỉnh TO => TT
                            syscash = new ExpConsignmentCashPay();
                            syscash.Id = Guid.NewGuid().ToString();
                            syscash.FK_ExtPostFrom = postTo.Id;
                            syscash.CurrentExtPostFrom = postTo.ValueBlance;
                            syscash.FK_ExtPostTo = postTT.Id;
                            syscash.CurrentExtPostTo = postTT.ValueBlance;
                            syscash.Value = postTo.InternalDeliveryFee;
                            syscash.CreateDate = currentDate.AddSeconds(2);
                            syscash.CreateBy = accountId;
                            syscash.FK_ExpConsignment = consig.Id;
                            syscash.Type = "TRANSIT_INT";
                            syscash.Note = "Phí trung chuyển nội tỉnh" + postTo.TenDaiLy + " trả giùm cho hệ thống";
                            syscash.IsDelete = false;
                            dc.EXpconsignmentcashpay.InsertOnSubmit(ConnectionData.Schema, syscash);
                            // ++/-- Update EXP Post
                            postTT.ValueBlance += syscash.Value;
                            postTo.ValueBlance -= syscash.Value;
                        }

                        // Phí giao hàng FROM => TO
                        if (postFrom.Id != postTo.Id)
                        {
                            int soTienPhieuThu = 0;
                            if (consig.FK_CachThanhToan == "01")
                            {
                                // Nếu người gửi trả thì FROM phải trả tiền giao hàng cho TO
                                syscash = new ExpConsignmentCashPay();
                                syscash.Id = Guid.NewGuid().ToString();
                                syscash.FK_ExtPostFrom = postFrom.Id;
                                syscash.CurrentExtPostFrom = postFrom.ValueBlance;
                                syscash.FK_ExtPostTo = postTo.Id;
                                syscash.CurrentExtPostTo = postTo.ValueBlance;
                                syscash.Value = postTo.DeliveryFee;
                                syscash.CreateDate = currentDate.AddSeconds(3);
                                syscash.CreateBy = accountId;
                                syscash.FK_ExpConsignment = consig.Id;
                                syscash.Type = "DELIVERY";
                                syscash.Note = "Phí giao hàng " + postFrom.TenDaiLy + " trả cho " + postTo.TenDaiLy;
                                syscash.IsDelete = false;
                                dc.EXpconsignmentcashpay.InsertOnSubmit(ConnectionData.Schema, syscash);
                                // ++/-- Update EXP Post
                                postTo.ValueBlance += syscash.Value;
                                postFrom.ValueBlance -= syscash.Value;
                            }
                            else if (consig.FK_CachThanhToan == "02")
                            {
                                // Nhận thanh toán TO => FROM
                                syscash = new ExpConsignmentCashPay();
                                syscash.Id = Guid.NewGuid().ToString();
                                syscash.FK_ExtPostFrom = postTo.Id;
                                syscash.CurrentExtPostFrom = postTo.ValueBlance;
                                syscash.FK_ExtPostTo = postFrom.Id;
                                syscash.CurrentExtPostTo = postFrom.ValueBlance;
                                // Tiền trả lại = Số tiền cước chính + số tiền cước thêm + phí cod - phí giao hàng
                                syscash.Value = consig.CuocPhiChinh + consig.CuocCongThem + consig.PhuPhi - postFrom.InternalDeliveryFee - postFrom.SytemFee - postTo.DeliveryFee;
                                soTienPhieuThu = consig.CuocPhiChinh + consig.CuocCongThem + consig.PhuPhi;
                                syscash.CreateDate = currentDate.AddSeconds(3);
                                syscash.CreateBy = accountId;
                                syscash.FK_ExpConsignment = consig.Id;
                                syscash.Type = "PROFIT";
                                syscash.Note = "Lợi nhuận gửi hàng " + postTo.TenDaiLy + " hoàn trả " + postFrom.TenDaiLy;
                                syscash.IsDelete = false;
                                dc.EXpconsignmentcashpay.InsertOnSubmit(ConnectionData.Schema, syscash);
                                // ++/-- Update EXP Post
                                postTo.ValueBlance -= syscash.Value;
                                postFrom.ValueBlance += syscash.Value;
                            }
                            if (consig.ThuHo > 0)
                            {
                                // Tiền Thu Hộ Chuyển tiền từ TO => FROM
                                syscash = new ExpConsignmentCashPay();
                                syscash.Id = Guid.NewGuid().ToString();
                                syscash.FK_ExtPostFrom = postTo.Id;
                                syscash.CurrentExtPostFrom = postTo.ValueBlance;
                                syscash.FK_ExtPostTo = postFrom.Id;
                                syscash.CurrentExtPostTo = postFrom.ValueBlance;
                                syscash.Value = consig.ThuHo;
                                // Cộng thêm tiền thu hộ vào phiếu thu
                                soTienPhieuThu += consig.ThuHo;
                                syscash.CreateDate = currentDate.AddSeconds(4);
                                syscash.CreateBy = accountId;
                                syscash.FK_ExpConsignment = consig.Id;
                                syscash.Type = "COD";
                                syscash.Note = "Tiền thu hộ khách hàng " + postTo.TenDaiLy + " trả cho " + postFrom.TenDaiLy;
                                syscash.IsDelete = false;
                                dc.EXpconsignmentcashpay.InsertOnSubmit(ConnectionData.Schema, syscash);
                                // ++/-- Update EXP Post
                                postTo.ValueBlance -= syscash.Value;
                                postFrom.ValueBlance += syscash.Value;
                            }
                            // Lập phiếu thu
                            if (soTienPhieuThu > 0)
                            {
                                ExpCashPay cashPay = new ExpCashPay();
                                cashPay.Id = Guid.NewGuid().ToString();
                                cashPay.CreateBy = accountId;
                                cashPay.CreateDate = currentDate;
                                cashPay.SoChungTu = consig.MaDonHang;
                                cashPay.FK_ExtPost = consig.FK_ExpPostTo;
                                cashPay.MaNguoiNopNhan = consig.FK_NguoiNhan;
                                cashPay.TenNguoiNopNhan = consig.NguoiNhan;
                                cashPay.DiaChi = consig.DiaChiNguoiNhan;
                                cashPay.SoDienThoai = consig.SoDienThoaiNguoiNhan;
                                cashPay.IsPay = false;
                                cashPay.IsDelete = false;
                                cashPay.Note = "Thu tiền của người nhận đơn hàng " + consig.MaDonHang;
                                cashPay.Value = soTienPhieuThu;
                                cashPay.Type = "CASH_COD";
                                cashPay.PrintCopied = 0;
                                dc.EXpcashpay.InsertOnSubmit(base.ConnectionData.Schema, cashPay);
                                // Update ExpPost
                                postTo.ValueBlanceMoney = postTo.ValueBlanceMoney + cashPay.Value;
                            }
                        }
                    }
                    else if (consig.FK_ExpProvider == "3" || consig.FK_ExpProvider == "4")
                    {
                        int phiphathcm = 0;
                        // Tính toán giao hàng TP HCM nhanh
                        if (consig.FK_ExpProvider == "3")
                        {
                            if (consig.TrongLuongGram <= 15000)
                            {
                                // 50k đơn
                                phiphathcm = 50000;
                            }
                            else if (consig.TrongLuongGram <= 50000)
                            {
                                //70k
                                phiphathcm = 70000;
                            }
                            else if (consig.TrongLuongGram <= 100)
                            {
                                //100k
                                phiphathcm = 100000;
                            }
                            else if (consig.TrongLuongGram <= 300)
                            {
                                // 1,000/kg
                                phiphathcm = (consig.TrongLuongGram / 1000) * 1000;
                            }
                            else
                            {
                                //900/kg
                                phiphathcm = (consig.TrongLuongGram / 1000) * 900;
                            }
                        }
                        else
                        {
                            // Tính toán giao hàng TP HCM chậm
                            if (consig.TrongLuongGram <= 5000)
                            {
                                // 24,500
                                phiphathcm = 24500;
                            }
                            else
                            {
                                //1,750/kg
                                phiphathcm = (consig.TrongLuongGram / 1000) * 1750;
                            }
                        }
                        int TongCuocVC = consig.CuocPhiChinh + consig.CuocCongThem + consig.PhuPhi;
                        int soTienPhieuThu = 0;
                        if (consig.FK_CachThanhToan == "01")
                        {
                            // Người gửi trả thì FROM => TO phí phát hàng HCM
                            ExpConsignmentCashPay syscash = new ExpConsignmentCashPay();
                            syscash.Id = Guid.NewGuid().ToString();
                            syscash.FK_ExtPostFrom = postFrom.Id;
                            syscash.CurrentExtPostFrom = postFrom.ValueBlance;
                            syscash.FK_ExtPostTo = postTo.Id;
                            syscash.CurrentExtPostTo = postTo.ValueBlance;
                            syscash.Value = phiphathcm;
                            syscash.CreateDate = currentDate.AddSeconds(1);
                            syscash.CreateBy = accountId;
                            syscash.FK_ExpConsignment = consig.Id;
                            syscash.Type = "DELIVERY";
                            syscash.Note = "Phí giao hàng " + postFrom.TenDaiLy + " trả cho " + postTo.TenDaiLy;
                            syscash.IsDelete = false;
                            dc.EXpconsignmentcashpay.InsertOnSubmit(ConnectionData.Schema, syscash);
                            // ++/-- Update EXP Post
                            postTo.ValueBlance += syscash.Value;
                            postFrom.ValueBlance -= syscash.Value;
                            // Người gửi trả thì FROM => SYS số tiền còn là sau  khi trừ 15% tiền hoa hồng
                            syscash = new ExpConsignmentCashPay();
                            syscash.Id = Guid.NewGuid().ToString();
                            syscash.FK_ExtPostFrom = postFrom.Id;
                            syscash.CurrentExtPostFrom = postFrom.ValueBlance;
                            syscash.FK_ExtPostTo = postTT.Id;
                            syscash.CurrentExtPostTo = postTT.ValueBlance;
                            syscash.Value = TongCuocVC - phiphathcm - (int)(TongCuocVC * 0.15);
                            syscash.CreateDate = currentDate.AddSeconds(2);
                            syscash.CreateBy = accountId;
                            syscash.FK_ExpConsignment = consig.Id;
                            syscash.Type = "TRANSIT_EXT";
                            syscash.Note = "Phí vận tải do " + postFrom.TenDaiLy + " trả cho hệ thống";
                            syscash.IsDelete = false;
                            dc.EXpconsignmentcashpay.InsertOnSubmit(ConnectionData.Schema, syscash);
                            // ++/-- Update EXP Post
                            postTT.ValueBlance += syscash.Value;
                            postFrom.ValueBlance -= syscash.Value;
                        }
                        else if (consig.FK_CachThanhToan == "02")
                        {
                            soTienPhieuThu += TongCuocVC;
                            // Người nhận trả thì TO => FROM 15% hoa hồng
                            ExpConsignmentCashPay syscash = new ExpConsignmentCashPay();
                            syscash.Id = Guid.NewGuid().ToString();
                            syscash.FK_ExtPostFrom = postTo.Id;
                            syscash.CurrentExtPostFrom = postTo.ValueBlance;
                            syscash.FK_ExtPostTo = postFrom.Id;
                            syscash.CurrentExtPostTo = postFrom.ValueBlance;
                            // Tiền trả hoa hồng 15% cho bưu cục nhận hàng
                            syscash.Value = (int)(TongCuocVC * 0.15);
                            syscash.CreateDate = currentDate.AddSeconds(3);
                            syscash.CreateBy = accountId;
                            syscash.FK_ExpConsignment = consig.Id;
                            syscash.Type = "PROFIT";
                            syscash.Note = "Lợi nhuận gửi hàng " + postTo.TenDaiLy + " hoàn trả " + postFrom.TenDaiLy;
                            syscash.IsDelete = false;
                            dc.EXpconsignmentcashpay.InsertOnSubmit(ConnectionData.Schema, syscash);
                            // ++/-- Update EXP Post
                            postTo.ValueBlance -= syscash.Value;
                            postFrom.ValueBlance += syscash.Value;
                            // Người nhận trả thì TO => SYS số tiền còn là sau  khi trừ 15% tiền hoa hồng
                            syscash = new ExpConsignmentCashPay();
                            syscash.Id = Guid.NewGuid().ToString();
                            syscash.FK_ExtPostFrom = postTo.Id;
                            syscash.CurrentExtPostFrom = postTo.ValueBlance;
                            syscash.FK_ExtPostTo = postTT.Id;
                            syscash.CurrentExtPostTo = postTT.ValueBlance;
                            syscash.Value = TongCuocVC - phiphathcm - (int)(TongCuocVC * 0.15);
                            syscash.CreateDate = currentDate.AddSeconds(1);
                            syscash.CreateBy = accountId;
                            syscash.FK_ExpConsignment = consig.Id;
                            syscash.Type = "TRANSIT_EXT";
                            syscash.Note = "Phí vận tải do " + postFrom.TenDaiLy + " trả cho hệ thống";
                            syscash.IsDelete = false;
                            dc.EXpconsignmentcashpay.InsertOnSubmit(ConnectionData.Schema, syscash);
                            // ++/-- Update EXP Post
                            postTT.ValueBlance += syscash.Value;
                            postTo.ValueBlance -= syscash.Value;
                        }
                        if (consig.ThuHo > 0)
                        {
                            // Tiền Thu Hộ Chuyển tiền từ TO => FROM
                            ExpConsignmentCashPay syscash = new ExpConsignmentCashPay();
                            syscash.Id = Guid.NewGuid().ToString();
                            syscash.FK_ExtPostFrom = postTo.Id;
                            syscash.CurrentExtPostFrom = postTo.ValueBlance;
                            syscash.FK_ExtPostTo = postFrom.Id;
                            syscash.CurrentExtPostTo = postFrom.ValueBlance;
                            syscash.Value = consig.ThuHo;
                            // Cộng thêm tiền thu hộ vào phiếu thu
                            soTienPhieuThu += consig.ThuHo;
                            syscash.CreateDate = currentDate.AddSeconds(4);
                            syscash.CreateBy = accountId;
                            syscash.FK_ExpConsignment = consig.Id;
                            syscash.Type = "COD";
                            syscash.Note = "Tiền thu hộ khách hàng " + postTo.TenDaiLy + " trả cho " + postFrom.TenDaiLy;
                            syscash.IsDelete = false;
                            dc.EXpconsignmentcashpay.InsertOnSubmit(ConnectionData.Schema, syscash);
                            // ++/-- Update EXP Post
                            postTo.ValueBlance -= syscash.Value;
                            postFrom.ValueBlance += syscash.Value;
                        }
                        // Lập phiếu thu
                        if (soTienPhieuThu > 0)
                        {
                            ExpCashPay cashPay = new ExpCashPay();
                            cashPay.Id = Guid.NewGuid().ToString();
                            cashPay.CreateBy = accountId;
                            cashPay.CreateDate = currentDate;
                            cashPay.SoChungTu = consig.MaDonHang;
                            cashPay.FK_ExtPost = consig.FK_ExpPostTo;
                            cashPay.MaNguoiNopNhan = consig.FK_NguoiNhan;
                            cashPay.TenNguoiNopNhan = consig.NguoiNhan;
                            cashPay.DiaChi = consig.DiaChiNguoiNhan;
                            cashPay.SoDienThoai = consig.SoDienThoaiNguoiNhan;
                            cashPay.IsPay = false;
                            cashPay.IsDelete = false;
                            cashPay.Note = "Thu tiền của người nhận đơn hàng " + consig.MaDonHang;
                            cashPay.Value = soTienPhieuThu;
                            cashPay.Type = "CASH_COD";
                            cashPay.PrintCopied = 0;
                            dc.EXpcashpay.InsertOnSubmit(base.ConnectionData.Schema, cashPay);
                            // Update ExpPost
                            postTo.ValueBlanceMoney = postTo.ValueBlanceMoney + cashPay.Value;
                        }
                    }
                    // Change Balance ExpPost
                    dc.EXppost.Update(ConnectionData.Schema, postTo);
                    dc.EXppost.Update(ConnectionData.Schema, postFrom);
                    dc.EXppost.Update(ConnectionData.Schema, postTT);
                }
                dc.SubmitChanges();
                return string.Empty;
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
        /// <summary>
        /// Tìm view_ExpConsignment theo keyword
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_ExpConsignment>> GetList(string keyword, string AccountId, string Status)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = string.Empty;
                if (Status == "NONE")
                {
                    condition = " WHERE FK_ExpPostFrom IN(SELECT FK_ExpPost FROM ExpPostAccount WHERE FK_AccountId='" + AccountId + "')";
                }
                else
                {
                    condition = " WHERE FK_ExpStatus='" + Status + "' AND FK_ExpPostFrom IN(SELECT FK_ExpPost FROM ExpPostAccount WHERE FK_AccountId='" + AccountId + "')";
                }

                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " AND (MaDonHang like N'%" + keyword + "%' | NguoiGui like N'%" + keyword + "%' | SoDienThoaiNguoiGui like N'%" + keyword + "%' | NguoiNhan like N'%" + keyword + "%' | SoDienThoaiNguoiNhan like N'%" + keyword + "%')| ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition + " ORDER BY CreateDate desc";
                return dc.VIewexpconsignment.GetListObjectCon(base.ConnectionData.Schema, condition);
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

        public async Task<List<ExpConsignmentStatus>> GetListStatus()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<ExpConsignmentStatus> items = dc.EXpconsignmentstatus.GetListObjectCon(base.ConnectionData.Schema, "ORDER BY OrderId");
                ExpConsignmentStatus selectAll = new ExpConsignmentStatus();
                selectAll.Id = "NONE";
                selectAll.StatusName = "Tất cả";
                List<ExpConsignmentStatus> result = new List<ExpConsignmentStatus>();
                result.Add(selectAll);
                result.AddRange(items);
                return result;
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


        public async Task<List<view_ExpConsignment>> GetListWait(string postId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = " WHERE FK_ExpPostTo='" + postId + "' AND (FK_ExpStatus='RECEIVE' OR FK_ExpStatus='NEW')";
                condition = condition + " ORDER BY CreateDate asc";
                return dc.VIewexpconsignment.GetListObjectCon(base.ConnectionData.Schema, condition);
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
        public async Task<List<view_ExpConsignment>> GetListProblem(string postId, string madonhang)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = " WHERE ((FK_ExpPostTo='" + postId + "' AND FK_ExpStatus='RECEIVE') OR (FK_ExpPostFrom='" + postId + "')) AND MaDonHang LIKE '%" + madonhang + "%'";
                condition = condition + " ORDER BY CreateDate asc";
                return dc.VIewexpconsignment.GetListObjectCon(base.ConnectionData.Schema, condition);
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
        public async Task<bool> ScanIncomming(string expPost, string expPostName, string accountId, List<string> listId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                DateTime currentDate = dc.CurrentTime();
                foreach (var item in listId)
                {
                    ExpConsignment consig = dc.EXpconsignment.GetObject(ConnectionData.Schema, item);
                    if (consig != null)
                    {
                        // Kiểm tra kiện hàng có quét cùng một thời điểm hay không
                        // History
                        ExpConsignmentHistory history = new ExpConsignmentHistory();
                        history.CreateDate = currentDate;
                        history.FK_ExpConsignment = consig.Id;
                        history.FK_ExpStatus = "RECEIVE";
                        history.FK_ExpPost = expPost;
                        history.Id = Guid.NewGuid().ToString();
                        history.Note = "Quét hàng đến bưu cục  " + expPostName;
                        history.CreateBy = accountId;
                        // Insert History
                        dc.EXpconsignmenthistory.InsertOnSubmit(ConnectionData.Schema, history);

                        consig.FK_ExpStatus = "RECEIVE";
                        dc.EXpconsignment.Update(ConnectionData.Schema, consig);
                    }
                }
                dc.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
            return false;
        }
        public async Task<bool> ScanProblem(string expPost, string expPostName, string accountId, string Id, string note)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                DateTime currentDate = dc.CurrentTime();

                ExpConsignment consig = dc.EXpconsignment.GetObject(ConnectionData.Schema, Id);
                if (consig != null)
                {
                    // Kiểm tra kiện hàng có quét cùng một thời điểm hay không
                    // History
                    ExpConsignmentHistory history = new ExpConsignmentHistory();
                    history.CreateDate = currentDate;
                    history.FK_ExpConsignment = consig.Id;
                    history.FK_ExpStatus = "ERROR";
                    history.FK_ExpPost = expPost;
                    history.Id = Guid.NewGuid().ToString();
                    history.Note = note;
                    history.CreateBy = accountId;
                    // Insert History
                    dc.EXpconsignmenthistory.InsertOnSubmit(ConnectionData.Schema, history);

                    //consig.FK_ExpStatus = "RECEIVE";
                    //dc.EXpconsignment.Update(ConnectionData.Schema, consig);
                }

                dc.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
            return false;
        }
        public async Task<view_ExpConsignment> GetDetailByMaDonHang(String MaDonHang)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpconsignment.GetObjectCon(base.ConnectionData.Schema, " WHERE MaDonHang=@MaDonHang ", "@MaDonHang", MaDonHang);
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
        public async Task<List<view_ExpConsignment>> GetDetailByMaDonHangLike(String MaDonHang)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpconsignment.GetListObjectCon(base.ConnectionData.Schema, " WHERE MaDonHang LIKE '%" + MaDonHang + "%' ORDER BY CreateDate");
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
        public async Task<ExpPost> GetExpPostDetail(String expId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXppost.GetObject(base.ConnectionData.Schema, expId);
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
        public async Task<List<AccountObject>> GetDeliveryList(string accountId)
        {
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.ACcountobject.GetListObjectCon(ConnectionData.Schema, "WHERE Id IN(SELECT FK_AccountId FROM ExpPostAccount WHERE FK_ExpPost IN(SELECT FK_ExpPost FROM ExpPostAccount WHERE FK_AccountId='" + accountId + "'))");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
        }
        public async Task<List<view_ExpDVHC_TINH>> GetDVHCTinh()
        {
            List<view_ExpDVHC_TINH> ls = new List<view_ExpDVHC_TINH>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.VIewexpdvhctinh.GetListObjectCon(ConnectionData.Schema, "ORDER BY Ten");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
            return ls;
        }
        public async Task<List<view_ExpConsignmentHistoryMater>> GetScanDoneList(string ExpPostId, string status, DateTime fromDate, DateTime toDate)
        {
            List<view_ExpConsignmentHistoryMater> ls = new List<view_ExpConsignmentHistoryMater>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.VIewexpconsignmenthistorymater.GetListObjectCon(ConnectionData.Schema, "WHERE ExpStatusHis=@ExpStatusHis AND ExpPostHis=@ExpPostHis AND (CreateDateHis BETWEEN '" + string.Format("{0:yyyy-MM-dd}", fromDate) + " 00:00:00' AND '" + string.Format("{0:yyyy-MM-dd}", toDate) + " 23:59:59')",
                    "@ExpStatusHis", status,
                    "@ExpPostHis", ExpPostId);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
            return ls;
        }
        public async Task<List<view_ExpDVHC_HUYEN>> GetDVHCHuyen(string idTinh)
        {
            List<view_ExpDVHC_HUYEN> ls = new List<view_ExpDVHC_HUYEN>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.VIewexpdvhchuyen.GetListObjectCon(ConnectionData.Schema, "WHERE CapTren=@CapTren", "@CapTren", idTinh);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
            return ls;
        }
        public async Task<List<view_ExpDVHC_XA>> GetDVHCXa(string idHuyen)
        {
            List<view_ExpDVHC_XA> ls = new List<view_ExpDVHC_XA>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.VIewexpdvhcxa.GetListObjectCon(ConnectionData.Schema, "WHERE CapTren=@CapTren", "@CapTren", idHuyen);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
            return ls;
        }
        public async Task<ExpDonViHanhChinh> GetDetailDVHC(string id)
        {
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpdonvihanhchinh.GetObject(ConnectionData.Schema, id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
        }
        public async Task<bool> UpdateNoteDVHCXa(string id, string note)
        {
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpDonViHanhChinh dvhc = dc.EXpdonvihanhchinh.GetObject(ConnectionData.Schema, id);
                if (dvhc != null)
                {
                    dvhc.Note = note;
                    dc.EXpdonvihanhchinh.Update(ConnectionData.Schema, dvhc);
                    dc.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
            return false;
        }
        public async Task<bool> UpdateNoteDVHCHuyen(string id, string note)
        {
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                dc.ExecuteNonQuery("UPDATE ExpDonViHanhChinh SET Note=N'" + note.Trim() + "' WHERE CapTren='" + id + "';");
                dc.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
        }
        public async Task<bool> UpdateNoteDVHCTinh(string id, string note)
        {
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                dc.ExecuteNonQuery("UPDATE ExpDonViHanhChinh SET Note=N'" + note.Trim() + "' WHERE CapTren IN (SELECT Id FROM ExpDonViHanhChinh WHERE CapTren='" + id + "');");
                dc.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
        }
        public view_ExpConsignmentObject GetThongTinKhachHang(string SoDienThoai)
        {
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpconsignmentobject.GetObjectCon(ConnectionData.Schema, "WHERE SoDienThoai=@SoDienThoai", "@SoDienThoai", SoDienThoai);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
        }
        public void GetCost(string FromProvine, string ToProvine)
        {
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpDistance distance = dc.EXpdistance.GetObjectCon(ConnectionData.Schema, "WHERE Id=@Id AND Target=@Target", "@Id", FromProvine, "@Target", ToProvine);
                if (distance == null)
                {
                    // Không có dữ liệu
                }
                else
                {
                    // Có dữ liệu
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
        }
        public int ExpGetCode(string ExpPostId, string Key)
        {
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                QueueNumber queueNumber = dc.QUeuenumber.GetObjectCon(ConnectionData.Schema, "WHERE KeyValue=@KeyValue AND FK_Branch=@FK_Branch",
                    "@KeyValue", Key,
                    "@FK_Branch", ExpPostId);
                if (queueNumber == null)
                {
                    queueNumber = new QueueNumber();
                    queueNumber.Id = Guid.NewGuid().ToString();
                    queueNumber.Value = 1;
                    queueNumber.KeyValue = Key;
                    queueNumber.FK_Branch = ExpPostId;
                    dc.QUeuenumber.InsertOnSubmit(ConnectionData.Schema, queueNumber);
                }
                else
                {
                    queueNumber.Value = queueNumber.Value + 1;
                    dc.QUeuenumber.Update(ConnectionData.Schema, queueNumber);
                }
                dc.SubmitChanges();
                return queueNumber.Value;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }

        }
        public async Task<bool> PrintBill(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpConsignment expCon = dc.EXpconsignment.GetObject(base.ConnectionData.Schema, Id);
                if (expCon != null)
                {
                    expCon.PrintNumber = expCon.PrintNumber + 1;
                    dc.EXpconsignment.Update(base.ConnectionData.Schema, expCon);
                    dc.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
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
        public async Task<List<view_ExpConsignmentHistory>> GetDetailHistory(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpconsignmenthistory.GetListObjectCon(ConnectionData.Schema, "WHERE FK_ExpConsignment=@FK_ExpConsignment ORDER BY CreateDate", "@FK_ExpConsignment", Id);
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
        public async Task<List<view_ExpConsignmentHistory>> GetProblemHistory(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpconsignmenthistory.GetListObjectCon(ConnectionData.Schema, "WHERE FK_ExpConsignment=@FK_ExpConsignment AND FK_ExpStatus=@FK_ExpStatus ORDER BY CreateDate",
                    "@FK_ExpConsignment", Id,
                    "@FK_ExpStatus", "ERROR");
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
        public async Task<ExpFee> GetDetailFee(string provider, string post)
        {
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpPostFeeProvider exFee = dc.EXppostfeeprovider.GetObject(ConnectionData.Schema, provider, post);
                if (exFee != null)
                {
                    return dc.EXpfee.GetObject(ConnectionData.Schema, exFee.FK_ExpFee);
                }
                else
                {
                    return null;
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
        }

        public List<ExpSaleProduct> GetProductBK()
        {
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<ExpSaleProduct> ls = dc.EXpsaleproduct.GetListObject(base.ConnectionData.Schema);
                foreach (var item in ls)
                {
                    item.TenSanPham = item.TenSanPham + " (" + item.SoLuongTon + ")";
                }
                return ls;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
        }
        public List<ExpSaleLoaiThanhToan> GetLoaiThanhToanBK()
        {
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpsaleloaithanhtoan.GetListObject(base.ConnectionData.Schema);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
        }
        public async Task<string> XuatBanHang(string IdCustomer, string IdProduct, decimal SoLuong, int DonGia, string IdLoaiTT, string userID, string post)
        {
            string mess = string.Empty;
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpSaleXuatKho xuatKho = new ExpSaleXuatKho();
                xuatKho.Id = Guid.NewGuid().ToString();
                xuatKho.DonGia = DonGia;
                xuatKho.FK_KhachHang = IdCustomer;
                xuatKho.FK_LoaiThanhToan = IdLoaiTT;
                xuatKho.FK_Product = IdProduct;
                xuatKho.NgayXuat = DateTime.Now;
                xuatKho.FK_NguoiXuat = userID;
                if (xuatKho.FK_LoaiThanhToan == "TM")
                {
                    xuatKho.IsThanhToan = true;
                    xuatKho.NgayThanhToan = DateTime.Now;
                    // Tạo phiếu thu tiền thay đổi số dư
                    SoQuyChiTienLogicInputDto payItem = new SoQuyChiTienLogicInputDto();
                    payItem.FK_ExtPost = post;
                    payItem.IsPay = false;
                    ExpCustomer customer = dc.EXpcustomer.GetObject(base.ConnectionData.Schema, xuatKho.FK_KhachHang);
                    if (customer != null)
                    {
                        payItem.MaNguoiNopNhan = xuatKho.FK_KhachHang;
                        payItem.TenNguoiNopNhan = customer.CustomerName;
                        payItem.DiaChi = customer.DiaChi;
                        payItem.SoDienThoai = customer.CustomerPhone;
                    }
                    else
                    {
                        payItem.MaNguoiNopNhan = userID;
                        payItem.TenNguoiNopNhan = "XXX";
                        payItem.DiaChi = "XXXX";
                        payItem.SoDienThoai = "XXXX";
                    }

                    payItem.Value = (int)xuatKho.ThanhTien;
                    payItem.CreateBy = userID;
                    payItem.SoChungTu = xuatKho.Id;
                    payItem.Type = "CASH_SELL";
                    payItem.Note = "Thu tiền bán hàng " + payItem.TenNguoiNopNhan;
                    payItem.IsDelete = false;
                    SoQuyChiTienLogic _logic = new SoQuyChiTienLogic(base.ConnectionData);
                    await _logic.CreateCash(payItem);
                }
                if (xuatKho.FK_LoaiThanhToan == "COD")
                {
                    xuatKho.IsThanhToan = false;
                }
                xuatKho.SoLuong = SoLuong;
                xuatKho.ThanhTien = SoLuong * DonGia;
                ExpSaleProduct product = dc.EXpsaleproduct.GetObject(base.ConnectionData.Schema, IdProduct);
                if (product != null)
                {
                    product.SoLuongTon = product.SoLuongTon - SoLuong;
                    dc.EXpsaleproduct.Update(base.ConnectionData.Schema, product);
                }
                dc.EXpsalexuatkho.InsertOnSubmit(base.ConnectionData.Schema, xuatKho);
                dc.SubmitChanges();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
            return mess;
        }
        public async Task<string> XoaXuatKho(string idXuatKho, string userID, string post)
        {
            string mess = string.Empty;
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpSaleXuatKho xuatKho = dc.EXpsalexuatkho.GetObject(base.ConnectionData.Schema, idXuatKho);
                if (xuatKho != null)
                {
                    ExpSaleProduct product = dc.EXpsaleproduct.GetObject(base.ConnectionData.Schema, xuatKho.FK_Product);
                    if (product != null)
                    {
                        product.SoLuongTon = product.SoLuongTon + xuatKho.SoLuong;
                        dc.EXpsaleproduct.Update(base.ConnectionData.Schema, product);
                    }
                    if (xuatKho.FK_LoaiThanhToan == "TM")
                    {
                        // Tạo phiếu chi tiền thay đổi số dư
                        SoQuyChiTienLogicInputDto payItem = new SoQuyChiTienLogicInputDto();
                        payItem.FK_ExtPost = post;
                        payItem.IsPay = true;
                        ExpCustomer customer = dc.EXpcustomer.GetObject(base.ConnectionData.Schema, xuatKho.FK_KhachHang);
                        if (customer != null)
                        {
                            payItem.MaNguoiNopNhan = xuatKho.FK_KhachHang;
                            payItem.TenNguoiNopNhan = customer.CustomerName;
                            payItem.DiaChi = customer.DiaChi;
                            payItem.SoDienThoai = customer.CustomerPhone;
                        }
                        else
                        {
                            payItem.MaNguoiNopNhan = userID;
                            payItem.TenNguoiNopNhan = "XXX";
                            payItem.DiaChi = "XXXX";
                            payItem.SoDienThoai = "XXXX";
                        }

                        payItem.Value = (int)xuatKho.ThanhTien;
                        payItem.CreateBy = userID;
                        payItem.SoChungTu = xuatKho.Id;
                        payItem.Type = "PAY";
                        payItem.Note = "Hoàn trả tiền bán hàng " + payItem.TenNguoiNopNhan;
                        payItem.IsDelete = false;
                        SoQuyChiTienLogic _logic = new SoQuyChiTienLogic(base.ConnectionData);
                        await _logic.Create(payItem);
                    }
                    dc.EXpsalexuatkho.DeleteOnSubmit(base.ConnectionData.Schema, xuatKho);
                    dc.SubmitChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
            return mess;
        }
        public async Task<string> ThuTienXuatKho(string idXuatKho, string userID, string post)
        {
            string mess = string.Empty;
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpSaleXuatKho xuatKho = dc.EXpsalexuatkho.GetObject(base.ConnectionData.Schema, idXuatKho);
                if (xuatKho != null)
                {
                    if (xuatKho.IsThanhToan == false)
                    {
                        ExpCustomer cus = dc.EXpcustomer.GetObject(base.ConnectionData.Schema, xuatKho.FK_KhachHang);

                        xuatKho.IsThanhToan = true;
                        xuatKho.NgayThanhToan = DateTime.Now;
                        dc.EXpsalexuatkho.Update(base.ConnectionData.Schema, xuatKho);
                        // Thu tiền băng keo
                        SoQuyChiTienLogicInputDto payItem = new SoQuyChiTienLogicInputDto();
                        payItem.FK_ExtPost = post;
                        payItem.IsPay = false;
                        payItem.MaNguoiNopNhan = xuatKho.FK_KhachHang;
                        if (cus != null)
                        {
                            payItem.TenNguoiNopNhan = cus.CustomerName;
                            payItem.DiaChi = cus.DiaChi;
                            payItem.SoDienThoai = cus.CustomerPhone;
                        }
                        else
                        {
                            payItem.TenNguoiNopNhan = "XXX";
                            payItem.DiaChi = "XXXX";
                            payItem.SoDienThoai = "XXXX";
                        }

                        payItem.Value = (int)xuatKho.ThanhTien;
                        payItem.CreateBy = userID;
                        payItem.SoChungTu = xuatKho.Id;
                        payItem.Type = "CASH_SELL";
                        payItem.Note = "Thu tiền hàng đã bán vào ngày " + string.Format("{0:dd/MM/yyyy}", xuatKho.NgayXuat);
                        payItem.IsDelete = false;
                        SoQuyChiTienLogic _logic = new SoQuyChiTienLogic(base.ConnectionData);
                        await _logic.CreateCash(payItem);
                        dc.SubmitChanges();
                    }
                    else
                    {
                        mess = "Đơn hàng đã được thanh toán vào ngày " + string.Format("{0:dd/MM/yyyy HH:mm}", xuatKho.NgayThanhToan);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
            return mess;
        }
        public string GetTienNoBangKeo(string sodienthoai, string postID)
        {
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpCustomer cus = dc.EXpcustomer.GetObjectCon(base.ConnectionData.Schema, "WHERE FK_Post=@FK_Post AND CustomerPhone=@CustomerPhone", "@FK_Post", postID, "@CustomerPhone", sodienthoai);
                if (cus == null)
                {
                    return "0";
                }
                List<ExpSaleXuatKho> lsxuatKho = dc.EXpsalexuatkho.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_KhachHang=@FK_KhachHang AND IsThanhToan=0", "@FK_KhachHang", cus.Id);
                if (lsxuatKho.Count > 0)
                {
                    return lsxuatKho.Sum(s => s.ThanhTien).ToString();
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
        }
        public List<view_ExpSaleXuatKho> GetDanhSachXuatBan(DateTime from, DateTime to)
        {
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string condition = "WHERE NgayXuat >'" + string.Format("{0:yyyy-MM-dd} 00:00:00", from) + "' AND NgayXuat <='" + string.Format("{0:yyyy-MM-dd} 23:59:59", to) + "'";
                return dc.VIewexpsalexuatkho.GetListObjectCon(base.ConnectionData.Schema, condition);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
        }
    }
}

