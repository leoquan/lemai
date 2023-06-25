using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_GExpAutoSign
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_Post { get; set; }
		public System.String FK_Shipper { get; set; }
		public System.Int32 MinuteSign { get; set; }
		public System.DateTime ActiveFrom { get; set; }
		public System.String TenDaiLy { get; set; }
		public System.String ShipperName { get; set; }
		public view_GExpAutoSign(){}
	}
}
