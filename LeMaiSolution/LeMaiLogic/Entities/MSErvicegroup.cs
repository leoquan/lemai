using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MSErvicegroup:ISErvicegroup
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MSErvicegroup(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ServiceGroup từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ServiceGroup]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ServiceGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ServiceGroup] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ServiceGroup từ Database
		/// </summary>
		public List<ServiceGroup> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ServiceGroup]");
				List<ServiceGroup> items = new List<ServiceGroup>();
				ServiceGroup item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ServiceGroup();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["GroupName"] != null && dr["GroupName"] != DBNull.Value)
					{
						item.GroupName = Convert.ToString(dr["GroupName"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["ShowOnWeb"] != null && dr["ShowOnWeb"] != DBNull.Value)
					{
						item.ShowOnWeb = Convert.ToBoolean(dr["ShowOnWeb"]);
					}
					if (dr["ShortDescription"] != null && dr["ShortDescription"] != DBNull.Value)
					{
						item.ShortDescription = Convert.ToString(dr["ShortDescription"]);
					}
					if (dr["IconOnWeb"] != null && dr["IconOnWeb"] != DBNull.Value)
					{
						item.IconOnWeb = Convert.ToString(dr["IconOnWeb"]);
					}
					if (dr["IsSevice"] != null && dr["IsSevice"] != DBNull.Value)
					{
						item.IsSevice = Convert.ToBoolean(dr["IsSevice"]);
					}
					if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
					{
						item.ImagePath = Convert.ToString(dr["ImagePath"]);
					}
					if (dr["NumberOrder"] != null && dr["NumberOrder"] != DBNull.Value)
					{
						item.NumberOrder = Convert.ToInt32(dr["NumberOrder"]);
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
		/// Lấy danh sách ServiceGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ServiceGroup> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ServiceGroup] A "+ condition,  parameters);
				List<ServiceGroup> items = new List<ServiceGroup>();
				ServiceGroup item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ServiceGroup();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Code"] != null && dr["Code"] != DBNull.Value)
					{
						item.Code = Convert.ToString(dr["Code"]);
					}
					if (dr["GroupName"] != null && dr["GroupName"] != DBNull.Value)
					{
						item.GroupName = Convert.ToString(dr["GroupName"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["ShowOnWeb"] != null && dr["ShowOnWeb"] != DBNull.Value)
					{
						item.ShowOnWeb = Convert.ToBoolean(dr["ShowOnWeb"]);
					}
					if (dr["ShortDescription"] != null && dr["ShortDescription"] != DBNull.Value)
					{
						item.ShortDescription = Convert.ToString(dr["ShortDescription"]);
					}
					if (dr["IconOnWeb"] != null && dr["IconOnWeb"] != DBNull.Value)
					{
						item.IconOnWeb = Convert.ToString(dr["IconOnWeb"]);
					}
					if (dr["IsSevice"] != null && dr["IsSevice"] != DBNull.Value)
					{
						item.IsSevice = Convert.ToBoolean(dr["IsSevice"]);
					}
					if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
					{
						item.ImagePath = Convert.ToString(dr["ImagePath"]);
					}
					if (dr["NumberOrder"] != null && dr["NumberOrder"] != DBNull.Value)
					{
						item.NumberOrder = Convert.ToInt32(dr["NumberOrder"]);
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

		public List<ServiceGroup> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ServiceGroup] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ServiceGroup] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ServiceGroup>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ServiceGroup từ Database
		/// </summary>
		public ServiceGroup GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ServiceGroup] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ServiceGroup item=new ServiceGroup();
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
						if (dr["GroupName"] != null && dr["GroupName"] != DBNull.Value)
						{
							item.GroupName = Convert.ToString(dr["GroupName"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
						}
						if (dr["ShowOnWeb"] != null && dr["ShowOnWeb"] != DBNull.Value)
						{
							item.ShowOnWeb = Convert.ToBoolean(dr["ShowOnWeb"]);
						}
						if (dr["ShortDescription"] != null && dr["ShortDescription"] != DBNull.Value)
						{
							item.ShortDescription = Convert.ToString(dr["ShortDescription"]);
						}
						if (dr["IconOnWeb"] != null && dr["IconOnWeb"] != DBNull.Value)
						{
							item.IconOnWeb = Convert.ToString(dr["IconOnWeb"]);
						}
						if (dr["IsSevice"] != null && dr["IsSevice"] != DBNull.Value)
						{
							item.IsSevice = Convert.ToBoolean(dr["IsSevice"]);
						}
						if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
						{
							item.ImagePath = Convert.ToString(dr["ImagePath"]);
						}
						if (dr["NumberOrder"] != null && dr["NumberOrder"] != DBNull.Value)
						{
							item.NumberOrder = Convert.ToInt32(dr["NumberOrder"]);
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
		/// Lấy một ServiceGroup đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ServiceGroup GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ServiceGroup] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ServiceGroup item=new ServiceGroup();
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
						if (dr["GroupName"] != null && dr["GroupName"] != DBNull.Value)
						{
							item.GroupName = Convert.ToString(dr["GroupName"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
						}
						if (dr["ShowOnWeb"] != null && dr["ShowOnWeb"] != DBNull.Value)
						{
							item.ShowOnWeb = Convert.ToBoolean(dr["ShowOnWeb"]);
						}
						if (dr["ShortDescription"] != null && dr["ShortDescription"] != DBNull.Value)
						{
							item.ShortDescription = Convert.ToString(dr["ShortDescription"]);
						}
						if (dr["IconOnWeb"] != null && dr["IconOnWeb"] != DBNull.Value)
						{
							item.IconOnWeb = Convert.ToString(dr["IconOnWeb"]);
						}
						if (dr["IsSevice"] != null && dr["IsSevice"] != DBNull.Value)
						{
							item.IsSevice = Convert.ToBoolean(dr["IsSevice"]);
						}
						if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
						{
							item.ImagePath = Convert.ToString(dr["ImagePath"]);
						}
						if (dr["NumberOrder"] != null && dr["NumberOrder"] != DBNull.Value)
						{
							item.NumberOrder = Convert.ToInt32(dr["NumberOrder"]);
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

		public ServiceGroup GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ServiceGroup] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ServiceGroup>(ds);
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
		/// Thêm mới ServiceGroup vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ServiceGroup _ServiceGroup)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ServiceGroup](Id, Code, GroupName, CreateDate, CreateBy, IsDelete, ShowOnWeb, ShortDescription, IconOnWeb, IsSevice, ImagePath, NumberOrder) VALUES(@Id, @Code, @GroupName, @CreateDate, @CreateBy, @IsDelete, @ShowOnWeb, @ShortDescription, @IconOnWeb, @IsSevice, @ImagePath, @NumberOrder)", 
					"@Id",  _ServiceGroup.Id, 
					"@Code",  _ServiceGroup.Code, 
					"@GroupName",  _ServiceGroup.GroupName, 
					"@CreateDate", this._dataContext.ConvertDateString( _ServiceGroup.CreateDate), 
					"@CreateBy",  _ServiceGroup.CreateBy, 
					"@IsDelete",  _ServiceGroup.IsDelete, 
					"@ShowOnWeb",  _ServiceGroup.ShowOnWeb, 
					"@ShortDescription",  _ServiceGroup.ShortDescription, 
					"@IconOnWeb",  _ServiceGroup.IconOnWeb, 
					"@IsSevice",  _ServiceGroup.IsSevice, 
					"@ImagePath",  _ServiceGroup.ImagePath, 
					"@NumberOrder",  _ServiceGroup.NumberOrder);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ServiceGroup vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ServiceGroup> _ServiceGroups)
		{
			foreach (ServiceGroup item in _ServiceGroups)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ServiceGroup vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ServiceGroup _ServiceGroup, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ServiceGroup] SET Id=@Id, Code=@Code, GroupName=@GroupName, CreateDate=@CreateDate, CreateBy=@CreateBy, IsDelete=@IsDelete, ShowOnWeb=@ShowOnWeb, ShortDescription=@ShortDescription, IconOnWeb=@IconOnWeb, IsSevice=@IsSevice, ImagePath=@ImagePath, NumberOrder=@NumberOrder WHERE Id=@Id", 
					"@Id",  _ServiceGroup.Id, 
					"@Code",  _ServiceGroup.Code, 
					"@GroupName",  _ServiceGroup.GroupName, 
					"@CreateDate", this._dataContext.ConvertDateString( _ServiceGroup.CreateDate), 
					"@CreateBy",  _ServiceGroup.CreateBy, 
					"@IsDelete",  _ServiceGroup.IsDelete, 
					"@ShowOnWeb",  _ServiceGroup.ShowOnWeb, 
					"@ShortDescription",  _ServiceGroup.ShortDescription, 
					"@IconOnWeb",  _ServiceGroup.IconOnWeb, 
					"@IsSevice",  _ServiceGroup.IsSevice, 
					"@ImagePath",  _ServiceGroup.ImagePath, 
					"@NumberOrder",  _ServiceGroup.NumberOrder, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ServiceGroup vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ServiceGroup _ServiceGroup)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ServiceGroup] SET Code=@Code, GroupName=@GroupName, CreateDate=@CreateDate, CreateBy=@CreateBy, IsDelete=@IsDelete, ShowOnWeb=@ShowOnWeb, ShortDescription=@ShortDescription, IconOnWeb=@IconOnWeb, IsSevice=@IsSevice, ImagePath=@ImagePath, NumberOrder=@NumberOrder WHERE Id=@Id", 
					"@Code",  _ServiceGroup.Code, 
					"@GroupName",  _ServiceGroup.GroupName, 
					"@CreateDate", this._dataContext.ConvertDateString( _ServiceGroup.CreateDate), 
					"@CreateBy",  _ServiceGroup.CreateBy, 
					"@IsDelete",  _ServiceGroup.IsDelete, 
					"@ShowOnWeb",  _ServiceGroup.ShowOnWeb, 
					"@ShortDescription",  _ServiceGroup.ShortDescription, 
					"@IconOnWeb",  _ServiceGroup.IconOnWeb, 
					"@IsSevice",  _ServiceGroup.IsSevice, 
					"@ImagePath",  _ServiceGroup.ImagePath, 
					"@NumberOrder",  _ServiceGroup.NumberOrder, 
					"@Id", _ServiceGroup.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ServiceGroup vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ServiceGroup> _ServiceGroups)
		{
			foreach (ServiceGroup item in _ServiceGroups)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ServiceGroup vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ServiceGroup _ServiceGroup, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ServiceGroup] SET Id=@Id, Code=@Code, GroupName=@GroupName, CreateDate=@CreateDate, CreateBy=@CreateBy, IsDelete=@IsDelete, ShowOnWeb=@ShowOnWeb, ShortDescription=@ShortDescription, IconOnWeb=@IconOnWeb, IsSevice=@IsSevice, ImagePath=@ImagePath, NumberOrder=@NumberOrder "+ condition, 
					"@Id",  _ServiceGroup.Id, 
					"@Code",  _ServiceGroup.Code, 
					"@GroupName",  _ServiceGroup.GroupName, 
					"@CreateDate", this._dataContext.ConvertDateString( _ServiceGroup.CreateDate), 
					"@CreateBy",  _ServiceGroup.CreateBy, 
					"@IsDelete",  _ServiceGroup.IsDelete, 
					"@ShowOnWeb",  _ServiceGroup.ShowOnWeb, 
					"@ShortDescription",  _ServiceGroup.ShortDescription, 
					"@IconOnWeb",  _ServiceGroup.IconOnWeb, 
					"@IsSevice",  _ServiceGroup.IsSevice, 
					"@ImagePath",  _ServiceGroup.ImagePath, 
					"@NumberOrder",  _ServiceGroup.NumberOrder);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ServiceGroup trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ServiceGroup] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ServiceGroup trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ServiceGroup _ServiceGroup)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ServiceGroup] WHERE Id=@Id",
					"@Id", _ServiceGroup.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ServiceGroup trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ServiceGroup] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ServiceGroup trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ServiceGroup> _ServiceGroups)
		{
			foreach (ServiceGroup item in _ServiceGroups)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
