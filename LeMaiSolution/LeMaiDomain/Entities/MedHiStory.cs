using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedHiStory
	{
		//Khai bao các biến
		public System.String id { get; set; }
		public System.String id_his_login { get; set; }
		public System.String createuser { get; set; }
		public System.DateTime createdate { get; set; }
		public System.String actions { get; set; }
		public MedHiStory(){}
	}
}
