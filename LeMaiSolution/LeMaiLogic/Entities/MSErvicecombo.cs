using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MSErvicecombo:ISErvicecombo
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MSErvicecombo(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ServiceCombo từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ServiceCombo]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ServiceCombo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ServiceCombo] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ServiceCombo từ Database
		/// </summary>
		public List<ServiceCombo> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ServiceCombo]");
				List<ServiceCombo> items = new List<ServiceCombo>();
				ServiceCombo item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ServiceCombo();
					if (dr["FK_ComboService"] != null && dr["FK_ComboService"] != DBNull.Value)
					{
						item.FK_ComboService = Convert.ToString(dr["FK_ComboService"]);
					}
					if (dr["FK_ServiceBelong"] != null && dr["FK_ServiceBelong"] != DBNull.Value)
					{
						item.FK_ServiceBelong = Convert.ToString(dr["FK_ServiceBelong"]);
					}
					if (dr["Price"] != null && dr["Price"] != DBNull.Value)
					{
						item.Price = Convert.ToInt32(dr["Price"]);
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
		/// Lấy danh sách ServiceCombo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ServiceCombo> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ServiceCombo] A "+ condition,  parameters);
				List<ServiceCombo> items = new List<ServiceCombo>();
				ServiceCombo item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ServiceCombo();
					if (dr["FK_ComboService"] != null && dr["FK_ComboService"] != DBNull.Value)
					{
						item.FK_ComboService = Convert.ToString(dr["FK_ComboService"]);
					}
					if (dr["FK_ServiceBelong"] != null && dr["FK_ServiceBelong"] != DBNull.Value)
					{
						item.FK_ServiceBelong = Convert.ToString(dr["FK_ServiceBelong"]);
					}
					if (dr["Price"] != null && dr["Price"] != DBNull.Value)
					{
						item.Price = Convert.ToInt32(dr["Price"]);
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

		public List<ServiceCombo> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ServiceCombo] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ServiceCombo] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ServiceCombo>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ServiceCombo từ Database
		/// </summary>
		public ServiceCombo GetObject(string schema, String FK_ComboService, String FK_ServiceBelong)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ServiceCombo] where FK_ComboService=@FK_ComboService and FK_ServiceBelong=@FK_ServiceBelong",
					"@FK_ComboService", FK_ComboService, 
					"@FK_ServiceBelong", FK_ServiceBelong);
				if (ds.Rows.Count > 0)
				{
					ServiceCombo item=new ServiceCombo();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_ComboService"] != null && dr["FK_ComboService"] != DBNull.Value)
						{
							item.FK_ComboService = Convert.ToString(dr["FK_ComboService"]);
						}
						if (dr["FK_ServiceBelong"] != null && dr["FK_ServiceBelong"] != DBNull.Value)
						{
							item.FK_ServiceBelong = Convert.ToString(dr["FK_ServiceBelong"]);
						}
						if (dr["Price"] != null && dr["Price"] != DBNull.Value)
						{
							item.Price = Convert.ToInt32(dr["Price"]);
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
		/// Lấy một ServiceCombo đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ServiceCombo GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ServiceCombo] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ServiceCombo item=new ServiceCombo();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["FK_ComboService"] != null && dr["FK_ComboService"] != DBNull.Value)
						{
							item.FK_ComboService = Convert.ToString(dr["FK_ComboService"]);
						}
						if (dr["FK_ServiceBelong"] != null && dr["FK_ServiceBelong"] != DBNull.Value)
						{
							item.FK_ServiceBelong = Convert.ToString(dr["FK_ServiceBelong"]);
						}
						if (dr["Price"] != null && dr["Price"] != DBNull.Value)
						{
							item.Price = Convert.ToInt32(dr["Price"]);
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

		public ServiceCombo GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ServiceCombo] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ServiceCombo>(ds);
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
		/// Thêm mới ServiceCombo vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ServiceCombo _ServiceCombo)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ServiceCombo](FK_ComboService, FK_ServiceBelong, Price) VALUES(@FK_ComboService, @FK_ServiceBelong, @Price)", 
					"@FK_ComboService",  _ServiceCombo.FK_ComboService, 
					"@FK_ServiceBelong",  _ServiceCombo.FK_ServiceBelong, 
					"@Price",  _ServiceCombo.Price);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ServiceCombo vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ServiceCombo> _ServiceCombos)
		{
			foreach (ServiceCombo item in _ServiceCombos)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ServiceCombo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ServiceCombo _ServiceCombo, String FK_ComboService, String FK_ServiceBelong)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ServiceCombo] SET FK_ComboService=@FK_ComboService, FK_ServiceBelong=@FK_ServiceBelong, Price=@Price WHERE FK_ComboService=@FK_ComboService and FK_ServiceBelong=@FK_ServiceBelong", 
					"@FK_ComboService",  _ServiceCombo.FK_ComboService, 
					"@FK_ServiceBelong",  _ServiceCombo.FK_ServiceBelong, 
					"@Price",  _ServiceCombo.Price, 
					"@FK_ComboService", FK_ComboService, 
					"@FK_ServiceBelong", FK_ServiceBelong);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ServiceCombo vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ServiceCombo _ServiceCombo)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ServiceCombo] SET Price=@Price WHERE FK_ComboService=@FK_ComboService and FK_ServiceBelong=@FK_ServiceBelong", 
					"@Price",  _ServiceCombo.Price, 
					"@FK_ComboService", _ServiceCombo.FK_ComboService, 
					"@FK_ServiceBelong", _ServiceCombo.FK_ServiceBelong);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ServiceCombo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ServiceCombo> _ServiceCombos)
		{
			foreach (ServiceCombo item in _ServiceCombos)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ServiceCombo vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ServiceCombo _ServiceCombo, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ServiceCombo] SET FK_ComboService=@FK_ComboService, FK_ServiceBelong=@FK_ServiceBelong, Price=@Price "+ condition, 
					"@FK_ComboService",  _ServiceCombo.FK_ComboService, 
					"@FK_ServiceBelong",  _ServiceCombo.FK_ServiceBelong, 
					"@Price",  _ServiceCombo.Price);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ServiceCombo trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String FK_ComboService, String FK_ServiceBelong)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ServiceCombo] WHERE FK_ComboService=@FK_ComboService and FK_ServiceBelong=@FK_ServiceBelong",
					"@FK_ComboService", FK_ComboService, 
					"@FK_ServiceBelong", FK_ServiceBelong);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ServiceCombo trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ServiceCombo _ServiceCombo)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ServiceCombo] WHERE FK_ComboService=@FK_ComboService and FK_ServiceBelong=@FK_ServiceBelong",
					"@FK_ComboService", _ServiceCombo.FK_ComboService, 
					"@FK_ServiceBelong", _ServiceCombo.FK_ServiceBelong);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ServiceCombo trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ServiceCombo] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ServiceCombo trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ServiceCombo> _ServiceCombos)
		{
			foreach (ServiceCombo item in _ServiceCombos)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
