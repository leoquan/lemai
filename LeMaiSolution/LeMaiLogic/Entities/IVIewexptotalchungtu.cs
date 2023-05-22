using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewexptotalchungtu
	{
		/// <summary>
		/// Lấy một DataTable view_ExpTotalChungTu từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_ExpTotalChungTu từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_ExpTotalChungTu từ Database
		/// </summary>
		List<view_ExpTotalChungTu> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_ExpTotalChungTu từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_ExpTotalChungTu> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_ExpTotalChungTu> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_ExpTotalChungTu đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_ExpTotalChungTu GetObjectCon(string schema, string condition, params Object[] parameters);
		view_ExpTotalChungTu GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
