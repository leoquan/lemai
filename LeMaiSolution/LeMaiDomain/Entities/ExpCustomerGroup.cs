using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpCustomerGroup
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Code { get; set; }
		public System.String TenNhom { get; set; }
		public System.Boolean MacDinh { get; set; }
		public System.String FK_Post { get; set; }
		public ExpCustomerGroup(){}
	}
}
