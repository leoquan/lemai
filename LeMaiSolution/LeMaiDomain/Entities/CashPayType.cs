using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class CashPayType
	{
		//Khai bao các biến
		public System.Int32 Id { get; set; }
		public System.String TypeName { get; set; }
		public System.Boolean IsWithraw { get; set; }
		public CashPayType(){}
	}
}
