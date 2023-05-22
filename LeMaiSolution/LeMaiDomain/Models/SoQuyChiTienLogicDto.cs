using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LeMaiDomain.Models
{
		//Sample 
		//[MaxLength(100)]
		//[RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")]
		//[Range(1, 10, ErrorMessage = "data must be between 1 and 10")]

	public class SoQuyChiTienLogicInputDto
	{
		[Required(ErrorMessage = "FK_ExtPost Not Empty")]
		public String FK_ExtPost { get; set; }
		[Required(ErrorMessage = "IsPay Not Empty")]
		public Boolean IsPay { get; set; }
		public String MaNguoiNopNhan { get; set; }
		[Required(ErrorMessage = "TenNguoiNopNhan Not Empty")]
		public String TenNguoiNopNhan { get; set; }
		public String DiaChi { get; set; }
		public String SoDienThoai { get; set; }
		[Required(ErrorMessage = "Value Not Empty")]
		public Int32 Value { get; set; }
		[Required(ErrorMessage = "CreateBy Not Empty")]
		public String CreateBy { get; set; }
		[Required(ErrorMessage = "SoChungTu Not Empty")]
		public String SoChungTu { get; set; }
		[Required(ErrorMessage = "Type Not Empty")]
		public String Type { get; set; }
		public String Note { get; set; }
		[Required(ErrorMessage = "IsDelete Not Empty")]
		public Boolean IsDelete { get; set; }
		public String FK_AccountDelete { get; set; }
		public DateTime CreateDelete { get; set; }
		public String Reason { get; set; }
		[Required(ErrorMessage = "PrintCopied Not Empty")]
		public Int32 PrintCopied { get; set; }
	}
	public class SoQuyChiTienLogicOutputDto:view_ExpCashPay
	{
	}
}

