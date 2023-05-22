using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewrole
	{
		/// <summary>
		/// Lấy một DataTable view_Role từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_Role từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_Role từ Database
		/// </summary>
		List<view_Role> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_Role từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_Role> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_Role> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_Role đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_Role GetObjectCon(string schema, string condition, params Object[] parameters);
		view_Role GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
