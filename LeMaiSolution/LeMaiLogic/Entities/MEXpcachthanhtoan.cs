using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpcachthanhtoan:IEXpcachthanhtoan
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpcachthanhtoan(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpCachThanhToan từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCachThanhToan]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpCachThanhToan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCachThanhToan] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpCachThanhToan từ Database
		/// </summary>
		public List<ExpCachThanhToan> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCachThanhToan]");
				List<ExpCachThanhToan> items = new List<ExpCachThanhToan>();
				ExpCachThanhToan item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpCachThanhToan();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["CachThanhToan"] != null && dr["CachThanhToan"] != DBNull.Value)
					{
						item.CachThanhToan = Convert.ToString(dr["CachThanhToan"]);
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
		/// Lấy danh sách ExpCachThanhToan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpCachThanhToan> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpCachThanhToan] A "+ condition,  parameters);
				List<ExpCachThanhToan> items = new List<ExpCachThanhToan>();
				ExpCachThanhToan item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpCachThanhToan();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["CachThanhToan"] != null && dr["CachThanhToan"] != DBNull.Value)
					{
						item.CachThanhToan = Convert.ToString(dr["CachThanhToan"]);
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

		public List<ExpCachThanhToan> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpCachThanhToan] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpCachThanhToan] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpCachThanhToan>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpCachThanhToan từ Database
		/// </summary>
		public ExpCachThanhToan GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCachThanhToan] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpCachThanhToan item=new ExpCachThanhToan();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["CachThanhToan"] != null && dr["CachThanhToan"] != DBNull.Value)
						{
							item.CachThanhToan = Convert.ToString(dr["CachThanhToan"]);
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
		/// Lấy một ExpCachThanhToan đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpCachThanhToan GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpCachThanhToan] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpCachThanhToan item=new ExpCachThanhToan();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["CachThanhToan"] != null && dr["CachThanhToan"] != DBNull.Value)
						{
							item.CachThanhToan = Convert.ToString(dr["CachThanhToan"]);
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

		public ExpCachThanhToan GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpCachThanhToan] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpCachThanhToan>(ds);
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
		/// Thêm mới ExpCachThanhToan vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpCachThanhToan _ExpCachThanhToan)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpCachThanhToan](Id, CachThanhToan) VALUES(@Id, @CachThanhToan)", 
					"@Id",  _ExpCachThanhToan.Id, 
					"@CachThanhToan",  _ExpCachThanhToan.CachThanhToan);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpCachThanhToan vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpCachThanhToan> _ExpCachThanhToans)
		{
			foreach (ExpCachThanhToan item in _ExpCachThanhToans)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpCachThanhToan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpCachThanhToan _ExpCachThanhToan, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCachThanhToan] SET Id=@Id, CachThanhToan=@CachThanhToan WHERE Id=@Id", 
					"@Id",  _ExpCachThanhToan.Id, 
					"@CachThanhToan",  _ExpCachThanhToan.CachThanhToan, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpCachThanhToan vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpCachThanhToan _ExpCachThanhToan)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCachThanhToan] SET CachThanhToan=@CachThanhToan WHERE Id=@Id", 
					"@CachThanhToan",  _ExpCachThanhToan.CachThanhToan, 
					"@Id", _ExpCachThanhToan.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpCachThanhToan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpCachThanhToan> _ExpCachThanhToans)
		{
			foreach (ExpCachThanhToan item in _ExpCachThanhToans)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpCachThanhToan vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpCachThanhToan _ExpCachThanhToan, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCachThanhToan] SET Id=@Id, CachThanhToan=@CachThanhToan "+ condition, 
					"@Id",  _ExpCachThanhToan.Id, 
					"@CachThanhToan",  _ExpCachThanhToan.CachThanhToan);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpCachThanhToan trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCachThanhToan] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCachThanhToan trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpCachThanhToan _ExpCachThanhToan)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCachThanhToan] WHERE Id=@Id",
					"@Id", _ExpCachThanhToan.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCachThanhToan trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCachThanhToan] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCachThanhToan trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpCachThanhToan> _ExpCachThanhToans)
		{
			foreach (ExpCachThanhToan item in _ExpCachThanhToans)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
