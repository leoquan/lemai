using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewwebnews
	{
		/// <summary>
		/// Lấy một DataTable view_WebNews từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_WebNews từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_WebNews từ Database
		/// </summary>
		List<view_WebNews> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_WebNews từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_WebNews> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_WebNews> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_WebNews đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_WebNews GetObjectCon(string schema, string condition, params Object[] parameters);
		view_WebNews GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
