using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_ExpTotalChungTu
	{
		//Khai bao các biến
		public System.String FK_KyKetToan { get; set; }
		public System.Decimal? THUEVAT_DAPH { get; set; }
		public System.Decimal? THUEVAT_CHUA_PH { get; set; }
		public System.Decimal? PHIVC_DAPH { get; set; }
		public System.Decimal? PHIVC_CHUA_PH { get; set; }
		public System.Decimal? COD_DAPH { get; set; }
		public System.Decimal? COD_CHUA_PH { get; set; }
		public view_ExpTotalChungTu(){}
	}
}
