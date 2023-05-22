using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GsUnit
	{
		//Khai bao các biến
		public System.String ID { get; set; }
		public System.String UnitName { get; set; }
		public System.Boolean IsWeight { get; set; }
		public System.Decimal KgWeightRate { get; set; }
		public System.Boolean IsDelete { get; set; }
		public GsUnit(){}
	}
}
