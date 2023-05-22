using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdcapmaso:IMEdcapmaso
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdcapmaso(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedCapMaSo từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedCapMaSo]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedCapMaSo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedCapMaSo] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedCapMaSo từ Database
		/// </summary>
		public List<MedCapMaSo> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedCapMaSo]");
				List<MedCapMaSo> items = new List<MedCapMaSo>();
				MedCapMaSo item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedCapMaSo();
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
		/// Lấy danh sách MedCapMaSo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedCapMaSo> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedCapMaSo] A "+ condition,  parameters);
				List<MedCapMaSo> items = new List<MedCapMaSo>();
				MedCapMaSo item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedCapMaSo();
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

		public List<MedCapMaSo> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedCapMaSo] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedCapMaSo] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedCapMaSo>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedCapMaSo từ Database
		/// </summary>
		public MedCapMaSo GetObject(string schema, String id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedCapMaSo] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedCapMaSo item=new MedCapMaSo();
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
		/// Lấy một MedCapMaSo đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedCapMaSo GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedCapMaSo] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedCapMaSo item=new MedCapMaSo();
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

		public MedCapMaSo GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedCapMaSo] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedCapMaSo>(ds);
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
		/// Thêm mới MedCapMaSo vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedCapMaSo _MedCapMaSo)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedCapMaSo](id, giatri) VALUES(@id, @giatri)", 
					"@id",  _MedCapMaSo.id, 
					"@giatri",  _MedCapMaSo.giatri);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedCapMaSo vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedCapMaSo> _MedCapMaSos)
		{
			foreach (MedCapMaSo item in _MedCapMaSos)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedCapMaSo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedCapMaSo _MedCapMaSo, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedCapMaSo] SET id=@id, giatri=@giatri WHERE id=@id", 
					"@id",  _MedCapMaSo.id, 
					"@giatri",  _MedCapMaSo.giatri, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedCapMaSo vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedCapMaSo _MedCapMaSo)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedCapMaSo] SET giatri=@giatri WHERE id=@id", 
					"@giatri",  _MedCapMaSo.giatri, 
					"@id", _MedCapMaSo.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedCapMaSo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedCapMaSo> _MedCapMaSos)
		{
			foreach (MedCapMaSo item in _MedCapMaSos)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedCapMaSo vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedCapMaSo _MedCapMaSo, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedCapMaSo] SET id=@id, giatri=@giatri "+ condition, 
					"@id",  _MedCapMaSo.id, 
					"@giatri",  _MedCapMaSo.giatri);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedCapMaSo trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedCapMaSo] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedCapMaSo trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedCapMaSo _MedCapMaSo)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedCapMaSo] WHERE id=@id",
					"@id", _MedCapMaSo.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedCapMaSo trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedCapMaSo] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedCapMaSo trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedCapMaSo> _MedCapMaSos)
		{
			foreach (MedCapMaSo item in _MedCapMaSos)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
