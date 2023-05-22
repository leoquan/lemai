using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_ServiceGroup
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Code { get; set; }
		public System.String GroupName { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String CreateBy { get; set; }
		public System.Boolean IsDelete { get; set; }
		public System.Boolean? ShowOnWeb { get; set; }
		public System.String ShortDescription { get; set; }
		public System.String IconOnWeb { get; set; }
		public System.Boolean IsSevice { get; set; }
		public System.String ImagePath { get; set; }
		public System.Int32? NumberOrder { get; set; }
		public System.String FullName { get; set; }
		public view_ServiceGroup(){}
	}
}
