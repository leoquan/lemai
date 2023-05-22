using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewgexporder:IVIewgexporder
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewgexporder(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_GExpOrder từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpOrder]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_GExpOrder từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpOrder] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_GExpOrder từ Database
		/// </summary>
		public List<view_GExpOrder> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpOrder]");
				List<view_GExpOrder> items = new List<view_GExpOrder>();
				view_GExpOrder item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GExpOrder();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["OrderCode"] != null && dr["OrderCode"] != DBNull.Value)
					{
						item.OrderCode = Convert.ToString(dr["OrderCode"]);
					}
					if (dr["AcceptName"] != null && dr["AcceptName"] != DBNull.Value)
					{
						item.AcceptName = Convert.ToString(dr["AcceptName"]);
					}
					if (dr["AcceptPhone"] != null && dr["AcceptPhone"] != DBNull.Value)
					{
						item.AcceptPhone = Convert.ToString(dr["AcceptPhone"]);
					}
					if (dr["AcceptAddress"] != null && dr["AcceptAddress"] != DBNull.Value)
					{
						item.AcceptAddress = Convert.ToString(dr["AcceptAddress"]);
					}
					if (dr["GoodsName"] != null && dr["GoodsName"] != DBNull.Value)
					{
						item.GoodsName = Convert.ToString(dr["GoodsName"]);
					}
					if (dr["COD"] != null && dr["COD"] != DBNull.Value)
					{
						item.COD = Convert.ToDecimal(dr["COD"]);
					}
					if (dr["Weight"] != null && dr["Weight"] != DBNull.Value)
					{
						item.Weight = Convert.ToInt32(dr["Weight"]);
					}
					if (dr["IsShopPay"] != null && dr["IsShopPay"] != DBNull.Value)
					{
						item.IsShopPay = Convert.ToBoolean(dr["IsShopPay"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_CustomerId"] != null && dr["FK_CustomerId"] != DBNull.Value)
					{
						item.FK_CustomerId = Convert.ToString(dr["FK_CustomerId"]);
					}
					if (dr["StatusOrder"] != null && dr["StatusOrder"] != DBNull.Value)
					{
						item.StatusOrder = Convert.ToInt32(dr["StatusOrder"]);
					}
					if (dr["PickupUser"] != null && dr["PickupUser"] != DBNull.Value)
					{
						item.PickupUser = Convert.ToString(dr["PickupUser"]);
					}
					if (dr["PickupDate"] != null && dr["PickupDate"] != DBNull.Value)
					{
						item.PickupDate = Convert.ToDateTime(dr["PickupDate"]);
					}
					if (dr["TransferCode"] != null && dr["TransferCode"] != DBNull.Value)
					{
						item.TransferCode = Convert.ToString(dr["TransferCode"]);
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
					if (dr["CustomerCode"] != null && dr["CustomerCode"] != DBNull.Value)
					{
						item.CustomerCode = Convert.ToString(dr["CustomerCode"]);
					}
					if (dr["CustomerName"] != null && dr["CustomerName"] != DBNull.Value)
					{
						item.CustomerName = Convert.ToString(dr["CustomerName"]);
					}
					if (dr["CustomerPhone"] != null && dr["CustomerPhone"] != DBNull.Value)
					{
						item.CustomerPhone = Convert.ToString(dr["CustomerPhone"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["ProvinceCode"] != null && dr["ProvinceCode"] != DBNull.Value)
					{
						item.ProvinceCode = Convert.ToInt32(dr["ProvinceCode"]);
					}
					if (dr["DistrictCode"] != null && dr["DistrictCode"] != DBNull.Value)
					{
						item.DistrictCode = Convert.ToInt32(dr["DistrictCode"]);
					}
					if (dr["DistrictWard"] != null && dr["DistrictWard"] != DBNull.Value)
					{
						item.DistrictWard = Convert.ToString(dr["DistrictWard"]);
					}
					if (dr["Freight"] != null && dr["Freight"] != DBNull.Value)
					{
						item.Freight = Convert.ToInt32(dr["Freight"]);
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
		/// Lấy danh sách view_GExpOrder từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_GExpOrder> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GExpOrder] A "+ condition,  parameters);
				List<view_GExpOrder> items = new List<view_GExpOrder>();
				view_GExpOrder item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GExpOrder();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["OrderCode"] != null && dr["OrderCode"] != DBNull.Value)
					{
						item.OrderCode = Convert.ToString(dr["OrderCode"]);
					}
					if (dr["AcceptName"] != null && dr["AcceptName"] != DBNull.Value)
					{
						item.AcceptName = Convert.ToString(dr["AcceptName"]);
					}
					if (dr["AcceptPhone"] != null && dr["AcceptPhone"] != DBNull.Value)
					{
						item.AcceptPhone = Convert.ToString(dr["AcceptPhone"]);
					}
					if (dr["AcceptAddress"] != null && dr["AcceptAddress"] != DBNull.Value)
					{
						item.AcceptAddress = Convert.ToString(dr["AcceptAddress"]);
					}
					if (dr["GoodsName"] != null && dr["GoodsName"] != DBNull.Value)
					{
						item.GoodsName = Convert.ToString(dr["GoodsName"]);
					}
					if (dr["COD"] != null && dr["COD"] != DBNull.Value)
					{
						item.COD = Convert.ToDecimal(dr["COD"]);
					}
					if (dr["Weight"] != null && dr["Weight"] != DBNull.Value)
					{
						item.Weight = Convert.ToInt32(dr["Weight"]);
					}
					if (dr["IsShopPay"] != null && dr["IsShopPay"] != DBNull.Value)
					{
						item.IsShopPay = Convert.ToBoolean(dr["IsShopPay"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
					{
						item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
					}
					if (dr["FK_CustomerId"] != null && dr["FK_CustomerId"] != DBNull.Value)
					{
						item.FK_CustomerId = Convert.ToString(dr["FK_CustomerId"]);
					}
					if (dr["StatusOrder"] != null && dr["StatusOrder"] != DBNull.Value)
					{
						item.StatusOrder = Convert.ToInt32(dr["StatusOrder"]);
					}
					if (dr["PickupUser"] != null && dr["PickupUser"] != DBNull.Value)
					{
						item.PickupUser = Convert.ToString(dr["PickupUser"]);
					}
					if (dr["PickupDate"] != null && dr["PickupDate"] != DBNull.Value)
					{
						item.PickupDate = Convert.ToDateTime(dr["PickupDate"]);
					}
					if (dr["TransferCode"] != null && dr["TransferCode"] != DBNull.Value)
					{
						item.TransferCode = Convert.ToString(dr["TransferCode"]);
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
					if (dr["CustomerCode"] != null && dr["CustomerCode"] != DBNull.Value)
					{
						item.CustomerCode = Convert.ToString(dr["CustomerCode"]);
					}
					if (dr["CustomerName"] != null && dr["CustomerName"] != DBNull.Value)
					{
						item.CustomerName = Convert.ToString(dr["CustomerName"]);
					}
					if (dr["CustomerPhone"] != null && dr["CustomerPhone"] != DBNull.Value)
					{
						item.CustomerPhone = Convert.ToString(dr["CustomerPhone"]);
					}
					if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
					{
						item.FK_Post = Convert.ToString(dr["FK_Post"]);
					}
					if (dr["ProvinceCode"] != null && dr["ProvinceCode"] != DBNull.Value)
					{
						item.ProvinceCode = Convert.ToInt32(dr["ProvinceCode"]);
					}
					if (dr["DistrictCode"] != null && dr["DistrictCode"] != DBNull.Value)
					{
						item.DistrictCode = Convert.ToInt32(dr["DistrictCode"]);
					}
					if (dr["DistrictWard"] != null && dr["DistrictWard"] != DBNull.Value)
					{
						item.DistrictWard = Convert.ToString(dr["DistrictWard"]);
					}
					if (dr["Freight"] != null && dr["Freight"] != DBNull.Value)
					{
						item.Freight = Convert.ToInt32(dr["Freight"]);
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

		public List<view_GExpOrder> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GExpOrder] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_GExpOrder] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_GExpOrder>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_GExpOrder đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_GExpOrder GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GExpOrder] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_GExpOrder item=new view_GExpOrder();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["OrderCode"] != null && dr["OrderCode"] != DBNull.Value)
						{
							item.OrderCode = Convert.ToString(dr["OrderCode"]);
						}
						if (dr["AcceptName"] != null && dr["AcceptName"] != DBNull.Value)
						{
							item.AcceptName = Convert.ToString(dr["AcceptName"]);
						}
						if (dr["AcceptPhone"] != null && dr["AcceptPhone"] != DBNull.Value)
						{
							item.AcceptPhone = Convert.ToString(dr["AcceptPhone"]);
						}
						if (dr["AcceptAddress"] != null && dr["AcceptAddress"] != DBNull.Value)
						{
							item.AcceptAddress = Convert.ToString(dr["AcceptAddress"]);
						}
						if (dr["GoodsName"] != null && dr["GoodsName"] != DBNull.Value)
						{
							item.GoodsName = Convert.ToString(dr["GoodsName"]);
						}
						if (dr["COD"] != null && dr["COD"] != DBNull.Value)
						{
							item.COD = Convert.ToDecimal(dr["COD"]);
						}
						if (dr["Weight"] != null && dr["Weight"] != DBNull.Value)
						{
							item.Weight = Convert.ToInt32(dr["Weight"]);
						}
						if (dr["IsShopPay"] != null && dr["IsShopPay"] != DBNull.Value)
						{
							item.IsShopPay = Convert.ToBoolean(dr["IsShopPay"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["CreateDate"] != null && dr["CreateDate"] != DBNull.Value)
						{
							item.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
						}
						if (dr["FK_CustomerId"] != null && dr["FK_CustomerId"] != DBNull.Value)
						{
							item.FK_CustomerId = Convert.ToString(dr["FK_CustomerId"]);
						}
						if (dr["StatusOrder"] != null && dr["StatusOrder"] != DBNull.Value)
						{
							item.StatusOrder = Convert.ToInt32(dr["StatusOrder"]);
						}
						if (dr["PickupUser"] != null && dr["PickupUser"] != DBNull.Value)
						{
							item.PickupUser = Convert.ToString(dr["PickupUser"]);
						}
						if (dr["PickupDate"] != null && dr["PickupDate"] != DBNull.Value)
						{
							item.PickupDate = Convert.ToDateTime(dr["PickupDate"]);
						}
						if (dr["TransferCode"] != null && dr["TransferCode"] != DBNull.Value)
						{
							item.TransferCode = Convert.ToString(dr["TransferCode"]);
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
						if (dr["CustomerCode"] != null && dr["CustomerCode"] != DBNull.Value)
						{
							item.CustomerCode = Convert.ToString(dr["CustomerCode"]);
						}
						if (dr["CustomerName"] != null && dr["CustomerName"] != DBNull.Value)
						{
							item.CustomerName = Convert.ToString(dr["CustomerName"]);
						}
						if (dr["CustomerPhone"] != null && dr["CustomerPhone"] != DBNull.Value)
						{
							item.CustomerPhone = Convert.ToString(dr["CustomerPhone"]);
						}
						if (dr["FK_Post"] != null && dr["FK_Post"] != DBNull.Value)
						{
							item.FK_Post = Convert.ToString(dr["FK_Post"]);
						}
						if (dr["ProvinceCode"] != null && dr["ProvinceCode"] != DBNull.Value)
						{
							item.ProvinceCode = Convert.ToInt32(dr["ProvinceCode"]);
						}
						if (dr["DistrictCode"] != null && dr["DistrictCode"] != DBNull.Value)
						{
							item.DistrictCode = Convert.ToInt32(dr["DistrictCode"]);
						}
						if (dr["DistrictWard"] != null && dr["DistrictWard"] != DBNull.Value)
						{
							item.DistrictWard = Convert.ToString(dr["DistrictWard"]);
						}
						if (dr["Freight"] != null && dr["Freight"] != DBNull.Value)
						{
							item.Freight = Convert.ToInt32(dr["Freight"]);
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

		public view_GExpOrder GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GExpOrder] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_GExpOrder>(ds);
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
