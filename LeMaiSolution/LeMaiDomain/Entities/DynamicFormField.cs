using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class DynamicFormField
	{
		//Khai bao các biến
		public System.String FK_DynamicForm { get; set; }
		public System.String FK_DynamicField { get; set; }
		public System.Int32 OrderNo { get; set; }
		public DynamicFormField(){}
	}
}
