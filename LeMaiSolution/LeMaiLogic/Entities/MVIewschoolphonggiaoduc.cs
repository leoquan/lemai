using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewschoolphonggiaoduc:IVIewschoolphonggiaoduc
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewschoolphonggiaoduc(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_SchoolPhongGiaoDuc từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_SchoolPhongGiaoDuc]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_SchoolPhongGiaoDuc từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_SchoolPhongGiaoDuc] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_SchoolPhongGiaoDuc từ Database
		/// </summary>
		public List<view_SchoolPhongGiaoDuc> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_SchoolPhongGiaoDuc]");
				List<view_SchoolPhongGiaoDuc> items = new List<view_SchoolPhongGiaoDuc>();
				view_SchoolPhongGiaoDuc item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_SchoolPhongGiaoDuc();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenPhong"] != null && dr["TenPhong"] != DBNull.Value)
					{
						item.TenPhong = Convert.ToString(dr["TenPhong"]);
					}
					if (dr["EnglishName"] != null && dr["EnglishName"] != DBNull.Value)
					{
						item.EnglishName = Convert.ToString(dr["EnglishName"]);
					}
					if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
					{
						item.Phone = Convert.ToString(dr["Phone"]);
					}
					if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
					{
						item.DiaChi = Convert.ToString(dr["DiaChi"]);
					}
					if (dr["Email"] != null && dr["Email"] != DBNull.Value)
					{
						item.Email = Convert.ToString(dr["Email"]);
					}
					if (dr["TruongPhong"] != null && dr["TruongPhong"] != DBNull.Value)
					{
						item.TruongPhong = Convert.ToString(dr["TruongPhong"]);
					}
					if (dr["DauMoiLienHe"] != null && dr["DauMoiLienHe"] != DBNull.Value)
					{
						item.DauMoiLienHe = Convert.ToString(dr["DauMoiLienHe"]);
					}
					if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
					{
						item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
					}
					if (dr["FK_NhanVien"] != null && dr["FK_NhanVien"] != DBNull.Value)
					{
						item.FK_NhanVien = Convert.ToString(dr["FK_NhanVien"]);
					}
					if (dr["FK_SoGiaoDuc"] != null && dr["FK_SoGiaoDuc"] != DBNull.Value)
					{
						item.FK_SoGiaoDuc = Convert.ToString(dr["FK_SoGiaoDuc"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["GoogleMap"] != null && dr["GoogleMap"] != DBNull.Value)
					{
						item.GoogleMap = Convert.ToString(dr["GoogleMap"]);
					}
					if (dr["TenSo"] != null && dr["TenSo"] != DBNull.Value)
					{
						item.TenSo = Convert.ToString(dr["TenSo"]);
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
		/// Lấy danh sách view_SchoolPhongGiaoDuc từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_SchoolPhongGiaoDuc> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_SchoolPhongGiaoDuc] A "+ condition,  parameters);
				List<view_SchoolPhongGiaoDuc> items = new List<view_SchoolPhongGiaoDuc>();
				view_SchoolPhongGiaoDuc item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_SchoolPhongGiaoDuc();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenPhong"] != null && dr["TenPhong"] != DBNull.Value)
					{
						item.TenPhong = Convert.ToString(dr["TenPhong"]);
					}
					if (dr["EnglishName"] != null && dr["EnglishName"] != DBNull.Value)
					{
						item.EnglishName = Convert.ToString(dr["EnglishName"]);
					}
					if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
					{
						item.Phone = Convert.ToString(dr["Phone"]);
					}
					if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
					{
						item.DiaChi = Convert.ToString(dr["DiaChi"]);
					}
					if (dr["Email"] != null && dr["Email"] != DBNull.Value)
					{
						item.Email = Convert.ToString(dr["Email"]);
					}
					if (dr["TruongPhong"] != null && dr["TruongPhong"] != DBNull.Value)
					{
						item.TruongPhong = Convert.ToString(dr["TruongPhong"]);
					}
					if (dr["DauMoiLienHe"] != null && dr["DauMoiLienHe"] != DBNull.Value)
					{
						item.DauMoiLienHe = Convert.ToString(dr["DauMoiLienHe"]);
					}
					if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
					{
						item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
					}
					if (dr["FK_NhanVien"] != null && dr["FK_NhanVien"] != DBNull.Value)
					{
						item.FK_NhanVien = Convert.ToString(dr["FK_NhanVien"]);
					}
					if (dr["FK_SoGiaoDuc"] != null && dr["FK_SoGiaoDuc"] != DBNull.Value)
					{
						item.FK_SoGiaoDuc = Convert.ToString(dr["FK_SoGiaoDuc"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["GoogleMap"] != null && dr["GoogleMap"] != DBNull.Value)
					{
						item.GoogleMap = Convert.ToString(dr["GoogleMap"]);
					}
					if (dr["TenSo"] != null && dr["TenSo"] != DBNull.Value)
					{
						item.TenSo = Convert.ToString(dr["TenSo"]);
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

		public List<view_SchoolPhongGiaoDuc> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_SchoolPhongGiaoDuc] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_SchoolPhongGiaoDuc] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_SchoolPhongGiaoDuc>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_SchoolPhongGiaoDuc đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_SchoolPhongGiaoDuc GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_SchoolPhongGiaoDuc] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_SchoolPhongGiaoDuc item=new view_SchoolPhongGiaoDuc();
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
						if (dr["EnglishName"] != null && dr["EnglishName"] != DBNull.Value)
						{
							item.EnglishName = Convert.ToString(dr["EnglishName"]);
						}
						if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
						{
							item.Phone = Convert.ToString(dr["Phone"]);
						}
						if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
						{
							item.DiaChi = Convert.ToString(dr["DiaChi"]);
						}
						if (dr["Email"] != null && dr["Email"] != DBNull.Value)
						{
							item.Email = Convert.ToString(dr["Email"]);
						}
						if (dr["TruongPhong"] != null && dr["TruongPhong"] != DBNull.Value)
						{
							item.TruongPhong = Convert.ToString(dr["TruongPhong"]);
						}
						if (dr["DauMoiLienHe"] != null && dr["DauMoiLienHe"] != DBNull.Value)
						{
							item.DauMoiLienHe = Convert.ToString(dr["DauMoiLienHe"]);
						}
						if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
						{
							item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
						}
						if (dr["FK_NhanVien"] != null && dr["FK_NhanVien"] != DBNull.Value)
						{
							item.FK_NhanVien = Convert.ToString(dr["FK_NhanVien"]);
						}
						if (dr["FK_SoGiaoDuc"] != null && dr["FK_SoGiaoDuc"] != DBNull.Value)
						{
							item.FK_SoGiaoDuc = Convert.ToString(dr["FK_SoGiaoDuc"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["GoogleMap"] != null && dr["GoogleMap"] != DBNull.Value)
						{
							item.GoogleMap = Convert.ToString(dr["GoogleMap"]);
						}
						if (dr["TenSo"] != null && dr["TenSo"] != DBNull.Value)
						{
							item.TenSo = Convert.ToString(dr["TenSo"]);
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

		public view_SchoolPhongGiaoDuc GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_SchoolPhongGiaoDuc] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_SchoolPhongGiaoDuc>(ds);
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
