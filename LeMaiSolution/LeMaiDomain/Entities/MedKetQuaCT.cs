using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedKetQuaCT
	{
		//Khai bao các biến
		public System.String id { get; set; }
		public System.Int32 stt { get; set; }
		public System.String id_ketqua { get; set; }
		public System.Int32? id_vp { get; set; }
		public System.Int32? id_doituong { get; set; }
		public System.String id_chidinh { get; set; }
		public System.String mmyy_chidinh { get; set; }
		public MedKetQuaCT(){}
	}
}
