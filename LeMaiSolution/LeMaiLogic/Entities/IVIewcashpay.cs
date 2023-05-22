using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewcashpay
	{
		/// <summary>
		/// Lấy một DataTable view_CashPay từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_CashPay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_CashPay từ Database
		/// </summary>
		List<view_CashPay> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_CashPay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_CashPay> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_CashPay> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_CashPay đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_CashPay GetObjectCon(string schema, string condition, params Object[] parameters);
		view_CashPay GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
