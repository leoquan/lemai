using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ContactHistory
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Name { get; set; }
		public System.String Phone { get; set; }
		public System.String Email { get; set; }
		public System.String Title { get; set; }
		public System.String ContactMesage { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.Boolean IsRead { get; set; }
		public ContactHistory(){}
	}
}
