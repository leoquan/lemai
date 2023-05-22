using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewaccountobject
	{
		/// <summary>
		/// Lấy một DataTable view_AccountObject từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_AccountObject từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_AccountObject từ Database
		/// </summary>
		List<view_AccountObject> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_AccountObject từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_AccountObject> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_AccountObject> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_AccountObject đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_AccountObject GetObjectCon(string schema, string condition, params Object[] parameters);
		view_AccountObject GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
