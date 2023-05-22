using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MamNonSoDauBai
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.DateTime NgayGhiSo { get; set; }
		public System.String FK_GiaoVien { get; set; }
		public System.String FK_PhaPhoiChuongTrinh { get; set; }
		public System.String FK_MamNonClass { get; set; }
		public System.Int32 SoTiet { get; set; }
		public System.Boolean IsHocBu { get; set; }
		public System.String GhiChu { get; set; }
		public System.String GoogleMap { get; set; }
		public MamNonSoDauBai(){}
	}
}
