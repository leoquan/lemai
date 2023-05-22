using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewinvoiceprint
	{
		/// <summary>
		/// Lấy một DataTable view_invoicePrint từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_invoicePrint từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_invoicePrint từ Database
		/// </summary>
		List<view_invoicePrint> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_invoicePrint từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_invoicePrint> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_invoicePrint> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_invoicePrint đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_invoicePrint GetObjectCon(string schema, string condition, params Object[] parameters);
		view_invoicePrint GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
