using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewexpcustomergroup
	{
		/// <summary>
		/// Lấy một DataTable view_ExpCustomerGroup từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_ExpCustomerGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_ExpCustomerGroup từ Database
		/// </summary>
		List<view_ExpCustomerGroup> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_ExpCustomerGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_ExpCustomerGroup> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_ExpCustomerGroup> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_ExpCustomerGroup đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_ExpCustomerGroup GetObjectCon(string schema, string condition, params Object[] parameters);
		view_ExpCustomerGroup GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
