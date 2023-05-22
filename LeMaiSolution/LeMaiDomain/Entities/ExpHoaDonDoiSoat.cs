using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpHoaDonDoiSoat
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String HoaDon { get; set; }
		public System.DateTime CreateHd { get; set; }
		public System.Decimal SoTienDoiSoat { get; set; }
		public System.String FK_Account { get; set; }
		public System.String AccountName { get; set; }
		public System.String FK_Post { get; set; }
		public System.String GiaoThanhCong { get; set; }
		public ExpHoaDonDoiSoat(){}
	}
}
