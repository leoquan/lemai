using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXppostaccount:IEXppostaccount
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXppostaccount(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpPostAccount từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpPostAccount]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpPostAccount từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpPostAccount] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpPostAccount từ Database
		/// </summary>
		public List<ExpPostAccount> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpPostAccount]");
				List<ExpPostAccount> items = new List<ExpPostAccount>();
				ExpPostAccount item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpPostAccount();
					if (dr["FK_AccountId"] != null && dr["FK_AccountId"] != DBNull.Value)
					{
						item.FK_AccountId = Convert.ToString(dr["FK_AccountId"]);
					}
					if (dr["FK_ExpPost"] != null && dr["FK_ExpPost"] != DBNull.Value)
					{
						item.FK_ExpPost = Convert.ToString(dr["FK_ExpPost"]);
					}
					if (dr["Position"] != null && dr["Position"] != DBNull.Value)
					{
						item.Position = Convert.ToInt32(dr["Position"]);
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
		/// Lấy danh sách ExpPostAccount từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpPostAccount> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpPostAccount] A "+ condition,  parameters);
				List<ExpPostAccount> items = new List<ExpPostAccount>();
				ExpPostAccount item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpPostAccount();
					if (dr["FK_AccountId"] != null && dr["FK_AccountId"] != DBNull.Value)
					{
						item.FK_AccountId = Convert.ToString(dr["FK_AccountId"]);
					}
					if (dr["FK_ExpPost"] != null && dr["FK_ExpPost"] != DBNull.Value)
					{
						item.FK_ExpPost = Convert.ToString(dr["FK_ExpPost"]);
					}
					if (dr["Position"] != null && dr["Position"] != DBNull.Value)
					{
						item.Position = Convert.ToInt32(dr["Position"]);
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

		public List<ExpPostAccount> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpPostAccount] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpPostAccount] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpPostAccount>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpPostAccount từ Database
		/// </summary>
		public ExpPostAccount GetObject(string schema, String FK_AccountId, String FK_ExpPost)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpPostAccount] where FK_AccountId=@FK_AccountId and FK_ExpPost=@FK_ExpPost",
					"@FK_AccountId", FK_AccountId, 
					"@FK_ExpPost", FK_ExpPost);
				if (ds.Rows.Count > 0)
				{
					ExpPostAccount item=new ExpPostAccount();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_AccountId"] != null && dr["FK_AccountId"] != DBNull.Value)
						{
							item.FK_AccountId = Convert.ToString(dr["FK_AccountId"]);
						}
						if (dr["FK_ExpPost"] != null && dr["FK_ExpPost"] != DBNull.Value)
						{
							item.FK_ExpPost = Convert.ToString(dr["FK_ExpPost"]);
						}
						if (dr["Position"] != null && dr["Position"] != DBNull.Value)
						{
							item.Position = Convert.ToInt32(dr["Position"]);
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
		/// Lấy một ExpPostAccount đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpPostAccount GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpPostAccount] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpPostAccount item=new ExpPostAccount();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_AccountId"] != null && dr["FK_AccountId"] != DBNull.Value)
						{
							item.FK_AccountId = Convert.ToString(dr["FK_AccountId"]);
						}
						if (dr["FK_ExpPost"] != null && dr["FK_ExpPost"] != DBNull.Value)
						{
							item.FK_ExpPost = Convert.ToString(dr["FK_ExpPost"]);
						}
						if (dr["Position"] != null && dr["Position"] != DBNull.Value)
						{
							item.Position = Convert.ToInt32(dr["Position"]);
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

		public ExpPostAccount GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpPostAccount] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpPostAccount>(ds);
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
		/// Thêm mới ExpPostAccount vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpPostAccount _ExpPostAccount)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpPostAccount](FK_AccountId, FK_ExpPost, Position, CreateDate) VALUES(@FK_AccountId, @FK_ExpPost, @Position, @CreateDate)", 
					"@FK_AccountId",  _ExpPostAccount.FK_AccountId, 
					"@FK_ExpPost",  _ExpPostAccount.FK_ExpPost, 
					"@Position",  _ExpPostAccount.Position, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpPostAccount.CreateDate));
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpPostAccount vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpPostAccount> _ExpPostAccounts)
		{
			foreach (ExpPostAccount item in _ExpPostAccounts)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpPostAccount vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpPostAccount _ExpPostAccount, String FK_AccountId, String FK_ExpPost)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpPostAccount] SET FK_AccountId=@FK_AccountId, FK_ExpPost=@FK_ExpPost, Position=@Position, CreateDate=@CreateDate WHERE FK_AccountId=@FK_AccountId and FK_ExpPost=@FK_ExpPost", 
					"@FK_AccountId",  _ExpPostAccount.FK_AccountId, 
					"@FK_ExpPost",  _ExpPostAccount.FK_ExpPost, 
					"@Position",  _ExpPostAccount.Position, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpPostAccount.CreateDate), 
					"@FK_AccountId", FK_AccountId, 
					"@FK_ExpPost", FK_ExpPost);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpPostAccount vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpPostAccount _ExpPostAccount)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpPostAccount] SET Position=@Position, CreateDate=@CreateDate WHERE FK_AccountId=@FK_AccountId and FK_ExpPost=@FK_ExpPost", 
					"@Position",  _ExpPostAccount.Position, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpPostAccount.CreateDate), 
					"@FK_AccountId", _ExpPostAccount.FK_AccountId, 
					"@FK_ExpPost", _ExpPostAccount.FK_ExpPost);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpPostAccount vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpPostAccount> _ExpPostAccounts)
		{
			foreach (ExpPostAccount item in _ExpPostAccounts)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpPostAccount vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpPostAccount _ExpPostAccount, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpPostAccount] SET FK_AccountId=@FK_AccountId, FK_ExpPost=@FK_ExpPost, Position=@Position, CreateDate=@CreateDate "+ condition, 
					"@FK_AccountId",  _ExpPostAccount.FK_AccountId, 
					"@FK_ExpPost",  _ExpPostAccount.FK_ExpPost, 
					"@Position",  _ExpPostAccount.Position, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpPostAccount.CreateDate));
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpPostAccount trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String FK_AccountId, String FK_ExpPost)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpPostAccount] WHERE FK_AccountId=@FK_AccountId and FK_ExpPost=@FK_ExpPost",
					"@FK_AccountId", FK_AccountId, 
					"@FK_ExpPost", FK_ExpPost);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpPostAccount trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpPostAccount _ExpPostAccount)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpPostAccount] WHERE FK_AccountId=@FK_AccountId and FK_ExpPost=@FK_ExpPost",
					"@FK_AccountId", _ExpPostAccount.FK_AccountId, 
					"@FK_ExpPost", _ExpPostAccount.FK_ExpPost);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpPostAccount trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpPostAccount] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpPostAccount trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpPostAccount> _ExpPostAccounts)
		{
			foreach (ExpPostAccount item in _ExpPostAccounts)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
