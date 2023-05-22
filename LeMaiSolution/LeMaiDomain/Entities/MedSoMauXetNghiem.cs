using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedSoMauXetNghiem
	{
		//Khai bao các biến
		public System.String maql { get; set; }
		public System.Int32 fromsomau { get; set; }
		public System.Int32 tosomau { get; set; }
		public MedSoMauXetNghiem(){}
	}
}
