using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedKetQuaEcg
	{
		//Khai bao các biến
		public System.String id { get; set; }
		public System.Int32 somau { get; set; }
		public System.String maql { get; set; }
		public System.String machinename { get; set; }
		public System.String filename { get; set; }
		public System.String localpath { get; set; }
		public System.String remotepath { get; set; }
		public System.String ghichu { get; set; }
		public System.DateTime createdate { get; set; }
		public System.DateTime updatedate { get; set; }
		public System.String localcheckfile { get; set; }
		public MedKetQuaEcg(){}
	}
}
