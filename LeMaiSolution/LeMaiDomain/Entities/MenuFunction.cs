using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MenuFunction
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Title { get; set; }
		public System.String ControllerName { get; set; }
		public System.String AcctionName { get; set; }
		public System.String ControllerNameApi { get; set; }
		public System.String AcctionNameApi { get; set; }
		public System.String RouteId { get; set; }
		public System.Boolean IsMenu { get; set; }
		public System.Boolean IsPublic { get; set; }
		public System.String Icon { get; set; }
		public System.String CssClass { get; set; }
		public System.String Parrent { get; set; }
		public System.Int32 Status { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.Int32 SortIndex { get; set; }
		public System.String Note { get; set; }
		public System.Int32 ProjectUsed { get; set; }
		public System.String FK_MenuGroup { get; set; }
		public System.Int32? MenuWidth { get; set; }
		public System.String MenuImageName { get; set; }
		public System.String FK_MenuImage { get; set; }
		public System.String CreateUser { get; set; }
		public System.String UpdateUser { get; set; }
		public System.Int32 FormShowType { get; set; }
		public MenuFunction(){}
	}
}
