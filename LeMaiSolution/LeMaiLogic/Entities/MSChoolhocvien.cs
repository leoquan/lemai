using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MSChoolhocvien:ISChoolhocvien
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MSChoolhocvien(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable SchoolHocVien từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolHocVien]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable SchoolHocVien từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolHocVien] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách SchoolHocVien từ Database
		/// </summary>
		public List<SchoolHocVien> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolHocVien]");
				List<SchoolHocVien> items = new List<SchoolHocVien>();
				SchoolHocVien item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SchoolHocVien();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["TenHocVien"] != null && dr["TenHocVien"] != DBNull.Value)
					{
						item.TenHocVien = Convert.ToString(dr["TenHocVien"]);
					}
					if (dr["EnglishName"] != null && dr["EnglishName"] != DBNull.Value)
					{
						item.EnglishName = Convert.ToString(dr["EnglishName"]);
					}
					if (dr["NickName"] != null && dr["NickName"] != DBNull.Value)
					{
						item.NickName = Convert.ToString(dr["NickName"]);
					}
					if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
					{
						item.DiaChi = Convert.ToString(dr["DiaChi"]);
					}
					if (dr["NamSinh"] != null && dr["NamSinh"] != DBNull.Value)
					{
						item.NamSinh = Convert.ToDateTime(dr["NamSinh"]);
					}
					if (dr["GioiTinh"] != null && dr["GioiTinh"] != DBNull.Value)
					{
						item.GioiTinh = Convert.ToInt32(dr["GioiTinh"]);
					}
					if (dr["TenPhuHuynh"] != null && dr["TenPhuHuynh"] != DBNull.Value)
					{
						item.TenPhuHuynh = Convert.ToString(dr["TenPhuHuynh"]);
					}
					if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
					{
						item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
					}
					if (dr["Zalo"] != null && dr["Zalo"] != DBNull.Value)
					{
						item.Zalo = Convert.ToString(dr["Zalo"]);
					}
					if (dr["Email"] != null && dr["Email"] != DBNull.Value)
					{
						item.Email = Convert.ToString(dr["Email"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["GoogleMap"] != null && dr["GoogleMap"] != DBNull.Value)
					{
						item.GoogleMap = Convert.ToString(dr["GoogleMap"]);
					}
					if (dr["ImageHocVien"] != null && dr["ImageHocVien"] != DBNull.Value)
					{
						item.ImageHocVien = Convert.ToString(dr["ImageHocVien"]);
					}
					if (dr["PercentPrice"] != null && dr["PercentPrice"] != DBNull.Value)
					{
						item.PercentPrice = Convert.ToInt32(dr["PercentPrice"]);
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
		/// Lấy danh sách SchoolHocVien từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<SchoolHocVien> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SchoolHocVien] A "+ condition,  parameters);
				List<SchoolHocVien> items = new List<SchoolHocVien>();
				SchoolHocVien item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SchoolHocVien();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["TenHocVien"] != null && dr["TenHocVien"] != DBNull.Value)
					{
						item.TenHocVien = Convert.ToString(dr["TenHocVien"]);
					}
					if (dr["EnglishName"] != null && dr["EnglishName"] != DBNull.Value)
					{
						item.EnglishName = Convert.ToString(dr["EnglishName"]);
					}
					if (dr["NickName"] != null && dr["NickName"] != DBNull.Value)
					{
						item.NickName = Convert.ToString(dr["NickName"]);
					}
					if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
					{
						item.DiaChi = Convert.ToString(dr["DiaChi"]);
					}
					if (dr["NamSinh"] != null && dr["NamSinh"] != DBNull.Value)
					{
						item.NamSinh = Convert.ToDateTime(dr["NamSinh"]);
					}
					if (dr["GioiTinh"] != null && dr["GioiTinh"] != DBNull.Value)
					{
						item.GioiTinh = Convert.ToInt32(dr["GioiTinh"]);
					}
					if (dr["TenPhuHuynh"] != null && dr["TenPhuHuynh"] != DBNull.Value)
					{
						item.TenPhuHuynh = Convert.ToString(dr["TenPhuHuynh"]);
					}
					if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
					{
						item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
					}
					if (dr["Zalo"] != null && dr["Zalo"] != DBNull.Value)
					{
						item.Zalo = Convert.ToString(dr["Zalo"]);
					}
					if (dr["Email"] != null && dr["Email"] != DBNull.Value)
					{
						item.Email = Convert.ToString(dr["Email"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["GoogleMap"] != null && dr["GoogleMap"] != DBNull.Value)
					{
						item.GoogleMap = Convert.ToString(dr["GoogleMap"]);
					}
					if (dr["ImageHocVien"] != null && dr["ImageHocVien"] != DBNull.Value)
					{
						item.ImageHocVien = Convert.ToString(dr["ImageHocVien"]);
					}
					if (dr["PercentPrice"] != null && dr["PercentPrice"] != DBNull.Value)
					{
						item.PercentPrice = Convert.ToInt32(dr["PercentPrice"]);
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

		public List<SchoolHocVien> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SchoolHocVien] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[SchoolHocVien] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<SchoolHocVien>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một SchoolHocVien từ Database
		/// </summary>
		public SchoolHocVien GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolHocVien] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					SchoolHocVien item=new SchoolHocVien();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Code"] != null && dr["Code"] != DBNull.Value)
						{
							item.Code = Convert.ToString(dr["Code"]);
						}
						if (dr["TenHocVien"] != null && dr["TenHocVien"] != DBNull.Value)
						{
							item.TenHocVien = Convert.ToString(dr["TenHocVien"]);
						}
						if (dr["EnglishName"] != null && dr["EnglishName"] != DBNull.Value)
						{
							item.EnglishName = Convert.ToString(dr["EnglishName"]);
						}
						if (dr["NickName"] != null && dr["NickName"] != DBNull.Value)
						{
							item.NickName = Convert.ToString(dr["NickName"]);
						}
						if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
						{
							item.DiaChi = Convert.ToString(dr["DiaChi"]);
						}
						if (dr["NamSinh"] != null && dr["NamSinh"] != DBNull.Value)
						{
							item.NamSinh = Convert.ToDateTime(dr["NamSinh"]);
						}
						if (dr["GioiTinh"] != null && dr["GioiTinh"] != DBNull.Value)
						{
							item.GioiTinh = Convert.ToInt32(dr["GioiTinh"]);
						}
						if (dr["TenPhuHuynh"] != null && dr["TenPhuHuynh"] != DBNull.Value)
						{
							item.TenPhuHuynh = Convert.ToString(dr["TenPhuHuynh"]);
						}
						if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
						{
							item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
						}
						if (dr["Zalo"] != null && dr["Zalo"] != DBNull.Value)
						{
							item.Zalo = Convert.ToString(dr["Zalo"]);
						}
						if (dr["Email"] != null && dr["Email"] != DBNull.Value)
						{
							item.Email = Convert.ToString(dr["Email"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["GoogleMap"] != null && dr["GoogleMap"] != DBNull.Value)
						{
							item.GoogleMap = Convert.ToString(dr["GoogleMap"]);
						}
						if (dr["ImageHocVien"] != null && dr["ImageHocVien"] != DBNull.Value)
						{
							item.ImageHocVien = Convert.ToString(dr["ImageHocVien"]);
						}
						if (dr["PercentPrice"] != null && dr["PercentPrice"] != DBNull.Value)
						{
							item.PercentPrice = Convert.ToInt32(dr["PercentPrice"]);
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
		/// Lấy một SchoolHocVien đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public SchoolHocVien GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SchoolHocVien] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					SchoolHocVien item=new SchoolHocVien();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Code"] != null && dr["Code"] != DBNull.Value)
						{
							item.Code = Convert.ToString(dr["Code"]);
						}
						if (dr["TenHocVien"] != null && dr["TenHocVien"] != DBNull.Value)
						{
							item.TenHocVien = Convert.ToString(dr["TenHocVien"]);
						}
						if (dr["EnglishName"] != null && dr["EnglishName"] != DBNull.Value)
						{
							item.EnglishName = Convert.ToString(dr["EnglishName"]);
						}
						if (dr["NickName"] != null && dr["NickName"] != DBNull.Value)
						{
							item.NickName = Convert.ToString(dr["NickName"]);
						}
						if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
						{
							item.DiaChi = Convert.ToString(dr["DiaChi"]);
						}
						if (dr["NamSinh"] != null && dr["NamSinh"] != DBNull.Value)
						{
							item.NamSinh = Convert.ToDateTime(dr["NamSinh"]);
						}
						if (dr["GioiTinh"] != null && dr["GioiTinh"] != DBNull.Value)
						{
							item.GioiTinh = Convert.ToInt32(dr["GioiTinh"]);
						}
						if (dr["TenPhuHuynh"] != null && dr["TenPhuHuynh"] != DBNull.Value)
						{
							item.TenPhuHuynh = Convert.ToString(dr["TenPhuHuynh"]);
						}
						if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
						{
							item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
						}
						if (dr["Zalo"] != null && dr["Zalo"] != DBNull.Value)
						{
							item.Zalo = Convert.ToString(dr["Zalo"]);
						}
						if (dr["Email"] != null && dr["Email"] != DBNull.Value)
						{
							item.Email = Convert.ToString(dr["Email"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["GoogleMap"] != null && dr["GoogleMap"] != DBNull.Value)
						{
							item.GoogleMap = Convert.ToString(dr["GoogleMap"]);
						}
						if (dr["ImageHocVien"] != null && dr["ImageHocVien"] != DBNull.Value)
						{
							item.ImageHocVien = Convert.ToString(dr["ImageHocVien"]);
						}
						if (dr["PercentPrice"] != null && dr["PercentPrice"] != DBNull.Value)
						{
							item.PercentPrice = Convert.ToInt32(dr["PercentPrice"]);
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

		public SchoolHocVien GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SchoolHocVien] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<SchoolHocVien>(ds);
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
		/// Thêm mới SchoolHocVien vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, SchoolHocVien _SchoolHocVien)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[SchoolHocVien](Id, Code, TenHocVien, EnglishName, NickName, DiaChi, NamSinh, GioiTinh, TenPhuHuynh, SoDienThoai, Zalo, Email, CreateBy, CreateDate, GoogleMap, ImageHocVien, PercentPrice) VALUES(@Id, @Code, @TenHocVien, @EnglishName, @NickName, @DiaChi, @NamSinh, @GioiTinh, @TenPhuHuynh, @SoDienThoai, @Zalo, @Email, @CreateBy, @CreateDate, @GoogleMap, @ImageHocVien, @PercentPrice)", 
					"@Id",  _SchoolHocVien.Id, 
					"@Code",  _SchoolHocVien.Code, 
					"@TenHocVien",  _SchoolHocVien.TenHocVien, 
					"@EnglishName",  _SchoolHocVien.EnglishName, 
					"@NickName",  _SchoolHocVien.NickName, 
					"@DiaChi",  _SchoolHocVien.DiaChi, 
					"@NamSinh", this._dataContext.ConvertDateString( _SchoolHocVien.NamSinh), 
					"@GioiTinh",  _SchoolHocVien.GioiTinh, 
					"@TenPhuHuynh",  _SchoolHocVien.TenPhuHuynh, 
					"@SoDienThoai",  _SchoolHocVien.SoDienThoai, 
					"@Zalo",  _SchoolHocVien.Zalo, 
					"@Email",  _SchoolHocVien.Email, 
					"@CreateBy",  _SchoolHocVien.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _SchoolHocVien.CreateDate), 
					"@GoogleMap",  _SchoolHocVien.GoogleMap, 
					"@ImageHocVien",  _SchoolHocVien.ImageHocVien, 
					"@PercentPrice",  _SchoolHocVien.PercentPrice);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng SchoolHocVien vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<SchoolHocVien> _SchoolHocViens)
		{
			foreach (SchoolHocVien item in _SchoolHocViens)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SchoolHocVien vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, SchoolHocVien _SchoolHocVien, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SchoolHocVien] SET Id=@Id, Code=@Code, TenHocVien=@TenHocVien, EnglishName=@EnglishName, NickName=@NickName, DiaChi=@DiaChi, NamSinh=@NamSinh, GioiTinh=@GioiTinh, TenPhuHuynh=@TenPhuHuynh, SoDienThoai=@SoDienThoai, Zalo=@Zalo, Email=@Email, CreateBy=@CreateBy, CreateDate=@CreateDate, GoogleMap=@GoogleMap, ImageHocVien=@ImageHocVien, PercentPrice=@PercentPrice WHERE Id=@Id", 
					"@Id",  _SchoolHocVien.Id, 
					"@Code",  _SchoolHocVien.Code, 
					"@TenHocVien",  _SchoolHocVien.TenHocVien, 
					"@EnglishName",  _SchoolHocVien.EnglishName, 
					"@NickName",  _SchoolHocVien.NickName, 
					"@DiaChi",  _SchoolHocVien.DiaChi, 
					"@NamSinh", this._dataContext.ConvertDateString( _SchoolHocVien.NamSinh), 
					"@GioiTinh",  _SchoolHocVien.GioiTinh, 
					"@TenPhuHuynh",  _SchoolHocVien.TenPhuHuynh, 
					"@SoDienThoai",  _SchoolHocVien.SoDienThoai, 
					"@Zalo",  _SchoolHocVien.Zalo, 
					"@Email",  _SchoolHocVien.Email, 
					"@CreateBy",  _SchoolHocVien.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _SchoolHocVien.CreateDate), 
					"@GoogleMap",  _SchoolHocVien.GoogleMap, 
					"@ImageHocVien",  _SchoolHocVien.ImageHocVien, 
					"@PercentPrice",  _SchoolHocVien.PercentPrice, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật SchoolHocVien vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, SchoolHocVien _SchoolHocVien)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SchoolHocVien] SET Code=@Code, TenHocVien=@TenHocVien, EnglishName=@EnglishName, NickName=@NickName, DiaChi=@DiaChi, NamSinh=@NamSinh, GioiTinh=@GioiTinh, TenPhuHuynh=@TenPhuHuynh, SoDienThoai=@SoDienThoai, Zalo=@Zalo, Email=@Email, CreateBy=@CreateBy, CreateDate=@CreateDate, GoogleMap=@GoogleMap, ImageHocVien=@ImageHocVien, PercentPrice=@PercentPrice WHERE Id=@Id", 
					"@Code",  _SchoolHocVien.Code, 
					"@TenHocVien",  _SchoolHocVien.TenHocVien, 
					"@EnglishName",  _SchoolHocVien.EnglishName, 
					"@NickName",  _SchoolHocVien.NickName, 
					"@DiaChi",  _SchoolHocVien.DiaChi, 
					"@NamSinh", this._dataContext.ConvertDateString( _SchoolHocVien.NamSinh), 
					"@GioiTinh",  _SchoolHocVien.GioiTinh, 
					"@TenPhuHuynh",  _SchoolHocVien.TenPhuHuynh, 
					"@SoDienThoai",  _SchoolHocVien.SoDienThoai, 
					"@Zalo",  _SchoolHocVien.Zalo, 
					"@Email",  _SchoolHocVien.Email, 
					"@CreateBy",  _SchoolHocVien.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _SchoolHocVien.CreateDate), 
					"@GoogleMap",  _SchoolHocVien.GoogleMap, 
					"@ImageHocVien",  _SchoolHocVien.ImageHocVien, 
					"@PercentPrice",  _SchoolHocVien.PercentPrice, 
					"@Id", _SchoolHocVien.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách SchoolHocVien vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<SchoolHocVien> _SchoolHocViens)
		{
			foreach (SchoolHocVien item in _SchoolHocViens)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SchoolHocVien vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, SchoolHocVien _SchoolHocVien, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SchoolHocVien] SET Id=@Id, Code=@Code, TenHocVien=@TenHocVien, EnglishName=@EnglishName, NickName=@NickName, DiaChi=@DiaChi, NamSinh=@NamSinh, GioiTinh=@GioiTinh, TenPhuHuynh=@TenPhuHuynh, SoDienThoai=@SoDienThoai, Zalo=@Zalo, Email=@Email, CreateBy=@CreateBy, CreateDate=@CreateDate, GoogleMap=@GoogleMap, ImageHocVien=@ImageHocVien, PercentPrice=@PercentPrice "+ condition, 
					"@Id",  _SchoolHocVien.Id, 
					"@Code",  _SchoolHocVien.Code, 
					"@TenHocVien",  _SchoolHocVien.TenHocVien, 
					"@EnglishName",  _SchoolHocVien.EnglishName, 
					"@NickName",  _SchoolHocVien.NickName, 
					"@DiaChi",  _SchoolHocVien.DiaChi, 
					"@NamSinh", this._dataContext.ConvertDateString( _SchoolHocVien.NamSinh), 
					"@GioiTinh",  _SchoolHocVien.GioiTinh, 
					"@TenPhuHuynh",  _SchoolHocVien.TenPhuHuynh, 
					"@SoDienThoai",  _SchoolHocVien.SoDienThoai, 
					"@Zalo",  _SchoolHocVien.Zalo, 
					"@Email",  _SchoolHocVien.Email, 
					"@CreateBy",  _SchoolHocVien.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _SchoolHocVien.CreateDate), 
					"@GoogleMap",  _SchoolHocVien.GoogleMap, 
					"@ImageHocVien",  _SchoolHocVien.ImageHocVien, 
					"@PercentPrice",  _SchoolHocVien.PercentPrice);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa SchoolHocVien trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SchoolHocVien] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SchoolHocVien trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, SchoolHocVien _SchoolHocVien)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SchoolHocVien] WHERE Id=@Id",
					"@Id", _SchoolHocVien.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SchoolHocVien trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SchoolHocVien] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SchoolHocVien trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<SchoolHocVien> _SchoolHocViens)
		{
			foreach (SchoolHocVien item in _SchoolHocViens)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
