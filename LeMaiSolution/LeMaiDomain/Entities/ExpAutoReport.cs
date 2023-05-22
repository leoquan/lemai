using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpAutoReport
	{
		//Khai bao các biến
		public System.String No { get; set; }
		public System.Int32 Hour { get; set; }
		public System.Int32 Minute { get; set; }
		public System.DateTime UpdateDate { get; set; }
		public ExpAutoReport(){}
	}
}
