using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpReceiveTaskStatus
	{
		//Khai bao các biến
		public System.Int32 Id { get; set; }
		public System.String StatusReceiveName { get; set; }
		public GExpReceiveTaskStatus(){}
	}
}
