using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpdoisoathistory:IGExpdoisoathistory
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpdoisoathistory(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpDoiSoatHistory từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDoiSoatHistory]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpDoiSoatHistory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDoiSoatHistory] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpDoiSoatHistory từ Database
		/// </summary>
		public List<GExpDoiSoatHistory> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDoiSoatHistory]");
				List<GExpDoiSoatHistory> items = new List<GExpDoiSoatHistory>();
				GExpDoiSoatHistory item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpDoiSoatHistory();
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
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
		/// Lấy danh sách GExpDoiSoatHistory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpDoiSoatHistory> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpDoiSoatHistory] A "+ condition,  parameters);
				List<GExpDoiSoatHistory> items = new List<GExpDoiSoatHistory>();
				GExpDoiSoatHistory item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpDoiSoatHistory();
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
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

		public List<GExpDoiSoatHistory> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpDoiSoatHistory] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpDoiSoatHistory] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpDoiSoatHistory>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpDoiSoatHistory từ Database
		/// </summary>
		public GExpDoiSoatHistory GetObject(string schema, String BillCode)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDoiSoatHistory] where BillCode=@BillCode",
					"@BillCode", BillCode);
				if (ds.Rows.Count > 0)
				{
					GExpDoiSoatHistory item=new GExpDoiSoatHistory();
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
						if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
						{
							item.FK_Account = Convert.ToString(dr["FK_Account"]);
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
		/// Lấy một GExpDoiSoatHistory đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpDoiSoatHistory GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpDoiSoatHistory] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpDoiSoatHistory item=new GExpDoiSoatHistory();
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
						if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
						{
							item.FK_Account = Convert.ToString(dr["FK_Account"]);
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

		public GExpDoiSoatHistory GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpDoiSoatHistory] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpDoiSoatHistory>(ds);
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
		/// Thêm mới GExpDoiSoatHistory vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpDoiSoatHistory _GExpDoiSoatHistory)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpDoiSoatHistory](BillCode, CreateDate, FK_Account) VALUES(@BillCode, @CreateDate, @FK_Account)", 
					"@BillCode",  _GExpDoiSoatHistory.BillCode, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpDoiSoatHistory.CreateDate), 
					"@FK_Account",  _GExpDoiSoatHistory.FK_Account);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpDoiSoatHistory vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpDoiSoatHistory> _GExpDoiSoatHistorys)
		{
			foreach (GExpDoiSoatHistory item in _GExpDoiSoatHistorys)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpDoiSoatHistory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpDoiSoatHistory _GExpDoiSoatHistory, String BillCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDoiSoatHistory] SET BillCode=@BillCode, CreateDate=@CreateDate, FK_Account=@FK_Account WHERE BillCode=@BillCode", 
					"@BillCode",  _GExpDoiSoatHistory.BillCode, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpDoiSoatHistory.CreateDate), 
					"@FK_Account",  _GExpDoiSoatHistory.FK_Account, 
					"@BillCode", BillCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpDoiSoatHistory vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpDoiSoatHistory _GExpDoiSoatHistory)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDoiSoatHistory] SET CreateDate=@CreateDate, FK_Account=@FK_Account WHERE BillCode=@BillCode", 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpDoiSoatHistory.CreateDate), 
					"@FK_Account",  _GExpDoiSoatHistory.FK_Account, 
					"@BillCode", _GExpDoiSoatHistory.BillCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpDoiSoatHistory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpDoiSoatHistory> _GExpDoiSoatHistorys)
		{
			foreach (GExpDoiSoatHistory item in _GExpDoiSoatHistorys)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpDoiSoatHistory vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpDoiSoatHistory _GExpDoiSoatHistory, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDoiSoatHistory] SET BillCode=@BillCode, CreateDate=@CreateDate, FK_Account=@FK_Account "+ condition, 
					"@BillCode",  _GExpDoiSoatHistory.BillCode, 
					"@CreateDate", this._dataContext.ConvertDateString( _GExpDoiSoatHistory.CreateDate), 
					"@FK_Account",  _GExpDoiSoatHistory.FK_Account);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpDoiSoatHistory trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String BillCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDoiSoatHistory] WHERE BillCode=@BillCode",
					"@BillCode", BillCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDoiSoatHistory trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpDoiSoatHistory _GExpDoiSoatHistory)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDoiSoatHistory] WHERE BillCode=@BillCode",
					"@BillCode", _GExpDoiSoatHistory.BillCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDoiSoatHistory trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDoiSoatHistory] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDoiSoatHistory trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpDoiSoatHistory> _GExpDoiSoatHistorys)
		{
			foreach (GExpDoiSoatHistory item in _GExpDoiSoatHistorys)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
