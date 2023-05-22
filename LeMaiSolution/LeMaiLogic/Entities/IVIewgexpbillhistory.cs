using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewgexpbillhistory
	{
		/// <summary>
		/// Lấy một DataTable view_GExpBillHistory từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_GExpBillHistory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_GExpBillHistory từ Database
		/// </summary>
		List<view_GExpBillHistory> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_GExpBillHistory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_GExpBillHistory> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_GExpBillHistory> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_GExpBillHistory đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_GExpBillHistory GetObjectCon(string schema, string condition, params Object[] parameters);
		view_GExpBillHistory GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
