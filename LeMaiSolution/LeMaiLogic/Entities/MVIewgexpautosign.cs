using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewgexpautosign:IVIewgexpautosign
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewgexpautosign(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_GExpAutoSign từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpAutoSign]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_GExpAutoSign từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpAutoSign] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_GExpAutoSign từ Database
		/// </summary>
		public List<view_GExpAutoSign> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpAutoSign]");
				List<view_GExpAutoSign> items = new List<view_GExpAutoSign>();
				view_GExpAutoSign item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GExpAutoSign();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["FK_Shipper"] != null && dr["FK_Shipper"] != DBNull.Value)
					{
						item.FK_Shipper = Convert.ToString(dr["FK_Shipper"]);
					}
					if (dr["MinuteSign"] != null && dr["MinuteSign"] != DBNull.Value)
					{
						item.MinuteSign = Convert.ToInt32(dr["MinuteSign"]);
					}
					if (dr["ActiveFrom"] != null && dr["ActiveFrom"] != DBNull.Value)
					{
						item.ActiveFrom = Convert.ToDateTime(dr["ActiveFrom"]);
					}
					if (dr["TenDaiLy"] != null && dr["TenDaiLy"] != DBNull.Value)
					{
						item.TenDaiLy = Convert.ToString(dr["TenDaiLy"]);
					}
					if (dr["ShipperName"] != null && dr["ShipperName"] != DBNull.Value)
					{
						item.ShipperName = Convert.ToString(dr["ShipperName"]);
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
		/// Lấy danh sách view_GExpAutoSign từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_GExpAutoSign> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GExpAutoSign] A "+ condition,  parameters);
				List<view_GExpAutoSign> items = new List<view_GExpAutoSign>();
				view_GExpAutoSign item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GExpAutoSign();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["FK_Shipper"] != null && dr["FK_Shipper"] != DBNull.Value)
					{
						item.FK_Shipper = Convert.ToString(dr["FK_Shipper"]);
					}
					if (dr["MinuteSign"] != null && dr["MinuteSign"] != DBNull.Value)
					{
						item.MinuteSign = Convert.ToInt32(dr["MinuteSign"]);
					}
					if (dr["ActiveFrom"] != null && dr["ActiveFrom"] != DBNull.Value)
					{
						item.ActiveFrom = Convert.ToDateTime(dr["ActiveFrom"]);
					}
					if (dr["TenDaiLy"] != null && dr["TenDaiLy"] != DBNull.Value)
					{
						item.TenDaiLy = Convert.ToString(dr["TenDaiLy"]);
					}
					if (dr["ShipperName"] != null && dr["ShipperName"] != DBNull.Value)
					{
						item.ShipperName = Convert.ToString(dr["ShipperName"]);
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

		public List<view_GExpAutoSign> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GExpAutoSign] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_GExpAutoSign] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_GExpAutoSign>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_GExpAutoSign đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_GExpAutoSign GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GExpAutoSign] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_GExpAutoSign item=new view_GExpAutoSign();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
						{
							item.FK_Post = Convert.ToString(dr["FK_Post"]);
						}
						if (dr["FK_Shipper"] != null && dr["FK_Shipper"] != DBNull.Value)
						{
							item.FK_Shipper = Convert.ToString(dr["FK_Shipper"]);
						}
						if (dr["MinuteSign"] != null && dr["MinuteSign"] != DBNull.Value)
						{
							item.MinuteSign = Convert.ToInt32(dr["MinuteSign"]);
						}
						if (dr["ActiveFrom"] != null && dr["ActiveFrom"] != DBNull.Value)
						{
							item.ActiveFrom = Convert.ToDateTime(dr["ActiveFrom"]);
						}
						if (dr["TenDaiLy"] != null && dr["TenDaiLy"] != DBNull.Value)
						{
							item.TenDaiLy = Convert.ToString(dr["TenDaiLy"]);
						}
						if (dr["ShipperName"] != null && dr["ShipperName"] != DBNull.Value)
						{
							item.ShipperName = Convert.ToString(dr["ShipperName"]);
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

		public view_GExpAutoSign GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GExpAutoSign] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_GExpAutoSign>(ds);
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
