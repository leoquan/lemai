using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpSender
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String SendManPhone { get; set; }
		public System.String SendMan { get; set; }
		public System.String SendAddress { get; set; }
		public GExpSender(){}
	}
}
