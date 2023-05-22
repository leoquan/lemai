using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpProviderType
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String ProviderName { get; set; }
		public System.String LinkCustomerLogin { get; set; }
		public System.String ConfigRequest { get; set; }
		public System.String TrackLink { get; set; }
		public GExpProviderType(){}
	}
}
