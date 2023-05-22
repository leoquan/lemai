using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class QueueNumber
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String KeyValue { get; set; }
		public System.Int32 Value { get; set; }
		public System.String FK_Branch { get; set; }
		public QueueNumber(){}
	}
}
