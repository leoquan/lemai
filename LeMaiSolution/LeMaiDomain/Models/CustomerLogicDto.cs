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

	public class CustomerLogicInputDto
	{
		[Required(ErrorMessage = "CustomerName Not Empty")]
		public String CustomerName { get; set; }
		[Required(ErrorMessage = "CustomerPhone Not Empty")]
		public String CustomerPhone { get; set; }
		public String BankName { get; set; }
        public String TenSanPham { get; set; }
        public String AccountName { get; set; }
		public String AccountCode { get; set; }
		public String GoogleMap { get; set; }
		[Required(ErrorMessage = "FK_Post Not Empty")]
		public String FK_Post { get; set; }
		public String CustomerCode { get; set; }
		[Required(ErrorMessage = "ContractCustomer Not Empty")]
		public Boolean ContractCustomer { get; set; }
        public string FK_Group { get; set; }
		public string SoHopDong { get; set; }
		public DateTime NgayHopDong { get; set; }
		public string TenHopDong { get; set; }
		public string DiaChi { get; set; }
        public string FK_BangGia { get; set; }
        public string MaSoThue { get; set; }
        public string TenCongTy { get; set; }
		public bool IsPickup { get; set; }
		public int ProvinceId { get; set; }
		public int DistrictId { get; set; }
		public string WardId { get; set; }

	}
	public class CustomerLogicOutputDto:view_ExpCustomer
	{
	}
}

