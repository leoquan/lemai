using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpProvinceGHSV
	{
		//Khai bao các biến
		public System.String provinceCode { get; set; }
		public System.String provinceName { get; set; }
		public System.Int32? ProvinceID { get; set; }
		public GExpProvinceGHSV(){}
	}
}
