using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_SumGExpBillStatus
	{
		//Khai bao các biến
		public System.Int32? COUNT_TT { get; set; }
		public System.Int32 BillStatus { get; set; }
		public System.String FK_Customer { get; set; }
		public System.String StatusName { get; set; }
		public System.String StatusTextColor { get; set; }
		public System.String StatusBackgroundColor { get; set; }
		public view_SumGExpBillStatus(){}
	}
}
