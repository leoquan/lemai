using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_SumGExpBill
	{
		//Khai bao các biến
		public System.Int32? SODON { get; set; }
		public System.Decimal? COD_DATT { get; set; }
		public System.Decimal? COD_CHUATT { get; set; }
		public System.Decimal? TONGTIEN { get; set; }
		public System.String FK_Customer { get; set; }
		public view_SumGExpBill(){}
	}
}
