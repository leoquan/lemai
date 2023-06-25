using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewgexpdebitcomparisondetail
	{
		/// <summary>
		/// Lấy một DataTable view_GExpDebitComparisonDetail từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_GExpDebitComparisonDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_GExpDebitComparisonDetail từ Database
		/// </summary>
		List<view_GExpDebitComparisonDetail> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_GExpDebitComparisonDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_GExpDebitComparisonDetail> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_GExpDebitComparisonDetail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_GExpDebitComparisonDetail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_GExpDebitComparisonDetail GetObjectCon(string schema, string condition, params Object[] parameters);
		view_GExpDebitComparisonDetail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
