using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewgexpshippercash
	{
		/// <summary>
		/// Lấy một DataTable view_GExpShipperCash từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_GExpShipperCash từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_GExpShipperCash từ Database
		/// </summary>
		List<view_GExpShipperCash> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_GExpShipperCash từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_GExpShipperCash> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_GExpShipperCash> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_GExpShipperCash đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_GExpShipperCash GetObjectCon(string schema, string condition, params Object[] parameters);
		view_GExpShipperCash GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
