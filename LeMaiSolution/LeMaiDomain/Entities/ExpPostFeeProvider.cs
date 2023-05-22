using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpPostFeeProvider
	{
		//Khai bao các biến
		public System.String FK_ExpProvider { get; set; }
		public System.String FK_ExpPost { get; set; }
		public System.String FK_ExpFee { get; set; }
		public ExpPostFeeProvider(){}
	}
}
