using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MWEblink:IWEblink
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MWEblink(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable WebLink từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebLink]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable WebLink từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebLink] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách WebLink từ Database
		/// </summary>
		public List<WebLink> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebLink]");
				List<WebLink> items = new List<WebLink>();
				WebLink item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebLink();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Name"] != null && dr["Name"] != DBNull.Value)
					{
						item.Name = Convert.ToString(dr["Name"]);
					}
					if (dr["Link"] != null && dr["Link"] != DBNull.Value)
					{
						item.Link = Convert.ToString(dr["Link"]);
					}
					if (dr["Type"] != null && dr["Type"] != DBNull.Value)
					{
						item.Type = Convert.ToInt32(dr["Type"]);
					}
					if (dr["Icon"] != null && dr["Icon"] != DBNull.Value)
					{
						item.Icon = Convert.ToString(dr["Icon"]);
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
		/// Lấy danh sách WebLink từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<WebLink> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebLink] A "+ condition,  parameters);
				List<WebLink> items = new List<WebLink>();
				WebLink item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebLink();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Name"] != null && dr["Name"] != DBNull.Value)
					{
						item.Name = Convert.ToString(dr["Name"]);
					}
					if (dr["Link"] != null && dr["Link"] != DBNull.Value)
					{
						item.Link = Convert.ToString(dr["Link"]);
					}
					if (dr["Type"] != null && dr["Type"] != DBNull.Value)
					{
						item.Type = Convert.ToInt32(dr["Type"]);
					}
					if (dr["Icon"] != null && dr["Icon"] != DBNull.Value)
					{
						item.Icon = Convert.ToString(dr["Icon"]);
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

		public List<WebLink> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebLink] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[WebLink] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<WebLink>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một WebLink từ Database
		/// </summary>
		public WebLink GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebLink] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					WebLink item=new WebLink();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Name"] != null && dr["Name"] != DBNull.Value)
						{
							item.Name = Convert.ToString(dr["Name"]);
						}
						if (dr["Link"] != null && dr["Link"] != DBNull.Value)
						{
							item.Link = Convert.ToString(dr["Link"]);
						}
						if (dr["Type"] != null && dr["Type"] != DBNull.Value)
						{
							item.Type = Convert.ToInt32(dr["Type"]);
						}
						if (dr["Icon"] != null && dr["Icon"] != DBNull.Value)
						{
							item.Icon = Convert.ToString(dr["Icon"]);
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
		/// Lấy một WebLink đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public WebLink GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebLink] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					WebLink item=new WebLink();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Name"] != null && dr["Name"] != DBNull.Value)
						{
							item.Name = Convert.ToString(dr["Name"]);
						}
						if (dr["Link"] != null && dr["Link"] != DBNull.Value)
						{
							item.Link = Convert.ToString(dr["Link"]);
						}
						if (dr["Type"] != null && dr["Type"] != DBNull.Value)
						{
							item.Type = Convert.ToInt32(dr["Type"]);
						}
						if (dr["Icon"] != null && dr["Icon"] != DBNull.Value)
						{
							item.Icon = Convert.ToString(dr["Icon"]);
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

		public WebLink GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebLink] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<WebLink>(ds);
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
		/// Thêm mới WebLink vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, WebLink _WebLink)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[WebLink](Id, Name, Link, Type, Icon, BranchCode) VALUES(@Id, @Name, @Link, @Type, @Icon, @BranchCode)", 
					"@Id",  _WebLink.Id, 
					"@Name",  _WebLink.Name, 
					"@Link",  _WebLink.Link, 
					"@Type",  _WebLink.Type, 
					"@Icon",  _WebLink.Icon, 
					"@BranchCode",  _WebLink.BranchCode);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng WebLink vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<WebLink> _WebLinks)
		{
			foreach (WebLink item in _WebLinks)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebLink vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, WebLink _WebLink, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebLink] SET Id=@Id, Name=@Name, Link=@Link, Type=@Type, Icon=@Icon, BranchCode=@BranchCode WHERE Id=@Id", 
					"@Id",  _WebLink.Id, 
					"@Name",  _WebLink.Name, 
					"@Link",  _WebLink.Link, 
					"@Type",  _WebLink.Type, 
					"@Icon",  _WebLink.Icon, 
					"@BranchCode",  _WebLink.BranchCode, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật WebLink vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, WebLink _WebLink)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebLink] SET Name=@Name, Link=@Link, Type=@Type, Icon=@Icon, BranchCode=@BranchCode WHERE Id=@Id", 
					"@Name",  _WebLink.Name, 
					"@Link",  _WebLink.Link, 
					"@Type",  _WebLink.Type, 
					"@Icon",  _WebLink.Icon, 
					"@BranchCode",  _WebLink.BranchCode, 
					"@Id", _WebLink.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách WebLink vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<WebLink> _WebLinks)
		{
			foreach (WebLink item in _WebLinks)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebLink vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, WebLink _WebLink, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebLink] SET Id=@Id, Name=@Name, Link=@Link, Type=@Type, Icon=@Icon, BranchCode=@BranchCode "+ condition, 
					"@Id",  _WebLink.Id, 
					"@Name",  _WebLink.Name, 
					"@Link",  _WebLink.Link, 
					"@Type",  _WebLink.Type, 
					"@Icon",  _WebLink.Icon, 
					"@BranchCode",  _WebLink.BranchCode);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa WebLink trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebLink] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebLink trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, WebLink _WebLink)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebLink] WHERE Id=@Id",
					"@Id", _WebLink.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebLink trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebLink] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebLink trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<WebLink> _WebLinks)
		{
			foreach (WebLink item in _WebLinks)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
