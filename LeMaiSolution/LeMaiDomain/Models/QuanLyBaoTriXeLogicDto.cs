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

	public class childQuanLyBaoTriXeLogicInputDto
	{
		[Required(ErrorMessage = "FK_Service Not Empty")]
		public String FK_Service { get; set; }
		[Required(ErrorMessage = "FK_VihcleCoupon Not Empty")]
		public String FK_VihcleCoupon { get; set; }
		[Required(ErrorMessage = "CurrentValue Not Empty")]
		public Int32 CurrentValue { get; set; }
	}
	public class QuanLyBaoTriXeLogicInputDto
	{
		[Required(ErrorMessage = "FK_Vihcle Not Empty")]
		public String FK_Vihcle { get; set; }
		[Required(ErrorMessage = "TotalFee Not Empty")]
		public Int32 TotalFee { get; set; }
		public String Note { get; set; }
		public List<childQuanLyBaoTriXeLogicInputDto> lsVihcleCouponDetail { get; set; } = new List<childQuanLyBaoTriXeLogicInputDto>();
	}
	public class QuanLyBaoTriXeLogicOutputDto:view_VihcleCoupon
	{
		public List<childQuanLyBaoTriXeLogicOutputDto> lsVihcleCouponDetail { get; set; } = new List<childQuanLyBaoTriXeLogicOutputDto>();
	}
	public class childQuanLyBaoTriXeLogicOutputDto:view_VihcleCouponDetail
	{
	}
}

