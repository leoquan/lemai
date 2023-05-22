using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewgexpmoneyreturn
	{
		/// <summary>
		/// Lấy một DataTable view_GExpMoneyReturn từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_GExpMoneyReturn từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_GExpMoneyReturn từ Database
		/// </summary>
		List<view_GExpMoneyReturn> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_GExpMoneyReturn từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_GExpMoneyReturn> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_GExpMoneyReturn> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_GExpMoneyReturn đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_GExpMoneyReturn GetObjectCon(string schema, string condition, params Object[] parameters);
		view_GExpMoneyReturn GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
