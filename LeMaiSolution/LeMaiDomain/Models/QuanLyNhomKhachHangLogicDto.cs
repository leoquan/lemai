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

	public class QuanLyNhomKhachHangLogicInputDto
	{
		public String Code { get; set; }
		[Required(ErrorMessage = "TenNhom Not Empty")]
		public String TenNhom { get; set; }
		[Required(ErrorMessage = "MacDinh Not Empty")]
		public Boolean MacDinh { get; set; }
		[Required(ErrorMessage = "FK_Post Not Empty")]
		public String FK_Post { get; set; }
	}
	public class QuanLyNhomKhachHangLogicOutputDto:view_ExpCustomerGroup
	{
	}
}

