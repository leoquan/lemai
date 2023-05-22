using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpProvinceFeeZ
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.Int32 IdProvince { get; set; }
		public System.Int32 MinRangeWeight { get; set; }
		public System.Int32 MaxRangeWeight { get; set; }
		public System.Int32 InitWeight { get; set; }
		public System.Int32 CostFee { get; set; }
		public System.Int32 Fee { get; set; }
		public System.Int32 MaxWeight { get; set; }
		public System.Int32 Step { get; set; }
		public System.Int32 NextWeightFee { get; set; }
		public System.Boolean IsRangeOnly { get; set; }
		public GExpProvinceFeeZ(){}
	}
}
