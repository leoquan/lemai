using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewgexpfeedetails
	{
		/// <summary>
		/// Lấy một DataTable view_GExpFeeDetails từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_GExpFeeDetails từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_GExpFeeDetails từ Database
		/// </summary>
		List<view_GExpFeeDetails> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_GExpFeeDetails từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_GExpFeeDetails> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_GExpFeeDetails> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_GExpFeeDetails đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_GExpFeeDetails GetObjectCon(string schema, string condition, params Object[] parameters);
		view_GExpFeeDetails GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
