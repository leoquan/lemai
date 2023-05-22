using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewschoolsogiaoduc
	{
		/// <summary>
		/// Lấy một DataTable view_SchoolSoGiaoDuc từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_SchoolSoGiaoDuc từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_SchoolSoGiaoDuc từ Database
		/// </summary>
		List<view_SchoolSoGiaoDuc> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_SchoolSoGiaoDuc từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_SchoolSoGiaoDuc> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_SchoolSoGiaoDuc> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_SchoolSoGiaoDuc đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_SchoolSoGiaoDuc GetObjectCon(string schema, string condition, params Object[] parameters);
		view_SchoolSoGiaoDuc GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
