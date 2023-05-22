using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class CashPayMoneyType
	{
		//Khai bao các biến
		public System.Int32 Id { get; set; }
		public System.String MoneyTypeName { get; set; }
		public System.String Image { get; set; }
		public System.Boolean? IsUsing { get; set; }
		public CashPayMoneyType(){}
	}
}
