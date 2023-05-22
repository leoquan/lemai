using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewschoolprogram
	{
		/// <summary>
		/// Lấy một DataTable view_SchoolProgram từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_SchoolProgram từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_SchoolProgram từ Database
		/// </summary>
		List<view_SchoolProgram> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_SchoolProgram từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_SchoolProgram> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_SchoolProgram> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_SchoolProgram đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_SchoolProgram GetObjectCon(string schema, string condition, params Object[] parameters);
		view_SchoolProgram GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
