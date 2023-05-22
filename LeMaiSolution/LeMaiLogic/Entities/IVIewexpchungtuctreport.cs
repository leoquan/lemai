using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewexpchungtuctreport
	{
		/// <summary>
		/// Lấy một DataTable view_ExpChungTuCtReport từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_ExpChungTuCtReport từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_ExpChungTuCtReport từ Database
		/// </summary>
		List<view_ExpChungTuCtReport> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_ExpChungTuCtReport từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_ExpChungTuCtReport> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_ExpChungTuCtReport> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_ExpChungTuCtReport đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_ExpChungTuCtReport GetObjectCon(string schema, string condition, params Object[] parameters);
		view_ExpChungTuCtReport GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
