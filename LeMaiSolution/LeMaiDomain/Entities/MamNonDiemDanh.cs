using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MamNonDiemDanh
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_SoDauBai { get; set; }
		public System.String FK_HocVien { get; set; }
		public System.Boolean CoMat { get; set; }
		public MamNonDiemDanh(){}
	}
}
