using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewvcmathang
	{
		/// <summary>
		/// Lấy một DataTable view_VCMatHang từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_VCMatHang từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_VCMatHang từ Database
		/// </summary>
		List<view_VCMatHang> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_VCMatHang từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_VCMatHang> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_VCMatHang> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_VCMatHang đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_VCMatHang GetObjectCon(string schema, string condition, params Object[] parameters);
		view_VCMatHang GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
