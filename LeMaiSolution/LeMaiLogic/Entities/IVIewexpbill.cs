using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewexpbill
	{
		/// <summary>
		/// Lấy một DataTable view_ExpBILL từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_ExpBILL từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_ExpBILL từ Database
		/// </summary>
		List<view_ExpBILL> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_ExpBILL từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_ExpBILL> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_ExpBILL> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_ExpBILL đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_ExpBILL GetObjectCon(string schema, string condition, params Object[] parameters);
		view_ExpBILL GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
