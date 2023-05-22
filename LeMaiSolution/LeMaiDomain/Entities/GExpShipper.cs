using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpShipper
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String ShipperName { get; set; }
		public System.String ShipperPhone { get; set; }
		public System.String FK_Post { get; set; }
		public System.String UserName { get; set; }
		public System.String Password { get; set; }
		public System.Int32 BalanceValue { get; set; }
		public System.Boolean IsDelete { get; set; }
		public GExpShipper(){}
	}
}
