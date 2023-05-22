using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpcomment:IEXpcomment
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpcomment(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpComment từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpComment]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpComment từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpComment] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpComment từ Database
		/// </summary>
		public List<ExpComment> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpComment]");
				List<ExpComment> items = new List<ExpComment>();
				ExpComment item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpComment();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["UpdateDate"] != null && dr["UpdateDate"] != DBNull.Value)
					{
						item.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
					}
					if (dr["Comment"] != null && dr["Comment"] != DBNull.Value)
					{
						item.Comment = Convert.ToString(dr["Comment"]);
					}
					if (dr["Author"] != null && dr["Author"] != DBNull.Value)
					{
						item.Author = Convert.ToString(dr["Author"]);
					}
					if (dr["CommentType"] != null && dr["CommentType"] != DBNull.Value)
					{
						item.CommentType = Convert.ToString(dr["CommentType"]);
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
		/// Lấy danh sách ExpComment từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpComment> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpComment] A "+ condition,  parameters);
				List<ExpComment> items = new List<ExpComment>();
				ExpComment item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpComment();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["UpdateDate"] != null && dr["UpdateDate"] != DBNull.Value)
					{
						item.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
					}
					if (dr["Comment"] != null && dr["Comment"] != DBNull.Value)
					{
						item.Comment = Convert.ToString(dr["Comment"]);
					}
					if (dr["Author"] != null && dr["Author"] != DBNull.Value)
					{
						item.Author = Convert.ToString(dr["Author"]);
					}
					if (dr["CommentType"] != null && dr["CommentType"] != DBNull.Value)
					{
						item.CommentType = Convert.ToString(dr["CommentType"]);
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

		public List<ExpComment> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpComment] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpComment] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpComment>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpComment từ Database
		/// </summary>
		public ExpComment GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpComment] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpComment item=new ExpComment();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["UpdateDate"] != null && dr["UpdateDate"] != DBNull.Value)
						{
							item.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
						}
						if (dr["Comment"] != null && dr["Comment"] != DBNull.Value)
						{
							item.Comment = Convert.ToString(dr["Comment"]);
						}
						if (dr["Author"] != null && dr["Author"] != DBNull.Value)
						{
							item.Author = Convert.ToString(dr["Author"]);
						}
						if (dr["CommentType"] != null && dr["CommentType"] != DBNull.Value)
						{
							item.CommentType = Convert.ToString(dr["CommentType"]);
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
		/// Lấy một ExpComment đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpComment GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpComment] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpComment item=new ExpComment();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["UpdateDate"] != null && dr["UpdateDate"] != DBNull.Value)
						{
							item.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
						}
						if (dr["Comment"] != null && dr["Comment"] != DBNull.Value)
						{
							item.Comment = Convert.ToString(dr["Comment"]);
						}
						if (dr["Author"] != null && dr["Author"] != DBNull.Value)
						{
							item.Author = Convert.ToString(dr["Author"]);
						}
						if (dr["CommentType"] != null && dr["CommentType"] != DBNull.Value)
						{
							item.CommentType = Convert.ToString(dr["CommentType"]);
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

		public ExpComment GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpComment] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpComment>(ds);
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
		/// Thêm mới ExpComment vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpComment _ExpComment)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpComment](Id, BillCode, UpdateDate, Comment, Author, CommentType) VALUES(@Id, @BillCode, @UpdateDate, @Comment, @Author, @CommentType)", 
					"@Id",  _ExpComment.Id, 
					"@BillCode",  _ExpComment.BillCode, 
					"@UpdateDate", this._dataContext.ConvertDateString( _ExpComment.UpdateDate), 
					"@Comment",  _ExpComment.Comment, 
					"@Author",  _ExpComment.Author, 
					"@CommentType",  _ExpComment.CommentType);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpComment vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpComment> _ExpComments)
		{
			foreach (ExpComment item in _ExpComments)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpComment vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpComment _ExpComment, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpComment] SET Id=@Id, BillCode=@BillCode, UpdateDate=@UpdateDate, Comment=@Comment, Author=@Author, CommentType=@CommentType WHERE Id=@Id", 
					"@Id",  _ExpComment.Id, 
					"@BillCode",  _ExpComment.BillCode, 
					"@UpdateDate", this._dataContext.ConvertDateString( _ExpComment.UpdateDate), 
					"@Comment",  _ExpComment.Comment, 
					"@Author",  _ExpComment.Author, 
					"@CommentType",  _ExpComment.CommentType, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpComment vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpComment _ExpComment)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpComment] SET BillCode=@BillCode, UpdateDate=@UpdateDate, Comment=@Comment, Author=@Author, CommentType=@CommentType WHERE Id=@Id", 
					"@BillCode",  _ExpComment.BillCode, 
					"@UpdateDate", this._dataContext.ConvertDateString( _ExpComment.UpdateDate), 
					"@Comment",  _ExpComment.Comment, 
					"@Author",  _ExpComment.Author, 
					"@CommentType",  _ExpComment.CommentType, 
					"@Id", _ExpComment.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpComment vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpComment> _ExpComments)
		{
			foreach (ExpComment item in _ExpComments)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpComment vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpComment _ExpComment, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpComment] SET Id=@Id, BillCode=@BillCode, UpdateDate=@UpdateDate, Comment=@Comment, Author=@Author, CommentType=@CommentType "+ condition, 
					"@Id",  _ExpComment.Id, 
					"@BillCode",  _ExpComment.BillCode, 
					"@UpdateDate", this._dataContext.ConvertDateString( _ExpComment.UpdateDate), 
					"@Comment",  _ExpComment.Comment, 
					"@Author",  _ExpComment.Author, 
					"@CommentType",  _ExpComment.CommentType);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpComment trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpComment] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpComment trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpComment _ExpComment)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpComment] WHERE Id=@Id",
					"@Id", _ExpComment.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpComment trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpComment] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpComment trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpComment> _ExpComments)
		{
			foreach (ExpComment item in _ExpComments)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
