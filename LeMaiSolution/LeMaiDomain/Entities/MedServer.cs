using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedServer
	{
		//Khai bao các biến
		public System.String id { get; set; }
		public System.String servername { get; set; }
		public System.String address { get; set; }
		public System.String userftp { get; set; }
		public System.String passftp { get; set; }
		public System.Int32 ftpport { get; set; }
		public System.String ftppath { get; set; }
		public System.DateTime createdate { get; set; }
		public System.String createuser { get; set; }
		public System.Boolean sudung { get; set; }
		public MedServer(){}
	}
}
