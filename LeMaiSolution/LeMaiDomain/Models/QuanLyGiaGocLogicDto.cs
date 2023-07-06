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

	public class QuanLyGiaGocLogicInputDto
	{
		public String FK_Post { get; set; }
		[Required(ErrorMessage = "MinWeightMN Not Empty")]
		public Int32 MinWeightMN { get; set; }
		[Required(ErrorMessage = "MinWeightMT Not Empty")]
		public Int32 MinWeightMT { get; set; }
		[Required(ErrorMessage = "MinWeightMB Not Empty")]
		public Int32 MinWeightMB { get; set; }
		[Required(ErrorMessage = "MinFeeMN Not Empty")]
		public Int32 MinFeeMN { get; set; }
		[Required(ErrorMessage = "MinFeeMT Not Empty")]
		public Int32 MinFeeMT { get; set; }
		[Required(ErrorMessage = "MinFeeMB Not Empty")]
		public Int32 MinFeeMB { get; set; }
		[Required(ErrorMessage = "NextFeeMN Not Empty")]
		public Int32 NextFeeMN { get; set; }
		[Required(ErrorMessage = "NextFeeMT Not Empty")]
		public Int32 NextFeeMT { get; set; }
		[Required(ErrorMessage = "NextFeeMB Not Empty")]
		public Int32 NextFeeMB { get; set; }
		[Required(ErrorMessage = "MinWeightInt Not Empty")]
		public Int32 MinWeightInt { get; set; }
		[Required(ErrorMessage = "MinFeeInt Not Empty")]
		public Int32 MinFeeInt { get; set; }
		[Required(ErrorMessage = "NextFeeInt Not Empty")]
		public Int32 NextFeeInt { get; set; }
		[Required(ErrorMessage = "StepWeightInt Not Empty")]
		public Int32 StepWeightInt { get; set; }
		[Required(ErrorMessage = "StepWeightMB Not Empty")]
		public Int32 StepWeightMB { get; set; }
		[Required(ErrorMessage = "StepWeightMT Not Empty")]
		public Int32 StepWeightMT { get; set; }
		[Required(ErrorMessage = "StepWeightMN Not Empty")]
		public Int32 StepWeightMN { get; set; }
		[Required(ErrorMessage = "ReturnFee Not Empty")]
		public Boolean ReturnFee { get; set; }
		[Required(ErrorMessage = "Insurance Not Empty")]
		public Int32 Insurance { get; set; }
		[Required(ErrorMessage = "CODFee Not Empty")]
		public Int32 CODFee { get; set; }
	}
	public class QuanLyGiaGocLogicOutputDto:view_GExpFeeDebitSession
	{
	}
}

