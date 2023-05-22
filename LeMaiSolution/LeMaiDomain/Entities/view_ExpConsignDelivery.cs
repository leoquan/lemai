using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_ExpConsignDelivery
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_ExpConsignment { get; set; }
		public System.String FK_ExpPost { get; set; }
		public System.String FK_Shipper { get; set; }
		public System.String CreateBy { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String Note { get; set; }
		public System.Boolean IsDone { get; set; }
		public System.String Type { get; set; }
		public System.DateTime? DeliveryDate { get; set; }
		public System.String MaDonHang { get; set; }
		public System.String TenHang { get; set; }
		public System.String NguoiGui { get; set; }
		public System.String SoDienThoaiNguoiGui { get; set; }
		public System.String NguoiNhan { get; set; }
		public System.String SoDienThoaiNguoiNhan { get; set; }
		public System.String DiaChiNguoiNhan { get; set; }
		public System.Int32 TongCuoc { get; set; }
		public System.String TenDaiLy { get; set; }
		public System.String ShipperName { get; set; }
		public System.String NguoiTao { get; set; }
		public view_ExpConsignDelivery(){}
	}
}
