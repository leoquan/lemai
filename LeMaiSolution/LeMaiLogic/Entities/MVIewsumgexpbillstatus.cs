using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewsumgexpbillstatus:IVIewsumgexpbillstatus
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewsumgexpbillstatus(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_SumGExpBillStatus từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_SumGExpBillStatus]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_SumGExpBillStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_SumGExpBillStatus] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_SumGExpBillStatus từ Database
		/// </summary>
		public List<view_SumGExpBillStatus> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_SumGExpBillStatus]");
				List<view_SumGExpBillStatus> items = new List<view_SumGExpBillStatus>();
				view_SumGExpBillStatus item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_SumGExpBillStatus();
					if (dr["COUNT_TT"] != null && dr["COUNT_TT"] != DBNull.Value)
					{
						item.COUNT_TT = Convert.ToInt32(dr["COUNT_TT"]);
					}
					if (dr["BillStatus"] != null && dr["BillStatus"] != DBNull.Value)
					{
						item.BillStatus = Convert.ToInt32(dr["BillStatus"]);
					}
					if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
					{
						item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
					}
					if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
					{
						item.StatusName = Convert.ToString(dr["StatusName"]);
					}
					if (dr["StatusTextColor"] != null && dr["StatusTextColor"] != DBNull.Value)
					{
						item.StatusTextColor = Convert.ToString(dr["StatusTextColor"]);
					}
					if (dr["StatusBackgroundColor"] != null && dr["StatusBackgroundColor"] != DBNull.Value)
					{
						item.StatusBackgroundColor = Convert.ToString(dr["StatusBackgroundColor"]);
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
		/// Lấy danh sách view_SumGExpBillStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_SumGExpBillStatus> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_SumGExpBillStatus] A "+ condition,  parameters);
				List<view_SumGExpBillStatus> items = new List<view_SumGExpBillStatus>();
				view_SumGExpBillStatus item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_SumGExpBillStatus();
					if (dr["COUNT_TT"] != null && dr["COUNT_TT"] != DBNull.Value)
					{
						item.COUNT_TT = Convert.ToInt32(dr["COUNT_TT"]);
					}
					if (dr["BillStatus"] != null && dr["BillStatus"] != DBNull.Value)
					{
						item.BillStatus = Convert.ToInt32(dr["BillStatus"]);
					}
					if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
					{
						item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
					}
					if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
					{
						item.StatusName = Convert.ToString(dr["StatusName"]);
					}
					if (dr["StatusTextColor"] != null && dr["StatusTextColor"] != DBNull.Value)
					{
						item.StatusTextColor = Convert.ToString(dr["StatusTextColor"]);
					}
					if (dr["StatusBackgroundColor"] != null && dr["StatusBackgroundColor"] != DBNull.Value)
					{
						item.StatusBackgroundColor = Convert.ToString(dr["StatusBackgroundColor"]);
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

		public List<view_SumGExpBillStatus> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_SumGExpBillStatus] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_SumGExpBillStatus] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_SumGExpBillStatus>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_SumGExpBillStatus đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_SumGExpBillStatus GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_SumGExpBillStatus] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_SumGExpBillStatus item=new view_SumGExpBillStatus();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["COUNT_TT"] != null && dr["COUNT_TT"] != DBNull.Value)
						{
							item.COUNT_TT = Convert.ToInt32(dr["COUNT_TT"]);
						}
						if (dr["BillStatus"] != null && dr["BillStatus"] != DBNull.Value)
						{
							item.BillStatus = Convert.ToInt32(dr["BillStatus"]);
						}
						if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
						{
							item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
						}
						if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
						{
							item.StatusName = Convert.ToString(dr["StatusName"]);
						}
						if (dr["StatusTextColor"] != null && dr["StatusTextColor"] != DBNull.Value)
						{
							item.StatusTextColor = Convert.ToString(dr["StatusTextColor"]);
						}
						if (dr["StatusBackgroundColor"] != null && dr["StatusBackgroundColor"] != DBNull.Value)
						{
							item.StatusBackgroundColor = Convert.ToString(dr["StatusBackgroundColor"]);
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

		public view_SumGExpBillStatus GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_SumGExpBillStatus] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_SumGExpBillStatus>(ds);
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
