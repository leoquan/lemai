using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class SchoolHocPhan
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Code { get; set; }
		public System.String HocPhan { get; set; }
		public System.Int32 MinAge { get; set; }
		public System.Int32 MaxAge { get; set; }
		public System.Decimal NumberMonth { get; set; }
		public System.Int32 SoTiet { get; set; }
		public System.Int32 OrderNumber { get; set; }
		public System.String CreateBy { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String FK_SchoolProgram { get; set; }
		public SchoolHocPhan(){}
	}
}
