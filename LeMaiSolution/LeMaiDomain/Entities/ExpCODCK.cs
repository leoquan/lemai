using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpCODCK
	{
		//Khai bao các biến
		public System.String BILL_CODE { get; set; }
		public System.Int32 SoTienCKCOD { get; set; }
		public System.String FK_Post { get; set; }
		public System.String FK_Account { get; set; }
		public System.DateTime CreateDate { get; set; }
		public ExpCODCK(){}
	}
}
