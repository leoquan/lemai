using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpFeeDebitSession
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_Post { get; set; }
		public System.Int32 MinWeightMN { get; set; }
		public System.Int32 MinWeightMT { get; set; }
		public System.Int32 MinWeightMB { get; set; }
		public System.Int32 MinFeeMN { get; set; }
		public System.Int32 MinFeeMT { get; set; }
		public System.Int32 MinFeeMB { get; set; }
		public System.Int32 NextFeeMN { get; set; }
		public System.Int32 NextFeeMT { get; set; }
		public System.Int32 NextFeeMB { get; set; }
		public System.Int32 MinWeightInt { get; set; }
		public System.Int32 MinFeeInt { get; set; }
		public System.Int32 NextFeeInt { get; set; }
		public System.Int32 StepWeightInt { get; set; }
		public System.Int32 StepWeightMB { get; set; }
		public System.Int32 StepWeightMT { get; set; }
		public System.Int32 StepWeightMN { get; set; }
		public System.Boolean ReturnFee { get; set; }
		public System.Int32 Insurance { get; set; }
		public System.Int32 CODFee { get; set; }
		public GExpFeeDebitSession(){}
	}
}
