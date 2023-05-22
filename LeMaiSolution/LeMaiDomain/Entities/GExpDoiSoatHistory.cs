using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpDoiSoatHistory
	{
		//Khai bao các biến
		public System.String BillCode { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String FK_Account { get; set; }
		public GExpDoiSoatHistory(){}
	}
}
