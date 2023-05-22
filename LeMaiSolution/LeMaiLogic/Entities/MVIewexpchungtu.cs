using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewexpchungtu:IVIewexpchungtu
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewexpchungtu(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_ExpChungTu từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpChungTu]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_ExpChungTu từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpChungTu] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_ExpChungTu từ Database
		/// </summary>
		public List<view_ExpChungTu> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpChungTu]");
				List<view_ExpChungTu> items = new List<view_ExpChungTu>();
				view_ExpChungTu item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpChungTu();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
					{
						item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
					}
					if (dr["NgayChungTu"] != null && dr["NgayChungTu"] != DBNull.Value)
					{
						item.NgayChungTu = Convert.ToDateTime(dr["NgayChungTu"]);
					}
					if (dr["SoHoaDon"] != null && dr["SoHoaDon"] != DBNull.Value)
					{
						item.SoHoaDon = Convert.ToString(dr["SoHoaDon"]);
					}
					if (dr["NgayHoaDon"] != null && dr["NgayHoaDon"] != DBNull.Value)
					{
						item.NgayHoaDon = Convert.ToDateTime(dr["NgayHoaDon"]);
					}
					if (dr["SoTienThu"] != null && dr["SoTienThu"] != DBNull.Value)
					{
						item.SoTienThu = Convert.ToDecimal(dr["SoTienThu"]);
					}
					if (dr["SoTienChi"] != null && dr["SoTienChi"] != DBNull.Value)
					{
						item.SoTienChi = Convert.ToDecimal(dr["SoTienChi"]);
					}
					if (dr["LyDoChi"] != null && dr["LyDoChi"] != DBNull.Value)
					{
						item.LyDoChi = Convert.ToString(dr["LyDoChi"]);
					}
					if (dr["LyDoThu"] != null && dr["LyDoThu"] != DBNull.Value)
					{
						item.LyDoThu = Convert.ToString(dr["LyDoThu"]);
					}
					if (dr["SoChungTuThu"] != null && dr["SoChungTuThu"] != DBNull.Value)
					{
						item.SoChungTuThu = Convert.ToString(dr["SoChungTuThu"]);
					}
					if (dr["SoChungTuChi"] != null && dr["SoChungTuChi"] != DBNull.Value)
					{
						item.SoChungTuChi = Convert.ToString(dr["SoChungTuChi"]);
					}
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
					}
					if (dr["ThangKT"] != null && dr["ThangKT"] != DBNull.Value)
					{
						item.ThangKT = Convert.ToDateTime(dr["ThangKT"]);
					}
					if (dr["FK_KyKetToan"] != null && dr["FK_KyKetToan"] != DBNull.Value)
					{
						item.FK_KyKetToan = Convert.ToString(dr["FK_KyKetToan"]);
					}
					if (dr["NguoiMuaHang"] != null && dr["NguoiMuaHang"] != DBNull.Value)
					{
						item.NguoiMuaHang = Convert.ToString(dr["NguoiMuaHang"]);
					}
					if (dr["DonViMuaHang"] != null && dr["DonViMuaHang"] != DBNull.Value)
					{
						item.DonViMuaHang = Convert.ToString(dr["DonViMuaHang"]);
					}
					if (dr["MaSoThue"] != null && dr["MaSoThue"] != DBNull.Value)
					{
						item.MaSoThue = Convert.ToString(dr["MaSoThue"]);
					}
					if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
					{
						item.DiaChi = Convert.ToString(dr["DiaChi"]);
					}
					if (dr["IsPhatHanh"] != null && dr["IsPhatHanh"] != DBNull.Value)
					{
						item.IsPhatHanh = Convert.ToBoolean(dr["IsPhatHanh"]);
					}
					if (dr["TongThuHo"] != null && dr["TongThuHo"] != DBNull.Value)
					{
						item.TongThuHo = Convert.ToDecimal(dr["TongThuHo"]);
					}
					if (dr["TongPhiNhanTra"] != null && dr["TongPhiNhanTra"] != DBNull.Value)
					{
						item.TongPhiNhanTra = Convert.ToDecimal(dr["TongPhiNhanTra"]);
					}
					if (dr["TongPhiGuiTra"] != null && dr["TongPhiGuiTra"] != DBNull.Value)
					{
						item.TongPhiGuiTra = Convert.ToDecimal(dr["TongPhiGuiTra"]);
					}
					if (dr["TongPhiChuaVAT"] != null && dr["TongPhiChuaVAT"] != DBNull.Value)
					{
						item.TongPhiChuaVAT = Convert.ToDecimal(dr["TongPhiChuaVAT"]);
					}
					if (dr["ThueVAT"] != null && dr["ThueVAT"] != DBNull.Value)
					{
						item.ThueVAT = Convert.ToDecimal(dr["ThueVAT"]);
					}
					if (dr["TongPhiVanChuyen"] != null && dr["TongPhiVanChuyen"] != DBNull.Value)
					{
						item.TongPhiVanChuyen = Convert.ToDecimal(dr["TongPhiVanChuyen"]);
					}
					if (dr["SoChungTu"] != null && dr["SoChungTu"] != DBNull.Value)
					{
						item.SoChungTu = Convert.ToInt32(dr["SoChungTu"]);
					}
					if (dr["CustomerCode"] != null && dr["CustomerCode"] != DBNull.Value)
					{
						item.CustomerCode = Convert.ToString(dr["CustomerCode"]);
					}
					if (dr["CustomerName"] != null && dr["CustomerName"] != DBNull.Value)
					{
						item.CustomerName = Convert.ToString(dr["CustomerName"]);
					}
					if (dr["CustomerPhone"] != null && dr["CustomerPhone"] != DBNull.Value)
					{
						item.CustomerPhone = Convert.ToString(dr["CustomerPhone"]);
					}
					if (dr["TenKy"] != null && dr["TenKy"] != DBNull.Value)
					{
						item.TenKy = Convert.ToString(dr["TenKy"]);
					}
					if (dr["QuyenSoChi"] != null && dr["QuyenSoChi"] != DBNull.Value)
					{
						item.QuyenSoChi = Convert.ToString(dr["QuyenSoChi"]);
					}
					if (dr["QuyenSoThu"] != null && dr["QuyenSoThu"] != DBNull.Value)
					{
						item.QuyenSoThu = Convert.ToString(dr["QuyenSoThu"]);
					}
					if (dr["QuyenSoTongChi"] != null && dr["QuyenSoTongChi"] != DBNull.Value)
					{
						item.QuyenSoTongChi = Convert.ToString(dr["QuyenSoTongChi"]);
					}
					if (dr["COUNT_CHILD"] != null && dr["COUNT_CHILD"] != DBNull.Value)
					{
						item.COUNT_CHILD = Convert.ToInt32(dr["COUNT_CHILD"]);
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
		/// Lấy danh sách view_ExpChungTu từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_ExpChungTu> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpChungTu] A "+ condition,  parameters);
				List<view_ExpChungTu> items = new List<view_ExpChungTu>();
				view_ExpChungTu item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpChungTu();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
					{
						item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
					}
					if (dr["NgayChungTu"] != null && dr["NgayChungTu"] != DBNull.Value)
					{
						item.NgayChungTu = Convert.ToDateTime(dr["NgayChungTu"]);
					}
					if (dr["SoHoaDon"] != null && dr["SoHoaDon"] != DBNull.Value)
					{
						item.SoHoaDon = Convert.ToString(dr["SoHoaDon"]);
					}
					if (dr["NgayHoaDon"] != null && dr["NgayHoaDon"] != DBNull.Value)
					{
						item.NgayHoaDon = Convert.ToDateTime(dr["NgayHoaDon"]);
					}
					if (dr["SoTienThu"] != null && dr["SoTienThu"] != DBNull.Value)
					{
						item.SoTienThu = Convert.ToDecimal(dr["SoTienThu"]);
					}
					if (dr["SoTienChi"] != null && dr["SoTienChi"] != DBNull.Value)
					{
						item.SoTienChi = Convert.ToDecimal(dr["SoTienChi"]);
					}
					if (dr["LyDoChi"] != null && dr["LyDoChi"] != DBNull.Value)
					{
						item.LyDoChi = Convert.ToString(dr["LyDoChi"]);
					}
					if (dr["LyDoThu"] != null && dr["LyDoThu"] != DBNull.Value)
					{
						item.LyDoThu = Convert.ToString(dr["LyDoThu"]);
					}
					if (dr["SoChungTuThu"] != null && dr["SoChungTuThu"] != DBNull.Value)
					{
						item.SoChungTuThu = Convert.ToString(dr["SoChungTuThu"]);
					}
					if (dr["SoChungTuChi"] != null && dr["SoChungTuChi"] != DBNull.Value)
					{
						item.SoChungTuChi = Convert.ToString(dr["SoChungTuChi"]);
					}
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
					}
					if (dr["ThangKT"] != null && dr["ThangKT"] != DBNull.Value)
					{
						item.ThangKT = Convert.ToDateTime(dr["ThangKT"]);
					}
					if (dr["FK_KyKetToan"] != null && dr["FK_KyKetToan"] != DBNull.Value)
					{
						item.FK_KyKetToan = Convert.ToString(dr["FK_KyKetToan"]);
					}
					if (dr["NguoiMuaHang"] != null && dr["NguoiMuaHang"] != DBNull.Value)
					{
						item.NguoiMuaHang = Convert.ToString(dr["NguoiMuaHang"]);
					}
					if (dr["DonViMuaHang"] != null && dr["DonViMuaHang"] != DBNull.Value)
					{
						item.DonViMuaHang = Convert.ToString(dr["DonViMuaHang"]);
					}
					if (dr["MaSoThue"] != null && dr["MaSoThue"] != DBNull.Value)
					{
						item.MaSoThue = Convert.ToString(dr["MaSoThue"]);
					}
					if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
					{
						item.DiaChi = Convert.ToString(dr["DiaChi"]);
					}
					if (dr["IsPhatHanh"] != null && dr["IsPhatHanh"] != DBNull.Value)
					{
						item.IsPhatHanh = Convert.ToBoolean(dr["IsPhatHanh"]);
					}
					if (dr["TongThuHo"] != null && dr["TongThuHo"] != DBNull.Value)
					{
						item.TongThuHo = Convert.ToDecimal(dr["TongThuHo"]);
					}
					if (dr["TongPhiNhanTra"] != null && dr["TongPhiNhanTra"] != DBNull.Value)
					{
						item.TongPhiNhanTra = Convert.ToDecimal(dr["TongPhiNhanTra"]);
					}
					if (dr["TongPhiGuiTra"] != null && dr["TongPhiGuiTra"] != DBNull.Value)
					{
						item.TongPhiGuiTra = Convert.ToDecimal(dr["TongPhiGuiTra"]);
					}
					if (dr["TongPhiChuaVAT"] != null && dr["TongPhiChuaVAT"] != DBNull.Value)
					{
						item.TongPhiChuaVAT = Convert.ToDecimal(dr["TongPhiChuaVAT"]);
					}
					if (dr["ThueVAT"] != null && dr["ThueVAT"] != DBNull.Value)
					{
						item.ThueVAT = Convert.ToDecimal(dr["ThueVAT"]);
					}
					if (dr["TongPhiVanChuyen"] != null && dr["TongPhiVanChuyen"] != DBNull.Value)
					{
						item.TongPhiVanChuyen = Convert.ToDecimal(dr["TongPhiVanChuyen"]);
					}
					if (dr["SoChungTu"] != null && dr["SoChungTu"] != DBNull.Value)
					{
						item.SoChungTu = Convert.ToInt32(dr["SoChungTu"]);
					}
					if (dr["CustomerCode"] != null && dr["CustomerCode"] != DBNull.Value)
					{
						item.CustomerCode = Convert.ToString(dr["CustomerCode"]);
					}
					if (dr["CustomerName"] != null && dr["CustomerName"] != DBNull.Value)
					{
						item.CustomerName = Convert.ToString(dr["CustomerName"]);
					}
					if (dr["CustomerPhone"] != null && dr["CustomerPhone"] != DBNull.Value)
					{
						item.CustomerPhone = Convert.ToString(dr["CustomerPhone"]);
					}
					if (dr["TenKy"] != null && dr["TenKy"] != DBNull.Value)
					{
						item.TenKy = Convert.ToString(dr["TenKy"]);
					}
					if (dr["QuyenSoChi"] != null && dr["QuyenSoChi"] != DBNull.Value)
					{
						item.QuyenSoChi = Convert.ToString(dr["QuyenSoChi"]);
					}
					if (dr["QuyenSoThu"] != null && dr["QuyenSoThu"] != DBNull.Value)
					{
						item.QuyenSoThu = Convert.ToString(dr["QuyenSoThu"]);
					}
					if (dr["QuyenSoTongChi"] != null && dr["QuyenSoTongChi"] != DBNull.Value)
					{
						item.QuyenSoTongChi = Convert.ToString(dr["QuyenSoTongChi"]);
					}
					if (dr["COUNT_CHILD"] != null && dr["COUNT_CHILD"] != DBNull.Value)
					{
						item.COUNT_CHILD = Convert.ToInt32(dr["COUNT_CHILD"]);
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

		public List<view_ExpChungTu> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpChungTu] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_ExpChungTu] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_ExpChungTu>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_ExpChungTu đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_ExpChungTu GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpChungTu] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_ExpChungTu item=new view_ExpChungTu();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
						{
							item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
						}
						if (dr["NgayChungTu"] != null && dr["NgayChungTu"] != DBNull.Value)
						{
							item.NgayChungTu = Convert.ToDateTime(dr["NgayChungTu"]);
						}
						if (dr["SoHoaDon"] != null && dr["SoHoaDon"] != DBNull.Value)
						{
							item.SoHoaDon = Convert.ToString(dr["SoHoaDon"]);
						}
						if (dr["NgayHoaDon"] != null && dr["NgayHoaDon"] != DBNull.Value)
						{
							item.NgayHoaDon = Convert.ToDateTime(dr["NgayHoaDon"]);
						}
						if (dr["SoTienThu"] != null && dr["SoTienThu"] != DBNull.Value)
						{
							item.SoTienThu = Convert.ToDecimal(dr["SoTienThu"]);
						}
						if (dr["SoTienChi"] != null && dr["SoTienChi"] != DBNull.Value)
						{
							item.SoTienChi = Convert.ToDecimal(dr["SoTienChi"]);
						}
						if (dr["LyDoChi"] != null && dr["LyDoChi"] != DBNull.Value)
						{
							item.LyDoChi = Convert.ToString(dr["LyDoChi"]);
						}
						if (dr["LyDoThu"] != null && dr["LyDoThu"] != DBNull.Value)
						{
							item.LyDoThu = Convert.ToString(dr["LyDoThu"]);
						}
						if (dr["SoChungTuThu"] != null && dr["SoChungTuThu"] != DBNull.Value)
						{
							item.SoChungTuThu = Convert.ToString(dr["SoChungTuThu"]);
						}
						if (dr["SoChungTuChi"] != null && dr["SoChungTuChi"] != DBNull.Value)
						{
							item.SoChungTuChi = Convert.ToString(dr["SoChungTuChi"]);
						}
						if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
						{
							item.FK_Account = Convert.ToString(dr["FK_Account"]);
						}
						if (dr["ThangKT"] != null && dr["ThangKT"] != DBNull.Value)
						{
							item.ThangKT = Convert.ToDateTime(dr["ThangKT"]);
						}
						if (dr["FK_KyKetToan"] != null && dr["FK_KyKetToan"] != DBNull.Value)
						{
							item.FK_KyKetToan = Convert.ToString(dr["FK_KyKetToan"]);
						}
						if (dr["NguoiMuaHang"] != null && dr["NguoiMuaHang"] != DBNull.Value)
						{
							item.NguoiMuaHang = Convert.ToString(dr["NguoiMuaHang"]);
						}
						if (dr["DonViMuaHang"] != null && dr["DonViMuaHang"] != DBNull.Value)
						{
							item.DonViMuaHang = Convert.ToString(dr["DonViMuaHang"]);
						}
						if (dr["MaSoThue"] != null && dr["MaSoThue"] != DBNull.Value)
						{
							item.MaSoThue = Convert.ToString(dr["MaSoThue"]);
						}
						if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
						{
							item.DiaChi = Convert.ToString(dr["DiaChi"]);
						}
						if (dr["IsPhatHanh"] != null && dr["IsPhatHanh"] != DBNull.Value)
						{
							item.IsPhatHanh = Convert.ToBoolean(dr["IsPhatHanh"]);
						}
						if (dr["TongThuHo"] != null && dr["TongThuHo"] != DBNull.Value)
						{
							item.TongThuHo = Convert.ToDecimal(dr["TongThuHo"]);
						}
						if (dr["TongPhiNhanTra"] != null && dr["TongPhiNhanTra"] != DBNull.Value)
						{
							item.TongPhiNhanTra = Convert.ToDecimal(dr["TongPhiNhanTra"]);
						}
						if (dr["TongPhiGuiTra"] != null && dr["TongPhiGuiTra"] != DBNull.Value)
						{
							item.TongPhiGuiTra = Convert.ToDecimal(dr["TongPhiGuiTra"]);
						}
						if (dr["TongPhiChuaVAT"] != null && dr["TongPhiChuaVAT"] != DBNull.Value)
						{
							item.TongPhiChuaVAT = Convert.ToDecimal(dr["TongPhiChuaVAT"]);
						}
						if (dr["ThueVAT"] != null && dr["ThueVAT"] != DBNull.Value)
						{
							item.ThueVAT = Convert.ToDecimal(dr["ThueVAT"]);
						}
						if (dr["TongPhiVanChuyen"] != null && dr["TongPhiVanChuyen"] != DBNull.Value)
						{
							item.TongPhiVanChuyen = Convert.ToDecimal(dr["TongPhiVanChuyen"]);
						}
						if (dr["SoChungTu"] != null && dr["SoChungTu"] != DBNull.Value)
						{
							item.SoChungTu = Convert.ToInt32(dr["SoChungTu"]);
						}
						if (dr["CustomerCode"] != null && dr["CustomerCode"] != DBNull.Value)
						{
							item.CustomerCode = Convert.ToString(dr["CustomerCode"]);
						}
						if (dr["CustomerName"] != null && dr["CustomerName"] != DBNull.Value)
						{
							item.CustomerName = Convert.ToString(dr["CustomerName"]);
						}
						if (dr["CustomerPhone"] != null && dr["CustomerPhone"] != DBNull.Value)
						{
							item.CustomerPhone = Convert.ToString(dr["CustomerPhone"]);
						}
						if (dr["TenKy"] != null && dr["TenKy"] != DBNull.Value)
						{
							item.TenKy = Convert.ToString(dr["TenKy"]);
						}
						if (dr["QuyenSoChi"] != null && dr["QuyenSoChi"] != DBNull.Value)
						{
							item.QuyenSoChi = Convert.ToString(dr["QuyenSoChi"]);
						}
						if (dr["QuyenSoThu"] != null && dr["QuyenSoThu"] != DBNull.Value)
						{
							item.QuyenSoThu = Convert.ToString(dr["QuyenSoThu"]);
						}
						if (dr["QuyenSoTongChi"] != null && dr["QuyenSoTongChi"] != DBNull.Value)
						{
							item.QuyenSoTongChi = Convert.ToString(dr["QuyenSoTongChi"]);
						}
						if (dr["COUNT_CHILD"] != null && dr["COUNT_CHILD"] != DBNull.Value)
						{
							item.COUNT_CHILD = Convert.ToInt32(dr["COUNT_CHILD"]);
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

		public view_ExpChungTu GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpChungTu] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_ExpChungTu>(ds);
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
