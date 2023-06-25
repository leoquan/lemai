using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewgexpdebitcomparison
	{
		/// <summary>
		/// Lấy một DataTable view_GExpDebitComparison từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_GExpDebitComparison từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_GExpDebitComparison từ Database
		/// </summary>
		List<view_GExpDebitComparison> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_GExpDebitComparison từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_GExpDebitComparison> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_GExpDebitComparison> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_GExpDebitComparison đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_GExpDebitComparison GetObjectCon(string schema, string condition, params Object[] parameters);
		view_GExpDebitComparison GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
