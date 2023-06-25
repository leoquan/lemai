using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpShipperCash
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_Shipper { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String FK_Account { get; set; }
		public System.Decimal TotalCash { get; set; }
		public System.String FK_Post { get; set; }
		public GExpShipperCash(){}
	}
}
