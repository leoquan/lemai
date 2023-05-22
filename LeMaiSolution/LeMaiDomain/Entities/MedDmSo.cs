using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedDmSo
	{
		//Khai bao các biến
		public System.Int32 id { get; set; }
		public System.Int32? stt { get; set; }
		public System.String ma { get; set; }
		public System.String ten { get; set; }
		public System.String report { get; set; }
		public System.Decimal? idso { get; set; }
		public System.String kyhieu { get; set; }
		public System.Decimal? thoigiantrakq { get; set; }
		public System.Int32? nhommavach { get; set; }
		public System.Decimal? thoigiantrakqcc { get; set; }
		public MedDmSo(){}
	}
}
