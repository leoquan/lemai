using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedCoSo
	{
		//Khai bao các biến
		public System.String id { get; set; }
		public System.String tencoso { get; set; }
		public System.String diachicoso { get; set; }
		public System.String sodienthoai { get; set; }
		public System.String sofax { get; set; }
		public System.String email { get; set; }
		public System.DateTime createdate { get; set; }
		public System.String createuser { get; set; }
		public System.String schemaused { get; set; }
		public System.String subfixreport { get; set; }
		public MedCoSo(){}
	}
}
