using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedKetQua
	{
		//Khai bao các biến
		public System.String id { get; set; }
		public System.String mabn { get; set; }
		public System.String mavv { get; set; }
		public System.String maql { get; set; }
		public System.DateTime? ngay { get; set; }
		public System.Int32? id_kp { get; set; }
		public System.Int32? id_doituong { get; set; }
		public System.Int32? id_bacsi { get; set; }
		public System.String chandoan { get; set; }
		public System.Int32? somau { get; set; }
		public System.Decimal? sophieu { get; set; }
		public System.DateTime? ngaylm { get; set; }
		public System.Decimal? id_ktv { get; set; }
		public System.Decimal? loaibn { get; set; }
		public System.String ghichu { get; set; }
		public System.String id_laymau { get; set; }
		public System.String mmyy_laymau { get; set; }
		public System.String userid { get; set; }
		public System.DateTime? ngayud { get; set; }
		public System.DateTime? ngayin { get; set; }
		public System.Int32? lanin { get; set; }
		public MedKetQua(){}
	}
}
