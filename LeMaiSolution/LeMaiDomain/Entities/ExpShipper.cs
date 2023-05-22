using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpShipper
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String BillCode { get; set; }
		public System.String Shipper { get; set; }
		public System.DateTime PayDate { get; set; }
		public System.Decimal RequestMoney { get; set; }
		public System.Decimal RealPay { get; set; }
		public System.String Note { get; set; }
		public ExpShipper(){}
	}
}
