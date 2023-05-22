using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MenuRole
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Code { get; set; }
		public System.String RoleName { get; set; }
		public System.DateTime AtCreatedDate { get; set; }
		public System.String AtCreatedBy { get; set; }
		public System.DateTime? AtLastModifiedDate { get; set; }
		public System.String AtLastModifiedBy { get; set; }
		public System.Int32 AtRowStatus { get; set; }
		public System.Int32 Prioty { get; set; }
		public MenuRole(){}
	}
}
