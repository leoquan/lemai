using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewvckhachhang:IVIewvckhachhang
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewvckhachhang(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_VCKhachHang từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_VCKhachHang]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_VCKhachHang từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_VCKhachHang] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_VCKhachHang từ Database
		/// </summary>
		public List<view_VCKhachHang> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_VCKhachHang]");
				List<view_VCKhachHang> items = new List<view_VCKhachHang>();
				view_VCKhachHang item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_VCKhachHang();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["MaKhachHang"] != null && dr["MaKhachHang"] != DBNull.Value)
					{
						item.MaKhachHang = Convert.ToString(dr["MaKhachHang"]);
					}
					if (dr["TenKhachHang"] != null && dr["TenKhachHang"] != DBNull.Value)
					{
						item.TenKhachHang = Convert.ToString(dr["TenKhachHang"]);
					}
					if (dr["TenKhachHangKD"] != null && dr["TenKhachHangKD"] != DBNull.Value)
					{
						item.TenKhachHangKD = Convert.ToString(dr["TenKhachHangKD"]);
					}
					if (dr["SoNo"] != null && dr["SoNo"] != DBNull.Value)
					{
						item.SoNo = Convert.ToDecimal(dr["SoNo"]);
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
		/// Lấy danh sách view_VCKhachHang từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_VCKhachHang> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_VCKhachHang] A "+ condition,  parameters);
				List<view_VCKhachHang> items = new List<view_VCKhachHang>();
				view_VCKhachHang item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_VCKhachHang();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["MaKhachHang"] != null && dr["MaKhachHang"] != DBNull.Value)
					{
						item.MaKhachHang = Convert.ToString(dr["MaKhachHang"]);
					}
					if (dr["TenKhachHang"] != null && dr["TenKhachHang"] != DBNull.Value)
					{
						item.TenKhachHang = Convert.ToString(dr["TenKhachHang"]);
					}
					if (dr["TenKhachHangKD"] != null && dr["TenKhachHangKD"] != DBNull.Value)
					{
						item.TenKhachHangKD = Convert.ToString(dr["TenKhachHangKD"]);
					}
					if (dr["SoNo"] != null && dr["SoNo"] != DBNull.Value)
					{
						item.SoNo = Convert.ToDecimal(dr["SoNo"]);
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

		public List<view_VCKhachHang> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_VCKhachHang] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_VCKhachHang] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_VCKhachHang>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_VCKhachHang đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_VCKhachHang GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_VCKhachHang] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_VCKhachHang item=new view_VCKhachHang();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["MaKhachHang"] != null && dr["MaKhachHang"] != DBNull.Value)
						{
							item.MaKhachHang = Convert.ToString(dr["MaKhachHang"]);
						}
						if (dr["TenKhachHang"] != null && dr["TenKhachHang"] != DBNull.Value)
						{
							item.TenKhachHang = Convert.ToString(dr["TenKhachHang"]);
						}
						if (dr["TenKhachHangKD"] != null && dr["TenKhachHangKD"] != DBNull.Value)
						{
							item.TenKhachHangKD = Convert.ToString(dr["TenKhachHangKD"]);
						}
						if (dr["SoNo"] != null && dr["SoNo"] != DBNull.Value)
						{
							item.SoNo = Convert.ToDecimal(dr["SoNo"]);
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

		public view_VCKhachHang GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_VCKhachHang] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_VCKhachHang>(ds);
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
