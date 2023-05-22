using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedKetQuaChanDoanHA
	{
		//Khai bao các biến
		public System.String id { get; set; }
		public System.String id_ketquachandoan { get; set; }
		public System.String id_server { get; set; }
		public System.String filename { get; set; }
		public System.String localpath { get; set; }
		public System.String remotepath { get; set; }
		public MedKetQuaChanDoanHA(){}
	}
}
