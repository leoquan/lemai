using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpWebhookPort
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Provider { get; set; }
		public System.String PostLink { get; set; }
		public System.String Token { get; set; }
		public GExpWebhookPort(){}
	}
}
