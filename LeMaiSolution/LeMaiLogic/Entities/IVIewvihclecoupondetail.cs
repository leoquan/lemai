using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewvihclecoupondetail
	{
		/// <summary>
		/// Lấy một DataTable view_VihcleCouponDetail từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_VihcleCouponDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_VihcleCouponDetail từ Database
		/// </summary>
		List<view_VihcleCouponDetail> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_VihcleCouponDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_VihcleCouponDetail> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_VihcleCouponDetail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_VihcleCouponDetail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_VihcleCouponDetail GetObjectCon(string schema, string condition, params Object[] parameters);
		view_VihcleCouponDetail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
