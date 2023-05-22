using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedKetLuanMau
	{
		//Khai bao các biến
		public System.String id { get; set; }
		public System.String tenmau { get; set; }
		public System.String noidung { get; set; }
		public MedKetLuanMau(){}
	}
}
