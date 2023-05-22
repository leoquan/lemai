using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedLayMau
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
		public System.Int32? loaibn { get; set; }
		public System.Int32? done { get; set; }
		public System.String userid { get; set; }
		public System.DateTime? ngayud { get; set; }
		public MedLayMau(){}
	}
}
