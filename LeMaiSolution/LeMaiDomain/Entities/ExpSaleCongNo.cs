using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpSaleCongNo
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.DateTime NgayTao { get; set; }
		public System.String NguoiTao { get; set; }
		public System.String FK_Customer { get; set; }
		public System.String TenKhacHang { get; set; }
		public System.String NoiDung { get; set; }
		public System.Int32 ThanhTien { get; set; }
		public System.Boolean IsThanhToan { get; set; }
		public System.DateTime? NgayThanhToan { get; set; }
		public System.String HinhThuc { get; set; }
		public ExpSaleCongNo(){}
	}
}
