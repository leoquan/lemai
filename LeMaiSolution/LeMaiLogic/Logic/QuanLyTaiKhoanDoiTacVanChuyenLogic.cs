using LeMaiDomain;
using LeMaiDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{
    public partial class QuanLyTaiKhoanDoiTacVanChuyenLogic : BaseLogic
    {
        public QuanLyTaiKhoanDoiTacVanChuyenLogic(BaseLogicConnectionData data) : base(data)
        {
        }
        /// <summary>
        /// Get all view_GExpProvider List
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_GExpProvider>> GetList()
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexpprovider.GetListObject(base.ConnectionData.Schema);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public void UpdateVungVanChuyen(string providerId, string provineId, string districtIds)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpProvider provider = dc.GExpprovider.GetObject(base.ConnectionData.Schema, providerId);
                if(provider != null)
                {
                    provider.WhiteListProvince = provineId;
                    provider.DistrictWhiteList= districtIds;
                    dc.GExpprovider.Update(base.ConnectionData.Schema, provider);
                    dc.SubmitChanges();
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        /// <summary>
        /// Tìm view_GExpProvider theo keyword
        /// </summary>
        /// <returns></returns>
        public async Task<List<view_GExpProvider>> GetList(string keyword, string post)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = "WHERE Post='" + post + "' &";
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += "ProviderName like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition.TrimEnd('&');
                condition = condition.Replace("&", "AND");
                condition = condition + " ORDER BY ProviderTypeCode asc";
                return dc.VIewgexpprovider.GetListObjectCon(base.ConnectionData.Schema, condition);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        /// <summary>
        /// Danh sách view_GExpProvider theo giới hạn keyword và page
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="page">Số trang hiển thị</param>
        /// <returns></returns>
        public async Task<List<view_GExpProvider>> GetPage(string keyword, int? page)
        {
            try
            {
                int take = 10;
                int skip = 0;
                // Có tham số phân trang
                if (page != null)
                {
                    skip = ((int)page - 1) * take;
                    skip = skip < 0 ? 0 : skip;
                }
                return await GetPage(keyword, take, skip);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Danh sách view_GExpProvider theo giới hạn keyword, Take, Skip
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<List<view_GExpProvider>> GetPage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                // Search
                string condition = string.Empty;
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " WHERE ProviderName like N'%" + keyword + "%' | ";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('|');
                condition = condition.Replace("|", "OR");
                condition = condition + " ORDER BY ProviderTypeCode asc";
                return dc.VIewgexpprovider.GetListObjectLimitCon(base.ConnectionData.Schema, "*", condition, Take, Skip);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        /// <summary>
        /// Tuple Danh sách view_GExpProvider theo giới hạn keyword, Take, Skip và số dòng dữ liệu
        /// </summary>
        /// <param name="keyword">Search Keyword</param>
        /// <param name="Take">Số dòng lấy dữ liệu</param>
        /// <param name="Skip">Số dòng bỏ qua</param>
        /// <returns></returns>
        public async Task<Tuple<List<view_GExpProvider>, int>> GetTuplePage(string keyword, int Take, int Skip)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                var list = dc.VIewgexpprovider.GetListObject(base.ConnectionData.Schema);
                var data = await GetPage(keyword, Take, Skip);
                return new Tuple<List<view_GExpProvider>, int>(data, list.Count);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        /// <summary>
        /// Get List of SameQuanLyTaiKhoanDoiTacVanChuyenLogic
        /// </summary>
        /// <param name="Id">Id Of GExpProvider</param>
        /// <returns></returns>
        public async Task<List<view_GExpProvider>> GetSameList(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                int take = 10;
                return dc.VIewgexpprovider.GetListObjectLimitCon(base.ConnectionData.Schema, "*", "WHERE Id<>@Id  ", take, 0, "@Id", Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        /// <summary>
        /// Get view_GExpProvider Object
        /// </summary>
        /// <param name="Id">Id Of GExpProvider</param>
        /// <returns></returns>
        public async Task<view_GExpProvider> GetDetails(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.VIewgexpprovider.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public async Task<GExpProviderType> GetTypeDetails(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.GExpprovidertype.GetObject(base.ConnectionData.Schema, Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public string ProviderGetCode()
        {
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpCode queueNumber = dc.GExpcode.GetObjectCon(ConnectionData.Schema, "WHERE Id=@Id",
                    "@Id", "BT3");
                if (queueNumber == null)
                {
                    queueNumber = new GExpCode();
                    queueNumber.Id = "BT3";
                    queueNumber.CurrentValue = 1;
                    queueNumber.Post = "A";
                    dc.GExpcode.InsertOnSubmit(ConnectionData.Schema, queueNumber);
                }
                else
                {
                    queueNumber.CurrentValue = queueNumber.CurrentValue + 1;
                    dc.GExpcode.Update(ConnectionData.Schema, queueNumber);
                }
                dc.SubmitChanges();
                return "P" + queueNumber.CurrentValue.ToString().PadLeft(4, '0');
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }

        }
        /// <summary>
        /// Create a GExpProvider Object into Database
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<GExpProvider> Create(QuanLyTaiKhoanDoiTacVanChuyenLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpProvider item = new GExpProvider();
                item.Id = ProviderGetCode();
                item.ProviderName = input.ProviderName;
                item.Token = input.Token;
                item.UserApi = input.UserApi;
                item.PassApi = input.PassApi;
                item.ShopId = input.ShopId;
                item.ClientId = input.ClientId;
                item.Post = input.Post;
                item.Address = input.Address;
                item.Email = input.Email;
                item.ShopName = input.ShopName;
                item.ShopPhone = input.ShopPhone;
                item.ProviderTypeCode = input.ProviderTypeCode;
                item.IsDelete = input.IsDelete;
                item.AutoSelect = input.AutoSelect;
                item.InitWeightSelect = input.InitWeightSelect;
                item.InitWeightSelectMax = input.InitWeightSelectMax;
                item.SelectIndex = input.SelectIndex;
                item.InitPrice = input.InitPrice;
                item.InitWeight = input.InitWeight;
                item.StepWeight = input.StepWeight;
                item.StepPrice = input.StepPrice;
                item.WardCode = input.WardCode;
                item.DistrictCode = input.DistrictCode;
                item.ProvinceCode = input.ProvinceCode;
                item.WardName = input.WardName;
                item.DistrictName = input.DistrictName;
                item.ProvinceName = input.ProvinceName;
                item.ServiceId = input.ServiceId;
                item.PostBT3Id = input.PostBT3Id;
                item.RunMode = input.RunMode;
                item.GroupProvider = input.GroupProvider;
                item.InsuranceValue = input.InsuranceValue;
                item.ClientSecrect = input.ClientSecrect;
                item.PrintLable = input.PrintLable;
                item.DeliveryInitPrice = input.DeliveryInitPrice;
                item.DeliveryInitWeight = input.DeliveryInitWeight;
                item.DeliveryStepWeight = input.DeliveryStepWeight;
                item.DeliveryStepPrice = input.DeliveryStepPrice;
                item.SysInitPrice = input.SysInitPrice;
                item.SysInitWeight = input.SysInitWeight;
                item.SysStepWeight = input.SysStepWeight;
                item.SysStepPrice = input.SysStepPrice;
                item.TranInitPrice = input.TranInitPrice;
                item.TranInitWeight = input.TranInitWeight;
                item.TranStepWeight = input.TranStepWeight;
                item.TranStepPrice = input.TranStepPrice;
                item.ManualSign = input.ManualSign;
                item.IsPickup = input.IsPickup;
                item.LinkCustomerLogin = input.LinkCustomerLogin;
                item.PercentConfig = 100;
                item.AlwayReceivePay = input.IsAlwayReceive;
                item.IsOwner = 0;
                //Change Database
                dc.GExpprovider.InsertOnSubmit(base.ConnectionData.Schema, item);
                dc.SubmitChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        /// <summary>
        /// Update GExpProvider 
        /// </summary>
        /// <returns></returns>
        public async Task<bool> Update(String Id, QuanLyTaiKhoanDoiTacVanChuyenLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpProvider item = dc.GExpprovider.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    // Mapping Prop
                    item.ProviderName = input.ProviderName;
                    item.Token = input.Token;
                    item.UserApi = input.UserApi;
                    item.PassApi = input.PassApi;
                    item.ShopId = input.ShopId;
                    item.ClientId = input.ClientId;
                    item.Post = input.Post;
                    item.Address = input.Address;
                    item.Email = input.Email;
                    item.ShopName = input.ShopName;
                    item.ShopPhone = input.ShopPhone;
                    item.ProviderTypeCode = input.ProviderTypeCode;
                    item.IsDelete = input.IsDelete;
                    item.AutoSelect = input.AutoSelect;
                    item.InitWeightSelect = input.InitWeightSelect;
                    item.InitWeightSelectMax = input.InitWeightSelectMax;
                    item.SelectIndex = input.SelectIndex;
                    item.WardCode = input.WardCode;
                    item.DistrictCode = input.DistrictCode;
                    item.ProvinceCode = input.ProvinceCode;
                    item.WardName = input.WardName;
                    item.DistrictName = input.DistrictName;
                    item.ProvinceName = input.ProvinceName;
                    item.ServiceId = input.ServiceId;
                    item.PostBT3Id = input.PostBT3Id;
                    item.RunMode = input.RunMode;
                    item.GroupProvider = input.GroupProvider;
                    item.InsuranceValue = input.InsuranceValue;
                    item.ClientSecrect = input.ClientSecrect;
                    item.PrintLable = input.PrintLable;
                    item.DeliveryInitPrice = input.DeliveryInitPrice;
                    item.DeliveryInitWeight = input.DeliveryInitWeight;
                    item.DeliveryStepWeight = input.DeliveryStepWeight;
                    item.DeliveryStepPrice = input.DeliveryStepPrice;

                    item.ManualSign = input.ManualSign;
                    item.IsPickup = input.IsPickup;
                    item.LinkCustomerLogin = input.LinkCustomerLogin;
                    item.AlwayReceivePay = input.IsAlwayReceive;
                    item.IsDelete = input.IsDelete;
                    //Change Database
                    dc.GExpprovider.Update(base.ConnectionData.Schema, item);
                    dc.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        /// <summary>
        /// Delete GExpProvider
        /// </summary>
        public async Task<bool> Delete(String Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpProvider item = dc.GExpprovider.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    //Delete master
                    item.IsDelete = true;
                    dc.GExpprovider.Update(base.ConnectionData.Schema, item);
                    dc.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        /// <summary>
        /// Create Or Update Master Only
        /// </summary>
        /// <param name="input"></param>
        /// <returns>view_GExpProvider</returns>
        public async Task<view_GExpProvider> CreateOrUpdateMasterOnly(String Id, QuanLyTaiKhoanDoiTacVanChuyenLogicInputDto input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                bool insert = false;
                GExpProvider item = dc.GExpprovider.GetObject(base.ConnectionData.Schema, Id);
                if (item == null)
                {
                    insert = true;
                    item = new GExpProvider();
                    item.Id = Guid.NewGuid().ToString();
                }
                // Update Value
                item.ProviderName = input.ProviderName;
                item.Token = input.Token;
                item.UserApi = input.UserApi;
                item.PassApi = input.PassApi;
                item.ShopId = input.ShopId;
                item.ClientId = input.ClientId;
                item.Post = input.Post;
                item.Address = input.Address;
                item.Email = input.Email;
                item.ShopName = input.ShopName;
                item.ShopPhone = input.ShopPhone;
                item.ProviderTypeCode = input.ProviderTypeCode;
                item.IsDelete = input.IsDelete;
                item.AutoSelect = input.AutoSelect;
                item.InitWeightSelect = input.InitWeightSelect;
                item.InitWeightSelectMax = input.InitWeightSelectMax;
                item.SelectIndex = input.SelectIndex;
                item.InitPrice = input.InitPrice;
                item.InitWeight = input.InitWeight;
                item.StepWeight = input.StepWeight;
                item.StepPrice = input.StepPrice;
                item.WardCode = input.WardCode;
                item.DistrictCode = input.DistrictCode;
                item.ProvinceCode = input.ProvinceCode;
                item.WardName = input.WardName;
                item.DistrictName = input.DistrictName;
                item.ProvinceName = input.ProvinceName;
                item.ServiceId = input.ServiceId;
                item.PostBT3Id = input.PostBT3Id;
                item.RunMode = input.RunMode;
                item.GroupProvider = input.GroupProvider;
                item.InsuranceValue = input.InsuranceValue;
                item.ClientSecrect = input.ClientSecrect;
                item.PrintLable = input.PrintLable;
                item.DeliveryInitPrice = input.DeliveryInitPrice;
                item.DeliveryInitWeight = input.DeliveryInitWeight;
                item.DeliveryStepWeight = input.DeliveryStepWeight;
                item.DeliveryStepPrice = input.DeliveryStepPrice;
                item.SysInitPrice = input.SysInitPrice;
                item.SysInitWeight = input.SysInitWeight;
                item.SysStepWeight = input.SysStepWeight;
                item.SysStepPrice = input.SysStepPrice;
                item.TranInitPrice = input.TranInitPrice;
                item.TranInitWeight = input.TranInitWeight;
                item.TranStepWeight = input.TranStepWeight;
                item.TranStepPrice = input.TranStepPrice;
                item.ManualSign = input.ManualSign;
                item.IsPickup = input.IsPickup;
                item.LinkCustomerLogin = input.LinkCustomerLogin;
                if (insert)
                {
                    dc.GExpprovider.InsertOnSubmit(base.ConnectionData.Schema, item);
                }
                else
                {
                    dc.GExpprovider.Update(base.ConnectionData.Schema, item);
                }

                // Get lại giá trị của Master
                view_GExpProvider returnItem = dc.VIewgexpprovider.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@Id ", "@Id", item.Id);
                // Change database
                dc.SubmitChanges();
                return returnItem;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        /// <summary>
        /// Get data refer Master GExpProviderType
        /// </summary>
        /// <returns>GExpProviderType</returns>
        public async Task<List<GExpProviderType>> GetMasterProviderTypeCodeList()
        {
            List<GExpProviderType> ls = new List<GExpProviderType>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.GExpprovidertype.GetListObject(ConnectionData.Schema);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
            return ls;
        }
        /// <summary>
        /// Get data refer Master GExpWard
        /// </summary>
        /// <returns>GExpWard</returns>
        public async Task<List<GExpWard>> GetMasterWardCodeList()
        {
            List<GExpWard> ls = new List<GExpWard>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.GExpward.GetListObject(ConnectionData.Schema);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
            return ls;
        }
        /// <summary>
        /// Get data refer Master GExpDistrict
        /// </summary>
        /// <returns>GExpDistrict</returns>
        public async Task<List<GExpDistrict>> GetMasterDistrictCodeList()
        {
            List<GExpDistrict> ls = new List<GExpDistrict>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.GExpdistrict.GetListObject(ConnectionData.Schema);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
            return ls;
        }
        /// <summary>
        /// Get data refer Master GExpProvince
        /// </summary>
        /// <returns>GExpProvince</returns>
        public async Task<List<GExpProvince>> GetMasterProvinceCodeList()
        {
            List<GExpProvince> ls = new List<GExpProvince>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.GExpprovince.GetListObject(ConnectionData.Schema);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
            return ls;
        }
        /// <summary>
        /// Get data refer Master GExpProviderType
        /// </summary>
        /// <returns>GExpProviderType</returns>
        public async Task<List<GExpProviderType>> GetMasterGroupProviderList()
        {
            List<GExpProviderType> ls = new List<GExpProviderType>();
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ls = dc.GExpprovidertype.GetListObject(ConnectionData.Schema);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dc.Close();
            }
            return ls;
        }
    }
}

