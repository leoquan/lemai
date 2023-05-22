using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdketluanmau:IMEdketluanmau
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdketluanmau(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedKetLuanMau từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetLuanMau]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedKetLuanMau từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetLuanMau] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedKetLuanMau từ Database
		/// </summary>
		public List<MedKetLuanMau> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetLuanMau]");
				List<MedKetLuanMau> items = new List<MedKetLuanMau>();
				MedKetLuanMau item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedKetLuanMau();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["tenmau"] != null && dr["tenmau"] != DBNull.Value)
					{
						item.tenmau = Convert.ToString(dr["tenmau"]);
					}
					if (dr["noidung"] != null && dr["noidung"] != DBNull.Value)
					{
						item.noidung = Convert.ToString(dr["noidung"]);
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
		/// Lấy danh sách MedKetLuanMau từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedKetLuanMau> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedKetLuanMau] A "+ condition,  parameters);
				List<MedKetLuanMau> items = new List<MedKetLuanMau>();
				MedKetLuanMau item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedKetLuanMau();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["tenmau"] != null && dr["tenmau"] != DBNull.Value)
					{
						item.tenmau = Convert.ToString(dr["tenmau"]);
					}
					if (dr["noidung"] != null && dr["noidung"] != DBNull.Value)
					{
						item.noidung = Convert.ToString(dr["noidung"]);
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

		public List<MedKetLuanMau> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedKetLuanMau] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedKetLuanMau] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedKetLuanMau>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedKetLuanMau từ Database
		/// </summary>
		public MedKetLuanMau GetObject(string schema, String id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetLuanMau] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedKetLuanMau item=new MedKetLuanMau();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["tenmau"] != null && dr["tenmau"] != DBNull.Value)
						{
							item.tenmau = Convert.ToString(dr["tenmau"]);
						}
						if (dr["noidung"] != null && dr["noidung"] != DBNull.Value)
						{
							item.noidung = Convert.ToString(dr["noidung"]);
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
		/// Lấy một MedKetLuanMau đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedKetLuanMau GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedKetLuanMau] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedKetLuanMau item=new MedKetLuanMau();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["tenmau"] != null && dr["tenmau"] != DBNull.Value)
						{
							item.tenmau = Convert.ToString(dr["tenmau"]);
						}
						if (dr["noidung"] != null && dr["noidung"] != DBNull.Value)
						{
							item.noidung = Convert.ToString(dr["noidung"]);
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

		public MedKetLuanMau GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedKetLuanMau] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedKetLuanMau>(ds);
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
		/// Thêm mới MedKetLuanMau vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedKetLuanMau _MedKetLuanMau)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedKetLuanMau](id, tenmau, noidung) VALUES(@id, @tenmau, @noidung)", 
					"@id",  _MedKetLuanMau.id, 
					"@tenmau",  _MedKetLuanMau.tenmau, 
					"@noidung",  _MedKetLuanMau.noidung);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedKetLuanMau vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedKetLuanMau> _MedKetLuanMaus)
		{
			foreach (MedKetLuanMau item in _MedKetLuanMaus)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedKetLuanMau vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedKetLuanMau _MedKetLuanMau, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKetLuanMau] SET id=@id, tenmau=@tenmau, noidung=@noidung WHERE id=@id", 
					"@id",  _MedKetLuanMau.id, 
					"@tenmau",  _MedKetLuanMau.tenmau, 
					"@noidung",  _MedKetLuanMau.noidung, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedKetLuanMau vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedKetLuanMau _MedKetLuanMau)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKetLuanMau] SET tenmau=@tenmau, noidung=@noidung WHERE id=@id", 
					"@tenmau",  _MedKetLuanMau.tenmau, 
					"@noidung",  _MedKetLuanMau.noidung, 
					"@id", _MedKetLuanMau.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedKetLuanMau vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedKetLuanMau> _MedKetLuanMaus)
		{
			foreach (MedKetLuanMau item in _MedKetLuanMaus)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedKetLuanMau vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedKetLuanMau _MedKetLuanMau, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKetLuanMau] SET id=@id, tenmau=@tenmau, noidung=@noidung "+ condition, 
					"@id",  _MedKetLuanMau.id, 
					"@tenmau",  _MedKetLuanMau.tenmau, 
					"@noidung",  _MedKetLuanMau.noidung);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedKetLuanMau trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKetLuanMau] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKetLuanMau trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedKetLuanMau _MedKetLuanMau)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKetLuanMau] WHERE id=@id",
					"@id", _MedKetLuanMau.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKetLuanMau trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKetLuanMau] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKetLuanMau trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedKetLuanMau> _MedKetLuanMaus)
		{
			foreach (MedKetLuanMau item in _MedKetLuanMaus)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
