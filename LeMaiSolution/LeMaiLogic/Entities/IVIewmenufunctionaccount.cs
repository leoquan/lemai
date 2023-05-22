using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewmenufunctionaccount
	{
		/// <summary>
		/// Lấy một DataTable view_MenuFunctionAccount từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_MenuFunctionAccount từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_MenuFunctionAccount từ Database
		/// </summary>
		List<view_MenuFunctionAccount> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_MenuFunctionAccount từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_MenuFunctionAccount> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_MenuFunctionAccount> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_MenuFunctionAccount đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_MenuFunctionAccount GetObjectCon(string schema, string condition, params Object[] parameters);
		view_MenuFunctionAccount GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
