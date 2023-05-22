using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpprovider:IEXpprovider
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpprovider(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpProvider từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpProvider]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpProvider từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpProvider] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpProvider từ Database
		/// </summary>
		public List<ExpProvider> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpProvider]");
				List<ExpProvider> items = new List<ExpProvider>();
				ExpProvider item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpProvider();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["TenNhaCungCap"] != null && dr["TenNhaCungCap"] != DBNull.Value)
					{
						item.TenNhaCungCap = Convert.ToString(dr["TenNhaCungCap"]);
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
					if (dr["QuanLy"] != null && dr["QuanLy"] != DBNull.Value)
					{
						item.QuanLy = Convert.ToString(dr["QuanLy"]);
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
					if (dr["GoogleMap"] != null && dr["GoogleMap"] != DBNull.Value)
					{
						item.GoogleMap = Convert.ToString(dr["GoogleMap"]);
					}
					if (dr["ApiUrl"] != null && dr["ApiUrl"] != DBNull.Value)
					{
						item.ApiUrl = Convert.ToString(dr["ApiUrl"]);
					}
					if (dr["ApiUser"] != null && dr["ApiUser"] != DBNull.Value)
					{
						item.ApiUser = Convert.ToString(dr["ApiUser"]);
					}
					if (dr["ApiSecrect"] != null && dr["ApiSecrect"] != DBNull.Value)
					{
						item.ApiSecrect = Convert.ToString(dr["ApiSecrect"]);
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
		/// Lấy danh sách ExpProvider từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpProvider> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpProvider] A "+ condition,  parameters);
				List<ExpProvider> items = new List<ExpProvider>();
				ExpProvider item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpProvider();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["TenNhaCungCap"] != null && dr["TenNhaCungCap"] != DBNull.Value)
					{
						item.TenNhaCungCap = Convert.ToString(dr["TenNhaCungCap"]);
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
					if (dr["QuanLy"] != null && dr["QuanLy"] != DBNull.Value)
					{
						item.QuanLy = Convert.ToString(dr["QuanLy"]);
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
					if (dr["GoogleMap"] != null && dr["GoogleMap"] != DBNull.Value)
					{
						item.GoogleMap = Convert.ToString(dr["GoogleMap"]);
					}
					if (dr["ApiUrl"] != null && dr["ApiUrl"] != DBNull.Value)
					{
						item.ApiUrl = Convert.ToString(dr["ApiUrl"]);
					}
					if (dr["ApiUser"] != null && dr["ApiUser"] != DBNull.Value)
					{
						item.ApiUser = Convert.ToString(dr["ApiUser"]);
					}
					if (dr["ApiSecrect"] != null && dr["ApiSecrect"] != DBNull.Value)
					{
						item.ApiSecrect = Convert.ToString(dr["ApiSecrect"]);
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

		public List<ExpProvider> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpProvider] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpProvider] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpProvider>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpProvider từ Database
		/// </summary>
		public ExpProvider GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpProvider] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpProvider item=new ExpProvider();
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
						if (dr["TenNhaCungCap"] != null && dr["TenNhaCungCap"] != DBNull.Value)
						{
							item.TenNhaCungCap = Convert.ToString(dr["TenNhaCungCap"]);
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
						if (dr["QuanLy"] != null && dr["QuanLy"] != DBNull.Value)
						{
							item.QuanLy = Convert.ToString(dr["QuanLy"]);
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
						if (dr["GoogleMap"] != null && dr["GoogleMap"] != DBNull.Value)
						{
							item.GoogleMap = Convert.ToString(dr["GoogleMap"]);
						}
						if (dr["ApiUrl"] != null && dr["ApiUrl"] != DBNull.Value)
						{
							item.ApiUrl = Convert.ToString(dr["ApiUrl"]);
						}
						if (dr["ApiUser"] != null && dr["ApiUser"] != DBNull.Value)
						{
							item.ApiUser = Convert.ToString(dr["ApiUser"]);
						}
						if (dr["ApiSecrect"] != null && dr["ApiSecrect"] != DBNull.Value)
						{
							item.ApiSecrect = Convert.ToString(dr["ApiSecrect"]);
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
		/// Lấy một ExpProvider đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpProvider GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpProvider] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpProvider item=new ExpProvider();
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
						if (dr["TenNhaCungCap"] != null && dr["TenNhaCungCap"] != DBNull.Value)
						{
							item.TenNhaCungCap = Convert.ToString(dr["TenNhaCungCap"]);
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
						if (dr["QuanLy"] != null && dr["QuanLy"] != DBNull.Value)
						{
							item.QuanLy = Convert.ToString(dr["QuanLy"]);
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
						if (dr["GoogleMap"] != null && dr["GoogleMap"] != DBNull.Value)
						{
							item.GoogleMap = Convert.ToString(dr["GoogleMap"]);
						}
						if (dr["ApiUrl"] != null && dr["ApiUrl"] != DBNull.Value)
						{
							item.ApiUrl = Convert.ToString(dr["ApiUrl"]);
						}
						if (dr["ApiUser"] != null && dr["ApiUser"] != DBNull.Value)
						{
							item.ApiUser = Convert.ToString(dr["ApiUser"]);
						}
						if (dr["ApiSecrect"] != null && dr["ApiSecrect"] != DBNull.Value)
						{
							item.ApiSecrect = Convert.ToString(dr["ApiSecrect"]);
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

		public ExpProvider GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpProvider] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpProvider>(ds);
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
		/// Thêm mới ExpProvider vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpProvider _ExpProvider)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpProvider](Id, Code, TenNhaCungCap, Phone, DiaChi, Email, QuanLy, SoDienThoai, CreateBy, CreateDate, GoogleMap, ApiUrl, ApiUser, ApiSecrect) VALUES(@Id, @Code, @TenNhaCungCap, @Phone, @DiaChi, @Email, @QuanLy, @SoDienThoai, @CreateBy, @CreateDate, @GoogleMap, @ApiUrl, @ApiUser, @ApiSecrect)", 
					"@Id",  _ExpProvider.Id, 
					"@Code",  _ExpProvider.Code, 
					"@TenNhaCungCap",  _ExpProvider.TenNhaCungCap, 
					"@Phone",  _ExpProvider.Phone, 
					"@DiaChi",  _ExpProvider.DiaChi, 
					"@Email",  _ExpProvider.Email, 
					"@QuanLy",  _ExpProvider.QuanLy, 
					"@SoDienThoai",  _ExpProvider.SoDienThoai, 
					"@CreateBy",  _ExpProvider.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpProvider.CreateDate), 
					"@GoogleMap",  _ExpProvider.GoogleMap, 
					"@ApiUrl",  _ExpProvider.ApiUrl, 
					"@ApiUser",  _ExpProvider.ApiUser, 
					"@ApiSecrect",  _ExpProvider.ApiSecrect);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpProvider vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpProvider> _ExpProviders)
		{
			foreach (ExpProvider item in _ExpProviders)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpProvider vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpProvider _ExpProvider, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpProvider] SET Id=@Id, Code=@Code, TenNhaCungCap=@TenNhaCungCap, Phone=@Phone, DiaChi=@DiaChi, Email=@Email, QuanLy=@QuanLy, SoDienThoai=@SoDienThoai, CreateBy=@CreateBy, CreateDate=@CreateDate, GoogleMap=@GoogleMap, ApiUrl=@ApiUrl, ApiUser=@ApiUser, ApiSecrect=@ApiSecrect WHERE Id=@Id", 
					"@Id",  _ExpProvider.Id, 
					"@Code",  _ExpProvider.Code, 
					"@TenNhaCungCap",  _ExpProvider.TenNhaCungCap, 
					"@Phone",  _ExpProvider.Phone, 
					"@DiaChi",  _ExpProvider.DiaChi, 
					"@Email",  _ExpProvider.Email, 
					"@QuanLy",  _ExpProvider.QuanLy, 
					"@SoDienThoai",  _ExpProvider.SoDienThoai, 
					"@CreateBy",  _ExpProvider.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpProvider.CreateDate), 
					"@GoogleMap",  _ExpProvider.GoogleMap, 
					"@ApiUrl",  _ExpProvider.ApiUrl, 
					"@ApiUser",  _ExpProvider.ApiUser, 
					"@ApiSecrect",  _ExpProvider.ApiSecrect, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpProvider vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpProvider _ExpProvider)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpProvider] SET Code=@Code, TenNhaCungCap=@TenNhaCungCap, Phone=@Phone, DiaChi=@DiaChi, Email=@Email, QuanLy=@QuanLy, SoDienThoai=@SoDienThoai, CreateBy=@CreateBy, CreateDate=@CreateDate, GoogleMap=@GoogleMap, ApiUrl=@ApiUrl, ApiUser=@ApiUser, ApiSecrect=@ApiSecrect WHERE Id=@Id", 
					"@Code",  _ExpProvider.Code, 
					"@TenNhaCungCap",  _ExpProvider.TenNhaCungCap, 
					"@Phone",  _ExpProvider.Phone, 
					"@DiaChi",  _ExpProvider.DiaChi, 
					"@Email",  _ExpProvider.Email, 
					"@QuanLy",  _ExpProvider.QuanLy, 
					"@SoDienThoai",  _ExpProvider.SoDienThoai, 
					"@CreateBy",  _ExpProvider.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpProvider.CreateDate), 
					"@GoogleMap",  _ExpProvider.GoogleMap, 
					"@ApiUrl",  _ExpProvider.ApiUrl, 
					"@ApiUser",  _ExpProvider.ApiUser, 
					"@ApiSecrect",  _ExpProvider.ApiSecrect, 
					"@Id", _ExpProvider.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpProvider vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpProvider> _ExpProviders)
		{
			foreach (ExpProvider item in _ExpProviders)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpProvider vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpProvider _ExpProvider, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpProvider] SET Id=@Id, Code=@Code, TenNhaCungCap=@TenNhaCungCap, Phone=@Phone, DiaChi=@DiaChi, Email=@Email, QuanLy=@QuanLy, SoDienThoai=@SoDienThoai, CreateBy=@CreateBy, CreateDate=@CreateDate, GoogleMap=@GoogleMap, ApiUrl=@ApiUrl, ApiUser=@ApiUser, ApiSecrect=@ApiSecrect "+ condition, 
					"@Id",  _ExpProvider.Id, 
					"@Code",  _ExpProvider.Code, 
					"@TenNhaCungCap",  _ExpProvider.TenNhaCungCap, 
					"@Phone",  _ExpProvider.Phone, 
					"@DiaChi",  _ExpProvider.DiaChi, 
					"@Email",  _ExpProvider.Email, 
					"@QuanLy",  _ExpProvider.QuanLy, 
					"@SoDienThoai",  _ExpProvider.SoDienThoai, 
					"@CreateBy",  _ExpProvider.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpProvider.CreateDate), 
					"@GoogleMap",  _ExpProvider.GoogleMap, 
					"@ApiUrl",  _ExpProvider.ApiUrl, 
					"@ApiUser",  _ExpProvider.ApiUser, 
					"@ApiSecrect",  _ExpProvider.ApiSecrect);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpProvider trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpProvider] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpProvider trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpProvider _ExpProvider)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpProvider] WHERE Id=@Id",
					"@Id", _ExpProvider.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpProvider trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpProvider] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpProvider trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpProvider> _ExpProviders)
		{
			foreach (ExpProvider item in _ExpProviders)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
