using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdbacsicdha:IMEdbacsicdha
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdbacsicdha(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedBacSiCDHA từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedBacSiCDHA]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedBacSiCDHA từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedBacSiCDHA] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedBacSiCDHA từ Database
		/// </summary>
		public List<MedBacSiCDHA> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedBacSiCDHA]");
				List<MedBacSiCDHA> items = new List<MedBacSiCDHA>();
				MedBacSiCDHA item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedBacSiCDHA();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToInt32(dr["id"]);
					}
					if (dr["tenbacsi"] != null && dr["tenbacsi"] != DBNull.Value)
					{
						item.tenbacsi = Convert.ToString(dr["tenbacsi"]);
					}
					if (dr["createdate"] != null && dr["createdate"] != DBNull.Value)
					{
						item.createdate = Convert.ToDateTime(dr["createdate"]);
					}
					if (dr["createuser"] != null && dr["createuser"] != DBNull.Value)
					{
						item.createuser = Convert.ToString(dr["createuser"]);
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
		/// Lấy danh sách MedBacSiCDHA từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedBacSiCDHA> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedBacSiCDHA] A "+ condition,  parameters);
				List<MedBacSiCDHA> items = new List<MedBacSiCDHA>();
				MedBacSiCDHA item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedBacSiCDHA();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToInt32(dr["id"]);
					}
					if (dr["tenbacsi"] != null && dr["tenbacsi"] != DBNull.Value)
					{
						item.tenbacsi = Convert.ToString(dr["tenbacsi"]);
					}
					if (dr["createdate"] != null && dr["createdate"] != DBNull.Value)
					{
						item.createdate = Convert.ToDateTime(dr["createdate"]);
					}
					if (dr["createuser"] != null && dr["createuser"] != DBNull.Value)
					{
						item.createuser = Convert.ToString(dr["createuser"]);
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

		public List<MedBacSiCDHA> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedBacSiCDHA] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedBacSiCDHA] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedBacSiCDHA>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedBacSiCDHA từ Database
		/// </summary>
		public MedBacSiCDHA GetObject(string schema, Int32 id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedBacSiCDHA] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedBacSiCDHA item=new MedBacSiCDHA();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToInt32(dr["id"]);
						}
						if (dr["tenbacsi"] != null && dr["tenbacsi"] != DBNull.Value)
						{
							item.tenbacsi = Convert.ToString(dr["tenbacsi"]);
						}
						if (dr["createdate"] != null && dr["createdate"] != DBNull.Value)
						{
							item.createdate = Convert.ToDateTime(dr["createdate"]);
						}
						if (dr["createuser"] != null && dr["createuser"] != DBNull.Value)
						{
							item.createuser = Convert.ToString(dr["createuser"]);
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
		/// Lấy một MedBacSiCDHA đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedBacSiCDHA GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedBacSiCDHA] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedBacSiCDHA item=new MedBacSiCDHA();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToInt32(dr["id"]);
						}
						if (dr["tenbacsi"] != null && dr["tenbacsi"] != DBNull.Value)
						{
							item.tenbacsi = Convert.ToString(dr["tenbacsi"]);
						}
						if (dr["createdate"] != null && dr["createdate"] != DBNull.Value)
						{
							item.createdate = Convert.ToDateTime(dr["createdate"]);
						}
						if (dr["createuser"] != null && dr["createuser"] != DBNull.Value)
						{
							item.createuser = Convert.ToString(dr["createuser"]);
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

		public MedBacSiCDHA GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedBacSiCDHA] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedBacSiCDHA>(ds);
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
		/// Thêm mới MedBacSiCDHA vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedBacSiCDHA _MedBacSiCDHA)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedBacSiCDHA](id, tenbacsi, createdate, createuser) VALUES(@id, @tenbacsi, @createdate, @createuser)", 
					"@id",  _MedBacSiCDHA.id, 
					"@tenbacsi",  _MedBacSiCDHA.tenbacsi, 
					"@createdate", this._dataContext.ConvertDateString( _MedBacSiCDHA.createdate), 
					"@createuser",  _MedBacSiCDHA.createuser);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedBacSiCDHA vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedBacSiCDHA> _MedBacSiCDHAs)
		{
			foreach (MedBacSiCDHA item in _MedBacSiCDHAs)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedBacSiCDHA vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedBacSiCDHA _MedBacSiCDHA, Int32 id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedBacSiCDHA] SET id=@id, tenbacsi=@tenbacsi, createdate=@createdate, createuser=@createuser WHERE id=@id", 
					"@id",  _MedBacSiCDHA.id, 
					"@tenbacsi",  _MedBacSiCDHA.tenbacsi, 
					"@createdate", this._dataContext.ConvertDateString( _MedBacSiCDHA.createdate), 
					"@createuser",  _MedBacSiCDHA.createuser, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedBacSiCDHA vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedBacSiCDHA _MedBacSiCDHA)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedBacSiCDHA] SET tenbacsi=@tenbacsi, createdate=@createdate, createuser=@createuser WHERE id=@id", 
					"@tenbacsi",  _MedBacSiCDHA.tenbacsi, 
					"@createdate", this._dataContext.ConvertDateString( _MedBacSiCDHA.createdate), 
					"@createuser",  _MedBacSiCDHA.createuser, 
					"@id", _MedBacSiCDHA.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedBacSiCDHA vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedBacSiCDHA> _MedBacSiCDHAs)
		{
			foreach (MedBacSiCDHA item in _MedBacSiCDHAs)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedBacSiCDHA vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedBacSiCDHA _MedBacSiCDHA, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedBacSiCDHA] SET id=@id, tenbacsi=@tenbacsi, createdate=@createdate, createuser=@createuser "+ condition, 
					"@id",  _MedBacSiCDHA.id, 
					"@tenbacsi",  _MedBacSiCDHA.tenbacsi, 
					"@createdate", this._dataContext.ConvertDateString( _MedBacSiCDHA.createdate), 
					"@createuser",  _MedBacSiCDHA.createuser);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedBacSiCDHA trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, Int32 id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedBacSiCDHA] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedBacSiCDHA trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedBacSiCDHA _MedBacSiCDHA)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedBacSiCDHA] WHERE id=@id",
					"@id", _MedBacSiCDHA.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedBacSiCDHA trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedBacSiCDHA] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedBacSiCDHA trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedBacSiCDHA> _MedBacSiCDHAs)
		{
			foreach (MedBacSiCDHA item in _MedBacSiCDHAs)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
