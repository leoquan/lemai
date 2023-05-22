using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewexpbill:IVIewexpbill
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewexpbill(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_ExpBILL từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpBILL]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_ExpBILL từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpBILL] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_ExpBILL từ Database
		/// </summary>
		public List<view_ExpBILL> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpBILL]");
				List<view_ExpBILL> items = new List<view_ExpBILL>();
				view_ExpBILL item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpBILL();
					if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
					{
						item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
					}
					if (dr["BILL_WEIGHT"] != null && dr["BILL_WEIGHT"] != DBNull.Value)
					{
						item.BILL_WEIGHT = Convert.ToDecimal(dr["BILL_WEIGHT"]);
					}
					if (dr["FEE_WEIGHT"] != null && dr["FEE_WEIGHT"] != DBNull.Value)
					{
						item.FEE_WEIGHT = Convert.ToDecimal(dr["FEE_WEIGHT"]);
					}
					if (dr["SEND_SITE_CODE"] != null && dr["SEND_SITE_CODE"] != DBNull.Value)
					{
						item.SEND_SITE_CODE = Convert.ToString(dr["SEND_SITE_CODE"]);
					}
					if (dr["REGISTER_SITE_CODE"] != null && dr["REGISTER_SITE_CODE"] != DBNull.Value)
					{
						item.REGISTER_SITE_CODE = Convert.ToString(dr["REGISTER_SITE_CODE"]);
					}
					if (dr["FREIGHT"] != null && dr["FREIGHT"] != DBNull.Value)
					{
						item.FREIGHT = Convert.ToDecimal(dr["FREIGHT"]);
					}
					if (dr["GOODS_PAYMENT"] != null && dr["GOODS_PAYMENT"] != DBNull.Value)
					{
						item.GOODS_PAYMENT = Convert.ToDecimal(dr["GOODS_PAYMENT"]);
					}
					if (dr["SEND_MAN"] != null && dr["SEND_MAN"] != DBNull.Value)
					{
						item.SEND_MAN = Convert.ToString(dr["SEND_MAN"]);
					}
					if (dr["SEND_MAN_PHONE"] != null && dr["SEND_MAN_PHONE"] != DBNull.Value)
					{
						item.SEND_MAN_PHONE = Convert.ToString(dr["SEND_MAN_PHONE"]);
					}
					if (dr["SEND_MAN_ADDRESS"] != null && dr["SEND_MAN_ADDRESS"] != DBNull.Value)
					{
						item.SEND_MAN_ADDRESS = Convert.ToString(dr["SEND_MAN_ADDRESS"]);
					}
					if (dr["ACCEPT_MAN"] != null && dr["ACCEPT_MAN"] != DBNull.Value)
					{
						item.ACCEPT_MAN = Convert.ToString(dr["ACCEPT_MAN"]);
					}
					if (dr["ACCEPT_MAN_PHONE"] != null && dr["ACCEPT_MAN_PHONE"] != DBNull.Value)
					{
						item.ACCEPT_MAN_PHONE = Convert.ToString(dr["ACCEPT_MAN_PHONE"]);
					}
					if (dr["ACCEPT_MAN_ADDRESS"] != null && dr["ACCEPT_MAN_ADDRESS"] != DBNull.Value)
					{
						item.ACCEPT_MAN_ADDRESS = Convert.ToString(dr["ACCEPT_MAN_ADDRESS"]);
					}
					if (dr["ACCEPT_PROVINCE_CODE"] != null && dr["ACCEPT_PROVINCE_CODE"] != DBNull.Value)
					{
						item.ACCEPT_PROVINCE_CODE = Convert.ToString(dr["ACCEPT_PROVINCE_CODE"]);
					}
					if (dr["ACCEPT_CITY_CODE"] != null && dr["ACCEPT_CITY_CODE"] != DBNull.Value)
					{
						item.ACCEPT_CITY_CODE = Convert.ToString(dr["ACCEPT_CITY_CODE"]);
					}
					if (dr["ACCEPT_COUNTY_CODE"] != null && dr["ACCEPT_COUNTY_CODE"] != DBNull.Value)
					{
						item.ACCEPT_COUNTY_CODE = Convert.ToString(dr["ACCEPT_COUNTY_CODE"]);
					}
					if (dr["IS_SIGNED"] != null && dr["IS_SIGNED"] != DBNull.Value)
					{
						item.IS_SIGNED = Convert.ToBoolean(dr["IS_SIGNED"]);
					}
					if (dr["IS_RETURN"] != null && dr["IS_RETURN"] != DBNull.Value)
					{
						item.IS_RETURN = Convert.ToBoolean(dr["IS_RETURN"]);
					}
					if (dr["BILL_PROCESS_STATUS"] != null && dr["BILL_PROCESS_STATUS"] != DBNull.Value)
					{
						item.BILL_PROCESS_STATUS = Convert.ToInt32(dr["BILL_PROCESS_STATUS"]);
					}
					if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
					{
						item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
					}
					if (dr["REGISTER_DATE"] != null && dr["REGISTER_DATE"] != DBNull.Value)
					{
						item.REGISTER_DATE = Convert.ToDateTime(dr["REGISTER_DATE"]);
					}
					if (dr["SIGNED_DATE"] != null && dr["SIGNED_DATE"] != DBNull.Value)
					{
						item.SIGNED_DATE = Convert.ToDateTime(dr["SIGNED_DATE"]);
					}
					if (dr["LAST_UPDATE_DATE"] != null && dr["LAST_UPDATE_DATE"] != DBNull.Value)
					{
						item.LAST_UPDATE_DATE = Convert.ToDateTime(dr["LAST_UPDATE_DATE"]);
					}
					if (dr["LAST_UPDATE_USER"] != null && dr["LAST_UPDATE_USER"] != DBNull.Value)
					{
						item.LAST_UPDATE_USER = Convert.ToString(dr["LAST_UPDATE_USER"]);
					}
					if (dr["PAY_TYPE"] != null && dr["PAY_TYPE"] != DBNull.Value)
					{
						item.PAY_TYPE = Convert.ToString(dr["PAY_TYPE"]);
					}
					if (dr["TTKT_WEIGHT"] != null && dr["TTKT_WEIGHT"] != DBNull.Value)
					{
						item.TTKT_WEIGHT = Convert.ToDecimal(dr["TTKT_WEIGHT"]);
					}
					if (dr["LAST_POST"] != null && dr["LAST_POST"] != DBNull.Value)
					{
						item.LAST_POST = Convert.ToString(dr["LAST_POST"]);
					}
					if (dr["IS_VITURAL"] != null && dr["IS_VITURAL"] != DBNull.Value)
					{
						item.IS_VITURAL = Convert.ToBoolean(dr["IS_VITURAL"]);
					}
					if (dr["DES_SITE"] != null && dr["DES_SITE"] != DBNull.Value)
					{
						item.DES_SITE = Convert.ToString(dr["DES_SITE"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["WORKING_PRIOTY"] != null && dr["WORKING_PRIOTY"] != DBNull.Value)
					{
						item.WORKING_PRIOTY = Convert.ToInt32(dr["WORKING_PRIOTY"]);
					}
					if (dr["SYSTEM_DATE"] != null && dr["SYSTEM_DATE"] != DBNull.Value)
					{
						item.SYSTEM_DATE = Convert.ToDateTime(dr["SYSTEM_DATE"]);
					}
					if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
					{
						item.StatusName = Convert.ToString(dr["StatusName"]);
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
		/// Lấy danh sách view_ExpBILL từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_ExpBILL> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpBILL] A "+ condition,  parameters);
				List<view_ExpBILL> items = new List<view_ExpBILL>();
				view_ExpBILL item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpBILL();
					if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
					{
						item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
					}
					if (dr["BILL_WEIGHT"] != null && dr["BILL_WEIGHT"] != DBNull.Value)
					{
						item.BILL_WEIGHT = Convert.ToDecimal(dr["BILL_WEIGHT"]);
					}
					if (dr["FEE_WEIGHT"] != null && dr["FEE_WEIGHT"] != DBNull.Value)
					{
						item.FEE_WEIGHT = Convert.ToDecimal(dr["FEE_WEIGHT"]);
					}
					if (dr["SEND_SITE_CODE"] != null && dr["SEND_SITE_CODE"] != DBNull.Value)
					{
						item.SEND_SITE_CODE = Convert.ToString(dr["SEND_SITE_CODE"]);
					}
					if (dr["REGISTER_SITE_CODE"] != null && dr["REGISTER_SITE_CODE"] != DBNull.Value)
					{
						item.REGISTER_SITE_CODE = Convert.ToString(dr["REGISTER_SITE_CODE"]);
					}
					if (dr["FREIGHT"] != null && dr["FREIGHT"] != DBNull.Value)
					{
						item.FREIGHT = Convert.ToDecimal(dr["FREIGHT"]);
					}
					if (dr["GOODS_PAYMENT"] != null && dr["GOODS_PAYMENT"] != DBNull.Value)
					{
						item.GOODS_PAYMENT = Convert.ToDecimal(dr["GOODS_PAYMENT"]);
					}
					if (dr["SEND_MAN"] != null && dr["SEND_MAN"] != DBNull.Value)
					{
						item.SEND_MAN = Convert.ToString(dr["SEND_MAN"]);
					}
					if (dr["SEND_MAN_PHONE"] != null && dr["SEND_MAN_PHONE"] != DBNull.Value)
					{
						item.SEND_MAN_PHONE = Convert.ToString(dr["SEND_MAN_PHONE"]);
					}
					if (dr["SEND_MAN_ADDRESS"] != null && dr["SEND_MAN_ADDRESS"] != DBNull.Value)
					{
						item.SEND_MAN_ADDRESS = Convert.ToString(dr["SEND_MAN_ADDRESS"]);
					}
					if (dr["ACCEPT_MAN"] != null && dr["ACCEPT_MAN"] != DBNull.Value)
					{
						item.ACCEPT_MAN = Convert.ToString(dr["ACCEPT_MAN"]);
					}
					if (dr["ACCEPT_MAN_PHONE"] != null && dr["ACCEPT_MAN_PHONE"] != DBNull.Value)
					{
						item.ACCEPT_MAN_PHONE = Convert.ToString(dr["ACCEPT_MAN_PHONE"]);
					}
					if (dr["ACCEPT_MAN_ADDRESS"] != null && dr["ACCEPT_MAN_ADDRESS"] != DBNull.Value)
					{
						item.ACCEPT_MAN_ADDRESS = Convert.ToString(dr["ACCEPT_MAN_ADDRESS"]);
					}
					if (dr["ACCEPT_PROVINCE_CODE"] != null && dr["ACCEPT_PROVINCE_CODE"] != DBNull.Value)
					{
						item.ACCEPT_PROVINCE_CODE = Convert.ToString(dr["ACCEPT_PROVINCE_CODE"]);
					}
					if (dr["ACCEPT_CITY_CODE"] != null && dr["ACCEPT_CITY_CODE"] != DBNull.Value)
					{
						item.ACCEPT_CITY_CODE = Convert.ToString(dr["ACCEPT_CITY_CODE"]);
					}
					if (dr["ACCEPT_COUNTY_CODE"] != null && dr["ACCEPT_COUNTY_CODE"] != DBNull.Value)
					{
						item.ACCEPT_COUNTY_CODE = Convert.ToString(dr["ACCEPT_COUNTY_CODE"]);
					}
					if (dr["IS_SIGNED"] != null && dr["IS_SIGNED"] != DBNull.Value)
					{
						item.IS_SIGNED = Convert.ToBoolean(dr["IS_SIGNED"]);
					}
					if (dr["IS_RETURN"] != null && dr["IS_RETURN"] != DBNull.Value)
					{
						item.IS_RETURN = Convert.ToBoolean(dr["IS_RETURN"]);
					}
					if (dr["BILL_PROCESS_STATUS"] != null && dr["BILL_PROCESS_STATUS"] != DBNull.Value)
					{
						item.BILL_PROCESS_STATUS = Convert.ToInt32(dr["BILL_PROCESS_STATUS"]);
					}
					if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
					{
						item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
					}
					if (dr["REGISTER_DATE"] != null && dr["REGISTER_DATE"] != DBNull.Value)
					{
						item.REGISTER_DATE = Convert.ToDateTime(dr["REGISTER_DATE"]);
					}
					if (dr["SIGNED_DATE"] != null && dr["SIGNED_DATE"] != DBNull.Value)
					{
						item.SIGNED_DATE = Convert.ToDateTime(dr["SIGNED_DATE"]);
					}
					if (dr["LAST_UPDATE_DATE"] != null && dr["LAST_UPDATE_DATE"] != DBNull.Value)
					{
						item.LAST_UPDATE_DATE = Convert.ToDateTime(dr["LAST_UPDATE_DATE"]);
					}
					if (dr["LAST_UPDATE_USER"] != null && dr["LAST_UPDATE_USER"] != DBNull.Value)
					{
						item.LAST_UPDATE_USER = Convert.ToString(dr["LAST_UPDATE_USER"]);
					}
					if (dr["PAY_TYPE"] != null && dr["PAY_TYPE"] != DBNull.Value)
					{
						item.PAY_TYPE = Convert.ToString(dr["PAY_TYPE"]);
					}
					if (dr["TTKT_WEIGHT"] != null && dr["TTKT_WEIGHT"] != DBNull.Value)
					{
						item.TTKT_WEIGHT = Convert.ToDecimal(dr["TTKT_WEIGHT"]);
					}
					if (dr["LAST_POST"] != null && dr["LAST_POST"] != DBNull.Value)
					{
						item.LAST_POST = Convert.ToString(dr["LAST_POST"]);
					}
					if (dr["IS_VITURAL"] != null && dr["IS_VITURAL"] != DBNull.Value)
					{
						item.IS_VITURAL = Convert.ToBoolean(dr["IS_VITURAL"]);
					}
					if (dr["DES_SITE"] != null && dr["DES_SITE"] != DBNull.Value)
					{
						item.DES_SITE = Convert.ToString(dr["DES_SITE"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["WORKING_PRIOTY"] != null && dr["WORKING_PRIOTY"] != DBNull.Value)
					{
						item.WORKING_PRIOTY = Convert.ToInt32(dr["WORKING_PRIOTY"]);
					}
					if (dr["SYSTEM_DATE"] != null && dr["SYSTEM_DATE"] != DBNull.Value)
					{
						item.SYSTEM_DATE = Convert.ToDateTime(dr["SYSTEM_DATE"]);
					}
					if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
					{
						item.StatusName = Convert.ToString(dr["StatusName"]);
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

		public List<view_ExpBILL> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpBILL] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_ExpBILL] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_ExpBILL>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_ExpBILL đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_ExpBILL GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpBILL] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_ExpBILL item=new view_ExpBILL();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
						{
							item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
						}
						if (dr["BILL_WEIGHT"] != null && dr["BILL_WEIGHT"] != DBNull.Value)
						{
							item.BILL_WEIGHT = Convert.ToDecimal(dr["BILL_WEIGHT"]);
						}
						if (dr["FEE_WEIGHT"] != null && dr["FEE_WEIGHT"] != DBNull.Value)
						{
							item.FEE_WEIGHT = Convert.ToDecimal(dr["FEE_WEIGHT"]);
						}
						if (dr["SEND_SITE_CODE"] != null && dr["SEND_SITE_CODE"] != DBNull.Value)
						{
							item.SEND_SITE_CODE = Convert.ToString(dr["SEND_SITE_CODE"]);
						}
						if (dr["REGISTER_SITE_CODE"] != null && dr["REGISTER_SITE_CODE"] != DBNull.Value)
						{
							item.REGISTER_SITE_CODE = Convert.ToString(dr["REGISTER_SITE_CODE"]);
						}
						if (dr["FREIGHT"] != null && dr["FREIGHT"] != DBNull.Value)
						{
							item.FREIGHT = Convert.ToDecimal(dr["FREIGHT"]);
						}
						if (dr["GOODS_PAYMENT"] != null && dr["GOODS_PAYMENT"] != DBNull.Value)
						{
							item.GOODS_PAYMENT = Convert.ToDecimal(dr["GOODS_PAYMENT"]);
						}
						if (dr["SEND_MAN"] != null && dr["SEND_MAN"] != DBNull.Value)
						{
							item.SEND_MAN = Convert.ToString(dr["SEND_MAN"]);
						}
						if (dr["SEND_MAN_PHONE"] != null && dr["SEND_MAN_PHONE"] != DBNull.Value)
						{
							item.SEND_MAN_PHONE = Convert.ToString(dr["SEND_MAN_PHONE"]);
						}
						if (dr["SEND_MAN_ADDRESS"] != null && dr["SEND_MAN_ADDRESS"] != DBNull.Value)
						{
							item.SEND_MAN_ADDRESS = Convert.ToString(dr["SEND_MAN_ADDRESS"]);
						}
						if (dr["ACCEPT_MAN"] != null && dr["ACCEPT_MAN"] != DBNull.Value)
						{
							item.ACCEPT_MAN = Convert.ToString(dr["ACCEPT_MAN"]);
						}
						if (dr["ACCEPT_MAN_PHONE"] != null && dr["ACCEPT_MAN_PHONE"] != DBNull.Value)
						{
							item.ACCEPT_MAN_PHONE = Convert.ToString(dr["ACCEPT_MAN_PHONE"]);
						}
						if (dr["ACCEPT_MAN_ADDRESS"] != null && dr["ACCEPT_MAN_ADDRESS"] != DBNull.Value)
						{
							item.ACCEPT_MAN_ADDRESS = Convert.ToString(dr["ACCEPT_MAN_ADDRESS"]);
						}
						if (dr["ACCEPT_PROVINCE_CODE"] != null && dr["ACCEPT_PROVINCE_CODE"] != DBNull.Value)
						{
							item.ACCEPT_PROVINCE_CODE = Convert.ToString(dr["ACCEPT_PROVINCE_CODE"]);
						}
						if (dr["ACCEPT_CITY_CODE"] != null && dr["ACCEPT_CITY_CODE"] != DBNull.Value)
						{
							item.ACCEPT_CITY_CODE = Convert.ToString(dr["ACCEPT_CITY_CODE"]);
						}
						if (dr["ACCEPT_COUNTY_CODE"] != null && dr["ACCEPT_COUNTY_CODE"] != DBNull.Value)
						{
							item.ACCEPT_COUNTY_CODE = Convert.ToString(dr["ACCEPT_COUNTY_CODE"]);
						}
						if (dr["IS_SIGNED"] != null && dr["IS_SIGNED"] != DBNull.Value)
						{
							item.IS_SIGNED = Convert.ToBoolean(dr["IS_SIGNED"]);
						}
						if (dr["IS_RETURN"] != null && dr["IS_RETURN"] != DBNull.Value)
						{
							item.IS_RETURN = Convert.ToBoolean(dr["IS_RETURN"]);
						}
						if (dr["BILL_PROCESS_STATUS"] != null && dr["BILL_PROCESS_STATUS"] != DBNull.Value)
						{
							item.BILL_PROCESS_STATUS = Convert.ToInt32(dr["BILL_PROCESS_STATUS"]);
						}
						if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
						{
							item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
						}
						if (dr["REGISTER_DATE"] != null && dr["REGISTER_DATE"] != DBNull.Value)
						{
							item.REGISTER_DATE = Convert.ToDateTime(dr["REGISTER_DATE"]);
						}
						if (dr["SIGNED_DATE"] != null && dr["SIGNED_DATE"] != DBNull.Value)
						{
							item.SIGNED_DATE = Convert.ToDateTime(dr["SIGNED_DATE"]);
						}
						if (dr["LAST_UPDATE_DATE"] != null && dr["LAST_UPDATE_DATE"] != DBNull.Value)
						{
							item.LAST_UPDATE_DATE = Convert.ToDateTime(dr["LAST_UPDATE_DATE"]);
						}
						if (dr["LAST_UPDATE_USER"] != null && dr["LAST_UPDATE_USER"] != DBNull.Value)
						{
							item.LAST_UPDATE_USER = Convert.ToString(dr["LAST_UPDATE_USER"]);
						}
						if (dr["PAY_TYPE"] != null && dr["PAY_TYPE"] != DBNull.Value)
						{
							item.PAY_TYPE = Convert.ToString(dr["PAY_TYPE"]);
						}
						if (dr["TTKT_WEIGHT"] != null && dr["TTKT_WEIGHT"] != DBNull.Value)
						{
							item.TTKT_WEIGHT = Convert.ToDecimal(dr["TTKT_WEIGHT"]);
						}
						if (dr["LAST_POST"] != null && dr["LAST_POST"] != DBNull.Value)
						{
							item.LAST_POST = Convert.ToString(dr["LAST_POST"]);
						}
						if (dr["IS_VITURAL"] != null && dr["IS_VITURAL"] != DBNull.Value)
						{
							item.IS_VITURAL = Convert.ToBoolean(dr["IS_VITURAL"]);
						}
						if (dr["DES_SITE"] != null && dr["DES_SITE"] != DBNull.Value)
						{
							item.DES_SITE = Convert.ToString(dr["DES_SITE"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["WORKING_PRIOTY"] != null && dr["WORKING_PRIOTY"] != DBNull.Value)
						{
							item.WORKING_PRIOTY = Convert.ToInt32(dr["WORKING_PRIOTY"]);
						}
						if (dr["SYSTEM_DATE"] != null && dr["SYSTEM_DATE"] != DBNull.Value)
						{
							item.SYSTEM_DATE = Convert.ToDateTime(dr["SYSTEM_DATE"]);
						}
						if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
						{
							item.StatusName = Convert.ToString(dr["StatusName"]);
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

		public view_ExpBILL GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpBILL] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_ExpBILL>(ds);
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
