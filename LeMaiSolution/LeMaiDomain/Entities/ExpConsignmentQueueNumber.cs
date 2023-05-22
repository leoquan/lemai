using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpConsignmentQueueNumber
	{
		//Khai bao các biến
		public System.String FK_ExpPost { get; set; }
		public System.String KeyValue { get; set; }
		public System.Int32 Value { get; set; }
		public ExpConsignmentQueueNumber(){}
	}
}
