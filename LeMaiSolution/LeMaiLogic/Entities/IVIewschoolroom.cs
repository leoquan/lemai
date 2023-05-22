using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewschoolroom
	{
		/// <summary>
		/// Lấy một DataTable view_SchoolRoom từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_SchoolRoom từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_SchoolRoom từ Database
		/// </summary>
		List<view_SchoolRoom> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_SchoolRoom từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_SchoolRoom> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_SchoolRoom> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_SchoolRoom đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_SchoolRoom GetObjectCon(string schema, string condition, params Object[] parameters);
		view_SchoolRoom GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
