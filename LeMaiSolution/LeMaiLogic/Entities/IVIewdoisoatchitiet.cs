using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewdoisoatchitiet
	{
		/// <summary>
		/// Lấy một DataTable view_DoiSoatChiTiet từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_DoiSoatChiTiet từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_DoiSoatChiTiet từ Database
		/// </summary>
		List<view_DoiSoatChiTiet> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_DoiSoatChiTiet từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_DoiSoatChiTiet> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_DoiSoatChiTiet> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_DoiSoatChiTiet đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_DoiSoatChiTiet GetObjectCon(string schema, string condition, params Object[] parameters);
		view_DoiSoatChiTiet GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
