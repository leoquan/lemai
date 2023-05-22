using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewvckettoan
	{
		/// <summary>
		/// Lấy một DataTable view_VCKetToan từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_VCKetToan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_VCKetToan từ Database
		/// </summary>
		List<view_VCKetToan> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_VCKetToan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_VCKetToan> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_VCKetToan> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_VCKetToan đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_VCKetToan GetObjectCon(string schema, string condition, params Object[] parameters);
		view_VCKetToan GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
