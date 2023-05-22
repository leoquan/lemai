using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeMaiDomain
{
	public class MenuHelper_GetDataMenuOutput
	{

		public List<MenuHelper_MenuFunctionOutput> listMenu { get; set; }
		public List<MenuHelper_MenuFunctionSubGroupOutput> listSubGroup { get; set; }
		public List<MenuHelper_MenuFunctionGroupOutput> listGroup { get; set; }
	}
	public class MenuHelper_GetDataPermissionOutput
	{
		public string Id { get; set; }
		public List<MenuHelper_MenuFunctionPermissonOutput> listPermisson { get; set; }
	}
	public class MenuHelper_MenuFunctionOutput
	{
		public string Id { get; set; }
		public string Title { get; set; }
		public string ControllerName { get; set; }
		public string AcctionName { get; set; }
		public string ControllerNameView { get; set; }
		public string AcctionNameView { get; set; }
		public string RouteId { get; set; }
		public bool IsMenu { get; set; }
		public bool IsPublic { get; set; }
		public string Icon { get; set; }
		public string CssClass { get; set; }
		public string Parrent { get; set; }
		public int Status { get; set; }
		public DateTime CreateDate { get; set; }
		public int SortIndex { get; set; }
		public string FK_MenuSubGroup { get; set; }
		public string Note { get; set; }
	}
	public class MenuHelper_MenuFunctionPermissonOutput
	{
		public string Id { get; set; }
		public string Title { get; set; }
		public string ControllerName { get; set; }
		public string AcctionName { get; set; }
		public string ControllerNameView { get; set; }
		public string AcctionNameView { get; set; }
		public string RouteId { get; set; }
	}
	public class MenuHelper_MenuFunctionGroupOutput
	{
		public string Id { get; set; }
		public string GroupName { get; set; }
		public string Icon { get; set; }
		public string CssClass { get; set; }
		public int SortIndex { get; set; }
		public DateTime CreateDate { get; set; }
		public int Status { get; set; }
	}
	public class MenuHelper_MenuFunctionSubGroupOutput
	{
		public string Id { get; set; }
		public string SubGroupName { get; set; }
		public int SortIndex { get; set; }
		public string Icon { get; set; }
		public string CssClass { get; set; }
		public DateTime CreateDate { get; set; }
		public int Status { get; set; }
		public string FK_MenuGroup { get; set; }
	}
}

