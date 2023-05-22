using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GsKPIAccountTarget
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_AccountEmployee { get; set; }
		public System.String FK_KPITarget { get; set; }
		public System.DateTime RegisterDate { get; set; }
		public System.Int32 RegisterValue { get; set; }
		public System.String CreateUser { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String UpdateUser { get; set; }
		public System.DateTime? UpdateDate { get; set; }
		public System.Boolean IsValid { get; set; }
		public GsKPIAccountTarget(){}
	}
}
