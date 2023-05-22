using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpSiteAutoRun
	{
		//Khai bao các biến
		public System.String SiteId { get; set; }
		public System.String UserId { get; set; }
		public System.String Password { get; set; }
		public System.String C2SiteCode { get; set; }
		public ExpSiteAutoRun(){}
	}
}
