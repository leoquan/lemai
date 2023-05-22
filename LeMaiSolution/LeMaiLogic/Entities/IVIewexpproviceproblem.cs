using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewexpproviceproblem
	{
		/// <summary>
		/// Lấy một DataTable view_ExpProviceProblem từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_ExpProviceProblem từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_ExpProviceProblem từ Database
		/// </summary>
		List<view_ExpProviceProblem> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_ExpProviceProblem từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_ExpProviceProblem> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_ExpProviceProblem> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_ExpProviceProblem đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_ExpProviceProblem GetObjectCon(string schema, string condition, params Object[] parameters);
		view_ExpProviceProblem GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
