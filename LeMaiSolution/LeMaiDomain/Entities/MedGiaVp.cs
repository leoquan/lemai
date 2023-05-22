using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedGiaVp
	{
		//Khai bao các biến
		public System.Int32 id { get; set; }
		public System.Int32? id_loai { get; set; }
		public System.String ma { get; set; }
		public System.String ten { get; set; }
		public System.String dvt { get; set; }
		public System.Int32? bhyt { get; set; }
		public System.Int32? gia_th { get; set; }
		public System.Int32? gia_bh { get; set; }
		public System.Int32? gia_yc { get; set; }
		public System.Int32? gia_nn { get; set; }
		public System.Int32? chenhlech { get; set; }
		public System.String goi { get; set; }
		public System.Int32 sudung { get; set; }
		public System.Int32 ktc { get; set; }
		public System.String userid { get; set; }
		public System.DateTime? ngayud { get; set; }
		public System.Int32 phuthu { get; set; }
		public System.Int32 boiduong { get; set; }
		public System.Int32 gia_byt { get; set; }
		public System.String stt_03 { get; set; }
		public System.String stt_04 { get; set; }
		public System.String stt { get; set; }
		public System.String ten_cu { get; set; }
		public System.String thutu { get; set; }
		public System.Int32? id_nhombc { get; set; }
		public System.String tenkhongdau { get; set; }
		public System.String ghichu { get; set; }
		public System.Int32 id_loaipt { get; set; }
		public System.Int32 hoichan { get; set; }
		public System.Int32 lienket { get; set; }
		public System.String ma_icd { get; set; }
		public System.String id_nhomkt { get; set; }
		public System.String cls { get; set; }
		public System.String covid { get; set; }
		public MedGiaVp(){}
	}
}
