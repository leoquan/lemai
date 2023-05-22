using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewexpkykettoan
	{
		/// <summary>
		/// Lấy một DataTable view_ExpKyKetToan từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_ExpKyKetToan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_ExpKyKetToan từ Database
		/// </summary>
		List<view_ExpKyKetToan> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_ExpKyKetToan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_ExpKyKetToan> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_ExpKyKetToan> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_ExpKyKetToan đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_ExpKyKetToan GetObjectCon(string schema, string condition, params Object[] parameters);
		view_ExpKyKetToan GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
