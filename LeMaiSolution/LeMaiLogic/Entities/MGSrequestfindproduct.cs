using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGSrequestfindproduct:IGSrequestfindproduct
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGSrequestfindproduct(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GsRequestFindProduct từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GsRequestFindProduct]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GsRequestFindProduct từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GsRequestFindProduct] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GsRequestFindProduct từ Database
		/// </summary>
		public List<GsRequestFindProduct> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GsRequestFindProduct]");
				List<GsRequestFindProduct> items = new List<GsRequestFindProduct>();
				GsRequestFindProduct item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GsRequestFindProduct();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["RequestCode"] != null && dr["RequestCode"] != DBNull.Value)
					{
						item.RequestCode = Convert.ToString(dr["RequestCode"]);
					}
					if (dr["ProductName"] != null && dr["ProductName"] != DBNull.Value)
					{
						item.ProductName = Convert.ToString(dr["ProductName"]);
					}
					if (dr["ProductNameUnsign"] != null && dr["ProductNameUnsign"] != DBNull.Value)
					{
						item.ProductNameUnsign = Convert.ToString(dr["ProductNameUnsign"]);
					}
					if (dr["RequestImage"] != null && dr["RequestImage"] != DBNull.Value)
					{
						item.RequestImage = Convert.ToString(dr["RequestImage"]);
					}
					if (dr["BeginRequestDate"] != null && dr["BeginRequestDate"] != DBNull.Value)
					{
						item.BeginRequestDate = Convert.ToDateTime(dr["BeginRequestDate"]);
					}
					if (dr["FK_InventoryCategory"] != null && dr["FK_InventoryCategory"] != DBNull.Value)
					{
						item.FK_InventoryCategory = Convert.ToString(dr["FK_InventoryCategory"]);
					}
					if (dr["Fk_Provine"] != null && dr["Fk_Provine"] != DBNull.Value)
					{
						item.Fk_Provine = Convert.ToString(dr["Fk_Provine"]);
					}
					if (dr["DeliveryAddress"] != null && dr["DeliveryAddress"] != DBNull.Value)
					{
						item.DeliveryAddress = Convert.ToString(dr["DeliveryAddress"]);
					}
					if (dr["Description"] != null && dr["Description"] != DBNull.Value)
					{
						item.Description = Convert.ToString(dr["Description"]);
					}
					if (dr["Quantity"] != null && dr["Quantity"] != DBNull.Value)
					{
						item.Quantity = Convert.ToInt32(dr["Quantity"]);
					}
					if (dr["Fk_Unit"] != null && dr["Fk_Unit"] != DBNull.Value)
					{
						item.Fk_Unit = Convert.ToString(dr["Fk_Unit"]);
					}
					if (dr["Packing"] != null && dr["Packing"] != DBNull.Value)
					{
						item.Packing = Convert.ToString(dr["Packing"]);
					}
					if (dr["QuantityOfPacking"] != null && dr["QuantityOfPacking"] != DBNull.Value)
					{
						item.QuantityOfPacking = Convert.ToDecimal(dr["QuantityOfPacking"]);
					}
					if (dr["WarrantyMonth"] != null && dr["WarrantyMonth"] != DBNull.Value)
					{
						item.WarrantyMonth = Convert.ToInt32(dr["WarrantyMonth"]);
					}
					if (dr["TradeMark"] != null && dr["TradeMark"] != DBNull.Value)
					{
						item.TradeMark = Convert.ToString(dr["TradeMark"]);
					}
					if (dr["DesignTradeMarkFile"] != null && dr["DesignTradeMarkFile"] != DBNull.Value)
					{
						item.DesignTradeMarkFile = Convert.ToString(dr["DesignTradeMarkFile"]);
					}
					if (dr["AdditionalLabel"] != null && dr["AdditionalLabel"] != DBNull.Value)
					{
						item.AdditionalLabel = Convert.ToString(dr["AdditionalLabel"]);
					}
					if (dr["EndRequestDate"] != null && dr["EndRequestDate"] != DBNull.Value)
					{
						item.EndRequestDate = Convert.ToDateTime(dr["EndRequestDate"]);
					}
					if (dr["RequestNote"] != null && dr["RequestNote"] != DBNull.Value)
					{
						item.RequestNote = Convert.ToString(dr["RequestNote"]);
					}
					if (dr["IsCustomerRequest"] != null && dr["IsCustomerRequest"] != DBNull.Value)
					{
						item.IsCustomerRequest = Convert.ToBoolean(dr["IsCustomerRequest"]);
					}
					if (dr["Fk_UserSaleRequest"] != null && dr["Fk_UserSaleRequest"] != DBNull.Value)
					{
						item.Fk_UserSaleRequest = Convert.ToString(dr["Fk_UserSaleRequest"]);
					}
					if (dr["HeightX"] != null && dr["HeightX"] != DBNull.Value)
					{
						item.HeightX = Convert.ToInt32(dr["HeightX"]);
					}
					if (dr["WidthY"] != null && dr["WidthY"] != DBNull.Value)
					{
						item.WidthY = Convert.ToInt32(dr["WidthY"]);
					}
					if (dr["ThicknessZ"] != null && dr["ThicknessZ"] != DBNull.Value)
					{
						item.ThicknessZ = Convert.ToInt32(dr["ThicknessZ"]);
					}
					if (dr["Weight"] != null && dr["Weight"] != DBNull.Value)
					{
						item.Weight = Convert.ToDecimal(dr["Weight"]);
					}
					if (dr["Fk_WeightUnit"] != null && dr["Fk_WeightUnit"] != DBNull.Value)
					{
						item.Fk_WeightUnit = Convert.ToString(dr["Fk_WeightUnit"]);
					}
					if (dr["Fk_Status"] != null && dr["Fk_Status"] != DBNull.Value)
					{
						item.Fk_Status = Convert.ToInt32(dr["Fk_Status"]);
					}
					if (dr["Fk_UserRequestApprover"] != null && dr["Fk_UserRequestApprover"] != DBNull.Value)
					{
						item.Fk_UserRequestApprover = Convert.ToString(dr["Fk_UserRequestApprover"]);
					}
					if (dr["UserRequestApproverDate"] != null && dr["UserRequestApproverDate"] != DBNull.Value)
					{
						item.UserRequestApproverDate = Convert.ToDateTime(dr["UserRequestApproverDate"]);
					}
					if (dr["RequestApproverNote"] != null && dr["RequestApproverNote"] != DBNull.Value)
					{
						item.RequestApproverNote = Convert.ToString(dr["RequestApproverNote"]);
					}
					if (dr["Fk_UserSourceProcess"] != null && dr["Fk_UserSourceProcess"] != DBNull.Value)
					{
						item.Fk_UserSourceProcess = Convert.ToString(dr["Fk_UserSourceProcess"]);
					}
					if (dr["SourceProcessDate"] != null && dr["SourceProcessDate"] != DBNull.Value)
					{
						item.SourceProcessDate = Convert.ToDateTime(dr["SourceProcessDate"]);
					}
					if (dr["Fk_UserSourceApprover"] != null && dr["Fk_UserSourceApprover"] != DBNull.Value)
					{
						item.Fk_UserSourceApprover = Convert.ToString(dr["Fk_UserSourceApprover"]);
					}
					if (dr["SourceApproverDate"] != null && dr["SourceApproverDate"] != DBNull.Value)
					{
						item.SourceApproverDate = Convert.ToDateTime(dr["SourceApproverDate"]);
					}
					if (dr["SourceApproverNote"] != null && dr["SourceApproverNote"] != DBNull.Value)
					{
						item.SourceApproverNote = Convert.ToString(dr["SourceApproverNote"]);
					}
					if (dr["Fk_UserSourceEstimator"] != null && dr["Fk_UserSourceEstimator"] != DBNull.Value)
					{
						item.Fk_UserSourceEstimator = Convert.ToString(dr["Fk_UserSourceEstimator"]);
					}
					if (dr["SourceEstimator"] != null && dr["SourceEstimator"] != DBNull.Value)
					{
						item.SourceEstimator = Convert.ToDateTime(dr["SourceEstimator"]);
					}
					if (dr["SourceEstimatorNote"] != null && dr["SourceEstimatorNote"] != DBNull.Value)
					{
						item.SourceEstimatorNote = Convert.ToString(dr["SourceEstimatorNote"]);
					}
					if (dr["IsLCOFDone"] != null && dr["IsLCOFDone"] != DBNull.Value)
					{
						item.IsLCOFDone = Convert.ToBoolean(dr["IsLCOFDone"]);
					}
					if (dr["Fk_UserLCOFProcess"] != null && dr["Fk_UserLCOFProcess"] != DBNull.Value)
					{
						item.Fk_UserLCOFProcess = Convert.ToString(dr["Fk_UserLCOFProcess"]);
					}
					if (dr["LCOFDate"] != null && dr["LCOFDate"] != DBNull.Value)
					{
						item.LCOFDate = Convert.ToDateTime(dr["LCOFDate"]);
					}
					if (dr["IsCustomsDone"] != null && dr["IsCustomsDone"] != DBNull.Value)
					{
						item.IsCustomsDone = Convert.ToBoolean(dr["IsCustomsDone"]);
					}
					if (dr["Fk_UserCustomsProcess"] != null && dr["Fk_UserCustomsProcess"] != DBNull.Value)
					{
						item.Fk_UserCustomsProcess = Convert.ToString(dr["Fk_UserCustomsProcess"]);
					}
					if (dr["CustomsProcessDate"] != null && dr["CustomsProcessDate"] != DBNull.Value)
					{
						item.CustomsProcessDate = Convert.ToDateTime(dr["CustomsProcessDate"]);
					}
					if (dr["IsTruckingDone"] != null && dr["IsTruckingDone"] != DBNull.Value)
					{
						item.IsTruckingDone = Convert.ToBoolean(dr["IsTruckingDone"]);
					}
					if (dr["Fk_UserTruckingProcess"] != null && dr["Fk_UserTruckingProcess"] != DBNull.Value)
					{
						item.Fk_UserTruckingProcess = Convert.ToString(dr["Fk_UserTruckingProcess"]);
					}
					if (dr["TruckingProcessDate"] != null && dr["TruckingProcessDate"] != DBNull.Value)
					{
						item.TruckingProcessDate = Convert.ToDateTime(dr["TruckingProcessDate"]);
					}
					if (dr["Fk_OPApprover"] != null && dr["Fk_OPApprover"] != DBNull.Value)
					{
						item.Fk_OPApprover = Convert.ToString(dr["Fk_OPApprover"]);
					}
					if (dr["OPApproverDate"] != null && dr["OPApproverDate"] != DBNull.Value)
					{
						item.OPApproverDate = Convert.ToDateTime(dr["OPApproverDate"]);
					}
					if (dr["OPApproverNote"] != null && dr["OPApproverNote"] != DBNull.Value)
					{
						item.OPApproverNote = Convert.ToString(dr["OPApproverNote"]);
					}
					if (dr["IsApproverLCOF"] != null && dr["IsApproverLCOF"] != DBNull.Value)
					{
						item.IsApproverLCOF = Convert.ToBoolean(dr["IsApproverLCOF"]);
					}
					if (dr["IsApproverCustoms"] != null && dr["IsApproverCustoms"] != DBNull.Value)
					{
						item.IsApproverCustoms = Convert.ToBoolean(dr["IsApproverCustoms"]);
					}
					if (dr["IsApproverTrucking"] != null && dr["IsApproverTrucking"] != DBNull.Value)
					{
						item.IsApproverTrucking = Convert.ToBoolean(dr["IsApproverTrucking"]);
					}
					if (dr["Fk_OPEstimator"] != null && dr["Fk_OPEstimator"] != DBNull.Value)
					{
						item.Fk_OPEstimator = Convert.ToString(dr["Fk_OPEstimator"]);
					}
					if (dr["OPEstimatorDate"] != null && dr["OPEstimatorDate"] != DBNull.Value)
					{
						item.OPEstimatorDate = Convert.ToDateTime(dr["OPEstimatorDate"]);
					}
					if (dr["OPEstimatorNote"] != null && dr["OPEstimatorNote"] != DBNull.Value)
					{
						item.OPEstimatorNote = Convert.ToString(dr["OPEstimatorNote"]);
					}
					if (dr["IsEstimatorLCOF"] != null && dr["IsEstimatorLCOF"] != DBNull.Value)
					{
						item.IsEstimatorLCOF = Convert.ToBoolean(dr["IsEstimatorLCOF"]);
					}
					if (dr["IsEstimatorCustoms"] != null && dr["IsEstimatorCustoms"] != DBNull.Value)
					{
						item.IsEstimatorCustoms = Convert.ToBoolean(dr["IsEstimatorCustoms"]);
					}
					if (dr["IsEstimatorTrucking"] != null && dr["IsEstimatorTrucking"] != DBNull.Value)
					{
						item.IsEstimatorTrucking = Convert.ToBoolean(dr["IsEstimatorTrucking"]);
					}
					if (dr["DemoTransferCost"] != null && dr["DemoTransferCost"] != DBNull.Value)
					{
						item.DemoTransferCost = Convert.ToDecimal(dr["DemoTransferCost"]);
					}
					if (dr["DemoCost"] != null && dr["DemoCost"] != DBNull.Value)
					{
						item.DemoCost = Convert.ToDecimal(dr["DemoCost"]);
					}
					if (dr["MoqTransferCost"] != null && dr["MoqTransferCost"] != DBNull.Value)
					{
						item.MoqTransferCost = Convert.ToDecimal(dr["MoqTransferCost"]);
					}
					if (dr["MoqCost"] != null && dr["MoqCost"] != DBNull.Value)
					{
						item.MoqCost = Convert.ToDecimal(dr["MoqCost"]);
					}
					if (dr["DC20TransferCost"] != null && dr["DC20TransferCost"] != DBNull.Value)
					{
						item.DC20TransferCost = Convert.ToDecimal(dr["DC20TransferCost"]);
					}
					if (dr["DC20Cost"] != null && dr["DC20Cost"] != DBNull.Value)
					{
						item.DC20Cost = Convert.ToDecimal(dr["DC20Cost"]);
					}
					if (dr["DC40TransferCost"] != null && dr["DC40TransferCost"] != DBNull.Value)
					{
						item.DC40TransferCost = Convert.ToDecimal(dr["DC40TransferCost"]);
					}
					if (dr["DC40Cost"] != null && dr["DC40Cost"] != DBNull.Value)
					{
						item.DC40Cost = Convert.ToDecimal(dr["DC40Cost"]);
					}
					if (dr["DC40HTransferCost"] != null && dr["DC40HTransferCost"] != DBNull.Value)
					{
						item.DC40HTransferCost = Convert.ToDecimal(dr["DC40HTransferCost"]);
					}
					if (dr["DC40HCost"] != null && dr["DC40HCost"] != DBNull.Value)
					{
						item.DC40HCost = Convert.ToDecimal(dr["DC40HCost"]);
					}
					if (dr["DemoWholesaleCost"] != null && dr["DemoWholesaleCost"] != DBNull.Value)
					{
						item.DemoWholesaleCost = Convert.ToDecimal(dr["DemoWholesaleCost"]);
					}
					if (dr["MoqWholesaleCost"] != null && dr["MoqWholesaleCost"] != DBNull.Value)
					{
						item.MoqWholesaleCost = Convert.ToDecimal(dr["MoqWholesaleCost"]);
					}
					if (dr["DC20WholesaleCost"] != null && dr["DC20WholesaleCost"] != DBNull.Value)
					{
						item.DC20WholesaleCost = Convert.ToDecimal(dr["DC20WholesaleCost"]);
					}
					if (dr["DC40WholesaleCost"] != null && dr["DC40WholesaleCost"] != DBNull.Value)
					{
						item.DC40WholesaleCost = Convert.ToDecimal(dr["DC40WholesaleCost"]);
					}
					if (dr["DC40HWholesaleCost"] != null && dr["DC40HWholesaleCost"] != DBNull.Value)
					{
						item.DC40HWholesaleCost = Convert.ToDecimal(dr["DC40HWholesaleCost"]);
					}
					if (dr["DemoRetailCost"] != null && dr["DemoRetailCost"] != DBNull.Value)
					{
						item.DemoRetailCost = Convert.ToDecimal(dr["DemoRetailCost"]);
					}
					if (dr["MoqRetailCost"] != null && dr["MoqRetailCost"] != DBNull.Value)
					{
						item.MoqRetailCost = Convert.ToDecimal(dr["MoqRetailCost"]);
					}
					if (dr["DC20RetailCost"] != null && dr["DC20RetailCost"] != DBNull.Value)
					{
						item.DC20RetailCost = Convert.ToDecimal(dr["DC20RetailCost"]);
					}
					if (dr["DC40RetailCost"] != null && dr["DC40RetailCost"] != DBNull.Value)
					{
						item.DC40RetailCost = Convert.ToDecimal(dr["DC40RetailCost"]);
					}
					if (dr["DC40HRetailCost"] != null && dr["DC40HRetailCost"] != DBNull.Value)
					{
						item.DC40HRetailCost = Convert.ToDecimal(dr["DC40HRetailCost"]);
					}
					if (dr["DemoWholesalePercent"] != null && dr["DemoWholesalePercent"] != DBNull.Value)
					{
						item.DemoWholesalePercent = Convert.ToInt32(dr["DemoWholesalePercent"]);
					}
					if (dr["MoqWholesalePercent"] != null && dr["MoqWholesalePercent"] != DBNull.Value)
					{
						item.MoqWholesalePercent = Convert.ToInt32(dr["MoqWholesalePercent"]);
					}
					if (dr["DC20WholesalePercent"] != null && dr["DC20WholesalePercent"] != DBNull.Value)
					{
						item.DC20WholesalePercent = Convert.ToInt32(dr["DC20WholesalePercent"]);
					}
					if (dr["DC40WholesalePercent"] != null && dr["DC40WholesalePercent"] != DBNull.Value)
					{
						item.DC40WholesalePercent = Convert.ToInt32(dr["DC40WholesalePercent"]);
					}
					if (dr["DC40HWholesalePercent"] != null && dr["DC40HWholesalePercent"] != DBNull.Value)
					{
						item.DC40HWholesalePercent = Convert.ToInt32(dr["DC40HWholesalePercent"]);
					}
					if (dr["DemoRetailPercent"] != null && dr["DemoRetailPercent"] != DBNull.Value)
					{
						item.DemoRetailPercent = Convert.ToInt32(dr["DemoRetailPercent"]);
					}
					if (dr["MoqRetailPercent"] != null && dr["MoqRetailPercent"] != DBNull.Value)
					{
						item.MoqRetailPercent = Convert.ToInt32(dr["MoqRetailPercent"]);
					}
					if (dr["DC20RetailPercent"] != null && dr["DC20RetailPercent"] != DBNull.Value)
					{
						item.DC20RetailPercent = Convert.ToInt32(dr["DC20RetailPercent"]);
					}
					if (dr["DC40RetailPercent"] != null && dr["DC40RetailPercent"] != DBNull.Value)
					{
						item.DC40RetailPercent = Convert.ToInt32(dr["DC40RetailPercent"]);
					}
					if (dr["DC40HRetailPercent"] != null && dr["DC40HRetailPercent"] != DBNull.Value)
					{
						item.DC40HRetailPercent = Convert.ToInt32(dr["DC40HRetailPercent"]);
					}
					if (dr["DemoWholesalePrice"] != null && dr["DemoWholesalePrice"] != DBNull.Value)
					{
						item.DemoWholesalePrice = Convert.ToDecimal(dr["DemoWholesalePrice"]);
					}
					if (dr["MoqWholesalePrice"] != null && dr["MoqWholesalePrice"] != DBNull.Value)
					{
						item.MoqWholesalePrice = Convert.ToDecimal(dr["MoqWholesalePrice"]);
					}
					if (dr["DC20WholesalePrice"] != null && dr["DC20WholesalePrice"] != DBNull.Value)
					{
						item.DC20WholesalePrice = Convert.ToDecimal(dr["DC20WholesalePrice"]);
					}
					if (dr["DC40WholesalePrice"] != null && dr["DC40WholesalePrice"] != DBNull.Value)
					{
						item.DC40WholesalePrice = Convert.ToDecimal(dr["DC40WholesalePrice"]);
					}
					if (dr["DC40HWholesalePrice"] != null && dr["DC40HWholesalePrice"] != DBNull.Value)
					{
						item.DC40HWholesalePrice = Convert.ToDecimal(dr["DC40HWholesalePrice"]);
					}
					if (dr["DemoRetailPrice"] != null && dr["DemoRetailPrice"] != DBNull.Value)
					{
						item.DemoRetailPrice = Convert.ToDecimal(dr["DemoRetailPrice"]);
					}
					if (dr["MoqRetailPrice"] != null && dr["MoqRetailPrice"] != DBNull.Value)
					{
						item.MoqRetailPrice = Convert.ToDecimal(dr["MoqRetailPrice"]);
					}
					if (dr["DC20RetailPrice"] != null && dr["DC20RetailPrice"] != DBNull.Value)
					{
						item.DC20RetailPrice = Convert.ToDecimal(dr["DC20RetailPrice"]);
					}
					if (dr["DC40RetailPrice"] != null && dr["DC40RetailPrice"] != DBNull.Value)
					{
						item.DC40RetailPrice = Convert.ToDecimal(dr["DC40RetailPrice"]);
					}
					if (dr["DC40HRetailPrice"] != null && dr["DC40HRetailPrice"] != DBNull.Value)
					{
						item.DC40HRetailPrice = Convert.ToDecimal(dr["DC40HRetailPrice"]);
					}
					if (dr["Fk_FinishEstimator"] != null && dr["Fk_FinishEstimator"] != DBNull.Value)
					{
						item.Fk_FinishEstimator = Convert.ToString(dr["Fk_FinishEstimator"]);
					}
					if (dr["FinishEstimatorDate"] != null && dr["FinishEstimatorDate"] != DBNull.Value)
					{
						item.FinishEstimatorDate = Convert.ToDateTime(dr["FinishEstimatorDate"]);
					}
					if (dr["Fk_InventoryItem"] != null && dr["Fk_InventoryItem"] != DBNull.Value)
					{
						item.Fk_InventoryItem = Convert.ToString(dr["Fk_InventoryItem"]);
					}
					if (dr["ReferRequestFindProduct"] != null && dr["ReferRequestFindProduct"] != DBNull.Value)
					{
						item.ReferRequestFindProduct = Convert.ToString(dr["ReferRequestFindProduct"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToInt32(dr["IsDelete"]);
					}
					if (dr["FK_TypeOfRequest"] != null && dr["FK_TypeOfRequest"] != DBNull.Value)
					{
						item.FK_TypeOfRequest = Convert.ToInt32(dr["FK_TypeOfRequest"]);
					}
					if (dr["IsBorderTradeDemo"] != null && dr["IsBorderTradeDemo"] != DBNull.Value)
					{
						item.IsBorderTradeDemo = Convert.ToBoolean(dr["IsBorderTradeDemo"]);
					}
					if (dr["DemoShippingPrice"] != null && dr["DemoShippingPrice"] != DBNull.Value)
					{
						item.DemoShippingPrice = Convert.ToDecimal(dr["DemoShippingPrice"]);
					}
					if (dr["IsBorderTradeMoq"] != null && dr["IsBorderTradeMoq"] != DBNull.Value)
					{
						item.IsBorderTradeMoq = Convert.ToBoolean(dr["IsBorderTradeMoq"]);
					}
					if (dr["MoqShippingPrice"] != null && dr["MoqShippingPrice"] != DBNull.Value)
					{
						item.MoqShippingPrice = Convert.ToDecimal(dr["MoqShippingPrice"]);
					}
					if (dr["IsSkipAllStep"] != null && dr["IsSkipAllStep"] != DBNull.Value)
					{
						item.IsSkipAllStep = Convert.ToBoolean(dr["IsSkipAllStep"]);
					}
					if (dr["WeightFrom"] != null && dr["WeightFrom"] != DBNull.Value)
					{
						item.WeightFrom = Convert.ToString(dr["WeightFrom"]);
					}
					if (dr["WeightTo"] != null && dr["WeightTo"] != DBNull.Value)
					{
						item.WeightTo = Convert.ToString(dr["WeightTo"]);
					}
					if (dr["IsNetWeight"] != null && dr["IsNetWeight"] != DBNull.Value)
					{
						item.IsNetWeight = Convert.ToBoolean(dr["IsNetWeight"]);
					}
					if (dr["WishPrice"] != null && dr["WishPrice"] != DBNull.Value)
					{
						item.WishPrice = Convert.ToDecimal(dr["WishPrice"]);
					}
					if (dr["FK_UnitPacking"] != null && dr["FK_UnitPacking"] != DBNull.Value)
					{
						item.FK_UnitPacking = Convert.ToString(dr["FK_UnitPacking"]);
					}
					if (dr["IsReceptionLCOF"] != null && dr["IsReceptionLCOF"] != DBNull.Value)
					{
						item.IsReceptionLCOF = Convert.ToBoolean(dr["IsReceptionLCOF"]);
					}
					if (dr["IsReceptionCustoms"] != null && dr["IsReceptionCustoms"] != DBNull.Value)
					{
						item.IsReceptionCustoms = Convert.ToBoolean(dr["IsReceptionCustoms"]);
					}
					if (dr["IsReceptionTrucking"] != null && dr["IsReceptionTrucking"] != DBNull.Value)
					{
						item.IsReceptionTrucking = Convert.ToBoolean(dr["IsReceptionTrucking"]);
					}
					if (dr["FK_RequestPrioty"] != null && dr["FK_RequestPrioty"] != DBNull.Value)
					{
						item.FK_RequestPrioty = Convert.ToInt32(dr["FK_RequestPrioty"]);
					}
					if (dr["PriotyName"] != null && dr["PriotyName"] != DBNull.Value)
					{
						item.PriotyName = Convert.ToString(dr["PriotyName"]);
					}
					if (dr["ExportRequestTypeName"] != null && dr["ExportRequestTypeName"] != DBNull.Value)
					{
						item.ExportRequestTypeName = Convert.ToString(dr["ExportRequestTypeName"]);
					}
					if (dr["IsDC20Price"] != null && dr["IsDC20Price"] != DBNull.Value)
					{
						item.IsDC20Price = Convert.ToBoolean(dr["IsDC20Price"]);
					}
					if (dr["IsDC40Price"] != null && dr["IsDC40Price"] != DBNull.Value)
					{
						item.IsDC40Price = Convert.ToBoolean(dr["IsDC40Price"]);
					}
					if (dr["IsDC40HPrice"] != null && dr["IsDC40HPrice"] != DBNull.Value)
					{
						item.IsDC40HPrice = Convert.ToBoolean(dr["IsDC40HPrice"]);
					}
					if (dr["UserCustomsProcess"] != null && dr["UserCustomsProcess"] != DBNull.Value)
					{
						item.UserCustomsProcess = Convert.ToString(dr["UserCustomsProcess"]);
					}
					if (dr["UserLCOFProcess"] != null && dr["UserLCOFProcess"] != DBNull.Value)
					{
						item.UserLCOFProcess = Convert.ToString(dr["UserLCOFProcess"]);
					}
					if (dr["UserTruckingProcess"] != null && dr["UserTruckingProcess"] != DBNull.Value)
					{
						item.UserTruckingProcess = Convert.ToString(dr["UserTruckingProcess"]);
					}
					if (dr["UserRequestApprover"] != null && dr["UserRequestApprover"] != DBNull.Value)
					{
						item.UserRequestApprover = Convert.ToString(dr["UserRequestApprover"]);
					}
					if (dr["UserSourceApprover"] != null && dr["UserSourceApprover"] != DBNull.Value)
					{
						item.UserSourceApprover = Convert.ToString(dr["UserSourceApprover"]);
					}
					if (dr["UserSourceEstimator"] != null && dr["UserSourceEstimator"] != DBNull.Value)
					{
						item.UserSourceEstimator = Convert.ToString(dr["UserSourceEstimator"]);
					}
					if (dr["UserSourceProcess"] != null && dr["UserSourceProcess"] != DBNull.Value)
					{
						item.UserSourceProcess = Convert.ToString(dr["UserSourceProcess"]);
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
		/// Lấy danh sách GsRequestFindProduct từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GsRequestFindProduct> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GsRequestFindProduct] A "+ condition,  parameters);
				List<GsRequestFindProduct> items = new List<GsRequestFindProduct>();
				GsRequestFindProduct item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GsRequestFindProduct();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["RequestCode"] != null && dr["RequestCode"] != DBNull.Value)
					{
						item.RequestCode = Convert.ToString(dr["RequestCode"]);
					}
					if (dr["ProductName"] != null && dr["ProductName"] != DBNull.Value)
					{
						item.ProductName = Convert.ToString(dr["ProductName"]);
					}
					if (dr["ProductNameUnsign"] != null && dr["ProductNameUnsign"] != DBNull.Value)
					{
						item.ProductNameUnsign = Convert.ToString(dr["ProductNameUnsign"]);
					}
					if (dr["RequestImage"] != null && dr["RequestImage"] != DBNull.Value)
					{
						item.RequestImage = Convert.ToString(dr["RequestImage"]);
					}
					if (dr["BeginRequestDate"] != null && dr["BeginRequestDate"] != DBNull.Value)
					{
						item.BeginRequestDate = Convert.ToDateTime(dr["BeginRequestDate"]);
					}
					if (dr["FK_InventoryCategory"] != null && dr["FK_InventoryCategory"] != DBNull.Value)
					{
						item.FK_InventoryCategory = Convert.ToString(dr["FK_InventoryCategory"]);
					}
					if (dr["Fk_Provine"] != null && dr["Fk_Provine"] != DBNull.Value)
					{
						item.Fk_Provine = Convert.ToString(dr["Fk_Provine"]);
					}
					if (dr["DeliveryAddress"] != null && dr["DeliveryAddress"] != DBNull.Value)
					{
						item.DeliveryAddress = Convert.ToString(dr["DeliveryAddress"]);
					}
					if (dr["Description"] != null && dr["Description"] != DBNull.Value)
					{
						item.Description = Convert.ToString(dr["Description"]);
					}
					if (dr["Quantity"] != null && dr["Quantity"] != DBNull.Value)
					{
						item.Quantity = Convert.ToInt32(dr["Quantity"]);
					}
					if (dr["Fk_Unit"] != null && dr["Fk_Unit"] != DBNull.Value)
					{
						item.Fk_Unit = Convert.ToString(dr["Fk_Unit"]);
					}
					if (dr["Packing"] != null && dr["Packing"] != DBNull.Value)
					{
						item.Packing = Convert.ToString(dr["Packing"]);
					}
					if (dr["QuantityOfPacking"] != null && dr["QuantityOfPacking"] != DBNull.Value)
					{
						item.QuantityOfPacking = Convert.ToDecimal(dr["QuantityOfPacking"]);
					}
					if (dr["WarrantyMonth"] != null && dr["WarrantyMonth"] != DBNull.Value)
					{
						item.WarrantyMonth = Convert.ToInt32(dr["WarrantyMonth"]);
					}
					if (dr["TradeMark"] != null && dr["TradeMark"] != DBNull.Value)
					{
						item.TradeMark = Convert.ToString(dr["TradeMark"]);
					}
					if (dr["DesignTradeMarkFile"] != null && dr["DesignTradeMarkFile"] != DBNull.Value)
					{
						item.DesignTradeMarkFile = Convert.ToString(dr["DesignTradeMarkFile"]);
					}
					if (dr["AdditionalLabel"] != null && dr["AdditionalLabel"] != DBNull.Value)
					{
						item.AdditionalLabel = Convert.ToString(dr["AdditionalLabel"]);
					}
					if (dr["EndRequestDate"] != null && dr["EndRequestDate"] != DBNull.Value)
					{
						item.EndRequestDate = Convert.ToDateTime(dr["EndRequestDate"]);
					}
					if (dr["RequestNote"] != null && dr["RequestNote"] != DBNull.Value)
					{
						item.RequestNote = Convert.ToString(dr["RequestNote"]);
					}
					if (dr["IsCustomerRequest"] != null && dr["IsCustomerRequest"] != DBNull.Value)
					{
						item.IsCustomerRequest = Convert.ToBoolean(dr["IsCustomerRequest"]);
					}
					if (dr["Fk_UserSaleRequest"] != null && dr["Fk_UserSaleRequest"] != DBNull.Value)
					{
						item.Fk_UserSaleRequest = Convert.ToString(dr["Fk_UserSaleRequest"]);
					}
					if (dr["HeightX"] != null && dr["HeightX"] != DBNull.Value)
					{
						item.HeightX = Convert.ToInt32(dr["HeightX"]);
					}
					if (dr["WidthY"] != null && dr["WidthY"] != DBNull.Value)
					{
						item.WidthY = Convert.ToInt32(dr["WidthY"]);
					}
					if (dr["ThicknessZ"] != null && dr["ThicknessZ"] != DBNull.Value)
					{
						item.ThicknessZ = Convert.ToInt32(dr["ThicknessZ"]);
					}
					if (dr["Weight"] != null && dr["Weight"] != DBNull.Value)
					{
						item.Weight = Convert.ToDecimal(dr["Weight"]);
					}
					if (dr["Fk_WeightUnit"] != null && dr["Fk_WeightUnit"] != DBNull.Value)
					{
						item.Fk_WeightUnit = Convert.ToString(dr["Fk_WeightUnit"]);
					}
					if (dr["Fk_Status"] != null && dr["Fk_Status"] != DBNull.Value)
					{
						item.Fk_Status = Convert.ToInt32(dr["Fk_Status"]);
					}
					if (dr["Fk_UserRequestApprover"] != null && dr["Fk_UserRequestApprover"] != DBNull.Value)
					{
						item.Fk_UserRequestApprover = Convert.ToString(dr["Fk_UserRequestApprover"]);
					}
					if (dr["UserRequestApproverDate"] != null && dr["UserRequestApproverDate"] != DBNull.Value)
					{
						item.UserRequestApproverDate = Convert.ToDateTime(dr["UserRequestApproverDate"]);
					}
					if (dr["RequestApproverNote"] != null && dr["RequestApproverNote"] != DBNull.Value)
					{
						item.RequestApproverNote = Convert.ToString(dr["RequestApproverNote"]);
					}
					if (dr["Fk_UserSourceProcess"] != null && dr["Fk_UserSourceProcess"] != DBNull.Value)
					{
						item.Fk_UserSourceProcess = Convert.ToString(dr["Fk_UserSourceProcess"]);
					}
					if (dr["SourceProcessDate"] != null && dr["SourceProcessDate"] != DBNull.Value)
					{
						item.SourceProcessDate = Convert.ToDateTime(dr["SourceProcessDate"]);
					}
					if (dr["Fk_UserSourceApprover"] != null && dr["Fk_UserSourceApprover"] != DBNull.Value)
					{
						item.Fk_UserSourceApprover = Convert.ToString(dr["Fk_UserSourceApprover"]);
					}
					if (dr["SourceApproverDate"] != null && dr["SourceApproverDate"] != DBNull.Value)
					{
						item.SourceApproverDate = Convert.ToDateTime(dr["SourceApproverDate"]);
					}
					if (dr["SourceApproverNote"] != null && dr["SourceApproverNote"] != DBNull.Value)
					{
						item.SourceApproverNote = Convert.ToString(dr["SourceApproverNote"]);
					}
					if (dr["Fk_UserSourceEstimator"] != null && dr["Fk_UserSourceEstimator"] != DBNull.Value)
					{
						item.Fk_UserSourceEstimator = Convert.ToString(dr["Fk_UserSourceEstimator"]);
					}
					if (dr["SourceEstimator"] != null && dr["SourceEstimator"] != DBNull.Value)
					{
						item.SourceEstimator = Convert.ToDateTime(dr["SourceEstimator"]);
					}
					if (dr["SourceEstimatorNote"] != null && dr["SourceEstimatorNote"] != DBNull.Value)
					{
						item.SourceEstimatorNote = Convert.ToString(dr["SourceEstimatorNote"]);
					}
					if (dr["IsLCOFDone"] != null && dr["IsLCOFDone"] != DBNull.Value)
					{
						item.IsLCOFDone = Convert.ToBoolean(dr["IsLCOFDone"]);
					}
					if (dr["Fk_UserLCOFProcess"] != null && dr["Fk_UserLCOFProcess"] != DBNull.Value)
					{
						item.Fk_UserLCOFProcess = Convert.ToString(dr["Fk_UserLCOFProcess"]);
					}
					if (dr["LCOFDate"] != null && dr["LCOFDate"] != DBNull.Value)
					{
						item.LCOFDate = Convert.ToDateTime(dr["LCOFDate"]);
					}
					if (dr["IsCustomsDone"] != null && dr["IsCustomsDone"] != DBNull.Value)
					{
						item.IsCustomsDone = Convert.ToBoolean(dr["IsCustomsDone"]);
					}
					if (dr["Fk_UserCustomsProcess"] != null && dr["Fk_UserCustomsProcess"] != DBNull.Value)
					{
						item.Fk_UserCustomsProcess = Convert.ToString(dr["Fk_UserCustomsProcess"]);
					}
					if (dr["CustomsProcessDate"] != null && dr["CustomsProcessDate"] != DBNull.Value)
					{
						item.CustomsProcessDate = Convert.ToDateTime(dr["CustomsProcessDate"]);
					}
					if (dr["IsTruckingDone"] != null && dr["IsTruckingDone"] != DBNull.Value)
					{
						item.IsTruckingDone = Convert.ToBoolean(dr["IsTruckingDone"]);
					}
					if (dr["Fk_UserTruckingProcess"] != null && dr["Fk_UserTruckingProcess"] != DBNull.Value)
					{
						item.Fk_UserTruckingProcess = Convert.ToString(dr["Fk_UserTruckingProcess"]);
					}
					if (dr["TruckingProcessDate"] != null && dr["TruckingProcessDate"] != DBNull.Value)
					{
						item.TruckingProcessDate = Convert.ToDateTime(dr["TruckingProcessDate"]);
					}
					if (dr["Fk_OPApprover"] != null && dr["Fk_OPApprover"] != DBNull.Value)
					{
						item.Fk_OPApprover = Convert.ToString(dr["Fk_OPApprover"]);
					}
					if (dr["OPApproverDate"] != null && dr["OPApproverDate"] != DBNull.Value)
					{
						item.OPApproverDate = Convert.ToDateTime(dr["OPApproverDate"]);
					}
					if (dr["OPApproverNote"] != null && dr["OPApproverNote"] != DBNull.Value)
					{
						item.OPApproverNote = Convert.ToString(dr["OPApproverNote"]);
					}
					if (dr["IsApproverLCOF"] != null && dr["IsApproverLCOF"] != DBNull.Value)
					{
						item.IsApproverLCOF = Convert.ToBoolean(dr["IsApproverLCOF"]);
					}
					if (dr["IsApproverCustoms"] != null && dr["IsApproverCustoms"] != DBNull.Value)
					{
						item.IsApproverCustoms = Convert.ToBoolean(dr["IsApproverCustoms"]);
					}
					if (dr["IsApproverTrucking"] != null && dr["IsApproverTrucking"] != DBNull.Value)
					{
						item.IsApproverTrucking = Convert.ToBoolean(dr["IsApproverTrucking"]);
					}
					if (dr["Fk_OPEstimator"] != null && dr["Fk_OPEstimator"] != DBNull.Value)
					{
						item.Fk_OPEstimator = Convert.ToString(dr["Fk_OPEstimator"]);
					}
					if (dr["OPEstimatorDate"] != null && dr["OPEstimatorDate"] != DBNull.Value)
					{
						item.OPEstimatorDate = Convert.ToDateTime(dr["OPEstimatorDate"]);
					}
					if (dr["OPEstimatorNote"] != null && dr["OPEstimatorNote"] != DBNull.Value)
					{
						item.OPEstimatorNote = Convert.ToString(dr["OPEstimatorNote"]);
					}
					if (dr["IsEstimatorLCOF"] != null && dr["IsEstimatorLCOF"] != DBNull.Value)
					{
						item.IsEstimatorLCOF = Convert.ToBoolean(dr["IsEstimatorLCOF"]);
					}
					if (dr["IsEstimatorCustoms"] != null && dr["IsEstimatorCustoms"] != DBNull.Value)
					{
						item.IsEstimatorCustoms = Convert.ToBoolean(dr["IsEstimatorCustoms"]);
					}
					if (dr["IsEstimatorTrucking"] != null && dr["IsEstimatorTrucking"] != DBNull.Value)
					{
						item.IsEstimatorTrucking = Convert.ToBoolean(dr["IsEstimatorTrucking"]);
					}
					if (dr["DemoTransferCost"] != null && dr["DemoTransferCost"] != DBNull.Value)
					{
						item.DemoTransferCost = Convert.ToDecimal(dr["DemoTransferCost"]);
					}
					if (dr["DemoCost"] != null && dr["DemoCost"] != DBNull.Value)
					{
						item.DemoCost = Convert.ToDecimal(dr["DemoCost"]);
					}
					if (dr["MoqTransferCost"] != null && dr["MoqTransferCost"] != DBNull.Value)
					{
						item.MoqTransferCost = Convert.ToDecimal(dr["MoqTransferCost"]);
					}
					if (dr["MoqCost"] != null && dr["MoqCost"] != DBNull.Value)
					{
						item.MoqCost = Convert.ToDecimal(dr["MoqCost"]);
					}
					if (dr["DC20TransferCost"] != null && dr["DC20TransferCost"] != DBNull.Value)
					{
						item.DC20TransferCost = Convert.ToDecimal(dr["DC20TransferCost"]);
					}
					if (dr["DC20Cost"] != null && dr["DC20Cost"] != DBNull.Value)
					{
						item.DC20Cost = Convert.ToDecimal(dr["DC20Cost"]);
					}
					if (dr["DC40TransferCost"] != null && dr["DC40TransferCost"] != DBNull.Value)
					{
						item.DC40TransferCost = Convert.ToDecimal(dr["DC40TransferCost"]);
					}
					if (dr["DC40Cost"] != null && dr["DC40Cost"] != DBNull.Value)
					{
						item.DC40Cost = Convert.ToDecimal(dr["DC40Cost"]);
					}
					if (dr["DC40HTransferCost"] != null && dr["DC40HTransferCost"] != DBNull.Value)
					{
						item.DC40HTransferCost = Convert.ToDecimal(dr["DC40HTransferCost"]);
					}
					if (dr["DC40HCost"] != null && dr["DC40HCost"] != DBNull.Value)
					{
						item.DC40HCost = Convert.ToDecimal(dr["DC40HCost"]);
					}
					if (dr["DemoWholesaleCost"] != null && dr["DemoWholesaleCost"] != DBNull.Value)
					{
						item.DemoWholesaleCost = Convert.ToDecimal(dr["DemoWholesaleCost"]);
					}
					if (dr["MoqWholesaleCost"] != null && dr["MoqWholesaleCost"] != DBNull.Value)
					{
						item.MoqWholesaleCost = Convert.ToDecimal(dr["MoqWholesaleCost"]);
					}
					if (dr["DC20WholesaleCost"] != null && dr["DC20WholesaleCost"] != DBNull.Value)
					{
						item.DC20WholesaleCost = Convert.ToDecimal(dr["DC20WholesaleCost"]);
					}
					if (dr["DC40WholesaleCost"] != null && dr["DC40WholesaleCost"] != DBNull.Value)
					{
						item.DC40WholesaleCost = Convert.ToDecimal(dr["DC40WholesaleCost"]);
					}
					if (dr["DC40HWholesaleCost"] != null && dr["DC40HWholesaleCost"] != DBNull.Value)
					{
						item.DC40HWholesaleCost = Convert.ToDecimal(dr["DC40HWholesaleCost"]);
					}
					if (dr["DemoRetailCost"] != null && dr["DemoRetailCost"] != DBNull.Value)
					{
						item.DemoRetailCost = Convert.ToDecimal(dr["DemoRetailCost"]);
					}
					if (dr["MoqRetailCost"] != null && dr["MoqRetailCost"] != DBNull.Value)
					{
						item.MoqRetailCost = Convert.ToDecimal(dr["MoqRetailCost"]);
					}
					if (dr["DC20RetailCost"] != null && dr["DC20RetailCost"] != DBNull.Value)
					{
						item.DC20RetailCost = Convert.ToDecimal(dr["DC20RetailCost"]);
					}
					if (dr["DC40RetailCost"] != null && dr["DC40RetailCost"] != DBNull.Value)
					{
						item.DC40RetailCost = Convert.ToDecimal(dr["DC40RetailCost"]);
					}
					if (dr["DC40HRetailCost"] != null && dr["DC40HRetailCost"] != DBNull.Value)
					{
						item.DC40HRetailCost = Convert.ToDecimal(dr["DC40HRetailCost"]);
					}
					if (dr["DemoWholesalePercent"] != null && dr["DemoWholesalePercent"] != DBNull.Value)
					{
						item.DemoWholesalePercent = Convert.ToInt32(dr["DemoWholesalePercent"]);
					}
					if (dr["MoqWholesalePercent"] != null && dr["MoqWholesalePercent"] != DBNull.Value)
					{
						item.MoqWholesalePercent = Convert.ToInt32(dr["MoqWholesalePercent"]);
					}
					if (dr["DC20WholesalePercent"] != null && dr["DC20WholesalePercent"] != DBNull.Value)
					{
						item.DC20WholesalePercent = Convert.ToInt32(dr["DC20WholesalePercent"]);
					}
					if (dr["DC40WholesalePercent"] != null && dr["DC40WholesalePercent"] != DBNull.Value)
					{
						item.DC40WholesalePercent = Convert.ToInt32(dr["DC40WholesalePercent"]);
					}
					if (dr["DC40HWholesalePercent"] != null && dr["DC40HWholesalePercent"] != DBNull.Value)
					{
						item.DC40HWholesalePercent = Convert.ToInt32(dr["DC40HWholesalePercent"]);
					}
					if (dr["DemoRetailPercent"] != null && dr["DemoRetailPercent"] != DBNull.Value)
					{
						item.DemoRetailPercent = Convert.ToInt32(dr["DemoRetailPercent"]);
					}
					if (dr["MoqRetailPercent"] != null && dr["MoqRetailPercent"] != DBNull.Value)
					{
						item.MoqRetailPercent = Convert.ToInt32(dr["MoqRetailPercent"]);
					}
					if (dr["DC20RetailPercent"] != null && dr["DC20RetailPercent"] != DBNull.Value)
					{
						item.DC20RetailPercent = Convert.ToInt32(dr["DC20RetailPercent"]);
					}
					if (dr["DC40RetailPercent"] != null && dr["DC40RetailPercent"] != DBNull.Value)
					{
						item.DC40RetailPercent = Convert.ToInt32(dr["DC40RetailPercent"]);
					}
					if (dr["DC40HRetailPercent"] != null && dr["DC40HRetailPercent"] != DBNull.Value)
					{
						item.DC40HRetailPercent = Convert.ToInt32(dr["DC40HRetailPercent"]);
					}
					if (dr["DemoWholesalePrice"] != null && dr["DemoWholesalePrice"] != DBNull.Value)
					{
						item.DemoWholesalePrice = Convert.ToDecimal(dr["DemoWholesalePrice"]);
					}
					if (dr["MoqWholesalePrice"] != null && dr["MoqWholesalePrice"] != DBNull.Value)
					{
						item.MoqWholesalePrice = Convert.ToDecimal(dr["MoqWholesalePrice"]);
					}
					if (dr["DC20WholesalePrice"] != null && dr["DC20WholesalePrice"] != DBNull.Value)
					{
						item.DC20WholesalePrice = Convert.ToDecimal(dr["DC20WholesalePrice"]);
					}
					if (dr["DC40WholesalePrice"] != null && dr["DC40WholesalePrice"] != DBNull.Value)
					{
						item.DC40WholesalePrice = Convert.ToDecimal(dr["DC40WholesalePrice"]);
					}
					if (dr["DC40HWholesalePrice"] != null && dr["DC40HWholesalePrice"] != DBNull.Value)
					{
						item.DC40HWholesalePrice = Convert.ToDecimal(dr["DC40HWholesalePrice"]);
					}
					if (dr["DemoRetailPrice"] != null && dr["DemoRetailPrice"] != DBNull.Value)
					{
						item.DemoRetailPrice = Convert.ToDecimal(dr["DemoRetailPrice"]);
					}
					if (dr["MoqRetailPrice"] != null && dr["MoqRetailPrice"] != DBNull.Value)
					{
						item.MoqRetailPrice = Convert.ToDecimal(dr["MoqRetailPrice"]);
					}
					if (dr["DC20RetailPrice"] != null && dr["DC20RetailPrice"] != DBNull.Value)
					{
						item.DC20RetailPrice = Convert.ToDecimal(dr["DC20RetailPrice"]);
					}
					if (dr["DC40RetailPrice"] != null && dr["DC40RetailPrice"] != DBNull.Value)
					{
						item.DC40RetailPrice = Convert.ToDecimal(dr["DC40RetailPrice"]);
					}
					if (dr["DC40HRetailPrice"] != null && dr["DC40HRetailPrice"] != DBNull.Value)
					{
						item.DC40HRetailPrice = Convert.ToDecimal(dr["DC40HRetailPrice"]);
					}
					if (dr["Fk_FinishEstimator"] != null && dr["Fk_FinishEstimator"] != DBNull.Value)
					{
						item.Fk_FinishEstimator = Convert.ToString(dr["Fk_FinishEstimator"]);
					}
					if (dr["FinishEstimatorDate"] != null && dr["FinishEstimatorDate"] != DBNull.Value)
					{
						item.FinishEstimatorDate = Convert.ToDateTime(dr["FinishEstimatorDate"]);
					}
					if (dr["Fk_InventoryItem"] != null && dr["Fk_InventoryItem"] != DBNull.Value)
					{
						item.Fk_InventoryItem = Convert.ToString(dr["Fk_InventoryItem"]);
					}
					if (dr["ReferRequestFindProduct"] != null && dr["ReferRequestFindProduct"] != DBNull.Value)
					{
						item.ReferRequestFindProduct = Convert.ToString(dr["ReferRequestFindProduct"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToInt32(dr["IsDelete"]);
					}
					if (dr["FK_TypeOfRequest"] != null && dr["FK_TypeOfRequest"] != DBNull.Value)
					{
						item.FK_TypeOfRequest = Convert.ToInt32(dr["FK_TypeOfRequest"]);
					}
					if (dr["IsBorderTradeDemo"] != null && dr["IsBorderTradeDemo"] != DBNull.Value)
					{
						item.IsBorderTradeDemo = Convert.ToBoolean(dr["IsBorderTradeDemo"]);
					}
					if (dr["DemoShippingPrice"] != null && dr["DemoShippingPrice"] != DBNull.Value)
					{
						item.DemoShippingPrice = Convert.ToDecimal(dr["DemoShippingPrice"]);
					}
					if (dr["IsBorderTradeMoq"] != null && dr["IsBorderTradeMoq"] != DBNull.Value)
					{
						item.IsBorderTradeMoq = Convert.ToBoolean(dr["IsBorderTradeMoq"]);
					}
					if (dr["MoqShippingPrice"] != null && dr["MoqShippingPrice"] != DBNull.Value)
					{
						item.MoqShippingPrice = Convert.ToDecimal(dr["MoqShippingPrice"]);
					}
					if (dr["IsSkipAllStep"] != null && dr["IsSkipAllStep"] != DBNull.Value)
					{
						item.IsSkipAllStep = Convert.ToBoolean(dr["IsSkipAllStep"]);
					}
					if (dr["WeightFrom"] != null && dr["WeightFrom"] != DBNull.Value)
					{
						item.WeightFrom = Convert.ToString(dr["WeightFrom"]);
					}
					if (dr["WeightTo"] != null && dr["WeightTo"] != DBNull.Value)
					{
						item.WeightTo = Convert.ToString(dr["WeightTo"]);
					}
					if (dr["IsNetWeight"] != null && dr["IsNetWeight"] != DBNull.Value)
					{
						item.IsNetWeight = Convert.ToBoolean(dr["IsNetWeight"]);
					}
					if (dr["WishPrice"] != null && dr["WishPrice"] != DBNull.Value)
					{
						item.WishPrice = Convert.ToDecimal(dr["WishPrice"]);
					}
					if (dr["FK_UnitPacking"] != null && dr["FK_UnitPacking"] != DBNull.Value)
					{
						item.FK_UnitPacking = Convert.ToString(dr["FK_UnitPacking"]);
					}
					if (dr["IsReceptionLCOF"] != null && dr["IsReceptionLCOF"] != DBNull.Value)
					{
						item.IsReceptionLCOF = Convert.ToBoolean(dr["IsReceptionLCOF"]);
					}
					if (dr["IsReceptionCustoms"] != null && dr["IsReceptionCustoms"] != DBNull.Value)
					{
						item.IsReceptionCustoms = Convert.ToBoolean(dr["IsReceptionCustoms"]);
					}
					if (dr["IsReceptionTrucking"] != null && dr["IsReceptionTrucking"] != DBNull.Value)
					{
						item.IsReceptionTrucking = Convert.ToBoolean(dr["IsReceptionTrucking"]);
					}
					if (dr["FK_RequestPrioty"] != null && dr["FK_RequestPrioty"] != DBNull.Value)
					{
						item.FK_RequestPrioty = Convert.ToInt32(dr["FK_RequestPrioty"]);
					}
					if (dr["PriotyName"] != null && dr["PriotyName"] != DBNull.Value)
					{
						item.PriotyName = Convert.ToString(dr["PriotyName"]);
					}
					if (dr["ExportRequestTypeName"] != null && dr["ExportRequestTypeName"] != DBNull.Value)
					{
						item.ExportRequestTypeName = Convert.ToString(dr["ExportRequestTypeName"]);
					}
					if (dr["IsDC20Price"] != null && dr["IsDC20Price"] != DBNull.Value)
					{
						item.IsDC20Price = Convert.ToBoolean(dr["IsDC20Price"]);
					}
					if (dr["IsDC40Price"] != null && dr["IsDC40Price"] != DBNull.Value)
					{
						item.IsDC40Price = Convert.ToBoolean(dr["IsDC40Price"]);
					}
					if (dr["IsDC40HPrice"] != null && dr["IsDC40HPrice"] != DBNull.Value)
					{
						item.IsDC40HPrice = Convert.ToBoolean(dr["IsDC40HPrice"]);
					}
					if (dr["UserCustomsProcess"] != null && dr["UserCustomsProcess"] != DBNull.Value)
					{
						item.UserCustomsProcess = Convert.ToString(dr["UserCustomsProcess"]);
					}
					if (dr["UserLCOFProcess"] != null && dr["UserLCOFProcess"] != DBNull.Value)
					{
						item.UserLCOFProcess = Convert.ToString(dr["UserLCOFProcess"]);
					}
					if (dr["UserTruckingProcess"] != null && dr["UserTruckingProcess"] != DBNull.Value)
					{
						item.UserTruckingProcess = Convert.ToString(dr["UserTruckingProcess"]);
					}
					if (dr["UserRequestApprover"] != null && dr["UserRequestApprover"] != DBNull.Value)
					{
						item.UserRequestApprover = Convert.ToString(dr["UserRequestApprover"]);
					}
					if (dr["UserSourceApprover"] != null && dr["UserSourceApprover"] != DBNull.Value)
					{
						item.UserSourceApprover = Convert.ToString(dr["UserSourceApprover"]);
					}
					if (dr["UserSourceEstimator"] != null && dr["UserSourceEstimator"] != DBNull.Value)
					{
						item.UserSourceEstimator = Convert.ToString(dr["UserSourceEstimator"]);
					}
					if (dr["UserSourceProcess"] != null && dr["UserSourceProcess"] != DBNull.Value)
					{
						item.UserSourceProcess = Convert.ToString(dr["UserSourceProcess"]);
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

		public List<GsRequestFindProduct> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GsRequestFindProduct] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GsRequestFindProduct] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GsRequestFindProduct>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GsRequestFindProduct từ Database
		/// </summary>
		public GsRequestFindProduct GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GsRequestFindProduct] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GsRequestFindProduct item=new GsRequestFindProduct();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["RequestCode"] != null && dr["RequestCode"] != DBNull.Value)
						{
							item.RequestCode = Convert.ToString(dr["RequestCode"]);
						}
						if (dr["ProductName"] != null && dr["ProductName"] != DBNull.Value)
						{
							item.ProductName = Convert.ToString(dr["ProductName"]);
						}
						if (dr["ProductNameUnsign"] != null && dr["ProductNameUnsign"] != DBNull.Value)
						{
							item.ProductNameUnsign = Convert.ToString(dr["ProductNameUnsign"]);
						}
						if (dr["RequestImage"] != null && dr["RequestImage"] != DBNull.Value)
						{
							item.RequestImage = Convert.ToString(dr["RequestImage"]);
						}
						if (dr["BeginRequestDate"] != null && dr["BeginRequestDate"] != DBNull.Value)
						{
							item.BeginRequestDate = Convert.ToDateTime(dr["BeginRequestDate"]);
						}
						if (dr["FK_InventoryCategory"] != null && dr["FK_InventoryCategory"] != DBNull.Value)
						{
							item.FK_InventoryCategory = Convert.ToString(dr["FK_InventoryCategory"]);
						}
						if (dr["Fk_Provine"] != null && dr["Fk_Provine"] != DBNull.Value)
						{
							item.Fk_Provine = Convert.ToString(dr["Fk_Provine"]);
						}
						if (dr["DeliveryAddress"] != null && dr["DeliveryAddress"] != DBNull.Value)
						{
							item.DeliveryAddress = Convert.ToString(dr["DeliveryAddress"]);
						}
						if (dr["Description"] != null && dr["Description"] != DBNull.Value)
						{
							item.Description = Convert.ToString(dr["Description"]);
						}
						if (dr["Quantity"] != null && dr["Quantity"] != DBNull.Value)
						{
							item.Quantity = Convert.ToInt32(dr["Quantity"]);
						}
						if (dr["Fk_Unit"] != null && dr["Fk_Unit"] != DBNull.Value)
						{
							item.Fk_Unit = Convert.ToString(dr["Fk_Unit"]);
						}
						if (dr["Packing"] != null && dr["Packing"] != DBNull.Value)
						{
							item.Packing = Convert.ToString(dr["Packing"]);
						}
						if (dr["QuantityOfPacking"] != null && dr["QuantityOfPacking"] != DBNull.Value)
						{
							item.QuantityOfPacking = Convert.ToDecimal(dr["QuantityOfPacking"]);
						}
						if (dr["WarrantyMonth"] != null && dr["WarrantyMonth"] != DBNull.Value)
						{
							item.WarrantyMonth = Convert.ToInt32(dr["WarrantyMonth"]);
						}
						if (dr["TradeMark"] != null && dr["TradeMark"] != DBNull.Value)
						{
							item.TradeMark = Convert.ToString(dr["TradeMark"]);
						}
						if (dr["DesignTradeMarkFile"] != null && dr["DesignTradeMarkFile"] != DBNull.Value)
						{
							item.DesignTradeMarkFile = Convert.ToString(dr["DesignTradeMarkFile"]);
						}
						if (dr["AdditionalLabel"] != null && dr["AdditionalLabel"] != DBNull.Value)
						{
							item.AdditionalLabel = Convert.ToString(dr["AdditionalLabel"]);
						}
						if (dr["EndRequestDate"] != null && dr["EndRequestDate"] != DBNull.Value)
						{
							item.EndRequestDate = Convert.ToDateTime(dr["EndRequestDate"]);
						}
						if (dr["RequestNote"] != null && dr["RequestNote"] != DBNull.Value)
						{
							item.RequestNote = Convert.ToString(dr["RequestNote"]);
						}
						if (dr["IsCustomerRequest"] != null && dr["IsCustomerRequest"] != DBNull.Value)
						{
							item.IsCustomerRequest = Convert.ToBoolean(dr["IsCustomerRequest"]);
						}
						if (dr["Fk_UserSaleRequest"] != null && dr["Fk_UserSaleRequest"] != DBNull.Value)
						{
							item.Fk_UserSaleRequest = Convert.ToString(dr["Fk_UserSaleRequest"]);
						}
						if (dr["HeightX"] != null && dr["HeightX"] != DBNull.Value)
						{
							item.HeightX = Convert.ToInt32(dr["HeightX"]);
						}
						if (dr["WidthY"] != null && dr["WidthY"] != DBNull.Value)
						{
							item.WidthY = Convert.ToInt32(dr["WidthY"]);
						}
						if (dr["ThicknessZ"] != null && dr["ThicknessZ"] != DBNull.Value)
						{
							item.ThicknessZ = Convert.ToInt32(dr["ThicknessZ"]);
						}
						if (dr["Weight"] != null && dr["Weight"] != DBNull.Value)
						{
							item.Weight = Convert.ToDecimal(dr["Weight"]);
						}
						if (dr["Fk_WeightUnit"] != null && dr["Fk_WeightUnit"] != DBNull.Value)
						{
							item.Fk_WeightUnit = Convert.ToString(dr["Fk_WeightUnit"]);
						}
						if (dr["Fk_Status"] != null && dr["Fk_Status"] != DBNull.Value)
						{
							item.Fk_Status = Convert.ToInt32(dr["Fk_Status"]);
						}
						if (dr["Fk_UserRequestApprover"] != null && dr["Fk_UserRequestApprover"] != DBNull.Value)
						{
							item.Fk_UserRequestApprover = Convert.ToString(dr["Fk_UserRequestApprover"]);
						}
						if (dr["UserRequestApproverDate"] != null && dr["UserRequestApproverDate"] != DBNull.Value)
						{
							item.UserRequestApproverDate = Convert.ToDateTime(dr["UserRequestApproverDate"]);
						}
						if (dr["RequestApproverNote"] != null && dr["RequestApproverNote"] != DBNull.Value)
						{
							item.RequestApproverNote = Convert.ToString(dr["RequestApproverNote"]);
						}
						if (dr["Fk_UserSourceProcess"] != null && dr["Fk_UserSourceProcess"] != DBNull.Value)
						{
							item.Fk_UserSourceProcess = Convert.ToString(dr["Fk_UserSourceProcess"]);
						}
						if (dr["SourceProcessDate"] != null && dr["SourceProcessDate"] != DBNull.Value)
						{
							item.SourceProcessDate = Convert.ToDateTime(dr["SourceProcessDate"]);
						}
						if (dr["Fk_UserSourceApprover"] != null && dr["Fk_UserSourceApprover"] != DBNull.Value)
						{
							item.Fk_UserSourceApprover = Convert.ToString(dr["Fk_UserSourceApprover"]);
						}
						if (dr["SourceApproverDate"] != null && dr["SourceApproverDate"] != DBNull.Value)
						{
							item.SourceApproverDate = Convert.ToDateTime(dr["SourceApproverDate"]);
						}
						if (dr["SourceApproverNote"] != null && dr["SourceApproverNote"] != DBNull.Value)
						{
							item.SourceApproverNote = Convert.ToString(dr["SourceApproverNote"]);
						}
						if (dr["Fk_UserSourceEstimator"] != null && dr["Fk_UserSourceEstimator"] != DBNull.Value)
						{
							item.Fk_UserSourceEstimator = Convert.ToString(dr["Fk_UserSourceEstimator"]);
						}
						if (dr["SourceEstimator"] != null && dr["SourceEstimator"] != DBNull.Value)
						{
							item.SourceEstimator = Convert.ToDateTime(dr["SourceEstimator"]);
						}
						if (dr["SourceEstimatorNote"] != null && dr["SourceEstimatorNote"] != DBNull.Value)
						{
							item.SourceEstimatorNote = Convert.ToString(dr["SourceEstimatorNote"]);
						}
						if (dr["IsLCOFDone"] != null && dr["IsLCOFDone"] != DBNull.Value)
						{
							item.IsLCOFDone = Convert.ToBoolean(dr["IsLCOFDone"]);
						}
						if (dr["Fk_UserLCOFProcess"] != null && dr["Fk_UserLCOFProcess"] != DBNull.Value)
						{
							item.Fk_UserLCOFProcess = Convert.ToString(dr["Fk_UserLCOFProcess"]);
						}
						if (dr["LCOFDate"] != null && dr["LCOFDate"] != DBNull.Value)
						{
							item.LCOFDate = Convert.ToDateTime(dr["LCOFDate"]);
						}
						if (dr["IsCustomsDone"] != null && dr["IsCustomsDone"] != DBNull.Value)
						{
							item.IsCustomsDone = Convert.ToBoolean(dr["IsCustomsDone"]);
						}
						if (dr["Fk_UserCustomsProcess"] != null && dr["Fk_UserCustomsProcess"] != DBNull.Value)
						{
							item.Fk_UserCustomsProcess = Convert.ToString(dr["Fk_UserCustomsProcess"]);
						}
						if (dr["CustomsProcessDate"] != null && dr["CustomsProcessDate"] != DBNull.Value)
						{
							item.CustomsProcessDate = Convert.ToDateTime(dr["CustomsProcessDate"]);
						}
						if (dr["IsTruckingDone"] != null && dr["IsTruckingDone"] != DBNull.Value)
						{
							item.IsTruckingDone = Convert.ToBoolean(dr["IsTruckingDone"]);
						}
						if (dr["Fk_UserTruckingProcess"] != null && dr["Fk_UserTruckingProcess"] != DBNull.Value)
						{
							item.Fk_UserTruckingProcess = Convert.ToString(dr["Fk_UserTruckingProcess"]);
						}
						if (dr["TruckingProcessDate"] != null && dr["TruckingProcessDate"] != DBNull.Value)
						{
							item.TruckingProcessDate = Convert.ToDateTime(dr["TruckingProcessDate"]);
						}
						if (dr["Fk_OPApprover"] != null && dr["Fk_OPApprover"] != DBNull.Value)
						{
							item.Fk_OPApprover = Convert.ToString(dr["Fk_OPApprover"]);
						}
						if (dr["OPApproverDate"] != null && dr["OPApproverDate"] != DBNull.Value)
						{
							item.OPApproverDate = Convert.ToDateTime(dr["OPApproverDate"]);
						}
						if (dr["OPApproverNote"] != null && dr["OPApproverNote"] != DBNull.Value)
						{
							item.OPApproverNote = Convert.ToString(dr["OPApproverNote"]);
						}
						if (dr["IsApproverLCOF"] != null && dr["IsApproverLCOF"] != DBNull.Value)
						{
							item.IsApproverLCOF = Convert.ToBoolean(dr["IsApproverLCOF"]);
						}
						if (dr["IsApproverCustoms"] != null && dr["IsApproverCustoms"] != DBNull.Value)
						{
							item.IsApproverCustoms = Convert.ToBoolean(dr["IsApproverCustoms"]);
						}
						if (dr["IsApproverTrucking"] != null && dr["IsApproverTrucking"] != DBNull.Value)
						{
							item.IsApproverTrucking = Convert.ToBoolean(dr["IsApproverTrucking"]);
						}
						if (dr["Fk_OPEstimator"] != null && dr["Fk_OPEstimator"] != DBNull.Value)
						{
							item.Fk_OPEstimator = Convert.ToString(dr["Fk_OPEstimator"]);
						}
						if (dr["OPEstimatorDate"] != null && dr["OPEstimatorDate"] != DBNull.Value)
						{
							item.OPEstimatorDate = Convert.ToDateTime(dr["OPEstimatorDate"]);
						}
						if (dr["OPEstimatorNote"] != null && dr["OPEstimatorNote"] != DBNull.Value)
						{
							item.OPEstimatorNote = Convert.ToString(dr["OPEstimatorNote"]);
						}
						if (dr["IsEstimatorLCOF"] != null && dr["IsEstimatorLCOF"] != DBNull.Value)
						{
							item.IsEstimatorLCOF = Convert.ToBoolean(dr["IsEstimatorLCOF"]);
						}
						if (dr["IsEstimatorCustoms"] != null && dr["IsEstimatorCustoms"] != DBNull.Value)
						{
							item.IsEstimatorCustoms = Convert.ToBoolean(dr["IsEstimatorCustoms"]);
						}
						if (dr["IsEstimatorTrucking"] != null && dr["IsEstimatorTrucking"] != DBNull.Value)
						{
							item.IsEstimatorTrucking = Convert.ToBoolean(dr["IsEstimatorTrucking"]);
						}
						if (dr["DemoTransferCost"] != null && dr["DemoTransferCost"] != DBNull.Value)
						{
							item.DemoTransferCost = Convert.ToDecimal(dr["DemoTransferCost"]);
						}
						if (dr["DemoCost"] != null && dr["DemoCost"] != DBNull.Value)
						{
							item.DemoCost = Convert.ToDecimal(dr["DemoCost"]);
						}
						if (dr["MoqTransferCost"] != null && dr["MoqTransferCost"] != DBNull.Value)
						{
							item.MoqTransferCost = Convert.ToDecimal(dr["MoqTransferCost"]);
						}
						if (dr["MoqCost"] != null && dr["MoqCost"] != DBNull.Value)
						{
							item.MoqCost = Convert.ToDecimal(dr["MoqCost"]);
						}
						if (dr["DC20TransferCost"] != null && dr["DC20TransferCost"] != DBNull.Value)
						{
							item.DC20TransferCost = Convert.ToDecimal(dr["DC20TransferCost"]);
						}
						if (dr["DC20Cost"] != null && dr["DC20Cost"] != DBNull.Value)
						{
							item.DC20Cost = Convert.ToDecimal(dr["DC20Cost"]);
						}
						if (dr["DC40TransferCost"] != null && dr["DC40TransferCost"] != DBNull.Value)
						{
							item.DC40TransferCost = Convert.ToDecimal(dr["DC40TransferCost"]);
						}
						if (dr["DC40Cost"] != null && dr["DC40Cost"] != DBNull.Value)
						{
							item.DC40Cost = Convert.ToDecimal(dr["DC40Cost"]);
						}
						if (dr["DC40HTransferCost"] != null && dr["DC40HTransferCost"] != DBNull.Value)
						{
							item.DC40HTransferCost = Convert.ToDecimal(dr["DC40HTransferCost"]);
						}
						if (dr["DC40HCost"] != null && dr["DC40HCost"] != DBNull.Value)
						{
							item.DC40HCost = Convert.ToDecimal(dr["DC40HCost"]);
						}
						if (dr["DemoWholesaleCost"] != null && dr["DemoWholesaleCost"] != DBNull.Value)
						{
							item.DemoWholesaleCost = Convert.ToDecimal(dr["DemoWholesaleCost"]);
						}
						if (dr["MoqWholesaleCost"] != null && dr["MoqWholesaleCost"] != DBNull.Value)
						{
							item.MoqWholesaleCost = Convert.ToDecimal(dr["MoqWholesaleCost"]);
						}
						if (dr["DC20WholesaleCost"] != null && dr["DC20WholesaleCost"] != DBNull.Value)
						{
							item.DC20WholesaleCost = Convert.ToDecimal(dr["DC20WholesaleCost"]);
						}
						if (dr["DC40WholesaleCost"] != null && dr["DC40WholesaleCost"] != DBNull.Value)
						{
							item.DC40WholesaleCost = Convert.ToDecimal(dr["DC40WholesaleCost"]);
						}
						if (dr["DC40HWholesaleCost"] != null && dr["DC40HWholesaleCost"] != DBNull.Value)
						{
							item.DC40HWholesaleCost = Convert.ToDecimal(dr["DC40HWholesaleCost"]);
						}
						if (dr["DemoRetailCost"] != null && dr["DemoRetailCost"] != DBNull.Value)
						{
							item.DemoRetailCost = Convert.ToDecimal(dr["DemoRetailCost"]);
						}
						if (dr["MoqRetailCost"] != null && dr["MoqRetailCost"] != DBNull.Value)
						{
							item.MoqRetailCost = Convert.ToDecimal(dr["MoqRetailCost"]);
						}
						if (dr["DC20RetailCost"] != null && dr["DC20RetailCost"] != DBNull.Value)
						{
							item.DC20RetailCost = Convert.ToDecimal(dr["DC20RetailCost"]);
						}
						if (dr["DC40RetailCost"] != null && dr["DC40RetailCost"] != DBNull.Value)
						{
							item.DC40RetailCost = Convert.ToDecimal(dr["DC40RetailCost"]);
						}
						if (dr["DC40HRetailCost"] != null && dr["DC40HRetailCost"] != DBNull.Value)
						{
							item.DC40HRetailCost = Convert.ToDecimal(dr["DC40HRetailCost"]);
						}
						if (dr["DemoWholesalePercent"] != null && dr["DemoWholesalePercent"] != DBNull.Value)
						{
							item.DemoWholesalePercent = Convert.ToInt32(dr["DemoWholesalePercent"]);
						}
						if (dr["MoqWholesalePercent"] != null && dr["MoqWholesalePercent"] != DBNull.Value)
						{
							item.MoqWholesalePercent = Convert.ToInt32(dr["MoqWholesalePercent"]);
						}
						if (dr["DC20WholesalePercent"] != null && dr["DC20WholesalePercent"] != DBNull.Value)
						{
							item.DC20WholesalePercent = Convert.ToInt32(dr["DC20WholesalePercent"]);
						}
						if (dr["DC40WholesalePercent"] != null && dr["DC40WholesalePercent"] != DBNull.Value)
						{
							item.DC40WholesalePercent = Convert.ToInt32(dr["DC40WholesalePercent"]);
						}
						if (dr["DC40HWholesalePercent"] != null && dr["DC40HWholesalePercent"] != DBNull.Value)
						{
							item.DC40HWholesalePercent = Convert.ToInt32(dr["DC40HWholesalePercent"]);
						}
						if (dr["DemoRetailPercent"] != null && dr["DemoRetailPercent"] != DBNull.Value)
						{
							item.DemoRetailPercent = Convert.ToInt32(dr["DemoRetailPercent"]);
						}
						if (dr["MoqRetailPercent"] != null && dr["MoqRetailPercent"] != DBNull.Value)
						{
							item.MoqRetailPercent = Convert.ToInt32(dr["MoqRetailPercent"]);
						}
						if (dr["DC20RetailPercent"] != null && dr["DC20RetailPercent"] != DBNull.Value)
						{
							item.DC20RetailPercent = Convert.ToInt32(dr["DC20RetailPercent"]);
						}
						if (dr["DC40RetailPercent"] != null && dr["DC40RetailPercent"] != DBNull.Value)
						{
							item.DC40RetailPercent = Convert.ToInt32(dr["DC40RetailPercent"]);
						}
						if (dr["DC40HRetailPercent"] != null && dr["DC40HRetailPercent"] != DBNull.Value)
						{
							item.DC40HRetailPercent = Convert.ToInt32(dr["DC40HRetailPercent"]);
						}
						if (dr["DemoWholesalePrice"] != null && dr["DemoWholesalePrice"] != DBNull.Value)
						{
							item.DemoWholesalePrice = Convert.ToDecimal(dr["DemoWholesalePrice"]);
						}
						if (dr["MoqWholesalePrice"] != null && dr["MoqWholesalePrice"] != DBNull.Value)
						{
							item.MoqWholesalePrice = Convert.ToDecimal(dr["MoqWholesalePrice"]);
						}
						if (dr["DC20WholesalePrice"] != null && dr["DC20WholesalePrice"] != DBNull.Value)
						{
							item.DC20WholesalePrice = Convert.ToDecimal(dr["DC20WholesalePrice"]);
						}
						if (dr["DC40WholesalePrice"] != null && dr["DC40WholesalePrice"] != DBNull.Value)
						{
							item.DC40WholesalePrice = Convert.ToDecimal(dr["DC40WholesalePrice"]);
						}
						if (dr["DC40HWholesalePrice"] != null && dr["DC40HWholesalePrice"] != DBNull.Value)
						{
							item.DC40HWholesalePrice = Convert.ToDecimal(dr["DC40HWholesalePrice"]);
						}
						if (dr["DemoRetailPrice"] != null && dr["DemoRetailPrice"] != DBNull.Value)
						{
							item.DemoRetailPrice = Convert.ToDecimal(dr["DemoRetailPrice"]);
						}
						if (dr["MoqRetailPrice"] != null && dr["MoqRetailPrice"] != DBNull.Value)
						{
							item.MoqRetailPrice = Convert.ToDecimal(dr["MoqRetailPrice"]);
						}
						if (dr["DC20RetailPrice"] != null && dr["DC20RetailPrice"] != DBNull.Value)
						{
							item.DC20RetailPrice = Convert.ToDecimal(dr["DC20RetailPrice"]);
						}
						if (dr["DC40RetailPrice"] != null && dr["DC40RetailPrice"] != DBNull.Value)
						{
							item.DC40RetailPrice = Convert.ToDecimal(dr["DC40RetailPrice"]);
						}
						if (dr["DC40HRetailPrice"] != null && dr["DC40HRetailPrice"] != DBNull.Value)
						{
							item.DC40HRetailPrice = Convert.ToDecimal(dr["DC40HRetailPrice"]);
						}
						if (dr["Fk_FinishEstimator"] != null && dr["Fk_FinishEstimator"] != DBNull.Value)
						{
							item.Fk_FinishEstimator = Convert.ToString(dr["Fk_FinishEstimator"]);
						}
						if (dr["FinishEstimatorDate"] != null && dr["FinishEstimatorDate"] != DBNull.Value)
						{
							item.FinishEstimatorDate = Convert.ToDateTime(dr["FinishEstimatorDate"]);
						}
						if (dr["Fk_InventoryItem"] != null && dr["Fk_InventoryItem"] != DBNull.Value)
						{
							item.Fk_InventoryItem = Convert.ToString(dr["Fk_InventoryItem"]);
						}
						if (dr["ReferRequestFindProduct"] != null && dr["ReferRequestFindProduct"] != DBNull.Value)
						{
							item.ReferRequestFindProduct = Convert.ToString(dr["ReferRequestFindProduct"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToInt32(dr["IsDelete"]);
						}
						if (dr["FK_TypeOfRequest"] != null && dr["FK_TypeOfRequest"] != DBNull.Value)
						{
							item.FK_TypeOfRequest = Convert.ToInt32(dr["FK_TypeOfRequest"]);
						}
						if (dr["IsBorderTradeDemo"] != null && dr["IsBorderTradeDemo"] != DBNull.Value)
						{
							item.IsBorderTradeDemo = Convert.ToBoolean(dr["IsBorderTradeDemo"]);
						}
						if (dr["DemoShippingPrice"] != null && dr["DemoShippingPrice"] != DBNull.Value)
						{
							item.DemoShippingPrice = Convert.ToDecimal(dr["DemoShippingPrice"]);
						}
						if (dr["IsBorderTradeMoq"] != null && dr["IsBorderTradeMoq"] != DBNull.Value)
						{
							item.IsBorderTradeMoq = Convert.ToBoolean(dr["IsBorderTradeMoq"]);
						}
						if (dr["MoqShippingPrice"] != null && dr["MoqShippingPrice"] != DBNull.Value)
						{
							item.MoqShippingPrice = Convert.ToDecimal(dr["MoqShippingPrice"]);
						}
						if (dr["IsSkipAllStep"] != null && dr["IsSkipAllStep"] != DBNull.Value)
						{
							item.IsSkipAllStep = Convert.ToBoolean(dr["IsSkipAllStep"]);
						}
						if (dr["WeightFrom"] != null && dr["WeightFrom"] != DBNull.Value)
						{
							item.WeightFrom = Convert.ToString(dr["WeightFrom"]);
						}
						if (dr["WeightTo"] != null && dr["WeightTo"] != DBNull.Value)
						{
							item.WeightTo = Convert.ToString(dr["WeightTo"]);
						}
						if (dr["IsNetWeight"] != null && dr["IsNetWeight"] != DBNull.Value)
						{
							item.IsNetWeight = Convert.ToBoolean(dr["IsNetWeight"]);
						}
						if (dr["WishPrice"] != null && dr["WishPrice"] != DBNull.Value)
						{
							item.WishPrice = Convert.ToDecimal(dr["WishPrice"]);
						}
						if (dr["FK_UnitPacking"] != null && dr["FK_UnitPacking"] != DBNull.Value)
						{
							item.FK_UnitPacking = Convert.ToString(dr["FK_UnitPacking"]);
						}
						if (dr["IsReceptionLCOF"] != null && dr["IsReceptionLCOF"] != DBNull.Value)
						{
							item.IsReceptionLCOF = Convert.ToBoolean(dr["IsReceptionLCOF"]);
						}
						if (dr["IsReceptionCustoms"] != null && dr["IsReceptionCustoms"] != DBNull.Value)
						{
							item.IsReceptionCustoms = Convert.ToBoolean(dr["IsReceptionCustoms"]);
						}
						if (dr["IsReceptionTrucking"] != null && dr["IsReceptionTrucking"] != DBNull.Value)
						{
							item.IsReceptionTrucking = Convert.ToBoolean(dr["IsReceptionTrucking"]);
						}
						if (dr["FK_RequestPrioty"] != null && dr["FK_RequestPrioty"] != DBNull.Value)
						{
							item.FK_RequestPrioty = Convert.ToInt32(dr["FK_RequestPrioty"]);
						}
						if (dr["PriotyName"] != null && dr["PriotyName"] != DBNull.Value)
						{
							item.PriotyName = Convert.ToString(dr["PriotyName"]);
						}
						if (dr["ExportRequestTypeName"] != null && dr["ExportRequestTypeName"] != DBNull.Value)
						{
							item.ExportRequestTypeName = Convert.ToString(dr["ExportRequestTypeName"]);
						}
						if (dr["IsDC20Price"] != null && dr["IsDC20Price"] != DBNull.Value)
						{
							item.IsDC20Price = Convert.ToBoolean(dr["IsDC20Price"]);
						}
						if (dr["IsDC40Price"] != null && dr["IsDC40Price"] != DBNull.Value)
						{
							item.IsDC40Price = Convert.ToBoolean(dr["IsDC40Price"]);
						}
						if (dr["IsDC40HPrice"] != null && dr["IsDC40HPrice"] != DBNull.Value)
						{
							item.IsDC40HPrice = Convert.ToBoolean(dr["IsDC40HPrice"]);
						}
						if (dr["UserCustomsProcess"] != null && dr["UserCustomsProcess"] != DBNull.Value)
						{
							item.UserCustomsProcess = Convert.ToString(dr["UserCustomsProcess"]);
						}
						if (dr["UserLCOFProcess"] != null && dr["UserLCOFProcess"] != DBNull.Value)
						{
							item.UserLCOFProcess = Convert.ToString(dr["UserLCOFProcess"]);
						}
						if (dr["UserTruckingProcess"] != null && dr["UserTruckingProcess"] != DBNull.Value)
						{
							item.UserTruckingProcess = Convert.ToString(dr["UserTruckingProcess"]);
						}
						if (dr["UserRequestApprover"] != null && dr["UserRequestApprover"] != DBNull.Value)
						{
							item.UserRequestApprover = Convert.ToString(dr["UserRequestApprover"]);
						}
						if (dr["UserSourceApprover"] != null && dr["UserSourceApprover"] != DBNull.Value)
						{
							item.UserSourceApprover = Convert.ToString(dr["UserSourceApprover"]);
						}
						if (dr["UserSourceEstimator"] != null && dr["UserSourceEstimator"] != DBNull.Value)
						{
							item.UserSourceEstimator = Convert.ToString(dr["UserSourceEstimator"]);
						}
						if (dr["UserSourceProcess"] != null && dr["UserSourceProcess"] != DBNull.Value)
						{
							item.UserSourceProcess = Convert.ToString(dr["UserSourceProcess"]);
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
		/// Lấy một GsRequestFindProduct đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GsRequestFindProduct GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GsRequestFindProduct] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GsRequestFindProduct item=new GsRequestFindProduct();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["RequestCode"] != null && dr["RequestCode"] != DBNull.Value)
						{
							item.RequestCode = Convert.ToString(dr["RequestCode"]);
						}
						if (dr["ProductName"] != null && dr["ProductName"] != DBNull.Value)
						{
							item.ProductName = Convert.ToString(dr["ProductName"]);
						}
						if (dr["ProductNameUnsign"] != null && dr["ProductNameUnsign"] != DBNull.Value)
						{
							item.ProductNameUnsign = Convert.ToString(dr["ProductNameUnsign"]);
						}
						if (dr["RequestImage"] != null && dr["RequestImage"] != DBNull.Value)
						{
							item.RequestImage = Convert.ToString(dr["RequestImage"]);
						}
						if (dr["BeginRequestDate"] != null && dr["BeginRequestDate"] != DBNull.Value)
						{
							item.BeginRequestDate = Convert.ToDateTime(dr["BeginRequestDate"]);
						}
						if (dr["FK_InventoryCategory"] != null && dr["FK_InventoryCategory"] != DBNull.Value)
						{
							item.FK_InventoryCategory = Convert.ToString(dr["FK_InventoryCategory"]);
						}
						if (dr["Fk_Provine"] != null && dr["Fk_Provine"] != DBNull.Value)
						{
							item.Fk_Provine = Convert.ToString(dr["Fk_Provine"]);
						}
						if (dr["DeliveryAddress"] != null && dr["DeliveryAddress"] != DBNull.Value)
						{
							item.DeliveryAddress = Convert.ToString(dr["DeliveryAddress"]);
						}
						if (dr["Description"] != null && dr["Description"] != DBNull.Value)
						{
							item.Description = Convert.ToString(dr["Description"]);
						}
						if (dr["Quantity"] != null && dr["Quantity"] != DBNull.Value)
						{
							item.Quantity = Convert.ToInt32(dr["Quantity"]);
						}
						if (dr["Fk_Unit"] != null && dr["Fk_Unit"] != DBNull.Value)
						{
							item.Fk_Unit = Convert.ToString(dr["Fk_Unit"]);
						}
						if (dr["Packing"] != null && dr["Packing"] != DBNull.Value)
						{
							item.Packing = Convert.ToString(dr["Packing"]);
						}
						if (dr["QuantityOfPacking"] != null && dr["QuantityOfPacking"] != DBNull.Value)
						{
							item.QuantityOfPacking = Convert.ToDecimal(dr["QuantityOfPacking"]);
						}
						if (dr["WarrantyMonth"] != null && dr["WarrantyMonth"] != DBNull.Value)
						{
							item.WarrantyMonth = Convert.ToInt32(dr["WarrantyMonth"]);
						}
						if (dr["TradeMark"] != null && dr["TradeMark"] != DBNull.Value)
						{
							item.TradeMark = Convert.ToString(dr["TradeMark"]);
						}
						if (dr["DesignTradeMarkFile"] != null && dr["DesignTradeMarkFile"] != DBNull.Value)
						{
							item.DesignTradeMarkFile = Convert.ToString(dr["DesignTradeMarkFile"]);
						}
						if (dr["AdditionalLabel"] != null && dr["AdditionalLabel"] != DBNull.Value)
						{
							item.AdditionalLabel = Convert.ToString(dr["AdditionalLabel"]);
						}
						if (dr["EndRequestDate"] != null && dr["EndRequestDate"] != DBNull.Value)
						{
							item.EndRequestDate = Convert.ToDateTime(dr["EndRequestDate"]);
						}
						if (dr["RequestNote"] != null && dr["RequestNote"] != DBNull.Value)
						{
							item.RequestNote = Convert.ToString(dr["RequestNote"]);
						}
						if (dr["IsCustomerRequest"] != null && dr["IsCustomerRequest"] != DBNull.Value)
						{
							item.IsCustomerRequest = Convert.ToBoolean(dr["IsCustomerRequest"]);
						}
						if (dr["Fk_UserSaleRequest"] != null && dr["Fk_UserSaleRequest"] != DBNull.Value)
						{
							item.Fk_UserSaleRequest = Convert.ToString(dr["Fk_UserSaleRequest"]);
						}
						if (dr["HeightX"] != null && dr["HeightX"] != DBNull.Value)
						{
							item.HeightX = Convert.ToInt32(dr["HeightX"]);
						}
						if (dr["WidthY"] != null && dr["WidthY"] != DBNull.Value)
						{
							item.WidthY = Convert.ToInt32(dr["WidthY"]);
						}
						if (dr["ThicknessZ"] != null && dr["ThicknessZ"] != DBNull.Value)
						{
							item.ThicknessZ = Convert.ToInt32(dr["ThicknessZ"]);
						}
						if (dr["Weight"] != null && dr["Weight"] != DBNull.Value)
						{
							item.Weight = Convert.ToDecimal(dr["Weight"]);
						}
						if (dr["Fk_WeightUnit"] != null && dr["Fk_WeightUnit"] != DBNull.Value)
						{
							item.Fk_WeightUnit = Convert.ToString(dr["Fk_WeightUnit"]);
						}
						if (dr["Fk_Status"] != null && dr["Fk_Status"] != DBNull.Value)
						{
							item.Fk_Status = Convert.ToInt32(dr["Fk_Status"]);
						}
						if (dr["Fk_UserRequestApprover"] != null && dr["Fk_UserRequestApprover"] != DBNull.Value)
						{
							item.Fk_UserRequestApprover = Convert.ToString(dr["Fk_UserRequestApprover"]);
						}
						if (dr["UserRequestApproverDate"] != null && dr["UserRequestApproverDate"] != DBNull.Value)
						{
							item.UserRequestApproverDate = Convert.ToDateTime(dr["UserRequestApproverDate"]);
						}
						if (dr["RequestApproverNote"] != null && dr["RequestApproverNote"] != DBNull.Value)
						{
							item.RequestApproverNote = Convert.ToString(dr["RequestApproverNote"]);
						}
						if (dr["Fk_UserSourceProcess"] != null && dr["Fk_UserSourceProcess"] != DBNull.Value)
						{
							item.Fk_UserSourceProcess = Convert.ToString(dr["Fk_UserSourceProcess"]);
						}
						if (dr["SourceProcessDate"] != null && dr["SourceProcessDate"] != DBNull.Value)
						{
							item.SourceProcessDate = Convert.ToDateTime(dr["SourceProcessDate"]);
						}
						if (dr["Fk_UserSourceApprover"] != null && dr["Fk_UserSourceApprover"] != DBNull.Value)
						{
							item.Fk_UserSourceApprover = Convert.ToString(dr["Fk_UserSourceApprover"]);
						}
						if (dr["SourceApproverDate"] != null && dr["SourceApproverDate"] != DBNull.Value)
						{
							item.SourceApproverDate = Convert.ToDateTime(dr["SourceApproverDate"]);
						}
						if (dr["SourceApproverNote"] != null && dr["SourceApproverNote"] != DBNull.Value)
						{
							item.SourceApproverNote = Convert.ToString(dr["SourceApproverNote"]);
						}
						if (dr["Fk_UserSourceEstimator"] != null && dr["Fk_UserSourceEstimator"] != DBNull.Value)
						{
							item.Fk_UserSourceEstimator = Convert.ToString(dr["Fk_UserSourceEstimator"]);
						}
						if (dr["SourceEstimator"] != null && dr["SourceEstimator"] != DBNull.Value)
						{
							item.SourceEstimator = Convert.ToDateTime(dr["SourceEstimator"]);
						}
						if (dr["SourceEstimatorNote"] != null && dr["SourceEstimatorNote"] != DBNull.Value)
						{
							item.SourceEstimatorNote = Convert.ToString(dr["SourceEstimatorNote"]);
						}
						if (dr["IsLCOFDone"] != null && dr["IsLCOFDone"] != DBNull.Value)
						{
							item.IsLCOFDone = Convert.ToBoolean(dr["IsLCOFDone"]);
						}
						if (dr["Fk_UserLCOFProcess"] != null && dr["Fk_UserLCOFProcess"] != DBNull.Value)
						{
							item.Fk_UserLCOFProcess = Convert.ToString(dr["Fk_UserLCOFProcess"]);
						}
						if (dr["LCOFDate"] != null && dr["LCOFDate"] != DBNull.Value)
						{
							item.LCOFDate = Convert.ToDateTime(dr["LCOFDate"]);
						}
						if (dr["IsCustomsDone"] != null && dr["IsCustomsDone"] != DBNull.Value)
						{
							item.IsCustomsDone = Convert.ToBoolean(dr["IsCustomsDone"]);
						}
						if (dr["Fk_UserCustomsProcess"] != null && dr["Fk_UserCustomsProcess"] != DBNull.Value)
						{
							item.Fk_UserCustomsProcess = Convert.ToString(dr["Fk_UserCustomsProcess"]);
						}
						if (dr["CustomsProcessDate"] != null && dr["CustomsProcessDate"] != DBNull.Value)
						{
							item.CustomsProcessDate = Convert.ToDateTime(dr["CustomsProcessDate"]);
						}
						if (dr["IsTruckingDone"] != null && dr["IsTruckingDone"] != DBNull.Value)
						{
							item.IsTruckingDone = Convert.ToBoolean(dr["IsTruckingDone"]);
						}
						if (dr["Fk_UserTruckingProcess"] != null && dr["Fk_UserTruckingProcess"] != DBNull.Value)
						{
							item.Fk_UserTruckingProcess = Convert.ToString(dr["Fk_UserTruckingProcess"]);
						}
						if (dr["TruckingProcessDate"] != null && dr["TruckingProcessDate"] != DBNull.Value)
						{
							item.TruckingProcessDate = Convert.ToDateTime(dr["TruckingProcessDate"]);
						}
						if (dr["Fk_OPApprover"] != null && dr["Fk_OPApprover"] != DBNull.Value)
						{
							item.Fk_OPApprover = Convert.ToString(dr["Fk_OPApprover"]);
						}
						if (dr["OPApproverDate"] != null && dr["OPApproverDate"] != DBNull.Value)
						{
							item.OPApproverDate = Convert.ToDateTime(dr["OPApproverDate"]);
						}
						if (dr["OPApproverNote"] != null && dr["OPApproverNote"] != DBNull.Value)
						{
							item.OPApproverNote = Convert.ToString(dr["OPApproverNote"]);
						}
						if (dr["IsApproverLCOF"] != null && dr["IsApproverLCOF"] != DBNull.Value)
						{
							item.IsApproverLCOF = Convert.ToBoolean(dr["IsApproverLCOF"]);
						}
						if (dr["IsApproverCustoms"] != null && dr["IsApproverCustoms"] != DBNull.Value)
						{
							item.IsApproverCustoms = Convert.ToBoolean(dr["IsApproverCustoms"]);
						}
						if (dr["IsApproverTrucking"] != null && dr["IsApproverTrucking"] != DBNull.Value)
						{
							item.IsApproverTrucking = Convert.ToBoolean(dr["IsApproverTrucking"]);
						}
						if (dr["Fk_OPEstimator"] != null && dr["Fk_OPEstimator"] != DBNull.Value)
						{
							item.Fk_OPEstimator = Convert.ToString(dr["Fk_OPEstimator"]);
						}
						if (dr["OPEstimatorDate"] != null && dr["OPEstimatorDate"] != DBNull.Value)
						{
							item.OPEstimatorDate = Convert.ToDateTime(dr["OPEstimatorDate"]);
						}
						if (dr["OPEstimatorNote"] != null && dr["OPEstimatorNote"] != DBNull.Value)
						{
							item.OPEstimatorNote = Convert.ToString(dr["OPEstimatorNote"]);
						}
						if (dr["IsEstimatorLCOF"] != null && dr["IsEstimatorLCOF"] != DBNull.Value)
						{
							item.IsEstimatorLCOF = Convert.ToBoolean(dr["IsEstimatorLCOF"]);
						}
						if (dr["IsEstimatorCustoms"] != null && dr["IsEstimatorCustoms"] != DBNull.Value)
						{
							item.IsEstimatorCustoms = Convert.ToBoolean(dr["IsEstimatorCustoms"]);
						}
						if (dr["IsEstimatorTrucking"] != null && dr["IsEstimatorTrucking"] != DBNull.Value)
						{
							item.IsEstimatorTrucking = Convert.ToBoolean(dr["IsEstimatorTrucking"]);
						}
						if (dr["DemoTransferCost"] != null && dr["DemoTransferCost"] != DBNull.Value)
						{
							item.DemoTransferCost = Convert.ToDecimal(dr["DemoTransferCost"]);
						}
						if (dr["DemoCost"] != null && dr["DemoCost"] != DBNull.Value)
						{
							item.DemoCost = Convert.ToDecimal(dr["DemoCost"]);
						}
						if (dr["MoqTransferCost"] != null && dr["MoqTransferCost"] != DBNull.Value)
						{
							item.MoqTransferCost = Convert.ToDecimal(dr["MoqTransferCost"]);
						}
						if (dr["MoqCost"] != null && dr["MoqCost"] != DBNull.Value)
						{
							item.MoqCost = Convert.ToDecimal(dr["MoqCost"]);
						}
						if (dr["DC20TransferCost"] != null && dr["DC20TransferCost"] != DBNull.Value)
						{
							item.DC20TransferCost = Convert.ToDecimal(dr["DC20TransferCost"]);
						}
						if (dr["DC20Cost"] != null && dr["DC20Cost"] != DBNull.Value)
						{
							item.DC20Cost = Convert.ToDecimal(dr["DC20Cost"]);
						}
						if (dr["DC40TransferCost"] != null && dr["DC40TransferCost"] != DBNull.Value)
						{
							item.DC40TransferCost = Convert.ToDecimal(dr["DC40TransferCost"]);
						}
						if (dr["DC40Cost"] != null && dr["DC40Cost"] != DBNull.Value)
						{
							item.DC40Cost = Convert.ToDecimal(dr["DC40Cost"]);
						}
						if (dr["DC40HTransferCost"] != null && dr["DC40HTransferCost"] != DBNull.Value)
						{
							item.DC40HTransferCost = Convert.ToDecimal(dr["DC40HTransferCost"]);
						}
						if (dr["DC40HCost"] != null && dr["DC40HCost"] != DBNull.Value)
						{
							item.DC40HCost = Convert.ToDecimal(dr["DC40HCost"]);
						}
						if (dr["DemoWholesaleCost"] != null && dr["DemoWholesaleCost"] != DBNull.Value)
						{
							item.DemoWholesaleCost = Convert.ToDecimal(dr["DemoWholesaleCost"]);
						}
						if (dr["MoqWholesaleCost"] != null && dr["MoqWholesaleCost"] != DBNull.Value)
						{
							item.MoqWholesaleCost = Convert.ToDecimal(dr["MoqWholesaleCost"]);
						}
						if (dr["DC20WholesaleCost"] != null && dr["DC20WholesaleCost"] != DBNull.Value)
						{
							item.DC20WholesaleCost = Convert.ToDecimal(dr["DC20WholesaleCost"]);
						}
						if (dr["DC40WholesaleCost"] != null && dr["DC40WholesaleCost"] != DBNull.Value)
						{
							item.DC40WholesaleCost = Convert.ToDecimal(dr["DC40WholesaleCost"]);
						}
						if (dr["DC40HWholesaleCost"] != null && dr["DC40HWholesaleCost"] != DBNull.Value)
						{
							item.DC40HWholesaleCost = Convert.ToDecimal(dr["DC40HWholesaleCost"]);
						}
						if (dr["DemoRetailCost"] != null && dr["DemoRetailCost"] != DBNull.Value)
						{
							item.DemoRetailCost = Convert.ToDecimal(dr["DemoRetailCost"]);
						}
						if (dr["MoqRetailCost"] != null && dr["MoqRetailCost"] != DBNull.Value)
						{
							item.MoqRetailCost = Convert.ToDecimal(dr["MoqRetailCost"]);
						}
						if (dr["DC20RetailCost"] != null && dr["DC20RetailCost"] != DBNull.Value)
						{
							item.DC20RetailCost = Convert.ToDecimal(dr["DC20RetailCost"]);
						}
						if (dr["DC40RetailCost"] != null && dr["DC40RetailCost"] != DBNull.Value)
						{
							item.DC40RetailCost = Convert.ToDecimal(dr["DC40RetailCost"]);
						}
						if (dr["DC40HRetailCost"] != null && dr["DC40HRetailCost"] != DBNull.Value)
						{
							item.DC40HRetailCost = Convert.ToDecimal(dr["DC40HRetailCost"]);
						}
						if (dr["DemoWholesalePercent"] != null && dr["DemoWholesalePercent"] != DBNull.Value)
						{
							item.DemoWholesalePercent = Convert.ToInt32(dr["DemoWholesalePercent"]);
						}
						if (dr["MoqWholesalePercent"] != null && dr["MoqWholesalePercent"] != DBNull.Value)
						{
							item.MoqWholesalePercent = Convert.ToInt32(dr["MoqWholesalePercent"]);
						}
						if (dr["DC20WholesalePercent"] != null && dr["DC20WholesalePercent"] != DBNull.Value)
						{
							item.DC20WholesalePercent = Convert.ToInt32(dr["DC20WholesalePercent"]);
						}
						if (dr["DC40WholesalePercent"] != null && dr["DC40WholesalePercent"] != DBNull.Value)
						{
							item.DC40WholesalePercent = Convert.ToInt32(dr["DC40WholesalePercent"]);
						}
						if (dr["DC40HWholesalePercent"] != null && dr["DC40HWholesalePercent"] != DBNull.Value)
						{
							item.DC40HWholesalePercent = Convert.ToInt32(dr["DC40HWholesalePercent"]);
						}
						if (dr["DemoRetailPercent"] != null && dr["DemoRetailPercent"] != DBNull.Value)
						{
							item.DemoRetailPercent = Convert.ToInt32(dr["DemoRetailPercent"]);
						}
						if (dr["MoqRetailPercent"] != null && dr["MoqRetailPercent"] != DBNull.Value)
						{
							item.MoqRetailPercent = Convert.ToInt32(dr["MoqRetailPercent"]);
						}
						if (dr["DC20RetailPercent"] != null && dr["DC20RetailPercent"] != DBNull.Value)
						{
							item.DC20RetailPercent = Convert.ToInt32(dr["DC20RetailPercent"]);
						}
						if (dr["DC40RetailPercent"] != null && dr["DC40RetailPercent"] != DBNull.Value)
						{
							item.DC40RetailPercent = Convert.ToInt32(dr["DC40RetailPercent"]);
						}
						if (dr["DC40HRetailPercent"] != null && dr["DC40HRetailPercent"] != DBNull.Value)
						{
							item.DC40HRetailPercent = Convert.ToInt32(dr["DC40HRetailPercent"]);
						}
						if (dr["DemoWholesalePrice"] != null && dr["DemoWholesalePrice"] != DBNull.Value)
						{
							item.DemoWholesalePrice = Convert.ToDecimal(dr["DemoWholesalePrice"]);
						}
						if (dr["MoqWholesalePrice"] != null && dr["MoqWholesalePrice"] != DBNull.Value)
						{
							item.MoqWholesalePrice = Convert.ToDecimal(dr["MoqWholesalePrice"]);
						}
						if (dr["DC20WholesalePrice"] != null && dr["DC20WholesalePrice"] != DBNull.Value)
						{
							item.DC20WholesalePrice = Convert.ToDecimal(dr["DC20WholesalePrice"]);
						}
						if (dr["DC40WholesalePrice"] != null && dr["DC40WholesalePrice"] != DBNull.Value)
						{
							item.DC40WholesalePrice = Convert.ToDecimal(dr["DC40WholesalePrice"]);
						}
						if (dr["DC40HWholesalePrice"] != null && dr["DC40HWholesalePrice"] != DBNull.Value)
						{
							item.DC40HWholesalePrice = Convert.ToDecimal(dr["DC40HWholesalePrice"]);
						}
						if (dr["DemoRetailPrice"] != null && dr["DemoRetailPrice"] != DBNull.Value)
						{
							item.DemoRetailPrice = Convert.ToDecimal(dr["DemoRetailPrice"]);
						}
						if (dr["MoqRetailPrice"] != null && dr["MoqRetailPrice"] != DBNull.Value)
						{
							item.MoqRetailPrice = Convert.ToDecimal(dr["MoqRetailPrice"]);
						}
						if (dr["DC20RetailPrice"] != null && dr["DC20RetailPrice"] != DBNull.Value)
						{
							item.DC20RetailPrice = Convert.ToDecimal(dr["DC20RetailPrice"]);
						}
						if (dr["DC40RetailPrice"] != null && dr["DC40RetailPrice"] != DBNull.Value)
						{
							item.DC40RetailPrice = Convert.ToDecimal(dr["DC40RetailPrice"]);
						}
						if (dr["DC40HRetailPrice"] != null && dr["DC40HRetailPrice"] != DBNull.Value)
						{
							item.DC40HRetailPrice = Convert.ToDecimal(dr["DC40HRetailPrice"]);
						}
						if (dr["Fk_FinishEstimator"] != null && dr["Fk_FinishEstimator"] != DBNull.Value)
						{
							item.Fk_FinishEstimator = Convert.ToString(dr["Fk_FinishEstimator"]);
						}
						if (dr["FinishEstimatorDate"] != null && dr["FinishEstimatorDate"] != DBNull.Value)
						{
							item.FinishEstimatorDate = Convert.ToDateTime(dr["FinishEstimatorDate"]);
						}
						if (dr["Fk_InventoryItem"] != null && dr["Fk_InventoryItem"] != DBNull.Value)
						{
							item.Fk_InventoryItem = Convert.ToString(dr["Fk_InventoryItem"]);
						}
						if (dr["ReferRequestFindProduct"] != null && dr["ReferRequestFindProduct"] != DBNull.Value)
						{
							item.ReferRequestFindProduct = Convert.ToString(dr["ReferRequestFindProduct"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToInt32(dr["IsDelete"]);
						}
						if (dr["FK_TypeOfRequest"] != null && dr["FK_TypeOfRequest"] != DBNull.Value)
						{
							item.FK_TypeOfRequest = Convert.ToInt32(dr["FK_TypeOfRequest"]);
						}
						if (dr["IsBorderTradeDemo"] != null && dr["IsBorderTradeDemo"] != DBNull.Value)
						{
							item.IsBorderTradeDemo = Convert.ToBoolean(dr["IsBorderTradeDemo"]);
						}
						if (dr["DemoShippingPrice"] != null && dr["DemoShippingPrice"] != DBNull.Value)
						{
							item.DemoShippingPrice = Convert.ToDecimal(dr["DemoShippingPrice"]);
						}
						if (dr["IsBorderTradeMoq"] != null && dr["IsBorderTradeMoq"] != DBNull.Value)
						{
							item.IsBorderTradeMoq = Convert.ToBoolean(dr["IsBorderTradeMoq"]);
						}
						if (dr["MoqShippingPrice"] != null && dr["MoqShippingPrice"] != DBNull.Value)
						{
							item.MoqShippingPrice = Convert.ToDecimal(dr["MoqShippingPrice"]);
						}
						if (dr["IsSkipAllStep"] != null && dr["IsSkipAllStep"] != DBNull.Value)
						{
							item.IsSkipAllStep = Convert.ToBoolean(dr["IsSkipAllStep"]);
						}
						if (dr["WeightFrom"] != null && dr["WeightFrom"] != DBNull.Value)
						{
							item.WeightFrom = Convert.ToString(dr["WeightFrom"]);
						}
						if (dr["WeightTo"] != null && dr["WeightTo"] != DBNull.Value)
						{
							item.WeightTo = Convert.ToString(dr["WeightTo"]);
						}
						if (dr["IsNetWeight"] != null && dr["IsNetWeight"] != DBNull.Value)
						{
							item.IsNetWeight = Convert.ToBoolean(dr["IsNetWeight"]);
						}
						if (dr["WishPrice"] != null && dr["WishPrice"] != DBNull.Value)
						{
							item.WishPrice = Convert.ToDecimal(dr["WishPrice"]);
						}
						if (dr["FK_UnitPacking"] != null && dr["FK_UnitPacking"] != DBNull.Value)
						{
							item.FK_UnitPacking = Convert.ToString(dr["FK_UnitPacking"]);
						}
						if (dr["IsReceptionLCOF"] != null && dr["IsReceptionLCOF"] != DBNull.Value)
						{
							item.IsReceptionLCOF = Convert.ToBoolean(dr["IsReceptionLCOF"]);
						}
						if (dr["IsReceptionCustoms"] != null && dr["IsReceptionCustoms"] != DBNull.Value)
						{
							item.IsReceptionCustoms = Convert.ToBoolean(dr["IsReceptionCustoms"]);
						}
						if (dr["IsReceptionTrucking"] != null && dr["IsReceptionTrucking"] != DBNull.Value)
						{
							item.IsReceptionTrucking = Convert.ToBoolean(dr["IsReceptionTrucking"]);
						}
						if (dr["FK_RequestPrioty"] != null && dr["FK_RequestPrioty"] != DBNull.Value)
						{
							item.FK_RequestPrioty = Convert.ToInt32(dr["FK_RequestPrioty"]);
						}
						if (dr["PriotyName"] != null && dr["PriotyName"] != DBNull.Value)
						{
							item.PriotyName = Convert.ToString(dr["PriotyName"]);
						}
						if (dr["ExportRequestTypeName"] != null && dr["ExportRequestTypeName"] != DBNull.Value)
						{
							item.ExportRequestTypeName = Convert.ToString(dr["ExportRequestTypeName"]);
						}
						if (dr["IsDC20Price"] != null && dr["IsDC20Price"] != DBNull.Value)
						{
							item.IsDC20Price = Convert.ToBoolean(dr["IsDC20Price"]);
						}
						if (dr["IsDC40Price"] != null && dr["IsDC40Price"] != DBNull.Value)
						{
							item.IsDC40Price = Convert.ToBoolean(dr["IsDC40Price"]);
						}
						if (dr["IsDC40HPrice"] != null && dr["IsDC40HPrice"] != DBNull.Value)
						{
							item.IsDC40HPrice = Convert.ToBoolean(dr["IsDC40HPrice"]);
						}
						if (dr["UserCustomsProcess"] != null && dr["UserCustomsProcess"] != DBNull.Value)
						{
							item.UserCustomsProcess = Convert.ToString(dr["UserCustomsProcess"]);
						}
						if (dr["UserLCOFProcess"] != null && dr["UserLCOFProcess"] != DBNull.Value)
						{
							item.UserLCOFProcess = Convert.ToString(dr["UserLCOFProcess"]);
						}
						if (dr["UserTruckingProcess"] != null && dr["UserTruckingProcess"] != DBNull.Value)
						{
							item.UserTruckingProcess = Convert.ToString(dr["UserTruckingProcess"]);
						}
						if (dr["UserRequestApprover"] != null && dr["UserRequestApprover"] != DBNull.Value)
						{
							item.UserRequestApprover = Convert.ToString(dr["UserRequestApprover"]);
						}
						if (dr["UserSourceApprover"] != null && dr["UserSourceApprover"] != DBNull.Value)
						{
							item.UserSourceApprover = Convert.ToString(dr["UserSourceApprover"]);
						}
						if (dr["UserSourceEstimator"] != null && dr["UserSourceEstimator"] != DBNull.Value)
						{
							item.UserSourceEstimator = Convert.ToString(dr["UserSourceEstimator"]);
						}
						if (dr["UserSourceProcess"] != null && dr["UserSourceProcess"] != DBNull.Value)
						{
							item.UserSourceProcess = Convert.ToString(dr["UserSourceProcess"]);
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

		public GsRequestFindProduct GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GsRequestFindProduct] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GsRequestFindProduct>(ds);
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
		/// Thêm mới GsRequestFindProduct vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GsRequestFindProduct _GsRequestFindProduct)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GsRequestFindProduct](Id, RequestCode, ProductName, ProductNameUnsign, RequestImage, BeginRequestDate, FK_InventoryCategory, Fk_Provine, DeliveryAddress, Description, Quantity, Fk_Unit, Packing, QuantityOfPacking, WarrantyMonth, TradeMark, DesignTradeMarkFile, AdditionalLabel, EndRequestDate, RequestNote, IsCustomerRequest, Fk_UserSaleRequest, HeightX, WidthY, ThicknessZ, Weight, Fk_WeightUnit, Fk_Status, Fk_UserRequestApprover, UserRequestApproverDate, RequestApproverNote, Fk_UserSourceProcess, SourceProcessDate, Fk_UserSourceApprover, SourceApproverDate, SourceApproverNote, Fk_UserSourceEstimator, SourceEstimator, SourceEstimatorNote, IsLCOFDone, Fk_UserLCOFProcess, LCOFDate, IsCustomsDone, Fk_UserCustomsProcess, CustomsProcessDate, IsTruckingDone, Fk_UserTruckingProcess, TruckingProcessDate, Fk_OPApprover, OPApproverDate, OPApproverNote, IsApproverLCOF, IsApproverCustoms, IsApproverTrucking, Fk_OPEstimator, OPEstimatorDate, OPEstimatorNote, IsEstimatorLCOF, IsEstimatorCustoms, IsEstimatorTrucking, DemoTransferCost, DemoCost, MoqTransferCost, MoqCost, DC20TransferCost, DC20Cost, DC40TransferCost, DC40Cost, DC40HTransferCost, DC40HCost, DemoWholesaleCost, MoqWholesaleCost, DC20WholesaleCost, DC40WholesaleCost, DC40HWholesaleCost, DemoRetailCost, MoqRetailCost, DC20RetailCost, DC40RetailCost, DC40HRetailCost, DemoWholesalePercent, MoqWholesalePercent, DC20WholesalePercent, DC40WholesalePercent, DC40HWholesalePercent, DemoRetailPercent, MoqRetailPercent, DC20RetailPercent, DC40RetailPercent, DC40HRetailPercent, DemoWholesalePrice, MoqWholesalePrice, DC20WholesalePrice, DC40WholesalePrice, DC40HWholesalePrice, DemoRetailPrice, MoqRetailPrice, DC20RetailPrice, DC40RetailPrice, DC40HRetailPrice, Fk_FinishEstimator, FinishEstimatorDate, Fk_InventoryItem, ReferRequestFindProduct, IsDelete, FK_TypeOfRequest, IsBorderTradeDemo, DemoShippingPrice, IsBorderTradeMoq, MoqShippingPrice, IsSkipAllStep, WeightFrom, WeightTo, IsNetWeight, WishPrice, FK_UnitPacking, IsReceptionLCOF, IsReceptionCustoms, IsReceptionTrucking, FK_RequestPrioty, PriotyName, ExportRequestTypeName, IsDC20Price, IsDC40Price, IsDC40HPrice, UserCustomsProcess, UserLCOFProcess, UserTruckingProcess, UserRequestApprover, UserSourceApprover, UserSourceEstimator, UserSourceProcess) VALUES(@Id, @RequestCode, @ProductName, @ProductNameUnsign, @RequestImage, @BeginRequestDate, @FK_InventoryCategory, @Fk_Provine, @DeliveryAddress, @Description, @Quantity, @Fk_Unit, @Packing, @QuantityOfPacking, @WarrantyMonth, @TradeMark, @DesignTradeMarkFile, @AdditionalLabel, @EndRequestDate, @RequestNote, @IsCustomerRequest, @Fk_UserSaleRequest, @HeightX, @WidthY, @ThicknessZ, @Weight, @Fk_WeightUnit, @Fk_Status, @Fk_UserRequestApprover, @UserRequestApproverDate, @RequestApproverNote, @Fk_UserSourceProcess, @SourceProcessDate, @Fk_UserSourceApprover, @SourceApproverDate, @SourceApproverNote, @Fk_UserSourceEstimator, @SourceEstimator, @SourceEstimatorNote, @IsLCOFDone, @Fk_UserLCOFProcess, @LCOFDate, @IsCustomsDone, @Fk_UserCustomsProcess, @CustomsProcessDate, @IsTruckingDone, @Fk_UserTruckingProcess, @TruckingProcessDate, @Fk_OPApprover, @OPApproverDate, @OPApproverNote, @IsApproverLCOF, @IsApproverCustoms, @IsApproverTrucking, @Fk_OPEstimator, @OPEstimatorDate, @OPEstimatorNote, @IsEstimatorLCOF, @IsEstimatorCustoms, @IsEstimatorTrucking, @DemoTransferCost, @DemoCost, @MoqTransferCost, @MoqCost, @DC20TransferCost, @DC20Cost, @DC40TransferCost, @DC40Cost, @DC40HTransferCost, @DC40HCost, @DemoWholesaleCost, @MoqWholesaleCost, @DC20WholesaleCost, @DC40WholesaleCost, @DC40HWholesaleCost, @DemoRetailCost, @MoqRetailCost, @DC20RetailCost, @DC40RetailCost, @DC40HRetailCost, @DemoWholesalePercent, @MoqWholesalePercent, @DC20WholesalePercent, @DC40WholesalePercent, @DC40HWholesalePercent, @DemoRetailPercent, @MoqRetailPercent, @DC20RetailPercent, @DC40RetailPercent, @DC40HRetailPercent, @DemoWholesalePrice, @MoqWholesalePrice, @DC20WholesalePrice, @DC40WholesalePrice, @DC40HWholesalePrice, @DemoRetailPrice, @MoqRetailPrice, @DC20RetailPrice, @DC40RetailPrice, @DC40HRetailPrice, @Fk_FinishEstimator, @FinishEstimatorDate, @Fk_InventoryItem, @ReferRequestFindProduct, @IsDelete, @FK_TypeOfRequest, @IsBorderTradeDemo, @DemoShippingPrice, @IsBorderTradeMoq, @MoqShippingPrice, @IsSkipAllStep, @WeightFrom, @WeightTo, @IsNetWeight, @WishPrice, @FK_UnitPacking, @IsReceptionLCOF, @IsReceptionCustoms, @IsReceptionTrucking, @FK_RequestPrioty, @PriotyName, @ExportRequestTypeName, @IsDC20Price, @IsDC40Price, @IsDC40HPrice, @UserCustomsProcess, @UserLCOFProcess, @UserTruckingProcess, @UserRequestApprover, @UserSourceApprover, @UserSourceEstimator, @UserSourceProcess)", 
					"@Id",  _GsRequestFindProduct.Id, 
					"@RequestCode",  _GsRequestFindProduct.RequestCode, 
					"@ProductName",  _GsRequestFindProduct.ProductName, 
					"@ProductNameUnsign",  _GsRequestFindProduct.ProductNameUnsign, 
					"@RequestImage",  _GsRequestFindProduct.RequestImage, 
					"@BeginRequestDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.BeginRequestDate), 
					"@FK_InventoryCategory",  _GsRequestFindProduct.FK_InventoryCategory, 
					"@Fk_Provine",  _GsRequestFindProduct.Fk_Provine, 
					"@DeliveryAddress",  _GsRequestFindProduct.DeliveryAddress, 
					"@Description",  _GsRequestFindProduct.Description, 
					"@Quantity",  _GsRequestFindProduct.Quantity, 
					"@Fk_Unit",  _GsRequestFindProduct.Fk_Unit, 
					"@Packing",  _GsRequestFindProduct.Packing, 
					"@QuantityOfPacking",  _GsRequestFindProduct.QuantityOfPacking, 
					"@WarrantyMonth",  _GsRequestFindProduct.WarrantyMonth, 
					"@TradeMark",  _GsRequestFindProduct.TradeMark, 
					"@DesignTradeMarkFile",  _GsRequestFindProduct.DesignTradeMarkFile, 
					"@AdditionalLabel",  _GsRequestFindProduct.AdditionalLabel, 
					"@EndRequestDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.EndRequestDate), 
					"@RequestNote",  _GsRequestFindProduct.RequestNote, 
					"@IsCustomerRequest",  _GsRequestFindProduct.IsCustomerRequest, 
					"@Fk_UserSaleRequest",  _GsRequestFindProduct.Fk_UserSaleRequest, 
					"@HeightX",  _GsRequestFindProduct.HeightX, 
					"@WidthY",  _GsRequestFindProduct.WidthY, 
					"@ThicknessZ",  _GsRequestFindProduct.ThicknessZ, 
					"@Weight",  _GsRequestFindProduct.Weight, 
					"@Fk_WeightUnit",  _GsRequestFindProduct.Fk_WeightUnit, 
					"@Fk_Status",  _GsRequestFindProduct.Fk_Status, 
					"@Fk_UserRequestApprover",  _GsRequestFindProduct.Fk_UserRequestApprover, 
					"@UserRequestApproverDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.UserRequestApproverDate), 
					"@RequestApproverNote",  _GsRequestFindProduct.RequestApproverNote, 
					"@Fk_UserSourceProcess",  _GsRequestFindProduct.Fk_UserSourceProcess, 
					"@SourceProcessDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.SourceProcessDate), 
					"@Fk_UserSourceApprover",  _GsRequestFindProduct.Fk_UserSourceApprover, 
					"@SourceApproverDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.SourceApproverDate), 
					"@SourceApproverNote",  _GsRequestFindProduct.SourceApproverNote, 
					"@Fk_UserSourceEstimator",  _GsRequestFindProduct.Fk_UserSourceEstimator, 
					"@SourceEstimator", this._dataContext.ConvertDateString( _GsRequestFindProduct.SourceEstimator), 
					"@SourceEstimatorNote",  _GsRequestFindProduct.SourceEstimatorNote, 
					"@IsLCOFDone",  _GsRequestFindProduct.IsLCOFDone, 
					"@Fk_UserLCOFProcess",  _GsRequestFindProduct.Fk_UserLCOFProcess, 
					"@LCOFDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.LCOFDate), 
					"@IsCustomsDone",  _GsRequestFindProduct.IsCustomsDone, 
					"@Fk_UserCustomsProcess",  _GsRequestFindProduct.Fk_UserCustomsProcess, 
					"@CustomsProcessDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.CustomsProcessDate), 
					"@IsTruckingDone",  _GsRequestFindProduct.IsTruckingDone, 
					"@Fk_UserTruckingProcess",  _GsRequestFindProduct.Fk_UserTruckingProcess, 
					"@TruckingProcessDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.TruckingProcessDate), 
					"@Fk_OPApprover",  _GsRequestFindProduct.Fk_OPApprover, 
					"@OPApproverDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.OPApproverDate), 
					"@OPApproverNote",  _GsRequestFindProduct.OPApproverNote, 
					"@IsApproverLCOF",  _GsRequestFindProduct.IsApproverLCOF, 
					"@IsApproverCustoms",  _GsRequestFindProduct.IsApproverCustoms, 
					"@IsApproverTrucking",  _GsRequestFindProduct.IsApproverTrucking, 
					"@Fk_OPEstimator",  _GsRequestFindProduct.Fk_OPEstimator, 
					"@OPEstimatorDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.OPEstimatorDate), 
					"@OPEstimatorNote",  _GsRequestFindProduct.OPEstimatorNote, 
					"@IsEstimatorLCOF",  _GsRequestFindProduct.IsEstimatorLCOF, 
					"@IsEstimatorCustoms",  _GsRequestFindProduct.IsEstimatorCustoms, 
					"@IsEstimatorTrucking",  _GsRequestFindProduct.IsEstimatorTrucking, 
					"@DemoTransferCost",  _GsRequestFindProduct.DemoTransferCost, 
					"@DemoCost",  _GsRequestFindProduct.DemoCost, 
					"@MoqTransferCost",  _GsRequestFindProduct.MoqTransferCost, 
					"@MoqCost",  _GsRequestFindProduct.MoqCost, 
					"@DC20TransferCost",  _GsRequestFindProduct.DC20TransferCost, 
					"@DC20Cost",  _GsRequestFindProduct.DC20Cost, 
					"@DC40TransferCost",  _GsRequestFindProduct.DC40TransferCost, 
					"@DC40Cost",  _GsRequestFindProduct.DC40Cost, 
					"@DC40HTransferCost",  _GsRequestFindProduct.DC40HTransferCost, 
					"@DC40HCost",  _GsRequestFindProduct.DC40HCost, 
					"@DemoWholesaleCost",  _GsRequestFindProduct.DemoWholesaleCost, 
					"@MoqWholesaleCost",  _GsRequestFindProduct.MoqWholesaleCost, 
					"@DC20WholesaleCost",  _GsRequestFindProduct.DC20WholesaleCost, 
					"@DC40WholesaleCost",  _GsRequestFindProduct.DC40WholesaleCost, 
					"@DC40HWholesaleCost",  _GsRequestFindProduct.DC40HWholesaleCost, 
					"@DemoRetailCost",  _GsRequestFindProduct.DemoRetailCost, 
					"@MoqRetailCost",  _GsRequestFindProduct.MoqRetailCost, 
					"@DC20RetailCost",  _GsRequestFindProduct.DC20RetailCost, 
					"@DC40RetailCost",  _GsRequestFindProduct.DC40RetailCost, 
					"@DC40HRetailCost",  _GsRequestFindProduct.DC40HRetailCost, 
					"@DemoWholesalePercent",  _GsRequestFindProduct.DemoWholesalePercent, 
					"@MoqWholesalePercent",  _GsRequestFindProduct.MoqWholesalePercent, 
					"@DC20WholesalePercent",  _GsRequestFindProduct.DC20WholesalePercent, 
					"@DC40WholesalePercent",  _GsRequestFindProduct.DC40WholesalePercent, 
					"@DC40HWholesalePercent",  _GsRequestFindProduct.DC40HWholesalePercent, 
					"@DemoRetailPercent",  _GsRequestFindProduct.DemoRetailPercent, 
					"@MoqRetailPercent",  _GsRequestFindProduct.MoqRetailPercent, 
					"@DC20RetailPercent",  _GsRequestFindProduct.DC20RetailPercent, 
					"@DC40RetailPercent",  _GsRequestFindProduct.DC40RetailPercent, 
					"@DC40HRetailPercent",  _GsRequestFindProduct.DC40HRetailPercent, 
					"@DemoWholesalePrice",  _GsRequestFindProduct.DemoWholesalePrice, 
					"@MoqWholesalePrice",  _GsRequestFindProduct.MoqWholesalePrice, 
					"@DC20WholesalePrice",  _GsRequestFindProduct.DC20WholesalePrice, 
					"@DC40WholesalePrice",  _GsRequestFindProduct.DC40WholesalePrice, 
					"@DC40HWholesalePrice",  _GsRequestFindProduct.DC40HWholesalePrice, 
					"@DemoRetailPrice",  _GsRequestFindProduct.DemoRetailPrice, 
					"@MoqRetailPrice",  _GsRequestFindProduct.MoqRetailPrice, 
					"@DC20RetailPrice",  _GsRequestFindProduct.DC20RetailPrice, 
					"@DC40RetailPrice",  _GsRequestFindProduct.DC40RetailPrice, 
					"@DC40HRetailPrice",  _GsRequestFindProduct.DC40HRetailPrice, 
					"@Fk_FinishEstimator",  _GsRequestFindProduct.Fk_FinishEstimator, 
					"@FinishEstimatorDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.FinishEstimatorDate), 
					"@Fk_InventoryItem",  _GsRequestFindProduct.Fk_InventoryItem, 
					"@ReferRequestFindProduct",  _GsRequestFindProduct.ReferRequestFindProduct, 
					"@IsDelete",  _GsRequestFindProduct.IsDelete, 
					"@FK_TypeOfRequest",  _GsRequestFindProduct.FK_TypeOfRequest, 
					"@IsBorderTradeDemo",  _GsRequestFindProduct.IsBorderTradeDemo, 
					"@DemoShippingPrice",  _GsRequestFindProduct.DemoShippingPrice, 
					"@IsBorderTradeMoq",  _GsRequestFindProduct.IsBorderTradeMoq, 
					"@MoqShippingPrice",  _GsRequestFindProduct.MoqShippingPrice, 
					"@IsSkipAllStep",  _GsRequestFindProduct.IsSkipAllStep, 
					"@WeightFrom",  _GsRequestFindProduct.WeightFrom, 
					"@WeightTo",  _GsRequestFindProduct.WeightTo, 
					"@IsNetWeight",  _GsRequestFindProduct.IsNetWeight, 
					"@WishPrice",  _GsRequestFindProduct.WishPrice, 
					"@FK_UnitPacking",  _GsRequestFindProduct.FK_UnitPacking, 
					"@IsReceptionLCOF",  _GsRequestFindProduct.IsReceptionLCOF, 
					"@IsReceptionCustoms",  _GsRequestFindProduct.IsReceptionCustoms, 
					"@IsReceptionTrucking",  _GsRequestFindProduct.IsReceptionTrucking, 
					"@FK_RequestPrioty",  _GsRequestFindProduct.FK_RequestPrioty, 
					"@PriotyName",  _GsRequestFindProduct.PriotyName, 
					"@ExportRequestTypeName",  _GsRequestFindProduct.ExportRequestTypeName, 
					"@IsDC20Price",  _GsRequestFindProduct.IsDC20Price, 
					"@IsDC40Price",  _GsRequestFindProduct.IsDC40Price, 
					"@IsDC40HPrice",  _GsRequestFindProduct.IsDC40HPrice, 
					"@UserCustomsProcess",  _GsRequestFindProduct.UserCustomsProcess, 
					"@UserLCOFProcess",  _GsRequestFindProduct.UserLCOFProcess, 
					"@UserTruckingProcess",  _GsRequestFindProduct.UserTruckingProcess, 
					"@UserRequestApprover",  _GsRequestFindProduct.UserRequestApprover, 
					"@UserSourceApprover",  _GsRequestFindProduct.UserSourceApprover, 
					"@UserSourceEstimator",  _GsRequestFindProduct.UserSourceEstimator, 
					"@UserSourceProcess",  _GsRequestFindProduct.UserSourceProcess);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GsRequestFindProduct vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GsRequestFindProduct> _GsRequestFindProducts)
		{
			foreach (GsRequestFindProduct item in _GsRequestFindProducts)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GsRequestFindProduct vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GsRequestFindProduct _GsRequestFindProduct, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsRequestFindProduct] SET Id=@Id, RequestCode=@RequestCode, ProductName=@ProductName, ProductNameUnsign=@ProductNameUnsign, RequestImage=@RequestImage, BeginRequestDate=@BeginRequestDate, FK_InventoryCategory=@FK_InventoryCategory, Fk_Provine=@Fk_Provine, DeliveryAddress=@DeliveryAddress, Description=@Description, Quantity=@Quantity, Fk_Unit=@Fk_Unit, Packing=@Packing, QuantityOfPacking=@QuantityOfPacking, WarrantyMonth=@WarrantyMonth, TradeMark=@TradeMark, DesignTradeMarkFile=@DesignTradeMarkFile, AdditionalLabel=@AdditionalLabel, EndRequestDate=@EndRequestDate, RequestNote=@RequestNote, IsCustomerRequest=@IsCustomerRequest, Fk_UserSaleRequest=@Fk_UserSaleRequest, HeightX=@HeightX, WidthY=@WidthY, ThicknessZ=@ThicknessZ, Weight=@Weight, Fk_WeightUnit=@Fk_WeightUnit, Fk_Status=@Fk_Status, Fk_UserRequestApprover=@Fk_UserRequestApprover, UserRequestApproverDate=@UserRequestApproverDate, RequestApproverNote=@RequestApproverNote, Fk_UserSourceProcess=@Fk_UserSourceProcess, SourceProcessDate=@SourceProcessDate, Fk_UserSourceApprover=@Fk_UserSourceApprover, SourceApproverDate=@SourceApproverDate, SourceApproverNote=@SourceApproverNote, Fk_UserSourceEstimator=@Fk_UserSourceEstimator, SourceEstimator=@SourceEstimator, SourceEstimatorNote=@SourceEstimatorNote, IsLCOFDone=@IsLCOFDone, Fk_UserLCOFProcess=@Fk_UserLCOFProcess, LCOFDate=@LCOFDate, IsCustomsDone=@IsCustomsDone, Fk_UserCustomsProcess=@Fk_UserCustomsProcess, CustomsProcessDate=@CustomsProcessDate, IsTruckingDone=@IsTruckingDone, Fk_UserTruckingProcess=@Fk_UserTruckingProcess, TruckingProcessDate=@TruckingProcessDate, Fk_OPApprover=@Fk_OPApprover, OPApproverDate=@OPApproverDate, OPApproverNote=@OPApproverNote, IsApproverLCOF=@IsApproverLCOF, IsApproverCustoms=@IsApproverCustoms, IsApproverTrucking=@IsApproverTrucking, Fk_OPEstimator=@Fk_OPEstimator, OPEstimatorDate=@OPEstimatorDate, OPEstimatorNote=@OPEstimatorNote, IsEstimatorLCOF=@IsEstimatorLCOF, IsEstimatorCustoms=@IsEstimatorCustoms, IsEstimatorTrucking=@IsEstimatorTrucking, DemoTransferCost=@DemoTransferCost, DemoCost=@DemoCost, MoqTransferCost=@MoqTransferCost, MoqCost=@MoqCost, DC20TransferCost=@DC20TransferCost, DC20Cost=@DC20Cost, DC40TransferCost=@DC40TransferCost, DC40Cost=@DC40Cost, DC40HTransferCost=@DC40HTransferCost, DC40HCost=@DC40HCost, DemoWholesaleCost=@DemoWholesaleCost, MoqWholesaleCost=@MoqWholesaleCost, DC20WholesaleCost=@DC20WholesaleCost, DC40WholesaleCost=@DC40WholesaleCost, DC40HWholesaleCost=@DC40HWholesaleCost, DemoRetailCost=@DemoRetailCost, MoqRetailCost=@MoqRetailCost, DC20RetailCost=@DC20RetailCost, DC40RetailCost=@DC40RetailCost, DC40HRetailCost=@DC40HRetailCost, DemoWholesalePercent=@DemoWholesalePercent, MoqWholesalePercent=@MoqWholesalePercent, DC20WholesalePercent=@DC20WholesalePercent, DC40WholesalePercent=@DC40WholesalePercent, DC40HWholesalePercent=@DC40HWholesalePercent, DemoRetailPercent=@DemoRetailPercent, MoqRetailPercent=@MoqRetailPercent, DC20RetailPercent=@DC20RetailPercent, DC40RetailPercent=@DC40RetailPercent, DC40HRetailPercent=@DC40HRetailPercent, DemoWholesalePrice=@DemoWholesalePrice, MoqWholesalePrice=@MoqWholesalePrice, DC20WholesalePrice=@DC20WholesalePrice, DC40WholesalePrice=@DC40WholesalePrice, DC40HWholesalePrice=@DC40HWholesalePrice, DemoRetailPrice=@DemoRetailPrice, MoqRetailPrice=@MoqRetailPrice, DC20RetailPrice=@DC20RetailPrice, DC40RetailPrice=@DC40RetailPrice, DC40HRetailPrice=@DC40HRetailPrice, Fk_FinishEstimator=@Fk_FinishEstimator, FinishEstimatorDate=@FinishEstimatorDate, Fk_InventoryItem=@Fk_InventoryItem, ReferRequestFindProduct=@ReferRequestFindProduct, IsDelete=@IsDelete, FK_TypeOfRequest=@FK_TypeOfRequest, IsBorderTradeDemo=@IsBorderTradeDemo, DemoShippingPrice=@DemoShippingPrice, IsBorderTradeMoq=@IsBorderTradeMoq, MoqShippingPrice=@MoqShippingPrice, IsSkipAllStep=@IsSkipAllStep, WeightFrom=@WeightFrom, WeightTo=@WeightTo, IsNetWeight=@IsNetWeight, WishPrice=@WishPrice, FK_UnitPacking=@FK_UnitPacking, IsReceptionLCOF=@IsReceptionLCOF, IsReceptionCustoms=@IsReceptionCustoms, IsReceptionTrucking=@IsReceptionTrucking, FK_RequestPrioty=@FK_RequestPrioty, PriotyName=@PriotyName, ExportRequestTypeName=@ExportRequestTypeName, IsDC20Price=@IsDC20Price, IsDC40Price=@IsDC40Price, IsDC40HPrice=@IsDC40HPrice, UserCustomsProcess=@UserCustomsProcess, UserLCOFProcess=@UserLCOFProcess, UserTruckingProcess=@UserTruckingProcess, UserRequestApprover=@UserRequestApprover, UserSourceApprover=@UserSourceApprover, UserSourceEstimator=@UserSourceEstimator, UserSourceProcess=@UserSourceProcess WHERE Id=@Id", 
					"@Id",  _GsRequestFindProduct.Id, 
					"@RequestCode",  _GsRequestFindProduct.RequestCode, 
					"@ProductName",  _GsRequestFindProduct.ProductName, 
					"@ProductNameUnsign",  _GsRequestFindProduct.ProductNameUnsign, 
					"@RequestImage",  _GsRequestFindProduct.RequestImage, 
					"@BeginRequestDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.BeginRequestDate), 
					"@FK_InventoryCategory",  _GsRequestFindProduct.FK_InventoryCategory, 
					"@Fk_Provine",  _GsRequestFindProduct.Fk_Provine, 
					"@DeliveryAddress",  _GsRequestFindProduct.DeliveryAddress, 
					"@Description",  _GsRequestFindProduct.Description, 
					"@Quantity",  _GsRequestFindProduct.Quantity, 
					"@Fk_Unit",  _GsRequestFindProduct.Fk_Unit, 
					"@Packing",  _GsRequestFindProduct.Packing, 
					"@QuantityOfPacking",  _GsRequestFindProduct.QuantityOfPacking, 
					"@WarrantyMonth",  _GsRequestFindProduct.WarrantyMonth, 
					"@TradeMark",  _GsRequestFindProduct.TradeMark, 
					"@DesignTradeMarkFile",  _GsRequestFindProduct.DesignTradeMarkFile, 
					"@AdditionalLabel",  _GsRequestFindProduct.AdditionalLabel, 
					"@EndRequestDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.EndRequestDate), 
					"@RequestNote",  _GsRequestFindProduct.RequestNote, 
					"@IsCustomerRequest",  _GsRequestFindProduct.IsCustomerRequest, 
					"@Fk_UserSaleRequest",  _GsRequestFindProduct.Fk_UserSaleRequest, 
					"@HeightX",  _GsRequestFindProduct.HeightX, 
					"@WidthY",  _GsRequestFindProduct.WidthY, 
					"@ThicknessZ",  _GsRequestFindProduct.ThicknessZ, 
					"@Weight",  _GsRequestFindProduct.Weight, 
					"@Fk_WeightUnit",  _GsRequestFindProduct.Fk_WeightUnit, 
					"@Fk_Status",  _GsRequestFindProduct.Fk_Status, 
					"@Fk_UserRequestApprover",  _GsRequestFindProduct.Fk_UserRequestApprover, 
					"@UserRequestApproverDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.UserRequestApproverDate), 
					"@RequestApproverNote",  _GsRequestFindProduct.RequestApproverNote, 
					"@Fk_UserSourceProcess",  _GsRequestFindProduct.Fk_UserSourceProcess, 
					"@SourceProcessDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.SourceProcessDate), 
					"@Fk_UserSourceApprover",  _GsRequestFindProduct.Fk_UserSourceApprover, 
					"@SourceApproverDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.SourceApproverDate), 
					"@SourceApproverNote",  _GsRequestFindProduct.SourceApproverNote, 
					"@Fk_UserSourceEstimator",  _GsRequestFindProduct.Fk_UserSourceEstimator, 
					"@SourceEstimator", this._dataContext.ConvertDateString( _GsRequestFindProduct.SourceEstimator), 
					"@SourceEstimatorNote",  _GsRequestFindProduct.SourceEstimatorNote, 
					"@IsLCOFDone",  _GsRequestFindProduct.IsLCOFDone, 
					"@Fk_UserLCOFProcess",  _GsRequestFindProduct.Fk_UserLCOFProcess, 
					"@LCOFDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.LCOFDate), 
					"@IsCustomsDone",  _GsRequestFindProduct.IsCustomsDone, 
					"@Fk_UserCustomsProcess",  _GsRequestFindProduct.Fk_UserCustomsProcess, 
					"@CustomsProcessDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.CustomsProcessDate), 
					"@IsTruckingDone",  _GsRequestFindProduct.IsTruckingDone, 
					"@Fk_UserTruckingProcess",  _GsRequestFindProduct.Fk_UserTruckingProcess, 
					"@TruckingProcessDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.TruckingProcessDate), 
					"@Fk_OPApprover",  _GsRequestFindProduct.Fk_OPApprover, 
					"@OPApproverDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.OPApproverDate), 
					"@OPApproverNote",  _GsRequestFindProduct.OPApproverNote, 
					"@IsApproverLCOF",  _GsRequestFindProduct.IsApproverLCOF, 
					"@IsApproverCustoms",  _GsRequestFindProduct.IsApproverCustoms, 
					"@IsApproverTrucking",  _GsRequestFindProduct.IsApproverTrucking, 
					"@Fk_OPEstimator",  _GsRequestFindProduct.Fk_OPEstimator, 
					"@OPEstimatorDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.OPEstimatorDate), 
					"@OPEstimatorNote",  _GsRequestFindProduct.OPEstimatorNote, 
					"@IsEstimatorLCOF",  _GsRequestFindProduct.IsEstimatorLCOF, 
					"@IsEstimatorCustoms",  _GsRequestFindProduct.IsEstimatorCustoms, 
					"@IsEstimatorTrucking",  _GsRequestFindProduct.IsEstimatorTrucking, 
					"@DemoTransferCost",  _GsRequestFindProduct.DemoTransferCost, 
					"@DemoCost",  _GsRequestFindProduct.DemoCost, 
					"@MoqTransferCost",  _GsRequestFindProduct.MoqTransferCost, 
					"@MoqCost",  _GsRequestFindProduct.MoqCost, 
					"@DC20TransferCost",  _GsRequestFindProduct.DC20TransferCost, 
					"@DC20Cost",  _GsRequestFindProduct.DC20Cost, 
					"@DC40TransferCost",  _GsRequestFindProduct.DC40TransferCost, 
					"@DC40Cost",  _GsRequestFindProduct.DC40Cost, 
					"@DC40HTransferCost",  _GsRequestFindProduct.DC40HTransferCost, 
					"@DC40HCost",  _GsRequestFindProduct.DC40HCost, 
					"@DemoWholesaleCost",  _GsRequestFindProduct.DemoWholesaleCost, 
					"@MoqWholesaleCost",  _GsRequestFindProduct.MoqWholesaleCost, 
					"@DC20WholesaleCost",  _GsRequestFindProduct.DC20WholesaleCost, 
					"@DC40WholesaleCost",  _GsRequestFindProduct.DC40WholesaleCost, 
					"@DC40HWholesaleCost",  _GsRequestFindProduct.DC40HWholesaleCost, 
					"@DemoRetailCost",  _GsRequestFindProduct.DemoRetailCost, 
					"@MoqRetailCost",  _GsRequestFindProduct.MoqRetailCost, 
					"@DC20RetailCost",  _GsRequestFindProduct.DC20RetailCost, 
					"@DC40RetailCost",  _GsRequestFindProduct.DC40RetailCost, 
					"@DC40HRetailCost",  _GsRequestFindProduct.DC40HRetailCost, 
					"@DemoWholesalePercent",  _GsRequestFindProduct.DemoWholesalePercent, 
					"@MoqWholesalePercent",  _GsRequestFindProduct.MoqWholesalePercent, 
					"@DC20WholesalePercent",  _GsRequestFindProduct.DC20WholesalePercent, 
					"@DC40WholesalePercent",  _GsRequestFindProduct.DC40WholesalePercent, 
					"@DC40HWholesalePercent",  _GsRequestFindProduct.DC40HWholesalePercent, 
					"@DemoRetailPercent",  _GsRequestFindProduct.DemoRetailPercent, 
					"@MoqRetailPercent",  _GsRequestFindProduct.MoqRetailPercent, 
					"@DC20RetailPercent",  _GsRequestFindProduct.DC20RetailPercent, 
					"@DC40RetailPercent",  _GsRequestFindProduct.DC40RetailPercent, 
					"@DC40HRetailPercent",  _GsRequestFindProduct.DC40HRetailPercent, 
					"@DemoWholesalePrice",  _GsRequestFindProduct.DemoWholesalePrice, 
					"@MoqWholesalePrice",  _GsRequestFindProduct.MoqWholesalePrice, 
					"@DC20WholesalePrice",  _GsRequestFindProduct.DC20WholesalePrice, 
					"@DC40WholesalePrice",  _GsRequestFindProduct.DC40WholesalePrice, 
					"@DC40HWholesalePrice",  _GsRequestFindProduct.DC40HWholesalePrice, 
					"@DemoRetailPrice",  _GsRequestFindProduct.DemoRetailPrice, 
					"@MoqRetailPrice",  _GsRequestFindProduct.MoqRetailPrice, 
					"@DC20RetailPrice",  _GsRequestFindProduct.DC20RetailPrice, 
					"@DC40RetailPrice",  _GsRequestFindProduct.DC40RetailPrice, 
					"@DC40HRetailPrice",  _GsRequestFindProduct.DC40HRetailPrice, 
					"@Fk_FinishEstimator",  _GsRequestFindProduct.Fk_FinishEstimator, 
					"@FinishEstimatorDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.FinishEstimatorDate), 
					"@Fk_InventoryItem",  _GsRequestFindProduct.Fk_InventoryItem, 
					"@ReferRequestFindProduct",  _GsRequestFindProduct.ReferRequestFindProduct, 
					"@IsDelete",  _GsRequestFindProduct.IsDelete, 
					"@FK_TypeOfRequest",  _GsRequestFindProduct.FK_TypeOfRequest, 
					"@IsBorderTradeDemo",  _GsRequestFindProduct.IsBorderTradeDemo, 
					"@DemoShippingPrice",  _GsRequestFindProduct.DemoShippingPrice, 
					"@IsBorderTradeMoq",  _GsRequestFindProduct.IsBorderTradeMoq, 
					"@MoqShippingPrice",  _GsRequestFindProduct.MoqShippingPrice, 
					"@IsSkipAllStep",  _GsRequestFindProduct.IsSkipAllStep, 
					"@WeightFrom",  _GsRequestFindProduct.WeightFrom, 
					"@WeightTo",  _GsRequestFindProduct.WeightTo, 
					"@IsNetWeight",  _GsRequestFindProduct.IsNetWeight, 
					"@WishPrice",  _GsRequestFindProduct.WishPrice, 
					"@FK_UnitPacking",  _GsRequestFindProduct.FK_UnitPacking, 
					"@IsReceptionLCOF",  _GsRequestFindProduct.IsReceptionLCOF, 
					"@IsReceptionCustoms",  _GsRequestFindProduct.IsReceptionCustoms, 
					"@IsReceptionTrucking",  _GsRequestFindProduct.IsReceptionTrucking, 
					"@FK_RequestPrioty",  _GsRequestFindProduct.FK_RequestPrioty, 
					"@PriotyName",  _GsRequestFindProduct.PriotyName, 
					"@ExportRequestTypeName",  _GsRequestFindProduct.ExportRequestTypeName, 
					"@IsDC20Price",  _GsRequestFindProduct.IsDC20Price, 
					"@IsDC40Price",  _GsRequestFindProduct.IsDC40Price, 
					"@IsDC40HPrice",  _GsRequestFindProduct.IsDC40HPrice, 
					"@UserCustomsProcess",  _GsRequestFindProduct.UserCustomsProcess, 
					"@UserLCOFProcess",  _GsRequestFindProduct.UserLCOFProcess, 
					"@UserTruckingProcess",  _GsRequestFindProduct.UserTruckingProcess, 
					"@UserRequestApprover",  _GsRequestFindProduct.UserRequestApprover, 
					"@UserSourceApprover",  _GsRequestFindProduct.UserSourceApprover, 
					"@UserSourceEstimator",  _GsRequestFindProduct.UserSourceEstimator, 
					"@UserSourceProcess",  _GsRequestFindProduct.UserSourceProcess, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GsRequestFindProduct vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GsRequestFindProduct _GsRequestFindProduct)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsRequestFindProduct] SET RequestCode=@RequestCode, ProductName=@ProductName, ProductNameUnsign=@ProductNameUnsign, RequestImage=@RequestImage, BeginRequestDate=@BeginRequestDate, FK_InventoryCategory=@FK_InventoryCategory, Fk_Provine=@Fk_Provine, DeliveryAddress=@DeliveryAddress, Description=@Description, Quantity=@Quantity, Fk_Unit=@Fk_Unit, Packing=@Packing, QuantityOfPacking=@QuantityOfPacking, WarrantyMonth=@WarrantyMonth, TradeMark=@TradeMark, DesignTradeMarkFile=@DesignTradeMarkFile, AdditionalLabel=@AdditionalLabel, EndRequestDate=@EndRequestDate, RequestNote=@RequestNote, IsCustomerRequest=@IsCustomerRequest, Fk_UserSaleRequest=@Fk_UserSaleRequest, HeightX=@HeightX, WidthY=@WidthY, ThicknessZ=@ThicknessZ, Weight=@Weight, Fk_WeightUnit=@Fk_WeightUnit, Fk_Status=@Fk_Status, Fk_UserRequestApprover=@Fk_UserRequestApprover, UserRequestApproverDate=@UserRequestApproverDate, RequestApproverNote=@RequestApproverNote, Fk_UserSourceProcess=@Fk_UserSourceProcess, SourceProcessDate=@SourceProcessDate, Fk_UserSourceApprover=@Fk_UserSourceApprover, SourceApproverDate=@SourceApproverDate, SourceApproverNote=@SourceApproverNote, Fk_UserSourceEstimator=@Fk_UserSourceEstimator, SourceEstimator=@SourceEstimator, SourceEstimatorNote=@SourceEstimatorNote, IsLCOFDone=@IsLCOFDone, Fk_UserLCOFProcess=@Fk_UserLCOFProcess, LCOFDate=@LCOFDate, IsCustomsDone=@IsCustomsDone, Fk_UserCustomsProcess=@Fk_UserCustomsProcess, CustomsProcessDate=@CustomsProcessDate, IsTruckingDone=@IsTruckingDone, Fk_UserTruckingProcess=@Fk_UserTruckingProcess, TruckingProcessDate=@TruckingProcessDate, Fk_OPApprover=@Fk_OPApprover, OPApproverDate=@OPApproverDate, OPApproverNote=@OPApproverNote, IsApproverLCOF=@IsApproverLCOF, IsApproverCustoms=@IsApproverCustoms, IsApproverTrucking=@IsApproverTrucking, Fk_OPEstimator=@Fk_OPEstimator, OPEstimatorDate=@OPEstimatorDate, OPEstimatorNote=@OPEstimatorNote, IsEstimatorLCOF=@IsEstimatorLCOF, IsEstimatorCustoms=@IsEstimatorCustoms, IsEstimatorTrucking=@IsEstimatorTrucking, DemoTransferCost=@DemoTransferCost, DemoCost=@DemoCost, MoqTransferCost=@MoqTransferCost, MoqCost=@MoqCost, DC20TransferCost=@DC20TransferCost, DC20Cost=@DC20Cost, DC40TransferCost=@DC40TransferCost, DC40Cost=@DC40Cost, DC40HTransferCost=@DC40HTransferCost, DC40HCost=@DC40HCost, DemoWholesaleCost=@DemoWholesaleCost, MoqWholesaleCost=@MoqWholesaleCost, DC20WholesaleCost=@DC20WholesaleCost, DC40WholesaleCost=@DC40WholesaleCost, DC40HWholesaleCost=@DC40HWholesaleCost, DemoRetailCost=@DemoRetailCost, MoqRetailCost=@MoqRetailCost, DC20RetailCost=@DC20RetailCost, DC40RetailCost=@DC40RetailCost, DC40HRetailCost=@DC40HRetailCost, DemoWholesalePercent=@DemoWholesalePercent, MoqWholesalePercent=@MoqWholesalePercent, DC20WholesalePercent=@DC20WholesalePercent, DC40WholesalePercent=@DC40WholesalePercent, DC40HWholesalePercent=@DC40HWholesalePercent, DemoRetailPercent=@DemoRetailPercent, MoqRetailPercent=@MoqRetailPercent, DC20RetailPercent=@DC20RetailPercent, DC40RetailPercent=@DC40RetailPercent, DC40HRetailPercent=@DC40HRetailPercent, DemoWholesalePrice=@DemoWholesalePrice, MoqWholesalePrice=@MoqWholesalePrice, DC20WholesalePrice=@DC20WholesalePrice, DC40WholesalePrice=@DC40WholesalePrice, DC40HWholesalePrice=@DC40HWholesalePrice, DemoRetailPrice=@DemoRetailPrice, MoqRetailPrice=@MoqRetailPrice, DC20RetailPrice=@DC20RetailPrice, DC40RetailPrice=@DC40RetailPrice, DC40HRetailPrice=@DC40HRetailPrice, Fk_FinishEstimator=@Fk_FinishEstimator, FinishEstimatorDate=@FinishEstimatorDate, Fk_InventoryItem=@Fk_InventoryItem, ReferRequestFindProduct=@ReferRequestFindProduct, IsDelete=@IsDelete, FK_TypeOfRequest=@FK_TypeOfRequest, IsBorderTradeDemo=@IsBorderTradeDemo, DemoShippingPrice=@DemoShippingPrice, IsBorderTradeMoq=@IsBorderTradeMoq, MoqShippingPrice=@MoqShippingPrice, IsSkipAllStep=@IsSkipAllStep, WeightFrom=@WeightFrom, WeightTo=@WeightTo, IsNetWeight=@IsNetWeight, WishPrice=@WishPrice, FK_UnitPacking=@FK_UnitPacking, IsReceptionLCOF=@IsReceptionLCOF, IsReceptionCustoms=@IsReceptionCustoms, IsReceptionTrucking=@IsReceptionTrucking, FK_RequestPrioty=@FK_RequestPrioty, PriotyName=@PriotyName, ExportRequestTypeName=@ExportRequestTypeName, IsDC20Price=@IsDC20Price, IsDC40Price=@IsDC40Price, IsDC40HPrice=@IsDC40HPrice, UserCustomsProcess=@UserCustomsProcess, UserLCOFProcess=@UserLCOFProcess, UserTruckingProcess=@UserTruckingProcess, UserRequestApprover=@UserRequestApprover, UserSourceApprover=@UserSourceApprover, UserSourceEstimator=@UserSourceEstimator, UserSourceProcess=@UserSourceProcess WHERE Id=@Id", 
					"@RequestCode",  _GsRequestFindProduct.RequestCode, 
					"@ProductName",  _GsRequestFindProduct.ProductName, 
					"@ProductNameUnsign",  _GsRequestFindProduct.ProductNameUnsign, 
					"@RequestImage",  _GsRequestFindProduct.RequestImage, 
					"@BeginRequestDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.BeginRequestDate), 
					"@FK_InventoryCategory",  _GsRequestFindProduct.FK_InventoryCategory, 
					"@Fk_Provine",  _GsRequestFindProduct.Fk_Provine, 
					"@DeliveryAddress",  _GsRequestFindProduct.DeliveryAddress, 
					"@Description",  _GsRequestFindProduct.Description, 
					"@Quantity",  _GsRequestFindProduct.Quantity, 
					"@Fk_Unit",  _GsRequestFindProduct.Fk_Unit, 
					"@Packing",  _GsRequestFindProduct.Packing, 
					"@QuantityOfPacking",  _GsRequestFindProduct.QuantityOfPacking, 
					"@WarrantyMonth",  _GsRequestFindProduct.WarrantyMonth, 
					"@TradeMark",  _GsRequestFindProduct.TradeMark, 
					"@DesignTradeMarkFile",  _GsRequestFindProduct.DesignTradeMarkFile, 
					"@AdditionalLabel",  _GsRequestFindProduct.AdditionalLabel, 
					"@EndRequestDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.EndRequestDate), 
					"@RequestNote",  _GsRequestFindProduct.RequestNote, 
					"@IsCustomerRequest",  _GsRequestFindProduct.IsCustomerRequest, 
					"@Fk_UserSaleRequest",  _GsRequestFindProduct.Fk_UserSaleRequest, 
					"@HeightX",  _GsRequestFindProduct.HeightX, 
					"@WidthY",  _GsRequestFindProduct.WidthY, 
					"@ThicknessZ",  _GsRequestFindProduct.ThicknessZ, 
					"@Weight",  _GsRequestFindProduct.Weight, 
					"@Fk_WeightUnit",  _GsRequestFindProduct.Fk_WeightUnit, 
					"@Fk_Status",  _GsRequestFindProduct.Fk_Status, 
					"@Fk_UserRequestApprover",  _GsRequestFindProduct.Fk_UserRequestApprover, 
					"@UserRequestApproverDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.UserRequestApproverDate), 
					"@RequestApproverNote",  _GsRequestFindProduct.RequestApproverNote, 
					"@Fk_UserSourceProcess",  _GsRequestFindProduct.Fk_UserSourceProcess, 
					"@SourceProcessDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.SourceProcessDate), 
					"@Fk_UserSourceApprover",  _GsRequestFindProduct.Fk_UserSourceApprover, 
					"@SourceApproverDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.SourceApproverDate), 
					"@SourceApproverNote",  _GsRequestFindProduct.SourceApproverNote, 
					"@Fk_UserSourceEstimator",  _GsRequestFindProduct.Fk_UserSourceEstimator, 
					"@SourceEstimator", this._dataContext.ConvertDateString( _GsRequestFindProduct.SourceEstimator), 
					"@SourceEstimatorNote",  _GsRequestFindProduct.SourceEstimatorNote, 
					"@IsLCOFDone",  _GsRequestFindProduct.IsLCOFDone, 
					"@Fk_UserLCOFProcess",  _GsRequestFindProduct.Fk_UserLCOFProcess, 
					"@LCOFDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.LCOFDate), 
					"@IsCustomsDone",  _GsRequestFindProduct.IsCustomsDone, 
					"@Fk_UserCustomsProcess",  _GsRequestFindProduct.Fk_UserCustomsProcess, 
					"@CustomsProcessDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.CustomsProcessDate), 
					"@IsTruckingDone",  _GsRequestFindProduct.IsTruckingDone, 
					"@Fk_UserTruckingProcess",  _GsRequestFindProduct.Fk_UserTruckingProcess, 
					"@TruckingProcessDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.TruckingProcessDate), 
					"@Fk_OPApprover",  _GsRequestFindProduct.Fk_OPApprover, 
					"@OPApproverDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.OPApproverDate), 
					"@OPApproverNote",  _GsRequestFindProduct.OPApproverNote, 
					"@IsApproverLCOF",  _GsRequestFindProduct.IsApproverLCOF, 
					"@IsApproverCustoms",  _GsRequestFindProduct.IsApproverCustoms, 
					"@IsApproverTrucking",  _GsRequestFindProduct.IsApproverTrucking, 
					"@Fk_OPEstimator",  _GsRequestFindProduct.Fk_OPEstimator, 
					"@OPEstimatorDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.OPEstimatorDate), 
					"@OPEstimatorNote",  _GsRequestFindProduct.OPEstimatorNote, 
					"@IsEstimatorLCOF",  _GsRequestFindProduct.IsEstimatorLCOF, 
					"@IsEstimatorCustoms",  _GsRequestFindProduct.IsEstimatorCustoms, 
					"@IsEstimatorTrucking",  _GsRequestFindProduct.IsEstimatorTrucking, 
					"@DemoTransferCost",  _GsRequestFindProduct.DemoTransferCost, 
					"@DemoCost",  _GsRequestFindProduct.DemoCost, 
					"@MoqTransferCost",  _GsRequestFindProduct.MoqTransferCost, 
					"@MoqCost",  _GsRequestFindProduct.MoqCost, 
					"@DC20TransferCost",  _GsRequestFindProduct.DC20TransferCost, 
					"@DC20Cost",  _GsRequestFindProduct.DC20Cost, 
					"@DC40TransferCost",  _GsRequestFindProduct.DC40TransferCost, 
					"@DC40Cost",  _GsRequestFindProduct.DC40Cost, 
					"@DC40HTransferCost",  _GsRequestFindProduct.DC40HTransferCost, 
					"@DC40HCost",  _GsRequestFindProduct.DC40HCost, 
					"@DemoWholesaleCost",  _GsRequestFindProduct.DemoWholesaleCost, 
					"@MoqWholesaleCost",  _GsRequestFindProduct.MoqWholesaleCost, 
					"@DC20WholesaleCost",  _GsRequestFindProduct.DC20WholesaleCost, 
					"@DC40WholesaleCost",  _GsRequestFindProduct.DC40WholesaleCost, 
					"@DC40HWholesaleCost",  _GsRequestFindProduct.DC40HWholesaleCost, 
					"@DemoRetailCost",  _GsRequestFindProduct.DemoRetailCost, 
					"@MoqRetailCost",  _GsRequestFindProduct.MoqRetailCost, 
					"@DC20RetailCost",  _GsRequestFindProduct.DC20RetailCost, 
					"@DC40RetailCost",  _GsRequestFindProduct.DC40RetailCost, 
					"@DC40HRetailCost",  _GsRequestFindProduct.DC40HRetailCost, 
					"@DemoWholesalePercent",  _GsRequestFindProduct.DemoWholesalePercent, 
					"@MoqWholesalePercent",  _GsRequestFindProduct.MoqWholesalePercent, 
					"@DC20WholesalePercent",  _GsRequestFindProduct.DC20WholesalePercent, 
					"@DC40WholesalePercent",  _GsRequestFindProduct.DC40WholesalePercent, 
					"@DC40HWholesalePercent",  _GsRequestFindProduct.DC40HWholesalePercent, 
					"@DemoRetailPercent",  _GsRequestFindProduct.DemoRetailPercent, 
					"@MoqRetailPercent",  _GsRequestFindProduct.MoqRetailPercent, 
					"@DC20RetailPercent",  _GsRequestFindProduct.DC20RetailPercent, 
					"@DC40RetailPercent",  _GsRequestFindProduct.DC40RetailPercent, 
					"@DC40HRetailPercent",  _GsRequestFindProduct.DC40HRetailPercent, 
					"@DemoWholesalePrice",  _GsRequestFindProduct.DemoWholesalePrice, 
					"@MoqWholesalePrice",  _GsRequestFindProduct.MoqWholesalePrice, 
					"@DC20WholesalePrice",  _GsRequestFindProduct.DC20WholesalePrice, 
					"@DC40WholesalePrice",  _GsRequestFindProduct.DC40WholesalePrice, 
					"@DC40HWholesalePrice",  _GsRequestFindProduct.DC40HWholesalePrice, 
					"@DemoRetailPrice",  _GsRequestFindProduct.DemoRetailPrice, 
					"@MoqRetailPrice",  _GsRequestFindProduct.MoqRetailPrice, 
					"@DC20RetailPrice",  _GsRequestFindProduct.DC20RetailPrice, 
					"@DC40RetailPrice",  _GsRequestFindProduct.DC40RetailPrice, 
					"@DC40HRetailPrice",  _GsRequestFindProduct.DC40HRetailPrice, 
					"@Fk_FinishEstimator",  _GsRequestFindProduct.Fk_FinishEstimator, 
					"@FinishEstimatorDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.FinishEstimatorDate), 
					"@Fk_InventoryItem",  _GsRequestFindProduct.Fk_InventoryItem, 
					"@ReferRequestFindProduct",  _GsRequestFindProduct.ReferRequestFindProduct, 
					"@IsDelete",  _GsRequestFindProduct.IsDelete, 
					"@FK_TypeOfRequest",  _GsRequestFindProduct.FK_TypeOfRequest, 
					"@IsBorderTradeDemo",  _GsRequestFindProduct.IsBorderTradeDemo, 
					"@DemoShippingPrice",  _GsRequestFindProduct.DemoShippingPrice, 
					"@IsBorderTradeMoq",  _GsRequestFindProduct.IsBorderTradeMoq, 
					"@MoqShippingPrice",  _GsRequestFindProduct.MoqShippingPrice, 
					"@IsSkipAllStep",  _GsRequestFindProduct.IsSkipAllStep, 
					"@WeightFrom",  _GsRequestFindProduct.WeightFrom, 
					"@WeightTo",  _GsRequestFindProduct.WeightTo, 
					"@IsNetWeight",  _GsRequestFindProduct.IsNetWeight, 
					"@WishPrice",  _GsRequestFindProduct.WishPrice, 
					"@FK_UnitPacking",  _GsRequestFindProduct.FK_UnitPacking, 
					"@IsReceptionLCOF",  _GsRequestFindProduct.IsReceptionLCOF, 
					"@IsReceptionCustoms",  _GsRequestFindProduct.IsReceptionCustoms, 
					"@IsReceptionTrucking",  _GsRequestFindProduct.IsReceptionTrucking, 
					"@FK_RequestPrioty",  _GsRequestFindProduct.FK_RequestPrioty, 
					"@PriotyName",  _GsRequestFindProduct.PriotyName, 
					"@ExportRequestTypeName",  _GsRequestFindProduct.ExportRequestTypeName, 
					"@IsDC20Price",  _GsRequestFindProduct.IsDC20Price, 
					"@IsDC40Price",  _GsRequestFindProduct.IsDC40Price, 
					"@IsDC40HPrice",  _GsRequestFindProduct.IsDC40HPrice, 
					"@UserCustomsProcess",  _GsRequestFindProduct.UserCustomsProcess, 
					"@UserLCOFProcess",  _GsRequestFindProduct.UserLCOFProcess, 
					"@UserTruckingProcess",  _GsRequestFindProduct.UserTruckingProcess, 
					"@UserRequestApprover",  _GsRequestFindProduct.UserRequestApprover, 
					"@UserSourceApprover",  _GsRequestFindProduct.UserSourceApprover, 
					"@UserSourceEstimator",  _GsRequestFindProduct.UserSourceEstimator, 
					"@UserSourceProcess",  _GsRequestFindProduct.UserSourceProcess, 
					"@Id", _GsRequestFindProduct.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GsRequestFindProduct vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GsRequestFindProduct> _GsRequestFindProducts)
		{
			foreach (GsRequestFindProduct item in _GsRequestFindProducts)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GsRequestFindProduct vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GsRequestFindProduct _GsRequestFindProduct, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GsRequestFindProduct] SET Id=@Id, RequestCode=@RequestCode, ProductName=@ProductName, ProductNameUnsign=@ProductNameUnsign, RequestImage=@RequestImage, BeginRequestDate=@BeginRequestDate, FK_InventoryCategory=@FK_InventoryCategory, Fk_Provine=@Fk_Provine, DeliveryAddress=@DeliveryAddress, Description=@Description, Quantity=@Quantity, Fk_Unit=@Fk_Unit, Packing=@Packing, QuantityOfPacking=@QuantityOfPacking, WarrantyMonth=@WarrantyMonth, TradeMark=@TradeMark, DesignTradeMarkFile=@DesignTradeMarkFile, AdditionalLabel=@AdditionalLabel, EndRequestDate=@EndRequestDate, RequestNote=@RequestNote, IsCustomerRequest=@IsCustomerRequest, Fk_UserSaleRequest=@Fk_UserSaleRequest, HeightX=@HeightX, WidthY=@WidthY, ThicknessZ=@ThicknessZ, Weight=@Weight, Fk_WeightUnit=@Fk_WeightUnit, Fk_Status=@Fk_Status, Fk_UserRequestApprover=@Fk_UserRequestApprover, UserRequestApproverDate=@UserRequestApproverDate, RequestApproverNote=@RequestApproverNote, Fk_UserSourceProcess=@Fk_UserSourceProcess, SourceProcessDate=@SourceProcessDate, Fk_UserSourceApprover=@Fk_UserSourceApprover, SourceApproverDate=@SourceApproverDate, SourceApproverNote=@SourceApproverNote, Fk_UserSourceEstimator=@Fk_UserSourceEstimator, SourceEstimator=@SourceEstimator, SourceEstimatorNote=@SourceEstimatorNote, IsLCOFDone=@IsLCOFDone, Fk_UserLCOFProcess=@Fk_UserLCOFProcess, LCOFDate=@LCOFDate, IsCustomsDone=@IsCustomsDone, Fk_UserCustomsProcess=@Fk_UserCustomsProcess, CustomsProcessDate=@CustomsProcessDate, IsTruckingDone=@IsTruckingDone, Fk_UserTruckingProcess=@Fk_UserTruckingProcess, TruckingProcessDate=@TruckingProcessDate, Fk_OPApprover=@Fk_OPApprover, OPApproverDate=@OPApproverDate, OPApproverNote=@OPApproverNote, IsApproverLCOF=@IsApproverLCOF, IsApproverCustoms=@IsApproverCustoms, IsApproverTrucking=@IsApproverTrucking, Fk_OPEstimator=@Fk_OPEstimator, OPEstimatorDate=@OPEstimatorDate, OPEstimatorNote=@OPEstimatorNote, IsEstimatorLCOF=@IsEstimatorLCOF, IsEstimatorCustoms=@IsEstimatorCustoms, IsEstimatorTrucking=@IsEstimatorTrucking, DemoTransferCost=@DemoTransferCost, DemoCost=@DemoCost, MoqTransferCost=@MoqTransferCost, MoqCost=@MoqCost, DC20TransferCost=@DC20TransferCost, DC20Cost=@DC20Cost, DC40TransferCost=@DC40TransferCost, DC40Cost=@DC40Cost, DC40HTransferCost=@DC40HTransferCost, DC40HCost=@DC40HCost, DemoWholesaleCost=@DemoWholesaleCost, MoqWholesaleCost=@MoqWholesaleCost, DC20WholesaleCost=@DC20WholesaleCost, DC40WholesaleCost=@DC40WholesaleCost, DC40HWholesaleCost=@DC40HWholesaleCost, DemoRetailCost=@DemoRetailCost, MoqRetailCost=@MoqRetailCost, DC20RetailCost=@DC20RetailCost, DC40RetailCost=@DC40RetailCost, DC40HRetailCost=@DC40HRetailCost, DemoWholesalePercent=@DemoWholesalePercent, MoqWholesalePercent=@MoqWholesalePercent, DC20WholesalePercent=@DC20WholesalePercent, DC40WholesalePercent=@DC40WholesalePercent, DC40HWholesalePercent=@DC40HWholesalePercent, DemoRetailPercent=@DemoRetailPercent, MoqRetailPercent=@MoqRetailPercent, DC20RetailPercent=@DC20RetailPercent, DC40RetailPercent=@DC40RetailPercent, DC40HRetailPercent=@DC40HRetailPercent, DemoWholesalePrice=@DemoWholesalePrice, MoqWholesalePrice=@MoqWholesalePrice, DC20WholesalePrice=@DC20WholesalePrice, DC40WholesalePrice=@DC40WholesalePrice, DC40HWholesalePrice=@DC40HWholesalePrice, DemoRetailPrice=@DemoRetailPrice, MoqRetailPrice=@MoqRetailPrice, DC20RetailPrice=@DC20RetailPrice, DC40RetailPrice=@DC40RetailPrice, DC40HRetailPrice=@DC40HRetailPrice, Fk_FinishEstimator=@Fk_FinishEstimator, FinishEstimatorDate=@FinishEstimatorDate, Fk_InventoryItem=@Fk_InventoryItem, ReferRequestFindProduct=@ReferRequestFindProduct, IsDelete=@IsDelete, FK_TypeOfRequest=@FK_TypeOfRequest, IsBorderTradeDemo=@IsBorderTradeDemo, DemoShippingPrice=@DemoShippingPrice, IsBorderTradeMoq=@IsBorderTradeMoq, MoqShippingPrice=@MoqShippingPrice, IsSkipAllStep=@IsSkipAllStep, WeightFrom=@WeightFrom, WeightTo=@WeightTo, IsNetWeight=@IsNetWeight, WishPrice=@WishPrice, FK_UnitPacking=@FK_UnitPacking, IsReceptionLCOF=@IsReceptionLCOF, IsReceptionCustoms=@IsReceptionCustoms, IsReceptionTrucking=@IsReceptionTrucking, FK_RequestPrioty=@FK_RequestPrioty, PriotyName=@PriotyName, ExportRequestTypeName=@ExportRequestTypeName, IsDC20Price=@IsDC20Price, IsDC40Price=@IsDC40Price, IsDC40HPrice=@IsDC40HPrice, UserCustomsProcess=@UserCustomsProcess, UserLCOFProcess=@UserLCOFProcess, UserTruckingProcess=@UserTruckingProcess, UserRequestApprover=@UserRequestApprover, UserSourceApprover=@UserSourceApprover, UserSourceEstimator=@UserSourceEstimator, UserSourceProcess=@UserSourceProcess "+ condition, 
					"@Id",  _GsRequestFindProduct.Id, 
					"@RequestCode",  _GsRequestFindProduct.RequestCode, 
					"@ProductName",  _GsRequestFindProduct.ProductName, 
					"@ProductNameUnsign",  _GsRequestFindProduct.ProductNameUnsign, 
					"@RequestImage",  _GsRequestFindProduct.RequestImage, 
					"@BeginRequestDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.BeginRequestDate), 
					"@FK_InventoryCategory",  _GsRequestFindProduct.FK_InventoryCategory, 
					"@Fk_Provine",  _GsRequestFindProduct.Fk_Provine, 
					"@DeliveryAddress",  _GsRequestFindProduct.DeliveryAddress, 
					"@Description",  _GsRequestFindProduct.Description, 
					"@Quantity",  _GsRequestFindProduct.Quantity, 
					"@Fk_Unit",  _GsRequestFindProduct.Fk_Unit, 
					"@Packing",  _GsRequestFindProduct.Packing, 
					"@QuantityOfPacking",  _GsRequestFindProduct.QuantityOfPacking, 
					"@WarrantyMonth",  _GsRequestFindProduct.WarrantyMonth, 
					"@TradeMark",  _GsRequestFindProduct.TradeMark, 
					"@DesignTradeMarkFile",  _GsRequestFindProduct.DesignTradeMarkFile, 
					"@AdditionalLabel",  _GsRequestFindProduct.AdditionalLabel, 
					"@EndRequestDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.EndRequestDate), 
					"@RequestNote",  _GsRequestFindProduct.RequestNote, 
					"@IsCustomerRequest",  _GsRequestFindProduct.IsCustomerRequest, 
					"@Fk_UserSaleRequest",  _GsRequestFindProduct.Fk_UserSaleRequest, 
					"@HeightX",  _GsRequestFindProduct.HeightX, 
					"@WidthY",  _GsRequestFindProduct.WidthY, 
					"@ThicknessZ",  _GsRequestFindProduct.ThicknessZ, 
					"@Weight",  _GsRequestFindProduct.Weight, 
					"@Fk_WeightUnit",  _GsRequestFindProduct.Fk_WeightUnit, 
					"@Fk_Status",  _GsRequestFindProduct.Fk_Status, 
					"@Fk_UserRequestApprover",  _GsRequestFindProduct.Fk_UserRequestApprover, 
					"@UserRequestApproverDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.UserRequestApproverDate), 
					"@RequestApproverNote",  _GsRequestFindProduct.RequestApproverNote, 
					"@Fk_UserSourceProcess",  _GsRequestFindProduct.Fk_UserSourceProcess, 
					"@SourceProcessDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.SourceProcessDate), 
					"@Fk_UserSourceApprover",  _GsRequestFindProduct.Fk_UserSourceApprover, 
					"@SourceApproverDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.SourceApproverDate), 
					"@SourceApproverNote",  _GsRequestFindProduct.SourceApproverNote, 
					"@Fk_UserSourceEstimator",  _GsRequestFindProduct.Fk_UserSourceEstimator, 
					"@SourceEstimator", this._dataContext.ConvertDateString( _GsRequestFindProduct.SourceEstimator), 
					"@SourceEstimatorNote",  _GsRequestFindProduct.SourceEstimatorNote, 
					"@IsLCOFDone",  _GsRequestFindProduct.IsLCOFDone, 
					"@Fk_UserLCOFProcess",  _GsRequestFindProduct.Fk_UserLCOFProcess, 
					"@LCOFDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.LCOFDate), 
					"@IsCustomsDone",  _GsRequestFindProduct.IsCustomsDone, 
					"@Fk_UserCustomsProcess",  _GsRequestFindProduct.Fk_UserCustomsProcess, 
					"@CustomsProcessDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.CustomsProcessDate), 
					"@IsTruckingDone",  _GsRequestFindProduct.IsTruckingDone, 
					"@Fk_UserTruckingProcess",  _GsRequestFindProduct.Fk_UserTruckingProcess, 
					"@TruckingProcessDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.TruckingProcessDate), 
					"@Fk_OPApprover",  _GsRequestFindProduct.Fk_OPApprover, 
					"@OPApproverDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.OPApproverDate), 
					"@OPApproverNote",  _GsRequestFindProduct.OPApproverNote, 
					"@IsApproverLCOF",  _GsRequestFindProduct.IsApproverLCOF, 
					"@IsApproverCustoms",  _GsRequestFindProduct.IsApproverCustoms, 
					"@IsApproverTrucking",  _GsRequestFindProduct.IsApproverTrucking, 
					"@Fk_OPEstimator",  _GsRequestFindProduct.Fk_OPEstimator, 
					"@OPEstimatorDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.OPEstimatorDate), 
					"@OPEstimatorNote",  _GsRequestFindProduct.OPEstimatorNote, 
					"@IsEstimatorLCOF",  _GsRequestFindProduct.IsEstimatorLCOF, 
					"@IsEstimatorCustoms",  _GsRequestFindProduct.IsEstimatorCustoms, 
					"@IsEstimatorTrucking",  _GsRequestFindProduct.IsEstimatorTrucking, 
					"@DemoTransferCost",  _GsRequestFindProduct.DemoTransferCost, 
					"@DemoCost",  _GsRequestFindProduct.DemoCost, 
					"@MoqTransferCost",  _GsRequestFindProduct.MoqTransferCost, 
					"@MoqCost",  _GsRequestFindProduct.MoqCost, 
					"@DC20TransferCost",  _GsRequestFindProduct.DC20TransferCost, 
					"@DC20Cost",  _GsRequestFindProduct.DC20Cost, 
					"@DC40TransferCost",  _GsRequestFindProduct.DC40TransferCost, 
					"@DC40Cost",  _GsRequestFindProduct.DC40Cost, 
					"@DC40HTransferCost",  _GsRequestFindProduct.DC40HTransferCost, 
					"@DC40HCost",  _GsRequestFindProduct.DC40HCost, 
					"@DemoWholesaleCost",  _GsRequestFindProduct.DemoWholesaleCost, 
					"@MoqWholesaleCost",  _GsRequestFindProduct.MoqWholesaleCost, 
					"@DC20WholesaleCost",  _GsRequestFindProduct.DC20WholesaleCost, 
					"@DC40WholesaleCost",  _GsRequestFindProduct.DC40WholesaleCost, 
					"@DC40HWholesaleCost",  _GsRequestFindProduct.DC40HWholesaleCost, 
					"@DemoRetailCost",  _GsRequestFindProduct.DemoRetailCost, 
					"@MoqRetailCost",  _GsRequestFindProduct.MoqRetailCost, 
					"@DC20RetailCost",  _GsRequestFindProduct.DC20RetailCost, 
					"@DC40RetailCost",  _GsRequestFindProduct.DC40RetailCost, 
					"@DC40HRetailCost",  _GsRequestFindProduct.DC40HRetailCost, 
					"@DemoWholesalePercent",  _GsRequestFindProduct.DemoWholesalePercent, 
					"@MoqWholesalePercent",  _GsRequestFindProduct.MoqWholesalePercent, 
					"@DC20WholesalePercent",  _GsRequestFindProduct.DC20WholesalePercent, 
					"@DC40WholesalePercent",  _GsRequestFindProduct.DC40WholesalePercent, 
					"@DC40HWholesalePercent",  _GsRequestFindProduct.DC40HWholesalePercent, 
					"@DemoRetailPercent",  _GsRequestFindProduct.DemoRetailPercent, 
					"@MoqRetailPercent",  _GsRequestFindProduct.MoqRetailPercent, 
					"@DC20RetailPercent",  _GsRequestFindProduct.DC20RetailPercent, 
					"@DC40RetailPercent",  _GsRequestFindProduct.DC40RetailPercent, 
					"@DC40HRetailPercent",  _GsRequestFindProduct.DC40HRetailPercent, 
					"@DemoWholesalePrice",  _GsRequestFindProduct.DemoWholesalePrice, 
					"@MoqWholesalePrice",  _GsRequestFindProduct.MoqWholesalePrice, 
					"@DC20WholesalePrice",  _GsRequestFindProduct.DC20WholesalePrice, 
					"@DC40WholesalePrice",  _GsRequestFindProduct.DC40WholesalePrice, 
					"@DC40HWholesalePrice",  _GsRequestFindProduct.DC40HWholesalePrice, 
					"@DemoRetailPrice",  _GsRequestFindProduct.DemoRetailPrice, 
					"@MoqRetailPrice",  _GsRequestFindProduct.MoqRetailPrice, 
					"@DC20RetailPrice",  _GsRequestFindProduct.DC20RetailPrice, 
					"@DC40RetailPrice",  _GsRequestFindProduct.DC40RetailPrice, 
					"@DC40HRetailPrice",  _GsRequestFindProduct.DC40HRetailPrice, 
					"@Fk_FinishEstimator",  _GsRequestFindProduct.Fk_FinishEstimator, 
					"@FinishEstimatorDate", this._dataContext.ConvertDateString( _GsRequestFindProduct.FinishEstimatorDate), 
					"@Fk_InventoryItem",  _GsRequestFindProduct.Fk_InventoryItem, 
					"@ReferRequestFindProduct",  _GsRequestFindProduct.ReferRequestFindProduct, 
					"@IsDelete",  _GsRequestFindProduct.IsDelete, 
					"@FK_TypeOfRequest",  _GsRequestFindProduct.FK_TypeOfRequest, 
					"@IsBorderTradeDemo",  _GsRequestFindProduct.IsBorderTradeDemo, 
					"@DemoShippingPrice",  _GsRequestFindProduct.DemoShippingPrice, 
					"@IsBorderTradeMoq",  _GsRequestFindProduct.IsBorderTradeMoq, 
					"@MoqShippingPrice",  _GsRequestFindProduct.MoqShippingPrice, 
					"@IsSkipAllStep",  _GsRequestFindProduct.IsSkipAllStep, 
					"@WeightFrom",  _GsRequestFindProduct.WeightFrom, 
					"@WeightTo",  _GsRequestFindProduct.WeightTo, 
					"@IsNetWeight",  _GsRequestFindProduct.IsNetWeight, 
					"@WishPrice",  _GsRequestFindProduct.WishPrice, 
					"@FK_UnitPacking",  _GsRequestFindProduct.FK_UnitPacking, 
					"@IsReceptionLCOF",  _GsRequestFindProduct.IsReceptionLCOF, 
					"@IsReceptionCustoms",  _GsRequestFindProduct.IsReceptionCustoms, 
					"@IsReceptionTrucking",  _GsRequestFindProduct.IsReceptionTrucking, 
					"@FK_RequestPrioty",  _GsRequestFindProduct.FK_RequestPrioty, 
					"@PriotyName",  _GsRequestFindProduct.PriotyName, 
					"@ExportRequestTypeName",  _GsRequestFindProduct.ExportRequestTypeName, 
					"@IsDC20Price",  _GsRequestFindProduct.IsDC20Price, 
					"@IsDC40Price",  _GsRequestFindProduct.IsDC40Price, 
					"@IsDC40HPrice",  _GsRequestFindProduct.IsDC40HPrice, 
					"@UserCustomsProcess",  _GsRequestFindProduct.UserCustomsProcess, 
					"@UserLCOFProcess",  _GsRequestFindProduct.UserLCOFProcess, 
					"@UserTruckingProcess",  _GsRequestFindProduct.UserTruckingProcess, 
					"@UserRequestApprover",  _GsRequestFindProduct.UserRequestApprover, 
					"@UserSourceApprover",  _GsRequestFindProduct.UserSourceApprover, 
					"@UserSourceEstimator",  _GsRequestFindProduct.UserSourceEstimator, 
					"@UserSourceProcess",  _GsRequestFindProduct.UserSourceProcess);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GsRequestFindProduct trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsRequestFindProduct] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsRequestFindProduct trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GsRequestFindProduct _GsRequestFindProduct)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsRequestFindProduct] WHERE Id=@Id",
					"@Id", _GsRequestFindProduct.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsRequestFindProduct trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GsRequestFindProduct] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GsRequestFindProduct trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GsRequestFindProduct> _GsRequestFindProducts)
		{
			foreach (GsRequestFindProduct item in _GsRequestFindProducts)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
