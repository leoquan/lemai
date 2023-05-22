using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpsiteautorun:IEXpsiteautorun
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpsiteautorun(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpSiteAutoRun từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpSiteAutoRun]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpSiteAutoRun từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpSiteAutoRun] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpSiteAutoRun từ Database
		/// </summary>
		public List<ExpSiteAutoRun> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpSiteAutoRun]");
				List<ExpSiteAutoRun> items = new List<ExpSiteAutoRun>();
				ExpSiteAutoRun item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpSiteAutoRun();
					if (dr["SiteId"] != null && dr["SiteId"] != DBNull.Value)
					{
						item.SiteId = Convert.ToString(dr["SiteId"]);
					}
					if (dr["UserId"] != null && dr["UserId"] != DBNull.Value)
					{
						item.UserId = Convert.ToString(dr["UserId"]);
					}
					if (dr["Password"] != null && dr["Password"] != DBNull.Value)
					{
						item.Password = Convert.ToString(dr["Password"]);
					}
					if (dr["C2SiteCode"] != null && dr["C2SiteCode"] != DBNull.Value)
					{
						item.C2SiteCode = Convert.ToString(dr["C2SiteCode"]);
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
		/// Lấy danh sách ExpSiteAutoRun từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpSiteAutoRun> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpSiteAutoRun] A "+ condition,  parameters);
				List<ExpSiteAutoRun> items = new List<ExpSiteAutoRun>();
				ExpSiteAutoRun item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpSiteAutoRun();
					if (dr["SiteId"] != null && dr["SiteId"] != DBNull.Value)
					{
						item.SiteId = Convert.ToString(dr["SiteId"]);
					}
					if (dr["UserId"] != null && dr["UserId"] != DBNull.Value)
					{
						item.UserId = Convert.ToString(dr["UserId"]);
					}
					if (dr["Password"] != null && dr["Password"] != DBNull.Value)
					{
						item.Password = Convert.ToString(dr["Password"]);
					}
					if (dr["C2SiteCode"] != null && dr["C2SiteCode"] != DBNull.Value)
					{
						item.C2SiteCode = Convert.ToString(dr["C2SiteCode"]);
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

		public List<ExpSiteAutoRun> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpSiteAutoRun] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpSiteAutoRun] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpSiteAutoRun>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpSiteAutoRun từ Database
		/// </summary>
		public ExpSiteAutoRun GetObject(string schema, String SiteId)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpSiteAutoRun] where SiteId=@SiteId",
					"@SiteId", SiteId);
				if (ds.Rows.Count > 0)
				{
					ExpSiteAutoRun item=new ExpSiteAutoRun();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["SiteId"] != null && dr["SiteId"] != DBNull.Value)
						{
							item.SiteId = Convert.ToString(dr["SiteId"]);
						}
						if (dr["UserId"] != null && dr["UserId"] != DBNull.Value)
						{
							item.UserId = Convert.ToString(dr["UserId"]);
						}
						if (dr["Password"] != null && dr["Password"] != DBNull.Value)
						{
							item.Password = Convert.ToString(dr["Password"]);
						}
						if (dr["C2SiteCode"] != null && dr["C2SiteCode"] != DBNull.Value)
						{
							item.C2SiteCode = Convert.ToString(dr["C2SiteCode"]);
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
		/// Lấy một ExpSiteAutoRun đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpSiteAutoRun GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpSiteAutoRun] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpSiteAutoRun item=new ExpSiteAutoRun();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["SiteId"] != null && dr["SiteId"] != DBNull.Value)
						{
							item.SiteId = Convert.ToString(dr["SiteId"]);
						}
						if (dr["UserId"] != null && dr["UserId"] != DBNull.Value)
						{
							item.UserId = Convert.ToString(dr["UserId"]);
						}
						if (dr["Password"] != null && dr["Password"] != DBNull.Value)
						{
							item.Password = Convert.ToString(dr["Password"]);
						}
						if (dr["C2SiteCode"] != null && dr["C2SiteCode"] != DBNull.Value)
						{
							item.C2SiteCode = Convert.ToString(dr["C2SiteCode"]);
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

		public ExpSiteAutoRun GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpSiteAutoRun] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpSiteAutoRun>(ds);
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
		/// Thêm mới ExpSiteAutoRun vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpSiteAutoRun _ExpSiteAutoRun)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpSiteAutoRun](SiteId, UserId, Password, C2SiteCode) VALUES(@SiteId, @UserId, @Password, @C2SiteCode)", 
					"@SiteId",  _ExpSiteAutoRun.SiteId, 
					"@UserId",  _ExpSiteAutoRun.UserId, 
					"@Password",  _ExpSiteAutoRun.Password, 
					"@C2SiteCode",  _ExpSiteAutoRun.C2SiteCode);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpSiteAutoRun vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpSiteAutoRun> _ExpSiteAutoRuns)
		{
			foreach (ExpSiteAutoRun item in _ExpSiteAutoRuns)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpSiteAutoRun vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpSiteAutoRun _ExpSiteAutoRun, String SiteId)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpSiteAutoRun] SET SiteId=@SiteId, UserId=@UserId, Password=@Password, C2SiteCode=@C2SiteCode WHERE SiteId=@SiteId", 
					"@SiteId",  _ExpSiteAutoRun.SiteId, 
					"@UserId",  _ExpSiteAutoRun.UserId, 
					"@Password",  _ExpSiteAutoRun.Password, 
					"@C2SiteCode",  _ExpSiteAutoRun.C2SiteCode, 
					"@SiteId", SiteId);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpSiteAutoRun vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpSiteAutoRun _ExpSiteAutoRun)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpSiteAutoRun] SET UserId=@UserId, Password=@Password, C2SiteCode=@C2SiteCode WHERE SiteId=@SiteId", 
					"@UserId",  _ExpSiteAutoRun.UserId, 
					"@Password",  _ExpSiteAutoRun.Password, 
					"@C2SiteCode",  _ExpSiteAutoRun.C2SiteCode, 
					"@SiteId", _ExpSiteAutoRun.SiteId);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpSiteAutoRun vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpSiteAutoRun> _ExpSiteAutoRuns)
		{
			foreach (ExpSiteAutoRun item in _ExpSiteAutoRuns)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpSiteAutoRun vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpSiteAutoRun _ExpSiteAutoRun, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpSiteAutoRun] SET SiteId=@SiteId, UserId=@UserId, Password=@Password, C2SiteCode=@C2SiteCode "+ condition, 
					"@SiteId",  _ExpSiteAutoRun.SiteId, 
					"@UserId",  _ExpSiteAutoRun.UserId, 
					"@Password",  _ExpSiteAutoRun.Password, 
					"@C2SiteCode",  _ExpSiteAutoRun.C2SiteCode);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpSiteAutoRun trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String SiteId)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpSiteAutoRun] WHERE SiteId=@SiteId",
					"@SiteId", SiteId);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpSiteAutoRun trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpSiteAutoRun _ExpSiteAutoRun)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpSiteAutoRun] WHERE SiteId=@SiteId",
					"@SiteId", _ExpSiteAutoRun.SiteId);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpSiteAutoRun trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpSiteAutoRun] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpSiteAutoRun trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpSiteAutoRun> _ExpSiteAutoRuns)
		{
			foreach (ExpSiteAutoRun item in _ExpSiteAutoRuns)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
