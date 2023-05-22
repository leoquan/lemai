using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpScanSign
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String BillCode { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String FK_Post { get; set; }
		public System.String FK_Account { get; set; }
		public System.String Note { get; set; }
		public GExpScanSign(){}
	}
}
