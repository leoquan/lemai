using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewexpcustomer
	{
		/// <summary>
		/// Lấy một DataTable view_ExpCustomer từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_ExpCustomer từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_ExpCustomer từ Database
		/// </summary>
		List<view_ExpCustomer> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_ExpCustomer từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_ExpCustomer> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_ExpCustomer> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_ExpCustomer đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_ExpCustomer GetObjectCon(string schema, string condition, params Object[] parameters);
		view_ExpCustomer GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
