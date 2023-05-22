using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpinternal:IEXpinternal
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpinternal(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpInternal từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpInternal]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpInternal từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpInternal] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpInternal từ Database
		/// </summary>
		public List<ExpInternal> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpInternal]");
				List<ExpInternal> items = new List<ExpInternal>();
				ExpInternal item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpInternal();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Post"] != null && dr["Post"] != DBNull.Value)
					{
						item.Post = Convert.ToString(dr["Post"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
					{
						item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
					}
					if (dr["FIRST_CODE"] != null && dr["FIRST_CODE"] != DBNull.Value)
					{
						item.FIRST_CODE = Convert.ToString(dr["FIRST_CODE"]);
					}
					if (dr["KEY_DATE"] != null && dr["KEY_DATE"] != DBNull.Value)
					{
						item.KEY_DATE = Convert.ToString(dr["KEY_DATE"]);
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
		/// Lấy danh sách ExpInternal từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpInternal> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpInternal] A "+ condition,  parameters);
				List<ExpInternal> items = new List<ExpInternal>();
				ExpInternal item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpInternal();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Post"] != null && dr["Post"] != DBNull.Value)
					{
						item.Post = Convert.ToString(dr["Post"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
					{
						item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
					}
					if (dr["FIRST_CODE"] != null && dr["FIRST_CODE"] != DBNull.Value)
					{
						item.FIRST_CODE = Convert.ToString(dr["FIRST_CODE"]);
					}
					if (dr["KEY_DATE"] != null && dr["KEY_DATE"] != DBNull.Value)
					{
						item.KEY_DATE = Convert.ToString(dr["KEY_DATE"]);
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

		public List<ExpInternal> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpInternal] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpInternal] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpInternal>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpInternal từ Database
		/// </summary>
		public ExpInternal GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpInternal] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpInternal item=new ExpInternal();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Post"] != null && dr["Post"] != DBNull.Value)
						{
							item.Post = Convert.ToString(dr["Post"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
						{
							item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
						}
						if (dr["FIRST_CODE"] != null && dr["FIRST_CODE"] != DBNull.Value)
						{
							item.FIRST_CODE = Convert.ToString(dr["FIRST_CODE"]);
						}
						if (dr["KEY_DATE"] != null && dr["KEY_DATE"] != DBNull.Value)
						{
							item.KEY_DATE = Convert.ToString(dr["KEY_DATE"]);
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
		/// Lấy một ExpInternal đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpInternal GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpInternal] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpInternal item=new ExpInternal();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Post"] != null && dr["Post"] != DBNull.Value)
						{
							item.Post = Convert.ToString(dr["Post"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["BILL_CODE"] != null && dr["BILL_CODE"] != DBNull.Value)
						{
							item.BILL_CODE = Convert.ToString(dr["BILL_CODE"]);
						}
						if (dr["FIRST_CODE"] != null && dr["FIRST_CODE"] != DBNull.Value)
						{
							item.FIRST_CODE = Convert.ToString(dr["FIRST_CODE"]);
						}
						if (dr["KEY_DATE"] != null && dr["KEY_DATE"] != DBNull.Value)
						{
							item.KEY_DATE = Convert.ToString(dr["KEY_DATE"]);
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

		public ExpInternal GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpInternal] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpInternal>(ds);
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
		/// Thêm mới ExpInternal vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpInternal _ExpInternal)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpInternal](Id, Post, CreateDate, CreateBy, Note, BILL_CODE, FIRST_CODE, KEY_DATE) VALUES(@Id, @Post, @CreateDate, @CreateBy, @Note, @BILL_CODE, @FIRST_CODE, @KEY_DATE)", 
					"@Id",  _ExpInternal.Id, 
					"@Post",  _ExpInternal.Post, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpInternal.CreateDate), 
					"@CreateBy",  _ExpInternal.CreateBy, 
					"@Note",  _ExpInternal.Note, 
					"@BILL_CODE",  _ExpInternal.BILL_CODE, 
					"@FIRST_CODE",  _ExpInternal.FIRST_CODE, 
					"@KEY_DATE",  _ExpInternal.KEY_DATE);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpInternal vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpInternal> _ExpInternals)
		{
			foreach (ExpInternal item in _ExpInternals)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpInternal vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpInternal _ExpInternal, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpInternal] SET Id=@Id, Post=@Post, CreateDate=@CreateDate, CreateBy=@CreateBy, Note=@Note, BILL_CODE=@BILL_CODE, FIRST_CODE=@FIRST_CODE, KEY_DATE=@KEY_DATE WHERE Id=@Id", 
					"@Id",  _ExpInternal.Id, 
					"@Post",  _ExpInternal.Post, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpInternal.CreateDate), 
					"@CreateBy",  _ExpInternal.CreateBy, 
					"@Note",  _ExpInternal.Note, 
					"@BILL_CODE",  _ExpInternal.BILL_CODE, 
					"@FIRST_CODE",  _ExpInternal.FIRST_CODE, 
					"@KEY_DATE",  _ExpInternal.KEY_DATE, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpInternal vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpInternal _ExpInternal)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpInternal] SET Post=@Post, CreateDate=@CreateDate, CreateBy=@CreateBy, Note=@Note, BILL_CODE=@BILL_CODE, FIRST_CODE=@FIRST_CODE, KEY_DATE=@KEY_DATE WHERE Id=@Id", 
					"@Post",  _ExpInternal.Post, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpInternal.CreateDate), 
					"@CreateBy",  _ExpInternal.CreateBy, 
					"@Note",  _ExpInternal.Note, 
					"@BILL_CODE",  _ExpInternal.BILL_CODE, 
					"@FIRST_CODE",  _ExpInternal.FIRST_CODE, 
					"@KEY_DATE",  _ExpInternal.KEY_DATE, 
					"@Id", _ExpInternal.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpInternal vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpInternal> _ExpInternals)
		{
			foreach (ExpInternal item in _ExpInternals)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpInternal vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpInternal _ExpInternal, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpInternal] SET Id=@Id, Post=@Post, CreateDate=@CreateDate, CreateBy=@CreateBy, Note=@Note, BILL_CODE=@BILL_CODE, FIRST_CODE=@FIRST_CODE, KEY_DATE=@KEY_DATE "+ condition, 
					"@Id",  _ExpInternal.Id, 
					"@Post",  _ExpInternal.Post, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpInternal.CreateDate), 
					"@CreateBy",  _ExpInternal.CreateBy, 
					"@Note",  _ExpInternal.Note, 
					"@BILL_CODE",  _ExpInternal.BILL_CODE, 
					"@FIRST_CODE",  _ExpInternal.FIRST_CODE, 
					"@KEY_DATE",  _ExpInternal.KEY_DATE);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpInternal trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpInternal] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpInternal trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpInternal _ExpInternal)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpInternal] WHERE Id=@Id",
					"@Id", _ExpInternal.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpInternal trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpInternal] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpInternal trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpInternal> _ExpInternals)
		{
			foreach (ExpInternal item in _ExpInternals)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
