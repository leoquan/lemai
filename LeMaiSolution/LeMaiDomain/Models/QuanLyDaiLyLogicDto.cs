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

	public class QuanLyDaiLyLogicInputDto
	{
		[Required(ErrorMessage = "Id Not Empty")]
		public String Id { get; set; }
		[Required(ErrorMessage = "Code Not Empty")]
		public String Code { get; set; }
		[Required(ErrorMessage = "TenDaiLy Not Empty")]
		public String TenDaiLy { get; set; }
		public String Phone { get; set; }
		public String DiaChi { get; set; }
		public String Email { get; set; }
		public String QuanLy { get; set; }
		public String SoDienThoai { get; set; }
		public String MaBuuCuc { get; set; }
		public String IDLogin { get; set; }
		public String Pass { get; set; }
		public String DieuPhoi { get; set; }
		[Required(ErrorMessage = "NamSinh Not Empty")]
		public Int32 NamSinh { get; set; }
		public String CMND { get; set; }
		public DateTime NgayCap { get; set; }
		public String SDTCaNhan { get; set; }
		public String SoTaiKhoan { get; set; }
		public String NganHang { get; set; }
		public String ThuongTru { get; set; }
		[Required(ErrorMessage = "FK_DVHC Not Empty")]
		public Int32 FK_DVHC { get; set; }
		[Required(ErrorMessage = "CreateBy Not Empty")]
		public String CreateBy { get; set; }
		public String GoogleMap { get; set; }
		public String ParrentPost { get; set; }
		[Required(ErrorMessage = "DeliveryFee Not Empty")]
		public Int32 DeliveryFee { get; set; }
		[Required(ErrorMessage = "SytemFee Not Empty")]
		public Int32 SytemFee { get; set; }
		[Required(ErrorMessage = "CodeFee Not Empty")]
		public Int32 CodeFee { get; set; }
		[Required(ErrorMessage = "CODFee Not Empty")]
		public Int32 CODFee { get; set; }
		[Required(ErrorMessage = "InternalDeliveryFee Not Empty")]
		public Int32 InternalDeliveryFee { get; set; }
		[Required(ErrorMessage = "ShipperFee Not Empty")]
		public Int32 ShipperFee { get; set; }
		[Required(ErrorMessage = "ZoneCode Not Empty")]
		public String ZoneCode { get; set; }
	}
	public class QuanLyDaiLyLogicOutputDto:view_ExpPost
	{
	}
}

