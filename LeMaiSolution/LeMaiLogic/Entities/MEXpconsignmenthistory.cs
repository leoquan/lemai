using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpconsignmenthistory:IEXpconsignmenthistory
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpconsignmenthistory(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpConsignmentHistory từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignmentHistory]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpConsignmentHistory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignmentHistory] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpConsignmentHistory từ Database
		/// </summary>
		public List<ExpConsignmentHistory> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignmentHistory]");
				List<ExpConsignmentHistory> items = new List<ExpConsignmentHistory>();
				ExpConsignmentHistory item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpConsignmentHistory();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_ExpConsignment"] != null && dr["FK_ExpConsignment"] != DBNull.Value)
					{
						item.FK_ExpConsignment = Convert.ToString(dr["FK_ExpConsignment"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_ExpStatus"] != null && dr["FK_ExpStatus"] != DBNull.Value)
					{
						item.FK_ExpStatus = Convert.ToString(dr["FK_ExpStatus"]);
					}
					if (dr["FK_ExpPost"] != null && dr["FK_ExpPost"] != DBNull.Value)
					{
						item.FK_ExpPost = Convert.ToString(dr["FK_ExpPost"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
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
		/// Lấy danh sách ExpConsignmentHistory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpConsignmentHistory> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpConsignmentHistory] A "+ condition,  parameters);
				List<ExpConsignmentHistory> items = new List<ExpConsignmentHistory>();
				ExpConsignmentHistory item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpConsignmentHistory();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_ExpConsignment"] != null && dr["FK_ExpConsignment"] != DBNull.Value)
					{
						item.FK_ExpConsignment = Convert.ToString(dr["FK_ExpConsignment"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_ExpStatus"] != null && dr["FK_ExpStatus"] != DBNull.Value)
					{
						item.FK_ExpStatus = Convert.ToString(dr["FK_ExpStatus"]);
					}
					if (dr["FK_ExpPost"] != null && dr["FK_ExpPost"] != DBNull.Value)
					{
						item.FK_ExpPost = Convert.ToString(dr["FK_ExpPost"]);
					}
					if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
					{
						item.CreateBy = Convert.ToString(dr["CreateBy"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
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

		public List<ExpConsignmentHistory> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpConsignmentHistory] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpConsignmentHistory] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpConsignmentHistory>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpConsignmentHistory từ Database
		/// </summary>
		public ExpConsignmentHistory GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpConsignmentHistory] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpConsignmentHistory item=new ExpConsignmentHistory();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_ExpConsignment"] != null && dr["FK_ExpConsignment"] != DBNull.Value)
						{
							item.FK_ExpConsignment = Convert.ToString(dr["FK_ExpConsignment"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["FK_ExpStatus"] != null && dr["FK_ExpStatus"] != DBNull.Value)
						{
							item.FK_ExpStatus = Convert.ToString(dr["FK_ExpStatus"]);
						}
						if (dr["FK_ExpPost"] != null && dr["FK_ExpPost"] != DBNull.Value)
						{
							item.FK_ExpPost = Convert.ToString(dr["FK_ExpPost"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
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
		/// Lấy một ExpConsignmentHistory đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpConsignmentHistory GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpConsignmentHistory] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpConsignmentHistory item=new ExpConsignmentHistory();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_ExpConsignment"] != null && dr["FK_ExpConsignment"] != DBNull.Value)
						{
							item.FK_ExpConsignment = Convert.ToString(dr["FK_ExpConsignment"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["FK_ExpStatus"] != null && dr["FK_ExpStatus"] != DBNull.Value)
						{
							item.FK_ExpStatus = Convert.ToString(dr["FK_ExpStatus"]);
						}
						if (dr["FK_ExpPost"] != null && dr["FK_ExpPost"] != DBNull.Value)
						{
							item.FK_ExpPost = Convert.ToString(dr["FK_ExpPost"]);
						}
						if (dr["CreateBy"] != null && dr["CreateBy"] != DBNull.Value)
						{
							item.CreateBy = Convert.ToString(dr["CreateBy"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
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

		public ExpConsignmentHistory GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpConsignmentHistory] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpConsignmentHistory>(ds);
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
		/// Thêm mới ExpConsignmentHistory vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpConsignmentHistory _ExpConsignmentHistory)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpConsignmentHistory](Id, FK_ExpConsignment, CreateDate, FK_ExpStatus, FK_ExpPost, CreateBy, Note) VALUES(@Id, @FK_ExpConsignment, @CreateDate, @FK_ExpStatus, @FK_ExpPost, @CreateBy, @Note)", 
					"@Id",  _ExpConsignmentHistory.Id, 
					"@FK_ExpConsignment",  _ExpConsignmentHistory.FK_ExpConsignment, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpConsignmentHistory.CreateDate), 
					"@FK_ExpStatus",  _ExpConsignmentHistory.FK_ExpStatus, 
					"@FK_ExpPost",  _ExpConsignmentHistory.FK_ExpPost, 
					"@CreateBy",  _ExpConsignmentHistory.CreateBy, 
					"@Note",  _ExpConsignmentHistory.Note);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpConsignmentHistory vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpConsignmentHistory> _ExpConsignmentHistorys)
		{
			foreach (ExpConsignmentHistory item in _ExpConsignmentHistorys)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpConsignmentHistory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpConsignmentHistory _ExpConsignmentHistory, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpConsignmentHistory] SET Id=@Id, FK_ExpConsignment=@FK_ExpConsignment, CreateDate=@CreateDate, FK_ExpStatus=@FK_ExpStatus, FK_ExpPost=@FK_ExpPost, CreateBy=@CreateBy, Note=@Note WHERE Id=@Id", 
					"@Id",  _ExpConsignmentHistory.Id, 
					"@FK_ExpConsignment",  _ExpConsignmentHistory.FK_ExpConsignment, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpConsignmentHistory.CreateDate), 
					"@FK_ExpStatus",  _ExpConsignmentHistory.FK_ExpStatus, 
					"@FK_ExpPost",  _ExpConsignmentHistory.FK_ExpPost, 
					"@CreateBy",  _ExpConsignmentHistory.CreateBy, 
					"@Note",  _ExpConsignmentHistory.Note, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpConsignmentHistory vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpConsignmentHistory _ExpConsignmentHistory)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpConsignmentHistory] SET FK_ExpConsignment=@FK_ExpConsignment, CreateDate=@CreateDate, FK_ExpStatus=@FK_ExpStatus, FK_ExpPost=@FK_ExpPost, CreateBy=@CreateBy, Note=@Note WHERE Id=@Id", 
					"@FK_ExpConsignment",  _ExpConsignmentHistory.FK_ExpConsignment, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpConsignmentHistory.CreateDate), 
					"@FK_ExpStatus",  _ExpConsignmentHistory.FK_ExpStatus, 
					"@FK_ExpPost",  _ExpConsignmentHistory.FK_ExpPost, 
					"@CreateBy",  _ExpConsignmentHistory.CreateBy, 
					"@Note",  _ExpConsignmentHistory.Note, 
					"@Id", _ExpConsignmentHistory.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpConsignmentHistory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpConsignmentHistory> _ExpConsignmentHistorys)
		{
			foreach (ExpConsignmentHistory item in _ExpConsignmentHistorys)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpConsignmentHistory vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpConsignmentHistory _ExpConsignmentHistory, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpConsignmentHistory] SET Id=@Id, FK_ExpConsignment=@FK_ExpConsignment, CreateDate=@CreateDate, FK_ExpStatus=@FK_ExpStatus, FK_ExpPost=@FK_ExpPost, CreateBy=@CreateBy, Note=@Note "+ condition, 
					"@Id",  _ExpConsignmentHistory.Id, 
					"@FK_ExpConsignment",  _ExpConsignmentHistory.FK_ExpConsignment, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpConsignmentHistory.CreateDate), 
					"@FK_ExpStatus",  _ExpConsignmentHistory.FK_ExpStatus, 
					"@FK_ExpPost",  _ExpConsignmentHistory.FK_ExpPost, 
					"@CreateBy",  _ExpConsignmentHistory.CreateBy, 
					"@Note",  _ExpConsignmentHistory.Note);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpConsignmentHistory trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpConsignmentHistory] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpConsignmentHistory trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpConsignmentHistory _ExpConsignmentHistory)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpConsignmentHistory] WHERE Id=@Id",
					"@Id", _ExpConsignmentHistory.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpConsignmentHistory trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpConsignmentHistory] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpConsignmentHistory trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpConsignmentHistory> _ExpConsignmentHistorys)
		{
			foreach (ExpConsignmentHistory item in _ExpConsignmentHistorys)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
