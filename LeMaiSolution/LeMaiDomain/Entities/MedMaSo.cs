using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedMaSo
	{
		//Khai bao các biến
		public System.String id { get; set; }
		public System.Decimal giatri { get; set; }
		public MedMaSo(){}
	}
}
