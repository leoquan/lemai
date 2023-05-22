using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpdoisoatchitietct:IGExpdoisoatchitietct
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpdoisoatchitietct(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpDoiSoatChiTietCt từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDoiSoatChiTietCt]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpDoiSoatChiTietCt từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDoiSoatChiTietCt] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpDoiSoatChiTietCt từ Database
		/// </summary>
		public List<GExpDoiSoatChiTietCt> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDoiSoatChiTietCt]");
				List<GExpDoiSoatChiTietCt> items = new List<GExpDoiSoatChiTietCt>();
				GExpDoiSoatChiTietCt item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpDoiSoatChiTietCt();
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["FK_DoiSoatChiTiet"] != null && dr["FK_DoiSoatChiTiet"] != DBNull.Value)
					{
						item.FK_DoiSoatChiTiet = Convert.ToString(dr["FK_DoiSoatChiTiet"]);
					}
					if (dr["NguoiGui"] != null && dr["NguoiGui"] != DBNull.Value)
					{
						item.NguoiGui = Convert.ToString(dr["NguoiGui"]);
					}
					if (dr["NguoiNhan"] != null && dr["NguoiNhan"] != DBNull.Value)
					{
						item.NguoiNhan = Convert.ToString(dr["NguoiNhan"]);
					}
					if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
					{
						item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
					}
					if (dr["NoiDen"] != null && dr["NoiDen"] != DBNull.Value)
					{
						item.NoiDen = Convert.ToString(dr["NoiDen"]);
					}
					if (dr["ThuHo"] != null && dr["ThuHo"] != DBNull.Value)
					{
						item.ThuHo = Convert.ToDecimal(dr["ThuHo"]);
					}
					if (dr["TrongLuong"] != null && dr["TrongLuong"] != DBNull.Value)
					{
						item.TrongLuong = Convert.ToDecimal(dr["TrongLuong"]);
					}
					if (dr["TrongLuongKH"] != null && dr["TrongLuongKH"] != DBNull.Value)
					{
						item.TrongLuongKH = Convert.ToDecimal(dr["TrongLuongKH"]);
					}
					if (dr["NgayGuiHang"] != null && dr["NgayGuiHang"] != DBNull.Value)
					{
						item.NgayGuiHang = Convert.ToString(dr["NgayGuiHang"]);
					}
					if (dr["NgayKyNhan"] != null && dr["NgayKyNhan"] != DBNull.Value)
					{
						item.NgayKyNhan = Convert.ToString(dr["NgayKyNhan"]);
					}
					if (dr["CuocVanChuyen"] != null && dr["CuocVanChuyen"] != DBNull.Value)
					{
						item.CuocVanChuyen = Convert.ToDecimal(dr["CuocVanChuyen"]);
					}
					if (dr["LoaiThanhToan"] != null && dr["LoaiThanhToan"] != DBNull.Value)
					{
						item.LoaiThanhToan = Convert.ToString(dr["LoaiThanhToan"]);
					}
					if (dr["LoaiKien"] != null && dr["LoaiKien"] != DBNull.Value)
					{
						item.LoaiKien = Convert.ToString(dr["LoaiKien"]);
					}
					if (dr["SoTienThanhToan"] != null && dr["SoTienThanhToan"] != DBNull.Value)
					{
						item.SoTienThanhToan = Convert.ToDecimal(dr["SoTienThanhToan"]);
					}
					if (dr["GhiChu"] != null && dr["GhiChu"] != DBNull.Value)
					{
						item.GhiChu = Convert.ToString(dr["GhiChu"]);
					}
					if (dr["IsHoanThanh"] != null && dr["IsHoanThanh"] != DBNull.Value)
					{
						item.IsHoanThanh = Convert.ToBoolean(dr["IsHoanThanh"]);
					}
					if (dr["Status"] != null && dr["Status"] != DBNull.Value)
					{
						item.Status = Convert.ToInt32(dr["Status"]);
					}
					if (dr["PhiVC"] != null && dr["PhiVC"] != DBNull.Value)
					{
						item.PhiVC = Convert.ToDecimal(dr["PhiVC"]);
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
		/// Lấy danh sách GExpDoiSoatChiTietCt từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpDoiSoatChiTietCt> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpDoiSoatChiTietCt] A "+ condition,  parameters);
				List<GExpDoiSoatChiTietCt> items = new List<GExpDoiSoatChiTietCt>();
				GExpDoiSoatChiTietCt item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpDoiSoatChiTietCt();
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["FK_DoiSoatChiTiet"] != null && dr["FK_DoiSoatChiTiet"] != DBNull.Value)
					{
						item.FK_DoiSoatChiTiet = Convert.ToString(dr["FK_DoiSoatChiTiet"]);
					}
					if (dr["NguoiGui"] != null && dr["NguoiGui"] != DBNull.Value)
					{
						item.NguoiGui = Convert.ToString(dr["NguoiGui"]);
					}
					if (dr["NguoiNhan"] != null && dr["NguoiNhan"] != DBNull.Value)
					{
						item.NguoiNhan = Convert.ToString(dr["NguoiNhan"]);
					}
					if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
					{
						item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
					}
					if (dr["NoiDen"] != null && dr["NoiDen"] != DBNull.Value)
					{
						item.NoiDen = Convert.ToString(dr["NoiDen"]);
					}
					if (dr["ThuHo"] != null && dr["ThuHo"] != DBNull.Value)
					{
						item.ThuHo = Convert.ToDecimal(dr["ThuHo"]);
					}
					if (dr["TrongLuong"] != null && dr["TrongLuong"] != DBNull.Value)
					{
						item.TrongLuong = Convert.ToDecimal(dr["TrongLuong"]);
					}
					if (dr["TrongLuongKH"] != null && dr["TrongLuongKH"] != DBNull.Value)
					{
						item.TrongLuongKH = Convert.ToDecimal(dr["TrongLuongKH"]);
					}
					if (dr["NgayGuiHang"] != null && dr["NgayGuiHang"] != DBNull.Value)
					{
						item.NgayGuiHang = Convert.ToString(dr["NgayGuiHang"]);
					}
					if (dr["NgayKyNhan"] != null && dr["NgayKyNhan"] != DBNull.Value)
					{
						item.NgayKyNhan = Convert.ToString(dr["NgayKyNhan"]);
					}
					if (dr["CuocVanChuyen"] != null && dr["CuocVanChuyen"] != DBNull.Value)
					{
						item.CuocVanChuyen = Convert.ToDecimal(dr["CuocVanChuyen"]);
					}
					if (dr["LoaiThanhToan"] != null && dr["LoaiThanhToan"] != DBNull.Value)
					{
						item.LoaiThanhToan = Convert.ToString(dr["LoaiThanhToan"]);
					}
					if (dr["LoaiKien"] != null && dr["LoaiKien"] != DBNull.Value)
					{
						item.LoaiKien = Convert.ToString(dr["LoaiKien"]);
					}
					if (dr["SoTienThanhToan"] != null && dr["SoTienThanhToan"] != DBNull.Value)
					{
						item.SoTienThanhToan = Convert.ToDecimal(dr["SoTienThanhToan"]);
					}
					if (dr["GhiChu"] != null && dr["GhiChu"] != DBNull.Value)
					{
						item.GhiChu = Convert.ToString(dr["GhiChu"]);
					}
					if (dr["IsHoanThanh"] != null && dr["IsHoanThanh"] != DBNull.Value)
					{
						item.IsHoanThanh = Convert.ToBoolean(dr["IsHoanThanh"]);
					}
					if (dr["Status"] != null && dr["Status"] != DBNull.Value)
					{
						item.Status = Convert.ToInt32(dr["Status"]);
					}
					if (dr["PhiVC"] != null && dr["PhiVC"] != DBNull.Value)
					{
						item.PhiVC = Convert.ToDecimal(dr["PhiVC"]);
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

		public List<GExpDoiSoatChiTietCt> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpDoiSoatChiTietCt] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpDoiSoatChiTietCt] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpDoiSoatChiTietCt>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpDoiSoatChiTietCt từ Database
		/// </summary>
		public GExpDoiSoatChiTietCt GetObject(string schema, String BillCode)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDoiSoatChiTietCt] where BillCode=@BillCode",
					"@BillCode", BillCode);
				if (ds.Rows.Count > 0)
				{
					GExpDoiSoatChiTietCt item=new GExpDoiSoatChiTietCt();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["FK_DoiSoatChiTiet"] != null && dr["FK_DoiSoatChiTiet"] != DBNull.Value)
						{
							item.FK_DoiSoatChiTiet = Convert.ToString(dr["FK_DoiSoatChiTiet"]);
						}
						if (dr["NguoiGui"] != null && dr["NguoiGui"] != DBNull.Value)
						{
							item.NguoiGui = Convert.ToString(dr["NguoiGui"]);
						}
						if (dr["NguoiNhan"] != null && dr["NguoiNhan"] != DBNull.Value)
						{
							item.NguoiNhan = Convert.ToString(dr["NguoiNhan"]);
						}
						if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
						{
							item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
						}
						if (dr["NoiDen"] != null && dr["NoiDen"] != DBNull.Value)
						{
							item.NoiDen = Convert.ToString(dr["NoiDen"]);
						}
						if (dr["ThuHo"] != null && dr["ThuHo"] != DBNull.Value)
						{
							item.ThuHo = Convert.ToDecimal(dr["ThuHo"]);
						}
						if (dr["TrongLuong"] != null && dr["TrongLuong"] != DBNull.Value)
						{
							item.TrongLuong = Convert.ToDecimal(dr["TrongLuong"]);
						}
						if (dr["TrongLuongKH"] != null && dr["TrongLuongKH"] != DBNull.Value)
						{
							item.TrongLuongKH = Convert.ToDecimal(dr["TrongLuongKH"]);
						}
						if (dr["NgayGuiHang"] != null && dr["NgayGuiHang"] != DBNull.Value)
						{
							item.NgayGuiHang = Convert.ToString(dr["NgayGuiHang"]);
						}
						if (dr["NgayKyNhan"] != null && dr["NgayKyNhan"] != DBNull.Value)
						{
							item.NgayKyNhan = Convert.ToString(dr["NgayKyNhan"]);
						}
						if (dr["CuocVanChuyen"] != null && dr["CuocVanChuyen"] != DBNull.Value)
						{
							item.CuocVanChuyen = Convert.ToDecimal(dr["CuocVanChuyen"]);
						}
						if (dr["LoaiThanhToan"] != null && dr["LoaiThanhToan"] != DBNull.Value)
						{
							item.LoaiThanhToan = Convert.ToString(dr["LoaiThanhToan"]);
						}
						if (dr["LoaiKien"] != null && dr["LoaiKien"] != DBNull.Value)
						{
							item.LoaiKien = Convert.ToString(dr["LoaiKien"]);
						}
						if (dr["SoTienThanhToan"] != null && dr["SoTienThanhToan"] != DBNull.Value)
						{
							item.SoTienThanhToan = Convert.ToDecimal(dr["SoTienThanhToan"]);
						}
						if (dr["GhiChu"] != null && dr["GhiChu"] != DBNull.Value)
						{
							item.GhiChu = Convert.ToString(dr["GhiChu"]);
						}
						if (dr["IsHoanThanh"] != null && dr["IsHoanThanh"] != DBNull.Value)
						{
							item.IsHoanThanh = Convert.ToBoolean(dr["IsHoanThanh"]);
						}
						if (dr["Status"] != null && dr["Status"] != DBNull.Value)
						{
							item.Status = Convert.ToInt32(dr["Status"]);
						}
						if (dr["PhiVC"] != null && dr["PhiVC"] != DBNull.Value)
						{
							item.PhiVC = Convert.ToDecimal(dr["PhiVC"]);
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
		/// Lấy một GExpDoiSoatChiTietCt đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpDoiSoatChiTietCt GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpDoiSoatChiTietCt] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpDoiSoatChiTietCt item=new GExpDoiSoatChiTietCt();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["FK_DoiSoatChiTiet"] != null && dr["FK_DoiSoatChiTiet"] != DBNull.Value)
						{
							item.FK_DoiSoatChiTiet = Convert.ToString(dr["FK_DoiSoatChiTiet"]);
						}
						if (dr["NguoiGui"] != null && dr["NguoiGui"] != DBNull.Value)
						{
							item.NguoiGui = Convert.ToString(dr["NguoiGui"]);
						}
						if (dr["NguoiNhan"] != null && dr["NguoiNhan"] != DBNull.Value)
						{
							item.NguoiNhan = Convert.ToString(dr["NguoiNhan"]);
						}
						if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
						{
							item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
						}
						if (dr["NoiDen"] != null && dr["NoiDen"] != DBNull.Value)
						{
							item.NoiDen = Convert.ToString(dr["NoiDen"]);
						}
						if (dr["ThuHo"] != null && dr["ThuHo"] != DBNull.Value)
						{
							item.ThuHo = Convert.ToDecimal(dr["ThuHo"]);
						}
						if (dr["TrongLuong"] != null && dr["TrongLuong"] != DBNull.Value)
						{
							item.TrongLuong = Convert.ToDecimal(dr["TrongLuong"]);
						}
						if (dr["TrongLuongKH"] != null && dr["TrongLuongKH"] != DBNull.Value)
						{
							item.TrongLuongKH = Convert.ToDecimal(dr["TrongLuongKH"]);
						}
						if (dr["NgayGuiHang"] != null && dr["NgayGuiHang"] != DBNull.Value)
						{
							item.NgayGuiHang = Convert.ToString(dr["NgayGuiHang"]);
						}
						if (dr["NgayKyNhan"] != null && dr["NgayKyNhan"] != DBNull.Value)
						{
							item.NgayKyNhan = Convert.ToString(dr["NgayKyNhan"]);
						}
						if (dr["CuocVanChuyen"] != null && dr["CuocVanChuyen"] != DBNull.Value)
						{
							item.CuocVanChuyen = Convert.ToDecimal(dr["CuocVanChuyen"]);
						}
						if (dr["LoaiThanhToan"] != null && dr["LoaiThanhToan"] != DBNull.Value)
						{
							item.LoaiThanhToan = Convert.ToString(dr["LoaiThanhToan"]);
						}
						if (dr["LoaiKien"] != null && dr["LoaiKien"] != DBNull.Value)
						{
							item.LoaiKien = Convert.ToString(dr["LoaiKien"]);
						}
						if (dr["SoTienThanhToan"] != null && dr["SoTienThanhToan"] != DBNull.Value)
						{
							item.SoTienThanhToan = Convert.ToDecimal(dr["SoTienThanhToan"]);
						}
						if (dr["GhiChu"] != null && dr["GhiChu"] != DBNull.Value)
						{
							item.GhiChu = Convert.ToString(dr["GhiChu"]);
						}
						if (dr["IsHoanThanh"] != null && dr["IsHoanThanh"] != DBNull.Value)
						{
							item.IsHoanThanh = Convert.ToBoolean(dr["IsHoanThanh"]);
						}
						if (dr["Status"] != null && dr["Status"] != DBNull.Value)
						{
							item.Status = Convert.ToInt32(dr["Status"]);
						}
						if (dr["PhiVC"] != null && dr["PhiVC"] != DBNull.Value)
						{
							item.PhiVC = Convert.ToDecimal(dr["PhiVC"]);
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

		public GExpDoiSoatChiTietCt GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpDoiSoatChiTietCt] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpDoiSoatChiTietCt>(ds);
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
		/// Thêm mới GExpDoiSoatChiTietCt vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpDoiSoatChiTietCt _GExpDoiSoatChiTietCt)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpDoiSoatChiTietCt](BillCode, FK_DoiSoatChiTiet, NguoiGui, NguoiNhan, SoDienThoai, NoiDen, ThuHo, TrongLuong, TrongLuongKH, NgayGuiHang, NgayKyNhan, CuocVanChuyen, LoaiThanhToan, LoaiKien, SoTienThanhToan, GhiChu, IsHoanThanh, Status, PhiVC) VALUES(@BillCode, @FK_DoiSoatChiTiet, @NguoiGui, @NguoiNhan, @SoDienThoai, @NoiDen, @ThuHo, @TrongLuong, @TrongLuongKH, @NgayGuiHang, @NgayKyNhan, @CuocVanChuyen, @LoaiThanhToan, @LoaiKien, @SoTienThanhToan, @GhiChu, @IsHoanThanh, @Status, @PhiVC)", 
					"@BillCode",  _GExpDoiSoatChiTietCt.BillCode, 
					"@FK_DoiSoatChiTiet",  _GExpDoiSoatChiTietCt.FK_DoiSoatChiTiet, 
					"@NguoiGui",  _GExpDoiSoatChiTietCt.NguoiGui, 
					"@NguoiNhan",  _GExpDoiSoatChiTietCt.NguoiNhan, 
					"@SoDienThoai",  _GExpDoiSoatChiTietCt.SoDienThoai, 
					"@NoiDen",  _GExpDoiSoatChiTietCt.NoiDen, 
					"@ThuHo",  _GExpDoiSoatChiTietCt.ThuHo, 
					"@TrongLuong",  _GExpDoiSoatChiTietCt.TrongLuong, 
					"@TrongLuongKH",  _GExpDoiSoatChiTietCt.TrongLuongKH, 
					"@NgayGuiHang",  _GExpDoiSoatChiTietCt.NgayGuiHang, 
					"@NgayKyNhan",  _GExpDoiSoatChiTietCt.NgayKyNhan, 
					"@CuocVanChuyen",  _GExpDoiSoatChiTietCt.CuocVanChuyen, 
					"@LoaiThanhToan",  _GExpDoiSoatChiTietCt.LoaiThanhToan, 
					"@LoaiKien",  _GExpDoiSoatChiTietCt.LoaiKien, 
					"@SoTienThanhToan",  _GExpDoiSoatChiTietCt.SoTienThanhToan, 
					"@GhiChu",  _GExpDoiSoatChiTietCt.GhiChu, 
					"@IsHoanThanh",  _GExpDoiSoatChiTietCt.IsHoanThanh, 
					"@Status",  _GExpDoiSoatChiTietCt.Status, 
					"@PhiVC",  _GExpDoiSoatChiTietCt.PhiVC);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpDoiSoatChiTietCt vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpDoiSoatChiTietCt> _GExpDoiSoatChiTietCts)
		{
			foreach (GExpDoiSoatChiTietCt item in _GExpDoiSoatChiTietCts)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpDoiSoatChiTietCt vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpDoiSoatChiTietCt _GExpDoiSoatChiTietCt, String BillCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDoiSoatChiTietCt] SET BillCode=@BillCode, FK_DoiSoatChiTiet=@FK_DoiSoatChiTiet, NguoiGui=@NguoiGui, NguoiNhan=@NguoiNhan, SoDienThoai=@SoDienThoai, NoiDen=@NoiDen, ThuHo=@ThuHo, TrongLuong=@TrongLuong, TrongLuongKH=@TrongLuongKH, NgayGuiHang=@NgayGuiHang, NgayKyNhan=@NgayKyNhan, CuocVanChuyen=@CuocVanChuyen, LoaiThanhToan=@LoaiThanhToan, LoaiKien=@LoaiKien, SoTienThanhToan=@SoTienThanhToan, GhiChu=@GhiChu, IsHoanThanh=@IsHoanThanh, Status=@Status, PhiVC=@PhiVC WHERE BillCode=@BillCode", 
					"@BillCode",  _GExpDoiSoatChiTietCt.BillCode, 
					"@FK_DoiSoatChiTiet",  _GExpDoiSoatChiTietCt.FK_DoiSoatChiTiet, 
					"@NguoiGui",  _GExpDoiSoatChiTietCt.NguoiGui, 
					"@NguoiNhan",  _GExpDoiSoatChiTietCt.NguoiNhan, 
					"@SoDienThoai",  _GExpDoiSoatChiTietCt.SoDienThoai, 
					"@NoiDen",  _GExpDoiSoatChiTietCt.NoiDen, 
					"@ThuHo",  _GExpDoiSoatChiTietCt.ThuHo, 
					"@TrongLuong",  _GExpDoiSoatChiTietCt.TrongLuong, 
					"@TrongLuongKH",  _GExpDoiSoatChiTietCt.TrongLuongKH, 
					"@NgayGuiHang",  _GExpDoiSoatChiTietCt.NgayGuiHang, 
					"@NgayKyNhan",  _GExpDoiSoatChiTietCt.NgayKyNhan, 
					"@CuocVanChuyen",  _GExpDoiSoatChiTietCt.CuocVanChuyen, 
					"@LoaiThanhToan",  _GExpDoiSoatChiTietCt.LoaiThanhToan, 
					"@LoaiKien",  _GExpDoiSoatChiTietCt.LoaiKien, 
					"@SoTienThanhToan",  _GExpDoiSoatChiTietCt.SoTienThanhToan, 
					"@GhiChu",  _GExpDoiSoatChiTietCt.GhiChu, 
					"@IsHoanThanh",  _GExpDoiSoatChiTietCt.IsHoanThanh, 
					"@Status",  _GExpDoiSoatChiTietCt.Status, 
					"@PhiVC",  _GExpDoiSoatChiTietCt.PhiVC, 
					"@BillCode", BillCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpDoiSoatChiTietCt vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpDoiSoatChiTietCt _GExpDoiSoatChiTietCt)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDoiSoatChiTietCt] SET FK_DoiSoatChiTiet=@FK_DoiSoatChiTiet, NguoiGui=@NguoiGui, NguoiNhan=@NguoiNhan, SoDienThoai=@SoDienThoai, NoiDen=@NoiDen, ThuHo=@ThuHo, TrongLuong=@TrongLuong, TrongLuongKH=@TrongLuongKH, NgayGuiHang=@NgayGuiHang, NgayKyNhan=@NgayKyNhan, CuocVanChuyen=@CuocVanChuyen, LoaiThanhToan=@LoaiThanhToan, LoaiKien=@LoaiKien, SoTienThanhToan=@SoTienThanhToan, GhiChu=@GhiChu, IsHoanThanh=@IsHoanThanh, Status=@Status, PhiVC=@PhiVC WHERE BillCode=@BillCode", 
					"@FK_DoiSoatChiTiet",  _GExpDoiSoatChiTietCt.FK_DoiSoatChiTiet, 
					"@NguoiGui",  _GExpDoiSoatChiTietCt.NguoiGui, 
					"@NguoiNhan",  _GExpDoiSoatChiTietCt.NguoiNhan, 
					"@SoDienThoai",  _GExpDoiSoatChiTietCt.SoDienThoai, 
					"@NoiDen",  _GExpDoiSoatChiTietCt.NoiDen, 
					"@ThuHo",  _GExpDoiSoatChiTietCt.ThuHo, 
					"@TrongLuong",  _GExpDoiSoatChiTietCt.TrongLuong, 
					"@TrongLuongKH",  _GExpDoiSoatChiTietCt.TrongLuongKH, 
					"@NgayGuiHang",  _GExpDoiSoatChiTietCt.NgayGuiHang, 
					"@NgayKyNhan",  _GExpDoiSoatChiTietCt.NgayKyNhan, 
					"@CuocVanChuyen",  _GExpDoiSoatChiTietCt.CuocVanChuyen, 
					"@LoaiThanhToan",  _GExpDoiSoatChiTietCt.LoaiThanhToan, 
					"@LoaiKien",  _GExpDoiSoatChiTietCt.LoaiKien, 
					"@SoTienThanhToan",  _GExpDoiSoatChiTietCt.SoTienThanhToan, 
					"@GhiChu",  _GExpDoiSoatChiTietCt.GhiChu, 
					"@IsHoanThanh",  _GExpDoiSoatChiTietCt.IsHoanThanh, 
					"@Status",  _GExpDoiSoatChiTietCt.Status, 
					"@PhiVC",  _GExpDoiSoatChiTietCt.PhiVC, 
					"@BillCode", _GExpDoiSoatChiTietCt.BillCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpDoiSoatChiTietCt vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpDoiSoatChiTietCt> _GExpDoiSoatChiTietCts)
		{
			foreach (GExpDoiSoatChiTietCt item in _GExpDoiSoatChiTietCts)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpDoiSoatChiTietCt vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpDoiSoatChiTietCt _GExpDoiSoatChiTietCt, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDoiSoatChiTietCt] SET BillCode=@BillCode, FK_DoiSoatChiTiet=@FK_DoiSoatChiTiet, NguoiGui=@NguoiGui, NguoiNhan=@NguoiNhan, SoDienThoai=@SoDienThoai, NoiDen=@NoiDen, ThuHo=@ThuHo, TrongLuong=@TrongLuong, TrongLuongKH=@TrongLuongKH, NgayGuiHang=@NgayGuiHang, NgayKyNhan=@NgayKyNhan, CuocVanChuyen=@CuocVanChuyen, LoaiThanhToan=@LoaiThanhToan, LoaiKien=@LoaiKien, SoTienThanhToan=@SoTienThanhToan, GhiChu=@GhiChu, IsHoanThanh=@IsHoanThanh, Status=@Status, PhiVC=@PhiVC "+ condition, 
					"@BillCode",  _GExpDoiSoatChiTietCt.BillCode, 
					"@FK_DoiSoatChiTiet",  _GExpDoiSoatChiTietCt.FK_DoiSoatChiTiet, 
					"@NguoiGui",  _GExpDoiSoatChiTietCt.NguoiGui, 
					"@NguoiNhan",  _GExpDoiSoatChiTietCt.NguoiNhan, 
					"@SoDienThoai",  _GExpDoiSoatChiTietCt.SoDienThoai, 
					"@NoiDen",  _GExpDoiSoatChiTietCt.NoiDen, 
					"@ThuHo",  _GExpDoiSoatChiTietCt.ThuHo, 
					"@TrongLuong",  _GExpDoiSoatChiTietCt.TrongLuong, 
					"@TrongLuongKH",  _GExpDoiSoatChiTietCt.TrongLuongKH, 
					"@NgayGuiHang",  _GExpDoiSoatChiTietCt.NgayGuiHang, 
					"@NgayKyNhan",  _GExpDoiSoatChiTietCt.NgayKyNhan, 
					"@CuocVanChuyen",  _GExpDoiSoatChiTietCt.CuocVanChuyen, 
					"@LoaiThanhToan",  _GExpDoiSoatChiTietCt.LoaiThanhToan, 
					"@LoaiKien",  _GExpDoiSoatChiTietCt.LoaiKien, 
					"@SoTienThanhToan",  _GExpDoiSoatChiTietCt.SoTienThanhToan, 
					"@GhiChu",  _GExpDoiSoatChiTietCt.GhiChu, 
					"@IsHoanThanh",  _GExpDoiSoatChiTietCt.IsHoanThanh, 
					"@Status",  _GExpDoiSoatChiTietCt.Status, 
					"@PhiVC",  _GExpDoiSoatChiTietCt.PhiVC);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpDoiSoatChiTietCt trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String BillCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDoiSoatChiTietCt] WHERE BillCode=@BillCode",
					"@BillCode", BillCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDoiSoatChiTietCt trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpDoiSoatChiTietCt _GExpDoiSoatChiTietCt)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDoiSoatChiTietCt] WHERE BillCode=@BillCode",
					"@BillCode", _GExpDoiSoatChiTietCt.BillCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDoiSoatChiTietCt trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDoiSoatChiTietCt] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDoiSoatChiTietCt trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpDoiSoatChiTietCt> _GExpDoiSoatChiTietCts)
		{
			foreach (GExpDoiSoatChiTietCt item in _GExpDoiSoatChiTietCts)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
