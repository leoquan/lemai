using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpFeeMaster
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_Post { get; set; }
		public System.String FK_ProviderId { get; set; }
		public System.Int32 MinWeight { get; set; }
		public System.Int32 MinFee { get; set; }
		public System.Int32 StepWeight { get; set; }
		public System.Int32 NextFee { get; set; }
		public GExpFeeMaster(){}
	}
}
