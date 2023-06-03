using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpAutoSign
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.Boolean ApplyForShipper { get; set; }
		public System.String FK_ShipperOrPost { get; set; }
		public System.Int32 MinuteSign { get; set; }
		public System.DateTime ActiveFrom { get; set; }
		public GExpAutoSign(){}
	}
}
