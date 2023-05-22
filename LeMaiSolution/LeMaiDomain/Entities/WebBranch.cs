using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class WebBranch
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String BranchName { get; set; }
		public System.String BranchCode { get; set; }
		public WebBranch(){}
	}
}
