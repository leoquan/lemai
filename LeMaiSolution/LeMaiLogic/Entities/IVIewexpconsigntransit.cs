using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewexpconsigntransit
	{
		/// <summary>
		/// Lấy một DataTable view_ExpConsignTransit từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_ExpConsignTransit từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_ExpConsignTransit từ Database
		/// </summary>
		List<view_ExpConsignTransit> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_ExpConsignTransit từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_ExpConsignTransit> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_ExpConsignTransit> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_ExpConsignTransit đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_ExpConsignTransit GetObjectCon(string schema, string condition, params Object[] parameters);
		view_ExpConsignTransit GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
