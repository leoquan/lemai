using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdketquact:IMEdketquact
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdketquact(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedKetQuaCT từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaCT]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedKetQuaCT từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaCT] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedKetQuaCT từ Database
		/// </summary>
		public List<MedKetQuaCT> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaCT]");
				List<MedKetQuaCT> items = new List<MedKetQuaCT>();
				MedKetQuaCT item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedKetQuaCT();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["stt"] != null && dr["stt"] != DBNull.Value)
					{
						item.stt = Convert.ToInt32(dr["stt"]);
					}
					if (dr["id_ketqua"] != null && dr["id_ketqua"] != DBNull.Value)
					{
						item.id_ketqua = Convert.ToString(dr["id_ketqua"]);
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
		/// Lấy danh sách MedKetQuaCT từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedKetQuaCT> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedKetQuaCT] A "+ condition,  parameters);
				List<MedKetQuaCT> items = new List<MedKetQuaCT>();
				MedKetQuaCT item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedKetQuaCT();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["stt"] != null && dr["stt"] != DBNull.Value)
					{
						item.stt = Convert.ToInt32(dr["stt"]);
					}
					if (dr["id_ketqua"] != null && dr["id_ketqua"] != DBNull.Value)
					{
						item.id_ketqua = Convert.ToString(dr["id_ketqua"]);
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

		public List<MedKetQuaCT> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedKetQuaCT] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedKetQuaCT] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedKetQuaCT>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedKetQuaCT từ Database
		/// </summary>
		public MedKetQuaCT GetObject(string schema, String id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedKetQuaCT] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedKetQuaCT item=new MedKetQuaCT();
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
						if (dr["id_ketqua"] != null && dr["id_ketqua"] != DBNull.Value)
						{
							item.id_ketqua = Convert.ToString(dr["id_ketqua"]);
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
		/// Lấy một MedKetQuaCT đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedKetQuaCT GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedKetQuaCT] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedKetQuaCT item=new MedKetQuaCT();
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
						if (dr["id_ketqua"] != null && dr["id_ketqua"] != DBNull.Value)
						{
							item.id_ketqua = Convert.ToString(dr["id_ketqua"]);
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

		public MedKetQuaCT GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedKetQuaCT] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedKetQuaCT>(ds);
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
		/// Thêm mới MedKetQuaCT vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedKetQuaCT _MedKetQuaCT)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedKetQuaCT](id, stt, id_ketqua, id_vp, id_doituong, id_chidinh, mmyy_chidinh) VALUES(@id, @stt, @id_ketqua, @id_vp, @id_doituong, @id_chidinh, @mmyy_chidinh)", 
					"@id",  _MedKetQuaCT.id, 
					"@stt",  _MedKetQuaCT.stt, 
					"@id_ketqua",  _MedKetQuaCT.id_ketqua, 
					"@id_vp",  _MedKetQuaCT.id_vp, 
					"@id_doituong",  _MedKetQuaCT.id_doituong, 
					"@id_chidinh",  _MedKetQuaCT.id_chidinh, 
					"@mmyy_chidinh",  _MedKetQuaCT.mmyy_chidinh);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedKetQuaCT vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedKetQuaCT> _MedKetQuaCTs)
		{
			foreach (MedKetQuaCT item in _MedKetQuaCTs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedKetQuaCT vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedKetQuaCT _MedKetQuaCT, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKetQuaCT] SET id=@id, stt=@stt, id_ketqua=@id_ketqua, id_vp=@id_vp, id_doituong=@id_doituong, id_chidinh=@id_chidinh, mmyy_chidinh=@mmyy_chidinh WHERE id=@id", 
					"@id",  _MedKetQuaCT.id, 
					"@stt",  _MedKetQuaCT.stt, 
					"@id_ketqua",  _MedKetQuaCT.id_ketqua, 
					"@id_vp",  _MedKetQuaCT.id_vp, 
					"@id_doituong",  _MedKetQuaCT.id_doituong, 
					"@id_chidinh",  _MedKetQuaCT.id_chidinh, 
					"@mmyy_chidinh",  _MedKetQuaCT.mmyy_chidinh, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedKetQuaCT vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedKetQuaCT _MedKetQuaCT)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKetQuaCT] SET stt=@stt, id_ketqua=@id_ketqua, id_vp=@id_vp, id_doituong=@id_doituong, id_chidinh=@id_chidinh, mmyy_chidinh=@mmyy_chidinh WHERE id=@id", 
					"@stt",  _MedKetQuaCT.stt, 
					"@id_ketqua",  _MedKetQuaCT.id_ketqua, 
					"@id_vp",  _MedKetQuaCT.id_vp, 
					"@id_doituong",  _MedKetQuaCT.id_doituong, 
					"@id_chidinh",  _MedKetQuaCT.id_chidinh, 
					"@mmyy_chidinh",  _MedKetQuaCT.mmyy_chidinh, 
					"@id", _MedKetQuaCT.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedKetQuaCT vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedKetQuaCT> _MedKetQuaCTs)
		{
			foreach (MedKetQuaCT item in _MedKetQuaCTs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedKetQuaCT vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedKetQuaCT _MedKetQuaCT, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedKetQuaCT] SET id=@id, stt=@stt, id_ketqua=@id_ketqua, id_vp=@id_vp, id_doituong=@id_doituong, id_chidinh=@id_chidinh, mmyy_chidinh=@mmyy_chidinh "+ condition, 
					"@id",  _MedKetQuaCT.id, 
					"@stt",  _MedKetQuaCT.stt, 
					"@id_ketqua",  _MedKetQuaCT.id_ketqua, 
					"@id_vp",  _MedKetQuaCT.id_vp, 
					"@id_doituong",  _MedKetQuaCT.id_doituong, 
					"@id_chidinh",  _MedKetQuaCT.id_chidinh, 
					"@mmyy_chidinh",  _MedKetQuaCT.mmyy_chidinh);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedKetQuaCT trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKetQuaCT] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKetQuaCT trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedKetQuaCT _MedKetQuaCT)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKetQuaCT] WHERE id=@id",
					"@id", _MedKetQuaCT.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKetQuaCT trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedKetQuaCT] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedKetQuaCT trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedKetQuaCT> _MedKetQuaCTs)
		{
			foreach (MedKetQuaCT item in _MedKetQuaCTs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
