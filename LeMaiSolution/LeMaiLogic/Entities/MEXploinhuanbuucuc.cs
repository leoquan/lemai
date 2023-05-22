using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXploinhuanbuucuc:IEXploinhuanbuucuc
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXploinhuanbuucuc(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpLoiNhuanBuuCuc từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpLoiNhuanBuuCuc]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpLoiNhuanBuuCuc từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpLoiNhuanBuuCuc] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpLoiNhuanBuuCuc từ Database
		/// </summary>
		public List<ExpLoiNhuanBuuCuc> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpLoiNhuanBuuCuc]");
				List<ExpLoiNhuanBuuCuc> items = new List<ExpLoiNhuanBuuCuc>();
				ExpLoiNhuanBuuCuc item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpLoiNhuanBuuCuc();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["PostName"] != null && dr["PostName"] != DBNull.Value)
					{
						item.PostName = Convert.ToString(dr["PostName"]);
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
		/// Lấy danh sách ExpLoiNhuanBuuCuc từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpLoiNhuanBuuCuc> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpLoiNhuanBuuCuc] A "+ condition,  parameters);
				List<ExpLoiNhuanBuuCuc> items = new List<ExpLoiNhuanBuuCuc>();
				ExpLoiNhuanBuuCuc item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpLoiNhuanBuuCuc();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["PostName"] != null && dr["PostName"] != DBNull.Value)
					{
						item.PostName = Convert.ToString(dr["PostName"]);
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

		public List<ExpLoiNhuanBuuCuc> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpLoiNhuanBuuCuc] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpLoiNhuanBuuCuc] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpLoiNhuanBuuCuc>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpLoiNhuanBuuCuc từ Database
		/// </summary>
		public ExpLoiNhuanBuuCuc GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpLoiNhuanBuuCuc] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpLoiNhuanBuuCuc item=new ExpLoiNhuanBuuCuc();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["PostName"] != null && dr["PostName"] != DBNull.Value)
						{
							item.PostName = Convert.ToString(dr["PostName"]);
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
		/// Lấy một ExpLoiNhuanBuuCuc đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpLoiNhuanBuuCuc GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpLoiNhuanBuuCuc] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpLoiNhuanBuuCuc item=new ExpLoiNhuanBuuCuc();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["PostName"] != null && dr["PostName"] != DBNull.Value)
						{
							item.PostName = Convert.ToString(dr["PostName"]);
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

		public ExpLoiNhuanBuuCuc GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpLoiNhuanBuuCuc] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpLoiNhuanBuuCuc>(ds);
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
		/// Thêm mới ExpLoiNhuanBuuCuc vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpLoiNhuanBuuCuc _ExpLoiNhuanBuuCuc)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpLoiNhuanBuuCuc](Id, PostName) VALUES(@Id, @PostName)", 
					"@Id",  _ExpLoiNhuanBuuCuc.Id, 
					"@PostName",  _ExpLoiNhuanBuuCuc.PostName);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpLoiNhuanBuuCuc vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpLoiNhuanBuuCuc> _ExpLoiNhuanBuuCucs)
		{
			foreach (ExpLoiNhuanBuuCuc item in _ExpLoiNhuanBuuCucs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpLoiNhuanBuuCuc vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpLoiNhuanBuuCuc _ExpLoiNhuanBuuCuc, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpLoiNhuanBuuCuc] SET Id=@Id, PostName=@PostName WHERE Id=@Id", 
					"@Id",  _ExpLoiNhuanBuuCuc.Id, 
					"@PostName",  _ExpLoiNhuanBuuCuc.PostName, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpLoiNhuanBuuCuc vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpLoiNhuanBuuCuc _ExpLoiNhuanBuuCuc)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpLoiNhuanBuuCuc] SET PostName=@PostName WHERE Id=@Id", 
					"@PostName",  _ExpLoiNhuanBuuCuc.PostName, 
					"@Id", _ExpLoiNhuanBuuCuc.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpLoiNhuanBuuCuc vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpLoiNhuanBuuCuc> _ExpLoiNhuanBuuCucs)
		{
			foreach (ExpLoiNhuanBuuCuc item in _ExpLoiNhuanBuuCucs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpLoiNhuanBuuCuc vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpLoiNhuanBuuCuc _ExpLoiNhuanBuuCuc, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpLoiNhuanBuuCuc] SET Id=@Id, PostName=@PostName "+ condition, 
					"@Id",  _ExpLoiNhuanBuuCuc.Id, 
					"@PostName",  _ExpLoiNhuanBuuCuc.PostName);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpLoiNhuanBuuCuc trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpLoiNhuanBuuCuc] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpLoiNhuanBuuCuc trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpLoiNhuanBuuCuc _ExpLoiNhuanBuuCuc)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpLoiNhuanBuuCuc] WHERE Id=@Id",
					"@Id", _ExpLoiNhuanBuuCuc.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpLoiNhuanBuuCuc trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpLoiNhuanBuuCuc] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpLoiNhuanBuuCuc trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpLoiNhuanBuuCuc> _ExpLoiNhuanBuuCucs)
		{
			foreach (ExpLoiNhuanBuuCuc item in _ExpLoiNhuanBuuCucs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
