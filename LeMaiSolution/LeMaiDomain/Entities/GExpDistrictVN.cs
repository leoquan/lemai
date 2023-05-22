using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpDistrictVN
	{
		//Khai bao các biến
		public System.String districtCode { get; set; }
		public System.String districtName { get; set; }
		public System.String provinceCode { get; set; }
		public System.Int32? DistrictID { get; set; }
		public GExpDistrictVN(){}
	}
}
