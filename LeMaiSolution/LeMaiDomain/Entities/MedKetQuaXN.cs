using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedKetQuaXN
	{
		//Khai bao các biến
		public System.String id { get; set; }
		public System.Int32 stt { get; set; }
		public System.Int32 id_xnten { get; set; }
		public System.String ketqua { get; set; }
		public System.String ghichu { get; set; }
		public MedKetQuaXN(){}
	}
}
