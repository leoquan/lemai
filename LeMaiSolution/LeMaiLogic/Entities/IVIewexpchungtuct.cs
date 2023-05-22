using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewexpchungtuct
	{
		/// <summary>
		/// Lấy một DataTable view_ExpChungTuCt từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_ExpChungTuCt từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_ExpChungTuCt từ Database
		/// </summary>
		List<view_ExpChungTuCt> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_ExpChungTuCt từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_ExpChungTuCt> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_ExpChungTuCt> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_ExpChungTuCt đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_ExpChungTuCt GetObjectCon(string schema, string condition, params Object[] parameters);
		view_ExpChungTuCt GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
