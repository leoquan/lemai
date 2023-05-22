using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class VCLoaiChiPhi
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String TenChiPhi { get; set; }
		public System.Int32 TypeCP { get; set; }
		public System.Decimal Rate { get; set; }
		public VCLoaiChiPhi(){}
	}
}
