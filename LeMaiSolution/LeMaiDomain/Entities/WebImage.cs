using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class WebImage
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String ImagePath { get; set; }
		public System.String BranchCode { get; set; }
		public WebImage(){}
	}
}
