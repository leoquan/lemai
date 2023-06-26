using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MGExpprovider:IGExpprovider
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MGExpprovider(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable GExpProvider từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProvider]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable GExpProvider từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProvider] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách GExpProvider từ Database
		/// </summary>
		public List<GExpProvider> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProvider]");
				List<GExpProvider> items = new List<GExpProvider>();
				GExpProvider item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpProvider();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["ProviderName"] != null && dr["ProviderName"] != DBNull.Value)
					{
						item.ProviderName = Convert.ToString(dr["ProviderName"]);
					}
					if (dr["Token"] != null && dr["Token"] != DBNull.Value)
					{
						item.Token = Convert.ToString(dr["Token"]);
					}
					if (dr["UserApi"] != null && dr["UserApi"] != DBNull.Value)
					{
						item.UserApi = Convert.ToString(dr["UserApi"]);
					}
					if (dr["PassApi"] != null && dr["PassApi"] != DBNull.Value)
					{
						item.PassApi = Convert.ToString(dr["PassApi"]);
					}
					if (dr["ShopId"] != null && dr["ShopId"] != DBNull.Value)
					{
						item.ShopId = Convert.ToString(dr["ShopId"]);
					}
					if (dr["ClientId"] != null && dr["ClientId"] != DBNull.Value)
					{
						item.ClientId = Convert.ToString(dr["ClientId"]);
					}
					if (dr["Post"] != null && dr["Post"] != DBNull.Value)
					{
						item.Post = Convert.ToString(dr["Post"]);
					}
					if (dr["Address"] != null && dr["Address"] != DBNull.Value)
					{
						item.Address = Convert.ToString(dr["Address"]);
					}
					if (dr["Email"] != null && dr["Email"] != DBNull.Value)
					{
						item.Email = Convert.ToString(dr["Email"]);
					}
					if (dr["ShopName"] != null && dr["ShopName"] != DBNull.Value)
					{
						item.ShopName = Convert.ToString(dr["ShopName"]);
					}
					if (dr["ShopPhone"] != null && dr["ShopPhone"] != DBNull.Value)
					{
						item.ShopPhone = Convert.ToString(dr["ShopPhone"]);
					}
					if (dr["ProviderTypeCode"] != null && dr["ProviderTypeCode"] != DBNull.Value)
					{
						item.ProviderTypeCode = Convert.ToString(dr["ProviderTypeCode"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["AutoSelect"] != null && dr["AutoSelect"] != DBNull.Value)
					{
						item.AutoSelect = Convert.ToBoolean(dr["AutoSelect"]);
					}
					if (dr["InitWeightSelect"] != null && dr["InitWeightSelect"] != DBNull.Value)
					{
						item.InitWeightSelect = Convert.ToInt32(dr["InitWeightSelect"]);
					}
					if (dr["InitWeightSelectMax"] != null && dr["InitWeightSelectMax"] != DBNull.Value)
					{
						item.InitWeightSelectMax = Convert.ToInt32(dr["InitWeightSelectMax"]);
					}
					if (dr["SelectIndex"] != null && dr["SelectIndex"] != DBNull.Value)
					{
						item.SelectIndex = Convert.ToInt32(dr["SelectIndex"]);
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
					if (dr["ServiceId"] != null && dr["ServiceId"] != DBNull.Value)
					{
						item.ServiceId = Convert.ToString(dr["ServiceId"]);
					}
					if (dr["PostBT3Id"] != null && dr["PostBT3Id"] != DBNull.Value)
					{
						item.PostBT3Id = Convert.ToString(dr["PostBT3Id"]);
					}
					if (dr["RunMode"] != null && dr["RunMode"] != DBNull.Value)
					{
						item.RunMode = Convert.ToInt32(dr["RunMode"]);
					}
					if (dr["TrackLink"] != null && dr["TrackLink"] != DBNull.Value)
					{
						item.TrackLink = Convert.ToString(dr["TrackLink"]);
					}
					if (dr["WhiteListProvince"] != null && dr["WhiteListProvince"] != DBNull.Value)
					{
						item.WhiteListProvince = Convert.ToString(dr["WhiteListProvince"]);
					}
					if (dr["BlackListProvince"] != null && dr["BlackListProvince"] != DBNull.Value)
					{
						item.BlackListProvince = Convert.ToString(dr["BlackListProvince"]);
					}
					if (dr["GroupProvider"] != null && dr["GroupProvider"] != DBNull.Value)
					{
						item.GroupProvider = Convert.ToString(dr["GroupProvider"]);
					}
					if (dr["InsuranceValue"] != null && dr["InsuranceValue"] != DBNull.Value)
					{
						item.InsuranceValue = Convert.ToInt32(dr["InsuranceValue"]);
					}
					if (dr["ExpiresDate"] != null && dr["ExpiresDate"] != DBNull.Value)
					{
						item.ExpiresDate = Convert.ToDateTime(dr["ExpiresDate"]);
					}
					if (dr["ClientSecrect"] != null && dr["ClientSecrect"] != DBNull.Value)
					{
						item.ClientSecrect = Convert.ToString(dr["ClientSecrect"]);
					}
					if (dr["PrintLable"] != null && dr["PrintLable"] != DBNull.Value)
					{
						item.PrintLable = Convert.ToString(dr["PrintLable"]);
					}
					if (dr["DeliveryInitPrice"] != null && dr["DeliveryInitPrice"] != DBNull.Value)
					{
						item.DeliveryInitPrice = Convert.ToInt32(dr["DeliveryInitPrice"]);
					}
					if (dr["DeliveryInitWeight"] != null && dr["DeliveryInitWeight"] != DBNull.Value)
					{
						item.DeliveryInitWeight = Convert.ToInt32(dr["DeliveryInitWeight"]);
					}
					if (dr["DeliveryStepWeight"] != null && dr["DeliveryStepWeight"] != DBNull.Value)
					{
						item.DeliveryStepWeight = Convert.ToInt32(dr["DeliveryStepWeight"]);
					}
					if (dr["DeliveryStepPrice"] != null && dr["DeliveryStepPrice"] != DBNull.Value)
					{
						item.DeliveryStepPrice = Convert.ToInt32(dr["DeliveryStepPrice"]);
					}
					if (dr["SysInitPrice"] != null && dr["SysInitPrice"] != DBNull.Value)
					{
						item.SysInitPrice = Convert.ToInt32(dr["SysInitPrice"]);
					}
					if (dr["SysInitWeight"] != null && dr["SysInitWeight"] != DBNull.Value)
					{
						item.SysInitWeight = Convert.ToInt32(dr["SysInitWeight"]);
					}
					if (dr["SysStepWeight"] != null && dr["SysStepWeight"] != DBNull.Value)
					{
						item.SysStepWeight = Convert.ToInt32(dr["SysStepWeight"]);
					}
					if (dr["SysStepPrice"] != null && dr["SysStepPrice"] != DBNull.Value)
					{
						item.SysStepPrice = Convert.ToInt32(dr["SysStepPrice"]);
					}
					if (dr["TranInitPrice"] != null && dr["TranInitPrice"] != DBNull.Value)
					{
						item.TranInitPrice = Convert.ToInt32(dr["TranInitPrice"]);
					}
					if (dr["TranInitWeight"] != null && dr["TranInitWeight"] != DBNull.Value)
					{
						item.TranInitWeight = Convert.ToInt32(dr["TranInitWeight"]);
					}
					if (dr["TranStepWeight"] != null && dr["TranStepWeight"] != DBNull.Value)
					{
						item.TranStepWeight = Convert.ToInt32(dr["TranStepWeight"]);
					}
					if (dr["TranStepPrice"] != null && dr["TranStepPrice"] != DBNull.Value)
					{
						item.TranStepPrice = Convert.ToInt32(dr["TranStepPrice"]);
					}
					if (dr["DistrictWhiteList"] != null && dr["DistrictWhiteList"] != DBNull.Value)
					{
						item.DistrictWhiteList = Convert.ToString(dr["DistrictWhiteList"]);
					}
					if (dr["ManualSign"] != null && dr["ManualSign"] != DBNull.Value)
					{
						item.ManualSign = Convert.ToBoolean(dr["ManualSign"]);
					}
					if (dr["IsPickup"] != null && dr["IsPickup"] != DBNull.Value)
					{
						item.IsPickup = Convert.ToBoolean(dr["IsPickup"]);
					}
					if (dr["LinkCustomerLogin"] != null && dr["LinkCustomerLogin"] != DBNull.Value)
					{
						item.LinkCustomerLogin = Convert.ToString(dr["LinkCustomerLogin"]);
					}
					if (dr["IsOwner"] != null && dr["IsOwner"] != DBNull.Value)
					{
						item.IsOwner = Convert.ToBoolean(dr["IsOwner"]);
					}
					if (dr["PercentConfig"] != null && dr["PercentConfig"] != DBNull.Value)
					{
						item.PercentConfig = Convert.ToInt32(dr["PercentConfig"]);
					}
					if (dr["AlwayReceivePay"] != null && dr["AlwayReceivePay"] != DBNull.Value)
					{
						item.AlwayReceivePay = Convert.ToBoolean(dr["AlwayReceivePay"]);
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
		/// Lấy danh sách GExpProvider từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<GExpProvider> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpProvider] A "+ condition,  parameters);
				List<GExpProvider> items = new List<GExpProvider>();
				GExpProvider item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new GExpProvider();
					if (dr["Id"] != null && dr["Id"] != DBNull.Value)
					{
						item.Id = Convert.ToString(dr["Id"]);
					}
					if (dr["ProviderName"] != null && dr["ProviderName"] != DBNull.Value)
					{
						item.ProviderName = Convert.ToString(dr["ProviderName"]);
					}
					if (dr["Token"] != null && dr["Token"] != DBNull.Value)
					{
						item.Token = Convert.ToString(dr["Token"]);
					}
					if (dr["UserApi"] != null && dr["UserApi"] != DBNull.Value)
					{
						item.UserApi = Convert.ToString(dr["UserApi"]);
					}
					if (dr["PassApi"] != null && dr["PassApi"] != DBNull.Value)
					{
						item.PassApi = Convert.ToString(dr["PassApi"]);
					}
					if (dr["ShopId"] != null && dr["ShopId"] != DBNull.Value)
					{
						item.ShopId = Convert.ToString(dr["ShopId"]);
					}
					if (dr["ClientId"] != null && dr["ClientId"] != DBNull.Value)
					{
						item.ClientId = Convert.ToString(dr["ClientId"]);
					}
					if (dr["Post"] != null && dr["Post"] != DBNull.Value)
					{
						item.Post = Convert.ToString(dr["Post"]);
					}
					if (dr["Address"] != null && dr["Address"] != DBNull.Value)
					{
						item.Address = Convert.ToString(dr["Address"]);
					}
					if (dr["Email"] != null && dr["Email"] != DBNull.Value)
					{
						item.Email = Convert.ToString(dr["Email"]);
					}
					if (dr["ShopName"] != null && dr["ShopName"] != DBNull.Value)
					{
						item.ShopName = Convert.ToString(dr["ShopName"]);
					}
					if (dr["ShopPhone"] != null && dr["ShopPhone"] != DBNull.Value)
					{
						item.ShopPhone = Convert.ToString(dr["ShopPhone"]);
					}
					if (dr["ProviderTypeCode"] != null && dr["ProviderTypeCode"] != DBNull.Value)
					{
						item.ProviderTypeCode = Convert.ToString(dr["ProviderTypeCode"]);
					}
					if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
					{
						item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
					}
					if (dr["AutoSelect"] != null && dr["AutoSelect"] != DBNull.Value)
					{
						item.AutoSelect = Convert.ToBoolean(dr["AutoSelect"]);
					}
					if (dr["InitWeightSelect"] != null && dr["InitWeightSelect"] != DBNull.Value)
					{
						item.InitWeightSelect = Convert.ToInt32(dr["InitWeightSelect"]);
					}
					if (dr["InitWeightSelectMax"] != null && dr["InitWeightSelectMax"] != DBNull.Value)
					{
						item.InitWeightSelectMax = Convert.ToInt32(dr["InitWeightSelectMax"]);
					}
					if (dr["SelectIndex"] != null && dr["SelectIndex"] != DBNull.Value)
					{
						item.SelectIndex = Convert.ToInt32(dr["SelectIndex"]);
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
					if (dr["ServiceId"] != null && dr["ServiceId"] != DBNull.Value)
					{
						item.ServiceId = Convert.ToString(dr["ServiceId"]);
					}
					if (dr["PostBT3Id"] != null && dr["PostBT3Id"] != DBNull.Value)
					{
						item.PostBT3Id = Convert.ToString(dr["PostBT3Id"]);
					}
					if (dr["RunMode"] != null && dr["RunMode"] != DBNull.Value)
					{
						item.RunMode = Convert.ToInt32(dr["RunMode"]);
					}
					if (dr["TrackLink"] != null && dr["TrackLink"] != DBNull.Value)
					{
						item.TrackLink = Convert.ToString(dr["TrackLink"]);
					}
					if (dr["WhiteListProvince"] != null && dr["WhiteListProvince"] != DBNull.Value)
					{
						item.WhiteListProvince = Convert.ToString(dr["WhiteListProvince"]);
					}
					if (dr["BlackListProvince"] != null && dr["BlackListProvince"] != DBNull.Value)
					{
						item.BlackListProvince = Convert.ToString(dr["BlackListProvince"]);
					}
					if (dr["GroupProvider"] != null && dr["GroupProvider"] != DBNull.Value)
					{
						item.GroupProvider = Convert.ToString(dr["GroupProvider"]);
					}
					if (dr["InsuranceValue"] != null && dr["InsuranceValue"] != DBNull.Value)
					{
						item.InsuranceValue = Convert.ToInt32(dr["InsuranceValue"]);
					}
					if (dr["ExpiresDate"] != null && dr["ExpiresDate"] != DBNull.Value)
					{
						item.ExpiresDate = Convert.ToDateTime(dr["ExpiresDate"]);
					}
					if (dr["ClientSecrect"] != null && dr["ClientSecrect"] != DBNull.Value)
					{
						item.ClientSecrect = Convert.ToString(dr["ClientSecrect"]);
					}
					if (dr["PrintLable"] != null && dr["PrintLable"] != DBNull.Value)
					{
						item.PrintLable = Convert.ToString(dr["PrintLable"]);
					}
					if (dr["DeliveryInitPrice"] != null && dr["DeliveryInitPrice"] != DBNull.Value)
					{
						item.DeliveryInitPrice = Convert.ToInt32(dr["DeliveryInitPrice"]);
					}
					if (dr["DeliveryInitWeight"] != null && dr["DeliveryInitWeight"] != DBNull.Value)
					{
						item.DeliveryInitWeight = Convert.ToInt32(dr["DeliveryInitWeight"]);
					}
					if (dr["DeliveryStepWeight"] != null && dr["DeliveryStepWeight"] != DBNull.Value)
					{
						item.DeliveryStepWeight = Convert.ToInt32(dr["DeliveryStepWeight"]);
					}
					if (dr["DeliveryStepPrice"] != null && dr["DeliveryStepPrice"] != DBNull.Value)
					{
						item.DeliveryStepPrice = Convert.ToInt32(dr["DeliveryStepPrice"]);
					}
					if (dr["SysInitPrice"] != null && dr["SysInitPrice"] != DBNull.Value)
					{
						item.SysInitPrice = Convert.ToInt32(dr["SysInitPrice"]);
					}
					if (dr["SysInitWeight"] != null && dr["SysInitWeight"] != DBNull.Value)
					{
						item.SysInitWeight = Convert.ToInt32(dr["SysInitWeight"]);
					}
					if (dr["SysStepWeight"] != null && dr["SysStepWeight"] != DBNull.Value)
					{
						item.SysStepWeight = Convert.ToInt32(dr["SysStepWeight"]);
					}
					if (dr["SysStepPrice"] != null && dr["SysStepPrice"] != DBNull.Value)
					{
						item.SysStepPrice = Convert.ToInt32(dr["SysStepPrice"]);
					}
					if (dr["TranInitPrice"] != null && dr["TranInitPrice"] != DBNull.Value)
					{
						item.TranInitPrice = Convert.ToInt32(dr["TranInitPrice"]);
					}
					if (dr["TranInitWeight"] != null && dr["TranInitWeight"] != DBNull.Value)
					{
						item.TranInitWeight = Convert.ToInt32(dr["TranInitWeight"]);
					}
					if (dr["TranStepWeight"] != null && dr["TranStepWeight"] != DBNull.Value)
					{
						item.TranStepWeight = Convert.ToInt32(dr["TranStepWeight"]);
					}
					if (dr["TranStepPrice"] != null && dr["TranStepPrice"] != DBNull.Value)
					{
						item.TranStepPrice = Convert.ToInt32(dr["TranStepPrice"]);
					}
					if (dr["DistrictWhiteList"] != null && dr["DistrictWhiteList"] != DBNull.Value)
					{
						item.DistrictWhiteList = Convert.ToString(dr["DistrictWhiteList"]);
					}
					if (dr["ManualSign"] != null && dr["ManualSign"] != DBNull.Value)
					{
						item.ManualSign = Convert.ToBoolean(dr["ManualSign"]);
					}
					if (dr["IsPickup"] != null && dr["IsPickup"] != DBNull.Value)
					{
						item.IsPickup = Convert.ToBoolean(dr["IsPickup"]);
					}
					if (dr["LinkCustomerLogin"] != null && dr["LinkCustomerLogin"] != DBNull.Value)
					{
						item.LinkCustomerLogin = Convert.ToString(dr["LinkCustomerLogin"]);
					}
					if (dr["IsOwner"] != null && dr["IsOwner"] != DBNull.Value)
					{
						item.IsOwner = Convert.ToBoolean(dr["IsOwner"]);
					}
					if (dr["PercentConfig"] != null && dr["PercentConfig"] != DBNull.Value)
					{
						item.PercentConfig = Convert.ToInt32(dr["PercentConfig"]);
					}
					if (dr["AlwayReceivePay"] != null && dr["AlwayReceivePay"] != DBNull.Value)
					{
						item.AlwayReceivePay = Convert.ToBoolean(dr["AlwayReceivePay"]);
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

		public List<GExpProvider> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpProvider] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[GExpProvider] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<GExpProvider>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một GExpProvider từ Database
		/// </summary>
		public GExpProvider GetObject(string schema, String Id)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[GExpProvider] where Id=@Id",
					"@Id", Id);
				if (ds.Rows.Count > 0)
				{
					GExpProvider item=new GExpProvider();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["ProviderName"] != null && dr["ProviderName"] != DBNull.Value)
						{
							item.ProviderName = Convert.ToString(dr["ProviderName"]);
						}
						if (dr["Token"] != null && dr["Token"] != DBNull.Value)
						{
							item.Token = Convert.ToString(dr["Token"]);
						}
						if (dr["UserApi"] != null && dr["UserApi"] != DBNull.Value)
						{
							item.UserApi = Convert.ToString(dr["UserApi"]);
						}
						if (dr["PassApi"] != null && dr["PassApi"] != DBNull.Value)
						{
							item.PassApi = Convert.ToString(dr["PassApi"]);
						}
						if (dr["ShopId"] != null && dr["ShopId"] != DBNull.Value)
						{
							item.ShopId = Convert.ToString(dr["ShopId"]);
						}
						if (dr["ClientId"] != null && dr["ClientId"] != DBNull.Value)
						{
							item.ClientId = Convert.ToString(dr["ClientId"]);
						}
						if (dr["Post"] != null && dr["Post"] != DBNull.Value)
						{
							item.Post = Convert.ToString(dr["Post"]);
						}
						if (dr["Address"] != null && dr["Address"] != DBNull.Value)
						{
							item.Address = Convert.ToString(dr["Address"]);
						}
						if (dr["Email"] != null && dr["Email"] != DBNull.Value)
						{
							item.Email = Convert.ToString(dr["Email"]);
						}
						if (dr["ShopName"] != null && dr["ShopName"] != DBNull.Value)
						{
							item.ShopName = Convert.ToString(dr["ShopName"]);
						}
						if (dr["ShopPhone"] != null && dr["ShopPhone"] != DBNull.Value)
						{
							item.ShopPhone = Convert.ToString(dr["ShopPhone"]);
						}
						if (dr["ProviderTypeCode"] != null && dr["ProviderTypeCode"] != DBNull.Value)
						{
							item.ProviderTypeCode = Convert.ToString(dr["ProviderTypeCode"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
						}
						if (dr["AutoSelect"] != null && dr["AutoSelect"] != DBNull.Value)
						{
							item.AutoSelect = Convert.ToBoolean(dr["AutoSelect"]);
						}
						if (dr["InitWeightSelect"] != null && dr["InitWeightSelect"] != DBNull.Value)
						{
							item.InitWeightSelect = Convert.ToInt32(dr["InitWeightSelect"]);
						}
						if (dr["InitWeightSelectMax"] != null && dr["InitWeightSelectMax"] != DBNull.Value)
						{
							item.InitWeightSelectMax = Convert.ToInt32(dr["InitWeightSelectMax"]);
						}
						if (dr["SelectIndex"] != null && dr["SelectIndex"] != DBNull.Value)
						{
							item.SelectIndex = Convert.ToInt32(dr["SelectIndex"]);
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
						if (dr["ServiceId"] != null && dr["ServiceId"] != DBNull.Value)
						{
							item.ServiceId = Convert.ToString(dr["ServiceId"]);
						}
						if (dr["PostBT3Id"] != null && dr["PostBT3Id"] != DBNull.Value)
						{
							item.PostBT3Id = Convert.ToString(dr["PostBT3Id"]);
						}
						if (dr["RunMode"] != null && dr["RunMode"] != DBNull.Value)
						{
							item.RunMode = Convert.ToInt32(dr["RunMode"]);
						}
						if (dr["TrackLink"] != null && dr["TrackLink"] != DBNull.Value)
						{
							item.TrackLink = Convert.ToString(dr["TrackLink"]);
						}
						if (dr["WhiteListProvince"] != null && dr["WhiteListProvince"] != DBNull.Value)
						{
							item.WhiteListProvince = Convert.ToString(dr["WhiteListProvince"]);
						}
						if (dr["BlackListProvince"] != null && dr["BlackListProvince"] != DBNull.Value)
						{
							item.BlackListProvince = Convert.ToString(dr["BlackListProvince"]);
						}
						if (dr["GroupProvider"] != null && dr["GroupProvider"] != DBNull.Value)
						{
							item.GroupProvider = Convert.ToString(dr["GroupProvider"]);
						}
						if (dr["InsuranceValue"] != null && dr["InsuranceValue"] != DBNull.Value)
						{
							item.InsuranceValue = Convert.ToInt32(dr["InsuranceValue"]);
						}
						if (dr["ExpiresDate"] != null && dr["ExpiresDate"] != DBNull.Value)
						{
							item.ExpiresDate = Convert.ToDateTime(dr["ExpiresDate"]);
						}
						if (dr["ClientSecrect"] != null && dr["ClientSecrect"] != DBNull.Value)
						{
							item.ClientSecrect = Convert.ToString(dr["ClientSecrect"]);
						}
						if (dr["PrintLable"] != null && dr["PrintLable"] != DBNull.Value)
						{
							item.PrintLable = Convert.ToString(dr["PrintLable"]);
						}
						if (dr["DeliveryInitPrice"] != null && dr["DeliveryInitPrice"] != DBNull.Value)
						{
							item.DeliveryInitPrice = Convert.ToInt32(dr["DeliveryInitPrice"]);
						}
						if (dr["DeliveryInitWeight"] != null && dr["DeliveryInitWeight"] != DBNull.Value)
						{
							item.DeliveryInitWeight = Convert.ToInt32(dr["DeliveryInitWeight"]);
						}
						if (dr["DeliveryStepWeight"] != null && dr["DeliveryStepWeight"] != DBNull.Value)
						{
							item.DeliveryStepWeight = Convert.ToInt32(dr["DeliveryStepWeight"]);
						}
						if (dr["DeliveryStepPrice"] != null && dr["DeliveryStepPrice"] != DBNull.Value)
						{
							item.DeliveryStepPrice = Convert.ToInt32(dr["DeliveryStepPrice"]);
						}
						if (dr["SysInitPrice"] != null && dr["SysInitPrice"] != DBNull.Value)
						{
							item.SysInitPrice = Convert.ToInt32(dr["SysInitPrice"]);
						}
						if (dr["SysInitWeight"] != null && dr["SysInitWeight"] != DBNull.Value)
						{
							item.SysInitWeight = Convert.ToInt32(dr["SysInitWeight"]);
						}
						if (dr["SysStepWeight"] != null && dr["SysStepWeight"] != DBNull.Value)
						{
							item.SysStepWeight = Convert.ToInt32(dr["SysStepWeight"]);
						}
						if (dr["SysStepPrice"] != null && dr["SysStepPrice"] != DBNull.Value)
						{
							item.SysStepPrice = Convert.ToInt32(dr["SysStepPrice"]);
						}
						if (dr["TranInitPrice"] != null && dr["TranInitPrice"] != DBNull.Value)
						{
							item.TranInitPrice = Convert.ToInt32(dr["TranInitPrice"]);
						}
						if (dr["TranInitWeight"] != null && dr["TranInitWeight"] != DBNull.Value)
						{
							item.TranInitWeight = Convert.ToInt32(dr["TranInitWeight"]);
						}
						if (dr["TranStepWeight"] != null && dr["TranStepWeight"] != DBNull.Value)
						{
							item.TranStepWeight = Convert.ToInt32(dr["TranStepWeight"]);
						}
						if (dr["TranStepPrice"] != null && dr["TranStepPrice"] != DBNull.Value)
						{
							item.TranStepPrice = Convert.ToInt32(dr["TranStepPrice"]);
						}
						if (dr["DistrictWhiteList"] != null && dr["DistrictWhiteList"] != DBNull.Value)
						{
							item.DistrictWhiteList = Convert.ToString(dr["DistrictWhiteList"]);
						}
						if (dr["ManualSign"] != null && dr["ManualSign"] != DBNull.Value)
						{
							item.ManualSign = Convert.ToBoolean(dr["ManualSign"]);
						}
						if (dr["IsPickup"] != null && dr["IsPickup"] != DBNull.Value)
						{
							item.IsPickup = Convert.ToBoolean(dr["IsPickup"]);
						}
						if (dr["LinkCustomerLogin"] != null && dr["LinkCustomerLogin"] != DBNull.Value)
						{
							item.LinkCustomerLogin = Convert.ToString(dr["LinkCustomerLogin"]);
						}
						if (dr["IsOwner"] != null && dr["IsOwner"] != DBNull.Value)
						{
							item.IsOwner = Convert.ToBoolean(dr["IsOwner"]);
						}
						if (dr["PercentConfig"] != null && dr["PercentConfig"] != DBNull.Value)
						{
							item.PercentConfig = Convert.ToInt32(dr["PercentConfig"]);
						}
						if (dr["AlwayReceivePay"] != null && dr["AlwayReceivePay"] != DBNull.Value)
						{
							item.AlwayReceivePay = Convert.ToBoolean(dr["AlwayReceivePay"]);
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
		/// Lấy một GExpProvider đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public GExpProvider GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[GExpProvider] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					GExpProvider item=new GExpProvider();
					foreach (DataRow dr in ds.Rows)
					{
						if (dr["Id"] != null && dr["Id"] != DBNull.Value)
						{
							item.Id = Convert.ToString(dr["Id"]);
						}
						if (dr["ProviderName"] != null && dr["ProviderName"] != DBNull.Value)
						{
							item.ProviderName = Convert.ToString(dr["ProviderName"]);
						}
						if (dr["Token"] != null && dr["Token"] != DBNull.Value)
						{
							item.Token = Convert.ToString(dr["Token"]);
						}
						if (dr["UserApi"] != null && dr["UserApi"] != DBNull.Value)
						{
							item.UserApi = Convert.ToString(dr["UserApi"]);
						}
						if (dr["PassApi"] != null && dr["PassApi"] != DBNull.Value)
						{
							item.PassApi = Convert.ToString(dr["PassApi"]);
						}
						if (dr["ShopId"] != null && dr["ShopId"] != DBNull.Value)
						{
							item.ShopId = Convert.ToString(dr["ShopId"]);
						}
						if (dr["ClientId"] != null && dr["ClientId"] != DBNull.Value)
						{
							item.ClientId = Convert.ToString(dr["ClientId"]);
						}
						if (dr["Post"] != null && dr["Post"] != DBNull.Value)
						{
							item.Post = Convert.ToString(dr["Post"]);
						}
						if (dr["Address"] != null && dr["Address"] != DBNull.Value)
						{
							item.Address = Convert.ToString(dr["Address"]);
						}
						if (dr["Email"] != null && dr["Email"] != DBNull.Value)
						{
							item.Email = Convert.ToString(dr["Email"]);
						}
						if (dr["ShopName"] != null && dr["ShopName"] != DBNull.Value)
						{
							item.ShopName = Convert.ToString(dr["ShopName"]);
						}
						if (dr["ShopPhone"] != null && dr["ShopPhone"] != DBNull.Value)
						{
							item.ShopPhone = Convert.ToString(dr["ShopPhone"]);
						}
						if (dr["ProviderTypeCode"] != null && dr["ProviderTypeCode"] != DBNull.Value)
						{
							item.ProviderTypeCode = Convert.ToString(dr["ProviderTypeCode"]);
						}
						if (dr["IsDelete"] != null && dr["IsDelete"] != DBNull.Value)
						{
							item.IsDelete = Convert.ToBoolean(dr["IsDelete"]);
						}
						if (dr["AutoSelect"] != null && dr["AutoSelect"] != DBNull.Value)
						{
							item.AutoSelect = Convert.ToBoolean(dr["AutoSelect"]);
						}
						if (dr["InitWeightSelect"] != null && dr["InitWeightSelect"] != DBNull.Value)
						{
							item.InitWeightSelect = Convert.ToInt32(dr["InitWeightSelect"]);
						}
						if (dr["InitWeightSelectMax"] != null && dr["InitWeightSelectMax"] != DBNull.Value)
						{
							item.InitWeightSelectMax = Convert.ToInt32(dr["InitWeightSelectMax"]);
						}
						if (dr["SelectIndex"] != null && dr["SelectIndex"] != DBNull.Value)
						{
							item.SelectIndex = Convert.ToInt32(dr["SelectIndex"]);
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
						if (dr["ServiceId"] != null && dr["ServiceId"] != DBNull.Value)
						{
							item.ServiceId = Convert.ToString(dr["ServiceId"]);
						}
						if (dr["PostBT3Id"] != null && dr["PostBT3Id"] != DBNull.Value)
						{
							item.PostBT3Id = Convert.ToString(dr["PostBT3Id"]);
						}
						if (dr["RunMode"] != null && dr["RunMode"] != DBNull.Value)
						{
							item.RunMode = Convert.ToInt32(dr["RunMode"]);
						}
						if (dr["TrackLink"] != null && dr["TrackLink"] != DBNull.Value)
						{
							item.TrackLink = Convert.ToString(dr["TrackLink"]);
						}
						if (dr["WhiteListProvince"] != null && dr["WhiteListProvince"] != DBNull.Value)
						{
							item.WhiteListProvince = Convert.ToString(dr["WhiteListProvince"]);
						}
						if (dr["BlackListProvince"] != null && dr["BlackListProvince"] != DBNull.Value)
						{
							item.BlackListProvince = Convert.ToString(dr["BlackListProvince"]);
						}
						if (dr["GroupProvider"] != null && dr["GroupProvider"] != DBNull.Value)
						{
							item.GroupProvider = Convert.ToString(dr["GroupProvider"]);
						}
						if (dr["InsuranceValue"] != null && dr["InsuranceValue"] != DBNull.Value)
						{
							item.InsuranceValue = Convert.ToInt32(dr["InsuranceValue"]);
						}
						if (dr["ExpiresDate"] != null && dr["ExpiresDate"] != DBNull.Value)
						{
							item.ExpiresDate = Convert.ToDateTime(dr["ExpiresDate"]);
						}
						if (dr["ClientSecrect"] != null && dr["ClientSecrect"] != DBNull.Value)
						{
							item.ClientSecrect = Convert.ToString(dr["ClientSecrect"]);
						}
						if (dr["PrintLable"] != null && dr["PrintLable"] != DBNull.Value)
						{
							item.PrintLable = Convert.ToString(dr["PrintLable"]);
						}
						if (dr["DeliveryInitPrice"] != null && dr["DeliveryInitPrice"] != DBNull.Value)
						{
							item.DeliveryInitPrice = Convert.ToInt32(dr["DeliveryInitPrice"]);
						}
						if (dr["DeliveryInitWeight"] != null && dr["DeliveryInitWeight"] != DBNull.Value)
						{
							item.DeliveryInitWeight = Convert.ToInt32(dr["DeliveryInitWeight"]);
						}
						if (dr["DeliveryStepWeight"] != null && dr["DeliveryStepWeight"] != DBNull.Value)
						{
							item.DeliveryStepWeight = Convert.ToInt32(dr["DeliveryStepWeight"]);
						}
						if (dr["DeliveryStepPrice"] != null && dr["DeliveryStepPrice"] != DBNull.Value)
						{
							item.DeliveryStepPrice = Convert.ToInt32(dr["DeliveryStepPrice"]);
						}
						if (dr["SysInitPrice"] != null && dr["SysInitPrice"] != DBNull.Value)
						{
							item.SysInitPrice = Convert.ToInt32(dr["SysInitPrice"]);
						}
						if (dr["SysInitWeight"] != null && dr["SysInitWeight"] != DBNull.Value)
						{
							item.SysInitWeight = Convert.ToInt32(dr["SysInitWeight"]);
						}
						if (dr["SysStepWeight"] != null && dr["SysStepWeight"] != DBNull.Value)
						{
							item.SysStepWeight = Convert.ToInt32(dr["SysStepWeight"]);
						}
						if (dr["SysStepPrice"] != null && dr["SysStepPrice"] != DBNull.Value)
						{
							item.SysStepPrice = Convert.ToInt32(dr["SysStepPrice"]);
						}
						if (dr["TranInitPrice"] != null && dr["TranInitPrice"] != DBNull.Value)
						{
							item.TranInitPrice = Convert.ToInt32(dr["TranInitPrice"]);
						}
						if (dr["TranInitWeight"] != null && dr["TranInitWeight"] != DBNull.Value)
						{
							item.TranInitWeight = Convert.ToInt32(dr["TranInitWeight"]);
						}
						if (dr["TranStepWeight"] != null && dr["TranStepWeight"] != DBNull.Value)
						{
							item.TranStepWeight = Convert.ToInt32(dr["TranStepWeight"]);
						}
						if (dr["TranStepPrice"] != null && dr["TranStepPrice"] != DBNull.Value)
						{
							item.TranStepPrice = Convert.ToInt32(dr["TranStepPrice"]);
						}
						if (dr["DistrictWhiteList"] != null && dr["DistrictWhiteList"] != DBNull.Value)
						{
							item.DistrictWhiteList = Convert.ToString(dr["DistrictWhiteList"]);
						}
						if (dr["ManualSign"] != null && dr["ManualSign"] != DBNull.Value)
						{
							item.ManualSign = Convert.ToBoolean(dr["ManualSign"]);
						}
						if (dr["IsPickup"] != null && dr["IsPickup"] != DBNull.Value)
						{
							item.IsPickup = Convert.ToBoolean(dr["IsPickup"]);
						}
						if (dr["LinkCustomerLogin"] != null && dr["LinkCustomerLogin"] != DBNull.Value)
						{
							item.LinkCustomerLogin = Convert.ToString(dr["LinkCustomerLogin"]);
						}
						if (dr["IsOwner"] != null && dr["IsOwner"] != DBNull.Value)
						{
							item.IsOwner = Convert.ToBoolean(dr["IsOwner"]);
						}
						if (dr["PercentConfig"] != null && dr["PercentConfig"] != DBNull.Value)
						{
							item.PercentConfig = Convert.ToInt32(dr["PercentConfig"]);
						}
						if (dr["AlwayReceivePay"] != null && dr["AlwayReceivePay"] != DBNull.Value)
						{
							item.AlwayReceivePay = Convert.ToBoolean(dr["AlwayReceivePay"]);
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

		public GExpProvider GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[GExpProvider] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<GExpProvider>(ds);
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
		/// Thêm mới GExpProvider vào Database
		/// </summary>
		public bool InsertOnSubmit(string schema, GExpProvider _GExpProvider)
		{
			try
			{
				this._dataContext.ExecuteNonQuery("INSERT INTO " + schema + ".[GExpProvider](Id, ProviderName, Token, UserApi, PassApi, ShopId, ClientId, Post, Address, Email, ShopName, ShopPhone, ProviderTypeCode, IsDelete, AutoSelect, InitWeightSelect, InitWeightSelectMax, SelectIndex, InitPrice, InitWeight, StepWeight, StepPrice, WardCode, DistrictCode, ProvinceCode, WardName, DistrictName, ProvinceName, ServiceId, PostBT3Id, RunMode, TrackLink, WhiteListProvince, BlackListProvince, GroupProvider, InsuranceValue, ExpiresDate, ClientSecrect, PrintLable, DeliveryInitPrice, DeliveryInitWeight, DeliveryStepWeight, DeliveryStepPrice, SysInitPrice, SysInitWeight, SysStepWeight, SysStepPrice, TranInitPrice, TranInitWeight, TranStepWeight, TranStepPrice, DistrictWhiteList, ManualSign, IsPickup, LinkCustomerLogin, IsOwner, PercentConfig, AlwayReceivePay) VALUES(@Id, @ProviderName, @Token, @UserApi, @PassApi, @ShopId, @ClientId, @Post, @Address, @Email, @ShopName, @ShopPhone, @ProviderTypeCode, @IsDelete, @AutoSelect, @InitWeightSelect, @InitWeightSelectMax, @SelectIndex, @InitPrice, @InitWeight, @StepWeight, @StepPrice, @WardCode, @DistrictCode, @ProvinceCode, @WardName, @DistrictName, @ProvinceName, @ServiceId, @PostBT3Id, @RunMode, @TrackLink, @WhiteListProvince, @BlackListProvince, @GroupProvider, @InsuranceValue, @ExpiresDate, @ClientSecrect, @PrintLable, @DeliveryInitPrice, @DeliveryInitWeight, @DeliveryStepWeight, @DeliveryStepPrice, @SysInitPrice, @SysInitWeight, @SysStepWeight, @SysStepPrice, @TranInitPrice, @TranInitWeight, @TranStepWeight, @TranStepPrice, @DistrictWhiteList, @ManualSign, @IsPickup, @LinkCustomerLogin, @IsOwner, @PercentConfig, @AlwayReceivePay)", 
					"@Id",  _GExpProvider.Id, 
					"@ProviderName",  _GExpProvider.ProviderName, 
					"@Token",  _GExpProvider.Token, 
					"@UserApi",  _GExpProvider.UserApi, 
					"@PassApi",  _GExpProvider.PassApi, 
					"@ShopId",  _GExpProvider.ShopId, 
					"@ClientId",  _GExpProvider.ClientId, 
					"@Post",  _GExpProvider.Post, 
					"@Address",  _GExpProvider.Address, 
					"@Email",  _GExpProvider.Email, 
					"@ShopName",  _GExpProvider.ShopName, 
					"@ShopPhone",  _GExpProvider.ShopPhone, 
					"@ProviderTypeCode",  _GExpProvider.ProviderTypeCode, 
					"@IsDelete",  _GExpProvider.IsDelete, 
					"@AutoSelect",  _GExpProvider.AutoSelect, 
					"@InitWeightSelect",  _GExpProvider.InitWeightSelect, 
					"@InitWeightSelectMax",  _GExpProvider.InitWeightSelectMax, 
					"@SelectIndex",  _GExpProvider.SelectIndex, 
					"@InitPrice",  _GExpProvider.InitPrice, 
					"@InitWeight",  _GExpProvider.InitWeight, 
					"@StepWeight",  _GExpProvider.StepWeight, 
					"@StepPrice",  _GExpProvider.StepPrice, 
					"@WardCode",  _GExpProvider.WardCode, 
					"@DistrictCode",  _GExpProvider.DistrictCode, 
					"@ProvinceCode",  _GExpProvider.ProvinceCode, 
					"@WardName",  _GExpProvider.WardName, 
					"@DistrictName",  _GExpProvider.DistrictName, 
					"@ProvinceName",  _GExpProvider.ProvinceName, 
					"@ServiceId",  _GExpProvider.ServiceId, 
					"@PostBT3Id",  _GExpProvider.PostBT3Id, 
					"@RunMode",  _GExpProvider.RunMode, 
					"@TrackLink",  _GExpProvider.TrackLink, 
					"@WhiteListProvince",  _GExpProvider.WhiteListProvince, 
					"@BlackListProvince",  _GExpProvider.BlackListProvince, 
					"@GroupProvider",  _GExpProvider.GroupProvider, 
					"@InsuranceValue",  _GExpProvider.InsuranceValue, 
					"@ExpiresDate", this._dataContext.ConvertDateString( _GExpProvider.ExpiresDate), 
					"@ClientSecrect",  _GExpProvider.ClientSecrect, 
					"@PrintLable",  _GExpProvider.PrintLable, 
					"@DeliveryInitPrice",  _GExpProvider.DeliveryInitPrice, 
					"@DeliveryInitWeight",  _GExpProvider.DeliveryInitWeight, 
					"@DeliveryStepWeight",  _GExpProvider.DeliveryStepWeight, 
					"@DeliveryStepPrice",  _GExpProvider.DeliveryStepPrice, 
					"@SysInitPrice",  _GExpProvider.SysInitPrice, 
					"@SysInitWeight",  _GExpProvider.SysInitWeight, 
					"@SysStepWeight",  _GExpProvider.SysStepWeight, 
					"@SysStepPrice",  _GExpProvider.SysStepPrice, 
					"@TranInitPrice",  _GExpProvider.TranInitPrice, 
					"@TranInitWeight",  _GExpProvider.TranInitWeight, 
					"@TranStepWeight",  _GExpProvider.TranStepWeight, 
					"@TranStepPrice",  _GExpProvider.TranStepPrice, 
					"@DistrictWhiteList",  _GExpProvider.DistrictWhiteList, 
					"@ManualSign",  _GExpProvider.ManualSign, 
					"@IsPickup",  _GExpProvider.IsPickup, 
					"@LinkCustomerLogin",  _GExpProvider.LinkCustomerLogin, 
					"@IsOwner",  _GExpProvider.IsOwner, 
					"@PercentConfig",  _GExpProvider.PercentConfig, 
					"@AlwayReceivePay",  _GExpProvider.AlwayReceivePay);
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Insert danh sách đối tượng GExpProvider vào database
		/// </summary>
		/// <returns></returns>
		public void InsertAllSubmit(string schema, List<GExpProvider> _GExpProviders)
		{
			foreach (GExpProvider item in _GExpProviders)
			{
				InsertOnSubmit(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpProvider vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public int Update(string schema, GExpProvider _GExpProvider, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProvider] SET Id=@Id, ProviderName=@ProviderName, Token=@Token, UserApi=@UserApi, PassApi=@PassApi, ShopId=@ShopId, ClientId=@ClientId, Post=@Post, Address=@Address, Email=@Email, ShopName=@ShopName, ShopPhone=@ShopPhone, ProviderTypeCode=@ProviderTypeCode, IsDelete=@IsDelete, AutoSelect=@AutoSelect, InitWeightSelect=@InitWeightSelect, InitWeightSelectMax=@InitWeightSelectMax, SelectIndex=@SelectIndex, InitPrice=@InitPrice, InitWeight=@InitWeight, StepWeight=@StepWeight, StepPrice=@StepPrice, WardCode=@WardCode, DistrictCode=@DistrictCode, ProvinceCode=@ProvinceCode, WardName=@WardName, DistrictName=@DistrictName, ProvinceName=@ProvinceName, ServiceId=@ServiceId, PostBT3Id=@PostBT3Id, RunMode=@RunMode, TrackLink=@TrackLink, WhiteListProvince=@WhiteListProvince, BlackListProvince=@BlackListProvince, GroupProvider=@GroupProvider, InsuranceValue=@InsuranceValue, ExpiresDate=@ExpiresDate, ClientSecrect=@ClientSecrect, PrintLable=@PrintLable, DeliveryInitPrice=@DeliveryInitPrice, DeliveryInitWeight=@DeliveryInitWeight, DeliveryStepWeight=@DeliveryStepWeight, DeliveryStepPrice=@DeliveryStepPrice, SysInitPrice=@SysInitPrice, SysInitWeight=@SysInitWeight, SysStepWeight=@SysStepWeight, SysStepPrice=@SysStepPrice, TranInitPrice=@TranInitPrice, TranInitWeight=@TranInitWeight, TranStepWeight=@TranStepWeight, TranStepPrice=@TranStepPrice, DistrictWhiteList=@DistrictWhiteList, ManualSign=@ManualSign, IsPickup=@IsPickup, LinkCustomerLogin=@LinkCustomerLogin, IsOwner=@IsOwner, PercentConfig=@PercentConfig, AlwayReceivePay=@AlwayReceivePay WHERE Id=@Id", 
					"@Id",  _GExpProvider.Id, 
					"@ProviderName",  _GExpProvider.ProviderName, 
					"@Token",  _GExpProvider.Token, 
					"@UserApi",  _GExpProvider.UserApi, 
					"@PassApi",  _GExpProvider.PassApi, 
					"@ShopId",  _GExpProvider.ShopId, 
					"@ClientId",  _GExpProvider.ClientId, 
					"@Post",  _GExpProvider.Post, 
					"@Address",  _GExpProvider.Address, 
					"@Email",  _GExpProvider.Email, 
					"@ShopName",  _GExpProvider.ShopName, 
					"@ShopPhone",  _GExpProvider.ShopPhone, 
					"@ProviderTypeCode",  _GExpProvider.ProviderTypeCode, 
					"@IsDelete",  _GExpProvider.IsDelete, 
					"@AutoSelect",  _GExpProvider.AutoSelect, 
					"@InitWeightSelect",  _GExpProvider.InitWeightSelect, 
					"@InitWeightSelectMax",  _GExpProvider.InitWeightSelectMax, 
					"@SelectIndex",  _GExpProvider.SelectIndex, 
					"@InitPrice",  _GExpProvider.InitPrice, 
					"@InitWeight",  _GExpProvider.InitWeight, 
					"@StepWeight",  _GExpProvider.StepWeight, 
					"@StepPrice",  _GExpProvider.StepPrice, 
					"@WardCode",  _GExpProvider.WardCode, 
					"@DistrictCode",  _GExpProvider.DistrictCode, 
					"@ProvinceCode",  _GExpProvider.ProvinceCode, 
					"@WardName",  _GExpProvider.WardName, 
					"@DistrictName",  _GExpProvider.DistrictName, 
					"@ProvinceName",  _GExpProvider.ProvinceName, 
					"@ServiceId",  _GExpProvider.ServiceId, 
					"@PostBT3Id",  _GExpProvider.PostBT3Id, 
					"@RunMode",  _GExpProvider.RunMode, 
					"@TrackLink",  _GExpProvider.TrackLink, 
					"@WhiteListProvince",  _GExpProvider.WhiteListProvince, 
					"@BlackListProvince",  _GExpProvider.BlackListProvince, 
					"@GroupProvider",  _GExpProvider.GroupProvider, 
					"@InsuranceValue",  _GExpProvider.InsuranceValue, 
					"@ExpiresDate", this._dataContext.ConvertDateString( _GExpProvider.ExpiresDate), 
					"@ClientSecrect",  _GExpProvider.ClientSecrect, 
					"@PrintLable",  _GExpProvider.PrintLable, 
					"@DeliveryInitPrice",  _GExpProvider.DeliveryInitPrice, 
					"@DeliveryInitWeight",  _GExpProvider.DeliveryInitWeight, 
					"@DeliveryStepWeight",  _GExpProvider.DeliveryStepWeight, 
					"@DeliveryStepPrice",  _GExpProvider.DeliveryStepPrice, 
					"@SysInitPrice",  _GExpProvider.SysInitPrice, 
					"@SysInitWeight",  _GExpProvider.SysInitWeight, 
					"@SysStepWeight",  _GExpProvider.SysStepWeight, 
					"@SysStepPrice",  _GExpProvider.SysStepPrice, 
					"@TranInitPrice",  _GExpProvider.TranInitPrice, 
					"@TranInitWeight",  _GExpProvider.TranInitWeight, 
					"@TranStepWeight",  _GExpProvider.TranStepWeight, 
					"@TranStepPrice",  _GExpProvider.TranStepPrice, 
					"@DistrictWhiteList",  _GExpProvider.DistrictWhiteList, 
					"@ManualSign",  _GExpProvider.ManualSign, 
					"@IsPickup",  _GExpProvider.IsPickup, 
					"@LinkCustomerLogin",  _GExpProvider.LinkCustomerLogin, 
					"@IsOwner",  _GExpProvider.IsOwner, 
					"@PercentConfig",  _GExpProvider.PercentConfig, 
					"@AlwayReceivePay",  _GExpProvider.AlwayReceivePay, 
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật GExpProvider vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		public int Update(string schema, GExpProvider _GExpProvider)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProvider] SET ProviderName=@ProviderName, Token=@Token, UserApi=@UserApi, PassApi=@PassApi, ShopId=@ShopId, ClientId=@ClientId, Post=@Post, Address=@Address, Email=@Email, ShopName=@ShopName, ShopPhone=@ShopPhone, ProviderTypeCode=@ProviderTypeCode, IsDelete=@IsDelete, AutoSelect=@AutoSelect, InitWeightSelect=@InitWeightSelect, InitWeightSelectMax=@InitWeightSelectMax, SelectIndex=@SelectIndex, InitPrice=@InitPrice, InitWeight=@InitWeight, StepWeight=@StepWeight, StepPrice=@StepPrice, WardCode=@WardCode, DistrictCode=@DistrictCode, ProvinceCode=@ProvinceCode, WardName=@WardName, DistrictName=@DistrictName, ProvinceName=@ProvinceName, ServiceId=@ServiceId, PostBT3Id=@PostBT3Id, RunMode=@RunMode, TrackLink=@TrackLink, WhiteListProvince=@WhiteListProvince, BlackListProvince=@BlackListProvince, GroupProvider=@GroupProvider, InsuranceValue=@InsuranceValue, ExpiresDate=@ExpiresDate, ClientSecrect=@ClientSecrect, PrintLable=@PrintLable, DeliveryInitPrice=@DeliveryInitPrice, DeliveryInitWeight=@DeliveryInitWeight, DeliveryStepWeight=@DeliveryStepWeight, DeliveryStepPrice=@DeliveryStepPrice, SysInitPrice=@SysInitPrice, SysInitWeight=@SysInitWeight, SysStepWeight=@SysStepWeight, SysStepPrice=@SysStepPrice, TranInitPrice=@TranInitPrice, TranInitWeight=@TranInitWeight, TranStepWeight=@TranStepWeight, TranStepPrice=@TranStepPrice, DistrictWhiteList=@DistrictWhiteList, ManualSign=@ManualSign, IsPickup=@IsPickup, LinkCustomerLogin=@LinkCustomerLogin, IsOwner=@IsOwner, PercentConfig=@PercentConfig, AlwayReceivePay=@AlwayReceivePay WHERE Id=@Id", 
					"@ProviderName",  _GExpProvider.ProviderName, 
					"@Token",  _GExpProvider.Token, 
					"@UserApi",  _GExpProvider.UserApi, 
					"@PassApi",  _GExpProvider.PassApi, 
					"@ShopId",  _GExpProvider.ShopId, 
					"@ClientId",  _GExpProvider.ClientId, 
					"@Post",  _GExpProvider.Post, 
					"@Address",  _GExpProvider.Address, 
					"@Email",  _GExpProvider.Email, 
					"@ShopName",  _GExpProvider.ShopName, 
					"@ShopPhone",  _GExpProvider.ShopPhone, 
					"@ProviderTypeCode",  _GExpProvider.ProviderTypeCode, 
					"@IsDelete",  _GExpProvider.IsDelete, 
					"@AutoSelect",  _GExpProvider.AutoSelect, 
					"@InitWeightSelect",  _GExpProvider.InitWeightSelect, 
					"@InitWeightSelectMax",  _GExpProvider.InitWeightSelectMax, 
					"@SelectIndex",  _GExpProvider.SelectIndex, 
					"@InitPrice",  _GExpProvider.InitPrice, 
					"@InitWeight",  _GExpProvider.InitWeight, 
					"@StepWeight",  _GExpProvider.StepWeight, 
					"@StepPrice",  _GExpProvider.StepPrice, 
					"@WardCode",  _GExpProvider.WardCode, 
					"@DistrictCode",  _GExpProvider.DistrictCode, 
					"@ProvinceCode",  _GExpProvider.ProvinceCode, 
					"@WardName",  _GExpProvider.WardName, 
					"@DistrictName",  _GExpProvider.DistrictName, 
					"@ProvinceName",  _GExpProvider.ProvinceName, 
					"@ServiceId",  _GExpProvider.ServiceId, 
					"@PostBT3Id",  _GExpProvider.PostBT3Id, 
					"@RunMode",  _GExpProvider.RunMode, 
					"@TrackLink",  _GExpProvider.TrackLink, 
					"@WhiteListProvince",  _GExpProvider.WhiteListProvince, 
					"@BlackListProvince",  _GExpProvider.BlackListProvince, 
					"@GroupProvider",  _GExpProvider.GroupProvider, 
					"@InsuranceValue",  _GExpProvider.InsuranceValue, 
					"@ExpiresDate", this._dataContext.ConvertDateString( _GExpProvider.ExpiresDate), 
					"@ClientSecrect",  _GExpProvider.ClientSecrect, 
					"@PrintLable",  _GExpProvider.PrintLable, 
					"@DeliveryInitPrice",  _GExpProvider.DeliveryInitPrice, 
					"@DeliveryInitWeight",  _GExpProvider.DeliveryInitWeight, 
					"@DeliveryStepWeight",  _GExpProvider.DeliveryStepWeight, 
					"@DeliveryStepPrice",  _GExpProvider.DeliveryStepPrice, 
					"@SysInitPrice",  _GExpProvider.SysInitPrice, 
					"@SysInitWeight",  _GExpProvider.SysInitWeight, 
					"@SysStepWeight",  _GExpProvider.SysStepWeight, 
					"@SysStepPrice",  _GExpProvider.SysStepPrice, 
					"@TranInitPrice",  _GExpProvider.TranInitPrice, 
					"@TranInitWeight",  _GExpProvider.TranInitWeight, 
					"@TranStepWeight",  _GExpProvider.TranStepWeight, 
					"@TranStepPrice",  _GExpProvider.TranStepPrice, 
					"@DistrictWhiteList",  _GExpProvider.DistrictWhiteList, 
					"@ManualSign",  _GExpProvider.ManualSign, 
					"@IsPickup",  _GExpProvider.IsPickup, 
					"@LinkCustomerLogin",  _GExpProvider.LinkCustomerLogin, 
					"@IsOwner",  _GExpProvider.IsOwner, 
					"@PercentConfig",  _GExpProvider.PercentConfig, 
					"@AlwayReceivePay",  _GExpProvider.AlwayReceivePay, 
					"@Id", _GExpProvider.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Cập nhật danh sách GExpProvider vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		public void UpdateAllSubmit(string schema, List<GExpProvider> _GExpProviders)
		{
			foreach (GExpProvider item in _GExpProviders)
			{
				Update(schema, item);
			}
		}

		/// <summary>
		/// Cập nhật GExpProvider vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		public int UpdateCon(string schema, GExpProvider _GExpProvider, string condition)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("UPDATE " + schema + ".[GExpProvider] SET Id=@Id, ProviderName=@ProviderName, Token=@Token, UserApi=@UserApi, PassApi=@PassApi, ShopId=@ShopId, ClientId=@ClientId, Post=@Post, Address=@Address, Email=@Email, ShopName=@ShopName, ShopPhone=@ShopPhone, ProviderTypeCode=@ProviderTypeCode, IsDelete=@IsDelete, AutoSelect=@AutoSelect, InitWeightSelect=@InitWeightSelect, InitWeightSelectMax=@InitWeightSelectMax, SelectIndex=@SelectIndex, InitPrice=@InitPrice, InitWeight=@InitWeight, StepWeight=@StepWeight, StepPrice=@StepPrice, WardCode=@WardCode, DistrictCode=@DistrictCode, ProvinceCode=@ProvinceCode, WardName=@WardName, DistrictName=@DistrictName, ProvinceName=@ProvinceName, ServiceId=@ServiceId, PostBT3Id=@PostBT3Id, RunMode=@RunMode, TrackLink=@TrackLink, WhiteListProvince=@WhiteListProvince, BlackListProvince=@BlackListProvince, GroupProvider=@GroupProvider, InsuranceValue=@InsuranceValue, ExpiresDate=@ExpiresDate, ClientSecrect=@ClientSecrect, PrintLable=@PrintLable, DeliveryInitPrice=@DeliveryInitPrice, DeliveryInitWeight=@DeliveryInitWeight, DeliveryStepWeight=@DeliveryStepWeight, DeliveryStepPrice=@DeliveryStepPrice, SysInitPrice=@SysInitPrice, SysInitWeight=@SysInitWeight, SysStepWeight=@SysStepWeight, SysStepPrice=@SysStepPrice, TranInitPrice=@TranInitPrice, TranInitWeight=@TranInitWeight, TranStepWeight=@TranStepWeight, TranStepPrice=@TranStepPrice, DistrictWhiteList=@DistrictWhiteList, ManualSign=@ManualSign, IsPickup=@IsPickup, LinkCustomerLogin=@LinkCustomerLogin, IsOwner=@IsOwner, PercentConfig=@PercentConfig, AlwayReceivePay=@AlwayReceivePay "+ condition, 
					"@Id",  _GExpProvider.Id, 
					"@ProviderName",  _GExpProvider.ProviderName, 
					"@Token",  _GExpProvider.Token, 
					"@UserApi",  _GExpProvider.UserApi, 
					"@PassApi",  _GExpProvider.PassApi, 
					"@ShopId",  _GExpProvider.ShopId, 
					"@ClientId",  _GExpProvider.ClientId, 
					"@Post",  _GExpProvider.Post, 
					"@Address",  _GExpProvider.Address, 
					"@Email",  _GExpProvider.Email, 
					"@ShopName",  _GExpProvider.ShopName, 
					"@ShopPhone",  _GExpProvider.ShopPhone, 
					"@ProviderTypeCode",  _GExpProvider.ProviderTypeCode, 
					"@IsDelete",  _GExpProvider.IsDelete, 
					"@AutoSelect",  _GExpProvider.AutoSelect, 
					"@InitWeightSelect",  _GExpProvider.InitWeightSelect, 
					"@InitWeightSelectMax",  _GExpProvider.InitWeightSelectMax, 
					"@SelectIndex",  _GExpProvider.SelectIndex, 
					"@InitPrice",  _GExpProvider.InitPrice, 
					"@InitWeight",  _GExpProvider.InitWeight, 
					"@StepWeight",  _GExpProvider.StepWeight, 
					"@StepPrice",  _GExpProvider.StepPrice, 
					"@WardCode",  _GExpProvider.WardCode, 
					"@DistrictCode",  _GExpProvider.DistrictCode, 
					"@ProvinceCode",  _GExpProvider.ProvinceCode, 
					"@WardName",  _GExpProvider.WardName, 
					"@DistrictName",  _GExpProvider.DistrictName, 
					"@ProvinceName",  _GExpProvider.ProvinceName, 
					"@ServiceId",  _GExpProvider.ServiceId, 
					"@PostBT3Id",  _GExpProvider.PostBT3Id, 
					"@RunMode",  _GExpProvider.RunMode, 
					"@TrackLink",  _GExpProvider.TrackLink, 
					"@WhiteListProvince",  _GExpProvider.WhiteListProvince, 
					"@BlackListProvince",  _GExpProvider.BlackListProvince, 
					"@GroupProvider",  _GExpProvider.GroupProvider, 
					"@InsuranceValue",  _GExpProvider.InsuranceValue, 
					"@ExpiresDate", this._dataContext.ConvertDateString( _GExpProvider.ExpiresDate), 
					"@ClientSecrect",  _GExpProvider.ClientSecrect, 
					"@PrintLable",  _GExpProvider.PrintLable, 
					"@DeliveryInitPrice",  _GExpProvider.DeliveryInitPrice, 
					"@DeliveryInitWeight",  _GExpProvider.DeliveryInitWeight, 
					"@DeliveryStepWeight",  _GExpProvider.DeliveryStepWeight, 
					"@DeliveryStepPrice",  _GExpProvider.DeliveryStepPrice, 
					"@SysInitPrice",  _GExpProvider.SysInitPrice, 
					"@SysInitWeight",  _GExpProvider.SysInitWeight, 
					"@SysStepWeight",  _GExpProvider.SysStepWeight, 
					"@SysStepPrice",  _GExpProvider.SysStepPrice, 
					"@TranInitPrice",  _GExpProvider.TranInitPrice, 
					"@TranInitWeight",  _GExpProvider.TranInitWeight, 
					"@TranStepWeight",  _GExpProvider.TranStepWeight, 
					"@TranStepPrice",  _GExpProvider.TranStepPrice, 
					"@DistrictWhiteList",  _GExpProvider.DistrictWhiteList, 
					"@ManualSign",  _GExpProvider.ManualSign, 
					"@IsPickup",  _GExpProvider.IsPickup, 
					"@LinkCustomerLogin",  _GExpProvider.LinkCustomerLogin, 
					"@IsOwner",  _GExpProvider.IsOwner, 
					"@PercentConfig",  _GExpProvider.PercentConfig, 
					"@AlwayReceivePay",  _GExpProvider.AlwayReceivePay);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Xóa GExpProvider trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, String Id)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProvider] WHERE Id=@Id",
					"@Id", Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProvider trong Database
		/// </summary>
		public int DeleteOnSubmit(string schema, GExpProvider _GExpProvider)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProvider] WHERE Id=@Id",
					"@Id", _GExpProvider.Id);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProvider trong Database với điều kiện condition.
		/// </summary>
		public int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.ExecuteNonQuery("DELETE FROM " + schema + ".[GExpProvider] "+ condition, parameters);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Xóa GExpProvider trong Database
		/// </summary>
		public void DeleteAllSubmit(string schema, List<GExpProvider> _GExpProviders)
		{
			foreach (GExpProvider item in _GExpProviders)
			{
				DeleteOnSubmit(schema, item);
			}
		}
	}
}
