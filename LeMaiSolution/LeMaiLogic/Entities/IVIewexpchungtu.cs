using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewexpchungtu
	{
		/// <summary>
		/// Lấy một DataTable view_ExpChungTu từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_ExpChungTu từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_ExpChungTu từ Database
		/// </summary>
		List<view_ExpChungTu> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_ExpChungTu từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_ExpChungTu> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_ExpChungTu> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_ExpChungTu đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_ExpChungTu GetObjectCon(string schema, string condition, params Object[] parameters);
		view_ExpChungTu GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
