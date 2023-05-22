using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewexpdvhctinh
	{
		/// <summary>
		/// Lấy một DataTable view_ExpDVHC_TINH từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_ExpDVHC_TINH từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_ExpDVHC_TINH từ Database
		/// </summary>
		List<view_ExpDVHC_TINH> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_ExpDVHC_TINH từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_ExpDVHC_TINH> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_ExpDVHC_TINH> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_ExpDVHC_TINH đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_ExpDVHC_TINH GetObjectCon(string schema, string condition, params Object[] parameters);
		view_ExpDVHC_TINH GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
