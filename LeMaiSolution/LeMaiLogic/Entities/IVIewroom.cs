using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewroom
	{
		/// <summary>
		/// Lấy một DataTable view_Room từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_Room từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_Room từ Database
		/// </summary>
		List<view_Room> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_Room từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_Room> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_Room> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_Room đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_Room GetObjectCon(string schema, string condition, params Object[] parameters);
		view_Room GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
