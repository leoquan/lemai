using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class Booking
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_AccountObject { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.DateTime DateBook { get; set; }
		public System.String Note { get; set; }
		public System.String FK_Branch { get; set; }
		public System.Int32 Status { get; set; }
		public System.Boolean IsGift { get; set; }
		public System.String Name { get; set; }
		public System.String Phone { get; set; }
		public System.String FK_ConfigBookingTime { get; set; }
		public Booking(){}
	}
}
