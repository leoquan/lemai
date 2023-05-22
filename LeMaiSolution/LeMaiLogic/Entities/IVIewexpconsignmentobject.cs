using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewexpconsignmentobject
	{
		/// <summary>
		/// Lấy một DataTable view_ExpConsignmentObject từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_ExpConsignmentObject từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_ExpConsignmentObject từ Database
		/// </summary>
		List<view_ExpConsignmentObject> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_ExpConsignmentObject từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_ExpConsignmentObject> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_ExpConsignmentObject> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_ExpConsignmentObject đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_ExpConsignmentObject GetObjectCon(string schema, string condition, params Object[] parameters);
		view_ExpConsignmentObject GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
