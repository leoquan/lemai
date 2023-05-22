using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewbooking
	{
		/// <summary>
		/// Lấy một DataTable view_Booking từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_Booking từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_Booking từ Database
		/// </summary>
		List<view_Booking> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_Booking từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_Booking> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_Booking> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_Booking đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_Booking GetObjectCon(string schema, string condition, params Object[] parameters);
		view_Booking GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
