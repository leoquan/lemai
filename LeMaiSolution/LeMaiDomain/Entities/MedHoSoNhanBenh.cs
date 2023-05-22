using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedHoSoNhanBenh
	{
		//Khai bao các biến
		public System.String mavv { get; set; }
		public System.String maql { get; set; }
		public System.Int32 sttxetnghiem { get; set; }
		public System.Int32? sttnhanhs { get; set; }
		public System.String mabn { get; set; }
		public System.DateTime? ngaynhan { get; set; }
		public System.String huyetap { get; set; }
		public System.Int32? chieucao { get; set; }
		public System.Int32? cannang { get; set; }
		public System.Decimal? chisobmi { get; set; }
		public System.String tuanhoan { get; set; }
		public System.String hohap { get; set; }
		public System.String tieuhoa { get; set; }
		public System.String thantietnieu { get; set; }
		public System.String coxuongkhop { get; set; }
		public System.String thankinh { get; set; }
		public System.String tamthan { get; set; }
		public System.String ngoaikhoa { get; set; }
		public System.String sanphukhoa { get; set; }
		public System.String mat { get; set; }
		public System.String taimuihong { get; set; }
		public System.String ranghammat { get; set; }
		public System.String dalieu { get; set; }
		public System.Int32 phanloai { get; set; }
		public System.String ketluan { get; set; }
		public System.DateTime? ngaykham { get; set; }
		public System.String icd10code { get; set; }
		public System.String icd10name { get; set; }
		public System.Int32 trangthai { get; set; }
		public System.String ghichu { get; set; }
		public System.String createuser { get; set; }
		public System.DateTime createdate { get; set; }
		public System.String userid { get; set; }
		public System.DateTime? ngayud { get; set; }
		public System.DateTime? ngaykls { get; set; }
		public System.String userkls { get; set; }
		public System.String historychange { get; set; }
		public System.String noitiet { get; set; }
		public System.Int32? mach { get; set; }
		public System.Int32? hs_idvvienphi { get; set; }
		public MedHoSoNhanBenh(){}
	}
}
