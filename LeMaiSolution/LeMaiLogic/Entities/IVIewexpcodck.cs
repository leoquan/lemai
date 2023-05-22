using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewexpcodck
	{
		/// <summary>
		/// Lấy một DataTable view_ExpCODCK từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_ExpCODCK từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_ExpCODCK từ Database
		/// </summary>
		List<view_ExpCODCK> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_ExpCODCK từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_ExpCODCK> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_ExpCODCK> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_ExpCODCK đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_ExpCODCK GetObjectCon(string schema, string condition, params Object[] parameters);
		view_ExpCODCK GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
