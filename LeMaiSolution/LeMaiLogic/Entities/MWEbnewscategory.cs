using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MWEbnewscategory:IWEbnewscategory
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MWEbnewscategory(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable WebNewsCategory từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebNewsCategory]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable WebNewsCategory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebNewsCategory] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách WebNewsCategory từ Database
		/// </summary>
		public List<WebNewsCategory> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebNewsCategory]");
				List<WebNewsCategory> items = new List<WebNewsCategory>();
				WebNewsCategory item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebNewsCategory();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["CategoryName"] != null && dr["CategoryName"] != DBNull.Value)
					{
						item.CategoryName = Convert.ToString(dr["CategoryName"]);
					}
					if (dr["Path"] != null && dr["Path"] != DBNull.Value)
					{
						item.Path = Convert.ToString(dr["Path"]);
					}
					if (dr["FK_ParrentCategory"] != null && dr["FK_ParrentCategory"] != DBNull.Value)
					{
						item.FK_ParrentCategory = Convert.ToString(dr["FK_ParrentCategory"]);
					}
					if (dr["Description"] != null && dr["Description"] != DBNull.Value)
					{
						item.Description = Convert.ToString(dr["Description"]);
					}
					if (dr["FK_CreateBy"] != null && dr["FK_CreateBy"] != DBNull.Value)
					{
						item.FK_CreateBy = Convert.ToString(dr["FK_CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["OrderNo"] != null && dr["OrderNo"] != DBNull.Value)
					{
						item.OrderNo = Convert.ToInt32(dr["OrderNo"]);
					}
					if (dr["BranchCode"] != null && dr["BranchCode"] != DBNull.Value)
					{
						item.BranchCode = Convert.ToString(dr["BranchCode"]);
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
		/// Lấy danh sách WebNewsCategory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<WebNewsCategory> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebNewsCategory] A "+ condition,  parameters);
				List<WebNewsCategory> items = new List<WebNewsCategory>();
				WebNewsCategory item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebNewsCategory();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["CategoryName"] != null && dr["CategoryName"] != DBNull.Value)
					{
						item.CategoryName = Convert.ToString(dr["CategoryName"]);
					}
					if (dr["Path"] != null && dr["Path"] != DBNull.Value)
					{
						item.Path = Convert.ToString(dr["Path"]);
					}
					if (dr["FK_ParrentCategory"] != null && dr["FK_ParrentCategory"] != DBNull.Value)
					{
						item.FK_ParrentCategory = Convert.ToString(dr["FK_ParrentCategory"]);
					}
					if (dr["Description"] != null && dr["Description"] != DBNull.Value)
					{
						item.Description = Convert.ToString(dr["Description"]);
					}
					if (dr["FK_CreateBy"] != null && dr["FK_CreateBy"] != DBNull.Value)
					{
						item.FK_CreateBy = Convert.ToString(dr["FK_CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["OrderNo"] != null && dr["OrderNo"] != DBNull.Value)
					{
						item.OrderNo = Convert.ToInt32(dr["OrderNo"]);
					}
					if (dr["BranchCode"] != null && dr["BranchCode"] != DBNull.Value)
					{
						item.BranchCode = Convert.ToString(dr["BranchCode"]);
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

		public List<WebNewsCategory> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebNewsCategory] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[WebNewsCategory] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<WebNewsCategory>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một WebNewsCategory từ Database
		/// </summary>
		public WebNewsCategory GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebNewsCategory] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					WebNewsCategory item=new WebNewsCategory();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["CategoryName"] != null && dr["CategoryName"] != DBNull.Value)
						{
							item.CategoryName = Convert.ToString(dr["CategoryName"]);
						}
						if (dr["Path"] != null && dr["Path"] != DBNull.Value)
						{
							item.Path = Convert.ToString(dr["Path"]);
						}
						if (dr["FK_ParrentCategory"] != null && dr["FK_ParrentCategory"] != DBNull.Value)
						{
							item.FK_ParrentCategory = Convert.ToString(dr["FK_ParrentCategory"]);
						}
						if (dr["Description"] != null && dr["Description"] != DBNull.Value)
						{
							item.Description = Convert.ToString(dr["Description"]);
						}
						if (dr["FK_CreateBy"] != null && dr["FK_CreateBy"] != DBNull.Value)
						{
							item.FK_CreateBy = Convert.ToString(dr["FK_CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
						}
						if (dr["OrderNo"] != null && dr["OrderNo"] != DBNull.Value)
						{
							item.OrderNo = Convert.ToInt32(dr["OrderNo"]);
						}
						if (dr["BranchCode"] != null && dr["BranchCode"] != DBNull.Value)
						{
							item.BranchCode = Convert.ToString(dr["BranchCode"]);
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
		/// Lấy một WebNewsCategory đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public WebNewsCategory GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebNewsCategory] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					WebNewsCategory item=new WebNewsCategory();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["CategoryName"] != null && dr["CategoryName"] != DBNull.Value)
						{
							item.CategoryName = Convert.ToString(dr["CategoryName"]);
						}
						if (dr["Path"] != null && dr["Path"] != DBNull.Value)
						{
							item.Path = Convert.ToString(dr["Path"]);
						}
						if (dr["FK_ParrentCategory"] != null && dr["FK_ParrentCategory"] != DBNull.Value)
						{
							item.FK_ParrentCategory = Convert.ToString(dr["FK_ParrentCategory"]);
						}
						if (dr["Description"] != null && dr["Description"] != DBNull.Value)
						{
							item.Description = Convert.ToString(dr["Description"]);
						}
						if (dr["FK_CreateBy"] != null && dr["FK_CreateBy"] != DBNull.Value)
						{
							item.FK_CreateBy = Convert.ToString(dr["FK_CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
						}
						if (dr["OrderNo"] != null && dr["OrderNo"] != DBNull.Value)
						{
							item.OrderNo = Convert.ToInt32(dr["OrderNo"]);
						}
						if (dr["BranchCode"] != null && dr["BranchCode"] != DBNull.Value)
						{
							item.BranchCode = Convert.ToString(dr["BranchCode"]);
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

		public WebNewsCategory GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebNewsCategory] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<WebNewsCategory>(ds);
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
		/// Thêm mới WebNewsCategory vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, WebNewsCategory _WebNewsCategory)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[WebNewsCategory](Id, CategoryName, Path, FK_ParrentCategory, Description, FK_CreateBy, CreateDate, IsDelete, OrderNo, BranchCode) VALUES(@Id, @CategoryName, @Path, @FK_ParrentCategory, @Description, @FK_CreateBy, @CreateDate, @IsDelete, @OrderNo, @BranchCode)", 
					"@Id",  _WebNewsCategory.Id, 
					"@CategoryName",  _WebNewsCategory.CategoryName, 
					"@Path",  _WebNewsCategory.Path, 
					"@FK_ParrentCategory",  _WebNewsCategory.FK_ParrentCategory, 
					"@Description",  _WebNewsCategory.Description, 
					"@FK_CreateBy",  _WebNewsCategory.FK_CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _WebNewsCategory.CreateDate), 
					"@IsDelete",  _WebNewsCategory.IsDelete, 
					"@OrderNo",  _WebNewsCategory.OrderNo, 
					"@BranchCode",  _WebNewsCategory.BranchCode);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng WebNewsCategory vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<WebNewsCategory> _WebNewsCategorys)
		{
			foreach (WebNewsCategory item in _WebNewsCategorys)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebNewsCategory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, WebNewsCategory _WebNewsCategory, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebNewsCategory] SET Id=@Id, CategoryName=@CategoryName, Path=@Path, FK_ParrentCategory=@FK_ParrentCategory, Description=@Description, FK_CreateBy=@FK_CreateBy, CreateDate=@CreateDate, IsDelete=@IsDelete, OrderNo=@OrderNo, BranchCode=@BranchCode WHERE Id=@Id", 
					"@Id",  _WebNewsCategory.Id, 
					"@CategoryName",  _WebNewsCategory.CategoryName, 
					"@Path",  _WebNewsCategory.Path, 
					"@FK_ParrentCategory",  _WebNewsCategory.FK_ParrentCategory, 
					"@Description",  _WebNewsCategory.Description, 
					"@FK_CreateBy",  _WebNewsCategory.FK_CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _WebNewsCategory.CreateDate), 
					"@IsDelete",  _WebNewsCategory.IsDelete, 
					"@OrderNo",  _WebNewsCategory.OrderNo, 
					"@BranchCode",  _WebNewsCategory.BranchCode, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật WebNewsCategory vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, WebNewsCategory _WebNewsCategory)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebNewsCategory] SET CategoryName=@CategoryName, Path=@Path, FK_ParrentCategory=@FK_ParrentCategory, Description=@Description, FK_CreateBy=@FK_CreateBy, CreateDate=@CreateDate, IsDelete=@IsDelete, OrderNo=@OrderNo, BranchCode=@BranchCode WHERE Id=@Id", 
					"@CategoryName",  _WebNewsCategory.CategoryName, 
					"@Path",  _WebNewsCategory.Path, 
					"@FK_ParrentCategory",  _WebNewsCategory.FK_ParrentCategory, 
					"@Description",  _WebNewsCategory.Description, 
					"@FK_CreateBy",  _WebNewsCategory.FK_CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _WebNewsCategory.CreateDate), 
					"@IsDelete",  _WebNewsCategory.IsDelete, 
					"@OrderNo",  _WebNewsCategory.OrderNo, 
					"@BranchCode",  _WebNewsCategory.BranchCode, 
					"@Id", _WebNewsCategory.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách WebNewsCategory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<WebNewsCategory> _WebNewsCategorys)
		{
			foreach (WebNewsCategory item in _WebNewsCategorys)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebNewsCategory vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, WebNewsCategory _WebNewsCategory, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebNewsCategory] SET Id=@Id, CategoryName=@CategoryName, Path=@Path, FK_ParrentCategory=@FK_ParrentCategory, Description=@Description, FK_CreateBy=@FK_CreateBy, CreateDate=@CreateDate, IsDelete=@IsDelete, OrderNo=@OrderNo, BranchCode=@BranchCode "+ condition, 
					"@Id",  _WebNewsCategory.Id, 
					"@CategoryName",  _WebNewsCategory.CategoryName, 
					"@Path",  _WebNewsCategory.Path, 
					"@FK_ParrentCategory",  _WebNewsCategory.FK_ParrentCategory, 
					"@Description",  _WebNewsCategory.Description, 
					"@FK_CreateBy",  _WebNewsCategory.FK_CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _WebNewsCategory.CreateDate), 
					"@IsDelete",  _WebNewsCategory.IsDelete, 
					"@OrderNo",  _WebNewsCategory.OrderNo, 
					"@BranchCode",  _WebNewsCategory.BranchCode);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa WebNewsCategory trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebNewsCategory] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebNewsCategory trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, WebNewsCategory _WebNewsCategory)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebNewsCategory] WHERE Id=@Id",
					"@Id", _WebNewsCategory.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebNewsCategory trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebNewsCategory] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebNewsCategory trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<WebNewsCategory> _WebNewsCategorys)
		{
			foreach (WebNewsCategory item in _WebNewsCategorys)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
