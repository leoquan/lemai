using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MWEbfaq:IWEbfaq
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MWEbfaq(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable WebFaq từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebFaq]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable WebFaq từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[WebFaq] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách WebFaq từ Database
		/// </summary>
		public List<WebFaq> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebFaq]");
				List<WebFaq> items = new List<WebFaq>();
				WebFaq item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebFaq();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Question"] != null && dr["Question"] != DBNull.Value)
					{
						item.Question = Convert.ToString(dr["Question"]);
					}
					if (dr["Answer"] != null && dr["Answer"] != DBNull.Value)
					{
						item.Answer = Convert.ToString(dr["Answer"]);
					}
					if (dr["AskName"] != null && dr["AskName"] != DBNull.Value)
					{
						item.AskName = Convert.ToString(dr["AskName"]);
					}
					if (dr["AskEmail"] != null && dr["AskEmail"] != DBNull.Value)
					{
						item.AskEmail = Convert.ToString(dr["AskEmail"]);
					}
					if (dr["AskSubject"] != null && dr["AskSubject"] != DBNull.Value)
					{
						item.AskSubject = Convert.ToString(dr["AskSubject"]);
					}
					if (dr["FK_Topic"] != null && dr["FK_Topic"] != DBNull.Value)
					{
						item.FK_Topic = Convert.ToString(dr["FK_Topic"]);
					}
					if (dr["IsShowOnWeb"] != null && dr["IsShowOnWeb"] != DBNull.Value)
					{
						item.IsShowOnWeb = Convert.ToBoolean(dr["IsShowOnWeb"]);
					}
					if (dr["BranchCode"] != null && dr["BranchCode"] != DBNull.Value)
					{
						item.BranchCode = Convert.ToString(dr["BranchCode"]);
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
		/// Lấy danh sách WebFaq từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<WebFaq> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebFaq] A "+ condition,  parameters);
				List<WebFaq> items = new List<WebFaq>();
				WebFaq item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new WebFaq();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Question"] != null && dr["Question"] != DBNull.Value)
					{
						item.Question = Convert.ToString(dr["Question"]);
					}
					if (dr["Answer"] != null && dr["Answer"] != DBNull.Value)
					{
						item.Answer = Convert.ToString(dr["Answer"]);
					}
					if (dr["AskName"] != null && dr["AskName"] != DBNull.Value)
					{
						item.AskName = Convert.ToString(dr["AskName"]);
					}
					if (dr["AskEmail"] != null && dr["AskEmail"] != DBNull.Value)
					{
						item.AskEmail = Convert.ToString(dr["AskEmail"]);
					}
					if (dr["AskSubject"] != null && dr["AskSubject"] != DBNull.Value)
					{
						item.AskSubject = Convert.ToString(dr["AskSubject"]);
					}
					if (dr["FK_Topic"] != null && dr["FK_Topic"] != DBNull.Value)
					{
						item.FK_Topic = Convert.ToString(dr["FK_Topic"]);
					}
					if (dr["IsShowOnWeb"] != null && dr["IsShowOnWeb"] != DBNull.Value)
					{
						item.IsShowOnWeb = Convert.ToBoolean(dr["IsShowOnWeb"]);
					}
					if (dr["BranchCode"] != null && dr["BranchCode"] != DBNull.Value)
					{
						item.BranchCode = Convert.ToString(dr["BranchCode"]);
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

		public List<WebFaq> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebFaq] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[WebFaq] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<WebFaq>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một WebFaq từ Database
		/// </summary>
		public WebFaq GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[WebFaq] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					WebFaq item=new WebFaq();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Question"] != null && dr["Question"] != DBNull.Value)
						{
							item.Question = Convert.ToString(dr["Question"]);
						}
						if (dr["Answer"] != null && dr["Answer"] != DBNull.Value)
						{
							item.Answer = Convert.ToString(dr["Answer"]);
						}
						if (dr["AskName"] != null && dr["AskName"] != DBNull.Value)
						{
							item.AskName = Convert.ToString(dr["AskName"]);
						}
						if (dr["AskEmail"] != null && dr["AskEmail"] != DBNull.Value)
						{
							item.AskEmail = Convert.ToString(dr["AskEmail"]);
						}
						if (dr["AskSubject"] != null && dr["AskSubject"] != DBNull.Value)
						{
							item.AskSubject = Convert.ToString(dr["AskSubject"]);
						}
						if (dr["FK_Topic"] != null && dr["FK_Topic"] != DBNull.Value)
						{
							item.FK_Topic = Convert.ToString(dr["FK_Topic"]);
						}
						if (dr["IsShowOnWeb"] != null && dr["IsShowOnWeb"] != DBNull.Value)
						{
							item.IsShowOnWeb = Convert.ToBoolean(dr["IsShowOnWeb"]);
						}
						if (dr["BranchCode"] != null && dr["BranchCode"] != DBNull.Value)
						{
							item.BranchCode = Convert.ToString(dr["BranchCode"]);
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
		/// Lấy một WebFaq đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public WebFaq GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[WebFaq] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					WebFaq item=new WebFaq();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Question"] != null && dr["Question"] != DBNull.Value)
						{
							item.Question = Convert.ToString(dr["Question"]);
						}
						if (dr["Answer"] != null && dr["Answer"] != DBNull.Value)
						{
							item.Answer = Convert.ToString(dr["Answer"]);
						}
						if (dr["AskName"] != null && dr["AskName"] != DBNull.Value)
						{
							item.AskName = Convert.ToString(dr["AskName"]);
						}
						if (dr["AskEmail"] != null && dr["AskEmail"] != DBNull.Value)
						{
							item.AskEmail = Convert.ToString(dr["AskEmail"]);
						}
						if (dr["AskSubject"] != null && dr["AskSubject"] != DBNull.Value)
						{
							item.AskSubject = Convert.ToString(dr["AskSubject"]);
						}
						if (dr["FK_Topic"] != null && dr["FK_Topic"] != DBNull.Value)
						{
							item.FK_Topic = Convert.ToString(dr["FK_Topic"]);
						}
						if (dr["IsShowOnWeb"] != null && dr["IsShowOnWeb"] != DBNull.Value)
						{
							item.IsShowOnWeb = Convert.ToBoolean(dr["IsShowOnWeb"]);
						}
						if (dr["BranchCode"] != null && dr["BranchCode"] != DBNull.Value)
						{
							item.BranchCode = Convert.ToString(dr["BranchCode"]);
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

		public WebFaq GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[WebFaq] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<WebFaq>(ds);
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
		/// Thêm mới WebFaq vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, WebFaq _WebFaq)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[WebFaq](Id, Question, Answer, AskName, AskEmail, AskSubject, FK_Topic, IsShowOnWeb, BranchCode) VALUES(@Id, @Question, @Answer, @AskName, @AskEmail, @AskSubject, @FK_Topic, @IsShowOnWeb, @BranchCode)", 
					"@Id",  _WebFaq.Id, 
					"@Question",  _WebFaq.Question, 
					"@Answer",  _WebFaq.Answer, 
					"@AskName",  _WebFaq.AskName, 
					"@AskEmail",  _WebFaq.AskEmail, 
					"@AskSubject",  _WebFaq.AskSubject, 
					"@FK_Topic",  _WebFaq.FK_Topic, 
					"@IsShowOnWeb",  _WebFaq.IsShowOnWeb, 
					"@BranchCode",  _WebFaq.BranchCode);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng WebFaq vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<WebFaq> _WebFaqs)
		{
			foreach (WebFaq item in _WebFaqs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebFaq vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, WebFaq _WebFaq, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebFaq] SET Id=@Id, Question=@Question, Answer=@Answer, AskName=@AskName, AskEmail=@AskEmail, AskSubject=@AskSubject, FK_Topic=@FK_Topic, IsShowOnWeb=@IsShowOnWeb, BranchCode=@BranchCode WHERE Id=@Id", 
					"@Id",  _WebFaq.Id, 
					"@Question",  _WebFaq.Question, 
					"@Answer",  _WebFaq.Answer, 
					"@AskName",  _WebFaq.AskName, 
					"@AskEmail",  _WebFaq.AskEmail, 
					"@AskSubject",  _WebFaq.AskSubject, 
					"@FK_Topic",  _WebFaq.FK_Topic, 
					"@IsShowOnWeb",  _WebFaq.IsShowOnWeb, 
					"@BranchCode",  _WebFaq.BranchCode, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật WebFaq vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, WebFaq _WebFaq)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebFaq] SET Question=@Question, Answer=@Answer, AskName=@AskName, AskEmail=@AskEmail, AskSubject=@AskSubject, FK_Topic=@FK_Topic, IsShowOnWeb=@IsShowOnWeb, BranchCode=@BranchCode WHERE Id=@Id", 
					"@Question",  _WebFaq.Question, 
					"@Answer",  _WebFaq.Answer, 
					"@AskName",  _WebFaq.AskName, 
					"@AskEmail",  _WebFaq.AskEmail, 
					"@AskSubject",  _WebFaq.AskSubject, 
					"@FK_Topic",  _WebFaq.FK_Topic, 
					"@IsShowOnWeb",  _WebFaq.IsShowOnWeb, 
					"@BranchCode",  _WebFaq.BranchCode, 
					"@Id", _WebFaq.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách WebFaq vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<WebFaq> _WebFaqs)
		{
			foreach (WebFaq item in _WebFaqs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật WebFaq vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, WebFaq _WebFaq, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[WebFaq] SET Id=@Id, Question=@Question, Answer=@Answer, AskName=@AskName, AskEmail=@AskEmail, AskSubject=@AskSubject, FK_Topic=@FK_Topic, IsShowOnWeb=@IsShowOnWeb, BranchCode=@BranchCode "+ condition, 
					"@Id",  _WebFaq.Id, 
					"@Question",  _WebFaq.Question, 
					"@Answer",  _WebFaq.Answer, 
					"@AskName",  _WebFaq.AskName, 
					"@AskEmail",  _WebFaq.AskEmail, 
					"@AskSubject",  _WebFaq.AskSubject, 
					"@FK_Topic",  _WebFaq.FK_Topic, 
					"@IsShowOnWeb",  _WebFaq.IsShowOnWeb, 
					"@BranchCode",  _WebFaq.BranchCode);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa WebFaq trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebFaq] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebFaq trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, WebFaq _WebFaq)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebFaq] WHERE Id=@Id",
					"@Id", _WebFaq.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebFaq trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[WebFaq] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa WebFaq trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<WebFaq> _WebFaqs)
		{
			foreach (WebFaq item in _WebFaqs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
