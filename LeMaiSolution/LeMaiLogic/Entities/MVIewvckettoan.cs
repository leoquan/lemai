using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewvckettoan:IVIewvckettoan
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewvckettoan(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_VCKetToan từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_VCKetToan]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_VCKetToan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_VCKetToan] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_VCKetToan từ Database
		/// </summary>
		public List<view_VCKetToan> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_VCKetToan]");
				List<view_VCKetToan> items = new List<view_VCKetToan>();
				view_VCKetToan item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_VCKetToan();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_BillCode"] != null && dr["FK_BillCode"] != DBNull.Value)
					{
						item.FK_BillCode = Convert.ToString(dr["FK_BillCode"]);
					}
					if (dr["FK_KhachHang"] != null && dr["FK_KhachHang"] != DBNull.Value)
					{
						item.FK_KhachHang = Convert.ToString(dr["FK_KhachHang"]);
					}
					if (dr["MaChiPhi"] != null && dr["MaChiPhi"] != DBNull.Value)
					{
						item.MaChiPhi = Convert.ToString(dr["MaChiPhi"]);
					}
					if (dr["SoDuTruoc"] != null && dr["SoDuTruoc"] != DBNull.Value)
					{
						item.SoDuTruoc = Convert.ToDecimal(dr["SoDuTruoc"]);
					}
					if (dr["SoTien"] != null && dr["SoTien"] != DBNull.Value)
					{
						item.SoTien = Convert.ToDecimal(dr["SoTien"]);
					}
					if (dr["SoDuSau"] != null && dr["SoDuSau"] != DBNull.Value)
					{
						item.SoDuSau = Convert.ToDecimal(dr["SoDuSau"]);
					}
					if (dr["NgayKetToan"] != null && dr["NgayKetToan"] != DBNull.Value)
					{
						item.NgayKetToan = Convert.ToDateTime(dr["NgayKetToan"]);
					}
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
					}
					if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
					{
						item.FullName = Convert.ToString(dr["FullName"]);
					}
					if (dr["TenChiPhi"] != null && dr["TenChiPhi"] != DBNull.Value)
					{
						item.TenChiPhi = Convert.ToString(dr["TenChiPhi"]);
					}
					if (dr["Rate"] != null && dr["Rate"] != DBNull.Value)
					{
						item.Rate = Convert.ToDecimal(dr["Rate"]);
					}
					if (dr["TenKhachHang"] != null && dr["TenKhachHang"] != DBNull.Value)
					{
						item.TenKhachHang = Convert.ToString(dr["TenKhachHang"]);
					}
					if (dr["MaKhachHang"] != null && dr["MaKhachHang"] != DBNull.Value)
					{
						item.MaKhachHang = Convert.ToString(dr["MaKhachHang"]);
					}
					if (dr["SoNo"] != null && dr["SoNo"] != DBNull.Value)
					{
						item.SoNo = Convert.ToDecimal(dr["SoNo"]);
					}
					if (dr["Ngay"] != null && dr["Ngay"] != DBNull.Value)
					{
						item.Ngay = Convert.ToDateTime(dr["Ngay"]);
					}
					if (dr["NgayXuat"] != null && dr["NgayXuat"] != DBNull.Value)
					{
						item.NgayXuat = Convert.ToDateTime(dr["NgayXuat"]);
					}
					if (dr["DonGia"] != null && dr["DonGia"] != DBNull.Value)
					{
						item.DonGia = Convert.ToInt32(dr["DonGia"]);
					}
					if (dr["SoLuong"] != null && dr["SoLuong"] != DBNull.Value)
					{
						item.SoLuong = Convert.ToDecimal(dr["SoLuong"]);
					}
					if (dr["ThanhTien"] != null && dr["ThanhTien"] != DBNull.Value)
					{
						item.ThanhTien = Convert.ToDecimal(dr["ThanhTien"]);
					}
					if (dr["ThanhToan"] != null && dr["ThanhToan"] != DBNull.Value)
					{
						item.ThanhToan = Convert.ToDecimal(dr["ThanhToan"]);
					}
					if (dr["MaHang"] != null && dr["MaHang"] != DBNull.Value)
					{
						item.MaHang = Convert.ToString(dr["MaHang"]);
					}
					if (dr["TenHang"] != null && dr["TenHang"] != DBNull.Value)
					{
						item.TenHang = Convert.ToString(dr["TenHang"]);
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
		/// Lấy danh sách view_VCKetToan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_VCKetToan> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_VCKetToan] A "+ condition,  parameters);
				List<view_VCKetToan> items = new List<view_VCKetToan>();
				view_VCKetToan item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_VCKetToan();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_BillCode"] != null && dr["FK_BillCode"] != DBNull.Value)
					{
						item.FK_BillCode = Convert.ToString(dr["FK_BillCode"]);
					}
					if (dr["FK_KhachHang"] != null && dr["FK_KhachHang"] != DBNull.Value)
					{
						item.FK_KhachHang = Convert.ToString(dr["FK_KhachHang"]);
					}
					if (dr["MaChiPhi"] != null && dr["MaChiPhi"] != DBNull.Value)
					{
						item.MaChiPhi = Convert.ToString(dr["MaChiPhi"]);
					}
					if (dr["SoDuTruoc"] != null && dr["SoDuTruoc"] != DBNull.Value)
					{
						item.SoDuTruoc = Convert.ToDecimal(dr["SoDuTruoc"]);
					}
					if (dr["SoTien"] != null && dr["SoTien"] != DBNull.Value)
					{
						item.SoTien = Convert.ToDecimal(dr["SoTien"]);
					}
					if (dr["SoDuSau"] != null && dr["SoDuSau"] != DBNull.Value)
					{
						item.SoDuSau = Convert.ToDecimal(dr["SoDuSau"]);
					}
					if (dr["NgayKetToan"] != null && dr["NgayKetToan"] != DBNull.Value)
					{
						item.NgayKetToan = Convert.ToDateTime(dr["NgayKetToan"]);
					}
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
					}
					if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
					{
						item.FullName = Convert.ToString(dr["FullName"]);
					}
					if (dr["TenChiPhi"] != null && dr["TenChiPhi"] != DBNull.Value)
					{
						item.TenChiPhi = Convert.ToString(dr["TenChiPhi"]);
					}
					if (dr["Rate"] != null && dr["Rate"] != DBNull.Value)
					{
						item.Rate = Convert.ToDecimal(dr["Rate"]);
					}
					if (dr["TenKhachHang"] != null && dr["TenKhachHang"] != DBNull.Value)
					{
						item.TenKhachHang = Convert.ToString(dr["TenKhachHang"]);
					}
					if (dr["MaKhachHang"] != null && dr["MaKhachHang"] != DBNull.Value)
					{
						item.MaKhachHang = Convert.ToString(dr["MaKhachHang"]);
					}
					if (dr["SoNo"] != null && dr["SoNo"] != DBNull.Value)
					{
						item.SoNo = Convert.ToDecimal(dr["SoNo"]);
					}
					if (dr["Ngay"] != null && dr["Ngay"] != DBNull.Value)
					{
						item.Ngay = Convert.ToDateTime(dr["Ngay"]);
					}
					if (dr["NgayXuat"] != null && dr["NgayXuat"] != DBNull.Value)
					{
						item.NgayXuat = Convert.ToDateTime(dr["NgayXuat"]);
					}
					if (dr["DonGia"] != null && dr["DonGia"] != DBNull.Value)
					{
						item.DonGia = Convert.ToInt32(dr["DonGia"]);
					}
					if (dr["SoLuong"] != null && dr["SoLuong"] != DBNull.Value)
					{
						item.SoLuong = Convert.ToDecimal(dr["SoLuong"]);
					}
					if (dr["ThanhTien"] != null && dr["ThanhTien"] != DBNull.Value)
					{
						item.ThanhTien = Convert.ToDecimal(dr["ThanhTien"]);
					}
					if (dr["ThanhToan"] != null && dr["ThanhToan"] != DBNull.Value)
					{
						item.ThanhToan = Convert.ToDecimal(dr["ThanhToan"]);
					}
					if (dr["MaHang"] != null && dr["MaHang"] != DBNull.Value)
					{
						item.MaHang = Convert.ToString(dr["MaHang"]);
					}
					if (dr["TenHang"] != null && dr["TenHang"] != DBNull.Value)
					{
						item.TenHang = Convert.ToString(dr["TenHang"]);
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

		public List<view_VCKetToan> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_VCKetToan] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_VCKetToan] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_VCKetToan>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_VCKetToan đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_VCKetToan GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_VCKetToan] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_VCKetToan item=new view_VCKetToan();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_BillCode"] != null && dr["FK_BillCode"] != DBNull.Value)
						{
							item.FK_BillCode = Convert.ToString(dr["FK_BillCode"]);
						}
						if (dr["FK_KhachHang"] != null && dr["FK_KhachHang"] != DBNull.Value)
						{
							item.FK_KhachHang = Convert.ToString(dr["FK_KhachHang"]);
						}
						if (dr["MaChiPhi"] != null && dr["MaChiPhi"] != DBNull.Value)
						{
							item.MaChiPhi = Convert.ToString(dr["MaChiPhi"]);
						}
						if (dr["SoDuTruoc"] != null && dr["SoDuTruoc"] != DBNull.Value)
						{
							item.SoDuTruoc = Convert.ToDecimal(dr["SoDuTruoc"]);
						}
						if (dr["SoTien"] != null && dr["SoTien"] != DBNull.Value)
						{
							item.SoTien = Convert.ToDecimal(dr["SoTien"]);
						}
						if (dr["SoDuSau"] != null && dr["SoDuSau"] != DBNull.Value)
						{
							item.SoDuSau = Convert.ToDecimal(dr["SoDuSau"]);
						}
						if (dr["NgayKetToan"] != null && dr["NgayKetToan"] != DBNull.Value)
						{
							item.NgayKetToan = Convert.ToDateTime(dr["NgayKetToan"]);
						}
						if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
						{
							item.FK_Account = Convert.ToString(dr["FK_Account"]);
						}
						if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
						{
							item.FullName = Convert.ToString(dr["FullName"]);
						}
						if (dr["TenChiPhi"] != null && dr["TenChiPhi"] != DBNull.Value)
						{
							item.TenChiPhi = Convert.ToString(dr["TenChiPhi"]);
						}
						if (dr["Rate"] != null && dr["Rate"] != DBNull.Value)
						{
							item.Rate = Convert.ToDecimal(dr["Rate"]);
						}
						if (dr["TenKhachHang"] != null && dr["TenKhachHang"] != DBNull.Value)
						{
							item.TenKhachHang = Convert.ToString(dr["TenKhachHang"]);
						}
						if (dr["MaKhachHang"] != null && dr["MaKhachHang"] != DBNull.Value)
						{
							item.MaKhachHang = Convert.ToString(dr["MaKhachHang"]);
						}
						if (dr["SoNo"] != null && dr["SoNo"] != DBNull.Value)
						{
							item.SoNo = Convert.ToDecimal(dr["SoNo"]);
						}
						if (dr["Ngay"] != null && dr["Ngay"] != DBNull.Value)
						{
							item.Ngay = Convert.ToDateTime(dr["Ngay"]);
						}
						if (dr["NgayXuat"] != null && dr["NgayXuat"] != DBNull.Value)
						{
							item.NgayXuat = Convert.ToDateTime(dr["NgayXuat"]);
						}
						if (dr["DonGia"] != null && dr["DonGia"] != DBNull.Value)
						{
							item.DonGia = Convert.ToInt32(dr["DonGia"]);
						}
						if (dr["SoLuong"] != null && dr["SoLuong"] != DBNull.Value)
						{
							item.SoLuong = Convert.ToDecimal(dr["SoLuong"]);
						}
						if (dr["ThanhTien"] != null && dr["ThanhTien"] != DBNull.Value)
						{
							item.ThanhTien = Convert.ToDecimal(dr["ThanhTien"]);
						}
						if (dr["ThanhToan"] != null && dr["ThanhToan"] != DBNull.Value)
						{
							item.ThanhToan = Convert.ToDecimal(dr["ThanhToan"]);
						}
						if (dr["MaHang"] != null && dr["MaHang"] != DBNull.Value)
						{
							item.MaHang = Convert.ToString(dr["MaHang"]);
						}
						if (dr["TenHang"] != null && dr["TenHang"] != DBNull.Value)
						{
							item.TenHang = Convert.ToString(dr["TenHang"]);
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

		public view_VCKetToan GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_VCKetToan] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_VCKetToan>(ds);
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
