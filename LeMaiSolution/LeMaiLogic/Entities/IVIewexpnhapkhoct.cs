using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewexpnhapkhoct
	{
		/// <summary>
		/// Lấy một DataTable view_ExpNhapKhoCt từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_ExpNhapKhoCt từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_ExpNhapKhoCt từ Database
		/// </summary>
		List<view_ExpNhapKhoCt> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_ExpNhapKhoCt từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_ExpNhapKhoCt> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_ExpNhapKhoCt> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_ExpNhapKhoCt đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_ExpNhapKhoCt GetObjectCon(string schema, string condition, params Object[] parameters);
		view_ExpNhapKhoCt GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
