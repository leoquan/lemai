using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpprovidercustomer:IGExpprovidercustomer
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpprovidercustomer(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpProviderCustomer từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProviderCustomer]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpProviderCustomer từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProviderCustomer] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpProviderCustomer từ Database
		/// </summary>
		public List<GExpProviderCustomer> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProviderCustomer]");
				List<GExpProviderCustomer> items = new List<GExpProviderCustomer>();
				GExpProviderCustomer item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpProviderCustomer();
					if (dr["ProviderId"] != null && dr["ProviderId"] != DBNull.Value)
					{
						item.ProviderId = Convert.ToString(dr["ProviderId"]);
					}
					if (dr["CustomerId"] != null && dr["CustomerId"] != DBNull.Value)
					{
						item.CustomerId = Convert.ToString(dr["CustomerId"]);
					}
					if (dr["DefaultProvider"] != null && dr["DefaultProvider"] != DBNull.Value)
					{
						item.DefaultProvider = Convert.ToBoolean(dr["DefaultProvider"]);
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
		/// Lấy danh sách GExpProviderCustomer từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpProviderCustomer> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpProviderCustomer] A "+ condition,  parameters);
				List<GExpProviderCustomer> items = new List<GExpProviderCustomer>();
				GExpProviderCustomer item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpProviderCustomer();
					if (dr["ProviderId"] != null && dr["ProviderId"] != DBNull.Value)
					{
						item.ProviderId = Convert.ToString(dr["ProviderId"]);
					}
					if (dr["CustomerId"] != null && dr["CustomerId"] != DBNull.Value)
					{
						item.CustomerId = Convert.ToString(dr["CustomerId"]);
					}
					if (dr["DefaultProvider"] != null && dr["DefaultProvider"] != DBNull.Value)
					{
						item.DefaultProvider = Convert.ToBoolean(dr["DefaultProvider"]);
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

		public List<GExpProviderCustomer> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpProviderCustomer] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpProviderCustomer] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpProviderCustomer>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpProviderCustomer từ Database
		/// </summary>
		public GExpProviderCustomer GetObject(string schema, String ProviderId, String CustomerId)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProviderCustomer] where ProviderId=@ProviderId and CustomerId=@CustomerId",
					"@ProviderId", ProviderId, 
					"@CustomerId", CustomerId);
				if (ds.Rows.Count > 0)
				{
					GExpProviderCustomer item=new GExpProviderCustomer();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["ProviderId"] != null && dr["ProviderId"] != DBNull.Value)
						{
							item.ProviderId = Convert.ToString(dr["ProviderId"]);
						}
						if (dr["CustomerId"] != null && dr["CustomerId"] != DBNull.Value)
						{
							item.CustomerId = Convert.ToString(dr["CustomerId"]);
						}
						if (dr["DefaultProvider"] != null && dr["DefaultProvider"] != DBNull.Value)
						{
							item.DefaultProvider = Convert.ToBoolean(dr["DefaultProvider"]);
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
		/// Lấy một GExpProviderCustomer đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpProviderCustomer GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpProviderCustomer] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpProviderCustomer item=new GExpProviderCustomer();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["ProviderId"] != null && dr["ProviderId"] != DBNull.Value)
						{
							item.ProviderId = Convert.ToString(dr["ProviderId"]);
						}
						if (dr["CustomerId"] != null && dr["CustomerId"] != DBNull.Value)
						{
							item.CustomerId = Convert.ToString(dr["CustomerId"]);
						}
						if (dr["DefaultProvider"] != null && dr["DefaultProvider"] != DBNull.Value)
						{
							item.DefaultProvider = Convert.ToBoolean(dr["DefaultProvider"]);
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

		public GExpProviderCustomer GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpProviderCustomer] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpProviderCustomer>(ds);
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
		/// Thêm mới GExpProviderCustomer vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpProviderCustomer _GExpProviderCustomer)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpProviderCustomer](ProviderId, CustomerId, DefaultProvider) VALUES(@ProviderId, @CustomerId, @DefaultProvider)", 
					"@ProviderId",  _GExpProviderCustomer.ProviderId, 
					"@CustomerId",  _GExpProviderCustomer.CustomerId, 
					"@DefaultProvider",  _GExpProviderCustomer.DefaultProvider);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpProviderCustomer vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpProviderCustomer> _GExpProviderCustomers)
		{
			foreach (GExpProviderCustomer item in _GExpProviderCustomers)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpProviderCustomer vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpProviderCustomer _GExpProviderCustomer, String ProviderId, String CustomerId)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProviderCustomer] SET ProviderId=@ProviderId, CustomerId=@CustomerId, DefaultProvider=@DefaultProvider WHERE ProviderId=@ProviderId and CustomerId=@CustomerId", 
					"@ProviderId",  _GExpProviderCustomer.ProviderId, 
					"@CustomerId",  _GExpProviderCustomer.CustomerId, 
					"@DefaultProvider",  _GExpProviderCustomer.DefaultProvider, 
					"@ProviderId", ProviderId, 
					"@CustomerId", CustomerId);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpProviderCustomer vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpProviderCustomer _GExpProviderCustomer)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProviderCustomer] SET DefaultProvider=@DefaultProvider WHERE ProviderId=@ProviderId and CustomerId=@CustomerId", 
					"@DefaultProvider",  _GExpProviderCustomer.DefaultProvider, 
					"@ProviderId", _GExpProviderCustomer.ProviderId, 
					"@CustomerId", _GExpProviderCustomer.CustomerId);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpProviderCustomer vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpProviderCustomer> _GExpProviderCustomers)
		{
			foreach (GExpProviderCustomer item in _GExpProviderCustomers)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpProviderCustomer vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpProviderCustomer _GExpProviderCustomer, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProviderCustomer] SET ProviderId=@ProviderId, CustomerId=@CustomerId, DefaultProvider=@DefaultProvider "+ condition, 
					"@ProviderId",  _GExpProviderCustomer.ProviderId, 
					"@CustomerId",  _GExpProviderCustomer.CustomerId, 
					"@DefaultProvider",  _GExpProviderCustomer.DefaultProvider);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpProviderCustomer trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String ProviderId, String CustomerId)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProviderCustomer] WHERE ProviderId=@ProviderId and CustomerId=@CustomerId",
					"@ProviderId", ProviderId, 
					"@CustomerId", CustomerId);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProviderCustomer trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpProviderCustomer _GExpProviderCustomer)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProviderCustomer] WHERE ProviderId=@ProviderId and CustomerId=@CustomerId",
					"@ProviderId", _GExpProviderCustomer.ProviderId, 
					"@CustomerId", _GExpProviderCustomer.CustomerId);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProviderCustomer trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProviderCustomer] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProviderCustomer trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpProviderCustomer> _GExpProviderCustomers)
		{
			foreach (GExpProviderCustomer item in _GExpProviderCustomers)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
