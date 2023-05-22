using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpDestination
	{
		//Khai bao các biến
		public System.String ExpId { get; set; }
		public System.String DestinationName { get; set; }
		public System.String Parrent { get; set; }
		public System.String CityCode { get; set; }
		public System.String SubCity { get; set; }
		public System.String KeyWord { get; set; }
		public System.Boolean ScanCome { get; set; }
		public System.String AccountCode { get; set; }
		public ExpDestination(){}
	}
}
