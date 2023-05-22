using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewschoolgiaotrinh
	{
		/// <summary>
		/// Lấy một DataTable view_SchoolGiaoTrinh từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_SchoolGiaoTrinh từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_SchoolGiaoTrinh từ Database
		/// </summary>
		List<view_SchoolGiaoTrinh> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_SchoolGiaoTrinh từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_SchoolGiaoTrinh> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_SchoolGiaoTrinh> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_SchoolGiaoTrinh đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_SchoolGiaoTrinh GetObjectCon(string schema, string condition, params Object[] parameters);
		view_SchoolGiaoTrinh GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
