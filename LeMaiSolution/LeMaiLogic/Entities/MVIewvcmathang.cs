using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewvcmathang:IVIewvcmathang
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewvcmathang(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_VCMatHang từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_VCMatHang]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_VCMatHang từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_VCMatHang] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_VCMatHang từ Database
		/// </summary>
		public List<view_VCMatHang> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_VCMatHang]");
				List<view_VCMatHang> items = new List<view_VCMatHang>();
				view_VCMatHang item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_VCMatHang();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["MaHang"] != null && dr["MaHang"] != DBNull.Value)
					{
						item.MaHang = Convert.ToString(dr["MaHang"]);
					}
					if (dr["TenHang"] != null && dr["TenHang"] != DBNull.Value)
					{
						item.TenHang = Convert.ToString(dr["TenHang"]);
					}
					if (dr["TenHangKD"] != null && dr["TenHangKD"] != DBNull.Value)
					{
						item.TenHangKD = Convert.ToString(dr["TenHangKD"]);
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
		/// Lấy danh sách view_VCMatHang từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_VCMatHang> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_VCMatHang] A "+ condition,  parameters);
				List<view_VCMatHang> items = new List<view_VCMatHang>();
				view_VCMatHang item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_VCMatHang();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["MaHang"] != null && dr["MaHang"] != DBNull.Value)
					{
						item.MaHang = Convert.ToString(dr["MaHang"]);
					}
					if (dr["TenHang"] != null && dr["TenHang"] != DBNull.Value)
					{
						item.TenHang = Convert.ToString(dr["TenHang"]);
					}
					if (dr["TenHangKD"] != null && dr["TenHangKD"] != DBNull.Value)
					{
						item.TenHangKD = Convert.ToString(dr["TenHangKD"]);
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

		public List<view_VCMatHang> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_VCMatHang] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_VCMatHang] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_VCMatHang>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_VCMatHang đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_VCMatHang GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_VCMatHang] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_VCMatHang item=new view_VCMatHang();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["MaHang"] != null && dr["MaHang"] != DBNull.Value)
						{
							item.MaHang = Convert.ToString(dr["MaHang"]);
						}
						if (dr["TenHang"] != null && dr["TenHang"] != DBNull.Value)
						{
							item.TenHang = Convert.ToString(dr["TenHang"]);
						}
						if (dr["TenHangKD"] != null && dr["TenHangKD"] != DBNull.Value)
						{
							item.TenHangKD = Convert.ToString(dr["TenHangKD"]);
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

		public view_VCMatHang GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_VCMatHang] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_VCMatHang>(ds);
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
