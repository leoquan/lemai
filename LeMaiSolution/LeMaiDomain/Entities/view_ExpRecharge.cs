using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_ExpRecharge
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String CreateBy { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String FK_PostRequest { get; set; }
		public System.String WithdrawType { get; set; }
		public System.Int32 Value { get; set; }
		public System.Int32 CurrentValue { get; set; }
		public System.String Note { get; set; }
		public System.String NguoiTao { get; set; }
		public System.String TenDaiLy { get; set; }
		public System.String TypeName { get; set; }
		public view_ExpRecharge(){}
	}
}
