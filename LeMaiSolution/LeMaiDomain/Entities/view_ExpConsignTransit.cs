using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_ExpConsignTransit
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_ExpConsignment { get; set; }
		public System.String FK_ExpPostFrom { get; set; }
		public System.String FK_ExpPostTo { get; set; }
		public System.String CreateBy { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String Note { get; set; }
		public System.Boolean IsDone { get; set; }
		public System.String ImportBy { get; set; }
		public System.DateTime? ImportDate { get; set; }
		public System.String Type { get; set; }
		public System.String MaDonHang { get; set; }
		public System.String TenHang { get; set; }
		public System.String NguoiGui { get; set; }
		public System.String SoDienThoaiNguoiGui { get; set; }
		public System.String NguoiNhan { get; set; }
		public System.String SoDienThoaiNguoiNhan { get; set; }
		public System.String DiaChiNguoiNhan { get; set; }
		public System.Int32 TongCuoc { get; set; }
		public System.String FromPost { get; set; }
		public System.String ToPost { get; set; }
		public System.String TenNguoiGui { get; set; }
		public System.String TenNguoiNhap { get; set; }
		public view_ExpConsignTransit(){}
	}
}
