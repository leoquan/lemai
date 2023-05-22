using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedDmTen
	{
		//Khai bao các biến
		public System.Int32 id { get; set; }
		public System.Int32 dmso { get; set; }
		public System.Int32 vienphi { get; set; }
		public System.Int32? stt { get; set; }
		public System.String ma { get; set; }
		public System.String ten { get; set; }
		public System.String dvt { get; set; }
		public System.Int32? tieuban { get; set; }
		public System.String viettat { get; set; }
		public System.Int32? sudung { get; set; }
		public System.String report { get; set; }
		public System.Int32? id_mayxn { get; set; }
		public System.Int32? tuongduong { get; set; }
		public System.Int32? hiv { get; set; }
		public System.Int32? thoigiantra { get; set; }
		public System.Int32? thoigiantra_cc { get; set; }
		public MedDmTen(){}
	}
}
