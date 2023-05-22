using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_ExpLoanCod
	{
		//Khai bao các biến
		public System.String BillCode { get; set; }
		public System.String FK_Account { get; set; }
		public System.String CreateBy { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.Decimal Value { get; set; }
		public System.Boolean IsBoiThuong { get; set; }
		public view_ExpLoanCod(){}
	}
}
