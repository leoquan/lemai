using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class SaleBangGia
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String TenBangGia { get; set; }
		public System.Boolean BangGiaMacDinh { get; set; }
		public System.Boolean HienThi { get; set; }
		public SaleBangGia(){}
	}
}
