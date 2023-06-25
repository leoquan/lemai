using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewgexpdebitcomparison:IVIewgexpdebitcomparison
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewgexpdebitcomparison(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_GExpDebitComparison từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpDebitComparison]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_GExpDebitComparison từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpDebitComparison] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_GExpDebitComparison từ Database
		/// </summary>
		public List<view_GExpDebitComparison> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpDebitComparison]");
				List<view_GExpDebitComparison> items = new List<view_GExpDebitComparison>();
				view_GExpDebitComparison item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GExpDebitComparison();
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
					if (dr["ProviderName"] != null && dr["ProviderName"] != DBNull.Value)
					{
						item.ProviderName = Convert.ToString(dr["ProviderName"]);
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
		/// Lấy danh sách view_GExpDebitComparison từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_GExpDebitComparison> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GExpDebitComparison] A "+ condition,  parameters);
				List<view_GExpDebitComparison> items = new List<view_GExpDebitComparison>();
				view_GExpDebitComparison item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GExpDebitComparison();
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
					if (dr["ProviderName"] != null && dr["ProviderName"] != DBNull.Value)
					{
						item.ProviderName = Convert.ToString(dr["ProviderName"]);
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

		public List<view_GExpDebitComparison> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GExpDebitComparison] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_GExpDebitComparison] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_GExpDebitComparison>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_GExpDebitComparison đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_GExpDebitComparison GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GExpDebitComparison] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_GExpDebitComparison item=new view_GExpDebitComparison();
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
						if (dr["ProviderName"] != null && dr["ProviderName"] != DBNull.Value)
						{
							item.ProviderName = Convert.ToString(dr["ProviderName"]);
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

		public view_GExpDebitComparison GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GExpDebitComparison] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_GExpDebitComparison>(ds);
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
	}
}
