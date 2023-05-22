using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpScan
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Post { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.Decimal Weight { get; set; }
		public System.String Note { get; set; }
		public System.String TypeScan { get; set; }
		public System.String BILL_CODE { get; set; }
		public System.String KeyDate { get; set; }
		public ExpScan(){}
	}
}
