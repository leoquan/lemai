using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpWardGHSV
	{
		//Khai bao các biến
		public System.String communeCode { get; set; }
		public System.String communeName { get; set; }
		public System.String districtCode { get; set; }
		public System.String WardId { get; set; }
		public GExpWardGHSV(){}
	}
}
