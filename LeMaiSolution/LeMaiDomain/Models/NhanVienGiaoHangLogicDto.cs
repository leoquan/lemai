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

	public class NhanVienGiaoHangLogicInputDto
	{
		[Required(ErrorMessage = "ShipperName Not Empty")]
		public String ShipperName { get; set; }
		[Required(ErrorMessage = "ShipperPhone Not Empty")]
		public String ShipperPhone { get; set; }
		[Required(ErrorMessage = "FK_Post Not Empty")]
		public String FK_Post { get; set; }
		[Required(ErrorMessage = "UserName Not Empty")]
		public String UserName { get; set; }
		[Required(ErrorMessage = "Password Not Empty")]
		public String Password { get; set; }
	}
	public class NhanVienGiaoHangLogicOutputDto:view_GexpShipper
	{
	}
}

