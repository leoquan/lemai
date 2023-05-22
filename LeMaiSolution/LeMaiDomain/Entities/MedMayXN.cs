using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedMayXN
	{
		//Khai bao các biến
		public System.Int32 id { get; set; }
		public System.String comport { get; set; }
		public System.Decimal? baudrate { get; set; }
		public System.String databits { get; set; }
		public System.String parity { get; set; }
		public System.String stopbits { get; set; }
		public System.String handshake { get; set; }
		public System.String phuongthuc { get; set; }
		public MedMayXN(){}
	}
}
