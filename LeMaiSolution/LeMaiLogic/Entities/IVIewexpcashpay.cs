using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewexpcashpay
	{
		/// <summary>
		/// Lấy một DataTable view_ExpCashPay từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_ExpCashPay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_ExpCashPay từ Database
		/// </summary>
		List<view_ExpCashPay> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_ExpCashPay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_ExpCashPay> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_ExpCashPay> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_ExpCashPay đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_ExpCashPay GetObjectCon(string schema, string condition, params Object[] parameters);
		view_ExpCashPay GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
