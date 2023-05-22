using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXprecheck:IEXprecheck
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXprecheck(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpReCheck từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpReCheck]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpReCheck từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpReCheck] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpReCheck từ Database
		/// </summary>
		public List<ExpReCheck> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpReCheck]");
				List<ExpReCheck> items = new List<ExpReCheck>();
				ExpReCheck item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpReCheck();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["DateAction"] != null && dr["DateAction"] != DBNull.Value)
					{
						item.DateAction = Convert.ToDateTime(dr["DateAction"]);
					}
					if (dr["BalanceValue"] != null && dr["BalanceValue"] != DBNull.Value)
					{
						item.BalanceValue = Convert.ToInt32(dr["BalanceValue"]);
					}
					if (dr["Weight"] != null && dr["Weight"] != DBNull.Value)
					{
						item.Weight = Convert.ToDecimal(dr["Weight"]);
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
		/// Lấy danh sách ExpReCheck từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpReCheck> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpReCheck] A "+ condition,  parameters);
				List<ExpReCheck> items = new List<ExpReCheck>();
				ExpReCheck item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpReCheck();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["DateAction"] != null && dr["DateAction"] != DBNull.Value)
					{
						item.DateAction = Convert.ToDateTime(dr["DateAction"]);
					}
					if (dr["BalanceValue"] != null && dr["BalanceValue"] != DBNull.Value)
					{
						item.BalanceValue = Convert.ToInt32(dr["BalanceValue"]);
					}
					if (dr["Weight"] != null && dr["Weight"] != DBNull.Value)
					{
						item.Weight = Convert.ToDecimal(dr["Weight"]);
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

		public List<ExpReCheck> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpReCheck] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpReCheck] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpReCheck>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpReCheck từ Database
		/// </summary>
		public ExpReCheck GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpReCheck] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					ExpReCheck item=new ExpReCheck();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["DateAction"] != null && dr["DateAction"] != DBNull.Value)
						{
							item.DateAction = Convert.ToDateTime(dr["DateAction"]);
						}
						if (dr["BalanceValue"] != null && dr["BalanceValue"] != DBNull.Value)
						{
							item.BalanceValue = Convert.ToInt32(dr["BalanceValue"]);
						}
						if (dr["Weight"] != null && dr["Weight"] != DBNull.Value)
						{
							item.Weight = Convert.ToDecimal(dr["Weight"]);
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
		/// Lấy một ExpReCheck đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpReCheck GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpReCheck] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpReCheck item=new ExpReCheck();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["DateAction"] != null && dr["DateAction"] != DBNull.Value)
						{
							item.DateAction = Convert.ToDateTime(dr["DateAction"]);
						}
						if (dr["BalanceValue"] != null && dr["BalanceValue"] != DBNull.Value)
						{
							item.BalanceValue = Convert.ToInt32(dr["BalanceValue"]);
						}
						if (dr["Weight"] != null && dr["Weight"] != DBNull.Value)
						{
							item.Weight = Convert.ToDecimal(dr["Weight"]);
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

		public ExpReCheck GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpReCheck] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpReCheck>(ds);
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
		/// Thêm mới ExpReCheck vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpReCheck _ExpReCheck)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpReCheck](Id, DateAction, BalanceValue, Weight) VALUES(@Id, @DateAction, @BalanceValue, @Weight)", 
					"@Id",  _ExpReCheck.Id, 
					"@DateAction", this._dataContext.ConvertDateString( _ExpReCheck.DateAction), 
					"@BalanceValue",  _ExpReCheck.BalanceValue, 
					"@Weight",  _ExpReCheck.Weight);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpReCheck vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpReCheck> _ExpReChecks)
		{
			foreach (ExpReCheck item in _ExpReChecks)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpReCheck vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpReCheck _ExpReCheck, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpReCheck] SET Id=@Id, DateAction=@DateAction, BalanceValue=@BalanceValue, Weight=@Weight WHERE Id=@Id", 
					"@Id",  _ExpReCheck.Id, 
					"@DateAction", this._dataContext.ConvertDateString( _ExpReCheck.DateAction), 
					"@BalanceValue",  _ExpReCheck.BalanceValue, 
					"@Weight",  _ExpReCheck.Weight, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpReCheck vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpReCheck _ExpReCheck)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpReCheck] SET DateAction=@DateAction, BalanceValue=@BalanceValue, Weight=@Weight WHERE Id=@Id", 
					"@DateAction", this._dataContext.ConvertDateString( _ExpReCheck.DateAction), 
					"@BalanceValue",  _ExpReCheck.BalanceValue, 
					"@Weight",  _ExpReCheck.Weight, 
					"@Id", _ExpReCheck.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpReCheck vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpReCheck> _ExpReChecks)
		{
			foreach (ExpReCheck item in _ExpReChecks)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpReCheck vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpReCheck _ExpReCheck, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpReCheck] SET Id=@Id, DateAction=@DateAction, BalanceValue=@BalanceValue, Weight=@Weight "+ condition, 
					"@Id",  _ExpReCheck.Id, 
					"@DateAction", this._dataContext.ConvertDateString( _ExpReCheck.DateAction), 
					"@BalanceValue",  _ExpReCheck.BalanceValue, 
					"@Weight",  _ExpReCheck.Weight);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpReCheck trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpReCheck] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpReCheck trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpReCheck _ExpReCheck)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpReCheck] WHERE Id=@Id",
					"@Id", _ExpReCheck.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpReCheck trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpReCheck] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpReCheck trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpReCheck> _ExpReChecks)
		{
			foreach (ExpReCheck item in _ExpReChecks)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
