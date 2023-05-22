using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class WebSetting
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Value { get; set; }
		public System.String Description { get; set; }
		public System.String BranchCode { get; set; }
		public WebSetting(){}
	}
}
