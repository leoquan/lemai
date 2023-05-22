using Common;
using DevComponents.WinForms.Drawing;
using LeMaiDomain;
using LeMaiDomain.Models;
using LeMaiLogic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiDesktop
{
    public interface IConnectApi
    {
        OutResultGHN CreateOrder(view_GExpBillGHNApi bill);
        OutResultGHN UpdateOrder(view_GExpBillGHNApi bill);
        OutResultGHN UpdateCOD(view_GExpBillGHNApi bill);
        OutTrackingResultGHN Tracking(view_GExpBillGHNApi bill);
        OutResultGHN CancelOrder(view_GExpBillGHNApi bill);


    }
    public static class ApiConnectUlti
    {
        public static string GetEncode64(string content, string key)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(content));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        public static void UpdateToken(string providerID, string token, DateTime expires)
        {
            IDataContext dc = new dcDataContextM(PBean.CONNECTION_STRING);
            try
            {
                dc.Open();
                GExpProvider provider = dc.GExpprovider.GetObject(PBean.SCHEMA, providerID);
                if (provider != null)
                {
                    provider.Token = token;
                    provider.ExpiresDate = expires;
                    dc.GExpprovider.Update(PBean.SCHEMA, provider);
                    dc.SubmitChanges();
                }
            }
            finally
            {
                dc.Close();
            }
        }
        public static List<GExpBillStatusName> GetTrackingNameList()
        {
            IDataContext dc = new dcDataContextM(PBean.CONNECTION_STRING);
            try
            {
                dc.Open();
                return dc.GExpbillstatusname.GetListObject(PBean.SCHEMA);
            }
            finally
            {
                dc.Close();
            }
        }
        public static IConnectApi GetApiByName(string providerTypeCode, view_GExpBillGHNApi bill)
        {
            string typeCode = providerTypeCode.Split('_')[0].Trim();
            if (typeCode.Contains("GHN"))
            {
                IDataContext dc = new dcDataContextM(PBean.CONNECTION_STRING);
                try
                {

                    if (bill.Pickup == true)
                    {
                        dc.Open();
                        GExpProvince province = dc.GExpprovince.GetObjectCon(PBean.SCHEMA, "WHERE ProvinceID=@ProvinceID",
                        "@ProvinceID", bill.ProvincePickup);
                        if (province != null)
                        {
                            bill.ProvincePickup = province.ProvinceName;
                        }
                        GExpDistrict district = dc.GExpdistrict.GetObjectCon(PBean.SCHEMA, "WHERE DistrictID=@DistrictID",
                         "@DistrictID", bill.DistricPickup);
                        if (district != null)
                        {
                            bill.DistricPickup = district.DistrictName;
                        }
                        GExpWard ward = dc.GExpward.GetObjectCon(PBean.SCHEMA, "WHERE WardId=@WardId",
                        "@WardId", bill.WardPickup);
                        if (ward != null)
                        {
                            bill.WardPickup = ward.WardName;
                        }
                    }
                }
                finally
                {
                    dc.Close();
                }
                return new ApiGHN();
            }
            else if (typeCode.Contains("VNPOST"))
            {
                // Change Code nơi nhận cho API VNPOST
                IDataContext dc = new dcDataContextM(PBean.CONNECTION_STRING);
                try
                {
                    dc.Open();
                    GExpProvinceVNP province = dc.GExpprovincevnp.GetObjectCon(PBean.SCHEMA, "WHERE ProvinceID=@ProvinceID",
                        "@ProvinceID", bill.AcceptProvinceCode);
                    if (province != null)
                    {
                        bill.AcceptProvinceCodeS = province.provinceCode;
                        bill.AcceptProvince = province.provinceName;
                    }
                    province = dc.GExpprovincevnp.GetObjectCon(PBean.SCHEMA, "WHERE ProvinceID=@ProvinceID",
                        "@ProvinceID", bill.ProvinceCode);
                    if (province != null)
                    {
                        bill.ProvinceName = province.provinceName;
                        bill.ProvinceCode = province.provinceCode;
                    }
                    GExpDistrictVNP district = dc.GExpdistrictvnp.GetObjectCon(PBean.SCHEMA, "WHERE DistrictID=@DistrictID",
                        "@DistrictID", bill.AcceptDistrictCode);
                    if (district != null)
                    {
                        bill.AcceptDistrictCodeS = district.districtCode;
                        bill.AcceptDistrict = district.districtName;
                    }
                    district = dc.GExpdistrictvnp.GetObjectCon(PBean.SCHEMA, "WHERE DistrictID=@DistrictID",
                    "@DistrictID", bill.DistrictCode);
                    if (district != null)
                    {
                        bill.DistrictName = district.districtName;
                        bill.DistrictCode = district.districtCode;

                    }
                    GExpWardVNP ward = dc.GExpwardvnp.GetObjectCon(PBean.SCHEMA, "WHERE WardId=@WardId",
                        "@WardId", bill.AcceptWardCode);
                    if (ward != null)
                    {
                        bill.AcceptWardCode = ward.communeCode;
                        bill.AcceptWardCodeS = ward.communeCode;
                        bill.AcceptWard = ward.communeName;
                    }
                    ward = dc.GExpwardvnp.GetObjectCon(PBean.SCHEMA, "WHERE WardId=@WardId",
                   "@WardId", bill.WardCode);
                    if (ward != null)
                    {
                        bill.WardName = ward.communeName;
                        bill.WardCode = ward.communeCode;
                    }
                }
                finally
                {
                    dc.Close();
                }
                return new ApiVNPOST();
            }
            else if (typeCode.Contains("GHSV"))
            {
                IDataContext dc = new dcDataContextM(PBean.CONNECTION_STRING);
                try
                {
                    dc.Open();
                    GExpProvinceGHSV province = dc.GExpprovinceghsv.GetObjectCon(PBean.SCHEMA, "WHERE ProvinceID=@ProvinceID",
                        "@ProvinceID", bill.AcceptProvinceCode);
                    if (province != null)
                    {
                        bill.AcceptProvinceCodeS = province.provinceCode;
                        bill.AcceptProvince = province.provinceName;
                    }
                    GExpDistrictGHSV district = dc.GExpdistrictghsv.GetObjectCon(PBean.SCHEMA, "WHERE DistrictID=@DistrictID",
                        "@DistrictID", bill.AcceptDistrictCode);
                    if (district != null)
                    {
                        bill.AcceptDistrictCodeS = district.districtCode;
                        bill.AcceptDistrict = district.districtName;
                    }
                    GExpWardGHSV ward = dc.GExpwardghsv.GetObjectCon(PBean.SCHEMA, "WHERE WardId=@WardId",
                        "@WardId", bill.AcceptWardCode);
                    if (ward != null)
                    {
                        bill.AcceptWardCode = ward.communeCode;
                        bill.AcceptWardCodeS = ward.communeCode;
                        bill.AcceptWard = ward.communeName;
                    }
                    // Check pickup
                    if (bill.Pickup == true)
                    {
                        province = dc.GExpprovinceghsv.GetObjectCon(PBean.SCHEMA, "WHERE ProvinceID=@ProvinceID",
                        "@ProvinceID", bill.ProvincePickup);
                        if (province != null)
                        {
                            bill.ProvincePickup = province.provinceCode;
                        }
                        district = dc.GExpdistrictghsv.GetObjectCon(PBean.SCHEMA, "WHERE DistrictID=@DistrictID",
                        "@DistrictID", bill.DistricPickup);
                        if (district != null)
                        {
                            bill.DistricPickup = district.districtCode;
                        }
                        ward = dc.GExpwardghsv.GetObjectCon(PBean.SCHEMA, "WHERE WardId=@WardId",
                        "@WardId", bill.WardPickup);
                        if (ward != null)
                        {
                            bill.WardPickup = ward.communeCode;
                        }
                    }
                }
                finally
                {
                    dc.Close();
                }
                return new ApiGHSV();
            }
            else if (typeCode.Contains("BEST"))
            {
                IDataContext dc = new dcDataContextM(PBean.CONNECTION_STRING);
                try
                {

                    if (bill.Pickup == true)
                    {
                        dc.Open();
                        GExpProvince province = dc.GExpprovince.GetObjectCon(PBean.SCHEMA, "WHERE ProvinceID=@ProvinceID",
                        "@ProvinceID", bill.ProvincePickup);
                        if (province != null)
                        {
                            bill.ProvincePickup = province.ProvinceName;
                        }
                        GExpDistrict district = dc.GExpdistrict.GetObjectCon(PBean.SCHEMA, "WHERE DistrictID=@DistrictID",
                         "@DistrictID", bill.DistricPickup);
                        if (district != null)
                        {
                            bill.DistricPickup = district.DistrictName;
                        }
                        GExpWard ward = dc.GExpward.GetObjectCon(PBean.SCHEMA, "WHERE WardId=@WardId",
                        "@WardId", bill.WardPickup);
                        if (ward != null)
                        {
                            bill.WardPickup = ward.WardName;
                        }
                    }
                }
                finally
                {
                    dc.Close();
                }
                return new ApiBEST();
            }
            else if (typeCode.Contains("NINJA"))
            {
                IDataContext dc = new dcDataContextM(PBean.CONNECTION_STRING);
                try
                {

                    if (bill.Pickup == true)
                    {
                        dc.Open();
                        GExpProvince province = dc.GExpprovince.GetObjectCon(PBean.SCHEMA, "WHERE ProvinceID=@ProvinceID",
                        "@ProvinceID", bill.ProvincePickup);
                        if (province != null)
                        {
                            bill.ProvincePickup = province.ProvinceName;
                        }
                        GExpDistrict district = dc.GExpdistrict.GetObjectCon(PBean.SCHEMA, "WHERE DistrictID=@DistrictID",
                         "@DistrictID", bill.DistricPickup);
                        if (district != null)
                        {
                            bill.DistricPickup = district.DistrictName;
                        }
                        GExpWard ward = dc.GExpward.GetObjectCon(PBean.SCHEMA, "WHERE WardId=@WardId",
                        "@WardId", bill.WardPickup);
                        if (ward != null)
                        {
                            bill.WardPickup = ward.WardName;
                        }
                    }
                }
                finally
                {
                    dc.Close();
                }
                return new ApiNinja();
            }
            else if (typeCode.Contains("JNT"))
            {
                IDataContext dc = new dcDataContextM(PBean.CONNECTION_STRING);
                try
                {
                    dc.Open();

                    // JNT Address
                    GExpProvinceJNT province = dc.GExpprovincejnt.GetObjectCon(PBean.SCHEMA, "WHERE ProvinceID=@ProvinceID",
                        "@ProvinceID", bill.AcceptProvinceCode);
                    if (province != null)
                    {
                        bill.AcceptProvinceCodeS = province.provinceCode;
                        bill.AcceptProvince = province.provinceName;
                    }
                    province = dc.GExpprovincejnt.GetObjectCon(PBean.SCHEMA, "WHERE ProvinceID=@ProvinceID",
                        "@ProvinceID", bill.ProvinceCode);
                    if (province != null)
                    {
                        bill.ProvinceName = province.provinceName;
                        bill.ProvinceCode = province.provinceCode;
                    }
                    GExpDistrictJNT district = dc.GExpdistrictjnt.GetObjectCon(PBean.SCHEMA, "WHERE DistrictID=@DistrictID",
                    "@DistrictID", bill.AcceptDistrictCode);
                    if (district != null)
                    {
                        bill.AcceptDistrictCodeS = district.districtCode;
                        bill.AcceptDistrict = district.districtName;
                    }
                    district = dc.GExpdistrictjnt.GetObjectCon(PBean.SCHEMA, "WHERE DistrictID=@DistrictID",
                    "@DistrictID", bill.DistrictCode);
                    if (district != null)
                    {
                        bill.DistrictName = district.districtName;
                        bill.DistrictCode = district.districtCode;

                    }
                    GExpWardJNT ward = dc.GExpwardjnt.GetObjectCon(PBean.SCHEMA, "WHERE WardId=@WardId",
                    "@WardId", bill.AcceptWardCode);
                    if (ward != null)
                    {
                        bill.AcceptWardCode = ward.communeCode;
                        bill.AcceptWardCodeS = ward.communeCode;
                        bill.AcceptWard = ward.communeName;
                    }
                    ward = dc.GExpwardjnt.GetObjectCon(PBean.SCHEMA, "WHERE WardId=@WardId",
                    "@WardId", bill.WardCode);
                    if (ward != null)
                    {
                        bill.WardName = ward.communeName;
                        bill.WardCode = ward.communeCode;
                    }
                }
                finally
                {
                    dc.Close();
                }
                return new ApiJNT();
            }
            else if (typeCode.Contains("GHTK"))
            {
                IDataContext dc = new dcDataContextM(PBean.CONNECTION_STRING);
                try
                {

                    if (bill.Pickup == true)
                    {
                        dc.Open();
                        GExpProvince province = dc.GExpprovince.GetObjectCon(PBean.SCHEMA, "WHERE ProvinceID=@ProvinceID",
                        "@ProvinceID", bill.ProvincePickup);
                        if (province != null)
                        {
                            bill.ProvincePickup = province.ProvinceName;
                        }
                        GExpDistrict district = dc.GExpdistrict.GetObjectCon(PBean.SCHEMA, "WHERE DistrictID=@DistrictID",
                         "@DistrictID", bill.DistricPickup);
                        if (district != null)
                        {
                            bill.DistricPickup = district.DistrictName;
                        }
                        GExpWard ward = dc.GExpward.GetObjectCon(PBean.SCHEMA, "WHERE WardId=@WardId",
                        "@WardId", bill.WardPickup);
                        if (ward != null)
                        {
                            bill.WardPickup = ward.WardName;
                        }
                    }
                }
                finally
                {
                    dc.Close();
                }
                return new ApiGHTK();
            }
            else if (typeCode.Contains("VIETTEL"))
            {
                IDataContext dc = new dcDataContextM(PBean.CONNECTION_STRING);
                try
                {
                    dc.Open();
                    GExpProvinceVTP province = dc.GExpprovincevtp.GetObjectCon(PBean.SCHEMA, "WHERE ProvinceID=@ProvinceID",
                        "@ProvinceID", bill.AcceptProvinceCode);
                    if (province != null)
                    {
                        bill.AcceptProvinceCodeS = province.provinceCode;
                        bill.AcceptProvince = province.provinceName;
                    }
                    GExpDistrictVTP district = dc.GExpdistrictvtp.GetObjectCon(PBean.SCHEMA, "WHERE DistrictID=@DistrictID",
                        "@DistrictID", bill.AcceptDistrictCode);
                    if (district != null)
                    {
                        bill.AcceptDistrictCodeS = district.districtCode;
                        bill.AcceptDistrict = district.districtName;
                    }
                    GExpWardVTP ward = dc.GExpwardvtp.GetObjectCon(PBean.SCHEMA, "WHERE WardId=@WardId",
                        "@WardId", bill.AcceptWardCode);
                    if (ward != null)
                    {
                        bill.AcceptWardCodeS = ward.communeCode;
                        bill.AcceptWard = ward.communeName;
                    }
                    // Sender Province + District
                    province = dc.GExpprovincevtp.GetObjectCon(PBean.SCHEMA, "WHERE ProvinceID=@ProvinceID",
                        "@ProvinceID", bill.ProvinceCode);
                    if (province != null)
                    {
                        bill.ProvinceCode = province.provinceCode;
                    }
                    district = dc.GExpdistrictvtp.GetObjectCon(PBean.SCHEMA, "WHERE DistrictID=@DistrictID",
                        "@DistrictID", bill.DistrictCode);
                    if (district != null)
                    {
                        bill.DistrictCode = district.districtCode;

                    }
                    ward = dc.GExpwardvtp.GetObjectCon(PBean.SCHEMA, "WHERE WardId=@WardId",
                        "@WardId", bill.WardCode);
                    if (ward != null)
                    {
                        bill.WardCode = ward.communeCode;
                    }
                    // Pickup

                    if (bill.Pickup == true)
                    {
                        dc.Open();
                        province = dc.GExpprovincevtp.GetObjectCon(PBean.SCHEMA, "WHERE ProvinceID=@ProvinceID",
                       "@ProvinceID", bill.ProvincePickup);
                        if (province != null)
                        {
                            bill.ProvincePickup = province.provinceCode;
                        }
                        district = dc.GExpdistrictvtp.GetObjectCon(PBean.SCHEMA, "WHERE DistrictID=@DistrictID",
                        "@DistrictID", bill.DistricPickup);
                        if (district != null)
                        {
                            bill.DistricPickup = district.districtCode;
                        }
                        ward = dc.GExpwardvtp.GetObjectCon(PBean.SCHEMA, "WHERE WardId=@WardId",
                       "@WardId", bill.WardPickup);
                        if (ward != null)
                        {
                            bill.WardPickup = ward.communeCode;
                        }
                    }
                }
                finally
                {
                    dc.Close();
                }
                return new ApiViettel();
            }
            else
            {
                return new ApiNull();
            }
        }
        public static void LogFileApi(string responeContent, string billCode, string provider)
        {
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + "\\App_Log\\" + DateTime.Today.ToString("yyyy_MM_dd") + "_[" + billCode + "]_" + provider + ".log";
                if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\App_Log"))
                {
                    Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\App_Log");
                }
                if (!File.Exists(path))
                {
                    File.Create(path).Close();
                }
                using (StreamWriter w = File.AppendText(path))
                {
                    w.WriteLine(responeContent);
                    w.Flush();
                    w.Close();
                }
            }
            catch
            {
            }
        }
    }
}
