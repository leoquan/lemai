using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewexppost
	{
		/// <summary>
		/// Lấy một DataTable view_ExpPost từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_ExpPost từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_ExpPost từ Database
		/// </summary>
		List<view_ExpPost> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_ExpPost từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_ExpPost> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_ExpPost> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_ExpPost đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_ExpPost GetObjectCon(string schema, string condition, params Object[] parameters);
		view_ExpPost GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
