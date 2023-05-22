using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ServiceCombo
	{
		//Khai bao các biến
		public System.String FK_ComboService { get; set; }
		public System.String FK_ServiceBelong { get; set; }
		public System.Int32 Price { get; set; }
		public ServiceCombo(){}
	}
}
