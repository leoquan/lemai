using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedCotBaoCao
	{
		//Khai bao các biến
		public System.String macot { get; set; }
		public System.String tencot { get; set; }
		public System.String nguoitao { get; set; }
		public System.DateTime ngaytao { get; set; }
		public System.Int32? indexview { get; set; }
		public System.String macdinh { get; set; }
		public MedCotBaoCao(){}
	}
}
