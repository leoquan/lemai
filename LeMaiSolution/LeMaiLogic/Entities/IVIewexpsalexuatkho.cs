using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewexpsalexuatkho
	{
		/// <summary>
		/// Lấy một DataTable view_ExpSaleXuatKho từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_ExpSaleXuatKho từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_ExpSaleXuatKho từ Database
		/// </summary>
		List<view_ExpSaleXuatKho> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_ExpSaleXuatKho từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_ExpSaleXuatKho> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_ExpSaleXuatKho> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_ExpSaleXuatKho đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_ExpSaleXuatKho GetObjectCon(string schema, string condition, params Object[] parameters);
		view_ExpSaleXuatKho GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
