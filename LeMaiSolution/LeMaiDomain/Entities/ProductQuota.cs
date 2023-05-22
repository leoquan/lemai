using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ProductQuota
	{
		//Khai bao các biến
		public System.String FK_ServiceQuota { get; set; }
		public System.String FK_ServiceRefer { get; set; }
		public System.Int32 Quota { get; set; }
		public ProductQuota(){}
	}
}
