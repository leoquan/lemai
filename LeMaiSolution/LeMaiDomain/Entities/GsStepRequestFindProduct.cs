using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GsStepRequestFindProduct
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_RequestFindProduct { get; set; }
		public System.String FK_StepDef { get; set; }
		public System.String FK_AccountUser { get; set; }
		public System.String FK_Group { get; set; }
		public System.DateTime ProcessDate { get; set; }
		public System.String Note { get; set; }
		public System.DateTime StartDate { get; set; }
		public System.DateTime? EndDate { get; set; }
		public System.Int32 DuringMinute { get; set; }
		public GsStepRequestFindProduct(){}
	}
}
