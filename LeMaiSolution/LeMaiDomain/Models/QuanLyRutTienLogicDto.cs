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

	public class QuanLyRutTienLogicInputDto
	{
		[Required(ErrorMessage = "Id Not Empty")]
		public String Id { get; set; }
		[Required(ErrorMessage = "FK_Post Not Empty")]
		public String FK_Post { get; set; }
		[Required(ErrorMessage = "FK_RequestAccount Not Empty")]
		public String FK_RequestAccount { get; set; }
		[Required(ErrorMessage = "FK_PostResponse Not Empty")]
		public String FK_PostResponse { get; set; }
		[Required(ErrorMessage = "CreateDate Not Empty")]
		public DateTime CreateDate { get; set; }
		[Required(ErrorMessage = "SoTien Not Empty")]
		public Int32 SoTien { get; set; }
		[Required(ErrorMessage = "RequestCode Not Empty")]
		public String RequestCode { get; set; }
		[Required(ErrorMessage = "Note Not Empty")]
		public String Note { get; set; }
		[Required(ErrorMessage = "IsConfirm Not Empty")]
		public Boolean IsConfirm { get; set; }
		[Required(ErrorMessage = "BankAccount Not Empty")]
		public String BankAccount { get; set; }
		[Required(ErrorMessage = "BankOwner Not Empty")]
		public String BankOwner { get; set; }
		[Required(ErrorMessage = "BankName Not Empty")]
		public String BankName { get; set; }
		public DateTime ConfirmDate { get; set; }
		public Int32 ReSoTien { get; set; }
		public String FK_Account { get; set; }
	}
	public class QuanLyRutTienLogicOutputDto:view_GExpWithdrawMoney
	{
	}
}

