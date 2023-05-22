using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpLogErrorCheck
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String BillCode { get; set; }
		public System.String Address { get; set; }
		public System.String HuyenCode { get; set; }
		public System.String SiteCode { get; set; }
		public System.String CreateSite { get; set; }
		public System.String ManCode { get; set; }
		public System.Int32 ResultCheck { get; set; }
		public ExpLogErrorCheck(){}
	}
}
