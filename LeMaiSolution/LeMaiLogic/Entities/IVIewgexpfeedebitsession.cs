using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewgexpfeedebitsession
	{
		/// <summary>
		/// Lấy một DataTable view_GExpFeeDebitSession từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_GExpFeeDebitSession từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_GExpFeeDebitSession từ Database
		/// </summary>
		List<view_GExpFeeDebitSession> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_GExpFeeDebitSession từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_GExpFeeDebitSession> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_GExpFeeDebitSession> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_GExpFeeDebitSession đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_GExpFeeDebitSession GetObjectCon(string schema, string condition, params Object[] parameters);
		view_GExpFeeDebitSession GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
