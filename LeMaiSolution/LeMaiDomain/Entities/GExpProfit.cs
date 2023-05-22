using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpProfit
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.DateTime DateComfirm { get; set; }
		public System.String BT3Code { get; set; }
		public System.String StatusName { get; set; }
		public System.Decimal FeeConfirm { get; set; }
		public System.Decimal FeeTotal { get; set; }
		public System.Decimal Profit { get; set; }
		public GExpProfit(){}
	}
}
