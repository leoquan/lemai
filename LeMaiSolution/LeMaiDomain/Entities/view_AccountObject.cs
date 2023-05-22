using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_AccountObject
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Code { get; set; }
		public System.String FullName { get; set; }
		public System.String UserName { get; set; }
		public System.String PassWord { get; set; }
		public System.String Phone { get; set; }
		public System.String Email { get; set; }
		public System.DateTime AtCreatedDate { get; set; }
		public System.String AtCreatedBy { get; set; }
		public System.DateTime? AtLastModifiedDate { get; set; }
		public System.String AtLastModifiedBy { get; set; }
		public System.Int32 AccountType { get; set; }
		public System.DateTime? LastLogin { get; set; }
		public System.String CardId { get; set; }
		public System.DateTime? BirthDay { get; set; }
		public System.String Address { get; set; }
		public System.String IdAccountIntro { get; set; }
		public System.String ImagePath { get; set; }
		public System.String FK_BranchOwner { get; set; }
		public System.String Note { get; set; }
		public System.Boolean IsDelete { get; set; }
		public System.Int32? Balance { get; set; }
		public System.Int32? RewardPoint { get; set; }
		public System.String TaxCode { get; set; }
		public System.String CreateByName { get; set; }
		public System.String ModifyByName { get; set; }
		public System.String BranchName { get; set; }
		public view_AccountObject(){}
	}
}
