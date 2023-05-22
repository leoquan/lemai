using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpContact
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String PostName { get; set; }
		public System.String Zalo { get; set; }
		public System.String Phone { get; set; }
		public ExpContact(){}
	}
}
