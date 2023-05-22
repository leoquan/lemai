using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdloaivp:IMEdloaivp
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdloaivp(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedLoaiVp từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedLoaiVp]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedLoaiVp từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedLoaiVp] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedLoaiVp từ Database
		/// </summary>
		public List<MedLoaiVp> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedLoaiVp]");
				List<MedLoaiVp> items = new List<MedLoaiVp>();
				MedLoaiVp item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedLoaiVp();
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
					if (dr["id_nhom"] != null && dr["id_nhom"] != DBNull.Value)
					{
						item.id_nhom = Convert.ToInt32(dr["id_nhom"]);
					}
					if (dr["userid"] != null && dr["userid"] != DBNull.Value)
					{
						item.userid = Convert.ToString(dr["userid"]);
					}
					if (dr["stt"] != null && dr["stt"] != DBNull.Value)
					{
						item.stt = Convert.ToString(dr["stt"]);
					}
					if (dr["report"] != null && dr["report"] != DBNull.Value)
					{
						item.report = Convert.ToString(dr["report"]);
					}
					if (dr["kyhieu"] != null && dr["kyhieu"] != DBNull.Value)
					{
						item.kyhieu = Convert.ToString(dr["kyhieu"]);
					}
					if (dr["noithuchien"] != null && dr["noithuchien"] != DBNull.Value)
					{
						item.noithuchien = Convert.ToString(dr["noithuchien"]);
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
		/// Lấy danh sách MedLoaiVp từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedLoaiVp> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedLoaiVp] A "+ condition,  parameters);
				List<MedLoaiVp> items = new List<MedLoaiVp>();
				MedLoaiVp item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedLoaiVp();
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
					if (dr["id_nhom"] != null && dr["id_nhom"] != DBNull.Value)
					{
						item.id_nhom = Convert.ToInt32(dr["id_nhom"]);
					}
					if (dr["userid"] != null && dr["userid"] != DBNull.Value)
					{
						item.userid = Convert.ToString(dr["userid"]);
					}
					if (dr["stt"] != null && dr["stt"] != DBNull.Value)
					{
						item.stt = Convert.ToString(dr["stt"]);
					}
					if (dr["report"] != null && dr["report"] != DBNull.Value)
					{
						item.report = Convert.ToString(dr["report"]);
					}
					if (dr["kyhieu"] != null && dr["kyhieu"] != DBNull.Value)
					{
						item.kyhieu = Convert.ToString(dr["kyhieu"]);
					}
					if (dr["noithuchien"] != null && dr["noithuchien"] != DBNull.Value)
					{
						item.noithuchien = Convert.ToString(dr["noithuchien"]);
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

		public List<MedLoaiVp> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedLoaiVp] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedLoaiVp] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedLoaiVp>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedLoaiVp từ Database
		/// </summary>
		public MedLoaiVp GetObject(string schema, Int32 id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedLoaiVp] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedLoaiVp item=new MedLoaiVp();
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
						if (dr["id_nhom"] != null && dr["id_nhom"] != DBNull.Value)
						{
							item.id_nhom = Convert.ToInt32(dr["id_nhom"]);
						}
						if (dr["userid"] != null && dr["userid"] != DBNull.Value)
						{
							item.userid = Convert.ToString(dr["userid"]);
						}
						if (dr["stt"] != null && dr["stt"] != DBNull.Value)
						{
							item.stt = Convert.ToString(dr["stt"]);
						}
						if (dr["report"] != null && dr["report"] != DBNull.Value)
						{
							item.report = Convert.ToString(dr["report"]);
						}
						if (dr["kyhieu"] != null && dr["kyhieu"] != DBNull.Value)
						{
							item.kyhieu = Convert.ToString(dr["kyhieu"]);
						}
						if (dr["noithuchien"] != null && dr["noithuchien"] != DBNull.Value)
						{
							item.noithuchien = Convert.ToString(dr["noithuchien"]);
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
		/// Lấy một MedLoaiVp đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedLoaiVp GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedLoaiVp] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedLoaiVp item=new MedLoaiVp();
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
						if (dr["id_nhom"] != null && dr["id_nhom"] != DBNull.Value)
						{
							item.id_nhom = Convert.ToInt32(dr["id_nhom"]);
						}
						if (dr["userid"] != null && dr["userid"] != DBNull.Value)
						{
							item.userid = Convert.ToString(dr["userid"]);
						}
						if (dr["stt"] != null && dr["stt"] != DBNull.Value)
						{
							item.stt = Convert.ToString(dr["stt"]);
						}
						if (dr["report"] != null && dr["report"] != DBNull.Value)
						{
							item.report = Convert.ToString(dr["report"]);
						}
						if (dr["kyhieu"] != null && dr["kyhieu"] != DBNull.Value)
						{
							item.kyhieu = Convert.ToString(dr["kyhieu"]);
						}
						if (dr["noithuchien"] != null && dr["noithuchien"] != DBNull.Value)
						{
							item.noithuchien = Convert.ToString(dr["noithuchien"]);
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

		public MedLoaiVp GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedLoaiVp] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedLoaiVp>(ds);
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
		/// Thêm mới MedLoaiVp vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedLoaiVp _MedLoaiVp)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedLoaiVp](id, ma, ten, id_nhom, userid, stt, report, kyhieu, noithuchien) VALUES(@id, @ma, @ten, @id_nhom, @userid, @stt, @report, @kyhieu, @noithuchien)", 
					"@id",  _MedLoaiVp.id, 
					"@ma",  _MedLoaiVp.ma, 
					"@ten",  _MedLoaiVp.ten, 
					"@id_nhom",  _MedLoaiVp.id_nhom, 
					"@userid",  _MedLoaiVp.userid, 
					"@stt",  _MedLoaiVp.stt, 
					"@report",  _MedLoaiVp.report, 
					"@kyhieu",  _MedLoaiVp.kyhieu, 
					"@noithuchien",  _MedLoaiVp.noithuchien);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedLoaiVp vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedLoaiVp> _MedLoaiVps)
		{
			foreach (MedLoaiVp item in _MedLoaiVps)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedLoaiVp vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedLoaiVp _MedLoaiVp, Int32 id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedLoaiVp] SET id=@id, ma=@ma, ten=@ten, id_nhom=@id_nhom, userid=@userid, stt=@stt, report=@report, kyhieu=@kyhieu, noithuchien=@noithuchien WHERE id=@id", 
					"@id",  _MedLoaiVp.id, 
					"@ma",  _MedLoaiVp.ma, 
					"@ten",  _MedLoaiVp.ten, 
					"@id_nhom",  _MedLoaiVp.id_nhom, 
					"@userid",  _MedLoaiVp.userid, 
					"@stt",  _MedLoaiVp.stt, 
					"@report",  _MedLoaiVp.report, 
					"@kyhieu",  _MedLoaiVp.kyhieu, 
					"@noithuchien",  _MedLoaiVp.noithuchien, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedLoaiVp vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedLoaiVp _MedLoaiVp)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedLoaiVp] SET ma=@ma, ten=@ten, id_nhom=@id_nhom, userid=@userid, stt=@stt, report=@report, kyhieu=@kyhieu, noithuchien=@noithuchien WHERE id=@id", 
					"@ma",  _MedLoaiVp.ma, 
					"@ten",  _MedLoaiVp.ten, 
					"@id_nhom",  _MedLoaiVp.id_nhom, 
					"@userid",  _MedLoaiVp.userid, 
					"@stt",  _MedLoaiVp.stt, 
					"@report",  _MedLoaiVp.report, 
					"@kyhieu",  _MedLoaiVp.kyhieu, 
					"@noithuchien",  _MedLoaiVp.noithuchien, 
					"@id", _MedLoaiVp.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedLoaiVp vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedLoaiVp> _MedLoaiVps)
		{
			foreach (MedLoaiVp item in _MedLoaiVps)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedLoaiVp vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedLoaiVp _MedLoaiVp, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedLoaiVp] SET id=@id, ma=@ma, ten=@ten, id_nhom=@id_nhom, userid=@userid, stt=@stt, report=@report, kyhieu=@kyhieu, noithuchien=@noithuchien "+ condition, 
					"@id",  _MedLoaiVp.id, 
					"@ma",  _MedLoaiVp.ma, 
					"@ten",  _MedLoaiVp.ten, 
					"@id_nhom",  _MedLoaiVp.id_nhom, 
					"@userid",  _MedLoaiVp.userid, 
					"@stt",  _MedLoaiVp.stt, 
					"@report",  _MedLoaiVp.report, 
					"@kyhieu",  _MedLoaiVp.kyhieu, 
					"@noithuchien",  _MedLoaiVp.noithuchien);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedLoaiVp trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedLoaiVp] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedLoaiVp trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedLoaiVp _MedLoaiVp)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedLoaiVp] WHERE id=@id",
					"@id", _MedLoaiVp.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedLoaiVp trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedLoaiVp] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedLoaiVp trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedLoaiVp> _MedLoaiVps)
		{
			foreach (MedLoaiVp item in _MedLoaiVps)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
