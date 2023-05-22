using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpProvider
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Code { get; set; }
		public System.String TenNhaCungCap { get; set; }
		public System.String Phone { get; set; }
		public System.String DiaChi { get; set; }
		public System.String Email { get; set; }
		public System.String QuanLy { get; set; }
		public System.String SoDienThoai { get; set; }
		public System.String CreateBy { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String GoogleMap { get; set; }
		public System.String ApiUrl { get; set; }
		public System.String ApiUser { get; set; }
		public System.String ApiSecrect { get; set; }
		public ExpProvider(){}
	}
}
