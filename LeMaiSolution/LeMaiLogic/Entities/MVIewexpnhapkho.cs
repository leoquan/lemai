using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewexpnhapkho:IVIewexpnhapkho
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewexpnhapkho(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_ExpNhapKho từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpNhapKho]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_ExpNhapKho từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpNhapKho] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_ExpNhapKho từ Database
		/// </summary>
		public List<view_ExpNhapKho> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpNhapKho]");
				List<view_ExpNhapKho> items = new List<view_ExpNhapKho>();
				view_ExpNhapKho item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpNhapKho();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["NgayNhapKho"] != null && dr["NgayNhapKho"] != DBNull.Value)
					{
						item.NgayNhapKho = Convert.ToDateTime(dr["NgayNhapKho"]);
					}
					if (dr["FK_NguoiNhapKho"] != null && dr["FK_NguoiNhapKho"] != DBNull.Value)
					{
						item.FK_NguoiNhapKho = Convert.ToString(dr["FK_NguoiNhapKho"]);
					}
					if (dr["FK_SanPham"] != null && dr["FK_SanPham"] != DBNull.Value)
					{
						item.FK_SanPham = Convert.ToString(dr["FK_SanPham"]);
					}
					if (dr["SoLuong"] != null && dr["SoLuong"] != DBNull.Value)
					{
						item.SoLuong = Convert.ToDecimal(dr["SoLuong"]);
					}
					if (dr["DonGia"] != null && dr["DonGia"] != DBNull.Value)
					{
						item.DonGia = Convert.ToDecimal(dr["DonGia"]);
					}
					if (dr["ThanhTien"] != null && dr["ThanhTien"] != DBNull.Value)
					{
						item.ThanhTien = Convert.ToDecimal(dr["ThanhTien"]);
					}
					if (dr["GhiChu"] != null && dr["GhiChu"] != DBNull.Value)
					{
						item.GhiChu = Convert.ToString(dr["GhiChu"]);
					}
					if (dr["TenSanPham"] != null && dr["TenSanPham"] != DBNull.Value)
					{
						item.TenSanPham = Convert.ToString(dr["TenSanPham"]);
					}
					if (dr["DonViTinh"] != null && dr["DonViTinh"] != DBNull.Value)
					{
						item.DonViTinh = Convert.ToString(dr["DonViTinh"]);
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
		/// Lấy danh sách view_ExpNhapKho từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_ExpNhapKho> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpNhapKho] A "+ condition,  parameters);
				List<view_ExpNhapKho> items = new List<view_ExpNhapKho>();
				view_ExpNhapKho item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpNhapKho();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["NgayNhapKho"] != null && dr["NgayNhapKho"] != DBNull.Value)
					{
						item.NgayNhapKho = Convert.ToDateTime(dr["NgayNhapKho"]);
					}
					if (dr["FK_NguoiNhapKho"] != null && dr["FK_NguoiNhapKho"] != DBNull.Value)
					{
						item.FK_NguoiNhapKho = Convert.ToString(dr["FK_NguoiNhapKho"]);
					}
					if (dr["FK_SanPham"] != null && dr["FK_SanPham"] != DBNull.Value)
					{
						item.FK_SanPham = Convert.ToString(dr["FK_SanPham"]);
					}
					if (dr["SoLuong"] != null && dr["SoLuong"] != DBNull.Value)
					{
						item.SoLuong = Convert.ToDecimal(dr["SoLuong"]);
					}
					if (dr["DonGia"] != null && dr["DonGia"] != DBNull.Value)
					{
						item.DonGia = Convert.ToDecimal(dr["DonGia"]);
					}
					if (dr["ThanhTien"] != null && dr["ThanhTien"] != DBNull.Value)
					{
						item.ThanhTien = Convert.ToDecimal(dr["ThanhTien"]);
					}
					if (dr["GhiChu"] != null && dr["GhiChu"] != DBNull.Value)
					{
						item.GhiChu = Convert.ToString(dr["GhiChu"]);
					}
					if (dr["TenSanPham"] != null && dr["TenSanPham"] != DBNull.Value)
					{
						item.TenSanPham = Convert.ToString(dr["TenSanPham"]);
					}
					if (dr["DonViTinh"] != null && dr["DonViTinh"] != DBNull.Value)
					{
						item.DonViTinh = Convert.ToString(dr["DonViTinh"]);
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

		public List<view_ExpNhapKho> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpNhapKho] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_ExpNhapKho] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_ExpNhapKho>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_ExpNhapKho đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_ExpNhapKho GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpNhapKho] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_ExpNhapKho item=new view_ExpNhapKho();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["NgayNhapKho"] != null && dr["NgayNhapKho"] != DBNull.Value)
						{
							item.NgayNhapKho = Convert.ToDateTime(dr["NgayNhapKho"]);
						}
						if (dr["FK_NguoiNhapKho"] != null && dr["FK_NguoiNhapKho"] != DBNull.Value)
						{
							item.FK_NguoiNhapKho = Convert.ToString(dr["FK_NguoiNhapKho"]);
						}
						if (dr["FK_SanPham"] != null && dr["FK_SanPham"] != DBNull.Value)
						{
							item.FK_SanPham = Convert.ToString(dr["FK_SanPham"]);
						}
						if (dr["SoLuong"] != null && dr["SoLuong"] != DBNull.Value)
						{
							item.SoLuong = Convert.ToDecimal(dr["SoLuong"]);
						}
						if (dr["DonGia"] != null && dr["DonGia"] != DBNull.Value)
						{
							item.DonGia = Convert.ToDecimal(dr["DonGia"]);
						}
						if (dr["ThanhTien"] != null && dr["ThanhTien"] != DBNull.Value)
						{
							item.ThanhTien = Convert.ToDecimal(dr["ThanhTien"]);
						}
						if (dr["GhiChu"] != null && dr["GhiChu"] != DBNull.Value)
						{
							item.GhiChu = Convert.ToString(dr["GhiChu"]);
						}
						if (dr["TenSanPham"] != null && dr["TenSanPham"] != DBNull.Value)
						{
							item.TenSanPham = Convert.ToString(dr["TenSanPham"]);
						}
						if (dr["DonViTinh"] != null && dr["DonViTinh"] != DBNull.Value)
						{
							item.DonViTinh = Convert.ToString(dr["DonViTinh"]);
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

		public view_ExpNhapKho GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpNhapKho] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_ExpNhapKho>(ds);
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
