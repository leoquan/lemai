using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class Stock
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Name { get; set; }
		public System.String FK_Branch { get; set; }
		public System.Boolean IsMatter { get; set; }
		public System.String FK_Owner { get; set; }
		public Stock(){}
	}
}
