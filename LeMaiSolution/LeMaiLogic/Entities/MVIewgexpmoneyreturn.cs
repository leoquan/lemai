using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewgexpmoneyreturn:IVIewgexpmoneyreturn
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewgexpmoneyreturn(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_GExpMoneyReturn từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpMoneyReturn]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_GExpMoneyReturn từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpMoneyReturn] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_GExpMoneyReturn từ Database
		/// </summary>
		public List<view_GExpMoneyReturn> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpMoneyReturn]");
				List<view_GExpMoneyReturn> items = new List<view_GExpMoneyReturn>();
				view_GExpMoneyReturn item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GExpMoneyReturn();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
					{
						item.BT3Code = Convert.ToString(dr["BT3Code"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["Status"] != null && dr["Status"] != DBNull.Value)
					{
						item.Status = Convert.ToInt32(dr["Status"]);
					}
					if (dr["BT3COD"] != null && dr["BT3COD"] != DBNull.Value)
					{
						item.BT3COD = Convert.ToDecimal(dr["BT3COD"]);
					}
					if (dr["BT3TotalPaid"] != null && dr["BT3TotalPaid"] != DBNull.Value)
					{
						item.BT3TotalPaid = Convert.ToDecimal(dr["BT3TotalPaid"]);
					}
					if (dr["BT3TotalDiscount"] != null && dr["BT3TotalDiscount"] != DBNull.Value)
					{
						item.BT3TotalDiscount = Convert.ToDecimal(dr["BT3TotalDiscount"]);
					}
					if (dr["BT3TotalFee"] != null && dr["BT3TotalFee"] != DBNull.Value)
					{
						item.BT3TotalFee = Convert.ToDecimal(dr["BT3TotalFee"]);
					}
					if (dr["MoneyReturn"] != null && dr["MoneyReturn"] != DBNull.Value)
					{
						item.MoneyReturn = Convert.ToDecimal(dr["MoneyReturn"]);
					}
					if (dr["DateReturn"] != null && dr["DateReturn"] != DBNull.Value)
					{
						item.DateReturn = Convert.ToDateTime(dr["DateReturn"]);
					}
					if (dr["IsPayCustomer"] != null && dr["IsPayCustomer"] != DBNull.Value)
					{
						item.IsPayCustomer = Convert.ToBoolean(dr["IsPayCustomer"]);
					}
					if (dr["FK_MoneyReturnSession"] != null && dr["FK_MoneyReturnSession"] != DBNull.Value)
					{
						item.FK_MoneyReturnSession = Convert.ToString(dr["FK_MoneyReturnSession"]);
					}
					if (dr["ShopName"] != null && dr["ShopName"] != DBNull.Value)
					{
						item.ShopName = Convert.ToString(dr["ShopName"]);
					}
					if (dr["UserApi"] != null && dr["UserApi"] != DBNull.Value)
					{
						item.UserApi = Convert.ToString(dr["UserApi"]);
					}
					if (dr["ProviderName"] != null && dr["ProviderName"] != DBNull.Value)
					{
						item.ProviderName = Convert.ToString(dr["ProviderName"]);
					}
					if (dr["ProviderTypeCode"] != null && dr["ProviderTypeCode"] != DBNull.Value)
					{
						item.ProviderTypeCode = Convert.ToString(dr["ProviderTypeCode"]);
					}
					if (dr["MoneyReturnStatusName"] != null && dr["MoneyReturnStatusName"] != DBNull.Value)
					{
						item.MoneyReturnStatusName = Convert.ToString(dr["MoneyReturnStatusName"]);
					}
					if (dr["SendMan"] != null && dr["SendMan"] != DBNull.Value)
					{
						item.SendMan = Convert.ToString(dr["SendMan"]);
					}
					if (dr["SendManPhone"] != null && dr["SendManPhone"] != DBNull.Value)
					{
						item.SendManPhone = Convert.ToString(dr["SendManPhone"]);
					}
					if (dr["AcceptMan"] != null && dr["AcceptMan"] != DBNull.Value)
					{
						item.AcceptMan = Convert.ToString(dr["AcceptMan"]);
					}
					if (dr["AcceptManPhone"] != null && dr["AcceptManPhone"] != DBNull.Value)
					{
						item.AcceptManPhone = Convert.ToString(dr["AcceptManPhone"]);
					}
					if (dr["AcceptProvince"] != null && dr["AcceptProvince"] != DBNull.Value)
					{
						item.AcceptProvince = Convert.ToString(dr["AcceptProvince"]);
					}
					if (dr["COD"] != null && dr["COD"] != DBNull.Value)
					{
						item.COD = Convert.ToDecimal(dr["COD"]);
					}
					if (dr["Freight"] != null && dr["Freight"] != DBNull.Value)
					{
						item.Freight = Convert.ToDecimal(dr["Freight"]);
					}
					if (dr["FeeWeight"] != null && dr["FeeWeight"] != DBNull.Value)
					{
						item.FeeWeight = Convert.ToDecimal(dr["FeeWeight"]);
					}
					if (dr["BillWeight"] != null && dr["BillWeight"] != DBNull.Value)
					{
						item.BillWeight = Convert.ToDecimal(dr["BillWeight"]);
					}
					if (dr["PayType"] != null && dr["PayType"] != DBNull.Value)
					{
						item.PayType = Convert.ToString(dr["PayType"]);
					}
					if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
					{
						item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
					}
					if (dr["RegisterDate"] != null && dr["RegisterDate"] != DBNull.Value)
					{
						item.RegisterDate = Convert.ToDateTime(dr["RegisterDate"]);
					}
					if (dr["RegisterSiteCode"] != null && dr["RegisterSiteCode"] != DBNull.Value)
					{
						item.RegisterSiteCode = Convert.ToString(dr["RegisterSiteCode"]);
					}
					if (dr["FK_PaymentType"] != null && dr["FK_PaymentType"] != DBNull.Value)
					{
						item.FK_PaymentType = Convert.ToString(dr["FK_PaymentType"]);
					}
					if (dr["BT3COD_B"] != null && dr["BT3COD_B"] != DBNull.Value)
					{
						item.BT3COD_B = Convert.ToDecimal(dr["BT3COD_B"]);
					}
					if (dr["BT3Freight_B"] != null && dr["BT3Freight_B"] != DBNull.Value)
					{
						item.BT3Freight_B = Convert.ToDecimal(dr["BT3Freight_B"]);
					}
					items.Add(item);
				}
				return items;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_GExpMoneyReturn từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_GExpMoneyReturn> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GExpMoneyReturn] A "+ condition,  parameters);
				List<view_GExpMoneyReturn> items = new List<view_GExpMoneyReturn>();
				view_GExpMoneyReturn item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GExpMoneyReturn();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
					{
						item.BT3Code = Convert.ToString(dr["BT3Code"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["Status"] != null && dr["Status"] != DBNull.Value)
					{
						item.Status = Convert.ToInt32(dr["Status"]);
					}
					if (dr["BT3COD"] != null && dr["BT3COD"] != DBNull.Value)
					{
						item.BT3COD = Convert.ToDecimal(dr["BT3COD"]);
					}
					if (dr["BT3TotalPaid"] != null && dr["BT3TotalPaid"] != DBNull.Value)
					{
						item.BT3TotalPaid = Convert.ToDecimal(dr["BT3TotalPaid"]);
					}
					if (dr["BT3TotalDiscount"] != null && dr["BT3TotalDiscount"] != DBNull.Value)
					{
						item.BT3TotalDiscount = Convert.ToDecimal(dr["BT3TotalDiscount"]);
					}
					if (dr["BT3TotalFee"] != null && dr["BT3TotalFee"] != DBNull.Value)
					{
						item.BT3TotalFee = Convert.ToDecimal(dr["BT3TotalFee"]);
					}
					if (dr["MoneyReturn"] != null && dr["MoneyReturn"] != DBNull.Value)
					{
						item.MoneyReturn = Convert.ToDecimal(dr["MoneyReturn"]);
					}
					if (dr["DateReturn"] != null && dr["DateReturn"] != DBNull.Value)
					{
						item.DateReturn = Convert.ToDateTime(dr["DateReturn"]);
					}
					if (dr["IsPayCustomer"] != null && dr["IsPayCustomer"] != DBNull.Value)
					{
						item.IsPayCustomer = Convert.ToBoolean(dr["IsPayCustomer"]);
					}
					if (dr["FK_MoneyReturnSession"] != null && dr["FK_MoneyReturnSession"] != DBNull.Value)
					{
						item.FK_MoneyReturnSession = Convert.ToString(dr["FK_MoneyReturnSession"]);
					}
					if (dr["ShopName"] != null && dr["ShopName"] != DBNull.Value)
					{
						item.ShopName = Convert.ToString(dr["ShopName"]);
					}
					if (dr["UserApi"] != null && dr["UserApi"] != DBNull.Value)
					{
						item.UserApi = Convert.ToString(dr["UserApi"]);
					}
					if (dr["ProviderName"] != null && dr["ProviderName"] != DBNull.Value)
					{
						item.ProviderName = Convert.ToString(dr["ProviderName"]);
					}
					if (dr["ProviderTypeCode"] != null && dr["ProviderTypeCode"] != DBNull.Value)
					{
						item.ProviderTypeCode = Convert.ToString(dr["ProviderTypeCode"]);
					}
					if (dr["MoneyReturnStatusName"] != null && dr["MoneyReturnStatusName"] != DBNull.Value)
					{
						item.MoneyReturnStatusName = Convert.ToString(dr["MoneyReturnStatusName"]);
					}
					if (dr["SendMan"] != null && dr["SendMan"] != DBNull.Value)
					{
						item.SendMan = Convert.ToString(dr["SendMan"]);
					}
					if (dr["SendManPhone"] != null && dr["SendManPhone"] != DBNull.Value)
					{
						item.SendManPhone = Convert.ToString(dr["SendManPhone"]);
					}
					if (dr["AcceptMan"] != null && dr["AcceptMan"] != DBNull.Value)
					{
						item.AcceptMan = Convert.ToString(dr["AcceptMan"]);
					}
					if (dr["AcceptManPhone"] != null && dr["AcceptManPhone"] != DBNull.Value)
					{
						item.AcceptManPhone = Convert.ToString(dr["AcceptManPhone"]);
					}
					if (dr["AcceptProvince"] != null && dr["AcceptProvince"] != DBNull.Value)
					{
						item.AcceptProvince = Convert.ToString(dr["AcceptProvince"]);
					}
					if (dr["COD"] != null && dr["COD"] != DBNull.Value)
					{
						item.COD = Convert.ToDecimal(dr["COD"]);
					}
					if (dr["Freight"] != null && dr["Freight"] != DBNull.Value)
					{
						item.Freight = Convert.ToDecimal(dr["Freight"]);
					}
					if (dr["FeeWeight"] != null && dr["FeeWeight"] != DBNull.Value)
					{
						item.FeeWeight = Convert.ToDecimal(dr["FeeWeight"]);
					}
					if (dr["BillWeight"] != null && dr["BillWeight"] != DBNull.Value)
					{
						item.BillWeight = Convert.ToDecimal(dr["BillWeight"]);
					}
					if (dr["PayType"] != null && dr["PayType"] != DBNull.Value)
					{
						item.PayType = Convert.ToString(dr["PayType"]);
					}
					if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
					{
						item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
					}
					if (dr["RegisterDate"] != null && dr["RegisterDate"] != DBNull.Value)
					{
						item.RegisterDate = Convert.ToDateTime(dr["RegisterDate"]);
					}
					if (dr["RegisterSiteCode"] != null && dr["RegisterSiteCode"] != DBNull.Value)
					{
						item.RegisterSiteCode = Convert.ToString(dr["RegisterSiteCode"]);
					}
					if (dr["FK_PaymentType"] != null && dr["FK_PaymentType"] != DBNull.Value)
					{
						item.FK_PaymentType = Convert.ToString(dr["FK_PaymentType"]);
					}
					if (dr["BT3COD_B"] != null && dr["BT3COD_B"] != DBNull.Value)
					{
						item.BT3COD_B = Convert.ToDecimal(dr["BT3COD_B"]);
					}
					if (dr["BT3Freight_B"] != null && dr["BT3Freight_B"] != DBNull.Value)
					{
						item.BT3Freight_B = Convert.ToDecimal(dr["BT3Freight_B"]);
					}
					items.Add(item);
				}
				return items;
			}
			catch
			{
				throw;
			}
		}

		public List<view_GExpMoneyReturn> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GExpMoneyReturn] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_GExpMoneyReturn] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_GExpMoneyReturn>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_GExpMoneyReturn đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_GExpMoneyReturn GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GExpMoneyReturn] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_GExpMoneyReturn item=new view_GExpMoneyReturn();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
						{
							item.BT3Code = Convert.ToString(dr["BT3Code"]);
						}
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["Status"] != null && dr["Status"] != DBNull.Value)
						{
							item.Status = Convert.ToInt32(dr["Status"]);
						}
						if (dr["BT3COD"] != null && dr["BT3COD"] != DBNull.Value)
						{
							item.BT3COD = Convert.ToDecimal(dr["BT3COD"]);
						}
						if (dr["BT3TotalPaid"] != null && dr["BT3TotalPaid"] != DBNull.Value)
						{
							item.BT3TotalPaid = Convert.ToDecimal(dr["BT3TotalPaid"]);
						}
						if (dr["BT3TotalDiscount"] != null && dr["BT3TotalDiscount"] != DBNull.Value)
						{
							item.BT3TotalDiscount = Convert.ToDecimal(dr["BT3TotalDiscount"]);
						}
						if (dr["BT3TotalFee"] != null && dr["BT3TotalFee"] != DBNull.Value)
						{
							item.BT3TotalFee = Convert.ToDecimal(dr["BT3TotalFee"]);
						}
						if (dr["MoneyReturn"] != null && dr["MoneyReturn"] != DBNull.Value)
						{
							item.MoneyReturn = Convert.ToDecimal(dr["MoneyReturn"]);
						}
						if (dr["DateReturn"] != null && dr["DateReturn"] != DBNull.Value)
						{
							item.DateReturn = Convert.ToDateTime(dr["DateReturn"]);
						}
						if (dr["IsPayCustomer"] != null && dr["IsPayCustomer"] != DBNull.Value)
						{
							item.IsPayCustomer = Convert.ToBoolean(dr["IsPayCustomer"]);
						}
						if (dr["FK_MoneyReturnSession"] != null && dr["FK_MoneyReturnSession"] != DBNull.Value)
						{
							item.FK_MoneyReturnSession = Convert.ToString(dr["FK_MoneyReturnSession"]);
						}
						if (dr["ShopName"] != null && dr["ShopName"] != DBNull.Value)
						{
							item.ShopName = Convert.ToString(dr["ShopName"]);
						}
						if (dr["UserApi"] != null && dr["UserApi"] != DBNull.Value)
						{
							item.UserApi = Convert.ToString(dr["UserApi"]);
						}
						if (dr["ProviderName"] != null && dr["ProviderName"] != DBNull.Value)
						{
							item.ProviderName = Convert.ToString(dr["ProviderName"]);
						}
						if (dr["ProviderTypeCode"] != null && dr["ProviderTypeCode"] != DBNull.Value)
						{
							item.ProviderTypeCode = Convert.ToString(dr["ProviderTypeCode"]);
						}
						if (dr["MoneyReturnStatusName"] != null && dr["MoneyReturnStatusName"] != DBNull.Value)
						{
							item.MoneyReturnStatusName = Convert.ToString(dr["MoneyReturnStatusName"]);
						}
						if (dr["SendMan"] != null && dr["SendMan"] != DBNull.Value)
						{
							item.SendMan = Convert.ToString(dr["SendMan"]);
						}
						if (dr["SendManPhone"] != null && dr["SendManPhone"] != DBNull.Value)
						{
							item.SendManPhone = Convert.ToString(dr["SendManPhone"]);
						}
						if (dr["AcceptMan"] != null && dr["AcceptMan"] != DBNull.Value)
						{
							item.AcceptMan = Convert.ToString(dr["AcceptMan"]);
						}
						if (dr["AcceptManPhone"] != null && dr["AcceptManPhone"] != DBNull.Value)
						{
							item.AcceptManPhone = Convert.ToString(dr["AcceptManPhone"]);
						}
						if (dr["AcceptProvince"] != null && dr["AcceptProvince"] != DBNull.Value)
						{
							item.AcceptProvince = Convert.ToString(dr["AcceptProvince"]);
						}
						if (dr["COD"] != null && dr["COD"] != DBNull.Value)
						{
							item.COD = Convert.ToDecimal(dr["COD"]);
						}
						if (dr["Freight"] != null && dr["Freight"] != DBNull.Value)
						{
							item.Freight = Convert.ToDecimal(dr["Freight"]);
						}
						if (dr["FeeWeight"] != null && dr["FeeWeight"] != DBNull.Value)
						{
							item.FeeWeight = Convert.ToDecimal(dr["FeeWeight"]);
						}
						if (dr["BillWeight"] != null && dr["BillWeight"] != DBNull.Value)
						{
							item.BillWeight = Convert.ToDecimal(dr["BillWeight"]);
						}
						if (dr["PayType"] != null && dr["PayType"] != DBNull.Value)
						{
							item.PayType = Convert.ToString(dr["PayType"]);
						}
						if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
						{
							item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
						}
						if (dr["RegisterDate"] != null && dr["RegisterDate"] != DBNull.Value)
						{
							item.RegisterDate = Convert.ToDateTime(dr["RegisterDate"]);
						}
						if (dr["RegisterSiteCode"] != null && dr["RegisterSiteCode"] != DBNull.Value)
						{
							item.RegisterSiteCode = Convert.ToString(dr["RegisterSiteCode"]);
						}
						if (dr["FK_PaymentType"] != null && dr["FK_PaymentType"] != DBNull.Value)
						{
							item.FK_PaymentType = Convert.ToString(dr["FK_PaymentType"]);
						}
						if (dr["BT3COD_B"] != null && dr["BT3COD_B"] != DBNull.Value)
						{
							item.BT3COD_B = Convert.ToDecimal(dr["BT3COD_B"]);
						}
						if (dr["BT3Freight_B"] != null && dr["BT3Freight_B"] != DBNull.Value)
						{
							item.BT3Freight_B = Convert.ToDecimal(dr["BT3Freight_B"]);
						}

						break;
					}
					return item;
				}
				else
				{
					return null;
				}
			}
			catch
			{
				throw;
			}
		}

		public view_GExpMoneyReturn GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GExpMoneyReturn] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_GExpMoneyReturn>(ds);
				}
				else
				{
					return null;
				}
			}
			catch
			{
				throw;
			}
		}
	}
}
