using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class WebLink
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Name { get; set; }
		public System.String Link { get; set; }
		public System.Int32 Type { get; set; }
		public System.String Icon { get; set; }
		public System.String BranchCode { get; set; }
		public WebLink(){}
	}
}
