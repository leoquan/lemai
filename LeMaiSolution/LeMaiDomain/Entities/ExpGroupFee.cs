using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpGroupFee
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Ten { get; set; }
		public System.String KeyWord { get; set; }
		public System.Int32 GroupFeeVal { get; set; }
		public ExpGroupFee(){}
	}
}
