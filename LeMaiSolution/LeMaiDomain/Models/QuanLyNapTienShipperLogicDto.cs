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

	public class childQuanLyNapTienShipperLogicInputDto
	{
		[Required(ErrorMessage = "Id Not Empty")]
		public String Id { get; set; }
		[Required(ErrorMessage = "BillCode Not Empty")]
		public String BillCode { get; set; }
		[Required(ErrorMessage = "MoneyValue Not Empty")]
		public Decimal MoneyValue { get; set; }
		[Required(ErrorMessage = "Freight Not Empty")]
		public Decimal Freight { get; set; }
		[Required(ErrorMessage = "COD Not Empty")]
		public Decimal COD { get; set; }
		[Required(ErrorMessage = "PayMentType Not Empty")]
		public String PayMentType { get; set; }
		[Required(ErrorMessage = "FK_CashShipper Not Empty")]
		public String FK_CashShipper { get; set; }
	}
	public class QuanLyNapTienShipperLogicInputDto
	{
		[Required(ErrorMessage = "FK_Shipper Not Empty")]
		public String FK_Shipper { get; set; }
		[Required(ErrorMessage = "FK_Account Not Empty")]
		public String FK_Account { get; set; }
		[Required(ErrorMessage = "TotalCash Not Empty")]
		public Decimal TotalCash { get; set; }
		[Required(ErrorMessage = "FK_Post Not Empty")]
		public String FK_Post { get; set; }
		public List<childQuanLyNapTienShipperLogicInputDto> lsGExpShipperCashDetail { get; set; } = new List<childQuanLyNapTienShipperLogicInputDto>();
	}
	public class QuanLyNapTienShipperLogicOutputDto:view_GExpShipperCash
	{
		public List<childQuanLyNapTienShipperLogicOutputDto> lsGExpShipperCashDetail { get; set; } = new List<childQuanLyNapTienShipperLogicOutputDto>();
	}
	public class childQuanLyNapTienShipperLogicOutputDto:view_GExpShipperCashDetail
	{
	}
}

