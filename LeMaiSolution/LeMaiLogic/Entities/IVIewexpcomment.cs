using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewexpcomment
	{
		/// <summary>
		/// Lấy một DataTable view_ExpComment từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_ExpComment từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_ExpComment từ Database
		/// </summary>
		List<view_ExpComment> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_ExpComment từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_ExpComment> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_ExpComment> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_ExpComment đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_ExpComment GetObjectCon(string schema, string condition, params Object[] parameters);
		view_ExpComment GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
