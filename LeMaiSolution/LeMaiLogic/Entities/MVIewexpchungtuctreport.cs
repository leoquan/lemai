using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewexpchungtuctreport:IVIewexpchungtuctreport
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewexpchungtuctreport(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_ExpChungTuCtReport từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpChungTuCtReport]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_ExpChungTuCtReport từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpChungTuCtReport] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_ExpChungTuCtReport từ Database
		/// </summary>
		public List<view_ExpChungTuCtReport> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpChungTuCtReport]");
				List<view_ExpChungTuCtReport> items = new List<view_ExpChungTuCtReport>();
				view_ExpChungTuCtReport item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpChungTuCtReport();
					if (dr["FK_ExpChungTu"] != null && dr["FK_ExpChungTu"] != DBNull.Value)
					{
						item.FK_ExpChungTu = Convert.ToString(dr["FK_ExpChungTu"]);
					}
					if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
					{
						item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
					}
					if (dr["SoTienPhaiThu"] != null && dr["SoTienPhaiThu"] != DBNull.Value)
					{
						item.SoTienPhaiThu = Convert.ToDecimal(dr["SoTienPhaiThu"]);
					}
					if (dr["SoTienPhaiChi"] != null && dr["SoTienPhaiChi"] != DBNull.Value)
					{
						item.SoTienPhaiChi = Convert.ToDecimal(dr["SoTienPhaiChi"]);
					}
					if (dr["TenNguoiNhan"] != null && dr["TenNguoiNhan"] != DBNull.Value)
					{
						item.TenNguoiNhan = Convert.ToString(dr["TenNguoiNhan"]);
					}
					if (dr["SoDienThoaiNhan"] != null && dr["SoDienThoaiNhan"] != DBNull.Value)
					{
						item.SoDienThoaiNhan = Convert.ToString(dr["SoDienThoaiNhan"]);
					}
					if (dr["DiaChiNhan"] != null && dr["DiaChiNhan"] != DBNull.Value)
					{
						item.DiaChiNhan = Convert.ToString(dr["DiaChiNhan"]);
					}
					if (dr["SoTienThuHo"] != null && dr["SoTienThuHo"] != DBNull.Value)
					{
						item.SoTienThuHo = Convert.ToDecimal(dr["SoTienThuHo"]);
					}
					if (dr["CuocPhiVanChuyen"] != null && dr["CuocPhiVanChuyen"] != DBNull.Value)
					{
						item.CuocPhiVanChuyen = Convert.ToDecimal(dr["CuocPhiVanChuyen"]);
					}
					if (dr["TenHang"] != null && dr["TenHang"] != DBNull.Value)
					{
						item.TenHang = Convert.ToString(dr["TenHang"]);
					}
					if (dr["TrongLuong"] != null && dr["TrongLuong"] != DBNull.Value)
					{
						item.TrongLuong = Convert.ToDecimal(dr["TrongLuong"]);
					}
					if (dr["IsPhatHanh"] != null && dr["IsPhatHanh"] != DBNull.Value)
					{
						item.IsPhatHanh = Convert.ToBoolean(dr["IsPhatHanh"]);
					}
					if (dr["CuocPhiChuaGTGT"] != null && dr["CuocPhiChuaGTGT"] != DBNull.Value)
					{
						item.CuocPhiChuaGTGT = Convert.ToDecimal(dr["CuocPhiChuaGTGT"]);
					}
					if (dr["ThueGTGT"] != null && dr["ThueGTGT"] != DBNull.Value)
					{
						item.ThueGTGT = Convert.ToDecimal(dr["ThueGTGT"]);
					}
					if (dr["NgayGuiHang"] != null && dr["NgayGuiHang"] != DBNull.Value)
					{
						item.NgayGuiHang = Convert.ToDateTime(dr["NgayGuiHang"]);
					}
					if (dr["LoaiThanhToan"] != null && dr["LoaiThanhToan"] != DBNull.Value)
					{
						item.LoaiThanhToan = Convert.ToString(dr["LoaiThanhToan"]);
					}
					if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
					{
						item.DiaChi = Convert.ToString(dr["DiaChi"]);
					}
					if (dr["DonViMuaHang"] != null && dr["DonViMuaHang"] != DBNull.Value)
					{
						item.DonViMuaHang = Convert.ToString(dr["DonViMuaHang"]);
					}
					if (dr["MaSoThue"] != null && dr["MaSoThue"] != DBNull.Value)
					{
						item.MaSoThue = Convert.ToString(dr["MaSoThue"]);
					}
					if (dr["NguoiMuaHang"] != null && dr["NguoiMuaHang"] != DBNull.Value)
					{
						item.NguoiMuaHang = Convert.ToString(dr["NguoiMuaHang"]);
					}
					if (dr["SoHoaDon"] != null && dr["SoHoaDon"] != DBNull.Value)
					{
						item.SoHoaDon = Convert.ToString(dr["SoHoaDon"]);
					}
					if (dr["NgayHoaDon"] != null && dr["NgayHoaDon"] != DBNull.Value)
					{
						item.NgayHoaDon = Convert.ToDateTime(dr["NgayHoaDon"]);
					}
					if (dr["NgayChungTu"] != null && dr["NgayChungTu"] != DBNull.Value)
					{
						item.NgayChungTu = Convert.ToDateTime(dr["NgayChungTu"]);
					}
					if (dr["SoChungTuThu"] != null && dr["SoChungTuThu"] != DBNull.Value)
					{
						item.SoChungTuThu = Convert.ToString(dr["SoChungTuThu"]);
					}
					if (dr["SoChungTuChi"] != null && dr["SoChungTuChi"] != DBNull.Value)
					{
						item.SoChungTuChi = Convert.ToString(dr["SoChungTuChi"]);
					}
					if (dr["ThangKT"] != null && dr["ThangKT"] != DBNull.Value)
					{
						item.ThangKT = Convert.ToDateTime(dr["ThangKT"]);
					}
					if (dr["ThueVAT"] != null && dr["ThueVAT"] != DBNull.Value)
					{
						item.ThueVAT = Convert.ToDecimal(dr["ThueVAT"]);
					}
					if (dr["TongPhiVanChuyen"] != null && dr["TongPhiVanChuyen"] != DBNull.Value)
					{
						item.TongPhiVanChuyen = Convert.ToDecimal(dr["TongPhiVanChuyen"]);
					}
					if (dr["TongPhiChuaVAT"] != null && dr["TongPhiChuaVAT"] != DBNull.Value)
					{
						item.TongPhiChuaVAT = Convert.ToDecimal(dr["TongPhiChuaVAT"]);
					}
					if (dr["SoChungTu"] != null && dr["SoChungTu"] != DBNull.Value)
					{
						item.SoChungTu = Convert.ToInt32(dr["SoChungTu"]);
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
					if (dr["DiaChiGui"] != null && dr["DiaChiGui"] != DBNull.Value)
					{
						item.DiaChiGui = Convert.ToString(dr["DiaChiGui"]);
					}
					if (dr["TenNguoiGui"] != null && dr["TenNguoiGui"] != DBNull.Value)
					{
						item.TenNguoiGui = Convert.ToString(dr["TenNguoiGui"]);
					}
					if (dr["SoDienThoaiGui"] != null && dr["SoDienThoaiGui"] != DBNull.Value)
					{
						item.SoDienThoaiGui = Convert.ToString(dr["SoDienThoaiGui"]);
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
		/// Lấy danh sách view_ExpChungTuCtReport từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_ExpChungTuCtReport> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpChungTuCtReport] A "+ condition,  parameters);
				List<view_ExpChungTuCtReport> items = new List<view_ExpChungTuCtReport>();
				view_ExpChungTuCtReport item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpChungTuCtReport();
					if (dr["FK_ExpChungTu"] != null && dr["FK_ExpChungTu"] != DBNull.Value)
					{
						item.FK_ExpChungTu = Convert.ToString(dr["FK_ExpChungTu"]);
					}
					if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
					{
						item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
					}
					if (dr["SoTienPhaiThu"] != null && dr["SoTienPhaiThu"] != DBNull.Value)
					{
						item.SoTienPhaiThu = Convert.ToDecimal(dr["SoTienPhaiThu"]);
					}
					if (dr["SoTienPhaiChi"] != null && dr["SoTienPhaiChi"] != DBNull.Value)
					{
						item.SoTienPhaiChi = Convert.ToDecimal(dr["SoTienPhaiChi"]);
					}
					if (dr["TenNguoiNhan"] != null && dr["TenNguoiNhan"] != DBNull.Value)
					{
						item.TenNguoiNhan = Convert.ToString(dr["TenNguoiNhan"]);
					}
					if (dr["SoDienThoaiNhan"] != null && dr["SoDienThoaiNhan"] != DBNull.Value)
					{
						item.SoDienThoaiNhan = Convert.ToString(dr["SoDienThoaiNhan"]);
					}
					if (dr["DiaChiNhan"] != null && dr["DiaChiNhan"] != DBNull.Value)
					{
						item.DiaChiNhan = Convert.ToString(dr["DiaChiNhan"]);
					}
					if (dr["SoTienThuHo"] != null && dr["SoTienThuHo"] != DBNull.Value)
					{
						item.SoTienThuHo = Convert.ToDecimal(dr["SoTienThuHo"]);
					}
					if (dr["CuocPhiVanChuyen"] != null && dr["CuocPhiVanChuyen"] != DBNull.Value)
					{
						item.CuocPhiVanChuyen = Convert.ToDecimal(dr["CuocPhiVanChuyen"]);
					}
					if (dr["TenHang"] != null && dr["TenHang"] != DBNull.Value)
					{
						item.TenHang = Convert.ToString(dr["TenHang"]);
					}
					if (dr["TrongLuong"] != null && dr["TrongLuong"] != DBNull.Value)
					{
						item.TrongLuong = Convert.ToDecimal(dr["TrongLuong"]);
					}
					if (dr["IsPhatHanh"] != null && dr["IsPhatHanh"] != DBNull.Value)
					{
						item.IsPhatHanh = Convert.ToBoolean(dr["IsPhatHanh"]);
					}
					if (dr["CuocPhiChuaGTGT"] != null && dr["CuocPhiChuaGTGT"] != DBNull.Value)
					{
						item.CuocPhiChuaGTGT = Convert.ToDecimal(dr["CuocPhiChuaGTGT"]);
					}
					if (dr["ThueGTGT"] != null && dr["ThueGTGT"] != DBNull.Value)
					{
						item.ThueGTGT = Convert.ToDecimal(dr["ThueGTGT"]);
					}
					if (dr["NgayGuiHang"] != null && dr["NgayGuiHang"] != DBNull.Value)
					{
						item.NgayGuiHang = Convert.ToDateTime(dr["NgayGuiHang"]);
					}
					if (dr["LoaiThanhToan"] != null && dr["LoaiThanhToan"] != DBNull.Value)
					{
						item.LoaiThanhToan = Convert.ToString(dr["LoaiThanhToan"]);
					}
					if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
					{
						item.DiaChi = Convert.ToString(dr["DiaChi"]);
					}
					if (dr["DonViMuaHang"] != null && dr["DonViMuaHang"] != DBNull.Value)
					{
						item.DonViMuaHang = Convert.ToString(dr["DonViMuaHang"]);
					}
					if (dr["MaSoThue"] != null && dr["MaSoThue"] != DBNull.Value)
					{
						item.MaSoThue = Convert.ToString(dr["MaSoThue"]);
					}
					if (dr["NguoiMuaHang"] != null && dr["NguoiMuaHang"] != DBNull.Value)
					{
						item.NguoiMuaHang = Convert.ToString(dr["NguoiMuaHang"]);
					}
					if (dr["SoHoaDon"] != null && dr["SoHoaDon"] != DBNull.Value)
					{
						item.SoHoaDon = Convert.ToString(dr["SoHoaDon"]);
					}
					if (dr["NgayHoaDon"] != null && dr["NgayHoaDon"] != DBNull.Value)
					{
						item.NgayHoaDon = Convert.ToDateTime(dr["NgayHoaDon"]);
					}
					if (dr["NgayChungTu"] != null && dr["NgayChungTu"] != DBNull.Value)
					{
						item.NgayChungTu = Convert.ToDateTime(dr["NgayChungTu"]);
					}
					if (dr["SoChungTuThu"] != null && dr["SoChungTuThu"] != DBNull.Value)
					{
						item.SoChungTuThu = Convert.ToString(dr["SoChungTuThu"]);
					}
					if (dr["SoChungTuChi"] != null && dr["SoChungTuChi"] != DBNull.Value)
					{
						item.SoChungTuChi = Convert.ToString(dr["SoChungTuChi"]);
					}
					if (dr["ThangKT"] != null && dr["ThangKT"] != DBNull.Value)
					{
						item.ThangKT = Convert.ToDateTime(dr["ThangKT"]);
					}
					if (dr["ThueVAT"] != null && dr["ThueVAT"] != DBNull.Value)
					{
						item.ThueVAT = Convert.ToDecimal(dr["ThueVAT"]);
					}
					if (dr["TongPhiVanChuyen"] != null && dr["TongPhiVanChuyen"] != DBNull.Value)
					{
						item.TongPhiVanChuyen = Convert.ToDecimal(dr["TongPhiVanChuyen"]);
					}
					if (dr["TongPhiChuaVAT"] != null && dr["TongPhiChuaVAT"] != DBNull.Value)
					{
						item.TongPhiChuaVAT = Convert.ToDecimal(dr["TongPhiChuaVAT"]);
					}
					if (dr["SoChungTu"] != null && dr["SoChungTu"] != DBNull.Value)
					{
						item.SoChungTu = Convert.ToInt32(dr["SoChungTu"]);
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
					if (dr["DiaChiGui"] != null && dr["DiaChiGui"] != DBNull.Value)
					{
						item.DiaChiGui = Convert.ToString(dr["DiaChiGui"]);
					}
					if (dr["TenNguoiGui"] != null && dr["TenNguoiGui"] != DBNull.Value)
					{
						item.TenNguoiGui = Convert.ToString(dr["TenNguoiGui"]);
					}
					if (dr["SoDienThoaiGui"] != null && dr["SoDienThoaiGui"] != DBNull.Value)
					{
						item.SoDienThoaiGui = Convert.ToString(dr["SoDienThoaiGui"]);
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

		public List<view_ExpChungTuCtReport> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpChungTuCtReport] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_ExpChungTuCtReport] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_ExpChungTuCtReport>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_ExpChungTuCtReport đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_ExpChungTuCtReport GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpChungTuCtReport] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_ExpChungTuCtReport item=new view_ExpChungTuCtReport();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_ExpChungTu"] != null && dr["FK_ExpChungTu"] != DBNull.Value)
						{
							item.FK_ExpChungTu = Convert.ToString(dr["FK_ExpChungTu"]);
						}
						if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
						{
							item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
						}
						if (dr["SoTienPhaiThu"] != null && dr["SoTienPhaiThu"] != DBNull.Value)
						{
							item.SoTienPhaiThu = Convert.ToDecimal(dr["SoTienPhaiThu"]);
						}
						if (dr["SoTienPhaiChi"] != null && dr["SoTienPhaiChi"] != DBNull.Value)
						{
							item.SoTienPhaiChi = Convert.ToDecimal(dr["SoTienPhaiChi"]);
						}
						if (dr["TenNguoiNhan"] != null && dr["TenNguoiNhan"] != DBNull.Value)
						{
							item.TenNguoiNhan = Convert.ToString(dr["TenNguoiNhan"]);
						}
						if (dr["SoDienThoaiNhan"] != null && dr["SoDienThoaiNhan"] != DBNull.Value)
						{
							item.SoDienThoaiNhan = Convert.ToString(dr["SoDienThoaiNhan"]);
						}
						if (dr["DiaChiNhan"] != null && dr["DiaChiNhan"] != DBNull.Value)
						{
							item.DiaChiNhan = Convert.ToString(dr["DiaChiNhan"]);
						}
						if (dr["SoTienThuHo"] != null && dr["SoTienThuHo"] != DBNull.Value)
						{
							item.SoTienThuHo = Convert.ToDecimal(dr["SoTienThuHo"]);
						}
						if (dr["CuocPhiVanChuyen"] != null && dr["CuocPhiVanChuyen"] != DBNull.Value)
						{
							item.CuocPhiVanChuyen = Convert.ToDecimal(dr["CuocPhiVanChuyen"]);
						}
						if (dr["TenHang"] != null && dr["TenHang"] != DBNull.Value)
						{
							item.TenHang = Convert.ToString(dr["TenHang"]);
						}
						if (dr["TrongLuong"] != null && dr["TrongLuong"] != DBNull.Value)
						{
							item.TrongLuong = Convert.ToDecimal(dr["TrongLuong"]);
						}
						if (dr["IsPhatHanh"] != null && dr["IsPhatHanh"] != DBNull.Value)
						{
							item.IsPhatHanh = Convert.ToBoolean(dr["IsPhatHanh"]);
						}
						if (dr["CuocPhiChuaGTGT"] != null && dr["CuocPhiChuaGTGT"] != DBNull.Value)
						{
							item.CuocPhiChuaGTGT = Convert.ToDecimal(dr["CuocPhiChuaGTGT"]);
						}
						if (dr["ThueGTGT"] != null && dr["ThueGTGT"] != DBNull.Value)
						{
							item.ThueGTGT = Convert.ToDecimal(dr["ThueGTGT"]);
						}
						if (dr["NgayGuiHang"] != null && dr["NgayGuiHang"] != DBNull.Value)
						{
							item.NgayGuiHang = Convert.ToDateTime(dr["NgayGuiHang"]);
						}
						if (dr["LoaiThanhToan"] != null && dr["LoaiThanhToan"] != DBNull.Value)
						{
							item.LoaiThanhToan = Convert.ToString(dr["LoaiThanhToan"]);
						}
						if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
						{
							item.DiaChi = Convert.ToString(dr["DiaChi"]);
						}
						if (dr["DonViMuaHang"] != null && dr["DonViMuaHang"] != DBNull.Value)
						{
							item.DonViMuaHang = Convert.ToString(dr["DonViMuaHang"]);
						}
						if (dr["MaSoThue"] != null && dr["MaSoThue"] != DBNull.Value)
						{
							item.MaSoThue = Convert.ToString(dr["MaSoThue"]);
						}
						if (dr["NguoiMuaHang"] != null && dr["NguoiMuaHang"] != DBNull.Value)
						{
							item.NguoiMuaHang = Convert.ToString(dr["NguoiMuaHang"]);
						}
						if (dr["SoHoaDon"] != null && dr["SoHoaDon"] != DBNull.Value)
						{
							item.SoHoaDon = Convert.ToString(dr["SoHoaDon"]);
						}
						if (dr["NgayHoaDon"] != null && dr["NgayHoaDon"] != DBNull.Value)
						{
							item.NgayHoaDon = Convert.ToDateTime(dr["NgayHoaDon"]);
						}
						if (dr["NgayChungTu"] != null && dr["NgayChungTu"] != DBNull.Value)
						{
							item.NgayChungTu = Convert.ToDateTime(dr["NgayChungTu"]);
						}
						if (dr["SoChungTuThu"] != null && dr["SoChungTuThu"] != DBNull.Value)
						{
							item.SoChungTuThu = Convert.ToString(dr["SoChungTuThu"]);
						}
						if (dr["SoChungTuChi"] != null && dr["SoChungTuChi"] != DBNull.Value)
						{
							item.SoChungTuChi = Convert.ToString(dr["SoChungTuChi"]);
						}
						if (dr["ThangKT"] != null && dr["ThangKT"] != DBNull.Value)
						{
							item.ThangKT = Convert.ToDateTime(dr["ThangKT"]);
						}
						if (dr["ThueVAT"] != null && dr["ThueVAT"] != DBNull.Value)
						{
							item.ThueVAT = Convert.ToDecimal(dr["ThueVAT"]);
						}
						if (dr["TongPhiVanChuyen"] != null && dr["TongPhiVanChuyen"] != DBNull.Value)
						{
							item.TongPhiVanChuyen = Convert.ToDecimal(dr["TongPhiVanChuyen"]);
						}
						if (dr["TongPhiChuaVAT"] != null && dr["TongPhiChuaVAT"] != DBNull.Value)
						{
							item.TongPhiChuaVAT = Convert.ToDecimal(dr["TongPhiChuaVAT"]);
						}
						if (dr["SoChungTu"] != null && dr["SoChungTu"] != DBNull.Value)
						{
							item.SoChungTu = Convert.ToInt32(dr["SoChungTu"]);
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
						if (dr["DiaChiGui"] != null && dr["DiaChiGui"] != DBNull.Value)
						{
							item.DiaChiGui = Convert.ToString(dr["DiaChiGui"]);
						}
						if (dr["TenNguoiGui"] != null && dr["TenNguoiGui"] != DBNull.Value)
						{
							item.TenNguoiGui = Convert.ToString(dr["TenNguoiGui"]);
						}
						if (dr["SoDienThoaiGui"] != null && dr["SoDienThoaiGui"] != DBNull.Value)
						{
							item.SoDienThoaiGui = Convert.ToString(dr["SoDienThoaiGui"]);
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

		public view_ExpChungTuCtReport GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpChungTuCtReport] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_ExpChungTuCtReport>(ds);
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
