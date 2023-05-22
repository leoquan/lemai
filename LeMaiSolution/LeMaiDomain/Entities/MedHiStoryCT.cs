using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedHiStoryCT
	{
		//Khai bao các biến
		public System.String id { get; set; }
		public System.String id_history { get; set; }
		public System.String id_user { get; set; }
		public System.DateTime ngaytao { get; set; }
		public System.String enumaction { get; set; }
		public System.String actioned { get; set; }
		public System.String id_actioned { get; set; }
		public System.String maql { get; set; }
		public MedHiStoryCT(){}
	}
}
