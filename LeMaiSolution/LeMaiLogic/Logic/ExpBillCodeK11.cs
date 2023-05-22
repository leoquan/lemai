using LeMaiDomain;
using LeMaiDomain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{
    public class ExpBillCodeK11 : BaseLogic
    {
        public ExpBillCodeK11(BaseLogicConnectionData data) : base(data)
        {
        }
        public ExpBILL GetBill(string mavandon)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpbill.GetObject(base.ConnectionData.Schema, mavandon);
            }
            catch
            {
                return null;
            }
            finally
            {
                dc.Close();
            }
        }

        public int InsertBill(ExpBILL bill, string post)
        {
            int row = 0;
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpBILL hd = dc.EXpbill.GetObject(base.ConnectionData.Schema, bill.BILL_CODE);
                if (hd == null)
                {
                    // New
                    bill.BILL_PROCESS_STATUS = 0;
                    ExpCustomer cus = dc.EXpcustomer.GetObjectCon(base.ConnectionData.Schema, "WHERE CustomerPhone=@CustomerPhone AND FK_Post=@FK_Post", "@CustomerPhone", bill.SEND_MAN_PHONE, "@FK_Post", post);
                    if (cus == null)
                    {
                        cus = new ExpCustomer();
                        cus.Id = Guid.NewGuid().ToString();
                        cus.ContractCustomer = false;
                        cus.CustomerName = bill.SEND_MAN.Trim();
                        cus.CustomerPhone = bill.SEND_MAN_PHONE.Trim();
                        cus.BankName = "NGÂN HÀNG ";
                        cus.AccountCode = "SỐ TK";
                        cus.AccountName = bill.SEND_MAN;
                        cus.GoogleMap = "Link Google Map";
                        cus.UnsigName = UnSigns(bill.SEND_MAN.Trim());
                        cus.FK_Post = post;
                        cus.CustomerCode = bill.LAST_UPDATE_USER;
                        cus.FK_GiaCuoc = "0000";
                        if (cus.CustomerCode != "20000")
                        {
                            cus.ContractCustomer = true;
                            cus.TenHopDong = bill.SEND_MAN;
                            cus.NgayHopDong = DateTime.Now.AddDays(-3);
                            cus.SoHopDong = cus.CustomerCode;
                            cus.DiaChi = bill.SEND_MAN_ADDRESS.Trim();
                        }
                        dc.EXpcustomer.InsertOnSubmit(base.ConnectionData.Schema, cus);
                    }
                    if (bill.IS_SIGNED)
                    {
                        bill.BILL_PROCESS_STATUS = 22;
                    }
                    bill.FK_Customer = cus.Id;
                    bill.LAST_UPDATE_USER = "NEW";
                    bill.LAST_UPDATE_DATE = DateTime.Now;
                    bill.SYSTEM_DATE = DateTime.Now.AddDays(-1);
                    dc.EXpbill.InsertOnSubmit(base.ConnectionData.Schema, bill);
                }
                else
                {
                    // Update
                    bill.BILL_PROCESS_STATUS = hd.BILL_PROCESS_STATUS;
                    ExpCustomer cus = dc.EXpcustomer.GetObjectCon(base.ConnectionData.Schema, "WHERE CustomerPhone=@CustomerPhone AND FK_Post=@FK_Post", "@CustomerPhone", bill.SEND_MAN_PHONE, "@FK_Post", post);
                    if (cus == null)
                    {
                        cus = new ExpCustomer();
                        cus.Id = Guid.NewGuid().ToString();
                        cus.ContractCustomer = false;
                        cus.CustomerName = bill.SEND_MAN.Trim();
                        cus.CustomerPhone = bill.SEND_MAN_PHONE.Trim();
                        cus.BankName = "NGÂN HÀNG ";
                        cus.AccountCode = "SỐ TK";
                        cus.AccountName = bill.SEND_MAN;
                        cus.GoogleMap = "Link Google Map";
                        cus.UnsigName = UnSigns(bill.SEND_MAN.Trim());
                        cus.FK_Post = post;
                        cus.CustomerCode = bill.LAST_UPDATE_USER;
                        cus.TenHopDong = cus.CustomerName;

                        cus.FK_GiaCuoc = "0000";
                        if (cus.CustomerCode != "20000")
                        {
                            cus.ContractCustomer = true;
                            cus.TenHopDong = bill.SEND_MAN;
                            cus.NgayHopDong = DateTime.Now.AddDays(-3);
                            cus.SoHopDong = cus.CustomerCode;
                            cus.DiaChi = bill.SEND_MAN_ADDRESS.Trim();
                        }
                        dc.EXpcustomer.InsertOnSubmit(base.ConnectionData.Schema, cus);
                    }
                    if (bill.IS_SIGNED)
                    {
                        bill.BILL_PROCESS_STATUS = 22;
                    }
                    bill.FK_Customer = cus.Id;
                    bill.LAST_UPDATE_USER = hd.LAST_UPDATE_USER;
                    bill.LAST_UPDATE_DATE = hd.LAST_UPDATE_DATE;
                    bill.TTKT_WEIGHT = hd.TTKT_WEIGHT;
                    bill.SYSTEM_DATE = hd.SYSTEM_DATE;
                    dc.EXpbill.Update(base.ConnectionData.Schema, bill);
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
        public void UpdateSYSDATE(string billCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpBILL bill = dc.EXpbill.GetObject(base.ConnectionData.Schema, billCode);
                if (bill != null)
                {
                    bill.SYSTEM_DATE = DateTime.Now;
                    dc.EXpbill.Update(base.ConnectionData.Schema, bill);
                    dc.SubmitChanges();
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
        public void ProcessProblem(List<ExpProblem> lsProblem, string billCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<ExpProblem> lsDataBase = dc.EXpproblem.GetListObjectCon(base.ConnectionData.Schema, "WHERE BILL_CODE=@BILL_CODE", "@BILL_CODE", billCode);
                if (lsDataBase.Count == 0)
                {
                    // Insert toàn bộ dữ liệu vào database
                    dc.EXpproblem.InsertAllSubmit(base.ConnectionData.Schema, lsProblem);
                }
                else if (lsProblem.Count > lsDataBase.Count)
                {
                    // Check và insert
                    foreach (ExpProblem item in lsProblem.OrderByDescending(u => u.CreateDate).ToList())
                    {
                        ExpProblem check = lsDataBase.FirstOrDefault(u => u.KEY_DATE == item.KEY_DATE);
                        if (check == null)
                        {
                            dc.EXpproblem.InsertOnSubmit(base.ConnectionData.Schema, item);
                        }
                        else
                        {
                            break;
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
        public void ProcessIntenal(List<ExpInternal> lsIntenal, string billCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<ExpInternal> lsDataBase = dc.EXpinternal.GetListObjectCon(base.ConnectionData.Schema, "WHERE BILL_CODE=@BILL_CODE", "@BILL_CODE", billCode);
                if (lsDataBase.Count == 0)
                {
                    // Insert toàn bộ dữ liệu vào database
                    dc.EXpinternal.InsertAllSubmit(base.ConnectionData.Schema, lsIntenal);
                }
                else if (lsIntenal.Count > lsDataBase.Count)
                {
                    // Check và insert
                    foreach (ExpInternal item in lsIntenal.OrderByDescending(u => u.CreateDate).ToList())
                    {
                        ExpInternal check = lsDataBase.FirstOrDefault(u => u.KEY_DATE == item.KEY_DATE);
                        if (check == null)
                        {
                            dc.EXpinternal.InsertOnSubmit(base.ConnectionData.Schema, item);
                        }
                        else
                        {
                            break;
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
        public void ProcessScan(List<ExpScan> lsScan, string billCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<ExpScan> lsDataBase = dc.EXpscan.GetListObjectCon(base.ConnectionData.Schema, "WHERE BILL_CODE=@BILL_CODE", "@BILL_CODE", billCode);
                if (lsDataBase.Count == 0)
                {
                    // Insert toàn bộ dữ liệu vào database
                    dc.EXpscan.InsertAllSubmit(base.ConnectionData.Schema, lsScan);
                }
                else if (lsScan.Count > lsDataBase.Count)
                {
                    // Check và insert
                    foreach (ExpScan item in lsScan.OrderByDescending(u => u.CreateDate).ToList())
                    {
                        ExpScan check = lsDataBase.FirstOrDefault(u => u.KeyDate == item.KeyDate);
                        if (check == null)
                        {
                            dc.EXpscan.InsertOnSubmit(base.ConnectionData.Schema, item);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                ExpBILL bill = dc.EXpbill.GetObject(base.ConnectionData.Schema, billCode);
                if (bill != null)
                {
                    // Update trọng lượng
                    int status = bill.BILL_PROCESS_STATUS;
                    bool updateBill = false;

                    ExpScan ttkt = lsScan.FirstOrDefault(u => u.Post == "Trung tâm khai thác HCM" && u.TypeScan == "Quét đến");
                    if (ttkt != null)
                    {
                        if (ttkt.Weight != bill.TTKT_WEIGHT)
                        {
                            updateBill = true;
                        }
                        bill.TTKT_WEIGHT = ttkt.Weight;
                    }
                    // 2.Đang trung chuyển
                    ExpScan trungchuyen = lsScan.FirstOrDefault(u => u.Post == "Trung tâm khai thác HCM" && u.TypeScan == "Quét gửi");
                    if (trungchuyen != null)
                    {
                        status = 2;
                    }
                    else
                    {
                        trungchuyen = lsScan.FirstOrDefault(u => u.TypeScan == "Xe trung chuyển");
                        if (trungchuyen != null)
                        {
                            status = 2;
                        }
                    }
                    // 3.Đang giao
                    ExpScan danggiao = lsScan.FirstOrDefault(u => u.TypeScan == "Quét giao");
                    if (danggiao != null)
                    {
                        status = 3;
                    }
                    // 4.Có kiện vấn đề
                    ExpScan kvd = lsScan.FirstOrDefault(u => u.TypeScan == "Kiện vấn đề");
                    if (kvd != null)
                    {
                        status = 4;
                    }
                    // 5.Đang hoàn
                    ExpScan hoan = lsScan.FirstOrDefault(u => u.TypeScan == "Hoàn");
                    if (hoan != null)
                    {
                        status = 5;
                    }
                    // 6.Check ký nhận 22
                    ExpScan kyNhan = lsScan.FirstOrDefault(u => u.TypeScan == "Ký nhận");
                    if (kyNhan != null)
                    {
                        bill.IS_SIGNED = true;
                        status = 22;
                        bill.SIGNED_DATE = kyNhan.CreateDate;
                    }
                    if (status > bill.BILL_PROCESS_STATUS)
                    {
                        bill.BILL_PROCESS_STATUS = status;
                        bill.LAST_UPDATE_DATE = DateTime.Now;
                        dc.EXpbill.Update(base.ConnectionData.Schema, bill);
                    }
                    else if (updateBill == true)
                    {
                        bill.LAST_UPDATE_DATE = DateTime.Now;
                        dc.EXpbill.Update(base.ConnectionData.Schema, bill);
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
        public DataTable GetListBillCode(string working, string billCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                DataTable data = new DataTable();
                if (!string.IsNullOrEmpty(billCode))
                {
                    data = dc.GetData("SELECT BILL_CODE FROM " + base.ConnectionData.Schema + ".ExpBILL WHERE BILL_CODE IN (" + billCode + ")");
                }
                else
                {
                    data = dc.GetData("SELECT TOP(10) BILL_CODE FROM " + base.ConnectionData.Schema + ".ExpBILL WHERE IS_SIGNED=@IS_SIGNED AND REGISTER_DATE >='" + string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddDays(-45)) + " 00:00:00' AND WORKING_PRIOTY IN (" + working + ") ORDER BY SYSTEM_DATE", "@IS_SIGNED", false);
                    string s = string.Empty;
                    foreach (DataRow item in data.Rows)
                    {
                        s += "'" + item["BILL_CODE"].ToString() + "',";
                    }
                    s = s.TrimEnd(',');
                    dc.ExecuteNonQuery("UPDATE ExpBILL SET SYSTEM_DATE = getdate() WHERE BILL_CODE IN (" + s + ")");
                    dc.SubmitChanges();
                }
                return data;
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

    }
}

