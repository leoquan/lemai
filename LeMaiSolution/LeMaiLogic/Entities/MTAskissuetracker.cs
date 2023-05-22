using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MTAskissuetracker:ITAskissuetracker
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MTAskissuetracker(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable TaskIssueTracker từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[TaskIssueTracker]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable TaskIssueTracker từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[TaskIssueTracker] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách TaskIssueTracker từ Database
		/// </summary>
		public List<TaskIssueTracker> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[TaskIssueTracker]");
				List<TaskIssueTracker> items = new List<TaskIssueTracker>();
				TaskIssueTracker item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new TaskIssueTracker();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToInt32(dr["Id"]);
					}
					if (dr["TrackerName"] != null && dr["TrackerName"] != DBNull.Value)
					{
						item.TrackerName = Convert.ToString(dr["TrackerName"]);
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
		/// Lấy danh sách TaskIssueTracker từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<TaskIssueTracker> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[TaskIssueTracker] A "+ condition,  parameters);
				List<TaskIssueTracker> items = new List<TaskIssueTracker>();
				TaskIssueTracker item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new TaskIssueTracker();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToInt32(dr["Id"]);
					}
					if (dr["TrackerName"] != null && dr["TrackerName"] != DBNull.Value)
					{
						item.TrackerName = Convert.ToString(dr["TrackerName"]);
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

		public List<TaskIssueTracker> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[TaskIssueTracker] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[TaskIssueTracker] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<TaskIssueTracker>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một TaskIssueTracker từ Database
		/// </summary>
		public TaskIssueTracker GetObject(string schema, Int32 Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[TaskIssueTracker] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					TaskIssueTracker item=new TaskIssueTracker();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToInt32(dr["Id"]);
						}
						if (dr["TrackerName"] != null && dr["TrackerName"] != DBNull.Value)
						{
							item.TrackerName = Convert.ToString(dr["TrackerName"]);
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
		/// Lấy một TaskIssueTracker đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public TaskIssueTracker GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[TaskIssueTracker] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					TaskIssueTracker item=new TaskIssueTracker();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToInt32(dr["Id"]);
						}
						if (dr["TrackerName"] != null && dr["TrackerName"] != DBNull.Value)
						{
							item.TrackerName = Convert.ToString(dr["TrackerName"]);
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

		public TaskIssueTracker GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[TaskIssueTracker] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<TaskIssueTracker>(ds);
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
		/// Thêm mới TaskIssueTracker vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, TaskIssueTracker _TaskIssueTracker)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[TaskIssueTracker](Id, TrackerName) VALUES(@Id, @TrackerName)", 
					"@Id",  _TaskIssueTracker.Id, 
					"@TrackerName",  _TaskIssueTracker.TrackerName);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng TaskIssueTracker vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<TaskIssueTracker> _TaskIssueTrackers)
		{
			foreach (TaskIssueTracker item in _TaskIssueTrackers)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật TaskIssueTracker vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, TaskIssueTracker _TaskIssueTracker, Int32 Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[TaskIssueTracker] SET Id=@Id, TrackerName=@TrackerName WHERE Id=@Id", 
					"@Id",  _TaskIssueTracker.Id, 
					"@TrackerName",  _TaskIssueTracker.TrackerName, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật TaskIssueTracker vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, TaskIssueTracker _TaskIssueTracker)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[TaskIssueTracker] SET TrackerName=@TrackerName WHERE Id=@Id", 
					"@TrackerName",  _TaskIssueTracker.TrackerName, 
					"@Id", _TaskIssueTracker.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách TaskIssueTracker vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<TaskIssueTracker> _TaskIssueTrackers)
		{
			foreach (TaskIssueTracker item in _TaskIssueTrackers)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật TaskIssueTracker vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, TaskIssueTracker _TaskIssueTracker, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[TaskIssueTracker] SET Id=@Id, TrackerName=@TrackerName "+ condition, 
					"@Id",  _TaskIssueTracker.Id, 
					"@TrackerName",  _TaskIssueTracker.TrackerName);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa TaskIssueTracker trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[TaskIssueTracker] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa TaskIssueTracker trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, TaskIssueTracker _TaskIssueTracker)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[TaskIssueTracker] WHERE Id=@Id",
					"@Id", _TaskIssueTracker.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa TaskIssueTracker trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[TaskIssueTracker] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa TaskIssueTracker trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<TaskIssueTracker> _TaskIssueTrackers)
		{
			foreach (TaskIssueTracker item in _TaskIssueTrackers)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
