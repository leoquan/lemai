using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpmoneyreturnstatus:IGExpmoneyreturnstatus
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpmoneyreturnstatus(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpMoneyReturnStatus từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpMoneyReturnStatus]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpMoneyReturnStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpMoneyReturnStatus] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpMoneyReturnStatus từ Database
		/// </summary>
		public List<GExpMoneyReturnStatus> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpMoneyReturnStatus]");
				List<GExpMoneyReturnStatus> items = new List<GExpMoneyReturnStatus>();
				GExpMoneyReturnStatus item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpMoneyReturnStatus();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToInt32(dr["Id"]);
					}
					if (dr["MoneyReturnStatusName"] != null && dr["MoneyReturnStatusName"] != DBNull.Value)
					{
						item.MoneyReturnStatusName = Convert.ToString(dr["MoneyReturnStatusName"]);
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
		/// Lấy danh sách GExpMoneyReturnStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpMoneyReturnStatus> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpMoneyReturnStatus] A "+ condition,  parameters);
				List<GExpMoneyReturnStatus> items = new List<GExpMoneyReturnStatus>();
				GExpMoneyReturnStatus item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpMoneyReturnStatus();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToInt32(dr["Id"]);
					}
					if (dr["MoneyReturnStatusName"] != null && dr["MoneyReturnStatusName"] != DBNull.Value)
					{
						item.MoneyReturnStatusName = Convert.ToString(dr["MoneyReturnStatusName"]);
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

		public List<GExpMoneyReturnStatus> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpMoneyReturnStatus] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpMoneyReturnStatus] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpMoneyReturnStatus>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpMoneyReturnStatus từ Database
		/// </summary>
		public GExpMoneyReturnStatus GetObject(string schema, Int32 Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpMoneyReturnStatus] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpMoneyReturnStatus item=new GExpMoneyReturnStatus();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToInt32(dr["Id"]);
						}
						if (dr["MoneyReturnStatusName"] != null && dr["MoneyReturnStatusName"] != DBNull.Value)
						{
							item.MoneyReturnStatusName = Convert.ToString(dr["MoneyReturnStatusName"]);
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
		/// Lấy một GExpMoneyReturnStatus đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpMoneyReturnStatus GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpMoneyReturnStatus] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpMoneyReturnStatus item=new GExpMoneyReturnStatus();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToInt32(dr["Id"]);
						}
						if (dr["MoneyReturnStatusName"] != null && dr["MoneyReturnStatusName"] != DBNull.Value)
						{
							item.MoneyReturnStatusName = Convert.ToString(dr["MoneyReturnStatusName"]);
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

		public GExpMoneyReturnStatus GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpMoneyReturnStatus] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpMoneyReturnStatus>(ds);
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
		/// Thêm mới GExpMoneyReturnStatus vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpMoneyReturnStatus _GExpMoneyReturnStatus)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpMoneyReturnStatus](Id, MoneyReturnStatusName) VALUES(@Id, @MoneyReturnStatusName)", 
					"@Id",  _GExpMoneyReturnStatus.Id, 
					"@MoneyReturnStatusName",  _GExpMoneyReturnStatus.MoneyReturnStatusName);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpMoneyReturnStatus vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpMoneyReturnStatus> _GExpMoneyReturnStatuss)
		{
			foreach (GExpMoneyReturnStatus item in _GExpMoneyReturnStatuss)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpMoneyReturnStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpMoneyReturnStatus _GExpMoneyReturnStatus, Int32 Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpMoneyReturnStatus] SET Id=@Id, MoneyReturnStatusName=@MoneyReturnStatusName WHERE Id=@Id", 
					"@Id",  _GExpMoneyReturnStatus.Id, 
					"@MoneyReturnStatusName",  _GExpMoneyReturnStatus.MoneyReturnStatusName, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpMoneyReturnStatus vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpMoneyReturnStatus _GExpMoneyReturnStatus)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpMoneyReturnStatus] SET MoneyReturnStatusName=@MoneyReturnStatusName WHERE Id=@Id", 
					"@MoneyReturnStatusName",  _GExpMoneyReturnStatus.MoneyReturnStatusName, 
					"@Id", _GExpMoneyReturnStatus.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpMoneyReturnStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpMoneyReturnStatus> _GExpMoneyReturnStatuss)
		{
			foreach (GExpMoneyReturnStatus item in _GExpMoneyReturnStatuss)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpMoneyReturnStatus vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpMoneyReturnStatus _GExpMoneyReturnStatus, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpMoneyReturnStatus] SET Id=@Id, MoneyReturnStatusName=@MoneyReturnStatusName "+ condition, 
					"@Id",  _GExpMoneyReturnStatus.Id, 
					"@MoneyReturnStatusName",  _GExpMoneyReturnStatus.MoneyReturnStatusName);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpMoneyReturnStatus trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpMoneyReturnStatus] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpMoneyReturnStatus trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpMoneyReturnStatus _GExpMoneyReturnStatus)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpMoneyReturnStatus] WHERE Id=@Id",
					"@Id", _GExpMoneyReturnStatus.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpMoneyReturnStatus trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpMoneyReturnStatus] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpMoneyReturnStatus trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpMoneyReturnStatus> _GExpMoneyReturnStatuss)
		{
			foreach (GExpMoneyReturnStatus item in _GExpMoneyReturnStatuss)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
