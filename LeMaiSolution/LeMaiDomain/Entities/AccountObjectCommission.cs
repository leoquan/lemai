using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class AccountObjectCommission
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.Int32 RewardPoint { get; set; }
		public System.Boolean IsWithraw { get; set; }
		public System.String FK_Service { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String FK_Branch { get; set; }
		public System.String FK_CreateBy { get; set; }
		public System.String Note { get; set; }
		public System.String FK_Employee { get; set; }
		public AccountObjectCommission(){}
	}
}
