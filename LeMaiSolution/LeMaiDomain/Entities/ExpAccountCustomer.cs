using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpAccountCustomer
	{
		//Khai bao các biến
		public System.String FK_Account { get; set; }
		public System.String FK_Customer { get; set; }
		public System.Int32 TypeCode { get; set; }
		public ExpAccountCustomer(){}
	}
}
