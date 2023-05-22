using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewgexpnotification:IVIewgexpnotification
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewgexpnotification(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_GExpNotification từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpNotification]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_GExpNotification từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpNotification] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_GExpNotification từ Database
		/// </summary>
		public List<view_GExpNotification> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpNotification]");
				List<view_GExpNotification> items = new List<view_GExpNotification>();
				view_GExpNotification item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GExpNotification();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["KeyDate"] != null && dr["KeyDate"] != DBNull.Value)
					{
						item.KeyDate = Convert.ToString(dr["KeyDate"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_AccountRead"] != null && dr["FK_AccountRead"] != DBNull.Value)
					{
						item.FK_AccountRead = Convert.ToString(dr["FK_AccountRead"]);
					}
					if (dr["DateRead"] != null && dr["DateRead"] != DBNull.Value)
					{
						item.DateRead = Convert.ToDateTime(dr["DateRead"]);
					}
					if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
					{
						item.BT3Code = Convert.ToString(dr["BT3Code"]);
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
					if (dr["BillWeight"] != null && dr["BillWeight"] != DBNull.Value)
					{
						item.BillWeight = Convert.ToDecimal(dr["BillWeight"]);
					}
					if (dr["FeeWeight"] != null && dr["FeeWeight"] != DBNull.Value)
					{
						item.FeeWeight = Convert.ToDecimal(dr["FeeWeight"]);
					}
					if (dr["Freight"] != null && dr["Freight"] != DBNull.Value)
					{
						item.Freight = Convert.ToDecimal(dr["Freight"]);
					}
					if (dr["PayType"] != null && dr["PayType"] != DBNull.Value)
					{
						item.PayType = Convert.ToString(dr["PayType"]);
					}
					if (dr["RegisterSiteCode"] != null && dr["RegisterSiteCode"] != DBNull.Value)
					{
						item.RegisterSiteCode = Convert.ToString(dr["RegisterSiteCode"]);
					}
					if (dr["FK_ProviderAccount"] != null && dr["FK_ProviderAccount"] != DBNull.Value)
					{
						item.FK_ProviderAccount = Convert.ToString(dr["FK_ProviderAccount"]);
					}
					if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
					{
						item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
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
		/// Lấy danh sách view_GExpNotification từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_GExpNotification> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GExpNotification] A "+ condition,  parameters);
				List<view_GExpNotification> items = new List<view_GExpNotification>();
				view_GExpNotification item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GExpNotification();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["KeyDate"] != null && dr["KeyDate"] != DBNull.Value)
					{
						item.KeyDate = Convert.ToString(dr["KeyDate"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_AccountRead"] != null && dr["FK_AccountRead"] != DBNull.Value)
					{
						item.FK_AccountRead = Convert.ToString(dr["FK_AccountRead"]);
					}
					if (dr["DateRead"] != null && dr["DateRead"] != DBNull.Value)
					{
						item.DateRead = Convert.ToDateTime(dr["DateRead"]);
					}
					if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
					{
						item.BT3Code = Convert.ToString(dr["BT3Code"]);
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
					if (dr["BillWeight"] != null && dr["BillWeight"] != DBNull.Value)
					{
						item.BillWeight = Convert.ToDecimal(dr["BillWeight"]);
					}
					if (dr["FeeWeight"] != null && dr["FeeWeight"] != DBNull.Value)
					{
						item.FeeWeight = Convert.ToDecimal(dr["FeeWeight"]);
					}
					if (dr["Freight"] != null && dr["Freight"] != DBNull.Value)
					{
						item.Freight = Convert.ToDecimal(dr["Freight"]);
					}
					if (dr["PayType"] != null && dr["PayType"] != DBNull.Value)
					{
						item.PayType = Convert.ToString(dr["PayType"]);
					}
					if (dr["RegisterSiteCode"] != null && dr["RegisterSiteCode"] != DBNull.Value)
					{
						item.RegisterSiteCode = Convert.ToString(dr["RegisterSiteCode"]);
					}
					if (dr["FK_ProviderAccount"] != null && dr["FK_ProviderAccount"] != DBNull.Value)
					{
						item.FK_ProviderAccount = Convert.ToString(dr["FK_ProviderAccount"]);
					}
					if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
					{
						item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
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

		public List<view_GExpNotification> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GExpNotification] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_GExpNotification] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_GExpNotification>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_GExpNotification đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_GExpNotification GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GExpNotification] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_GExpNotification item=new view_GExpNotification();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["KeyDate"] != null && dr["KeyDate"] != DBNull.Value)
						{
							item.KeyDate = Convert.ToString(dr["KeyDate"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["FK_AccountRead"] != null && dr["FK_AccountRead"] != DBNull.Value)
						{
							item.FK_AccountRead = Convert.ToString(dr["FK_AccountRead"]);
						}
						if (dr["DateRead"] != null && dr["DateRead"] != DBNull.Value)
						{
							item.DateRead = Convert.ToDateTime(dr["DateRead"]);
						}
						if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
						{
							item.BT3Code = Convert.ToString(dr["BT3Code"]);
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
						if (dr["BillWeight"] != null && dr["BillWeight"] != DBNull.Value)
						{
							item.BillWeight = Convert.ToDecimal(dr["BillWeight"]);
						}
						if (dr["FeeWeight"] != null && dr["FeeWeight"] != DBNull.Value)
						{
							item.FeeWeight = Convert.ToDecimal(dr["FeeWeight"]);
						}
						if (dr["Freight"] != null && dr["Freight"] != DBNull.Value)
						{
							item.Freight = Convert.ToDecimal(dr["Freight"]);
						}
						if (dr["PayType"] != null && dr["PayType"] != DBNull.Value)
						{
							item.PayType = Convert.ToString(dr["PayType"]);
						}
						if (dr["RegisterSiteCode"] != null && dr["RegisterSiteCode"] != DBNull.Value)
						{
							item.RegisterSiteCode = Convert.ToString(dr["RegisterSiteCode"]);
						}
						if (dr["FK_ProviderAccount"] != null && dr["FK_ProviderAccount"] != DBNull.Value)
						{
							item.FK_ProviderAccount = Convert.ToString(dr["FK_ProviderAccount"]);
						}
						if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
						{
							item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
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

		public view_GExpNotification GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GExpNotification] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_GExpNotification>(ds);
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
