using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpwebhookport:IGExpwebhookport
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpwebhookport(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpWebhookPort từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWebhookPort]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpWebhookPort từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWebhookPort] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpWebhookPort từ Database
		/// </summary>
		public List<GExpWebhookPort> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWebhookPort]");
				List<GExpWebhookPort> items = new List<GExpWebhookPort>();
				GExpWebhookPort item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpWebhookPort();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Provider"] != null && dr["Provider"] != DBNull.Value)
					{
						item.Provider = Convert.ToString(dr["Provider"]);
					}
					if (dr["PostLink"] != null && dr["PostLink"] != DBNull.Value)
					{
						item.PostLink = Convert.ToString(dr["PostLink"]);
					}
					if (dr["Token"] != null && dr["Token"] != DBNull.Value)
					{
						item.Token = Convert.ToString(dr["Token"]);
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
		/// Lấy danh sách GExpWebhookPort từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpWebhookPort> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpWebhookPort] A "+ condition,  parameters);
				List<GExpWebhookPort> items = new List<GExpWebhookPort>();
				GExpWebhookPort item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpWebhookPort();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["Provider"] != null && dr["Provider"] != DBNull.Value)
					{
						item.Provider = Convert.ToString(dr["Provider"]);
					}
					if (dr["PostLink"] != null && dr["PostLink"] != DBNull.Value)
					{
						item.PostLink = Convert.ToString(dr["PostLink"]);
					}
					if (dr["Token"] != null && dr["Token"] != DBNull.Value)
					{
						item.Token = Convert.ToString(dr["Token"]);
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

		public List<GExpWebhookPort> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpWebhookPort] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpWebhookPort] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpWebhookPort>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpWebhookPort từ Database
		/// </summary>
		public GExpWebhookPort GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpWebhookPort] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpWebhookPort item=new GExpWebhookPort();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Provider"] != null && dr["Provider"] != DBNull.Value)
						{
							item.Provider = Convert.ToString(dr["Provider"]);
						}
						if (dr["PostLink"] != null && dr["PostLink"] != DBNull.Value)
						{
							item.PostLink = Convert.ToString(dr["PostLink"]);
						}
						if (dr["Token"] != null && dr["Token"] != DBNull.Value)
						{
							item.Token = Convert.ToString(dr["Token"]);
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
		/// Lấy một GExpWebhookPort đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpWebhookPort GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpWebhookPort] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpWebhookPort item=new GExpWebhookPort();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["Provider"] != null && dr["Provider"] != DBNull.Value)
						{
							item.Provider = Convert.ToString(dr["Provider"]);
						}
						if (dr["PostLink"] != null && dr["PostLink"] != DBNull.Value)
						{
							item.PostLink = Convert.ToString(dr["PostLink"]);
						}
						if (dr["Token"] != null && dr["Token"] != DBNull.Value)
						{
							item.Token = Convert.ToString(dr["Token"]);
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

		public GExpWebhookPort GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpWebhookPort] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpWebhookPort>(ds);
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
		/// Thêm mới GExpWebhookPort vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpWebhookPort _GExpWebhookPort)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpWebhookPort](Id, Provider, PostLink, Token) VALUES(@Id, @Provider, @PostLink, @Token)", 
					"@Id",  _GExpWebhookPort.Id, 
					"@Provider",  _GExpWebhookPort.Provider, 
					"@PostLink",  _GExpWebhookPort.PostLink, 
					"@Token",  _GExpWebhookPort.Token);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpWebhookPort vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpWebhookPort> _GExpWebhookPorts)
		{
			foreach (GExpWebhookPort item in _GExpWebhookPorts)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpWebhookPort vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpWebhookPort _GExpWebhookPort, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpWebhookPort] SET Id=@Id, Provider=@Provider, PostLink=@PostLink, Token=@Token WHERE Id=@Id", 
					"@Id",  _GExpWebhookPort.Id, 
					"@Provider",  _GExpWebhookPort.Provider, 
					"@PostLink",  _GExpWebhookPort.PostLink, 
					"@Token",  _GExpWebhookPort.Token, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpWebhookPort vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpWebhookPort _GExpWebhookPort)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpWebhookPort] SET Provider=@Provider, PostLink=@PostLink, Token=@Token WHERE Id=@Id", 
					"@Provider",  _GExpWebhookPort.Provider, 
					"@PostLink",  _GExpWebhookPort.PostLink, 
					"@Token",  _GExpWebhookPort.Token, 
					"@Id", _GExpWebhookPort.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpWebhookPort vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpWebhookPort> _GExpWebhookPorts)
		{
			foreach (GExpWebhookPort item in _GExpWebhookPorts)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpWebhookPort vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpWebhookPort _GExpWebhookPort, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpWebhookPort] SET Id=@Id, Provider=@Provider, PostLink=@PostLink, Token=@Token "+ condition, 
					"@Id",  _GExpWebhookPort.Id, 
					"@Provider",  _GExpWebhookPort.Provider, 
					"@PostLink",  _GExpWebhookPort.PostLink, 
					"@Token",  _GExpWebhookPort.Token);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpWebhookPort trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpWebhookPort] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpWebhookPort trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpWebhookPort _GExpWebhookPort)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpWebhookPort] WHERE Id=@Id",
					"@Id", _GExpWebhookPort.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpWebhookPort trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpWebhookPort] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpWebhookPort trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpWebhookPort> _GExpWebhookPorts)
		{
			foreach (GExpWebhookPort item in _GExpWebhookPorts)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
