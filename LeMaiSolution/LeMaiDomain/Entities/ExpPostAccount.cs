using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpPostAccount
	{
		//Khai bao các biến
		public System.String FK_AccountId { get; set; }
		public System.String FK_ExpPost { get; set; }
		public System.Int32 Position { get; set; }
		public System.DateTime CreateDate { get; set; }
		public ExpPostAccount(){}
	}
}
