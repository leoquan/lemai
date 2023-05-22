using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewinvoicelist
	{
		/// <summary>
		/// Lấy một DataTable view_InvoiceList từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_InvoiceList từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_InvoiceList từ Database
		/// </summary>
		List<view_InvoiceList> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_InvoiceList từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_InvoiceList> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_InvoiceList> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_InvoiceList đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_InvoiceList GetObjectCon(string schema, string condition, params Object[] parameters);
		view_InvoiceList GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
