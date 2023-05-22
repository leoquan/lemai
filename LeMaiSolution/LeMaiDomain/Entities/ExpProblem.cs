using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpProblem
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Post { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String TypeC1 { get; set; }
		public System.String TypeC2 { get; set; }
		public System.String Note { get; set; }
		public System.String Replay { get; set; }
		public System.String BILL_CODE { get; set; }
		public System.String KEY_DATE { get; set; }
		public ExpProblem(){}
	}
}
