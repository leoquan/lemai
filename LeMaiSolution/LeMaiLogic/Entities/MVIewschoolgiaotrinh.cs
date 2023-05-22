using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewschoolgiaotrinh:IVIewschoolgiaotrinh
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewschoolgiaotrinh(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_SchoolGiaoTrinh từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_SchoolGiaoTrinh]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_SchoolGiaoTrinh từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_SchoolGiaoTrinh] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_SchoolGiaoTrinh từ Database
		/// </summary>
		public List<view_SchoolGiaoTrinh> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_SchoolGiaoTrinh]");
				List<view_SchoolGiaoTrinh> items = new List<view_SchoolGiaoTrinh>();
				view_SchoolGiaoTrinh item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_SchoolGiaoTrinh();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["MaGiaoTrinh"] != null && dr["MaGiaoTrinh"] != DBNull.Value)
					{
						item.MaGiaoTrinh = Convert.ToString(dr["MaGiaoTrinh"]);
					}
					if (dr["TenGiaoTrinh"] != null && dr["TenGiaoTrinh"] != DBNull.Value)
					{
						item.TenGiaoTrinh = Convert.ToString(dr["TenGiaoTrinh"]);
					}
					if (dr["DonGia"] != null && dr["DonGia"] != DBNull.Value)
					{
						item.DonGia = Convert.ToInt32(dr["DonGia"]);
					}
					if (dr["GiaBan"] != null && dr["GiaBan"] != DBNull.Value)
					{
						item.GiaBan = Convert.ToInt32(dr["GiaBan"]);
					}
					if (dr["HoaHongPercent"] != null && dr["HoaHongPercent"] != DBNull.Value)
					{
						item.HoaHongPercent = Convert.ToInt32(dr["HoaHongPercent"]);
					}
					if (dr["FK_HocPhan"] != null && dr["FK_HocPhan"] != DBNull.Value)
					{
						item.FK_HocPhan = Convert.ToString(dr["FK_HocPhan"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["HocPhan"] != null && dr["HocPhan"] != DBNull.Value)
					{
						item.HocPhan = Convert.ToString(dr["HocPhan"]);
					}
					if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
					{
						item.FullName = Convert.ToString(dr["FullName"]);
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
		/// Lấy danh sách view_SchoolGiaoTrinh từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_SchoolGiaoTrinh> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_SchoolGiaoTrinh] A "+ condition,  parameters);
				List<view_SchoolGiaoTrinh> items = new List<view_SchoolGiaoTrinh>();
				view_SchoolGiaoTrinh item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_SchoolGiaoTrinh();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["MaGiaoTrinh"] != null && dr["MaGiaoTrinh"] != DBNull.Value)
					{
						item.MaGiaoTrinh = Convert.ToString(dr["MaGiaoTrinh"]);
					}
					if (dr["TenGiaoTrinh"] != null && dr["TenGiaoTrinh"] != DBNull.Value)
					{
						item.TenGiaoTrinh = Convert.ToString(dr["TenGiaoTrinh"]);
					}
					if (dr["DonGia"] != null && dr["DonGia"] != DBNull.Value)
					{
						item.DonGia = Convert.ToInt32(dr["DonGia"]);
					}
					if (dr["GiaBan"] != null && dr["GiaBan"] != DBNull.Value)
					{
						item.GiaBan = Convert.ToInt32(dr["GiaBan"]);
					}
					if (dr["HoaHongPercent"] != null && dr["HoaHongPercent"] != DBNull.Value)
					{
						item.HoaHongPercent = Convert.ToInt32(dr["HoaHongPercent"]);
					}
					if (dr["FK_HocPhan"] != null && dr["FK_HocPhan"] != DBNull.Value)
					{
						item.FK_HocPhan = Convert.ToString(dr["FK_HocPhan"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["HocPhan"] != null && dr["HocPhan"] != DBNull.Value)
					{
						item.HocPhan = Convert.ToString(dr["HocPhan"]);
					}
					if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
					{
						item.FullName = Convert.ToString(dr["FullName"]);
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

		public List<view_SchoolGiaoTrinh> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_SchoolGiaoTrinh] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_SchoolGiaoTrinh] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_SchoolGiaoTrinh>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_SchoolGiaoTrinh đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_SchoolGiaoTrinh GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_SchoolGiaoTrinh] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_SchoolGiaoTrinh item=new view_SchoolGiaoTrinh();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["MaGiaoTrinh"] != null && dr["MaGiaoTrinh"] != DBNull.Value)
						{
							item.MaGiaoTrinh = Convert.ToString(dr["MaGiaoTrinh"]);
						}
						if (dr["TenGiaoTrinh"] != null && dr["TenGiaoTrinh"] != DBNull.Value)
						{
							item.TenGiaoTrinh = Convert.ToString(dr["TenGiaoTrinh"]);
						}
						if (dr["DonGia"] != null && dr["DonGia"] != DBNull.Value)
						{
							item.DonGia = Convert.ToInt32(dr["DonGia"]);
						}
						if (dr["GiaBan"] != null && dr["GiaBan"] != DBNull.Value)
						{
							item.GiaBan = Convert.ToInt32(dr["GiaBan"]);
						}
						if (dr["HoaHongPercent"] != null && dr["HoaHongPercent"] != DBNull.Value)
						{
							item.HoaHongPercent = Convert.ToInt32(dr["HoaHongPercent"]);
						}
						if (dr["FK_HocPhan"] != null && dr["FK_HocPhan"] != DBNull.Value)
						{
							item.FK_HocPhan = Convert.ToString(dr["FK_HocPhan"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["HocPhan"] != null && dr["HocPhan"] != DBNull.Value)
						{
							item.HocPhan = Convert.ToString(dr["HocPhan"]);
						}
						if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
						{
							item.FullName = Convert.ToString(dr["FullName"]);
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

		public view_SchoolGiaoTrinh GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_SchoolGiaoTrinh] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_SchoolGiaoTrinh>(ds);
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
