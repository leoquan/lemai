using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class WebConfig
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String KeyConfig { get; set; }
		public System.String Value { get; set; }
		public System.String ConfigGroup { get; set; }
		public System.String BranchCode { get; set; }
		public WebConfig(){}
	}
}
