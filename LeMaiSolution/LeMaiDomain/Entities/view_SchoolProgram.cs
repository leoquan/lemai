using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_SchoolProgram
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Code { get; set; }
		public System.String ProgramName { get; set; }
		public System.String ClassName { get; set; }
		public System.String CambridgeStandar { get; set; }
		public System.String CEFRStandar { get; set; }
		public System.Int32 NumberPart { get; set; }
		public System.String CreateBy { get; set; }
		public System.DateTime CreateDate { get; set; }
		public view_SchoolProgram(){}
	}
}
