using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class WebGallery
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String GalleryName { get; set; }
		public System.String GalleryGroup { get; set; }
		public System.Int32 OrderNumber { get; set; }
		public System.Boolean IsDelete { get; set; }
		public System.String ImagePath { get; set; }
		public System.String ShortDescription { get; set; }
		public System.String Sumary { get; set; }
		public System.String BranchCode { get; set; }
		public WebGallery(){}
	}
}
