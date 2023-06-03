using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewvihclecoupon
	{
		/// <summary>
		/// Lấy một DataTable view_VihcleCoupon từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_VihcleCoupon từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_VihcleCoupon từ Database
		/// </summary>
		List<view_VihcleCoupon> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_VihcleCoupon từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_VihcleCoupon> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_VihcleCoupon> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_VihcleCoupon đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_VihcleCoupon GetObjectCon(string schema, string condition, params Object[] parameters);
		view_VihcleCoupon GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
