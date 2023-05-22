using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MWEbnews:IWEbnews
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MWEbnews(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable WebNews từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebNews]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable WebNews từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebNews] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách WebNews từ Database
		/// </summary>
		public List<WebNews> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebNews]");
				List<WebNews> items = new List<WebNews>();
				WebNews item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebNews();
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
					if (dr["FK_Category"] != null && dr["FK_Category"] != DBNull.Value)
					{
						item.FK_Category = Convert.ToString(dr["FK_Category"]);
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
					if (dr["OrderNo"] != null && dr["OrderNo"] != DBNull.Value)
					{
						item.OrderNo = Convert.ToInt32(dr["OrderNo"]);
					}
					if (dr["ViewCount"] != null && dr["ViewCount"] != DBNull.Value)
					{
						item.ViewCount = Convert.ToInt32(dr["ViewCount"]);
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
		/// Lấy danh sách WebNews từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<WebNews> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebNews] A "+ condition,  parameters);
				List<WebNews> items = new List<WebNews>();
				WebNews item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebNews();
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
					if (dr["FK_Category"] != null && dr["FK_Category"] != DBNull.Value)
					{
						item.FK_Category = Convert.ToString(dr["FK_Category"]);
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
					if (dr["OrderNo"] != null && dr["OrderNo"] != DBNull.Value)
					{
						item.OrderNo = Convert.ToInt32(dr["OrderNo"]);
					}
					if (dr["ViewCount"] != null && dr["ViewCount"] != DBNull.Value)
					{
						item.ViewCount = Convert.ToInt32(dr["ViewCount"]);
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

		public List<WebNews> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebNews] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[WebNews] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<WebNews>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một WebNews từ Database
		/// </summary>
		public WebNews GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebNews] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					WebNews item=new WebNews();
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
						if (dr["FK_Category"] != null && dr["FK_Category"] != DBNull.Value)
						{
							item.FK_Category = Convert.ToString(dr["FK_Category"]);
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
						if (dr["OrderNo"] != null && dr["OrderNo"] != DBNull.Value)
						{
							item.OrderNo = Convert.ToInt32(dr["OrderNo"]);
						}
						if (dr["ViewCount"] != null && dr["ViewCount"] != DBNull.Value)
						{
							item.ViewCount = Convert.ToInt32(dr["ViewCount"]);
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
		/// Lấy một WebNews đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public WebNews GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebNews] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					WebNews item=new WebNews();
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
						if (dr["FK_Category"] != null && dr["FK_Category"] != DBNull.Value)
						{
							item.FK_Category = Convert.ToString(dr["FK_Category"]);
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
						if (dr["OrderNo"] != null && dr["OrderNo"] != DBNull.Value)
						{
							item.OrderNo = Convert.ToInt32(dr["OrderNo"]);
						}
						if (dr["ViewCount"] != null && dr["ViewCount"] != DBNull.Value)
						{
							item.ViewCount = Convert.ToInt32(dr["ViewCount"]);
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

		public WebNews GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebNews] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<WebNews>(ds);
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
		/// Thêm mới WebNews vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, WebNews _WebNews)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[WebNews](Id, Title, Tag, StaticLink, ShortDescription, ContentBody, FK_Author, FK_Category, CreateDate, ImagePath, ShowPage, StatusPage, OrderNo, ViewCount, BranchCode) VALUES(@Id, @Title, @Tag, @StaticLink, @ShortDescription, @ContentBody, @FK_Author, @FK_Category, @CreateDate, @ImagePath, @ShowPage, @StatusPage, @OrderNo, @ViewCount, @BranchCode)", 
					"@Id",  _WebNews.Id, 
					"@Title",  _WebNews.Title, 
					"@Tag",  _WebNews.Tag, 
					"@StaticLink",  _WebNews.StaticLink, 
					"@ShortDescription",  _WebNews.ShortDescription, 
					"@ContentBody",  _WebNews.ContentBody, 
					"@FK_Author",  _WebNews.FK_Author, 
					"@FK_Category",  _WebNews.FK_Category, 
					"@CreateDate", this._dataContext.ConvertDateString( _WebNews.CreateDate), 
					"@ImagePath",  _WebNews.ImagePath, 
					"@ShowPage",  _WebNews.ShowPage, 
					"@StatusPage",  _WebNews.StatusPage, 
					"@OrderNo",  _WebNews.OrderNo, 
					"@ViewCount",  _WebNews.ViewCount, 
					"@BranchCode",  _WebNews.BranchCode);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng WebNews vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<WebNews> _WebNewss)
		{
			foreach (WebNews item in _WebNewss)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebNews vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, WebNews _WebNews, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebNews] SET Id=@Id, Title=@Title, Tag=@Tag, StaticLink=@StaticLink, ShortDescription=@ShortDescription, ContentBody=@ContentBody, FK_Author=@FK_Author, FK_Category=@FK_Category, CreateDate=@CreateDate, ImagePath=@ImagePath, ShowPage=@ShowPage, StatusPage=@StatusPage, OrderNo=@OrderNo, ViewCount=@ViewCount, BranchCode=@BranchCode WHERE Id=@Id", 
					"@Id",  _WebNews.Id, 
					"@Title",  _WebNews.Title, 
					"@Tag",  _WebNews.Tag, 
					"@StaticLink",  _WebNews.StaticLink, 
					"@ShortDescription",  _WebNews.ShortDescription, 
					"@ContentBody",  _WebNews.ContentBody, 
					"@FK_Author",  _WebNews.FK_Author, 
					"@FK_Category",  _WebNews.FK_Category, 
					"@CreateDate", this._dataContext.ConvertDateString( _WebNews.CreateDate), 
					"@ImagePath",  _WebNews.ImagePath, 
					"@ShowPage",  _WebNews.ShowPage, 
					"@StatusPage",  _WebNews.StatusPage, 
					"@OrderNo",  _WebNews.OrderNo, 
					"@ViewCount",  _WebNews.ViewCount, 
					"@BranchCode",  _WebNews.BranchCode, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật WebNews vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, WebNews _WebNews)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebNews] SET Title=@Title, Tag=@Tag, StaticLink=@StaticLink, ShortDescription=@ShortDescription, ContentBody=@ContentBody, FK_Author=@FK_Author, FK_Category=@FK_Category, CreateDate=@CreateDate, ImagePath=@ImagePath, ShowPage=@ShowPage, StatusPage=@StatusPage, OrderNo=@OrderNo, ViewCount=@ViewCount, BranchCode=@BranchCode WHERE Id=@Id", 
					"@Title",  _WebNews.Title, 
					"@Tag",  _WebNews.Tag, 
					"@StaticLink",  _WebNews.StaticLink, 
					"@ShortDescription",  _WebNews.ShortDescription, 
					"@ContentBody",  _WebNews.ContentBody, 
					"@FK_Author",  _WebNews.FK_Author, 
					"@FK_Category",  _WebNews.FK_Category, 
					"@CreateDate", this._dataContext.ConvertDateString( _WebNews.CreateDate), 
					"@ImagePath",  _WebNews.ImagePath, 
					"@ShowPage",  _WebNews.ShowPage, 
					"@StatusPage",  _WebNews.StatusPage, 
					"@OrderNo",  _WebNews.OrderNo, 
					"@ViewCount",  _WebNews.ViewCount, 
					"@BranchCode",  _WebNews.BranchCode, 
					"@Id", _WebNews.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách WebNews vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<WebNews> _WebNewss)
		{
			foreach (WebNews item in _WebNewss)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebNews vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, WebNews _WebNews, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebNews] SET Id=@Id, Title=@Title, Tag=@Tag, StaticLink=@StaticLink, ShortDescription=@ShortDescription, ContentBody=@ContentBody, FK_Author=@FK_Author, FK_Category=@FK_Category, CreateDate=@CreateDate, ImagePath=@ImagePath, ShowPage=@ShowPage, StatusPage=@StatusPage, OrderNo=@OrderNo, ViewCount=@ViewCount, BranchCode=@BranchCode "+ condition, 
					"@Id",  _WebNews.Id, 
					"@Title",  _WebNews.Title, 
					"@Tag",  _WebNews.Tag, 
					"@StaticLink",  _WebNews.StaticLink, 
					"@ShortDescription",  _WebNews.ShortDescription, 
					"@ContentBody",  _WebNews.ContentBody, 
					"@FK_Author",  _WebNews.FK_Author, 
					"@FK_Category",  _WebNews.FK_Category, 
					"@CreateDate", this._dataContext.ConvertDateString( _WebNews.CreateDate), 
					"@ImagePath",  _WebNews.ImagePath, 
					"@ShowPage",  _WebNews.ShowPage, 
					"@StatusPage",  _WebNews.StatusPage, 
					"@OrderNo",  _WebNews.OrderNo, 
					"@ViewCount",  _WebNews.ViewCount, 
					"@BranchCode",  _WebNews.BranchCode);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa WebNews trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebNews] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebNews trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, WebNews _WebNews)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebNews] WHERE Id=@Id",
					"@Id", _WebNews.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebNews trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebNews] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebNews trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<WebNews> _WebNewss)
		{
			foreach (WebNews item in _WebNewss)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
