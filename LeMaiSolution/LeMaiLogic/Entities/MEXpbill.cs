using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpbill:IEXpbill
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpbill(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpBILL từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpBILL]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpBILL từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpBILL] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpBILL từ Database
		/// </summary>
		public List<ExpBILL> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpBILL]");
				List<ExpBILL> items = new List<ExpBILL>();
				ExpBILL item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpBILL();
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
					if (dr["BT3Type"] != null && dr["BT3Type"] != DBNull.Value)
					{
						item.BT3Type = Convert.ToString(dr["BT3Type"]);
					}
					if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
					{
						item.BT3Code = Convert.ToString(dr["BT3Code"]);
					}
					if (dr["BT3Status"] != null && dr["BT3Status"] != DBNull.Value)
					{
						item.BT3Status = Convert.ToString(dr["BT3Status"]);
					}
					if (dr["BT3LastMess"] != null && dr["BT3LastMess"] != DBNull.Value)
					{
						item.BT3LastMess = Convert.ToString(dr["BT3LastMess"]);
					}
					if (dr["TenVatPham"] != null && dr["TenVatPham"] != DBNull.Value)
					{
						item.TenVatPham = Convert.ToString(dr["TenVatPham"]);
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
		/// Lấy danh sách ExpBILL từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpBILL> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpBILL] A "+ condition,  parameters);
				List<ExpBILL> items = new List<ExpBILL>();
				ExpBILL item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpBILL();
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
					if (dr["BT3Type"] != null && dr["BT3Type"] != DBNull.Value)
					{
						item.BT3Type = Convert.ToString(dr["BT3Type"]);
					}
					if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
					{
						item.BT3Code = Convert.ToString(dr["BT3Code"]);
					}
					if (dr["BT3Status"] != null && dr["BT3Status"] != DBNull.Value)
					{
						item.BT3Status = Convert.ToString(dr["BT3Status"]);
					}
					if (dr["BT3LastMess"] != null && dr["BT3LastMess"] != DBNull.Value)
					{
						item.BT3LastMess = Convert.ToString(dr["BT3LastMess"]);
					}
					if (dr["TenVatPham"] != null && dr["TenVatPham"] != DBNull.Value)
					{
						item.TenVatPham = Convert.ToString(dr["TenVatPham"]);
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

		public List<ExpBILL> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpBILL] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpBILL] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpBILL>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpBILL từ Database
		/// </summary>
		public ExpBILL GetObject(string schema, String BILL_CODE)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpBILL] where BILL_CODE=@BILL_CODE",
					"@BILL_CODE", BILL_CODE);
				if (ds.Rows.Count > 0)
				{
					ExpBILL item=new ExpBILL();
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
						if (dr["BT3Type"] != null && dr["BT3Type"] != DBNull.Value)
						{
							item.BT3Type = Convert.ToString(dr["BT3Type"]);
						}
						if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
						{
							item.BT3Code = Convert.ToString(dr["BT3Code"]);
						}
						if (dr["BT3Status"] != null && dr["BT3Status"] != DBNull.Value)
						{
							item.BT3Status = Convert.ToString(dr["BT3Status"]);
						}
						if (dr["BT3LastMess"] != null && dr["BT3LastMess"] != DBNull.Value)
						{
							item.BT3LastMess = Convert.ToString(dr["BT3LastMess"]);
						}
						if (dr["TenVatPham"] != null && dr["TenVatPham"] != DBNull.Value)
						{
							item.TenVatPham = Convert.ToString(dr["TenVatPham"]);
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

		/// <summary>
		/// Lấy một ExpBILL đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpBILL GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpBILL] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpBILL item=new ExpBILL();
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
						if (dr["BT3Type"] != null && dr["BT3Type"] != DBNull.Value)
						{
							item.BT3Type = Convert.ToString(dr["BT3Type"]);
						}
						if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
						{
							item.BT3Code = Convert.ToString(dr["BT3Code"]);
						}
						if (dr["BT3Status"] != null && dr["BT3Status"] != DBNull.Value)
						{
							item.BT3Status = Convert.ToString(dr["BT3Status"]);
						}
						if (dr["BT3LastMess"] != null && dr["BT3LastMess"] != DBNull.Value)
						{
							item.BT3LastMess = Convert.ToString(dr["BT3LastMess"]);
						}
						if (dr["TenVatPham"] != null && dr["TenVatPham"] != DBNull.Value)
						{
							item.TenVatPham = Convert.ToString(dr["TenVatPham"]);
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

		public ExpBILL GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpBILL] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpBILL>(ds);
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
		/// <summary>
		/// Thêm mới ExpBILL vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpBILL _ExpBILL)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpBILL](BILL_CODE, BILL_WEIGHT, FEE_WEIGHT, SEND_SITE_CODE, REGISTER_SITE_CODE, FREIGHT, GOODS_PAYMENT, SEND_MAN, SEND_MAN_PHONE, SEND_MAN_ADDRESS, ACCEPT_MAN, ACCEPT_MAN_PHONE, ACCEPT_MAN_ADDRESS, ACCEPT_PROVINCE_CODE, ACCEPT_CITY_CODE, ACCEPT_COUNTY_CODE, IS_SIGNED, IS_RETURN, BILL_PROCESS_STATUS, FK_Customer, REGISTER_DATE, SIGNED_DATE, LAST_UPDATE_DATE, LAST_UPDATE_USER, PAY_TYPE, TTKT_WEIGHT, LAST_POST, IS_VITURAL, DES_SITE, Note, WORKING_PRIOTY, SYSTEM_DATE, BT3Type, BT3Code, BT3Status, BT3LastMess, TenVatPham) VALUES(@BILL_CODE, @BILL_WEIGHT, @FEE_WEIGHT, @SEND_SITE_CODE, @REGISTER_SITE_CODE, @FREIGHT, @GOODS_PAYMENT, @SEND_MAN, @SEND_MAN_PHONE, @SEND_MAN_ADDRESS, @ACCEPT_MAN, @ACCEPT_MAN_PHONE, @ACCEPT_MAN_ADDRESS, @ACCEPT_PROVINCE_CODE, @ACCEPT_CITY_CODE, @ACCEPT_COUNTY_CODE, @IS_SIGNED, @IS_RETURN, @BILL_PROCESS_STATUS, @FK_Customer, @REGISTER_DATE, @SIGNED_DATE, @LAST_UPDATE_DATE, @LAST_UPDATE_USER, @PAY_TYPE, @TTKT_WEIGHT, @LAST_POST, @IS_VITURAL, @DES_SITE, @Note, @WORKING_PRIOTY, @SYSTEM_DATE, @BT3Type, @BT3Code, @BT3Status, @BT3LastMess, @TenVatPham)", 
					"@BILL_CODE",  _ExpBILL.BILL_CODE, 
					"@BILL_WEIGHT",  _ExpBILL.BILL_WEIGHT, 
					"@FEE_WEIGHT",  _ExpBILL.FEE_WEIGHT, 
					"@SEND_SITE_CODE",  _ExpBILL.SEND_SITE_CODE, 
					"@REGISTER_SITE_CODE",  _ExpBILL.REGISTER_SITE_CODE, 
					"@FREIGHT",  _ExpBILL.FREIGHT, 
					"@GOODS_PAYMENT",  _ExpBILL.GOODS_PAYMENT, 
					"@SEND_MAN",  _ExpBILL.SEND_MAN, 
					"@SEND_MAN_PHONE",  _ExpBILL.SEND_MAN_PHONE, 
					"@SEND_MAN_ADDRESS",  _ExpBILL.SEND_MAN_ADDRESS, 
					"@ACCEPT_MAN",  _ExpBILL.ACCEPT_MAN, 
					"@ACCEPT_MAN_PHONE",  _ExpBILL.ACCEPT_MAN_PHONE, 
					"@ACCEPT_MAN_ADDRESS",  _ExpBILL.ACCEPT_MAN_ADDRESS, 
					"@ACCEPT_PROVINCE_CODE",  _ExpBILL.ACCEPT_PROVINCE_CODE, 
					"@ACCEPT_CITY_CODE",  _ExpBILL.ACCEPT_CITY_CODE, 
					"@ACCEPT_COUNTY_CODE",  _ExpBILL.ACCEPT_COUNTY_CODE, 
					"@IS_SIGNED",  _ExpBILL.IS_SIGNED, 
					"@IS_RETURN",  _ExpBILL.IS_RETURN, 
					"@BILL_PROCESS_STATUS",  _ExpBILL.BILL_PROCESS_STATUS, 
					"@FK_Customer",  _ExpBILL.FK_Customer, 
					"@REGISTER_DATE", this._dataContext.ConvertDateString( _ExpBILL.REGISTER_DATE), 
					"@SIGNED_DATE", this._dataContext.ConvertDateString( _ExpBILL.SIGNED_DATE), 
					"@LAST_UPDATE_DATE", this._dataContext.ConvertDateString( _ExpBILL.LAST_UPDATE_DATE), 
					"@LAST_UPDATE_USER",  _ExpBILL.LAST_UPDATE_USER, 
					"@PAY_TYPE",  _ExpBILL.PAY_TYPE, 
					"@TTKT_WEIGHT",  _ExpBILL.TTKT_WEIGHT, 
					"@LAST_POST",  _ExpBILL.LAST_POST, 
					"@IS_VITURAL",  _ExpBILL.IS_VITURAL, 
					"@DES_SITE",  _ExpBILL.DES_SITE, 
					"@Note",  _ExpBILL.Note, 
					"@WORKING_PRIOTY",  _ExpBILL.WORKING_PRIOTY, 
					"@SYSTEM_DATE", this._dataContext.ConvertDateString( _ExpBILL.SYSTEM_DATE), 
					"@BT3Type",  _ExpBILL.BT3Type, 
					"@BT3Code",  _ExpBILL.BT3Code, 
					"@BT3Status",  _ExpBILL.BT3Status, 
					"@BT3LastMess",  _ExpBILL.BT3LastMess, 
					"@TenVatPham",  _ExpBILL.TenVatPham);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpBILL vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpBILL> _ExpBILLs)
		{
			foreach (ExpBILL item in _ExpBILLs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpBILL vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpBILL _ExpBILL, String BILL_CODE)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpBILL] SET BILL_CODE=@BILL_CODE, BILL_WEIGHT=@BILL_WEIGHT, FEE_WEIGHT=@FEE_WEIGHT, SEND_SITE_CODE=@SEND_SITE_CODE, REGISTER_SITE_CODE=@REGISTER_SITE_CODE, FREIGHT=@FREIGHT, GOODS_PAYMENT=@GOODS_PAYMENT, SEND_MAN=@SEND_MAN, SEND_MAN_PHONE=@SEND_MAN_PHONE, SEND_MAN_ADDRESS=@SEND_MAN_ADDRESS, ACCEPT_MAN=@ACCEPT_MAN, ACCEPT_MAN_PHONE=@ACCEPT_MAN_PHONE, ACCEPT_MAN_ADDRESS=@ACCEPT_MAN_ADDRESS, ACCEPT_PROVINCE_CODE=@ACCEPT_PROVINCE_CODE, ACCEPT_CITY_CODE=@ACCEPT_CITY_CODE, ACCEPT_COUNTY_CODE=@ACCEPT_COUNTY_CODE, IS_SIGNED=@IS_SIGNED, IS_RETURN=@IS_RETURN, BILL_PROCESS_STATUS=@BILL_PROCESS_STATUS, FK_Customer=@FK_Customer, REGISTER_DATE=@REGISTER_DATE, SIGNED_DATE=@SIGNED_DATE, LAST_UPDATE_DATE=@LAST_UPDATE_DATE, LAST_UPDATE_USER=@LAST_UPDATE_USER, PAY_TYPE=@PAY_TYPE, TTKT_WEIGHT=@TTKT_WEIGHT, LAST_POST=@LAST_POST, IS_VITURAL=@IS_VITURAL, DES_SITE=@DES_SITE, Note=@Note, WORKING_PRIOTY=@WORKING_PRIOTY, SYSTEM_DATE=@SYSTEM_DATE, BT3Type=@BT3Type, BT3Code=@BT3Code, BT3Status=@BT3Status, BT3LastMess=@BT3LastMess, TenVatPham=@TenVatPham WHERE BILL_CODE=@BILL_CODE", 
					"@BILL_CODE",  _ExpBILL.BILL_CODE, 
					"@BILL_WEIGHT",  _ExpBILL.BILL_WEIGHT, 
					"@FEE_WEIGHT",  _ExpBILL.FEE_WEIGHT, 
					"@SEND_SITE_CODE",  _ExpBILL.SEND_SITE_CODE, 
					"@REGISTER_SITE_CODE",  _ExpBILL.REGISTER_SITE_CODE, 
					"@FREIGHT",  _ExpBILL.FREIGHT, 
					"@GOODS_PAYMENT",  _ExpBILL.GOODS_PAYMENT, 
					"@SEND_MAN",  _ExpBILL.SEND_MAN, 
					"@SEND_MAN_PHONE",  _ExpBILL.SEND_MAN_PHONE, 
					"@SEND_MAN_ADDRESS",  _ExpBILL.SEND_MAN_ADDRESS, 
					"@ACCEPT_MAN",  _ExpBILL.ACCEPT_MAN, 
					"@ACCEPT_MAN_PHONE",  _ExpBILL.ACCEPT_MAN_PHONE, 
					"@ACCEPT_MAN_ADDRESS",  _ExpBILL.ACCEPT_MAN_ADDRESS, 
					"@ACCEPT_PROVINCE_CODE",  _ExpBILL.ACCEPT_PROVINCE_CODE, 
					"@ACCEPT_CITY_CODE",  _ExpBILL.ACCEPT_CITY_CODE, 
					"@ACCEPT_COUNTY_CODE",  _ExpBILL.ACCEPT_COUNTY_CODE, 
					"@IS_SIGNED",  _ExpBILL.IS_SIGNED, 
					"@IS_RETURN",  _ExpBILL.IS_RETURN, 
					"@BILL_PROCESS_STATUS",  _ExpBILL.BILL_PROCESS_STATUS, 
					"@FK_Customer",  _ExpBILL.FK_Customer, 
					"@REGISTER_DATE", this._dataContext.ConvertDateString( _ExpBILL.REGISTER_DATE), 
					"@SIGNED_DATE", this._dataContext.ConvertDateString( _ExpBILL.SIGNED_DATE), 
					"@LAST_UPDATE_DATE", this._dataContext.ConvertDateString( _ExpBILL.LAST_UPDATE_DATE), 
					"@LAST_UPDATE_USER",  _ExpBILL.LAST_UPDATE_USER, 
					"@PAY_TYPE",  _ExpBILL.PAY_TYPE, 
					"@TTKT_WEIGHT",  _ExpBILL.TTKT_WEIGHT, 
					"@LAST_POST",  _ExpBILL.LAST_POST, 
					"@IS_VITURAL",  _ExpBILL.IS_VITURAL, 
					"@DES_SITE",  _ExpBILL.DES_SITE, 
					"@Note",  _ExpBILL.Note, 
					"@WORKING_PRIOTY",  _ExpBILL.WORKING_PRIOTY, 
					"@SYSTEM_DATE", this._dataContext.ConvertDateString( _ExpBILL.SYSTEM_DATE), 
					"@BT3Type",  _ExpBILL.BT3Type, 
					"@BT3Code",  _ExpBILL.BT3Code, 
					"@BT3Status",  _ExpBILL.BT3Status, 
					"@BT3LastMess",  _ExpBILL.BT3LastMess, 
					"@TenVatPham",  _ExpBILL.TenVatPham, 
					"@BILL_CODE", BILL_CODE);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpBILL vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpBILL _ExpBILL)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpBILL] SET BILL_WEIGHT=@BILL_WEIGHT, FEE_WEIGHT=@FEE_WEIGHT, SEND_SITE_CODE=@SEND_SITE_CODE, REGISTER_SITE_CODE=@REGISTER_SITE_CODE, FREIGHT=@FREIGHT, GOODS_PAYMENT=@GOODS_PAYMENT, SEND_MAN=@SEND_MAN, SEND_MAN_PHONE=@SEND_MAN_PHONE, SEND_MAN_ADDRESS=@SEND_MAN_ADDRESS, ACCEPT_MAN=@ACCEPT_MAN, ACCEPT_MAN_PHONE=@ACCEPT_MAN_PHONE, ACCEPT_MAN_ADDRESS=@ACCEPT_MAN_ADDRESS, ACCEPT_PROVINCE_CODE=@ACCEPT_PROVINCE_CODE, ACCEPT_CITY_CODE=@ACCEPT_CITY_CODE, ACCEPT_COUNTY_CODE=@ACCEPT_COUNTY_CODE, IS_SIGNED=@IS_SIGNED, IS_RETURN=@IS_RETURN, BILL_PROCESS_STATUS=@BILL_PROCESS_STATUS, FK_Customer=@FK_Customer, REGISTER_DATE=@REGISTER_DATE, SIGNED_DATE=@SIGNED_DATE, LAST_UPDATE_DATE=@LAST_UPDATE_DATE, LAST_UPDATE_USER=@LAST_UPDATE_USER, PAY_TYPE=@PAY_TYPE, TTKT_WEIGHT=@TTKT_WEIGHT, LAST_POST=@LAST_POST, IS_VITURAL=@IS_VITURAL, DES_SITE=@DES_SITE, Note=@Note, WORKING_PRIOTY=@WORKING_PRIOTY, SYSTEM_DATE=@SYSTEM_DATE, BT3Type=@BT3Type, BT3Code=@BT3Code, BT3Status=@BT3Status, BT3LastMess=@BT3LastMess, TenVatPham=@TenVatPham WHERE BILL_CODE=@BILL_CODE", 
					"@BILL_WEIGHT",  _ExpBILL.BILL_WEIGHT, 
					"@FEE_WEIGHT",  _ExpBILL.FEE_WEIGHT, 
					"@SEND_SITE_CODE",  _ExpBILL.SEND_SITE_CODE, 
					"@REGISTER_SITE_CODE",  _ExpBILL.REGISTER_SITE_CODE, 
					"@FREIGHT",  _ExpBILL.FREIGHT, 
					"@GOODS_PAYMENT",  _ExpBILL.GOODS_PAYMENT, 
					"@SEND_MAN",  _ExpBILL.SEND_MAN, 
					"@SEND_MAN_PHONE",  _ExpBILL.SEND_MAN_PHONE, 
					"@SEND_MAN_ADDRESS",  _ExpBILL.SEND_MAN_ADDRESS, 
					"@ACCEPT_MAN",  _ExpBILL.ACCEPT_MAN, 
					"@ACCEPT_MAN_PHONE",  _ExpBILL.ACCEPT_MAN_PHONE, 
					"@ACCEPT_MAN_ADDRESS",  _ExpBILL.ACCEPT_MAN_ADDRESS, 
					"@ACCEPT_PROVINCE_CODE",  _ExpBILL.ACCEPT_PROVINCE_CODE, 
					"@ACCEPT_CITY_CODE",  _ExpBILL.ACCEPT_CITY_CODE, 
					"@ACCEPT_COUNTY_CODE",  _ExpBILL.ACCEPT_COUNTY_CODE, 
					"@IS_SIGNED",  _ExpBILL.IS_SIGNED, 
					"@IS_RETURN",  _ExpBILL.IS_RETURN, 
					"@BILL_PROCESS_STATUS",  _ExpBILL.BILL_PROCESS_STATUS, 
					"@FK_Customer",  _ExpBILL.FK_Customer, 
					"@REGISTER_DATE", this._dataContext.ConvertDateString( _ExpBILL.REGISTER_DATE), 
					"@SIGNED_DATE", this._dataContext.ConvertDateString( _ExpBILL.SIGNED_DATE), 
					"@LAST_UPDATE_DATE", this._dataContext.ConvertDateString( _ExpBILL.LAST_UPDATE_DATE), 
					"@LAST_UPDATE_USER",  _ExpBILL.LAST_UPDATE_USER, 
					"@PAY_TYPE",  _ExpBILL.PAY_TYPE, 
					"@TTKT_WEIGHT",  _ExpBILL.TTKT_WEIGHT, 
					"@LAST_POST",  _ExpBILL.LAST_POST, 
					"@IS_VITURAL",  _ExpBILL.IS_VITURAL, 
					"@DES_SITE",  _ExpBILL.DES_SITE, 
					"@Note",  _ExpBILL.Note, 
					"@WORKING_PRIOTY",  _ExpBILL.WORKING_PRIOTY, 
					"@SYSTEM_DATE", this._dataContext.ConvertDateString( _ExpBILL.SYSTEM_DATE), 
					"@BT3Type",  _ExpBILL.BT3Type, 
					"@BT3Code",  _ExpBILL.BT3Code, 
					"@BT3Status",  _ExpBILL.BT3Status, 
					"@BT3LastMess",  _ExpBILL.BT3LastMess, 
					"@TenVatPham",  _ExpBILL.TenVatPham, 
					"@BILL_CODE", _ExpBILL.BILL_CODE);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpBILL vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpBILL> _ExpBILLs)
		{
			foreach (ExpBILL item in _ExpBILLs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpBILL vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpBILL _ExpBILL, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpBILL] SET BILL_CODE=@BILL_CODE, BILL_WEIGHT=@BILL_WEIGHT, FEE_WEIGHT=@FEE_WEIGHT, SEND_SITE_CODE=@SEND_SITE_CODE, REGISTER_SITE_CODE=@REGISTER_SITE_CODE, FREIGHT=@FREIGHT, GOODS_PAYMENT=@GOODS_PAYMENT, SEND_MAN=@SEND_MAN, SEND_MAN_PHONE=@SEND_MAN_PHONE, SEND_MAN_ADDRESS=@SEND_MAN_ADDRESS, ACCEPT_MAN=@ACCEPT_MAN, ACCEPT_MAN_PHONE=@ACCEPT_MAN_PHONE, ACCEPT_MAN_ADDRESS=@ACCEPT_MAN_ADDRESS, ACCEPT_PROVINCE_CODE=@ACCEPT_PROVINCE_CODE, ACCEPT_CITY_CODE=@ACCEPT_CITY_CODE, ACCEPT_COUNTY_CODE=@ACCEPT_COUNTY_CODE, IS_SIGNED=@IS_SIGNED, IS_RETURN=@IS_RETURN, BILL_PROCESS_STATUS=@BILL_PROCESS_STATUS, FK_Customer=@FK_Customer, REGISTER_DATE=@REGISTER_DATE, SIGNED_DATE=@SIGNED_DATE, LAST_UPDATE_DATE=@LAST_UPDATE_DATE, LAST_UPDATE_USER=@LAST_UPDATE_USER, PAY_TYPE=@PAY_TYPE, TTKT_WEIGHT=@TTKT_WEIGHT, LAST_POST=@LAST_POST, IS_VITURAL=@IS_VITURAL, DES_SITE=@DES_SITE, Note=@Note, WORKING_PRIOTY=@WORKING_PRIOTY, SYSTEM_DATE=@SYSTEM_DATE, BT3Type=@BT3Type, BT3Code=@BT3Code, BT3Status=@BT3Status, BT3LastMess=@BT3LastMess, TenVatPham=@TenVatPham "+ condition, 
					"@BILL_CODE",  _ExpBILL.BILL_CODE, 
					"@BILL_WEIGHT",  _ExpBILL.BILL_WEIGHT, 
					"@FEE_WEIGHT",  _ExpBILL.FEE_WEIGHT, 
					"@SEND_SITE_CODE",  _ExpBILL.SEND_SITE_CODE, 
					"@REGISTER_SITE_CODE",  _ExpBILL.REGISTER_SITE_CODE, 
					"@FREIGHT",  _ExpBILL.FREIGHT, 
					"@GOODS_PAYMENT",  _ExpBILL.GOODS_PAYMENT, 
					"@SEND_MAN",  _ExpBILL.SEND_MAN, 
					"@SEND_MAN_PHONE",  _ExpBILL.SEND_MAN_PHONE, 
					"@SEND_MAN_ADDRESS",  _ExpBILL.SEND_MAN_ADDRESS, 
					"@ACCEPT_MAN",  _ExpBILL.ACCEPT_MAN, 
					"@ACCEPT_MAN_PHONE",  _ExpBILL.ACCEPT_MAN_PHONE, 
					"@ACCEPT_MAN_ADDRESS",  _ExpBILL.ACCEPT_MAN_ADDRESS, 
					"@ACCEPT_PROVINCE_CODE",  _ExpBILL.ACCEPT_PROVINCE_CODE, 
					"@ACCEPT_CITY_CODE",  _ExpBILL.ACCEPT_CITY_CODE, 
					"@ACCEPT_COUNTY_CODE",  _ExpBILL.ACCEPT_COUNTY_CODE, 
					"@IS_SIGNED",  _ExpBILL.IS_SIGNED, 
					"@IS_RETURN",  _ExpBILL.IS_RETURN, 
					"@BILL_PROCESS_STATUS",  _ExpBILL.BILL_PROCESS_STATUS, 
					"@FK_Customer",  _ExpBILL.FK_Customer, 
					"@REGISTER_DATE", this._dataContext.ConvertDateString( _ExpBILL.REGISTER_DATE), 
					"@SIGNED_DATE", this._dataContext.ConvertDateString( _ExpBILL.SIGNED_DATE), 
					"@LAST_UPDATE_DATE", this._dataContext.ConvertDateString( _ExpBILL.LAST_UPDATE_DATE), 
					"@LAST_UPDATE_USER",  _ExpBILL.LAST_UPDATE_USER, 
					"@PAY_TYPE",  _ExpBILL.PAY_TYPE, 
					"@TTKT_WEIGHT",  _ExpBILL.TTKT_WEIGHT, 
					"@LAST_POST",  _ExpBILL.LAST_POST, 
					"@IS_VITURAL",  _ExpBILL.IS_VITURAL, 
					"@DES_SITE",  _ExpBILL.DES_SITE, 
					"@Note",  _ExpBILL.Note, 
					"@WORKING_PRIOTY",  _ExpBILL.WORKING_PRIOTY, 
					"@SYSTEM_DATE", this._dataContext.ConvertDateString( _ExpBILL.SYSTEM_DATE), 
					"@BT3Type",  _ExpBILL.BT3Type, 
					"@BT3Code",  _ExpBILL.BT3Code, 
					"@BT3Status",  _ExpBILL.BT3Status, 
					"@BT3LastMess",  _ExpBILL.BT3LastMess, 
					"@TenVatPham",  _ExpBILL.TenVatPham);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpBILL trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String BILL_CODE)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpBILL] WHERE BILL_CODE=@BILL_CODE",
					"@BILL_CODE", BILL_CODE);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpBILL trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpBILL _ExpBILL)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpBILL] WHERE BILL_CODE=@BILL_CODE",
					"@BILL_CODE", _ExpBILL.BILL_CODE);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpBILL trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpBILL] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpBILL trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpBILL> _ExpBILLs)
		{
			foreach (ExpBILL item in _ExpBILLs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
