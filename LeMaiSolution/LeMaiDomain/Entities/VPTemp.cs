using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class VPTemp
	{
		//Khai bao các biến
		public System.String ID { get; set; }
		public System.String GroupId { get; set; }
		public System.String STTTN { get; set; }
		public System.String STTTT { get; set; }
		public System.String MaThuoc { get; set; }
		public System.String HoatChat { get; set; }
		public System.String BietDuoc { get; set; }
		public System.String NongDo { get; set; }
		public System.String BaoChe { get; set; }
		public System.String TrinhBay { get; set; }
		public System.String DuongDung { get; set; }
		public System.String DVT { get; set; }
		public System.String NHOM { get; set; }
		public System.Decimal SoLuong { get; set; }
		public System.Decimal DonGia { get; set; }
		public System.Decimal ThanhTien { get; set; }
		public System.Decimal DonGiaMin { get; set; }
		public System.Decimal DonGiaMax { get; set; }
		public System.String CTY1 { get; set; }
		public System.String TENT1 { get; set; }
		public System.String DONGIA1 { get; set; }
		public System.String GIAKK1 { get; set; }
		public System.String CTY2 { get; set; }
		public System.String TENT2 { get; set; }
		public System.String DONGIA2 { get; set; }
		public System.String GIAKK2 { get; set; }
		public System.String CTY3 { get; set; }
		public System.String TENT3 { get; set; }
		public System.String DONGIA3 { get; set; }
		public System.String GIAKK3 { get; set; }
		public System.String Note { get; set; }
		public VPTemp(){}
	}
}
