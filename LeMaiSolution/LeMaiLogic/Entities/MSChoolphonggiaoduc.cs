using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MSChoolphonggiaoduc:ISChoolphonggiaoduc
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MSChoolphonggiaoduc(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable SchoolPhongGiaoDuc từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolPhongGiaoDuc]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable SchoolPhongGiaoDuc từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolPhongGiaoDuc] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách SchoolPhongGiaoDuc từ Database
		/// </summary>
		public List<SchoolPhongGiaoDuc> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolPhongGiaoDuc]");
				List<SchoolPhongGiaoDuc> items = new List<SchoolPhongGiaoDuc>();
				SchoolPhongGiaoDuc item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SchoolPhongGiaoDuc();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenPhong"] != null && dr["TenPhong"] != DBNull.Value)
					{
						item.TenPhong = Convert.ToString(dr["TenPhong"]);
					}
					if (dr["EnglishName"] != null && dr["EnglishName"] != DBNull.Value)
					{
						item.EnglishName = Convert.ToString(dr["EnglishName"]);
					}
					if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
					{
						item.Phone = Convert.ToString(dr["Phone"]);
					}
					if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
					{
						item.DiaChi = Convert.ToString(dr["DiaChi"]);
					}
					if (dr["Email"] != null && dr["Email"] != DBNull.Value)
					{
						item.Email = Convert.ToString(dr["Email"]);
					}
					if (dr["TruongPhong"] != null && dr["TruongPhong"] != DBNull.Value)
					{
						item.TruongPhong = Convert.ToString(dr["TruongPhong"]);
					}
					if (dr["DauMoiLienHe"] != null && dr["DauMoiLienHe"] != DBNull.Value)
					{
						item.DauMoiLienHe = Convert.ToString(dr["DauMoiLienHe"]);
					}
					if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
					{
						item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
					}
					if (dr["FK_NhanVien"] != null && dr["FK_NhanVien"] != DBNull.Value)
					{
						item.FK_NhanVien = Convert.ToString(dr["FK_NhanVien"]);
					}
					if (dr["FK_SoGiaoDuc"] != null && dr["FK_SoGiaoDuc"] != DBNull.Value)
					{
						item.FK_SoGiaoDuc = Convert.ToString(dr["FK_SoGiaoDuc"]);
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
		/// Lấy danh sách SchoolPhongGiaoDuc từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<SchoolPhongGiaoDuc> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SchoolPhongGiaoDuc] A "+ condition,  parameters);
				List<SchoolPhongGiaoDuc> items = new List<SchoolPhongGiaoDuc>();
				SchoolPhongGiaoDuc item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SchoolPhongGiaoDuc();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenPhong"] != null && dr["TenPhong"] != DBNull.Value)
					{
						item.TenPhong = Convert.ToString(dr["TenPhong"]);
					}
					if (dr["EnglishName"] != null && dr["EnglishName"] != DBNull.Value)
					{
						item.EnglishName = Convert.ToString(dr["EnglishName"]);
					}
					if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
					{
						item.Phone = Convert.ToString(dr["Phone"]);
					}
					if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
					{
						item.DiaChi = Convert.ToString(dr["DiaChi"]);
					}
					if (dr["Email"] != null && dr["Email"] != DBNull.Value)
					{
						item.Email = Convert.ToString(dr["Email"]);
					}
					if (dr["TruongPhong"] != null && dr["TruongPhong"] != DBNull.Value)
					{
						item.TruongPhong = Convert.ToString(dr["TruongPhong"]);
					}
					if (dr["DauMoiLienHe"] != null && dr["DauMoiLienHe"] != DBNull.Value)
					{
						item.DauMoiLienHe = Convert.ToString(dr["DauMoiLienHe"]);
					}
					if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
					{
						item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
					}
					if (dr["FK_NhanVien"] != null && dr["FK_NhanVien"] != DBNull.Value)
					{
						item.FK_NhanVien = Convert.ToString(dr["FK_NhanVien"]);
					}
					if (dr["FK_SoGiaoDuc"] != null && dr["FK_SoGiaoDuc"] != DBNull.Value)
					{
						item.FK_SoGiaoDuc = Convert.ToString(dr["FK_SoGiaoDuc"]);
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
					items.Add(item);
				}
				return items;
			}
			catch
			{
				throw;
			}
		}

		public List<SchoolPhongGiaoDuc> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SchoolPhongGiaoDuc] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[SchoolPhongGiaoDuc] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<SchoolPhongGiaoDuc>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một SchoolPhongGiaoDuc từ Database
		/// </summary>
		public SchoolPhongGiaoDuc GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolPhongGiaoDuc] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					SchoolPhongGiaoDuc item=new SchoolPhongGiaoDuc();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TenPhong"] != null && dr["TenPhong"] != DBNull.Value)
						{
							item.TenPhong = Convert.ToString(dr["TenPhong"]);
						}
						if (dr["EnglishName"] != null && dr["EnglishName"] != DBNull.Value)
						{
							item.EnglishName = Convert.ToString(dr["EnglishName"]);
						}
						if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
						{
							item.Phone = Convert.ToString(dr["Phone"]);
						}
						if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
						{
							item.DiaChi = Convert.ToString(dr["DiaChi"]);
						}
						if (dr["Email"] != null && dr["Email"] != DBNull.Value)
						{
							item.Email = Convert.ToString(dr["Email"]);
						}
						if (dr["TruongPhong"] != null && dr["TruongPhong"] != DBNull.Value)
						{
							item.TruongPhong = Convert.ToString(dr["TruongPhong"]);
						}
						if (dr["DauMoiLienHe"] != null && dr["DauMoiLienHe"] != DBNull.Value)
						{
							item.DauMoiLienHe = Convert.ToString(dr["DauMoiLienHe"]);
						}
						if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
						{
							item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
						}
						if (dr["FK_NhanVien"] != null && dr["FK_NhanVien"] != DBNull.Value)
						{
							item.FK_NhanVien = Convert.ToString(dr["FK_NhanVien"]);
						}
						if (dr["FK_SoGiaoDuc"] != null && dr["FK_SoGiaoDuc"] != DBNull.Value)
						{
							item.FK_SoGiaoDuc = Convert.ToString(dr["FK_SoGiaoDuc"]);
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
		/// Lấy một SchoolPhongGiaoDuc đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public SchoolPhongGiaoDuc GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SchoolPhongGiaoDuc] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					SchoolPhongGiaoDuc item=new SchoolPhongGiaoDuc();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TenPhong"] != null && dr["TenPhong"] != DBNull.Value)
						{
							item.TenPhong = Convert.ToString(dr["TenPhong"]);
						}
						if (dr["EnglishName"] != null && dr["EnglishName"] != DBNull.Value)
						{
							item.EnglishName = Convert.ToString(dr["EnglishName"]);
						}
						if (dr["Phone"] != null && dr["Phone"] != DBNull.Value)
						{
							item.Phone = Convert.ToString(dr["Phone"]);
						}
						if (dr["DiaChi"] != null && dr["DiaChi"] != DBNull.Value)
						{
							item.DiaChi = Convert.ToString(dr["DiaChi"]);
						}
						if (dr["Email"] != null && dr["Email"] != DBNull.Value)
						{
							item.Email = Convert.ToString(dr["Email"]);
						}
						if (dr["TruongPhong"] != null && dr["TruongPhong"] != DBNull.Value)
						{
							item.TruongPhong = Convert.ToString(dr["TruongPhong"]);
						}
						if (dr["DauMoiLienHe"] != null && dr["DauMoiLienHe"] != DBNull.Value)
						{
							item.DauMoiLienHe = Convert.ToString(dr["DauMoiLienHe"]);
						}
						if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
						{
							item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
						}
						if (dr["FK_NhanVien"] != null && dr["FK_NhanVien"] != DBNull.Value)
						{
							item.FK_NhanVien = Convert.ToString(dr["FK_NhanVien"]);
						}
						if (dr["FK_SoGiaoDuc"] != null && dr["FK_SoGiaoDuc"] != DBNull.Value)
						{
							item.FK_SoGiaoDuc = Convert.ToString(dr["FK_SoGiaoDuc"]);
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

		public SchoolPhongGiaoDuc GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SchoolPhongGiaoDuc] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<SchoolPhongGiaoDuc>(ds);
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
		/// Thêm mới SchoolPhongGiaoDuc vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, SchoolPhongGiaoDuc _SchoolPhongGiaoDuc)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[SchoolPhongGiaoDuc](Id, TenPhong, EnglishName, Phone, DiaChi, Email, TruongPhong, DauMoiLienHe, SoDienThoai, FK_NhanVien, FK_SoGiaoDuc, CreateBy, CreateDate, GoogleMap) VALUES(@Id, @TenPhong, @EnglishName, @Phone, @DiaChi, @Email, @TruongPhong, @DauMoiLienHe, @SoDienThoai, @FK_NhanVien, @FK_SoGiaoDuc, @CreateBy, @CreateDate, @GoogleMap)", 
					"@Id",  _SchoolPhongGiaoDuc.Id, 
					"@TenPhong",  _SchoolPhongGiaoDuc.TenPhong, 
					"@EnglishName",  _SchoolPhongGiaoDuc.EnglishName, 
					"@Phone",  _SchoolPhongGiaoDuc.Phone, 
					"@DiaChi",  _SchoolPhongGiaoDuc.DiaChi, 
					"@Email",  _SchoolPhongGiaoDuc.Email, 
					"@TruongPhong",  _SchoolPhongGiaoDuc.TruongPhong, 
					"@DauMoiLienHe",  _SchoolPhongGiaoDuc.DauMoiLienHe, 
					"@SoDienThoai",  _SchoolPhongGiaoDuc.SoDienThoai, 
					"@FK_NhanVien",  _SchoolPhongGiaoDuc.FK_NhanVien, 
					"@FK_SoGiaoDuc",  _SchoolPhongGiaoDuc.FK_SoGiaoDuc, 
					"@CreateBy",  _SchoolPhongGiaoDuc.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _SchoolPhongGiaoDuc.CreateDate), 
					"@GoogleMap",  _SchoolPhongGiaoDuc.GoogleMap);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng SchoolPhongGiaoDuc vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<SchoolPhongGiaoDuc> _SchoolPhongGiaoDucs)
		{
			foreach (SchoolPhongGiaoDuc item in _SchoolPhongGiaoDucs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SchoolPhongGiaoDuc vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, SchoolPhongGiaoDuc _SchoolPhongGiaoDuc, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SchoolPhongGiaoDuc] SET Id=@Id, TenPhong=@TenPhong, EnglishName=@EnglishName, Phone=@Phone, DiaChi=@DiaChi, Email=@Email, TruongPhong=@TruongPhong, DauMoiLienHe=@DauMoiLienHe, SoDienThoai=@SoDienThoai, FK_NhanVien=@FK_NhanVien, FK_SoGiaoDuc=@FK_SoGiaoDuc, CreateBy=@CreateBy, CreateDate=@CreateDate, GoogleMap=@GoogleMap WHERE Id=@Id", 
					"@Id",  _SchoolPhongGiaoDuc.Id, 
					"@TenPhong",  _SchoolPhongGiaoDuc.TenPhong, 
					"@EnglishName",  _SchoolPhongGiaoDuc.EnglishName, 
					"@Phone",  _SchoolPhongGiaoDuc.Phone, 
					"@DiaChi",  _SchoolPhongGiaoDuc.DiaChi, 
					"@Email",  _SchoolPhongGiaoDuc.Email, 
					"@TruongPhong",  _SchoolPhongGiaoDuc.TruongPhong, 
					"@DauMoiLienHe",  _SchoolPhongGiaoDuc.DauMoiLienHe, 
					"@SoDienThoai",  _SchoolPhongGiaoDuc.SoDienThoai, 
					"@FK_NhanVien",  _SchoolPhongGiaoDuc.FK_NhanVien, 
					"@FK_SoGiaoDuc",  _SchoolPhongGiaoDuc.FK_SoGiaoDuc, 
					"@CreateBy",  _SchoolPhongGiaoDuc.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _SchoolPhongGiaoDuc.CreateDate), 
					"@GoogleMap",  _SchoolPhongGiaoDuc.GoogleMap, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật SchoolPhongGiaoDuc vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, SchoolPhongGiaoDuc _SchoolPhongGiaoDuc)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SchoolPhongGiaoDuc] SET TenPhong=@TenPhong, EnglishName=@EnglishName, Phone=@Phone, DiaChi=@DiaChi, Email=@Email, TruongPhong=@TruongPhong, DauMoiLienHe=@DauMoiLienHe, SoDienThoai=@SoDienThoai, FK_NhanVien=@FK_NhanVien, FK_SoGiaoDuc=@FK_SoGiaoDuc, CreateBy=@CreateBy, CreateDate=@CreateDate, GoogleMap=@GoogleMap WHERE Id=@Id", 
					"@TenPhong",  _SchoolPhongGiaoDuc.TenPhong, 
					"@EnglishName",  _SchoolPhongGiaoDuc.EnglishName, 
					"@Phone",  _SchoolPhongGiaoDuc.Phone, 
					"@DiaChi",  _SchoolPhongGiaoDuc.DiaChi, 
					"@Email",  _SchoolPhongGiaoDuc.Email, 
					"@TruongPhong",  _SchoolPhongGiaoDuc.TruongPhong, 
					"@DauMoiLienHe",  _SchoolPhongGiaoDuc.DauMoiLienHe, 
					"@SoDienThoai",  _SchoolPhongGiaoDuc.SoDienThoai, 
					"@FK_NhanVien",  _SchoolPhongGiaoDuc.FK_NhanVien, 
					"@FK_SoGiaoDuc",  _SchoolPhongGiaoDuc.FK_SoGiaoDuc, 
					"@CreateBy",  _SchoolPhongGiaoDuc.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _SchoolPhongGiaoDuc.CreateDate), 
					"@GoogleMap",  _SchoolPhongGiaoDuc.GoogleMap, 
					"@Id", _SchoolPhongGiaoDuc.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách SchoolPhongGiaoDuc vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<SchoolPhongGiaoDuc> _SchoolPhongGiaoDucs)
		{
			foreach (SchoolPhongGiaoDuc item in _SchoolPhongGiaoDucs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SchoolPhongGiaoDuc vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, SchoolPhongGiaoDuc _SchoolPhongGiaoDuc, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SchoolPhongGiaoDuc] SET Id=@Id, TenPhong=@TenPhong, EnglishName=@EnglishName, Phone=@Phone, DiaChi=@DiaChi, Email=@Email, TruongPhong=@TruongPhong, DauMoiLienHe=@DauMoiLienHe, SoDienThoai=@SoDienThoai, FK_NhanVien=@FK_NhanVien, FK_SoGiaoDuc=@FK_SoGiaoDuc, CreateBy=@CreateBy, CreateDate=@CreateDate, GoogleMap=@GoogleMap "+ condition, 
					"@Id",  _SchoolPhongGiaoDuc.Id, 
					"@TenPhong",  _SchoolPhongGiaoDuc.TenPhong, 
					"@EnglishName",  _SchoolPhongGiaoDuc.EnglishName, 
					"@Phone",  _SchoolPhongGiaoDuc.Phone, 
					"@DiaChi",  _SchoolPhongGiaoDuc.DiaChi, 
					"@Email",  _SchoolPhongGiaoDuc.Email, 
					"@TruongPhong",  _SchoolPhongGiaoDuc.TruongPhong, 
					"@DauMoiLienHe",  _SchoolPhongGiaoDuc.DauMoiLienHe, 
					"@SoDienThoai",  _SchoolPhongGiaoDuc.SoDienThoai, 
					"@FK_NhanVien",  _SchoolPhongGiaoDuc.FK_NhanVien, 
					"@FK_SoGiaoDuc",  _SchoolPhongGiaoDuc.FK_SoGiaoDuc, 
					"@CreateBy",  _SchoolPhongGiaoDuc.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _SchoolPhongGiaoDuc.CreateDate), 
					"@GoogleMap",  _SchoolPhongGiaoDuc.GoogleMap);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa SchoolPhongGiaoDuc trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SchoolPhongGiaoDuc] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SchoolPhongGiaoDuc trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, SchoolPhongGiaoDuc _SchoolPhongGiaoDuc)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SchoolPhongGiaoDuc] WHERE Id=@Id",
					"@Id", _SchoolPhongGiaoDuc.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SchoolPhongGiaoDuc trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SchoolPhongGiaoDuc] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SchoolPhongGiaoDuc trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<SchoolPhongGiaoDuc> _SchoolPhongGiaoDucs)
		{
			foreach (SchoolPhongGiaoDuc item in _SchoolPhongGiaoDucs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
