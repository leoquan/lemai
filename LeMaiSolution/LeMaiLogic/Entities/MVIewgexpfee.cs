using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewgexpfee:IVIewgexpfee
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewgexpfee(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_GExpFee từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpFee]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_GExpFee từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpFee] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_GExpFee từ Database
		/// </summary>
		public List<view_GExpFee> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpFee]");
				List<view_GExpFee> items = new List<view_GExpFee>();
				view_GExpFee item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GExpFee();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["FeeName"] != null && dr["FeeName"] != DBNull.Value)
					{
						item.FeeName = Convert.ToString(dr["FeeName"]);
					}
					if (dr["DefaultFee"] != null && dr["DefaultFee"] != DBNull.Value)
					{
						item.DefaultFee = Convert.ToBoolean(dr["DefaultFee"]);
					}
					if (dr["TenDaiLy"] != null && dr["TenDaiLy"] != DBNull.Value)
					{
						item.TenDaiLy = Convert.ToString(dr["TenDaiLy"]);
					}
					if (dr["ZoneCode"] != null && dr["ZoneCode"] != DBNull.Value)
					{
						item.ZoneCode = Convert.ToString(dr["ZoneCode"]);
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
		/// Lấy danh sách view_GExpFee từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_GExpFee> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GExpFee] A "+ condition,  parameters);
				List<view_GExpFee> items = new List<view_GExpFee>();
				view_GExpFee item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GExpFee();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["FeeName"] != null && dr["FeeName"] != DBNull.Value)
					{
						item.FeeName = Convert.ToString(dr["FeeName"]);
					}
					if (dr["DefaultFee"] != null && dr["DefaultFee"] != DBNull.Value)
					{
						item.DefaultFee = Convert.ToBoolean(dr["DefaultFee"]);
					}
					if (dr["TenDaiLy"] != null && dr["TenDaiLy"] != DBNull.Value)
					{
						item.TenDaiLy = Convert.ToString(dr["TenDaiLy"]);
					}
					if (dr["ZoneCode"] != null && dr["ZoneCode"] != DBNull.Value)
					{
						item.ZoneCode = Convert.ToString(dr["ZoneCode"]);
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

		public List<view_GExpFee> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GExpFee] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_GExpFee] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_GExpFee>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_GExpFee đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_GExpFee GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GExpFee] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_GExpFee item=new view_GExpFee();
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
						if (dr["FeeName"] != null && dr["FeeName"] != DBNull.Value)
						{
							item.FeeName = Convert.ToString(dr["FeeName"]);
						}
						if (dr["DefaultFee"] != null && dr["DefaultFee"] != DBNull.Value)
						{
							item.DefaultFee = Convert.ToBoolean(dr["DefaultFee"]);
						}
						if (dr["TenDaiLy"] != null && dr["TenDaiLy"] != DBNull.Value)
						{
							item.TenDaiLy = Convert.ToString(dr["TenDaiLy"]);
						}
						if (dr["ZoneCode"] != null && dr["ZoneCode"] != DBNull.Value)
						{
							item.ZoneCode = Convert.ToString(dr["ZoneCode"]);
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

		public view_GExpFee GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GExpFee] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_GExpFee>(ds);
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
