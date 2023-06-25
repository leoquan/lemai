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

	public class QuanLyKyNhanTuDongLogicInputDto
	{
		public String FK_Post { get; set; }
		public String FK_Shipper { get; set; }
		[Required(ErrorMessage = "MinuteSign Not Empty")]
		public Int32 MinuteSign { get; set; }
		[Required(ErrorMessage = "ActiveFrom Not Empty")]
		public DateTime ActiveFrom { get; set; }
	}
	public class QuanLyKyNhanTuDongLogicOutputDto:view_GExpAutoSign
	{
	}
}

