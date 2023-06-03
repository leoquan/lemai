using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class VihcleServiceConfig
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_ServiceId { get; set; }
		public System.String FK_Vihcle { get; set; }
		public System.Decimal ValueCycle { get; set; }
		public System.String Note { get; set; }
		public VihcleServiceConfig(){}
	}
}
