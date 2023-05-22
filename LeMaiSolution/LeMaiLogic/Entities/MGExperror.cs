using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExperror:IGExperror
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExperror(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpError từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpError]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpError từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpError] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpError từ Database
		/// </summary>
		public List<GExpError> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpError]");
				List<GExpError> items = new List<GExpError>();
				GExpError item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpError();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["ErrorName"] != null && dr["ErrorName"] != DBNull.Value)
					{
						item.ErrorName = Convert.ToString(dr["ErrorName"]);
					}
					if (dr["Provider"] != null && dr["Provider"] != DBNull.Value)
					{
						item.Provider = Convert.ToString(dr["Provider"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
					{
						item.BT3Code = Convert.ToString(dr["BT3Code"]);
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
		/// Lấy danh sách GExpError từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpError> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpError] A "+ condition,  parameters);
				List<GExpError> items = new List<GExpError>();
				GExpError item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpError();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["ErrorName"] != null && dr["ErrorName"] != DBNull.Value)
					{
						item.ErrorName = Convert.ToString(dr["ErrorName"]);
					}
					if (dr["Provider"] != null && dr["Provider"] != DBNull.Value)
					{
						item.Provider = Convert.ToString(dr["Provider"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
					{
						item.BT3Code = Convert.ToString(dr["BT3Code"]);
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

		public List<GExpError> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpError] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpError] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpError>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpError từ Database
		/// </summary>
		public GExpError GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpError] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpError item=new GExpError();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["ErrorName"] != null && dr["ErrorName"] != DBNull.Value)
						{
							item.ErrorName = Convert.ToString(dr["ErrorName"]);
						}
						if (dr["Provider"] != null && dr["Provider"] != DBNull.Value)
						{
							item.Provider = Convert.ToString(dr["Provider"]);
						}
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
						{
							item.BT3Code = Convert.ToString(dr["BT3Code"]);
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
		/// Lấy một GExpError đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpError GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpError] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpError item=new GExpError();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["ErrorName"] != null && dr["ErrorName"] != DBNull.Value)
						{
							item.ErrorName = Convert.ToString(dr["ErrorName"]);
						}
						if (dr["Provider"] != null && dr["Provider"] != DBNull.Value)
						{
							item.Provider = Convert.ToString(dr["Provider"]);
						}
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
						{
							item.BT3Code = Convert.ToString(dr["BT3Code"]);
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

		public GExpError GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpError] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpError>(ds);
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
		/// Thêm mới GExpError vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpError _GExpError)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpError](Id, ErrorName, Provider, BillCode, BT3Code, Note) VALUES(@Id, @ErrorName, @Provider, @BillCode, @BT3Code, @Note)", 
					"@Id",  _GExpError.Id, 
					"@ErrorName",  _GExpError.ErrorName, 
					"@Provider",  _GExpError.Provider, 
					"@BillCode",  _GExpError.BillCode, 
					"@BT3Code",  _GExpError.BT3Code, 
					"@Note",  _GExpError.Note);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpError vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpError> _GExpErrors)
		{
			foreach (GExpError item in _GExpErrors)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpError vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpError _GExpError, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpError] SET Id=@Id, ErrorName=@ErrorName, Provider=@Provider, BillCode=@BillCode, BT3Code=@BT3Code, Note=@Note WHERE Id=@Id", 
					"@Id",  _GExpError.Id, 
					"@ErrorName",  _GExpError.ErrorName, 
					"@Provider",  _GExpError.Provider, 
					"@BillCode",  _GExpError.BillCode, 
					"@BT3Code",  _GExpError.BT3Code, 
					"@Note",  _GExpError.Note, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpError vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpError _GExpError)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpError] SET ErrorName=@ErrorName, Provider=@Provider, BillCode=@BillCode, BT3Code=@BT3Code, Note=@Note WHERE Id=@Id", 
					"@ErrorName",  _GExpError.ErrorName, 
					"@Provider",  _GExpError.Provider, 
					"@BillCode",  _GExpError.BillCode, 
					"@BT3Code",  _GExpError.BT3Code, 
					"@Note",  _GExpError.Note, 
					"@Id", _GExpError.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpError vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpError> _GExpErrors)
		{
			foreach (GExpError item in _GExpErrors)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpError vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpError _GExpError, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpError] SET Id=@Id, ErrorName=@ErrorName, Provider=@Provider, BillCode=@BillCode, BT3Code=@BT3Code, Note=@Note "+ condition, 
					"@Id",  _GExpError.Id, 
					"@ErrorName",  _GExpError.ErrorName, 
					"@Provider",  _GExpError.Provider, 
					"@BillCode",  _GExpError.BillCode, 
					"@BT3Code",  _GExpError.BT3Code, 
					"@Note",  _GExpError.Note);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpError trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpError] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpError trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpError _GExpError)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpError] WHERE Id=@Id",
					"@Id", _GExpError.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpError trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpError] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpError trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpError> _GExpErrors)
		{
			foreach (GExpError item in _GExpErrors)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
