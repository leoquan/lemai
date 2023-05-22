using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdticcapmaso:IMEdticcapmaso
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdticcapmaso(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedTicCapMaSo từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedTicCapMaSo]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedTicCapMaSo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedTicCapMaSo] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedTicCapMaSo từ Database
		/// </summary>
		public List<MedTicCapMaSo> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedTicCapMaSo]");
				List<MedTicCapMaSo> items = new List<MedTicCapMaSo>();
				MedTicCapMaSo item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedTicCapMaSo();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToInt32(dr["id"]);
					}
					if (dr["ma"] != null && dr["ma"] != DBNull.Value)
					{
						item.ma = Convert.ToString(dr["ma"]);
					}
					if (dr["ten"] != null && dr["ten"] != DBNull.Value)
					{
						item.ten = Convert.ToString(dr["ten"]);
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
		/// Lấy danh sách MedTicCapMaSo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedTicCapMaSo> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedTicCapMaSo] A "+ condition,  parameters);
				List<MedTicCapMaSo> items = new List<MedTicCapMaSo>();
				MedTicCapMaSo item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedTicCapMaSo();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToInt32(dr["id"]);
					}
					if (dr["ma"] != null && dr["ma"] != DBNull.Value)
					{
						item.ma = Convert.ToString(dr["ma"]);
					}
					if (dr["ten"] != null && dr["ten"] != DBNull.Value)
					{
						item.ten = Convert.ToString(dr["ten"]);
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

		public List<MedTicCapMaSo> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedTicCapMaSo] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedTicCapMaSo] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedTicCapMaSo>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedTicCapMaSo từ Database
		/// </summary>
		public MedTicCapMaSo GetObject(string schema, Int32 id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedTicCapMaSo] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedTicCapMaSo item=new MedTicCapMaSo();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToInt32(dr["id"]);
						}
						if (dr["ma"] != null && dr["ma"] != DBNull.Value)
						{
							item.ma = Convert.ToString(dr["ma"]);
						}
						if (dr["ten"] != null && dr["ten"] != DBNull.Value)
						{
							item.ten = Convert.ToString(dr["ten"]);
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
		/// Lấy một MedTicCapMaSo đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedTicCapMaSo GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedTicCapMaSo] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedTicCapMaSo item=new MedTicCapMaSo();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToInt32(dr["id"]);
						}
						if (dr["ma"] != null && dr["ma"] != DBNull.Value)
						{
							item.ma = Convert.ToString(dr["ma"]);
						}
						if (dr["ten"] != null && dr["ten"] != DBNull.Value)
						{
							item.ten = Convert.ToString(dr["ten"]);
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

		public MedTicCapMaSo GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedTicCapMaSo] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedTicCapMaSo>(ds);
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
		/// Thêm mới MedTicCapMaSo vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedTicCapMaSo _MedTicCapMaSo)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedTicCapMaSo](id, ma, ten) VALUES(@id, @ma, @ten)", 
					"@id",  _MedTicCapMaSo.id, 
					"@ma",  _MedTicCapMaSo.ma, 
					"@ten",  _MedTicCapMaSo.ten);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedTicCapMaSo vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedTicCapMaSo> _MedTicCapMaSos)
		{
			foreach (MedTicCapMaSo item in _MedTicCapMaSos)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedTicCapMaSo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedTicCapMaSo _MedTicCapMaSo, Int32 id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedTicCapMaSo] SET id=@id, ma=@ma, ten=@ten WHERE id=@id", 
					"@id",  _MedTicCapMaSo.id, 
					"@ma",  _MedTicCapMaSo.ma, 
					"@ten",  _MedTicCapMaSo.ten, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedTicCapMaSo vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedTicCapMaSo _MedTicCapMaSo)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedTicCapMaSo] SET ma=@ma, ten=@ten WHERE id=@id", 
					"@ma",  _MedTicCapMaSo.ma, 
					"@ten",  _MedTicCapMaSo.ten, 
					"@id", _MedTicCapMaSo.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedTicCapMaSo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedTicCapMaSo> _MedTicCapMaSos)
		{
			foreach (MedTicCapMaSo item in _MedTicCapMaSos)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedTicCapMaSo vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedTicCapMaSo _MedTicCapMaSo, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedTicCapMaSo] SET id=@id, ma=@ma, ten=@ten "+ condition, 
					"@id",  _MedTicCapMaSo.id, 
					"@ma",  _MedTicCapMaSo.ma, 
					"@ten",  _MedTicCapMaSo.ten);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedTicCapMaSo trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedTicCapMaSo] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedTicCapMaSo trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedTicCapMaSo _MedTicCapMaSo)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedTicCapMaSo] WHERE id=@id",
					"@id", _MedTicCapMaSo.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedTicCapMaSo trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedTicCapMaSo] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedTicCapMaSo trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedTicCapMaSo> _MedTicCapMaSos)
		{
			foreach (MedTicCapMaSo item in _MedTicCapMaSos)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
