using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedKetQuaMayXN
	{
		//Khai bao các biến
		public System.String id { get; set; }
		public System.Int32 sttlm { get; set; }
		public System.String ngay { get; set; }
		public System.Int32 id_mayxn { get; set; }
		public System.String ketqua { get; set; }
		public System.String ketquabd1 { get; set; }
		public System.String ketquabd2 { get; set; }
		public System.String ketquabd3 { get; set; }
		public System.String ketquabd4 { get; set; }
		public System.String ketquabd5 { get; set; }
		public System.String ghichu { get; set; }
		public System.DateTime? ngayud { get; set; }
		public System.Int32? isvalid { get; set; }
		public System.String user_valid { get; set; }
		public System.DateTime? date_valid { get; set; }
		public System.String note_valid { get; set; }
		public System.String fk_workspace { get; set; }
		public MedKetQuaMayXN(){}
	}
}
