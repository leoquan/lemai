using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewgexpdebitcomparisondetail:IVIewgexpdebitcomparisondetail
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewgexpdebitcomparisondetail(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_GExpDebitComparisonDetail từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpDebitComparisonDetail]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_GExpDebitComparisonDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpDebitComparisonDetail] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_GExpDebitComparisonDetail từ Database
		/// </summary>
		public List<view_GExpDebitComparisonDetail> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpDebitComparisonDetail]");
				List<view_GExpDebitComparisonDetail> items = new List<view_GExpDebitComparisonDetail>();
				view_GExpDebitComparisonDetail item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GExpDebitComparisonDetail();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_DebitComparison"] != null && dr["FK_DebitComparison"] != DBNull.Value)
					{
						item.FK_DebitComparison = Convert.ToString(dr["FK_DebitComparison"]);
					}
					if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
					{
						item.BT3Code = Convert.ToString(dr["BT3Code"]);
					}
					if (dr["AcceptMan"] != null && dr["AcceptMan"] != DBNull.Value)
					{
						item.AcceptMan = Convert.ToString(dr["AcceptMan"]);
					}
					if (dr["AcceptAddress"] != null && dr["AcceptAddress"] != DBNull.Value)
					{
						item.AcceptAddress = Convert.ToString(dr["AcceptAddress"]);
					}
					if (dr["AcceptManPhone"] != null && dr["AcceptManPhone"] != DBNull.Value)
					{
						item.AcceptManPhone = Convert.ToString(dr["AcceptManPhone"]);
					}
					if (dr["Status"] != null && dr["Status"] != DBNull.Value)
					{
						item.Status = Convert.ToInt32(dr["Status"]);
					}
					if (dr["COD"] != null && dr["COD"] != DBNull.Value)
					{
						item.COD = Convert.ToDecimal(dr["COD"]);
					}
					if (dr["Fee"] != null && dr["Fee"] != DBNull.Value)
					{
						item.Fee = Convert.ToDecimal(dr["Fee"]);
					}
					if (dr["IsPayCustomer"] != null && dr["IsPayCustomer"] != DBNull.Value)
					{
						item.IsPayCustomer = Convert.ToBoolean(dr["IsPayCustomer"]);
					}
					if (dr["PayDate"] != null && dr["PayDate"] != DBNull.Value)
					{
						item.PayDate = Convert.ToDateTime(dr["PayDate"]);
					}
					if (dr["FK_KyDoiSoat"] != null && dr["FK_KyDoiSoat"] != DBNull.Value)
					{
						item.FK_KyDoiSoat = Convert.ToString(dr["FK_KyDoiSoat"]);
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
		/// Lấy danh sách view_GExpDebitComparisonDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_GExpDebitComparisonDetail> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GExpDebitComparisonDetail] A "+ condition,  parameters);
				List<view_GExpDebitComparisonDetail> items = new List<view_GExpDebitComparisonDetail>();
				view_GExpDebitComparisonDetail item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GExpDebitComparisonDetail();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_DebitComparison"] != null && dr["FK_DebitComparison"] != DBNull.Value)
					{
						item.FK_DebitComparison = Convert.ToString(dr["FK_DebitComparison"]);
					}
					if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
					{
						item.BT3Code = Convert.ToString(dr["BT3Code"]);
					}
					if (dr["AcceptMan"] != null && dr["AcceptMan"] != DBNull.Value)
					{
						item.AcceptMan = Convert.ToString(dr["AcceptMan"]);
					}
					if (dr["AcceptAddress"] != null && dr["AcceptAddress"] != DBNull.Value)
					{
						item.AcceptAddress = Convert.ToString(dr["AcceptAddress"]);
					}
					if (dr["AcceptManPhone"] != null && dr["AcceptManPhone"] != DBNull.Value)
					{
						item.AcceptManPhone = Convert.ToString(dr["AcceptManPhone"]);
					}
					if (dr["Status"] != null && dr["Status"] != DBNull.Value)
					{
						item.Status = Convert.ToInt32(dr["Status"]);
					}
					if (dr["COD"] != null && dr["COD"] != DBNull.Value)
					{
						item.COD = Convert.ToDecimal(dr["COD"]);
					}
					if (dr["Fee"] != null && dr["Fee"] != DBNull.Value)
					{
						item.Fee = Convert.ToDecimal(dr["Fee"]);
					}
					if (dr["IsPayCustomer"] != null && dr["IsPayCustomer"] != DBNull.Value)
					{
						item.IsPayCustomer = Convert.ToBoolean(dr["IsPayCustomer"]);
					}
					if (dr["PayDate"] != null && dr["PayDate"] != DBNull.Value)
					{
						item.PayDate = Convert.ToDateTime(dr["PayDate"]);
					}
					if (dr["FK_KyDoiSoat"] != null && dr["FK_KyDoiSoat"] != DBNull.Value)
					{
						item.FK_KyDoiSoat = Convert.ToString(dr["FK_KyDoiSoat"]);
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

		public List<view_GExpDebitComparisonDetail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GExpDebitComparisonDetail] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_GExpDebitComparisonDetail] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_GExpDebitComparisonDetail>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_GExpDebitComparisonDetail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_GExpDebitComparisonDetail GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GExpDebitComparisonDetail] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_GExpDebitComparisonDetail item=new view_GExpDebitComparisonDetail();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_DebitComparison"] != null && dr["FK_DebitComparison"] != DBNull.Value)
						{
							item.FK_DebitComparison = Convert.ToString(dr["FK_DebitComparison"]);
						}
						if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
						{
							item.BT3Code = Convert.ToString(dr["BT3Code"]);
						}
						if (dr["AcceptMan"] != null && dr["AcceptMan"] != DBNull.Value)
						{
							item.AcceptMan = Convert.ToString(dr["AcceptMan"]);
						}
						if (dr["AcceptAddress"] != null && dr["AcceptAddress"] != DBNull.Value)
						{
							item.AcceptAddress = Convert.ToString(dr["AcceptAddress"]);
						}
						if (dr["AcceptManPhone"] != null && dr["AcceptManPhone"] != DBNull.Value)
						{
							item.AcceptManPhone = Convert.ToString(dr["AcceptManPhone"]);
						}
						if (dr["Status"] != null && dr["Status"] != DBNull.Value)
						{
							item.Status = Convert.ToInt32(dr["Status"]);
						}
						if (dr["COD"] != null && dr["COD"] != DBNull.Value)
						{
							item.COD = Convert.ToDecimal(dr["COD"]);
						}
						if (dr["Fee"] != null && dr["Fee"] != DBNull.Value)
						{
							item.Fee = Convert.ToDecimal(dr["Fee"]);
						}
						if (dr["IsPayCustomer"] != null && dr["IsPayCustomer"] != DBNull.Value)
						{
							item.IsPayCustomer = Convert.ToBoolean(dr["IsPayCustomer"]);
						}
						if (dr["PayDate"] != null && dr["PayDate"] != DBNull.Value)
						{
							item.PayDate = Convert.ToDateTime(dr["PayDate"]);
						}
						if (dr["FK_KyDoiSoat"] != null && dr["FK_KyDoiSoat"] != DBNull.Value)
						{
							item.FK_KyDoiSoat = Convert.ToString(dr["FK_KyDoiSoat"]);
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

		public view_GExpDebitComparisonDetail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GExpDebitComparisonDetail] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_GExpDebitComparisonDetail>(ds);
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
