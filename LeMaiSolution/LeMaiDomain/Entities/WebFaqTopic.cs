using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class WebFaqTopic
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String TopicName { get; set; }
		public System.Int32 OrderNumber { get; set; }
		public System.String BranchCode { get; set; }
		public WebFaqTopic(){}
	}
}
