using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MTAskissue:ITAskissue
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MTAskissue(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable TaskIssue từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[TaskIssue]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable TaskIssue từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[TaskIssue] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách TaskIssue từ Database
		/// </summary>
		public List<TaskIssue> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[TaskIssue]");
				List<TaskIssue> items = new List<TaskIssue>();
				TaskIssue item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new TaskIssue();
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
					if (dr["FK_Status"] != null && dr["FK_Status"] != DBNull.Value)
					{
						item.FK_Status = Convert.ToInt32(dr["FK_Status"]);
					}
					if (dr["FK_Tracker"] != null && dr["FK_Tracker"] != DBNull.Value)
					{
						item.FK_Tracker = Convert.ToInt32(dr["FK_Tracker"]);
					}
					if (dr["FK_Priority"] != null && dr["FK_Priority"] != DBNull.Value)
					{
						item.FK_Priority = Convert.ToInt32(dr["FK_Priority"]);
					}
					if (dr["FK_Assignee"] != null && dr["FK_Assignee"] != DBNull.Value)
					{
						item.FK_Assignee = Convert.ToString(dr["FK_Assignee"]);
					}
					if (dr["StartDate"] != null && dr["StartDate"] != DBNull.Value)
					{
						item.StartDate = Convert.ToDateTime(dr["StartDate"]);
					}
					if (dr["EndDate"] != null && dr["EndDate"] != DBNull.Value)
					{
						item.EndDate = Convert.ToDateTime(dr["EndDate"]);
					}
					if (dr["PercentComplete"] != null && dr["PercentComplete"] != DBNull.Value)
					{
						item.PercentComplete = Convert.ToInt32(dr["PercentComplete"]);
					}
					if (dr["FileAttach"] != null && dr["FileAttach"] != DBNull.Value)
					{
						item.FileAttach = Convert.ToString(dr["FileAttach"]);
					}
					if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
					{
						item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
					}
					if (dr["IsPrivate"] != null && dr["IsPrivate"] != DBNull.Value)
					{
						item.IsPrivate = Convert.ToBoolean(dr["IsPrivate"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
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
		/// Lấy danh sách TaskIssue từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<TaskIssue> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[TaskIssue] A "+ condition,  parameters);
				List<TaskIssue> items = new List<TaskIssue>();
				TaskIssue item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new TaskIssue();
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
					if (dr["FK_Status"] != null && dr["FK_Status"] != DBNull.Value)
					{
						item.FK_Status = Convert.ToInt32(dr["FK_Status"]);
					}
					if (dr["FK_Tracker"] != null && dr["FK_Tracker"] != DBNull.Value)
					{
						item.FK_Tracker = Convert.ToInt32(dr["FK_Tracker"]);
					}
					if (dr["FK_Priority"] != null && dr["FK_Priority"] != DBNull.Value)
					{
						item.FK_Priority = Convert.ToInt32(dr["FK_Priority"]);
					}
					if (dr["FK_Assignee"] != null && dr["FK_Assignee"] != DBNull.Value)
					{
						item.FK_Assignee = Convert.ToString(dr["FK_Assignee"]);
					}
					if (dr["StartDate"] != null && dr["StartDate"] != DBNull.Value)
					{
						item.StartDate = Convert.ToDateTime(dr["StartDate"]);
					}
					if (dr["EndDate"] != null && dr["EndDate"] != DBNull.Value)
					{
						item.EndDate = Convert.ToDateTime(dr["EndDate"]);
					}
					if (dr["PercentComplete"] != null && dr["PercentComplete"] != DBNull.Value)
					{
						item.PercentComplete = Convert.ToInt32(dr["PercentComplete"]);
					}
					if (dr["FileAttach"] != null && dr["FileAttach"] != DBNull.Value)
					{
						item.FileAttach = Convert.ToString(dr["FileAttach"]);
					}
					if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
					{
						item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
					}
					if (dr["IsPrivate"] != null && dr["IsPrivate"] != DBNull.Value)
					{
						item.IsPrivate = Convert.ToBoolean(dr["IsPrivate"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
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

		public List<TaskIssue> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[TaskIssue] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[TaskIssue] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<TaskIssue>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một TaskIssue từ Database
		/// </summary>
		public TaskIssue GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[TaskIssue] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					TaskIssue item=new TaskIssue();
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
						if (dr["FK_Status"] != null && dr["FK_Status"] != DBNull.Value)
						{
							item.FK_Status = Convert.ToInt32(dr["FK_Status"]);
						}
						if (dr["FK_Tracker"] != null && dr["FK_Tracker"] != DBNull.Value)
						{
							item.FK_Tracker = Convert.ToInt32(dr["FK_Tracker"]);
						}
						if (dr["FK_Priority"] != null && dr["FK_Priority"] != DBNull.Value)
						{
							item.FK_Priority = Convert.ToInt32(dr["FK_Priority"]);
						}
						if (dr["FK_Assignee"] != null && dr["FK_Assignee"] != DBNull.Value)
						{
							item.FK_Assignee = Convert.ToString(dr["FK_Assignee"]);
						}
						if (dr["StartDate"] != null && dr["StartDate"] != DBNull.Value)
						{
							item.StartDate = Convert.ToDateTime(dr["StartDate"]);
						}
						if (dr["EndDate"] != null && dr["EndDate"] != DBNull.Value)
						{
							item.EndDate = Convert.ToDateTime(dr["EndDate"]);
						}
						if (dr["PercentComplete"] != null && dr["PercentComplete"] != DBNull.Value)
						{
							item.PercentComplete = Convert.ToInt32(dr["PercentComplete"]);
						}
						if (dr["FileAttach"] != null && dr["FileAttach"] != DBNull.Value)
						{
							item.FileAttach = Convert.ToString(dr["FileAttach"]);
						}
						if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
						{
							item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
						}
						if (dr["IsPrivate"] != null && dr["IsPrivate"] != DBNull.Value)
						{
							item.IsPrivate = Convert.ToBoolean(dr["IsPrivate"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
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
		/// Lấy một TaskIssue đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public TaskIssue GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[TaskIssue] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					TaskIssue item=new TaskIssue();
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
						if (dr["FK_Status"] != null && dr["FK_Status"] != DBNull.Value)
						{
							item.FK_Status = Convert.ToInt32(dr["FK_Status"]);
						}
						if (dr["FK_Tracker"] != null && dr["FK_Tracker"] != DBNull.Value)
						{
							item.FK_Tracker = Convert.ToInt32(dr["FK_Tracker"]);
						}
						if (dr["FK_Priority"] != null && dr["FK_Priority"] != DBNull.Value)
						{
							item.FK_Priority = Convert.ToInt32(dr["FK_Priority"]);
						}
						if (dr["FK_Assignee"] != null && dr["FK_Assignee"] != DBNull.Value)
						{
							item.FK_Assignee = Convert.ToString(dr["FK_Assignee"]);
						}
						if (dr["StartDate"] != null && dr["StartDate"] != DBNull.Value)
						{
							item.StartDate = Convert.ToDateTime(dr["StartDate"]);
						}
						if (dr["EndDate"] != null && dr["EndDate"] != DBNull.Value)
						{
							item.EndDate = Convert.ToDateTime(dr["EndDate"]);
						}
						if (dr["PercentComplete"] != null && dr["PercentComplete"] != DBNull.Value)
						{
							item.PercentComplete = Convert.ToInt32(dr["PercentComplete"]);
						}
						if (dr["FileAttach"] != null && dr["FileAttach"] != DBNull.Value)
						{
							item.FileAttach = Convert.ToString(dr["FileAttach"]);
						}
						if (dr["FK_Branch"] != null && dr["FK_Branch"] != DBNull.Value)
						{
							item.FK_Branch = Convert.ToString(dr["FK_Branch"]);
						}
						if (dr["IsPrivate"] != null && dr["IsPrivate"] != DBNull.Value)
						{
							item.IsPrivate = Convert.ToBoolean(dr["IsPrivate"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
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

		public TaskIssue GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[TaskIssue] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<TaskIssue>(ds);
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
		/// Thêm mới TaskIssue vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, TaskIssue _TaskIssue)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[TaskIssue](Id, Title, ContentBody, FK_Status, FK_Tracker, FK_Priority, FK_Assignee, StartDate, EndDate, PercentComplete, FileAttach, FK_Branch, IsPrivate, CreateDate, CreateBy) VALUES(@Id, @Title, @ContentBody, @FK_Status, @FK_Tracker, @FK_Priority, @FK_Assignee, @StartDate, @EndDate, @PercentComplete, @FileAttach, @FK_Branch, @IsPrivate, @CreateDate, @CreateBy)", 
					"@Id",  _TaskIssue.Id, 
					"@Title",  _TaskIssue.Title, 
					"@ContentBody",  _TaskIssue.ContentBody, 
					"@FK_Status",  _TaskIssue.FK_Status, 
					"@FK_Tracker",  _TaskIssue.FK_Tracker, 
					"@FK_Priority",  _TaskIssue.FK_Priority, 
					"@FK_Assignee",  _TaskIssue.FK_Assignee, 
					"@StartDate", this._dataContext.ConvertDateString( _TaskIssue.StartDate), 
					"@EndDate", this._dataContext.ConvertDateString( _TaskIssue.EndDate), 
					"@PercentComplete",  _TaskIssue.PercentComplete, 
					"@FileAttach",  _TaskIssue.FileAttach, 
					"@FK_Branch",  _TaskIssue.FK_Branch, 
					"@IsPrivate",  _TaskIssue.IsPrivate, 
					"@CreateDate", this._dataContext.ConvertDateString( _TaskIssue.CreateDate), 
					"@CreateBy",  _TaskIssue.CreateBy);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng TaskIssue vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<TaskIssue> _TaskIssues)
		{
			foreach (TaskIssue item in _TaskIssues)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật TaskIssue vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, TaskIssue _TaskIssue, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[TaskIssue] SET Id=@Id, Title=@Title, ContentBody=@ContentBody, FK_Status=@FK_Status, FK_Tracker=@FK_Tracker, FK_Priority=@FK_Priority, FK_Assignee=@FK_Assignee, StartDate=@StartDate, EndDate=@EndDate, PercentComplete=@PercentComplete, FileAttach=@FileAttach, FK_Branch=@FK_Branch, IsPrivate=@IsPrivate, CreateDate=@CreateDate, CreateBy=@CreateBy WHERE Id=@Id", 
					"@Id",  _TaskIssue.Id, 
					"@Title",  _TaskIssue.Title, 
					"@ContentBody",  _TaskIssue.ContentBody, 
					"@FK_Status",  _TaskIssue.FK_Status, 
					"@FK_Tracker",  _TaskIssue.FK_Tracker, 
					"@FK_Priority",  _TaskIssue.FK_Priority, 
					"@FK_Assignee",  _TaskIssue.FK_Assignee, 
					"@StartDate", this._dataContext.ConvertDateString( _TaskIssue.StartDate), 
					"@EndDate", this._dataContext.ConvertDateString( _TaskIssue.EndDate), 
					"@PercentComplete",  _TaskIssue.PercentComplete, 
					"@FileAttach",  _TaskIssue.FileAttach, 
					"@FK_Branch",  _TaskIssue.FK_Branch, 
					"@IsPrivate",  _TaskIssue.IsPrivate, 
					"@CreateDate", this._dataContext.ConvertDateString( _TaskIssue.CreateDate), 
					"@CreateBy",  _TaskIssue.CreateBy, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật TaskIssue vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, TaskIssue _TaskIssue)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[TaskIssue] SET Title=@Title, ContentBody=@ContentBody, FK_Status=@FK_Status, FK_Tracker=@FK_Tracker, FK_Priority=@FK_Priority, FK_Assignee=@FK_Assignee, StartDate=@StartDate, EndDate=@EndDate, PercentComplete=@PercentComplete, FileAttach=@FileAttach, FK_Branch=@FK_Branch, IsPrivate=@IsPrivate, CreateDate=@CreateDate, CreateBy=@CreateBy WHERE Id=@Id", 
					"@Title",  _TaskIssue.Title, 
					"@ContentBody",  _TaskIssue.ContentBody, 
					"@FK_Status",  _TaskIssue.FK_Status, 
					"@FK_Tracker",  _TaskIssue.FK_Tracker, 
					"@FK_Priority",  _TaskIssue.FK_Priority, 
					"@FK_Assignee",  _TaskIssue.FK_Assignee, 
					"@StartDate", this._dataContext.ConvertDateString( _TaskIssue.StartDate), 
					"@EndDate", this._dataContext.ConvertDateString( _TaskIssue.EndDate), 
					"@PercentComplete",  _TaskIssue.PercentComplete, 
					"@FileAttach",  _TaskIssue.FileAttach, 
					"@FK_Branch",  _TaskIssue.FK_Branch, 
					"@IsPrivate",  _TaskIssue.IsPrivate, 
					"@CreateDate", this._dataContext.ConvertDateString( _TaskIssue.CreateDate), 
					"@CreateBy",  _TaskIssue.CreateBy, 
					"@Id", _TaskIssue.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách TaskIssue vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<TaskIssue> _TaskIssues)
		{
			foreach (TaskIssue item in _TaskIssues)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật TaskIssue vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, TaskIssue _TaskIssue, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[TaskIssue] SET Id=@Id, Title=@Title, ContentBody=@ContentBody, FK_Status=@FK_Status, FK_Tracker=@FK_Tracker, FK_Priority=@FK_Priority, FK_Assignee=@FK_Assignee, StartDate=@StartDate, EndDate=@EndDate, PercentComplete=@PercentComplete, FileAttach=@FileAttach, FK_Branch=@FK_Branch, IsPrivate=@IsPrivate, CreateDate=@CreateDate, CreateBy=@CreateBy "+ condition, 
					"@Id",  _TaskIssue.Id, 
					"@Title",  _TaskIssue.Title, 
					"@ContentBody",  _TaskIssue.ContentBody, 
					"@FK_Status",  _TaskIssue.FK_Status, 
					"@FK_Tracker",  _TaskIssue.FK_Tracker, 
					"@FK_Priority",  _TaskIssue.FK_Priority, 
					"@FK_Assignee",  _TaskIssue.FK_Assignee, 
					"@StartDate", this._dataContext.ConvertDateString( _TaskIssue.StartDate), 
					"@EndDate", this._dataContext.ConvertDateString( _TaskIssue.EndDate), 
					"@PercentComplete",  _TaskIssue.PercentComplete, 
					"@FileAttach",  _TaskIssue.FileAttach, 
					"@FK_Branch",  _TaskIssue.FK_Branch, 
					"@IsPrivate",  _TaskIssue.IsPrivate, 
					"@CreateDate", this._dataContext.ConvertDateString( _TaskIssue.CreateDate), 
					"@CreateBy",  _TaskIssue.CreateBy);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa TaskIssue trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[TaskIssue] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa TaskIssue trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, TaskIssue _TaskIssue)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[TaskIssue] WHERE Id=@Id",
					"@Id", _TaskIssue.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa TaskIssue trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[TaskIssue] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa TaskIssue trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<TaskIssue> _TaskIssues)
		{
			foreach (TaskIssue item in _TaskIssues)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
