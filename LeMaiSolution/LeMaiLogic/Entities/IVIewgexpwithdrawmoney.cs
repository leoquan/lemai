using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewgexpwithdrawmoney
	{
		/// <summary>
		/// Lấy một DataTable view_GExpWithdrawMoney từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_GExpWithdrawMoney từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_GExpWithdrawMoney từ Database
		/// </summary>
		List<view_GExpWithdrawMoney> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_GExpWithdrawMoney từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_GExpWithdrawMoney> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_GExpWithdrawMoney> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_GExpWithdrawMoney đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_GExpWithdrawMoney GetObjectCon(string schema, string condition, params Object[] parameters);
		view_GExpWithdrawMoney GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
