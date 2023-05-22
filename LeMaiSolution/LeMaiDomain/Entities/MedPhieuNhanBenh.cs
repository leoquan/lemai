using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedPhieuNhanBenh
	{
		//Khai bao các biến
		public System.String id { get; set; }
		public System.String id_congty { get; set; }
		public System.String tenphieu { get; set; }
		public System.DateTime tungay { get; set; }
		public System.DateTime denngay { get; set; }
		public System.Int32 trangthai { get; set; }
		public System.String ghichu { get; set; }
		public System.String userid { get; set; }
		public System.DateTime ngayud { get; set; }
		public System.String schemaused { get; set; }
		public System.String fk_source { get; set; }
		public MedPhieuNhanBenh(){}
	}
}
