using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewschoolroom:IVIewschoolroom
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewschoolroom(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_SchoolRoom từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_SchoolRoom]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_SchoolRoom từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_SchoolRoom] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_SchoolRoom từ Database
		/// </summary>
		public List<view_SchoolRoom> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_SchoolRoom]");
				List<view_SchoolRoom> items = new List<view_SchoolRoom>();
				view_SchoolRoom item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_SchoolRoom();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenPhong"] != null && dr["TenPhong"] != DBNull.Value)
					{
						item.TenPhong = Convert.ToString(dr["TenPhong"]);
					}
					if (dr["FK_TrungTam"] != null && dr["FK_TrungTam"] != DBNull.Value)
					{
						item.FK_TrungTam = Convert.ToString(dr["FK_TrungTam"]);
					}
					if (dr["TrungTam"] != null && dr["TrungTam"] != DBNull.Value)
					{
						item.TrungTam = Convert.ToString(dr["TrungTam"]);
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
		/// Lấy danh sách view_SchoolRoom từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_SchoolRoom> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_SchoolRoom] A "+ condition,  parameters);
				List<view_SchoolRoom> items = new List<view_SchoolRoom>();
				view_SchoolRoom item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_SchoolRoom();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenPhong"] != null && dr["TenPhong"] != DBNull.Value)
					{
						item.TenPhong = Convert.ToString(dr["TenPhong"]);
					}
					if (dr["FK_TrungTam"] != null && dr["FK_TrungTam"] != DBNull.Value)
					{
						item.FK_TrungTam = Convert.ToString(dr["FK_TrungTam"]);
					}
					if (dr["TrungTam"] != null && dr["TrungTam"] != DBNull.Value)
					{
						item.TrungTam = Convert.ToString(dr["TrungTam"]);
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

		public List<view_SchoolRoom> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_SchoolRoom] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_SchoolRoom] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_SchoolRoom>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_SchoolRoom đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_SchoolRoom GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_SchoolRoom] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_SchoolRoom item=new view_SchoolRoom();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TenPhong"] != null && dr["TenPhong"] != DBNull.Value)
						{
							item.TenPhong = Convert.ToString(dr["TenPhong"]);
						}
						if (dr["FK_TrungTam"] != null && dr["FK_TrungTam"] != DBNull.Value)
						{
							item.FK_TrungTam = Convert.ToString(dr["FK_TrungTam"]);
						}
						if (dr["TrungTam"] != null && dr["TrungTam"] != DBNull.Value)
						{
							item.TrungTam = Convert.ToString(dr["TrungTam"]);
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

		public view_SchoolRoom GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_SchoolRoom] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_SchoolRoom>(ds);
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
