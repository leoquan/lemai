using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedXNThongSoMayCT
	{
		//Khai bao các biến
		public System.Int32 id { get; set; }
		public System.Int32 stt { get; set; }
		public System.Int32? vitri { get; set; }
		public System.String makq { get; set; }
		public System.String tenkq { get; set; }
		public MedXNThongSoMayCT(){}
	}
}
