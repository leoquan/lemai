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

	public class UngCODKHLogicInputDto
	{
		[Required(ErrorMessage = "BillCode Not Empty")]
		public String BillCode { get; set; }
		[Required(ErrorMessage = "FK_Account Not Empty")]
		public String FK_Account { get; set; }
		[Required(ErrorMessage = "CreateBy Not Empty")]
		public String CreateBy { get; set; }
		[Required(ErrorMessage = "Value Not Empty")]
		public Decimal Value { get; set; }
        public bool IsGiaoHangThanhCong { get; set; }
    }
	public class UngCODKHLogicOutputDto:view_ExpLoanCod
	{
	}
}

