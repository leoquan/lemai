using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using LeMaiDomain;
namespace LeMaiLogic
{
	public class MVIewgexpprovider:IVIewgexpprovider
	{
		private IDataContext _dataContext;

		/// <summary>
		/// Khởi tạo đối tượng với tham số truyền vào là một đối tượng kiểu dcDataContext
		/// </summary>
		/// <param name="dataContext">Đối tượng dcDataContext đầu vào</param>
		public MVIewgexpprovider(IDataContext dataContext)
		{
			this._dataContext = dataContext;
		}
		/// <summary>
		/// Lấy một DataTable view_GExpProvider từ Database
		/// </summary>
		public DataTable GetDataTable(string schema)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpProvider]");
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy một DataTable view_GExpProvider từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public DataTable GetDataTable(string schema, string condition, params Object[] parameters)
		{
			try
			{
				return this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpProvider] "+ condition, parameters);
				
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy danh sách view_GExpProvider từ Database
		/// </summary>
		public List<view_GExpProvider> GetListObject(string schema)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT * FROM " + schema + ".[view_GExpProvider]");
				List<view_GExpProvider> items = new List<view_GExpProvider>();
				view_GExpProvider item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GExpProvider();
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
					if (dr["ProviderTypeName"] != null && dr["ProviderTypeName"] != DBNull.Value)
					{
						item.ProviderTypeName = Convert.ToString(dr["ProviderTypeName"]);
					}
					if (dr["IsPickup"] != null && dr["IsPickup"] != DBNull.Value)
					{
						item.IsPickup = Convert.ToBoolean(dr["IsPickup"]);
					}
					if (dr["LinkCustomerLogin"] != null && dr["LinkCustomerLogin"] != DBNull.Value)
					{
						item.LinkCustomerLogin = Convert.ToString(dr["LinkCustomerLogin"]);
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
		/// Lấy danh sách view_GExpProvider từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		public List<view_GExpProvider> GetListObjectCon(string schema, string condition,  params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GExpProvider] A "+ condition,  parameters);
				List<view_GExpProvider> items = new List<view_GExpProvider>();
				view_GExpProvider item;
				foreach (DataRow dr in ds.Rows)
				{
					item = new view_GExpProvider();
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
					if (dr["ProviderTypeName"] != null && dr["ProviderTypeName"] != DBNull.Value)
					{
						item.ProviderTypeName = Convert.ToString(dr["ProviderTypeName"]);
					}
					if (dr["IsPickup"] != null && dr["IsPickup"] != DBNull.Value)
					{
						item.IsPickup = Convert.ToBoolean(dr["IsPickup"]);
					}
					if (dr["LinkCustomerLogin"] != null && dr["LinkCustomerLogin"] != DBNull.Value)
					{
						item.LinkCustomerLogin = Convert.ToString(dr["LinkCustomerLogin"]);
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

		public List<view_GExpProvider> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters)
		{
			try
			{
				DataTable ds;
				if (take <= 0 || (take == 0 && skip == 0))
				{
					// Lấy không giới hạn
					ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GExpProvider] A " + condition, parameters);
				}
				else
				{
					// Lấy có giới hạn
					ds = this._dataContext.GetDataRows("SELECT " + columns + " FROM " + schema + ".[view_GExpProvider] A " + condition, skip, take, parameters);
				}
				return MapperExtensionClass.ToList<view_GExpProvider>(ds);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy một view_GExpProvider đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		public view_GExpProvider GetObjectCon(string schema, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT A.* FROM " + schema + ".[view_GExpProvider] A "+ condition, parameters);
				if (ds.Rows.Count > 0)
				{
					view_GExpProvider item=new view_GExpProvider();
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
						if (dr["ProviderTypeName"] != null && dr["ProviderTypeName"] != DBNull.Value)
						{
							item.ProviderTypeName = Convert.ToString(dr["ProviderTypeName"]);
						}
						if (dr["IsPickup"] != null && dr["IsPickup"] != DBNull.Value)
						{
							item.IsPickup = Convert.ToBoolean(dr["IsPickup"]);
						}
						if (dr["LinkCustomerLogin"] != null && dr["LinkCustomerLogin"] != DBNull.Value)
						{
							item.LinkCustomerLogin = Convert.ToString(dr["LinkCustomerLogin"]);
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

		public view_GExpProvider GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters)
		{
			try
			{
				DataTable ds = this._dataContext.GetData("SELECT " + columns + " FROM " + schema + ".[view_GExpProvider] A " + condition, parameters);
				if (ds.Rows.Count > 0)
				{
					return MapperExtensionClass.ToObject<view_GExpProvider>(ds);
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
