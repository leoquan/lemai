using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpDistrict
	{
		//Khai bao các biến
		public System.Int32 DistrictID { get; set; }
		public System.Int32 ProvinceID { get; set; }
		public System.String DistrictName { get; set; }
		public System.String Code { get; set; }
		public System.Int32 Type { get; set; }
		public System.Int32 SupportType { get; set; }
		public GExpDistrict(){}
	}
}
