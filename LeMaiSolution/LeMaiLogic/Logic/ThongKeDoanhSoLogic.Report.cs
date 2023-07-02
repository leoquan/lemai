using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace LeMaiLogic.Logic
{
	public partial class ThongKeDoanhSoLogic : BaseLogic
	{
        public ThongKeDoanhSoLogic(BaseLogicConnectionData data) : base(data)
        {
        }
		/// <summary>
		/// Get all view_GExpBill List
		/// </summary>
		/// <returns></returns>
		public async Task<List<view_GExpBill>> GetList(String BillCode,String RegisterUser,String RegisterSiteCode,String AcceptProvinceCode, DateTime fromRegisterDate, DateTime toRegisterDate,String FK_Customer,String FK_ProviderAccount,String BillStatus,String FK_PaymentType)
		{
			IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
			try
			{
				dc.Open();
				string param = " WHERE 1=1 | ";
				// Filter Condition
				if (!string.IsNullOrEmpty(BillCode))
				{
					param += "BillCode like '%" + BillCode + "%' | ";
				}
				if (RegisterUser != "0000")
				{
					param += "RegisterUser='" + RegisterUser + "' | ";
				}
				if (RegisterSiteCode != "0000")
				{
					param += "RegisterSiteCode='" + RegisterSiteCode + "' | ";
				}
				if (AcceptProvinceCode != "-1")
				{
					param += "AcceptProvinceCode=" + AcceptProvinceCode + " | ";
				}
				param += "(RegisterDate BETWEEN '" + string.Format("{0:yyyy-MM-dd}  00:00:00", fromRegisterDate) + "' AND '" + string.Format("{0:yyyy-MM-dd} 23:59:59", toRegisterDate) + "') | ";
				if (FK_Customer != "0000")
				{
					param += "FK_Customer='" + FK_Customer + "' | ";
				}
				if (FK_ProviderAccount != "0000")
				{
					param += "FK_ProviderAccount='" + FK_ProviderAccount + "' | ";
				}
				if (BillStatus != "-1")
				{
					param += "BillStatus=" + BillStatus + " | ";
				}
				if (FK_PaymentType != "0000")
				{
					param += "FK_PaymentType='" + FK_PaymentType + "' | ";
				}
				//Trim Param
				param = param.Trim();
				param = param.TrimEnd('|');
				param = param.Replace("|","AND");
				return dc.VIewgexpbill.GetListObjectCon(base.ConnectionData.Schema, param);
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

		public async Task<List<AccountObject>> GetListAccountObject()
		{
			IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
			try
			{
				dc.Open();
				List<AccountObject> items = dc.ACcountobject.GetListObject(base.ConnectionData.Schema);
				AccountObject selectAll = new AccountObject();
				selectAll.Id = "0000";
				selectAll.FullName = "ALL";
				List<AccountObject> result = new List<AccountObject>();
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
		public async Task<List<ExpPost>> GetListExpPost()
		{
			IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
			try
			{
				dc.Open();
				List<ExpPost> items = dc.EXppost.GetListObject(base.ConnectionData.Schema);
				ExpPost selectAll = new ExpPost();
				selectAll.Id = "0000";
				selectAll.TenDaiLy = "ALL";
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
		public async Task<List<GExpProvince>> GetListGExpProvince()
		{
			IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
			try
			{
				dc.Open();
				List<GExpProvince> items = dc.GExpprovince.GetListObject(base.ConnectionData.Schema);
				GExpProvince selectAll = new GExpProvince();
				selectAll.ProvinceID = -1;
				selectAll.ProvinceName = "ALL";
				List<GExpProvince> result = new List<GExpProvince>();
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
		public async Task<List<ExpCustomer>> GetListExpCustomer()
		{
			IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
			try
			{
				dc.Open();
				List<ExpCustomer> items = dc.EXpcustomer.GetListObject(base.ConnectionData.Schema);
				ExpCustomer selectAll = new ExpCustomer();
				selectAll.Id = "0000";
				selectAll.CustomerName = "ALL";
				List<ExpCustomer> result = new List<ExpCustomer>();
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
		public async Task<List<GExpProvider>> GetListExpProvider()
		{
			IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
			try
			{
				dc.Open();
				List<GExpProvider> items = dc.GExpprovider.GetListObject(base.ConnectionData.Schema);
                GExpProvider selectAll = new GExpProvider();
				selectAll.Id = "0000";
				selectAll.ProviderName = "ALL";
				List<GExpProvider> result = new List<GExpProvider>();
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
		public async Task<List<GExpBillStatus>> GetListGExpBillStatus()
		{
			IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
			try
			{
				dc.Open();
				List<GExpBillStatus> items = dc.GExpbillstatus.GetListObject(base.ConnectionData.Schema);
				GExpBillStatus selectAll = new GExpBillStatus();
				selectAll.Id = -1;
				selectAll.StatusName = "ALL";
				List<GExpBillStatus> result = new List<GExpBillStatus>();
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
		public async Task<List<GExpPaymentType>> GetListGExpPaymentType()
		{
			IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
			try
			{
				dc.Open();
				List<GExpPaymentType> items = dc.GExppaymenttype.GetListObject(base.ConnectionData.Schema);
				GExpPaymentType selectAll = new GExpPaymentType();
				selectAll.Id = "0000";
				selectAll.PaymentTypeName = "ALL";
				List<GExpPaymentType> result = new List<GExpPaymentType>();
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
	}
}

