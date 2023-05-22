using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedKetQuaChanDoan
	{
		//Khai bao các biến
		public System.String id { get; set; }
		public System.Int32 id_vienphi { get; set; }
		public System.String mabn { get; set; }
		public System.String mavv { get; set; }
		public System.String maql { get; set; }
		public System.Int32? id_kp { get; set; }
		public System.Int32? id_bacsi { get; set; }
		public System.String id_chidinh { get; set; }
		public System.String id_maumota { get; set; }
		public System.DateTime? ngay { get; set; }
		public System.String chandoan { get; set; }
		public System.String mota { get; set; }
		public System.String ketluan { get; set; }
		public System.String ketluanmau { get; set; }
		public System.DateTime ngaychidinh { get; set; }
		public System.Int32? lanin { get; set; }
		public System.String nguoitao { get; set; }
		public System.DateTime ngayud { get; set; }
		public MedKetQuaChanDoan(){}
	}
}
