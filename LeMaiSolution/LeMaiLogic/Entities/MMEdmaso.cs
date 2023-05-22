using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdmaso:IMEdmaso
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdmaso(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedMaSo từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedMaSo]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedMaSo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedMaSo] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedMaSo từ Database
		/// </summary>
		public List<MedMaSo> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedMaSo]");
				List<MedMaSo> items = new List<MedMaSo>();
				MedMaSo item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedMaSo();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["giatri"] != null && dr["giatri"] != DBNull.Value)
					{
						item.giatri = Convert.ToDecimal(dr["giatri"]);
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
		/// Lấy danh sách MedMaSo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedMaSo> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedMaSo] A "+ condition,  parameters);
				List<MedMaSo> items = new List<MedMaSo>();
				MedMaSo item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedMaSo();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["giatri"] != null && dr["giatri"] != DBNull.Value)
					{
						item.giatri = Convert.ToDecimal(dr["giatri"]);
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

		public List<MedMaSo> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedMaSo] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedMaSo] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedMaSo>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedMaSo từ Database
		/// </summary>
		public MedMaSo GetObject(string schema, String id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedMaSo] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedMaSo item=new MedMaSo();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["giatri"] != null && dr["giatri"] != DBNull.Value)
						{
							item.giatri = Convert.ToDecimal(dr["giatri"]);
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
		/// Lấy một MedMaSo đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedMaSo GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedMaSo] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedMaSo item=new MedMaSo();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["giatri"] != null && dr["giatri"] != DBNull.Value)
						{
							item.giatri = Convert.ToDecimal(dr["giatri"]);
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

		public MedMaSo GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedMaSo] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedMaSo>(ds);
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
		/// Thêm mới MedMaSo vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedMaSo _MedMaSo)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedMaSo](id, giatri) VALUES(@id, @giatri)", 
					"@id",  _MedMaSo.id, 
					"@giatri",  _MedMaSo.giatri);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedMaSo vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedMaSo> _MedMaSos)
		{
			foreach (MedMaSo item in _MedMaSos)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedMaSo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedMaSo _MedMaSo, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedMaSo] SET id=@id, giatri=@giatri WHERE id=@id", 
					"@id",  _MedMaSo.id, 
					"@giatri",  _MedMaSo.giatri, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedMaSo vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedMaSo _MedMaSo)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedMaSo] SET giatri=@giatri WHERE id=@id", 
					"@giatri",  _MedMaSo.giatri, 
					"@id", _MedMaSo.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedMaSo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedMaSo> _MedMaSos)
		{
			foreach (MedMaSo item in _MedMaSos)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedMaSo vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedMaSo _MedMaSo, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedMaSo] SET id=@id, giatri=@giatri "+ condition, 
					"@id",  _MedMaSo.id, 
					"@giatri",  _MedMaSo.giatri);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedMaSo trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedMaSo] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedMaSo trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedMaSo _MedMaSo)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedMaSo] WHERE id=@id",
					"@id", _MedMaSo.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedMaSo trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedMaSo] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedMaSo trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedMaSo> _MedMaSos)
		{
			foreach (MedMaSo item in _MedMaSos)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
