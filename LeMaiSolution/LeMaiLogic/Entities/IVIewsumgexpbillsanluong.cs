using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewsumgexpbillsanluong
	{
		/// <summary>
		/// Lấy một DataTable view_SumGExpBillSanLuong từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_SumGExpBillSanLuong từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_SumGExpBillSanLuong từ Database
		/// </summary>
		List<view_SumGExpBillSanLuong> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_SumGExpBillSanLuong từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_SumGExpBillSanLuong> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_SumGExpBillSanLuong> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_SumGExpBillSanLuong đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_SumGExpBillSanLuong GetObjectCon(string schema, string condition, params Object[] parameters);
		view_SumGExpBillSanLuong GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
