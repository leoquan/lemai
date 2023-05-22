using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpProviderCustomer
	{
		//Khai bao các biến
		public System.String ProviderId { get; set; }
		public System.String CustomerId { get; set; }
		public System.Boolean DefaultProvider { get; set; }
		public GExpProviderCustomer(){}
	}
}
