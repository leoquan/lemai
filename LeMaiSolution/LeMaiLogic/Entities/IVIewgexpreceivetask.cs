using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewgexpreceivetask
	{
		/// <summary>
		/// Lấy một DataTable view_GExpReceiveTask từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_GExpReceiveTask từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_GExpReceiveTask từ Database
		/// </summary>
		List<view_GExpReceiveTask> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_GExpReceiveTask từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_GExpReceiveTask> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_GExpReceiveTask> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_GExpReceiveTask đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_GExpReceiveTask GetObjectCon(string schema, string condition, params Object[] parameters);
		view_GExpReceiveTask GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
