using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MenuFunction_Role
	{
		//Khai bao các biến
		public System.String FK_Role { get; set; }
		public System.String FK_MenuFunction { get; set; }
		public System.DateTime CreateDate { get; set; }
		public MenuFunction_Role(){}
	}
}
