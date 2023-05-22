using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpconsignment:IEXpconsignment
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpconsignment(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpConsignment từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignment]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpConsignment từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignment] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpConsignment từ Database
		/// </summary>
		public List<ExpConsignment> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignment]");
				List<ExpConsignment> items = new List<ExpConsignment>();
				ExpConsignment item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpConsignment();
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
		/// Lấy danh sách ExpConsignment từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpConsignment> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpConsignment] A "+ condition,  parameters);
				List<ExpConsignment> items = new List<ExpConsignment>();
				ExpConsignment item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpConsignment();
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
					items.Add(item);
				}
				return items;
			}
			catch
			{
				throw;
			}
		}

		public List<ExpConsignment> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpConsignment] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpConsignment] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpConsignment>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpConsignment từ Database
		/// </summary>
		public ExpConsignment GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignment] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpConsignment item=new ExpConsignment();
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

		/// <summary>
		/// Lấy một ExpConsignment đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpConsignment GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpConsignment] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpConsignment item=new ExpConsignment();
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

		public ExpConsignment GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpConsignment] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpConsignment>(ds);
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
		/// <summary>
		/// Thêm mới ExpConsignment vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpConsignment _ExpConsignment)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpConsignment](Id, MaDonHang, TenHang, SoLuong, TrongLuongGram, GiaTriTienHang, FK_YeuCauKhiGiao, YeuCauKhac, FK_NguoiGui, FK_NguoiNhan, FK_LoaiMatHang, FK_ExpProvider, FK_CachVanChuyen, FK_CachGiaoHang, FK_CachThanhToan, FK_CaLamViec, FK_NguoiThuHang, FK_ExpPostFrom, FK_ExpPostTo, FK_ExpStatus, CreateDate, CreateBy, CuocPhiChinh, CuocCongThem, PhuPhi, ThuHo, TongCuoc, FK_NhanVienPhat, HoTenNguoiKyNhan, NguoiGui, SoDienThoaiNguoiGui, FK_DVHCNguoiGui, SoNhaNguoiGui, DiaChiNguoiGui, NguoiNhan, SoDienThoaiNguoiNhan, FK_DVHCNguoiNhan, SoNhaNguoiNhan, DiaChiNguoiNhan, PrintNumber) VALUES(@Id, @MaDonHang, @TenHang, @SoLuong, @TrongLuongGram, @GiaTriTienHang, @FK_YeuCauKhiGiao, @YeuCauKhac, @FK_NguoiGui, @FK_NguoiNhan, @FK_LoaiMatHang, @FK_ExpProvider, @FK_CachVanChuyen, @FK_CachGiaoHang, @FK_CachThanhToan, @FK_CaLamViec, @FK_NguoiThuHang, @FK_ExpPostFrom, @FK_ExpPostTo, @FK_ExpStatus, @CreateDate, @CreateBy, @CuocPhiChinh, @CuocCongThem, @PhuPhi, @ThuHo, @TongCuoc, @FK_NhanVienPhat, @HoTenNguoiKyNhan, @NguoiGui, @SoDienThoaiNguoiGui, @FK_DVHCNguoiGui, @SoNhaNguoiGui, @DiaChiNguoiGui, @NguoiNhan, @SoDienThoaiNguoiNhan, @FK_DVHCNguoiNhan, @SoNhaNguoiNhan, @DiaChiNguoiNhan, @PrintNumber)", 
					"@Id",  _ExpConsignment.Id, 
					"@MaDonHang",  _ExpConsignment.MaDonHang, 
					"@TenHang",  _ExpConsignment.TenHang, 
					"@SoLuong",  _ExpConsignment.SoLuong, 
					"@TrongLuongGram",  _ExpConsignment.TrongLuongGram, 
					"@GiaTriTienHang",  _ExpConsignment.GiaTriTienHang, 
					"@FK_YeuCauKhiGiao",  _ExpConsignment.FK_YeuCauKhiGiao, 
					"@YeuCauKhac",  _ExpConsignment.YeuCauKhac, 
					"@FK_NguoiGui",  _ExpConsignment.FK_NguoiGui, 
					"@FK_NguoiNhan",  _ExpConsignment.FK_NguoiNhan, 
					"@FK_LoaiMatHang",  _ExpConsignment.FK_LoaiMatHang, 
					"@FK_ExpProvider",  _ExpConsignment.FK_ExpProvider, 
					"@FK_CachVanChuyen",  _ExpConsignment.FK_CachVanChuyen, 
					"@FK_CachGiaoHang",  _ExpConsignment.FK_CachGiaoHang, 
					"@FK_CachThanhToan",  _ExpConsignment.FK_CachThanhToan, 
					"@FK_CaLamViec",  _ExpConsignment.FK_CaLamViec, 
					"@FK_NguoiThuHang",  _ExpConsignment.FK_NguoiThuHang, 
					"@FK_ExpPostFrom",  _ExpConsignment.FK_ExpPostFrom, 
					"@FK_ExpPostTo",  _ExpConsignment.FK_ExpPostTo, 
					"@FK_ExpStatus",  _ExpConsignment.FK_ExpStatus, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpConsignment.CreateDate), 
					"@CreateBy",  _ExpConsignment.CreateBy, 
					"@CuocPhiChinh",  _ExpConsignment.CuocPhiChinh, 
					"@CuocCongThem",  _ExpConsignment.CuocCongThem, 
					"@PhuPhi",  _ExpConsignment.PhuPhi, 
					"@ThuHo",  _ExpConsignment.ThuHo, 
					"@TongCuoc",  _ExpConsignment.TongCuoc, 
					"@FK_NhanVienPhat",  _ExpConsignment.FK_NhanVienPhat, 
					"@HoTenNguoiKyNhan",  _ExpConsignment.HoTenNguoiKyNhan, 
					"@NguoiGui",  _ExpConsignment.NguoiGui, 
					"@SoDienThoaiNguoiGui",  _ExpConsignment.SoDienThoaiNguoiGui, 
					"@FK_DVHCNguoiGui",  _ExpConsignment.FK_DVHCNguoiGui, 
					"@SoNhaNguoiGui",  _ExpConsignment.SoNhaNguoiGui, 
					"@DiaChiNguoiGui",  _ExpConsignment.DiaChiNguoiGui, 
					"@NguoiNhan",  _ExpConsignment.NguoiNhan, 
					"@SoDienThoaiNguoiNhan",  _ExpConsignment.SoDienThoaiNguoiNhan, 
					"@FK_DVHCNguoiNhan",  _ExpConsignment.FK_DVHCNguoiNhan, 
					"@SoNhaNguoiNhan",  _ExpConsignment.SoNhaNguoiNhan, 
					"@DiaChiNguoiNhan",  _ExpConsignment.DiaChiNguoiNhan, 
					"@PrintNumber",  _ExpConsignment.PrintNumber);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpConsignment vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpConsignment> _ExpConsignments)
		{
			foreach (ExpConsignment item in _ExpConsignments)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpConsignment vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpConsignment _ExpConsignment, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpConsignment] SET Id=@Id, MaDonHang=@MaDonHang, TenHang=@TenHang, SoLuong=@SoLuong, TrongLuongGram=@TrongLuongGram, GiaTriTienHang=@GiaTriTienHang, FK_YeuCauKhiGiao=@FK_YeuCauKhiGiao, YeuCauKhac=@YeuCauKhac, FK_NguoiGui=@FK_NguoiGui, FK_NguoiNhan=@FK_NguoiNhan, FK_LoaiMatHang=@FK_LoaiMatHang, FK_ExpProvider=@FK_ExpProvider, FK_CachVanChuyen=@FK_CachVanChuyen, FK_CachGiaoHang=@FK_CachGiaoHang, FK_CachThanhToan=@FK_CachThanhToan, FK_CaLamViec=@FK_CaLamViec, FK_NguoiThuHang=@FK_NguoiThuHang, FK_ExpPostFrom=@FK_ExpPostFrom, FK_ExpPostTo=@FK_ExpPostTo, FK_ExpStatus=@FK_ExpStatus, CreateDate=@CreateDate, CreateBy=@CreateBy, CuocPhiChinh=@CuocPhiChinh, CuocCongThem=@CuocCongThem, PhuPhi=@PhuPhi, ThuHo=@ThuHo, TongCuoc=@TongCuoc, FK_NhanVienPhat=@FK_NhanVienPhat, HoTenNguoiKyNhan=@HoTenNguoiKyNhan, NguoiGui=@NguoiGui, SoDienThoaiNguoiGui=@SoDienThoaiNguoiGui, FK_DVHCNguoiGui=@FK_DVHCNguoiGui, SoNhaNguoiGui=@SoNhaNguoiGui, DiaChiNguoiGui=@DiaChiNguoiGui, NguoiNhan=@NguoiNhan, SoDienThoaiNguoiNhan=@SoDienThoaiNguoiNhan, FK_DVHCNguoiNhan=@FK_DVHCNguoiNhan, SoNhaNguoiNhan=@SoNhaNguoiNhan, DiaChiNguoiNhan=@DiaChiNguoiNhan, PrintNumber=@PrintNumber WHERE Id=@Id", 
					"@Id",  _ExpConsignment.Id, 
					"@MaDonHang",  _ExpConsignment.MaDonHang, 
					"@TenHang",  _ExpConsignment.TenHang, 
					"@SoLuong",  _ExpConsignment.SoLuong, 
					"@TrongLuongGram",  _ExpConsignment.TrongLuongGram, 
					"@GiaTriTienHang",  _ExpConsignment.GiaTriTienHang, 
					"@FK_YeuCauKhiGiao",  _ExpConsignment.FK_YeuCauKhiGiao, 
					"@YeuCauKhac",  _ExpConsignment.YeuCauKhac, 
					"@FK_NguoiGui",  _ExpConsignment.FK_NguoiGui, 
					"@FK_NguoiNhan",  _ExpConsignment.FK_NguoiNhan, 
					"@FK_LoaiMatHang",  _ExpConsignment.FK_LoaiMatHang, 
					"@FK_ExpProvider",  _ExpConsignment.FK_ExpProvider, 
					"@FK_CachVanChuyen",  _ExpConsignment.FK_CachVanChuyen, 
					"@FK_CachGiaoHang",  _ExpConsignment.FK_CachGiaoHang, 
					"@FK_CachThanhToan",  _ExpConsignment.FK_CachThanhToan, 
					"@FK_CaLamViec",  _ExpConsignment.FK_CaLamViec, 
					"@FK_NguoiThuHang",  _ExpConsignment.FK_NguoiThuHang, 
					"@FK_ExpPostFrom",  _ExpConsignment.FK_ExpPostFrom, 
					"@FK_ExpPostTo",  _ExpConsignment.FK_ExpPostTo, 
					"@FK_ExpStatus",  _ExpConsignment.FK_ExpStatus, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpConsignment.CreateDate), 
					"@CreateBy",  _ExpConsignment.CreateBy, 
					"@CuocPhiChinh",  _ExpConsignment.CuocPhiChinh, 
					"@CuocCongThem",  _ExpConsignment.CuocCongThem, 
					"@PhuPhi",  _ExpConsignment.PhuPhi, 
					"@ThuHo",  _ExpConsignment.ThuHo, 
					"@TongCuoc",  _ExpConsignment.TongCuoc, 
					"@FK_NhanVienPhat",  _ExpConsignment.FK_NhanVienPhat, 
					"@HoTenNguoiKyNhan",  _ExpConsignment.HoTenNguoiKyNhan, 
					"@NguoiGui",  _ExpConsignment.NguoiGui, 
					"@SoDienThoaiNguoiGui",  _ExpConsignment.SoDienThoaiNguoiGui, 
					"@FK_DVHCNguoiGui",  _ExpConsignment.FK_DVHCNguoiGui, 
					"@SoNhaNguoiGui",  _ExpConsignment.SoNhaNguoiGui, 
					"@DiaChiNguoiGui",  _ExpConsignment.DiaChiNguoiGui, 
					"@NguoiNhan",  _ExpConsignment.NguoiNhan, 
					"@SoDienThoaiNguoiNhan",  _ExpConsignment.SoDienThoaiNguoiNhan, 
					"@FK_DVHCNguoiNhan",  _ExpConsignment.FK_DVHCNguoiNhan, 
					"@SoNhaNguoiNhan",  _ExpConsignment.SoNhaNguoiNhan, 
					"@DiaChiNguoiNhan",  _ExpConsignment.DiaChiNguoiNhan, 
					"@PrintNumber",  _ExpConsignment.PrintNumber, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpConsignment vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpConsignment _ExpConsignment)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpConsignment] SET MaDonHang=@MaDonHang, TenHang=@TenHang, SoLuong=@SoLuong, TrongLuongGram=@TrongLuongGram, GiaTriTienHang=@GiaTriTienHang, FK_YeuCauKhiGiao=@FK_YeuCauKhiGiao, YeuCauKhac=@YeuCauKhac, FK_NguoiGui=@FK_NguoiGui, FK_NguoiNhan=@FK_NguoiNhan, FK_LoaiMatHang=@FK_LoaiMatHang, FK_ExpProvider=@FK_ExpProvider, FK_CachVanChuyen=@FK_CachVanChuyen, FK_CachGiaoHang=@FK_CachGiaoHang, FK_CachThanhToan=@FK_CachThanhToan, FK_CaLamViec=@FK_CaLamViec, FK_NguoiThuHang=@FK_NguoiThuHang, FK_ExpPostFrom=@FK_ExpPostFrom, FK_ExpPostTo=@FK_ExpPostTo, FK_ExpStatus=@FK_ExpStatus, CreateDate=@CreateDate, CreateBy=@CreateBy, CuocPhiChinh=@CuocPhiChinh, CuocCongThem=@CuocCongThem, PhuPhi=@PhuPhi, ThuHo=@ThuHo, TongCuoc=@TongCuoc, FK_NhanVienPhat=@FK_NhanVienPhat, HoTenNguoiKyNhan=@HoTenNguoiKyNhan, NguoiGui=@NguoiGui, SoDienThoaiNguoiGui=@SoDienThoaiNguoiGui, FK_DVHCNguoiGui=@FK_DVHCNguoiGui, SoNhaNguoiGui=@SoNhaNguoiGui, DiaChiNguoiGui=@DiaChiNguoiGui, NguoiNhan=@NguoiNhan, SoDienThoaiNguoiNhan=@SoDienThoaiNguoiNhan, FK_DVHCNguoiNhan=@FK_DVHCNguoiNhan, SoNhaNguoiNhan=@SoNhaNguoiNhan, DiaChiNguoiNhan=@DiaChiNguoiNhan, PrintNumber=@PrintNumber WHERE Id=@Id", 
					"@MaDonHang",  _ExpConsignment.MaDonHang, 
					"@TenHang",  _ExpConsignment.TenHang, 
					"@SoLuong",  _ExpConsignment.SoLuong, 
					"@TrongLuongGram",  _ExpConsignment.TrongLuongGram, 
					"@GiaTriTienHang",  _ExpConsignment.GiaTriTienHang, 
					"@FK_YeuCauKhiGiao",  _ExpConsignment.FK_YeuCauKhiGiao, 
					"@YeuCauKhac",  _ExpConsignment.YeuCauKhac, 
					"@FK_NguoiGui",  _ExpConsignment.FK_NguoiGui, 
					"@FK_NguoiNhan",  _ExpConsignment.FK_NguoiNhan, 
					"@FK_LoaiMatHang",  _ExpConsignment.FK_LoaiMatHang, 
					"@FK_ExpProvider",  _ExpConsignment.FK_ExpProvider, 
					"@FK_CachVanChuyen",  _ExpConsignment.FK_CachVanChuyen, 
					"@FK_CachGiaoHang",  _ExpConsignment.FK_CachGiaoHang, 
					"@FK_CachThanhToan",  _ExpConsignment.FK_CachThanhToan, 
					"@FK_CaLamViec",  _ExpConsignment.FK_CaLamViec, 
					"@FK_NguoiThuHang",  _ExpConsignment.FK_NguoiThuHang, 
					"@FK_ExpPostFrom",  _ExpConsignment.FK_ExpPostFrom, 
					"@FK_ExpPostTo",  _ExpConsignment.FK_ExpPostTo, 
					"@FK_ExpStatus",  _ExpConsignment.FK_ExpStatus, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpConsignment.CreateDate), 
					"@CreateBy",  _ExpConsignment.CreateBy, 
					"@CuocPhiChinh",  _ExpConsignment.CuocPhiChinh, 
					"@CuocCongThem",  _ExpConsignment.CuocCongThem, 
					"@PhuPhi",  _ExpConsignment.PhuPhi, 
					"@ThuHo",  _ExpConsignment.ThuHo, 
					"@TongCuoc",  _ExpConsignment.TongCuoc, 
					"@FK_NhanVienPhat",  _ExpConsignment.FK_NhanVienPhat, 
					"@HoTenNguoiKyNhan",  _ExpConsignment.HoTenNguoiKyNhan, 
					"@NguoiGui",  _ExpConsignment.NguoiGui, 
					"@SoDienThoaiNguoiGui",  _ExpConsignment.SoDienThoaiNguoiGui, 
					"@FK_DVHCNguoiGui",  _ExpConsignment.FK_DVHCNguoiGui, 
					"@SoNhaNguoiGui",  _ExpConsignment.SoNhaNguoiGui, 
					"@DiaChiNguoiGui",  _ExpConsignment.DiaChiNguoiGui, 
					"@NguoiNhan",  _ExpConsignment.NguoiNhan, 
					"@SoDienThoaiNguoiNhan",  _ExpConsignment.SoDienThoaiNguoiNhan, 
					"@FK_DVHCNguoiNhan",  _ExpConsignment.FK_DVHCNguoiNhan, 
					"@SoNhaNguoiNhan",  _ExpConsignment.SoNhaNguoiNhan, 
					"@DiaChiNguoiNhan",  _ExpConsignment.DiaChiNguoiNhan, 
					"@PrintNumber",  _ExpConsignment.PrintNumber, 
					"@Id", _ExpConsignment.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpConsignment vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpConsignment> _ExpConsignments)
		{
			foreach (ExpConsignment item in _ExpConsignments)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpConsignment vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpConsignment _ExpConsignment, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpConsignment] SET Id=@Id, MaDonHang=@MaDonHang, TenHang=@TenHang, SoLuong=@SoLuong, TrongLuongGram=@TrongLuongGram, GiaTriTienHang=@GiaTriTienHang, FK_YeuCauKhiGiao=@FK_YeuCauKhiGiao, YeuCauKhac=@YeuCauKhac, FK_NguoiGui=@FK_NguoiGui, FK_NguoiNhan=@FK_NguoiNhan, FK_LoaiMatHang=@FK_LoaiMatHang, FK_ExpProvider=@FK_ExpProvider, FK_CachVanChuyen=@FK_CachVanChuyen, FK_CachGiaoHang=@FK_CachGiaoHang, FK_CachThanhToan=@FK_CachThanhToan, FK_CaLamViec=@FK_CaLamViec, FK_NguoiThuHang=@FK_NguoiThuHang, FK_ExpPostFrom=@FK_ExpPostFrom, FK_ExpPostTo=@FK_ExpPostTo, FK_ExpStatus=@FK_ExpStatus, CreateDate=@CreateDate, CreateBy=@CreateBy, CuocPhiChinh=@CuocPhiChinh, CuocCongThem=@CuocCongThem, PhuPhi=@PhuPhi, ThuHo=@ThuHo, TongCuoc=@TongCuoc, FK_NhanVienPhat=@FK_NhanVienPhat, HoTenNguoiKyNhan=@HoTenNguoiKyNhan, NguoiGui=@NguoiGui, SoDienThoaiNguoiGui=@SoDienThoaiNguoiGui, FK_DVHCNguoiGui=@FK_DVHCNguoiGui, SoNhaNguoiGui=@SoNhaNguoiGui, DiaChiNguoiGui=@DiaChiNguoiGui, NguoiNhan=@NguoiNhan, SoDienThoaiNguoiNhan=@SoDienThoaiNguoiNhan, FK_DVHCNguoiNhan=@FK_DVHCNguoiNhan, SoNhaNguoiNhan=@SoNhaNguoiNhan, DiaChiNguoiNhan=@DiaChiNguoiNhan, PrintNumber=@PrintNumber "+ condition, 
					"@Id",  _ExpConsignment.Id, 
					"@MaDonHang",  _ExpConsignment.MaDonHang, 
					"@TenHang",  _ExpConsignment.TenHang, 
					"@SoLuong",  _ExpConsignment.SoLuong, 
					"@TrongLuongGram",  _ExpConsignment.TrongLuongGram, 
					"@GiaTriTienHang",  _ExpConsignment.GiaTriTienHang, 
					"@FK_YeuCauKhiGiao",  _ExpConsignment.FK_YeuCauKhiGiao, 
					"@YeuCauKhac",  _ExpConsignment.YeuCauKhac, 
					"@FK_NguoiGui",  _ExpConsignment.FK_NguoiGui, 
					"@FK_NguoiNhan",  _ExpConsignment.FK_NguoiNhan, 
					"@FK_LoaiMatHang",  _ExpConsignment.FK_LoaiMatHang, 
					"@FK_ExpProvider",  _ExpConsignment.FK_ExpProvider, 
					"@FK_CachVanChuyen",  _ExpConsignment.FK_CachVanChuyen, 
					"@FK_CachGiaoHang",  _ExpConsignment.FK_CachGiaoHang, 
					"@FK_CachThanhToan",  _ExpConsignment.FK_CachThanhToan, 
					"@FK_CaLamViec",  _ExpConsignment.FK_CaLamViec, 
					"@FK_NguoiThuHang",  _ExpConsignment.FK_NguoiThuHang, 
					"@FK_ExpPostFrom",  _ExpConsignment.FK_ExpPostFrom, 
					"@FK_ExpPostTo",  _ExpConsignment.FK_ExpPostTo, 
					"@FK_ExpStatus",  _ExpConsignment.FK_ExpStatus, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpConsignment.CreateDate), 
					"@CreateBy",  _ExpConsignment.CreateBy, 
					"@CuocPhiChinh",  _ExpConsignment.CuocPhiChinh, 
					"@CuocCongThem",  _ExpConsignment.CuocCongThem, 
					"@PhuPhi",  _ExpConsignment.PhuPhi, 
					"@ThuHo",  _ExpConsignment.ThuHo, 
					"@TongCuoc",  _ExpConsignment.TongCuoc, 
					"@FK_NhanVienPhat",  _ExpConsignment.FK_NhanVienPhat, 
					"@HoTenNguoiKyNhan",  _ExpConsignment.HoTenNguoiKyNhan, 
					"@NguoiGui",  _ExpConsignment.NguoiGui, 
					"@SoDienThoaiNguoiGui",  _ExpConsignment.SoDienThoaiNguoiGui, 
					"@FK_DVHCNguoiGui",  _ExpConsignment.FK_DVHCNguoiGui, 
					"@SoNhaNguoiGui",  _ExpConsignment.SoNhaNguoiGui, 
					"@DiaChiNguoiGui",  _ExpConsignment.DiaChiNguoiGui, 
					"@NguoiNhan",  _ExpConsignment.NguoiNhan, 
					"@SoDienThoaiNguoiNhan",  _ExpConsignment.SoDienThoaiNguoiNhan, 
					"@FK_DVHCNguoiNhan",  _ExpConsignment.FK_DVHCNguoiNhan, 
					"@SoNhaNguoiNhan",  _ExpConsignment.SoNhaNguoiNhan, 
					"@DiaChiNguoiNhan",  _ExpConsignment.DiaChiNguoiNhan, 
					"@PrintNumber",  _ExpConsignment.PrintNumber);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpConsignment trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpConsignment] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpConsignment trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpConsignment _ExpConsignment)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpConsignment] WHERE Id=@Id",
					"@Id", _ExpConsignment.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpConsignment trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpConsignment] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpConsignment trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpConsignment> _ExpConsignments)
		{
			foreach (ExpConsignment item in _ExpConsignments)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
