using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MWEbreviews:IWEbreviews
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MWEbreviews(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable WebReviews từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebReviews]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable WebReviews từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebReviews] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách WebReviews từ Database
		/// </summary>
		public List<WebReviews> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebReviews]");
				List<WebReviews> items = new List<WebReviews>();
				WebReviews item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebReviews();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Title"] != null && dr["Title"] != DBNull.Value)
					{
						item.Title = Convert.ToString(dr["Title"]);
					}
					if (dr["ContentBody"] != null && dr["ContentBody"] != DBNull.Value)
					{
						item.ContentBody = Convert.ToString(dr["ContentBody"]);
					}
					if (dr["Description"] != null && dr["Description"] != DBNull.Value)
					{
						item.Description = Convert.ToString(dr["Description"]);
					}
					if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
					{
						item.ImagePath = Convert.ToString(dr["ImagePath"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_CreateBy"] != null && dr["FK_CreateBy"] != DBNull.Value)
					{
						item.FK_CreateBy = Convert.ToString(dr["FK_CreateBy"]);
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
		/// Lấy danh sách WebReviews từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<WebReviews> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebReviews] A "+ condition,  parameters);
				List<WebReviews> items = new List<WebReviews>();
				WebReviews item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebReviews();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Title"] != null && dr["Title"] != DBNull.Value)
					{
						item.Title = Convert.ToString(dr["Title"]);
					}
					if (dr["ContentBody"] != null && dr["ContentBody"] != DBNull.Value)
					{
						item.ContentBody = Convert.ToString(dr["ContentBody"]);
					}
					if (dr["Description"] != null && dr["Description"] != DBNull.Value)
					{
						item.Description = Convert.ToString(dr["Description"]);
					}
					if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
					{
						item.ImagePath = Convert.ToString(dr["ImagePath"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_CreateBy"] != null && dr["FK_CreateBy"] != DBNull.Value)
					{
						item.FK_CreateBy = Convert.ToString(dr["FK_CreateBy"]);
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

		public List<WebReviews> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebReviews] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[WebReviews] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<WebReviews>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một WebReviews từ Database
		/// </summary>
		public WebReviews GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebReviews] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					WebReviews item=new WebReviews();
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
						if (dr["ContentBody"] != null && dr["ContentBody"] != DBNull.Value)
						{
							item.ContentBody = Convert.ToString(dr["ContentBody"]);
						}
						if (dr["Description"] != null && dr["Description"] != DBNull.Value)
						{
							item.Description = Convert.ToString(dr["Description"]);
						}
						if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
						{
							item.ImagePath = Convert.ToString(dr["ImagePath"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["FK_CreateBy"] != null && dr["FK_CreateBy"] != DBNull.Value)
						{
							item.FK_CreateBy = Convert.ToString(dr["FK_CreateBy"]);
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
		/// Lấy một WebReviews đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public WebReviews GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebReviews] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					WebReviews item=new WebReviews();
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
						if (dr["ContentBody"] != null && dr["ContentBody"] != DBNull.Value)
						{
							item.ContentBody = Convert.ToString(dr["ContentBody"]);
						}
						if (dr["Description"] != null && dr["Description"] != DBNull.Value)
						{
							item.Description = Convert.ToString(dr["Description"]);
						}
						if (dr["ImagePath"] != null && dr["ImagePath"] != DBNull.Value)
						{
							item.ImagePath = Convert.ToString(dr["ImagePath"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["FK_CreateBy"] != null && dr["FK_CreateBy"] != DBNull.Value)
						{
							item.FK_CreateBy = Convert.ToString(dr["FK_CreateBy"]);
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

		public WebReviews GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebReviews] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<WebReviews>(ds);
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
		/// Thêm mới WebReviews vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, WebReviews _WebReviews)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[WebReviews](Id, Title, ContentBody, Description, ImagePath, CreateDate, FK_CreateBy, OrderNo, BranchCode) VALUES(@Id, @Title, @ContentBody, @Description, @ImagePath, @CreateDate, @FK_CreateBy, @OrderNo, @BranchCode)", 
					"@Id",  _WebReviews.Id, 
					"@Title",  _WebReviews.Title, 
					"@ContentBody",  _WebReviews.ContentBody, 
					"@Description",  _WebReviews.Description, 
					"@ImagePath",  _WebReviews.ImagePath, 
					"@CreateDate", this._dataContext.ConvertDateString( _WebReviews.CreateDate), 
					"@FK_CreateBy",  _WebReviews.FK_CreateBy, 
					"@OrderNo",  _WebReviews.OrderNo, 
					"@BranchCode",  _WebReviews.BranchCode);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng WebReviews vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<WebReviews> _WebReviewss)
		{
			foreach (WebReviews item in _WebReviewss)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebReviews vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, WebReviews _WebReviews, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebReviews] SET Id=@Id, Title=@Title, ContentBody=@ContentBody, Description=@Description, ImagePath=@ImagePath, CreateDate=@CreateDate, FK_CreateBy=@FK_CreateBy, OrderNo=@OrderNo, BranchCode=@BranchCode WHERE Id=@Id", 
					"@Id",  _WebReviews.Id, 
					"@Title",  _WebReviews.Title, 
					"@ContentBody",  _WebReviews.ContentBody, 
					"@Description",  _WebReviews.Description, 
					"@ImagePath",  _WebReviews.ImagePath, 
					"@CreateDate", this._dataContext.ConvertDateString( _WebReviews.CreateDate), 
					"@FK_CreateBy",  _WebReviews.FK_CreateBy, 
					"@OrderNo",  _WebReviews.OrderNo, 
					"@BranchCode",  _WebReviews.BranchCode, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật WebReviews vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, WebReviews _WebReviews)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebReviews] SET Title=@Title, ContentBody=@ContentBody, Description=@Description, ImagePath=@ImagePath, CreateDate=@CreateDate, FK_CreateBy=@FK_CreateBy, OrderNo=@OrderNo, BranchCode=@BranchCode WHERE Id=@Id", 
					"@Title",  _WebReviews.Title, 
					"@ContentBody",  _WebReviews.ContentBody, 
					"@Description",  _WebReviews.Description, 
					"@ImagePath",  _WebReviews.ImagePath, 
					"@CreateDate", this._dataContext.ConvertDateString( _WebReviews.CreateDate), 
					"@FK_CreateBy",  _WebReviews.FK_CreateBy, 
					"@OrderNo",  _WebReviews.OrderNo, 
					"@BranchCode",  _WebReviews.BranchCode, 
					"@Id", _WebReviews.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách WebReviews vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<WebReviews> _WebReviewss)
		{
			foreach (WebReviews item in _WebReviewss)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebReviews vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, WebReviews _WebReviews, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebReviews] SET Id=@Id, Title=@Title, ContentBody=@ContentBody, Description=@Description, ImagePath=@ImagePath, CreateDate=@CreateDate, FK_CreateBy=@FK_CreateBy, OrderNo=@OrderNo, BranchCode=@BranchCode "+ condition, 
					"@Id",  _WebReviews.Id, 
					"@Title",  _WebReviews.Title, 
					"@ContentBody",  _WebReviews.ContentBody, 
					"@Description",  _WebReviews.Description, 
					"@ImagePath",  _WebReviews.ImagePath, 
					"@CreateDate", this._dataContext.ConvertDateString( _WebReviews.CreateDate), 
					"@FK_CreateBy",  _WebReviews.FK_CreateBy, 
					"@OrderNo",  _WebReviews.OrderNo, 
					"@BranchCode",  _WebReviews.BranchCode);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa WebReviews trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebReviews] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebReviews trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, WebReviews _WebReviews)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebReviews] WHERE Id=@Id",
					"@Id", _WebReviews.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebReviews trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebReviews] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebReviews trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<WebReviews> _WebReviewss)
		{
			foreach (WebReviews item in _WebReviewss)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
