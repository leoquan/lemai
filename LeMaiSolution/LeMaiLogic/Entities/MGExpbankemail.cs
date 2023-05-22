using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpbankemail:IGExpbankemail
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpbankemail(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpBankEmail từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBankEmail]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpBankEmail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBankEmail] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpBankEmail từ Database
		/// </summary>
		public List<GExpBankEmail> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBankEmail]");
				List<GExpBankEmail> items = new List<GExpBankEmail>();
				GExpBankEmail item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpBankEmail();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FromEmail"] != null && dr["FromEmail"] != DBNull.Value)
					{
						item.FromEmail = Convert.ToString(dr["FromEmail"]);
					}
					if (dr["EmailDate"] != null && dr["EmailDate"] != DBNull.Value)
					{
						item.EmailDate = Convert.ToDateTime(dr["EmailDate"]);
					}
					if (dr["EmailId"] != null && dr["EmailId"] != DBNull.Value)
					{
						item.EmailId = Convert.ToString(dr["EmailId"]);
					}
					if (dr["TransactionId"] != null && dr["TransactionId"] != DBNull.Value)
					{
						item.TransactionId = Convert.ToString(dr["TransactionId"]);
					}
					if (dr["MoneyValue"] != null && dr["MoneyValue"] != DBNull.Value)
					{
						item.MoneyValue = Convert.ToDecimal(dr["MoneyValue"]);
					}
					if (dr["ContentBodyCode"] != null && dr["ContentBodyCode"] != DBNull.Value)
					{
						item.ContentBodyCode = Convert.ToString(dr["ContentBodyCode"]);
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
		/// Lấy danh sách GExpBankEmail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpBankEmail> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpBankEmail] A "+ condition,  parameters);
				List<GExpBankEmail> items = new List<GExpBankEmail>();
				GExpBankEmail item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpBankEmail();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FromEmail"] != null && dr["FromEmail"] != DBNull.Value)
					{
						item.FromEmail = Convert.ToString(dr["FromEmail"]);
					}
					if (dr["EmailDate"] != null && dr["EmailDate"] != DBNull.Value)
					{
						item.EmailDate = Convert.ToDateTime(dr["EmailDate"]);
					}
					if (dr["EmailId"] != null && dr["EmailId"] != DBNull.Value)
					{
						item.EmailId = Convert.ToString(dr["EmailId"]);
					}
					if (dr["TransactionId"] != null && dr["TransactionId"] != DBNull.Value)
					{
						item.TransactionId = Convert.ToString(dr["TransactionId"]);
					}
					if (dr["MoneyValue"] != null && dr["MoneyValue"] != DBNull.Value)
					{
						item.MoneyValue = Convert.ToDecimal(dr["MoneyValue"]);
					}
					if (dr["ContentBodyCode"] != null && dr["ContentBodyCode"] != DBNull.Value)
					{
						item.ContentBodyCode = Convert.ToString(dr["ContentBodyCode"]);
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

		public List<GExpBankEmail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpBankEmail] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpBankEmail] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpBankEmail>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpBankEmail từ Database
		/// </summary>
		public GExpBankEmail GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBankEmail] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpBankEmail item=new GExpBankEmail();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FromEmail"] != null && dr["FromEmail"] != DBNull.Value)
						{
							item.FromEmail = Convert.ToString(dr["FromEmail"]);
						}
						if (dr["EmailDate"] != null && dr["EmailDate"] != DBNull.Value)
						{
							item.EmailDate = Convert.ToDateTime(dr["EmailDate"]);
						}
						if (dr["EmailId"] != null && dr["EmailId"] != DBNull.Value)
						{
							item.EmailId = Convert.ToString(dr["EmailId"]);
						}
						if (dr["TransactionId"] != null && dr["TransactionId"] != DBNull.Value)
						{
							item.TransactionId = Convert.ToString(dr["TransactionId"]);
						}
						if (dr["MoneyValue"] != null && dr["MoneyValue"] != DBNull.Value)
						{
							item.MoneyValue = Convert.ToDecimal(dr["MoneyValue"]);
						}
						if (dr["ContentBodyCode"] != null && dr["ContentBodyCode"] != DBNull.Value)
						{
							item.ContentBodyCode = Convert.ToString(dr["ContentBodyCode"]);
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
		/// Lấy một GExpBankEmail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpBankEmail GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpBankEmail] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpBankEmail item=new GExpBankEmail();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FromEmail"] != null && dr["FromEmail"] != DBNull.Value)
						{
							item.FromEmail = Convert.ToString(dr["FromEmail"]);
						}
						if (dr["EmailDate"] != null && dr["EmailDate"] != DBNull.Value)
						{
							item.EmailDate = Convert.ToDateTime(dr["EmailDate"]);
						}
						if (dr["EmailId"] != null && dr["EmailId"] != DBNull.Value)
						{
							item.EmailId = Convert.ToString(dr["EmailId"]);
						}
						if (dr["TransactionId"] != null && dr["TransactionId"] != DBNull.Value)
						{
							item.TransactionId = Convert.ToString(dr["TransactionId"]);
						}
						if (dr["MoneyValue"] != null && dr["MoneyValue"] != DBNull.Value)
						{
							item.MoneyValue = Convert.ToDecimal(dr["MoneyValue"]);
						}
						if (dr["ContentBodyCode"] != null && dr["ContentBodyCode"] != DBNull.Value)
						{
							item.ContentBodyCode = Convert.ToString(dr["ContentBodyCode"]);
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

		public GExpBankEmail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpBankEmail] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpBankEmail>(ds);
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
		/// Thêm mới GExpBankEmail vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpBankEmail _GExpBankEmail)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpBankEmail](Id, FromEmail, EmailDate, EmailId, TransactionId, MoneyValue, ContentBodyCode) VALUES(@Id, @FromEmail, @EmailDate, @EmailId, @TransactionId, @MoneyValue, @ContentBodyCode)", 
					"@Id",  _GExpBankEmail.Id, 
					"@FromEmail",  _GExpBankEmail.FromEmail, 
					"@EmailDate", this._dataContext.ConvertDateString( _GExpBankEmail.EmailDate), 
					"@EmailId",  _GExpBankEmail.EmailId, 
					"@TransactionId",  _GExpBankEmail.TransactionId, 
					"@MoneyValue",  _GExpBankEmail.MoneyValue, 
					"@ContentBodyCode",  _GExpBankEmail.ContentBodyCode);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpBankEmail vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpBankEmail> _GExpBankEmails)
		{
			foreach (GExpBankEmail item in _GExpBankEmails)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpBankEmail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpBankEmail _GExpBankEmail, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpBankEmail] SET Id=@Id, FromEmail=@FromEmail, EmailDate=@EmailDate, EmailId=@EmailId, TransactionId=@TransactionId, MoneyValue=@MoneyValue, ContentBodyCode=@ContentBodyCode WHERE Id=@Id", 
					"@Id",  _GExpBankEmail.Id, 
					"@FromEmail",  _GExpBankEmail.FromEmail, 
					"@EmailDate", this._dataContext.ConvertDateString( _GExpBankEmail.EmailDate), 
					"@EmailId",  _GExpBankEmail.EmailId, 
					"@TransactionId",  _GExpBankEmail.TransactionId, 
					"@MoneyValue",  _GExpBankEmail.MoneyValue, 
					"@ContentBodyCode",  _GExpBankEmail.ContentBodyCode, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpBankEmail vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpBankEmail _GExpBankEmail)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpBankEmail] SET FromEmail=@FromEmail, EmailDate=@EmailDate, EmailId=@EmailId, TransactionId=@TransactionId, MoneyValue=@MoneyValue, ContentBodyCode=@ContentBodyCode WHERE Id=@Id", 
					"@FromEmail",  _GExpBankEmail.FromEmail, 
					"@EmailDate", this._dataContext.ConvertDateString( _GExpBankEmail.EmailDate), 
					"@EmailId",  _GExpBankEmail.EmailId, 
					"@TransactionId",  _GExpBankEmail.TransactionId, 
					"@MoneyValue",  _GExpBankEmail.MoneyValue, 
					"@ContentBodyCode",  _GExpBankEmail.ContentBodyCode, 
					"@Id", _GExpBankEmail.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpBankEmail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpBankEmail> _GExpBankEmails)
		{
			foreach (GExpBankEmail item in _GExpBankEmails)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpBankEmail vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpBankEmail _GExpBankEmail, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpBankEmail] SET Id=@Id, FromEmail=@FromEmail, EmailDate=@EmailDate, EmailId=@EmailId, TransactionId=@TransactionId, MoneyValue=@MoneyValue, ContentBodyCode=@ContentBodyCode "+ condition, 
					"@Id",  _GExpBankEmail.Id, 
					"@FromEmail",  _GExpBankEmail.FromEmail, 
					"@EmailDate", this._dataContext.ConvertDateString( _GExpBankEmail.EmailDate), 
					"@EmailId",  _GExpBankEmail.EmailId, 
					"@TransactionId",  _GExpBankEmail.TransactionId, 
					"@MoneyValue",  _GExpBankEmail.MoneyValue, 
					"@ContentBodyCode",  _GExpBankEmail.ContentBodyCode);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpBankEmail trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpBankEmail] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpBankEmail trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpBankEmail _GExpBankEmail)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpBankEmail] WHERE Id=@Id",
					"@Id", _GExpBankEmail.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpBankEmail trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpBankEmail] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpBankEmail trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpBankEmail> _GExpBankEmails)
		{
			foreach (GExpBankEmail item in _GExpBankEmails)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
