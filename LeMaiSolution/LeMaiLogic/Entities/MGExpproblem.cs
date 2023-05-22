using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpproblem:IGExpproblem
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpproblem(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpProblem từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProblem]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpProblem từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProblem] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpProblem từ Database
		/// </summary>
		public List<GExpProblem> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProblem]");
				List<GExpProblem> items = new List<GExpProblem>();
				GExpProblem item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpProblem();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["RegisterDate"] != null && dr["RegisterDate"] != DBNull.Value)
					{
						item.RegisterDate = Convert.ToDateTime(dr["RegisterDate"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["UserId"] != null && dr["UserId"] != DBNull.Value)
					{
						item.UserId = Convert.ToString(dr["UserId"]);
					}
					if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
					{
						item.FullName = Convert.ToString(dr["FullName"]);
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
		/// Lấy danh sách GExpProblem từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpProblem> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpProblem] A "+ condition,  parameters);
				List<GExpProblem> items = new List<GExpProblem>();
				GExpProblem item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpProblem();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["RegisterDate"] != null && dr["RegisterDate"] != DBNull.Value)
					{
						item.RegisterDate = Convert.ToDateTime(dr["RegisterDate"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["UserId"] != null && dr["UserId"] != DBNull.Value)
					{
						item.UserId = Convert.ToString(dr["UserId"]);
					}
					if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
					{
						item.FullName = Convert.ToString(dr["FullName"]);
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

		public List<GExpProblem> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpProblem] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpProblem] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpProblem>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpProblem từ Database
		/// </summary>
		public GExpProblem GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProblem] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpProblem item=new GExpProblem();
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
						if (dr["RegisterDate"] != null && dr["RegisterDate"] != DBNull.Value)
						{
							item.RegisterDate = Convert.ToDateTime(dr["RegisterDate"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["UserId"] != null && dr["UserId"] != DBNull.Value)
						{
							item.UserId = Convert.ToString(dr["UserId"]);
						}
						if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
						{
							item.FullName = Convert.ToString(dr["FullName"]);
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
		/// Lấy một GExpProblem đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpProblem GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpProblem] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpProblem item=new GExpProblem();
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
						if (dr["RegisterDate"] != null && dr["RegisterDate"] != DBNull.Value)
						{
							item.RegisterDate = Convert.ToDateTime(dr["RegisterDate"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["UserId"] != null && dr["UserId"] != DBNull.Value)
						{
							item.UserId = Convert.ToString(dr["UserId"]);
						}
						if (dr["FullName"] != null && dr["FullName"] != DBNull.Value)
						{
							item.FullName = Convert.ToString(dr["FullName"]);
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

		public GExpProblem GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpProblem] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpProblem>(ds);
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
		/// Thêm mới GExpProblem vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpProblem _GExpProblem)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpProblem](Id, BillCode, RegisterDate, Note, UserId, FullName) VALUES(@Id, @BillCode, @RegisterDate, @Note, @UserId, @FullName)", 
					"@Id",  _GExpProblem.Id, 
					"@BillCode",  _GExpProblem.BillCode, 
					"@RegisterDate", this._dataContext.ConvertDateString( _GExpProblem.RegisterDate), 
					"@Note",  _GExpProblem.Note, 
					"@UserId",  _GExpProblem.UserId, 
					"@FullName",  _GExpProblem.FullName);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpProblem vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpProblem> _GExpProblems)
		{
			foreach (GExpProblem item in _GExpProblems)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpProblem vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpProblem _GExpProblem, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProblem] SET Id=@Id, BillCode=@BillCode, RegisterDate=@RegisterDate, Note=@Note, UserId=@UserId, FullName=@FullName WHERE Id=@Id", 
					"@Id",  _GExpProblem.Id, 
					"@BillCode",  _GExpProblem.BillCode, 
					"@RegisterDate", this._dataContext.ConvertDateString( _GExpProblem.RegisterDate), 
					"@Note",  _GExpProblem.Note, 
					"@UserId",  _GExpProblem.UserId, 
					"@FullName",  _GExpProblem.FullName, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpProblem vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpProblem _GExpProblem)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProblem] SET BillCode=@BillCode, RegisterDate=@RegisterDate, Note=@Note, UserId=@UserId, FullName=@FullName WHERE Id=@Id", 
					"@BillCode",  _GExpProblem.BillCode, 
					"@RegisterDate", this._dataContext.ConvertDateString( _GExpProblem.RegisterDate), 
					"@Note",  _GExpProblem.Note, 
					"@UserId",  _GExpProblem.UserId, 
					"@FullName",  _GExpProblem.FullName, 
					"@Id", _GExpProblem.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpProblem vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpProblem> _GExpProblems)
		{
			foreach (GExpProblem item in _GExpProblems)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpProblem vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpProblem _GExpProblem, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProblem] SET Id=@Id, BillCode=@BillCode, RegisterDate=@RegisterDate, Note=@Note, UserId=@UserId, FullName=@FullName "+ condition, 
					"@Id",  _GExpProblem.Id, 
					"@BillCode",  _GExpProblem.BillCode, 
					"@RegisterDate", this._dataContext.ConvertDateString( _GExpProblem.RegisterDate), 
					"@Note",  _GExpProblem.Note, 
					"@UserId",  _GExpProblem.UserId, 
					"@FullName",  _GExpProblem.FullName);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpProblem trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProblem] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProblem trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpProblem _GExpProblem)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProblem] WHERE Id=@Id",
					"@Id", _GExpProblem.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProblem trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProblem] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProblem trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpProblem> _GExpProblems)
		{
			foreach (GExpProblem item in _GExpProblems)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
