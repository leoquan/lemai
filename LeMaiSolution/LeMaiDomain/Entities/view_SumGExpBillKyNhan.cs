using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_SumGExpBillKyNhan
	{
		//Khai bao các biến
		public System.DateTime? DATE_TT { get; set; }
		public System.String FK_Customer { get; set; }
		public System.Int32? COUNT_TT { get; set; }
		public view_SumGExpBillKyNhan(){}
	}
}
