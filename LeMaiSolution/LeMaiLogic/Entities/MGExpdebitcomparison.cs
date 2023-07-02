using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpdebitcomparison:IGExpdebitcomparison
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpdebitcomparison(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpDebitComparison từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDebitComparison]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpDebitComparison từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDebitComparison] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpDebitComparison từ Database
		/// </summary>
		public List<GExpDebitComparison> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDebitComparison]");
				List<GExpDebitComparison> items = new List<GExpDebitComparison>();
				GExpDebitComparison item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpDebitComparison();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["DebitComparisonCode"] != null && dr["DebitComparisonCode"] != DBNull.Value)
					{
						item.DebitComparisonCode = Convert.ToString(dr["DebitComparisonCode"]);
					}
					if (dr["DebitComparisonDate"] != null && dr["DebitComparisonDate"] != DBNull.Value)
					{
						item.DebitComparisonDate = Convert.ToDateTime(dr["DebitComparisonDate"]);
					}
					if (dr["SuccessCount"] != null && dr["SuccessCount"] != DBNull.Value)
					{
						item.SuccessCount = Convert.ToInt32(dr["SuccessCount"]);
					}
					if (dr["ReturnCount"] != null && dr["ReturnCount"] != DBNull.Value)
					{
						item.ReturnCount = Convert.ToInt32(dr["ReturnCount"]);
					}
					if (dr["PendingCount"] != null && dr["PendingCount"] != DBNull.Value)
					{
						item.PendingCount = Convert.ToInt32(dr["PendingCount"]);
					}
					if (dr["FeeCost"] != null && dr["FeeCost"] != DBNull.Value)
					{
						item.FeeCost = Convert.ToDecimal(dr["FeeCost"]);
					}
					if (dr["COD"] != null && dr["COD"] != DBNull.Value)
					{
						item.COD = Convert.ToDecimal(dr["COD"]);
					}
					if (dr["ReturnCOD"] != null && dr["ReturnCOD"] != DBNull.Value)
					{
						item.ReturnCOD = Convert.ToDecimal(dr["ReturnCOD"]);
					}
					if (dr["FK_Provider"] != null && dr["FK_Provider"] != DBNull.Value)
					{
						item.FK_Provider = Convert.ToString(dr["FK_Provider"]);
					}
					if (dr["FK_AccountRefer"] != null && dr["FK_AccountRefer"] != DBNull.Value)
					{
						item.FK_AccountRefer = Convert.ToString(dr["FK_AccountRefer"]);
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
		/// Lấy danh sách GExpDebitComparison từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpDebitComparison> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpDebitComparison] A "+ condition,  parameters);
				List<GExpDebitComparison> items = new List<GExpDebitComparison>();
				GExpDebitComparison item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpDebitComparison();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["DebitComparisonCode"] != null && dr["DebitComparisonCode"] != DBNull.Value)
					{
						item.DebitComparisonCode = Convert.ToString(dr["DebitComparisonCode"]);
					}
					if (dr["DebitComparisonDate"] != null && dr["DebitComparisonDate"] != DBNull.Value)
					{
						item.DebitComparisonDate = Convert.ToDateTime(dr["DebitComparisonDate"]);
					}
					if (dr["SuccessCount"] != null && dr["SuccessCount"] != DBNull.Value)
					{
						item.SuccessCount = Convert.ToInt32(dr["SuccessCount"]);
					}
					if (dr["ReturnCount"] != null && dr["ReturnCount"] != DBNull.Value)
					{
						item.ReturnCount = Convert.ToInt32(dr["ReturnCount"]);
					}
					if (dr["PendingCount"] != null && dr["PendingCount"] != DBNull.Value)
					{
						item.PendingCount = Convert.ToInt32(dr["PendingCount"]);
					}
					if (dr["FeeCost"] != null && dr["FeeCost"] != DBNull.Value)
					{
						item.FeeCost = Convert.ToDecimal(dr["FeeCost"]);
					}
					if (dr["COD"] != null && dr["COD"] != DBNull.Value)
					{
						item.COD = Convert.ToDecimal(dr["COD"]);
					}
					if (dr["ReturnCOD"] != null && dr["ReturnCOD"] != DBNull.Value)
					{
						item.ReturnCOD = Convert.ToDecimal(dr["ReturnCOD"]);
					}
					if (dr["FK_Provider"] != null && dr["FK_Provider"] != DBNull.Value)
					{
						item.FK_Provider = Convert.ToString(dr["FK_Provider"]);
					}
					if (dr["FK_AccountRefer"] != null && dr["FK_AccountRefer"] != DBNull.Value)
					{
						item.FK_AccountRefer = Convert.ToString(dr["FK_AccountRefer"]);
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

		public List<GExpDebitComparison> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpDebitComparison] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpDebitComparison] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpDebitComparison>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpDebitComparison từ Database
		/// </summary>
		public GExpDebitComparison GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpDebitComparison] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpDebitComparison item=new GExpDebitComparison();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["DebitComparisonCode"] != null && dr["DebitComparisonCode"] != DBNull.Value)
						{
							item.DebitComparisonCode = Convert.ToString(dr["DebitComparisonCode"]);
						}
						if (dr["DebitComparisonDate"] != null && dr["DebitComparisonDate"] != DBNull.Value)
						{
							item.DebitComparisonDate = Convert.ToDateTime(dr["DebitComparisonDate"]);
						}
						if (dr["SuccessCount"] != null && dr["SuccessCount"] != DBNull.Value)
						{
							item.SuccessCount = Convert.ToInt32(dr["SuccessCount"]);
						}
						if (dr["ReturnCount"] != null && dr["ReturnCount"] != DBNull.Value)
						{
							item.ReturnCount = Convert.ToInt32(dr["ReturnCount"]);
						}
						if (dr["PendingCount"] != null && dr["PendingCount"] != DBNull.Value)
						{
							item.PendingCount = Convert.ToInt32(dr["PendingCount"]);
						}
						if (dr["FeeCost"] != null && dr["FeeCost"] != DBNull.Value)
						{
							item.FeeCost = Convert.ToDecimal(dr["FeeCost"]);
						}
						if (dr["COD"] != null && dr["COD"] != DBNull.Value)
						{
							item.COD = Convert.ToDecimal(dr["COD"]);
						}
						if (dr["ReturnCOD"] != null && dr["ReturnCOD"] != DBNull.Value)
						{
							item.ReturnCOD = Convert.ToDecimal(dr["ReturnCOD"]);
						}
						if (dr["FK_Provider"] != null && dr["FK_Provider"] != DBNull.Value)
						{
							item.FK_Provider = Convert.ToString(dr["FK_Provider"]);
						}
						if (dr["FK_AccountRefer"] != null && dr["FK_AccountRefer"] != DBNull.Value)
						{
							item.FK_AccountRefer = Convert.ToString(dr["FK_AccountRefer"]);
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
		/// Lấy một GExpDebitComparison đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpDebitComparison GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpDebitComparison] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpDebitComparison item=new GExpDebitComparison();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["DebitComparisonCode"] != null && dr["DebitComparisonCode"] != DBNull.Value)
						{
							item.DebitComparisonCode = Convert.ToString(dr["DebitComparisonCode"]);
						}
						if (dr["DebitComparisonDate"] != null && dr["DebitComparisonDate"] != DBNull.Value)
						{
							item.DebitComparisonDate = Convert.ToDateTime(dr["DebitComparisonDate"]);
						}
						if (dr["SuccessCount"] != null && dr["SuccessCount"] != DBNull.Value)
						{
							item.SuccessCount = Convert.ToInt32(dr["SuccessCount"]);
						}
						if (dr["ReturnCount"] != null && dr["ReturnCount"] != DBNull.Value)
						{
							item.ReturnCount = Convert.ToInt32(dr["ReturnCount"]);
						}
						if (dr["PendingCount"] != null && dr["PendingCount"] != DBNull.Value)
						{
							item.PendingCount = Convert.ToInt32(dr["PendingCount"]);
						}
						if (dr["FeeCost"] != null && dr["FeeCost"] != DBNull.Value)
						{
							item.FeeCost = Convert.ToDecimal(dr["FeeCost"]);
						}
						if (dr["COD"] != null && dr["COD"] != DBNull.Value)
						{
							item.COD = Convert.ToDecimal(dr["COD"]);
						}
						if (dr["ReturnCOD"] != null && dr["ReturnCOD"] != DBNull.Value)
						{
							item.ReturnCOD = Convert.ToDecimal(dr["ReturnCOD"]);
						}
						if (dr["FK_Provider"] != null && dr["FK_Provider"] != DBNull.Value)
						{
							item.FK_Provider = Convert.ToString(dr["FK_Provider"]);
						}
						if (dr["FK_AccountRefer"] != null && dr["FK_AccountRefer"] != DBNull.Value)
						{
							item.FK_AccountRefer = Convert.ToString(dr["FK_AccountRefer"]);
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

		public GExpDebitComparison GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpDebitComparison] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpDebitComparison>(ds);
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
		/// Thêm mới GExpDebitComparison vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpDebitComparison _GExpDebitComparison)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpDebitComparison](Id, DebitComparisonCode, DebitComparisonDate, SuccessCount, ReturnCount, PendingCount, FeeCost, COD, ReturnCOD, FK_Provider, FK_AccountRefer, FK_Post) VALUES(@Id, @DebitComparisonCode, @DebitComparisonDate, @SuccessCount, @ReturnCount, @PendingCount, @FeeCost, @COD, @ReturnCOD, @FK_Provider, @FK_AccountRefer, @FK_Post)", 
					"@Id",  _GExpDebitComparison.Id, 
					"@DebitComparisonCode",  _GExpDebitComparison.DebitComparisonCode, 
					"@DebitComparisonDate", this._dataContext.ConvertDateString( _GExpDebitComparison.DebitComparisonDate), 
					"@SuccessCount",  _GExpDebitComparison.SuccessCount, 
					"@ReturnCount",  _GExpDebitComparison.ReturnCount, 
					"@PendingCount",  _GExpDebitComparison.PendingCount, 
					"@FeeCost",  _GExpDebitComparison.FeeCost, 
					"@COD",  _GExpDebitComparison.COD, 
					"@ReturnCOD",  _GExpDebitComparison.ReturnCOD, 
					"@FK_Provider",  _GExpDebitComparison.FK_Provider, 
					"@FK_AccountRefer",  _GExpDebitComparison.FK_AccountRefer, 
					"@FK_Post",  _GExpDebitComparison.FK_Post);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpDebitComparison vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpDebitComparison> _GExpDebitComparisons)
		{
			foreach (GExpDebitComparison item in _GExpDebitComparisons)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpDebitComparison vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpDebitComparison _GExpDebitComparison, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDebitComparison] SET Id=@Id, DebitComparisonCode=@DebitComparisonCode, DebitComparisonDate=@DebitComparisonDate, SuccessCount=@SuccessCount, ReturnCount=@ReturnCount, PendingCount=@PendingCount, FeeCost=@FeeCost, COD=@COD, ReturnCOD=@ReturnCOD, FK_Provider=@FK_Provider, FK_AccountRefer=@FK_AccountRefer, FK_Post=@FK_Post WHERE Id=@Id", 
					"@Id",  _GExpDebitComparison.Id, 
					"@DebitComparisonCode",  _GExpDebitComparison.DebitComparisonCode, 
					"@DebitComparisonDate", this._dataContext.ConvertDateString( _GExpDebitComparison.DebitComparisonDate), 
					"@SuccessCount",  _GExpDebitComparison.SuccessCount, 
					"@ReturnCount",  _GExpDebitComparison.ReturnCount, 
					"@PendingCount",  _GExpDebitComparison.PendingCount, 
					"@FeeCost",  _GExpDebitComparison.FeeCost, 
					"@COD",  _GExpDebitComparison.COD, 
					"@ReturnCOD",  _GExpDebitComparison.ReturnCOD, 
					"@FK_Provider",  _GExpDebitComparison.FK_Provider, 
					"@FK_AccountRefer",  _GExpDebitComparison.FK_AccountRefer, 
					"@FK_Post",  _GExpDebitComparison.FK_Post, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpDebitComparison vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpDebitComparison _GExpDebitComparison)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDebitComparison] SET DebitComparisonCode=@DebitComparisonCode, DebitComparisonDate=@DebitComparisonDate, SuccessCount=@SuccessCount, ReturnCount=@ReturnCount, PendingCount=@PendingCount, FeeCost=@FeeCost, COD=@COD, ReturnCOD=@ReturnCOD, FK_Provider=@FK_Provider, FK_AccountRefer=@FK_AccountRefer, FK_Post=@FK_Post WHERE Id=@Id", 
					"@DebitComparisonCode",  _GExpDebitComparison.DebitComparisonCode, 
					"@DebitComparisonDate", this._dataContext.ConvertDateString( _GExpDebitComparison.DebitComparisonDate), 
					"@SuccessCount",  _GExpDebitComparison.SuccessCount, 
					"@ReturnCount",  _GExpDebitComparison.ReturnCount, 
					"@PendingCount",  _GExpDebitComparison.PendingCount, 
					"@FeeCost",  _GExpDebitComparison.FeeCost, 
					"@COD",  _GExpDebitComparison.COD, 
					"@ReturnCOD",  _GExpDebitComparison.ReturnCOD, 
					"@FK_Provider",  _GExpDebitComparison.FK_Provider, 
					"@FK_AccountRefer",  _GExpDebitComparison.FK_AccountRefer, 
					"@FK_Post",  _GExpDebitComparison.FK_Post, 
					"@Id", _GExpDebitComparison.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpDebitComparison vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpDebitComparison> _GExpDebitComparisons)
		{
			foreach (GExpDebitComparison item in _GExpDebitComparisons)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpDebitComparison vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpDebitComparison _GExpDebitComparison, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpDebitComparison] SET Id=@Id, DebitComparisonCode=@DebitComparisonCode, DebitComparisonDate=@DebitComparisonDate, SuccessCount=@SuccessCount, ReturnCount=@ReturnCount, PendingCount=@PendingCount, FeeCost=@FeeCost, COD=@COD, ReturnCOD=@ReturnCOD, FK_Provider=@FK_Provider, FK_AccountRefer=@FK_AccountRefer, FK_Post=@FK_Post "+ condition, 
					"@Id",  _GExpDebitComparison.Id, 
					"@DebitComparisonCode",  _GExpDebitComparison.DebitComparisonCode, 
					"@DebitComparisonDate", this._dataContext.ConvertDateString( _GExpDebitComparison.DebitComparisonDate), 
					"@SuccessCount",  _GExpDebitComparison.SuccessCount, 
					"@ReturnCount",  _GExpDebitComparison.ReturnCount, 
					"@PendingCount",  _GExpDebitComparison.PendingCount, 
					"@FeeCost",  _GExpDebitComparison.FeeCost, 
					"@COD",  _GExpDebitComparison.COD, 
					"@ReturnCOD",  _GExpDebitComparison.ReturnCOD, 
					"@FK_Provider",  _GExpDebitComparison.FK_Provider, 
					"@FK_AccountRefer",  _GExpDebitComparison.FK_AccountRefer, 
					"@FK_Post",  _GExpDebitComparison.FK_Post);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpDebitComparison trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDebitComparison] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDebitComparison trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpDebitComparison _GExpDebitComparison)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDebitComparison] WHERE Id=@Id",
					"@Id", _GExpDebitComparison.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDebitComparison trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpDebitComparison] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpDebitComparison trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpDebitComparison> _GExpDebitComparisons)
		{
			foreach (GExpDebitComparison item in _GExpDebitComparisons)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
