using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewgexpbillcus:IVIewgexpbillcus
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewgexpbillcus(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_GExpBillCus từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpBillCus]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_GExpBillCus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpBillCus] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_GExpBillCus từ Database
		/// </summary>
		public List<view_GExpBillCus> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpBillCus]");
				List<view_GExpBillCus> items = new List<view_GExpBillCus>();
				view_GExpBillCus item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GExpBillCus();
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
					if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
					{
						item.BT3Code = Convert.ToString(dr["BT3Code"]);
					}
					if (dr["BT3CodeSub"] != null && dr["BT3CodeSub"] != DBNull.Value)
					{
						item.BT3CodeSub = Convert.ToString(dr["BT3CodeSub"]);
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
					if (dr["FullAddress"] != null && dr["FullAddress"] != DBNull.Value)
					{
						item.FullAddress = Convert.ToString(dr["FullAddress"]);
					}
					if (dr["ProviderName"] != null && dr["ProviderName"] != DBNull.Value)
					{
						item.ProviderName = Convert.ToString(dr["ProviderName"]);
					}
					if (dr["ProviderTypeCode"] != null && dr["ProviderTypeCode"] != DBNull.Value)
					{
						item.ProviderTypeCode = Convert.ToString(dr["ProviderTypeCode"]);
					}
					if (dr["GroupProvider"] != null && dr["GroupProvider"] != DBNull.Value)
					{
						item.GroupProvider = Convert.ToString(dr["GroupProvider"]);
					}
					if (dr["CustomerCode"] != null && dr["CustomerCode"] != DBNull.Value)
					{
						item.CustomerCode = Convert.ToString(dr["CustomerCode"]);
					}
					if (dr["PaymentTypeName"] != null && dr["PaymentTypeName"] != DBNull.Value)
					{
						item.PaymentTypeName = Convert.ToString(dr["PaymentTypeName"]);
					}
					if (dr["ShipNoteType"] != null && dr["ShipNoteType"] != DBNull.Value)
					{
						item.ShipNoteType = Convert.ToString(dr["ShipNoteType"]);
					}
					if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
					{
						item.StatusName = Convert.ToString(dr["StatusName"]);
					}
					if (dr["StatusBackgroundColor"] != null && dr["StatusBackgroundColor"] != DBNull.Value)
					{
						item.StatusBackgroundColor = Convert.ToString(dr["StatusBackgroundColor"]);
					}
					if (dr["StatusTextColor"] != null && dr["StatusTextColor"] != DBNull.Value)
					{
						item.StatusTextColor = Convert.ToString(dr["StatusTextColor"]);
					}
					if (dr["LastComment"] != null && dr["LastComment"] != DBNull.Value)
					{
						item.LastComment = Convert.ToString(dr["LastComment"]);
					}
					if (dr["DiffTime"] != null && dr["DiffTime"] != DBNull.Value)
					{
						item.DiffTime = Convert.ToString(dr["DiffTime"]);
					}
					if (dr["KetQua1"] != null && dr["KetQua1"] != DBNull.Value)
					{
						item.KetQua1 = Convert.ToString(dr["KetQua1"]);
					}
					if (dr["KetQua2"] != null && dr["KetQua2"] != DBNull.Value)
					{
						item.KetQua2 = Convert.ToString(dr["KetQua2"]);
					}
					if (dr["KetQua3"] != null && dr["KetQua3"] != DBNull.Value)
					{
						item.KetQua3 = Convert.ToString(dr["KetQua3"]);
					}
					if (dr["KetQua4"] != null && dr["KetQua4"] != DBNull.Value)
					{
						item.KetQua4 = Convert.ToString(dr["KetQua4"]);
					}
					if (dr["KetQua5"] != null && dr["KetQua5"] != DBNull.Value)
					{
						item.KetQua5 = Convert.ToString(dr["KetQua5"]);
					}
					if (dr["KetQuaInt1"] != null && dr["KetQuaInt1"] != DBNull.Value)
					{
						item.KetQuaInt1 = Convert.ToInt32(dr["KetQuaInt1"]);
					}
					if (dr["KetQuaInt2"] != null && dr["KetQuaInt2"] != DBNull.Value)
					{
						item.KetQuaInt2 = Convert.ToInt32(dr["KetQuaInt2"]);
					}
					if (dr["KetQuaInt3"] != null && dr["KetQuaInt3"] != DBNull.Value)
					{
						item.KetQuaInt3 = Convert.ToInt32(dr["KetQuaInt3"]);
					}
					if (dr["KetQuaInt4"] != null && dr["KetQuaInt4"] != DBNull.Value)
					{
						item.KetQuaInt4 = Convert.ToInt32(dr["KetQuaInt4"]);
					}
					if (dr["KetQuaInt5"] != null && dr["KetQuaInt5"] != DBNull.Value)
					{
						item.KetQuaInt5 = Convert.ToInt32(dr["KetQuaInt5"]);
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
		/// Lấy danh sách view_GExpBillCus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_GExpBillCus> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GExpBillCus] A "+ condition,  parameters);
				List<view_GExpBillCus> items = new List<view_GExpBillCus>();
				view_GExpBillCus item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GExpBillCus();
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
					if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
					{
						item.BT3Code = Convert.ToString(dr["BT3Code"]);
					}
					if (dr["BT3CodeSub"] != null && dr["BT3CodeSub"] != DBNull.Value)
					{
						item.BT3CodeSub = Convert.ToString(dr["BT3CodeSub"]);
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
					if (dr["FullAddress"] != null && dr["FullAddress"] != DBNull.Value)
					{
						item.FullAddress = Convert.ToString(dr["FullAddress"]);
					}
					if (dr["ProviderName"] != null && dr["ProviderName"] != DBNull.Value)
					{
						item.ProviderName = Convert.ToString(dr["ProviderName"]);
					}
					if (dr["ProviderTypeCode"] != null && dr["ProviderTypeCode"] != DBNull.Value)
					{
						item.ProviderTypeCode = Convert.ToString(dr["ProviderTypeCode"]);
					}
					if (dr["GroupProvider"] != null && dr["GroupProvider"] != DBNull.Value)
					{
						item.GroupProvider = Convert.ToString(dr["GroupProvider"]);
					}
					if (dr["CustomerCode"] != null && dr["CustomerCode"] != DBNull.Value)
					{
						item.CustomerCode = Convert.ToString(dr["CustomerCode"]);
					}
					if (dr["PaymentTypeName"] != null && dr["PaymentTypeName"] != DBNull.Value)
					{
						item.PaymentTypeName = Convert.ToString(dr["PaymentTypeName"]);
					}
					if (dr["ShipNoteType"] != null && dr["ShipNoteType"] != DBNull.Value)
					{
						item.ShipNoteType = Convert.ToString(dr["ShipNoteType"]);
					}
					if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
					{
						item.StatusName = Convert.ToString(dr["StatusName"]);
					}
					if (dr["StatusBackgroundColor"] != null && dr["StatusBackgroundColor"] != DBNull.Value)
					{
						item.StatusBackgroundColor = Convert.ToString(dr["StatusBackgroundColor"]);
					}
					if (dr["StatusTextColor"] != null && dr["StatusTextColor"] != DBNull.Value)
					{
						item.StatusTextColor = Convert.ToString(dr["StatusTextColor"]);
					}
					if (dr["LastComment"] != null && dr["LastComment"] != DBNull.Value)
					{
						item.LastComment = Convert.ToString(dr["LastComment"]);
					}
					if (dr["DiffTime"] != null && dr["DiffTime"] != DBNull.Value)
					{
						item.DiffTime = Convert.ToString(dr["DiffTime"]);
					}
					if (dr["KetQua1"] != null && dr["KetQua1"] != DBNull.Value)
					{
						item.KetQua1 = Convert.ToString(dr["KetQua1"]);
					}
					if (dr["KetQua2"] != null && dr["KetQua2"] != DBNull.Value)
					{
						item.KetQua2 = Convert.ToString(dr["KetQua2"]);
					}
					if (dr["KetQua3"] != null && dr["KetQua3"] != DBNull.Value)
					{
						item.KetQua3 = Convert.ToString(dr["KetQua3"]);
					}
					if (dr["KetQua4"] != null && dr["KetQua4"] != DBNull.Value)
					{
						item.KetQua4 = Convert.ToString(dr["KetQua4"]);
					}
					if (dr["KetQua5"] != null && dr["KetQua5"] != DBNull.Value)
					{
						item.KetQua5 = Convert.ToString(dr["KetQua5"]);
					}
					if (dr["KetQuaInt1"] != null && dr["KetQuaInt1"] != DBNull.Value)
					{
						item.KetQuaInt1 = Convert.ToInt32(dr["KetQuaInt1"]);
					}
					if (dr["KetQuaInt2"] != null && dr["KetQuaInt2"] != DBNull.Value)
					{
						item.KetQuaInt2 = Convert.ToInt32(dr["KetQuaInt2"]);
					}
					if (dr["KetQuaInt3"] != null && dr["KetQuaInt3"] != DBNull.Value)
					{
						item.KetQuaInt3 = Convert.ToInt32(dr["KetQuaInt3"]);
					}
					if (dr["KetQuaInt4"] != null && dr["KetQuaInt4"] != DBNull.Value)
					{
						item.KetQuaInt4 = Convert.ToInt32(dr["KetQuaInt4"]);
					}
					if (dr["KetQuaInt5"] != null && dr["KetQuaInt5"] != DBNull.Value)
					{
						item.KetQuaInt5 = Convert.ToInt32(dr["KetQuaInt5"]);
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

		public List<view_GExpBillCus> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GExpBillCus] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_GExpBillCus] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_GExpBillCus>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_GExpBillCus đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_GExpBillCus GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GExpBillCus] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_GExpBillCus item=new view_GExpBillCus();
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
						if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
						{
							item.BT3Code = Convert.ToString(dr["BT3Code"]);
						}
						if (dr["BT3CodeSub"] != null && dr["BT3CodeSub"] != DBNull.Value)
						{
							item.BT3CodeSub = Convert.ToString(dr["BT3CodeSub"]);
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
						if (dr["FullAddress"] != null && dr["FullAddress"] != DBNull.Value)
						{
							item.FullAddress = Convert.ToString(dr["FullAddress"]);
						}
						if (dr["ProviderName"] != null && dr["ProviderName"] != DBNull.Value)
						{
							item.ProviderName = Convert.ToString(dr["ProviderName"]);
						}
						if (dr["ProviderTypeCode"] != null && dr["ProviderTypeCode"] != DBNull.Value)
						{
							item.ProviderTypeCode = Convert.ToString(dr["ProviderTypeCode"]);
						}
						if (dr["GroupProvider"] != null && dr["GroupProvider"] != DBNull.Value)
						{
							item.GroupProvider = Convert.ToString(dr["GroupProvider"]);
						}
						if (dr["CustomerCode"] != null && dr["CustomerCode"] != DBNull.Value)
						{
							item.CustomerCode = Convert.ToString(dr["CustomerCode"]);
						}
						if (dr["PaymentTypeName"] != null && dr["PaymentTypeName"] != DBNull.Value)
						{
							item.PaymentTypeName = Convert.ToString(dr["PaymentTypeName"]);
						}
						if (dr["ShipNoteType"] != null && dr["ShipNoteType"] != DBNull.Value)
						{
							item.ShipNoteType = Convert.ToString(dr["ShipNoteType"]);
						}
						if (dr["StatusName"] != null && dr["StatusName"] != DBNull.Value)
						{
							item.StatusName = Convert.ToString(dr["StatusName"]);
						}
						if (dr["StatusBackgroundColor"] != null && dr["StatusBackgroundColor"] != DBNull.Value)
						{
							item.StatusBackgroundColor = Convert.ToString(dr["StatusBackgroundColor"]);
						}
						if (dr["StatusTextColor"] != null && dr["StatusTextColor"] != DBNull.Value)
						{
							item.StatusTextColor = Convert.ToString(dr["StatusTextColor"]);
						}
						if (dr["LastComment"] != null && dr["LastComment"] != DBNull.Value)
						{
							item.LastComment = Convert.ToString(dr["LastComment"]);
						}
						if (dr["DiffTime"] != null && dr["DiffTime"] != DBNull.Value)
						{
							item.DiffTime = Convert.ToString(dr["DiffTime"]);
						}
						if (dr["KetQua1"] != null && dr["KetQua1"] != DBNull.Value)
						{
							item.KetQua1 = Convert.ToString(dr["KetQua1"]);
						}
						if (dr["KetQua2"] != null && dr["KetQua2"] != DBNull.Value)
						{
							item.KetQua2 = Convert.ToString(dr["KetQua2"]);
						}
						if (dr["KetQua3"] != null && dr["KetQua3"] != DBNull.Value)
						{
							item.KetQua3 = Convert.ToString(dr["KetQua3"]);
						}
						if (dr["KetQua4"] != null && dr["KetQua4"] != DBNull.Value)
						{
							item.KetQua4 = Convert.ToString(dr["KetQua4"]);
						}
						if (dr["KetQua5"] != null && dr["KetQua5"] != DBNull.Value)
						{
							item.KetQua5 = Convert.ToString(dr["KetQua5"]);
						}
						if (dr["KetQuaInt1"] != null && dr["KetQuaInt1"] != DBNull.Value)
						{
							item.KetQuaInt1 = Convert.ToInt32(dr["KetQuaInt1"]);
						}
						if (dr["KetQuaInt2"] != null && dr["KetQuaInt2"] != DBNull.Value)
						{
							item.KetQuaInt2 = Convert.ToInt32(dr["KetQuaInt2"]);
						}
						if (dr["KetQuaInt3"] != null && dr["KetQuaInt3"] != DBNull.Value)
						{
							item.KetQuaInt3 = Convert.ToInt32(dr["KetQuaInt3"]);
						}
						if (dr["KetQuaInt4"] != null && dr["KetQuaInt4"] != DBNull.Value)
						{
							item.KetQuaInt4 = Convert.ToInt32(dr["KetQuaInt4"]);
						}
						if (dr["KetQuaInt5"] != null && dr["KetQuaInt5"] != DBNull.Value)
						{
							item.KetQuaInt5 = Convert.ToInt32(dr["KetQuaInt5"]);
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

		public view_GExpBillCus GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GExpBillCus] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_GExpBillCus>(ds);
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
