using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpbillhistory:IGExpbillhistory
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpbillhistory(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpBillHistory từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBillHistory]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpBillHistory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBillHistory] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpBillHistory từ Database
		/// </summary>
		public List<GExpBillHistory> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBillHistory]");
				List<GExpBillHistory> items = new List<GExpBillHistory>();
				GExpBillHistory item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpBillHistory();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["BeforeUpdate"] != null && dr["BeforeUpdate"] != DBNull.Value)
					{
						item.BeforeUpdate = Convert.ToString(dr["BeforeUpdate"]);
					}
					if (dr["AfterUpdate"] != null && dr["AfterUpdate"] != DBNull.Value)
					{
						item.AfterUpdate = Convert.ToString(dr["AfterUpdate"]);
					}
					if (dr["UpdateDate"] != null && dr["UpdateDate"] != DBNull.Value)
					{
						item.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
					}
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
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
		/// Lấy danh sách GExpBillHistory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpBillHistory> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpBillHistory] A "+ condition,  parameters);
				List<GExpBillHistory> items = new List<GExpBillHistory>();
				GExpBillHistory item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpBillHistory();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["BeforeUpdate"] != null && dr["BeforeUpdate"] != DBNull.Value)
					{
						item.BeforeUpdate = Convert.ToString(dr["BeforeUpdate"]);
					}
					if (dr["AfterUpdate"] != null && dr["AfterUpdate"] != DBNull.Value)
					{
						item.AfterUpdate = Convert.ToString(dr["AfterUpdate"]);
					}
					if (dr["UpdateDate"] != null && dr["UpdateDate"] != DBNull.Value)
					{
						item.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
					}
					if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
					{
						item.FK_Account = Convert.ToString(dr["FK_Account"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
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

		public List<GExpBillHistory> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpBillHistory] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpBillHistory] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpBillHistory>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpBillHistory từ Database
		/// </summary>
		public GExpBillHistory GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBillHistory] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpBillHistory item=new GExpBillHistory();
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
						if (dr["BeforeUpdate"] != null && dr["BeforeUpdate"] != DBNull.Value)
						{
							item.BeforeUpdate = Convert.ToString(dr["BeforeUpdate"]);
						}
						if (dr["AfterUpdate"] != null && dr["AfterUpdate"] != DBNull.Value)
						{
							item.AfterUpdate = Convert.ToString(dr["AfterUpdate"]);
						}
						if (dr["UpdateDate"] != null && dr["UpdateDate"] != DBNull.Value)
						{
							item.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
						}
						if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
						{
							item.FK_Account = Convert.ToString(dr["FK_Account"]);
						}
						if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
						{
							item.FK_Post = Convert.ToString(dr["FK_Post"]);
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
		/// Lấy một GExpBillHistory đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpBillHistory GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpBillHistory] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpBillHistory item=new GExpBillHistory();
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
						if (dr["BeforeUpdate"] != null && dr["BeforeUpdate"] != DBNull.Value)
						{
							item.BeforeUpdate = Convert.ToString(dr["BeforeUpdate"]);
						}
						if (dr["AfterUpdate"] != null && dr["AfterUpdate"] != DBNull.Value)
						{
							item.AfterUpdate = Convert.ToString(dr["AfterUpdate"]);
						}
						if (dr["UpdateDate"] != null && dr["UpdateDate"] != DBNull.Value)
						{
							item.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
						}
						if (dr["FK_Account"] != null && dr["FK_Account"] != DBNull.Value)
						{
							item.FK_Account = Convert.ToString(dr["FK_Account"]);
						}
						if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
						{
							item.FK_Post = Convert.ToString(dr["FK_Post"]);
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

		public GExpBillHistory GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpBillHistory] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpBillHistory>(ds);
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
		/// Thêm mới GExpBillHistory vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpBillHistory _GExpBillHistory)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpBillHistory](Id, BillCode, BeforeUpdate, AfterUpdate, UpdateDate, FK_Account, FK_Post) VALUES(@Id, @BillCode, @BeforeUpdate, @AfterUpdate, @UpdateDate, @FK_Account, @FK_Post)", 
					"@Id",  _GExpBillHistory.Id, 
					"@BillCode",  _GExpBillHistory.BillCode, 
					"@BeforeUpdate",  _GExpBillHistory.BeforeUpdate, 
					"@AfterUpdate",  _GExpBillHistory.AfterUpdate, 
					"@UpdateDate", this._dataContext.ConvertDateString( _GExpBillHistory.UpdateDate), 
					"@FK_Account",  _GExpBillHistory.FK_Account, 
					"@FK_Post",  _GExpBillHistory.FK_Post);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpBillHistory vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpBillHistory> _GExpBillHistorys)
		{
			foreach (GExpBillHistory item in _GExpBillHistorys)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpBillHistory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpBillHistory _GExpBillHistory, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpBillHistory] SET Id=@Id, BillCode=@BillCode, BeforeUpdate=@BeforeUpdate, AfterUpdate=@AfterUpdate, UpdateDate=@UpdateDate, FK_Account=@FK_Account, FK_Post=@FK_Post WHERE Id=@Id", 
					"@Id",  _GExpBillHistory.Id, 
					"@BillCode",  _GExpBillHistory.BillCode, 
					"@BeforeUpdate",  _GExpBillHistory.BeforeUpdate, 
					"@AfterUpdate",  _GExpBillHistory.AfterUpdate, 
					"@UpdateDate", this._dataContext.ConvertDateString( _GExpBillHistory.UpdateDate), 
					"@FK_Account",  _GExpBillHistory.FK_Account, 
					"@FK_Post",  _GExpBillHistory.FK_Post, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpBillHistory vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpBillHistory _GExpBillHistory)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpBillHistory] SET BillCode=@BillCode, BeforeUpdate=@BeforeUpdate, AfterUpdate=@AfterUpdate, UpdateDate=@UpdateDate, FK_Account=@FK_Account, FK_Post=@FK_Post WHERE Id=@Id", 
					"@BillCode",  _GExpBillHistory.BillCode, 
					"@BeforeUpdate",  _GExpBillHistory.BeforeUpdate, 
					"@AfterUpdate",  _GExpBillHistory.AfterUpdate, 
					"@UpdateDate", this._dataContext.ConvertDateString( _GExpBillHistory.UpdateDate), 
					"@FK_Account",  _GExpBillHistory.FK_Account, 
					"@FK_Post",  _GExpBillHistory.FK_Post, 
					"@Id", _GExpBillHistory.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpBillHistory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpBillHistory> _GExpBillHistorys)
		{
			foreach (GExpBillHistory item in _GExpBillHistorys)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpBillHistory vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpBillHistory _GExpBillHistory, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpBillHistory] SET Id=@Id, BillCode=@BillCode, BeforeUpdate=@BeforeUpdate, AfterUpdate=@AfterUpdate, UpdateDate=@UpdateDate, FK_Account=@FK_Account, FK_Post=@FK_Post "+ condition, 
					"@Id",  _GExpBillHistory.Id, 
					"@BillCode",  _GExpBillHistory.BillCode, 
					"@BeforeUpdate",  _GExpBillHistory.BeforeUpdate, 
					"@AfterUpdate",  _GExpBillHistory.AfterUpdate, 
					"@UpdateDate", this._dataContext.ConvertDateString( _GExpBillHistory.UpdateDate), 
					"@FK_Account",  _GExpBillHistory.FK_Account, 
					"@FK_Post",  _GExpBillHistory.FK_Post);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpBillHistory trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpBillHistory] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpBillHistory trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpBillHistory _GExpBillHistory)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpBillHistory] WHERE Id=@Id",
					"@Id", _GExpBillHistory.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpBillHistory trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpBillHistory] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpBillHistory trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpBillHistory> _GExpBillHistorys)
		{
			foreach (GExpBillHistory item in _GExpBillHistorys)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
