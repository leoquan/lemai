using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpdoisoatchitietct:IEXpdoisoatchitietct
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpdoisoatchitietct(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpDoiSoatChiTietCt từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpDoiSoatChiTietCt]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpDoiSoatChiTietCt từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpDoiSoatChiTietCt] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpDoiSoatChiTietCt từ Database
		/// </summary>
		public List<ExpDoiSoatChiTietCt> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpDoiSoatChiTietCt]");
				List<ExpDoiSoatChiTietCt> items = new List<ExpDoiSoatChiTietCt>();
				ExpDoiSoatChiTietCt item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpDoiSoatChiTietCt();
					if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
					{
						item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
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
		/// Lấy danh sách ExpDoiSoatChiTietCt từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpDoiSoatChiTietCt> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpDoiSoatChiTietCt] A "+ condition,  parameters);
				List<ExpDoiSoatChiTietCt> items = new List<ExpDoiSoatChiTietCt>();
				ExpDoiSoatChiTietCt item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpDoiSoatChiTietCt();
					if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
					{
						item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
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
					items.Add(item);
				}
				return items;
			}
			catch
			{
				throw;
			}
		}

		public List<ExpDoiSoatChiTietCt> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpDoiSoatChiTietCt] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpDoiSoatChiTietCt] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpDoiSoatChiTietCt>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpDoiSoatChiTietCt từ Database
		/// </summary>
		public ExpDoiSoatChiTietCt GetObject(string schema, String BILL_CODE)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpDoiSoatChiTietCt] where BILL_CODE=@BILL_CODE",
					"@BILL_CODE", BILL_CODE);
				if (ds.Rows.Count > 0)
				{
					ExpDoiSoatChiTietCt item=new ExpDoiSoatChiTietCt();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
						{
							item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
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
		/// Lấy một ExpDoiSoatChiTietCt đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpDoiSoatChiTietCt GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpDoiSoatChiTietCt] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpDoiSoatChiTietCt item=new ExpDoiSoatChiTietCt();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
						{
							item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
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

		public ExpDoiSoatChiTietCt GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpDoiSoatChiTietCt] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpDoiSoatChiTietCt>(ds);
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
		/// Thêm mới ExpDoiSoatChiTietCt vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpDoiSoatChiTietCt _ExpDoiSoatChiTietCt)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpDoiSoatChiTietCt](BILL_CODE, FK_DoiSoatChiTiet, NguoiGui, NguoiNhan, SoDienThoai, NoiDen, ThuHo, TrongLuong, NgayGuiHang, NgayKyNhan, CuocVanChuyen, LoaiThanhToan, LoaiKien, SoTienThanhToan, GhiChu, IsHoanThanh) VALUES(@BILL_CODE, @FK_DoiSoatChiTiet, @NguoiGui, @NguoiNhan, @SoDienThoai, @NoiDen, @ThuHo, @TrongLuong, @NgayGuiHang, @NgayKyNhan, @CuocVanChuyen, @LoaiThanhToan, @LoaiKien, @SoTienThanhToan, @GhiChu, @IsHoanThanh)", 
					"@BILL_CODE",  _ExpDoiSoatChiTietCt.BILL_CODE, 
					"@FK_DoiSoatChiTiet",  _ExpDoiSoatChiTietCt.FK_DoiSoatChiTiet, 
					"@NguoiGui",  _ExpDoiSoatChiTietCt.NguoiGui, 
					"@NguoiNhan",  _ExpDoiSoatChiTietCt.NguoiNhan, 
					"@SoDienThoai",  _ExpDoiSoatChiTietCt.SoDienThoai, 
					"@NoiDen",  _ExpDoiSoatChiTietCt.NoiDen, 
					"@ThuHo",  _ExpDoiSoatChiTietCt.ThuHo, 
					"@TrongLuong",  _ExpDoiSoatChiTietCt.TrongLuong, 
					"@NgayGuiHang",  _ExpDoiSoatChiTietCt.NgayGuiHang, 
					"@NgayKyNhan",  _ExpDoiSoatChiTietCt.NgayKyNhan, 
					"@CuocVanChuyen",  _ExpDoiSoatChiTietCt.CuocVanChuyen, 
					"@LoaiThanhToan",  _ExpDoiSoatChiTietCt.LoaiThanhToan, 
					"@LoaiKien",  _ExpDoiSoatChiTietCt.LoaiKien, 
					"@SoTienThanhToan",  _ExpDoiSoatChiTietCt.SoTienThanhToan, 
					"@GhiChu",  _ExpDoiSoatChiTietCt.GhiChu, 
					"@IsHoanThanh",  _ExpDoiSoatChiTietCt.IsHoanThanh);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpDoiSoatChiTietCt vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpDoiSoatChiTietCt> _ExpDoiSoatChiTietCts)
		{
			foreach (ExpDoiSoatChiTietCt item in _ExpDoiSoatChiTietCts)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpDoiSoatChiTietCt vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpDoiSoatChiTietCt _ExpDoiSoatChiTietCt, String BILL_CODE)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpDoiSoatChiTietCt] SET BILL_CODE=@BILL_CODE, FK_DoiSoatChiTiet=@FK_DoiSoatChiTiet, NguoiGui=@NguoiGui, NguoiNhan=@NguoiNhan, SoDienThoai=@SoDienThoai, NoiDen=@NoiDen, ThuHo=@ThuHo, TrongLuong=@TrongLuong, NgayGuiHang=@NgayGuiHang, NgayKyNhan=@NgayKyNhan, CuocVanChuyen=@CuocVanChuyen, LoaiThanhToan=@LoaiThanhToan, LoaiKien=@LoaiKien, SoTienThanhToan=@SoTienThanhToan, GhiChu=@GhiChu, IsHoanThanh=@IsHoanThanh WHERE BILL_CODE=@BILL_CODE", 
					"@BILL_CODE",  _ExpDoiSoatChiTietCt.BILL_CODE, 
					"@FK_DoiSoatChiTiet",  _ExpDoiSoatChiTietCt.FK_DoiSoatChiTiet, 
					"@NguoiGui",  _ExpDoiSoatChiTietCt.NguoiGui, 
					"@NguoiNhan",  _ExpDoiSoatChiTietCt.NguoiNhan, 
					"@SoDienThoai",  _ExpDoiSoatChiTietCt.SoDienThoai, 
					"@NoiDen",  _ExpDoiSoatChiTietCt.NoiDen, 
					"@ThuHo",  _ExpDoiSoatChiTietCt.ThuHo, 
					"@TrongLuong",  _ExpDoiSoatChiTietCt.TrongLuong, 
					"@NgayGuiHang",  _ExpDoiSoatChiTietCt.NgayGuiHang, 
					"@NgayKyNhan",  _ExpDoiSoatChiTietCt.NgayKyNhan, 
					"@CuocVanChuyen",  _ExpDoiSoatChiTietCt.CuocVanChuyen, 
					"@LoaiThanhToan",  _ExpDoiSoatChiTietCt.LoaiThanhToan, 
					"@LoaiKien",  _ExpDoiSoatChiTietCt.LoaiKien, 
					"@SoTienThanhToan",  _ExpDoiSoatChiTietCt.SoTienThanhToan, 
					"@GhiChu",  _ExpDoiSoatChiTietCt.GhiChu, 
					"@IsHoanThanh",  _ExpDoiSoatChiTietCt.IsHoanThanh, 
					"@BILL_CODE", BILL_CODE);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpDoiSoatChiTietCt vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpDoiSoatChiTietCt _ExpDoiSoatChiTietCt)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpDoiSoatChiTietCt] SET FK_DoiSoatChiTiet=@FK_DoiSoatChiTiet, NguoiGui=@NguoiGui, NguoiNhan=@NguoiNhan, SoDienThoai=@SoDienThoai, NoiDen=@NoiDen, ThuHo=@ThuHo, TrongLuong=@TrongLuong, NgayGuiHang=@NgayGuiHang, NgayKyNhan=@NgayKyNhan, CuocVanChuyen=@CuocVanChuyen, LoaiThanhToan=@LoaiThanhToan, LoaiKien=@LoaiKien, SoTienThanhToan=@SoTienThanhToan, GhiChu=@GhiChu, IsHoanThanh=@IsHoanThanh WHERE BILL_CODE=@BILL_CODE", 
					"@FK_DoiSoatChiTiet",  _ExpDoiSoatChiTietCt.FK_DoiSoatChiTiet, 
					"@NguoiGui",  _ExpDoiSoatChiTietCt.NguoiGui, 
					"@NguoiNhan",  _ExpDoiSoatChiTietCt.NguoiNhan, 
					"@SoDienThoai",  _ExpDoiSoatChiTietCt.SoDienThoai, 
					"@NoiDen",  _ExpDoiSoatChiTietCt.NoiDen, 
					"@ThuHo",  _ExpDoiSoatChiTietCt.ThuHo, 
					"@TrongLuong",  _ExpDoiSoatChiTietCt.TrongLuong, 
					"@NgayGuiHang",  _ExpDoiSoatChiTietCt.NgayGuiHang, 
					"@NgayKyNhan",  _ExpDoiSoatChiTietCt.NgayKyNhan, 
					"@CuocVanChuyen",  _ExpDoiSoatChiTietCt.CuocVanChuyen, 
					"@LoaiThanhToan",  _ExpDoiSoatChiTietCt.LoaiThanhToan, 
					"@LoaiKien",  _ExpDoiSoatChiTietCt.LoaiKien, 
					"@SoTienThanhToan",  _ExpDoiSoatChiTietCt.SoTienThanhToan, 
					"@GhiChu",  _ExpDoiSoatChiTietCt.GhiChu, 
					"@IsHoanThanh",  _ExpDoiSoatChiTietCt.IsHoanThanh, 
					"@BILL_CODE", _ExpDoiSoatChiTietCt.BILL_CODE);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpDoiSoatChiTietCt vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpDoiSoatChiTietCt> _ExpDoiSoatChiTietCts)
		{
			foreach (ExpDoiSoatChiTietCt item in _ExpDoiSoatChiTietCts)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpDoiSoatChiTietCt vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpDoiSoatChiTietCt _ExpDoiSoatChiTietCt, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpDoiSoatChiTietCt] SET BILL_CODE=@BILL_CODE, FK_DoiSoatChiTiet=@FK_DoiSoatChiTiet, NguoiGui=@NguoiGui, NguoiNhan=@NguoiNhan, SoDienThoai=@SoDienThoai, NoiDen=@NoiDen, ThuHo=@ThuHo, TrongLuong=@TrongLuong, NgayGuiHang=@NgayGuiHang, NgayKyNhan=@NgayKyNhan, CuocVanChuyen=@CuocVanChuyen, LoaiThanhToan=@LoaiThanhToan, LoaiKien=@LoaiKien, SoTienThanhToan=@SoTienThanhToan, GhiChu=@GhiChu, IsHoanThanh=@IsHoanThanh "+ condition, 
					"@BILL_CODE",  _ExpDoiSoatChiTietCt.BILL_CODE, 
					"@FK_DoiSoatChiTiet",  _ExpDoiSoatChiTietCt.FK_DoiSoatChiTiet, 
					"@NguoiGui",  _ExpDoiSoatChiTietCt.NguoiGui, 
					"@NguoiNhan",  _ExpDoiSoatChiTietCt.NguoiNhan, 
					"@SoDienThoai",  _ExpDoiSoatChiTietCt.SoDienThoai, 
					"@NoiDen",  _ExpDoiSoatChiTietCt.NoiDen, 
					"@ThuHo",  _ExpDoiSoatChiTietCt.ThuHo, 
					"@TrongLuong",  _ExpDoiSoatChiTietCt.TrongLuong, 
					"@NgayGuiHang",  _ExpDoiSoatChiTietCt.NgayGuiHang, 
					"@NgayKyNhan",  _ExpDoiSoatChiTietCt.NgayKyNhan, 
					"@CuocVanChuyen",  _ExpDoiSoatChiTietCt.CuocVanChuyen, 
					"@LoaiThanhToan",  _ExpDoiSoatChiTietCt.LoaiThanhToan, 
					"@LoaiKien",  _ExpDoiSoatChiTietCt.LoaiKien, 
					"@SoTienThanhToan",  _ExpDoiSoatChiTietCt.SoTienThanhToan, 
					"@GhiChu",  _ExpDoiSoatChiTietCt.GhiChu, 
					"@IsHoanThanh",  _ExpDoiSoatChiTietCt.IsHoanThanh);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpDoiSoatChiTietCt trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String BILL_CODE)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpDoiSoatChiTietCt] WHERE BILL_CODE=@BILL_CODE",
					"@BILL_CODE", BILL_CODE);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpDoiSoatChiTietCt trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpDoiSoatChiTietCt _ExpDoiSoatChiTietCt)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpDoiSoatChiTietCt] WHERE BILL_CODE=@BILL_CODE",
					"@BILL_CODE", _ExpDoiSoatChiTietCt.BILL_CODE);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpDoiSoatChiTietCt trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpDoiSoatChiTietCt] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpDoiSoatChiTietCt trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpDoiSoatChiTietCt> _ExpDoiSoatChiTietCts)
		{
			foreach (ExpDoiSoatChiTietCt item in _ExpDoiSoatChiTietCts)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
