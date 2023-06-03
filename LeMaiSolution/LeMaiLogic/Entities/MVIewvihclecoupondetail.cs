using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewvihclecoupondetail:IVIewvihclecoupondetail
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewvihclecoupondetail(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_VihcleCouponDetail từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_VihcleCouponDetail]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_VihcleCouponDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_VihcleCouponDetail] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_VihcleCouponDetail từ Database
		/// </summary>
		public List<view_VihcleCouponDetail> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_VihcleCouponDetail]");
				List<view_VihcleCouponDetail> items = new List<view_VihcleCouponDetail>();
				view_VihcleCouponDetail item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_VihcleCouponDetail();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
					{
						item.FK_Service = Convert.ToString(dr["FK_Service"]);
					}
					if (dr["FK_VihcleCoupon"] != null && dr["FK_VihcleCoupon"] != DBNull.Value)
					{
						item.FK_VihcleCoupon = Convert.ToString(dr["FK_VihcleCoupon"]);
					}
					if (dr["CurrentValue"] != null && dr["CurrentValue"] != DBNull.Value)
					{
						item.CurrentValue = Convert.ToInt32(dr["CurrentValue"]);
					}
					if (dr["ServiceDate"] != null && dr["ServiceDate"] != DBNull.Value)
					{
						item.ServiceDate = Convert.ToDateTime(dr["ServiceDate"]);
					}
					if (dr["ServiceName"] != null && dr["ServiceName"] != DBNull.Value)
					{
						item.ServiceName = Convert.ToString(dr["ServiceName"]);
					}
					if (dr["ValueCycle"] != null && dr["ValueCycle"] != DBNull.Value)
					{
						item.ValueCycle = Convert.ToDecimal(dr["ValueCycle"]);
					}
					if (dr["ConfigNote"] != null && dr["ConfigNote"] != DBNull.Value)
					{
						item.ConfigNote = Convert.ToString(dr["ConfigNote"]);
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
		/// Lấy danh sách view_VihcleCouponDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_VihcleCouponDetail> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_VihcleCouponDetail] A "+ condition,  parameters);
				List<view_VihcleCouponDetail> items = new List<view_VihcleCouponDetail>();
				view_VihcleCouponDetail item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_VihcleCouponDetail();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
					{
						item.FK_Service = Convert.ToString(dr["FK_Service"]);
					}
					if (dr["FK_VihcleCoupon"] != null && dr["FK_VihcleCoupon"] != DBNull.Value)
					{
						item.FK_VihcleCoupon = Convert.ToString(dr["FK_VihcleCoupon"]);
					}
					if (dr["CurrentValue"] != null && dr["CurrentValue"] != DBNull.Value)
					{
						item.CurrentValue = Convert.ToInt32(dr["CurrentValue"]);
					}
					if (dr["ServiceDate"] != null && dr["ServiceDate"] != DBNull.Value)
					{
						item.ServiceDate = Convert.ToDateTime(dr["ServiceDate"]);
					}
					if (dr["ServiceName"] != null && dr["ServiceName"] != DBNull.Value)
					{
						item.ServiceName = Convert.ToString(dr["ServiceName"]);
					}
					if (dr["ValueCycle"] != null && dr["ValueCycle"] != DBNull.Value)
					{
						item.ValueCycle = Convert.ToDecimal(dr["ValueCycle"]);
					}
					if (dr["ConfigNote"] != null && dr["ConfigNote"] != DBNull.Value)
					{
						item.ConfigNote = Convert.ToString(dr["ConfigNote"]);
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

		public List<view_VihcleCouponDetail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_VihcleCouponDetail] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_VihcleCouponDetail] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_VihcleCouponDetail>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_VihcleCouponDetail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_VihcleCouponDetail GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_VihcleCouponDetail] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_VihcleCouponDetail item=new view_VihcleCouponDetail();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["FK_Service"] != null && dr["FK_Service"] != DBNull.Value)
						{
							item.FK_Service = Convert.ToString(dr["FK_Service"]);
						}
						if (dr["FK_VihcleCoupon"] != null && dr["FK_VihcleCoupon"] != DBNull.Value)
						{
							item.FK_VihcleCoupon = Convert.ToString(dr["FK_VihcleCoupon"]);
						}
						if (dr["CurrentValue"] != null && dr["CurrentValue"] != DBNull.Value)
						{
							item.CurrentValue = Convert.ToInt32(dr["CurrentValue"]);
						}
						if (dr["ServiceDate"] != null && dr["ServiceDate"] != DBNull.Value)
						{
							item.ServiceDate = Convert.ToDateTime(dr["ServiceDate"]);
						}
						if (dr["ServiceName"] != null && dr["ServiceName"] != DBNull.Value)
						{
							item.ServiceName = Convert.ToString(dr["ServiceName"]);
						}
						if (dr["ValueCycle"] != null && dr["ValueCycle"] != DBNull.Value)
						{
							item.ValueCycle = Convert.ToDecimal(dr["ValueCycle"]);
						}
						if (dr["ConfigNote"] != null && dr["ConfigNote"] != DBNull.Value)
						{
							item.ConfigNote = Convert.ToString(dr["ConfigNote"]);
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

		public view_VihcleCouponDetail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_VihcleCouponDetail] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_VihcleCouponDetail>(ds);
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
