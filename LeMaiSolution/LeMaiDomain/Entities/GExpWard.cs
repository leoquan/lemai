using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpWard
	{
		//Khai bao các biến
		public System.String WardId { get; set; }
		public System.String Code { get; set; }
		public System.Int32 DistrictID { get; set; }
		public System.String WardName { get; set; }
		public System.Int32 ProvinceID { get; set; }
		public System.String SearchKey { get; set; }
		public System.String DisplayValue { get; set; }
		public GExpWard(){}
	}
}
