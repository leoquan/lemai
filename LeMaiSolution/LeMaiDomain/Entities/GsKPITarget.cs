using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GsKPITarget
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String TargetCode { get; set; }
		public System.String TargetName { get; set; }
		public System.String FK_TargetType { get; set; }
		public System.DateTime ValidFrom { get; set; }
		public System.String FK_AccountObjectType { get; set; }
		public GsKPITarget(){}
	}
}
