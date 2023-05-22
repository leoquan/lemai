using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GsRequestInstance
	{
		//Khai bao các biến
		public System.String FK_RequestProduct { get; set; }
		public System.String FK_StepDef { get; set; }
		public System.String FK_AssignGroup { get; set; }
		public System.String FK_AssignAccount { get; set; }
		public System.DateTime StartDate { get; set; }
		public System.DateTime EndDate { get; set; }
		public GsRequestInstance(){}
	}
}
