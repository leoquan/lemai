using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewsumgexpbill
	{
		/// <summary>
		/// Lấy một DataTable view_SumGExpBill từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_SumGExpBill từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_SumGExpBill từ Database
		/// </summary>
		List<view_SumGExpBill> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_SumGExpBill từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_SumGExpBill> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_SumGExpBill> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_SumGExpBill đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_SumGExpBill GetObjectCon(string schema, string condition, params Object[] parameters);
		view_SumGExpBill GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
