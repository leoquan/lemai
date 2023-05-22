using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewgexpbillghnapi:IVIewgexpbillghnapi
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewgexpbillghnapi(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_GExpBillGHNApi từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpBillGHNApi]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_GExpBillGHNApi từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpBillGHNApi] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_GExpBillGHNApi từ Database
		/// </summary>
		public List<view_GExpBillGHNApi> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpBillGHNApi]");
				List<view_GExpBillGHNApi> items = new List<view_GExpBillGHNApi>();
				view_GExpBillGHNApi item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GExpBillGHNApi();
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["BillWeight"] != null && dr["BillWeight"] != DBNull.Value)
					{
						item.BillWeight = Convert.ToDecimal(dr["BillWeight"]);
					}
					if (dr["Freight"] != null && dr["Freight"] != DBNull.Value)
					{
						item.Freight = Convert.ToDecimal(dr["Freight"]);
					}
					if (dr["COD"] != null && dr["COD"] != DBNull.Value)
					{
						item.COD = Convert.ToDecimal(dr["COD"]);
					}
					if (dr["SendMan"] != null && dr["SendMan"] != DBNull.Value)
					{
						item.SendMan = Convert.ToString(dr["SendMan"]);
					}
					if (dr["SendManPhone"] != null && dr["SendManPhone"] != DBNull.Value)
					{
						item.SendManPhone = Convert.ToString(dr["SendManPhone"]);
					}
					if (dr["SendManAddress"] != null && dr["SendManAddress"] != DBNull.Value)
					{
						item.SendManAddress = Convert.ToString(dr["SendManAddress"]);
					}
					if (dr["AcceptMan"] != null && dr["AcceptMan"] != DBNull.Value)
					{
						item.AcceptMan = Convert.ToString(dr["AcceptMan"]);
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
					if (dr["AcceptProvinceCode"] != null && dr["AcceptProvinceCode"] != DBNull.Value)
					{
						item.AcceptProvinceCode = Convert.ToInt32(dr["AcceptProvinceCode"]);
					}
					if (dr["AcceptProvinceCodeS"] != null && dr["AcceptProvinceCodeS"] != DBNull.Value)
					{
						item.AcceptProvinceCodeS = Convert.ToString(dr["AcceptProvinceCodeS"]);
					}
					if (dr["AcceptDistrict"] != null && dr["AcceptDistrict"] != DBNull.Value)
					{
						item.AcceptDistrict = Convert.ToString(dr["AcceptDistrict"]);
					}
					if (dr["AcceptDistrictCode"] != null && dr["AcceptDistrictCode"] != DBNull.Value)
					{
						item.AcceptDistrictCode = Convert.ToInt32(dr["AcceptDistrictCode"]);
					}
					if (dr["AcceptDistrictCodeS"] != null && dr["AcceptDistrictCodeS"] != DBNull.Value)
					{
						item.AcceptDistrictCodeS = Convert.ToString(dr["AcceptDistrictCodeS"]);
					}
					if (dr["AcceptWard"] != null && dr["AcceptWard"] != DBNull.Value)
					{
						item.AcceptWard = Convert.ToString(dr["AcceptWard"]);
					}
					if (dr["AcceptWardCode"] != null && dr["AcceptWardCode"] != DBNull.Value)
					{
						item.AcceptWardCode = Convert.ToString(dr["AcceptWardCode"]);
					}
					if (dr["AcceptWardCodeS"] != null && dr["AcceptWardCodeS"] != DBNull.Value)
					{
						item.AcceptWardCodeS = Convert.ToString(dr["AcceptWardCodeS"]);
					}
					if (dr["RegisterDate"] != null && dr["RegisterDate"] != DBNull.Value)
					{
						item.RegisterDate = Convert.ToDateTime(dr["RegisterDate"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
					{
						item.BT3Code = Convert.ToString(dr["BT3Code"]);
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
					if (dr["FK_PaymentType"] != null && dr["FK_PaymentType"] != DBNull.Value)
					{
						item.FK_PaymentType = Convert.ToString(dr["FK_PaymentType"]);
					}
					if (dr["FK_ShipType"] != null && dr["FK_ShipType"] != DBNull.Value)
					{
						item.FK_ShipType = Convert.ToString(dr["FK_ShipType"]);
					}
					if (dr["SystemDate"] != null && dr["SystemDate"] != DBNull.Value)
					{
						item.SystemDate = Convert.ToDateTime(dr["SystemDate"]);
					}
					if (dr["BillStatus"] != null && dr["BillStatus"] != DBNull.Value)
					{
						item.BillStatus = Convert.ToInt32(dr["BillStatus"]);
					}
					if (dr["BillProcessStatus"] != null && dr["BillProcessStatus"] != DBNull.Value)
					{
						item.BillProcessStatus = Convert.ToInt32(dr["BillProcessStatus"]);
					}
					if (dr["ProviderTypeCode"] != null && dr["ProviderTypeCode"] != DBNull.Value)
					{
						item.ProviderTypeCode = Convert.ToString(dr["ProviderTypeCode"]);
					}
					if (dr["Token"] != null && dr["Token"] != DBNull.Value)
					{
						item.Token = Convert.ToString(dr["Token"]);
					}
					if (dr["ShopId"] != null && dr["ShopId"] != DBNull.Value)
					{
						item.ShopId = Convert.ToString(dr["ShopId"]);
					}
					if (dr["InitPrice"] != null && dr["InitPrice"] != DBNull.Value)
					{
						item.InitPrice = Convert.ToInt32(dr["InitPrice"]);
					}
					if (dr["InitWeight"] != null && dr["InitWeight"] != DBNull.Value)
					{
						item.InitWeight = Convert.ToInt32(dr["InitWeight"]);
					}
					if (dr["StepWeight"] != null && dr["StepWeight"] != DBNull.Value)
					{
						item.StepWeight = Convert.ToInt32(dr["StepWeight"]);
					}
					if (dr["StepPrice"] != null && dr["StepPrice"] != DBNull.Value)
					{
						item.StepPrice = Convert.ToInt32(dr["StepPrice"]);
					}
					if (dr["WardCode"] != null && dr["WardCode"] != DBNull.Value)
					{
						item.WardCode = Convert.ToString(dr["WardCode"]);
					}
					if (dr["DistrictCode"] != null && dr["DistrictCode"] != DBNull.Value)
					{
						item.DistrictCode = Convert.ToString(dr["DistrictCode"]);
					}
					if (dr["ProvinceCode"] != null && dr["ProvinceCode"] != DBNull.Value)
					{
						item.ProvinceCode = Convert.ToString(dr["ProvinceCode"]);
					}
					if (dr["WardName"] != null && dr["WardName"] != DBNull.Value)
					{
						item.WardName = Convert.ToString(dr["WardName"]);
					}
					if (dr["DistrictName"] != null && dr["DistrictName"] != DBNull.Value)
					{
						item.DistrictName = Convert.ToString(dr["DistrictName"]);
					}
					if (dr["ProvinceName"] != null && dr["ProvinceName"] != DBNull.Value)
					{
						item.ProvinceName = Convert.ToString(dr["ProvinceName"]);
					}
					if (dr["ClientId"] != null && dr["ClientId"] != DBNull.Value)
					{
						item.ClientId = Convert.ToString(dr["ClientId"]);
					}
					if (dr["ServiceId"] != null && dr["ServiceId"] != DBNull.Value)
					{
						item.ServiceId = Convert.ToString(dr["ServiceId"]);
					}
					if (dr["PostBT3Id"] != null && dr["PostBT3Id"] != DBNull.Value)
					{
						item.PostBT3Id = Convert.ToString(dr["PostBT3Id"]);
					}
					if (dr["ShopPhone"] != null && dr["ShopPhone"] != DBNull.Value)
					{
						item.ShopPhone = Convert.ToString(dr["ShopPhone"]);
					}
					if (dr["ShopName"] != null && dr["ShopName"] != DBNull.Value)
					{
						item.ShopName = Convert.ToString(dr["ShopName"]);
					}
					if (dr["Address"] != null && dr["Address"] != DBNull.Value)
					{
						item.Address = Convert.ToString(dr["Address"]);
					}
					if (dr["FK_ProviderAccount"] != null && dr["FK_ProviderAccount"] != DBNull.Value)
					{
						item.FK_ProviderAccount = Convert.ToString(dr["FK_ProviderAccount"]);
					}
					if (dr["PaymentTypeName"] != null && dr["PaymentTypeName"] != DBNull.Value)
					{
						item.PaymentTypeName = Convert.ToString(dr["PaymentTypeName"]);
					}
					if (dr["ShipNoteCodeGHN"] != null && dr["ShipNoteCodeGHN"] != DBNull.Value)
					{
						item.ShipNoteCodeGHN = Convert.ToString(dr["ShipNoteCodeGHN"]);
					}
					if (dr["ShipNoteType"] != null && dr["ShipNoteType"] != DBNull.Value)
					{
						item.ShipNoteType = Convert.ToString(dr["ShipNoteType"]);
					}
					if (dr["InsuranceValue"] != null && dr["InsuranceValue"] != DBNull.Value)
					{
						item.InsuranceValue = Convert.ToInt32(dr["InsuranceValue"]);
					}
					if (dr["RunMode"] != null && dr["RunMode"] != DBNull.Value)
					{
						item.RunMode = Convert.ToInt32(dr["RunMode"]);
					}
					if (dr["ProviderName"] != null && dr["ProviderName"] != DBNull.Value)
					{
						item.ProviderName = Convert.ToString(dr["ProviderName"]);
					}
					if (dr["BT3CodeSub"] != null && dr["BT3CodeSub"] != DBNull.Value)
					{
						item.BT3CodeSub = Convert.ToString(dr["BT3CodeSub"]);
					}
					if (dr["ClientSecrect"] != null && dr["ClientSecrect"] != DBNull.Value)
					{
						item.ClientSecrect = Convert.ToString(dr["ClientSecrect"]);
					}
					if (dr["ExpiresDate"] != null && dr["ExpiresDate"] != DBNull.Value)
					{
						item.ExpiresDate = Convert.ToDateTime(dr["ExpiresDate"]);
					}
					if (dr["IsPickup"] != null && dr["IsPickup"] != DBNull.Value)
					{
						item.IsPickup = Convert.ToBoolean(dr["IsPickup"]);
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
					if (dr["UserApi"] != null && dr["UserApi"] != DBNull.Value)
					{
						item.UserApi = Convert.ToString(dr["UserApi"]);
					}
					if (dr["PassApi"] != null && dr["PassApi"] != DBNull.Value)
					{
						item.PassApi = Convert.ToString(dr["PassApi"]);
					}
					if (dr["LinkCustomerLogin"] != null && dr["LinkCustomerLogin"] != DBNull.Value)
					{
						item.LinkCustomerLogin = Convert.ToString(dr["LinkCustomerLogin"]);
					}
					if (dr["PP_LinkCustomerLogin"] != null && dr["PP_LinkCustomerLogin"] != DBNull.Value)
					{
						item.PP_LinkCustomerLogin = Convert.ToString(dr["PP_LinkCustomerLogin"]);
					}
					if (dr["PP_TrackLink"] != null && dr["PP_TrackLink"] != DBNull.Value)
					{
						item.PP_TrackLink = Convert.ToString(dr["PP_TrackLink"]);
					}
					if (dr["TrackLink"] != null && dr["TrackLink"] != DBNull.Value)
					{
						item.TrackLink = Convert.ToString(dr["TrackLink"]);
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
		/// Lấy danh sách view_GExpBillGHNApi từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_GExpBillGHNApi> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GExpBillGHNApi] A "+ condition,  parameters);
				List<view_GExpBillGHNApi> items = new List<view_GExpBillGHNApi>();
				view_GExpBillGHNApi item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GExpBillGHNApi();
					if (dr["BillCode"] != null && dr["BillCode"] != DBNull.Value)
					{
						item.BillCode = Convert.ToString(dr["BillCode"]);
					}
					if (dr["BillWeight"] != null && dr["BillWeight"] != DBNull.Value)
					{
						item.BillWeight = Convert.ToDecimal(dr["BillWeight"]);
					}
					if (dr["Freight"] != null && dr["Freight"] != DBNull.Value)
					{
						item.Freight = Convert.ToDecimal(dr["Freight"]);
					}
					if (dr["COD"] != null && dr["COD"] != DBNull.Value)
					{
						item.COD = Convert.ToDecimal(dr["COD"]);
					}
					if (dr["SendMan"] != null && dr["SendMan"] != DBNull.Value)
					{
						item.SendMan = Convert.ToString(dr["SendMan"]);
					}
					if (dr["SendManPhone"] != null && dr["SendManPhone"] != DBNull.Value)
					{
						item.SendManPhone = Convert.ToString(dr["SendManPhone"]);
					}
					if (dr["SendManAddress"] != null && dr["SendManAddress"] != DBNull.Value)
					{
						item.SendManAddress = Convert.ToString(dr["SendManAddress"]);
					}
					if (dr["AcceptMan"] != null && dr["AcceptMan"] != DBNull.Value)
					{
						item.AcceptMan = Convert.ToString(dr["AcceptMan"]);
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
					if (dr["AcceptProvinceCode"] != null && dr["AcceptProvinceCode"] != DBNull.Value)
					{
						item.AcceptProvinceCode = Convert.ToInt32(dr["AcceptProvinceCode"]);
					}
					if (dr["AcceptProvinceCodeS"] != null && dr["AcceptProvinceCodeS"] != DBNull.Value)
					{
						item.AcceptProvinceCodeS = Convert.ToString(dr["AcceptProvinceCodeS"]);
					}
					if (dr["AcceptDistrict"] != null && dr["AcceptDistrict"] != DBNull.Value)
					{
						item.AcceptDistrict = Convert.ToString(dr["AcceptDistrict"]);
					}
					if (dr["AcceptDistrictCode"] != null && dr["AcceptDistrictCode"] != DBNull.Value)
					{
						item.AcceptDistrictCode = Convert.ToInt32(dr["AcceptDistrictCode"]);
					}
					if (dr["AcceptDistrictCodeS"] != null && dr["AcceptDistrictCodeS"] != DBNull.Value)
					{
						item.AcceptDistrictCodeS = Convert.ToString(dr["AcceptDistrictCodeS"]);
					}
					if (dr["AcceptWard"] != null && dr["AcceptWard"] != DBNull.Value)
					{
						item.AcceptWard = Convert.ToString(dr["AcceptWard"]);
					}
					if (dr["AcceptWardCode"] != null && dr["AcceptWardCode"] != DBNull.Value)
					{
						item.AcceptWardCode = Convert.ToString(dr["AcceptWardCode"]);
					}
					if (dr["AcceptWardCodeS"] != null && dr["AcceptWardCodeS"] != DBNull.Value)
					{
						item.AcceptWardCodeS = Convert.ToString(dr["AcceptWardCodeS"]);
					}
					if (dr["RegisterDate"] != null && dr["RegisterDate"] != DBNull.Value)
					{
						item.RegisterDate = Convert.ToDateTime(dr["RegisterDate"]);
					}
					if (dr["Note"] != null && dr["Note"] != DBNull.Value)
					{
						item.Note = Convert.ToString(dr["Note"]);
					}
					if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
					{
						item.BT3Code = Convert.ToString(dr["BT3Code"]);
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
					if (dr["FK_PaymentType"] != null && dr["FK_PaymentType"] != DBNull.Value)
					{
						item.FK_PaymentType = Convert.ToString(dr["FK_PaymentType"]);
					}
					if (dr["FK_ShipType"] != null && dr["FK_ShipType"] != DBNull.Value)
					{
						item.FK_ShipType = Convert.ToString(dr["FK_ShipType"]);
					}
					if (dr["SystemDate"] != null && dr["SystemDate"] != DBNull.Value)
					{
						item.SystemDate = Convert.ToDateTime(dr["SystemDate"]);
					}
					if (dr["BillStatus"] != null && dr["BillStatus"] != DBNull.Value)
					{
						item.BillStatus = Convert.ToInt32(dr["BillStatus"]);
					}
					if (dr["BillProcessStatus"] != null && dr["BillProcessStatus"] != DBNull.Value)
					{
						item.BillProcessStatus = Convert.ToInt32(dr["BillProcessStatus"]);
					}
					if (dr["ProviderTypeCode"] != null && dr["ProviderTypeCode"] != DBNull.Value)
					{
						item.ProviderTypeCode = Convert.ToString(dr["ProviderTypeCode"]);
					}
					if (dr["Token"] != null && dr["Token"] != DBNull.Value)
					{
						item.Token = Convert.ToString(dr["Token"]);
					}
					if (dr["ShopId"] != null && dr["ShopId"] != DBNull.Value)
					{
						item.ShopId = Convert.ToString(dr["ShopId"]);
					}
					if (dr["InitPrice"] != null && dr["InitPrice"] != DBNull.Value)
					{
						item.InitPrice = Convert.ToInt32(dr["InitPrice"]);
					}
					if (dr["InitWeight"] != null && dr["InitWeight"] != DBNull.Value)
					{
						item.InitWeight = Convert.ToInt32(dr["InitWeight"]);
					}
					if (dr["StepWeight"] != null && dr["StepWeight"] != DBNull.Value)
					{
						item.StepWeight = Convert.ToInt32(dr["StepWeight"]);
					}
					if (dr["StepPrice"] != null && dr["StepPrice"] != DBNull.Value)
					{
						item.StepPrice = Convert.ToInt32(dr["StepPrice"]);
					}
					if (dr["WardCode"] != null && dr["WardCode"] != DBNull.Value)
					{
						item.WardCode = Convert.ToString(dr["WardCode"]);
					}
					if (dr["DistrictCode"] != null && dr["DistrictCode"] != DBNull.Value)
					{
						item.DistrictCode = Convert.ToString(dr["DistrictCode"]);
					}
					if (dr["ProvinceCode"] != null && dr["ProvinceCode"] != DBNull.Value)
					{
						item.ProvinceCode = Convert.ToString(dr["ProvinceCode"]);
					}
					if (dr["WardName"] != null && dr["WardName"] != DBNull.Value)
					{
						item.WardName = Convert.ToString(dr["WardName"]);
					}
					if (dr["DistrictName"] != null && dr["DistrictName"] != DBNull.Value)
					{
						item.DistrictName = Convert.ToString(dr["DistrictName"]);
					}
					if (dr["ProvinceName"] != null && dr["ProvinceName"] != DBNull.Value)
					{
						item.ProvinceName = Convert.ToString(dr["ProvinceName"]);
					}
					if (dr["ClientId"] != null && dr["ClientId"] != DBNull.Value)
					{
						item.ClientId = Convert.ToString(dr["ClientId"]);
					}
					if (dr["ServiceId"] != null && dr["ServiceId"] != DBNull.Value)
					{
						item.ServiceId = Convert.ToString(dr["ServiceId"]);
					}
					if (dr["PostBT3Id"] != null && dr["PostBT3Id"] != DBNull.Value)
					{
						item.PostBT3Id = Convert.ToString(dr["PostBT3Id"]);
					}
					if (dr["ShopPhone"] != null && dr["ShopPhone"] != DBNull.Value)
					{
						item.ShopPhone = Convert.ToString(dr["ShopPhone"]);
					}
					if (dr["ShopName"] != null && dr["ShopName"] != DBNull.Value)
					{
						item.ShopName = Convert.ToString(dr["ShopName"]);
					}
					if (dr["Address"] != null && dr["Address"] != DBNull.Value)
					{
						item.Address = Convert.ToString(dr["Address"]);
					}
					if (dr["FK_ProviderAccount"] != null && dr["FK_ProviderAccount"] != DBNull.Value)
					{
						item.FK_ProviderAccount = Convert.ToString(dr["FK_ProviderAccount"]);
					}
					if (dr["PaymentTypeName"] != null && dr["PaymentTypeName"] != DBNull.Value)
					{
						item.PaymentTypeName = Convert.ToString(dr["PaymentTypeName"]);
					}
					if (dr["ShipNoteCodeGHN"] != null && dr["ShipNoteCodeGHN"] != DBNull.Value)
					{
						item.ShipNoteCodeGHN = Convert.ToString(dr["ShipNoteCodeGHN"]);
					}
					if (dr["ShipNoteType"] != null && dr["ShipNoteType"] != DBNull.Value)
					{
						item.ShipNoteType = Convert.ToString(dr["ShipNoteType"]);
					}
					if (dr["InsuranceValue"] != null && dr["InsuranceValue"] != DBNull.Value)
					{
						item.InsuranceValue = Convert.ToInt32(dr["InsuranceValue"]);
					}
					if (dr["RunMode"] != null && dr["RunMode"] != DBNull.Value)
					{
						item.RunMode = Convert.ToInt32(dr["RunMode"]);
					}
					if (dr["ProviderName"] != null && dr["ProviderName"] != DBNull.Value)
					{
						item.ProviderName = Convert.ToString(dr["ProviderName"]);
					}
					if (dr["BT3CodeSub"] != null && dr["BT3CodeSub"] != DBNull.Value)
					{
						item.BT3CodeSub = Convert.ToString(dr["BT3CodeSub"]);
					}
					if (dr["ClientSecrect"] != null && dr["ClientSecrect"] != DBNull.Value)
					{
						item.ClientSecrect = Convert.ToString(dr["ClientSecrect"]);
					}
					if (dr["ExpiresDate"] != null && dr["ExpiresDate"] != DBNull.Value)
					{
						item.ExpiresDate = Convert.ToDateTime(dr["ExpiresDate"]);
					}
					if (dr["IsPickup"] != null && dr["IsPickup"] != DBNull.Value)
					{
						item.IsPickup = Convert.ToBoolean(dr["IsPickup"]);
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
					if (dr["UserApi"] != null && dr["UserApi"] != DBNull.Value)
					{
						item.UserApi = Convert.ToString(dr["UserApi"]);
					}
					if (dr["PassApi"] != null && dr["PassApi"] != DBNull.Value)
					{
						item.PassApi = Convert.ToString(dr["PassApi"]);
					}
					if (dr["LinkCustomerLogin"] != null && dr["LinkCustomerLogin"] != DBNull.Value)
					{
						item.LinkCustomerLogin = Convert.ToString(dr["LinkCustomerLogin"]);
					}
					if (dr["PP_LinkCustomerLogin"] != null && dr["PP_LinkCustomerLogin"] != DBNull.Value)
					{
						item.PP_LinkCustomerLogin = Convert.ToString(dr["PP_LinkCustomerLogin"]);
					}
					if (dr["PP_TrackLink"] != null && dr["PP_TrackLink"] != DBNull.Value)
					{
						item.PP_TrackLink = Convert.ToString(dr["PP_TrackLink"]);
					}
					if (dr["TrackLink"] != null && dr["TrackLink"] != DBNull.Value)
					{
						item.TrackLink = Convert.ToString(dr["TrackLink"]);
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

		public List<view_GExpBillGHNApi> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GExpBillGHNApi] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_GExpBillGHNApi] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_GExpBillGHNApi>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_GExpBillGHNApi đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_GExpBillGHNApi GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GExpBillGHNApi] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_GExpBillGHNApi item=new view_GExpBillGHNApi();
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
						if (dr["Freight"] != null && dr["Freight"] != DBNull.Value)
						{
							item.Freight = Convert.ToDecimal(dr["Freight"]);
						}
						if (dr["COD"] != null && dr["COD"] != DBNull.Value)
						{
							item.COD = Convert.ToDecimal(dr["COD"]);
						}
						if (dr["SendMan"] != null && dr["SendMan"] != DBNull.Value)
						{
							item.SendMan = Convert.ToString(dr["SendMan"]);
						}
						if (dr["SendManPhone"] != null && dr["SendManPhone"] != DBNull.Value)
						{
							item.SendManPhone = Convert.ToString(dr["SendManPhone"]);
						}
						if (dr["SendManAddress"] != null && dr["SendManAddress"] != DBNull.Value)
						{
							item.SendManAddress = Convert.ToString(dr["SendManAddress"]);
						}
						if (dr["AcceptMan"] != null && dr["AcceptMan"] != DBNull.Value)
						{
							item.AcceptMan = Convert.ToString(dr["AcceptMan"]);
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
						if (dr["AcceptProvinceCode"] != null && dr["AcceptProvinceCode"] != DBNull.Value)
						{
							item.AcceptProvinceCode = Convert.ToInt32(dr["AcceptProvinceCode"]);
						}
						if (dr["AcceptProvinceCodeS"] != null && dr["AcceptProvinceCodeS"] != DBNull.Value)
						{
							item.AcceptProvinceCodeS = Convert.ToString(dr["AcceptProvinceCodeS"]);
						}
						if (dr["AcceptDistrict"] != null && dr["AcceptDistrict"] != DBNull.Value)
						{
							item.AcceptDistrict = Convert.ToString(dr["AcceptDistrict"]);
						}
						if (dr["AcceptDistrictCode"] != null && dr["AcceptDistrictCode"] != DBNull.Value)
						{
							item.AcceptDistrictCode = Convert.ToInt32(dr["AcceptDistrictCode"]);
						}
						if (dr["AcceptDistrictCodeS"] != null && dr["AcceptDistrictCodeS"] != DBNull.Value)
						{
							item.AcceptDistrictCodeS = Convert.ToString(dr["AcceptDistrictCodeS"]);
						}
						if (dr["AcceptWard"] != null && dr["AcceptWard"] != DBNull.Value)
						{
							item.AcceptWard = Convert.ToString(dr["AcceptWard"]);
						}
						if (dr["AcceptWardCode"] != null && dr["AcceptWardCode"] != DBNull.Value)
						{
							item.AcceptWardCode = Convert.ToString(dr["AcceptWardCode"]);
						}
						if (dr["AcceptWardCodeS"] != null && dr["AcceptWardCodeS"] != DBNull.Value)
						{
							item.AcceptWardCodeS = Convert.ToString(dr["AcceptWardCodeS"]);
						}
						if (dr["RegisterDate"] != null && dr["RegisterDate"] != DBNull.Value)
						{
							item.RegisterDate = Convert.ToDateTime(dr["RegisterDate"]);
						}
						if (dr["Note"] != null && dr["Note"] != DBNull.Value)
						{
							item.Note = Convert.ToString(dr["Note"]);
						}
						if (dr["BT3Code"] != null && dr["BT3Code"] != DBNull.Value)
						{
							item.BT3Code = Convert.ToString(dr["BT3Code"]);
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
						if (dr["FK_PaymentType"] != null && dr["FK_PaymentType"] != DBNull.Value)
						{
							item.FK_PaymentType = Convert.ToString(dr["FK_PaymentType"]);
						}
						if (dr["FK_ShipType"] != null && dr["FK_ShipType"] != DBNull.Value)
						{
							item.FK_ShipType = Convert.ToString(dr["FK_ShipType"]);
						}
						if (dr["SystemDate"] != null && dr["SystemDate"] != DBNull.Value)
						{
							item.SystemDate = Convert.ToDateTime(dr["SystemDate"]);
						}
						if (dr["BillStatus"] != null && dr["BillStatus"] != DBNull.Value)
						{
							item.BillStatus = Convert.ToInt32(dr["BillStatus"]);
						}
						if (dr["BillProcessStatus"] != null && dr["BillProcessStatus"] != DBNull.Value)
						{
							item.BillProcessStatus = Convert.ToInt32(dr["BillProcessStatus"]);
						}
						if (dr["ProviderTypeCode"] != null && dr["ProviderTypeCode"] != DBNull.Value)
						{
							item.ProviderTypeCode = Convert.ToString(dr["ProviderTypeCode"]);
						}
						if (dr["Token"] != null && dr["Token"] != DBNull.Value)
						{
							item.Token = Convert.ToString(dr["Token"]);
						}
						if (dr["ShopId"] != null && dr["ShopId"] != DBNull.Value)
						{
							item.ShopId = Convert.ToString(dr["ShopId"]);
						}
						if (dr["InitPrice"] != null && dr["InitPrice"] != DBNull.Value)
						{
							item.InitPrice = Convert.ToInt32(dr["InitPrice"]);
						}
						if (dr["InitWeight"] != null && dr["InitWeight"] != DBNull.Value)
						{
							item.InitWeight = Convert.ToInt32(dr["InitWeight"]);
						}
						if (dr["StepWeight"] != null && dr["StepWeight"] != DBNull.Value)
						{
							item.StepWeight = Convert.ToInt32(dr["StepWeight"]);
						}
						if (dr["StepPrice"] != null && dr["StepPrice"] != DBNull.Value)
						{
							item.StepPrice = Convert.ToInt32(dr["StepPrice"]);
						}
						if (dr["WardCode"] != null && dr["WardCode"] != DBNull.Value)
						{
							item.WardCode = Convert.ToString(dr["WardCode"]);
						}
						if (dr["DistrictCode"] != null && dr["DistrictCode"] != DBNull.Value)
						{
							item.DistrictCode = Convert.ToString(dr["DistrictCode"]);
						}
						if (dr["ProvinceCode"] != null && dr["ProvinceCode"] != DBNull.Value)
						{
							item.ProvinceCode = Convert.ToString(dr["ProvinceCode"]);
						}
						if (dr["WardName"] != null && dr["WardName"] != DBNull.Value)
						{
							item.WardName = Convert.ToString(dr["WardName"]);
						}
						if (dr["DistrictName"] != null && dr["DistrictName"] != DBNull.Value)
						{
							item.DistrictName = Convert.ToString(dr["DistrictName"]);
						}
						if (dr["ProvinceName"] != null && dr["ProvinceName"] != DBNull.Value)
						{
							item.ProvinceName = Convert.ToString(dr["ProvinceName"]);
						}
						if (dr["ClientId"] != null && dr["ClientId"] != DBNull.Value)
						{
							item.ClientId = Convert.ToString(dr["ClientId"]);
						}
						if (dr["ServiceId"] != null && dr["ServiceId"] != DBNull.Value)
						{
							item.ServiceId = Convert.ToString(dr["ServiceId"]);
						}
						if (dr["PostBT3Id"] != null && dr["PostBT3Id"] != DBNull.Value)
						{
							item.PostBT3Id = Convert.ToString(dr["PostBT3Id"]);
						}
						if (dr["ShopPhone"] != null && dr["ShopPhone"] != DBNull.Value)
						{
							item.ShopPhone = Convert.ToString(dr["ShopPhone"]);
						}
						if (dr["ShopName"] != null && dr["ShopName"] != DBNull.Value)
						{
							item.ShopName = Convert.ToString(dr["ShopName"]);
						}
						if (dr["Address"] != null && dr["Address"] != DBNull.Value)
						{
							item.Address = Convert.ToString(dr["Address"]);
						}
						if (dr["FK_ProviderAccount"] != null && dr["FK_ProviderAccount"] != DBNull.Value)
						{
							item.FK_ProviderAccount = Convert.ToString(dr["FK_ProviderAccount"]);
						}
						if (dr["PaymentTypeName"] != null && dr["PaymentTypeName"] != DBNull.Value)
						{
							item.PaymentTypeName = Convert.ToString(dr["PaymentTypeName"]);
						}
						if (dr["ShipNoteCodeGHN"] != null && dr["ShipNoteCodeGHN"] != DBNull.Value)
						{
							item.ShipNoteCodeGHN = Convert.ToString(dr["ShipNoteCodeGHN"]);
						}
						if (dr["ShipNoteType"] != null && dr["ShipNoteType"] != DBNull.Value)
						{
							item.ShipNoteType = Convert.ToString(dr["ShipNoteType"]);
						}
						if (dr["InsuranceValue"] != null && dr["InsuranceValue"] != DBNull.Value)
						{
							item.InsuranceValue = Convert.ToInt32(dr["InsuranceValue"]);
						}
						if (dr["RunMode"] != null && dr["RunMode"] != DBNull.Value)
						{
							item.RunMode = Convert.ToInt32(dr["RunMode"]);
						}
						if (dr["ProviderName"] != null && dr["ProviderName"] != DBNull.Value)
						{
							item.ProviderName = Convert.ToString(dr["ProviderName"]);
						}
						if (dr["BT3CodeSub"] != null && dr["BT3CodeSub"] != DBNull.Value)
						{
							item.BT3CodeSub = Convert.ToString(dr["BT3CodeSub"]);
						}
						if (dr["ClientSecrect"] != null && dr["ClientSecrect"] != DBNull.Value)
						{
							item.ClientSecrect = Convert.ToString(dr["ClientSecrect"]);
						}
						if (dr["ExpiresDate"] != null && dr["ExpiresDate"] != DBNull.Value)
						{
							item.ExpiresDate = Convert.ToDateTime(dr["ExpiresDate"]);
						}
						if (dr["IsPickup"] != null && dr["IsPickup"] != DBNull.Value)
						{
							item.IsPickup = Convert.ToBoolean(dr["IsPickup"]);
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
						if (dr["UserApi"] != null && dr["UserApi"] != DBNull.Value)
						{
							item.UserApi = Convert.ToString(dr["UserApi"]);
						}
						if (dr["PassApi"] != null && dr["PassApi"] != DBNull.Value)
						{
							item.PassApi = Convert.ToString(dr["PassApi"]);
						}
						if (dr["LinkCustomerLogin"] != null && dr["LinkCustomerLogin"] != DBNull.Value)
						{
							item.LinkCustomerLogin = Convert.ToString(dr["LinkCustomerLogin"]);
						}
						if (dr["PP_LinkCustomerLogin"] != null && dr["PP_LinkCustomerLogin"] != DBNull.Value)
						{
							item.PP_LinkCustomerLogin = Convert.ToString(dr["PP_LinkCustomerLogin"]);
						}
						if (dr["PP_TrackLink"] != null && dr["PP_TrackLink"] != DBNull.Value)
						{
							item.PP_TrackLink = Convert.ToString(dr["PP_TrackLink"]);
						}
						if (dr["TrackLink"] != null && dr["TrackLink"] != DBNull.Value)
						{
							item.TrackLink = Convert.ToString(dr["TrackLink"]);
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

		public view_GExpBillGHNApi GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GExpBillGHNApi] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_GExpBillGHNApi>(ds);
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
