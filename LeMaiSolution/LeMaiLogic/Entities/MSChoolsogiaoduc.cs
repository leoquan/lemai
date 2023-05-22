using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MSChoolsogiaoduc:ISChoolsogiaoduc
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MSChoolsogiaoduc(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable SchoolSoGiaoDuc từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolSoGiaoDuc]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable SchoolSoGiaoDuc từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolSoGiaoDuc] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách SchoolSoGiaoDuc từ Database
		/// </summary>
		public List<SchoolSoGiaoDuc> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolSoGiaoDuc]");
				List<SchoolSoGiaoDuc> items = new List<SchoolSoGiaoDuc>();
				SchoolSoGiaoDuc item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SchoolSoGiaoDuc();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenSo"] != null && dr["TenSo"] != DBNull.Value)
					{
						item.TenSo = Convert.ToString(dr["TenSo"]);
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
					if (dr["GiamDoc"] != null && dr["GiamDoc"] != DBNull.Value)
					{
						item.GiamDoc = Convert.ToString(dr["GiamDoc"]);
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
		/// Lấy danh sách SchoolSoGiaoDuc từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<SchoolSoGiaoDuc> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SchoolSoGiaoDuc] A "+ condition,  parameters);
				List<SchoolSoGiaoDuc> items = new List<SchoolSoGiaoDuc>();
				SchoolSoGiaoDuc item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SchoolSoGiaoDuc();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenSo"] != null && dr["TenSo"] != DBNull.Value)
					{
						item.TenSo = Convert.ToString(dr["TenSo"]);
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
					if (dr["GiamDoc"] != null && dr["GiamDoc"] != DBNull.Value)
					{
						item.GiamDoc = Convert.ToString(dr["GiamDoc"]);
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

		public List<SchoolSoGiaoDuc> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SchoolSoGiaoDuc] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[SchoolSoGiaoDuc] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<SchoolSoGiaoDuc>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một SchoolSoGiaoDuc từ Database
		/// </summary>
		public SchoolSoGiaoDuc GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolSoGiaoDuc] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					SchoolSoGiaoDuc item=new SchoolSoGiaoDuc();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TenSo"] != null && dr["TenSo"] != DBNull.Value)
						{
							item.TenSo = Convert.ToString(dr["TenSo"]);
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
						if (dr["GiamDoc"] != null && dr["GiamDoc"] != DBNull.Value)
						{
							item.GiamDoc = Convert.ToString(dr["GiamDoc"]);
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
		/// Lấy một SchoolSoGiaoDuc đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public SchoolSoGiaoDuc GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SchoolSoGiaoDuc] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					SchoolSoGiaoDuc item=new SchoolSoGiaoDuc();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TenSo"] != null && dr["TenSo"] != DBNull.Value)
						{
							item.TenSo = Convert.ToString(dr["TenSo"]);
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
						if (dr["GiamDoc"] != null && dr["GiamDoc"] != DBNull.Value)
						{
							item.GiamDoc = Convert.ToString(dr["GiamDoc"]);
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

		public SchoolSoGiaoDuc GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SchoolSoGiaoDuc] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<SchoolSoGiaoDuc>(ds);
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
		/// Thêm mới SchoolSoGiaoDuc vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, SchoolSoGiaoDuc _SchoolSoGiaoDuc)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[SchoolSoGiaoDuc](Id, TenSo, EnglishName, Phone, DiaChi, Email, GiamDoc, DauMoiLienHe, SoDienThoai, FK_NhanVien, CreateBy, CreateDate, GoogleMap) VALUES(@Id, @TenSo, @EnglishName, @Phone, @DiaChi, @Email, @GiamDoc, @DauMoiLienHe, @SoDienThoai, @FK_NhanVien, @CreateBy, @CreateDate, @GoogleMap)", 
					"@Id",  _SchoolSoGiaoDuc.Id, 
					"@TenSo",  _SchoolSoGiaoDuc.TenSo, 
					"@EnglishName",  _SchoolSoGiaoDuc.EnglishName, 
					"@Phone",  _SchoolSoGiaoDuc.Phone, 
					"@DiaChi",  _SchoolSoGiaoDuc.DiaChi, 
					"@Email",  _SchoolSoGiaoDuc.Email, 
					"@GiamDoc",  _SchoolSoGiaoDuc.GiamDoc, 
					"@DauMoiLienHe",  _SchoolSoGiaoDuc.DauMoiLienHe, 
					"@SoDienThoai",  _SchoolSoGiaoDuc.SoDienThoai, 
					"@FK_NhanVien",  _SchoolSoGiaoDuc.FK_NhanVien, 
					"@CreateBy",  _SchoolSoGiaoDuc.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _SchoolSoGiaoDuc.CreateDate), 
					"@GoogleMap",  _SchoolSoGiaoDuc.GoogleMap);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng SchoolSoGiaoDuc vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<SchoolSoGiaoDuc> _SchoolSoGiaoDucs)
		{
			foreach (SchoolSoGiaoDuc item in _SchoolSoGiaoDucs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SchoolSoGiaoDuc vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, SchoolSoGiaoDuc _SchoolSoGiaoDuc, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SchoolSoGiaoDuc] SET Id=@Id, TenSo=@TenSo, EnglishName=@EnglishName, Phone=@Phone, DiaChi=@DiaChi, Email=@Email, GiamDoc=@GiamDoc, DauMoiLienHe=@DauMoiLienHe, SoDienThoai=@SoDienThoai, FK_NhanVien=@FK_NhanVien, CreateBy=@CreateBy, CreateDate=@CreateDate, GoogleMap=@GoogleMap WHERE Id=@Id", 
					"@Id",  _SchoolSoGiaoDuc.Id, 
					"@TenSo",  _SchoolSoGiaoDuc.TenSo, 
					"@EnglishName",  _SchoolSoGiaoDuc.EnglishName, 
					"@Phone",  _SchoolSoGiaoDuc.Phone, 
					"@DiaChi",  _SchoolSoGiaoDuc.DiaChi, 
					"@Email",  _SchoolSoGiaoDuc.Email, 
					"@GiamDoc",  _SchoolSoGiaoDuc.GiamDoc, 
					"@DauMoiLienHe",  _SchoolSoGiaoDuc.DauMoiLienHe, 
					"@SoDienThoai",  _SchoolSoGiaoDuc.SoDienThoai, 
					"@FK_NhanVien",  _SchoolSoGiaoDuc.FK_NhanVien, 
					"@CreateBy",  _SchoolSoGiaoDuc.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _SchoolSoGiaoDuc.CreateDate), 
					"@GoogleMap",  _SchoolSoGiaoDuc.GoogleMap, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật SchoolSoGiaoDuc vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, SchoolSoGiaoDuc _SchoolSoGiaoDuc)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SchoolSoGiaoDuc] SET TenSo=@TenSo, EnglishName=@EnglishName, Phone=@Phone, DiaChi=@DiaChi, Email=@Email, GiamDoc=@GiamDoc, DauMoiLienHe=@DauMoiLienHe, SoDienThoai=@SoDienThoai, FK_NhanVien=@FK_NhanVien, CreateBy=@CreateBy, CreateDate=@CreateDate, GoogleMap=@GoogleMap WHERE Id=@Id", 
					"@TenSo",  _SchoolSoGiaoDuc.TenSo, 
					"@EnglishName",  _SchoolSoGiaoDuc.EnglishName, 
					"@Phone",  _SchoolSoGiaoDuc.Phone, 
					"@DiaChi",  _SchoolSoGiaoDuc.DiaChi, 
					"@Email",  _SchoolSoGiaoDuc.Email, 
					"@GiamDoc",  _SchoolSoGiaoDuc.GiamDoc, 
					"@DauMoiLienHe",  _SchoolSoGiaoDuc.DauMoiLienHe, 
					"@SoDienThoai",  _SchoolSoGiaoDuc.SoDienThoai, 
					"@FK_NhanVien",  _SchoolSoGiaoDuc.FK_NhanVien, 
					"@CreateBy",  _SchoolSoGiaoDuc.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _SchoolSoGiaoDuc.CreateDate), 
					"@GoogleMap",  _SchoolSoGiaoDuc.GoogleMap, 
					"@Id", _SchoolSoGiaoDuc.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách SchoolSoGiaoDuc vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<SchoolSoGiaoDuc> _SchoolSoGiaoDucs)
		{
			foreach (SchoolSoGiaoDuc item in _SchoolSoGiaoDucs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SchoolSoGiaoDuc vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, SchoolSoGiaoDuc _SchoolSoGiaoDuc, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SchoolSoGiaoDuc] SET Id=@Id, TenSo=@TenSo, EnglishName=@EnglishName, Phone=@Phone, DiaChi=@DiaChi, Email=@Email, GiamDoc=@GiamDoc, DauMoiLienHe=@DauMoiLienHe, SoDienThoai=@SoDienThoai, FK_NhanVien=@FK_NhanVien, CreateBy=@CreateBy, CreateDate=@CreateDate, GoogleMap=@GoogleMap "+ condition, 
					"@Id",  _SchoolSoGiaoDuc.Id, 
					"@TenSo",  _SchoolSoGiaoDuc.TenSo, 
					"@EnglishName",  _SchoolSoGiaoDuc.EnglishName, 
					"@Phone",  _SchoolSoGiaoDuc.Phone, 
					"@DiaChi",  _SchoolSoGiaoDuc.DiaChi, 
					"@Email",  _SchoolSoGiaoDuc.Email, 
					"@GiamDoc",  _SchoolSoGiaoDuc.GiamDoc, 
					"@DauMoiLienHe",  _SchoolSoGiaoDuc.DauMoiLienHe, 
					"@SoDienThoai",  _SchoolSoGiaoDuc.SoDienThoai, 
					"@FK_NhanVien",  _SchoolSoGiaoDuc.FK_NhanVien, 
					"@CreateBy",  _SchoolSoGiaoDuc.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _SchoolSoGiaoDuc.CreateDate), 
					"@GoogleMap",  _SchoolSoGiaoDuc.GoogleMap);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa SchoolSoGiaoDuc trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SchoolSoGiaoDuc] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SchoolSoGiaoDuc trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, SchoolSoGiaoDuc _SchoolSoGiaoDuc)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SchoolSoGiaoDuc] WHERE Id=@Id",
					"@Id", _SchoolSoGiaoDuc.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SchoolSoGiaoDuc trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SchoolSoGiaoDuc] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SchoolSoGiaoDuc trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<SchoolSoGiaoDuc> _SchoolSoGiaoDucs)
		{
			foreach (SchoolSoGiaoDuc item in _SchoolSoGiaoDucs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
