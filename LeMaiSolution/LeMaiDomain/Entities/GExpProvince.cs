using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpProvince
	{
		//Khai bao các biến
		public System.Int32 ProvinceID { get; set; }
		public System.String ProvinceName { get; set; }
		public System.String Code { get; set; }
		public System.String ZoneCode { get; set; }
		public System.Boolean Delay { get; set; }
		public System.String Short { get; set; }
		public GExpProvince(){}
	}
}
