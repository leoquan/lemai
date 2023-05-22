using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_ExpCustomer
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String CustomerName { get; set; }
		public System.String CustomerPhone { get; set; }
		public System.String BankName { get; set; }
		public System.String AccountName { get; set; }
		public System.String AccountCode { get; set; }
		public System.String GoogleMap { get; set; }
		public System.String FK_Post { get; set; }
		public System.String CustomerCode { get; set; }
		public System.Boolean ContractCustomer { get; set; }
		public System.String UnsigName { get; set; }
		public System.String FK_Group { get; set; }
		public System.String SoHopDong { get; set; }
		public System.DateTime? NgayHopDong { get; set; }
		public System.String TenHopDong { get; set; }
		public System.String DiaChi { get; set; }
		public System.String FK_GiaCuoc { get; set; }
		public System.String DonVi { get; set; }
		public System.String MaSoThue { get; set; }
		public System.String CustomerCodePass { get; set; }
		public System.String TenSanPham { get; set; }
		public System.String Token { get; set; }
		public System.String ShopIDPickup { get; set; }
		public System.Boolean? IsPickup { get; set; }
		public System.String SecrectId { get; set; }
		public System.Int32? ProvinceId { get; set; }
		public System.Int32? DistrictId { get; set; }
		public System.String WardId { get; set; }
		public view_ExpCustomer(){}
	}
}
