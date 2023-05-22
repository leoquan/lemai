using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXploaimathang:IEXploaimathang
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXploaimathang(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpLoaiMatHang từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpLoaiMatHang]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpLoaiMatHang từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpLoaiMatHang] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpLoaiMatHang từ Database
		/// </summary>
		public List<ExpLoaiMatHang> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpLoaiMatHang]");
				List<ExpLoaiMatHang> items = new List<ExpLoaiMatHang>();
				ExpLoaiMatHang item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpLoaiMatHang();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenLoaiMatHang"] != null && dr["TenLoaiMatHang"] != DBNull.Value)
					{
						item.TenLoaiMatHang = Convert.ToString(dr["TenLoaiMatHang"]);
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
		/// Lấy danh sách ExpLoaiMatHang từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpLoaiMatHang> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpLoaiMatHang] A "+ condition,  parameters);
				List<ExpLoaiMatHang> items = new List<ExpLoaiMatHang>();
				ExpLoaiMatHang item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpLoaiMatHang();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenLoaiMatHang"] != null && dr["TenLoaiMatHang"] != DBNull.Value)
					{
						item.TenLoaiMatHang = Convert.ToString(dr["TenLoaiMatHang"]);
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

		public List<ExpLoaiMatHang> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpLoaiMatHang] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpLoaiMatHang] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpLoaiMatHang>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpLoaiMatHang từ Database
		/// </summary>
		public ExpLoaiMatHang GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpLoaiMatHang] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpLoaiMatHang item=new ExpLoaiMatHang();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TenLoaiMatHang"] != null && dr["TenLoaiMatHang"] != DBNull.Value)
						{
							item.TenLoaiMatHang = Convert.ToString(dr["TenLoaiMatHang"]);
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
		/// Lấy một ExpLoaiMatHang đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpLoaiMatHang GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpLoaiMatHang] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpLoaiMatHang item=new ExpLoaiMatHang();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TenLoaiMatHang"] != null && dr["TenLoaiMatHang"] != DBNull.Value)
						{
							item.TenLoaiMatHang = Convert.ToString(dr["TenLoaiMatHang"]);
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

		public ExpLoaiMatHang GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpLoaiMatHang] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpLoaiMatHang>(ds);
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
		/// Thêm mới ExpLoaiMatHang vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpLoaiMatHang _ExpLoaiMatHang)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpLoaiMatHang](Id, TenLoaiMatHang) VALUES(@Id, @TenLoaiMatHang)", 
					"@Id",  _ExpLoaiMatHang.Id, 
					"@TenLoaiMatHang",  _ExpLoaiMatHang.TenLoaiMatHang);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpLoaiMatHang vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpLoaiMatHang> _ExpLoaiMatHangs)
		{
			foreach (ExpLoaiMatHang item in _ExpLoaiMatHangs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpLoaiMatHang vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpLoaiMatHang _ExpLoaiMatHang, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpLoaiMatHang] SET Id=@Id, TenLoaiMatHang=@TenLoaiMatHang WHERE Id=@Id", 
					"@Id",  _ExpLoaiMatHang.Id, 
					"@TenLoaiMatHang",  _ExpLoaiMatHang.TenLoaiMatHang, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpLoaiMatHang vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpLoaiMatHang _ExpLoaiMatHang)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpLoaiMatHang] SET TenLoaiMatHang=@TenLoaiMatHang WHERE Id=@Id", 
					"@TenLoaiMatHang",  _ExpLoaiMatHang.TenLoaiMatHang, 
					"@Id", _ExpLoaiMatHang.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpLoaiMatHang vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpLoaiMatHang> _ExpLoaiMatHangs)
		{
			foreach (ExpLoaiMatHang item in _ExpLoaiMatHangs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpLoaiMatHang vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpLoaiMatHang _ExpLoaiMatHang, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpLoaiMatHang] SET Id=@Id, TenLoaiMatHang=@TenLoaiMatHang "+ condition, 
					"@Id",  _ExpLoaiMatHang.Id, 
					"@TenLoaiMatHang",  _ExpLoaiMatHang.TenLoaiMatHang);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpLoaiMatHang trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpLoaiMatHang] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpLoaiMatHang trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpLoaiMatHang _ExpLoaiMatHang)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpLoaiMatHang] WHERE Id=@Id",
					"@Id", _ExpLoaiMatHang.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpLoaiMatHang trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpLoaiMatHang] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpLoaiMatHang trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpLoaiMatHang> _ExpLoaiMatHangs)
		{
			foreach (ExpLoaiMatHang item in _ExpLoaiMatHangs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
