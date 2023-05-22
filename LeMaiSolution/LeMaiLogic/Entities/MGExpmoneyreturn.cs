using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpmoneyreturn:IGExpmoneyreturn
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpmoneyreturn(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpMoneyReturn từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpMoneyReturn]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpMoneyReturn từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpMoneyReturn] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpMoneyReturn từ Database
		/// </summary>
		public List<GExpMoneyReturn> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpMoneyReturn]");
				List<GExpMoneyReturn> items = new List<GExpMoneyReturn>();
				GExpMoneyReturn item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpMoneyReturn();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
					{
						item.BT3Code = Convert.ToString(dr["BT3Code"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["Status"] != null && dr["Status"] != DBNull.Value)
					{
						item.Status = Convert.ToInt32(dr["Status"]);
					}
					if (dr["BT3COD"] != null && dr["BT3COD"] != DBNull.Value)
					{
						item.BT3COD = Convert.ToDecimal(dr["BT3COD"]);
					}
					if (dr["BT3TotalPaid"] != null && dr["BT3TotalPaid"] != DBNull.Value)
					{
						item.BT3TotalPaid = Convert.ToDecimal(dr["BT3TotalPaid"]);
					}
					if (dr["BT3TotalDiscount"] != null && dr["BT3TotalDiscount"] != DBNull.Value)
					{
						item.BT3TotalDiscount = Convert.ToDecimal(dr["BT3TotalDiscount"]);
					}
					if (dr["BT3TotalFee"] != null && dr["BT3TotalFee"] != DBNull.Value)
					{
						item.BT3TotalFee = Convert.ToDecimal(dr["BT3TotalFee"]);
					}
					if (dr["MoneyReturn"] != null && dr["MoneyReturn"] != DBNull.Value)
					{
						item.MoneyReturn = Convert.ToDecimal(dr["MoneyReturn"]);
					}
					if (dr["DateReturn"] != null && dr["DateReturn"] != DBNull.Value)
					{
						item.DateReturn = Convert.ToDateTime(dr["DateReturn"]);
					}
					if (dr["FK_MoneyReturnSession"] != null && dr["FK_MoneyReturnSession"] != DBNull.Value)
					{
						item.FK_MoneyReturnSession = Convert.ToString(dr["FK_MoneyReturnSession"]);
					}
					if (dr["IsPayCustomer"] != null && dr["IsPayCustomer"] != DBNull.Value)
					{
						item.IsPayCustomer = Convert.ToBoolean(dr["IsPayCustomer"]);
					}
					if (dr["CustomerPayDate"] != null && dr["CustomerPayDate"] != DBNull.Value)
					{
						item.CustomerPayDate = Convert.ToDateTime(dr["CustomerPayDate"]);
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
		/// Lấy danh sách GExpMoneyReturn từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpMoneyReturn> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpMoneyReturn] A "+ condition,  parameters);
				List<GExpMoneyReturn> items = new List<GExpMoneyReturn>();
				GExpMoneyReturn item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpMoneyReturn();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
					{
						item.BT3Code = Convert.ToString(dr["BT3Code"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["Status"] != null && dr["Status"] != DBNull.Value)
					{
						item.Status = Convert.ToInt32(dr["Status"]);
					}
					if (dr["BT3COD"] != null && dr["BT3COD"] != DBNull.Value)
					{
						item.BT3COD = Convert.ToDecimal(dr["BT3COD"]);
					}
					if (dr["BT3TotalPaid"] != null && dr["BT3TotalPaid"] != DBNull.Value)
					{
						item.BT3TotalPaid = Convert.ToDecimal(dr["BT3TotalPaid"]);
					}
					if (dr["BT3TotalDiscount"] != null && dr["BT3TotalDiscount"] != DBNull.Value)
					{
						item.BT3TotalDiscount = Convert.ToDecimal(dr["BT3TotalDiscount"]);
					}
					if (dr["BT3TotalFee"] != null && dr["BT3TotalFee"] != DBNull.Value)
					{
						item.BT3TotalFee = Convert.ToDecimal(dr["BT3TotalFee"]);
					}
					if (dr["MoneyReturn"] != null && dr["MoneyReturn"] != DBNull.Value)
					{
						item.MoneyReturn = Convert.ToDecimal(dr["MoneyReturn"]);
					}
					if (dr["DateReturn"] != null && dr["DateReturn"] != DBNull.Value)
					{
						item.DateReturn = Convert.ToDateTime(dr["DateReturn"]);
					}
					if (dr["FK_MoneyReturnSession"] != null && dr["FK_MoneyReturnSession"] != DBNull.Value)
					{
						item.FK_MoneyReturnSession = Convert.ToString(dr["FK_MoneyReturnSession"]);
					}
					if (dr["IsPayCustomer"] != null && dr["IsPayCustomer"] != DBNull.Value)
					{
						item.IsPayCustomer = Convert.ToBoolean(dr["IsPayCustomer"]);
					}
					if (dr["CustomerPayDate"] != null && dr["CustomerPayDate"] != DBNull.Value)
					{
						item.CustomerPayDate = Convert.ToDateTime(dr["CustomerPayDate"]);
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

		public List<GExpMoneyReturn> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpMoneyReturn] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpMoneyReturn] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpMoneyReturn>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpMoneyReturn từ Database
		/// </summary>
		public GExpMoneyReturn GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpMoneyReturn] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpMoneyReturn item=new GExpMoneyReturn();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
						{
							item.BT3Code = Convert.ToString(dr["BT3Code"]);
						}
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["Status"] != null && dr["Status"] != DBNull.Value)
						{
							item.Status = Convert.ToInt32(dr["Status"]);
						}
						if (dr["BT3COD"] != null && dr["BT3COD"] != DBNull.Value)
						{
							item.BT3COD = Convert.ToDecimal(dr["BT3COD"]);
						}
						if (dr["BT3TotalPaid"] != null && dr["BT3TotalPaid"] != DBNull.Value)
						{
							item.BT3TotalPaid = Convert.ToDecimal(dr["BT3TotalPaid"]);
						}
						if (dr["BT3TotalDiscount"] != null && dr["BT3TotalDiscount"] != DBNull.Value)
						{
							item.BT3TotalDiscount = Convert.ToDecimal(dr["BT3TotalDiscount"]);
						}
						if (dr["BT3TotalFee"] != null && dr["BT3TotalFee"] != DBNull.Value)
						{
							item.BT3TotalFee = Convert.ToDecimal(dr["BT3TotalFee"]);
						}
						if (dr["MoneyReturn"] != null && dr["MoneyReturn"] != DBNull.Value)
						{
							item.MoneyReturn = Convert.ToDecimal(dr["MoneyReturn"]);
						}
						if (dr["DateReturn"] != null && dr["DateReturn"] != DBNull.Value)
						{
							item.DateReturn = Convert.ToDateTime(dr["DateReturn"]);
						}
						if (dr["FK_MoneyReturnSession"] != null && dr["FK_MoneyReturnSession"] != DBNull.Value)
						{
							item.FK_MoneyReturnSession = Convert.ToString(dr["FK_MoneyReturnSession"]);
						}
						if (dr["IsPayCustomer"] != null && dr["IsPayCustomer"] != DBNull.Value)
						{
							item.IsPayCustomer = Convert.ToBoolean(dr["IsPayCustomer"]);
						}
						if (dr["CustomerPayDate"] != null && dr["CustomerPayDate"] != DBNull.Value)
						{
							item.CustomerPayDate = Convert.ToDateTime(dr["CustomerPayDate"]);
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
		/// Lấy một GExpMoneyReturn đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpMoneyReturn GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpMoneyReturn] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpMoneyReturn item=new GExpMoneyReturn();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
						{
							item.BT3Code = Convert.ToString(dr["BT3Code"]);
						}
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["Status"] != null && dr["Status"] != DBNull.Value)
						{
							item.Status = Convert.ToInt32(dr["Status"]);
						}
						if (dr["BT3COD"] != null && dr["BT3COD"] != DBNull.Value)
						{
							item.BT3COD = Convert.ToDecimal(dr["BT3COD"]);
						}
						if (dr["BT3TotalPaid"] != null && dr["BT3TotalPaid"] != DBNull.Value)
						{
							item.BT3TotalPaid = Convert.ToDecimal(dr["BT3TotalPaid"]);
						}
						if (dr["BT3TotalDiscount"] != null && dr["BT3TotalDiscount"] != DBNull.Value)
						{
							item.BT3TotalDiscount = Convert.ToDecimal(dr["BT3TotalDiscount"]);
						}
						if (dr["BT3TotalFee"] != null && dr["BT3TotalFee"] != DBNull.Value)
						{
							item.BT3TotalFee = Convert.ToDecimal(dr["BT3TotalFee"]);
						}
						if (dr["MoneyReturn"] != null && dr["MoneyReturn"] != DBNull.Value)
						{
							item.MoneyReturn = Convert.ToDecimal(dr["MoneyReturn"]);
						}
						if (dr["DateReturn"] != null && dr["DateReturn"] != DBNull.Value)
						{
							item.DateReturn = Convert.ToDateTime(dr["DateReturn"]);
						}
						if (dr["FK_MoneyReturnSession"] != null && dr["FK_MoneyReturnSession"] != DBNull.Value)
						{
							item.FK_MoneyReturnSession = Convert.ToString(dr["FK_MoneyReturnSession"]);
						}
						if (dr["IsPayCustomer"] != null && dr["IsPayCustomer"] != DBNull.Value)
						{
							item.IsPayCustomer = Convert.ToBoolean(dr["IsPayCustomer"]);
						}
						if (dr["CustomerPayDate"] != null && dr["CustomerPayDate"] != DBNull.Value)
						{
							item.CustomerPayDate = Convert.ToDateTime(dr["CustomerPayDate"]);
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

		public GExpMoneyReturn GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpMoneyReturn] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpMoneyReturn>(ds);
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
		/// Thêm mới GExpMoneyReturn vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpMoneyReturn _GExpMoneyReturn)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpMoneyReturn](Id, BT3Code, BillCode, Status, BT3COD, BT3TotalPaid, BT3TotalDiscount, BT3TotalFee, MoneyReturn, DateReturn, FK_MoneyReturnSession, IsPayCustomer, CustomerPayDate) VALUES(@Id, @BT3Code, @BillCode, @Status, @BT3COD, @BT3TotalPaid, @BT3TotalDiscount, @BT3TotalFee, @MoneyReturn, @DateReturn, @FK_MoneyReturnSession, @IsPayCustomer, @CustomerPayDate)", 
					"@Id",  _GExpMoneyReturn.Id, 
					"@BT3Code",  _GExpMoneyReturn.BT3Code, 
					"@BillCode",  _GExpMoneyReturn.BillCode, 
					"@Status",  _GExpMoneyReturn.Status, 
					"@BT3COD",  _GExpMoneyReturn.BT3COD, 
					"@BT3TotalPaid",  _GExpMoneyReturn.BT3TotalPaid, 
					"@BT3TotalDiscount",  _GExpMoneyReturn.BT3TotalDiscount, 
					"@BT3TotalFee",  _GExpMoneyReturn.BT3TotalFee, 
					"@MoneyReturn",  _GExpMoneyReturn.MoneyReturn, 
					"@DateReturn", this._dataContext.ConvertDateString( _GExpMoneyReturn.DateReturn), 
					"@FK_MoneyReturnSession",  _GExpMoneyReturn.FK_MoneyReturnSession, 
					"@IsPayCustomer",  _GExpMoneyReturn.IsPayCustomer, 
					"@CustomerPayDate", this._dataContext.ConvertDateString( _GExpMoneyReturn.CustomerPayDate));
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpMoneyReturn vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpMoneyReturn> _GExpMoneyReturns)
		{
			foreach (GExpMoneyReturn item in _GExpMoneyReturns)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpMoneyReturn vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpMoneyReturn _GExpMoneyReturn, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpMoneyReturn] SET Id=@Id, BT3Code=@BT3Code, BillCode=@BillCode, Status=@Status, BT3COD=@BT3COD, BT3TotalPaid=@BT3TotalPaid, BT3TotalDiscount=@BT3TotalDiscount, BT3TotalFee=@BT3TotalFee, MoneyReturn=@MoneyReturn, DateReturn=@DateReturn, FK_MoneyReturnSession=@FK_MoneyReturnSession, IsPayCustomer=@IsPayCustomer, CustomerPayDate=@CustomerPayDate WHERE Id=@Id", 
					"@Id",  _GExpMoneyReturn.Id, 
					"@BT3Code",  _GExpMoneyReturn.BT3Code, 
					"@BillCode",  _GExpMoneyReturn.BillCode, 
					"@Status",  _GExpMoneyReturn.Status, 
					"@BT3COD",  _GExpMoneyReturn.BT3COD, 
					"@BT3TotalPaid",  _GExpMoneyReturn.BT3TotalPaid, 
					"@BT3TotalDiscount",  _GExpMoneyReturn.BT3TotalDiscount, 
					"@BT3TotalFee",  _GExpMoneyReturn.BT3TotalFee, 
					"@MoneyReturn",  _GExpMoneyReturn.MoneyReturn, 
					"@DateReturn", this._dataContext.ConvertDateString( _GExpMoneyReturn.DateReturn), 
					"@FK_MoneyReturnSession",  _GExpMoneyReturn.FK_MoneyReturnSession, 
					"@IsPayCustomer",  _GExpMoneyReturn.IsPayCustomer, 
					"@CustomerPayDate", this._dataContext.ConvertDateString( _GExpMoneyReturn.CustomerPayDate), 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpMoneyReturn vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpMoneyReturn _GExpMoneyReturn)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpMoneyReturn] SET BT3Code=@BT3Code, BillCode=@BillCode, Status=@Status, BT3COD=@BT3COD, BT3TotalPaid=@BT3TotalPaid, BT3TotalDiscount=@BT3TotalDiscount, BT3TotalFee=@BT3TotalFee, MoneyReturn=@MoneyReturn, DateReturn=@DateReturn, FK_MoneyReturnSession=@FK_MoneyReturnSession, IsPayCustomer=@IsPayCustomer, CustomerPayDate=@CustomerPayDate WHERE Id=@Id", 
					"@BT3Code",  _GExpMoneyReturn.BT3Code, 
					"@BillCode",  _GExpMoneyReturn.BillCode, 
					"@Status",  _GExpMoneyReturn.Status, 
					"@BT3COD",  _GExpMoneyReturn.BT3COD, 
					"@BT3TotalPaid",  _GExpMoneyReturn.BT3TotalPaid, 
					"@BT3TotalDiscount",  _GExpMoneyReturn.BT3TotalDiscount, 
					"@BT3TotalFee",  _GExpMoneyReturn.BT3TotalFee, 
					"@MoneyReturn",  _GExpMoneyReturn.MoneyReturn, 
					"@DateReturn", this._dataContext.ConvertDateString( _GExpMoneyReturn.DateReturn), 
					"@FK_MoneyReturnSession",  _GExpMoneyReturn.FK_MoneyReturnSession, 
					"@IsPayCustomer",  _GExpMoneyReturn.IsPayCustomer, 
					"@CustomerPayDate", this._dataContext.ConvertDateString( _GExpMoneyReturn.CustomerPayDate), 
					"@Id", _GExpMoneyReturn.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpMoneyReturn vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpMoneyReturn> _GExpMoneyReturns)
		{
			foreach (GExpMoneyReturn item in _GExpMoneyReturns)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpMoneyReturn vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpMoneyReturn _GExpMoneyReturn, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpMoneyReturn] SET Id=@Id, BT3Code=@BT3Code, BillCode=@BillCode, Status=@Status, BT3COD=@BT3COD, BT3TotalPaid=@BT3TotalPaid, BT3TotalDiscount=@BT3TotalDiscount, BT3TotalFee=@BT3TotalFee, MoneyReturn=@MoneyReturn, DateReturn=@DateReturn, FK_MoneyReturnSession=@FK_MoneyReturnSession, IsPayCustomer=@IsPayCustomer, CustomerPayDate=@CustomerPayDate "+ condition, 
					"@Id",  _GExpMoneyReturn.Id, 
					"@BT3Code",  _GExpMoneyReturn.BT3Code, 
					"@BillCode",  _GExpMoneyReturn.BillCode, 
					"@Status",  _GExpMoneyReturn.Status, 
					"@BT3COD",  _GExpMoneyReturn.BT3COD, 
					"@BT3TotalPaid",  _GExpMoneyReturn.BT3TotalPaid, 
					"@BT3TotalDiscount",  _GExpMoneyReturn.BT3TotalDiscount, 
					"@BT3TotalFee",  _GExpMoneyReturn.BT3TotalFee, 
					"@MoneyReturn",  _GExpMoneyReturn.MoneyReturn, 
					"@DateReturn", this._dataContext.ConvertDateString( _GExpMoneyReturn.DateReturn), 
					"@FK_MoneyReturnSession",  _GExpMoneyReturn.FK_MoneyReturnSession, 
					"@IsPayCustomer",  _GExpMoneyReturn.IsPayCustomer, 
					"@CustomerPayDate", this._dataContext.ConvertDateString( _GExpMoneyReturn.CustomerPayDate));
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpMoneyReturn trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpMoneyReturn] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpMoneyReturn trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpMoneyReturn _GExpMoneyReturn)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpMoneyReturn] WHERE Id=@Id",
					"@Id", _GExpMoneyReturn.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpMoneyReturn trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpMoneyReturn] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpMoneyReturn trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpMoneyReturn> _GExpMoneyReturns)
		{
			foreach (GExpMoneyReturn item in _GExpMoneyReturns)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
