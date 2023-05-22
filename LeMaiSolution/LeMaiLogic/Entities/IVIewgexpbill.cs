using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewgexpbill
	{
		/// <summary>
		/// Lấy một DataTable view_GExpBill từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_GExpBill từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_GExpBill từ Database
		/// </summary>
		List<view_GExpBill> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_GExpBill từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_GExpBill> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_GExpBill> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_GExpBill đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_GExpBill GetObjectCon(string schema, string condition, params Object[] parameters);
		view_GExpBill GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
