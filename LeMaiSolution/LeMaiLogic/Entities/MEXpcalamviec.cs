using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpcalamviec:IEXpcalamviec
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpcalamviec(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpCaLamViec từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCaLamViec]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpCaLamViec từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCaLamViec] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpCaLamViec từ Database
		/// </summary>
		public List<ExpCaLamViec> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCaLamViec]");
				List<ExpCaLamViec> items = new List<ExpCaLamViec>();
				ExpCaLamViec item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpCaLamViec();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenCaLamViec"] != null && dr["TenCaLamViec"] != DBNull.Value)
					{
						item.TenCaLamViec = Convert.ToString(dr["TenCaLamViec"]);
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
		/// Lấy danh sách ExpCaLamViec từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpCaLamViec> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpCaLamViec] A "+ condition,  parameters);
				List<ExpCaLamViec> items = new List<ExpCaLamViec>();
				ExpCaLamViec item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpCaLamViec();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["TenCaLamViec"] != null && dr["TenCaLamViec"] != DBNull.Value)
					{
						item.TenCaLamViec = Convert.ToString(dr["TenCaLamViec"]);
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

		public List<ExpCaLamViec> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpCaLamViec] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpCaLamViec] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpCaLamViec>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpCaLamViec từ Database
		/// </summary>
		public ExpCaLamViec GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCaLamViec] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpCaLamViec item=new ExpCaLamViec();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TenCaLamViec"] != null && dr["TenCaLamViec"] != DBNull.Value)
						{
							item.TenCaLamViec = Convert.ToString(dr["TenCaLamViec"]);
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
		/// Lấy một ExpCaLamViec đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpCaLamViec GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpCaLamViec] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpCaLamViec item=new ExpCaLamViec();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["TenCaLamViec"] != null && dr["TenCaLamViec"] != DBNull.Value)
						{
							item.TenCaLamViec = Convert.ToString(dr["TenCaLamViec"]);
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

		public ExpCaLamViec GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpCaLamViec] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpCaLamViec>(ds);
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
		/// Thêm mới ExpCaLamViec vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpCaLamViec _ExpCaLamViec)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpCaLamViec](Id, TenCaLamViec) VALUES(@Id, @TenCaLamViec)", 
					"@Id",  _ExpCaLamViec.Id, 
					"@TenCaLamViec",  _ExpCaLamViec.TenCaLamViec);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpCaLamViec vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpCaLamViec> _ExpCaLamViecs)
		{
			foreach (ExpCaLamViec item in _ExpCaLamViecs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpCaLamViec vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpCaLamViec _ExpCaLamViec, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCaLamViec] SET Id=@Id, TenCaLamViec=@TenCaLamViec WHERE Id=@Id", 
					"@Id",  _ExpCaLamViec.Id, 
					"@TenCaLamViec",  _ExpCaLamViec.TenCaLamViec, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpCaLamViec vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpCaLamViec _ExpCaLamViec)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCaLamViec] SET TenCaLamViec=@TenCaLamViec WHERE Id=@Id", 
					"@TenCaLamViec",  _ExpCaLamViec.TenCaLamViec, 
					"@Id", _ExpCaLamViec.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpCaLamViec vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpCaLamViec> _ExpCaLamViecs)
		{
			foreach (ExpCaLamViec item in _ExpCaLamViecs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpCaLamViec vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpCaLamViec _ExpCaLamViec, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCaLamViec] SET Id=@Id, TenCaLamViec=@TenCaLamViec "+ condition, 
					"@Id",  _ExpCaLamViec.Id, 
					"@TenCaLamViec",  _ExpCaLamViec.TenCaLamViec);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpCaLamViec trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCaLamViec] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCaLamViec trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpCaLamViec _ExpCaLamViec)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCaLamViec] WHERE Id=@Id",
					"@Id", _ExpCaLamViec.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCaLamViec trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCaLamViec] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCaLamViec trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpCaLamViec> _ExpCaLamViecs)
		{
			foreach (ExpCaLamViec item in _ExpCaLamViecs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
