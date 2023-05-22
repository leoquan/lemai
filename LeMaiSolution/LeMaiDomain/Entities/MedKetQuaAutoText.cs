using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedKetQuaAutoText
	{
		//Khai bao các biến
		public System.Int32 id { get; set; }
		public System.String loai { get; set; }
		public System.String macdinh { get; set; }
		public MedKetQuaAutoText(){}
	}
}
