using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewsubmenugroup
	{
		/// <summary>
		/// Lấy một DataTable view_SubMenuGroup từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_SubMenuGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_SubMenuGroup từ Database
		/// </summary>
		List<view_SubMenuGroup> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_SubMenuGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_SubMenuGroup> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_SubMenuGroup> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_SubMenuGroup đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_SubMenuGroup GetObjectCon(string schema, string condition, params Object[] parameters);
		view_SubMenuGroup GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
