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
	public partial class CustomerLogic : BaseLogic
	{
        public DataTable GetCustomer(string Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewexpcustomer.GetDataTable(base.ConnectionData.Schema, "WHERE Id=@Id", "@Id", Id);
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
    }
}

