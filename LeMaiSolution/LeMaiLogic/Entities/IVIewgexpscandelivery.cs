using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewgexpscandelivery
	{
		/// <summary>
		/// Lấy một DataTable view_GExpScanDelivery từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_GExpScanDelivery từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_GExpScanDelivery từ Database
		/// </summary>
		List<view_GExpScanDelivery> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_GExpScanDelivery từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_GExpScanDelivery> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_GExpScanDelivery> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_GExpScanDelivery đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_GExpScanDelivery GetObjectCon(string schema, string condition, params Object[] parameters);
		view_GExpScanDelivery GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
