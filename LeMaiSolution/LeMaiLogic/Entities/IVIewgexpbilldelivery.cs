using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewgexpbilldelivery
	{
		/// <summary>
		/// Lấy một DataTable view_GExpBillDelivery từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_GExpBillDelivery từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_GExpBillDelivery từ Database
		/// </summary>
		List<view_GExpBillDelivery> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_GExpBillDelivery từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_GExpBillDelivery> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_GExpBillDelivery> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_GExpBillDelivery đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_GExpBillDelivery GetObjectCon(string schema, string condition, params Object[] parameters);
		view_GExpBillDelivery GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
