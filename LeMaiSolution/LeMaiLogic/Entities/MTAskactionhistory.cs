using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MTAskactionhistory:ITAskactionhistory
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MTAskactionhistory(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable TaskActionHistory từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[TaskActionHistory]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable TaskActionHistory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[TaskActionHistory] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách TaskActionHistory từ Database
		/// </summary>
		public List<TaskActionHistory> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[TaskActionHistory]");
				List<TaskActionHistory> items = new List<TaskActionHistory>();
				TaskActionHistory item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new TaskActionHistory();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["ActionDate"] != null && dr["ActionDate"] != DBNull.Value)
					{
						item.ActionDate = Convert.ToDateTime(dr["ActionDate"]);
					}
					if (dr["ContentAction"] != null && dr["ContentAction"] != DBNull.Value)
					{
						item.ContentAction = Convert.ToString(dr["ContentAction"]);
					}
					if (dr["FK_AcctionBy"] != null && dr["FK_AcctionBy"] != DBNull.Value)
					{
						item.FK_AcctionBy = Convert.ToString(dr["FK_AcctionBy"]);
					}
					if (dr["FK_TaskIssue"] != null && dr["FK_TaskIssue"] != DBNull.Value)
					{
						item.FK_TaskIssue = Convert.ToString(dr["FK_TaskIssue"]);
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
		/// Lấy danh sách TaskActionHistory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<TaskActionHistory> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[TaskActionHistory] A "+ condition,  parameters);
				List<TaskActionHistory> items = new List<TaskActionHistory>();
				TaskActionHistory item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new TaskActionHistory();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["ActionDate"] != null && dr["ActionDate"] != DBNull.Value)
					{
						item.ActionDate = Convert.ToDateTime(dr["ActionDate"]);
					}
					if (dr["ContentAction"] != null && dr["ContentAction"] != DBNull.Value)
					{
						item.ContentAction = Convert.ToString(dr["ContentAction"]);
					}
					if (dr["FK_AcctionBy"] != null && dr["FK_AcctionBy"] != DBNull.Value)
					{
						item.FK_AcctionBy = Convert.ToString(dr["FK_AcctionBy"]);
					}
					if (dr["FK_TaskIssue"] != null && dr["FK_TaskIssue"] != DBNull.Value)
					{
						item.FK_TaskIssue = Convert.ToString(dr["FK_TaskIssue"]);
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

		public List<TaskActionHistory> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[TaskActionHistory] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[TaskActionHistory] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<TaskActionHistory>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một TaskActionHistory từ Database
		/// </summary>
		public TaskActionHistory GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[TaskActionHistory] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					TaskActionHistory item=new TaskActionHistory();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["ActionDate"] != null && dr["ActionDate"] != DBNull.Value)
						{
							item.ActionDate = Convert.ToDateTime(dr["ActionDate"]);
						}
						if (dr["ContentAction"] != null && dr["ContentAction"] != DBNull.Value)
						{
							item.ContentAction = Convert.ToString(dr["ContentAction"]);
						}
						if (dr["FK_AcctionBy"] != null && dr["FK_AcctionBy"] != DBNull.Value)
						{
							item.FK_AcctionBy = Convert.ToString(dr["FK_AcctionBy"]);
						}
						if (dr["FK_TaskIssue"] != null && dr["FK_TaskIssue"] != DBNull.Value)
						{
							item.FK_TaskIssue = Convert.ToString(dr["FK_TaskIssue"]);
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
		/// Lấy một TaskActionHistory đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public TaskActionHistory GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[TaskActionHistory] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					TaskActionHistory item=new TaskActionHistory();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["ActionDate"] != null && dr["ActionDate"] != DBNull.Value)
						{
							item.ActionDate = Convert.ToDateTime(dr["ActionDate"]);
						}
						if (dr["ContentAction"] != null && dr["ContentAction"] != DBNull.Value)
						{
							item.ContentAction = Convert.ToString(dr["ContentAction"]);
						}
						if (dr["FK_AcctionBy"] != null && dr["FK_AcctionBy"] != DBNull.Value)
						{
							item.FK_AcctionBy = Convert.ToString(dr["FK_AcctionBy"]);
						}
						if (dr["FK_TaskIssue"] != null && dr["FK_TaskIssue"] != DBNull.Value)
						{
							item.FK_TaskIssue = Convert.ToString(dr["FK_TaskIssue"]);
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

		public TaskActionHistory GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[TaskActionHistory] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<TaskActionHistory>(ds);
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
		/// Thêm mới TaskActionHistory vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, TaskActionHistory _TaskActionHistory)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[TaskActionHistory](Id, ActionDate, ContentAction, FK_AcctionBy, FK_TaskIssue) VALUES(@Id, @ActionDate, @ContentAction, @FK_AcctionBy, @FK_TaskIssue)", 
					"@Id",  _TaskActionHistory.Id, 
					"@ActionDate", this._dataContext.ConvertDateString( _TaskActionHistory.ActionDate), 
					"@ContentAction",  _TaskActionHistory.ContentAction, 
					"@FK_AcctionBy",  _TaskActionHistory.FK_AcctionBy, 
					"@FK_TaskIssue",  _TaskActionHistory.FK_TaskIssue);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng TaskActionHistory vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<TaskActionHistory> _TaskActionHistorys)
		{
			foreach (TaskActionHistory item in _TaskActionHistorys)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật TaskActionHistory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, TaskActionHistory _TaskActionHistory, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[TaskActionHistory] SET Id=@Id, ActionDate=@ActionDate, ContentAction=@ContentAction, FK_AcctionBy=@FK_AcctionBy, FK_TaskIssue=@FK_TaskIssue WHERE Id=@Id", 
					"@Id",  _TaskActionHistory.Id, 
					"@ActionDate", this._dataContext.ConvertDateString( _TaskActionHistory.ActionDate), 
					"@ContentAction",  _TaskActionHistory.ContentAction, 
					"@FK_AcctionBy",  _TaskActionHistory.FK_AcctionBy, 
					"@FK_TaskIssue",  _TaskActionHistory.FK_TaskIssue, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật TaskActionHistory vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, TaskActionHistory _TaskActionHistory)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[TaskActionHistory] SET ActionDate=@ActionDate, ContentAction=@ContentAction, FK_AcctionBy=@FK_AcctionBy, FK_TaskIssue=@FK_TaskIssue WHERE Id=@Id", 
					"@ActionDate", this._dataContext.ConvertDateString( _TaskActionHistory.ActionDate), 
					"@ContentAction",  _TaskActionHistory.ContentAction, 
					"@FK_AcctionBy",  _TaskActionHistory.FK_AcctionBy, 
					"@FK_TaskIssue",  _TaskActionHistory.FK_TaskIssue, 
					"@Id", _TaskActionHistory.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách TaskActionHistory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<TaskActionHistory> _TaskActionHistorys)
		{
			foreach (TaskActionHistory item in _TaskActionHistorys)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật TaskActionHistory vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, TaskActionHistory _TaskActionHistory, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[TaskActionHistory] SET Id=@Id, ActionDate=@ActionDate, ContentAction=@ContentAction, FK_AcctionBy=@FK_AcctionBy, FK_TaskIssue=@FK_TaskIssue "+ condition, 
					"@Id",  _TaskActionHistory.Id, 
					"@ActionDate", this._dataContext.ConvertDateString( _TaskActionHistory.ActionDate), 
					"@ContentAction",  _TaskActionHistory.ContentAction, 
					"@FK_AcctionBy",  _TaskActionHistory.FK_AcctionBy, 
					"@FK_TaskIssue",  _TaskActionHistory.FK_TaskIssue);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa TaskActionHistory trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[TaskActionHistory] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa TaskActionHistory trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, TaskActionHistory _TaskActionHistory)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[TaskActionHistory] WHERE Id=@Id",
					"@Id", _TaskActionHistory.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa TaskActionHistory trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[TaskActionHistory] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa TaskActionHistory trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<TaskActionHistory> _TaskActionHistorys)
		{
			foreach (TaskActionHistory item in _TaskActionHistorys)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
