using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_Branch
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String BranchName { get; set; }
		public System.String Address { get; set; }
		public System.String TaxCode { get; set; }
		public System.String Phone { get; set; }
		public System.String Email { get; set; }
		public System.Boolean IsDelete { get; set; }
		public System.String ImagePath { get; set; }
		public System.String BankCode { get; set; }
		public System.String BankName { get; set; }
		public System.String BankOwner { get; set; }
		public view_Branch(){}
	}
}
