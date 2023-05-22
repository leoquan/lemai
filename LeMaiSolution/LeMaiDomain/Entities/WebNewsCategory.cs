using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class WebNewsCategory
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String CategoryName { get; set; }
		public System.String Path { get; set; }
		public System.String FK_ParrentCategory { get; set; }
		public System.String Description { get; set; }
		public System.String FK_CreateBy { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.Boolean IsDelete { get; set; }
		public System.Int32 OrderNo { get; set; }
		public System.String BranchCode { get; set; }
		public WebNewsCategory(){}
	}
}
