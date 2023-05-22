using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MTAskissuestatus:ITAskissuestatus
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MTAskissuestatus(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable TaskIssueStatus từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[TaskIssueStatus]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable TaskIssueStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[TaskIssueStatus] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách TaskIssueStatus từ Database
		/// </summary>
		public List<TaskIssueStatus> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[TaskIssueStatus]");
				List<TaskIssueStatus> items = new List<TaskIssueStatus>();
				TaskIssueStatus item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new TaskIssueStatus();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToInt32(dr["Id"]);
					}
					if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
					{
						item.StatusName = Convert.ToString(dr["StatusName"]);
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
		/// Lấy danh sách TaskIssueStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<TaskIssueStatus> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[TaskIssueStatus] A "+ condition,  parameters);
				List<TaskIssueStatus> items = new List<TaskIssueStatus>();
				TaskIssueStatus item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new TaskIssueStatus();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToInt32(dr["Id"]);
					}
					if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
					{
						item.StatusName = Convert.ToString(dr["StatusName"]);
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

		public List<TaskIssueStatus> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[TaskIssueStatus] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[TaskIssueStatus] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<TaskIssueStatus>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một TaskIssueStatus từ Database
		/// </summary>
		public TaskIssueStatus GetObject(string schema, Int32 Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[TaskIssueStatus] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					TaskIssueStatus item=new TaskIssueStatus();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToInt32(dr["Id"]);
						}
						if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
						{
							item.StatusName = Convert.ToString(dr["StatusName"]);
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
		/// Lấy một TaskIssueStatus đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public TaskIssueStatus GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[TaskIssueStatus] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					TaskIssueStatus item=new TaskIssueStatus();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToInt32(dr["Id"]);
						}
						if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
						{
							item.StatusName = Convert.ToString(dr["StatusName"]);
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

		public TaskIssueStatus GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[TaskIssueStatus] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<TaskIssueStatus>(ds);
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
		/// Thêm mới TaskIssueStatus vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, TaskIssueStatus _TaskIssueStatus)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[TaskIssueStatus](Id, StatusName) VALUES(@Id, @StatusName)", 
					"@Id",  _TaskIssueStatus.Id, 
					"@StatusName",  _TaskIssueStatus.StatusName);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng TaskIssueStatus vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<TaskIssueStatus> _TaskIssueStatuss)
		{
			foreach (TaskIssueStatus item in _TaskIssueStatuss)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật TaskIssueStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, TaskIssueStatus _TaskIssueStatus, Int32 Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[TaskIssueStatus] SET Id=@Id, StatusName=@StatusName WHERE Id=@Id", 
					"@Id",  _TaskIssueStatus.Id, 
					"@StatusName",  _TaskIssueStatus.StatusName, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật TaskIssueStatus vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, TaskIssueStatus _TaskIssueStatus)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[TaskIssueStatus] SET StatusName=@StatusName WHERE Id=@Id", 
					"@StatusName",  _TaskIssueStatus.StatusName, 
					"@Id", _TaskIssueStatus.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách TaskIssueStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<TaskIssueStatus> _TaskIssueStatuss)
		{
			foreach (TaskIssueStatus item in _TaskIssueStatuss)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật TaskIssueStatus vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, TaskIssueStatus _TaskIssueStatus, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[TaskIssueStatus] SET Id=@Id, StatusName=@StatusName "+ condition, 
					"@Id",  _TaskIssueStatus.Id, 
					"@StatusName",  _TaskIssueStatus.StatusName);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa TaskIssueStatus trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[TaskIssueStatus] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa TaskIssueStatus trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, TaskIssueStatus _TaskIssueStatus)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[TaskIssueStatus] WHERE Id=@Id",
					"@Id", _TaskIssueStatus.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa TaskIssueStatus trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[TaskIssueStatus] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa TaskIssueStatus trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<TaskIssueStatus> _TaskIssueStatuss)
		{
			foreach (TaskIssueStatus item in _TaskIssueStatuss)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
