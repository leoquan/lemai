using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_VihcleCouponDetail
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_Service { get; set; }
		public System.String FK_VihcleCoupon { get; set; }
		public System.Int32 CurrentValue { get; set; }
		public System.DateTime ServiceDate { get; set; }
		public System.String ServiceName { get; set; }
		public System.Decimal? ValueCycle { get; set; }
		public System.String ConfigNote { get; set; }
		public view_VihcleCouponDetail(){}
	}
}
