using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedBenhNhan
	{
		//Khai bao các biến
		public System.String mabn { get; set; }
		public System.String manhanvien { get; set; }
		public System.String hoten { get; set; }
		public System.String hotenkd { get; set; }
		public System.String ngaysinh { get; set; }
		public System.Int32 namsinh { get; set; }
		public System.Int32 gioitinh { get; set; }
		public System.String id_bophan { get; set; }
		public System.String id_congty { get; set; }
		public System.String nguoitao { get; set; }
		public System.DateTime ngaytao { get; set; }
		public System.String nguoicapnhat { get; set; }
		public System.DateTime? ngaycapnhat { get; set; }
		public System.String id_nhom { get; set; }
		public MedBenhNhan(){}
	}
}
