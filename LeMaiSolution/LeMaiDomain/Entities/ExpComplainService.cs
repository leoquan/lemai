using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpComplainService
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String BillCode { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String CreateBy { get; set; }
		public System.String TypeService { get; set; }
		public System.String ContentComplain { get; set; }
		public System.String DestinationComplain { get; set; }
		public ExpComplainService(){}
	}
}
