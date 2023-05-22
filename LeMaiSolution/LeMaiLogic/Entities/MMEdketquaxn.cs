using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdketquaxn:IMEdketquaxn
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdketquaxn(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedKetQuaXN từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaXN]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedKetQuaXN từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaXN] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedKetQuaXN từ Database
		/// </summary>
		public List<MedKetQuaXN> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaXN]");
				List<MedKetQuaXN> items = new List<MedKetQuaXN>();
				MedKetQuaXN item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedKetQuaXN();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["stt"] != null && dr["stt"] != DBNull.Value)
					{
						item.stt = Convert.ToInt32(dr["stt"]);
					}
					if (dr["id_xnten"] != null && dr["id_xnten"] != DBNull.Value)
					{
						item.id_xnten = Convert.ToInt32(dr["id_xnten"]);
					}
					if (dr["ketqua"] != null && dr["ketqua"] != DBNull.Value)
					{
						item.ketqua = Convert.ToString(dr["ketqua"]);
					}
					if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
					{
						item.ghichu = Convert.ToString(dr["ghichu"]);
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
		/// Lấy danh sách MedKetQuaXN từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedKetQuaXN> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedKetQuaXN] A "+ condition,  parameters);
				List<MedKetQuaXN> items = new List<MedKetQuaXN>();
				MedKetQuaXN item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedKetQuaXN();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["stt"] != null && dr["stt"] != DBNull.Value)
					{
						item.stt = Convert.ToInt32(dr["stt"]);
					}
					if (dr["id_xnten"] != null && dr["id_xnten"] != DBNull.Value)
					{
						item.id_xnten = Convert.ToInt32(dr["id_xnten"]);
					}
					if (dr["ketqua"] != null && dr["ketqua"] != DBNull.Value)
					{
						item.ketqua = Convert.ToString(dr["ketqua"]);
					}
					if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
					{
						item.ghichu = Convert.ToString(dr["ghichu"]);
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

		public List<MedKetQuaXN> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedKetQuaXN] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedKetQuaXN] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedKetQuaXN>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedKetQuaXN từ Database
		/// </summary>
		public MedKetQuaXN GetObject(string schema, String id, Int32 stt)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaXN] where id=@id and stt=@stt",
					"@id", id, 
					"@stt", stt);
				if (ds.Rows.Count > 0)
				{
					MedKetQuaXN item=new MedKetQuaXN();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["stt"] != null && dr["stt"] != DBNull.Value)
						{
							item.stt = Convert.ToInt32(dr["stt"]);
						}
						if (dr["id_xnten"] != null && dr["id_xnten"] != DBNull.Value)
						{
							item.id_xnten = Convert.ToInt32(dr["id_xnten"]);
						}
						if (dr["ketqua"] != null && dr["ketqua"] != DBNull.Value)
						{
							item.ketqua = Convert.ToString(dr["ketqua"]);
						}
						if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
						{
							item.ghichu = Convert.ToString(dr["ghichu"]);
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
		/// Lấy một MedKetQuaXN đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedKetQuaXN GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedKetQuaXN] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedKetQuaXN item=new MedKetQuaXN();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["stt"] != null && dr["stt"] != DBNull.Value)
						{
							item.stt = Convert.ToInt32(dr["stt"]);
						}
						if (dr["id_xnten"] != null && dr["id_xnten"] != DBNull.Value)
						{
							item.id_xnten = Convert.ToInt32(dr["id_xnten"]);
						}
						if (dr["ketqua"] != null && dr["ketqua"] != DBNull.Value)
						{
							item.ketqua = Convert.ToString(dr["ketqua"]);
						}
						if (dr["ghichu"] != null && dr["ghichu"] != DBNull.Value)
						{
							item.ghichu = Convert.ToString(dr["ghichu"]);
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

		public MedKetQuaXN GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedKetQuaXN] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedKetQuaXN>(ds);
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
		/// Thêm mới MedKetQuaXN vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedKetQuaXN _MedKetQuaXN)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedKetQuaXN](id, stt, id_xnten, ketqua, ghichu) VALUES(@id, @stt, @id_xnten, @ketqua, @ghichu)", 
					"@id",  _MedKetQuaXN.id, 
					"@stt",  _MedKetQuaXN.stt, 
					"@id_xnten",  _MedKetQuaXN.id_xnten, 
					"@ketqua",  _MedKetQuaXN.ketqua, 
					"@ghichu",  _MedKetQuaXN.ghichu);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedKetQuaXN vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedKetQuaXN> _MedKetQuaXNs)
		{
			foreach (MedKetQuaXN item in _MedKetQuaXNs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedKetQuaXN vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedKetQuaXN _MedKetQuaXN, String id, Int32 stt)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKetQuaXN] SET id=@id, stt=@stt, id_xnten=@id_xnten, ketqua=@ketqua, ghichu=@ghichu WHERE id=@id and stt=@stt", 
					"@id",  _MedKetQuaXN.id, 
					"@stt",  _MedKetQuaXN.stt, 
					"@id_xnten",  _MedKetQuaXN.id_xnten, 
					"@ketqua",  _MedKetQuaXN.ketqua, 
					"@ghichu",  _MedKetQuaXN.ghichu, 
					"@id", id, 
					"@stt", stt);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedKetQuaXN vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedKetQuaXN _MedKetQuaXN)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKetQuaXN] SET id_xnten=@id_xnten, ketqua=@ketqua, ghichu=@ghichu WHERE id=@id and stt=@stt", 
					"@id_xnten",  _MedKetQuaXN.id_xnten, 
					"@ketqua",  _MedKetQuaXN.ketqua, 
					"@ghichu",  _MedKetQuaXN.ghichu, 
					"@id", _MedKetQuaXN.id, 
					"@stt", _MedKetQuaXN.stt);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedKetQuaXN vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedKetQuaXN> _MedKetQuaXNs)
		{
			foreach (MedKetQuaXN item in _MedKetQuaXNs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedKetQuaXN vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedKetQuaXN _MedKetQuaXN, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKetQuaXN] SET id=@id, stt=@stt, id_xnten=@id_xnten, ketqua=@ketqua, ghichu=@ghichu "+ condition, 
					"@id",  _MedKetQuaXN.id, 
					"@stt",  _MedKetQuaXN.stt, 
					"@id_xnten",  _MedKetQuaXN.id_xnten, 
					"@ketqua",  _MedKetQuaXN.ketqua, 
					"@ghichu",  _MedKetQuaXN.ghichu);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedKetQuaXN trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String id, Int32 stt)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKetQuaXN] WHERE id=@id and stt=@stt",
					"@id", id, 
					"@stt", stt);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKetQuaXN trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedKetQuaXN _MedKetQuaXN)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKetQuaXN] WHERE id=@id and stt=@stt",
					"@id", _MedKetQuaXN.id, 
					"@stt", _MedKetQuaXN.stt);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKetQuaXN trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKetQuaXN] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKetQuaXN trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedKetQuaXN> _MedKetQuaXNs)
		{
			foreach (MedKetQuaXN item in _MedKetQuaXNs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
