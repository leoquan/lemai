using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MEXpautoreport:IEXpautoreport
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MEXpautoreport(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable ExpAutoReport từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpAutoReport]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable ExpAutoReport từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpAutoReport] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách ExpAutoReport từ Database
		/// </summary>
		public List<ExpAutoReport> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpAutoReport]");
				List<ExpAutoReport> items = new List<ExpAutoReport>();
				ExpAutoReport item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpAutoReport();
					if (dr["No"] != null && dr["No"] != DBNull.Value)
					{
						item.No = Convert.ToString(dr["No"]);
					}
					if (dr["Hour"] != null && dr["Hour"] != DBNull.Value)
					{
						item.Hour = Convert.ToInt32(dr["Hour"]);
					}
					if (dr["Minute"] != null && dr["Minute"] != DBNull.Value)
					{
						item.Minute = Convert.ToInt32(dr["Minute"]);
					}
					if (dr["UpdateDate"] != null && dr["UpdateDate"] != DBNull.Value)
					{
						item.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
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
		/// Lấy danh sách ExpAutoReport từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<ExpAutoReport> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpAutoReport] A "+ condition,  parameters);
				List<ExpAutoReport> items = new List<ExpAutoReport>();
				ExpAutoReport item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new ExpAutoReport();
					if (dr["No"] != null && dr["No"] != DBNull.Value)
					{
						item.No = Convert.ToString(dr["No"]);
					}
					if (dr["Hour"] != null && dr["Hour"] != DBNull.Value)
					{
						item.Hour = Convert.ToInt32(dr["Hour"]);
					}
					if (dr["Minute"] != null && dr["Minute"] != DBNull.Value)
					{
						item.Minute = Convert.ToInt32(dr["Minute"]);
					}
					if (dr["UpdateDate"] != null && dr["UpdateDate"] != DBNull.Value)
					{
						item.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
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

		public List<ExpAutoReport> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpAutoReport] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[ExpAutoReport] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<ExpAutoReport>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một ExpAutoReport từ Database
		/// </summary>
		public ExpAutoReport GetObject(string schema, String No)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[ExpAutoReport] where No=@No",
					"@No", No);
				if (ds.Rows.Count > 0)
				{
					ExpAutoReport item=new ExpAutoReport();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["No"] != null && dr["No"] != DBNull.Value)
						{
							item.No = Convert.ToString(dr["No"]);
						}
						if (dr["Hour"] != null && dr["Hour"] != DBNull.Value)
						{
							item.Hour = Convert.ToInt32(dr["Hour"]);
						}
						if (dr["Minute"] != null && dr["Minute"] != DBNull.Value)
						{
							item.Minute = Convert.ToInt32(dr["Minute"]);
						}
						if (dr["UpdateDate"] != null && dr["UpdateDate"] != DBNull.Value)
						{
							item.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
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
		/// Lấy một ExpAutoReport đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public ExpAutoReport GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[ExpAutoReport] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					ExpAutoReport item=new ExpAutoReport();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["No"] != null && dr["No"] != DBNull.Value)
						{
							item.No = Convert.ToString(dr["No"]);
						}
						if (dr["Hour"] != null && dr["Hour"] != DBNull.Value)
						{
							item.Hour = Convert.ToInt32(dr["Hour"]);
						}
						if (dr["Minute"] != null && dr["Minute"] != DBNull.Value)
						{
							item.Minute = Convert.ToInt32(dr["Minute"]);
						}
						if (dr["UpdateDate"] != null && dr["UpdateDate"] != DBNull.Value)
						{
							item.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
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

		public ExpAutoReport GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[ExpAutoReport] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<ExpAutoReport>(ds);
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
		/// Thêm mới ExpAutoReport vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, ExpAutoReport _ExpAutoReport)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[ExpAutoReport](No, Hour, Minute, UpdateDate) VALUES(@No, @Hour, @Minute, @UpdateDate)", 
					"@No",  _ExpAutoReport.No, 
					"@Hour",  _ExpAutoReport.Hour, 
					"@Minute",  _ExpAutoReport.Minute, 
					"@UpdateDate", this._dataContext.ConvertDateString( _ExpAutoReport.UpdateDate));
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng ExpAutoReport vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<ExpAutoReport> _ExpAutoReports)
		{
			foreach (ExpAutoReport item in _ExpAutoReports)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpAutoReport vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, ExpAutoReport _ExpAutoReport, String No)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpAutoReport] SET No=@No, Hour=@Hour, Minute=@Minute, UpdateDate=@UpdateDate WHERE No=@No", 
					"@No",  _ExpAutoReport.No, 
					"@Hour",  _ExpAutoReport.Hour, 
					"@Minute",  _ExpAutoReport.Minute, 
					"@UpdateDate", this._dataContext.ConvertDateString( _ExpAutoReport.UpdateDate), 
					"@No", No);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật ExpAutoReport vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, ExpAutoReport _ExpAutoReport)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpAutoReport] SET Hour=@Hour, Minute=@Minute, UpdateDate=@UpdateDate WHERE No=@No", 
					"@Hour",  _ExpAutoReport.Hour, 
					"@Minute",  _ExpAutoReport.Minute, 
					"@UpdateDate", this._dataContext.ConvertDateString( _ExpAutoReport.UpdateDate), 
					"@No", _ExpAutoReport.No);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách ExpAutoReport vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<ExpAutoReport> _ExpAutoReports)
		{
			foreach (ExpAutoReport item in _ExpAutoReports)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật ExpAutoReport vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, ExpAutoReport _ExpAutoReport, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[ExpAutoReport] SET No=@No, Hour=@Hour, Minute=@Minute, UpdateDate=@UpdateDate "+ condition, 
					"@No",  _ExpAutoReport.No, 
					"@Hour",  _ExpAutoReport.Hour, 
					"@Minute",  _ExpAutoReport.Minute, 
					"@UpdateDate", this._dataContext.ConvertDateString( _ExpAutoReport.UpdateDate));
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa ExpAutoReport trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String No)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpAutoReport] WHERE No=@No",
					"@No", No);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpAutoReport trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, ExpAutoReport _ExpAutoReport)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpAutoReport] WHERE No=@No",
					"@No", _ExpAutoReport.No);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpAutoReport trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[ExpAutoReport] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa ExpAutoReport trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<ExpAutoReport> _ExpAutoReports)
		{
			foreach (ExpAutoReport item in _ExpAutoReports)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
