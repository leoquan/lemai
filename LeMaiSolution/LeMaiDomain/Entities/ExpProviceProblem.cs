using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpProviceProblem
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String ProvinceName { get; set; }
		public System.String KeyWord { get; set; }
		public ExpProviceProblem(){}
	}
}
