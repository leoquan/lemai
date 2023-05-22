using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class WebEmployee
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Name { get; set; }
		public System.String Position { get; set; }
		public System.String Email { get; set; }
		public System.String Facebook { get; set; }
		public System.String Twitter { get; set; }
		public System.String Instagram { get; set; }
		public System.Int32 OrderNumber { get; set; }
		public System.String ImagePath { get; set; }
		public System.String Icon { get; set; }
		public System.Boolean ShowOnAbout { get; set; }
		public System.String BranchCode { get; set; }
		public WebEmployee(){}
	}
}
