using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEddmso:IMEddmso
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEddmso(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedDmSo từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedDmSo]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedDmSo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedDmSo] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedDmSo từ Database
		/// </summary>
		public List<MedDmSo> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedDmSo]");
				List<MedDmSo> items = new List<MedDmSo>();
				MedDmSo item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedDmSo();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToInt32(dr["id"]);
					}
					if (dr["stt"] != null && dr["stt"] != DBNull.Value)
					{
						item.stt = Convert.ToInt32(dr["stt"]);
					}
					if (dr["ma"] != null && dr["ma"] != DBNull.Value)
					{
						item.ma = Convert.ToString(dr["ma"]);
					}
					if (dr["ten"] != null && dr["ten"] != DBNull.Value)
					{
						item.ten = Convert.ToString(dr["ten"]);
					}
					if (dr["report"] != null && dr["report"] != DBNull.Value)
					{
						item.report = Convert.ToString(dr["report"]);
					}
					if (dr["idso"] != null && dr["idso"] != DBNull.Value)
					{
						item.idso = Convert.ToDecimal(dr["idso"]);
					}
					if (dr["kyhieu"] != null && dr["kyhieu"] != DBNull.Value)
					{
						item.kyhieu = Convert.ToString(dr["kyhieu"]);
					}
					if (dr["thoigiantrakq"] != null && dr["thoigiantrakq"] != DBNull.Value)
					{
						item.thoigiantrakq = Convert.ToDecimal(dr["thoigiantrakq"]);
					}
					if (dr["nhommavach"] != null && dr["nhommavach"] != DBNull.Value)
					{
						item.nhommavach = Convert.ToInt32(dr["nhommavach"]);
					}
					if (dr["thoigiantrakqcc"] != null && dr["thoigiantrakqcc"] != DBNull.Value)
					{
						item.thoigiantrakqcc = Convert.ToDecimal(dr["thoigiantrakqcc"]);
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
		/// Lấy danh sách MedDmSo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedDmSo> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedDmSo] A "+ condition,  parameters);
				List<MedDmSo> items = new List<MedDmSo>();
				MedDmSo item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedDmSo();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToInt32(dr["id"]);
					}
					if (dr["stt"] != null && dr["stt"] != DBNull.Value)
					{
						item.stt = Convert.ToInt32(dr["stt"]);
					}
					if (dr["ma"] != null && dr["ma"] != DBNull.Value)
					{
						item.ma = Convert.ToString(dr["ma"]);
					}
					if (dr["ten"] != null && dr["ten"] != DBNull.Value)
					{
						item.ten = Convert.ToString(dr["ten"]);
					}
					if (dr["report"] != null && dr["report"] != DBNull.Value)
					{
						item.report = Convert.ToString(dr["report"]);
					}
					if (dr["idso"] != null && dr["idso"] != DBNull.Value)
					{
						item.idso = Convert.ToDecimal(dr["idso"]);
					}
					if (dr["kyhieu"] != null && dr["kyhieu"] != DBNull.Value)
					{
						item.kyhieu = Convert.ToString(dr["kyhieu"]);
					}
					if (dr["thoigiantrakq"] != null && dr["thoigiantrakq"] != DBNull.Value)
					{
						item.thoigiantrakq = Convert.ToDecimal(dr["thoigiantrakq"]);
					}
					if (dr["nhommavach"] != null && dr["nhommavach"] != DBNull.Value)
					{
						item.nhommavach = Convert.ToInt32(dr["nhommavach"]);
					}
					if (dr["thoigiantrakqcc"] != null && dr["thoigiantrakqcc"] != DBNull.Value)
					{
						item.thoigiantrakqcc = Convert.ToDecimal(dr["thoigiantrakqcc"]);
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

		public List<MedDmSo> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedDmSo] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedDmSo] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedDmSo>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedDmSo từ Database
		/// </summary>
		public MedDmSo GetObject(string schema, Int32 id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedDmSo] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedDmSo item=new MedDmSo();
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
						if (dr["ma"] != null && dr["ma"] != DBNull.Value)
						{
							item.ma = Convert.ToString(dr["ma"]);
						}
						if (dr["ten"] != null && dr["ten"] != DBNull.Value)
						{
							item.ten = Convert.ToString(dr["ten"]);
						}
						if (dr["report"] != null && dr["report"] != DBNull.Value)
						{
							item.report = Convert.ToString(dr["report"]);
						}
						if (dr["idso"] != null && dr["idso"] != DBNull.Value)
						{
							item.idso = Convert.ToDecimal(dr["idso"]);
						}
						if (dr["kyhieu"] != null && dr["kyhieu"] != DBNull.Value)
						{
							item.kyhieu = Convert.ToString(dr["kyhieu"]);
						}
						if (dr["thoigiantrakq"] != null && dr["thoigiantrakq"] != DBNull.Value)
						{
							item.thoigiantrakq = Convert.ToDecimal(dr["thoigiantrakq"]);
						}
						if (dr["nhommavach"] != null && dr["nhommavach"] != DBNull.Value)
						{
							item.nhommavach = Convert.ToInt32(dr["nhommavach"]);
						}
						if (dr["thoigiantrakqcc"] != null && dr["thoigiantrakqcc"] != DBNull.Value)
						{
							item.thoigiantrakqcc = Convert.ToDecimal(dr["thoigiantrakqcc"]);
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
		/// Lấy một MedDmSo đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedDmSo GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedDmSo] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedDmSo item=new MedDmSo();
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
						if (dr["ma"] != null && dr["ma"] != DBNull.Value)
						{
							item.ma = Convert.ToString(dr["ma"]);
						}
						if (dr["ten"] != null && dr["ten"] != DBNull.Value)
						{
							item.ten = Convert.ToString(dr["ten"]);
						}
						if (dr["report"] != null && dr["report"] != DBNull.Value)
						{
							item.report = Convert.ToString(dr["report"]);
						}
						if (dr["idso"] != null && dr["idso"] != DBNull.Value)
						{
							item.idso = Convert.ToDecimal(dr["idso"]);
						}
						if (dr["kyhieu"] != null && dr["kyhieu"] != DBNull.Value)
						{
							item.kyhieu = Convert.ToString(dr["kyhieu"]);
						}
						if (dr["thoigiantrakq"] != null && dr["thoigiantrakq"] != DBNull.Value)
						{
							item.thoigiantrakq = Convert.ToDecimal(dr["thoigiantrakq"]);
						}
						if (dr["nhommavach"] != null && dr["nhommavach"] != DBNull.Value)
						{
							item.nhommavach = Convert.ToInt32(dr["nhommavach"]);
						}
						if (dr["thoigiantrakqcc"] != null && dr["thoigiantrakqcc"] != DBNull.Value)
						{
							item.thoigiantrakqcc = Convert.ToDecimal(dr["thoigiantrakqcc"]);
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

		public MedDmSo GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedDmSo] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedDmSo>(ds);
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
		/// Thêm mới MedDmSo vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedDmSo _MedDmSo)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedDmSo](id, stt, ma, ten, report, idso, kyhieu, thoigiantrakq, nhommavach, thoigiantrakqcc) VALUES(@id, @stt, @ma, @ten, @report, @idso, @kyhieu, @thoigiantrakq, @nhommavach, @thoigiantrakqcc)", 
					"@id",  _MedDmSo.id, 
					"@stt",  _MedDmSo.stt, 
					"@ma",  _MedDmSo.ma, 
					"@ten",  _MedDmSo.ten, 
					"@report",  _MedDmSo.report, 
					"@idso",  _MedDmSo.idso, 
					"@kyhieu",  _MedDmSo.kyhieu, 
					"@thoigiantrakq",  _MedDmSo.thoigiantrakq, 
					"@nhommavach",  _MedDmSo.nhommavach, 
					"@thoigiantrakqcc",  _MedDmSo.thoigiantrakqcc);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedDmSo vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedDmSo> _MedDmSos)
		{
			foreach (MedDmSo item in _MedDmSos)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedDmSo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedDmSo _MedDmSo, Int32 id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedDmSo] SET id=@id, stt=@stt, ma=@ma, ten=@ten, report=@report, idso=@idso, kyhieu=@kyhieu, thoigiantrakq=@thoigiantrakq, nhommavach=@nhommavach, thoigiantrakqcc=@thoigiantrakqcc WHERE id=@id", 
					"@id",  _MedDmSo.id, 
					"@stt",  _MedDmSo.stt, 
					"@ma",  _MedDmSo.ma, 
					"@ten",  _MedDmSo.ten, 
					"@report",  _MedDmSo.report, 
					"@idso",  _MedDmSo.idso, 
					"@kyhieu",  _MedDmSo.kyhieu, 
					"@thoigiantrakq",  _MedDmSo.thoigiantrakq, 
					"@nhommavach",  _MedDmSo.nhommavach, 
					"@thoigiantrakqcc",  _MedDmSo.thoigiantrakqcc, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedDmSo vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedDmSo _MedDmSo)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedDmSo] SET stt=@stt, ma=@ma, ten=@ten, report=@report, idso=@idso, kyhieu=@kyhieu, thoigiantrakq=@thoigiantrakq, nhommavach=@nhommavach, thoigiantrakqcc=@thoigiantrakqcc WHERE id=@id", 
					"@stt",  _MedDmSo.stt, 
					"@ma",  _MedDmSo.ma, 
					"@ten",  _MedDmSo.ten, 
					"@report",  _MedDmSo.report, 
					"@idso",  _MedDmSo.idso, 
					"@kyhieu",  _MedDmSo.kyhieu, 
					"@thoigiantrakq",  _MedDmSo.thoigiantrakq, 
					"@nhommavach",  _MedDmSo.nhommavach, 
					"@thoigiantrakqcc",  _MedDmSo.thoigiantrakqcc, 
					"@id", _MedDmSo.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedDmSo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedDmSo> _MedDmSos)
		{
			foreach (MedDmSo item in _MedDmSos)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedDmSo vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedDmSo _MedDmSo, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedDmSo] SET id=@id, stt=@stt, ma=@ma, ten=@ten, report=@report, idso=@idso, kyhieu=@kyhieu, thoigiantrakq=@thoigiantrakq, nhommavach=@nhommavach, thoigiantrakqcc=@thoigiantrakqcc "+ condition, 
					"@id",  _MedDmSo.id, 
					"@stt",  _MedDmSo.stt, 
					"@ma",  _MedDmSo.ma, 
					"@ten",  _MedDmSo.ten, 
					"@report",  _MedDmSo.report, 
					"@idso",  _MedDmSo.idso, 
					"@kyhieu",  _MedDmSo.kyhieu, 
					"@thoigiantrakq",  _MedDmSo.thoigiantrakq, 
					"@nhommavach",  _MedDmSo.nhommavach, 
					"@thoigiantrakqcc",  _MedDmSo.thoigiantrakqcc);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedDmSo trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedDmSo] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedDmSo trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedDmSo _MedDmSo)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedDmSo] WHERE id=@id",
					"@id", _MedDmSo.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedDmSo trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedDmSo] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedDmSo trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedDmSo> _MedDmSos)
		{
			foreach (MedDmSo item in _MedDmSos)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
