using LeMaiDomain;
using LeMaiDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{
    public partial class GExpBillLogic : BaseLogic
    {
        //TODO: Extend Function Here
        public List<view_GExpBill> GetBills(string billCodes)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexpbill.GetListObjectCon(base.ConnectionData.Schema, "WHERE BillCode IN (" + billCodes + ")");
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
        public List<GExpBillStatus> GetGExpBillStatusAndAll()
        {
            List<GExpBillStatus> ls = new List<GExpBillStatus>();
            ls.Add(new GExpBillStatus { Id = -1, StatusName = "Tất cả" });
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls.AddRange(dc.GExpbillstatus.GetListObjectCon(ConnectionData.Schema, "ORDER BY Id"));
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
    }
}

