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

	public class QuanLyNhanHangLogicInputDto
	{
		[Required(ErrorMessage = "FK_CustomerId Not Empty")]
		public String FK_CustomerId { get; set; }
		[Required(ErrorMessage = "FK_ShipperId Not Empty")]
		public String FK_ShipperId { get; set; }
		[Required(ErrorMessage = "FK_Post Not Empty")]
		public String FK_Post { get; set; }
		[Required(ErrorMessage = "FK_Account Not Empty")]
		public String FK_Account { get; set; }
		[Required(ErrorMessage = "GoodsNumber Not Empty")]
		public Int32 GoodsNumber { get; set; }
		[Required(ErrorMessage = "HaveReturn Not Empty")]
		public Boolean HaveReturn { get; set; }
		public String Note { get; set; }

        public DateTime Date { get; set; }
    }
	public class QuanLyNhanHangLogicOutputDto:view_GExpReceiveTask
	{
	}
}

