using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedThongSoKQMayXN
	{
		//Khai bao các biến
		public System.String id { get; set; }
		public System.Int32? stt { get; set; }
		public System.Int32? id_mayxn { get; set; }
		public System.String makqmay { get; set; }
		public System.String tenkqmay { get; set; }
		public System.String ghichu { get; set; }
		public System.Decimal? isreadonly { get; set; }
		public System.String userid { get; set; }
		public System.DateTime? ngayud { get; set; }
		public System.Decimal? heso { get; set; }
		public System.Decimal? morong { get; set; }
		public MedThongSoKQMayXN(){}
	}
}
