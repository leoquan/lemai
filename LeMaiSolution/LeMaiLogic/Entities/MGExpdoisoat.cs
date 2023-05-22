using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpdoisoat:IGExpdoisoat
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpdoisoat(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpDoiSoat từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDoiSoat]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpDoiSoat từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDoiSoat] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpDoiSoat từ Database
		/// </summary>
		public List<GExpDoiSoat> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDoiSoat]");
				List<GExpDoiSoat> items = new List<GExpDoiSoat>();
				GExpDoiSoat item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpDoiSoat();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Post"] != null && dr["Post"] != DBNull.Value)
					{
						item.Post = Convert.ToString(dr["Post"]);
					}
					if (dr["NguoiDoiSoat"] != null && dr["NguoiDoiSoat"] != DBNull.Value)
					{
						item.NguoiDoiSoat = Convert.ToString(dr["NguoiDoiSoat"]);
					}
					if (dr["NgayDoiSoat"] != null && dr["NgayDoiSoat"] != DBNull.Value)
					{
						item.NgayDoiSoat = Convert.ToDateTime(dr["NgayDoiSoat"]);
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
					if (dr["GhiChu"] != null && dr["GhiChu"] != DBNull.Value)
					{
						item.GhiChu = Convert.ToString(dr["GhiChu"]);
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
		/// Lấy danh sách GExpDoiSoat từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpDoiSoat> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpDoiSoat] A "+ condition,  parameters);
				List<GExpDoiSoat> items = new List<GExpDoiSoat>();
				GExpDoiSoat item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpDoiSoat();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Post"] != null && dr["Post"] != DBNull.Value)
					{
						item.Post = Convert.ToString(dr["Post"]);
					}
					if (dr["NguoiDoiSoat"] != null && dr["NguoiDoiSoat"] != DBNull.Value)
					{
						item.NguoiDoiSoat = Convert.ToString(dr["NguoiDoiSoat"]);
					}
					if (dr["NgayDoiSoat"] != null && dr["NgayDoiSoat"] != DBNull.Value)
					{
						item.NgayDoiSoat = Convert.ToDateTime(dr["NgayDoiSoat"]);
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
					if (dr["GhiChu"] != null && dr["GhiChu"] != DBNull.Value)
					{
						item.GhiChu = Convert.ToString(dr["GhiChu"]);
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

		public List<GExpDoiSoat> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpDoiSoat] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpDoiSoat] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpDoiSoat>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpDoiSoat từ Database
		/// </summary>
		public GExpDoiSoat GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDoiSoat] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpDoiSoat item=new GExpDoiSoat();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Post"] != null && dr["Post"] != DBNull.Value)
						{
							item.Post = Convert.ToString(dr["Post"]);
						}
						if (dr["NguoiDoiSoat"] != null && dr["NguoiDoiSoat"] != DBNull.Value)
						{
							item.NguoiDoiSoat = Convert.ToString(dr["NguoiDoiSoat"]);
						}
						if (dr["NgayDoiSoat"] != null && dr["NgayDoiSoat"] != DBNull.Value)
						{
							item.NgayDoiSoat = Convert.ToDateTime(dr["NgayDoiSoat"]);
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
						if (dr["GhiChu"] != null && dr["GhiChu"] != DBNull.Value)
						{
							item.GhiChu = Convert.ToString(dr["GhiChu"]);
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
		/// Lấy một GExpDoiSoat đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpDoiSoat GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpDoiSoat] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpDoiSoat item=new GExpDoiSoat();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Post"] != null && dr["Post"] != DBNull.Value)
						{
							item.Post = Convert.ToString(dr["Post"]);
						}
						if (dr["NguoiDoiSoat"] != null && dr["NguoiDoiSoat"] != DBNull.Value)
						{
							item.NguoiDoiSoat = Convert.ToString(dr["NguoiDoiSoat"]);
						}
						if (dr["NgayDoiSoat"] != null && dr["NgayDoiSoat"] != DBNull.Value)
						{
							item.NgayDoiSoat = Convert.ToDateTime(dr["NgayDoiSoat"]);
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
						if (dr["GhiChu"] != null && dr["GhiChu"] != DBNull.Value)
						{
							item.GhiChu = Convert.ToString(dr["GhiChu"]);
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

		public GExpDoiSoat GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpDoiSoat] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpDoiSoat>(ds);
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
		/// Thêm mới GExpDoiSoat vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpDoiSoat _GExpDoiSoat)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpDoiSoat](Id, Post, NguoiDoiSoat, NgayDoiSoat, SoLuongDon, ThuHo, ThuHoKT, SaiLech, CuocGuiTra, CuocNhanTra, ChiPhi, LoiNhuan, ThanhToanKH, DaThanhToanKH, GhiChu) VALUES(@Id, @Post, @NguoiDoiSoat, @NgayDoiSoat, @SoLuongDon, @ThuHo, @ThuHoKT, @SaiLech, @CuocGuiTra, @CuocNhanTra, @ChiPhi, @LoiNhuan, @ThanhToanKH, @DaThanhToanKH, @GhiChu)", 
					"@Id",  _GExpDoiSoat.Id, 
					"@Post",  _GExpDoiSoat.Post, 
					"@NguoiDoiSoat",  _GExpDoiSoat.NguoiDoiSoat, 
					"@NgayDoiSoat", this._dataContext.ConvertDateString( _GExpDoiSoat.NgayDoiSoat), 
					"@SoLuongDon",  _GExpDoiSoat.SoLuongDon, 
					"@ThuHo",  _GExpDoiSoat.ThuHo, 
					"@ThuHoKT",  _GExpDoiSoat.ThuHoKT, 
					"@SaiLech",  _GExpDoiSoat.SaiLech, 
					"@CuocGuiTra",  _GExpDoiSoat.CuocGuiTra, 
					"@CuocNhanTra",  _GExpDoiSoat.CuocNhanTra, 
					"@ChiPhi",  _GExpDoiSoat.ChiPhi, 
					"@LoiNhuan",  _GExpDoiSoat.LoiNhuan, 
					"@ThanhToanKH",  _GExpDoiSoat.ThanhToanKH, 
					"@DaThanhToanKH",  _GExpDoiSoat.DaThanhToanKH, 
					"@GhiChu",  _GExpDoiSoat.GhiChu);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpDoiSoat vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpDoiSoat> _GExpDoiSoats)
		{
			foreach (GExpDoiSoat item in _GExpDoiSoats)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpDoiSoat vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpDoiSoat _GExpDoiSoat, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDoiSoat] SET Id=@Id, Post=@Post, NguoiDoiSoat=@NguoiDoiSoat, NgayDoiSoat=@NgayDoiSoat, SoLuongDon=@SoLuongDon, ThuHo=@ThuHo, ThuHoKT=@ThuHoKT, SaiLech=@SaiLech, CuocGuiTra=@CuocGuiTra, CuocNhanTra=@CuocNhanTra, ChiPhi=@ChiPhi, LoiNhuan=@LoiNhuan, ThanhToanKH=@ThanhToanKH, DaThanhToanKH=@DaThanhToanKH, GhiChu=@GhiChu WHERE Id=@Id", 
					"@Id",  _GExpDoiSoat.Id, 
					"@Post",  _GExpDoiSoat.Post, 
					"@NguoiDoiSoat",  _GExpDoiSoat.NguoiDoiSoat, 
					"@NgayDoiSoat", this._dataContext.ConvertDateString( _GExpDoiSoat.NgayDoiSoat), 
					"@SoLuongDon",  _GExpDoiSoat.SoLuongDon, 
					"@ThuHo",  _GExpDoiSoat.ThuHo, 
					"@ThuHoKT",  _GExpDoiSoat.ThuHoKT, 
					"@SaiLech",  _GExpDoiSoat.SaiLech, 
					"@CuocGuiTra",  _GExpDoiSoat.CuocGuiTra, 
					"@CuocNhanTra",  _GExpDoiSoat.CuocNhanTra, 
					"@ChiPhi",  _GExpDoiSoat.ChiPhi, 
					"@LoiNhuan",  _GExpDoiSoat.LoiNhuan, 
					"@ThanhToanKH",  _GExpDoiSoat.ThanhToanKH, 
					"@DaThanhToanKH",  _GExpDoiSoat.DaThanhToanKH, 
					"@GhiChu",  _GExpDoiSoat.GhiChu, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpDoiSoat vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpDoiSoat _GExpDoiSoat)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDoiSoat] SET Post=@Post, NguoiDoiSoat=@NguoiDoiSoat, NgayDoiSoat=@NgayDoiSoat, SoLuongDon=@SoLuongDon, ThuHo=@ThuHo, ThuHoKT=@ThuHoKT, SaiLech=@SaiLech, CuocGuiTra=@CuocGuiTra, CuocNhanTra=@CuocNhanTra, ChiPhi=@ChiPhi, LoiNhuan=@LoiNhuan, ThanhToanKH=@ThanhToanKH, DaThanhToanKH=@DaThanhToanKH, GhiChu=@GhiChu WHERE Id=@Id", 
					"@Post",  _GExpDoiSoat.Post, 
					"@NguoiDoiSoat",  _GExpDoiSoat.NguoiDoiSoat, 
					"@NgayDoiSoat", this._dataContext.ConvertDateString( _GExpDoiSoat.NgayDoiSoat), 
					"@SoLuongDon",  _GExpDoiSoat.SoLuongDon, 
					"@ThuHo",  _GExpDoiSoat.ThuHo, 
					"@ThuHoKT",  _GExpDoiSoat.ThuHoKT, 
					"@SaiLech",  _GExpDoiSoat.SaiLech, 
					"@CuocGuiTra",  _GExpDoiSoat.CuocGuiTra, 
					"@CuocNhanTra",  _GExpDoiSoat.CuocNhanTra, 
					"@ChiPhi",  _GExpDoiSoat.ChiPhi, 
					"@LoiNhuan",  _GExpDoiSoat.LoiNhuan, 
					"@ThanhToanKH",  _GExpDoiSoat.ThanhToanKH, 
					"@DaThanhToanKH",  _GExpDoiSoat.DaThanhToanKH, 
					"@GhiChu",  _GExpDoiSoat.GhiChu, 
					"@Id", _GExpDoiSoat.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpDoiSoat vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpDoiSoat> _GExpDoiSoats)
		{
			foreach (GExpDoiSoat item in _GExpDoiSoats)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpDoiSoat vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpDoiSoat _GExpDoiSoat, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDoiSoat] SET Id=@Id, Post=@Post, NguoiDoiSoat=@NguoiDoiSoat, NgayDoiSoat=@NgayDoiSoat, SoLuongDon=@SoLuongDon, ThuHo=@ThuHo, ThuHoKT=@ThuHoKT, SaiLech=@SaiLech, CuocGuiTra=@CuocGuiTra, CuocNhanTra=@CuocNhanTra, ChiPhi=@ChiPhi, LoiNhuan=@LoiNhuan, ThanhToanKH=@ThanhToanKH, DaThanhToanKH=@DaThanhToanKH, GhiChu=@GhiChu "+ condition, 
					"@Id",  _GExpDoiSoat.Id, 
					"@Post",  _GExpDoiSoat.Post, 
					"@NguoiDoiSoat",  _GExpDoiSoat.NguoiDoiSoat, 
					"@NgayDoiSoat", this._dataContext.ConvertDateString( _GExpDoiSoat.NgayDoiSoat), 
					"@SoLuongDon",  _GExpDoiSoat.SoLuongDon, 
					"@ThuHo",  _GExpDoiSoat.ThuHo, 
					"@ThuHoKT",  _GExpDoiSoat.ThuHoKT, 
					"@SaiLech",  _GExpDoiSoat.SaiLech, 
					"@CuocGuiTra",  _GExpDoiSoat.CuocGuiTra, 
					"@CuocNhanTra",  _GExpDoiSoat.CuocNhanTra, 
					"@ChiPhi",  _GExpDoiSoat.ChiPhi, 
					"@LoiNhuan",  _GExpDoiSoat.LoiNhuan, 
					"@ThanhToanKH",  _GExpDoiSoat.ThanhToanKH, 
					"@DaThanhToanKH",  _GExpDoiSoat.DaThanhToanKH, 
					"@GhiChu",  _GExpDoiSoat.GhiChu);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpDoiSoat trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDoiSoat] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDoiSoat trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpDoiSoat _GExpDoiSoat)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDoiSoat] WHERE Id=@Id",
					"@Id", _GExpDoiSoat.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDoiSoat trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDoiSoat] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDoiSoat trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpDoiSoat> _GExpDoiSoats)
		{
			foreach (GExpDoiSoat item in _GExpDoiSoats)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
