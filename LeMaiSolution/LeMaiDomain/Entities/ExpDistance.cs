using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpDistance
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Target { get; set; }
		public System.String FromProvine { get; set; }
		public System.String ToProvine { get; set; }
		public System.Int32 Distance { get; set; }
		public ExpDistance(){}
	}
}
