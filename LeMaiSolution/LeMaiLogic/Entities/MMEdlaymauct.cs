using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdlaymauct:IMEdlaymauct
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdlaymauct(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedLayMauCT từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedLayMauCT]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedLayMauCT từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedLayMauCT] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedLayMauCT từ Database
		/// </summary>
		public List<MedLayMauCT> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedLayMauCT]");
				List<MedLayMauCT> items = new List<MedLayMauCT>();
				MedLayMauCT item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedLayMauCT();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["stt"] != null && dr["stt"] != DBNull.Value)
					{
						item.stt = Convert.ToInt32(dr["stt"]);
					}
					if (dr["id_vp"] != null && dr["id_vp"] != DBNull.Value)
					{
						item.id_vp = Convert.ToInt32(dr["id_vp"]);
					}
					if (dr["id_doituong"] != null && dr["id_doituong"] != DBNull.Value)
					{
						item.id_doituong = Convert.ToInt32(dr["id_doituong"]);
					}
					if (dr["id_chidinh"] != null && dr["id_chidinh"] != DBNull.Value)
					{
						item.id_chidinh = Convert.ToString(dr["id_chidinh"]);
					}
					if (dr["mmyy_chidinh"] != null && dr["mmyy_chidinh"] != DBNull.Value)
					{
						item.mmyy_chidinh = Convert.ToString(dr["mmyy_chidinh"]);
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
		/// Lấy danh sách MedLayMauCT từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedLayMauCT> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedLayMauCT] A "+ condition,  parameters);
				List<MedLayMauCT> items = new List<MedLayMauCT>();
				MedLayMauCT item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedLayMauCT();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["stt"] != null && dr["stt"] != DBNull.Value)
					{
						item.stt = Convert.ToInt32(dr["stt"]);
					}
					if (dr["id_vp"] != null && dr["id_vp"] != DBNull.Value)
					{
						item.id_vp = Convert.ToInt32(dr["id_vp"]);
					}
					if (dr["id_doituong"] != null && dr["id_doituong"] != DBNull.Value)
					{
						item.id_doituong = Convert.ToInt32(dr["id_doituong"]);
					}
					if (dr["id_chidinh"] != null && dr["id_chidinh"] != DBNull.Value)
					{
						item.id_chidinh = Convert.ToString(dr["id_chidinh"]);
					}
					if (dr["mmyy_chidinh"] != null && dr["mmyy_chidinh"] != DBNull.Value)
					{
						item.mmyy_chidinh = Convert.ToString(dr["mmyy_chidinh"]);
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

		public List<MedLayMauCT> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedLayMauCT] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedLayMauCT] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedLayMauCT>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedLayMauCT từ Database
		/// </summary>
		public MedLayMauCT GetObject(string schema, String id, Int32 stt)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedLayMauCT] where id=@id and stt=@stt",
					"@id", id, 
					"@stt", stt);
				if (ds.Rows.Count > 0)
				{
					MedLayMauCT item=new MedLayMauCT();
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
						if (dr["id_vp"] != null && dr["id_vp"] != DBNull.Value)
						{
							item.id_vp = Convert.ToInt32(dr["id_vp"]);
						}
						if (dr["id_doituong"] != null && dr["id_doituong"] != DBNull.Value)
						{
							item.id_doituong = Convert.ToInt32(dr["id_doituong"]);
						}
						if (dr["id_chidinh"] != null && dr["id_chidinh"] != DBNull.Value)
						{
							item.id_chidinh = Convert.ToString(dr["id_chidinh"]);
						}
						if (dr["mmyy_chidinh"] != null && dr["mmyy_chidinh"] != DBNull.Value)
						{
							item.mmyy_chidinh = Convert.ToString(dr["mmyy_chidinh"]);
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
		/// Lấy một MedLayMauCT đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedLayMauCT GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedLayMauCT] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedLayMauCT item=new MedLayMauCT();
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
						if (dr["id_vp"] != null && dr["id_vp"] != DBNull.Value)
						{
							item.id_vp = Convert.ToInt32(dr["id_vp"]);
						}
						if (dr["id_doituong"] != null && dr["id_doituong"] != DBNull.Value)
						{
							item.id_doituong = Convert.ToInt32(dr["id_doituong"]);
						}
						if (dr["id_chidinh"] != null && dr["id_chidinh"] != DBNull.Value)
						{
							item.id_chidinh = Convert.ToString(dr["id_chidinh"]);
						}
						if (dr["mmyy_chidinh"] != null && dr["mmyy_chidinh"] != DBNull.Value)
						{
							item.mmyy_chidinh = Convert.ToString(dr["mmyy_chidinh"]);
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

		public MedLayMauCT GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedLayMauCT] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedLayMauCT>(ds);
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
		/// Thêm mới MedLayMauCT vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedLayMauCT _MedLayMauCT)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedLayMauCT](id, stt, id_vp, id_doituong, id_chidinh, mmyy_chidinh) VALUES(@id, @stt, @id_vp, @id_doituong, @id_chidinh, @mmyy_chidinh)", 
					"@id",  _MedLayMauCT.id, 
					"@stt",  _MedLayMauCT.stt, 
					"@id_vp",  _MedLayMauCT.id_vp, 
					"@id_doituong",  _MedLayMauCT.id_doituong, 
					"@id_chidinh",  _MedLayMauCT.id_chidinh, 
					"@mmyy_chidinh",  _MedLayMauCT.mmyy_chidinh);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedLayMauCT vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedLayMauCT> _MedLayMauCTs)
		{
			foreach (MedLayMauCT item in _MedLayMauCTs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedLayMauCT vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedLayMauCT _MedLayMauCT, String id, Int32 stt)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedLayMauCT] SET id=@id, stt=@stt, id_vp=@id_vp, id_doituong=@id_doituong, id_chidinh=@id_chidinh, mmyy_chidinh=@mmyy_chidinh WHERE id=@id and stt=@stt", 
					"@id",  _MedLayMauCT.id, 
					"@stt",  _MedLayMauCT.stt, 
					"@id_vp",  _MedLayMauCT.id_vp, 
					"@id_doituong",  _MedLayMauCT.id_doituong, 
					"@id_chidinh",  _MedLayMauCT.id_chidinh, 
					"@mmyy_chidinh",  _MedLayMauCT.mmyy_chidinh, 
					"@id", id, 
					"@stt", stt);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedLayMauCT vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedLayMauCT _MedLayMauCT)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedLayMauCT] SET id_vp=@id_vp, id_doituong=@id_doituong, id_chidinh=@id_chidinh, mmyy_chidinh=@mmyy_chidinh WHERE id=@id and stt=@stt", 
					"@id_vp",  _MedLayMauCT.id_vp, 
					"@id_doituong",  _MedLayMauCT.id_doituong, 
					"@id_chidinh",  _MedLayMauCT.id_chidinh, 
					"@mmyy_chidinh",  _MedLayMauCT.mmyy_chidinh, 
					"@id", _MedLayMauCT.id, 
					"@stt", _MedLayMauCT.stt);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedLayMauCT vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedLayMauCT> _MedLayMauCTs)
		{
			foreach (MedLayMauCT item in _MedLayMauCTs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedLayMauCT vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedLayMauCT _MedLayMauCT, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedLayMauCT] SET id=@id, stt=@stt, id_vp=@id_vp, id_doituong=@id_doituong, id_chidinh=@id_chidinh, mmyy_chidinh=@mmyy_chidinh "+ condition, 
					"@id",  _MedLayMauCT.id, 
					"@stt",  _MedLayMauCT.stt, 
					"@id_vp",  _MedLayMauCT.id_vp, 
					"@id_doituong",  _MedLayMauCT.id_doituong, 
					"@id_chidinh",  _MedLayMauCT.id_chidinh, 
					"@mmyy_chidinh",  _MedLayMauCT.mmyy_chidinh);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedLayMauCT trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String id, Int32 stt)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedLayMauCT] WHERE id=@id and stt=@stt",
					"@id", id, 
					"@stt", stt);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedLayMauCT trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedLayMauCT _MedLayMauCT)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedLayMauCT] WHERE id=@id and stt=@stt",
					"@id", _MedLayMauCT.id, 
					"@stt", _MedLayMauCT.stt);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedLayMauCT trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedLayMauCT] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedLayMauCT trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedLayMauCT> _MedLayMauCTs)
		{
			foreach (MedLayMauCT item in _MedLayMauCTs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
