using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MMEdserver:IMEdserver
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MMEdserver(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable MedServer từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedServer]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable MedServer từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[MedServer] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách MedServer từ Database
		/// </summary>
		public List<MedServer> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedServer]");
				List<MedServer> items = new List<MedServer>();
				MedServer item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedServer();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["servername"] != null && dr["servername"] != DBNull.Value)
					{
						item.servername = Convert.ToString(dr["servername"]);
					}
					if (dr["address"] != null && dr["address"] != DBNull.Value)
					{
						item.address = Convert.ToString(dr["address"]);
					}
					if (dr["userftp"] != null && dr["userftp"] != DBNull.Value)
					{
						item.userftp = Convert.ToString(dr["userftp"]);
					}
					if (dr["passftp"] != null && dr["passftp"] != DBNull.Value)
					{
						item.passftp = Convert.ToString(dr["passftp"]);
					}
					if (dr["ftpport"] != null && dr["ftpport"] != DBNull.Value)
					{
						item.ftpport = Convert.ToInt32(dr["ftpport"]);
					}
					if (dr["ftppath"] != null && dr["ftppath"] != DBNull.Value)
					{
						item.ftppath = Convert.ToString(dr["ftppath"]);
					}
					if (dr["createdate"] != null && dr["createdate"] != DBNull.Value)
					{
						item.createdate = Convert.ToDateTime(dr["createdate"]);
					}
					if (dr["createuser"] != null && dr["createuser"] != DBNull.Value)
					{
						item.createuser = Convert.ToString(dr["createuser"]);
					}
					if (dr["sudung"] != null && dr["sudung"] != DBNull.Value)
					{
						item.sudung = Convert.ToBoolean(dr["sudung"]);
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
		/// Lấy danh sách MedServer từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<MedServer> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedServer] A "+ condition,  parameters);
				List<MedServer> items = new List<MedServer>();
				MedServer item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new MedServer();
					if (dr["id"] != null && dr["id"] != DBNull.Value)
					{
						item.id = Convert.ToString(dr["id"]);
					}
					if (dr["servername"] != null && dr["servername"] != DBNull.Value)
					{
						item.servername = Convert.ToString(dr["servername"]);
					}
					if (dr["address"] != null && dr["address"] != DBNull.Value)
					{
						item.address = Convert.ToString(dr["address"]);
					}
					if (dr["userftp"] != null && dr["userftp"] != DBNull.Value)
					{
						item.userftp = Convert.ToString(dr["userftp"]);
					}
					if (dr["passftp"] != null && dr["passftp"] != DBNull.Value)
					{
						item.passftp = Convert.ToString(dr["passftp"]);
					}
					if (dr["ftpport"] != null && dr["ftpport"] != DBNull.Value)
					{
						item.ftpport = Convert.ToInt32(dr["ftpport"]);
					}
					if (dr["ftppath"] != null && dr["ftppath"] != DBNull.Value)
					{
						item.ftppath = Convert.ToString(dr["ftppath"]);
					}
					if (dr["createdate"] != null && dr["createdate"] != DBNull.Value)
					{
						item.createdate = Convert.ToDateTime(dr["createdate"]);
					}
					if (dr["createuser"] != null && dr["createuser"] != DBNull.Value)
					{
						item.createuser = Convert.ToString(dr["createuser"]);
					}
					if (dr["sudung"] != null && dr["sudung"] != DBNull.Value)
					{
						item.sudung = Convert.ToBoolean(dr["sudung"]);
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

		public List<MedServer> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedServer] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[MedServer] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<MedServer>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một MedServer từ Database
		/// </summary>
		public MedServer GetObject(string schema, String id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[MedServer] where id=@id",
					"@id", id);
				if (ds.Rows.Count > 0)
				{
					MedServer item=new MedServer();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["servername"] != null && dr["servername"] != DBNull.Value)
						{
							item.servername = Convert.ToString(dr["servername"]);
						}
						if (dr["address"] != null && dr["address"] != DBNull.Value)
						{
							item.address = Convert.ToString(dr["address"]);
						}
						if (dr["userftp"] != null && dr["userftp"] != DBNull.Value)
						{
							item.userftp = Convert.ToString(dr["userftp"]);
						}
						if (dr["passftp"] != null && dr["passftp"] != DBNull.Value)
						{
							item.passftp = Convert.ToString(dr["passftp"]);
						}
						if (dr["ftpport"] != null && dr["ftpport"] != DBNull.Value)
						{
							item.ftpport = Convert.ToInt32(dr["ftpport"]);
						}
						if (dr["ftppath"] != null && dr["ftppath"] != DBNull.Value)
						{
							item.ftppath = Convert.ToString(dr["ftppath"]);
						}
						if (dr["createdate"] != null && dr["createdate"] != DBNull.Value)
						{
							item.createdate = Convert.ToDateTime(dr["createdate"]);
						}
						if (dr["createuser"] != null && dr["createuser"] != DBNull.Value)
						{
							item.createuser = Convert.ToString(dr["createuser"]);
						}
						if (dr["sudung"] != null && dr["sudung"] != DBNull.Value)
						{
							item.sudung = Convert.ToBoolean(dr["sudung"]);
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
		/// Lấy một MedServer đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public MedServer GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[MedServer] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					MedServer item=new MedServer();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["id"] != null && dr["id"] != DBNull.Value)
						{
							item.id = Convert.ToString(dr["id"]);
						}
						if (dr["servername"] != null && dr["servername"] != DBNull.Value)
						{
							item.servername = Convert.ToString(dr["servername"]);
						}
						if (dr["address"] != null && dr["address"] != DBNull.Value)
						{
							item.address = Convert.ToString(dr["address"]);
						}
						if (dr["userftp"] != null && dr["userftp"] != DBNull.Value)
						{
							item.userftp = Convert.ToString(dr["userftp"]);
						}
						if (dr["passftp"] != null && dr["passftp"] != DBNull.Value)
						{
							item.passftp = Convert.ToString(dr["passftp"]);
						}
						if (dr["ftpport"] != null && dr["ftpport"] != DBNull.Value)
						{
							item.ftpport = Convert.ToInt32(dr["ftpport"]);
						}
						if (dr["ftppath"] != null && dr["ftppath"] != DBNull.Value)
						{
							item.ftppath = Convert.ToString(dr["ftppath"]);
						}
						if (dr["createdate"] != null && dr["createdate"] != DBNull.Value)
						{
							item.createdate = Convert.ToDateTime(dr["createdate"]);
						}
						if (dr["createuser"] != null && dr["createuser"] != DBNull.Value)
						{
							item.createuser = Convert.ToString(dr["createuser"]);
						}
						if (dr["sudung"] != null && dr["sudung"] != DBNull.Value)
						{
							item.sudung = Convert.ToBoolean(dr["sudung"]);
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

		public MedServer GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[MedServer] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<MedServer>(ds);
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
		/// Thêm mới MedServer vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, MedServer _MedServer)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[MedServer](id, servername, address, userftp, passftp, ftpport, ftppath, createdate, createuser, sudung) VALUES(@id, @servername, @address, @userftp, @passftp, @ftpport, @ftppath, @createdate, @createuser, @sudung)", 
					"@id",  _MedServer.id, 
					"@servername",  _MedServer.servername, 
					"@address",  _MedServer.address, 
					"@userftp",  _MedServer.userftp, 
					"@passftp",  _MedServer.passftp, 
					"@ftpport",  _MedServer.ftpport, 
					"@ftppath",  _MedServer.ftppath, 
					"@createdate", this._dataContext.ConvertDateString( _MedServer.createdate), 
					"@createuser",  _MedServer.createuser, 
					"@sudung",  _MedServer.sudung);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng MedServer vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<MedServer> _MedServers)
		{
			foreach (MedServer item in _MedServers)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedServer vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, MedServer _MedServer, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedServer] SET id=@id, servername=@servername, address=@address, userftp=@userftp, passftp=@passftp, ftpport=@ftpport, ftppath=@ftppath, createdate=@createdate, createuser=@createuser, sudung=@sudung WHERE id=@id", 
					"@id",  _MedServer.id, 
					"@servername",  _MedServer.servername, 
					"@address",  _MedServer.address, 
					"@userftp",  _MedServer.userftp, 
					"@passftp",  _MedServer.passftp, 
					"@ftpport",  _MedServer.ftpport, 
					"@ftppath",  _MedServer.ftppath, 
					"@createdate", this._dataContext.ConvertDateString( _MedServer.createdate), 
					"@createuser",  _MedServer.createuser, 
					"@sudung",  _MedServer.sudung, 
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật MedServer vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, MedServer _MedServer)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedServer] SET servername=@servername, address=@address, userftp=@userftp, passftp=@passftp, ftpport=@ftpport, ftppath=@ftppath, createdate=@createdate, createuser=@createuser, sudung=@sudung WHERE id=@id", 
					"@servername",  _MedServer.servername, 
					"@address",  _MedServer.address, 
					"@userftp",  _MedServer.userftp, 
					"@passftp",  _MedServer.passftp, 
					"@ftpport",  _MedServer.ftpport, 
					"@ftppath",  _MedServer.ftppath, 
					"@createdate", this._dataContext.ConvertDateString( _MedServer.createdate), 
					"@createuser",  _MedServer.createuser, 
					"@sudung",  _MedServer.sudung, 
					"@id", _MedServer.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách MedServer vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<MedServer> _MedServers)
		{
			foreach (MedServer item in _MedServers)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật MedServer vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, MedServer _MedServer, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[MedServer] SET id=@id, servername=@servername, address=@address, userftp=@userftp, passftp=@passftp, ftpport=@ftpport, ftppath=@ftppath, createdate=@createdate, createuser=@createuser, sudung=@sudung "+ condition, 
					"@id",  _MedServer.id, 
					"@servername",  _MedServer.servername, 
					"@address",  _MedServer.address, 
					"@userftp",  _MedServer.userftp, 
					"@passftp",  _MedServer.passftp, 
					"@ftpport",  _MedServer.ftpport, 
					"@ftppath",  _MedServer.ftppath, 
					"@createdate", this._dataContext.ConvertDateString( _MedServer.createdate), 
					"@createuser",  _MedServer.createuser, 
					"@sudung",  _MedServer.sudung);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa MedServer trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedServer] WHERE id=@id",
					"@id", id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedServer trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, MedServer _MedServer)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedServer] WHERE id=@id",
					"@id", _MedServer.id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedServer trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[MedServer] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa MedServer trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<MedServer> _MedServers)
		{
			foreach (MedServer item in _MedServers)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
