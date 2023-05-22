using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MamNonThangDiem
	{
		//Khai bao các biến
		public System.Int32 Id { get; set; }
		public System.String TenThangDiem { get; set; }
		public System.Int32 OrderNumber { get; set; }
		public MamNonThangDiem(){}
	}
}
