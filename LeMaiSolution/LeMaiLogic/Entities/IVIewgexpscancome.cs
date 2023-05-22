using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewgexpscancome
	{
		/// <summary>
		/// Lấy một DataTable view_GExpScanCome từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_GExpScanCome từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_GExpScanCome từ Database
		/// </summary>
		List<view_GExpScanCome> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_GExpScanCome từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_GExpScanCome> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_GExpScanCome> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_GExpScanCome đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_GExpScanCome GetObjectCon(string schema, string condition, params Object[] parameters);
		view_GExpScanCome GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
