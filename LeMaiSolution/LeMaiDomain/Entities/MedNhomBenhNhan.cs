using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedNhomBenhNhan
	{
		//Khai bao các biến
		public System.String id { get; set; }
		public System.String tennhom { get; set; }
		public System.String id_coso { get; set; }
		public System.String nguoitao { get; set; }
		public System.DateTime ngaytao { get; set; }
		public MedNhomBenhNhan(){}
	}
}
