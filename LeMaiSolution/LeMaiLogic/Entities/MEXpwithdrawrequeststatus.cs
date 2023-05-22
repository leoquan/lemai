using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpwithdrawrequeststatus:IEXpwithdrawrequeststatus
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpwithdrawrequeststatus(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpWithdrawRequestStatus từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpWithdrawRequestStatus]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpWithdrawRequestStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpWithdrawRequestStatus] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpWithdrawRequestStatus từ Database
		/// </summary>
		public List<ExpWithdrawRequestStatus> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpWithdrawRequestStatus]");
				List<ExpWithdrawRequestStatus> items = new List<ExpWithdrawRequestStatus>();
				ExpWithdrawRequestStatus item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpWithdrawRequestStatus();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
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
		/// Lấy danh sách ExpWithdrawRequestStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpWithdrawRequestStatus> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpWithdrawRequestStatus] A "+ condition,  parameters);
				List<ExpWithdrawRequestStatus> items = new List<ExpWithdrawRequestStatus>();
				ExpWithdrawRequestStatus item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpWithdrawRequestStatus();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
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

		public List<ExpWithdrawRequestStatus> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpWithdrawRequestStatus] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpWithdrawRequestStatus] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpWithdrawRequestStatus>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpWithdrawRequestStatus từ Database
		/// </summary>
		public ExpWithdrawRequestStatus GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpWithdrawRequestStatus] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpWithdrawRequestStatus item=new ExpWithdrawRequestStatus();
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
		/// Lấy một ExpWithdrawRequestStatus đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpWithdrawRequestStatus GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpWithdrawRequestStatus] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpWithdrawRequestStatus item=new ExpWithdrawRequestStatus();
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

		public ExpWithdrawRequestStatus GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpWithdrawRequestStatus] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpWithdrawRequestStatus>(ds);
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
		/// Thêm mới ExpWithdrawRequestStatus vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpWithdrawRequestStatus _ExpWithdrawRequestStatus)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpWithdrawRequestStatus](Id, StatusName) VALUES(@Id, @StatusName)", 
					"@Id",  _ExpWithdrawRequestStatus.Id, 
					"@StatusName",  _ExpWithdrawRequestStatus.StatusName);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpWithdrawRequestStatus vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpWithdrawRequestStatus> _ExpWithdrawRequestStatuss)
		{
			foreach (ExpWithdrawRequestStatus item in _ExpWithdrawRequestStatuss)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpWithdrawRequestStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpWithdrawRequestStatus _ExpWithdrawRequestStatus, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpWithdrawRequestStatus] SET Id=@Id, StatusName=@StatusName WHERE Id=@Id", 
					"@Id",  _ExpWithdrawRequestStatus.Id, 
					"@StatusName",  _ExpWithdrawRequestStatus.StatusName, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpWithdrawRequestStatus vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpWithdrawRequestStatus _ExpWithdrawRequestStatus)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpWithdrawRequestStatus] SET StatusName=@StatusName WHERE Id=@Id", 
					"@StatusName",  _ExpWithdrawRequestStatus.StatusName, 
					"@Id", _ExpWithdrawRequestStatus.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpWithdrawRequestStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpWithdrawRequestStatus> _ExpWithdrawRequestStatuss)
		{
			foreach (ExpWithdrawRequestStatus item in _ExpWithdrawRequestStatuss)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpWithdrawRequestStatus vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpWithdrawRequestStatus _ExpWithdrawRequestStatus, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpWithdrawRequestStatus] SET Id=@Id, StatusName=@StatusName "+ condition, 
					"@Id",  _ExpWithdrawRequestStatus.Id, 
					"@StatusName",  _ExpWithdrawRequestStatus.StatusName);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpWithdrawRequestStatus trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpWithdrawRequestStatus] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpWithdrawRequestStatus trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpWithdrawRequestStatus _ExpWithdrawRequestStatus)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpWithdrawRequestStatus] WHERE Id=@Id",
					"@Id", _ExpWithdrawRequestStatus.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpWithdrawRequestStatus trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpWithdrawRequestStatus] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpWithdrawRequestStatus trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpWithdrawRequestStatus> _ExpWithdrawRequestStatuss)
		{
			foreach (ExpWithdrawRequestStatus item in _ExpWithdrawRequestStatuss)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
