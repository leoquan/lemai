using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LeMaiDomain.Models
{
		//Sample 
		//[MaxLength(100)]
		//[RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")]
		//[Range(1, 10, ErrorMessage = "data must be between 1 and 10")]

	public class QuanLyTaiKhoanLogicInputDto
	{
		[Required(ErrorMessage = "FullName Not Empty")]
		public String FullName { get; set; }
		[Required(ErrorMessage = "UserName Not Empty")]
		public String UserName { get; set; }
		[Required(ErrorMessage = "PassWord Not Empty")]
		public String PassWord { get; set; }
		public String Phone { get; set; }
		public String Email { get; set; }
		[Required(ErrorMessage = "AtCreatedBy Not Empty")]
		public String AtCreatedBy { get; set; }
		public String AtLastModifiedBy { get; set; }
		[Required(ErrorMessage = "AtRowStatus Not Empty")]
		public Int32 AtRowStatus { get; set; }
		[Required(ErrorMessage = "AccountType Not Empty")]
		public Int32 AccountType { get; set; }
		public String CardId { get; set; }
		public String Address { get; set; }
		public String IdAccountIntro { get; set; }
		public String FK_BranchOwner { get; set; }
		public String Note { get; set; }
		public Int32 cap { get; set; }
		public String companyid { get; set; }
		public String FK_Leader { get; set; }
	}
	public class QuanLyTaiKhoanLogicOutputDto:view_AccountObject
	{
	}
}

