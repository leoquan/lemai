using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewgexpautosign
	{
		/// <summary>
		/// Lấy một DataTable view_GExpAutoSign từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_GExpAutoSign từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_GExpAutoSign từ Database
		/// </summary>
		List<view_GExpAutoSign> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_GExpAutoSign từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_GExpAutoSign> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_GExpAutoSign> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_GExpAutoSign đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_GExpAutoSign GetObjectCon(string schema, string condition, params Object[] parameters);
		view_GExpAutoSign GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
