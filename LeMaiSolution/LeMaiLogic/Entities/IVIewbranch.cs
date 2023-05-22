using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewbranch
	{
		/// <summary>
		/// Lấy một DataTable view_Branch từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_Branch từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_Branch từ Database
		/// </summary>
		List<view_Branch> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_Branch từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_Branch> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_Branch> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_Branch đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_Branch GetObjectCon(string schema, string condition, params Object[] parameters);
		view_Branch GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
