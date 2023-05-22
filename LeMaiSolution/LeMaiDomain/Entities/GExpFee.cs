using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpFee
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_Post { get; set; }
		public System.String FeeName { get; set; }
		public System.Boolean DefaultFee { get; set; }
		public System.String ProvinceApply { get; set; }
		public GExpFee(){}
	}
}
