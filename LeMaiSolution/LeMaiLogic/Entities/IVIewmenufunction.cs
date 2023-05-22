using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewmenufunction
	{
		/// <summary>
		/// Lấy một DataTable view_MenuFunction từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_MenuFunction từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_MenuFunction từ Database
		/// </summary>
		List<view_MenuFunction> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_MenuFunction từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_MenuFunction> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_MenuFunction> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_MenuFunction đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_MenuFunction GetObjectCon(string schema, string condition, params Object[] parameters);
		view_MenuFunction GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
