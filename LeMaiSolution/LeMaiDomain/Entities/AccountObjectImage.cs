using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class AccountObjectImage
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_AccountObject { get; set; }
		public System.String SessionId { get; set; }
		public System.String ImagePath { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String CreateBy { get; set; }
		public AccountObjectImage(){}
	}
}
