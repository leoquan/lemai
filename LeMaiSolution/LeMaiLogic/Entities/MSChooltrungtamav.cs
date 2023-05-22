using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MSChooltrungtamav:ISChooltrungtamav
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MSChooltrungtamav(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable SchoolTrungTamAV từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolTrungTamAV]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable SchoolTrungTamAV từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolTrungTamAV] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách SchoolTrungTamAV từ Database
		/// </summary>
		public List<SchoolTrungTamAV> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolTrungTamAV]");
				List<SchoolTrungTamAV> items = new List<SchoolTrungTamAV>();
				SchoolTrungTamAV item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SchoolTrungTamAV();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["TrungTam"] != null && dr["TrungTam"] != DBNull.Value)
					{
						item.TrungTam = Convert.ToString(dr["TrungTam"]);
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
					if (dr["HanhChinh"] != null && dr["HanhChinh"] != DBNull.Value)
					{
						item.HanhChinh = Convert.ToString(dr["HanhChinh"]);
					}
					if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
					{
						item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
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
		/// Lấy danh sách SchoolTrungTamAV từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<SchoolTrungTamAV> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SchoolTrungTamAV] A "+ condition,  parameters);
				List<SchoolTrungTamAV> items = new List<SchoolTrungTamAV>();
				SchoolTrungTamAV item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new SchoolTrungTamAV();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["TrungTam"] != null && dr["TrungTam"] != DBNull.Value)
					{
						item.TrungTam = Convert.ToString(dr["TrungTam"]);
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
					if (dr["HanhChinh"] != null && dr["HanhChinh"] != DBNull.Value)
					{
						item.HanhChinh = Convert.ToString(dr["HanhChinh"]);
					}
					if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
					{
						item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
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

		public List<SchoolTrungTamAV> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SchoolTrungTamAV] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[SchoolTrungTamAV] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<SchoolTrungTamAV>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một SchoolTrungTamAV từ Database
		/// </summary>
		public SchoolTrungTamAV GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[SchoolTrungTamAV] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					SchoolTrungTamAV item=new SchoolTrungTamAV();
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
						if (dr["TrungTam"] != null && dr["TrungTam"] != DBNull.Value)
						{
							item.TrungTam = Convert.ToString(dr["TrungTam"]);
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
						if (dr["HanhChinh"] != null && dr["HanhChinh"] != DBNull.Value)
						{
							item.HanhChinh = Convert.ToString(dr["HanhChinh"]);
						}
						if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
						{
							item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
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
		/// Lấy một SchoolTrungTamAV đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public SchoolTrungTamAV GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[SchoolTrungTamAV] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					SchoolTrungTamAV item=new SchoolTrungTamAV();
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
						if (dr["TrungTam"] != null && dr["TrungTam"] != DBNull.Value)
						{
							item.TrungTam = Convert.ToString(dr["TrungTam"]);
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
						if (dr["HanhChinh"] != null && dr["HanhChinh"] != DBNull.Value)
						{
							item.HanhChinh = Convert.ToString(dr["HanhChinh"]);
						}
						if (dr["SoDienThoai"] != null && dr["SoDienThoai"] != DBNull.Value)
						{
							item.SoDienThoai = Convert.ToString(dr["SoDienThoai"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
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

		public SchoolTrungTamAV GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[SchoolTrungTamAV] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<SchoolTrungTamAV>(ds);
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
		/// Thêm mới SchoolTrungTamAV vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, SchoolTrungTamAV _SchoolTrungTamAV)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[SchoolTrungTamAV](Id, Code, TrungTam, EnglishName, Phone, DiaChi, Email, GiamDoc, HanhChinh, SoDienThoai, CreateBy, CreateDate) VALUES(@Id, @Code, @TrungTam, @EnglishName, @Phone, @DiaChi, @Email, @GiamDoc, @HanhChinh, @SoDienThoai, @CreateBy, @CreateDate)", 
					"@Id",  _SchoolTrungTamAV.Id, 
					"@Code",  _SchoolTrungTamAV.Code, 
					"@TrungTam",  _SchoolTrungTamAV.TrungTam, 
					"@EnglishName",  _SchoolTrungTamAV.EnglishName, 
					"@Phone",  _SchoolTrungTamAV.Phone, 
					"@DiaChi",  _SchoolTrungTamAV.DiaChi, 
					"@Email",  _SchoolTrungTamAV.Email, 
					"@GiamDoc",  _SchoolTrungTamAV.GiamDoc, 
					"@HanhChinh",  _SchoolTrungTamAV.HanhChinh, 
					"@SoDienThoai",  _SchoolTrungTamAV.SoDienThoai, 
					"@CreateBy",  _SchoolTrungTamAV.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _SchoolTrungTamAV.CreateDate));
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng SchoolTrungTamAV vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<SchoolTrungTamAV> _SchoolTrungTamAVs)
		{
			foreach (SchoolTrungTamAV item in _SchoolTrungTamAVs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SchoolTrungTamAV vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, SchoolTrungTamAV _SchoolTrungTamAV, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SchoolTrungTamAV] SET Id=@Id, Code=@Code, TrungTam=@TrungTam, EnglishName=@EnglishName, Phone=@Phone, DiaChi=@DiaChi, Email=@Email, GiamDoc=@GiamDoc, HanhChinh=@HanhChinh, SoDienThoai=@SoDienThoai, CreateBy=@CreateBy, CreateDate=@CreateDate WHERE Id=@Id", 
					"@Id",  _SchoolTrungTamAV.Id, 
					"@Code",  _SchoolTrungTamAV.Code, 
					"@TrungTam",  _SchoolTrungTamAV.TrungTam, 
					"@EnglishName",  _SchoolTrungTamAV.EnglishName, 
					"@Phone",  _SchoolTrungTamAV.Phone, 
					"@DiaChi",  _SchoolTrungTamAV.DiaChi, 
					"@Email",  _SchoolTrungTamAV.Email, 
					"@GiamDoc",  _SchoolTrungTamAV.GiamDoc, 
					"@HanhChinh",  _SchoolTrungTamAV.HanhChinh, 
					"@SoDienThoai",  _SchoolTrungTamAV.SoDienThoai, 
					"@CreateBy",  _SchoolTrungTamAV.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _SchoolTrungTamAV.CreateDate), 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật SchoolTrungTamAV vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, SchoolTrungTamAV _SchoolTrungTamAV)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SchoolTrungTamAV] SET Code=@Code, TrungTam=@TrungTam, EnglishName=@EnglishName, Phone=@Phone, DiaChi=@DiaChi, Email=@Email, GiamDoc=@GiamDoc, HanhChinh=@HanhChinh, SoDienThoai=@SoDienThoai, CreateBy=@CreateBy, CreateDate=@CreateDate WHERE Id=@Id", 
					"@Code",  _SchoolTrungTamAV.Code, 
					"@TrungTam",  _SchoolTrungTamAV.TrungTam, 
					"@EnglishName",  _SchoolTrungTamAV.EnglishName, 
					"@Phone",  _SchoolTrungTamAV.Phone, 
					"@DiaChi",  _SchoolTrungTamAV.DiaChi, 
					"@Email",  _SchoolTrungTamAV.Email, 
					"@GiamDoc",  _SchoolTrungTamAV.GiamDoc, 
					"@HanhChinh",  _SchoolTrungTamAV.HanhChinh, 
					"@SoDienThoai",  _SchoolTrungTamAV.SoDienThoai, 
					"@CreateBy",  _SchoolTrungTamAV.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _SchoolTrungTamAV.CreateDate), 
					"@Id", _SchoolTrungTamAV.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách SchoolTrungTamAV vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<SchoolTrungTamAV> _SchoolTrungTamAVs)
		{
			foreach (SchoolTrungTamAV item in _SchoolTrungTamAVs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật SchoolTrungTamAV vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, SchoolTrungTamAV _SchoolTrungTamAV, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[SchoolTrungTamAV] SET Id=@Id, Code=@Code, TrungTam=@TrungTam, EnglishName=@EnglishName, Phone=@Phone, DiaChi=@DiaChi, Email=@Email, GiamDoc=@GiamDoc, HanhChinh=@HanhChinh, SoDienThoai=@SoDienThoai, CreateBy=@CreateBy, CreateDate=@CreateDate "+ condition, 
					"@Id",  _SchoolTrungTamAV.Id, 
					"@Code",  _SchoolTrungTamAV.Code, 
					"@TrungTam",  _SchoolTrungTamAV.TrungTam, 
					"@EnglishName",  _SchoolTrungTamAV.EnglishName, 
					"@Phone",  _SchoolTrungTamAV.Phone, 
					"@DiaChi",  _SchoolTrungTamAV.DiaChi, 
					"@Email",  _SchoolTrungTamAV.Email, 
					"@GiamDoc",  _SchoolTrungTamAV.GiamDoc, 
					"@HanhChinh",  _SchoolTrungTamAV.HanhChinh, 
					"@SoDienThoai",  _SchoolTrungTamAV.SoDienThoai, 
					"@CreateBy",  _SchoolTrungTamAV.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _SchoolTrungTamAV.CreateDate));
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa SchoolTrungTamAV trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SchoolTrungTamAV] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SchoolTrungTamAV trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, SchoolTrungTamAV _SchoolTrungTamAV)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SchoolTrungTamAV] WHERE Id=@Id",
					"@Id", _SchoolTrungTamAV.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SchoolTrungTamAV trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[SchoolTrungTamAV] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa SchoolTrungTamAV trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<SchoolTrungTamAV> _SchoolTrungTamAVs)
		{
			foreach (SchoolTrungTamAV item in _SchoolTrungTamAVs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
