using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewsumgexpbillkynhan
	{
		/// <summary>
		/// Lấy một DataTable view_SumGExpBillKyNhan từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_SumGExpBillKyNhan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_SumGExpBillKyNhan từ Database
		/// </summary>
		List<view_SumGExpBillKyNhan> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_SumGExpBillKyNhan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_SumGExpBillKyNhan> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_SumGExpBillKyNhan> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_SumGExpBillKyNhan đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_SumGExpBillKyNhan GetObjectCon(string schema, string condition, params Object[] parameters);
		view_SumGExpBillKyNhan GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
