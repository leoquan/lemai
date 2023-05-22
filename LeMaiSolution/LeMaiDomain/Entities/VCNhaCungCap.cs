using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class VCNhaCungCap
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String MaNCC { get; set; }
		public System.String TenNhaCungCap { get; set; }
		public System.String TenNhaCungCapKD { get; set; }
		public VCNhaCungCap(){}
	}
}
