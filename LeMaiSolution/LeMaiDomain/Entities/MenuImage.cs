using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MenuImage
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FullName { get; set; }
		public System.String ImageString { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String CreateUser { get; set; }
		public MenuImage(){}
	}
}
