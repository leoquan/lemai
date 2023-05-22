using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_GExpRequestMoney
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_Post { get; set; }
		public System.String FK_RequestAccount { get; set; }
		public System.String FK_PostResponse { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.Int32 SoTien { get; set; }
		public System.String RequestCode { get; set; }
		public System.String Note { get; set; }
		public System.Boolean IsConfirm { get; set; }
		public System.String BankAccount { get; set; }
		public System.String BankOwner { get; set; }
		public System.String BankName { get; set; }
		public System.DateTime? ConfirmDate { get; set; }
		public System.Int32? ReSoTien { get; set; }
		public System.String FK_Account { get; set; }
		public System.String DaiLyYeuCau { get; set; }
		public System.String NguoiYeuCau { get; set; }
		public System.String NguoiXuLy { get; set; }
		public System.String DaiLyXuLy { get; set; }
		public view_GExpRequestMoney(){}
	}
}
