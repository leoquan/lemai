using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedBacSiCDHA
	{
		//Khai bao các biến
		public System.Int32 id { get; set; }
		public System.String tenbacsi { get; set; }
		public System.DateTime createdate { get; set; }
		public System.String createuser { get; set; }
		public MedBacSiCDHA(){}
	}
}
