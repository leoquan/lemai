using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedNhomVp
	{
		//Khai bao các biến
		public System.Int32 id { get; set; }
		public System.String ma { get; set; }
		public System.String ten { get; set; }
		public System.String userid { get; set; }
		public System.Int32? id_nhombhyt { get; set; }
		public System.String kyhieu { get; set; }
		public System.String report { get; set; }
		public System.String lydo { get; set; }
		public MedNhomVp(){}
	}
}
