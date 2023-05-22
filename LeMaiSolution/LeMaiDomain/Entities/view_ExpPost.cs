using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_ExpPost
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Code { get; set; }
		public System.String TenDaiLy { get; set; }
		public System.String Phone { get; set; }
		public System.String DiaChi { get; set; }
		public System.String Email { get; set; }
		public System.String QuanLy { get; set; }
		public System.String SoDienThoai { get; set; }
		public System.String MaBuuCuc { get; set; }
		public System.String IDLogin { get; set; }
		public System.String Pass { get; set; }
		public System.String DieuPhoi { get; set; }
		public System.Int32 NamSinh { get; set; }
		public System.String CMND { get; set; }
		public System.DateTime? NgayCap { get; set; }
		public System.String SDTCaNhan { get; set; }
		public System.String SoTaiKhoan { get; set; }
		public System.String NganHang { get; set; }
		public System.String ThuongTru { get; set; }
		public System.Int32 FK_DVHC { get; set; }
		public System.String CreateBy { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String GoogleMap { get; set; }
		public System.String ParrentPost { get; set; }
		public System.Int32 ValueBlance { get; set; }
		public System.Int32 DeliveryFee { get; set; }
		public System.Int32 SytemFee { get; set; }
		public System.Int32 CodeFee { get; set; }
		public System.Int32 CODFee { get; set; }
		public System.Int32 InternalDeliveryFee { get; set; }
		public System.Int32 ShipperFee { get; set; }
		public System.Int32 ValueBlanceMoney { get; set; }
		public System.String ZoneCode { get; set; }
		public view_ExpPost(){}
	}
}
