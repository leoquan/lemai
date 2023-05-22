using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewgexpnotification
	{
		/// <summary>
		/// Lấy một DataTable view_GExpNotification từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_GExpNotification từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_GExpNotification từ Database
		/// </summary>
		List<view_GExpNotification> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_GExpNotification từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_GExpNotification> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_GExpNotification> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_GExpNotification đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_GExpNotification GetObjectCon(string schema, string condition, params Object[] parameters);
		view_GExpNotification GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
