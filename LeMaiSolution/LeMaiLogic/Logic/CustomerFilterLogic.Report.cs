using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace LeMaiLogic.Logic
{
    public partial class CustomerFilterLogic : BaseLogic
    {
        public CustomerFilterLogic(BaseLogicConnectionData data) : base(data)
        {
        }
        /// <summary>
        /// Get all view_ExpCustomer List
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_ExpCustomer>> GetList(String keyword, string postId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string param = " WHERE FK_Post='" + postId + "' &";
                // Filter Condition
                if (!string.IsNullOrEmpty(keyword))
                {
                    param += " CustomerName like N'%" + keyword + "%' | CustomerPhone like N'%" + keyword + "%' | CustomerCode like N'%" + keyword + "%' | UnsigName like N'%" + keyword + "%'";
                }
                //Trim Param
                param = param.Trim();
                param = param.TrimEnd('|');
                param = param.Replace("|", "OR");
				param = param.TrimEnd('&');
				param = param.Replace("&", "AND");
				return dc.VIewexpcustomer.GetListObjectCon(base.ConnectionData.Schema, param);
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
        public ExpCustomer GetThongTinKhachHang(string customerId)
        {
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpcustomer.GetObject(ConnectionData.Schema, customerId);
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

