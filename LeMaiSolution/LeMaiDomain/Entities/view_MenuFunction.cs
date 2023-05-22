using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_MenuFunction
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
		public System.String SubId { get; set; }
		public System.String SubGroupName { get; set; }
		public System.Int32 SubSortIndex { get; set; }
		public System.String SubIcon { get; set; }
		public System.String SubCssClass { get; set; }
		public System.DateTime SubCreateDate { get; set; }
		public System.Int32 SubStatus { get; set; }
		public System.String SubFK_MenuGroup { get; set; }
		public System.Int32 SubProjectUsed { get; set; }
		public System.String GroupId { get; set; }
		public System.String GroupGroupName { get; set; }
		public System.Int32 GroupSortIndex { get; set; }
		public System.String GroupIcon { get; set; }
		public System.String GroupCssClass { get; set; }
		public System.DateTime GroupCreateDate { get; set; }
		public System.Int32 GroupStatus { get; set; }
		public System.String GroupFK_MenuGroup { get; set; }
		public System.Int32 GroupProjectUsed { get; set; }
		public view_MenuFunction(){}
	}
}
