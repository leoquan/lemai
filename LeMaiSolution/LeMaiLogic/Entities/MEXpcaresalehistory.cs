using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpcaresalehistory:IEXpcaresalehistory
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpcaresalehistory(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpCareSaleHistory từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCareSaleHistory]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpCareSaleHistory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCareSaleHistory] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpCareSaleHistory từ Database
		/// </summary>
		public List<ExpCareSaleHistory> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCareSaleHistory]");
				List<ExpCareSaleHistory> items = new List<ExpCareSaleHistory>();
				ExpCareSaleHistory item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpCareSaleHistory();
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["SaleId"] != null && dr["SaleId"] != DBNull.Value)
					{
						item.SaleId = Convert.ToString(dr["SaleId"]);
					}
					if (dr["CareId"] != null && dr["CareId"] != DBNull.Value)
					{
						item.CareId = Convert.ToString(dr["CareId"]);
					}
					if (dr["CollectId"] != null && dr["CollectId"] != DBNull.Value)
					{
						item.CollectId = Convert.ToString(dr["CollectId"]);
					}
					if (dr["SaleValue"] != null && dr["SaleValue"] != DBNull.Value)
					{
						item.SaleValue = Convert.ToInt32(dr["SaleValue"]);
					}
					if (dr["CareValue"] != null && dr["CareValue"] != DBNull.Value)
					{
						item.CareValue = Convert.ToInt32(dr["CareValue"]);
					}
					if (dr["CollectValue"] != null && dr["CollectValue"] != DBNull.Value)
					{
						item.CollectValue = Convert.ToInt32(dr["CollectValue"]);
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
		/// Lấy danh sách ExpCareSaleHistory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpCareSaleHistory> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpCareSaleHistory] A "+ condition,  parameters);
				List<ExpCareSaleHistory> items = new List<ExpCareSaleHistory>();
				ExpCareSaleHistory item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpCareSaleHistory();
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["SaleId"] != null && dr["SaleId"] != DBNull.Value)
					{
						item.SaleId = Convert.ToString(dr["SaleId"]);
					}
					if (dr["CareId"] != null && dr["CareId"] != DBNull.Value)
					{
						item.CareId = Convert.ToString(dr["CareId"]);
					}
					if (dr["CollectId"] != null && dr["CollectId"] != DBNull.Value)
					{
						item.CollectId = Convert.ToString(dr["CollectId"]);
					}
					if (dr["SaleValue"] != null && dr["SaleValue"] != DBNull.Value)
					{
						item.SaleValue = Convert.ToInt32(dr["SaleValue"]);
					}
					if (dr["CareValue"] != null && dr["CareValue"] != DBNull.Value)
					{
						item.CareValue = Convert.ToInt32(dr["CareValue"]);
					}
					if (dr["CollectValue"] != null && dr["CollectValue"] != DBNull.Value)
					{
						item.CollectValue = Convert.ToInt32(dr["CollectValue"]);
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

		public List<ExpCareSaleHistory> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpCareSaleHistory] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpCareSaleHistory] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpCareSaleHistory>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpCareSaleHistory từ Database
		/// </summary>
		public ExpCareSaleHistory GetObject(string schema, String BillCode)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCareSaleHistory] where BillCode=@BillCode",
					"@BillCode", BillCode);
				if (ds.Rows.Count > 0)
				{
					ExpCareSaleHistory item=new ExpCareSaleHistory();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["SaleId"] != null && dr["SaleId"] != DBNull.Value)
						{
							item.SaleId = Convert.ToString(dr["SaleId"]);
						}
						if (dr["CareId"] != null && dr["CareId"] != DBNull.Value)
						{
							item.CareId = Convert.ToString(dr["CareId"]);
						}
						if (dr["CollectId"] != null && dr["CollectId"] != DBNull.Value)
						{
							item.CollectId = Convert.ToString(dr["CollectId"]);
						}
						if (dr["SaleValue"] != null && dr["SaleValue"] != DBNull.Value)
						{
							item.SaleValue = Convert.ToInt32(dr["SaleValue"]);
						}
						if (dr["CareValue"] != null && dr["CareValue"] != DBNull.Value)
						{
							item.CareValue = Convert.ToInt32(dr["CareValue"]);
						}
						if (dr["CollectValue"] != null && dr["CollectValue"] != DBNull.Value)
						{
							item.CollectValue = Convert.ToInt32(dr["CollectValue"]);
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
		/// Lấy một ExpCareSaleHistory đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpCareSaleHistory GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpCareSaleHistory] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpCareSaleHistory item=new ExpCareSaleHistory();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["SaleId"] != null && dr["SaleId"] != DBNull.Value)
						{
							item.SaleId = Convert.ToString(dr["SaleId"]);
						}
						if (dr["CareId"] != null && dr["CareId"] != DBNull.Value)
						{
							item.CareId = Convert.ToString(dr["CareId"]);
						}
						if (dr["CollectId"] != null && dr["CollectId"] != DBNull.Value)
						{
							item.CollectId = Convert.ToString(dr["CollectId"]);
						}
						if (dr["SaleValue"] != null && dr["SaleValue"] != DBNull.Value)
						{
							item.SaleValue = Convert.ToInt32(dr["SaleValue"]);
						}
						if (dr["CareValue"] != null && dr["CareValue"] != DBNull.Value)
						{
							item.CareValue = Convert.ToInt32(dr["CareValue"]);
						}
						if (dr["CollectValue"] != null && dr["CollectValue"] != DBNull.Value)
						{
							item.CollectValue = Convert.ToInt32(dr["CollectValue"]);
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

		public ExpCareSaleHistory GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpCareSaleHistory] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpCareSaleHistory>(ds);
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
		/// Thêm mới ExpCareSaleHistory vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpCareSaleHistory _ExpCareSaleHistory)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpCareSaleHistory](BillCode, CreateDate, SaleId, CareId, CollectId, SaleValue, CareValue, CollectValue) VALUES(@BillCode, @CreateDate, @SaleId, @CareId, @CollectId, @SaleValue, @CareValue, @CollectValue)", 
					"@BillCode",  _ExpCareSaleHistory.BillCode, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpCareSaleHistory.CreateDate), 
					"@SaleId",  _ExpCareSaleHistory.SaleId, 
					"@CareId",  _ExpCareSaleHistory.CareId, 
					"@CollectId",  _ExpCareSaleHistory.CollectId, 
					"@SaleValue",  _ExpCareSaleHistory.SaleValue, 
					"@CareValue",  _ExpCareSaleHistory.CareValue, 
					"@CollectValue",  _ExpCareSaleHistory.CollectValue);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpCareSaleHistory vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpCareSaleHistory> _ExpCareSaleHistorys)
		{
			foreach (ExpCareSaleHistory item in _ExpCareSaleHistorys)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpCareSaleHistory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpCareSaleHistory _ExpCareSaleHistory, String BillCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCareSaleHistory] SET BillCode=@BillCode, CreateDate=@CreateDate, SaleId=@SaleId, CareId=@CareId, CollectId=@CollectId, SaleValue=@SaleValue, CareValue=@CareValue, CollectValue=@CollectValue WHERE BillCode=@BillCode", 
					"@BillCode",  _ExpCareSaleHistory.BillCode, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpCareSaleHistory.CreateDate), 
					"@SaleId",  _ExpCareSaleHistory.SaleId, 
					"@CareId",  _ExpCareSaleHistory.CareId, 
					"@CollectId",  _ExpCareSaleHistory.CollectId, 
					"@SaleValue",  _ExpCareSaleHistory.SaleValue, 
					"@CareValue",  _ExpCareSaleHistory.CareValue, 
					"@CollectValue",  _ExpCareSaleHistory.CollectValue, 
					"@BillCode", BillCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpCareSaleHistory vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpCareSaleHistory _ExpCareSaleHistory)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCareSaleHistory] SET CreateDate=@CreateDate, SaleId=@SaleId, CareId=@CareId, CollectId=@CollectId, SaleValue=@SaleValue, CareValue=@CareValue, CollectValue=@CollectValue WHERE BillCode=@BillCode", 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpCareSaleHistory.CreateDate), 
					"@SaleId",  _ExpCareSaleHistory.SaleId, 
					"@CareId",  _ExpCareSaleHistory.CareId, 
					"@CollectId",  _ExpCareSaleHistory.CollectId, 
					"@SaleValue",  _ExpCareSaleHistory.SaleValue, 
					"@CareValue",  _ExpCareSaleHistory.CareValue, 
					"@CollectValue",  _ExpCareSaleHistory.CollectValue, 
					"@BillCode", _ExpCareSaleHistory.BillCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpCareSaleHistory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpCareSaleHistory> _ExpCareSaleHistorys)
		{
			foreach (ExpCareSaleHistory item in _ExpCareSaleHistorys)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpCareSaleHistory vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpCareSaleHistory _ExpCareSaleHistory, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCareSaleHistory] SET BillCode=@BillCode, CreateDate=@CreateDate, SaleId=@SaleId, CareId=@CareId, CollectId=@CollectId, SaleValue=@SaleValue, CareValue=@CareValue, CollectValue=@CollectValue "+ condition, 
					"@BillCode",  _ExpCareSaleHistory.BillCode, 
					"@CreateDate", this._dataContext.ConvertDateString( _ExpCareSaleHistory.CreateDate), 
					"@SaleId",  _ExpCareSaleHistory.SaleId, 
					"@CareId",  _ExpCareSaleHistory.CareId, 
					"@CollectId",  _ExpCareSaleHistory.CollectId, 
					"@SaleValue",  _ExpCareSaleHistory.SaleValue, 
					"@CareValue",  _ExpCareSaleHistory.CareValue, 
					"@CollectValue",  _ExpCareSaleHistory.CollectValue);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpCareSaleHistory trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String BillCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCareSaleHistory] WHERE BillCode=@BillCode",
					"@BillCode", BillCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCareSaleHistory trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpCareSaleHistory _ExpCareSaleHistory)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCareSaleHistory] WHERE BillCode=@BillCode",
					"@BillCode", _ExpCareSaleHistory.BillCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCareSaleHistory trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCareSaleHistory] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCareSaleHistory trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpCareSaleHistory> _ExpCareSaleHistorys)
		{
			foreach (ExpCareSaleHistory item in _ExpCareSaleHistorys)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
