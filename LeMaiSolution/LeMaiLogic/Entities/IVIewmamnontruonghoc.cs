using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewmamnontruonghoc
	{
		/// <summary>
		/// Lấy một DataTable view_MamNonTruongHoc từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_MamNonTruongHoc từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_MamNonTruongHoc từ Database
		/// </summary>
		List<view_MamNonTruongHoc> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_MamNonTruongHoc từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_MamNonTruongHoc> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_MamNonTruongHoc> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_MamNonTruongHoc đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_MamNonTruongHoc GetObjectCon(string schema, string condition, params Object[] parameters);
		view_MamNonTruongHoc GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
