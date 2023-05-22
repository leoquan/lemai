using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedXNLoaiMay
	{
		//Khai bao các biến
		public System.Int32 id { get; set; }
		public System.String ten { get; set; }
		public System.Int32? nhom { get; set; }
		public MedXNLoaiMay(){}
	}
}
