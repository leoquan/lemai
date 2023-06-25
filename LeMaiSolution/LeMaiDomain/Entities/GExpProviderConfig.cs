using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpProviderConfig
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_FromPost { get; set; }
		public System.String FK_ToPost { get; set; }
		public System.String FK_Provider { get; set; }
		public System.Int32 DeliveryInitPrice { get; set; }
		public System.Int32 DeliveryInitWeight { get; set; }
		public System.Int32 DeliveryStepWeight { get; set; }
		public System.Int32 DeliveryStepPrice { get; set; }
		public System.Int32 SysInitPrice { get; set; }
		public System.Int32 SysInitWeight { get; set; }
		public System.Int32 SysStepWeight { get; set; }
		public System.Int32 SysStepPrice { get; set; }
		public System.Int32 TranInitPrice { get; set; }
		public System.Int32 TranInitWeight { get; set; }
		public System.Int32 TranStepWeight { get; set; }
		public System.Int32 TranStepPrice { get; set; }
		public GExpProviderConfig(){}
	}
}
