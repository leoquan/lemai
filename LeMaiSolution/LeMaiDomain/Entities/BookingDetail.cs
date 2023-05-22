using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class BookingDetail
	{
		//Khai bao các biến
		public System.String ID { get; set; }
		public System.String FK_Booking { get; set; }
		public System.String FK_Service { get; set; }
		public System.String CreateBy { get; set; }
		public System.DateTime CreateDate { get; set; }
		public BookingDetail(){}
	}
}
