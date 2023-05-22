using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpConsignTransit
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_ExpConsignment { get; set; }
		public System.String FK_ExpPostFrom { get; set; }
		public System.String FK_ExpPostTo { get; set; }
		public System.String CreateBy { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String Note { get; set; }
		public System.Boolean IsDone { get; set; }
		public System.String ImportBy { get; set; }
		public System.DateTime? ImportDate { get; set; }
		public System.String Type { get; set; }
		public ExpConsignTransit(){}
	}
}
