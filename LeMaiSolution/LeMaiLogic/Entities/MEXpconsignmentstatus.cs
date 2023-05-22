using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpconsignmentstatus:IEXpconsignmentstatus
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpconsignmentstatus(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpConsignmentStatus từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignmentStatus]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpConsignmentStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignmentStatus] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpConsignmentStatus từ Database
		/// </summary>
		public List<ExpConsignmentStatus> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignmentStatus]");
				List<ExpConsignmentStatus> items = new List<ExpConsignmentStatus>();
				ExpConsignmentStatus item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpConsignmentStatus();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
					{
						item.StatusName = Convert.ToString(dr["StatusName"]);
					}
					if (dr["OrderId"] != null && dr["OrderId"] != DBNull.Value)
					{
						item.OrderId = Convert.ToInt32(dr["OrderId"]);
					}
					if (dr["IsDone"] != null && dr["IsDone"] != DBNull.Value)
					{
						item.IsDone = Convert.ToBoolean(dr["IsDone"]);
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
		/// Lấy danh sách ExpConsignmentStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpConsignmentStatus> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpConsignmentStatus] A "+ condition,  parameters);
				List<ExpConsignmentStatus> items = new List<ExpConsignmentStatus>();
				ExpConsignmentStatus item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpConsignmentStatus();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
					{
						item.StatusName = Convert.ToString(dr["StatusName"]);
					}
					if (dr["OrderId"] != null && dr["OrderId"] != DBNull.Value)
					{
						item.OrderId = Convert.ToInt32(dr["OrderId"]);
					}
					if (dr["IsDone"] != null && dr["IsDone"] != DBNull.Value)
					{
						item.IsDone = Convert.ToBoolean(dr["IsDone"]);
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

		public List<ExpConsignmentStatus> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpConsignmentStatus] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpConsignmentStatus] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpConsignmentStatus>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpConsignmentStatus từ Database
		/// </summary>
		public ExpConsignmentStatus GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignmentStatus] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpConsignmentStatus item=new ExpConsignmentStatus();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
						{
							item.StatusName = Convert.ToString(dr["StatusName"]);
						}
						if (dr["OrderId"] != null && dr["OrderId"] != DBNull.Value)
						{
							item.OrderId = Convert.ToInt32(dr["OrderId"]);
						}
						if (dr["IsDone"] != null && dr["IsDone"] != DBNull.Value)
						{
							item.IsDone = Convert.ToBoolean(dr["IsDone"]);
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
		/// Lấy một ExpConsignmentStatus đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpConsignmentStatus GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpConsignmentStatus] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpConsignmentStatus item=new ExpConsignmentStatus();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
						{
							item.StatusName = Convert.ToString(dr["StatusName"]);
						}
						if (dr["OrderId"] != null && dr["OrderId"] != DBNull.Value)
						{
							item.OrderId = Convert.ToInt32(dr["OrderId"]);
						}
						if (dr["IsDone"] != null && dr["IsDone"] != DBNull.Value)
						{
							item.IsDone = Convert.ToBoolean(dr["IsDone"]);
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

		public ExpConsignmentStatus GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpConsignmentStatus] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpConsignmentStatus>(ds);
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
		/// Thêm mới ExpConsignmentStatus vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpConsignmentStatus _ExpConsignmentStatus)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpConsignmentStatus](Id, StatusName, OrderId, IsDone) VALUES(@Id, @StatusName, @OrderId, @IsDone)", 
					"@Id",  _ExpConsignmentStatus.Id, 
					"@StatusName",  _ExpConsignmentStatus.StatusName, 
					"@OrderId",  _ExpConsignmentStatus.OrderId, 
					"@IsDone",  _ExpConsignmentStatus.IsDone);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpConsignmentStatus vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpConsignmentStatus> _ExpConsignmentStatuss)
		{
			foreach (ExpConsignmentStatus item in _ExpConsignmentStatuss)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpConsignmentStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpConsignmentStatus _ExpConsignmentStatus, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpConsignmentStatus] SET Id=@Id, StatusName=@StatusName, OrderId=@OrderId, IsDone=@IsDone WHERE Id=@Id", 
					"@Id",  _ExpConsignmentStatus.Id, 
					"@StatusName",  _ExpConsignmentStatus.StatusName, 
					"@OrderId",  _ExpConsignmentStatus.OrderId, 
					"@IsDone",  _ExpConsignmentStatus.IsDone, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpConsignmentStatus vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpConsignmentStatus _ExpConsignmentStatus)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpConsignmentStatus] SET StatusName=@StatusName, OrderId=@OrderId, IsDone=@IsDone WHERE Id=@Id", 
					"@StatusName",  _ExpConsignmentStatus.StatusName, 
					"@OrderId",  _ExpConsignmentStatus.OrderId, 
					"@IsDone",  _ExpConsignmentStatus.IsDone, 
					"@Id", _ExpConsignmentStatus.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpConsignmentStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpConsignmentStatus> _ExpConsignmentStatuss)
		{
			foreach (ExpConsignmentStatus item in _ExpConsignmentStatuss)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpConsignmentStatus vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpConsignmentStatus _ExpConsignmentStatus, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpConsignmentStatus] SET Id=@Id, StatusName=@StatusName, OrderId=@OrderId, IsDone=@IsDone "+ condition, 
					"@Id",  _ExpConsignmentStatus.Id, 
					"@StatusName",  _ExpConsignmentStatus.StatusName, 
					"@OrderId",  _ExpConsignmentStatus.OrderId, 
					"@IsDone",  _ExpConsignmentStatus.IsDone);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpConsignmentStatus trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpConsignmentStatus] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpConsignmentStatus trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpConsignmentStatus _ExpConsignmentStatus)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpConsignmentStatus] WHERE Id=@Id",
					"@Id", _ExpConsignmentStatus.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpConsignmentStatus trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpConsignmentStatus] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpConsignmentStatus trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpConsignmentStatus> _ExpConsignmentStatuss)
		{
			foreach (ExpConsignmentStatus item in _ExpConsignmentStatuss)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
