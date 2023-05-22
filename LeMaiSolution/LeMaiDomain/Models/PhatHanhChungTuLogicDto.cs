using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LeMaiDomain.Models
{
		//Sample 
		//[MaxLength(100)]
		//[RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")]
		//[Range(1, 10, ErrorMessage = "data must be between 1 and 10")]

	public class childPhatHanhChungTuLogicInputDto
	{
		[Required(ErrorMessage = "FK_ExpChungTu Not Empty")]
		public String FK_ExpChungTu { get; set; }
		[Required(ErrorMessage = "BILL_CODE Not Empty")]
		public String BILL_CODE { get; set; }
		[Required(ErrorMessage = "SoTienPhaiThu Not Empty")]
		public Decimal SoTienPhaiThu { get; set; }
		[Required(ErrorMessage = "SoTienPhaiChi Not Empty")]
		public Decimal SoTienPhaiChi { get; set; }
		[Required(ErrorMessage = "TenNguoiNhan Not Empty")]
		public String TenNguoiNhan { get; set; }
		[Required(ErrorMessage = "SoDienThoaiNhan Not Empty")]
		public String SoDienThoaiNhan { get; set; }
		[Required(ErrorMessage = "DiaChiNhan Not Empty")]
		public String DiaChiNhan { get; set; }
		[Required(ErrorMessage = "SoTienThuHo Not Empty")]
		public Decimal SoTienThuHo { get; set; }
		[Required(ErrorMessage = "CuocPhiVanChuyen Not Empty")]
		public Decimal CuocPhiVanChuyen { get; set; }
		[Required(ErrorMessage = "TenHang Not Empty")]
		public String TenHang { get; set; }
		[Required(ErrorMessage = "TrongLuong Not Empty")]
		public Decimal TrongLuong { get; set; }
		[Required(ErrorMessage = "IsPhatHanh Not Empty")]
		public Boolean IsPhatHanh { get; set; }
		[Required(ErrorMessage = "CuocPhiChuaGTGT Not Empty")]
		public Decimal CuocPhiChuaGTGT { get; set; }
		[Required(ErrorMessage = "ThueGTGT Not Empty")]
		public Decimal ThueGTGT { get; set; }
		[Required(ErrorMessage = "NgayGuiHang Not Empty")]
		public DateTime NgayGuiHang { get; set; }
        public string LoaiThanhToan { get; set; }
    }
	public class PhatHanhChungTuLogicInputDto
	{
		[Required(ErrorMessage = "SoHoaDon Not Empty")]
		public String SoHoaDon { get; set; }
		[Required(ErrorMessage = "NgayHoaDon Not Empty")]
		public DateTime NgayHoaDon { get; set; }
		[Required(ErrorMessage = "SoTienThu Not Empty")]
		public Decimal SoTienThu { get; set; }
		[Required(ErrorMessage = "SoTienChi Not Empty")]
		public Decimal SoTienChi { get; set; }
		[Required(ErrorMessage = "LyDoChi Not Empty")]
		public String LyDoChi { get; set; }
		[Required(ErrorMessage = "LyDoThu Not Empty")]
		public String LyDoThu { get; set; }
		[Required(ErrorMessage = "SoChungTuThu Not Empty")]
		public String SoChungTuThu { get; set; }
		[Required(ErrorMessage = "SoChungTuChi Not Empty")]
		public String SoChungTuChi { get; set; }
		[Required(ErrorMessage = "FK_Account Not Empty")]
		public String FK_Account { get; set; }
		[Required(ErrorMessage = "ThangKT Not Empty")]
		public DateTime ThangKT { get; set; }
		[Required(ErrorMessage = "FK_KyKetToan Not Empty")]
		public String FK_KyKetToan { get; set; }
		[Required(ErrorMessage = "NguoiMuaHang Not Empty")]
		public String NguoiMuaHang { get; set; }
		public String DonViMuaHang { get; set; }
		public String MaSoThue { get; set; }
		public String DiaChi { get; set; }
		public DateTime NgayCT { get; set; }
		public List<childPhatHanhChungTuLogicInputDto> lsExpChungTuCt { get; set; } = new List<childPhatHanhChungTuLogicInputDto>();
	}
	public class PhatHanhChungTuLogicOutputDto:view_ExpChungTu
	{
		public List<childPhatHanhChungTuLogicOutputDto> lsExpChungTuCt { get; set; } = new List<childPhatHanhChungTuLogicOutputDto>();
	}
	public class childPhatHanhChungTuLogicOutputDto:view_ExpChungTuCt
	{
	}
}

