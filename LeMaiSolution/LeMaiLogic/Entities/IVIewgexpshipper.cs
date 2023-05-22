using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewgexpshipper
	{
		/// <summary>
		/// Lấy một DataTable view_GexpShipper từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_GexpShipper từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_GexpShipper từ Database
		/// </summary>
		List<view_GexpShipper> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_GexpShipper từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_GexpShipper> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_GexpShipper> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_GexpShipper đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_GexpShipper GetObjectCon(string schema, string condition, params Object[] parameters);
		view_GexpShipper GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
