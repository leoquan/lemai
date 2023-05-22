using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewservice
	{
		/// <summary>
		/// Lấy một DataTable view_Service từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_Service từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_Service từ Database
		/// </summary>
		List<view_Service> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_Service từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_Service> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_Service> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_Service đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_Service GetObjectCon(string schema, string condition, params Object[] parameters);
		view_Service GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
