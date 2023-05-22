using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpContentMessage
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String AccessToken { get; set; }
		public System.String RefreshToken { get; set; }
		public System.String ContentMessage { get; set; }
		public System.String NotifyAddress { get; set; }
		public System.String NotifyType { get; set; }
		public System.DateTime UpdateDate { get; set; }
		public System.Boolean IsDone { get; set; }
		public ExpContentMessage(){}
	}
}
