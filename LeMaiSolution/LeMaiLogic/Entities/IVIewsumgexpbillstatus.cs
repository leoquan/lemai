using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewsumgexpbillstatus
	{
		/// <summary>
		/// Lấy một DataTable view_SumGExpBillStatus từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_SumGExpBillStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_SumGExpBillStatus từ Database
		/// </summary>
		List<view_SumGExpBillStatus> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_SumGExpBillStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_SumGExpBillStatus> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_SumGExpBillStatus> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_SumGExpBillStatus đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_SumGExpBillStatus GetObjectCon(string schema, string condition, params Object[] parameters);
		view_SumGExpBillStatus GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
