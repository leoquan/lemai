using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpcode:IGExpcode
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpcode(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpCode từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpCode]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpCode từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpCode] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpCode từ Database
		/// </summary>
		public List<GExpCode> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpCode]");
				List<GExpCode> items = new List<GExpCode>();
				GExpCode item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpCode();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["CurrentValue"] != null && dr["CurrentValue"] != DBNull.Value)
					{
						item.CurrentValue = Convert.ToInt32(dr["CurrentValue"]);
					}
					if (dr["Post"] != null && dr["Post"] != DBNull.Value)
					{
						item.Post = Convert.ToString(dr["Post"]);
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
		/// Lấy danh sách GExpCode từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpCode> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpCode] A "+ condition,  parameters);
				List<GExpCode> items = new List<GExpCode>();
				GExpCode item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpCode();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["CurrentValue"] != null && dr["CurrentValue"] != DBNull.Value)
					{
						item.CurrentValue = Convert.ToInt32(dr["CurrentValue"]);
					}
					if (dr["Post"] != null && dr["Post"] != DBNull.Value)
					{
						item.Post = Convert.ToString(dr["Post"]);
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

		public List<GExpCode> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpCode] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpCode] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpCode>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpCode từ Database
		/// </summary>
		public GExpCode GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpCode] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpCode item=new GExpCode();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["CurrentValue"] != null && dr["CurrentValue"] != DBNull.Value)
						{
							item.CurrentValue = Convert.ToInt32(dr["CurrentValue"]);
						}
						if (dr["Post"] != null && dr["Post"] != DBNull.Value)
						{
							item.Post = Convert.ToString(dr["Post"]);
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
		/// Lấy một GExpCode đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpCode GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpCode] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpCode item=new GExpCode();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["CurrentValue"] != null && dr["CurrentValue"] != DBNull.Value)
						{
							item.CurrentValue = Convert.ToInt32(dr["CurrentValue"]);
						}
						if (dr["Post"] != null && dr["Post"] != DBNull.Value)
						{
							item.Post = Convert.ToString(dr["Post"]);
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

		public GExpCode GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpCode] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpCode>(ds);
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
		/// Thêm mới GExpCode vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpCode _GExpCode)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpCode](Id, CurrentValue, Post) VALUES(@Id, @CurrentValue, @Post)", 
					"@Id",  _GExpCode.Id, 
					"@CurrentValue",  _GExpCode.CurrentValue, 
					"@Post",  _GExpCode.Post);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpCode vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpCode> _GExpCodes)
		{
			foreach (GExpCode item in _GExpCodes)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpCode vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpCode _GExpCode, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpCode] SET Id=@Id, CurrentValue=@CurrentValue, Post=@Post WHERE Id=@Id", 
					"@Id",  _GExpCode.Id, 
					"@CurrentValue",  _GExpCode.CurrentValue, 
					"@Post",  _GExpCode.Post, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpCode vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpCode _GExpCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpCode] SET CurrentValue=@CurrentValue, Post=@Post WHERE Id=@Id", 
					"@CurrentValue",  _GExpCode.CurrentValue, 
					"@Post",  _GExpCode.Post, 
					"@Id", _GExpCode.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpCode vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpCode> _GExpCodes)
		{
			foreach (GExpCode item in _GExpCodes)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpCode vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpCode _GExpCode, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpCode] SET Id=@Id, CurrentValue=@CurrentValue, Post=@Post "+ condition, 
					"@Id",  _GExpCode.Id, 
					"@CurrentValue",  _GExpCode.CurrentValue, 
					"@Post",  _GExpCode.Post);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpCode trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpCode] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpCode trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpCode _GExpCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpCode] WHERE Id=@Id",
					"@Id", _GExpCode.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpCode trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpCode] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpCode trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpCode> _GExpCodes)
		{
			foreach (GExpCode item in _GExpCodes)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
