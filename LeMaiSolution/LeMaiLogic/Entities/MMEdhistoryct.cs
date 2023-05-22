using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdhistoryct:IMEdhistoryct
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdhistoryct(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedHiStoryCT từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedHiStoryCT]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedHiStoryCT từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedHiStoryCT] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedHiStoryCT từ Database
		/// </summary>
		public List<MedHiStoryCT> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedHiStoryCT]");
				List<MedHiStoryCT> items = new List<MedHiStoryCT>();
				MedHiStoryCT item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedHiStoryCT();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["id_history"] != null && dr["id_history"] != DBNull.Value)
					{
						item.id_history = Convert.ToString(dr["id_history"]);
					}
					if (dr["id_user"] != null && dr["id_user"] != DBNull.Value)
					{
						item.id_user = Convert.ToString(dr["id_user"]);
					}
					if (dr["ngaytao"] != null && dr["ngaytao"] != DBNull.Value)
					{
						item.ngaytao = Convert.ToDateTime(dr["ngaytao"]);
					}
					if (dr["enumaction"] != null && dr["enumaction"] != DBNull.Value)
					{
						item.enumaction = Convert.ToString(dr["enumaction"]);
					}
					if (dr["actioned"] != null && dr["actioned"] != DBNull.Value)
					{
						item.actioned = Convert.ToString(dr["actioned"]);
					}
					if (dr["id_actioned"] != null && dr["id_actioned"] != DBNull.Value)
					{
						item.id_actioned = Convert.ToString(dr["id_actioned"]);
					}
					if (dr["maql"] != null && dr["maql"] != DBNull.Value)
					{
						item.maql = Convert.ToString(dr["maql"]);
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
		/// Lấy danh sách MedHiStoryCT từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedHiStoryCT> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedHiStoryCT] A "+ condition,  parameters);
				List<MedHiStoryCT> items = new List<MedHiStoryCT>();
				MedHiStoryCT item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedHiStoryCT();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["id_history"] != null && dr["id_history"] != DBNull.Value)
					{
						item.id_history = Convert.ToString(dr["id_history"]);
					}
					if (dr["id_user"] != null && dr["id_user"] != DBNull.Value)
					{
						item.id_user = Convert.ToString(dr["id_user"]);
					}
					if (dr["ngaytao"] != null && dr["ngaytao"] != DBNull.Value)
					{
						item.ngaytao = Convert.ToDateTime(dr["ngaytao"]);
					}
					if (dr["enumaction"] != null && dr["enumaction"] != DBNull.Value)
					{
						item.enumaction = Convert.ToString(dr["enumaction"]);
					}
					if (dr["actioned"] != null && dr["actioned"] != DBNull.Value)
					{
						item.actioned = Convert.ToString(dr["actioned"]);
					}
					if (dr["id_actioned"] != null && dr["id_actioned"] != DBNull.Value)
					{
						item.id_actioned = Convert.ToString(dr["id_actioned"]);
					}
					if (dr["maql"] != null && dr["maql"] != DBNull.Value)
					{
						item.maql = Convert.ToString(dr["maql"]);
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

		public List<MedHiStoryCT> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedHiStoryCT] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedHiStoryCT] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedHiStoryCT>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedHiStoryCT từ Database
		/// </summary>
		public MedHiStoryCT GetObject(string schema, String id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedHiStoryCT] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedHiStoryCT item=new MedHiStoryCT();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["id_history"] != null && dr["id_history"] != DBNull.Value)
						{
							item.id_history = Convert.ToString(dr["id_history"]);
						}
						if (dr["id_user"] != null && dr["id_user"] != DBNull.Value)
						{
							item.id_user = Convert.ToString(dr["id_user"]);
						}
						if (dr["ngaytao"] != null && dr["ngaytao"] != DBNull.Value)
						{
							item.ngaytao = Convert.ToDateTime(dr["ngaytao"]);
						}
						if (dr["enumaction"] != null && dr["enumaction"] != DBNull.Value)
						{
							item.enumaction = Convert.ToString(dr["enumaction"]);
						}
						if (dr["actioned"] != null && dr["actioned"] != DBNull.Value)
						{
							item.actioned = Convert.ToString(dr["actioned"]);
						}
						if (dr["id_actioned"] != null && dr["id_actioned"] != DBNull.Value)
						{
							item.id_actioned = Convert.ToString(dr["id_actioned"]);
						}
						if (dr["maql"] != null && dr["maql"] != DBNull.Value)
						{
							item.maql = Convert.ToString(dr["maql"]);
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
		/// Lấy một MedHiStoryCT đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedHiStoryCT GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedHiStoryCT] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedHiStoryCT item=new MedHiStoryCT();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["id_history"] != null && dr["id_history"] != DBNull.Value)
						{
							item.id_history = Convert.ToString(dr["id_history"]);
						}
						if (dr["id_user"] != null && dr["id_user"] != DBNull.Value)
						{
							item.id_user = Convert.ToString(dr["id_user"]);
						}
						if (dr["ngaytao"] != null && dr["ngaytao"] != DBNull.Value)
						{
							item.ngaytao = Convert.ToDateTime(dr["ngaytao"]);
						}
						if (dr["enumaction"] != null && dr["enumaction"] != DBNull.Value)
						{
							item.enumaction = Convert.ToString(dr["enumaction"]);
						}
						if (dr["actioned"] != null && dr["actioned"] != DBNull.Value)
						{
							item.actioned = Convert.ToString(dr["actioned"]);
						}
						if (dr["id_actioned"] != null && dr["id_actioned"] != DBNull.Value)
						{
							item.id_actioned = Convert.ToString(dr["id_actioned"]);
						}
						if (dr["maql"] != null && dr["maql"] != DBNull.Value)
						{
							item.maql = Convert.ToString(dr["maql"]);
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

		public MedHiStoryCT GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedHiStoryCT] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedHiStoryCT>(ds);
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
		/// Thêm mới MedHiStoryCT vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedHiStoryCT _MedHiStoryCT)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedHiStoryCT](id, id_history, id_user, ngaytao, enumaction, actioned, id_actioned, maql) VALUES(@id, @id_history, @id_user, @ngaytao, @enumaction, @actioned, @id_actioned, @maql)", 
					"@id",  _MedHiStoryCT.id, 
					"@id_history",  _MedHiStoryCT.id_history, 
					"@id_user",  _MedHiStoryCT.id_user, 
					"@ngaytao", this._dataContext.ConvertDateString( _MedHiStoryCT.ngaytao), 
					"@enumaction",  _MedHiStoryCT.enumaction, 
					"@actioned",  _MedHiStoryCT.actioned, 
					"@id_actioned",  _MedHiStoryCT.id_actioned, 
					"@maql",  _MedHiStoryCT.maql);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedHiStoryCT vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedHiStoryCT> _MedHiStoryCTs)
		{
			foreach (MedHiStoryCT item in _MedHiStoryCTs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedHiStoryCT vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedHiStoryCT _MedHiStoryCT, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedHiStoryCT] SET id=@id, id_history=@id_history, id_user=@id_user, ngaytao=@ngaytao, enumaction=@enumaction, actioned=@actioned, id_actioned=@id_actioned, maql=@maql WHERE id=@id", 
					"@id",  _MedHiStoryCT.id, 
					"@id_history",  _MedHiStoryCT.id_history, 
					"@id_user",  _MedHiStoryCT.id_user, 
					"@ngaytao", this._dataContext.ConvertDateString( _MedHiStoryCT.ngaytao), 
					"@enumaction",  _MedHiStoryCT.enumaction, 
					"@actioned",  _MedHiStoryCT.actioned, 
					"@id_actioned",  _MedHiStoryCT.id_actioned, 
					"@maql",  _MedHiStoryCT.maql, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedHiStoryCT vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedHiStoryCT _MedHiStoryCT)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedHiStoryCT] SET id_history=@id_history, id_user=@id_user, ngaytao=@ngaytao, enumaction=@enumaction, actioned=@actioned, id_actioned=@id_actioned, maql=@maql WHERE id=@id", 
					"@id_history",  _MedHiStoryCT.id_history, 
					"@id_user",  _MedHiStoryCT.id_user, 
					"@ngaytao", this._dataContext.ConvertDateString( _MedHiStoryCT.ngaytao), 
					"@enumaction",  _MedHiStoryCT.enumaction, 
					"@actioned",  _MedHiStoryCT.actioned, 
					"@id_actioned",  _MedHiStoryCT.id_actioned, 
					"@maql",  _MedHiStoryCT.maql, 
					"@id", _MedHiStoryCT.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedHiStoryCT vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedHiStoryCT> _MedHiStoryCTs)
		{
			foreach (MedHiStoryCT item in _MedHiStoryCTs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedHiStoryCT vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedHiStoryCT _MedHiStoryCT, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedHiStoryCT] SET id=@id, id_history=@id_history, id_user=@id_user, ngaytao=@ngaytao, enumaction=@enumaction, actioned=@actioned, id_actioned=@id_actioned, maql=@maql "+ condition, 
					"@id",  _MedHiStoryCT.id, 
					"@id_history",  _MedHiStoryCT.id_history, 
					"@id_user",  _MedHiStoryCT.id_user, 
					"@ngaytao", this._dataContext.ConvertDateString( _MedHiStoryCT.ngaytao), 
					"@enumaction",  _MedHiStoryCT.enumaction, 
					"@actioned",  _MedHiStoryCT.actioned, 
					"@id_actioned",  _MedHiStoryCT.id_actioned, 
					"@maql",  _MedHiStoryCT.maql);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedHiStoryCT trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedHiStoryCT] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedHiStoryCT trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedHiStoryCT _MedHiStoryCT)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedHiStoryCT] WHERE id=@id",
					"@id", _MedHiStoryCT.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedHiStoryCT trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedHiStoryCT] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedHiStoryCT trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedHiStoryCT> _MedHiStoryCTs)
		{
			foreach (MedHiStoryCT item in _MedHiStoryCTs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
