using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class DynamicFilledFormFields
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_DynamicFilledForms { get; set; }
		public System.String Value { get; set; }
		public System.String FK_DynamicField { get; set; }
		public DynamicFilledFormFields(){}
	}
}
