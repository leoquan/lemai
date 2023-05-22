using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpCode
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.Int32 CurrentValue { get; set; }
		public System.String Post { get; set; }
		public GExpCode(){}
	}
}
