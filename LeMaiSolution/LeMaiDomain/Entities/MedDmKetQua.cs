using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedDmKetQua
	{
		//Khai bao các biến
		public System.Int32 dmten { get; set; }
		public System.Int32 idten { get; set; }
		public System.Int32 stt { get; set; }
		public System.String viettat { get; set; }
		public MedDmKetQua(){}
	}
}
