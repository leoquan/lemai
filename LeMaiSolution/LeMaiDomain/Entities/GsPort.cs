using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GsPort
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String PortName { get; set; }
		public System.String PortAddress { get; set; }
		public System.String PortNameUnsign { get; set; }
		public GsPort(){}
	}
}
