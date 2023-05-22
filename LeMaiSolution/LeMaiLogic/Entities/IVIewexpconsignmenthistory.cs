using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewexpconsignmenthistory
	{
		/// <summary>
		/// Lấy một DataTable view_ExpConsignmentHistory từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_ExpConsignmentHistory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_ExpConsignmentHistory từ Database
		/// </summary>
		List<view_ExpConsignmentHistory> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_ExpConsignmentHistory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_ExpConsignmentHistory> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_ExpConsignmentHistory> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_ExpConsignmentHistory đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_ExpConsignmentHistory GetObjectCon(string schema, string condition, params Object[] parameters);
		view_ExpConsignmentHistory GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
