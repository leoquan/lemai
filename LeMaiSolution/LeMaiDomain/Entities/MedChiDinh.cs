using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedChiDinh
	{
		//Khai bao các biến
		public System.String id { get; set; }
		public System.String mabn { get; set; }
		public System.String mavv { get; set; }
		public System.String maql { get; set; }
		public System.DateTime? ngay { get; set; }
		public System.Int32? id_kp { get; set; }
		public System.Int32? id_doituong { get; set; }
		public System.Int32 id_vp { get; set; }
		public System.Int32 soluong { get; set; }
		public System.Int32 dongia { get; set; }
		public System.Int32? loaibn { get; set; }
		public System.String maicd { get; set; }
		public System.String chandoan { get; set; }
		public System.Int32? id_bacsi { get; set; }
		public System.Int32? capcuu { get; set; }
		public System.Int32? thuchien { get; set; }
		public System.Int32? done { get; set; }
		public System.String computer { get; set; }
		public System.String ghichu { get; set; }
		public System.String userid { get; set; }
		public System.DateTime? ngayud { get; set; }
		public System.Int32? id_bn_chidinh { get; set; }
		public System.String hs_mabn { get; set; }
		public MedChiDinh(){}
	}
}
