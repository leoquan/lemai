using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewgexpbillghnapi
	{
		/// <summary>
		/// Lấy một DataTable view_GExpBillGHNApi từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_GExpBillGHNApi từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_GExpBillGHNApi từ Database
		/// </summary>
		List<view_GExpBillGHNApi> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_GExpBillGHNApi từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_GExpBillGHNApi> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_GExpBillGHNApi> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_GExpBillGHNApi đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_GExpBillGHNApi GetObjectCon(string schema, string condition, params Object[] parameters);
		view_GExpBillGHNApi GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
