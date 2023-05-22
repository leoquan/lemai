using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ConfigBookingTime
	{
		//Khai bao các biến
		public System.String ID { get; set; }
		public System.Int32 Hour { get; set; }
		public System.Int32 Minute { get; set; }
		public System.Boolean IsPause { get; set; }
		public System.Boolean IsDelete { get; set; }
		public System.Int32 Day { get; set; }
		public System.Int32 Slot { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String CreateBy { get; set; }
		public System.DateTime? ModifyDate { get; set; }
		public System.String ModifyBy { get; set; }
		public ConfigBookingTime(){}
	}
}
