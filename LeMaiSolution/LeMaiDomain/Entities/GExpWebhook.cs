using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpWebhook
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Provider { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String JsonContent { get; set; }
		public System.Boolean IsProcess { get; set; }
		public System.DateTime? ProcessDate { get; set; }
		public GExpWebhook(){}
	}
}
