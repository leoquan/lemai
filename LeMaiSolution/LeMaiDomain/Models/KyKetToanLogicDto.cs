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

	public class KyKetToanLogicInputDto
	{
		[Required(ErrorMessage = "TenKy Not Empty")]
		public String TenKy { get; set; }
		[Required(ErrorMessage = "SoBangKe Not Empty")]
		public Int32 SoBangKe { get; set; }

		public String QuyenSoChi { get; set; }
		public String QuyenSoThu { get; set; }
		public String QuyenSoTongChi { get; set; }
	}
	public class KyKetToanLogicOutputDto:view_ExpKyKetToan
	{
	}
}

