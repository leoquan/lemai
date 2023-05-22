using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedMauKetQua
	{
		//Khai bao các biến
		public System.String id { get; set; }
		public System.String tenmaumota { get; set; }
		public System.String tenmaumotakd { get; set; }
		public System.String maumota { get; set; }
		public System.String ketluan { get; set; }
		public System.Decimal id_vienphi { get; set; }
		public System.DateTime ngaytao { get; set; }
		public System.String nguoitao { get; set; }
		public System.String tieudereport { get; set; }
		public System.String filereport { get; set; }
		public MedMauKetQua(){}
	}
}
