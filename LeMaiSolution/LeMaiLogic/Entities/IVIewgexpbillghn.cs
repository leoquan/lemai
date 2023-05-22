using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewgexpbillghn
	{
		/// <summary>
		/// Lấy một DataTable view_GExpBillGHN từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_GExpBillGHN từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_GExpBillGHN từ Database
		/// </summary>
		List<view_GExpBillGHN> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_GExpBillGHN từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_GExpBillGHN> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_GExpBillGHN> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_GExpBillGHN đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_GExpBillGHN GetObjectCon(string schema, string condition, params Object[] parameters);
		view_GExpBillGHN GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
