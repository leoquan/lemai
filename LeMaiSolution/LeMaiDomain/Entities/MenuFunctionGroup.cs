using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MenuFunctionGroup
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String GroupName { get; set; }
		public System.Int32 SortIndex { get; set; }
		public System.String Icon { get; set; }
		public System.String CssClass { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.Int32 Status { get; set; }
		public System.String FK_MenuGroup { get; set; }
		public System.Int32 ProjectUsed { get; set; }
		public System.String ProgramGroup { get; set; }
		public MenuFunctionGroup(){}
	}
}
