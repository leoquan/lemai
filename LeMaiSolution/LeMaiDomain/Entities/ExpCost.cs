using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpCost
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Ten { get; set; }
		public System.String Cap { get; set; }
		public System.String CapTren { get; set; }
		public System.Boolean? InternalPost { get; set; }
		public System.Int32? Fee1 { get; set; }
		public System.Int32? Fee2 { get; set; }
		public System.Int32? Fee3 { get; set; }
		public System.Int32? Fee4 { get; set; }
		public System.Int32? Fee5 { get; set; }
		public ExpCost(){}
	}
}
