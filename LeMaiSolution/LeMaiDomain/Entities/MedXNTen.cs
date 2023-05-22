using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedXNTen
	{
		//Khai bao các biến
		public System.Int32 id { get; set; }
		public System.Int32? loai { get; set; }
		public System.Int32? stt { get; set; }
		public System.String ma { get; set; }
		public System.String ten { get; set; }
		public System.Int32? donvi { get; set; }
		public System.String viettat { get; set; }
		public System.String minnu { get; set; }
		public System.String nu { get; set; }
		public System.String maxnu { get; set; }
		public System.String minnam { get; set; }
		public System.String nam { get; set; }
		public System.String maxnam { get; set; }
		public System.Boolean? state { get; set; }
		public System.String ghichu { get; set; }
		public MedXNTen(){}
	}
}
