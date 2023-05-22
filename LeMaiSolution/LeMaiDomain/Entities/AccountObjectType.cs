using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class AccountObjectType
	{
		//Khai bao các biến
		public System.Int32 Id { get; set; }
		public System.String AccountTypeName { get; set; }
		public System.String NhomTaiKhoan { get; set; }
		public AccountObjectType(){}
	}
}
