using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class AccountObjectAndGroup
	{
		//Khai bao các biến
		public System.String FK_Account { get; set; }
		public System.String FK_Group { get; set; }
		public System.DateTime? Valid { get; set; }
		public AccountObjectAndGroup(){}
	}
}
