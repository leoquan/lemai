using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MamNonThuHocPhi
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_MamNonTruong { get; set; }
		public System.Decimal SoTienDuThu { get; set; }
		public System.Decimal SoTienThucThu { get; set; }
		public System.Int32 TinhTrang { get; set; }
		public MamNonThuHocPhi(){}
	}
}
