using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MWEbpage:IWEbpage
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MWEbpage(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable WebPage từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebPage]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable WebPage từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebPage] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách WebPage từ Database
		/// </summary>
		public List<WebPage> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebPage]");
				List<WebPage> items = new List<WebPage>();
				WebPage item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebPage();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Title"] != null && dr["Title"] != DBNull.Value)
					{
						item.Title = Convert.ToString(dr["Title"]);
					}
					if (dr["Tag"] != null && dr["Tag"] != DBNull.Value)
					{
						item.Tag = Convert.ToString(dr["Tag"]);
					}
					if (dr["StaticLink"] != null && dr["StaticLink"] != DBNull.Value)
					{
						item.StaticLink = Convert.ToString(dr["StaticLink"]);
					}
					if (dr["ShortDescription"] != null && dr["ShortDescription"] != DBNull.Value)
					{
						item.ShortDescription = Convert.ToString(dr["ShortDescription"]);
					}
					if (dr["ContentBody"] != null && dr["ContentBody"] != DBNull.Value)
					{
						item.ContentBody = Convert.ToString(dr["ContentBody"]);
					}
					if (dr["FK_Author"] != null && dr["FK_Author"] != DBNull.Value)
					{
						item.FK_Author = Convert.ToString(dr["FK_Author"]);
					}
					if (dr["FK_ParrentPage"] != null && dr["FK_ParrentPage"] != DBNull.Value)
					{
						item.FK_ParrentPage = Convert.ToString(dr["FK_ParrentPage"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
					{
						item.ImagePath = Convert.ToString(dr["ImagePath"]);
					}
					if (dr["ShowPage"] != null && dr["ShowPage"] != DBNull.Value)
					{
						item.ShowPage = Convert.ToInt32(dr["ShowPage"]);
					}
					if (dr["StatusPage"] != null && dr["StatusPage"] != DBNull.Value)
					{
						item.StatusPage = Convert.ToInt32(dr["StatusPage"]);
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
		/// Lấy danh sách WebPage từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<WebPage> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebPage] A "+ condition,  parameters);
				List<WebPage> items = new List<WebPage>();
				WebPage item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebPage();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Title"] != null && dr["Title"] != DBNull.Value)
					{
						item.Title = Convert.ToString(dr["Title"]);
					}
					if (dr["Tag"] != null && dr["Tag"] != DBNull.Value)
					{
						item.Tag = Convert.ToString(dr["Tag"]);
					}
					if (dr["StaticLink"] != null && dr["StaticLink"] != DBNull.Value)
					{
						item.StaticLink = Convert.ToString(dr["StaticLink"]);
					}
					if (dr["ShortDescription"] != null && dr["ShortDescription"] != DBNull.Value)
					{
						item.ShortDescription = Convert.ToString(dr["ShortDescription"]);
					}
					if (dr["ContentBody"] != null && dr["ContentBody"] != DBNull.Value)
					{
						item.ContentBody = Convert.ToString(dr["ContentBody"]);
					}
					if (dr["FK_Author"] != null && dr["FK_Author"] != DBNull.Value)
					{
						item.FK_Author = Convert.ToString(dr["FK_Author"]);
					}
					if (dr["FK_ParrentPage"] != null && dr["FK_ParrentPage"] != DBNull.Value)
					{
						item.FK_ParrentPage = Convert.ToString(dr["FK_ParrentPage"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
					{
						item.ImagePath = Convert.ToString(dr["ImagePath"]);
					}
					if (dr["ShowPage"] != null && dr["ShowPage"] != DBNull.Value)
					{
						item.ShowPage = Convert.ToInt32(dr["ShowPage"]);
					}
					if (dr["StatusPage"] != null && dr["StatusPage"] != DBNull.Value)
					{
						item.StatusPage = Convert.ToInt32(dr["StatusPage"]);
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

		public List<WebPage> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebPage] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[WebPage] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<WebPage>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một WebPage từ Database
		/// </summary>
		public WebPage GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebPage] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					WebPage item=new WebPage();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Title"] != null && dr["Title"] != DBNull.Value)
						{
							item.Title = Convert.ToString(dr["Title"]);
						}
						if (dr["Tag"] != null && dr["Tag"] != DBNull.Value)
						{
							item.Tag = Convert.ToString(dr["Tag"]);
						}
						if (dr["StaticLink"] != null && dr["StaticLink"] != DBNull.Value)
						{
							item.StaticLink = Convert.ToString(dr["StaticLink"]);
						}
						if (dr["ShortDescription"] != null && dr["ShortDescription"] != DBNull.Value)
						{
							item.ShortDescription = Convert.ToString(dr["ShortDescription"]);
						}
						if (dr["ContentBody"] != null && dr["ContentBody"] != DBNull.Value)
						{
							item.ContentBody = Convert.ToString(dr["ContentBody"]);
						}
						if (dr["FK_Author"] != null && dr["FK_Author"] != DBNull.Value)
						{
							item.FK_Author = Convert.ToString(dr["FK_Author"]);
						}
						if (dr["FK_ParrentPage"] != null && dr["FK_ParrentPage"] != DBNull.Value)
						{
							item.FK_ParrentPage = Convert.ToString(dr["FK_ParrentPage"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
						{
							item.ImagePath = Convert.ToString(dr["ImagePath"]);
						}
						if (dr["ShowPage"] != null && dr["ShowPage"] != DBNull.Value)
						{
							item.ShowPage = Convert.ToInt32(dr["ShowPage"]);
						}
						if (dr["StatusPage"] != null && dr["StatusPage"] != DBNull.Value)
						{
							item.StatusPage = Convert.ToInt32(dr["StatusPage"]);
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
		/// Lấy một WebPage đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public WebPage GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebPage] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					WebPage item=new WebPage();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Title"] != null && dr["Title"] != DBNull.Value)
						{
							item.Title = Convert.ToString(dr["Title"]);
						}
						if (dr["Tag"] != null && dr["Tag"] != DBNull.Value)
						{
							item.Tag = Convert.ToString(dr["Tag"]);
						}
						if (dr["StaticLink"] != null && dr["StaticLink"] != DBNull.Value)
						{
							item.StaticLink = Convert.ToString(dr["StaticLink"]);
						}
						if (dr["ShortDescription"] != null && dr["ShortDescription"] != DBNull.Value)
						{
							item.ShortDescription = Convert.ToString(dr["ShortDescription"]);
						}
						if (dr["ContentBody"] != null && dr["ContentBody"] != DBNull.Value)
						{
							item.ContentBody = Convert.ToString(dr["ContentBody"]);
						}
						if (dr["FK_Author"] != null && dr["FK_Author"] != DBNull.Value)
						{
							item.FK_Author = Convert.ToString(dr["FK_Author"]);
						}
						if (dr["FK_ParrentPage"] != null && dr["FK_ParrentPage"] != DBNull.Value)
						{
							item.FK_ParrentPage = Convert.ToString(dr["FK_ParrentPage"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
						{
							item.ImagePath = Convert.ToString(dr["ImagePath"]);
						}
						if (dr["ShowPage"] != null && dr["ShowPage"] != DBNull.Value)
						{
							item.ShowPage = Convert.ToInt32(dr["ShowPage"]);
						}
						if (dr["StatusPage"] != null && dr["StatusPage"] != DBNull.Value)
						{
							item.StatusPage = Convert.ToInt32(dr["StatusPage"]);
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

		public WebPage GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebPage] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<WebPage>(ds);
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
		/// Thêm mới WebPage vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, WebPage _WebPage)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[WebPage](Id, Title, Tag, StaticLink, ShortDescription, ContentBody, FK_Author, FK_ParrentPage, CreateDate, ImagePath, ShowPage, StatusPage, BranchCode) VALUES(@Id, @Title, @Tag, @StaticLink, @ShortDescription, @ContentBody, @FK_Author, @FK_ParrentPage, @CreateDate, @ImagePath, @ShowPage, @StatusPage, @BranchCode)", 
					"@Id",  _WebPage.Id, 
					"@Title",  _WebPage.Title, 
					"@Tag",  _WebPage.Tag, 
					"@StaticLink",  _WebPage.StaticLink, 
					"@ShortDescription",  _WebPage.ShortDescription, 
					"@ContentBody",  _WebPage.ContentBody, 
					"@FK_Author",  _WebPage.FK_Author, 
					"@FK_ParrentPage",  _WebPage.FK_ParrentPage, 
					"@CreateDate", this._dataContext.ConvertDateString( _WebPage.CreateDate), 
					"@ImagePath",  _WebPage.ImagePath, 
					"@ShowPage",  _WebPage.ShowPage, 
					"@StatusPage",  _WebPage.StatusPage, 
					"@BranchCode",  _WebPage.BranchCode);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng WebPage vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<WebPage> _WebPages)
		{
			foreach (WebPage item in _WebPages)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebPage vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, WebPage _WebPage, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebPage] SET Id=@Id, Title=@Title, Tag=@Tag, StaticLink=@StaticLink, ShortDescription=@ShortDescription, ContentBody=@ContentBody, FK_Author=@FK_Author, FK_ParrentPage=@FK_ParrentPage, CreateDate=@CreateDate, ImagePath=@ImagePath, ShowPage=@ShowPage, StatusPage=@StatusPage, BranchCode=@BranchCode WHERE Id=@Id", 
					"@Id",  _WebPage.Id, 
					"@Title",  _WebPage.Title, 
					"@Tag",  _WebPage.Tag, 
					"@StaticLink",  _WebPage.StaticLink, 
					"@ShortDescription",  _WebPage.ShortDescription, 
					"@ContentBody",  _WebPage.ContentBody, 
					"@FK_Author",  _WebPage.FK_Author, 
					"@FK_ParrentPage",  _WebPage.FK_ParrentPage, 
					"@CreateDate", this._dataContext.ConvertDateString( _WebPage.CreateDate), 
					"@ImagePath",  _WebPage.ImagePath, 
					"@ShowPage",  _WebPage.ShowPage, 
					"@StatusPage",  _WebPage.StatusPage, 
					"@BranchCode",  _WebPage.BranchCode, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật WebPage vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, WebPage _WebPage)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebPage] SET Title=@Title, Tag=@Tag, StaticLink=@StaticLink, ShortDescription=@ShortDescription, ContentBody=@ContentBody, FK_Author=@FK_Author, FK_ParrentPage=@FK_ParrentPage, CreateDate=@CreateDate, ImagePath=@ImagePath, ShowPage=@ShowPage, StatusPage=@StatusPage, BranchCode=@BranchCode WHERE Id=@Id", 
					"@Title",  _WebPage.Title, 
					"@Tag",  _WebPage.Tag, 
					"@StaticLink",  _WebPage.StaticLink, 
					"@ShortDescription",  _WebPage.ShortDescription, 
					"@ContentBody",  _WebPage.ContentBody, 
					"@FK_Author",  _WebPage.FK_Author, 
					"@FK_ParrentPage",  _WebPage.FK_ParrentPage, 
					"@CreateDate", this._dataContext.ConvertDateString( _WebPage.CreateDate), 
					"@ImagePath",  _WebPage.ImagePath, 
					"@ShowPage",  _WebPage.ShowPage, 
					"@StatusPage",  _WebPage.StatusPage, 
					"@BranchCode",  _WebPage.BranchCode, 
					"@Id", _WebPage.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách WebPage vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<WebPage> _WebPages)
		{
			foreach (WebPage item in _WebPages)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebPage vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, WebPage _WebPage, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebPage] SET Id=@Id, Title=@Title, Tag=@Tag, StaticLink=@StaticLink, ShortDescription=@ShortDescription, ContentBody=@ContentBody, FK_Author=@FK_Author, FK_ParrentPage=@FK_ParrentPage, CreateDate=@CreateDate, ImagePath=@ImagePath, ShowPage=@ShowPage, StatusPage=@StatusPage, BranchCode=@BranchCode "+ condition, 
					"@Id",  _WebPage.Id, 
					"@Title",  _WebPage.Title, 
					"@Tag",  _WebPage.Tag, 
					"@StaticLink",  _WebPage.StaticLink, 
					"@ShortDescription",  _WebPage.ShortDescription, 
					"@ContentBody",  _WebPage.ContentBody, 
					"@FK_Author",  _WebPage.FK_Author, 
					"@FK_ParrentPage",  _WebPage.FK_ParrentPage, 
					"@CreateDate", this._dataContext.ConvertDateString( _WebPage.CreateDate), 
					"@ImagePath",  _WebPage.ImagePath, 
					"@ShowPage",  _WebPage.ShowPage, 
					"@StatusPage",  _WebPage.StatusPage, 
					"@BranchCode",  _WebPage.BranchCode);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa WebPage trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebPage] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebPage trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, WebPage _WebPage)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebPage] WHERE Id=@Id",
					"@Id", _WebPage.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebPage trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebPage] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebPage trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<WebPage> _WebPages)
		{
			foreach (WebPage item in _WebPages)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
