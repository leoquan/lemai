using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class DynamicFilledForms
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_DynamicForm { get; set; }
		public System.String UserName { get; set; }
		public DynamicFilledForms(){}
	}
}
