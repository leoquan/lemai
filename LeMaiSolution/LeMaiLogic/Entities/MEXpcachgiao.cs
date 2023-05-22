using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpcachgiao:IEXpcachgiao
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpcachgiao(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpCachGiao từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCachGiao]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpCachGiao từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCachGiao] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpCachGiao từ Database
		/// </summary>
		public List<ExpCachGiao> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCachGiao]");
				List<ExpCachGiao> items = new List<ExpCachGiao>();
				ExpCachGiao item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpCachGiao();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenCachGiao"] != null && dr["TenCachGiao"] != DBNull.Value)
					{
						item.TenCachGiao = Convert.ToString(dr["TenCachGiao"]);
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
		/// Lấy danh sách ExpCachGiao từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpCachGiao> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpCachGiao] A "+ condition,  parameters);
				List<ExpCachGiao> items = new List<ExpCachGiao>();
				ExpCachGiao item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpCachGiao();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenCachGiao"] != null && dr["TenCachGiao"] != DBNull.Value)
					{
						item.TenCachGiao = Convert.ToString(dr["TenCachGiao"]);
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

		public List<ExpCachGiao> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpCachGiao] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpCachGiao] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpCachGiao>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpCachGiao từ Database
		/// </summary>
		public ExpCachGiao GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCachGiao] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpCachGiao item=new ExpCachGiao();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TenCachGiao"] != null && dr["TenCachGiao"] != DBNull.Value)
						{
							item.TenCachGiao = Convert.ToString(dr["TenCachGiao"]);
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
		/// Lấy một ExpCachGiao đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpCachGiao GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpCachGiao] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpCachGiao item=new ExpCachGiao();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TenCachGiao"] != null && dr["TenCachGiao"] != DBNull.Value)
						{
							item.TenCachGiao = Convert.ToString(dr["TenCachGiao"]);
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

		public ExpCachGiao GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpCachGiao] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpCachGiao>(ds);
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
		/// Thêm mới ExpCachGiao vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpCachGiao _ExpCachGiao)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpCachGiao](Id, TenCachGiao) VALUES(@Id, @TenCachGiao)", 
					"@Id",  _ExpCachGiao.Id, 
					"@TenCachGiao",  _ExpCachGiao.TenCachGiao);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpCachGiao vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpCachGiao> _ExpCachGiaos)
		{
			foreach (ExpCachGiao item in _ExpCachGiaos)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpCachGiao vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpCachGiao _ExpCachGiao, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCachGiao] SET Id=@Id, TenCachGiao=@TenCachGiao WHERE Id=@Id", 
					"@Id",  _ExpCachGiao.Id, 
					"@TenCachGiao",  _ExpCachGiao.TenCachGiao, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpCachGiao vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpCachGiao _ExpCachGiao)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCachGiao] SET TenCachGiao=@TenCachGiao WHERE Id=@Id", 
					"@TenCachGiao",  _ExpCachGiao.TenCachGiao, 
					"@Id", _ExpCachGiao.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpCachGiao vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpCachGiao> _ExpCachGiaos)
		{
			foreach (ExpCachGiao item in _ExpCachGiaos)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpCachGiao vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpCachGiao _ExpCachGiao, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCachGiao] SET Id=@Id, TenCachGiao=@TenCachGiao "+ condition, 
					"@Id",  _ExpCachGiao.Id, 
					"@TenCachGiao",  _ExpCachGiao.TenCachGiao);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpCachGiao trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCachGiao] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCachGiao trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpCachGiao _ExpCachGiao)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCachGiao] WHERE Id=@Id",
					"@Id", _ExpCachGiao.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCachGiao trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCachGiao] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCachGiao trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpCachGiao> _ExpCachGiaos)
		{
			foreach (ExpCachGiao item in _ExpCachGiaos)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
