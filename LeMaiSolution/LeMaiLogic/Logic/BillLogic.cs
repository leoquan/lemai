using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{
    public class BillLogic : BaseLogic
    {
        public BillLogic(BaseLogicConnectionData data) : base(data)
        {
        }
        /// <summary>
        /// Chi tiết đơn hàng
        /// </summary>
        /// <param name="billCode">Mã đơn hàng</param>
        /// <returns></returns>
        public async Task<GExpBill> GetBillDetail(string billCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpBill bill = dc.GExpbill.GetObject(base.ConnectionData.Schema, billCode);
                return bill;
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
        /// Danh sách đơn hàng của khách hàng
        /// </summary>
        /// <param name="customerCode">Mã khách hàng</param>
        /// <param name="fromDate">Từ ngày chuỗi string dạng yyyy-MM-dd</param>
        /// <param name="toDate">Đến ngày chuỗi string dạng yyyy-MM-dd</param>
        /// <returns></returns>
        public async Task<List<GExpBill>> GetBillList(string customerCode, string fromDate, string toDate)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.GExpbill.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_Customer=@FK_Customer AND RegisterDate>='" + fromDate + " 00:00:00' AND RegisterDate<='" + toDate + " 23:59:59'", "@FK_Customer", customerCode);
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
        /// Tìm kiếm đơn hàng bằng từ khóa
        /// </summary>
        /// <param name="keyWord">Từ khóa cần tìm kiếm: Người nhận, người gửi, số điện thoại nhận, số điện thoại gửi</param>
        /// <param name="customerCode">Mã khách hàng, trường hợp tìm tất cả thì truyền mã là string.empty</param>
        /// <returns></returns>
        public async Task<List<GExpBill>> SearchBillList(string keyWord, string customerCode = "")
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string condition = string.Empty;
                if (string.IsNullOrEmpty(customerCode))
                {
                    condition = "WHERE SendMan LIKE '%@KEY%' OR SendManPhone LIKE '%@KEY%' OR SendManUs LIKE '%@KEY%' OR AcceptMan LIKE '%@KEY%' OR AcceptManUs LIKE '%@KEY%' OR AcceptManPhone LIKE '%@KEY%'";
                }
                else
                {
                    // Search by customer
                    condition = "WHERE FK_Customer='" + customerCode + "' AND (SendMan LIKE '%@KEY%' OR SendManPhone LIKE '%@KEY%' OR SendManUs LIKE '%@KEY%' OR AcceptMan LIKE '%@KEY%' OR AcceptManUs LIKE '%@KEY%' OR AcceptManPhone LIKE '%@KEY%')";
                }
                condition = condition.Replace("@KEY", keyWord);

                return dc.GExpbill.GetListObjectCon(base.ConnectionData.Schema, condition);
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
        /// Hiển thị hành trình đơn hàng
        /// </summary>
        /// <param name="billCode"></param>
        /// <returns></returns>
        public async Task<List<GExpScan>> GetScanList(string billCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.GExpscan.GetListObjectCon(base.ConnectionData.Schema, "WHERE BillCode=@BillCode ORDER BY CreateDate DESC", "@BillCode", billCode);
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
        /// Hiển thị danh sách kiện vấn đề
        /// </summary>
        /// <param name="billCode"></param>
        /// <returns></returns>
        public async Task<List<GExpScan>> GetProblemList(string billCode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.GExpscan.GetListObjectCon(base.ConnectionData.Schema, "WHERE BillCode=@BillCode AND TypeScan='PROB' ORDER BY CreateDate DESC", "@BillCode", billCode);
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
        /// Tạo mã đơn hàng
        /// </summary>
        /// <param name="ExpPostId">Trạm tạo đơn</param>
        /// <returns></returns>
        public string ExpGetCode(string ExpPostId)
        {
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpCode queueNumber = dc.GExpcode.GetObjectCon(ConnectionData.Schema, "WHERE Id=@Id",
                    "@KeyValue", ExpPostId);
                if (queueNumber == null)
                {
                    queueNumber = new GExpCode();
                    queueNumber.Id = ExpPostId;
                    queueNumber.CurrentValue = 1;
                    queueNumber.Post = "A";
                    dc.GExpcode.InsertOnSubmit(ConnectionData.Schema, queueNumber);
                }
                else
                {
                    queueNumber.CurrentValue = queueNumber.CurrentValue + 1;
                    dc.GExpcode.Update(ConnectionData.Schema, queueNumber);
                }
                dc.SubmitChanges();
                return queueNumber.Post + queueNumber.CurrentValue.ToString().PadLeft(5, '6');
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

