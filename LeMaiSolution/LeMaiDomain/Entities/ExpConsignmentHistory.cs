using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpConsignmentHistory
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_ExpConsignment { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String FK_ExpStatus { get; set; }
		public System.String FK_ExpPost { get; set; }
		public System.String CreateBy { get; set; }
		public System.String Note { get; set; }
		public ExpConsignmentHistory(){}
	}
}
