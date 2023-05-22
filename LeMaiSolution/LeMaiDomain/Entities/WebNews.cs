using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class WebNews
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Title { get; set; }
		public System.String Tag { get; set; }
		public System.String StaticLink { get; set; }
		public System.String ShortDescription { get; set; }
		public System.String ContentBody { get; set; }
		public System.String FK_Author { get; set; }
		public System.String FK_Category { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String ImagePath { get; set; }
		public System.Int32 ShowPage { get; set; }
		public System.Int32 StatusPage { get; set; }
		public System.Int32 OrderNo { get; set; }
		public System.Int32 ViewCount { get; set; }
		public System.String BranchCode { get; set; }
		public WebNews(){}
	}
}
