using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpFee
	{
		//Khai bao các biến
		public System.String MaBG { get; set; }
		public System.Int32 InitWeight { get; set; }
		public System.Int32 InitFee { get; set; }
		public System.Int32 FeePerKg { get; set; }
		public System.Int32 Less20 { get; set; }
		public System.Int32 Less50 { get; set; }
		public System.Int32 Less100 { get; set; }
		public System.Int32 Less300 { get; set; }
		public System.Int32 Less500 { get; set; }
		public System.Int32 Less1000 { get; set; }
		public System.Int32 ElseFee { get; set; }
		public System.Int32 InitFeeFrom { get; set; }
		public System.Int32 FeePerKgFrom { get; set; }
		public System.Int32 Less20From { get; set; }
		public System.Int32 Less50From { get; set; }
		public System.Int32 Less100From { get; set; }
		public System.Int32 Less300From { get; set; }
		public System.Int32 Less500From { get; set; }
		public System.Int32 Less1000From { get; set; }
		public System.Int32 ElseFeeFrom { get; set; }
		public System.Int32 InitFeeTo { get; set; }
		public System.Int32 FeePerKgTo { get; set; }
		public System.Int32 Less20To { get; set; }
		public System.Int32 Less50To { get; set; }
		public System.Int32 Less100To { get; set; }
		public System.Int32 Less300To { get; set; }
		public System.Int32 Less500To { get; set; }
		public System.Int32 Less1000To { get; set; }
		public System.Int32 ElseFeeTo { get; set; }
		public System.Int32 InitFeeSys { get; set; }
		public System.Int32 FeePerKgSys { get; set; }
		public System.Int32 Less20Sys { get; set; }
		public System.Int32 Less50Sys { get; set; }
		public System.Int32 Less100Sys { get; set; }
		public System.Int32 Less300Sys { get; set; }
		public System.Int32 Less500Sys { get; set; }
		public System.Int32 Less1000Sys { get; set; }
		public System.Int32 ElseFeeSys { get; set; }
		public System.Int32 SystemFee { get; set; }
		public System.Int32 InternalFee { get; set; }
		public System.Int32 ExternalFee { get; set; }
		public ExpFee(){}
	}
}
