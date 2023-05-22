using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class Inventory
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_Stock { get; set; }
		public System.String FK_Service { get; set; }
		public System.Decimal RealityAmount { get; set; }
		public System.Decimal ImportAmount { get; set; }
		public System.Decimal ExportAmount { get; set; }
		public System.Decimal InitAmount { get; set; }
		public System.String Lot { get; set; }
		public System.DateTime ExperiedDate { get; set; }
		public Inventory(){}
	}
}
