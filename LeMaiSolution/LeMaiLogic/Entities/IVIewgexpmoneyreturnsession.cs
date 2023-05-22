using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewgexpmoneyreturnsession
	{
		/// <summary>
		/// Lấy một DataTable view_GExpMoneyReturnSession từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_GExpMoneyReturnSession từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_GExpMoneyReturnSession từ Database
		/// </summary>
		List<view_GExpMoneyReturnSession> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_GExpMoneyReturnSession từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_GExpMoneyReturnSession> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_GExpMoneyReturnSession> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_GExpMoneyReturnSession đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_GExpMoneyReturnSession GetObjectCon(string schema, string condition, params Object[] parameters);
		view_GExpMoneyReturnSession GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
