using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_ExpConsignmentCashPay
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_ExtPostFrom { get; set; }
		public System.Int32 CurrentExtPostFrom { get; set; }
		public System.String FK_ExtPostTo { get; set; }
		public System.Int32 CurrentExtPostTo { get; set; }
		public System.Int32 Value { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String CreateBy { get; set; }
		public System.String FK_ExpConsignment { get; set; }
		public System.String Type { get; set; }
		public System.String Note { get; set; }
		public System.Boolean IsDelete { get; set; }
		public System.String FK_AccountDelete { get; set; }
		public System.DateTime? CreateDelete { get; set; }
		public System.String Reason { get; set; }
		public System.String RequestId { get; set; }
		public System.String FromPost { get; set; }
		public System.String ToPost { get; set; }
		public System.String MaDonHang { get; set; }
		public System.String TenHang { get; set; }
		public System.String NguoiGui { get; set; }
		public System.String SoDienThoaiNguoiGui { get; set; }
		public System.String NguoiNhan { get; set; }
		public System.String SoDienThoaiNguoiNhan { get; set; }
		public System.String DiaChiNguoiNhan { get; set; }
		public System.Int32 TongCuoc { get; set; }
		public System.String NguoiTao { get; set; }
		public System.String TenLoai { get; set; }
		public System.String NguoiXoa { get; set; }
		public view_ExpConsignmentCashPay(){}
	}
}
