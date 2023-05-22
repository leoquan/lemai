using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewexpsalenhapvattu
	{
		/// <summary>
		/// Lấy một DataTable view_ExpSaleNhapVatTu từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_ExpSaleNhapVatTu từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_ExpSaleNhapVatTu từ Database
		/// </summary>
		List<view_ExpSaleNhapVatTu> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_ExpSaleNhapVatTu từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_ExpSaleNhapVatTu> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_ExpSaleNhapVatTu> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_ExpSaleNhapVatTu đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_ExpSaleNhapVatTu GetObjectCon(string schema, string condition, params Object[] parameters);
		view_ExpSaleNhapVatTu GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
