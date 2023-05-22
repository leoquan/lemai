using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class WebFaq
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Question { get; set; }
		public System.String Answer { get; set; }
		public System.String AskName { get; set; }
		public System.String AskEmail { get; set; }
		public System.String AskSubject { get; set; }
		public System.String FK_Topic { get; set; }
		public System.Boolean IsShowOnWeb { get; set; }
		public System.String BranchCode { get; set; }
		public WebFaq(){}
	}
}
