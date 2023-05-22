using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedLoaiKhoaPhong
	{
		//Khai bao các biến
		public System.String id { get; set; }
		public System.String tenloai { get; set; }
		public System.Boolean sudungauto { get; set; }
		public System.String nguoitao { get; set; }
		public System.DateTime ngaytao { get; set; }
		public MedLoaiKhoaPhong(){}
	}
}
