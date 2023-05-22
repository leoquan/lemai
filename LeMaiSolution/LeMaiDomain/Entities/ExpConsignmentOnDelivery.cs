using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpConsignmentOnDelivery
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String YeuCauGiao { get; set; }
		public System.Int32 OrderId { get; set; }
		public ExpConsignmentOnDelivery(){}
	}
}
