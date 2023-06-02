using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpreceivetaskstatus:IGExpreceivetaskstatus
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpreceivetaskstatus(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpReceiveTaskStatus từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpReceiveTaskStatus]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpReceiveTaskStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpReceiveTaskStatus] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpReceiveTaskStatus từ Database
		/// </summary>
		public List<GExpReceiveTaskStatus> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpReceiveTaskStatus]");
				List<GExpReceiveTaskStatus> items = new List<GExpReceiveTaskStatus>();
				GExpReceiveTaskStatus item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpReceiveTaskStatus();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToInt32(dr["Id"]);
					}
					if (dr["StatusReceiveName"] != null && dr["StatusReceiveName"] != DBNull.Value)
					{
						item.StatusReceiveName = Convert.ToString(dr["StatusReceiveName"]);
					}
					if (dr["StatusBackgroundColor"] != null && dr["StatusBackgroundColor"] != DBNull.Value)
					{
						item.StatusBackgroundColor = Convert.ToString(dr["StatusBackgroundColor"]);
					}
					if (dr["StatusTextColor"] != null && dr["StatusTextColor"] != DBNull.Value)
					{
						item.StatusTextColor = Convert.ToString(dr["StatusTextColor"]);
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
		/// Lấy danh sách GExpReceiveTaskStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpReceiveTaskStatus> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpReceiveTaskStatus] A "+ condition,  parameters);
				List<GExpReceiveTaskStatus> items = new List<GExpReceiveTaskStatus>();
				GExpReceiveTaskStatus item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpReceiveTaskStatus();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToInt32(dr["Id"]);
					}
					if (dr["StatusReceiveName"] != null && dr["StatusReceiveName"] != DBNull.Value)
					{
						item.StatusReceiveName = Convert.ToString(dr["StatusReceiveName"]);
					}
					if (dr["StatusBackgroundColor"] != null && dr["StatusBackgroundColor"] != DBNull.Value)
					{
						item.StatusBackgroundColor = Convert.ToString(dr["StatusBackgroundColor"]);
					}
					if (dr["StatusTextColor"] != null && dr["StatusTextColor"] != DBNull.Value)
					{
						item.StatusTextColor = Convert.ToString(dr["StatusTextColor"]);
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

		public List<GExpReceiveTaskStatus> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpReceiveTaskStatus] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpReceiveTaskStatus] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpReceiveTaskStatus>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpReceiveTaskStatus từ Database
		/// </summary>
		public GExpReceiveTaskStatus GetObject(string schema, Int32 Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpReceiveTaskStatus] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpReceiveTaskStatus item=new GExpReceiveTaskStatus();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToInt32(dr["Id"]);
						}
						if (dr["StatusReceiveName"] != null && dr["StatusReceiveName"] != DBNull.Value)
						{
							item.StatusReceiveName = Convert.ToString(dr["StatusReceiveName"]);
						}
						if (dr["StatusBackgroundColor"] != null && dr["StatusBackgroundColor"] != DBNull.Value)
						{
							item.StatusBackgroundColor = Convert.ToString(dr["StatusBackgroundColor"]);
						}
						if (dr["StatusTextColor"] != null && dr["StatusTextColor"] != DBNull.Value)
						{
							item.StatusTextColor = Convert.ToString(dr["StatusTextColor"]);
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
		/// Lấy một GExpReceiveTaskStatus đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpReceiveTaskStatus GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpReceiveTaskStatus] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpReceiveTaskStatus item=new GExpReceiveTaskStatus();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToInt32(dr["Id"]);
						}
						if (dr["StatusReceiveName"] != null && dr["StatusReceiveName"] != DBNull.Value)
						{
							item.StatusReceiveName = Convert.ToString(dr["StatusReceiveName"]);
						}
						if (dr["StatusBackgroundColor"] != null && dr["StatusBackgroundColor"] != DBNull.Value)
						{
							item.StatusBackgroundColor = Convert.ToString(dr["StatusBackgroundColor"]);
						}
						if (dr["StatusTextColor"] != null && dr["StatusTextColor"] != DBNull.Value)
						{
							item.StatusTextColor = Convert.ToString(dr["StatusTextColor"]);
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

		public GExpReceiveTaskStatus GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpReceiveTaskStatus] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpReceiveTaskStatus>(ds);
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
		/// Thêm mới GExpReceiveTaskStatus vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpReceiveTaskStatus _GExpReceiveTaskStatus)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpReceiveTaskStatus](Id, StatusReceiveName, StatusBackgroundColor, StatusTextColor) VALUES(@Id, @StatusReceiveName, @StatusBackgroundColor, @StatusTextColor)", 
					"@Id",  _GExpReceiveTaskStatus.Id, 
					"@StatusReceiveName",  _GExpReceiveTaskStatus.StatusReceiveName, 
					"@StatusBackgroundColor",  _GExpReceiveTaskStatus.StatusBackgroundColor, 
					"@StatusTextColor",  _GExpReceiveTaskStatus.StatusTextColor);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpReceiveTaskStatus vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpReceiveTaskStatus> _GExpReceiveTaskStatuss)
		{
			foreach (GExpReceiveTaskStatus item in _GExpReceiveTaskStatuss)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpReceiveTaskStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpReceiveTaskStatus _GExpReceiveTaskStatus, Int32 Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpReceiveTaskStatus] SET Id=@Id, StatusReceiveName=@StatusReceiveName, StatusBackgroundColor=@StatusBackgroundColor, StatusTextColor=@StatusTextColor WHERE Id=@Id", 
					"@Id",  _GExpReceiveTaskStatus.Id, 
					"@StatusReceiveName",  _GExpReceiveTaskStatus.StatusReceiveName, 
					"@StatusBackgroundColor",  _GExpReceiveTaskStatus.StatusBackgroundColor, 
					"@StatusTextColor",  _GExpReceiveTaskStatus.StatusTextColor, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpReceiveTaskStatus vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpReceiveTaskStatus _GExpReceiveTaskStatus)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpReceiveTaskStatus] SET StatusReceiveName=@StatusReceiveName, StatusBackgroundColor=@StatusBackgroundColor, StatusTextColor=@StatusTextColor WHERE Id=@Id", 
					"@StatusReceiveName",  _GExpReceiveTaskStatus.StatusReceiveName, 
					"@StatusBackgroundColor",  _GExpReceiveTaskStatus.StatusBackgroundColor, 
					"@StatusTextColor",  _GExpReceiveTaskStatus.StatusTextColor, 
					"@Id", _GExpReceiveTaskStatus.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpReceiveTaskStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpReceiveTaskStatus> _GExpReceiveTaskStatuss)
		{
			foreach (GExpReceiveTaskStatus item in _GExpReceiveTaskStatuss)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpReceiveTaskStatus vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpReceiveTaskStatus _GExpReceiveTaskStatus, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpReceiveTaskStatus] SET Id=@Id, StatusReceiveName=@StatusReceiveName, StatusBackgroundColor=@StatusBackgroundColor, StatusTextColor=@StatusTextColor "+ condition, 
					"@Id",  _GExpReceiveTaskStatus.Id, 
					"@StatusReceiveName",  _GExpReceiveTaskStatus.StatusReceiveName, 
					"@StatusBackgroundColor",  _GExpReceiveTaskStatus.StatusBackgroundColor, 
					"@StatusTextColor",  _GExpReceiveTaskStatus.StatusTextColor);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpReceiveTaskStatus trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpReceiveTaskStatus] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpReceiveTaskStatus trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpReceiveTaskStatus _GExpReceiveTaskStatus)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpReceiveTaskStatus] WHERE Id=@Id",
					"@Id", _GExpReceiveTaskStatus.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpReceiveTaskStatus trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpReceiveTaskStatus] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpReceiveTaskStatus trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpReceiveTaskStatus> _GExpReceiveTaskStatuss)
		{
			foreach (GExpReceiveTaskStatus item in _GExpReceiveTaskStatuss)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
