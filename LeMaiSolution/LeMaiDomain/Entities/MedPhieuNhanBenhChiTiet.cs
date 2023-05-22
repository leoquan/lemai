using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedPhieuNhanBenhChiTiet
	{
		//Khai bao các biến
		public System.String id_phieunhanbenh { get; set; }
		public System.Int32 stt { get; set; }
		public System.Decimal id_vienphi { get; set; }
		public System.String mavienphi { get; set; }
		public System.String tenvienphi { get; set; }
		public System.String dvttinh { get; set; }
		public System.Int32 dongia { get; set; }
		public MedPhieuNhanBenhChiTiet(){}
	}
}
