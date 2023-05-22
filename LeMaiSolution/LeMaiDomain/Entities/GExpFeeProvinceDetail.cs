using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpFeeProvinceDetail
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_GExpFee { get; set; }
		public System.Int32 MinWeight { get; set; }
		public System.Int32 MinFee { get; set; }
		public System.Int32 StepWeight { get; set; }
		public System.Int32 NextFee { get; set; }
		public System.Int32 ProvineId { get; set; }
		public System.String District { get; set; }
		public GExpFeeProvinceDetail(){}
	}
}
