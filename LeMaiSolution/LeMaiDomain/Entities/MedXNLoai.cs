using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedXNLoai
	{
		//Khai bao các biến
		public System.Int32 id { get; set; }
		public System.Int32? nhom { get; set; }
		public System.Int32? stt { get; set; }
		public System.String ma { get; set; }
		public System.String ten { get; set; }
		public System.String viettat { get; set; }
		public System.Boolean? state { get; set; }
		public System.Decimal? tieuban { get; set; }
		public MedXNLoai(){}
	}
}
