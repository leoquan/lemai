using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpScanTT
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String BillCode { get; set; }
		public System.DateTime ScanDate { get; set; }
		public System.String ToSite { get; set; }
		public System.String FromSite { get; set; }
		public System.String BillSite { get; set; }
		public System.String ScanManCode { get; set; }
		public System.String ErrorMessage { get; set; }
		public System.Boolean IsUpdate { get; set; }
		public System.String ChangeSiteCode { get; set; }
		public ExpScanTT(){}
	}
}
