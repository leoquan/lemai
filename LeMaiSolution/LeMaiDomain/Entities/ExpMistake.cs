using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpMistake
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String MistakeComment { get; set; }
		public System.String FK_MistakeOn { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String CreateBy { get; set; }
		public ExpMistake(){}
	}
}
