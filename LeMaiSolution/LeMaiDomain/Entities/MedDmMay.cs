using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedDmMay
	{
		//Khai bao các biến
		public System.Int32 id { get; set; }
		public System.Int32? stt { get; set; }
		public System.String ma { get; set; }
		public System.String ten { get; set; }
		public System.Boolean tinhtrang { get; set; }
		public System.Int32? iddmso { get; set; }
		public System.Int32? idloaimay { get; set; }
		public System.String comport { get; set; }
		public System.Int32? baudrate { get; set; }
		public System.String databits { get; set; }
		public System.String parity { get; set; }
		public System.String stopbits { get; set; }
		public System.String handshake { get; set; }
		public System.String phuongthuc { get; set; }
		public System.String computername { get; set; }
		public System.String quytrinh { get; set; }
		public MedDmMay(){}
	}
}
