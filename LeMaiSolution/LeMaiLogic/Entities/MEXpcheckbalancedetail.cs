using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpcheckbalancedetail:IEXpcheckbalancedetail
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpcheckbalancedetail(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpCheckBalanceDetail từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCheckBalanceDetail]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpCheckBalanceDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCheckBalanceDetail] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpCheckBalanceDetail từ Database
		/// </summary>
		public List<ExpCheckBalanceDetail> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCheckBalanceDetail]");
				List<ExpCheckBalanceDetail> items = new List<ExpCheckBalanceDetail>();
				ExpCheckBalanceDetail item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpCheckBalanceDetail();
					if (dr["BalanceType"] != null && dr["BalanceType"] != DBNull.Value)
					{
						item.BalanceType = Convert.ToString(dr["BalanceType"]);
					}
					if (dr["FK_CheckBalance"] != null && dr["FK_CheckBalance"] != DBNull.Value)
					{
						item.FK_CheckBalance = Convert.ToString(dr["FK_CheckBalance"]);
					}
					if (dr["BalanceTypeName"] != null && dr["BalanceTypeName"] != DBNull.Value)
					{
						item.BalanceTypeName = Convert.ToString(dr["BalanceTypeName"]);
					}
					if (dr["MoneyValue"] != null && dr["MoneyValue"] != DBNull.Value)
					{
						item.MoneyValue = Convert.ToDecimal(dr["MoneyValue"]);
					}
					if (dr["CheckDate"] != null && dr["CheckDate"] != DBNull.Value)
					{
						item.CheckDate = Convert.ToDateTime(dr["CheckDate"]);
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
		/// Lấy danh sách ExpCheckBalanceDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpCheckBalanceDetail> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpCheckBalanceDetail] A "+ condition,  parameters);
				List<ExpCheckBalanceDetail> items = new List<ExpCheckBalanceDetail>();
				ExpCheckBalanceDetail item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpCheckBalanceDetail();
					if (dr["BalanceType"] != null && dr["BalanceType"] != DBNull.Value)
					{
						item.BalanceType = Convert.ToString(dr["BalanceType"]);
					}
					if (dr["FK_CheckBalance"] != null && dr["FK_CheckBalance"] != DBNull.Value)
					{
						item.FK_CheckBalance = Convert.ToString(dr["FK_CheckBalance"]);
					}
					if (dr["BalanceTypeName"] != null && dr["BalanceTypeName"] != DBNull.Value)
					{
						item.BalanceTypeName = Convert.ToString(dr["BalanceTypeName"]);
					}
					if (dr["MoneyValue"] != null && dr["MoneyValue"] != DBNull.Value)
					{
						item.MoneyValue = Convert.ToDecimal(dr["MoneyValue"]);
					}
					if (dr["CheckDate"] != null && dr["CheckDate"] != DBNull.Value)
					{
						item.CheckDate = Convert.ToDateTime(dr["CheckDate"]);
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

		public List<ExpCheckBalanceDetail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpCheckBalanceDetail] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpCheckBalanceDetail] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpCheckBalanceDetail>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpCheckBalanceDetail từ Database
		/// </summary>
		public ExpCheckBalanceDetail GetObject(string schema, String BalanceType, String FK_CheckBalance)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpCheckBalanceDetail] where BalanceType=@BalanceType and FK_CheckBalance=@FK_CheckBalance",
					"@BalanceType", BalanceType, 
					"@FK_CheckBalance", FK_CheckBalance);
				if (ds.Rows.Count > 0)
				{
					ExpCheckBalanceDetail item=new ExpCheckBalanceDetail();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["BalanceType"] != null && dr["BalanceType"] != DBNull.Value)
						{
							item.BalanceType = Convert.ToString(dr["BalanceType"]);
						}
						if (dr["FK_CheckBalance"] != null && dr["FK_CheckBalance"] != DBNull.Value)
						{
							item.FK_CheckBalance = Convert.ToString(dr["FK_CheckBalance"]);
						}
						if (dr["BalanceTypeName"] != null && dr["BalanceTypeName"] != DBNull.Value)
						{
							item.BalanceTypeName = Convert.ToString(dr["BalanceTypeName"]);
						}
						if (dr["MoneyValue"] != null && dr["MoneyValue"] != DBNull.Value)
						{
							item.MoneyValue = Convert.ToDecimal(dr["MoneyValue"]);
						}
						if (dr["CheckDate"] != null && dr["CheckDate"] != DBNull.Value)
						{
							item.CheckDate = Convert.ToDateTime(dr["CheckDate"]);
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
		/// Lấy một ExpCheckBalanceDetail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpCheckBalanceDetail GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpCheckBalanceDetail] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpCheckBalanceDetail item=new ExpCheckBalanceDetail();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["BalanceType"] != null && dr["BalanceType"] != DBNull.Value)
						{
							item.BalanceType = Convert.ToString(dr["BalanceType"]);
						}
						if (dr["FK_CheckBalance"] != null && dr["FK_CheckBalance"] != DBNull.Value)
						{
							item.FK_CheckBalance = Convert.ToString(dr["FK_CheckBalance"]);
						}
						if (dr["BalanceTypeName"] != null && dr["BalanceTypeName"] != DBNull.Value)
						{
							item.BalanceTypeName = Convert.ToString(dr["BalanceTypeName"]);
						}
						if (dr["MoneyValue"] != null && dr["MoneyValue"] != DBNull.Value)
						{
							item.MoneyValue = Convert.ToDecimal(dr["MoneyValue"]);
						}
						if (dr["CheckDate"] != null && dr["CheckDate"] != DBNull.Value)
						{
							item.CheckDate = Convert.ToDateTime(dr["CheckDate"]);
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

		public ExpCheckBalanceDetail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpCheckBalanceDetail] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpCheckBalanceDetail>(ds);
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
		/// Thêm mới ExpCheckBalanceDetail vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpCheckBalanceDetail _ExpCheckBalanceDetail)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpCheckBalanceDetail](BalanceType, FK_CheckBalance, BalanceTypeName, MoneyValue, CheckDate) VALUES(@BalanceType, @FK_CheckBalance, @BalanceTypeName, @MoneyValue, @CheckDate)", 
					"@BalanceType",  _ExpCheckBalanceDetail.BalanceType, 
					"@FK_CheckBalance",  _ExpCheckBalanceDetail.FK_CheckBalance, 
					"@BalanceTypeName",  _ExpCheckBalanceDetail.BalanceTypeName, 
					"@MoneyValue",  _ExpCheckBalanceDetail.MoneyValue, 
					"@CheckDate", this._dataContext.ConvertDateString( _ExpCheckBalanceDetail.CheckDate));
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpCheckBalanceDetail vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpCheckBalanceDetail> _ExpCheckBalanceDetails)
		{
			foreach (ExpCheckBalanceDetail item in _ExpCheckBalanceDetails)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpCheckBalanceDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpCheckBalanceDetail _ExpCheckBalanceDetail, String BalanceType, String FK_CheckBalance)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCheckBalanceDetail] SET BalanceType=@BalanceType, FK_CheckBalance=@FK_CheckBalance, BalanceTypeName=@BalanceTypeName, MoneyValue=@MoneyValue, CheckDate=@CheckDate WHERE BalanceType=@BalanceType and FK_CheckBalance=@FK_CheckBalance", 
					"@BalanceType",  _ExpCheckBalanceDetail.BalanceType, 
					"@FK_CheckBalance",  _ExpCheckBalanceDetail.FK_CheckBalance, 
					"@BalanceTypeName",  _ExpCheckBalanceDetail.BalanceTypeName, 
					"@MoneyValue",  _ExpCheckBalanceDetail.MoneyValue, 
					"@CheckDate", this._dataContext.ConvertDateString( _ExpCheckBalanceDetail.CheckDate), 
					"@BalanceType", BalanceType, 
					"@FK_CheckBalance", FK_CheckBalance);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpCheckBalanceDetail vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpCheckBalanceDetail _ExpCheckBalanceDetail)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCheckBalanceDetail] SET BalanceTypeName=@BalanceTypeName, MoneyValue=@MoneyValue, CheckDate=@CheckDate WHERE BalanceType=@BalanceType and FK_CheckBalance=@FK_CheckBalance", 
					"@BalanceTypeName",  _ExpCheckBalanceDetail.BalanceTypeName, 
					"@MoneyValue",  _ExpCheckBalanceDetail.MoneyValue, 
					"@CheckDate", this._dataContext.ConvertDateString( _ExpCheckBalanceDetail.CheckDate), 
					"@BalanceType", _ExpCheckBalanceDetail.BalanceType, 
					"@FK_CheckBalance", _ExpCheckBalanceDetail.FK_CheckBalance);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpCheckBalanceDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpCheckBalanceDetail> _ExpCheckBalanceDetails)
		{
			foreach (ExpCheckBalanceDetail item in _ExpCheckBalanceDetails)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpCheckBalanceDetail vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpCheckBalanceDetail _ExpCheckBalanceDetail, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpCheckBalanceDetail] SET BalanceType=@BalanceType, FK_CheckBalance=@FK_CheckBalance, BalanceTypeName=@BalanceTypeName, MoneyValue=@MoneyValue, CheckDate=@CheckDate "+ condition, 
					"@BalanceType",  _ExpCheckBalanceDetail.BalanceType, 
					"@FK_CheckBalance",  _ExpCheckBalanceDetail.FK_CheckBalance, 
					"@BalanceTypeName",  _ExpCheckBalanceDetail.BalanceTypeName, 
					"@MoneyValue",  _ExpCheckBalanceDetail.MoneyValue, 
					"@CheckDate", this._dataContext.ConvertDateString( _ExpCheckBalanceDetail.CheckDate));
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpCheckBalanceDetail trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String BalanceType, String FK_CheckBalance)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCheckBalanceDetail] WHERE BalanceType=@BalanceType and FK_CheckBalance=@FK_CheckBalance",
					"@BalanceType", BalanceType, 
					"@FK_CheckBalance", FK_CheckBalance);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCheckBalanceDetail trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpCheckBalanceDetail _ExpCheckBalanceDetail)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCheckBalanceDetail] WHERE BalanceType=@BalanceType and FK_CheckBalance=@FK_CheckBalance",
					"@BalanceType", _ExpCheckBalanceDetail.BalanceType, 
					"@FK_CheckBalance", _ExpCheckBalanceDetail.FK_CheckBalance);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCheckBalanceDetail trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpCheckBalanceDetail] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpCheckBalanceDetail trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpCheckBalanceDetail> _ExpCheckBalanceDetails)
		{
			foreach (ExpCheckBalanceDetail item in _ExpCheckBalanceDetails)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
