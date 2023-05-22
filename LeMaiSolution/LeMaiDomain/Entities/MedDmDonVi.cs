using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedDmDonVi
	{
		//Khai bao các biến
		public System.Int32 id { get; set; }
		public System.String ma { get; set; }
		public System.String ten { get; set; }
		public MedDmDonVi(){}
	}
}
