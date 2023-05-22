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

	public class ProvineProblemLogicInputDto
	{
		[Required(ErrorMessage = "ProvinceName Not Empty")]
		public String ProvinceName { get; set; }
		[Required(ErrorMessage = "KeyWord Not Empty")]
		public String KeyWord { get; set; }
	}
	public class ProvineProblemLogicOutputDto:view_ExpProviceProblem
	{
	}
}

