using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpProviderSub
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_Provider { get; set; }
		public System.String ProviderName { get; set; }
		public System.String SubProviderName { get; set; }
		public System.String Token { get; set; }
		public System.String ShopId { get; set; }
		public System.String ClientId { get; set; }
		public System.Int32 MinWeight { get; set; }
		public System.Int32 MaxWeight { get; set; }
		public System.String TypeCode { get; set; }
		public GExpProviderSub(){}
	}
}
