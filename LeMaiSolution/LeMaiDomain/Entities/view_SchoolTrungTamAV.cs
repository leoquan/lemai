using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_SchoolTrungTamAV
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Code { get; set; }
		public System.String TrungTam { get; set; }
		public System.String EnglishName { get; set; }
		public System.String Phone { get; set; }
		public System.String DiaChi { get; set; }
		public System.String Email { get; set; }
		public System.String GiamDoc { get; set; }
		public System.String HanhChinh { get; set; }
		public System.String SoDienThoai { get; set; }
		public System.String CreateBy { get; set; }
		public System.DateTime CreateDate { get; set; }
		public view_SchoolTrungTamAV(){}
	}
}
