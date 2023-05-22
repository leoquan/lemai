using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewgexpscansign
	{
		/// <summary>
		/// Lấy một DataTable view_GExpScanSign từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_GExpScanSign từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_GExpScanSign từ Database
		/// </summary>
		List<view_GExpScanSign> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_GExpScanSign từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_GExpScanSign> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_GExpScanSign> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_GExpScanSign đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_GExpScanSign GetObjectCon(string schema, string condition, params Object[] parameters);
		view_GExpScanSign GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
