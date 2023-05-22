using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpshippercashdetail:IGExpshippercashdetail
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpshippercashdetail(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpShipperCashDetail từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpShipperCashDetail]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpShipperCashDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpShipperCashDetail] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpShipperCashDetail từ Database
		/// </summary>
		public List<GExpShipperCashDetail> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpShipperCashDetail]");
				List<GExpShipperCashDetail> items = new List<GExpShipperCashDetail>();
				GExpShipperCashDetail item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpShipperCashDetail();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["CashType"] != null && dr["CashType"] != DBNull.Value)
					{
						item.CashType = Convert.ToInt32(dr["CashType"]);
					}
					if (dr["MoneyValue"] != null && dr["MoneyValue"] != DBNull.Value)
					{
						item.MoneyValue = Convert.ToDecimal(dr["MoneyValue"]);
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
		/// Lấy danh sách GExpShipperCashDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpShipperCashDetail> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpShipperCashDetail] A "+ condition,  parameters);
				List<GExpShipperCashDetail> items = new List<GExpShipperCashDetail>();
				GExpShipperCashDetail item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpShipperCashDetail();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["CashType"] != null && dr["CashType"] != DBNull.Value)
					{
						item.CashType = Convert.ToInt32(dr["CashType"]);
					}
					if (dr["MoneyValue"] != null && dr["MoneyValue"] != DBNull.Value)
					{
						item.MoneyValue = Convert.ToDecimal(dr["MoneyValue"]);
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

		public List<GExpShipperCashDetail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpShipperCashDetail] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpShipperCashDetail] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpShipperCashDetail>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpShipperCashDetail từ Database
		/// </summary>
		public GExpShipperCashDetail GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpShipperCashDetail] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpShipperCashDetail item=new GExpShipperCashDetail();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["CashType"] != null && dr["CashType"] != DBNull.Value)
						{
							item.CashType = Convert.ToInt32(dr["CashType"]);
						}
						if (dr["MoneyValue"] != null && dr["MoneyValue"] != DBNull.Value)
						{
							item.MoneyValue = Convert.ToDecimal(dr["MoneyValue"]);
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
		/// Lấy một GExpShipperCashDetail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpShipperCashDetail GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpShipperCashDetail] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpShipperCashDetail item=new GExpShipperCashDetail();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["CashType"] != null && dr["CashType"] != DBNull.Value)
						{
							item.CashType = Convert.ToInt32(dr["CashType"]);
						}
						if (dr["MoneyValue"] != null && dr["MoneyValue"] != DBNull.Value)
						{
							item.MoneyValue = Convert.ToDecimal(dr["MoneyValue"]);
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

		public GExpShipperCashDetail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpShipperCashDetail] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpShipperCashDetail>(ds);
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
		/// Thêm mới GExpShipperCashDetail vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpShipperCashDetail _GExpShipperCashDetail)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpShipperCashDetail](Id, BillCode, CashType, MoneyValue) VALUES(@Id, @BillCode, @CashType, @MoneyValue)", 
					"@Id",  _GExpShipperCashDetail.Id, 
					"@BillCode",  _GExpShipperCashDetail.BillCode, 
					"@CashType",  _GExpShipperCashDetail.CashType, 
					"@MoneyValue",  _GExpShipperCashDetail.MoneyValue);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpShipperCashDetail vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpShipperCashDetail> _GExpShipperCashDetails)
		{
			foreach (GExpShipperCashDetail item in _GExpShipperCashDetails)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpShipperCashDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpShipperCashDetail _GExpShipperCashDetail, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpShipperCashDetail] SET Id=@Id, BillCode=@BillCode, CashType=@CashType, MoneyValue=@MoneyValue WHERE Id=@Id", 
					"@Id",  _GExpShipperCashDetail.Id, 
					"@BillCode",  _GExpShipperCashDetail.BillCode, 
					"@CashType",  _GExpShipperCashDetail.CashType, 
					"@MoneyValue",  _GExpShipperCashDetail.MoneyValue, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpShipperCashDetail vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpShipperCashDetail _GExpShipperCashDetail)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpShipperCashDetail] SET BillCode=@BillCode, CashType=@CashType, MoneyValue=@MoneyValue WHERE Id=@Id", 
					"@BillCode",  _GExpShipperCashDetail.BillCode, 
					"@CashType",  _GExpShipperCashDetail.CashType, 
					"@MoneyValue",  _GExpShipperCashDetail.MoneyValue, 
					"@Id", _GExpShipperCashDetail.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpShipperCashDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpShipperCashDetail> _GExpShipperCashDetails)
		{
			foreach (GExpShipperCashDetail item in _GExpShipperCashDetails)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpShipperCashDetail vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpShipperCashDetail _GExpShipperCashDetail, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpShipperCashDetail] SET Id=@Id, BillCode=@BillCode, CashType=@CashType, MoneyValue=@MoneyValue "+ condition, 
					"@Id",  _GExpShipperCashDetail.Id, 
					"@BillCode",  _GExpShipperCashDetail.BillCode, 
					"@CashType",  _GExpShipperCashDetail.CashType, 
					"@MoneyValue",  _GExpShipperCashDetail.MoneyValue);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpShipperCashDetail trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpShipperCashDetail] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpShipperCashDetail trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpShipperCashDetail _GExpShipperCashDetail)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpShipperCashDetail] WHERE Id=@Id",
					"@Id", _GExpShipperCashDetail.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpShipperCashDetail trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpShipperCashDetail] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpShipperCashDetail trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpShipperCashDetail> _GExpShipperCashDetails)
		{
			foreach (GExpShipperCashDetail item in _GExpShipperCashDetails)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
