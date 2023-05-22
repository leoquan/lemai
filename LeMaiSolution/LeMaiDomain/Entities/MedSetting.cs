using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedSetting
	{
		//Khai bao các biến
		public System.String id { get; set; }
		public System.String giatri { get; set; }
		public MedSetting(){}
	}
}
