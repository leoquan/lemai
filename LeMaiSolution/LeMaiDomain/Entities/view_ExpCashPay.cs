using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_ExpCashPay
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_ExtPost { get; set; }
		public System.Boolean IsPay { get; set; }
		public System.String MaNguoiNopNhan { get; set; }
		public System.String TenNguoiNopNhan { get; set; }
		public System.String DiaChi { get; set; }
		public System.String SoDienThoai { get; set; }
		public System.Int32 Value { get; set; }
		public System.Int32 AfterTotalValue { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String CreateBy { get; set; }
		public System.String SoChungTu { get; set; }
		public System.String Type { get; set; }
		public System.String Note { get; set; }
		public System.Boolean IsDelete { get; set; }
		public System.String FK_AccountDelete { get; set; }
		public System.DateTime? CreateDelete { get; set; }
		public System.String Reason { get; set; }
		public System.Int32 PrintCopied { get; set; }
		public System.String TenDaiLy { get; set; }
		public System.String TenLoai { get; set; }
		public System.String NguoiThu { get; set; }
		public System.String NguoiXoa { get; set; }
		public view_ExpCashPay(){}
	}
}
