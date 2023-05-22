using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpcaresale:IEXpcaresale
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpcaresale(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpCareSale từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCareSale]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpCareSale từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCareSale] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpCareSale từ Database
		/// </summary>
		public List<ExpCareSale> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCareSale]");
				List<ExpCareSale> items = new List<ExpCareSale>();
				ExpCareSale item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpCareSale();
					if (dr["CustomerId"] != null && dr["CustomerId"] != DBNull.Value)
					{
						item.CustomerId = Convert.ToString(dr["CustomerId"]);
					}
					if (dr["SaleId"] != null && dr["SaleId"] != DBNull.Value)
					{
						item.SaleId = Convert.ToString(dr["SaleId"]);
					}
					if (dr["SaleName"] != null && dr["SaleName"] != DBNull.Value)
					{
						item.SaleName = Convert.ToString(dr["SaleName"]);
					}
					if (dr["SaleValue"] != null && dr["SaleValue"] != DBNull.Value)
					{
						item.SaleValue = Convert.ToInt32(dr["SaleValue"]);
					}
					if (dr["CareId"] != null && dr["CareId"] != DBNull.Value)
					{
						item.CareId = Convert.ToString(dr["CareId"]);
					}
					if (dr["CareName"] != null && dr["CareName"] != DBNull.Value)
					{
						item.CareName = Convert.ToString(dr["CareName"]);
					}
					if (dr["CareValue"] != null && dr["CareValue"] != DBNull.Value)
					{
						item.CareValue = Convert.ToInt32(dr["CareValue"]);
					}
					if (dr["CollectId"] != null && dr["CollectId"] != DBNull.Value)
					{
						item.CollectId = Convert.ToString(dr["CollectId"]);
					}
					if (dr["CollectName"] != null && dr["CollectName"] != DBNull.Value)
					{
						item.CollectName = Convert.ToString(dr["CollectName"]);
					}
					if (dr["CollectValue"] != null && dr["CollectValue"] != DBNull.Value)
					{
						item.CollectValue = Convert.ToInt32(dr["CollectValue"]);
					}
					if (dr["DiffValue"] != null && dr["DiffValue"] != DBNull.Value)
					{
						item.DiffValue = Convert.ToInt32(dr["DiffValue"]);
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
		/// Lấy danh sách ExpCareSale từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpCareSale> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpCareSale] A "+ condition,  parameters);
				List<ExpCareSale> items = new List<ExpCareSale>();
				ExpCareSale item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpCareSale();
					if (dr["CustomerId"] != null && dr["CustomerId"] != DBNull.Value)
					{
						item.CustomerId = Convert.ToString(dr["CustomerId"]);
					}
					if (dr["SaleId"] != null && dr["SaleId"] != DBNull.Value)
					{
						item.SaleId = Convert.ToString(dr["SaleId"]);
					}
					if (dr["SaleName"] != null && dr["SaleName"] != DBNull.Value)
					{
						item.SaleName = Convert.ToString(dr["SaleName"]);
					}
					if (dr["SaleValue"] != null && dr["SaleValue"] != DBNull.Value)
					{
						item.SaleValue = Convert.ToInt32(dr["SaleValue"]);
					}
					if (dr["CareId"] != null && dr["CareId"] != DBNull.Value)
					{
						item.CareId = Convert.ToString(dr["CareId"]);
					}
					if (dr["CareName"] != null && dr["CareName"] != DBNull.Value)
					{
						item.CareName = Convert.ToString(dr["CareName"]);
					}
					if (dr["CareValue"] != null && dr["CareValue"] != DBNull.Value)
					{
						item.CareValue = Convert.ToInt32(dr["CareValue"]);
					}
					if (dr["CollectId"] != null && dr["CollectId"] != DBNull.Value)
					{
						item.CollectId = Convert.ToString(dr["CollectId"]);
					}
					if (dr["CollectName"] != null && dr["CollectName"] != DBNull.Value)
					{
						item.CollectName = Convert.ToString(dr["CollectName"]);
					}
					if (dr["CollectValue"] != null && dr["CollectValue"] != DBNull.Value)
					{
						item.CollectValue = Convert.ToInt32(dr["CollectValue"]);
					}
					if (dr["DiffValue"] != null && dr["DiffValue"] != DBNull.Value)
					{
						item.DiffValue = Convert.ToInt32(dr["DiffValue"]);
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

		public List<ExpCareSale> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpCareSale] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpCareSale] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpCareSale>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpCareSale từ Database
		/// </summary>
		public ExpCareSale GetObject(string schema, String CustomerId)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCareSale] where CustomerId=@CustomerId",
					"@CustomerId", CustomerId);
				if (ds.Rows.Count > 0)
				{
					ExpCareSale item=new ExpCareSale();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["CustomerId"] != null && dr["CustomerId"] != DBNull.Value)
						{
							item.CustomerId = Convert.ToString(dr["CustomerId"]);
						}
						if (dr["SaleId"] != null && dr["SaleId"] != DBNull.Value)
						{
							item.SaleId = Convert.ToString(dr["SaleId"]);
						}
						if (dr["SaleName"] != null && dr["SaleName"] != DBNull.Value)
						{
							item.SaleName = Convert.ToString(dr["SaleName"]);
						}
						if (dr["SaleValue"] != null && dr["SaleValue"] != DBNull.Value)
						{
							item.SaleValue = Convert.ToInt32(dr["SaleValue"]);
						}
						if (dr["CareId"] != null && dr["CareId"] != DBNull.Value)
						{
							item.CareId = Convert.ToString(dr["CareId"]);
						}
						if (dr["CareName"] != null && dr["CareName"] != DBNull.Value)
						{
							item.CareName = Convert.ToString(dr["CareName"]);
						}
						if (dr["CareValue"] != null && dr["CareValue"] != DBNull.Value)
						{
							item.CareValue = Convert.ToInt32(dr["CareValue"]);
						}
						if (dr["CollectId"] != null && dr["CollectId"] != DBNull.Value)
						{
							item.CollectId = Convert.ToString(dr["CollectId"]);
						}
						if (dr["CollectName"] != null && dr["CollectName"] != DBNull.Value)
						{
							item.CollectName = Convert.ToString(dr["CollectName"]);
						}
						if (dr["CollectValue"] != null && dr["CollectValue"] != DBNull.Value)
						{
							item.CollectValue = Convert.ToInt32(dr["CollectValue"]);
						}
						if (dr["DiffValue"] != null && dr["DiffValue"] != DBNull.Value)
						{
							item.DiffValue = Convert.ToInt32(dr["DiffValue"]);
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
		/// Lấy một ExpCareSale đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpCareSale GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpCareSale] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpCareSale item=new ExpCareSale();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["CustomerId"] != null && dr["CustomerId"] != DBNull.Value)
						{
							item.CustomerId = Convert.ToString(dr["CustomerId"]);
						}
						if (dr["SaleId"] != null && dr["SaleId"] != DBNull.Value)
						{
							item.SaleId = Convert.ToString(dr["SaleId"]);
						}
						if (dr["SaleName"] != null && dr["SaleName"] != DBNull.Value)
						{
							item.SaleName = Convert.ToString(dr["SaleName"]);
						}
						if (dr["SaleValue"] != null && dr["SaleValue"] != DBNull.Value)
						{
							item.SaleValue = Convert.ToInt32(dr["SaleValue"]);
						}
						if (dr["CareId"] != null && dr["CareId"] != DBNull.Value)
						{
							item.CareId = Convert.ToString(dr["CareId"]);
						}
						if (dr["CareName"] != null && dr["CareName"] != DBNull.Value)
						{
							item.CareName = Convert.ToString(dr["CareName"]);
						}
						if (dr["CareValue"] != null && dr["CareValue"] != DBNull.Value)
						{
							item.CareValue = Convert.ToInt32(dr["CareValue"]);
						}
						if (dr["CollectId"] != null && dr["CollectId"] != DBNull.Value)
						{
							item.CollectId = Convert.ToString(dr["CollectId"]);
						}
						if (dr["CollectName"] != null && dr["CollectName"] != DBNull.Value)
						{
							item.CollectName = Convert.ToString(dr["CollectName"]);
						}
						if (dr["CollectValue"] != null && dr["CollectValue"] != DBNull.Value)
						{
							item.CollectValue = Convert.ToInt32(dr["CollectValue"]);
						}
						if (dr["DiffValue"] != null && dr["DiffValue"] != DBNull.Value)
						{
							item.DiffValue = Convert.ToInt32(dr["DiffValue"]);
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

		public ExpCareSale GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpCareSale] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpCareSale>(ds);
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
		/// Thêm mới ExpCareSale vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpCareSale _ExpCareSale)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpCareSale](CustomerId, SaleId, SaleName, SaleValue, CareId, CareName, CareValue, CollectId, CollectName, CollectValue, DiffValue) VALUES(@CustomerId, @SaleId, @SaleName, @SaleValue, @CareId, @CareName, @CareValue, @CollectId, @CollectName, @CollectValue, @DiffValue)", 
					"@CustomerId",  _ExpCareSale.CustomerId, 
					"@SaleId",  _ExpCareSale.SaleId, 
					"@SaleName",  _ExpCareSale.SaleName, 
					"@SaleValue",  _ExpCareSale.SaleValue, 
					"@CareId",  _ExpCareSale.CareId, 
					"@CareName",  _ExpCareSale.CareName, 
					"@CareValue",  _ExpCareSale.CareValue, 
					"@CollectId",  _ExpCareSale.CollectId, 
					"@CollectName",  _ExpCareSale.CollectName, 
					"@CollectValue",  _ExpCareSale.CollectValue, 
					"@DiffValue",  _ExpCareSale.DiffValue);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpCareSale vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpCareSale> _ExpCareSales)
		{
			foreach (ExpCareSale item in _ExpCareSales)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpCareSale vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpCareSale _ExpCareSale, String CustomerId)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCareSale] SET CustomerId=@CustomerId, SaleId=@SaleId, SaleName=@SaleName, SaleValue=@SaleValue, CareId=@CareId, CareName=@CareName, CareValue=@CareValue, CollectId=@CollectId, CollectName=@CollectName, CollectValue=@CollectValue, DiffValue=@DiffValue WHERE CustomerId=@CustomerId", 
					"@CustomerId",  _ExpCareSale.CustomerId, 
					"@SaleId",  _ExpCareSale.SaleId, 
					"@SaleName",  _ExpCareSale.SaleName, 
					"@SaleValue",  _ExpCareSale.SaleValue, 
					"@CareId",  _ExpCareSale.CareId, 
					"@CareName",  _ExpCareSale.CareName, 
					"@CareValue",  _ExpCareSale.CareValue, 
					"@CollectId",  _ExpCareSale.CollectId, 
					"@CollectName",  _ExpCareSale.CollectName, 
					"@CollectValue",  _ExpCareSale.CollectValue, 
					"@DiffValue",  _ExpCareSale.DiffValue, 
					"@CustomerId", CustomerId);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpCareSale vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpCareSale _ExpCareSale)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCareSale] SET SaleId=@SaleId, SaleName=@SaleName, SaleValue=@SaleValue, CareId=@CareId, CareName=@CareName, CareValue=@CareValue, CollectId=@CollectId, CollectName=@CollectName, CollectValue=@CollectValue, DiffValue=@DiffValue WHERE CustomerId=@CustomerId", 
					"@SaleId",  _ExpCareSale.SaleId, 
					"@SaleName",  _ExpCareSale.SaleName, 
					"@SaleValue",  _ExpCareSale.SaleValue, 
					"@CareId",  _ExpCareSale.CareId, 
					"@CareName",  _ExpCareSale.CareName, 
					"@CareValue",  _ExpCareSale.CareValue, 
					"@CollectId",  _ExpCareSale.CollectId, 
					"@CollectName",  _ExpCareSale.CollectName, 
					"@CollectValue",  _ExpCareSale.CollectValue, 
					"@DiffValue",  _ExpCareSale.DiffValue, 
					"@CustomerId", _ExpCareSale.CustomerId);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpCareSale vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpCareSale> _ExpCareSales)
		{
			foreach (ExpCareSale item in _ExpCareSales)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpCareSale vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpCareSale _ExpCareSale, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCareSale] SET CustomerId=@CustomerId, SaleId=@SaleId, SaleName=@SaleName, SaleValue=@SaleValue, CareId=@CareId, CareName=@CareName, CareValue=@CareValue, CollectId=@CollectId, CollectName=@CollectName, CollectValue=@CollectValue, DiffValue=@DiffValue "+ condition, 
					"@CustomerId",  _ExpCareSale.CustomerId, 
					"@SaleId",  _ExpCareSale.SaleId, 
					"@SaleName",  _ExpCareSale.SaleName, 
					"@SaleValue",  _ExpCareSale.SaleValue, 
					"@CareId",  _ExpCareSale.CareId, 
					"@CareName",  _ExpCareSale.CareName, 
					"@CareValue",  _ExpCareSale.CareValue, 
					"@CollectId",  _ExpCareSale.CollectId, 
					"@CollectName",  _ExpCareSale.CollectName, 
					"@CollectValue",  _ExpCareSale.CollectValue, 
					"@DiffValue",  _ExpCareSale.DiffValue);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpCareSale trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String CustomerId)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCareSale] WHERE CustomerId=@CustomerId",
					"@CustomerId", CustomerId);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCareSale trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpCareSale _ExpCareSale)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCareSale] WHERE CustomerId=@CustomerId",
					"@CustomerId", _ExpCareSale.CustomerId);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCareSale trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCareSale] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCareSale trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpCareSale> _ExpCareSales)
		{
			foreach (ExpCareSale item in _ExpCareSales)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
