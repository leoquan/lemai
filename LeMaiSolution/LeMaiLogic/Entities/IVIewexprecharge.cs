using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewexprecharge
	{
		/// <summary>
		/// Lấy một DataTable view_ExpRecharge từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_ExpRecharge từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_ExpRecharge từ Database
		/// </summary>
		List<view_ExpRecharge> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_ExpRecharge từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_ExpRecharge> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_ExpRecharge> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_ExpRecharge đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_ExpRecharge GetObjectCon(string schema, string condition, params Object[] parameters);
		view_ExpRecharge GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
