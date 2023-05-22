using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExporderstatus:IGExporderstatus
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExporderstatus(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpOrderStatus từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpOrderStatus]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpOrderStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpOrderStatus] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpOrderStatus từ Database
		/// </summary>
		public List<GExpOrderStatus> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpOrderStatus]");
				List<GExpOrderStatus> items = new List<GExpOrderStatus>();
				GExpOrderStatus item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpOrderStatus();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToInt32(dr["Id"]);
					}
					if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
					{
						item.StatusName = Convert.ToString(dr["StatusName"]);
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
		/// Lấy danh sách GExpOrderStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpOrderStatus> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpOrderStatus] A "+ condition,  parameters);
				List<GExpOrderStatus> items = new List<GExpOrderStatus>();
				GExpOrderStatus item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpOrderStatus();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToInt32(dr["Id"]);
					}
					if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
					{
						item.StatusName = Convert.ToString(dr["StatusName"]);
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

		public List<GExpOrderStatus> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpOrderStatus] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpOrderStatus] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpOrderStatus>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpOrderStatus từ Database
		/// </summary>
		public GExpOrderStatus GetObject(string schema, Int32 Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpOrderStatus] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpOrderStatus item=new GExpOrderStatus();
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
		/// Lấy một GExpOrderStatus đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpOrderStatus GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpOrderStatus] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpOrderStatus item=new GExpOrderStatus();
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

		public GExpOrderStatus GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpOrderStatus] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpOrderStatus>(ds);
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
		/// Thêm mới GExpOrderStatus vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpOrderStatus _GExpOrderStatus)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpOrderStatus](Id, StatusName, StatusBackgroundColor, StatusTextColor) VALUES(@Id, @StatusName, @StatusBackgroundColor, @StatusTextColor)", 
					"@Id",  _GExpOrderStatus.Id, 
					"@StatusName",  _GExpOrderStatus.StatusName, 
					"@StatusBackgroundColor",  _GExpOrderStatus.StatusBackgroundColor, 
					"@StatusTextColor",  _GExpOrderStatus.StatusTextColor);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpOrderStatus vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpOrderStatus> _GExpOrderStatuss)
		{
			foreach (GExpOrderStatus item in _GExpOrderStatuss)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpOrderStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpOrderStatus _GExpOrderStatus, Int32 Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpOrderStatus] SET Id=@Id, StatusName=@StatusName, StatusBackgroundColor=@StatusBackgroundColor, StatusTextColor=@StatusTextColor WHERE Id=@Id", 
					"@Id",  _GExpOrderStatus.Id, 
					"@StatusName",  _GExpOrderStatus.StatusName, 
					"@StatusBackgroundColor",  _GExpOrderStatus.StatusBackgroundColor, 
					"@StatusTextColor",  _GExpOrderStatus.StatusTextColor, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpOrderStatus vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpOrderStatus _GExpOrderStatus)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpOrderStatus] SET StatusName=@StatusName, StatusBackgroundColor=@StatusBackgroundColor, StatusTextColor=@StatusTextColor WHERE Id=@Id", 
					"@StatusName",  _GExpOrderStatus.StatusName, 
					"@StatusBackgroundColor",  _GExpOrderStatus.StatusBackgroundColor, 
					"@StatusTextColor",  _GExpOrderStatus.StatusTextColor, 
					"@Id", _GExpOrderStatus.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpOrderStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpOrderStatus> _GExpOrderStatuss)
		{
			foreach (GExpOrderStatus item in _GExpOrderStatuss)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpOrderStatus vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpOrderStatus _GExpOrderStatus, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpOrderStatus] SET Id=@Id, StatusName=@StatusName, StatusBackgroundColor=@StatusBackgroundColor, StatusTextColor=@StatusTextColor "+ condition, 
					"@Id",  _GExpOrderStatus.Id, 
					"@StatusName",  _GExpOrderStatus.StatusName, 
					"@StatusBackgroundColor",  _GExpOrderStatus.StatusBackgroundColor, 
					"@StatusTextColor",  _GExpOrderStatus.StatusTextColor);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpOrderStatus trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpOrderStatus] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpOrderStatus trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpOrderStatus _GExpOrderStatus)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpOrderStatus] WHERE Id=@Id",
					"@Id", _GExpOrderStatus.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpOrderStatus trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpOrderStatus] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpOrderStatus trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpOrderStatus> _GExpOrderStatuss)
		{
			foreach (GExpOrderStatus item in _GExpOrderStatuss)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
