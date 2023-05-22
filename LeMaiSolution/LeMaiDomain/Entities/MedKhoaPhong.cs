using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedKhoaPhong
	{
		//Khai bao các biến
		public System.String id { get; set; }
		public System.String ma { get; set; }
		public System.String tenkhoaphong { get; set; }
		public System.String id_coso { get; set; }
		public System.String nguoitao { get; set; }
		public System.DateTime ngaytao { get; set; }
		public System.String id_loaikhoaphong { get; set; }
		public MedKhoaPhong(){}
	}
}
