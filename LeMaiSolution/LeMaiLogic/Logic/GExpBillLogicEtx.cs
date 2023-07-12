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
    }
}

