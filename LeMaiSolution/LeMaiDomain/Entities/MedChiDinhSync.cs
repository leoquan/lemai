using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedChiDinhSync
	{
		//Khai bao các biến
		public System.String id_local { get; set; }
		public System.String id_remote { get; set; }
		public System.String maql { get; set; }
		public MedChiDinhSync(){}
	}
}
