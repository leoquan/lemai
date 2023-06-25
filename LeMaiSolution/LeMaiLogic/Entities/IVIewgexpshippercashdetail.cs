using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewgexpshippercashdetail
	{
		/// <summary>
		/// Lấy một DataTable view_GExpShipperCashDetail từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_GExpShipperCashDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_GExpShipperCashDetail từ Database
		/// </summary>
		List<view_GExpShipperCashDetail> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_GExpShipperCashDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_GExpShipperCashDetail> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_GExpShipperCashDetail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_GExpShipperCashDetail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_GExpShipperCashDetail GetObjectCon(string schema, string condition, params Object[] parameters);
		view_GExpShipperCashDetail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
