using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpReCheck
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.DateTime DateAction { get; set; }
		public System.Int32 BalanceValue { get; set; }
		public System.Decimal Weight { get; set; }
		public ExpReCheck(){}
	}
}
