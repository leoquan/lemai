using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GsStepDef
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String StepName { get; set; }
		public System.String FK_WorkFlowDef { get; set; }
		public System.String NextStep { get; set; }
		public System.String BackStep { get; set; }
		public System.String FK_AssignGroup { get; set; }
		public System.String FK_AssignAccount { get; set; }
		public System.Int32 PriotyStep { get; set; }
		public System.Boolean FinalStep { get; set; }
		public System.Boolean? DenyStep { get; set; }
		public GsStepDef(){}
	}
}
