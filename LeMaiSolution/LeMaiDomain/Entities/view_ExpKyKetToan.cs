using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_ExpKyKetToan
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String TenKy { get; set; }
		public System.Int32 SoBangKe { get; set; }
		public System.DateTime NgayTao { get; set; }
		public System.String QuyenSoChi { get; set; }
		public System.String QuyenSoThu { get; set; }
		public System.String QuyenSoTongChi { get; set; }
		public view_ExpKyKetToan(){}
	}
}
