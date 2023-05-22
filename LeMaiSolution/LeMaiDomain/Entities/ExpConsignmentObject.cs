using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpConsignmentObject
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FullName { get; set; }
		public System.String SoDienThoai { get; set; }
		public System.String FK_DonViHC { get; set; }
		public System.String SoNha { get; set; }
		public System.String DiaChi { get; set; }
		public System.Boolean IsProvider { get; set; }
		public ExpConsignmentObject(){}
	}
}
