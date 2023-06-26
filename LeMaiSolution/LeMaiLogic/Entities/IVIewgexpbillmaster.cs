using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewgexpbillmaster
	{
		/// <summary>
		/// Lấy một DataTable view_GExpBillMaster từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_GExpBillMaster từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_GExpBillMaster từ Database
		/// </summary>
		List<view_GExpBillMaster> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_GExpBillMaster từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_GExpBillMaster> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_GExpBillMaster> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_GExpBillMaster đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_GExpBillMaster GetObjectCon(string schema, string condition, params Object[] parameters);
		view_GExpBillMaster GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
