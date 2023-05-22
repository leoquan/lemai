using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewgexpprovider
	{
		/// <summary>
		/// Lấy một DataTable view_GExpProvider từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_GExpProvider từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_GExpProvider từ Database
		/// </summary>
		List<view_GExpProvider> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_GExpProvider từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_GExpProvider> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_GExpProvider> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_GExpProvider đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_GExpProvider GetObjectCon(string schema, string condition, params Object[] parameters);
		view_GExpProvider GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
