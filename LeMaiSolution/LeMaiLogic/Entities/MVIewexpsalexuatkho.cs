using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewexpsalexuatkho:IVIewexpsalexuatkho
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewexpsalexuatkho(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_ExpSaleXuatKho từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpSaleXuatKho]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_ExpSaleXuatKho từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpSaleXuatKho] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_ExpSaleXuatKho từ Database
		/// </summary>
		public List<view_ExpSaleXuatKho> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpSaleXuatKho]");
				List<view_ExpSaleXuatKho> items = new List<view_ExpSaleXuatKho>();
				view_ExpSaleXuatKho item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpSaleXuatKho();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Product"] != null && dr["FK_Product"] != DBNull.Value)
					{
						item.FK_Product = Convert.ToString(dr["FK_Product"]);
					}
					if (dr["FK_KhachHang"] != null && dr["FK_KhachHang"] != DBNull.Value)
					{
						item.FK_KhachHang = Convert.ToString(dr["FK_KhachHang"]);
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
					if (dr["IsThanhToan"] != null && dr["IsThanhToan"] != DBNull.Value)
					{
						item.IsThanhToan = Convert.ToBoolean(dr["IsThanhToan"]);
					}
					if (dr["FK_LoaiThanhToan"] != null && dr["FK_LoaiThanhToan"] != DBNull.Value)
					{
						item.FK_LoaiThanhToan = Convert.ToString(dr["FK_LoaiThanhToan"]);
					}
					if (dr["NgayThanhToan"] != null && dr["NgayThanhToan"] != DBNull.Value)
					{
						item.NgayThanhToan = Convert.ToDateTime(dr["NgayThanhToan"]);
					}
					if (dr["NgayXuat"] != null && dr["NgayXuat"] != DBNull.Value)
					{
						item.NgayXuat = Convert.ToDateTime(dr["NgayXuat"]);
					}
					if (dr["FK_NguoiXuat"] != null && dr["FK_NguoiXuat"] != DBNull.Value)
					{
						item.FK_NguoiXuat = Convert.ToString(dr["FK_NguoiXuat"]);
					}
					if (dr["TenLoai"] != null && dr["TenLoai"] != DBNull.Value)
					{
						item.TenLoai = Convert.ToString(dr["TenLoai"]);
					}
					if (dr["TenSanPham"] != null && dr["TenSanPham"] != DBNull.Value)
					{
						item.TenSanPham = Convert.ToString(dr["TenSanPham"]);
					}
					if (dr["DonViTinh"] != null && dr["DonViTinh"] != DBNull.Value)
					{
						item.DonViTinh = Convert.ToString(dr["DonViTinh"]);
					}
					if (dr["GiaLe"] != null && dr["GiaLe"] != DBNull.Value)
					{
						item.GiaLe = Convert.ToInt32(dr["GiaLe"]);
					}
					if (dr["GiaSi"] != null && dr["GiaSi"] != DBNull.Value)
					{
						item.GiaSi = Convert.ToInt32(dr["GiaSi"]);
					}
					if (dr["SoLuongGiaSi"] != null && dr["SoLuongGiaSi"] != DBNull.Value)
					{
						item.SoLuongGiaSi = Convert.ToInt32(dr["SoLuongGiaSi"]);
					}
					if (dr["SoLuongTon"] != null && dr["SoLuongTon"] != DBNull.Value)
					{
						item.SoLuongTon = Convert.ToDecimal(dr["SoLuongTon"]);
					}
					if (dr["CustomerName"] != null && dr["CustomerName"] != DBNull.Value)
					{
						item.CustomerName = Convert.ToString(dr["CustomerName"]);
					}
					if (dr["CustomerPhone"] != null && dr["CustomerPhone"] != DBNull.Value)
					{
						item.CustomerPhone = Convert.ToString(dr["CustomerPhone"]);
					}
					if (dr["CustomerCode"] != null && dr["CustomerCode"] != DBNull.Value)
					{
						item.CustomerCode = Convert.ToString(dr["CustomerCode"]);
					}
					if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
					{
						item.FullName = Convert.ToString(dr["FullName"]);
					}
					if (dr["STHANHTOAN"] != null && dr["STHANHTOAN"] != DBNull.Value)
					{
						item.STHANHTOAN = Convert.ToString(dr["STHANHTOAN"]);
					}
					if (dr["SNGAYTHANHTOAN"] != null && dr["SNGAYTHANHTOAN"] != DBNull.Value)
					{
						item.SNGAYTHANHTOAN = Convert.ToString(dr["SNGAYTHANHTOAN"]);
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
		/// Lấy danh sách view_ExpSaleXuatKho từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_ExpSaleXuatKho> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpSaleXuatKho] A "+ condition,  parameters);
				List<view_ExpSaleXuatKho> items = new List<view_ExpSaleXuatKho>();
				view_ExpSaleXuatKho item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpSaleXuatKho();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Product"] != null && dr["FK_Product"] != DBNull.Value)
					{
						item.FK_Product = Convert.ToString(dr["FK_Product"]);
					}
					if (dr["FK_KhachHang"] != null && dr["FK_KhachHang"] != DBNull.Value)
					{
						item.FK_KhachHang = Convert.ToString(dr["FK_KhachHang"]);
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
					if (dr["IsThanhToan"] != null && dr["IsThanhToan"] != DBNull.Value)
					{
						item.IsThanhToan = Convert.ToBoolean(dr["IsThanhToan"]);
					}
					if (dr["FK_LoaiThanhToan"] != null && dr["FK_LoaiThanhToan"] != DBNull.Value)
					{
						item.FK_LoaiThanhToan = Convert.ToString(dr["FK_LoaiThanhToan"]);
					}
					if (dr["NgayThanhToan"] != null && dr["NgayThanhToan"] != DBNull.Value)
					{
						item.NgayThanhToan = Convert.ToDateTime(dr["NgayThanhToan"]);
					}
					if (dr["NgayXuat"] != null && dr["NgayXuat"] != DBNull.Value)
					{
						item.NgayXuat = Convert.ToDateTime(dr["NgayXuat"]);
					}
					if (dr["FK_NguoiXuat"] != null && dr["FK_NguoiXuat"] != DBNull.Value)
					{
						item.FK_NguoiXuat = Convert.ToString(dr["FK_NguoiXuat"]);
					}
					if (dr["TenLoai"] != null && dr["TenLoai"] != DBNull.Value)
					{
						item.TenLoai = Convert.ToString(dr["TenLoai"]);
					}
					if (dr["TenSanPham"] != null && dr["TenSanPham"] != DBNull.Value)
					{
						item.TenSanPham = Convert.ToString(dr["TenSanPham"]);
					}
					if (dr["DonViTinh"] != null && dr["DonViTinh"] != DBNull.Value)
					{
						item.DonViTinh = Convert.ToString(dr["DonViTinh"]);
					}
					if (dr["GiaLe"] != null && dr["GiaLe"] != DBNull.Value)
					{
						item.GiaLe = Convert.ToInt32(dr["GiaLe"]);
					}
					if (dr["GiaSi"] != null && dr["GiaSi"] != DBNull.Value)
					{
						item.GiaSi = Convert.ToInt32(dr["GiaSi"]);
					}
					if (dr["SoLuongGiaSi"] != null && dr["SoLuongGiaSi"] != DBNull.Value)
					{
						item.SoLuongGiaSi = Convert.ToInt32(dr["SoLuongGiaSi"]);
					}
					if (dr["SoLuongTon"] != null && dr["SoLuongTon"] != DBNull.Value)
					{
						item.SoLuongTon = Convert.ToDecimal(dr["SoLuongTon"]);
					}
					if (dr["CustomerName"] != null && dr["CustomerName"] != DBNull.Value)
					{
						item.CustomerName = Convert.ToString(dr["CustomerName"]);
					}
					if (dr["CustomerPhone"] != null && dr["CustomerPhone"] != DBNull.Value)
					{
						item.CustomerPhone = Convert.ToString(dr["CustomerPhone"]);
					}
					if (dr["CustomerCode"] != null && dr["CustomerCode"] != DBNull.Value)
					{
						item.CustomerCode = Convert.ToString(dr["CustomerCode"]);
					}
					if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
					{
						item.FullName = Convert.ToString(dr["FullName"]);
					}
					if (dr["STHANHTOAN"] != null && dr["STHANHTOAN"] != DBNull.Value)
					{
						item.STHANHTOAN = Convert.ToString(dr["STHANHTOAN"]);
					}
					if (dr["SNGAYTHANHTOAN"] != null && dr["SNGAYTHANHTOAN"] != DBNull.Value)
					{
						item.SNGAYTHANHTOAN = Convert.ToString(dr["SNGAYTHANHTOAN"]);
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

		public List<view_ExpSaleXuatKho> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpSaleXuatKho] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_ExpSaleXuatKho] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_ExpSaleXuatKho>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_ExpSaleXuatKho đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_ExpSaleXuatKho GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpSaleXuatKho] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_ExpSaleXuatKho item=new view_ExpSaleXuatKho();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_Product"] != null && dr["FK_Product"] != DBNull.Value)
						{
							item.FK_Product = Convert.ToString(dr["FK_Product"]);
						}
						if (dr["FK_KhachHang"] != null && dr["FK_KhachHang"] != DBNull.Value)
						{
							item.FK_KhachHang = Convert.ToString(dr["FK_KhachHang"]);
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
						if (dr["IsThanhToan"] != null && dr["IsThanhToan"] != DBNull.Value)
						{
							item.IsThanhToan = Convert.ToBoolean(dr["IsThanhToan"]);
						}
						if (dr["FK_LoaiThanhToan"] != null && dr["FK_LoaiThanhToan"] != DBNull.Value)
						{
							item.FK_LoaiThanhToan = Convert.ToString(dr["FK_LoaiThanhToan"]);
						}
						if (dr["NgayThanhToan"] != null && dr["NgayThanhToan"] != DBNull.Value)
						{
							item.NgayThanhToan = Convert.ToDateTime(dr["NgayThanhToan"]);
						}
						if (dr["NgayXuat"] != null && dr["NgayXuat"] != DBNull.Value)
						{
							item.NgayXuat = Convert.ToDateTime(dr["NgayXuat"]);
						}
						if (dr["FK_NguoiXuat"] != null && dr["FK_NguoiXuat"] != DBNull.Value)
						{
							item.FK_NguoiXuat = Convert.ToString(dr["FK_NguoiXuat"]);
						}
						if (dr["TenLoai"] != null && dr["TenLoai"] != DBNull.Value)
						{
							item.TenLoai = Convert.ToString(dr["TenLoai"]);
						}
						if (dr["TenSanPham"] != null && dr["TenSanPham"] != DBNull.Value)
						{
							item.TenSanPham = Convert.ToString(dr["TenSanPham"]);
						}
						if (dr["DonViTinh"] != null && dr["DonViTinh"] != DBNull.Value)
						{
							item.DonViTinh = Convert.ToString(dr["DonViTinh"]);
						}
						if (dr["GiaLe"] != null && dr["GiaLe"] != DBNull.Value)
						{
							item.GiaLe = Convert.ToInt32(dr["GiaLe"]);
						}
						if (dr["GiaSi"] != null && dr["GiaSi"] != DBNull.Value)
						{
							item.GiaSi = Convert.ToInt32(dr["GiaSi"]);
						}
						if (dr["SoLuongGiaSi"] != null && dr["SoLuongGiaSi"] != DBNull.Value)
						{
							item.SoLuongGiaSi = Convert.ToInt32(dr["SoLuongGiaSi"]);
						}
						if (dr["SoLuongTon"] != null && dr["SoLuongTon"] != DBNull.Value)
						{
							item.SoLuongTon = Convert.ToDecimal(dr["SoLuongTon"]);
						}
						if (dr["CustomerName"] != null && dr["CustomerName"] != DBNull.Value)
						{
							item.CustomerName = Convert.ToString(dr["CustomerName"]);
						}
						if (dr["CustomerPhone"] != null && dr["CustomerPhone"] != DBNull.Value)
						{
							item.CustomerPhone = Convert.ToString(dr["CustomerPhone"]);
						}
						if (dr["CustomerCode"] != null && dr["CustomerCode"] != DBNull.Value)
						{
							item.CustomerCode = Convert.ToString(dr["CustomerCode"]);
						}
						if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
						{
							item.FullName = Convert.ToString(dr["FullName"]);
						}
						if (dr["STHANHTOAN"] != null && dr["STHANHTOAN"] != DBNull.Value)
						{
							item.STHANHTOAN = Convert.ToString(dr["STHANHTOAN"]);
						}
						if (dr["SNGAYTHANHTOAN"] != null && dr["SNGAYTHANHTOAN"] != DBNull.Value)
						{
							item.SNGAYTHANHTOAN = Convert.ToString(dr["SNGAYTHANHTOAN"]);
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

		public view_ExpSaleXuatKho GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpSaleXuatKho] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_ExpSaleXuatKho>(ds);
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
