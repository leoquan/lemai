using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class Setting
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Value { get; set; }
		public System.String Description { get; set; }
		public System.Boolean? IsManual { get; set; }
		public System.String GroupName { get; set; }
		public System.Byte[] RowVersion { get; set; }
		public System.String ImageSlug { get; set; }
		public Setting(){}
	}
}
