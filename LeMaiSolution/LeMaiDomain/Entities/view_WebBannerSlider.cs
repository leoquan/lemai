using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_WebBannerSlider
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String BannerName { get; set; }
		public System.String BannerTitle { get; set; }
		public System.String BannerDescription { get; set; }
		public System.String ImagePath { get; set; }
		public System.String LinkDetail { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String FK_CreateBy { get; set; }
		public System.DateTime PostValidDate { get; set; }
		public System.Boolean IsDelete { get; set; }
		public System.Int32 Type { get; set; }
		public System.String FullName { get; set; }
		public System.Int32? typeDisplay { get; set; }
		public view_WebBannerSlider(){}
	}
}
