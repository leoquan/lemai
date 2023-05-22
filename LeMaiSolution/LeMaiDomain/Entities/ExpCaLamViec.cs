using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpCaLamViec
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String TenCaLamViec { get; set; }
		public ExpCaLamViec(){}
	}
}
