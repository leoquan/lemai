using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_VihcleCoupon
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_Vihcle { get; set; }
		public System.Int32 TotalFee { get; set; }
		public System.DateTime Date { get; set; }
		public System.String Note { get; set; }
		public System.Int32 SoKM { get; set; }
		public System.String BienSo { get; set; }
		public System.String TenXe { get; set; }
		public view_VihcleCoupon(){}
	}
}
