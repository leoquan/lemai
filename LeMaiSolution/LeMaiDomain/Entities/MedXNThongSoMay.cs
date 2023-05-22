using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedXNThongSoMay
	{
		//Khai bao các biến
		public System.Int32 id { get; set; }
		public System.Int32? mayxn { get; set; }
		public System.Int32? xetnghiem { get; set; }
		public System.String tenfile { get; set; }
		public System.String filepath { get; set; }
		public System.Boolean? mabn { get; set; }
		public System.Boolean? sophieu { get; set; }
		public System.Int32? sudung { get; set; }
		public System.String ma_test { get; set; }
		public MedXNThongSoMay(){}
	}
}
