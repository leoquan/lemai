using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXptype:IEXptype
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXptype(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpType từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpType]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpType] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpType từ Database
		/// </summary>
		public List<ExpType> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpType]");
				List<ExpType> items = new List<ExpType>();
				ExpType item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpType();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenCachVanChuyen"] != null && dr["TenCachVanChuyen"] != DBNull.Value)
					{
						item.TenCachVanChuyen = Convert.ToString(dr["TenCachVanChuyen"]);
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
		/// Lấy danh sách ExpType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpType> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpType] A "+ condition,  parameters);
				List<ExpType> items = new List<ExpType>();
				ExpType item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpType();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenCachVanChuyen"] != null && dr["TenCachVanChuyen"] != DBNull.Value)
					{
						item.TenCachVanChuyen = Convert.ToString(dr["TenCachVanChuyen"]);
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

		public List<ExpType> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpType] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpType] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpType>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpType từ Database
		/// </summary>
		public ExpType GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpType] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpType item=new ExpType();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TenCachVanChuyen"] != null && dr["TenCachVanChuyen"] != DBNull.Value)
						{
							item.TenCachVanChuyen = Convert.ToString(dr["TenCachVanChuyen"]);
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
		/// Lấy một ExpType đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpType GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpType] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpType item=new ExpType();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TenCachVanChuyen"] != null && dr["TenCachVanChuyen"] != DBNull.Value)
						{
							item.TenCachVanChuyen = Convert.ToString(dr["TenCachVanChuyen"]);
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

		public ExpType GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpType] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpType>(ds);
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
		/// Thêm mới ExpType vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpType _ExpType)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpType](Id, TenCachVanChuyen) VALUES(@Id, @TenCachVanChuyen)", 
					"@Id",  _ExpType.Id, 
					"@TenCachVanChuyen",  _ExpType.TenCachVanChuyen);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpType vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpType> _ExpTypes)
		{
			foreach (ExpType item in _ExpTypes)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpType _ExpType, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpType] SET Id=@Id, TenCachVanChuyen=@TenCachVanChuyen WHERE Id=@Id", 
					"@Id",  _ExpType.Id, 
					"@TenCachVanChuyen",  _ExpType.TenCachVanChuyen, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpType vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpType _ExpType)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpType] SET TenCachVanChuyen=@TenCachVanChuyen WHERE Id=@Id", 
					"@TenCachVanChuyen",  _ExpType.TenCachVanChuyen, 
					"@Id", _ExpType.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpType> _ExpTypes)
		{
			foreach (ExpType item in _ExpTypes)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpType vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpType _ExpType, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpType] SET Id=@Id, TenCachVanChuyen=@TenCachVanChuyen "+ condition, 
					"@Id",  _ExpType.Id, 
					"@TenCachVanChuyen",  _ExpType.TenCachVanChuyen);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpType trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpType] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpType trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpType _ExpType)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpType] WHERE Id=@Id",
					"@Id", _ExpType.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpType trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpType] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpType trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpType> _ExpTypes)
		{
			foreach (ExpType item in _ExpTypes)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
