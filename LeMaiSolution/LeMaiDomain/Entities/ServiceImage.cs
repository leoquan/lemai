using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ServiceImage
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_Service { get; set; }
		public System.String ImagePath { get; set; }
		public System.Int32 SortIndex { get; set; }
		public ServiceImage(){}
	}
}
