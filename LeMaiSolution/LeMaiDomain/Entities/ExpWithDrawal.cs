using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpWithDrawal
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_ExpPost { get; set; }
		public System.Int32 Value { get; set; }
		public System.String NoiDung { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String CreateBy { get; set; }
		public System.Boolean IsDone { get; set; }
		public System.Boolean IsWithDrawal { get; set; }
		public ExpWithDrawal(){}
	}
}
