using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GsCCY
	{
		//Khai bao các biến
		public System.String Code { get; set; }
		public System.String CCYName { get; set; }
		public System.Boolean DefaultCCY { get; set; }
		public System.Boolean TradeCCY { get; set; }
		public System.Decimal ExchangeRate { get; set; }
		public System.Decimal? ExchangeRateBuy { get; set; }
		public System.Boolean IsDelete { get; set; }
		public System.Int32? SortIndex { get; set; }
		public GsCCY(){}
	}
}
