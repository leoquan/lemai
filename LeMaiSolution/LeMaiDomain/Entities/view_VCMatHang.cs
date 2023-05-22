using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_VCMatHang
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String MaHang { get; set; }
		public System.String TenHang { get; set; }
		public System.String TenHangKD { get; set; }
		public view_VCMatHang(){}
	}
}
