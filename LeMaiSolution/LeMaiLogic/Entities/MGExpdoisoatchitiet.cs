using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpdoisoatchitiet:IGExpdoisoatchitiet
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpdoisoatchitiet(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpDoiSoatChiTiet từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDoiSoatChiTiet]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpDoiSoatChiTiet từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDoiSoatChiTiet] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpDoiSoatChiTiet từ Database
		/// </summary>
		public List<GExpDoiSoatChiTiet> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDoiSoatChiTiet]");
				List<GExpDoiSoatChiTiet> items = new List<GExpDoiSoatChiTiet>();
				GExpDoiSoatChiTiet item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpDoiSoatChiTiet();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_DoiSoat"] != null && dr["FK_DoiSoat"] != DBNull.Value)
					{
						item.FK_DoiSoat = Convert.ToString(dr["FK_DoiSoat"]);
					}
					if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
					{
						item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
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
		/// Lấy danh sách GExpDoiSoatChiTiet từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpDoiSoatChiTiet> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpDoiSoatChiTiet] A "+ condition,  parameters);
				List<GExpDoiSoatChiTiet> items = new List<GExpDoiSoatChiTiet>();
				GExpDoiSoatChiTiet item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpDoiSoatChiTiet();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_DoiSoat"] != null && dr["FK_DoiSoat"] != DBNull.Value)
					{
						item.FK_DoiSoat = Convert.ToString(dr["FK_DoiSoat"]);
					}
					if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
					{
						item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
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

		public List<GExpDoiSoatChiTiet> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpDoiSoatChiTiet] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpDoiSoatChiTiet] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpDoiSoatChiTiet>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpDoiSoatChiTiet từ Database
		/// </summary>
		public GExpDoiSoatChiTiet GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDoiSoatChiTiet] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpDoiSoatChiTiet item=new GExpDoiSoatChiTiet();
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
						if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
						{
							item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
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
		/// Lấy một GExpDoiSoatChiTiet đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpDoiSoatChiTiet GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpDoiSoatChiTiet] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpDoiSoatChiTiet item=new GExpDoiSoatChiTiet();
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
						if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
						{
							item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
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

		public GExpDoiSoatChiTiet GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpDoiSoatChiTiet] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpDoiSoatChiTiet>(ds);
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
		/// Thêm mới GExpDoiSoatChiTiet vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpDoiSoatChiTiet _GExpDoiSoatChiTiet)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpDoiSoatChiTiet](Id, FK_DoiSoat, FK_Customer, TenKhachHang, SoDienThoai, SoLuongDon, ThuHo, ThuHoKT, SaiLech, CuocGuiTra, CuocNhanTra, ChiPhi, LoiNhuan, ThanhToanKH, DaThanhToanKH, PhuongThucThanhToan, NgayThanhToan, GhiChu, IsHoanThanh) VALUES(@Id, @FK_DoiSoat, @FK_Customer, @TenKhachHang, @SoDienThoai, @SoLuongDon, @ThuHo, @ThuHoKT, @SaiLech, @CuocGuiTra, @CuocNhanTra, @ChiPhi, @LoiNhuan, @ThanhToanKH, @DaThanhToanKH, @PhuongThucThanhToan, @NgayThanhToan, @GhiChu, @IsHoanThanh)", 
					"@Id",  _GExpDoiSoatChiTiet.Id, 
					"@FK_DoiSoat",  _GExpDoiSoatChiTiet.FK_DoiSoat, 
					"@FK_Customer",  _GExpDoiSoatChiTiet.FK_Customer, 
					"@TenKhachHang",  _GExpDoiSoatChiTiet.TenKhachHang, 
					"@SoDienThoai",  _GExpDoiSoatChiTiet.SoDienThoai, 
					"@SoLuongDon",  _GExpDoiSoatChiTiet.SoLuongDon, 
					"@ThuHo",  _GExpDoiSoatChiTiet.ThuHo, 
					"@ThuHoKT",  _GExpDoiSoatChiTiet.ThuHoKT, 
					"@SaiLech",  _GExpDoiSoatChiTiet.SaiLech, 
					"@CuocGuiTra",  _GExpDoiSoatChiTiet.CuocGuiTra, 
					"@CuocNhanTra",  _GExpDoiSoatChiTiet.CuocNhanTra, 
					"@ChiPhi",  _GExpDoiSoatChiTiet.ChiPhi, 
					"@LoiNhuan",  _GExpDoiSoatChiTiet.LoiNhuan, 
					"@ThanhToanKH",  _GExpDoiSoatChiTiet.ThanhToanKH, 
					"@DaThanhToanKH",  _GExpDoiSoatChiTiet.DaThanhToanKH, 
					"@PhuongThucThanhToan",  _GExpDoiSoatChiTiet.PhuongThucThanhToan, 
					"@NgayThanhToan", this._dataContext.ConvertDateString( _GExpDoiSoatChiTiet.NgayThanhToan), 
					"@GhiChu",  _GExpDoiSoatChiTiet.GhiChu, 
					"@IsHoanThanh",  _GExpDoiSoatChiTiet.IsHoanThanh);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpDoiSoatChiTiet vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpDoiSoatChiTiet> _GExpDoiSoatChiTiets)
		{
			foreach (GExpDoiSoatChiTiet item in _GExpDoiSoatChiTiets)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpDoiSoatChiTiet vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpDoiSoatChiTiet _GExpDoiSoatChiTiet, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDoiSoatChiTiet] SET Id=@Id, FK_DoiSoat=@FK_DoiSoat, FK_Customer=@FK_Customer, TenKhachHang=@TenKhachHang, SoDienThoai=@SoDienThoai, SoLuongDon=@SoLuongDon, ThuHo=@ThuHo, ThuHoKT=@ThuHoKT, SaiLech=@SaiLech, CuocGuiTra=@CuocGuiTra, CuocNhanTra=@CuocNhanTra, ChiPhi=@ChiPhi, LoiNhuan=@LoiNhuan, ThanhToanKH=@ThanhToanKH, DaThanhToanKH=@DaThanhToanKH, PhuongThucThanhToan=@PhuongThucThanhToan, NgayThanhToan=@NgayThanhToan, GhiChu=@GhiChu, IsHoanThanh=@IsHoanThanh WHERE Id=@Id", 
					"@Id",  _GExpDoiSoatChiTiet.Id, 
					"@FK_DoiSoat",  _GExpDoiSoatChiTiet.FK_DoiSoat, 
					"@FK_Customer",  _GExpDoiSoatChiTiet.FK_Customer, 
					"@TenKhachHang",  _GExpDoiSoatChiTiet.TenKhachHang, 
					"@SoDienThoai",  _GExpDoiSoatChiTiet.SoDienThoai, 
					"@SoLuongDon",  _GExpDoiSoatChiTiet.SoLuongDon, 
					"@ThuHo",  _GExpDoiSoatChiTiet.ThuHo, 
					"@ThuHoKT",  _GExpDoiSoatChiTiet.ThuHoKT, 
					"@SaiLech",  _GExpDoiSoatChiTiet.SaiLech, 
					"@CuocGuiTra",  _GExpDoiSoatChiTiet.CuocGuiTra, 
					"@CuocNhanTra",  _GExpDoiSoatChiTiet.CuocNhanTra, 
					"@ChiPhi",  _GExpDoiSoatChiTiet.ChiPhi, 
					"@LoiNhuan",  _GExpDoiSoatChiTiet.LoiNhuan, 
					"@ThanhToanKH",  _GExpDoiSoatChiTiet.ThanhToanKH, 
					"@DaThanhToanKH",  _GExpDoiSoatChiTiet.DaThanhToanKH, 
					"@PhuongThucThanhToan",  _GExpDoiSoatChiTiet.PhuongThucThanhToan, 
					"@NgayThanhToan", this._dataContext.ConvertDateString( _GExpDoiSoatChiTiet.NgayThanhToan), 
					"@GhiChu",  _GExpDoiSoatChiTiet.GhiChu, 
					"@IsHoanThanh",  _GExpDoiSoatChiTiet.IsHoanThanh, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpDoiSoatChiTiet vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpDoiSoatChiTiet _GExpDoiSoatChiTiet)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDoiSoatChiTiet] SET FK_DoiSoat=@FK_DoiSoat, FK_Customer=@FK_Customer, TenKhachHang=@TenKhachHang, SoDienThoai=@SoDienThoai, SoLuongDon=@SoLuongDon, ThuHo=@ThuHo, ThuHoKT=@ThuHoKT, SaiLech=@SaiLech, CuocGuiTra=@CuocGuiTra, CuocNhanTra=@CuocNhanTra, ChiPhi=@ChiPhi, LoiNhuan=@LoiNhuan, ThanhToanKH=@ThanhToanKH, DaThanhToanKH=@DaThanhToanKH, PhuongThucThanhToan=@PhuongThucThanhToan, NgayThanhToan=@NgayThanhToan, GhiChu=@GhiChu, IsHoanThanh=@IsHoanThanh WHERE Id=@Id", 
					"@FK_DoiSoat",  _GExpDoiSoatChiTiet.FK_DoiSoat, 
					"@FK_Customer",  _GExpDoiSoatChiTiet.FK_Customer, 
					"@TenKhachHang",  _GExpDoiSoatChiTiet.TenKhachHang, 
					"@SoDienThoai",  _GExpDoiSoatChiTiet.SoDienThoai, 
					"@SoLuongDon",  _GExpDoiSoatChiTiet.SoLuongDon, 
					"@ThuHo",  _GExpDoiSoatChiTiet.ThuHo, 
					"@ThuHoKT",  _GExpDoiSoatChiTiet.ThuHoKT, 
					"@SaiLech",  _GExpDoiSoatChiTiet.SaiLech, 
					"@CuocGuiTra",  _GExpDoiSoatChiTiet.CuocGuiTra, 
					"@CuocNhanTra",  _GExpDoiSoatChiTiet.CuocNhanTra, 
					"@ChiPhi",  _GExpDoiSoatChiTiet.ChiPhi, 
					"@LoiNhuan",  _GExpDoiSoatChiTiet.LoiNhuan, 
					"@ThanhToanKH",  _GExpDoiSoatChiTiet.ThanhToanKH, 
					"@DaThanhToanKH",  _GExpDoiSoatChiTiet.DaThanhToanKH, 
					"@PhuongThucThanhToan",  _GExpDoiSoatChiTiet.PhuongThucThanhToan, 
					"@NgayThanhToan", this._dataContext.ConvertDateString( _GExpDoiSoatChiTiet.NgayThanhToan), 
					"@GhiChu",  _GExpDoiSoatChiTiet.GhiChu, 
					"@IsHoanThanh",  _GExpDoiSoatChiTiet.IsHoanThanh, 
					"@Id", _GExpDoiSoatChiTiet.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpDoiSoatChiTiet vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpDoiSoatChiTiet> _GExpDoiSoatChiTiets)
		{
			foreach (GExpDoiSoatChiTiet item in _GExpDoiSoatChiTiets)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpDoiSoatChiTiet vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpDoiSoatChiTiet _GExpDoiSoatChiTiet, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDoiSoatChiTiet] SET Id=@Id, FK_DoiSoat=@FK_DoiSoat, FK_Customer=@FK_Customer, TenKhachHang=@TenKhachHang, SoDienThoai=@SoDienThoai, SoLuongDon=@SoLuongDon, ThuHo=@ThuHo, ThuHoKT=@ThuHoKT, SaiLech=@SaiLech, CuocGuiTra=@CuocGuiTra, CuocNhanTra=@CuocNhanTra, ChiPhi=@ChiPhi, LoiNhuan=@LoiNhuan, ThanhToanKH=@ThanhToanKH, DaThanhToanKH=@DaThanhToanKH, PhuongThucThanhToan=@PhuongThucThanhToan, NgayThanhToan=@NgayThanhToan, GhiChu=@GhiChu, IsHoanThanh=@IsHoanThanh "+ condition, 
					"@Id",  _GExpDoiSoatChiTiet.Id, 
					"@FK_DoiSoat",  _GExpDoiSoatChiTiet.FK_DoiSoat, 
					"@FK_Customer",  _GExpDoiSoatChiTiet.FK_Customer, 
					"@TenKhachHang",  _GExpDoiSoatChiTiet.TenKhachHang, 
					"@SoDienThoai",  _GExpDoiSoatChiTiet.SoDienThoai, 
					"@SoLuongDon",  _GExpDoiSoatChiTiet.SoLuongDon, 
					"@ThuHo",  _GExpDoiSoatChiTiet.ThuHo, 
					"@ThuHoKT",  _GExpDoiSoatChiTiet.ThuHoKT, 
					"@SaiLech",  _GExpDoiSoatChiTiet.SaiLech, 
					"@CuocGuiTra",  _GExpDoiSoatChiTiet.CuocGuiTra, 
					"@CuocNhanTra",  _GExpDoiSoatChiTiet.CuocNhanTra, 
					"@ChiPhi",  _GExpDoiSoatChiTiet.ChiPhi, 
					"@LoiNhuan",  _GExpDoiSoatChiTiet.LoiNhuan, 
					"@ThanhToanKH",  _GExpDoiSoatChiTiet.ThanhToanKH, 
					"@DaThanhToanKH",  _GExpDoiSoatChiTiet.DaThanhToanKH, 
					"@PhuongThucThanhToan",  _GExpDoiSoatChiTiet.PhuongThucThanhToan, 
					"@NgayThanhToan", this._dataContext.ConvertDateString( _GExpDoiSoatChiTiet.NgayThanhToan), 
					"@GhiChu",  _GExpDoiSoatChiTiet.GhiChu, 
					"@IsHoanThanh",  _GExpDoiSoatChiTiet.IsHoanThanh);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpDoiSoatChiTiet trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDoiSoatChiTiet] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDoiSoatChiTiet trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpDoiSoatChiTiet _GExpDoiSoatChiTiet)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDoiSoatChiTiet] WHERE Id=@Id",
					"@Id", _GExpDoiSoatChiTiet.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDoiSoatChiTiet trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDoiSoatChiTiet] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDoiSoatChiTiet trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpDoiSoatChiTiet> _GExpDoiSoatChiTiets)
		{
			foreach (GExpDoiSoatChiTiet item in _GExpDoiSoatChiTiets)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
