using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpScanType
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String ScanName { get; set; }
		public System.String FormatRegexString { get; set; }
		public GExpScanType(){}
	}
}
