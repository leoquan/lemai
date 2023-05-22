using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpbill:IGExpbill
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpbill(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpBill từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBill]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpBill từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBill] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpBill từ Database
		/// </summary>
		public List<GExpBill> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBill]");
				List<GExpBill> items = new List<GExpBill>();
				GExpBill item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpBill();
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["BillWeight"] != null && dr["BillWeight"] != DBNull.Value)
					{
						item.BillWeight = Convert.ToDecimal(dr["BillWeight"]);
					}
					if (dr["FeeWeight"] != null && dr["FeeWeight"] != DBNull.Value)
					{
						item.FeeWeight = Convert.ToDecimal(dr["FeeWeight"]);
					}
					if (dr["RegisterUser"] != null && dr["RegisterUser"] != DBNull.Value)
					{
						item.RegisterUser = Convert.ToString(dr["RegisterUser"]);
					}
					if (dr["RegisterSiteCode"] != null && dr["RegisterSiteCode"] != DBNull.Value)
					{
						item.RegisterSiteCode = Convert.ToString(dr["RegisterSiteCode"]);
					}
					if (dr["Freight"] != null && dr["Freight"] != DBNull.Value)
					{
						item.Freight = Convert.ToDecimal(dr["Freight"]);
					}
					if (dr["PayType"] != null && dr["PayType"] != DBNull.Value)
					{
						item.PayType = Convert.ToString(dr["PayType"]);
					}
					if (dr["COD"] != null && dr["COD"] != DBNull.Value)
					{
						item.COD = Convert.ToDecimal(dr["COD"]);
					}
					if (dr["SendMan"] != null && dr["SendMan"] != DBNull.Value)
					{
						item.SendMan = Convert.ToString(dr["SendMan"]);
					}
					if (dr["SendManUs"] != null && dr["SendManUs"] != DBNull.Value)
					{
						item.SendManUs = Convert.ToString(dr["SendManUs"]);
					}
					if (dr["SendManPhone"] != null && dr["SendManPhone"] != DBNull.Value)
					{
						item.SendManPhone = Convert.ToString(dr["SendManPhone"]);
					}
					if (dr["SendManAddress"] != null && dr["SendManAddress"] != DBNull.Value)
					{
						item.SendManAddress = Convert.ToString(dr["SendManAddress"]);
					}
					if (dr["AcceptProvinceCode"] != null && dr["AcceptProvinceCode"] != DBNull.Value)
					{
						item.AcceptProvinceCode = Convert.ToInt32(dr["AcceptProvinceCode"]);
					}
					if (dr["AcceptDistrictCode"] != null && dr["AcceptDistrictCode"] != DBNull.Value)
					{
						item.AcceptDistrictCode = Convert.ToInt32(dr["AcceptDistrictCode"]);
					}
					if (dr["AcceptWardCode"] != null && dr["AcceptWardCode"] != DBNull.Value)
					{
						item.AcceptWardCode = Convert.ToString(dr["AcceptWardCode"]);
					}
					if (dr["AcceptMan"] != null && dr["AcceptMan"] != DBNull.Value)
					{
						item.AcceptMan = Convert.ToString(dr["AcceptMan"]);
					}
					if (dr["AcceptManUs"] != null && dr["AcceptManUs"] != DBNull.Value)
					{
						item.AcceptManUs = Convert.ToString(dr["AcceptManUs"]);
					}
					if (dr["AcceptManPhone"] != null && dr["AcceptManPhone"] != DBNull.Value)
					{
						item.AcceptManPhone = Convert.ToString(dr["AcceptManPhone"]);
					}
					if (dr["AcceptManAddress"] != null && dr["AcceptManAddress"] != DBNull.Value)
					{
						item.AcceptManAddress = Convert.ToString(dr["AcceptManAddress"]);
					}
					if (dr["AcceptProvince"] != null && dr["AcceptProvince"] != DBNull.Value)
					{
						item.AcceptProvince = Convert.ToString(dr["AcceptProvince"]);
					}
					if (dr["AcceptDistrict"] != null && dr["AcceptDistrict"] != DBNull.Value)
					{
						item.AcceptDistrict = Convert.ToString(dr["AcceptDistrict"]);
					}
					if (dr["AcceptWard"] != null && dr["AcceptWard"] != DBNull.Value)
					{
						item.AcceptWard = Convert.ToString(dr["AcceptWard"]);
					}
					if (dr["IsSigned"] != null && dr["IsSigned"] != DBNull.Value)
					{
						item.IsSigned = Convert.ToBoolean(dr["IsSigned"]);
					}
					if (dr["IsReturn"] != null && dr["IsReturn"] != DBNull.Value)
					{
						item.IsReturn = Convert.ToBoolean(dr["IsReturn"]);
					}
					if (dr["BillProcessStatus"] != null && dr["BillProcessStatus"] != DBNull.Value)
					{
						item.BillProcessStatus = Convert.ToInt32(dr["BillProcessStatus"]);
					}
					if (dr["RegisterDate"] != null && dr["RegisterDate"] != DBNull.Value)
					{
						item.RegisterDate = Convert.ToDateTime(dr["RegisterDate"]);
					}
					if (dr["SignedDate"] != null && dr["SignedDate"] != DBNull.Value)
					{
						item.SignedDate = Convert.ToDateTime(dr["SignedDate"]);
					}
					if (dr["LastUpdateDate"] != null && dr["LastUpdateDate"] != DBNull.Value)
					{
						item.LastUpdateDate = Convert.ToDateTime(dr["LastUpdateDate"]);
					}
					if (dr["LastUpdateUser"] != null && dr["LastUpdateUser"] != DBNull.Value)
					{
						item.LastUpdateUser = Convert.ToString(dr["LastUpdateUser"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["SystemDate"] != null && dr["SystemDate"] != DBNull.Value)
					{
						item.SystemDate = Convert.ToDateTime(dr["SystemDate"]);
					}
					if (dr["BT3Type"] != null && dr["BT3Type"] != DBNull.Value)
					{
						item.BT3Type = Convert.ToString(dr["BT3Type"]);
					}
					if (dr["BT3CodeSub"] != null && dr["BT3CodeSub"] != DBNull.Value)
					{
						item.BT3CodeSub = Convert.ToString(dr["BT3CodeSub"]);
					}
					if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
					{
						item.BT3Code = Convert.ToString(dr["BT3Code"]);
					}
					if (dr["BT3Status"] != null && dr["BT3Status"] != DBNull.Value)
					{
						item.BT3Status = Convert.ToString(dr["BT3Status"]);
					}
					if (dr["BT3Freight"] != null && dr["BT3Freight"] != DBNull.Value)
					{
						item.BT3Freight = Convert.ToDecimal(dr["BT3Freight"]);
					}
					if (dr["BT3COD"] != null && dr["BT3COD"] != DBNull.Value)
					{
						item.BT3COD = Convert.ToDecimal(dr["BT3COD"]);
					}
					if (dr["BT3PayType"] != null && dr["BT3PayType"] != DBNull.Value)
					{
						item.BT3PayType = Convert.ToString(dr["BT3PayType"]);
					}
					if (dr["BT3LastMess"] != null && dr["BT3LastMess"] != DBNull.Value)
					{
						item.BT3LastMess = Convert.ToString(dr["BT3LastMess"]);
					}
					if (dr["GoodsName"] != null && dr["GoodsName"] != DBNull.Value)
					{
						item.GoodsName = Convert.ToString(dr["GoodsName"]);
					}
					if (dr["GoodsNumber"] != null && dr["GoodsNumber"] != DBNull.Value)
					{
						item.GoodsNumber = Convert.ToInt32(dr["GoodsNumber"]);
					}
					if (dr["GoodsCode"] != null && dr["GoodsCode"] != DBNull.Value)
					{
						item.GoodsCode = Convert.ToString(dr["GoodsCode"]);
					}
					if (dr["GoodsW"] != null && dr["GoodsW"] != DBNull.Value)
					{
						item.GoodsW = Convert.ToInt32(dr["GoodsW"]);
					}
					if (dr["GoodsH"] != null && dr["GoodsH"] != DBNull.Value)
					{
						item.GoodsH = Convert.ToInt32(dr["GoodsH"]);
					}
					if (dr["GoodsL"] != null && dr["GoodsL"] != DBNull.Value)
					{
						item.GoodsL = Convert.ToInt32(dr["GoodsL"]);
					}
					if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
					{
						item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
					}
					if (dr["FK_ProviderAccount"] != null && dr["FK_ProviderAccount"] != DBNull.Value)
					{
						item.FK_ProviderAccount = Convert.ToString(dr["FK_ProviderAccount"]);
					}
					if (dr["PayCustomerDate"] != null && dr["PayCustomerDate"] != DBNull.Value)
					{
						item.PayCustomerDate = Convert.ToDateTime(dr["PayCustomerDate"]);
					}
					if (dr["IsPayCustomer"] != null && dr["IsPayCustomer"] != DBNull.Value)
					{
						item.IsPayCustomer = Convert.ToBoolean(dr["IsPayCustomer"]);
					}
					if (dr["ShipperPhoneNumber"] != null && dr["ShipperPhoneNumber"] != DBNull.Value)
					{
						item.ShipperPhoneNumber = Convert.ToString(dr["ShipperPhoneNumber"]);
					}
					if (dr["BillStatus"] != null && dr["BillStatus"] != DBNull.Value)
					{
						item.BillStatus = Convert.ToInt32(dr["BillStatus"]);
					}
					if (dr["FK_PaymentType"] != null && dr["FK_PaymentType"] != DBNull.Value)
					{
						item.FK_PaymentType = Convert.ToString(dr["FK_PaymentType"]);
					}
					if (dr["FK_ShipType"] != null && dr["FK_ShipType"] != DBNull.Value)
					{
						item.FK_ShipType = Convert.ToString(dr["FK_ShipType"]);
					}
					if (dr["Pickup"] != null && dr["Pickup"] != DBNull.Value)
					{
						item.Pickup = Convert.ToBoolean(dr["Pickup"]);
					}
					if (dr["AddressPickup"] != null && dr["AddressPickup"] != DBNull.Value)
					{
						item.AddressPickup = Convert.ToString(dr["AddressPickup"]);
					}
					if (dr["ProvincePickup"] != null && dr["ProvincePickup"] != DBNull.Value)
					{
						item.ProvincePickup = Convert.ToString(dr["ProvincePickup"]);
					}
					if (dr["DistricPickup"] != null && dr["DistricPickup"] != DBNull.Value)
					{
						item.DistricPickup = Convert.ToString(dr["DistricPickup"]);
					}
					if (dr["WardPickup"] != null && dr["WardPickup"] != DBNull.Value)
					{
						item.WardPickup = Convert.ToString(dr["WardPickup"]);
					}
					if (dr["ShopIdPickup"] != null && dr["ShopIdPickup"] != DBNull.Value)
					{
						item.ShopIdPickup = Convert.ToString(dr["ShopIdPickup"]);
					}
					if (dr["SiteCode"] != null && dr["SiteCode"] != DBNull.Value)
					{
						item.SiteCode = Convert.ToString(dr["SiteCode"]);
					}
					if (dr["IsReceiveBill"] != null && dr["IsReceiveBill"] != DBNull.Value)
					{
						item.IsReceiveBill = Convert.ToBoolean(dr["IsReceiveBill"]);
					}
					if (dr["PrintData"] != null && dr["PrintData"] != DBNull.Value)
					{
						item.PrintData = Convert.ToString(dr["PrintData"]);
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
		/// Lấy danh sách GExpBill từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpBill> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpBill] A "+ condition,  parameters);
				List<GExpBill> items = new List<GExpBill>();
				GExpBill item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpBill();
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["BillWeight"] != null && dr["BillWeight"] != DBNull.Value)
					{
						item.BillWeight = Convert.ToDecimal(dr["BillWeight"]);
					}
					if (dr["FeeWeight"] != null && dr["FeeWeight"] != DBNull.Value)
					{
						item.FeeWeight = Convert.ToDecimal(dr["FeeWeight"]);
					}
					if (dr["RegisterUser"] != null && dr["RegisterUser"] != DBNull.Value)
					{
						item.RegisterUser = Convert.ToString(dr["RegisterUser"]);
					}
					if (dr["RegisterSiteCode"] != null && dr["RegisterSiteCode"] != DBNull.Value)
					{
						item.RegisterSiteCode = Convert.ToString(dr["RegisterSiteCode"]);
					}
					if (dr["Freight"] != null && dr["Freight"] != DBNull.Value)
					{
						item.Freight = Convert.ToDecimal(dr["Freight"]);
					}
					if (dr["PayType"] != null && dr["PayType"] != DBNull.Value)
					{
						item.PayType = Convert.ToString(dr["PayType"]);
					}
					if (dr["COD"] != null && dr["COD"] != DBNull.Value)
					{
						item.COD = Convert.ToDecimal(dr["COD"]);
					}
					if (dr["SendMan"] != null && dr["SendMan"] != DBNull.Value)
					{
						item.SendMan = Convert.ToString(dr["SendMan"]);
					}
					if (dr["SendManUs"] != null && dr["SendManUs"] != DBNull.Value)
					{
						item.SendManUs = Convert.ToString(dr["SendManUs"]);
					}
					if (dr["SendManPhone"] != null && dr["SendManPhone"] != DBNull.Value)
					{
						item.SendManPhone = Convert.ToString(dr["SendManPhone"]);
					}
					if (dr["SendManAddress"] != null && dr["SendManAddress"] != DBNull.Value)
					{
						item.SendManAddress = Convert.ToString(dr["SendManAddress"]);
					}
					if (dr["AcceptProvinceCode"] != null && dr["AcceptProvinceCode"] != DBNull.Value)
					{
						item.AcceptProvinceCode = Convert.ToInt32(dr["AcceptProvinceCode"]);
					}
					if (dr["AcceptDistrictCode"] != null && dr["AcceptDistrictCode"] != DBNull.Value)
					{
						item.AcceptDistrictCode = Convert.ToInt32(dr["AcceptDistrictCode"]);
					}
					if (dr["AcceptWardCode"] != null && dr["AcceptWardCode"] != DBNull.Value)
					{
						item.AcceptWardCode = Convert.ToString(dr["AcceptWardCode"]);
					}
					if (dr["AcceptMan"] != null && dr["AcceptMan"] != DBNull.Value)
					{
						item.AcceptMan = Convert.ToString(dr["AcceptMan"]);
					}
					if (dr["AcceptManUs"] != null && dr["AcceptManUs"] != DBNull.Value)
					{
						item.AcceptManUs = Convert.ToString(dr["AcceptManUs"]);
					}
					if (dr["AcceptManPhone"] != null && dr["AcceptManPhone"] != DBNull.Value)
					{
						item.AcceptManPhone = Convert.ToString(dr["AcceptManPhone"]);
					}
					if (dr["AcceptManAddress"] != null && dr["AcceptManAddress"] != DBNull.Value)
					{
						item.AcceptManAddress = Convert.ToString(dr["AcceptManAddress"]);
					}
					if (dr["AcceptProvince"] != null && dr["AcceptProvince"] != DBNull.Value)
					{
						item.AcceptProvince = Convert.ToString(dr["AcceptProvince"]);
					}
					if (dr["AcceptDistrict"] != null && dr["AcceptDistrict"] != DBNull.Value)
					{
						item.AcceptDistrict = Convert.ToString(dr["AcceptDistrict"]);
					}
					if (dr["AcceptWard"] != null && dr["AcceptWard"] != DBNull.Value)
					{
						item.AcceptWard = Convert.ToString(dr["AcceptWard"]);
					}
					if (dr["IsSigned"] != null && dr["IsSigned"] != DBNull.Value)
					{
						item.IsSigned = Convert.ToBoolean(dr["IsSigned"]);
					}
					if (dr["IsReturn"] != null && dr["IsReturn"] != DBNull.Value)
					{
						item.IsReturn = Convert.ToBoolean(dr["IsReturn"]);
					}
					if (dr["BillProcessStatus"] != null && dr["BillProcessStatus"] != DBNull.Value)
					{
						item.BillProcessStatus = Convert.ToInt32(dr["BillProcessStatus"]);
					}
					if (dr["RegisterDate"] != null && dr["RegisterDate"] != DBNull.Value)
					{
						item.RegisterDate = Convert.ToDateTime(dr["RegisterDate"]);
					}
					if (dr["SignedDate"] != null && dr["SignedDate"] != DBNull.Value)
					{
						item.SignedDate = Convert.ToDateTime(dr["SignedDate"]);
					}
					if (dr["LastUpdateDate"] != null && dr["LastUpdateDate"] != DBNull.Value)
					{
						item.LastUpdateDate = Convert.ToDateTime(dr["LastUpdateDate"]);
					}
					if (dr["LastUpdateUser"] != null && dr["LastUpdateUser"] != DBNull.Value)
					{
						item.LastUpdateUser = Convert.ToString(dr["LastUpdateUser"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["SystemDate"] != null && dr["SystemDate"] != DBNull.Value)
					{
						item.SystemDate = Convert.ToDateTime(dr["SystemDate"]);
					}
					if (dr["BT3Type"] != null && dr["BT3Type"] != DBNull.Value)
					{
						item.BT3Type = Convert.ToString(dr["BT3Type"]);
					}
					if (dr["BT3CodeSub"] != null && dr["BT3CodeSub"] != DBNull.Value)
					{
						item.BT3CodeSub = Convert.ToString(dr["BT3CodeSub"]);
					}
					if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
					{
						item.BT3Code = Convert.ToString(dr["BT3Code"]);
					}
					if (dr["BT3Status"] != null && dr["BT3Status"] != DBNull.Value)
					{
						item.BT3Status = Convert.ToString(dr["BT3Status"]);
					}
					if (dr["BT3Freight"] != null && dr["BT3Freight"] != DBNull.Value)
					{
						item.BT3Freight = Convert.ToDecimal(dr["BT3Freight"]);
					}
					if (dr["BT3COD"] != null && dr["BT3COD"] != DBNull.Value)
					{
						item.BT3COD = Convert.ToDecimal(dr["BT3COD"]);
					}
					if (dr["BT3PayType"] != null && dr["BT3PayType"] != DBNull.Value)
					{
						item.BT3PayType = Convert.ToString(dr["BT3PayType"]);
					}
					if (dr["BT3LastMess"] != null && dr["BT3LastMess"] != DBNull.Value)
					{
						item.BT3LastMess = Convert.ToString(dr["BT3LastMess"]);
					}
					if (dr["GoodsName"] != null && dr["GoodsName"] != DBNull.Value)
					{
						item.GoodsName = Convert.ToString(dr["GoodsName"]);
					}
					if (dr["GoodsNumber"] != null && dr["GoodsNumber"] != DBNull.Value)
					{
						item.GoodsNumber = Convert.ToInt32(dr["GoodsNumber"]);
					}
					if (dr["GoodsCode"] != null && dr["GoodsCode"] != DBNull.Value)
					{
						item.GoodsCode = Convert.ToString(dr["GoodsCode"]);
					}
					if (dr["GoodsW"] != null && dr["GoodsW"] != DBNull.Value)
					{
						item.GoodsW = Convert.ToInt32(dr["GoodsW"]);
					}
					if (dr["GoodsH"] != null && dr["GoodsH"] != DBNull.Value)
					{
						item.GoodsH = Convert.ToInt32(dr["GoodsH"]);
					}
					if (dr["GoodsL"] != null && dr["GoodsL"] != DBNull.Value)
					{
						item.GoodsL = Convert.ToInt32(dr["GoodsL"]);
					}
					if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
					{
						item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
					}
					if (dr["FK_ProviderAccount"] != null && dr["FK_ProviderAccount"] != DBNull.Value)
					{
						item.FK_ProviderAccount = Convert.ToString(dr["FK_ProviderAccount"]);
					}
					if (dr["PayCustomerDate"] != null && dr["PayCustomerDate"] != DBNull.Value)
					{
						item.PayCustomerDate = Convert.ToDateTime(dr["PayCustomerDate"]);
					}
					if (dr["IsPayCustomer"] != null && dr["IsPayCustomer"] != DBNull.Value)
					{
						item.IsPayCustomer = Convert.ToBoolean(dr["IsPayCustomer"]);
					}
					if (dr["ShipperPhoneNumber"] != null && dr["ShipperPhoneNumber"] != DBNull.Value)
					{
						item.ShipperPhoneNumber = Convert.ToString(dr["ShipperPhoneNumber"]);
					}
					if (dr["BillStatus"] != null && dr["BillStatus"] != DBNull.Value)
					{
						item.BillStatus = Convert.ToInt32(dr["BillStatus"]);
					}
					if (dr["FK_PaymentType"] != null && dr["FK_PaymentType"] != DBNull.Value)
					{
						item.FK_PaymentType = Convert.ToString(dr["FK_PaymentType"]);
					}
					if (dr["FK_ShipType"] != null && dr["FK_ShipType"] != DBNull.Value)
					{
						item.FK_ShipType = Convert.ToString(dr["FK_ShipType"]);
					}
					if (dr["Pickup"] != null && dr["Pickup"] != DBNull.Value)
					{
						item.Pickup = Convert.ToBoolean(dr["Pickup"]);
					}
					if (dr["AddressPickup"] != null && dr["AddressPickup"] != DBNull.Value)
					{
						item.AddressPickup = Convert.ToString(dr["AddressPickup"]);
					}
					if (dr["ProvincePickup"] != null && dr["ProvincePickup"] != DBNull.Value)
					{
						item.ProvincePickup = Convert.ToString(dr["ProvincePickup"]);
					}
					if (dr["DistricPickup"] != null && dr["DistricPickup"] != DBNull.Value)
					{
						item.DistricPickup = Convert.ToString(dr["DistricPickup"]);
					}
					if (dr["WardPickup"] != null && dr["WardPickup"] != DBNull.Value)
					{
						item.WardPickup = Convert.ToString(dr["WardPickup"]);
					}
					if (dr["ShopIdPickup"] != null && dr["ShopIdPickup"] != DBNull.Value)
					{
						item.ShopIdPickup = Convert.ToString(dr["ShopIdPickup"]);
					}
					if (dr["SiteCode"] != null && dr["SiteCode"] != DBNull.Value)
					{
						item.SiteCode = Convert.ToString(dr["SiteCode"]);
					}
					if (dr["IsReceiveBill"] != null && dr["IsReceiveBill"] != DBNull.Value)
					{
						item.IsReceiveBill = Convert.ToBoolean(dr["IsReceiveBill"]);
					}
					if (dr["PrintData"] != null && dr["PrintData"] != DBNull.Value)
					{
						item.PrintData = Convert.ToString(dr["PrintData"]);
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

		public List<GExpBill> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpBill] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpBill] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpBill>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpBill từ Database
		/// </summary>
		public GExpBill GetObject(string schema, String BillCode)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpBill] where BillCode=@BillCode",
					"@BillCode", BillCode);
				if (ds.Rows.Count > 0)
				{
					GExpBill item=new GExpBill();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["BillWeight"] != null && dr["BillWeight"] != DBNull.Value)
						{
							item.BillWeight = Convert.ToDecimal(dr["BillWeight"]);
						}
						if (dr["FeeWeight"] != null && dr["FeeWeight"] != DBNull.Value)
						{
							item.FeeWeight = Convert.ToDecimal(dr["FeeWeight"]);
						}
						if (dr["RegisterUser"] != null && dr["RegisterUser"] != DBNull.Value)
						{
							item.RegisterUser = Convert.ToString(dr["RegisterUser"]);
						}
						if (dr["RegisterSiteCode"] != null && dr["RegisterSiteCode"] != DBNull.Value)
						{
							item.RegisterSiteCode = Convert.ToString(dr["RegisterSiteCode"]);
						}
						if (dr["Freight"] != null && dr["Freight"] != DBNull.Value)
						{
							item.Freight = Convert.ToDecimal(dr["Freight"]);
						}
						if (dr["PayType"] != null && dr["PayType"] != DBNull.Value)
						{
							item.PayType = Convert.ToString(dr["PayType"]);
						}
						if (dr["COD"] != null && dr["COD"] != DBNull.Value)
						{
							item.COD = Convert.ToDecimal(dr["COD"]);
						}
						if (dr["SendMan"] != null && dr["SendMan"] != DBNull.Value)
						{
							item.SendMan = Convert.ToString(dr["SendMan"]);
						}
						if (dr["SendManUs"] != null && dr["SendManUs"] != DBNull.Value)
						{
							item.SendManUs = Convert.ToString(dr["SendManUs"]);
						}
						if (dr["SendManPhone"] != null && dr["SendManPhone"] != DBNull.Value)
						{
							item.SendManPhone = Convert.ToString(dr["SendManPhone"]);
						}
						if (dr["SendManAddress"] != null && dr["SendManAddress"] != DBNull.Value)
						{
							item.SendManAddress = Convert.ToString(dr["SendManAddress"]);
						}
						if (dr["AcceptProvinceCode"] != null && dr["AcceptProvinceCode"] != DBNull.Value)
						{
							item.AcceptProvinceCode = Convert.ToInt32(dr["AcceptProvinceCode"]);
						}
						if (dr["AcceptDistrictCode"] != null && dr["AcceptDistrictCode"] != DBNull.Value)
						{
							item.AcceptDistrictCode = Convert.ToInt32(dr["AcceptDistrictCode"]);
						}
						if (dr["AcceptWardCode"] != null && dr["AcceptWardCode"] != DBNull.Value)
						{
							item.AcceptWardCode = Convert.ToString(dr["AcceptWardCode"]);
						}
						if (dr["AcceptMan"] != null && dr["AcceptMan"] != DBNull.Value)
						{
							item.AcceptMan = Convert.ToString(dr["AcceptMan"]);
						}
						if (dr["AcceptManUs"] != null && dr["AcceptManUs"] != DBNull.Value)
						{
							item.AcceptManUs = Convert.ToString(dr["AcceptManUs"]);
						}
						if (dr["AcceptManPhone"] != null && dr["AcceptManPhone"] != DBNull.Value)
						{
							item.AcceptManPhone = Convert.ToString(dr["AcceptManPhone"]);
						}
						if (dr["AcceptManAddress"] != null && dr["AcceptManAddress"] != DBNull.Value)
						{
							item.AcceptManAddress = Convert.ToString(dr["AcceptManAddress"]);
						}
						if (dr["AcceptProvince"] != null && dr["AcceptProvince"] != DBNull.Value)
						{
							item.AcceptProvince = Convert.ToString(dr["AcceptProvince"]);
						}
						if (dr["AcceptDistrict"] != null && dr["AcceptDistrict"] != DBNull.Value)
						{
							item.AcceptDistrict = Convert.ToString(dr["AcceptDistrict"]);
						}
						if (dr["AcceptWard"] != null && dr["AcceptWard"] != DBNull.Value)
						{
							item.AcceptWard = Convert.ToString(dr["AcceptWard"]);
						}
						if (dr["IsSigned"] != null && dr["IsSigned"] != DBNull.Value)
						{
							item.IsSigned = Convert.ToBoolean(dr["IsSigned"]);
						}
						if (dr["IsReturn"] != null && dr["IsReturn"] != DBNull.Value)
						{
							item.IsReturn = Convert.ToBoolean(dr["IsReturn"]);
						}
						if (dr["BillProcessStatus"] != null && dr["BillProcessStatus"] != DBNull.Value)
						{
							item.BillProcessStatus = Convert.ToInt32(dr["BillProcessStatus"]);
						}
						if (dr["RegisterDate"] != null && dr["RegisterDate"] != DBNull.Value)
						{
							item.RegisterDate = Convert.ToDateTime(dr["RegisterDate"]);
						}
						if (dr["SignedDate"] != null && dr["SignedDate"] != DBNull.Value)
						{
							item.SignedDate = Convert.ToDateTime(dr["SignedDate"]);
						}
						if (dr["LastUpdateDate"] != null && dr["LastUpdateDate"] != DBNull.Value)
						{
							item.LastUpdateDate = Convert.ToDateTime(dr["LastUpdateDate"]);
						}
						if (dr["LastUpdateUser"] != null && dr["LastUpdateUser"] != DBNull.Value)
						{
							item.LastUpdateUser = Convert.ToString(dr["LastUpdateUser"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["SystemDate"] != null && dr["SystemDate"] != DBNull.Value)
						{
							item.SystemDate = Convert.ToDateTime(dr["SystemDate"]);
						}
						if (dr["BT3Type"] != null && dr["BT3Type"] != DBNull.Value)
						{
							item.BT3Type = Convert.ToString(dr["BT3Type"]);
						}
						if (dr["BT3CodeSub"] != null && dr["BT3CodeSub"] != DBNull.Value)
						{
							item.BT3CodeSub = Convert.ToString(dr["BT3CodeSub"]);
						}
						if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
						{
							item.BT3Code = Convert.ToString(dr["BT3Code"]);
						}
						if (dr["BT3Status"] != null && dr["BT3Status"] != DBNull.Value)
						{
							item.BT3Status = Convert.ToString(dr["BT3Status"]);
						}
						if (dr["BT3Freight"] != null && dr["BT3Freight"] != DBNull.Value)
						{
							item.BT3Freight = Convert.ToDecimal(dr["BT3Freight"]);
						}
						if (dr["BT3COD"] != null && dr["BT3COD"] != DBNull.Value)
						{
							item.BT3COD = Convert.ToDecimal(dr["BT3COD"]);
						}
						if (dr["BT3PayType"] != null && dr["BT3PayType"] != DBNull.Value)
						{
							item.BT3PayType = Convert.ToString(dr["BT3PayType"]);
						}
						if (dr["BT3LastMess"] != null && dr["BT3LastMess"] != DBNull.Value)
						{
							item.BT3LastMess = Convert.ToString(dr["BT3LastMess"]);
						}
						if (dr["GoodsName"] != null && dr["GoodsName"] != DBNull.Value)
						{
							item.GoodsName = Convert.ToString(dr["GoodsName"]);
						}
						if (dr["GoodsNumber"] != null && dr["GoodsNumber"] != DBNull.Value)
						{
							item.GoodsNumber = Convert.ToInt32(dr["GoodsNumber"]);
						}
						if (dr["GoodsCode"] != null && dr["GoodsCode"] != DBNull.Value)
						{
							item.GoodsCode = Convert.ToString(dr["GoodsCode"]);
						}
						if (dr["GoodsW"] != null && dr["GoodsW"] != DBNull.Value)
						{
							item.GoodsW = Convert.ToInt32(dr["GoodsW"]);
						}
						if (dr["GoodsH"] != null && dr["GoodsH"] != DBNull.Value)
						{
							item.GoodsH = Convert.ToInt32(dr["GoodsH"]);
						}
						if (dr["GoodsL"] != null && dr["GoodsL"] != DBNull.Value)
						{
							item.GoodsL = Convert.ToInt32(dr["GoodsL"]);
						}
						if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
						{
							item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
						}
						if (dr["FK_ProviderAccount"] != null && dr["FK_ProviderAccount"] != DBNull.Value)
						{
							item.FK_ProviderAccount = Convert.ToString(dr["FK_ProviderAccount"]);
						}
						if (dr["PayCustomerDate"] != null && dr["PayCustomerDate"] != DBNull.Value)
						{
							item.PayCustomerDate = Convert.ToDateTime(dr["PayCustomerDate"]);
						}
						if (dr["IsPayCustomer"] != null && dr["IsPayCustomer"] != DBNull.Value)
						{
							item.IsPayCustomer = Convert.ToBoolean(dr["IsPayCustomer"]);
						}
						if (dr["ShipperPhoneNumber"] != null && dr["ShipperPhoneNumber"] != DBNull.Value)
						{
							item.ShipperPhoneNumber = Convert.ToString(dr["ShipperPhoneNumber"]);
						}
						if (dr["BillStatus"] != null && dr["BillStatus"] != DBNull.Value)
						{
							item.BillStatus = Convert.ToInt32(dr["BillStatus"]);
						}
						if (dr["FK_PaymentType"] != null && dr["FK_PaymentType"] != DBNull.Value)
						{
							item.FK_PaymentType = Convert.ToString(dr["FK_PaymentType"]);
						}
						if (dr["FK_ShipType"] != null && dr["FK_ShipType"] != DBNull.Value)
						{
							item.FK_ShipType = Convert.ToString(dr["FK_ShipType"]);
						}
						if (dr["Pickup"] != null && dr["Pickup"] != DBNull.Value)
						{
							item.Pickup = Convert.ToBoolean(dr["Pickup"]);
						}
						if (dr["AddressPickup"] != null && dr["AddressPickup"] != DBNull.Value)
						{
							item.AddressPickup = Convert.ToString(dr["AddressPickup"]);
						}
						if (dr["ProvincePickup"] != null && dr["ProvincePickup"] != DBNull.Value)
						{
							item.ProvincePickup = Convert.ToString(dr["ProvincePickup"]);
						}
						if (dr["DistricPickup"] != null && dr["DistricPickup"] != DBNull.Value)
						{
							item.DistricPickup = Convert.ToString(dr["DistricPickup"]);
						}
						if (dr["WardPickup"] != null && dr["WardPickup"] != DBNull.Value)
						{
							item.WardPickup = Convert.ToString(dr["WardPickup"]);
						}
						if (dr["ShopIdPickup"] != null && dr["ShopIdPickup"] != DBNull.Value)
						{
							item.ShopIdPickup = Convert.ToString(dr["ShopIdPickup"]);
						}
						if (dr["SiteCode"] != null && dr["SiteCode"] != DBNull.Value)
						{
							item.SiteCode = Convert.ToString(dr["SiteCode"]);
						}
						if (dr["IsReceiveBill"] != null && dr["IsReceiveBill"] != DBNull.Value)
						{
							item.IsReceiveBill = Convert.ToBoolean(dr["IsReceiveBill"]);
						}
						if (dr["PrintData"] != null && dr["PrintData"] != DBNull.Value)
						{
							item.PrintData = Convert.ToString(dr["PrintData"]);
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
		/// Lấy một GExpBill đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpBill GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpBill] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpBill item=new GExpBill();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
						{
							item.BillCode = Convert.ToString(dr["BillCode"]);
						}
						if (dr["BillWeight"] != null && dr["BillWeight"] != DBNull.Value)
						{
							item.BillWeight = Convert.ToDecimal(dr["BillWeight"]);
						}
						if (dr["FeeWeight"] != null && dr["FeeWeight"] != DBNull.Value)
						{
							item.FeeWeight = Convert.ToDecimal(dr["FeeWeight"]);
						}
						if (dr["RegisterUser"] != null && dr["RegisterUser"] != DBNull.Value)
						{
							item.RegisterUser = Convert.ToString(dr["RegisterUser"]);
						}
						if (dr["RegisterSiteCode"] != null && dr["RegisterSiteCode"] != DBNull.Value)
						{
							item.RegisterSiteCode = Convert.ToString(dr["RegisterSiteCode"]);
						}
						if (dr["Freight"] != null && dr["Freight"] != DBNull.Value)
						{
							item.Freight = Convert.ToDecimal(dr["Freight"]);
						}
						if (dr["PayType"] != null && dr["PayType"] != DBNull.Value)
						{
							item.PayType = Convert.ToString(dr["PayType"]);
						}
						if (dr["COD"] != null && dr["COD"] != DBNull.Value)
						{
							item.COD = Convert.ToDecimal(dr["COD"]);
						}
						if (dr["SendMan"] != null && dr["SendMan"] != DBNull.Value)
						{
							item.SendMan = Convert.ToString(dr["SendMan"]);
						}
						if (dr["SendManUs"] != null && dr["SendManUs"] != DBNull.Value)
						{
							item.SendManUs = Convert.ToString(dr["SendManUs"]);
						}
						if (dr["SendManPhone"] != null && dr["SendManPhone"] != DBNull.Value)
						{
							item.SendManPhone = Convert.ToString(dr["SendManPhone"]);
						}
						if (dr["SendManAddress"] != null && dr["SendManAddress"] != DBNull.Value)
						{
							item.SendManAddress = Convert.ToString(dr["SendManAddress"]);
						}
						if (dr["AcceptProvinceCode"] != null && dr["AcceptProvinceCode"] != DBNull.Value)
						{
							item.AcceptProvinceCode = Convert.ToInt32(dr["AcceptProvinceCode"]);
						}
						if (dr["AcceptDistrictCode"] != null && dr["AcceptDistrictCode"] != DBNull.Value)
						{
							item.AcceptDistrictCode = Convert.ToInt32(dr["AcceptDistrictCode"]);
						}
						if (dr["AcceptWardCode"] != null && dr["AcceptWardCode"] != DBNull.Value)
						{
							item.AcceptWardCode = Convert.ToString(dr["AcceptWardCode"]);
						}
						if (dr["AcceptMan"] != null && dr["AcceptMan"] != DBNull.Value)
						{
							item.AcceptMan = Convert.ToString(dr["AcceptMan"]);
						}
						if (dr["AcceptManUs"] != null && dr["AcceptManUs"] != DBNull.Value)
						{
							item.AcceptManUs = Convert.ToString(dr["AcceptManUs"]);
						}
						if (dr["AcceptManPhone"] != null && dr["AcceptManPhone"] != DBNull.Value)
						{
							item.AcceptManPhone = Convert.ToString(dr["AcceptManPhone"]);
						}
						if (dr["AcceptManAddress"] != null && dr["AcceptManAddress"] != DBNull.Value)
						{
							item.AcceptManAddress = Convert.ToString(dr["AcceptManAddress"]);
						}
						if (dr["AcceptProvince"] != null && dr["AcceptProvince"] != DBNull.Value)
						{
							item.AcceptProvince = Convert.ToString(dr["AcceptProvince"]);
						}
						if (dr["AcceptDistrict"] != null && dr["AcceptDistrict"] != DBNull.Value)
						{
							item.AcceptDistrict = Convert.ToString(dr["AcceptDistrict"]);
						}
						if (dr["AcceptWard"] != null && dr["AcceptWard"] != DBNull.Value)
						{
							item.AcceptWard = Convert.ToString(dr["AcceptWard"]);
						}
						if (dr["IsSigned"] != null && dr["IsSigned"] != DBNull.Value)
						{
							item.IsSigned = Convert.ToBoolean(dr["IsSigned"]);
						}
						if (dr["IsReturn"] != null && dr["IsReturn"] != DBNull.Value)
						{
							item.IsReturn = Convert.ToBoolean(dr["IsReturn"]);
						}
						if (dr["BillProcessStatus"] != null && dr["BillProcessStatus"] != DBNull.Value)
						{
							item.BillProcessStatus = Convert.ToInt32(dr["BillProcessStatus"]);
						}
						if (dr["RegisterDate"] != null && dr["RegisterDate"] != DBNull.Value)
						{
							item.RegisterDate = Convert.ToDateTime(dr["RegisterDate"]);
						}
						if (dr["SignedDate"] != null && dr["SignedDate"] != DBNull.Value)
						{
							item.SignedDate = Convert.ToDateTime(dr["SignedDate"]);
						}
						if (dr["LastUpdateDate"] != null && dr["LastUpdateDate"] != DBNull.Value)
						{
							item.LastUpdateDate = Convert.ToDateTime(dr["LastUpdateDate"]);
						}
						if (dr["LastUpdateUser"] != null && dr["LastUpdateUser"] != DBNull.Value)
						{
							item.LastUpdateUser = Convert.ToString(dr["LastUpdateUser"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["SystemDate"] != null && dr["SystemDate"] != DBNull.Value)
						{
							item.SystemDate = Convert.ToDateTime(dr["SystemDate"]);
						}
						if (dr["BT3Type"] != null && dr["BT3Type"] != DBNull.Value)
						{
							item.BT3Type = Convert.ToString(dr["BT3Type"]);
						}
						if (dr["BT3CodeSub"] != null && dr["BT3CodeSub"] != DBNull.Value)
						{
							item.BT3CodeSub = Convert.ToString(dr["BT3CodeSub"]);
						}
						if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
						{
							item.BT3Code = Convert.ToString(dr["BT3Code"]);
						}
						if (dr["BT3Status"] != null && dr["BT3Status"] != DBNull.Value)
						{
							item.BT3Status = Convert.ToString(dr["BT3Status"]);
						}
						if (dr["BT3Freight"] != null && dr["BT3Freight"] != DBNull.Value)
						{
							item.BT3Freight = Convert.ToDecimal(dr["BT3Freight"]);
						}
						if (dr["BT3COD"] != null && dr["BT3COD"] != DBNull.Value)
						{
							item.BT3COD = Convert.ToDecimal(dr["BT3COD"]);
						}
						if (dr["BT3PayType"] != null && dr["BT3PayType"] != DBNull.Value)
						{
							item.BT3PayType = Convert.ToString(dr["BT3PayType"]);
						}
						if (dr["BT3LastMess"] != null && dr["BT3LastMess"] != DBNull.Value)
						{
							item.BT3LastMess = Convert.ToString(dr["BT3LastMess"]);
						}
						if (dr["GoodsName"] != null && dr["GoodsName"] != DBNull.Value)
						{
							item.GoodsName = Convert.ToString(dr["GoodsName"]);
						}
						if (dr["GoodsNumber"] != null && dr["GoodsNumber"] != DBNull.Value)
						{
							item.GoodsNumber = Convert.ToInt32(dr["GoodsNumber"]);
						}
						if (dr["GoodsCode"] != null && dr["GoodsCode"] != DBNull.Value)
						{
							item.GoodsCode = Convert.ToString(dr["GoodsCode"]);
						}
						if (dr["GoodsW"] != null && dr["GoodsW"] != DBNull.Value)
						{
							item.GoodsW = Convert.ToInt32(dr["GoodsW"]);
						}
						if (dr["GoodsH"] != null && dr["GoodsH"] != DBNull.Value)
						{
							item.GoodsH = Convert.ToInt32(dr["GoodsH"]);
						}
						if (dr["GoodsL"] != null && dr["GoodsL"] != DBNull.Value)
						{
							item.GoodsL = Convert.ToInt32(dr["GoodsL"]);
						}
						if (dr["FK_Customer"] != null && dr["FK_Customer"] != DBNull.Value)
						{
							item.FK_Customer = Convert.ToString(dr["FK_Customer"]);
						}
						if (dr["FK_ProviderAccount"] != null && dr["FK_ProviderAccount"] != DBNull.Value)
						{
							item.FK_ProviderAccount = Convert.ToString(dr["FK_ProviderAccount"]);
						}
						if (dr["PayCustomerDate"] != null && dr["PayCustomerDate"] != DBNull.Value)
						{
							item.PayCustomerDate = Convert.ToDateTime(dr["PayCustomerDate"]);
						}
						if (dr["IsPayCustomer"] != null && dr["IsPayCustomer"] != DBNull.Value)
						{
							item.IsPayCustomer = Convert.ToBoolean(dr["IsPayCustomer"]);
						}
						if (dr["ShipperPhoneNumber"] != null && dr["ShipperPhoneNumber"] != DBNull.Value)
						{
							item.ShipperPhoneNumber = Convert.ToString(dr["ShipperPhoneNumber"]);
						}
						if (dr["BillStatus"] != null && dr["BillStatus"] != DBNull.Value)
						{
							item.BillStatus = Convert.ToInt32(dr["BillStatus"]);
						}
						if (dr["FK_PaymentType"] != null && dr["FK_PaymentType"] != DBNull.Value)
						{
							item.FK_PaymentType = Convert.ToString(dr["FK_PaymentType"]);
						}
						if (dr["FK_ShipType"] != null && dr["FK_ShipType"] != DBNull.Value)
						{
							item.FK_ShipType = Convert.ToString(dr["FK_ShipType"]);
						}
						if (dr["Pickup"] != null && dr["Pickup"] != DBNull.Value)
						{
							item.Pickup = Convert.ToBoolean(dr["Pickup"]);
						}
						if (dr["AddressPickup"] != null && dr["AddressPickup"] != DBNull.Value)
						{
							item.AddressPickup = Convert.ToString(dr["AddressPickup"]);
						}
						if (dr["ProvincePickup"] != null && dr["ProvincePickup"] != DBNull.Value)
						{
							item.ProvincePickup = Convert.ToString(dr["ProvincePickup"]);
						}
						if (dr["DistricPickup"] != null && dr["DistricPickup"] != DBNull.Value)
						{
							item.DistricPickup = Convert.ToString(dr["DistricPickup"]);
						}
						if (dr["WardPickup"] != null && dr["WardPickup"] != DBNull.Value)
						{
							item.WardPickup = Convert.ToString(dr["WardPickup"]);
						}
						if (dr["ShopIdPickup"] != null && dr["ShopIdPickup"] != DBNull.Value)
						{
							item.ShopIdPickup = Convert.ToString(dr["ShopIdPickup"]);
						}
						if (dr["SiteCode"] != null && dr["SiteCode"] != DBNull.Value)
						{
							item.SiteCode = Convert.ToString(dr["SiteCode"]);
						}
						if (dr["IsReceiveBill"] != null && dr["IsReceiveBill"] != DBNull.Value)
						{
							item.IsReceiveBill = Convert.ToBoolean(dr["IsReceiveBill"]);
						}
						if (dr["PrintData"] != null && dr["PrintData"] != DBNull.Value)
						{
							item.PrintData = Convert.ToString(dr["PrintData"]);
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

		public GExpBill GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpBill] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpBill>(ds);
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
		/// Thêm mới GExpBill vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpBill _GExpBill)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpBill](BillCode, BillWeight, FeeWeight, RegisterUser, RegisterSiteCode, Freight, PayType, COD, SendMan, SendManUs, SendManPhone, SendManAddress, AcceptProvinceCode, AcceptDistrictCode, AcceptWardCode, AcceptMan, AcceptManUs, AcceptManPhone, AcceptManAddress, AcceptProvince, AcceptDistrict, AcceptWard, IsSigned, IsReturn, BillProcessStatus, RegisterDate, SignedDate, LastUpdateDate, LastUpdateUser, Note, SystemDate, BT3Type, BT3CodeSub, BT3Code, BT3Status, BT3Freight, BT3COD, BT3PayType, BT3LastMess, GoodsName, GoodsNumber, GoodsCode, GoodsW, GoodsH, GoodsL, FK_Customer, FK_ProviderAccount, PayCustomerDate, IsPayCustomer, ShipperPhoneNumber, BillStatus, FK_PaymentType, FK_ShipType, Pickup, AddressPickup, ProvincePickup, DistricPickup, WardPickup, ShopIdPickup, SiteCode, IsReceiveBill, PrintData) VALUES(@BillCode, @BillWeight, @FeeWeight, @RegisterUser, @RegisterSiteCode, @Freight, @PayType, @COD, @SendMan, @SendManUs, @SendManPhone, @SendManAddress, @AcceptProvinceCode, @AcceptDistrictCode, @AcceptWardCode, @AcceptMan, @AcceptManUs, @AcceptManPhone, @AcceptManAddress, @AcceptProvince, @AcceptDistrict, @AcceptWard, @IsSigned, @IsReturn, @BillProcessStatus, @RegisterDate, @SignedDate, @LastUpdateDate, @LastUpdateUser, @Note, @SystemDate, @BT3Type, @BT3CodeSub, @BT3Code, @BT3Status, @BT3Freight, @BT3COD, @BT3PayType, @BT3LastMess, @GoodsName, @GoodsNumber, @GoodsCode, @GoodsW, @GoodsH, @GoodsL, @FK_Customer, @FK_ProviderAccount, @PayCustomerDate, @IsPayCustomer, @ShipperPhoneNumber, @BillStatus, @FK_PaymentType, @FK_ShipType, @Pickup, @AddressPickup, @ProvincePickup, @DistricPickup, @WardPickup, @ShopIdPickup, @SiteCode, @IsReceiveBill, @PrintData)", 
					"@BillCode",  _GExpBill.BillCode, 
					"@BillWeight",  _GExpBill.BillWeight, 
					"@FeeWeight",  _GExpBill.FeeWeight, 
					"@RegisterUser",  _GExpBill.RegisterUser, 
					"@RegisterSiteCode",  _GExpBill.RegisterSiteCode, 
					"@Freight",  _GExpBill.Freight, 
					"@PayType",  _GExpBill.PayType, 
					"@COD",  _GExpBill.COD, 
					"@SendMan",  _GExpBill.SendMan, 
					"@SendManUs",  _GExpBill.SendManUs, 
					"@SendManPhone",  _GExpBill.SendManPhone, 
					"@SendManAddress",  _GExpBill.SendManAddress, 
					"@AcceptProvinceCode",  _GExpBill.AcceptProvinceCode, 
					"@AcceptDistrictCode",  _GExpBill.AcceptDistrictCode, 
					"@AcceptWardCode",  _GExpBill.AcceptWardCode, 
					"@AcceptMan",  _GExpBill.AcceptMan, 
					"@AcceptManUs",  _GExpBill.AcceptManUs, 
					"@AcceptManPhone",  _GExpBill.AcceptManPhone, 
					"@AcceptManAddress",  _GExpBill.AcceptManAddress, 
					"@AcceptProvince",  _GExpBill.AcceptProvince, 
					"@AcceptDistrict",  _GExpBill.AcceptDistrict, 
					"@AcceptWard",  _GExpBill.AcceptWard, 
					"@IsSigned",  _GExpBill.IsSigned, 
					"@IsReturn",  _GExpBill.IsReturn, 
					"@BillProcessStatus",  _GExpBill.BillProcessStatus, 
					"@RegisterDate", this._dataContext.ConvertDateString( _GExpBill.RegisterDate), 
					"@SignedDate", this._dataContext.ConvertDateString( _GExpBill.SignedDate), 
					"@LastUpdateDate", this._dataContext.ConvertDateString( _GExpBill.LastUpdateDate), 
					"@LastUpdateUser",  _GExpBill.LastUpdateUser, 
					"@Note",  _GExpBill.Note, 
					"@SystemDate", this._dataContext.ConvertDateString( _GExpBill.SystemDate), 
					"@BT3Type",  _GExpBill.BT3Type, 
					"@BT3CodeSub",  _GExpBill.BT3CodeSub, 
					"@BT3Code",  _GExpBill.BT3Code, 
					"@BT3Status",  _GExpBill.BT3Status, 
					"@BT3Freight",  _GExpBill.BT3Freight, 
					"@BT3COD",  _GExpBill.BT3COD, 
					"@BT3PayType",  _GExpBill.BT3PayType, 
					"@BT3LastMess",  _GExpBill.BT3LastMess, 
					"@GoodsName",  _GExpBill.GoodsName, 
					"@GoodsNumber",  _GExpBill.GoodsNumber, 
					"@GoodsCode",  _GExpBill.GoodsCode, 
					"@GoodsW",  _GExpBill.GoodsW, 
					"@GoodsH",  _GExpBill.GoodsH, 
					"@GoodsL",  _GExpBill.GoodsL, 
					"@FK_Customer",  _GExpBill.FK_Customer, 
					"@FK_ProviderAccount",  _GExpBill.FK_ProviderAccount, 
					"@PayCustomerDate", this._dataContext.ConvertDateString( _GExpBill.PayCustomerDate), 
					"@IsPayCustomer",  _GExpBill.IsPayCustomer, 
					"@ShipperPhoneNumber",  _GExpBill.ShipperPhoneNumber, 
					"@BillStatus",  _GExpBill.BillStatus, 
					"@FK_PaymentType",  _GExpBill.FK_PaymentType, 
					"@FK_ShipType",  _GExpBill.FK_ShipType, 
					"@Pickup",  _GExpBill.Pickup, 
					"@AddressPickup",  _GExpBill.AddressPickup, 
					"@ProvincePickup",  _GExpBill.ProvincePickup, 
					"@DistricPickup",  _GExpBill.DistricPickup, 
					"@WardPickup",  _GExpBill.WardPickup, 
					"@ShopIdPickup",  _GExpBill.ShopIdPickup, 
					"@SiteCode",  _GExpBill.SiteCode, 
					"@IsReceiveBill",  _GExpBill.IsReceiveBill, 
					"@PrintData",  _GExpBill.PrintData);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpBill vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpBill> _GExpBills)
		{
			foreach (GExpBill item in _GExpBills)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpBill vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpBill _GExpBill, String BillCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpBill] SET BillCode=@BillCode, BillWeight=@BillWeight, FeeWeight=@FeeWeight, RegisterUser=@RegisterUser, RegisterSiteCode=@RegisterSiteCode, Freight=@Freight, PayType=@PayType, COD=@COD, SendMan=@SendMan, SendManUs=@SendManUs, SendManPhone=@SendManPhone, SendManAddress=@SendManAddress, AcceptProvinceCode=@AcceptProvinceCode, AcceptDistrictCode=@AcceptDistrictCode, AcceptWardCode=@AcceptWardCode, AcceptMan=@AcceptMan, AcceptManUs=@AcceptManUs, AcceptManPhone=@AcceptManPhone, AcceptManAddress=@AcceptManAddress, AcceptProvince=@AcceptProvince, AcceptDistrict=@AcceptDistrict, AcceptWard=@AcceptWard, IsSigned=@IsSigned, IsReturn=@IsReturn, BillProcessStatus=@BillProcessStatus, RegisterDate=@RegisterDate, SignedDate=@SignedDate, LastUpdateDate=@LastUpdateDate, LastUpdateUser=@LastUpdateUser, Note=@Note, SystemDate=@SystemDate, BT3Type=@BT3Type, BT3CodeSub=@BT3CodeSub, BT3Code=@BT3Code, BT3Status=@BT3Status, BT3Freight=@BT3Freight, BT3COD=@BT3COD, BT3PayType=@BT3PayType, BT3LastMess=@BT3LastMess, GoodsName=@GoodsName, GoodsNumber=@GoodsNumber, GoodsCode=@GoodsCode, GoodsW=@GoodsW, GoodsH=@GoodsH, GoodsL=@GoodsL, FK_Customer=@FK_Customer, FK_ProviderAccount=@FK_ProviderAccount, PayCustomerDate=@PayCustomerDate, IsPayCustomer=@IsPayCustomer, ShipperPhoneNumber=@ShipperPhoneNumber, BillStatus=@BillStatus, FK_PaymentType=@FK_PaymentType, FK_ShipType=@FK_ShipType, Pickup=@Pickup, AddressPickup=@AddressPickup, ProvincePickup=@ProvincePickup, DistricPickup=@DistricPickup, WardPickup=@WardPickup, ShopIdPickup=@ShopIdPickup, SiteCode=@SiteCode, IsReceiveBill=@IsReceiveBill, PrintData=@PrintData WHERE BillCode=@BillCode", 
					"@BillCode",  _GExpBill.BillCode, 
					"@BillWeight",  _GExpBill.BillWeight, 
					"@FeeWeight",  _GExpBill.FeeWeight, 
					"@RegisterUser",  _GExpBill.RegisterUser, 
					"@RegisterSiteCode",  _GExpBill.RegisterSiteCode, 
					"@Freight",  _GExpBill.Freight, 
					"@PayType",  _GExpBill.PayType, 
					"@COD",  _GExpBill.COD, 
					"@SendMan",  _GExpBill.SendMan, 
					"@SendManUs",  _GExpBill.SendManUs, 
					"@SendManPhone",  _GExpBill.SendManPhone, 
					"@SendManAddress",  _GExpBill.SendManAddress, 
					"@AcceptProvinceCode",  _GExpBill.AcceptProvinceCode, 
					"@AcceptDistrictCode",  _GExpBill.AcceptDistrictCode, 
					"@AcceptWardCode",  _GExpBill.AcceptWardCode, 
					"@AcceptMan",  _GExpBill.AcceptMan, 
					"@AcceptManUs",  _GExpBill.AcceptManUs, 
					"@AcceptManPhone",  _GExpBill.AcceptManPhone, 
					"@AcceptManAddress",  _GExpBill.AcceptManAddress, 
					"@AcceptProvince",  _GExpBill.AcceptProvince, 
					"@AcceptDistrict",  _GExpBill.AcceptDistrict, 
					"@AcceptWard",  _GExpBill.AcceptWard, 
					"@IsSigned",  _GExpBill.IsSigned, 
					"@IsReturn",  _GExpBill.IsReturn, 
					"@BillProcessStatus",  _GExpBill.BillProcessStatus, 
					"@RegisterDate", this._dataContext.ConvertDateString( _GExpBill.RegisterDate), 
					"@SignedDate", this._dataContext.ConvertDateString( _GExpBill.SignedDate), 
					"@LastUpdateDate", this._dataContext.ConvertDateString( _GExpBill.LastUpdateDate), 
					"@LastUpdateUser",  _GExpBill.LastUpdateUser, 
					"@Note",  _GExpBill.Note, 
					"@SystemDate", this._dataContext.ConvertDateString( _GExpBill.SystemDate), 
					"@BT3Type",  _GExpBill.BT3Type, 
					"@BT3CodeSub",  _GExpBill.BT3CodeSub, 
					"@BT3Code",  _GExpBill.BT3Code, 
					"@BT3Status",  _GExpBill.BT3Status, 
					"@BT3Freight",  _GExpBill.BT3Freight, 
					"@BT3COD",  _GExpBill.BT3COD, 
					"@BT3PayType",  _GExpBill.BT3PayType, 
					"@BT3LastMess",  _GExpBill.BT3LastMess, 
					"@GoodsName",  _GExpBill.GoodsName, 
					"@GoodsNumber",  _GExpBill.GoodsNumber, 
					"@GoodsCode",  _GExpBill.GoodsCode, 
					"@GoodsW",  _GExpBill.GoodsW, 
					"@GoodsH",  _GExpBill.GoodsH, 
					"@GoodsL",  _GExpBill.GoodsL, 
					"@FK_Customer",  _GExpBill.FK_Customer, 
					"@FK_ProviderAccount",  _GExpBill.FK_ProviderAccount, 
					"@PayCustomerDate", this._dataContext.ConvertDateString( _GExpBill.PayCustomerDate), 
					"@IsPayCustomer",  _GExpBill.IsPayCustomer, 
					"@ShipperPhoneNumber",  _GExpBill.ShipperPhoneNumber, 
					"@BillStatus",  _GExpBill.BillStatus, 
					"@FK_PaymentType",  _GExpBill.FK_PaymentType, 
					"@FK_ShipType",  _GExpBill.FK_ShipType, 
					"@Pickup",  _GExpBill.Pickup, 
					"@AddressPickup",  _GExpBill.AddressPickup, 
					"@ProvincePickup",  _GExpBill.ProvincePickup, 
					"@DistricPickup",  _GExpBill.DistricPickup, 
					"@WardPickup",  _GExpBill.WardPickup, 
					"@ShopIdPickup",  _GExpBill.ShopIdPickup, 
					"@SiteCode",  _GExpBill.SiteCode, 
					"@IsReceiveBill",  _GExpBill.IsReceiveBill, 
					"@PrintData",  _GExpBill.PrintData, 
					"@BillCode", BillCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpBill vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpBill _GExpBill)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpBill] SET BillWeight=@BillWeight, FeeWeight=@FeeWeight, RegisterUser=@RegisterUser, RegisterSiteCode=@RegisterSiteCode, Freight=@Freight, PayType=@PayType, COD=@COD, SendMan=@SendMan, SendManUs=@SendManUs, SendManPhone=@SendManPhone, SendManAddress=@SendManAddress, AcceptProvinceCode=@AcceptProvinceCode, AcceptDistrictCode=@AcceptDistrictCode, AcceptWardCode=@AcceptWardCode, AcceptMan=@AcceptMan, AcceptManUs=@AcceptManUs, AcceptManPhone=@AcceptManPhone, AcceptManAddress=@AcceptManAddress, AcceptProvince=@AcceptProvince, AcceptDistrict=@AcceptDistrict, AcceptWard=@AcceptWard, IsSigned=@IsSigned, IsReturn=@IsReturn, BillProcessStatus=@BillProcessStatus, RegisterDate=@RegisterDate, SignedDate=@SignedDate, LastUpdateDate=@LastUpdateDate, LastUpdateUser=@LastUpdateUser, Note=@Note, SystemDate=@SystemDate, BT3Type=@BT3Type, BT3CodeSub=@BT3CodeSub, BT3Code=@BT3Code, BT3Status=@BT3Status, BT3Freight=@BT3Freight, BT3COD=@BT3COD, BT3PayType=@BT3PayType, BT3LastMess=@BT3LastMess, GoodsName=@GoodsName, GoodsNumber=@GoodsNumber, GoodsCode=@GoodsCode, GoodsW=@GoodsW, GoodsH=@GoodsH, GoodsL=@GoodsL, FK_Customer=@FK_Customer, FK_ProviderAccount=@FK_ProviderAccount, PayCustomerDate=@PayCustomerDate, IsPayCustomer=@IsPayCustomer, ShipperPhoneNumber=@ShipperPhoneNumber, BillStatus=@BillStatus, FK_PaymentType=@FK_PaymentType, FK_ShipType=@FK_ShipType, Pickup=@Pickup, AddressPickup=@AddressPickup, ProvincePickup=@ProvincePickup, DistricPickup=@DistricPickup, WardPickup=@WardPickup, ShopIdPickup=@ShopIdPickup, SiteCode=@SiteCode, IsReceiveBill=@IsReceiveBill, PrintData=@PrintData WHERE BillCode=@BillCode", 
					"@BillWeight",  _GExpBill.BillWeight, 
					"@FeeWeight",  _GExpBill.FeeWeight, 
					"@RegisterUser",  _GExpBill.RegisterUser, 
					"@RegisterSiteCode",  _GExpBill.RegisterSiteCode, 
					"@Freight",  _GExpBill.Freight, 
					"@PayType",  _GExpBill.PayType, 
					"@COD",  _GExpBill.COD, 
					"@SendMan",  _GExpBill.SendMan, 
					"@SendManUs",  _GExpBill.SendManUs, 
					"@SendManPhone",  _GExpBill.SendManPhone, 
					"@SendManAddress",  _GExpBill.SendManAddress, 
					"@AcceptProvinceCode",  _GExpBill.AcceptProvinceCode, 
					"@AcceptDistrictCode",  _GExpBill.AcceptDistrictCode, 
					"@AcceptWardCode",  _GExpBill.AcceptWardCode, 
					"@AcceptMan",  _GExpBill.AcceptMan, 
					"@AcceptManUs",  _GExpBill.AcceptManUs, 
					"@AcceptManPhone",  _GExpBill.AcceptManPhone, 
					"@AcceptManAddress",  _GExpBill.AcceptManAddress, 
					"@AcceptProvince",  _GExpBill.AcceptProvince, 
					"@AcceptDistrict",  _GExpBill.AcceptDistrict, 
					"@AcceptWard",  _GExpBill.AcceptWard, 
					"@IsSigned",  _GExpBill.IsSigned, 
					"@IsReturn",  _GExpBill.IsReturn, 
					"@BillProcessStatus",  _GExpBill.BillProcessStatus, 
					"@RegisterDate", this._dataContext.ConvertDateString( _GExpBill.RegisterDate), 
					"@SignedDate", this._dataContext.ConvertDateString( _GExpBill.SignedDate), 
					"@LastUpdateDate", this._dataContext.ConvertDateString( _GExpBill.LastUpdateDate), 
					"@LastUpdateUser",  _GExpBill.LastUpdateUser, 
					"@Note",  _GExpBill.Note, 
					"@SystemDate", this._dataContext.ConvertDateString( _GExpBill.SystemDate), 
					"@BT3Type",  _GExpBill.BT3Type, 
					"@BT3CodeSub",  _GExpBill.BT3CodeSub, 
					"@BT3Code",  _GExpBill.BT3Code, 
					"@BT3Status",  _GExpBill.BT3Status, 
					"@BT3Freight",  _GExpBill.BT3Freight, 
					"@BT3COD",  _GExpBill.BT3COD, 
					"@BT3PayType",  _GExpBill.BT3PayType, 
					"@BT3LastMess",  _GExpBill.BT3LastMess, 
					"@GoodsName",  _GExpBill.GoodsName, 
					"@GoodsNumber",  _GExpBill.GoodsNumber, 
					"@GoodsCode",  _GExpBill.GoodsCode, 
					"@GoodsW",  _GExpBill.GoodsW, 
					"@GoodsH",  _GExpBill.GoodsH, 
					"@GoodsL",  _GExpBill.GoodsL, 
					"@FK_Customer",  _GExpBill.FK_Customer, 
					"@FK_ProviderAccount",  _GExpBill.FK_ProviderAccount, 
					"@PayCustomerDate", this._dataContext.ConvertDateString( _GExpBill.PayCustomerDate), 
					"@IsPayCustomer",  _GExpBill.IsPayCustomer, 
					"@ShipperPhoneNumber",  _GExpBill.ShipperPhoneNumber, 
					"@BillStatus",  _GExpBill.BillStatus, 
					"@FK_PaymentType",  _GExpBill.FK_PaymentType, 
					"@FK_ShipType",  _GExpBill.FK_ShipType, 
					"@Pickup",  _GExpBill.Pickup, 
					"@AddressPickup",  _GExpBill.AddressPickup, 
					"@ProvincePickup",  _GExpBill.ProvincePickup, 
					"@DistricPickup",  _GExpBill.DistricPickup, 
					"@WardPickup",  _GExpBill.WardPickup, 
					"@ShopIdPickup",  _GExpBill.ShopIdPickup, 
					"@SiteCode",  _GExpBill.SiteCode, 
					"@IsReceiveBill",  _GExpBill.IsReceiveBill, 
					"@PrintData",  _GExpBill.PrintData, 
					"@BillCode", _GExpBill.BillCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpBill vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpBill> _GExpBills)
		{
			foreach (GExpBill item in _GExpBills)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpBill vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpBill _GExpBill, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpBill] SET BillCode=@BillCode, BillWeight=@BillWeight, FeeWeight=@FeeWeight, RegisterUser=@RegisterUser, RegisterSiteCode=@RegisterSiteCode, Freight=@Freight, PayType=@PayType, COD=@COD, SendMan=@SendMan, SendManUs=@SendManUs, SendManPhone=@SendManPhone, SendManAddress=@SendManAddress, AcceptProvinceCode=@AcceptProvinceCode, AcceptDistrictCode=@AcceptDistrictCode, AcceptWardCode=@AcceptWardCode, AcceptMan=@AcceptMan, AcceptManUs=@AcceptManUs, AcceptManPhone=@AcceptManPhone, AcceptManAddress=@AcceptManAddress, AcceptProvince=@AcceptProvince, AcceptDistrict=@AcceptDistrict, AcceptWard=@AcceptWard, IsSigned=@IsSigned, IsReturn=@IsReturn, BillProcessStatus=@BillProcessStatus, RegisterDate=@RegisterDate, SignedDate=@SignedDate, LastUpdateDate=@LastUpdateDate, LastUpdateUser=@LastUpdateUser, Note=@Note, SystemDate=@SystemDate, BT3Type=@BT3Type, BT3CodeSub=@BT3CodeSub, BT3Code=@BT3Code, BT3Status=@BT3Status, BT3Freight=@BT3Freight, BT3COD=@BT3COD, BT3PayType=@BT3PayType, BT3LastMess=@BT3LastMess, GoodsName=@GoodsName, GoodsNumber=@GoodsNumber, GoodsCode=@GoodsCode, GoodsW=@GoodsW, GoodsH=@GoodsH, GoodsL=@GoodsL, FK_Customer=@FK_Customer, FK_ProviderAccount=@FK_ProviderAccount, PayCustomerDate=@PayCustomerDate, IsPayCustomer=@IsPayCustomer, ShipperPhoneNumber=@ShipperPhoneNumber, BillStatus=@BillStatus, FK_PaymentType=@FK_PaymentType, FK_ShipType=@FK_ShipType, Pickup=@Pickup, AddressPickup=@AddressPickup, ProvincePickup=@ProvincePickup, DistricPickup=@DistricPickup, WardPickup=@WardPickup, ShopIdPickup=@ShopIdPickup, SiteCode=@SiteCode, IsReceiveBill=@IsReceiveBill, PrintData=@PrintData "+ condition, 
					"@BillCode",  _GExpBill.BillCode, 
					"@BillWeight",  _GExpBill.BillWeight, 
					"@FeeWeight",  _GExpBill.FeeWeight, 
					"@RegisterUser",  _GExpBill.RegisterUser, 
					"@RegisterSiteCode",  _GExpBill.RegisterSiteCode, 
					"@Freight",  _GExpBill.Freight, 
					"@PayType",  _GExpBill.PayType, 
					"@COD",  _GExpBill.COD, 
					"@SendMan",  _GExpBill.SendMan, 
					"@SendManUs",  _GExpBill.SendManUs, 
					"@SendManPhone",  _GExpBill.SendManPhone, 
					"@SendManAddress",  _GExpBill.SendManAddress, 
					"@AcceptProvinceCode",  _GExpBill.AcceptProvinceCode, 
					"@AcceptDistrictCode",  _GExpBill.AcceptDistrictCode, 
					"@AcceptWardCode",  _GExpBill.AcceptWardCode, 
					"@AcceptMan",  _GExpBill.AcceptMan, 
					"@AcceptManUs",  _GExpBill.AcceptManUs, 
					"@AcceptManPhone",  _GExpBill.AcceptManPhone, 
					"@AcceptManAddress",  _GExpBill.AcceptManAddress, 
					"@AcceptProvince",  _GExpBill.AcceptProvince, 
					"@AcceptDistrict",  _GExpBill.AcceptDistrict, 
					"@AcceptWard",  _GExpBill.AcceptWard, 
					"@IsSigned",  _GExpBill.IsSigned, 
					"@IsReturn",  _GExpBill.IsReturn, 
					"@BillProcessStatus",  _GExpBill.BillProcessStatus, 
					"@RegisterDate", this._dataContext.ConvertDateString( _GExpBill.RegisterDate), 
					"@SignedDate", this._dataContext.ConvertDateString( _GExpBill.SignedDate), 
					"@LastUpdateDate", this._dataContext.ConvertDateString( _GExpBill.LastUpdateDate), 
					"@LastUpdateUser",  _GExpBill.LastUpdateUser, 
					"@Note",  _GExpBill.Note, 
					"@SystemDate", this._dataContext.ConvertDateString( _GExpBill.SystemDate), 
					"@BT3Type",  _GExpBill.BT3Type, 
					"@BT3CodeSub",  _GExpBill.BT3CodeSub, 
					"@BT3Code",  _GExpBill.BT3Code, 
					"@BT3Status",  _GExpBill.BT3Status, 
					"@BT3Freight",  _GExpBill.BT3Freight, 
					"@BT3COD",  _GExpBill.BT3COD, 
					"@BT3PayType",  _GExpBill.BT3PayType, 
					"@BT3LastMess",  _GExpBill.BT3LastMess, 
					"@GoodsName",  _GExpBill.GoodsName, 
					"@GoodsNumber",  _GExpBill.GoodsNumber, 
					"@GoodsCode",  _GExpBill.GoodsCode, 
					"@GoodsW",  _GExpBill.GoodsW, 
					"@GoodsH",  _GExpBill.GoodsH, 
					"@GoodsL",  _GExpBill.GoodsL, 
					"@FK_Customer",  _GExpBill.FK_Customer, 
					"@FK_ProviderAccount",  _GExpBill.FK_ProviderAccount, 
					"@PayCustomerDate", this._dataContext.ConvertDateString( _GExpBill.PayCustomerDate), 
					"@IsPayCustomer",  _GExpBill.IsPayCustomer, 
					"@ShipperPhoneNumber",  _GExpBill.ShipperPhoneNumber, 
					"@BillStatus",  _GExpBill.BillStatus, 
					"@FK_PaymentType",  _GExpBill.FK_PaymentType, 
					"@FK_ShipType",  _GExpBill.FK_ShipType, 
					"@Pickup",  _GExpBill.Pickup, 
					"@AddressPickup",  _GExpBill.AddressPickup, 
					"@ProvincePickup",  _GExpBill.ProvincePickup, 
					"@DistricPickup",  _GExpBill.DistricPickup, 
					"@WardPickup",  _GExpBill.WardPickup, 
					"@ShopIdPickup",  _GExpBill.ShopIdPickup, 
					"@SiteCode",  _GExpBill.SiteCode, 
					"@IsReceiveBill",  _GExpBill.IsReceiveBill, 
					"@PrintData",  _GExpBill.PrintData);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpBill trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String BillCode)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpBill] WHERE BillCode=@BillCode",
					"@BillCode", BillCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpBill trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpBill _GExpBill)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpBill] WHERE BillCode=@BillCode",
					"@BillCode", _GExpBill.BillCode);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpBill trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpBill] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpBill trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpBill> _GExpBills)
		{
			foreach (GExpBill item in _GExpBills)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
