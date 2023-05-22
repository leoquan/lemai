using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewgexpscanreturn
	{
		/// <summary>
		/// Lấy một DataTable view_GExpScanReturn từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_GExpScanReturn từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_GExpScanReturn từ Database
		/// </summary>
		List<view_GExpScanReturn> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_GExpScanReturn từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_GExpScanReturn> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_GExpScanReturn> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_GExpScanReturn đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_GExpScanReturn GetObjectCon(string schema, string condition, params Object[] parameters);
		view_GExpScanReturn GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
