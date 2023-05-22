using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdxnthongsomayct:IMEdxnthongsomayct
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdxnthongsomayct(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedXNThongSoMayCT từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedXNThongSoMayCT]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedXNThongSoMayCT từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedXNThongSoMayCT] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedXNThongSoMayCT từ Database
		/// </summary>
		public List<MedXNThongSoMayCT> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedXNThongSoMayCT]");
				List<MedXNThongSoMayCT> items = new List<MedXNThongSoMayCT>();
				MedXNThongSoMayCT item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedXNThongSoMayCT();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToInt32(dr["id"]);
					}
					if (dr["stt"] != null && dr["stt"] != DBNull.Value)
					{
						item.stt = Convert.ToInt32(dr["stt"]);
					}
					if (dr["vitri"] != null && dr["vitri"] != DBNull.Value)
					{
						item.vitri = Convert.ToInt32(dr["vitri"]);
					}
					if (dr["makq"] != null && dr["makq"] != DBNull.Value)
					{
						item.makq = Convert.ToString(dr["makq"]);
					}
					if (dr["tenkq"] != null && dr["tenkq"] != DBNull.Value)
					{
						item.tenkq = Convert.ToString(dr["tenkq"]);
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
		/// Lấy danh sách MedXNThongSoMayCT từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedXNThongSoMayCT> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedXNThongSoMayCT] A "+ condition,  parameters);
				List<MedXNThongSoMayCT> items = new List<MedXNThongSoMayCT>();
				MedXNThongSoMayCT item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedXNThongSoMayCT();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToInt32(dr["id"]);
					}
					if (dr["stt"] != null && dr["stt"] != DBNull.Value)
					{
						item.stt = Convert.ToInt32(dr["stt"]);
					}
					if (dr["vitri"] != null && dr["vitri"] != DBNull.Value)
					{
						item.vitri = Convert.ToInt32(dr["vitri"]);
					}
					if (dr["makq"] != null && dr["makq"] != DBNull.Value)
					{
						item.makq = Convert.ToString(dr["makq"]);
					}
					if (dr["tenkq"] != null && dr["tenkq"] != DBNull.Value)
					{
						item.tenkq = Convert.ToString(dr["tenkq"]);
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

		public List<MedXNThongSoMayCT> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedXNThongSoMayCT] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedXNThongSoMayCT] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedXNThongSoMayCT>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedXNThongSoMayCT từ Database
		/// </summary>
		public MedXNThongSoMayCT GetObject(string schema, Int32 id, Int32 stt)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedXNThongSoMayCT] where id=@id and stt=@stt",
					"@id", id, 
					"@stt", stt);
				if (ds.Rows.Count > 0)
				{
					MedXNThongSoMayCT item=new MedXNThongSoMayCT();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToInt32(dr["id"]);
						}
						if (dr["stt"] != null && dr["stt"] != DBNull.Value)
						{
							item.stt = Convert.ToInt32(dr["stt"]);
						}
						if (dr["vitri"] != null && dr["vitri"] != DBNull.Value)
						{
							item.vitri = Convert.ToInt32(dr["vitri"]);
						}
						if (dr["makq"] != null && dr["makq"] != DBNull.Value)
						{
							item.makq = Convert.ToString(dr["makq"]);
						}
						if (dr["tenkq"] != null && dr["tenkq"] != DBNull.Value)
						{
							item.tenkq = Convert.ToString(dr["tenkq"]);
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
		/// Lấy một MedXNThongSoMayCT đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedXNThongSoMayCT GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedXNThongSoMayCT] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedXNThongSoMayCT item=new MedXNThongSoMayCT();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToInt32(dr["id"]);
						}
						if (dr["stt"] != null && dr["stt"] != DBNull.Value)
						{
							item.stt = Convert.ToInt32(dr["stt"]);
						}
						if (dr["vitri"] != null && dr["vitri"] != DBNull.Value)
						{
							item.vitri = Convert.ToInt32(dr["vitri"]);
						}
						if (dr["makq"] != null && dr["makq"] != DBNull.Value)
						{
							item.makq = Convert.ToString(dr["makq"]);
						}
						if (dr["tenkq"] != null && dr["tenkq"] != DBNull.Value)
						{
							item.tenkq = Convert.ToString(dr["tenkq"]);
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

		public MedXNThongSoMayCT GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedXNThongSoMayCT] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedXNThongSoMayCT>(ds);
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
		/// Thêm mới MedXNThongSoMayCT vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedXNThongSoMayCT _MedXNThongSoMayCT)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedXNThongSoMayCT](id, stt, vitri, makq, tenkq) VALUES(@id, @stt, @vitri, @makq, @tenkq)", 
					"@id",  _MedXNThongSoMayCT.id, 
					"@stt",  _MedXNThongSoMayCT.stt, 
					"@vitri",  _MedXNThongSoMayCT.vitri, 
					"@makq",  _MedXNThongSoMayCT.makq, 
					"@tenkq",  _MedXNThongSoMayCT.tenkq);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedXNThongSoMayCT vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedXNThongSoMayCT> _MedXNThongSoMayCTs)
		{
			foreach (MedXNThongSoMayCT item in _MedXNThongSoMayCTs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedXNThongSoMayCT vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedXNThongSoMayCT _MedXNThongSoMayCT, Int32 id, Int32 stt)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedXNThongSoMayCT] SET id=@id, stt=@stt, vitri=@vitri, makq=@makq, tenkq=@tenkq WHERE id=@id and stt=@stt", 
					"@id",  _MedXNThongSoMayCT.id, 
					"@stt",  _MedXNThongSoMayCT.stt, 
					"@vitri",  _MedXNThongSoMayCT.vitri, 
					"@makq",  _MedXNThongSoMayCT.makq, 
					"@tenkq",  _MedXNThongSoMayCT.tenkq, 
					"@id", id, 
					"@stt", stt);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedXNThongSoMayCT vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedXNThongSoMayCT _MedXNThongSoMayCT)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedXNThongSoMayCT] SET vitri=@vitri, makq=@makq, tenkq=@tenkq WHERE id=@id and stt=@stt", 
					"@vitri",  _MedXNThongSoMayCT.vitri, 
					"@makq",  _MedXNThongSoMayCT.makq, 
					"@tenkq",  _MedXNThongSoMayCT.tenkq, 
					"@id", _MedXNThongSoMayCT.id, 
					"@stt", _MedXNThongSoMayCT.stt);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedXNThongSoMayCT vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedXNThongSoMayCT> _MedXNThongSoMayCTs)
		{
			foreach (MedXNThongSoMayCT item in _MedXNThongSoMayCTs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedXNThongSoMayCT vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedXNThongSoMayCT _MedXNThongSoMayCT, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedXNThongSoMayCT] SET id=@id, stt=@stt, vitri=@vitri, makq=@makq, tenkq=@tenkq "+ condition, 
					"@id",  _MedXNThongSoMayCT.id, 
					"@stt",  _MedXNThongSoMayCT.stt, 
					"@vitri",  _MedXNThongSoMayCT.vitri, 
					"@makq",  _MedXNThongSoMayCT.makq, 
					"@tenkq",  _MedXNThongSoMayCT.tenkq);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedXNThongSoMayCT trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 id, Int32 stt)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedXNThongSoMayCT] WHERE id=@id and stt=@stt",
					"@id", id, 
					"@stt", stt);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedXNThongSoMayCT trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedXNThongSoMayCT _MedXNThongSoMayCT)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedXNThongSoMayCT] WHERE id=@id and stt=@stt",
					"@id", _MedXNThongSoMayCT.id, 
					"@stt", _MedXNThongSoMayCT.stt);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedXNThongSoMayCT trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedXNThongSoMayCT] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedXNThongSoMayCT trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedXNThongSoMayCT> _MedXNThongSoMayCTs)
		{
			foreach (MedXNThongSoMayCT item in _MedXNThongSoMayCTs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
