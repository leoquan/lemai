using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedWorkSpace
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String WorkSpace { get; set; }
		public System.Boolean IsValid { get; set; }
		public System.DateTime StartDate { get; set; }
		public System.DateTime EndDate { get; set; }
		public MedWorkSpace(){}
	}
}
