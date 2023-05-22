using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class WebGalleryImage
	{
		//Khai bao các biến
		public System.String FK_WebGallery { get; set; }
		public System.String FK_WebImage { get; set; }
		public System.Int32 OrderNumber { get; set; }
		public WebGalleryImage(){}
	}
}
