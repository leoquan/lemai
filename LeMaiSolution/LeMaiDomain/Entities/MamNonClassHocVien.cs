using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MamNonClassHocVien
	{
		//Khai bao các biến
		public System.String FK_MamNonClass { get; set; }
		public System.String FK_MamNonHocVien { get; set; }
		public System.DateTime NgayThamGia { get; set; }
		public MamNonClassHocVien(){}
	}
}
