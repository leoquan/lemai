using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class WebPartner
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String PartnerName { get; set; }
		public System.String ImagePath { get; set; }
		public System.String Description { get; set; }
		public System.Int32 OrderNumber { get; set; }
		public System.String BranchCode { get; set; }
		public WebPartner(){}
	}
}
