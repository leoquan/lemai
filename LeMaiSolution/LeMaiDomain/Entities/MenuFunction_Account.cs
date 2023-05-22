using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MenuFunction_Account
	{
		//Khai bao các biến
		public System.String FK_AccountObject { get; set; }
		public System.String FK_MenuFunction { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String CreateUser { get; set; }
		public System.Int32 PermissionValue { get; set; }
		public MenuFunction_Account(){}
	}
}
