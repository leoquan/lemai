using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpBillStatus
	{
		//Khai bao các biến
		public System.Int32 Id { get; set; }
		public System.String StatusName { get; set; }
		public System.Int32 StatusType { get; set; }
		public System.Boolean IsShowMobile { get; set; }
		public System.String StatusBackgroundColor { get; set; }
		public System.String StatusTextColor { get; set; }
		public System.Int32? SelectNV { get; set; }
		public GExpBillStatus(){}
	}
}
