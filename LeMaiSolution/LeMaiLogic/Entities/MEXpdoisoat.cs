using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpdoisoat:IEXpdoisoat
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpdoisoat(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpDoiSoat từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpDoiSoat]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpDoiSoat từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpDoiSoat] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpDoiSoat từ Database
		/// </summary>
		public List<ExpDoiSoat> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpDoiSoat]");
				List<ExpDoiSoat> items = new List<ExpDoiSoat>();
				ExpDoiSoat item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpDoiSoat();
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
		/// Lấy danh sách ExpDoiSoat từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpDoiSoat> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpDoiSoat] A "+ condition,  parameters);
				List<ExpDoiSoat> items = new List<ExpDoiSoat>();
				ExpDoiSoat item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpDoiSoat();
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

		public List<ExpDoiSoat> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpDoiSoat] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpDoiSoat] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpDoiSoat>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpDoiSoat từ Database
		/// </summary>
		public ExpDoiSoat GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpDoiSoat] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpDoiSoat item=new ExpDoiSoat();
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
		/// Lấy một ExpDoiSoat đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpDoiSoat GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpDoiSoat] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpDoiSoat item=new ExpDoiSoat();
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

		public ExpDoiSoat GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpDoiSoat] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpDoiSoat>(ds);
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
		/// Thêm mới ExpDoiSoat vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpDoiSoat _ExpDoiSoat)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpDoiSoat](Id, Post, NguoiDoiSoat, NgayDoiSoat, SoLuongDon, ThuHo, ThuHoKT, SaiLech, CuocGuiTra, CuocNhanTra, ChiPhi, LoiNhuan, ThanhToanKH, DaThanhToanKH, GhiChu) VALUES(@Id, @Post, @NguoiDoiSoat, @NgayDoiSoat, @SoLuongDon, @ThuHo, @ThuHoKT, @SaiLech, @CuocGuiTra, @CuocNhanTra, @ChiPhi, @LoiNhuan, @ThanhToanKH, @DaThanhToanKH, @GhiChu)", 
					"@Id",  _ExpDoiSoat.Id, 
					"@Post",  _ExpDoiSoat.Post, 
					"@NguoiDoiSoat",  _ExpDoiSoat.NguoiDoiSoat, 
					"@NgayDoiSoat", this._dataContext.ConvertDateString( _ExpDoiSoat.NgayDoiSoat), 
					"@SoLuongDon",  _ExpDoiSoat.SoLuongDon, 
					"@ThuHo",  _ExpDoiSoat.ThuHo, 
					"@ThuHoKT",  _ExpDoiSoat.ThuHoKT, 
					"@SaiLech",  _ExpDoiSoat.SaiLech, 
					"@CuocGuiTra",  _ExpDoiSoat.CuocGuiTra, 
					"@CuocNhanTra",  _ExpDoiSoat.CuocNhanTra, 
					"@ChiPhi",  _ExpDoiSoat.ChiPhi, 
					"@LoiNhuan",  _ExpDoiSoat.LoiNhuan, 
					"@ThanhToanKH",  _ExpDoiSoat.ThanhToanKH, 
					"@DaThanhToanKH",  _ExpDoiSoat.DaThanhToanKH, 
					"@GhiChu",  _ExpDoiSoat.GhiChu);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpDoiSoat vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpDoiSoat> _ExpDoiSoats)
		{
			foreach (ExpDoiSoat item in _ExpDoiSoats)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpDoiSoat vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpDoiSoat _ExpDoiSoat, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpDoiSoat] SET Id=@Id, Post=@Post, NguoiDoiSoat=@NguoiDoiSoat, NgayDoiSoat=@NgayDoiSoat, SoLuongDon=@SoLuongDon, ThuHo=@ThuHo, ThuHoKT=@ThuHoKT, SaiLech=@SaiLech, CuocGuiTra=@CuocGuiTra, CuocNhanTra=@CuocNhanTra, ChiPhi=@ChiPhi, LoiNhuan=@LoiNhuan, ThanhToanKH=@ThanhToanKH, DaThanhToanKH=@DaThanhToanKH, GhiChu=@GhiChu WHERE Id=@Id", 
					"@Id",  _ExpDoiSoat.Id, 
					"@Post",  _ExpDoiSoat.Post, 
					"@NguoiDoiSoat",  _ExpDoiSoat.NguoiDoiSoat, 
					"@NgayDoiSoat", this._dataContext.ConvertDateString( _ExpDoiSoat.NgayDoiSoat), 
					"@SoLuongDon",  _ExpDoiSoat.SoLuongDon, 
					"@ThuHo",  _ExpDoiSoat.ThuHo, 
					"@ThuHoKT",  _ExpDoiSoat.ThuHoKT, 
					"@SaiLech",  _ExpDoiSoat.SaiLech, 
					"@CuocGuiTra",  _ExpDoiSoat.CuocGuiTra, 
					"@CuocNhanTra",  _ExpDoiSoat.CuocNhanTra, 
					"@ChiPhi",  _ExpDoiSoat.ChiPhi, 
					"@LoiNhuan",  _ExpDoiSoat.LoiNhuan, 
					"@ThanhToanKH",  _ExpDoiSoat.ThanhToanKH, 
					"@DaThanhToanKH",  _ExpDoiSoat.DaThanhToanKH, 
					"@GhiChu",  _ExpDoiSoat.GhiChu, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpDoiSoat vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpDoiSoat _ExpDoiSoat)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpDoiSoat] SET Post=@Post, NguoiDoiSoat=@NguoiDoiSoat, NgayDoiSoat=@NgayDoiSoat, SoLuongDon=@SoLuongDon, ThuHo=@ThuHo, ThuHoKT=@ThuHoKT, SaiLech=@SaiLech, CuocGuiTra=@CuocGuiTra, CuocNhanTra=@CuocNhanTra, ChiPhi=@ChiPhi, LoiNhuan=@LoiNhuan, ThanhToanKH=@ThanhToanKH, DaThanhToanKH=@DaThanhToanKH, GhiChu=@GhiChu WHERE Id=@Id", 
					"@Post",  _ExpDoiSoat.Post, 
					"@NguoiDoiSoat",  _ExpDoiSoat.NguoiDoiSoat, 
					"@NgayDoiSoat", this._dataContext.ConvertDateString( _ExpDoiSoat.NgayDoiSoat), 
					"@SoLuongDon",  _ExpDoiSoat.SoLuongDon, 
					"@ThuHo",  _ExpDoiSoat.ThuHo, 
					"@ThuHoKT",  _ExpDoiSoat.ThuHoKT, 
					"@SaiLech",  _ExpDoiSoat.SaiLech, 
					"@CuocGuiTra",  _ExpDoiSoat.CuocGuiTra, 
					"@CuocNhanTra",  _ExpDoiSoat.CuocNhanTra, 
					"@ChiPhi",  _ExpDoiSoat.ChiPhi, 
					"@LoiNhuan",  _ExpDoiSoat.LoiNhuan, 
					"@ThanhToanKH",  _ExpDoiSoat.ThanhToanKH, 
					"@DaThanhToanKH",  _ExpDoiSoat.DaThanhToanKH, 
					"@GhiChu",  _ExpDoiSoat.GhiChu, 
					"@Id", _ExpDoiSoat.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpDoiSoat vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpDoiSoat> _ExpDoiSoats)
		{
			foreach (ExpDoiSoat item in _ExpDoiSoats)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpDoiSoat vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpDoiSoat _ExpDoiSoat, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpDoiSoat] SET Id=@Id, Post=@Post, NguoiDoiSoat=@NguoiDoiSoat, NgayDoiSoat=@NgayDoiSoat, SoLuongDon=@SoLuongDon, ThuHo=@ThuHo, ThuHoKT=@ThuHoKT, SaiLech=@SaiLech, CuocGuiTra=@CuocGuiTra, CuocNhanTra=@CuocNhanTra, ChiPhi=@ChiPhi, LoiNhuan=@LoiNhuan, ThanhToanKH=@ThanhToanKH, DaThanhToanKH=@DaThanhToanKH, GhiChu=@GhiChu "+ condition, 
					"@Id",  _ExpDoiSoat.Id, 
					"@Post",  _ExpDoiSoat.Post, 
					"@NguoiDoiSoat",  _ExpDoiSoat.NguoiDoiSoat, 
					"@NgayDoiSoat", this._dataContext.ConvertDateString( _ExpDoiSoat.NgayDoiSoat), 
					"@SoLuongDon",  _ExpDoiSoat.SoLuongDon, 
					"@ThuHo",  _ExpDoiSoat.ThuHo, 
					"@ThuHoKT",  _ExpDoiSoat.ThuHoKT, 
					"@SaiLech",  _ExpDoiSoat.SaiLech, 
					"@CuocGuiTra",  _ExpDoiSoat.CuocGuiTra, 
					"@CuocNhanTra",  _ExpDoiSoat.CuocNhanTra, 
					"@ChiPhi",  _ExpDoiSoat.ChiPhi, 
					"@LoiNhuan",  _ExpDoiSoat.LoiNhuan, 
					"@ThanhToanKH",  _ExpDoiSoat.ThanhToanKH, 
					"@DaThanhToanKH",  _ExpDoiSoat.DaThanhToanKH, 
					"@GhiChu",  _ExpDoiSoat.GhiChu);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpDoiSoat trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpDoiSoat] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpDoiSoat trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpDoiSoat _ExpDoiSoat)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpDoiSoat] WHERE Id=@Id",
					"@Id", _ExpDoiSoat.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpDoiSoat trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpDoiSoat] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpDoiSoat trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpDoiSoat> _ExpDoiSoats)
		{
			foreach (ExpDoiSoat item in _ExpDoiSoats)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
