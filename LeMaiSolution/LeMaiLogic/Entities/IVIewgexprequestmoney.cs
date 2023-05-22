using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewgexprequestmoney
	{
		/// <summary>
		/// Lấy một DataTable view_GExpRequestMoney từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_GExpRequestMoney từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_GExpRequestMoney từ Database
		/// </summary>
		List<view_GExpRequestMoney> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_GExpRequestMoney từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_GExpRequestMoney> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_GExpRequestMoney> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_GExpRequestMoney đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_GExpRequestMoney GetObjectCon(string schema, string condition, params Object[] parameters);
		view_GExpRequestMoney GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
