using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewvckhachhang
	{
		/// <summary>
		/// Lấy một DataTable view_VCKhachHang từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_VCKhachHang từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_VCKhachHang từ Database
		/// </summary>
		List<view_VCKhachHang> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_VCKhachHang từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_VCKhachHang> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_VCKhachHang> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_VCKhachHang đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_VCKhachHang GetObjectCon(string schema, string condition, params Object[] parameters);
		view_VCKhachHang GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
