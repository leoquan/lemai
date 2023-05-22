using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpBillStatusName
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String StatusName { get; set; }
		public System.Int32 BillStatus { get; set; }
		public System.String Note { get; set; }
		public System.Boolean UpdateStatus { get; set; }
		public System.String ScanType { get; set; }
		public GExpBillStatusName(){}
	}
}
