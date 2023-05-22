using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewservicegroup
	{
		/// <summary>
		/// Lấy một DataTable view_ServiceGroup từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_ServiceGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_ServiceGroup từ Database
		/// </summary>
		List<view_ServiceGroup> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_ServiceGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_ServiceGroup> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_ServiceGroup> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_ServiceGroup đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_ServiceGroup GetObjectCon(string schema, string condition, params Object[] parameters);
		view_ServiceGroup GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
