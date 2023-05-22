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

	public class NhapVatTuLogicInputDto
	{
		[Required(ErrorMessage = "FK_VatTu Not Empty")]
		public String FK_VatTu { get; set; }
		[Required(ErrorMessage = "NguoiNhap Not Empty")]
		public String NguoiNhap { get; set; }
		[Required(ErrorMessage = "SoLuong Not Empty")]
		public Decimal SoLuong { get; set; }
		[Required(ErrorMessage = "DonGia Not Empty")]
		public Decimal DonGia { get; set; }
		[Required(ErrorMessage = "ThanhTien Not Empty")]
		public Decimal ThanhTien { get; set; }
	}
	public class NhapVatTuLogicOutputDto:view_ExpSaleNhapVatTu
	{
	}
}

