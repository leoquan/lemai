using System;
using System.Collections.Generic;

namespace LeMai.Efs;

public partial class ExpCustomer
{
    public string Id { get; set; }

    public string CustomerName { get; set; }

    public string CustomerPhone { get; set; }

    public string BankName { get; set; }

    public string AccountName { get; set; }

    public string AccountCode { get; set; }

    public string GoogleMap { get; set; }

    public string FkPost { get; set; }

    public string CustomerCode { get; set; }

    public bool ContractCustomer { get; set; }

    public string UnsigName { get; set; }

    public string FkGroup { get; set; }

    public string SoHopDong { get; set; }

    public DateTime? NgayHopDong { get; set; }

    public string TenHopDong { get; set; }

    public string DiaChi { get; set; }

    public string FkGiaCuoc { get; set; }

    public string DonVi { get; set; }

    public string MaSoThue { get; set; }

    public string CustomerCodePass { get; set; }

    public string TenSanPham { get; set; }

    public string Token { get; set; }

    public string ShopIdpickup { get; set; }

    public bool? IsPickup { get; set; }

    public string SecrectId { get; set; }

    public int? ProvinceId { get; set; }

    public int? DistrictId { get; set; }

    public string WardId { get; set; }
}
