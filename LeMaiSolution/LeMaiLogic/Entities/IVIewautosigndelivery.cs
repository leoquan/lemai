using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewautosigndelivery
	{
		/// <summary>
		/// Lấy một DataTable view_AutoSignDelivery từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_AutoSignDelivery từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_AutoSignDelivery từ Database
		/// </summary>
		List<view_AutoSignDelivery> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_AutoSignDelivery từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_AutoSignDelivery> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_AutoSignDelivery> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_AutoSignDelivery đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_AutoSignDelivery GetObjectCon(string schema, string condition, params Object[] parameters);
		view_AutoSignDelivery GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
