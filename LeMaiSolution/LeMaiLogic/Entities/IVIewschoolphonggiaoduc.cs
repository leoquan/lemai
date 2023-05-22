using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewschoolphonggiaoduc
	{
		/// <summary>
		/// Lấy một DataTable view_SchoolPhongGiaoDuc từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_SchoolPhongGiaoDuc từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_SchoolPhongGiaoDuc từ Database
		/// </summary>
		List<view_SchoolPhongGiaoDuc> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_SchoolPhongGiaoDuc từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_SchoolPhongGiaoDuc> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_SchoolPhongGiaoDuc> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_SchoolPhongGiaoDuc đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_SchoolPhongGiaoDuc GetObjectCon(string schema, string condition, params Object[] parameters);
		view_SchoolPhongGiaoDuc GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
