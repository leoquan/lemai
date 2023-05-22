using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpProvinceFee
	{
		//Khai bao các biến
		public System.String FeeID { get; set; }
		public System.String ProvineName { get; set; }
		public System.Decimal InitWeight { get; set; }
		public System.Decimal NextWeight { get; set; }
		public System.Int32 W05 { get; set; }
		public System.Int32 W10 { get; set; }
		public System.Int32 W30 { get; set; }
		public System.Int32 W50 { get; set; }
		public System.Int32 W500 { get; set; }
		public System.String Zone { get; set; }
		public ExpProvinceFee(){}
	}
}
