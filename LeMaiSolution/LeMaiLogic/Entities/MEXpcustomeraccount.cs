using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpcustomeraccount:IEXpcustomeraccount
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpcustomeraccount(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpCustomerAccount từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCustomerAccount]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpCustomerAccount từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCustomerAccount] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpCustomerAccount từ Database
		/// </summary>
		public List<ExpCustomerAccount> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCustomerAccount]");
				List<ExpCustomerAccount> items = new List<ExpCustomerAccount>();
				ExpCustomerAccount item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpCustomerAccount();
					if (dr["FK_CustomerID"] != null && dr["FK_CustomerID"] != DBNull.Value)
					{
						item.FK_CustomerID = Convert.ToString(dr["FK_CustomerID"]);
					}
					if (dr["FK_AccountObject"] != null && dr["FK_AccountObject"] != DBNull.Value)
					{
						item.FK_AccountObject = Convert.ToString(dr["FK_AccountObject"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
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
		/// Lấy danh sách ExpCustomerAccount từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpCustomerAccount> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpCustomerAccount] A "+ condition,  parameters);
				List<ExpCustomerAccount> items = new List<ExpCustomerAccount>();
				ExpCustomerAccount item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpCustomerAccount();
					if (dr["FK_CustomerID"] != null && dr["FK_CustomerID"] != DBNull.Value)
					{
						item.FK_CustomerID = Convert.ToString(dr["FK_CustomerID"]);
					}
					if (dr["FK_AccountObject"] != null && dr["FK_AccountObject"] != DBNull.Value)
					{
						item.FK_AccountObject = Convert.ToString(dr["FK_AccountObject"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
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

		public List<ExpCustomerAccount> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpCustomerAccount] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpCustomerAccount] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpCustomerAccount>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpCustomerAccount từ Database
		/// </summary>
		public ExpCustomerAccount GetObject(string schema, String FK_CustomerID, String FK_AccountObject)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCustomerAccount] where FK_CustomerID=@FK_CustomerID and FK_AccountObject=@FK_AccountObject",
					"@FK_CustomerID", FK_CustomerID, 
					"@FK_AccountObject", FK_AccountObject);
				if (ds.Rows.Count > 0)
				{
					ExpCustomerAccount item=new ExpCustomerAccount();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_CustomerID"] != null && dr["FK_CustomerID"] != DBNull.Value)
						{
							item.FK_CustomerID = Convert.ToString(dr["FK_CustomerID"]);
						}
						if (dr["FK_AccountObject"] != null && dr["FK_AccountObject"] != DBNull.Value)
						{
							item.FK_AccountObject = Convert.ToString(dr["FK_AccountObject"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
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
		/// Lấy một ExpCustomerAccount đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpCustomerAccount GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpCustomerAccount] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpCustomerAccount item=new ExpCustomerAccount();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_CustomerID"] != null && dr["FK_CustomerID"] != DBNull.Value)
						{
							item.FK_CustomerID = Convert.ToString(dr["FK_CustomerID"]);
						}
						if (dr["FK_AccountObject"] != null && dr["FK_AccountObject"] != DBNull.Value)
						{
							item.FK_AccountObject = Convert.ToString(dr["FK_AccountObject"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
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

		public ExpCustomerAccount GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpCustomerAccount] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpCustomerAccount>(ds);
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
		/// Thêm mới ExpCustomerAccount vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpCustomerAccount _ExpCustomerAccount)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpCustomerAccount](FK_CustomerID, FK_AccountObject, CreateBy, CreateDate) VALUES(@FK_CustomerID, @FK_AccountObject, @CreateBy, @CreateDate)", 
					"@FK_CustomerID",  _ExpCustomerAccount.FK_CustomerID, 
					"@FK_AccountObject",  _ExpCustomerAccount.FK_AccountObject, 
					"@CreateBy",  _ExpCustomerAccount.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpCustomerAccount.CreateDate));
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpCustomerAccount vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpCustomerAccount> _ExpCustomerAccounts)
		{
			foreach (ExpCustomerAccount item in _ExpCustomerAccounts)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpCustomerAccount vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpCustomerAccount _ExpCustomerAccount, String FK_CustomerID, String FK_AccountObject)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCustomerAccount] SET FK_CustomerID=@FK_CustomerID, FK_AccountObject=@FK_AccountObject, CreateBy=@CreateBy, CreateDate=@CreateDate WHERE FK_CustomerID=@FK_CustomerID and FK_AccountObject=@FK_AccountObject", 
					"@FK_CustomerID",  _ExpCustomerAccount.FK_CustomerID, 
					"@FK_AccountObject",  _ExpCustomerAccount.FK_AccountObject, 
					"@CreateBy",  _ExpCustomerAccount.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpCustomerAccount.CreateDate), 
					"@FK_CustomerID", FK_CustomerID, 
					"@FK_AccountObject", FK_AccountObject);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpCustomerAccount vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpCustomerAccount _ExpCustomerAccount)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCustomerAccount] SET CreateBy=@CreateBy, CreateDate=@CreateDate WHERE FK_CustomerID=@FK_CustomerID and FK_AccountObject=@FK_AccountObject", 
					"@CreateBy",  _ExpCustomerAccount.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpCustomerAccount.CreateDate), 
					"@FK_CustomerID", _ExpCustomerAccount.FK_CustomerID, 
					"@FK_AccountObject", _ExpCustomerAccount.FK_AccountObject);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpCustomerAccount vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpCustomerAccount> _ExpCustomerAccounts)
		{
			foreach (ExpCustomerAccount item in _ExpCustomerAccounts)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpCustomerAccount vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpCustomerAccount _ExpCustomerAccount, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCustomerAccount] SET FK_CustomerID=@FK_CustomerID, FK_AccountObject=@FK_AccountObject, CreateBy=@CreateBy, CreateDate=@CreateDate "+ condition, 
					"@FK_CustomerID",  _ExpCustomerAccount.FK_CustomerID, 
					"@FK_AccountObject",  _ExpCustomerAccount.FK_AccountObject, 
					"@CreateBy",  _ExpCustomerAccount.CreateBy, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpCustomerAccount.CreateDate));
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpCustomerAccount trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String FK_CustomerID, String FK_AccountObject)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCustomerAccount] WHERE FK_CustomerID=@FK_CustomerID and FK_AccountObject=@FK_AccountObject",
					"@FK_CustomerID", FK_CustomerID, 
					"@FK_AccountObject", FK_AccountObject);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCustomerAccount trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpCustomerAccount _ExpCustomerAccount)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCustomerAccount] WHERE FK_CustomerID=@FK_CustomerID and FK_AccountObject=@FK_AccountObject",
					"@FK_CustomerID", _ExpCustomerAccount.FK_CustomerID, 
					"@FK_AccountObject", _ExpCustomerAccount.FK_AccountObject);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCustomerAccount trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCustomerAccount] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCustomerAccount trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpCustomerAccount> _ExpCustomerAccounts)
		{
			foreach (ExpCustomerAccount item in _ExpCustomerAccounts)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
