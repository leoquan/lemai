using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class AccountObjectBranch
	{
		//Khai bao các biến
		public System.String FK_Branch { get; set; }
		public System.String FK_AccountObject { get; set; }
		public System.String FK_Role { get; set; }
		public AccountObjectBranch(){}
	}
}
