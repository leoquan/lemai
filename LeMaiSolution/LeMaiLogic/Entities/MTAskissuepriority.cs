using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MTAskissuepriority:ITAskissuepriority
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MTAskissuepriority(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable TaskIssuePriority từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[TaskIssuePriority]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable TaskIssuePriority từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[TaskIssuePriority] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách TaskIssuePriority từ Database
		/// </summary>
		public List<TaskIssuePriority> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[TaskIssuePriority]");
				List<TaskIssuePriority> items = new List<TaskIssuePriority>();
				TaskIssuePriority item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new TaskIssuePriority();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToInt32(dr["Id"]);
					}
					if (dr["PriorityName"] != null && dr["PriorityName"] != DBNull.Value)
					{
						item.PriorityName = Convert.ToString(dr["PriorityName"]);
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
		/// Lấy danh sách TaskIssuePriority từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<TaskIssuePriority> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[TaskIssuePriority] A "+ condition,  parameters);
				List<TaskIssuePriority> items = new List<TaskIssuePriority>();
				TaskIssuePriority item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new TaskIssuePriority();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToInt32(dr["Id"]);
					}
					if (dr["PriorityName"] != null && dr["PriorityName"] != DBNull.Value)
					{
						item.PriorityName = Convert.ToString(dr["PriorityName"]);
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

		public List<TaskIssuePriority> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[TaskIssuePriority] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[TaskIssuePriority] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<TaskIssuePriority>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một TaskIssuePriority từ Database
		/// </summary>
		public TaskIssuePriority GetObject(string schema, Int32 Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[TaskIssuePriority] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					TaskIssuePriority item=new TaskIssuePriority();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToInt32(dr["Id"]);
						}
						if (dr["PriorityName"] != null && dr["PriorityName"] != DBNull.Value)
						{
							item.PriorityName = Convert.ToString(dr["PriorityName"]);
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
		/// Lấy một TaskIssuePriority đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public TaskIssuePriority GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[TaskIssuePriority] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					TaskIssuePriority item=new TaskIssuePriority();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToInt32(dr["Id"]);
						}
						if (dr["PriorityName"] != null && dr["PriorityName"] != DBNull.Value)
						{
							item.PriorityName = Convert.ToString(dr["PriorityName"]);
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

		public TaskIssuePriority GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[TaskIssuePriority] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<TaskIssuePriority>(ds);
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
		/// Thêm mới TaskIssuePriority vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, TaskIssuePriority _TaskIssuePriority)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[TaskIssuePriority](Id, PriorityName) VALUES(@Id, @PriorityName)", 
					"@Id",  _TaskIssuePriority.Id, 
					"@PriorityName",  _TaskIssuePriority.PriorityName);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng TaskIssuePriority vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<TaskIssuePriority> _TaskIssuePrioritys)
		{
			foreach (TaskIssuePriority item in _TaskIssuePrioritys)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật TaskIssuePriority vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, TaskIssuePriority _TaskIssuePriority, Int32 Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[TaskIssuePriority] SET Id=@Id, PriorityName=@PriorityName WHERE Id=@Id", 
					"@Id",  _TaskIssuePriority.Id, 
					"@PriorityName",  _TaskIssuePriority.PriorityName, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật TaskIssuePriority vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, TaskIssuePriority _TaskIssuePriority)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[TaskIssuePriority] SET PriorityName=@PriorityName WHERE Id=@Id", 
					"@PriorityName",  _TaskIssuePriority.PriorityName, 
					"@Id", _TaskIssuePriority.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách TaskIssuePriority vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<TaskIssuePriority> _TaskIssuePrioritys)
		{
			foreach (TaskIssuePriority item in _TaskIssuePrioritys)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật TaskIssuePriority vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, TaskIssuePriority _TaskIssuePriority, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[TaskIssuePriority] SET Id=@Id, PriorityName=@PriorityName "+ condition, 
					"@Id",  _TaskIssuePriority.Id, 
					"@PriorityName",  _TaskIssuePriority.PriorityName);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa TaskIssuePriority trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[TaskIssuePriority] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa TaskIssuePriority trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, TaskIssuePriority _TaskIssuePriority)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[TaskIssuePriority] WHERE Id=@Id",
					"@Id", _TaskIssuePriority.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa TaskIssuePriority trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[TaskIssuePriority] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa TaskIssuePriority trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<TaskIssuePriority> _TaskIssuePrioritys)
		{
			foreach (TaskIssuePriority item in _TaskIssuePrioritys)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
