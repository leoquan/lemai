using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedKetQuaMacDinh
	{
		//Khai bao các biến
		public System.Int32 id { get; set; }
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
		public System.String noitiet { get; set; }
		public MedKetQuaMacDinh(){}
	}
}
