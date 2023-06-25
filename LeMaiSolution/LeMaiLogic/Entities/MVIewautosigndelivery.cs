using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewautosigndelivery:IVIewautosigndelivery
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewautosigndelivery(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_AutoSignDelivery từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_AutoSignDelivery]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_AutoSignDelivery từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_AutoSignDelivery] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_AutoSignDelivery từ Database
		/// </summary>
		public List<view_AutoSignDelivery> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_AutoSignDelivery]");
				List<view_AutoSignDelivery> items = new List<view_AutoSignDelivery>();
				view_AutoSignDelivery item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_AutoSignDelivery();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["ShipperId"] != null && dr["ShipperId"] != DBNull.Value)
					{
						item.ShipperId = Convert.ToString(dr["ShipperId"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["SignDate"] != null && dr["SignDate"] != DBNull.Value)
					{
						item.SignDate = Convert.ToDateTime(dr["SignDate"]);
					}
					if (dr["TotalCOD"] != null && dr["TotalCOD"] != DBNull.Value)
					{
						item.TotalCOD = Convert.ToDecimal(dr["TotalCOD"]);
					}
					if (dr["IsCash"] != null && dr["IsCash"] != DBNull.Value)
					{
						item.IsCash = Convert.ToBoolean(dr["IsCash"]);
					}
					if (dr["CashTime"] != null && dr["CashTime"] != DBNull.Value)
					{
						item.CashTime = Convert.ToDateTime(dr["CashTime"]);
					}
					if (dr["FK_AccountCash"] != null && dr["FK_AccountCash"] != DBNull.Value)
					{
						item.FK_AccountCash = Convert.ToString(dr["FK_AccountCash"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["FK_CashId"] != null && dr["FK_CashId"] != DBNull.Value)
					{
						item.FK_CashId = Convert.ToString(dr["FK_CashId"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["MinuteSign"] != null && dr["MinuteSign"] != DBNull.Value)
					{
						item.MinuteSign = Convert.ToInt32(dr["MinuteSign"]);
					}
					if (dr["ShipperName"] != null && dr["ShipperName"] != DBNull.Value)
					{
						item.ShipperName = Convert.ToString(dr["ShipperName"]);
					}
					if (dr["ShipperPhone"] != null && dr["ShipperPhone"] != DBNull.Value)
					{
						item.ShipperPhone = Convert.ToString(dr["ShipperPhone"]);
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
		/// Lấy danh sách view_AutoSignDelivery từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_AutoSignDelivery> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_AutoSignDelivery] A "+ condition,  parameters);
				List<view_AutoSignDelivery> items = new List<view_AutoSignDelivery>();
				view_AutoSignDelivery item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_AutoSignDelivery();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["ShipperId"] != null && dr["ShipperId"] != DBNull.Value)
					{
						item.ShipperId = Convert.ToString(dr["ShipperId"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["SignDate"] != null && dr["SignDate"] != DBNull.Value)
					{
						item.SignDate = Convert.ToDateTime(dr["SignDate"]);
					}
					if (dr["TotalCOD"] != null && dr["TotalCOD"] != DBNull.Value)
					{
						item.TotalCOD = Convert.ToDecimal(dr["TotalCOD"]);
					}
					if (dr["IsCash"] != null && dr["IsCash"] != DBNull.Value)
					{
						item.IsCash = Convert.ToBoolean(dr["IsCash"]);
					}
					if (dr["CashTime"] != null && dr["CashTime"] != DBNull.Value)
					{
						item.CashTime = Convert.ToDateTime(dr["CashTime"]);
					}
					if (dr["FK_AccountCash"] != null && dr["FK_AccountCash"] != DBNull.Value)
					{
						item.FK_AccountCash = Convert.ToString(dr["FK_AccountCash"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["FK_CashId"] != null && dr["FK_CashId"] != DBNull.Value)
					{
						item.FK_CashId = Convert.ToString(dr["FK_CashId"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["MinuteSign"] != null && dr["MinuteSign"] != DBNull.Value)
					{
						item.MinuteSign = Convert.ToInt32(dr["MinuteSign"]);
					}
					if (dr["ShipperName"] != null && dr["ShipperName"] != DBNull.Value)
					{
						item.ShipperName = Convert.ToString(dr["ShipperName"]);
					}
					if (dr["ShipperPhone"] != null && dr["ShipperPhone"] != DBNull.Value)
					{
						item.ShipperPhone = Convert.ToString(dr["ShipperPhone"]);
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

		public List<view_AutoSignDelivery> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_AutoSignDelivery] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_AutoSignDelivery] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_AutoSignDelivery>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_AutoSignDelivery đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_AutoSignDelivery GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_AutoSignDelivery] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_AutoSignDelivery item=new view_AutoSignDelivery();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["ShipperId"] != null && dr["ShipperId"] != DBNull.Value)
						{
							item.ShipperId = Convert.ToString(dr["ShipperId"]);
						}
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["SignDate"] != null && dr["SignDate"] != DBNull.Value)
						{
							item.SignDate = Convert.ToDateTime(dr["SignDate"]);
						}
						if (dr["TotalCOD"] != null && dr["TotalCOD"] != DBNull.Value)
						{
							item.TotalCOD = Convert.ToDecimal(dr["TotalCOD"]);
						}
						if (dr["IsCash"] != null && dr["IsCash"] != DBNull.Value)
						{
							item.IsCash = Convert.ToBoolean(dr["IsCash"]);
						}
						if (dr["CashTime"] != null && dr["CashTime"] != DBNull.Value)
						{
							item.CashTime = Convert.ToDateTime(dr["CashTime"]);
						}
						if (dr["FK_AccountCash"] != null && dr["FK_AccountCash"] != DBNull.Value)
						{
							item.FK_AccountCash = Convert.ToString(dr["FK_AccountCash"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["FK_CashId"] != null && dr["FK_CashId"] != DBNull.Value)
						{
							item.FK_CashId = Convert.ToString(dr["FK_CashId"]);
						}
						if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
						{
							item.FK_Post = Convert.ToString(dr["FK_Post"]);
						}
						if (dr["MinuteSign"] != null && dr["MinuteSign"] != DBNull.Value)
						{
							item.MinuteSign = Convert.ToInt32(dr["MinuteSign"]);
						}
						if (dr["ShipperName"] != null && dr["ShipperName"] != DBNull.Value)
						{
							item.ShipperName = Convert.ToString(dr["ShipperName"]);
						}
						if (dr["ShipperPhone"] != null && dr["ShipperPhone"] != DBNull.Value)
						{
							item.ShipperPhone = Convert.ToString(dr["ShipperPhone"]);
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

		public view_AutoSignDelivery GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_AutoSignDelivery] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_AutoSignDelivery>(ds);
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
