using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewexpconsignmentcashpay
	{
		/// <summary>
		/// Lấy một DataTable view_ExpConsignmentCashPay từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_ExpConsignmentCashPay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_ExpConsignmentCashPay từ Database
		/// </summary>
		List<view_ExpConsignmentCashPay> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_ExpConsignmentCashPay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_ExpConsignmentCashPay> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_ExpConsignmentCashPay> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_ExpConsignmentCashPay đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_ExpConsignmentCashPay GetObjectCon(string schema, string condition, params Object[] parameters);
		view_ExpConsignmentCashPay GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
