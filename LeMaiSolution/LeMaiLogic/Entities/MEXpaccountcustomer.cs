using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpaccountcustomer:IEXpaccountcustomer
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpaccountcustomer(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpAccountCustomer từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpAccountCustomer]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpAccountCustomer từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpAccountCustomer] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpAccountCustomer từ Database
		/// </summary>
		public List<ExpAccountCustomer> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpAccountCustomer]");
				List<ExpAccountCustomer> items = new List<ExpAccountCustomer>();
				ExpAccountCustomer item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpAccountCustomer();
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
					}
					if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
					{
						item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
					}
					if (dr["TypeCode"] != null && dr["TypeCode"] != DBNull.Value)
					{
						item.TypeCode = Convert.ToInt32(dr["TypeCode"]);
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
		/// Lấy danh sách ExpAccountCustomer từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpAccountCustomer> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpAccountCustomer] A "+ condition,  parameters);
				List<ExpAccountCustomer> items = new List<ExpAccountCustomer>();
				ExpAccountCustomer item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpAccountCustomer();
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
					}
					if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
					{
						item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
					}
					if (dr["TypeCode"] != null && dr["TypeCode"] != DBNull.Value)
					{
						item.TypeCode = Convert.ToInt32(dr["TypeCode"]);
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

		public List<ExpAccountCustomer> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpAccountCustomer] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpAccountCustomer] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpAccountCustomer>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpAccountCustomer từ Database
		/// </summary>
		public ExpAccountCustomer GetObject(string schema, String FK_Account, String FK_Customer)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpAccountCustomer] where FK_Account=@FK_Account and FK_Customer=@FK_Customer",
					"@FK_Account", FK_Account, 
					"@FK_Customer", FK_Customer);
				if (ds.Rows.Count > 0)
				{
					ExpAccountCustomer item=new ExpAccountCustomer();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
						{
							item.FK_Account = Convert.ToString(dr["FK_Account"]);
						}
						if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
						{
							item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
						}
						if (dr["TypeCode"] != null && dr["TypeCode"] != DBNull.Value)
						{
							item.TypeCode = Convert.ToInt32(dr["TypeCode"]);
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
		/// Lấy một ExpAccountCustomer đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpAccountCustomer GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpAccountCustomer] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpAccountCustomer item=new ExpAccountCustomer();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
						{
							item.FK_Account = Convert.ToString(dr["FK_Account"]);
						}
						if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
						{
							item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
						}
						if (dr["TypeCode"] != null && dr["TypeCode"] != DBNull.Value)
						{
							item.TypeCode = Convert.ToInt32(dr["TypeCode"]);
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

		public ExpAccountCustomer GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpAccountCustomer] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpAccountCustomer>(ds);
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
		/// Thêm mới ExpAccountCustomer vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpAccountCustomer _ExpAccountCustomer)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpAccountCustomer](FK_Account, FK_Customer, TypeCode) VALUES(@FK_Account, @FK_Customer, @TypeCode)", 
					"@FK_Account",  _ExpAccountCustomer.FK_Account, 
					"@FK_Customer",  _ExpAccountCustomer.FK_Customer, 
					"@TypeCode",  _ExpAccountCustomer.TypeCode);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpAccountCustomer vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpAccountCustomer> _ExpAccountCustomers)
		{
			foreach (ExpAccountCustomer item in _ExpAccountCustomers)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpAccountCustomer vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpAccountCustomer _ExpAccountCustomer, String FK_Account, String FK_Customer)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpAccountCustomer] SET FK_Account=@FK_Account, FK_Customer=@FK_Customer, TypeCode=@TypeCode WHERE FK_Account=@FK_Account and FK_Customer=@FK_Customer", 
					"@FK_Account",  _ExpAccountCustomer.FK_Account, 
					"@FK_Customer",  _ExpAccountCustomer.FK_Customer, 
					"@TypeCode",  _ExpAccountCustomer.TypeCode, 
					"@FK_Account", FK_Account, 
					"@FK_Customer", FK_Customer);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpAccountCustomer vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpAccountCustomer _ExpAccountCustomer)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpAccountCustomer] SET TypeCode=@TypeCode WHERE FK_Account=@FK_Account and FK_Customer=@FK_Customer", 
					"@TypeCode",  _ExpAccountCustomer.TypeCode, 
					"@FK_Account", _ExpAccountCustomer.FK_Account, 
					"@FK_Customer", _ExpAccountCustomer.FK_Customer);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpAccountCustomer vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpAccountCustomer> _ExpAccountCustomers)
		{
			foreach (ExpAccountCustomer item in _ExpAccountCustomers)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpAccountCustomer vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpAccountCustomer _ExpAccountCustomer, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpAccountCustomer] SET FK_Account=@FK_Account, FK_Customer=@FK_Customer, TypeCode=@TypeCode "+ condition, 
					"@FK_Account",  _ExpAccountCustomer.FK_Account, 
					"@FK_Customer",  _ExpAccountCustomer.FK_Customer, 
					"@TypeCode",  _ExpAccountCustomer.TypeCode);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpAccountCustomer trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String FK_Account, String FK_Customer)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpAccountCustomer] WHERE FK_Account=@FK_Account and FK_Customer=@FK_Customer",
					"@FK_Account", FK_Account, 
					"@FK_Customer", FK_Customer);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpAccountCustomer trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpAccountCustomer _ExpAccountCustomer)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpAccountCustomer] WHERE FK_Account=@FK_Account and FK_Customer=@FK_Customer",
					"@FK_Account", _ExpAccountCustomer.FK_Account, 
					"@FK_Customer", _ExpAccountCustomer.FK_Customer);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpAccountCustomer trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpAccountCustomer] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpAccountCustomer trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpAccountCustomer> _ExpAccountCustomers)
		{
			foreach (ExpAccountCustomer item in _ExpAccountCustomers)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
