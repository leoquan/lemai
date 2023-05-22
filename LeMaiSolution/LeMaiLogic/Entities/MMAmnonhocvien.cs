using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMAmnonhocvien:IMAmnonhocvien
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMAmnonhocvien(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MamNonHocVien từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MamNonHocVien]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MamNonHocVien từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MamNonHocVien] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MamNonHocVien từ Database
		/// </summary>
		public List<MamNonHocVien> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MamNonHocVien]");
				List<MamNonHocVien> items = new List<MamNonHocVien>();
				MamNonHocVien item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MamNonHocVien();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["MaHocVien"] != null && dr["MaHocVien"] != DBNull.Value)
					{
						item.MaHocVien = Convert.ToString(dr["MaHocVien"]);
					}
					if (dr["TenHocVien"] != null && dr["TenHocVien"] != DBNull.Value)
					{
						item.TenHocVien = Convert.ToString(dr["TenHocVien"]);
					}
					if (dr["NgaySinh"] != null && dr["NgaySinh"] != DBNull.Value)
					{
						item.NgaySinh = Convert.ToDateTime(dr["NgaySinh"]);
					}
					if (dr["TenLopTruong"] != null && dr["TenLopTruong"] != DBNull.Value)
					{
						item.TenLopTruong = Convert.ToString(dr["TenLopTruong"]);
					}
					if (dr["TenTiengAnh"] != null && dr["TenTiengAnh"] != DBNull.Value)
					{
						item.TenTiengAnh = Convert.ToString(dr["TenTiengAnh"]);
					}
					if (dr["isGioiTinhNam"] != null && dr["isGioiTinhNam"] != DBNull.Value)
					{
						item.isGioiTinhNam = Convert.ToBoolean(dr["isGioiTinhNam"]);
					}
					if (dr["DoiTuong"] != null && dr["DoiTuong"] != DBNull.Value)
					{
						item.DoiTuong = Convert.ToInt32(dr["DoiTuong"]);
					}
					if (dr["Speaking1"] != null && dr["Speaking1"] != DBNull.Value)
					{
						item.Speaking1 = Convert.ToInt32(dr["Speaking1"]);
					}
					if (dr["Listerning1"] != null && dr["Listerning1"] != DBNull.Value)
					{
						item.Listerning1 = Convert.ToInt32(dr["Listerning1"]);
					}
					if (dr["Total1"] != null && dr["Total1"] != DBNull.Value)
					{
						item.Total1 = Convert.ToInt32(dr["Total1"]);
					}
					if (dr["Speaking2"] != null && dr["Speaking2"] != DBNull.Value)
					{
						item.Speaking2 = Convert.ToInt32(dr["Speaking2"]);
					}
					if (dr["Listerning2"] != null && dr["Listerning2"] != DBNull.Value)
					{
						item.Listerning2 = Convert.ToInt32(dr["Listerning2"]);
					}
					if (dr["Total2"] != null && dr["Total2"] != DBNull.Value)
					{
						item.Total2 = Convert.ToInt32(dr["Total2"]);
					}
					if (dr["Total"] != null && dr["Total"] != DBNull.Value)
					{
						item.Total = Convert.ToInt32(dr["Total"]);
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
		/// Lấy danh sách MamNonHocVien từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MamNonHocVien> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MamNonHocVien] A "+ condition,  parameters);
				List<MamNonHocVien> items = new List<MamNonHocVien>();
				MamNonHocVien item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MamNonHocVien();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["MaHocVien"] != null && dr["MaHocVien"] != DBNull.Value)
					{
						item.MaHocVien = Convert.ToString(dr["MaHocVien"]);
					}
					if (dr["TenHocVien"] != null && dr["TenHocVien"] != DBNull.Value)
					{
						item.TenHocVien = Convert.ToString(dr["TenHocVien"]);
					}
					if (dr["NgaySinh"] != null && dr["NgaySinh"] != DBNull.Value)
					{
						item.NgaySinh = Convert.ToDateTime(dr["NgaySinh"]);
					}
					if (dr["TenLopTruong"] != null && dr["TenLopTruong"] != DBNull.Value)
					{
						item.TenLopTruong = Convert.ToString(dr["TenLopTruong"]);
					}
					if (dr["TenTiengAnh"] != null && dr["TenTiengAnh"] != DBNull.Value)
					{
						item.TenTiengAnh = Convert.ToString(dr["TenTiengAnh"]);
					}
					if (dr["isGioiTinhNam"] != null && dr["isGioiTinhNam"] != DBNull.Value)
					{
						item.isGioiTinhNam = Convert.ToBoolean(dr["isGioiTinhNam"]);
					}
					if (dr["DoiTuong"] != null && dr["DoiTuong"] != DBNull.Value)
					{
						item.DoiTuong = Convert.ToInt32(dr["DoiTuong"]);
					}
					if (dr["Speaking1"] != null && dr["Speaking1"] != DBNull.Value)
					{
						item.Speaking1 = Convert.ToInt32(dr["Speaking1"]);
					}
					if (dr["Listerning1"] != null && dr["Listerning1"] != DBNull.Value)
					{
						item.Listerning1 = Convert.ToInt32(dr["Listerning1"]);
					}
					if (dr["Total1"] != null && dr["Total1"] != DBNull.Value)
					{
						item.Total1 = Convert.ToInt32(dr["Total1"]);
					}
					if (dr["Speaking2"] != null && dr["Speaking2"] != DBNull.Value)
					{
						item.Speaking2 = Convert.ToInt32(dr["Speaking2"]);
					}
					if (dr["Listerning2"] != null && dr["Listerning2"] != DBNull.Value)
					{
						item.Listerning2 = Convert.ToInt32(dr["Listerning2"]);
					}
					if (dr["Total2"] != null && dr["Total2"] != DBNull.Value)
					{
						item.Total2 = Convert.ToInt32(dr["Total2"]);
					}
					if (dr["Total"] != null && dr["Total"] != DBNull.Value)
					{
						item.Total = Convert.ToInt32(dr["Total"]);
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

		public List<MamNonHocVien> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MamNonHocVien] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MamNonHocVien] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MamNonHocVien>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MamNonHocVien từ Database
		/// </summary>
		public MamNonHocVien GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MamNonHocVien] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					MamNonHocVien item=new MamNonHocVien();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["MaHocVien"] != null && dr["MaHocVien"] != DBNull.Value)
						{
							item.MaHocVien = Convert.ToString(dr["MaHocVien"]);
						}
						if (dr["TenHocVien"] != null && dr["TenHocVien"] != DBNull.Value)
						{
							item.TenHocVien = Convert.ToString(dr["TenHocVien"]);
						}
						if (dr["NgaySinh"] != null && dr["NgaySinh"] != DBNull.Value)
						{
							item.NgaySinh = Convert.ToDateTime(dr["NgaySinh"]);
						}
						if (dr["TenLopTruong"] != null && dr["TenLopTruong"] != DBNull.Value)
						{
							item.TenLopTruong = Convert.ToString(dr["TenLopTruong"]);
						}
						if (dr["TenTiengAnh"] != null && dr["TenTiengAnh"] != DBNull.Value)
						{
							item.TenTiengAnh = Convert.ToString(dr["TenTiengAnh"]);
						}
						if (dr["isGioiTinhNam"] != null && dr["isGioiTinhNam"] != DBNull.Value)
						{
							item.isGioiTinhNam = Convert.ToBoolean(dr["isGioiTinhNam"]);
						}
						if (dr["DoiTuong"] != null && dr["DoiTuong"] != DBNull.Value)
						{
							item.DoiTuong = Convert.ToInt32(dr["DoiTuong"]);
						}
						if (dr["Speaking1"] != null && dr["Speaking1"] != DBNull.Value)
						{
							item.Speaking1 = Convert.ToInt32(dr["Speaking1"]);
						}
						if (dr["Listerning1"] != null && dr["Listerning1"] != DBNull.Value)
						{
							item.Listerning1 = Convert.ToInt32(dr["Listerning1"]);
						}
						if (dr["Total1"] != null && dr["Total1"] != DBNull.Value)
						{
							item.Total1 = Convert.ToInt32(dr["Total1"]);
						}
						if (dr["Speaking2"] != null && dr["Speaking2"] != DBNull.Value)
						{
							item.Speaking2 = Convert.ToInt32(dr["Speaking2"]);
						}
						if (dr["Listerning2"] != null && dr["Listerning2"] != DBNull.Value)
						{
							item.Listerning2 = Convert.ToInt32(dr["Listerning2"]);
						}
						if (dr["Total2"] != null && dr["Total2"] != DBNull.Value)
						{
							item.Total2 = Convert.ToInt32(dr["Total2"]);
						}
						if (dr["Total"] != null && dr["Total"] != DBNull.Value)
						{
							item.Total = Convert.ToInt32(dr["Total"]);
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
		/// Lấy một MamNonHocVien đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MamNonHocVien GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MamNonHocVien] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MamNonHocVien item=new MamNonHocVien();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["MaHocVien"] != null && dr["MaHocVien"] != DBNull.Value)
						{
							item.MaHocVien = Convert.ToString(dr["MaHocVien"]);
						}
						if (dr["TenHocVien"] != null && dr["TenHocVien"] != DBNull.Value)
						{
							item.TenHocVien = Convert.ToString(dr["TenHocVien"]);
						}
						if (dr["NgaySinh"] != null && dr["NgaySinh"] != DBNull.Value)
						{
							item.NgaySinh = Convert.ToDateTime(dr["NgaySinh"]);
						}
						if (dr["TenLopTruong"] != null && dr["TenLopTruong"] != DBNull.Value)
						{
							item.TenLopTruong = Convert.ToString(dr["TenLopTruong"]);
						}
						if (dr["TenTiengAnh"] != null && dr["TenTiengAnh"] != DBNull.Value)
						{
							item.TenTiengAnh = Convert.ToString(dr["TenTiengAnh"]);
						}
						if (dr["isGioiTinhNam"] != null && dr["isGioiTinhNam"] != DBNull.Value)
						{
							item.isGioiTinhNam = Convert.ToBoolean(dr["isGioiTinhNam"]);
						}
						if (dr["DoiTuong"] != null && dr["DoiTuong"] != DBNull.Value)
						{
							item.DoiTuong = Convert.ToInt32(dr["DoiTuong"]);
						}
						if (dr["Speaking1"] != null && dr["Speaking1"] != DBNull.Value)
						{
							item.Speaking1 = Convert.ToInt32(dr["Speaking1"]);
						}
						if (dr["Listerning1"] != null && dr["Listerning1"] != DBNull.Value)
						{
							item.Listerning1 = Convert.ToInt32(dr["Listerning1"]);
						}
						if (dr["Total1"] != null && dr["Total1"] != DBNull.Value)
						{
							item.Total1 = Convert.ToInt32(dr["Total1"]);
						}
						if (dr["Speaking2"] != null && dr["Speaking2"] != DBNull.Value)
						{
							item.Speaking2 = Convert.ToInt32(dr["Speaking2"]);
						}
						if (dr["Listerning2"] != null && dr["Listerning2"] != DBNull.Value)
						{
							item.Listerning2 = Convert.ToInt32(dr["Listerning2"]);
						}
						if (dr["Total2"] != null && dr["Total2"] != DBNull.Value)
						{
							item.Total2 = Convert.ToInt32(dr["Total2"]);
						}
						if (dr["Total"] != null && dr["Total"] != DBNull.Value)
						{
							item.Total = Convert.ToInt32(dr["Total"]);
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

		public MamNonHocVien GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MamNonHocVien] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MamNonHocVien>(ds);
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
		/// Thêm mới MamNonHocVien vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MamNonHocVien _MamNonHocVien)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MamNonHocVien](Id, MaHocVien, TenHocVien, NgaySinh, TenLopTruong, TenTiengAnh, isGioiTinhNam, DoiTuong, Speaking1, Listerning1, Total1, Speaking2, Listerning2, Total2, Total) VALUES(@Id, @MaHocVien, @TenHocVien, @NgaySinh, @TenLopTruong, @TenTiengAnh, @isGioiTinhNam, @DoiTuong, @Speaking1, @Listerning1, @Total1, @Speaking2, @Listerning2, @Total2, @Total)", 
					"@Id",  _MamNonHocVien.Id, 
					"@MaHocVien",  _MamNonHocVien.MaHocVien, 
					"@TenHocVien",  _MamNonHocVien.TenHocVien, 
					"@NgaySinh", this._dataContext.ConvertDateString( _MamNonHocVien.NgaySinh), 
					"@TenLopTruong",  _MamNonHocVien.TenLopTruong, 
					"@TenTiengAnh",  _MamNonHocVien.TenTiengAnh, 
					"@isGioiTinhNam",  _MamNonHocVien.isGioiTinhNam, 
					"@DoiTuong",  _MamNonHocVien.DoiTuong, 
					"@Speaking1",  _MamNonHocVien.Speaking1, 
					"@Listerning1",  _MamNonHocVien.Listerning1, 
					"@Total1",  _MamNonHocVien.Total1, 
					"@Speaking2",  _MamNonHocVien.Speaking2, 
					"@Listerning2",  _MamNonHocVien.Listerning2, 
					"@Total2",  _MamNonHocVien.Total2, 
					"@Total",  _MamNonHocVien.Total);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MamNonHocVien vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MamNonHocVien> _MamNonHocViens)
		{
			foreach (MamNonHocVien item in _MamNonHocViens)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MamNonHocVien vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MamNonHocVien _MamNonHocVien, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MamNonHocVien] SET Id=@Id, MaHocVien=@MaHocVien, TenHocVien=@TenHocVien, NgaySinh=@NgaySinh, TenLopTruong=@TenLopTruong, TenTiengAnh=@TenTiengAnh, isGioiTinhNam=@isGioiTinhNam, DoiTuong=@DoiTuong, Speaking1=@Speaking1, Listerning1=@Listerning1, Total1=@Total1, Speaking2=@Speaking2, Listerning2=@Listerning2, Total2=@Total2, Total=@Total WHERE Id=@Id", 
					"@Id",  _MamNonHocVien.Id, 
					"@MaHocVien",  _MamNonHocVien.MaHocVien, 
					"@TenHocVien",  _MamNonHocVien.TenHocVien, 
					"@NgaySinh", this._dataContext.ConvertDateString( _MamNonHocVien.NgaySinh), 
					"@TenLopTruong",  _MamNonHocVien.TenLopTruong, 
					"@TenTiengAnh",  _MamNonHocVien.TenTiengAnh, 
					"@isGioiTinhNam",  _MamNonHocVien.isGioiTinhNam, 
					"@DoiTuong",  _MamNonHocVien.DoiTuong, 
					"@Speaking1",  _MamNonHocVien.Speaking1, 
					"@Listerning1",  _MamNonHocVien.Listerning1, 
					"@Total1",  _MamNonHocVien.Total1, 
					"@Speaking2",  _MamNonHocVien.Speaking2, 
					"@Listerning2",  _MamNonHocVien.Listerning2, 
					"@Total2",  _MamNonHocVien.Total2, 
					"@Total",  _MamNonHocVien.Total, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MamNonHocVien vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MamNonHocVien _MamNonHocVien)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MamNonHocVien] SET MaHocVien=@MaHocVien, TenHocVien=@TenHocVien, NgaySinh=@NgaySinh, TenLopTruong=@TenLopTruong, TenTiengAnh=@TenTiengAnh, isGioiTinhNam=@isGioiTinhNam, DoiTuong=@DoiTuong, Speaking1=@Speaking1, Listerning1=@Listerning1, Total1=@Total1, Speaking2=@Speaking2, Listerning2=@Listerning2, Total2=@Total2, Total=@Total WHERE Id=@Id", 
					"@MaHocVien",  _MamNonHocVien.MaHocVien, 
					"@TenHocVien",  _MamNonHocVien.TenHocVien, 
					"@NgaySinh", this._dataContext.ConvertDateString( _MamNonHocVien.NgaySinh), 
					"@TenLopTruong",  _MamNonHocVien.TenLopTruong, 
					"@TenTiengAnh",  _MamNonHocVien.TenTiengAnh, 
					"@isGioiTinhNam",  _MamNonHocVien.isGioiTinhNam, 
					"@DoiTuong",  _MamNonHocVien.DoiTuong, 
					"@Speaking1",  _MamNonHocVien.Speaking1, 
					"@Listerning1",  _MamNonHocVien.Listerning1, 
					"@Total1",  _MamNonHocVien.Total1, 
					"@Speaking2",  _MamNonHocVien.Speaking2, 
					"@Listerning2",  _MamNonHocVien.Listerning2, 
					"@Total2",  _MamNonHocVien.Total2, 
					"@Total",  _MamNonHocVien.Total, 
					"@Id", _MamNonHocVien.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MamNonHocVien vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MamNonHocVien> _MamNonHocViens)
		{
			foreach (MamNonHocVien item in _MamNonHocViens)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MamNonHocVien vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MamNonHocVien _MamNonHocVien, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MamNonHocVien] SET Id=@Id, MaHocVien=@MaHocVien, TenHocVien=@TenHocVien, NgaySinh=@NgaySinh, TenLopTruong=@TenLopTruong, TenTiengAnh=@TenTiengAnh, isGioiTinhNam=@isGioiTinhNam, DoiTuong=@DoiTuong, Speaking1=@Speaking1, Listerning1=@Listerning1, Total1=@Total1, Speaking2=@Speaking2, Listerning2=@Listerning2, Total2=@Total2, Total=@Total "+ condition, 
					"@Id",  _MamNonHocVien.Id, 
					"@MaHocVien",  _MamNonHocVien.MaHocVien, 
					"@TenHocVien",  _MamNonHocVien.TenHocVien, 
					"@NgaySinh", this._dataContext.ConvertDateString( _MamNonHocVien.NgaySinh), 
					"@TenLopTruong",  _MamNonHocVien.TenLopTruong, 
					"@TenTiengAnh",  _MamNonHocVien.TenTiengAnh, 
					"@isGioiTinhNam",  _MamNonHocVien.isGioiTinhNam, 
					"@DoiTuong",  _MamNonHocVien.DoiTuong, 
					"@Speaking1",  _MamNonHocVien.Speaking1, 
					"@Listerning1",  _MamNonHocVien.Listerning1, 
					"@Total1",  _MamNonHocVien.Total1, 
					"@Speaking2",  _MamNonHocVien.Speaking2, 
					"@Listerning2",  _MamNonHocVien.Listerning2, 
					"@Total2",  _MamNonHocVien.Total2, 
					"@Total",  _MamNonHocVien.Total);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MamNonHocVien trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MamNonHocVien] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MamNonHocVien trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MamNonHocVien _MamNonHocVien)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MamNonHocVien] WHERE Id=@Id",
					"@Id", _MamNonHocVien.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MamNonHocVien trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MamNonHocVien] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MamNonHocVien trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MamNonHocVien> _MamNonHocViens)
		{
			foreach (MamNonHocVien item in _MamNonHocViens)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
