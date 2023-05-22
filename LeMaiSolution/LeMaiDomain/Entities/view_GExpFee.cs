using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_GExpFee
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_Post { get; set; }
		public System.String FeeName { get; set; }
		public System.Boolean DefaultFee { get; set; }
		public System.String TenDaiLy { get; set; }
		public System.String ZoneCode { get; set; }
		public view_GExpFee(){}
	}
}
