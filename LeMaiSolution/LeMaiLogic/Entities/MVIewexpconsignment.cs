using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewexpconsignment:IVIewexpconsignment
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewexpconsignment(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_ExpConsignment từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpConsignment]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_ExpConsignment từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpConsignment] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_ExpConsignment từ Database
		/// </summary>
		public List<view_ExpConsignment> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_ExpConsignment]");
				List<view_ExpConsignment> items = new List<view_ExpConsignment>();
				view_ExpConsignment item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpConsignment();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["MaDonHang"] != null && dr["MaDonHang"] != DBNull.Value)
					{
						item.MaDonHang = Convert.ToString(dr["MaDonHang"]);
					}
					if (dr["TenHang"] != null && dr["TenHang"] != DBNull.Value)
					{
						item.TenHang = Convert.ToString(dr["TenHang"]);
					}
					if (dr["SoLuong"] != null && dr["SoLuong"] != DBNull.Value)
					{
						item.SoLuong = Convert.ToInt32(dr["SoLuong"]);
					}
					if (dr["TrongLuongGram"] != null && dr["TrongLuongGram"] != DBNull.Value)
					{
						item.TrongLuongGram = Convert.ToInt32(dr["TrongLuongGram"]);
					}
					if (dr["GiaTriTienHang"] != null && dr["GiaTriTienHang"] != DBNull.Value)
					{
						item.GiaTriTienHang = Convert.ToInt32(dr["GiaTriTienHang"]);
					}
					if (dr["FK_YeuCauKhiGiao"] != null && dr["FK_YeuCauKhiGiao"] != DBNull.Value)
					{
						item.FK_YeuCauKhiGiao = Convert.ToString(dr["FK_YeuCauKhiGiao"]);
					}
					if (dr["YeuCauKhac"] != null && dr["YeuCauKhac"] != DBNull.Value)
					{
						item.YeuCauKhac = Convert.ToString(dr["YeuCauKhac"]);
					}
					if (dr["FK_NguoiGui"] != null && dr["FK_NguoiGui"] != DBNull.Value)
					{
						item.FK_NguoiGui = Convert.ToString(dr["FK_NguoiGui"]);
					}
					if (dr["FK_NguoiNhan"] != null && dr["FK_NguoiNhan"] != DBNull.Value)
					{
						item.FK_NguoiNhan = Convert.ToString(dr["FK_NguoiNhan"]);
					}
					if (dr["FK_LoaiMatHang"] != null && dr["FK_LoaiMatHang"] != DBNull.Value)
					{
						item.FK_LoaiMatHang = Convert.ToString(dr["FK_LoaiMatHang"]);
					}
					if (dr["FK_ExpProvider"] != null && dr["FK_ExpProvider"] != DBNull.Value)
					{
						item.FK_ExpProvider = Convert.ToString(dr["FK_ExpProvider"]);
					}
					if (dr["FK_CachVanChuyen"] != null && dr["FK_CachVanChuyen"] != DBNull.Value)
					{
						item.FK_CachVanChuyen = Convert.ToString(dr["FK_CachVanChuyen"]);
					}
					if (dr["FK_CachGiaoHang"] != null && dr["FK_CachGiaoHang"] != DBNull.Value)
					{
						item.FK_CachGiaoHang = Convert.ToString(dr["FK_CachGiaoHang"]);
					}
					if (dr["FK_CachThanhToan"] != null && dr["FK_CachThanhToan"] != DBNull.Value)
					{
						item.FK_CachThanhToan = Convert.ToString(dr["FK_CachThanhToan"]);
					}
					if (dr["FK_CaLamViec"] != null && dr["FK_CaLamViec"] != DBNull.Value)
					{
						item.FK_CaLamViec = Convert.ToString(dr["FK_CaLamViec"]);
					}
					if (dr["FK_NguoiThuHang"] != null && dr["FK_NguoiThuHang"] != DBNull.Value)
					{
						item.FK_NguoiThuHang = Convert.ToString(dr["FK_NguoiThuHang"]);
					}
					if (dr["FK_ExpPostFrom"] != null && dr["FK_ExpPostFrom"] != DBNull.Value)
					{
						item.FK_ExpPostFrom = Convert.ToString(dr["FK_ExpPostFrom"]);
					}
					if (dr["FK_ExpPostTo"] != null && dr["FK_ExpPostTo"] != DBNull.Value)
					{
						item.FK_ExpPostTo = Convert.ToString(dr["FK_ExpPostTo"]);
					}
					if (dr["FK_ExpStatus"] != null && dr["FK_ExpStatus"] != DBNull.Value)
					{
						item.FK_ExpStatus = Convert.ToString(dr["FK_ExpStatus"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CuocPhiChinh"] != null && dr["CuocPhiChinh"] != DBNull.Value)
					{
						item.CuocPhiChinh = Convert.ToInt32(dr["CuocPhiChinh"]);
					}
					if (dr["CuocCongThem"] != null && dr["CuocCongThem"] != DBNull.Value)
					{
						item.CuocCongThem = Convert.ToInt32(dr["CuocCongThem"]);
					}
					if (dr["PhuPhi"] != null && dr["PhuPhi"] != DBNull.Value)
					{
						item.PhuPhi = Convert.ToInt32(dr["PhuPhi"]);
					}
					if (dr["ThuHo"] != null && dr["ThuHo"] != DBNull.Value)
					{
						item.ThuHo = Convert.ToInt32(dr["ThuHo"]);
					}
					if (dr["TongCuoc"] != null && dr["TongCuoc"] != DBNull.Value)
					{
						item.TongCuoc = Convert.ToInt32(dr["TongCuoc"]);
					}
					if (dr["FK_NhanVienPhat"] != null && dr["FK_NhanVienPhat"] != DBNull.Value)
					{
						item.FK_NhanVienPhat = Convert.ToString(dr["FK_NhanVienPhat"]);
					}
					if (dr["HoTenNguoiKyNhan"] != null && dr["HoTenNguoiKyNhan"] != DBNull.Value)
					{
						item.HoTenNguoiKyNhan = Convert.ToString(dr["HoTenNguoiKyNhan"]);
					}
					if (dr["NguoiGui"] != null && dr["NguoiGui"] != DBNull.Value)
					{
						item.NguoiGui = Convert.ToString(dr["NguoiGui"]);
					}
					if (dr["SoDienThoaiNguoiGui"] != null && dr["SoDienThoaiNguoiGui"] != DBNull.Value)
					{
						item.SoDienThoaiNguoiGui = Convert.ToString(dr["SoDienThoaiNguoiGui"]);
					}
					if (dr["FK_DVHCNguoiGui"] != null && dr["FK_DVHCNguoiGui"] != DBNull.Value)
					{
						item.FK_DVHCNguoiGui = Convert.ToString(dr["FK_DVHCNguoiGui"]);
					}
					if (dr["SoNhaNguoiGui"] != null && dr["SoNhaNguoiGui"] != DBNull.Value)
					{
						item.SoNhaNguoiGui = Convert.ToString(dr["SoNhaNguoiGui"]);
					}
					if (dr["DiaChiNguoiGui"] != null && dr["DiaChiNguoiGui"] != DBNull.Value)
					{
						item.DiaChiNguoiGui = Convert.ToString(dr["DiaChiNguoiGui"]);
					}
					if (dr["NguoiNhan"] != null && dr["NguoiNhan"] != DBNull.Value)
					{
						item.NguoiNhan = Convert.ToString(dr["NguoiNhan"]);
					}
					if (dr["SoDienThoaiNguoiNhan"] != null && dr["SoDienThoaiNguoiNhan"] != DBNull.Value)
					{
						item.SoDienThoaiNguoiNhan = Convert.ToString(dr["SoDienThoaiNguoiNhan"]);
					}
					if (dr["FK_DVHCNguoiNhan"] != null && dr["FK_DVHCNguoiNhan"] != DBNull.Value)
					{
						item.FK_DVHCNguoiNhan = Convert.ToString(dr["FK_DVHCNguoiNhan"]);
					}
					if (dr["SoNhaNguoiNhan"] != null && dr["SoNhaNguoiNhan"] != DBNull.Value)
					{
						item.SoNhaNguoiNhan = Convert.ToString(dr["SoNhaNguoiNhan"]);
					}
					if (dr["DiaChiNguoiNhan"] != null && dr["DiaChiNguoiNhan"] != DBNull.Value)
					{
						item.DiaChiNguoiNhan = Convert.ToString(dr["DiaChiNguoiNhan"]);
					}
					if (dr["PrintNumber"] != null && dr["PrintNumber"] != DBNull.Value)
					{
						item.PrintNumber = Convert.ToInt32(dr["PrintNumber"]);
					}
					if (dr["YeuCauGiao"] != null && dr["YeuCauGiao"] != DBNull.Value)
					{
						item.YeuCauGiao = Convert.ToString(dr["YeuCauGiao"]);
					}
					if (dr["TenNhaCungCap"] != null && dr["TenNhaCungCap"] != DBNull.Value)
					{
						item.TenNhaCungCap = Convert.ToString(dr["TenNhaCungCap"]);
					}
					if (dr["TenDaiLy"] != null && dr["TenDaiLy"] != DBNull.Value)
					{
						item.TenDaiLy = Convert.ToString(dr["TenDaiLy"]);
					}
					if (dr["ToDaiLy"] != null && dr["ToDaiLy"] != DBNull.Value)
					{
						item.ToDaiLy = Convert.ToString(dr["ToDaiLy"]);
					}
					if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
					{
						item.StatusName = Convert.ToString(dr["StatusName"]);
					}
					if (dr["NguoiTaoDon"] != null && dr["NguoiTaoDon"] != DBNull.Value)
					{
						item.NguoiTaoDon = Convert.ToString(dr["NguoiTaoDon"]);
					}
					if (dr["NguoiPhat"] != null && dr["NguoiPhat"] != DBNull.Value)
					{
						item.NguoiPhat = Convert.ToString(dr["NguoiPhat"]);
					}
					if (dr["IdHuyenGui"] != null && dr["IdHuyenGui"] != DBNull.Value)
					{
						item.IdHuyenGui = Convert.ToString(dr["IdHuyenGui"]);
					}
					if (dr["IdTinhGui"] != null && dr["IdTinhGui"] != DBNull.Value)
					{
						item.IdTinhGui = Convert.ToString(dr["IdTinhGui"]);
					}
					if (dr["IdHuyenNhan"] != null && dr["IdHuyenNhan"] != DBNull.Value)
					{
						item.IdHuyenNhan = Convert.ToString(dr["IdHuyenNhan"]);
					}
					if (dr["IdTinhNhan"] != null && dr["IdTinhNhan"] != DBNull.Value)
					{
						item.IdTinhNhan = Convert.ToString(dr["IdTinhNhan"]);
					}
					if (dr["NguoiThuHang"] != null && dr["NguoiThuHang"] != DBNull.Value)
					{
						item.NguoiThuHang = Convert.ToString(dr["NguoiThuHang"]);
					}
					if (dr["TenCachGiao"] != null && dr["TenCachGiao"] != DBNull.Value)
					{
						item.TenCachGiao = Convert.ToString(dr["TenCachGiao"]);
					}
					if (dr["CachThanhToan"] != null && dr["CachThanhToan"] != DBNull.Value)
					{
						item.CachThanhToan = Convert.ToString(dr["CachThanhToan"]);
					}
					if (dr["TenCachVanChuyen"] != null && dr["TenCachVanChuyen"] != DBNull.Value)
					{
						item.TenCachVanChuyen = Convert.ToString(dr["TenCachVanChuyen"]);
					}
					if (dr["TenCaLamViec"] != null && dr["TenCaLamViec"] != DBNull.Value)
					{
						item.TenCaLamViec = Convert.ToString(dr["TenCaLamViec"]);
					}
					if (dr["TenLoaiMatHang"] != null && dr["TenLoaiMatHang"] != DBNull.Value)
					{
						item.TenLoaiMatHang = Convert.ToString(dr["TenLoaiMatHang"]);
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
		/// Lấy danh sách view_ExpConsignment từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_ExpConsignment> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpConsignment] A "+ condition,  parameters);
				List<view_ExpConsignment> items = new List<view_ExpConsignment>();
				view_ExpConsignment item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_ExpConsignment();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["MaDonHang"] != null && dr["MaDonHang"] != DBNull.Value)
					{
						item.MaDonHang = Convert.ToString(dr["MaDonHang"]);
					}
					if (dr["TenHang"] != null && dr["TenHang"] != DBNull.Value)
					{
						item.TenHang = Convert.ToString(dr["TenHang"]);
					}
					if (dr["SoLuong"] != null && dr["SoLuong"] != DBNull.Value)
					{
						item.SoLuong = Convert.ToInt32(dr["SoLuong"]);
					}
					if (dr["TrongLuongGram"] != null && dr["TrongLuongGram"] != DBNull.Value)
					{
						item.TrongLuongGram = Convert.ToInt32(dr["TrongLuongGram"]);
					}
					if (dr["GiaTriTienHang"] != null && dr["GiaTriTienHang"] != DBNull.Value)
					{
						item.GiaTriTienHang = Convert.ToInt32(dr["GiaTriTienHang"]);
					}
					if (dr["FK_YeuCauKhiGiao"] != null && dr["FK_YeuCauKhiGiao"] != DBNull.Value)
					{
						item.FK_YeuCauKhiGiao = Convert.ToString(dr["FK_YeuCauKhiGiao"]);
					}
					if (dr["YeuCauKhac"] != null && dr["YeuCauKhac"] != DBNull.Value)
					{
						item.YeuCauKhac = Convert.ToString(dr["YeuCauKhac"]);
					}
					if (dr["FK_NguoiGui"] != null && dr["FK_NguoiGui"] != DBNull.Value)
					{
						item.FK_NguoiGui = Convert.ToString(dr["FK_NguoiGui"]);
					}
					if (dr["FK_NguoiNhan"] != null && dr["FK_NguoiNhan"] != DBNull.Value)
					{
						item.FK_NguoiNhan = Convert.ToString(dr["FK_NguoiNhan"]);
					}
					if (dr["FK_LoaiMatHang"] != null && dr["FK_LoaiMatHang"] != DBNull.Value)
					{
						item.FK_LoaiMatHang = Convert.ToString(dr["FK_LoaiMatHang"]);
					}
					if (dr["FK_ExpProvider"] != null && dr["FK_ExpProvider"] != DBNull.Value)
					{
						item.FK_ExpProvider = Convert.ToString(dr["FK_ExpProvider"]);
					}
					if (dr["FK_CachVanChuyen"] != null && dr["FK_CachVanChuyen"] != DBNull.Value)
					{
						item.FK_CachVanChuyen = Convert.ToString(dr["FK_CachVanChuyen"]);
					}
					if (dr["FK_CachGiaoHang"] != null && dr["FK_CachGiaoHang"] != DBNull.Value)
					{
						item.FK_CachGiaoHang = Convert.ToString(dr["FK_CachGiaoHang"]);
					}
					if (dr["FK_CachThanhToan"] != null && dr["FK_CachThanhToan"] != DBNull.Value)
					{
						item.FK_CachThanhToan = Convert.ToString(dr["FK_CachThanhToan"]);
					}
					if (dr["FK_CaLamViec"] != null && dr["FK_CaLamViec"] != DBNull.Value)
					{
						item.FK_CaLamViec = Convert.ToString(dr["FK_CaLamViec"]);
					}
					if (dr["FK_NguoiThuHang"] != null && dr["FK_NguoiThuHang"] != DBNull.Value)
					{
						item.FK_NguoiThuHang = Convert.ToString(dr["FK_NguoiThuHang"]);
					}
					if (dr["FK_ExpPostFrom"] != null && dr["FK_ExpPostFrom"] != DBNull.Value)
					{
						item.FK_ExpPostFrom = Convert.ToString(dr["FK_ExpPostFrom"]);
					}
					if (dr["FK_ExpPostTo"] != null && dr["FK_ExpPostTo"] != DBNull.Value)
					{
						item.FK_ExpPostTo = Convert.ToString(dr["FK_ExpPostTo"]);
					}
					if (dr["FK_ExpStatus"] != null && dr["FK_ExpStatus"] != DBNull.Value)
					{
						item.FK_ExpStatus = Convert.ToString(dr["FK_ExpStatus"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CuocPhiChinh"] != null && dr["CuocPhiChinh"] != DBNull.Value)
					{
						item.CuocPhiChinh = Convert.ToInt32(dr["CuocPhiChinh"]);
					}
					if (dr["CuocCongThem"] != null && dr["CuocCongThem"] != DBNull.Value)
					{
						item.CuocCongThem = Convert.ToInt32(dr["CuocCongThem"]);
					}
					if (dr["PhuPhi"] != null && dr["PhuPhi"] != DBNull.Value)
					{
						item.PhuPhi = Convert.ToInt32(dr["PhuPhi"]);
					}
					if (dr["ThuHo"] != null && dr["ThuHo"] != DBNull.Value)
					{
						item.ThuHo = Convert.ToInt32(dr["ThuHo"]);
					}
					if (dr["TongCuoc"] != null && dr["TongCuoc"] != DBNull.Value)
					{
						item.TongCuoc = Convert.ToInt32(dr["TongCuoc"]);
					}
					if (dr["FK_NhanVienPhat"] != null && dr["FK_NhanVienPhat"] != DBNull.Value)
					{
						item.FK_NhanVienPhat = Convert.ToString(dr["FK_NhanVienPhat"]);
					}
					if (dr["HoTenNguoiKyNhan"] != null && dr["HoTenNguoiKyNhan"] != DBNull.Value)
					{
						item.HoTenNguoiKyNhan = Convert.ToString(dr["HoTenNguoiKyNhan"]);
					}
					if (dr["NguoiGui"] != null && dr["NguoiGui"] != DBNull.Value)
					{
						item.NguoiGui = Convert.ToString(dr["NguoiGui"]);
					}
					if (dr["SoDienThoaiNguoiGui"] != null && dr["SoDienThoaiNguoiGui"] != DBNull.Value)
					{
						item.SoDienThoaiNguoiGui = Convert.ToString(dr["SoDienThoaiNguoiGui"]);
					}
					if (dr["FK_DVHCNguoiGui"] != null && dr["FK_DVHCNguoiGui"] != DBNull.Value)
					{
						item.FK_DVHCNguoiGui = Convert.ToString(dr["FK_DVHCNguoiGui"]);
					}
					if (dr["SoNhaNguoiGui"] != null && dr["SoNhaNguoiGui"] != DBNull.Value)
					{
						item.SoNhaNguoiGui = Convert.ToString(dr["SoNhaNguoiGui"]);
					}
					if (dr["DiaChiNguoiGui"] != null && dr["DiaChiNguoiGui"] != DBNull.Value)
					{
						item.DiaChiNguoiGui = Convert.ToString(dr["DiaChiNguoiGui"]);
					}
					if (dr["NguoiNhan"] != null && dr["NguoiNhan"] != DBNull.Value)
					{
						item.NguoiNhan = Convert.ToString(dr["NguoiNhan"]);
					}
					if (dr["SoDienThoaiNguoiNhan"] != null && dr["SoDienThoaiNguoiNhan"] != DBNull.Value)
					{
						item.SoDienThoaiNguoiNhan = Convert.ToString(dr["SoDienThoaiNguoiNhan"]);
					}
					if (dr["FK_DVHCNguoiNhan"] != null && dr["FK_DVHCNguoiNhan"] != DBNull.Value)
					{
						item.FK_DVHCNguoiNhan = Convert.ToString(dr["FK_DVHCNguoiNhan"]);
					}
					if (dr["SoNhaNguoiNhan"] != null && dr["SoNhaNguoiNhan"] != DBNull.Value)
					{
						item.SoNhaNguoiNhan = Convert.ToString(dr["SoNhaNguoiNhan"]);
					}
					if (dr["DiaChiNguoiNhan"] != null && dr["DiaChiNguoiNhan"] != DBNull.Value)
					{
						item.DiaChiNguoiNhan = Convert.ToString(dr["DiaChiNguoiNhan"]);
					}
					if (dr["PrintNumber"] != null && dr["PrintNumber"] != DBNull.Value)
					{
						item.PrintNumber = Convert.ToInt32(dr["PrintNumber"]);
					}
					if (dr["YeuCauGiao"] != null && dr["YeuCauGiao"] != DBNull.Value)
					{
						item.YeuCauGiao = Convert.ToString(dr["YeuCauGiao"]);
					}
					if (dr["TenNhaCungCap"] != null && dr["TenNhaCungCap"] != DBNull.Value)
					{
						item.TenNhaCungCap = Convert.ToString(dr["TenNhaCungCap"]);
					}
					if (dr["TenDaiLy"] != null && dr["TenDaiLy"] != DBNull.Value)
					{
						item.TenDaiLy = Convert.ToString(dr["TenDaiLy"]);
					}
					if (dr["ToDaiLy"] != null && dr["ToDaiLy"] != DBNull.Value)
					{
						item.ToDaiLy = Convert.ToString(dr["ToDaiLy"]);
					}
					if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
					{
						item.StatusName = Convert.ToString(dr["StatusName"]);
					}
					if (dr["NguoiTaoDon"] != null && dr["NguoiTaoDon"] != DBNull.Value)
					{
						item.NguoiTaoDon = Convert.ToString(dr["NguoiTaoDon"]);
					}
					if (dr["NguoiPhat"] != null && dr["NguoiPhat"] != DBNull.Value)
					{
						item.NguoiPhat = Convert.ToString(dr["NguoiPhat"]);
					}
					if (dr["IdHuyenGui"] != null && dr["IdHuyenGui"] != DBNull.Value)
					{
						item.IdHuyenGui = Convert.ToString(dr["IdHuyenGui"]);
					}
					if (dr["IdTinhGui"] != null && dr["IdTinhGui"] != DBNull.Value)
					{
						item.IdTinhGui = Convert.ToString(dr["IdTinhGui"]);
					}
					if (dr["IdHuyenNhan"] != null && dr["IdHuyenNhan"] != DBNull.Value)
					{
						item.IdHuyenNhan = Convert.ToString(dr["IdHuyenNhan"]);
					}
					if (dr["IdTinhNhan"] != null && dr["IdTinhNhan"] != DBNull.Value)
					{
						item.IdTinhNhan = Convert.ToString(dr["IdTinhNhan"]);
					}
					if (dr["NguoiThuHang"] != null && dr["NguoiThuHang"] != DBNull.Value)
					{
						item.NguoiThuHang = Convert.ToString(dr["NguoiThuHang"]);
					}
					if (dr["TenCachGiao"] != null && dr["TenCachGiao"] != DBNull.Value)
					{
						item.TenCachGiao = Convert.ToString(dr["TenCachGiao"]);
					}
					if (dr["CachThanhToan"] != null && dr["CachThanhToan"] != DBNull.Value)
					{
						item.CachThanhToan = Convert.ToString(dr["CachThanhToan"]);
					}
					if (dr["TenCachVanChuyen"] != null && dr["TenCachVanChuyen"] != DBNull.Value)
					{
						item.TenCachVanChuyen = Convert.ToString(dr["TenCachVanChuyen"]);
					}
					if (dr["TenCaLamViec"] != null && dr["TenCaLamViec"] != DBNull.Value)
					{
						item.TenCaLamViec = Convert.ToString(dr["TenCaLamViec"]);
					}
					if (dr["TenLoaiMatHang"] != null && dr["TenLoaiMatHang"] != DBNull.Value)
					{
						item.TenLoaiMatHang = Convert.ToString(dr["TenLoaiMatHang"]);
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

		public List<view_ExpConsignment> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpConsignment] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_ExpConsignment] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_ExpConsignment>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_ExpConsignment đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_ExpConsignment GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_ExpConsignment] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_ExpConsignment item=new view_ExpConsignment();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["MaDonHang"] != null && dr["MaDonHang"] != DBNull.Value)
						{
							item.MaDonHang = Convert.ToString(dr["MaDonHang"]);
						}
						if (dr["TenHang"] != null && dr["TenHang"] != DBNull.Value)
						{
							item.TenHang = Convert.ToString(dr["TenHang"]);
						}
						if (dr["SoLuong"] != null && dr["SoLuong"] != DBNull.Value)
						{
							item.SoLuong = Convert.ToInt32(dr["SoLuong"]);
						}
						if (dr["TrongLuongGram"] != null && dr["TrongLuongGram"] != DBNull.Value)
						{
							item.TrongLuongGram = Convert.ToInt32(dr["TrongLuongGram"]);
						}
						if (dr["GiaTriTienHang"] != null && dr["GiaTriTienHang"] != DBNull.Value)
						{
							item.GiaTriTienHang = Convert.ToInt32(dr["GiaTriTienHang"]);
						}
						if (dr["FK_YeuCauKhiGiao"] != null && dr["FK_YeuCauKhiGiao"] != DBNull.Value)
						{
							item.FK_YeuCauKhiGiao = Convert.ToString(dr["FK_YeuCauKhiGiao"]);
						}
						if (dr["YeuCauKhac"] != null && dr["YeuCauKhac"] != DBNull.Value)
						{
							item.YeuCauKhac = Convert.ToString(dr["YeuCauKhac"]);
						}
						if (dr["FK_NguoiGui"] != null && dr["FK_NguoiGui"] != DBNull.Value)
						{
							item.FK_NguoiGui = Convert.ToString(dr["FK_NguoiGui"]);
						}
						if (dr["FK_NguoiNhan"] != null && dr["FK_NguoiNhan"] != DBNull.Value)
						{
							item.FK_NguoiNhan = Convert.ToString(dr["FK_NguoiNhan"]);
						}
						if (dr["FK_LoaiMatHang"] != null && dr["FK_LoaiMatHang"] != DBNull.Value)
						{
							item.FK_LoaiMatHang = Convert.ToString(dr["FK_LoaiMatHang"]);
						}
						if (dr["FK_ExpProvider"] != null && dr["FK_ExpProvider"] != DBNull.Value)
						{
							item.FK_ExpProvider = Convert.ToString(dr["FK_ExpProvider"]);
						}
						if (dr["FK_CachVanChuyen"] != null && dr["FK_CachVanChuyen"] != DBNull.Value)
						{
							item.FK_CachVanChuyen = Convert.ToString(dr["FK_CachVanChuyen"]);
						}
						if (dr["FK_CachGiaoHang"] != null && dr["FK_CachGiaoHang"] != DBNull.Value)
						{
							item.FK_CachGiaoHang = Convert.ToString(dr["FK_CachGiaoHang"]);
						}
						if (dr["FK_CachThanhToan"] != null && dr["FK_CachThanhToan"] != DBNull.Value)
						{
							item.FK_CachThanhToan = Convert.ToString(dr["FK_CachThanhToan"]);
						}
						if (dr["FK_CaLamViec"] != null && dr["FK_CaLamViec"] != DBNull.Value)
						{
							item.FK_CaLamViec = Convert.ToString(dr["FK_CaLamViec"]);
						}
						if (dr["FK_NguoiThuHang"] != null && dr["FK_NguoiThuHang"] != DBNull.Value)
						{
							item.FK_NguoiThuHang = Convert.ToString(dr["FK_NguoiThuHang"]);
						}
						if (dr["FK_ExpPostFrom"] != null && dr["FK_ExpPostFrom"] != DBNull.Value)
						{
							item.FK_ExpPostFrom = Convert.ToString(dr["FK_ExpPostFrom"]);
						}
						if (dr["FK_ExpPostTo"] != null && dr["FK_ExpPostTo"] != DBNull.Value)
						{
							item.FK_ExpPostTo = Convert.ToString(dr["FK_ExpPostTo"]);
						}
						if (dr["FK_ExpStatus"] != null && dr["FK_ExpStatus"] != DBNull.Value)
						{
							item.FK_ExpStatus = Convert.ToString(dr["FK_ExpStatus"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["CuocPhiChinh"] != null && dr["CuocPhiChinh"] != DBNull.Value)
						{
							item.CuocPhiChinh = Convert.ToInt32(dr["CuocPhiChinh"]);
						}
						if (dr["CuocCongThem"] != null && dr["CuocCongThem"] != DBNull.Value)
						{
							item.CuocCongThem = Convert.ToInt32(dr["CuocCongThem"]);
						}
						if (dr["PhuPhi"] != null && dr["PhuPhi"] != DBNull.Value)
						{
							item.PhuPhi = Convert.ToInt32(dr["PhuPhi"]);
						}
						if (dr["ThuHo"] != null && dr["ThuHo"] != DBNull.Value)
						{
							item.ThuHo = Convert.ToInt32(dr["ThuHo"]);
						}
						if (dr["TongCuoc"] != null && dr["TongCuoc"] != DBNull.Value)
						{
							item.TongCuoc = Convert.ToInt32(dr["TongCuoc"]);
						}
						if (dr["FK_NhanVienPhat"] != null && dr["FK_NhanVienPhat"] != DBNull.Value)
						{
							item.FK_NhanVienPhat = Convert.ToString(dr["FK_NhanVienPhat"]);
						}
						if (dr["HoTenNguoiKyNhan"] != null && dr["HoTenNguoiKyNhan"] != DBNull.Value)
						{
							item.HoTenNguoiKyNhan = Convert.ToString(dr["HoTenNguoiKyNhan"]);
						}
						if (dr["NguoiGui"] != null && dr["NguoiGui"] != DBNull.Value)
						{
							item.NguoiGui = Convert.ToString(dr["NguoiGui"]);
						}
						if (dr["SoDienThoaiNguoiGui"] != null && dr["SoDienThoaiNguoiGui"] != DBNull.Value)
						{
							item.SoDienThoaiNguoiGui = Convert.ToString(dr["SoDienThoaiNguoiGui"]);
						}
						if (dr["FK_DVHCNguoiGui"] != null && dr["FK_DVHCNguoiGui"] != DBNull.Value)
						{
							item.FK_DVHCNguoiGui = Convert.ToString(dr["FK_DVHCNguoiGui"]);
						}
						if (dr["SoNhaNguoiGui"] != null && dr["SoNhaNguoiGui"] != DBNull.Value)
						{
							item.SoNhaNguoiGui = Convert.ToString(dr["SoNhaNguoiGui"]);
						}
						if (dr["DiaChiNguoiGui"] != null && dr["DiaChiNguoiGui"] != DBNull.Value)
						{
							item.DiaChiNguoiGui = Convert.ToString(dr["DiaChiNguoiGui"]);
						}
						if (dr["NguoiNhan"] != null && dr["NguoiNhan"] != DBNull.Value)
						{
							item.NguoiNhan = Convert.ToString(dr["NguoiNhan"]);
						}
						if (dr["SoDienThoaiNguoiNhan"] != null && dr["SoDienThoaiNguoiNhan"] != DBNull.Value)
						{
							item.SoDienThoaiNguoiNhan = Convert.ToString(dr["SoDienThoaiNguoiNhan"]);
						}
						if (dr["FK_DVHCNguoiNhan"] != null && dr["FK_DVHCNguoiNhan"] != DBNull.Value)
						{
							item.FK_DVHCNguoiNhan = Convert.ToString(dr["FK_DVHCNguoiNhan"]);
						}
						if (dr["SoNhaNguoiNhan"] != null && dr["SoNhaNguoiNhan"] != DBNull.Value)
						{
							item.SoNhaNguoiNhan = Convert.ToString(dr["SoNhaNguoiNhan"]);
						}
						if (dr["DiaChiNguoiNhan"] != null && dr["DiaChiNguoiNhan"] != DBNull.Value)
						{
							item.DiaChiNguoiNhan = Convert.ToString(dr["DiaChiNguoiNhan"]);
						}
						if (dr["PrintNumber"] != null && dr["PrintNumber"] != DBNull.Value)
						{
							item.PrintNumber = Convert.ToInt32(dr["PrintNumber"]);
						}
						if (dr["YeuCauGiao"] != null && dr["YeuCauGiao"] != DBNull.Value)
						{
							item.YeuCauGiao = Convert.ToString(dr["YeuCauGiao"]);
						}
						if (dr["TenNhaCungCap"] != null && dr["TenNhaCungCap"] != DBNull.Value)
						{
							item.TenNhaCungCap = Convert.ToString(dr["TenNhaCungCap"]);
						}
						if (dr["TenDaiLy"] != null && dr["TenDaiLy"] != DBNull.Value)
						{
							item.TenDaiLy = Convert.ToString(dr["TenDaiLy"]);
						}
						if (dr["ToDaiLy"] != null && dr["ToDaiLy"] != DBNull.Value)
						{
							item.ToDaiLy = Convert.ToString(dr["ToDaiLy"]);
						}
						if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
						{
							item.StatusName = Convert.ToString(dr["StatusName"]);
						}
						if (dr["NguoiTaoDon"] != null && dr["NguoiTaoDon"] != DBNull.Value)
						{
							item.NguoiTaoDon = Convert.ToString(dr["NguoiTaoDon"]);
						}
						if (dr["NguoiPhat"] != null && dr["NguoiPhat"] != DBNull.Value)
						{
							item.NguoiPhat = Convert.ToString(dr["NguoiPhat"]);
						}
						if (dr["IdHuyenGui"] != null && dr["IdHuyenGui"] != DBNull.Value)
						{
							item.IdHuyenGui = Convert.ToString(dr["IdHuyenGui"]);
						}
						if (dr["IdTinhGui"] != null && dr["IdTinhGui"] != DBNull.Value)
						{
							item.IdTinhGui = Convert.ToString(dr["IdTinhGui"]);
						}
						if (dr["IdHuyenNhan"] != null && dr["IdHuyenNhan"] != DBNull.Value)
						{
							item.IdHuyenNhan = Convert.ToString(dr["IdHuyenNhan"]);
						}
						if (dr["IdTinhNhan"] != null && dr["IdTinhNhan"] != DBNull.Value)
						{
							item.IdTinhNhan = Convert.ToString(dr["IdTinhNhan"]);
						}
						if (dr["NguoiThuHang"] != null && dr["NguoiThuHang"] != DBNull.Value)
						{
							item.NguoiThuHang = Convert.ToString(dr["NguoiThuHang"]);
						}
						if (dr["TenCachGiao"] != null && dr["TenCachGiao"] != DBNull.Value)
						{
							item.TenCachGiao = Convert.ToString(dr["TenCachGiao"]);
						}
						if (dr["CachThanhToan"] != null && dr["CachThanhToan"] != DBNull.Value)
						{
							item.CachThanhToan = Convert.ToString(dr["CachThanhToan"]);
						}
						if (dr["TenCachVanChuyen"] != null && dr["TenCachVanChuyen"] != DBNull.Value)
						{
							item.TenCachVanChuyen = Convert.ToString(dr["TenCachVanChuyen"]);
						}
						if (dr["TenCaLamViec"] != null && dr["TenCaLamViec"] != DBNull.Value)
						{
							item.TenCaLamViec = Convert.ToString(dr["TenCaLamViec"]);
						}
						if (dr["TenLoaiMatHang"] != null && dr["TenLoaiMatHang"] != DBNull.Value)
						{
							item.TenLoaiMatHang = Convert.ToString(dr["TenLoaiMatHang"]);
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

		public view_ExpConsignment GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_ExpConsignment] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_ExpConsignment>(ds);
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
