using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpCheckBalance
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Post { get; set; }
		public System.Decimal CurMoney { get; set; }
		public System.DateTime CheckDate { get; set; }
		public System.Decimal DiffMoney { get; set; }
		public ExpCheckBalance(){}
	}
}
