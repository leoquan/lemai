using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpConsignmentStatus
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String StatusName { get; set; }
		public System.Int32 OrderId { get; set; }
		public System.Boolean IsDone { get; set; }
		public ExpConsignmentStatus(){}
	}
}
