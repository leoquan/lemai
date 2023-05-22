using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdlogin:IMEdlogin
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdlogin(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedLogin từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedLogin]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedLogin từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedLogin] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedLogin từ Database
		/// </summary>
		public List<MedLogin> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedLogin]");
				List<MedLogin> items = new List<MedLogin>();
				MedLogin item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedLogin();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["id_user"] != null && dr["id_user"] != DBNull.Value)
					{
						item.id_user = Convert.ToString(dr["id_user"]);
					}
					if (dr["tenmay"] != null && dr["tenmay"] != DBNull.Value)
					{
						item.tenmay = Convert.ToString(dr["tenmay"]);
					}
					if (dr["ngaylogin"] != null && dr["ngaylogin"] != DBNull.Value)
					{
						item.ngaylogin = Convert.ToDateTime(dr["ngaylogin"]);
					}
					if (dr["ipaddress"] != null && dr["ipaddress"] != DBNull.Value)
					{
						item.ipaddress = Convert.ToString(dr["ipaddress"]);
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
		/// Lấy danh sách MedLogin từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedLogin> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedLogin] A "+ condition,  parameters);
				List<MedLogin> items = new List<MedLogin>();
				MedLogin item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedLogin();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["id_user"] != null && dr["id_user"] != DBNull.Value)
					{
						item.id_user = Convert.ToString(dr["id_user"]);
					}
					if (dr["tenmay"] != null && dr["tenmay"] != DBNull.Value)
					{
						item.tenmay = Convert.ToString(dr["tenmay"]);
					}
					if (dr["ngaylogin"] != null && dr["ngaylogin"] != DBNull.Value)
					{
						item.ngaylogin = Convert.ToDateTime(dr["ngaylogin"]);
					}
					if (dr["ipaddress"] != null && dr["ipaddress"] != DBNull.Value)
					{
						item.ipaddress = Convert.ToString(dr["ipaddress"]);
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

		public List<MedLogin> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedLogin] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedLogin] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedLogin>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedLogin từ Database
		/// </summary>
		public MedLogin GetObject(string schema, String id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedLogin] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedLogin item=new MedLogin();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["id_user"] != null && dr["id_user"] != DBNull.Value)
						{
							item.id_user = Convert.ToString(dr["id_user"]);
						}
						if (dr["tenmay"] != null && dr["tenmay"] != DBNull.Value)
						{
							item.tenmay = Convert.ToString(dr["tenmay"]);
						}
						if (dr["ngaylogin"] != null && dr["ngaylogin"] != DBNull.Value)
						{
							item.ngaylogin = Convert.ToDateTime(dr["ngaylogin"]);
						}
						if (dr["ipaddress"] != null && dr["ipaddress"] != DBNull.Value)
						{
							item.ipaddress = Convert.ToString(dr["ipaddress"]);
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
		/// Lấy một MedLogin đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedLogin GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedLogin] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedLogin item=new MedLogin();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["id_user"] != null && dr["id_user"] != DBNull.Value)
						{
							item.id_user = Convert.ToString(dr["id_user"]);
						}
						if (dr["tenmay"] != null && dr["tenmay"] != DBNull.Value)
						{
							item.tenmay = Convert.ToString(dr["tenmay"]);
						}
						if (dr["ngaylogin"] != null && dr["ngaylogin"] != DBNull.Value)
						{
							item.ngaylogin = Convert.ToDateTime(dr["ngaylogin"]);
						}
						if (dr["ipaddress"] != null && dr["ipaddress"] != DBNull.Value)
						{
							item.ipaddress = Convert.ToString(dr["ipaddress"]);
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

		public MedLogin GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedLogin] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedLogin>(ds);
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
		/// Thêm mới MedLogin vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedLogin _MedLogin)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedLogin](id, id_user, tenmay, ngaylogin, ipaddress) VALUES(@id, @id_user, @tenmay, @ngaylogin, @ipaddress)", 
					"@id",  _MedLogin.id, 
					"@id_user",  _MedLogin.id_user, 
					"@tenmay",  _MedLogin.tenmay, 
					"@ngaylogin", this._dataContext.ConvertDateString( _MedLogin.ngaylogin), 
					"@ipaddress",  _MedLogin.ipaddress);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedLogin vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedLogin> _MedLogins)
		{
			foreach (MedLogin item in _MedLogins)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedLogin vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedLogin _MedLogin, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedLogin] SET id=@id, id_user=@id_user, tenmay=@tenmay, ngaylogin=@ngaylogin, ipaddress=@ipaddress WHERE id=@id", 
					"@id",  _MedLogin.id, 
					"@id_user",  _MedLogin.id_user, 
					"@tenmay",  _MedLogin.tenmay, 
					"@ngaylogin", this._dataContext.ConvertDateString( _MedLogin.ngaylogin), 
					"@ipaddress",  _MedLogin.ipaddress, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedLogin vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedLogin _MedLogin)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedLogin] SET id_user=@id_user, tenmay=@tenmay, ngaylogin=@ngaylogin, ipaddress=@ipaddress WHERE id=@id", 
					"@id_user",  _MedLogin.id_user, 
					"@tenmay",  _MedLogin.tenmay, 
					"@ngaylogin", this._dataContext.ConvertDateString( _MedLogin.ngaylogin), 
					"@ipaddress",  _MedLogin.ipaddress, 
					"@id", _MedLogin.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedLogin vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedLogin> _MedLogins)
		{
			foreach (MedLogin item in _MedLogins)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedLogin vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedLogin _MedLogin, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedLogin] SET id=@id, id_user=@id_user, tenmay=@tenmay, ngaylogin=@ngaylogin, ipaddress=@ipaddress "+ condition, 
					"@id",  _MedLogin.id, 
					"@id_user",  _MedLogin.id_user, 
					"@tenmay",  _MedLogin.tenmay, 
					"@ngaylogin", this._dataContext.ConvertDateString( _MedLogin.ngaylogin), 
					"@ipaddress",  _MedLogin.ipaddress);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedLogin trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedLogin] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedLogin trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedLogin _MedLogin)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedLogin] WHERE id=@id",
					"@id", _MedLogin.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedLogin trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedLogin] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedLogin trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedLogin> _MedLogins)
		{
			foreach (MedLogin item in _MedLogins)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
