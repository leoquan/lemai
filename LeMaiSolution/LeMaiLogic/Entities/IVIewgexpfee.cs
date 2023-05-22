using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewgexpfee
	{
		/// <summary>
		/// Lấy một DataTable view_GExpFee từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_GExpFee từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_GExpFee từ Database
		/// </summary>
		List<view_GExpFee> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_GExpFee từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_GExpFee> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_GExpFee> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_GExpFee đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_GExpFee GetObjectCon(string schema, string condition, params Object[] parameters);
		view_GExpFee GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
