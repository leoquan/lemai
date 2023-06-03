using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class VihcleService
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String ServiceName { get; set; }
		public System.Boolean IsDistance { get; set; }
		public VihcleService(){}
	}
}
