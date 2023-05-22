using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewexpnhapkho
	{
		/// <summary>
		/// Lấy một DataTable view_ExpNhapKho từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_ExpNhapKho từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_ExpNhapKho từ Database
		/// </summary>
		List<view_ExpNhapKho> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_ExpNhapKho từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_ExpNhapKho> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_ExpNhapKho> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_ExpNhapKho đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_ExpNhapKho GetObjectCon(string schema, string condition, params Object[] parameters);
		view_ExpNhapKho GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
