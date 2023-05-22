using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpdoisoatchitiet:IEXpdoisoatchitiet
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpdoisoatchitiet(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpDoiSoatChiTiet từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpDoiSoatChiTiet]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpDoiSoatChiTiet từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpDoiSoatChiTiet] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpDoiSoatChiTiet từ Database
		/// </summary>
		public List<ExpDoiSoatChiTiet> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpDoiSoatChiTiet]");
				List<ExpDoiSoatChiTiet> items = new List<ExpDoiSoatChiTiet>();
				ExpDoiSoatChiTiet item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpDoiSoatChiTiet();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_DoiSoat"] != null && dr["FK_DoiSoat"] != DBNull.Value)
					{
						item.FK_DoiSoat = Convert.ToString(dr["FK_DoiSoat"]);
					}
					if (dr["TenKhachHang"] != null && dr["TenKhachHang"] != DBNull.Value)
					{
						item.TenKhachHang = Convert.ToString(dr["TenKhachHang"]);
					}
					if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
					{
						item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
					}
					if (dr["SoLuongDon"] != null && dr["SoLuongDon"] != DBNull.Value)
					{
						item.SoLuongDon = Convert.ToInt32(dr["SoLuongDon"]);
					}
					if (dr["ThuHo"] != null && dr["ThuHo"] != DBNull.Value)
					{
						item.ThuHo = Convert.ToDecimal(dr["ThuHo"]);
					}
					if (dr["ThuHoKT"] != null && dr["ThuHoKT"] != DBNull.Value)
					{
						item.ThuHoKT = Convert.ToDecimal(dr["ThuHoKT"]);
					}
					if (dr["SaiLech"] != null && dr["SaiLech"] != DBNull.Value)
					{
						item.SaiLech = Convert.ToDecimal(dr["SaiLech"]);
					}
					if (dr["CuocGuiTra"] != null && dr["CuocGuiTra"] != DBNull.Value)
					{
						item.CuocGuiTra = Convert.ToDecimal(dr["CuocGuiTra"]);
					}
					if (dr["CuocNhanTra"] != null && dr["CuocNhanTra"] != DBNull.Value)
					{
						item.CuocNhanTra = Convert.ToDecimal(dr["CuocNhanTra"]);
					}
					if (dr["ChiPhi"] != null && dr["ChiPhi"] != DBNull.Value)
					{
						item.ChiPhi = Convert.ToDecimal(dr["ChiPhi"]);
					}
					if (dr["LoiNhuan"] != null && dr["LoiNhuan"] != DBNull.Value)
					{
						item.LoiNhuan = Convert.ToDecimal(dr["LoiNhuan"]);
					}
					if (dr["ThanhToanKH"] != null && dr["ThanhToanKH"] != DBNull.Value)
					{
						item.ThanhToanKH = Convert.ToDecimal(dr["ThanhToanKH"]);
					}
					if (dr["DaThanhToanKH"] != null && dr["DaThanhToanKH"] != DBNull.Value)
					{
						item.DaThanhToanKH = Convert.ToDecimal(dr["DaThanhToanKH"]);
					}
					if (dr["PhuongThucThanhToan"] != null && dr["PhuongThucThanhToan"] != DBNull.Value)
					{
						item.PhuongThucThanhToan = Convert.ToString(dr["PhuongThucThanhToan"]);
					}
					if (dr["NgayThanhToan"] != null && dr["NgayThanhToan"] != DBNull.Value)
					{
						item.NgayThanhToan = Convert.ToDateTime(dr["NgayThanhToan"]);
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
		/// Lấy danh sách ExpDoiSoatChiTiet từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpDoiSoatChiTiet> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpDoiSoatChiTiet] A "+ condition,  parameters);
				List<ExpDoiSoatChiTiet> items = new List<ExpDoiSoatChiTiet>();
				ExpDoiSoatChiTiet item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpDoiSoatChiTiet();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_DoiSoat"] != null && dr["FK_DoiSoat"] != DBNull.Value)
					{
						item.FK_DoiSoat = Convert.ToString(dr["FK_DoiSoat"]);
					}
					if (dr["TenKhachHang"] != null && dr["TenKhachHang"] != DBNull.Value)
					{
						item.TenKhachHang = Convert.ToString(dr["TenKhachHang"]);
					}
					if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
					{
						item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
					}
					if (dr["SoLuongDon"] != null && dr["SoLuongDon"] != DBNull.Value)
					{
						item.SoLuongDon = Convert.ToInt32(dr["SoLuongDon"]);
					}
					if (dr["ThuHo"] != null && dr["ThuHo"] != DBNull.Value)
					{
						item.ThuHo = Convert.ToDecimal(dr["ThuHo"]);
					}
					if (dr["ThuHoKT"] != null && dr["ThuHoKT"] != DBNull.Value)
					{
						item.ThuHoKT = Convert.ToDecimal(dr["ThuHoKT"]);
					}
					if (dr["SaiLech"] != null && dr["SaiLech"] != DBNull.Value)
					{
						item.SaiLech = Convert.ToDecimal(dr["SaiLech"]);
					}
					if (dr["CuocGuiTra"] != null && dr["CuocGuiTra"] != DBNull.Value)
					{
						item.CuocGuiTra = Convert.ToDecimal(dr["CuocGuiTra"]);
					}
					if (dr["CuocNhanTra"] != null && dr["CuocNhanTra"] != DBNull.Value)
					{
						item.CuocNhanTra = Convert.ToDecimal(dr["CuocNhanTra"]);
					}
					if (dr["ChiPhi"] != null && dr["ChiPhi"] != DBNull.Value)
					{
						item.ChiPhi = Convert.ToDecimal(dr["ChiPhi"]);
					}
					if (dr["LoiNhuan"] != null && dr["LoiNhuan"] != DBNull.Value)
					{
						item.LoiNhuan = Convert.ToDecimal(dr["LoiNhuan"]);
					}
					if (dr["ThanhToanKH"] != null && dr["ThanhToanKH"] != DBNull.Value)
					{
						item.ThanhToanKH = Convert.ToDecimal(dr["ThanhToanKH"]);
					}
					if (dr["DaThanhToanKH"] != null && dr["DaThanhToanKH"] != DBNull.Value)
					{
						item.DaThanhToanKH = Convert.ToDecimal(dr["DaThanhToanKH"]);
					}
					if (dr["PhuongThucThanhToan"] != null && dr["PhuongThucThanhToan"] != DBNull.Value)
					{
						item.PhuongThucThanhToan = Convert.ToString(dr["PhuongThucThanhToan"]);
					}
					if (dr["NgayThanhToan"] != null && dr["NgayThanhToan"] != DBNull.Value)
					{
						item.NgayThanhToan = Convert.ToDateTime(dr["NgayThanhToan"]);
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

		public List<ExpDoiSoatChiTiet> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpDoiSoatChiTiet] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpDoiSoatChiTiet] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpDoiSoatChiTiet>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpDoiSoatChiTiet từ Database
		/// </summary>
		public ExpDoiSoatChiTiet GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpDoiSoatChiTiet] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpDoiSoatChiTiet item=new ExpDoiSoatChiTiet();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_DoiSoat"] != null && dr["FK_DoiSoat"] != DBNull.Value)
						{
							item.FK_DoiSoat = Convert.ToString(dr["FK_DoiSoat"]);
						}
						if (dr["TenKhachHang"] != null && dr["TenKhachHang"] != DBNull.Value)
						{
							item.TenKhachHang = Convert.ToString(dr["TenKhachHang"]);
						}
						if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
						{
							item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
						}
						if (dr["SoLuongDon"] != null && dr["SoLuongDon"] != DBNull.Value)
						{
							item.SoLuongDon = Convert.ToInt32(dr["SoLuongDon"]);
						}
						if (dr["ThuHo"] != null && dr["ThuHo"] != DBNull.Value)
						{
							item.ThuHo = Convert.ToDecimal(dr["ThuHo"]);
						}
						if (dr["ThuHoKT"] != null && dr["ThuHoKT"] != DBNull.Value)
						{
							item.ThuHoKT = Convert.ToDecimal(dr["ThuHoKT"]);
						}
						if (dr["SaiLech"] != null && dr["SaiLech"] != DBNull.Value)
						{
							item.SaiLech = Convert.ToDecimal(dr["SaiLech"]);
						}
						if (dr["CuocGuiTra"] != null && dr["CuocGuiTra"] != DBNull.Value)
						{
							item.CuocGuiTra = Convert.ToDecimal(dr["CuocGuiTra"]);
						}
						if (dr["CuocNhanTra"] != null && dr["CuocNhanTra"] != DBNull.Value)
						{
							item.CuocNhanTra = Convert.ToDecimal(dr["CuocNhanTra"]);
						}
						if (dr["ChiPhi"] != null && dr["ChiPhi"] != DBNull.Value)
						{
							item.ChiPhi = Convert.ToDecimal(dr["ChiPhi"]);
						}
						if (dr["LoiNhuan"] != null && dr["LoiNhuan"] != DBNull.Value)
						{
							item.LoiNhuan = Convert.ToDecimal(dr["LoiNhuan"]);
						}
						if (dr["ThanhToanKH"] != null && dr["ThanhToanKH"] != DBNull.Value)
						{
							item.ThanhToanKH = Convert.ToDecimal(dr["ThanhToanKH"]);
						}
						if (dr["DaThanhToanKH"] != null && dr["DaThanhToanKH"] != DBNull.Value)
						{
							item.DaThanhToanKH = Convert.ToDecimal(dr["DaThanhToanKH"]);
						}
						if (dr["PhuongThucThanhToan"] != null && dr["PhuongThucThanhToan"] != DBNull.Value)
						{
							item.PhuongThucThanhToan = Convert.ToString(dr["PhuongThucThanhToan"]);
						}
						if (dr["NgayThanhToan"] != null && dr["NgayThanhToan"] != DBNull.Value)
						{
							item.NgayThanhToan = Convert.ToDateTime(dr["NgayThanhToan"]);
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
		/// Lấy một ExpDoiSoatChiTiet đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpDoiSoatChiTiet GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpDoiSoatChiTiet] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpDoiSoatChiTiet item=new ExpDoiSoatChiTiet();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_DoiSoat"] != null && dr["FK_DoiSoat"] != DBNull.Value)
						{
							item.FK_DoiSoat = Convert.ToString(dr["FK_DoiSoat"]);
						}
						if (dr["TenKhachHang"] != null && dr["TenKhachHang"] != DBNull.Value)
						{
							item.TenKhachHang = Convert.ToString(dr["TenKhachHang"]);
						}
						if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
						{
							item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
						}
						if (dr["SoLuongDon"] != null && dr["SoLuongDon"] != DBNull.Value)
						{
							item.SoLuongDon = Convert.ToInt32(dr["SoLuongDon"]);
						}
						if (dr["ThuHo"] != null && dr["ThuHo"] != DBNull.Value)
						{
							item.ThuHo = Convert.ToDecimal(dr["ThuHo"]);
						}
						if (dr["ThuHoKT"] != null && dr["ThuHoKT"] != DBNull.Value)
						{
							item.ThuHoKT = Convert.ToDecimal(dr["ThuHoKT"]);
						}
						if (dr["SaiLech"] != null && dr["SaiLech"] != DBNull.Value)
						{
							item.SaiLech = Convert.ToDecimal(dr["SaiLech"]);
						}
						if (dr["CuocGuiTra"] != null && dr["CuocGuiTra"] != DBNull.Value)
						{
							item.CuocGuiTra = Convert.ToDecimal(dr["CuocGuiTra"]);
						}
						if (dr["CuocNhanTra"] != null && dr["CuocNhanTra"] != DBNull.Value)
						{
							item.CuocNhanTra = Convert.ToDecimal(dr["CuocNhanTra"]);
						}
						if (dr["ChiPhi"] != null && dr["ChiPhi"] != DBNull.Value)
						{
							item.ChiPhi = Convert.ToDecimal(dr["ChiPhi"]);
						}
						if (dr["LoiNhuan"] != null && dr["LoiNhuan"] != DBNull.Value)
						{
							item.LoiNhuan = Convert.ToDecimal(dr["LoiNhuan"]);
						}
						if (dr["ThanhToanKH"] != null && dr["ThanhToanKH"] != DBNull.Value)
						{
							item.ThanhToanKH = Convert.ToDecimal(dr["ThanhToanKH"]);
						}
						if (dr["DaThanhToanKH"] != null && dr["DaThanhToanKH"] != DBNull.Value)
						{
							item.DaThanhToanKH = Convert.ToDecimal(dr["DaThanhToanKH"]);
						}
						if (dr["PhuongThucThanhToan"] != null && dr["PhuongThucThanhToan"] != DBNull.Value)
						{
							item.PhuongThucThanhToan = Convert.ToString(dr["PhuongThucThanhToan"]);
						}
						if (dr["NgayThanhToan"] != null && dr["NgayThanhToan"] != DBNull.Value)
						{
							item.NgayThanhToan = Convert.ToDateTime(dr["NgayThanhToan"]);
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

		public ExpDoiSoatChiTiet GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpDoiSoatChiTiet] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpDoiSoatChiTiet>(ds);
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
		/// Thêm mới ExpDoiSoatChiTiet vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpDoiSoatChiTiet _ExpDoiSoatChiTiet)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpDoiSoatChiTiet](Id, FK_DoiSoat, TenKhachHang, SoDienThoai, SoLuongDon, ThuHo, ThuHoKT, SaiLech, CuocGuiTra, CuocNhanTra, ChiPhi, LoiNhuan, ThanhToanKH, DaThanhToanKH, PhuongThucThanhToan, NgayThanhToan, GhiChu, IsHoanThanh) VALUES(@Id, @FK_DoiSoat, @TenKhachHang, @SoDienThoai, @SoLuongDon, @ThuHo, @ThuHoKT, @SaiLech, @CuocGuiTra, @CuocNhanTra, @ChiPhi, @LoiNhuan, @ThanhToanKH, @DaThanhToanKH, @PhuongThucThanhToan, @NgayThanhToan, @GhiChu, @IsHoanThanh)", 
					"@Id",  _ExpDoiSoatChiTiet.Id, 
					"@FK_DoiSoat",  _ExpDoiSoatChiTiet.FK_DoiSoat, 
					"@TenKhachHang",  _ExpDoiSoatChiTiet.TenKhachHang, 
					"@SoDienThoai",  _ExpDoiSoatChiTiet.SoDienThoai, 
					"@SoLuongDon",  _ExpDoiSoatChiTiet.SoLuongDon, 
					"@ThuHo",  _ExpDoiSoatChiTiet.ThuHo, 
					"@ThuHoKT",  _ExpDoiSoatChiTiet.ThuHoKT, 
					"@SaiLech",  _ExpDoiSoatChiTiet.SaiLech, 
					"@CuocGuiTra",  _ExpDoiSoatChiTiet.CuocGuiTra, 
					"@CuocNhanTra",  _ExpDoiSoatChiTiet.CuocNhanTra, 
					"@ChiPhi",  _ExpDoiSoatChiTiet.ChiPhi, 
					"@LoiNhuan",  _ExpDoiSoatChiTiet.LoiNhuan, 
					"@ThanhToanKH",  _ExpDoiSoatChiTiet.ThanhToanKH, 
					"@DaThanhToanKH",  _ExpDoiSoatChiTiet.DaThanhToanKH, 
					"@PhuongThucThanhToan",  _ExpDoiSoatChiTiet.PhuongThucThanhToan, 
					"@NgayThanhToan", this._dataContext.ConvertDateString( _ExpDoiSoatChiTiet.NgayThanhToan), 
					"@GhiChu",  _ExpDoiSoatChiTiet.GhiChu, 
					"@IsHoanThanh",  _ExpDoiSoatChiTiet.IsHoanThanh);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpDoiSoatChiTiet vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpDoiSoatChiTiet> _ExpDoiSoatChiTiets)
		{
			foreach (ExpDoiSoatChiTiet item in _ExpDoiSoatChiTiets)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpDoiSoatChiTiet vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpDoiSoatChiTiet _ExpDoiSoatChiTiet, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpDoiSoatChiTiet] SET Id=@Id, FK_DoiSoat=@FK_DoiSoat, TenKhachHang=@TenKhachHang, SoDienThoai=@SoDienThoai, SoLuongDon=@SoLuongDon, ThuHo=@ThuHo, ThuHoKT=@ThuHoKT, SaiLech=@SaiLech, CuocGuiTra=@CuocGuiTra, CuocNhanTra=@CuocNhanTra, ChiPhi=@ChiPhi, LoiNhuan=@LoiNhuan, ThanhToanKH=@ThanhToanKH, DaThanhToanKH=@DaThanhToanKH, PhuongThucThanhToan=@PhuongThucThanhToan, NgayThanhToan=@NgayThanhToan, GhiChu=@GhiChu, IsHoanThanh=@IsHoanThanh WHERE Id=@Id", 
					"@Id",  _ExpDoiSoatChiTiet.Id, 
					"@FK_DoiSoat",  _ExpDoiSoatChiTiet.FK_DoiSoat, 
					"@TenKhachHang",  _ExpDoiSoatChiTiet.TenKhachHang, 
					"@SoDienThoai",  _ExpDoiSoatChiTiet.SoDienThoai, 
					"@SoLuongDon",  _ExpDoiSoatChiTiet.SoLuongDon, 
					"@ThuHo",  _ExpDoiSoatChiTiet.ThuHo, 
					"@ThuHoKT",  _ExpDoiSoatChiTiet.ThuHoKT, 
					"@SaiLech",  _ExpDoiSoatChiTiet.SaiLech, 
					"@CuocGuiTra",  _ExpDoiSoatChiTiet.CuocGuiTra, 
					"@CuocNhanTra",  _ExpDoiSoatChiTiet.CuocNhanTra, 
					"@ChiPhi",  _ExpDoiSoatChiTiet.ChiPhi, 
					"@LoiNhuan",  _ExpDoiSoatChiTiet.LoiNhuan, 
					"@ThanhToanKH",  _ExpDoiSoatChiTiet.ThanhToanKH, 
					"@DaThanhToanKH",  _ExpDoiSoatChiTiet.DaThanhToanKH, 
					"@PhuongThucThanhToan",  _ExpDoiSoatChiTiet.PhuongThucThanhToan, 
					"@NgayThanhToan", this._dataContext.ConvertDateString( _ExpDoiSoatChiTiet.NgayThanhToan), 
					"@GhiChu",  _ExpDoiSoatChiTiet.GhiChu, 
					"@IsHoanThanh",  _ExpDoiSoatChiTiet.IsHoanThanh, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpDoiSoatChiTiet vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpDoiSoatChiTiet _ExpDoiSoatChiTiet)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpDoiSoatChiTiet] SET FK_DoiSoat=@FK_DoiSoat, TenKhachHang=@TenKhachHang, SoDienThoai=@SoDienThoai, SoLuongDon=@SoLuongDon, ThuHo=@ThuHo, ThuHoKT=@ThuHoKT, SaiLech=@SaiLech, CuocGuiTra=@CuocGuiTra, CuocNhanTra=@CuocNhanTra, ChiPhi=@ChiPhi, LoiNhuan=@LoiNhuan, ThanhToanKH=@ThanhToanKH, DaThanhToanKH=@DaThanhToanKH, PhuongThucThanhToan=@PhuongThucThanhToan, NgayThanhToan=@NgayThanhToan, GhiChu=@GhiChu, IsHoanThanh=@IsHoanThanh WHERE Id=@Id", 
					"@FK_DoiSoat",  _ExpDoiSoatChiTiet.FK_DoiSoat, 
					"@TenKhachHang",  _ExpDoiSoatChiTiet.TenKhachHang, 
					"@SoDienThoai",  _ExpDoiSoatChiTiet.SoDienThoai, 
					"@SoLuongDon",  _ExpDoiSoatChiTiet.SoLuongDon, 
					"@ThuHo",  _ExpDoiSoatChiTiet.ThuHo, 
					"@ThuHoKT",  _ExpDoiSoatChiTiet.ThuHoKT, 
					"@SaiLech",  _ExpDoiSoatChiTiet.SaiLech, 
					"@CuocGuiTra",  _ExpDoiSoatChiTiet.CuocGuiTra, 
					"@CuocNhanTra",  _ExpDoiSoatChiTiet.CuocNhanTra, 
					"@ChiPhi",  _ExpDoiSoatChiTiet.ChiPhi, 
					"@LoiNhuan",  _ExpDoiSoatChiTiet.LoiNhuan, 
					"@ThanhToanKH",  _ExpDoiSoatChiTiet.ThanhToanKH, 
					"@DaThanhToanKH",  _ExpDoiSoatChiTiet.DaThanhToanKH, 
					"@PhuongThucThanhToan",  _ExpDoiSoatChiTiet.PhuongThucThanhToan, 
					"@NgayThanhToan", this._dataContext.ConvertDateString( _ExpDoiSoatChiTiet.NgayThanhToan), 
					"@GhiChu",  _ExpDoiSoatChiTiet.GhiChu, 
					"@IsHoanThanh",  _ExpDoiSoatChiTiet.IsHoanThanh, 
					"@Id", _ExpDoiSoatChiTiet.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpDoiSoatChiTiet vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpDoiSoatChiTiet> _ExpDoiSoatChiTiets)
		{
			foreach (ExpDoiSoatChiTiet item in _ExpDoiSoatChiTiets)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpDoiSoatChiTiet vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpDoiSoatChiTiet _ExpDoiSoatChiTiet, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpDoiSoatChiTiet] SET Id=@Id, FK_DoiSoat=@FK_DoiSoat, TenKhachHang=@TenKhachHang, SoDienThoai=@SoDienThoai, SoLuongDon=@SoLuongDon, ThuHo=@ThuHo, ThuHoKT=@ThuHoKT, SaiLech=@SaiLech, CuocGuiTra=@CuocGuiTra, CuocNhanTra=@CuocNhanTra, ChiPhi=@ChiPhi, LoiNhuan=@LoiNhuan, ThanhToanKH=@ThanhToanKH, DaThanhToanKH=@DaThanhToanKH, PhuongThucThanhToan=@PhuongThucThanhToan, NgayThanhToan=@NgayThanhToan, GhiChu=@GhiChu, IsHoanThanh=@IsHoanThanh "+ condition, 
					"@Id",  _ExpDoiSoatChiTiet.Id, 
					"@FK_DoiSoat",  _ExpDoiSoatChiTiet.FK_DoiSoat, 
					"@TenKhachHang",  _ExpDoiSoatChiTiet.TenKhachHang, 
					"@SoDienThoai",  _ExpDoiSoatChiTiet.SoDienThoai, 
					"@SoLuongDon",  _ExpDoiSoatChiTiet.SoLuongDon, 
					"@ThuHo",  _ExpDoiSoatChiTiet.ThuHo, 
					"@ThuHoKT",  _ExpDoiSoatChiTiet.ThuHoKT, 
					"@SaiLech",  _ExpDoiSoatChiTiet.SaiLech, 
					"@CuocGuiTra",  _ExpDoiSoatChiTiet.CuocGuiTra, 
					"@CuocNhanTra",  _ExpDoiSoatChiTiet.CuocNhanTra, 
					"@ChiPhi",  _ExpDoiSoatChiTiet.ChiPhi, 
					"@LoiNhuan",  _ExpDoiSoatChiTiet.LoiNhuan, 
					"@ThanhToanKH",  _ExpDoiSoatChiTiet.ThanhToanKH, 
					"@DaThanhToanKH",  _ExpDoiSoatChiTiet.DaThanhToanKH, 
					"@PhuongThucThanhToan",  _ExpDoiSoatChiTiet.PhuongThucThanhToan, 
					"@NgayThanhToan", this._dataContext.ConvertDateString( _ExpDoiSoatChiTiet.NgayThanhToan), 
					"@GhiChu",  _ExpDoiSoatChiTiet.GhiChu, 
					"@IsHoanThanh",  _ExpDoiSoatChiTiet.IsHoanThanh);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpDoiSoatChiTiet trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpDoiSoatChiTiet] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpDoiSoatChiTiet trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpDoiSoatChiTiet _ExpDoiSoatChiTiet)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpDoiSoatChiTiet] WHERE Id=@Id",
					"@Id", _ExpDoiSoatChiTiet.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpDoiSoatChiTiet trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpDoiSoatChiTiet] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpDoiSoatChiTiet trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpDoiSoatChiTiet> _ExpDoiSoatChiTiets)
		{
			foreach (ExpDoiSoatChiTiet item in _ExpDoiSoatChiTiets)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
